namespace Kaltura
{
	public sealed class KalturaYahooSyndicationFeedOrderBy : KalturaStringEnum
	{
		public static readonly KalturaYahooSyndicationFeedOrderBy PLAYLIST_ID_ASC = new KalturaYahooSyndicationFeedOrderBy("+playlistId");
		public static readonly KalturaYahooSyndicationFeedOrderBy PLAYLIST_ID_DESC = new KalturaYahooSyndicationFeedOrderBy("-playlistId");
		public static readonly KalturaYahooSyndicationFeedOrderBy NAME_ASC = new KalturaYahooSyndicationFeedOrderBy("+name");
		public static readonly KalturaYahooSyndicationFeedOrderBy NAME_DESC = new KalturaYahooSyndicationFeedOrderBy("-name");
		public static readonly KalturaYahooSyndicationFeedOrderBy TYPE_ASC = new KalturaYahooSyndicationFeedOrderBy("+type");
		public static readonly KalturaYahooSyndicationFeedOrderBy TYPE_DESC = new KalturaYahooSyndicationFeedOrderBy("-type");
		public static readonly KalturaYahooSyndicationFeedOrderBy CREATED_AT_ASC = new KalturaYahooSyndicationFeedOrderBy("+createdAt");
		public static readonly KalturaYahooSyndicationFeedOrderBy CREATED_AT_DESC = new KalturaYahooSyndicationFeedOrderBy("-createdAt");

		private KalturaYahooSyndicationFeedOrderBy(string name) : base(name) { }
	}
}
