namespace Kaltura
{
	public sealed class KalturaBaseEntryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaBaseEntryOrderBy NAME_ASC = new KalturaBaseEntryOrderBy("+name");
		public static readonly KalturaBaseEntryOrderBy NAME_DESC = new KalturaBaseEntryOrderBy("-name");
		public static readonly KalturaBaseEntryOrderBy MODERATION_COUNT_ASC = new KalturaBaseEntryOrderBy("+moderationCount");
		public static readonly KalturaBaseEntryOrderBy MODERATION_COUNT_DESC = new KalturaBaseEntryOrderBy("-moderationCount");
		public static readonly KalturaBaseEntryOrderBy CREATED_AT_ASC = new KalturaBaseEntryOrderBy("+createdAt");
		public static readonly KalturaBaseEntryOrderBy CREATED_AT_DESC = new KalturaBaseEntryOrderBy("-createdAt");
		public static readonly KalturaBaseEntryOrderBy UPDATED_AT_ASC = new KalturaBaseEntryOrderBy("+updatedAt");
		public static readonly KalturaBaseEntryOrderBy UPDATED_AT_DESC = new KalturaBaseEntryOrderBy("-updatedAt");
		public static readonly KalturaBaseEntryOrderBy RANK_ASC = new KalturaBaseEntryOrderBy("+rank");
		public static readonly KalturaBaseEntryOrderBy RANK_DESC = new KalturaBaseEntryOrderBy("-rank");
		public static readonly KalturaBaseEntryOrderBy START_DATE_ASC = new KalturaBaseEntryOrderBy("+startDate");
		public static readonly KalturaBaseEntryOrderBy START_DATE_DESC = new KalturaBaseEntryOrderBy("-startDate");
		public static readonly KalturaBaseEntryOrderBy END_DATE_ASC = new KalturaBaseEntryOrderBy("+endDate");
		public static readonly KalturaBaseEntryOrderBy END_DATE_DESC = new KalturaBaseEntryOrderBy("-endDate");
		public static readonly KalturaBaseEntryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaBaseEntryOrderBy("+partnerSortValue");
		public static readonly KalturaBaseEntryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaBaseEntryOrderBy("-partnerSortValue");

		private KalturaBaseEntryOrderBy(string name) : base(name) { }
	}
}
