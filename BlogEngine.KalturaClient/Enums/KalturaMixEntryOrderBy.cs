namespace Kaltura
{
	public sealed class KalturaMixEntryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaMixEntryOrderBy PLAYS_ASC = new KalturaMixEntryOrderBy("+plays");
		public static readonly KalturaMixEntryOrderBy PLAYS_DESC = new KalturaMixEntryOrderBy("-plays");
		public static readonly KalturaMixEntryOrderBy VIEWS_ASC = new KalturaMixEntryOrderBy("+views");
		public static readonly KalturaMixEntryOrderBy VIEWS_DESC = new KalturaMixEntryOrderBy("-views");
		public static readonly KalturaMixEntryOrderBy DURATION_ASC = new KalturaMixEntryOrderBy("+duration");
		public static readonly KalturaMixEntryOrderBy DURATION_DESC = new KalturaMixEntryOrderBy("-duration");
		public static readonly KalturaMixEntryOrderBy MS_DURATION_ASC = new KalturaMixEntryOrderBy("+msDuration");
		public static readonly KalturaMixEntryOrderBy MS_DURATION_DESC = new KalturaMixEntryOrderBy("-msDuration");
		public static readonly KalturaMixEntryOrderBy NAME_ASC = new KalturaMixEntryOrderBy("+name");
		public static readonly KalturaMixEntryOrderBy NAME_DESC = new KalturaMixEntryOrderBy("-name");
		public static readonly KalturaMixEntryOrderBy MODERATION_COUNT_ASC = new KalturaMixEntryOrderBy("+moderationCount");
		public static readonly KalturaMixEntryOrderBy MODERATION_COUNT_DESC = new KalturaMixEntryOrderBy("-moderationCount");
		public static readonly KalturaMixEntryOrderBy CREATED_AT_ASC = new KalturaMixEntryOrderBy("+createdAt");
		public static readonly KalturaMixEntryOrderBy CREATED_AT_DESC = new KalturaMixEntryOrderBy("-createdAt");
		public static readonly KalturaMixEntryOrderBy UPDATED_AT_ASC = new KalturaMixEntryOrderBy("+updatedAt");
		public static readonly KalturaMixEntryOrderBy UPDATED_AT_DESC = new KalturaMixEntryOrderBy("-updatedAt");
		public static readonly KalturaMixEntryOrderBy RANK_ASC = new KalturaMixEntryOrderBy("+rank");
		public static readonly KalturaMixEntryOrderBy RANK_DESC = new KalturaMixEntryOrderBy("-rank");
		public static readonly KalturaMixEntryOrderBy START_DATE_ASC = new KalturaMixEntryOrderBy("+startDate");
		public static readonly KalturaMixEntryOrderBy START_DATE_DESC = new KalturaMixEntryOrderBy("-startDate");
		public static readonly KalturaMixEntryOrderBy END_DATE_ASC = new KalturaMixEntryOrderBy("+endDate");
		public static readonly KalturaMixEntryOrderBy END_DATE_DESC = new KalturaMixEntryOrderBy("-endDate");
		public static readonly KalturaMixEntryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaMixEntryOrderBy("+partnerSortValue");
		public static readonly KalturaMixEntryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaMixEntryOrderBy("-partnerSortValue");

		private KalturaMixEntryOrderBy(string name) : base(name) { }
	}
}
