﻿using System.Collections.Generic;

namespace pkNX.Game
{
    public static class SWSHInfo
    {
        public static readonly IReadOnlyDictionary<ulong, string> Zones = new Dictionary<ulong, string>
        {
            { 0x078BC1FF1A657844, "Route 1" },
            { 0x10355EFF1F4DB0B5, "Route 2" },
            { 0x776776717EA4483E, "Rolling Fields" },
            { 0x776777717EA449F1, "Dappled Grove" },
            { 0x776778717EA44BA4, "Watchtower Ruins" },
            { 0x776779717EA44D57, "East Lake Axewell" },
            { 0x77677A717EA44F0A, "West Lake Axewell" },
            { 0x77677B717EA450BD, "Axew's Eye" },
            { 0x77676C717EA43740, "South Lake Miloch" },
            { 0x77676D717EA438F3, "Giant's Seat" },
            { 0x776AFA717EA75E61, "North Lake Miloch" },
            { 0x194B97FF2492111A, "Route 3" },
            { 0x776E81717EAA799D, "Motostoke Riverbank" },
            { 0x776E7E717EAA7484, "Bridge Field" },
            { 0xDBCF5CFF0180B073, "Route 4" },
            { 0x8F67CD45F405D66E, "Slumbering Weald" },
            { 0xE0D6E5E78C91F4A7, "City of Motostoke" },
            { 0xE4E595FF06C510D8, "Route 5" },
            { 0x1C7150C0594994E5, "Town of Hulbury" },
            { 0x7D3B7A45E97D4A51, "Galar Mine No. 2" },
            { 0x75D83E45E5AA7953, "Galar Mine" },
            { 0x7D3B7745E97D4538, "Motostoke Outskirts" },
            { 0xA88AC04602050B95, "Glimwood Tangle" },
            { 0xEDFC32FF0C0A1B29, "Route 6" },
            { 0xF55F6BFF0FDCE70E, "Route 7" },
            { 0x449AE0FF3D19D777, "Route 8" },
            { 0x4BFDF9FF40EC6CFC, "Route 8 (on Steamdrift Way)" },
            { 0x4BFDFCFF40EC7215, "Route 9" },
            { 0x4BFDF6FF40EC67E3, "Route 9 (in Circhester Bay)" },
            { 0x4BFDFBFF40EC7062, "Route 9 (in Outer Spikemuth)" },
            { 0xB332930807F9D48A, "Route 10 (Near Station)" },
            { 0x7771E5717EAD5960, "Stony Wilderness" },
            { 0x7771E8717EAD5E79, "Dusty Bowl" },
            { 0x7771E7717EAD5CC6, "Giant's Mirror" },
            { 0x7771EA717EAD61DF, "Hammerlocke Hills" },
            { 0x7771E9717EAD602C, "Giant's Cap" },
            { 0x7771EC717EAD6545, "Lake of Outrage" },
            { 0x10355BFF1F4DAB9C, "Route 2" },
            { 0xB332920807F9D2D7, "Route 10" },
            { 0x8F67CB45F405D308, "Slumbering Weald" },
            { 0xCD6E4FBCE1466F32, "Route 1" },
            { 0xDF686EC613544BD1, "Route 2" },
            { 0xD602B2A66C268F7C, "Rolling Fields" },
            { 0x458C9CA2C0087385, "Dappled Grove" },
            { 0xE20E6AE30AAA57D2, "Watchtower Ruins" },
            { 0xEEEEAC06BAC8D0B3, "East Lake Axewell" },
            { 0xF8D1E527F7B21FA0, "West Lake Axewell" },
            { 0xB6CFE90E0378FD79, "Axew's Eye" },
            { 0x520D8DD522E9A4C6, "South Lake Miloch" },
            { 0xBC7237A0392D8837, "Giant's Seat" },
            { 0xB67C706F5BAE9E35, "North Lake Miloch" },
            { 0xDA910F69A1B92FED, "West Lake Axewell (Surfing)" },
            { 0x7C17DB1B430F9543, "South Lake Miloch (Surfing)" },
            { 0xCC0F8A437312B8AC, "East Lake Axewell (Surfing)" },
            { 0x8BE2F6160986FB8E, "North Lake Miloch (Surfing)" },
            { 0x0E8392C0A57D5830, "Route 3" },
            { 0x82A7A328A26B9057, "Galar Mine" },
            { 0x5B2BC38E044EC2B7, "Route 4" },
            { 0x8D68276C03A332BE, "Route 5" },
            { 0x16D2FC4840A658A5, "Galar Mine No. 2" },
            { 0x3D6D58A96894575E, "Motostoke Outskirts" },
            { 0x6AA652641154B119, "Motostoke Riverbank" },
            { 0x36A5DC94335E1E72, "Bridge Field" },
            { 0xE503416A1C05765D, "Route 6" },
            { 0x201EF8E9D2A32D71, "Glimwood Tangle" },
            { 0x42312695C904658C, "Route 7" },
            { 0x1B95A78295F6F213, "Route 8" },
            { 0xAADAC3CB6A1DFE8A, "Route 8 (on Steamdrift Way)" },
            { 0x9116B224702CDCF1, "Route 9" },
            { 0xCDD3B5660D2E5E67, "Route 9 (in Circhester Bay)" },
            { 0x5A3B8F8147272058, "Route 9 (in Outer Spikemuth)" },
            { 0xA93101EA38598995, "Route 9  (Surfing)" },
            { 0x0181225223DE5420, "Route 10 (Near Station)" },
            { 0x1F0F1AE1818C4326, "Stony Wilderness" },
            { 0xAD11B3F3B2AC662D, "Dusty Bowl" },
            { 0xCD9719B2E64F2AA4, "Giant's Mirror" },
            { 0xCD48625EDC10CBFB, "Hammerlocke Hills" },
            { 0x712F3056573E23FA, "Giant's Cap" },
            { 0x593196758BA16B61, "Lake of Outrage" },
            { 0xF79DE930E6F50533, "Route 10" },
            { 0xA26A4595F72EDAEA, "Route 2 (High Level)" },
            { 0x56580C94EDFCE664, "Route 3 (Garbage)" },
            { 0xCB38FEA3F71C3958, "Rolling Fields (Flying)" },
            { 0x1F174D36062B8C38, "Rolling Fields  (Ground)" },
            { 0x23017513039A78E7, "Rolling Fields  (2)" },
            { 0xF1BA4AAD9AAB2C1A, "Watchtower Ruins (Flying)" },
            { 0x3D2E746F9D3F5CB5, "East Lake Axewell (Flying)" },
            { 0x6E121A9CE4F58F1E, "East Lake Axewell (Flying)" },
            { 0x3171A0C61793816E, "South Lake Miloch (Flying)" },
            { 0x198E4023A1B2DDEF, "South Lake Miloch (2)" },
            { 0xFAB1C08E70C0F1CA, "Motostoke Riverbank (Surfing)" },
            { 0xB9F76CEE459CEC07, "Bridge Field (Surfing)" },
            { 0x5F4E0AB29FD3F13A, "Bridge Field (Flying)" },
            { 0xF603DEA4177200EA, "Stony Wilderness (2)" },
            { 0x76EE4E28DD28374E, "Stony Wilderness (Flying)" },
            { 0x3F264B6FCB5647B4, "Giant's Mirror (Flying)" },
            { 0x2D887A1CA9B1B99A, "Dusty Bowl (Flying)" },
            { 0x2BE7E6A8901ECC20, "Giant's Mirror (Ground)" },
            { 0x39F0170769BF4524, "Dusty Bowl and Giant's Mirror (Surfing)" },
            { 0xB2067FBCF8D5C7BA, "Giant's Cap (Ground)" },
            { 0x48B9525945EE48B5, "Stony Wilderness (3)" },
            { 0xB5756B87989661E1, "Giant's Cap (2)" },
            { 0x7AB83D18C831DDEB, "Giant's Cap (3)" },
            { 0xDBEF8A8593377AAA, "Giant's Cap (Ground)" },
            { 0x066F97F8765BC22D, "Hammerlocke Hills (Flying)" },
            { 0x87A97AFF94BC6CF2, "Lake of Outrage (Surfing)" },
            { 0x94289204B628522C, "Slumbering Weald (Low Level)" },
            { 0x5D02F15C043B872E, "Slumbering Weald (High Level)" },
            { 0xA4945486A2B97DFF, "Route 2 (Surfing)" },
            { 0xAC1187E9EC166853, "Route 9 (in Circhester Bay) (Surfing)" }
        };
    }

    public enum SWSHEncounterType
    {
        Normal_Weather,
        Overcast,
        Raining,
        Thunderstorm,
        Intense_Sun,
        Snowing,
        Snowstorm,
        Sandstorm,
        Heavy_Fog,
        Shaking_Trees,
        Fishing,
    };
}
