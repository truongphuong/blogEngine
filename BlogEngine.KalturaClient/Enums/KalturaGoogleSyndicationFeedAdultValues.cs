namespace Kaltura
{
	public sealed class KalturaGoogleSyndicationFeedAdultValues : KalturaStringEnum
	{
		public static readonly KalturaGoogleSyndicationFeedAdultValues YES = new KalturaGoogleSyndicationFeedAdultValues("Yes");
		public static readonly KalturaGoogleSyndicationFeedAdultValues NO = new KalturaGoogleSyndicationFeedAdultValues("No");

		private KalturaGoogleSyndicationFeedAdultValues(string name) : base(name) { }
	}
}
