﻿using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<Guild>> GetGuildAsync(string realmSlug, string nameSlug, string @namespace)
        {
            return await GetGuildAsync(realmSlug, nameSlug, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<Guild>> GetGuildAsync(string realmSlug, string nameSlug, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<Guild>(region, $"{host}/data/wow/guild/{realmSlug}/{nameSlug?.ToLowerInvariant()}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<GuildActivity>> GetGuildActivityAsync(string realmSlug, string nameSlug, string @namespace)
        {
            return await GetGuildActivityAsync(realmSlug, nameSlug, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<GuildActivity>> GetGuildActivityAsync(string realmSlug, string nameSlug, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<GuildActivity>(region, $"{host}/data/wow/guild/{realmSlug}/{nameSlug?.ToLowerInvariant()}/activity?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<GuildAchievements>> GetGuildAchievementsAsync(string realmSlug, string nameSlug, string @namespace)
        {
            return await GetGuildAchievementsAsync(realmSlug, nameSlug, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<GuildAchievements>> GetGuildAchievementsAsync(string realmSlug, string nameSlug, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<GuildAchievements>(region, $"{host}/data/wow/guild/{realmSlug}/{nameSlug?.ToLowerInvariant()}/achievements?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<GuildRoster>> GetGuildRosterAsync(string realmSlug, string nameSlug, string @namespace)
        {
            return await GetGuildRosterAsync(realmSlug, nameSlug, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<GuildRoster>> GetGuildRosterAsync(string realmSlug, string nameSlug, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<GuildRoster>(region, $"{host}/data/wow/guild/{realmSlug}/{nameSlug?.ToLowerInvariant()}/roster?namespace={@namespace}&locale={locale}");
        }
    }
}
