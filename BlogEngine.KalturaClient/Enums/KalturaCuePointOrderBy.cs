namespace Kaltura
{
	public sealed class KalturaCuePointOrderBy : KalturaStringEnum
	{
		public static readonly KalturaCuePointOrderBy CREATED_AT_ASC = new KalturaCuePointOrderBy("+createdAt");
		public static readonly KalturaCuePointOrderBy CREATED_AT_DESC = new KalturaCuePointOrderBy("-createdAt");
		public static readonly KalturaCuePointOrderBy UPDATED_AT_ASC = new KalturaCuePointOrderBy("+updatedAt");
		public static readonly KalturaCuePointOrderBy UPDATED_AT_DESC = new KalturaCuePointOrderBy("-updatedAt");
		public static readonly KalturaCuePointOrderBy START_TIME_ASC = new KalturaCuePointOrderBy("+startTime");
		public static readonly KalturaCuePointOrderBy START_TIME_DESC = new KalturaCuePointOrderBy("-startTime");
		public static readonly KalturaCuePointOrderBy PARTNER_SORT_VALUE_ASC = new KalturaCuePointOrderBy("+partnerSortValue");
		public static readonly KalturaCuePointOrderBy PARTNER_SORT_VALUE_DESC = new KalturaCuePointOrderBy("-partnerSortValue");

		private KalturaCuePointOrderBy(string name) : base(name) { }
	}
}
