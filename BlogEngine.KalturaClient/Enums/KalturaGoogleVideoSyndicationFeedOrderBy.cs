namespace Kaltura
{
	public sealed class KalturaGoogleVideoSyndicationFeedOrderBy : KalturaStringEnum
	{
		public static readonly KalturaGoogleVideoSyndicationFeedOrderBy PLAYLIST_ID_ASC = new KalturaGoogleVideoSyndicationFeedOrderBy("+playlistId");
		public static readonly KalturaGoogleVideoSyndicationFeedOrderBy PLAYLIST_ID_DESC = new KalturaGoogleVideoSyndicationFeedOrderBy("-playlistId");
		public static readonly KalturaGoogleVideoSyndicationFeedOrderBy NAME_ASC = new KalturaGoogleVideoSyndicationFeedOrderBy("+name");
		public static readonly KalturaGoogleVideoSyndicationFeedOrderBy NAME_DESC = new KalturaGoogleVideoSyndicationFeedOrderBy("-name");
		public static readonly KalturaGoogleVideoSyndicationFeedOrderBy TYPE_ASC = new KalturaGoogleVideoSyndicationFeedOrderBy("+type");
		public static readonly KalturaGoogleVideoSyndicationFeedOrderBy TYPE_DESC = new KalturaGoogleVideoSyndicationFeedOrderBy("-type");
		public static readonly KalturaGoogleVideoSyndicationFeedOrderBy CREATED_AT_ASC = new KalturaGoogleVideoSyndicationFeedOrderBy("+createdAt");
		public static readonly KalturaGoogleVideoSyndicationFeedOrderBy CREATED_AT_DESC = new KalturaGoogleVideoSyndicationFeedOrderBy("-createdAt");

		private KalturaGoogleVideoSyndicationFeedOrderBy(string name) : base(name) { }
	}
}
