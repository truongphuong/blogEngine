namespace Kaltura
{
	public sealed class KalturaGenericXsltSyndicationFeedOrderBy : KalturaStringEnum
	{
		public static readonly KalturaGenericXsltSyndicationFeedOrderBy PLAYLIST_ID_ASC = new KalturaGenericXsltSyndicationFeedOrderBy("+playlistId");
		public static readonly KalturaGenericXsltSyndicationFeedOrderBy PLAYLIST_ID_DESC = new KalturaGenericXsltSyndicationFeedOrderBy("-playlistId");
		public static readonly KalturaGenericXsltSyndicationFeedOrderBy NAME_ASC = new KalturaGenericXsltSyndicationFeedOrderBy("+name");
		public static readonly KalturaGenericXsltSyndicationFeedOrderBy NAME_DESC = new KalturaGenericXsltSyndicationFeedOrderBy("-name");
		public static readonly KalturaGenericXsltSyndicationFeedOrderBy TYPE_ASC = new KalturaGenericXsltSyndicationFeedOrderBy("+type");
		public static readonly KalturaGenericXsltSyndicationFeedOrderBy TYPE_DESC = new KalturaGenericXsltSyndicationFeedOrderBy("-type");
		public static readonly KalturaGenericXsltSyndicationFeedOrderBy CREATED_AT_ASC = new KalturaGenericXsltSyndicationFeedOrderBy("+createdAt");
		public static readonly KalturaGenericXsltSyndicationFeedOrderBy CREATED_AT_DESC = new KalturaGenericXsltSyndicationFeedOrderBy("-createdAt");

		private KalturaGenericXsltSyndicationFeedOrderBy(string name) : base(name) { }
	}
}
