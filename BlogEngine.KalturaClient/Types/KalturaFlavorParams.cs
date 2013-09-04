using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFlavorParams : KalturaAssetParams
	{
		#region Private Fields
		private KalturaVideoCodec _VideoCodec = null;
		private int _VideoBitrate = Int32.MinValue;
		private KalturaAudioCodec _AudioCodec = null;
		private int _AudioBitrate = Int32.MinValue;
		private int _AudioChannels = Int32.MinValue;
		private int _AudioSampleRate = Int32.MinValue;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		private int _FrameRate = Int32.MinValue;
		private int _GopSize = Int32.MinValue;
		private string _ConversionEngines = null;
		private string _ConversionEnginesExtraParams = null;
		private bool? _TwoPass = false;
		private int _Deinterlice = Int32.MinValue;
		private int _Rotate = Int32.MinValue;
		private string _Operators = null;
		private int _EngineVersion = Int32.MinValue;
		private KalturaContainerFormat _Format = null;
		#endregion

		#region Properties
		public KalturaVideoCodec VideoCodec
		{
			get { return _VideoCodec; }
			set 
			{ 
				_VideoCodec = value;
				OnPropertyChanged("VideoCodec");
			}
		}
		public int VideoBitrate
		{
			get { return _VideoBitrate; }
			set 
			{ 
				_VideoBitrate = value;
				OnPropertyChanged("VideoBitrate");
			}
		}
		public KalturaAudioCodec AudioCodec
		{
			get { return _AudioCodec; }
			set 
			{ 
				_AudioCodec = value;
				OnPropertyChanged("AudioCodec");
			}
		}
		public int AudioBitrate
		{
			get { return _AudioBitrate; }
			set 
			{ 
				_AudioBitrate = value;
				OnPropertyChanged("AudioBitrate");
			}
		}
		public int AudioChannels
		{
			get { return _AudioChannels; }
			set 
			{ 
				_AudioChannels = value;
				OnPropertyChanged("AudioChannels");
			}
		}
		public int AudioSampleRate
		{
			get { return _AudioSampleRate; }
			set 
			{ 
				_AudioSampleRate = value;
				OnPropertyChanged("AudioSampleRate");
			}
		}
		public int Width
		{
			get { return _Width; }
			set 
			{ 
				_Width = value;
				OnPropertyChanged("Width");
			}
		}
		public int Height
		{
			get { return _Height; }
			set 
			{ 
				_Height = value;
				OnPropertyChanged("Height");
			}
		}
		public int FrameRate
		{
			get { return _FrameRate; }
			set 
			{ 
				_FrameRate = value;
				OnPropertyChanged("FrameRate");
			}
		}
		public int GopSize
		{
			get { return _GopSize; }
			set 
			{ 
				_GopSize = value;
				OnPropertyChanged("GopSize");
			}
		}
		public string ConversionEngines
		{
			get { return _ConversionEngines; }
			set 
			{ 
				_ConversionEngines = value;
				OnPropertyChanged("ConversionEngines");
			}
		}
		public string ConversionEnginesExtraParams
		{
			get { return _ConversionEnginesExtraParams; }
			set 
			{ 
				_ConversionEnginesExtraParams = value;
				OnPropertyChanged("ConversionEnginesExtraParams");
			}
		}
		public bool? TwoPass
		{
			get { return _TwoPass; }
			set 
			{ 
				_TwoPass = value;
				OnPropertyChanged("TwoPass");
			}
		}
		public int Deinterlice
		{
			get { return _Deinterlice; }
			set 
			{ 
				_Deinterlice = value;
				OnPropertyChanged("Deinterlice");
			}
		}
		public int Rotate
		{
			get { return _Rotate; }
			set 
			{ 
				_Rotate = value;
				OnPropertyChanged("Rotate");
			}
		}
		public string Operators
		{
			get { return _Operators; }
			set 
			{ 
				_Operators = value;
				OnPropertyChanged("Operators");
			}
		}
		public int EngineVersion
		{
			get { return _EngineVersion; }
			set 
			{ 
				_EngineVersion = value;
				OnPropertyChanged("EngineVersion");
			}
		}
		public KalturaContainerFormat Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		#endregion

		#region CTor
		public KalturaFlavorParams()
		{
		}

		public KalturaFlavorParams(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "videoCodec":
						this.VideoCodec = (KalturaVideoCodec)KalturaStringEnum.Parse(typeof(KalturaVideoCodec), txt);
						continue;
					case "videoBitrate":
						this.VideoBitrate = ParseInt(txt);
						continue;
					case "audioCodec":
						this.AudioCodec = (KalturaAudioCodec)KalturaStringEnum.Parse(typeof(KalturaAudioCodec), txt);
						continue;
					case "audioBitrate":
						this.AudioBitrate = ParseInt(txt);
						continue;
					case "audioChannels":
						this.AudioChannels = ParseInt(txt);
						continue;
					case "audioSampleRate":
						this.AudioSampleRate = ParseInt(txt);
						continue;
					case "width":
						this.Width = ParseInt(txt);
						continue;
					case "height":
						this.Height = ParseInt(txt);
						continue;
					case "frameRate":
						this.FrameRate = ParseInt(txt);
						continue;
					case "gopSize":
						this.GopSize = ParseInt(txt);
						continue;
					case "conversionEngines":
						this.ConversionEngines = txt;
						continue;
					case "conversionEnginesExtraParams":
						this.ConversionEnginesExtraParams = txt;
						continue;
					case "twoPass":
						this.TwoPass = ParseBool(txt);
						continue;
					case "deinterlice":
						this.Deinterlice = ParseInt(txt);
						continue;
					case "rotate":
						this.Rotate = ParseInt(txt);
						continue;
					case "operators":
						this.Operators = txt;
						continue;
					case "engineVersion":
						this.EngineVersion = ParseInt(txt);
						continue;
					case "format":
						this.Format = (KalturaContainerFormat)KalturaStringEnum.Parse(typeof(KalturaContainerFormat), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringEnumIfNotNull("videoCodec", this.VideoCodec);
			kparams.AddIntIfNotNull("videoBitrate", this.VideoBitrate);
			kparams.AddStringEnumIfNotNull("audioCodec", this.AudioCodec);
			kparams.AddIntIfNotNull("audioBitrate", this.AudioBitrate);
			kparams.AddIntIfNotNull("audioChannels", this.AudioChannels);
			kparams.AddIntIfNotNull("audioSampleRate", this.AudioSampleRate);
			kparams.AddIntIfNotNull("width", this.Width);
			kparams.AddIntIfNotNull("height", this.Height);
			kparams.AddIntIfNotNull("frameRate", this.FrameRate);
			kparams.AddIntIfNotNull("gopSize", this.GopSize);
			kparams.AddStringIfNotNull("conversionEngines", this.ConversionEngines);
			kparams.AddStringIfNotNull("conversionEnginesExtraParams", this.ConversionEnginesExtraParams);
			kparams.AddBoolIfNotNull("twoPass", this.TwoPass);
			kparams.AddIntIfNotNull("deinterlice", this.Deinterlice);
			kparams.AddIntIfNotNull("rotate", this.Rotate);
			kparams.AddStringIfNotNull("operators", this.Operators);
			kparams.AddIntIfNotNull("engineVersion", this.EngineVersion);
			kparams.AddStringEnumIfNotNull("format", this.Format);
			return kparams;
		}
		#endregion
	}
}

