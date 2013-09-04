namespace Kaltura
{
	public sealed class KalturaBaseSyndicationFeedOrderBy : KalturaStringEnum
	{
		public static readonly KalturaBaseSyndicationFeedOrderBy PLAYLIST_ID_ASC = new KalturaBaseSyndicationFeedOrderBy("+playlistId");
		public static readonly KalturaBaseSyndicationFeedOrderBy PLAYLIST_ID_DESC = new KalturaBaseSyndicationFeedOrderBy("-playlistId");
		public static readonly KalturaBaseSyndicationFeedOrderBy NAME_ASC = new KalturaBaseSyndicationFeedOrderBy("+name");
		public static readonly KalturaBaseSyndicationFeedOrderBy NAME_DESC = new KalturaBaseSyndicationFeedOrderBy("-name");
		public static readonly KalturaBaseSyndicationFeedOrderBy TYPE_ASC = new KalturaBaseSyndicationFeedOrderBy("+type");
		public static readonly KalturaBaseSyndicationFeedOrderBy TYPE_DESC = new KalturaBaseSyndicationFeedOrderBy("-type");
		public static readonly KalturaBaseSyndicationFeedOrderBy CREATED_AT_ASC = new KalturaBaseSyndicationFeedOrderBy("+createdAt");
		public static readonly KalturaBaseSyndicationFeedOrderBy CREATED_AT_DESC = new KalturaBaseSyndicationFeedOrderBy("-createdAt");

		private KalturaBaseSyndicationFeedOrderBy(string name) : base(name) { }
	}
}
