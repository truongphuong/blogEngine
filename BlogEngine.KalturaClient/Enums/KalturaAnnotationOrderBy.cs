namespace Kaltura
{
	public sealed class KalturaAnnotationOrderBy : KalturaStringEnum
	{
		public static readonly KalturaAnnotationOrderBy END_TIME_ASC = new KalturaAnnotationOrderBy("+endTime");
		public static readonly KalturaAnnotationOrderBy END_TIME_DESC = new KalturaAnnotationOrderBy("-endTime");
		public static readonly KalturaAnnotationOrderBy DURATION_ASC = new KalturaAnnotationOrderBy("+duration");
		public static readonly KalturaAnnotationOrderBy DURATION_DESC = new KalturaAnnotationOrderBy("-duration");
		public static readonly KalturaAnnotationOrderBy CREATED_AT_ASC = new KalturaAnnotationOrderBy("+createdAt");
		public static readonly KalturaAnnotationOrderBy CREATED_AT_DESC = new KalturaAnnotationOrderBy("-createdAt");
		public static readonly KalturaAnnotationOrderBy UPDATED_AT_ASC = new KalturaAnnotationOrderBy("+updatedAt");
		public static readonly KalturaAnnotationOrderBy UPDATED_AT_DESC = new KalturaAnnotationOrderBy("-updatedAt");
		public static readonly KalturaAnnotationOrderBy START_TIME_ASC = new KalturaAnnotationOrderBy("+startTime");
		public static readonly KalturaAnnotationOrderBy START_TIME_DESC = new KalturaAnnotationOrderBy("-startTime");
		public static readonly KalturaAnnotationOrderBy PARTNER_SORT_VALUE_ASC = new KalturaAnnotationOrderBy("+partnerSortValue");
		public static readonly KalturaAnnotationOrderBy PARTNER_SORT_VALUE_DESC = new KalturaAnnotationOrderBy("-partnerSortValue");

		private KalturaAnnotationOrderBy(string name) : base(name) { }
	}
}
