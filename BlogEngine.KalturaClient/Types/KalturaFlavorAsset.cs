using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFlavorAsset : KalturaAsset
	{
		#region Private Fields
		private int _FlavorParamsId = Int32.MinValue;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		private int _Bitrate = Int32.MinValue;
		private int _FrameRate = Int32.MinValue;
		private bool? _IsOriginal = false;
		private bool? _IsWeb = false;
		private string _ContainerFormat = null;
		private string _VideoCodecId = null;
		private KalturaFlavorAssetStatus _Status = (KalturaFlavorAssetStatus)Int32.MinValue;
		#endregion

		#region Properties
		public int FlavorParamsId
		{
			get { return _FlavorParamsId; }
			set 
			{ 
				_FlavorParamsId = value;
				OnPropertyChanged("FlavorParamsId");
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
		public int Bitrate
		{
			get { return _Bitrate; }
			set 
			{ 
				_Bitrate = value;
				OnPropertyChanged("Bitrate");
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
		public bool? IsOriginal
		{
			get { return _IsOriginal; }
			set 
			{ 
				_IsOriginal = value;
				OnPropertyChanged("IsOriginal");
			}
		}
		public bool? IsWeb
		{
			get { return _IsWeb; }
			set 
			{ 
				_IsWeb = value;
				OnPropertyChanged("IsWeb");
			}
		}
		public string ContainerFormat
		{
			get { return _ContainerFormat; }
			set 
			{ 
				_ContainerFormat = value;
				OnPropertyChanged("ContainerFormat");
			}
		}
		public string VideoCodecId
		{
			get { return _VideoCodecId; }
			set 
			{ 
				_VideoCodecId = value;
				OnPropertyChanged("VideoCodecId");
			}
		}
		public KalturaFlavorAssetStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		#endregion

		#region CTor
		public KalturaFlavorAsset()
		{
		}

		public KalturaFlavorAsset(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "flavorParamsId":
						this.FlavorParamsId = ParseInt(txt);
						continue;
					case "width":
						this.Width = ParseInt(txt);
						continue;
					case "height":
						this.Height = ParseInt(txt);
						continue;
					case "bitrate":
						this.Bitrate = ParseInt(txt);
						continue;
					case "frameRate":
						this.FrameRate = ParseInt(txt);
						continue;
					case "isOriginal":
						this.IsOriginal = ParseBool(txt);
						continue;
					case "isWeb":
						this.IsWeb = ParseBool(txt);
						continue;
					case "containerFormat":
						this.ContainerFormat = txt;
						continue;
					case "videoCodecId":
						this.VideoCodecId = txt;
						continue;
					case "status":
						this.Status = (KalturaFlavorAssetStatus)ParseEnum(typeof(KalturaFlavorAssetStatus), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("flavorParamsId", this.FlavorParamsId);
			kparams.AddIntIfNotNull("width", this.Width);
			kparams.AddIntIfNotNull("height", this.Height);
			kparams.AddIntIfNotNull("bitrate", this.Bitrate);
			kparams.AddIntIfNotNull("frameRate", this.FrameRate);
			kparams.AddBoolIfNotNull("isOriginal", this.IsOriginal);
			kparams.AddBoolIfNotNull("isWeb", this.IsWeb);
			kparams.AddStringIfNotNull("containerFormat", this.ContainerFormat);
			kparams.AddStringIfNotNull("videoCodecId", this.VideoCodecId);
			kparams.AddEnumIfNotNull("status", this.Status);
			return kparams;
		}
		#endregion
	}
}

