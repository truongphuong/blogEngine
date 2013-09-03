namespace Kaltura
{
	public sealed class KalturaCategoryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaCategoryOrderBy DEPTH_ASC = new KalturaCategoryOrderBy("+depth");
		public static readonly KalturaCategoryOrderBy DEPTH_DESC = new KalturaCategoryOrderBy("-depth");
		public static readonly KalturaCategoryOrderBy FULL_NAME_ASC = new KalturaCategoryOrderBy("+fullName");
		public static readonly KalturaCategoryOrderBy FULL_NAME_DESC = new KalturaCategoryOrderBy("-fullName");
		public static readonly KalturaCategoryOrderBy CREATED_AT_ASC = new KalturaCategoryOrderBy("+createdAt");
		public static readonly KalturaCategoryOrderBy CREATED_AT_DESC = new KalturaCategoryOrderBy("-createdAt");

		private KalturaCategoryOrderBy(string name) : base(name) { }
	}
}
