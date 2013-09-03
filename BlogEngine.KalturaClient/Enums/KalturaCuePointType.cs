namespace Kaltura
{
	public sealed class KalturaCuePointType : KalturaStringEnum
	{
		public static readonly KalturaCuePointType ANNOTATION = new KalturaCuePointType("annotation.Annotation");
		public static readonly KalturaCuePointType AD = new KalturaCuePointType("adCuePoint.Ad");
		public static readonly KalturaCuePointType CODE = new KalturaCuePointType("codeCuePoint.Code");

		private KalturaCuePointType(string name) : base(name) { }
	}
}
