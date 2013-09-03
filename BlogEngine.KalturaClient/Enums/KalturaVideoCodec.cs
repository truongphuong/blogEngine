namespace Kaltura
{
	public sealed class KalturaVideoCodec : KalturaStringEnum
	{
		public static readonly KalturaVideoCodec NONE = new KalturaVideoCodec("");
		public static readonly KalturaVideoCodec VP6 = new KalturaVideoCodec("vp6");
		public static readonly KalturaVideoCodec H263 = new KalturaVideoCodec("h263");
		public static readonly KalturaVideoCodec H264 = new KalturaVideoCodec("h264");
		public static readonly KalturaVideoCodec H264B = new KalturaVideoCodec("h264b");
		public static readonly KalturaVideoCodec H264M = new KalturaVideoCodec("h264m");
		public static readonly KalturaVideoCodec H264H = new KalturaVideoCodec("h264h");
		public static readonly KalturaVideoCodec FLV = new KalturaVideoCodec("flv");
		public static readonly KalturaVideoCodec MPEG4 = new KalturaVideoCodec("mpeg4");
		public static readonly KalturaVideoCodec THEORA = new KalturaVideoCodec("theora");
		public static readonly KalturaVideoCodec WMV2 = new KalturaVideoCodec("wmv2");
		public static readonly KalturaVideoCodec WMV3 = new KalturaVideoCodec("wmv3");
		public static readonly KalturaVideoCodec WVC1A = new KalturaVideoCodec("wvc1a");
		public static readonly KalturaVideoCodec VP8 = new KalturaVideoCodec("vp8");
		public static readonly KalturaVideoCodec MPEG2 = new KalturaVideoCodec("mpeg2");
		public static readonly KalturaVideoCodec COPY = new KalturaVideoCodec("copy");

		private KalturaVideoCodec(string name) : base(name) { }
	}
}
