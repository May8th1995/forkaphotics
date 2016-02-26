﻿namespace PKHeX
{
    public static partial class Legal
    {
        // PKHeX Valid Array Storage
        #region Items
        internal static readonly int[] Items_Held = { 
                000,001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,017,018,019,020,021,022,023,024,025,026,027,028,029,030,031,032,033,034,035,
                036,037,038,039,040,041,042,043,044,045,046,047,048,049,050,051,052,053,054,055,056,057,058,059,060,061,062,063,064,065,066,067,068,069,070,
                071,072,073,074,075,076,077,078,079,080,081,082,083,084,085,086,087,088,089,090,091,092,093,094,099,100,101,102,103,104,105,106,107,108,109,
                110,112,116,117,118,119,134,135,136,149,150,151,152,153,154,155,156,157,158,159,160,161,162,163,164,165,166,167,168,169,170,171,172,173,174,
                175,176,177,178,179,180,181,182,183,184,185,186,187,188,189,190,191,192,193,194,195,196,197,198,199,200,201,202,203,204,205,206,207,208,209,
                210,211,212,213,214,215,217,218,219,220,221,222,223,224,225,226,227,228,229,230,231,232,233,234,235,236,237,238,239,240,241,242,243,244,
                245,246,247,248,249,250,251,252,253,254,255,256,257,258,259,260,261,262,263,264,265,266,267,268,269,270,271,272,273,274,275,276,277,278,279,
                280,281,282,283,284,285,286,287,288,289,290,291,292,293,294,295,296,297,298,299,300,301,302,303,304,305,306,307,308,309,310,311,312,313,314,
                315,316,317,318,319,320,321,322,323,324,325,326,327,504,537,538,539,540,541,542,543,544,545,546,547,548,549,550,551,552,553,554,555,556,557,
                558,559,560,561,562,563,564,565,566,567,568,569,570,571,572,573,577,580,581,582,583,584,585,586,587,588,589,590,591,639,640,644,645,646,647,
                648,649,650,652,653,654,655,656,657,658,659,660,661,662,663,664,665,666,667,668,669,670,671,672,673,674,675,676,677,678,679,680,681,682,683,
                684,685,686,687,688,699,704,708,709,710,711,715,

                // Appended ORAS Items (Orbs & Mega Stones)
                534,535,
                752,753,754,755,756,757,758,759,760,761,762,763,764,767,768,769,770,
        };
        internal static readonly int[] Items_Ball = { 000, 001, 002, 003, 004, 005, 006, 007, 008, 009, 010, 011, 012, 013, 014, 015, 016, 492, 493, 494, 495, 496, 497, 498, 499, 576, };
        internal static readonly int[] Items_CommonBall = { 4, 3, 2, 1};
        internal static readonly int[] Items_UncommonBall = { 7, 576, 13, 492, 497, 14, 495, 493, 496, 494, 11, 498, 8, 6, 12, 15, 9, 5, 499, 10, 16 };
        #endregion
        internal static readonly int[] Gen4EncounterTypes = { 1, 2, 4, 5, 7, 9, 10, 12, 23, 24 };
        #region Games
        internal static readonly int[] Games_6xy = { 24, 25 };
        internal static readonly int[] Games_6oras = { 26, 27 };
        internal static readonly int[] Games_5 = { 20, 21, 22, 23 };
        internal static readonly int[] Games_4 = { 10, 11, };
        internal static readonly int[] Games_4e = { 12 };
        internal static readonly int[] Games_4r = { 7, 8 };
        internal static readonly int[] Games_3 = { 1, 2 };
        internal static readonly int[] Games_3e = { 3 };
        internal static readonly int[] Games_3r = { 4, 5 };
        internal static readonly int[] Games_3s = { 15 };
        #endregion
        #region Met Locations
        internal static readonly int[] Met_BW2c = { 0, 60002, 30003 };
        internal static readonly int[] Met_BW2_0 = { 1,2,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125,126,127,128,129,130,131,132,133,134,135,136,137,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153, };
        internal static readonly int[] Met_BW2_3 = { 30001,30002,30004,30005,30006,30007,30008,30010,30011,30012,30013,30014,30015, };
        internal static readonly int[] Met_BW2_4 = { 40001, 40002, 40003, 40004, 40005, 40006, 40007, 40008, 40009, 40010, 40011, 40012, 40013, 40014, 40015, 40016, 40017, 40018, 40019, 40020, 40021, 40022, 40023, 40024, 40025, 40026, 40027, 40028, 40029, 40030, 40031, 40032, 40033, 40034, 40035, 40036, 40037, 40038, 40039, 40040, 40041, 40042, 40043, 40044, 40045, 40046, 40047, 40048, 40049, 40050, 40051, 40052, 40053, 40054, 40055, 40056, 40057, 40058, 40059, 40060, 40061, 40062, 40063, 40064, 40065, 40066, 40067, 40068, 40069, 40070, 40071, 40072, 40073, 40074, 40075, 40076, 40077, 40078, 40079, 40080, 40081, 40082, 40083, 40084, 40085, 40086, 40087, 40088, 40089, 40090, 40091, 40092, 40093, 40094, 40095, 40096, 40097, 40098, 40099, 40100, 40101, 40102, 40103, 40104, 40105, 40106, 40107, 40108, 40109, };
        internal static readonly int[] Met_BW2_6 = { 60001,60003 };
        internal static readonly int[] Met_XYc = { 0, 60002, 30002, };
        internal static readonly int[] Met_XY_0 = { /* XY */ 2,6,8,10,12,14,16,17,18,20,22,24,26,28,30,32,34,36,38,40,42,44,46,48,50,52,54,56,58,60,62,64,66,68,70,72,74,76,78,82,84,86,88,90,92,94,96,98,100,102,104,106,108,110,112,114,116,118,120,122,124,126,128,130,132,134,136,138,140,142,144,146,148,150,152,154,156,158,160,162,164,166,168, /* ORAS */ 170,172,174,176,178,180,182,184,186,188,190,192,194,196,198,200,202,204,206,208,210,212,214,216,218,220,222,224,226,228,230,232,234,236,238,240,242,244,246,248,250,252,254,256,258,260,262,264,266,268,270,272,274,276,278,280,282,284,286,288,290,292,294,296,298,300,302,304,306,308,310,312,314,316,318,320,322,324,326,328,330,332,334,336,338,340,342,344,346,348,350,352,354,};      
        internal static readonly int[] Met_XY_3 = { 30001,30003,30004,30005,30006,30007,30008,30009,30010,30011, };
        internal static readonly int[] Met_XY_4 = { 40001, 40002, 40003, 40004, 40005, 40006, 40007, 40008, 40009, 40010, 40011, 40012, 40013, 40014, 40015, 40016, 40017, 40018, 40019, 40020, 40021, 40022, 40023, 40024, 40025, 40026, 40027, 40028, 40029, 40030, 40031, 40032, 40033, 40034, 40035, 40036, 40037, 40038, 40039, 40040, 40041, 40042, 40043, 40044, 40045, 40046, 40047, 40048, 40049, 40050, 40051, 40052, 40053, 40054, 40055, 40056, 40057, 40058, 40059, 40060, 40061, 40062, 40063, 40064, 40065, 40066, 40067, 40068, 40069, 40070, 40071, 40072, 40073, 40074, 40075, 40076, 40077, 40078, 40079, };
        internal static readonly int[] Met_XY_6 = { /* XY */ 60001,60003, /* ORAS */ 60004,};
        internal static readonly int[] Met_HGSS_0 = {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,159,160,161,162,163,164,165,166,167,168,169,170,171,172,173,174,175,176,177,178,179,180,181,182,183,184,185,186,187,188,189,190,191,192,193,194,195,196,197,198,199,200,201,202,203,204,205,206,207,208,209,210,211,212,213,214,215,216,217,218,219,220,221,222,223,224,225,226,227,228,229,230,231,232,233,234,};
        internal static readonly int[] Met_HGSS_2 = {2000,2001,2002,2003,2004,2005,2006,2008,2009,2010,2011,2012,2013,2014,};
        internal static readonly int[] Met_HGSS_3 = {3000,3001,3002,3003,3004,3005,3006,3007,3008,3009,3010,3011,3012,3013,3014,3015,3016,3017,3018,3019,3020,3021,3022,3023,3024,3025,3026,3027,3028,3029,3030,3031,3032,3033,3034,3035,3036,3037,3038,3039,3040,3041,3042,3043,3044,3045,3046,3047,3048,3049,3050,3051,3052,3053,3054,3055,3056,3057,3058,3059,3060,3061,3062,3063,3064,3065,3066,3067,3068,3069,3070,3071,3072,3073,3074,3075,3076};
        #endregion
        #region Inventory Pouch
        internal static readonly ushort[] Pouch_Items_XY = { 
                000,001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,016,055,056,
                057,058,059,060,061,062,063,064,065,066,067,068,069,070,071,072,073,074,075,
                076,077,078,079,080,081,082,083,084,085,086,087,088,089,090,091,092,093,094,
                099,100,101,102,103,104,105,106,107,108,109,110,112,116,117,118,119,135,136,
                213,214,215,217,218,219,220,221,222,223,224,225,226,227,228,229,230,231,232,
                233,234,235,236,237,238,239,240,241,242,243,244,245,246,247,248,249,250,251,
                252,253,254,255,256,257,258,259,260,261,262,263,264,265,266,267,268,269,270,
                271,272,273,274,275,276,277,278,279,280,281,282,283,284,285,286,287,288,289,
                290,291,292,293,294,295,296,297,298,299,300,301,302,303,304,305,306,307,308,
                309,310,311,312,313,314,315,316,317,318,319,320,321,322,323,324,325,326,327,
                492,493,494,495,496,497,498,499,500,537,538,539,540,541,542,543,544,545,546,
                547,548,549,550,551,552,553,554,555,556,557,558,559,560,561,562,563,564,571,
                572,573,576,577,580,581,582,583,584,585,586,587,588,589,590,639,640,644,646,
                647,648,649,650,652,653,654,655,656,657,658,659,660,661,662,663,664,665,666,
                667,668,669,670,671,672,673,674,675,676,677,678,679,680,681,682,683,684,685,
                699,704,710,711,715,
        };
        internal static readonly ushort[] Pouch_Items_ORAS = {
                000,001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,016,055,056,
                057,058,059,060,061,062,063,064,068,069,070,071,072,073,074,075,
                076,077,078,079,080,081,082,083,084,085,086,087,088,089,090,091,092,093,094,
                099,100,101,102,103,104,105,106,107,108,109,110,112,116,117,118,119,135,136,
                213,214,215,217,218,219,220,221,222,223,224,225,226,227,228,229,230,231,232,
                233,234,235,236,237,238,239,240,241,242,243,244,245,246,247,248,249,250,251,
                252,253,254,255,256,257,258,259,260,261,262,263,264,265,266,267,268,269,270,
                271,272,273,274,275,276,277,278,279,280,281,282,283,284,285,286,287,288,289,
                290,291,292,293,294,295,296,297,298,299,300,301,302,303,304,305,306,307,308,
                309,310,311,312,313,314,315,316,317,318,319,320,321,322,323,324,325,326,327,
                492,493,494,495,496,497,498,499,500,537,538,539,540,541,542,543,544,545,546,
                547,548,549,550,551,552,553,554,555,556,557,558,559,560,561,562,563,564,571,
                572,573,576,577,580,581,582,583,584,585,586,587,588,589,590,639,640,644,646,
                647,648,649,650,652,653,654,655,656,657,658,659,660,661,662,663,664,665,666,
                667,668,669,670,671,672,673,674,675,676,677,678,679,680,681,682,683,684,685,
                699,704,710,711,715,

                // ORAS
                534,535,
                752,753,754,755,756,757,758,759,760,761,762,763,764,767,768,769,770,
        };
        internal static readonly ushort[] Pouch_Key_XY = {
                000,216,431,442,445,446,447,450,465,466,471,628,
                629,631,632,638,641,642,643,689,695,696,697,698,
                700,701,702,703,705,706,707,712,713,714,
                
                // Illegal
                716,717, // For the cheaters who want useless items... 
        };
        internal static readonly ushort[] Pouch_Key_ORAS = {
                000,216,        445,446,447,    465,466,471,628,
                629,631,632,638,                        697,

                // Illegal
                716,717,745,746,747,748,749,750, // For the cheaters who want useless items...

                // ORAS
                457,474,503,

                718,719,
                720,721,722,723,724,725,726,727,728,729,
                730,731,732,733,734,735,736,    738,739,
                740,741,742,743,744,
                751,765,766,771,772,774,775,
        };
        internal static readonly ushort[] Pouch_TMHM_XY = {
            0,
            328,329,330,331,332,333,334,335,336,337,338,339,340,341,342,343,344,345,
            346,347,348,349,350,351,352,353,354,355,356,357,358,359,360,361,362,363,
            364,365,366,367,368,369,370,371,372,373,374,375,376,377,378,379,380,381,
            382,383,384,385,386,387,388,389,390,391,392,393,394,395,396,397,398,399,
            400,401,402,403,404,405,406,407,408,409,410,411,412,413,414,415,416,417,
            418,419,618,619,620,690,691,692,693,694,
                
            420,421,422,423,424,
        };
        internal static readonly ushort[] Pouch_TMHM_ORAS = {
            0,
            328,329,330,331,332,333,334,335,336,337,338,339,340,341,342,343,344,345,
            346,347,348,349,350,351,352,353,354,355,356,357,358,359,360,361,362,363,
            364,365,366,367,368,369,370,371,372,373,374,375,376,377,378,379,380,381,
            382,383,384,385,386,387,388,389,390,391,392,393,394,395,396,397,398,399,
            400,401,402,403,404,405,406,407,408,409,410,411,412,413,414,415,416,417,
            418,419,618,619,620,690,691,692,693,694,
                
            420,421,422,423,424,
                
            // ORAS
            425,737,
        };
        internal static readonly ushort[] Pouch_Medicine_XY = {
            000,017,018,019,020,021,022,023,024,025,026,027,028,029,030,031,032,033,
            034,035,036,037,038,039,040,041,042,043,044,045,046,047,048,049,050,051,
            052,053,054,134,504,565,566,567,568,569,570,571,591,645,708,709,
        };
        internal static readonly ushort[] Pouch_Medicine_ORAS = {
            000,017,018,019,020,021,022,023,024,025,026,027,028,029,030,031,032,033,
            034,035,036,037,038,039,040,041,042,043,044,045,046,047,048,049,050,051,
            052,053,054,134,504,565,566,567,568,569,570,571,591,645,708,709,
            
            //ORAS
            065,066,067
        };
        internal static readonly ushort[] Pouch_Berry_XY = {
            0,149,150,151,152,153,154,155,156,157,158,159,160,161,162,
            163,164,165,166,167,168,169,170,171,172,173,174,175,176,177,
            178,179,180,181,182,183,184,185,186,187,188,189,190,191,192,
            193,194,195,196,197,198,199,200,201,202,203,204,205,206,207,
            208,209,210,211,212,686,687,688,
        };
        #endregion
        #region TMHM
        internal static readonly int[] TMHM_AO =
        {
            468, 337, 473, 347, 046, 092, 258, 339, 474, 237,
            241, 269, 058, 059, 063, 113, 182, 240, 355, 219,
            218, 076, 479, 085, 087, 089, 216, 091, 094, 247,
            280, 104, 115, 482, 053, 188, 201, 126, 317, 332,
            259, 263, 488, 156, 213, 168, 490, 496, 497, 315,
            211, 411, 412, 206, 503, 374, 451, 507, 510, 511,
            261, 512, 373, 153, 421, 371, 514, 416, 397, 148,
            444, 521, 086, 360, 014, 522, 244, 523, 524, 157,
            404, 525, 611, 398, 138, 447, 207, 214, 369, 164,
            430, 433, 528, 290, 555, 267, 399, 612, 605, 590,

            15, 19, 57, 70, 127, 249, 291,
        };
        internal static readonly int[] TMHM_XY =
        {
            468, 337, 473, 347, 046, 092, 258, 339, 474, 237,
            241, 269, 058, 059, 063, 113, 182, 240, 355, 219,
            218, 076, 479, 085, 087, 089, 216, 091, 094, 247,
            280, 104, 115, 482, 053, 188, 201, 126, 317, 332,
            259, 263, 488, 156, 213, 168, 490, 496, 497, 315,
            211, 411, 412, 206, 503, 374, 451, 507, 510, 511,
            261, 512, 373, 153, 421, 371, 514, 416, 397, 148,
            444, 521, 086, 360, 014, 522, 244, 523, 524, 157,
            404, 525, 611, 398, 138, 447, 207, 214, 369, 164,
            430, 433, 528, 249, 555, 267, 399, 612, 605, 590,

            15, 19, 57, 70, 127,
        };
        internal static readonly int[] TypeTutor = { 338, 307, 308, 520, 519, 518, 434, 620 };
        internal static readonly int[][] Tutors_AO =
        {
            new[] {450, 343, 162, 530, 324, 442, 402, 529, 340, 67, 441, 253, 9, 7, 8},
            new[] {277, 335, 414, 492, 356, 393, 334, 387, 276, 527, 196, 401, 399, 428, 406, 304, 231},
            new[] {20, 173, 282, 235, 257, 272, 215, 366, 143, 220, 202, 409, 314, 264, 351, 352},
            new[] {380, 388, 180, 495, 270, 271, 478, 472, 283, 200, 278, 289, 446, 214, 285},
        };
        #endregion

        internal static readonly int Struggle = 165;
        internal static readonly int Chatter = 448;
        internal static readonly int[] InvalidSketch = {Struggle, Chatter};
        internal static readonly int[] EggLocations = {318, 60002, 30002};
    }
}
