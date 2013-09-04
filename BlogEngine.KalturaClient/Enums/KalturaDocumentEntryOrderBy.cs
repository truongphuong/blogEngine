namespace Kaltura
{
	public sealed class KalturaDocumentEntryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaDocumentEntryOrderBy NAME_ASC = new KalturaDocumentEntryOrderBy("+name");
		public static readonly KalturaDocumentEntryOrderBy NAME_DESC = new KalturaDocumentEntryOrderBy("-name");
		public static readonly KalturaDocumentEntryOrderBy MODERATION_COUNT_ASC = new KalturaDocumentEntryOrderBy("+moderationCount");
		public static readonly KalturaDocumentEntryOrderBy MODERATION_COUNT_DESC = new KalturaDocumentEntryOrderBy("-moderationCount");
		public static readonly KalturaDocumentEntryOrderBy CREATED_AT_ASC = new KalturaDocumentEntryOrderBy("+createdAt");
		public static readonly KalturaDocumentEntryOrderBy CREATED_AT_DESC = new KalturaDocumentEntryOrderBy("-createdAt");
		public static readonly KalturaDocumentEntryOrderBy UPDATED_AT_ASC = new KalturaDocumentEntryOrderBy("+updatedAt");
		public static readonly KalturaDocumentEntryOrderBy UPDATED_AT_DESC = new KalturaDocumentEntryOrderBy("-updatedAt");
		public static readonly KalturaDocumentEntryOrderBy RANK_ASC = new KalturaDocumentEntryOrderBy("+rank");
		public static readonly KalturaDocumentEntryOrderBy RANK_DESC = new KalturaDocumentEntryOrderBy("-rank");
		public static readonly KalturaDocumentEntryOrderBy START_DATE_ASC = new KalturaDocumentEntryOrderBy("+startDate");
		public static readonly KalturaDocumentEntryOrderBy START_DATE_DESC = new KalturaDocumentEntryOrderBy("-startDate");
		public static readonly KalturaDocumentEntryOrderBy END_DATE_ASC = new KalturaDocumentEntryOrderBy("+endDate");
		public static readonly KalturaDocumentEntryOrderBy END_DATE_DESC = new KalturaDocumentEntryOrderBy("-endDate");
		public static readonly KalturaDocumentEntryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaDocumentEntryOrderBy("+partnerSortValue");
		public static readonly KalturaDocumentEntryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaDocumentEntryOrderBy("-partnerSortValue");

		private KalturaDocumentEntryOrderBy(string name) : base(name) { }
	}
}
