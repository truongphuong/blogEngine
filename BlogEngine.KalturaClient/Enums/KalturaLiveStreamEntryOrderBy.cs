namespace Kaltura
{
	public sealed class KalturaLiveStreamEntryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaLiveStreamEntryOrderBy MEDIA_TYPE_ASC = new KalturaLiveStreamEntryOrderBy("+mediaType");
		public static readonly KalturaLiveStreamEntryOrderBy MEDIA_TYPE_DESC = new KalturaLiveStreamEntryOrderBy("-mediaType");
		public static readonly KalturaLiveStreamEntryOrderBy PLAYS_ASC = new KalturaLiveStreamEntryOrderBy("+plays");
		public static readonly KalturaLiveStreamEntryOrderBy PLAYS_DESC = new KalturaLiveStreamEntryOrderBy("-plays");
		public static readonly KalturaLiveStreamEntryOrderBy VIEWS_ASC = new KalturaLiveStreamEntryOrderBy("+views");
		public static readonly KalturaLiveStreamEntryOrderBy VIEWS_DESC = new KalturaLiveStreamEntryOrderBy("-views");
		public static readonly KalturaLiveStreamEntryOrderBy DURATION_ASC = new KalturaLiveStreamEntryOrderBy("+duration");
		public static readonly KalturaLiveStreamEntryOrderBy DURATION_DESC = new KalturaLiveStreamEntryOrderBy("-duration");
		public static readonly KalturaLiveStreamEntryOrderBy MS_DURATION_ASC = new KalturaLiveStreamEntryOrderBy("+msDuration");
		public static readonly KalturaLiveStreamEntryOrderBy MS_DURATION_DESC = new KalturaLiveStreamEntryOrderBy("-msDuration");
		public static readonly KalturaLiveStreamEntryOrderBy NAME_ASC = new KalturaLiveStreamEntryOrderBy("+name");
		public static readonly KalturaLiveStreamEntryOrderBy NAME_DESC = new KalturaLiveStreamEntryOrderBy("-name");
		public static readonly KalturaLiveStreamEntryOrderBy MODERATION_COUNT_ASC = new KalturaLiveStreamEntryOrderBy("+moderationCount");
		public static readonly KalturaLiveStreamEntryOrderBy MODERATION_COUNT_DESC = new KalturaLiveStreamEntryOrderBy("-moderationCount");
		public static readonly KalturaLiveStreamEntryOrderBy CREATED_AT_ASC = new KalturaLiveStreamEntryOrderBy("+createdAt");
		public static readonly KalturaLiveStreamEntryOrderBy CREATED_AT_DESC = new KalturaLiveStreamEntryOrderBy("-createdAt");
		public static readonly KalturaLiveStreamEntryOrderBy UPDATED_AT_ASC = new KalturaLiveStreamEntryOrderBy("+updatedAt");
		public static readonly KalturaLiveStreamEntryOrderBy UPDATED_AT_DESC = new KalturaLiveStreamEntryOrderBy("-updatedAt");
		public static readonly KalturaLiveStreamEntryOrderBy RANK_ASC = new KalturaLiveStreamEntryOrderBy("+rank");
		public static readonly KalturaLiveStreamEntryOrderBy RANK_DESC = new KalturaLiveStreamEntryOrderBy("-rank");
		public static readonly KalturaLiveStreamEntryOrderBy START_DATE_ASC = new KalturaLiveStreamEntryOrderBy("+startDate");
		public static readonly KalturaLiveStreamEntryOrderBy START_DATE_DESC = new KalturaLiveStreamEntryOrderBy("-startDate");
		public static readonly KalturaLiveStreamEntryOrderBy END_DATE_ASC = new KalturaLiveStreamEntryOrderBy("+endDate");
		public static readonly KalturaLiveStreamEntryOrderBy END_DATE_DESC = new KalturaLiveStreamEntryOrderBy("-endDate");
		public static readonly KalturaLiveStreamEntryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaLiveStreamEntryOrderBy("+partnerSortValue");
		public static readonly KalturaLiveStreamEntryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaLiveStreamEntryOrderBy("-partnerSortValue");

		private KalturaLiveStreamEntryOrderBy(string name) : base(name) { }
	}
}
