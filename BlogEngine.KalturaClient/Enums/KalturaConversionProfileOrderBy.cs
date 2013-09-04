namespace Kaltura
{
	public sealed class KalturaConversionProfileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaConversionProfileOrderBy CREATED_AT_ASC = new KalturaConversionProfileOrderBy("+createdAt");
		public static readonly KalturaConversionProfileOrderBy CREATED_AT_DESC = new KalturaConversionProfileOrderBy("-createdAt");

		private KalturaConversionProfileOrderBy(string name) : base(name) { }
	}
}
