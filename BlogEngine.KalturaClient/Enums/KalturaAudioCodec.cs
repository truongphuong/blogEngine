namespace Kaltura
{
	public sealed class KalturaAudioCodec : KalturaStringEnum
	{
		public static readonly KalturaAudioCodec NONE = new KalturaAudioCodec("");
		public static readonly KalturaAudioCodec MP3 = new KalturaAudioCodec("mp3");
		public static readonly KalturaAudioCodec AAC = new KalturaAudioCodec("aac");
		public static readonly KalturaAudioCodec VORBIS = new KalturaAudioCodec("vorbis");
		public static readonly KalturaAudioCodec WMA = new KalturaAudioCodec("wma");
		public static readonly KalturaAudioCodec AMRNB = new KalturaAudioCodec("amrnb");
		public static readonly KalturaAudioCodec COPY = new KalturaAudioCodec("copy");

		private KalturaAudioCodec(string name) : base(name) { }
	}
}
