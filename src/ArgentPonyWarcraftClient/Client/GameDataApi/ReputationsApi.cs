﻿using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<ReputationFactionsIndex>> GetReputationFactionsIndexAsync(string @namespace)
        {
            return await GetReputationFactionsIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<ReputationFactionsIndex>> GetReputationFactionsIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<ReputationFactionsIndex>(region, $"{host}/data/wow/reputation-faction/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<ReputationFaction>> GetReputationFactionAsync(int reputationFactionId, string @namespace)
        {
            return await GetReputationFactionAsync(reputationFactionId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<ReputationFaction>> GetReputationFactionAsync(int reputationFactionId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<ReputationFaction>(region, $"{host}/data/wow/reputation-faction/{reputationFactionId}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<ReputationTiersIndex>> GetReputationTiersIndexAsync(string @namespace)
        {
            return await GetReputationTiersIndexAsync(@namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<ReputationTiersIndex>> GetReputationTiersIndexAsync(string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<ReputationTiersIndex>(region, $"{host}/data/wow/reputation-tiers/index?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<ReputationTiers>> GetReputationTiersAsync(int reputationTiersId, string @namespace)
        {
            return await GetReputationTiersAsync(reputationTiersId, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<ReputationTiers>> GetReputationTiersAsync(int reputationTiersId, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<ReputationTiers>(region, $"{host}/data/wow/reputation-tiers/{reputationTiersId}?namespace={@namespace}&locale={locale}");
        }
    }
}
