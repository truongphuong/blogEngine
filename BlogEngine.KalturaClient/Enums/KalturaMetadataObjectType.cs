namespace Kaltura
{
	public sealed class KalturaMetadataObjectType : KalturaStringEnum
	{
		public static readonly KalturaMetadataObjectType ENTRY = new KalturaMetadataObjectType("1");
		public static readonly KalturaMetadataObjectType ANNOTATION = new KalturaMetadataObjectType("annotationMetadata.Annotation");
		public static readonly KalturaMetadataObjectType AD_CUE_POINT = new KalturaMetadataObjectType("adCuePointMetadata.AdCuePoint");
		public static readonly KalturaMetadataObjectType CODE_CUE_POINT = new KalturaMetadataObjectType("codeCuePointMetadata.CodeCuePoint");

		private KalturaMetadataObjectType(string name) : base(name) { }
	}
}
