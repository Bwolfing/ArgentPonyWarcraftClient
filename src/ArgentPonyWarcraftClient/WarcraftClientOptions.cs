namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Configuration options for <see cref="WarcraftClient" /> instances.
    /// </summary>
    public class WarcraftClientOptions
    {
        /// <summary>
        /// The Blizzard Mashery API key.
        /// <para>
        /// To create an API key visit
        /// https://dev.battle.net/member/register
        /// </para>
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// The region that the API will retrieve its data from.
        /// </summary>
        public Region Region { get; set; } = Region.US;

        /// <summary>
        /// Specifies the language that the result will be in.
        /// <para>
        /// Visit https://dev.battle.net/docs/read/community_apis
        /// to see a list of available locales.
        /// </para>
        /// </summary>
        public Locale Locale { get; set; } = Locale.en_US;
    }
}