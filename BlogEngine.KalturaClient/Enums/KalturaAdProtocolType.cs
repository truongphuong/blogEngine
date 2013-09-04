namespace Kaltura
{
	public sealed class KalturaAdProtocolType : KalturaStringEnum
	{
		public static readonly KalturaAdProtocolType CUSTOM = new KalturaAdProtocolType("0");
		public static readonly KalturaAdProtocolType VAST = new KalturaAdProtocolType("1");
		public static readonly KalturaAdProtocolType VAST_2_0 = new KalturaAdProtocolType("2");
		public static readonly KalturaAdProtocolType VPAID = new KalturaAdProtocolType("3");

		private KalturaAdProtocolType(string name) : base(name) { }
	}
}
