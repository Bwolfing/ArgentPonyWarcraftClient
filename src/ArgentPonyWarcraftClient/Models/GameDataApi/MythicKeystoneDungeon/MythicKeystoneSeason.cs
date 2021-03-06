﻿using System;
using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A mythic keystone season.
    /// </summary>
    public class MythicKeystoneSeason
    {
        /// <summary>
        /// Gets links for the mythic keystone season.
        /// </summary>
        [JsonProperty("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the mythic keystone season.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the start timestamp of the mythic keystone season.
        /// </summary>
        [JsonProperty("start_timestamp")]
        public DateTime StartTimestamp { get; set; }

        /// <summary>
        /// Gets the end timestamp of the mythic keystone season.
        /// </summary>
        [JsonProperty("end_timestamp")]
        public DateTime EndTimestamp { get; set; }

        /// <summary>
        /// Gets refernces to the periods in the mythic keystone season.
        /// </summary>
        [JsonProperty("periods")]
        public MythicKeystonePeriodReference[] Periods { get; set; }
    }
}
