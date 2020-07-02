﻿namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     A client for the World of Warcraft Game Data APIs.
    /// </summary>
    public interface IGameDataApi :
        IAchievementApi,
        IAuctionHouseApi,
        IConnectedRealmApi,
        ICreatureApi,
        IGuildCrestApi,
        IItemApi,
        IJournalApi,
        IMountApi,
        IMythicKeystoneAffixApi,
        IMythicKeystoneDungeonApi,
        IMythicKeystoneLeaderboardApi,
        IMythicRaidLeaderboardApi,
        IPetApi,
        IPlayableClassApi,
        IPlayableRaceApi,
        IPlayableSpecializationApi,
        IProfessionApi,
        IPvpSeasonApi,
        IPvpTierApi,
        IQuestApi,
        IRealmApi,
        ISpellApi,
        ITalentApi
    {
    }
}