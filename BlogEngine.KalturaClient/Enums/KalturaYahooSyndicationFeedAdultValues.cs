namespace Kaltura
{
	public sealed class KalturaYahooSyndicationFeedAdultValues : KalturaStringEnum
	{
		public static readonly KalturaYahooSyndicationFeedAdultValues ADULT = new KalturaYahooSyndicationFeedAdultValues("adult");
		public static readonly KalturaYahooSyndicationFeedAdultValues NON_ADULT = new KalturaYahooSyndicationFeedAdultValues("nonadult");

		private KalturaYahooSyndicationFeedAdultValues(string name) : base(name) { }
	}
}
