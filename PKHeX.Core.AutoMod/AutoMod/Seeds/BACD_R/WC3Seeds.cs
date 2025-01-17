﻿namespace PKHeX.Core.AutoMod;

// There only exists 9 shiny seeds for wishmaker jirachi bacd_r, just have a list and gen based on nature
public static class WC3Seeds
{
    public static uint GetShinyWishmakerSeed(Nature nature) => nature switch
    {
        Nature.Bashful => 0x353d,
        Nature.Careful => 0xf500,
        Nature.Docile => 0xecdd,
        Nature.Hasty => 0x9359,
        Nature.Jolly => 0xcf37,
        Nature.Lonely => 0x7236,
        Nature.Naughty => 0xa030,
        Nature.Timid => 0x7360,
        Nature.Serious => 0x3d60,
        _ => 0,
    };
}