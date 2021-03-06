﻿using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneLeaderboardsIndex>> GetMythicKeystoneLeaderboardsIndexAsync(int connectedRealmId, string @namespace)
        {
            return await GetMythicKeystoneLeaderboardsIndexAsync(connectedRealmId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneLeaderboardsIndex>> GetMythicKeystoneLeaderboardsIndexAsync(int connectedRealmId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<MythicKeystoneLeaderboardsIndex>(region, $"{host}/data/wow/connected-realm/{connectedRealmId}/mythic-leaderboard/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneLeaderboard>> GetMythicKeystoneLeaderboard(int connectedRealmId, int dungeonId, int period, string @namespace)
        {
            return await GetMythicKeystoneLeaderboard(connectedRealmId, dungeonId, period, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<MythicKeystoneLeaderboard>> GetMythicKeystoneLeaderboard(int connectedRealmId, int dungeonId, int period, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<MythicKeystoneLeaderboard>(region, $"{host}/data/wow/connected-realm/{connectedRealmId}/mythic-leaderboard/{dungeonId}/period/{period}?namespace={@namespace}&locale={locale}");
        }
    }
}
