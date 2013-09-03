namespace Kaltura
{
	public sealed class KalturaAdCuePointOrderBy : KalturaStringEnum
	{
		public static readonly KalturaAdCuePointOrderBy END_TIME_ASC = new KalturaAdCuePointOrderBy("+endTime");
		public static readonly KalturaAdCuePointOrderBy END_TIME_DESC = new KalturaAdCuePointOrderBy("-endTime");
		public static readonly KalturaAdCuePointOrderBy DURATION_ASC = new KalturaAdCuePointOrderBy("+duration");
		public static readonly KalturaAdCuePointOrderBy DURATION_DESC = new KalturaAdCuePointOrderBy("-duration");
		public static readonly KalturaAdCuePointOrderBy CREATED_AT_ASC = new KalturaAdCuePointOrderBy("+createdAt");
		public static readonly KalturaAdCuePointOrderBy CREATED_AT_DESC = new KalturaAdCuePointOrderBy("-createdAt");
		public static readonly KalturaAdCuePointOrderBy UPDATED_AT_ASC = new KalturaAdCuePointOrderBy("+updatedAt");
		public static readonly KalturaAdCuePointOrderBy UPDATED_AT_DESC = new KalturaAdCuePointOrderBy("-updatedAt");
		public static readonly KalturaAdCuePointOrderBy START_TIME_ASC = new KalturaAdCuePointOrderBy("+startTime");
		public static readonly KalturaAdCuePointOrderBy START_TIME_DESC = new KalturaAdCuePointOrderBy("-startTime");
		public static readonly KalturaAdCuePointOrderBy PARTNER_SORT_VALUE_ASC = new KalturaAdCuePointOrderBy("+partnerSortValue");
		public static readonly KalturaAdCuePointOrderBy PARTNER_SORT_VALUE_DESC = new KalturaAdCuePointOrderBy("-partnerSortValue");

		private KalturaAdCuePointOrderBy(string name) : base(name) { }
	}
}
