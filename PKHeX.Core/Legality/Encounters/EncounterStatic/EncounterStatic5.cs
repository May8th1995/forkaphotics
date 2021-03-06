using System.Linq;

namespace PKHeX.Core
{
    /// <summary>
    /// Generation 5 Static Encounter
    /// </summary>
    /// <inheritdoc cref="EncounterStatic"/>
    public record EncounterStatic5 : EncounterStatic
    {
        public sealed override int Generation => 5;
        public bool Roaming { get; init; }

        public EncounterStatic5(GameVersion game) : base(game) { }

        protected sealed override bool IsMatchPartial(PKM pkm)
        {
            if (Ability == 4 && pkm.AbilityNumber != 4 && pkm.Format <= 7) // BW/2 Jellicent collision with wild surf slot, resolved by duplicating the encounter with any abil
                return true;
            return base.IsMatchPartial(pkm);
        }

        protected sealed override bool IsMatchLocation(PKM pk)
        {
            if (!Roaming)
                return base.IsMatchLocation(pk);
            return Roaming_MetLocation_BW.Contains(pk.Met_Location);
        }

        protected override bool IsMatchEggLocation(PKM pkm)
        {
            if (pkm.IsEgg) // unhatched
            {
                if (!EggEncounter)
                    return false;
                if (EggLocation != pkm.Met_Location)
                    return pkm.Met_Location == Locations.LinkTrade5 && pkm.Egg_Location == EggLocation;
                return pkm.Egg_Location == 0;
            }

            if (EggLocation == pkm.Egg_Location)
                return true;

            // Only way to mismatch is to be a Link Traded egg.
            return EggEncounter && pkm.Egg_Location == Locations.LinkTrade5;
        }

        private static readonly int[] Roaming_MetLocation_BW =
        {
            25,26,27,28, // Route 12, 13, 14, 15 Night latter half
            15,16,31,    // Route 2, 3, 18 Morning
            17,18,29,    // Route 4, 5, 16 Daytime
            19,20,21,    // Route 6, 7, 8 Evening
            22,23,24,    // Route 9, 10, 11 Night former half
        };
    }
}
