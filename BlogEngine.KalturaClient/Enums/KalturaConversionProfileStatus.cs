namespace Kaltura
{
	public sealed class KalturaConversionProfileStatus : KalturaStringEnum
	{
		public static readonly KalturaConversionProfileStatus DISABLED = new KalturaConversionProfileStatus("1");
		public static readonly KalturaConversionProfileStatus ENABLED = new KalturaConversionProfileStatus("2");
		public static readonly KalturaConversionProfileStatus DELETED = new KalturaConversionProfileStatus("3");

		private KalturaConversionProfileStatus(string name) : base(name) { }
	}
}
