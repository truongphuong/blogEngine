namespace Kaltura
{
	public sealed class KalturaDurationType : KalturaStringEnum
	{
		public static readonly KalturaDurationType NOT_AVAILABLE = new KalturaDurationType("notavailable");
		public static readonly KalturaDurationType SHORT = new KalturaDurationType("short");
		public static readonly KalturaDurationType MEDIUM = new KalturaDurationType("medium");
		public static readonly KalturaDurationType LONG = new KalturaDurationType("long");

		private KalturaDurationType(string name) : base(name) { }
	}
}
