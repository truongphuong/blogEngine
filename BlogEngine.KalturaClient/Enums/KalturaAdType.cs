namespace Kaltura
{
	public sealed class KalturaAdType : KalturaStringEnum
	{
		public static readonly KalturaAdType VIDEO = new KalturaAdType("1");
		public static readonly KalturaAdType OVERLAY = new KalturaAdType("2");

		private KalturaAdType(string name) : base(name) { }
	}
}
