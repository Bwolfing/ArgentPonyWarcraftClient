﻿using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a PvP tier.
    /// </summary>
    public class PvpTierReference
    {
        /// <summary>
        /// Gets the key for the PvP tier.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the name of the PvP tier.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the ID of the PvP tier.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
