namespace Kaltura
{
	public sealed class KalturaCaptionType : KalturaStringEnum
	{
		public static readonly KalturaCaptionType SRT = new KalturaCaptionType("1");
		public static readonly KalturaCaptionType DFXP = new KalturaCaptionType("2");

		private KalturaCaptionType(string name) : base(name) { }
	}
}
