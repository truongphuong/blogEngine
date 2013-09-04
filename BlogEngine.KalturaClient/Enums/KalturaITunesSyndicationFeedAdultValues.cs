namespace Kaltura
{
	public sealed class KalturaITunesSyndicationFeedAdultValues : KalturaStringEnum
	{
		public static readonly KalturaITunesSyndicationFeedAdultValues YES = new KalturaITunesSyndicationFeedAdultValues("yes");
		public static readonly KalturaITunesSyndicationFeedAdultValues NO = new KalturaITunesSyndicationFeedAdultValues("no");
		public static readonly KalturaITunesSyndicationFeedAdultValues CLEAN = new KalturaITunesSyndicationFeedAdultValues("clean");

		private KalturaITunesSyndicationFeedAdultValues(string name) : base(name) { }
	}
}
