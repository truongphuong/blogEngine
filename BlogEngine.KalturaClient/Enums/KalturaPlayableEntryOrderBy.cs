namespace Kaltura
{
	public sealed class KalturaPlayableEntryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaPlayableEntryOrderBy PLAYS_ASC = new KalturaPlayableEntryOrderBy("+plays");
		public static readonly KalturaPlayableEntryOrderBy PLAYS_DESC = new KalturaPlayableEntryOrderBy("-plays");
		public static readonly KalturaPlayableEntryOrderBy VIEWS_ASC = new KalturaPlayableEntryOrderBy("+views");
		public static readonly KalturaPlayableEntryOrderBy VIEWS_DESC = new KalturaPlayableEntryOrderBy("-views");
		public static readonly KalturaPlayableEntryOrderBy DURATION_ASC = new KalturaPlayableEntryOrderBy("+duration");
		public static readonly KalturaPlayableEntryOrderBy DURATION_DESC = new KalturaPlayableEntryOrderBy("-duration");
		public static readonly KalturaPlayableEntryOrderBy MS_DURATION_ASC = new KalturaPlayableEntryOrderBy("+msDuration");
		public static readonly KalturaPlayableEntryOrderBy MS_DURATION_DESC = new KalturaPlayableEntryOrderBy("-msDuration");
		public static readonly KalturaPlayableEntryOrderBy NAME_ASC = new KalturaPlayableEntryOrderBy("+name");
		public static readonly KalturaPlayableEntryOrderBy NAME_DESC = new KalturaPlayableEntryOrderBy("-name");
		public static readonly KalturaPlayableEntryOrderBy MODERATION_COUNT_ASC = new KalturaPlayableEntryOrderBy("+moderationCount");
		public static readonly KalturaPlayableEntryOrderBy MODERATION_COUNT_DESC = new KalturaPlayableEntryOrderBy("-moderationCount");
		public static readonly KalturaPlayableEntryOrderBy CREATED_AT_ASC = new KalturaPlayableEntryOrderBy("+createdAt");
		public static readonly KalturaPlayableEntryOrderBy CREATED_AT_DESC = new KalturaPlayableEntryOrderBy("-createdAt");
		public static readonly KalturaPlayableEntryOrderBy UPDATED_AT_ASC = new KalturaPlayableEntryOrderBy("+updatedAt");
		public static readonly KalturaPlayableEntryOrderBy UPDATED_AT_DESC = new KalturaPlayableEntryOrderBy("-updatedAt");
		public static readonly KalturaPlayableEntryOrderBy RANK_ASC = new KalturaPlayableEntryOrderBy("+rank");
		public static readonly KalturaPlayableEntryOrderBy RANK_DESC = new KalturaPlayableEntryOrderBy("-rank");
		public static readonly KalturaPlayableEntryOrderBy START_DATE_ASC = new KalturaPlayableEntryOrderBy("+startDate");
		public static readonly KalturaPlayableEntryOrderBy START_DATE_DESC = new KalturaPlayableEntryOrderBy("-startDate");
		public static readonly KalturaPlayableEntryOrderBy END_DATE_ASC = new KalturaPlayableEntryOrderBy("+endDate");
		public static readonly KalturaPlayableEntryOrderBy END_DATE_DESC = new KalturaPlayableEntryOrderBy("-endDate");
		public static readonly KalturaPlayableEntryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaPlayableEntryOrderBy("+partnerSortValue");
		public static readonly KalturaPlayableEntryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaPlayableEntryOrderBy("-partnerSortValue");

		private KalturaPlayableEntryOrderBy(string name) : base(name) { }
	}
}
