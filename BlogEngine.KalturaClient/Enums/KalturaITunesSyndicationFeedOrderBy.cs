namespace Kaltura
{
	public sealed class KalturaITunesSyndicationFeedOrderBy : KalturaStringEnum
	{
		public static readonly KalturaITunesSyndicationFeedOrderBy PLAYLIST_ID_ASC = new KalturaITunesSyndicationFeedOrderBy("+playlistId");
		public static readonly KalturaITunesSyndicationFeedOrderBy PLAYLIST_ID_DESC = new KalturaITunesSyndicationFeedOrderBy("-playlistId");
		public static readonly KalturaITunesSyndicationFeedOrderBy NAME_ASC = new KalturaITunesSyndicationFeedOrderBy("+name");
		public static readonly KalturaITunesSyndicationFeedOrderBy NAME_DESC = new KalturaITunesSyndicationFeedOrderBy("-name");
		public static readonly KalturaITunesSyndicationFeedOrderBy TYPE_ASC = new KalturaITunesSyndicationFeedOrderBy("+type");
		public static readonly KalturaITunesSyndicationFeedOrderBy TYPE_DESC = new KalturaITunesSyndicationFeedOrderBy("-type");
		public static readonly KalturaITunesSyndicationFeedOrderBy CREATED_AT_ASC = new KalturaITunesSyndicationFeedOrderBy("+createdAt");
		public static readonly KalturaITunesSyndicationFeedOrderBy CREATED_AT_DESC = new KalturaITunesSyndicationFeedOrderBy("-createdAt");

		private KalturaITunesSyndicationFeedOrderBy(string name) : base(name) { }
	}
}
