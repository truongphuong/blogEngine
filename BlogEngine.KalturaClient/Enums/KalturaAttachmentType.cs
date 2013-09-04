namespace Kaltura
{
	public sealed class KalturaAttachmentType : KalturaStringEnum
	{
		public static readonly KalturaAttachmentType TEXT = new KalturaAttachmentType("1");
		public static readonly KalturaAttachmentType MEDIA = new KalturaAttachmentType("2");
		public static readonly KalturaAttachmentType DOCUMENT = new KalturaAttachmentType("3");

		private KalturaAttachmentType(string name) : base(name) { }
	}
}
