namespace Kaltura
{
	public sealed class KalturaDataEntryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaDataEntryOrderBy NAME_ASC = new KalturaDataEntryOrderBy("+name");
		public static readonly KalturaDataEntryOrderBy NAME_DESC = new KalturaDataEntryOrderBy("-name");
		public static readonly KalturaDataEntryOrderBy MODERATION_COUNT_ASC = new KalturaDataEntryOrderBy("+moderationCount");
		public static readonly KalturaDataEntryOrderBy MODERATION_COUNT_DESC = new KalturaDataEntryOrderBy("-moderationCount");
		public static readonly KalturaDataEntryOrderBy CREATED_AT_ASC = new KalturaDataEntryOrderBy("+createdAt");
		public static readonly KalturaDataEntryOrderBy CREATED_AT_DESC = new KalturaDataEntryOrderBy("-createdAt");
		public static readonly KalturaDataEntryOrderBy UPDATED_AT_ASC = new KalturaDataEntryOrderBy("+updatedAt");
		public static readonly KalturaDataEntryOrderBy UPDATED_AT_DESC = new KalturaDataEntryOrderBy("-updatedAt");
		public static readonly KalturaDataEntryOrderBy RANK_ASC = new KalturaDataEntryOrderBy("+rank");
		public static readonly KalturaDataEntryOrderBy RANK_DESC = new KalturaDataEntryOrderBy("-rank");
		public static readonly KalturaDataEntryOrderBy START_DATE_ASC = new KalturaDataEntryOrderBy("+startDate");
		public static readonly KalturaDataEntryOrderBy START_DATE_DESC = new KalturaDataEntryOrderBy("-startDate");
		public static readonly KalturaDataEntryOrderBy END_DATE_ASC = new KalturaDataEntryOrderBy("+endDate");
		public static readonly KalturaDataEntryOrderBy END_DATE_DESC = new KalturaDataEntryOrderBy("-endDate");
		public static readonly KalturaDataEntryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaDataEntryOrderBy("+partnerSortValue");
		public static readonly KalturaDataEntryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaDataEntryOrderBy("-partnerSortValue");

		private KalturaDataEntryOrderBy(string name) : base(name) { }
	}
}
