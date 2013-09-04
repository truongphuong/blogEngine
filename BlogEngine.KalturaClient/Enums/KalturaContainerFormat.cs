namespace Kaltura
{
	public sealed class KalturaContainerFormat : KalturaStringEnum
	{
		public static readonly KalturaContainerFormat FLV = new KalturaContainerFormat("flv");
		public static readonly KalturaContainerFormat MP4 = new KalturaContainerFormat("mp4");
		public static readonly KalturaContainerFormat AVI = new KalturaContainerFormat("avi");
		public static readonly KalturaContainerFormat MOV = new KalturaContainerFormat("mov");
		public static readonly KalturaContainerFormat MP3 = new KalturaContainerFormat("mp3");
		public static readonly KalturaContainerFormat _3GP = new KalturaContainerFormat("3gp");
		public static readonly KalturaContainerFormat OGG = new KalturaContainerFormat("ogg");
		public static readonly KalturaContainerFormat WMV = new KalturaContainerFormat("wmv");
		public static readonly KalturaContainerFormat WMA = new KalturaContainerFormat("wma");
		public static readonly KalturaContainerFormat ISMV = new KalturaContainerFormat("ismv");
		public static readonly KalturaContainerFormat MKV = new KalturaContainerFormat("mkv");
		public static readonly KalturaContainerFormat WEBM = new KalturaContainerFormat("webm");
		public static readonly KalturaContainerFormat MPEG = new KalturaContainerFormat("mpeg");
		public static readonly KalturaContainerFormat MPEGTS = new KalturaContainerFormat("mpegts");
		public static readonly KalturaContainerFormat APPLEHTTP = new KalturaContainerFormat("applehttp");
		public static readonly KalturaContainerFormat SWF = new KalturaContainerFormat("swf");
		public static readonly KalturaContainerFormat PDF = new KalturaContainerFormat("pdf");
		public static readonly KalturaContainerFormat JPG = new KalturaContainerFormat("jpg");

		private KalturaContainerFormat(string name) : base(name) { }
	}
}
