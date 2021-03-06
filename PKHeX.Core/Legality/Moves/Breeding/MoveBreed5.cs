using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static PKHeX.Core.EggSource5;

namespace PKHeX.Core
{
    /// <summary>
    /// Inheritance logic for Generation 5.
    /// </summary>
    /// <remarks>Refer to <see cref="EggSource5"/> for inheritance ordering.</remarks>
    public static class MoveBreed5
    {
        private const int level = 1;

        public static EggSource5[] Validate(int species, GameVersion version, int[] moves, out bool valid)
        {
            var count = Array.IndexOf(moves, 0);
            if (count == 0)
            {
                valid = false; // empty moveset
                return Array.Empty<EggSource5>();
            }
            if (count == -1)
                count = moves.Length;

            var learn = GameData.GetLearnsets(version);
            var table = GameData.GetPersonal(version);
            var learnset = learn[species];
            var pi = table[species];
            var egg = Legal.EggMovesBW[species].Moves;

            var value = new BreedInfo<EggSource5>(count, learnset, moves, level);
            if (moves[count - 1] is (int)Move.VoltTackle)
            {
                if (--count == 0)
                {
                    valid = false; // must have base moves; sanity check
                    return Array.Empty<EggSource5>();
                }
                value.Actual[count] = VoltTackle;
            }

            bool inherit = Breeding.GetCanInheritMoves(species);
            MarkMovesForOrigin(value, egg, count, inherit, pi);

            valid = RecurseMovesForOrigin(value, count - 1);
            return value.Actual;
        }

        private static bool RecurseMovesForOrigin(BreedInfo<EggSource5> info, int start, EggSource5 type = Max - 1)
        {
            int i = start;
            do
            {
                var unpeel = type - 1;
                if (unpeel != 0 && RecurseMovesForOrigin(info, i, unpeel))
                    return true;

                var permit = info.Possible[i];
                if ((permit & (1 << (int)type)) == 0)
                    return false;

                info.Actual[i] = type;
            } while (--i >= 0);

            return VerifyBaseMoves(info);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool VerifyBaseMoves(BreedInfo<EggSource5> info)
        {
            var count = 0;
            foreach (var x in info.Actual)
            {
                if (x == Base)
                    count++;
                else
                    break;
            }

            var moves = info.Moves;
            if (count == -1)
                return moves[moves.Length - 1] != 0;

            var baseMoves = info.Learnset.GetBaseEggMoves(info.Level);
            if (baseMoves.Length < count)
                return false;
            if (moves[moves.Length - 1] == 0 && count != baseMoves.Length)
                return false;

            for (int i = count - 1, b = baseMoves.Length - 1; i >= 0; i--, b--)
            {
                var move = moves[i];
                var expect = baseMoves[b];
                if (expect != move)
                    return false;
            }

            // A low-index base egg move may be nudged out, but can only reappear if sufficient non-base moves are before it.
            if (baseMoves.Length == count)
                return true;

            for (int i = count; i < info.Actual.Length; i++)
            {
                var isBase = (info.Possible[i] & (1 << (int)Base)) != 0;
                if (!isBase)
                    continue;

                var baseIndex = baseMoves.IndexOf(moves[i]);
                var min = moves.Length - baseMoves.Length + baseIndex;
                if (i <= min + count)
                    return false;
            }

            return true;
        }

        private static void MarkMovesForOrigin(BreedInfo<EggSource5> value, ICollection<int> eggMoves, int count, bool inheritLevelUp, PersonalInfo info)
        {
            var possible = value.Possible;
            var learn = value.Learnset;
            var baseEgg = value.Learnset.GetBaseEggMoves(value.Level);
            var tm = info.TMHM;
            var tmlist = Legal.TMHM_BW.AsSpan(0, 95); // actually 96, but TM96 is unavailable (Snarl - Lock Capsule)

            var moves = value.Moves;
            for (int i = 0; i < count; i++)
            {
                var move = moves[i];

                if (baseEgg.IndexOf(move) != -1)
                    possible[i] |= 1 << (int)Base;

                if (inheritLevelUp && learn.GetLevelLearnMove(move) != -1)
                    possible[i] |= 1 << (int)ParentLevelUp;

                if (eggMoves.Contains(move))
                    possible[i] |= 1 << (int)FatherEgg;

                var tmIndex = tmlist.IndexOf(move);
                if (tmIndex != -1 && tm[tmIndex])
                    possible[i] |= 1 << (int)FatherTM;
            }
        }
    }
}
