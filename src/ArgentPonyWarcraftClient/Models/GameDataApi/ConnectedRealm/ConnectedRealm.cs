﻿using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A connected realm.
    /// </summary>
    public class ConnectedRealm
    {
        /// <summary>
        /// Gets links for the connected realm.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the connected realm.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a value indicating whether there is a queue to log in to the connected realm.
        /// </summary>
        [JsonProperty("has_queue")]
        public bool HasQueue { get; set; }

        /// <summary>
        /// Gets the status of the realm.
        /// </summary>
        [JsonProperty("status")]
        public EnumType Status { get; set; }

        /// <summary>
        /// Gets a rough indicator of the connected realm population.
        /// </summary>
        [JsonProperty("population")]
        public EnumType Population { get; set; }

        /// <summary>
        /// Gets the realms in the connected realm.
        /// </summary>
        [JsonProperty("realms")]
        public Realm[] Realms { get; set; }

        /// <summary>
        /// Gets a reference to the Mythic Keystone Leaderboard data for this connected realm.
        /// </summary>
        [JsonProperty("mythic_leaderboards")]
        public Self MythicLeaderboards { get; set; }

        /// <summary>
        /// Gets a reference to the auction house data for this connected realm.
        /// </summary>
        [JsonProperty("auctions")]
        public Self Auctions { get; set; }
    }
}
