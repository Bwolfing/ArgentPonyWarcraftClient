﻿using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<CharacterAppearanceSummary>> GetCharacterAppearanceSummaryAsync(string realmSlug, string characterName, string @namespace)
        {
            return await GetCharacterAppearanceSummaryAsync(realmSlug, characterName, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterAppearanceSummary>> GetCharacterAppearanceSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CharacterAppearanceSummary>(region, $"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/appearance?namespace={@namespace}&locale={locale}");
        }
    }
}
