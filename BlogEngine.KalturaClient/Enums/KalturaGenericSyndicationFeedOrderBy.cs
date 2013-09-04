namespace Kaltura
{
	public sealed class KalturaGenericSyndicationFeedOrderBy : KalturaStringEnum
	{
		public static readonly KalturaGenericSyndicationFeedOrderBy PLAYLIST_ID_ASC = new KalturaGenericSyndicationFeedOrderBy("+playlistId");
		public static readonly KalturaGenericSyndicationFeedOrderBy PLAYLIST_ID_DESC = new KalturaGenericSyndicationFeedOrderBy("-playlistId");
		public static readonly KalturaGenericSyndicationFeedOrderBy NAME_ASC = new KalturaGenericSyndicationFeedOrderBy("+name");
		public static readonly KalturaGenericSyndicationFeedOrderBy NAME_DESC = new KalturaGenericSyndicationFeedOrderBy("-name");
		public static readonly KalturaGenericSyndicationFeedOrderBy TYPE_ASC = new KalturaGenericSyndicationFeedOrderBy("+type");
		public static readonly KalturaGenericSyndicationFeedOrderBy TYPE_DESC = new KalturaGenericSyndicationFeedOrderBy("-type");
		public static readonly KalturaGenericSyndicationFeedOrderBy CREATED_AT_ASC = new KalturaGenericSyndicationFeedOrderBy("+createdAt");
		public static readonly KalturaGenericSyndicationFeedOrderBy CREATED_AT_DESC = new KalturaGenericSyndicationFeedOrderBy("-createdAt");

		private KalturaGenericSyndicationFeedOrderBy(string name) : base(name) { }
	}
}
