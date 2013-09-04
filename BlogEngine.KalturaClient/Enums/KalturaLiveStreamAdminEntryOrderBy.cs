namespace Kaltura
{
	public sealed class KalturaLiveStreamAdminEntryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaLiveStreamAdminEntryOrderBy MEDIA_TYPE_ASC = new KalturaLiveStreamAdminEntryOrderBy("+mediaType");
		public static readonly KalturaLiveStreamAdminEntryOrderBy MEDIA_TYPE_DESC = new KalturaLiveStreamAdminEntryOrderBy("-mediaType");
		public static readonly KalturaLiveStreamAdminEntryOrderBy PLAYS_ASC = new KalturaLiveStreamAdminEntryOrderBy("+plays");
		public static readonly KalturaLiveStreamAdminEntryOrderBy PLAYS_DESC = new KalturaLiveStreamAdminEntryOrderBy("-plays");
		public static readonly KalturaLiveStreamAdminEntryOrderBy VIEWS_ASC = new KalturaLiveStreamAdminEntryOrderBy("+views");
		public static readonly KalturaLiveStreamAdminEntryOrderBy VIEWS_DESC = new KalturaLiveStreamAdminEntryOrderBy("-views");
		public static readonly KalturaLiveStreamAdminEntryOrderBy DURATION_ASC = new KalturaLiveStreamAdminEntryOrderBy("+duration");
		public static readonly KalturaLiveStreamAdminEntryOrderBy DURATION_DESC = new KalturaLiveStreamAdminEntryOrderBy("-duration");
		public static readonly KalturaLiveStreamAdminEntryOrderBy MS_DURATION_ASC = new KalturaLiveStreamAdminEntryOrderBy("+msDuration");
		public static readonly KalturaLiveStreamAdminEntryOrderBy MS_DURATION_DESC = new KalturaLiveStreamAdminEntryOrderBy("-msDuration");
		public static readonly KalturaLiveStreamAdminEntryOrderBy NAME_ASC = new KalturaLiveStreamAdminEntryOrderBy("+name");
		public static readonly KalturaLiveStreamAdminEntryOrderBy NAME_DESC = new KalturaLiveStreamAdminEntryOrderBy("-name");
		public static readonly KalturaLiveStreamAdminEntryOrderBy MODERATION_COUNT_ASC = new KalturaLiveStreamAdminEntryOrderBy("+moderationCount");
		public static readonly KalturaLiveStreamAdminEntryOrderBy MODERATION_COUNT_DESC = new KalturaLiveStreamAdminEntryOrderBy("-moderationCount");
		public static readonly KalturaLiveStreamAdminEntryOrderBy CREATED_AT_ASC = new KalturaLiveStreamAdminEntryOrderBy("+createdAt");
		public static readonly KalturaLiveStreamAdminEntryOrderBy CREATED_AT_DESC = new KalturaLiveStreamAdminEntryOrderBy("-createdAt");
		public static readonly KalturaLiveStreamAdminEntryOrderBy UPDATED_AT_ASC = new KalturaLiveStreamAdminEntryOrderBy("+updatedAt");
		public static readonly KalturaLiveStreamAdminEntryOrderBy UPDATED_AT_DESC = new KalturaLiveStreamAdminEntryOrderBy("-updatedAt");
		public static readonly KalturaLiveStreamAdminEntryOrderBy RANK_ASC = new KalturaLiveStreamAdminEntryOrderBy("+rank");
		public static readonly KalturaLiveStreamAdminEntryOrderBy RANK_DESC = new KalturaLiveStreamAdminEntryOrderBy("-rank");
		public static readonly KalturaLiveStreamAdminEntryOrderBy START_DATE_ASC = new KalturaLiveStreamAdminEntryOrderBy("+startDate");
		public static readonly KalturaLiveStreamAdminEntryOrderBy START_DATE_DESC = new KalturaLiveStreamAdminEntryOrderBy("-startDate");
		public static readonly KalturaLiveStreamAdminEntryOrderBy END_DATE_ASC = new KalturaLiveStreamAdminEntryOrderBy("+endDate");
		public static readonly KalturaLiveStreamAdminEntryOrderBy END_DATE_DESC = new KalturaLiveStreamAdminEntryOrderBy("-endDate");
		public static readonly KalturaLiveStreamAdminEntryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaLiveStreamAdminEntryOrderBy("+partnerSortValue");
		public static readonly KalturaLiveStreamAdminEntryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaLiveStreamAdminEntryOrderBy("-partnerSortValue");

		private KalturaLiveStreamAdminEntryOrderBy(string name) : base(name) { }
	}
}
