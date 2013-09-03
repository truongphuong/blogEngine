namespace Kaltura
{
	public sealed class KalturaEntryStatus : KalturaStringEnum
	{
		public static readonly KalturaEntryStatus ERROR_IMPORTING = new KalturaEntryStatus("-2");
		public static readonly KalturaEntryStatus ERROR_CONVERTING = new KalturaEntryStatus("-1");
		public static readonly KalturaEntryStatus IMPORT = new KalturaEntryStatus("0");
		public static readonly KalturaEntryStatus PRECONVERT = new KalturaEntryStatus("1");
		public static readonly KalturaEntryStatus READY = new KalturaEntryStatus("2");
		public static readonly KalturaEntryStatus DELETED = new KalturaEntryStatus("3");
		public static readonly KalturaEntryStatus PENDING = new KalturaEntryStatus("4");
		public static readonly KalturaEntryStatus MODERATE = new KalturaEntryStatus("5");
		public static readonly KalturaEntryStatus BLOCKED = new KalturaEntryStatus("6");
		public static readonly KalturaEntryStatus NO_CONTENT = new KalturaEntryStatus("7");
		public static readonly KalturaEntryStatus INFECTED = new KalturaEntryStatus("virusScan.Infected");

		private KalturaEntryStatus(string name) : base(name) { }
	}
}
