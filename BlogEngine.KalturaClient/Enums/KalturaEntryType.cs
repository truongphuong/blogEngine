namespace Kaltura
{
	public sealed class KalturaEntryType : KalturaStringEnum
	{
		public static readonly KalturaEntryType AUTOMATIC = new KalturaEntryType("-1");
		public static readonly KalturaEntryType MEDIA_CLIP = new KalturaEntryType("1");
		public static readonly KalturaEntryType MIX = new KalturaEntryType("2");
		public static readonly KalturaEntryType PLAYLIST = new KalturaEntryType("5");
		public static readonly KalturaEntryType DATA = new KalturaEntryType("6");
		public static readonly KalturaEntryType LIVE_STREAM = new KalturaEntryType("7");
		public static readonly KalturaEntryType DOCUMENT = new KalturaEntryType("10");

		private KalturaEntryType(string name) : base(name) { }
	}
}
