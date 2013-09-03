namespace Kaltura
{
	public sealed class KalturaTubeMogulSyndicationFeedOrderBy : KalturaStringEnum
	{
		public static readonly KalturaTubeMogulSyndicationFeedOrderBy PLAYLIST_ID_ASC = new KalturaTubeMogulSyndicationFeedOrderBy("+playlistId");
		public static readonly KalturaTubeMogulSyndicationFeedOrderBy PLAYLIST_ID_DESC = new KalturaTubeMogulSyndicationFeedOrderBy("-playlistId");
		public static readonly KalturaTubeMogulSyndicationFeedOrderBy NAME_ASC = new KalturaTubeMogulSyndicationFeedOrderBy("+name");
		public static readonly KalturaTubeMogulSyndicationFeedOrderBy NAME_DESC = new KalturaTubeMogulSyndicationFeedOrderBy("-name");
		public static readonly KalturaTubeMogulSyndicationFeedOrderBy TYPE_ASC = new KalturaTubeMogulSyndicationFeedOrderBy("+type");
		public static readonly KalturaTubeMogulSyndicationFeedOrderBy TYPE_DESC = new KalturaTubeMogulSyndicationFeedOrderBy("-type");
		public static readonly KalturaTubeMogulSyndicationFeedOrderBy CREATED_AT_ASC = new KalturaTubeMogulSyndicationFeedOrderBy("+createdAt");
		public static readonly KalturaTubeMogulSyndicationFeedOrderBy CREATED_AT_DESC = new KalturaTubeMogulSyndicationFeedOrderBy("-createdAt");

		private KalturaTubeMogulSyndicationFeedOrderBy(string name) : base(name) { }
	}
}
