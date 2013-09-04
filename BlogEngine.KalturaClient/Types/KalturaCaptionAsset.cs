using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaCaptionAsset : KalturaAsset
	{
		#region Private Fields
		private int _CaptionParamsId = Int32.MinValue;
		private KalturaLanguage _Language = null;
		private KalturaLanguageCode _LanguageCode = null;
		private KalturaNullableBoolean _IsDefault = (KalturaNullableBoolean)Int32.MinValue;
		private string _Label = null;
		private KalturaCaptionType _Format = null;
		private KalturaCaptionAssetStatus _Status = (KalturaCaptionAssetStatus)Int32.MinValue;
		#endregion

		#region Properties
		public int CaptionParamsId
		{
			get { return _CaptionParamsId; }
			set 
			{ 
				_CaptionParamsId = value;
				OnPropertyChanged("CaptionParamsId");
			}
		}
		public KalturaLanguage Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		public KalturaLanguageCode LanguageCode
		{
			get { return _LanguageCode; }
			set 
			{ 
				_LanguageCode = value;
				OnPropertyChanged("LanguageCode");
			}
		}
		public KalturaNullableBoolean IsDefault
		{
			get { return _IsDefault; }
			set 
			{ 
				_IsDefault = value;
				OnPropertyChanged("IsDefault");
			}
		}
		public string Label
		{
			get { return _Label; }
			set 
			{ 
				_Label = value;
				OnPropertyChanged("Label");
			}
		}
		public KalturaCaptionType Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		public KalturaCaptionAssetStatus Status
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
		public KalturaCaptionAsset()
		{
		}

		public KalturaCaptionAsset(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "captionParamsId":
						this.CaptionParamsId = ParseInt(txt);
						continue;
					case "language":
						this.Language = (KalturaLanguage)KalturaStringEnum.Parse(typeof(KalturaLanguage), txt);
						continue;
					case "languageCode":
						this.LanguageCode = (KalturaLanguageCode)KalturaStringEnum.Parse(typeof(KalturaLanguageCode), txt);
						continue;
					case "isDefault":
						this.IsDefault = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "label":
						this.Label = txt;
						continue;
					case "format":
						this.Format = (KalturaCaptionType)KalturaStringEnum.Parse(typeof(KalturaCaptionType), txt);
						continue;
					case "status":
						this.Status = (KalturaCaptionAssetStatus)ParseEnum(typeof(KalturaCaptionAssetStatus), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("captionParamsId", this.CaptionParamsId);
			kparams.AddStringEnumIfNotNull("language", this.Language);
			kparams.AddStringEnumIfNotNull("languageCode", this.LanguageCode);
			kparams.AddEnumIfNotNull("isDefault", this.IsDefault);
			kparams.AddStringIfNotNull("label", this.Label);
			kparams.AddStringEnumIfNotNull("format", this.Format);
			kparams.AddEnumIfNotNull("status", this.Status);
			return kparams;
		}
		#endregion
	}
}

