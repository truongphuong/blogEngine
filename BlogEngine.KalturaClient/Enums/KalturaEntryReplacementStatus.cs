namespace Kaltura
{
	public sealed class KalturaEntryReplacementStatus : KalturaStringEnum
	{
		public static readonly KalturaEntryReplacementStatus NONE = new KalturaEntryReplacementStatus("0");
		public static readonly KalturaEntryReplacementStatus APPROVED_BUT_NOT_READY = new KalturaEntryReplacementStatus("1");
		public static readonly KalturaEntryReplacementStatus READY_BUT_NOT_APPROVED = new KalturaEntryReplacementStatus("2");
		public static readonly KalturaEntryReplacementStatus NOT_READY_AND_NOT_APPROVED = new KalturaEntryReplacementStatus("3");

		private KalturaEntryReplacementStatus(string name) : base(name) { }
	}
}
