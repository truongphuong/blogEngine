namespace Kaltura
{
	public sealed class KalturaMediaEntryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaMediaEntryOrderBy MEDIA_TYPE_ASC = new KalturaMediaEntryOrderBy("+mediaType");
		public static readonly KalturaMediaEntryOrderBy MEDIA_TYPE_DESC = new KalturaMediaEntryOrderBy("-mediaType");
		public static readonly KalturaMediaEntryOrderBy PLAYS_ASC = new KalturaMediaEntryOrderBy("+plays");
		public static readonly KalturaMediaEntryOrderBy PLAYS_DESC = new KalturaMediaEntryOrderBy("-plays");
		public static readonly KalturaMediaEntryOrderBy VIEWS_ASC = new KalturaMediaEntryOrderBy("+views");
		public static readonly KalturaMediaEntryOrderBy VIEWS_DESC = new KalturaMediaEntryOrderBy("-views");
		public static readonly KalturaMediaEntryOrderBy DURATION_ASC = new KalturaMediaEntryOrderBy("+duration");
		public static readonly KalturaMediaEntryOrderBy DURATION_DESC = new KalturaMediaEntryOrderBy("-duration");
		public static readonly KalturaMediaEntryOrderBy MS_DURATION_ASC = new KalturaMediaEntryOrderBy("+msDuration");
		public static readonly KalturaMediaEntryOrderBy MS_DURATION_DESC = new KalturaMediaEntryOrderBy("-msDuration");
		public static readonly KalturaMediaEntryOrderBy NAME_ASC = new KalturaMediaEntryOrderBy("+name");
		public static readonly KalturaMediaEntryOrderBy NAME_DESC = new KalturaMediaEntryOrderBy("-name");
		public static readonly KalturaMediaEntryOrderBy MODERATION_COUNT_ASC = new KalturaMediaEntryOrderBy("+moderationCount");
		public static readonly KalturaMediaEntryOrderBy MODERATION_COUNT_DESC = new KalturaMediaEntryOrderBy("-moderationCount");
		public static readonly KalturaMediaEntryOrderBy CREATED_AT_ASC = new KalturaMediaEntryOrderBy("+createdAt");
		public static readonly KalturaMediaEntryOrderBy CREATED_AT_DESC = new KalturaMediaEntryOrderBy("-createdAt");
		public static readonly KalturaMediaEntryOrderBy UPDATED_AT_ASC = new KalturaMediaEntryOrderBy("+updatedAt");
		public static readonly KalturaMediaEntryOrderBy UPDATED_AT_DESC = new KalturaMediaEntryOrderBy("-updatedAt");
		public static readonly KalturaMediaEntryOrderBy RANK_ASC = new KalturaMediaEntryOrderBy("+rank");
		public static readonly KalturaMediaEntryOrderBy RANK_DESC = new KalturaMediaEntryOrderBy("-rank");
		public static readonly KalturaMediaEntryOrderBy START_DATE_ASC = new KalturaMediaEntryOrderBy("+startDate");
		public static readonly KalturaMediaEntryOrderBy START_DATE_DESC = new KalturaMediaEntryOrderBy("-startDate");
		public static readonly KalturaMediaEntryOrderBy END_DATE_ASC = new KalturaMediaEntryOrderBy("+endDate");
		public static readonly KalturaMediaEntryOrderBy END_DATE_DESC = new KalturaMediaEntryOrderBy("-endDate");
		public static readonly KalturaMediaEntryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaMediaEntryOrderBy("+partnerSortValue");
		public static readonly KalturaMediaEntryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaMediaEntryOrderBy("-partnerSortValue");

		private KalturaMediaEntryOrderBy(string name) : base(name) { }
	}
}
