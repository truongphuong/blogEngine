namespace Kaltura
{
	public sealed class KalturaCodeCuePointOrderBy : KalturaStringEnum
	{
		public static readonly KalturaCodeCuePointOrderBy CREATED_AT_ASC = new KalturaCodeCuePointOrderBy("+createdAt");
		public static readonly KalturaCodeCuePointOrderBy CREATED_AT_DESC = new KalturaCodeCuePointOrderBy("-createdAt");
		public static readonly KalturaCodeCuePointOrderBy UPDATED_AT_ASC = new KalturaCodeCuePointOrderBy("+updatedAt");
		public static readonly KalturaCodeCuePointOrderBy UPDATED_AT_DESC = new KalturaCodeCuePointOrderBy("-updatedAt");
		public static readonly KalturaCodeCuePointOrderBy START_TIME_ASC = new KalturaCodeCuePointOrderBy("+startTime");
		public static readonly KalturaCodeCuePointOrderBy START_TIME_DESC = new KalturaCodeCuePointOrderBy("-startTime");
		public static readonly KalturaCodeCuePointOrderBy PARTNER_SORT_VALUE_ASC = new KalturaCodeCuePointOrderBy("+partnerSortValue");
		public static readonly KalturaCodeCuePointOrderBy PARTNER_SORT_VALUE_DESC = new KalturaCodeCuePointOrderBy("-partnerSortValue");

		private KalturaCodeCuePointOrderBy(string name) : base(name) { }
	}
}
