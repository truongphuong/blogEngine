using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaThumbParams : KalturaAssetParams
	{
		#region Private Fields
		private KalturaThumbCropType _CropType = (KalturaThumbCropType)Int32.MinValue;
		private int _Quality = Int32.MinValue;
		private int _CropX = Int32.MinValue;
		private int _CropY = Int32.MinValue;
		private int _CropWidth = Int32.MinValue;
		private int _CropHeight = Int32.MinValue;
		private float _VideoOffset = Single.MinValue;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		private float _ScaleWidth = Single.MinValue;
		private float _ScaleHeight = Single.MinValue;
		private string _BackgroundColor = null;
		private int _SourceParamsId = Int32.MinValue;
		private KalturaContainerFormat _Format = null;
		#endregion

		#region Properties
		public KalturaThumbCropType CropType
		{
			get { return _CropType; }
			set 
			{ 
				_CropType = value;
				OnPropertyChanged("CropType");
			}
		}
		public int Quality
		{
			get { return _Quality; }
			set 
			{ 
				_Quality = value;
				OnPropertyChanged("Quality");
			}
		}
		public int CropX
		{
			get { return _CropX; }
			set 
			{ 
				_CropX = value;
				OnPropertyChanged("CropX");
			}
		}
		public int CropY
		{
			get { return _CropY; }
			set 
			{ 
				_CropY = value;
				OnPropertyChanged("CropY");
			}
		}
		public int CropWidth
		{
			get { return _CropWidth; }
			set 
			{ 
				_CropWidth = value;
				OnPropertyChanged("CropWidth");
			}
		}
		public int CropHeight
		{
			get { return _CropHeight; }
			set 
			{ 
				_CropHeight = value;
				OnPropertyChanged("CropHeight");
			}
		}
		public float VideoOffset
		{
			get { return _VideoOffset; }
			set 
			{ 
				_VideoOffset = value;
				OnPropertyChanged("VideoOffset");
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
		public float ScaleWidth
		{
			get { return _ScaleWidth; }
			set 
			{ 
				_ScaleWidth = value;
				OnPropertyChanged("ScaleWidth");
			}
		}
		public float ScaleHeight
		{
			get { return _ScaleHeight; }
			set 
			{ 
				_ScaleHeight = value;
				OnPropertyChanged("ScaleHeight");
			}
		}
		public string BackgroundColor
		{
			get { return _BackgroundColor; }
			set 
			{ 
				_BackgroundColor = value;
				OnPropertyChanged("BackgroundColor");
			}
		}
		public int SourceParamsId
		{
			get { return _SourceParamsId; }
			set 
			{ 
				_SourceParamsId = value;
				OnPropertyChanged("SourceParamsId");
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
		public KalturaThumbParams()
		{
		}

		public KalturaThumbParams(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "cropType":
						this.CropType = (KalturaThumbCropType)ParseEnum(typeof(KalturaThumbCropType), txt);
						continue;
					case "quality":
						this.Quality = ParseInt(txt);
						continue;
					case "cropX":
						this.CropX = ParseInt(txt);
						continue;
					case "cropY":
						this.CropY = ParseInt(txt);
						continue;
					case "cropWidth":
						this.CropWidth = ParseInt(txt);
						continue;
					case "cropHeight":
						this.CropHeight = ParseInt(txt);
						continue;
					case "videoOffset":
						this.VideoOffset = ParseFloat(txt);
						continue;
					case "width":
						this.Width = ParseInt(txt);
						continue;
					case "height":
						this.Height = ParseInt(txt);
						continue;
					case "scaleWidth":
						this.ScaleWidth = ParseFloat(txt);
						continue;
					case "scaleHeight":
						this.ScaleHeight = ParseFloat(txt);
						continue;
					case "backgroundColor":
						this.BackgroundColor = txt;
						continue;
					case "sourceParamsId":
						this.SourceParamsId = ParseInt(txt);
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
			kparams.AddEnumIfNotNull("cropType", this.CropType);
			kparams.AddIntIfNotNull("quality", this.Quality);
			kparams.AddIntIfNotNull("cropX", this.CropX);
			kparams.AddIntIfNotNull("cropY", this.CropY);
			kparams.AddIntIfNotNull("cropWidth", this.CropWidth);
			kparams.AddIntIfNotNull("cropHeight", this.CropHeight);
			kparams.AddFloatIfNotNull("videoOffset", this.VideoOffset);
			kparams.AddIntIfNotNull("width", this.Width);
			kparams.AddIntIfNotNull("height", this.Height);
			kparams.AddFloatIfNotNull("scaleWidth", this.ScaleWidth);
			kparams.AddFloatIfNotNull("scaleHeight", this.ScaleHeight);
			kparams.AddStringIfNotNull("backgroundColor", this.BackgroundColor);
			kparams.AddIntIfNotNull("sourceParamsId", this.SourceParamsId);
			kparams.AddStringEnumIfNotNull("format", this.Format);
			return kparams;
		}
		#endregion
	}
}

