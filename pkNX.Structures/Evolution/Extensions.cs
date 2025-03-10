﻿using System.Collections.Generic;

using static pkNX.Structures.EvolutionType;
using static pkNX.Structures.EvolutionTypeArgumentType;

namespace pkNX.Structures
{
    public static partial class Extensions
    {
        private static readonly Dictionary<EvolutionType, EvolutionTypeArgumentType> ArgType = new Dictionary<EvolutionType, EvolutionTypeArgumentType>
        {
            [None] = NoArg,
            [LevelUpFriendship] = NoArg,
            [LevelUpFriendshipMorning] = NoArg,
            [LevelUpFriendshipNight] = NoArg,
            [LevelUp] = Level,
            [Trade] = NoArg,
            [TradeHeldItem] = Items,
            [TradeSpecies] = Species,
            [UseItem] = Items,

            [LevelUpATK] = Level,
            [LevelUpDEF] = Level,
            [LevelUpAeqD] = Level,
            [LevelUpECl5] = Level,
            [LevelUpECgeq5] = Level,
            [LevelUpNinjask] = Level,
            [LevelUpShedinja] = Level,
            [LevelUpBeauty] = Stat,

            [UseItemMale] = Items,
            [UseItemFemale] = Items,
            [LevelUpHeldItemDay] = Items,
            [LevelUpHeldItemNight] = Items,
            [LevelUpKnowMove] = Moves,
            [LevelUpWithTeammate] = Species,
            [LevelUpMale] = Level,
            [LevelUpFemale] = Level,
            [LevelUpElectric] = NoArg,
            [LevelUpForest] = NoArg,
            [LevelUpCold] = NoArg,
            [LevelUpInverted] = NoArg,
            [LevelUpAffection50MoveType] = Type,

            [LevelUpMoveType] = Type,
            [LevelUpWeather] = Level,
            [LevelUpMorning] = Level,
            [LevelUpNight] = Level,
            [LevelUpFormFemale1] = Level,
            [UNUSED] = NoArg,
            [LevelUpVersion] = Version,
            [LevelUpVersionDay] = Version,
            [LevelUpVersionNight] = Version,
            [LevelUpSummit] = Level,
            [LevelUpDusk] = Level,
            [LevelUpWormhole] = Level,
            [UseItemWormhole] = Items,

            [U43] = Version, // Farfetch'd (1) with val 3? -> Sirfetch'd
            [U44] = Version, // Yamask (1) -> Runerigus (val 49)
            [U45] = Version, // Milcery->Alcremie (Console Region==Form?)
            [U46] = Version, // Toxel->Toxtricity (0)
            [U47] = Version, // Toxel->Toxtricity (1)
        };

        public static EvolutionTypeArgumentType GetArgType(this EvolutionType t) => ArgType[t];
    }
}