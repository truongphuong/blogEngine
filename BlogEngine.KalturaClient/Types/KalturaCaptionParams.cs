using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaCaptionParams : KalturaAssetParams
	{
		#region Private Fields
		private KalturaLanguage _Language = null;
		private KalturaNullableBoolean _IsDefault = (KalturaNullableBoolean)Int32.MinValue;
		private string _Label = null;
		private KalturaCaptionType _Format = null;
		private int _SourceParamsId = Int32.MinValue;
		#endregion

		#region Properties
		public KalturaLanguage Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
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
		public int SourceParamsId
		{
			get { return _SourceParamsId; }
			set 
			{ 
				_SourceParamsId = value;
				OnPropertyChanged("SourceParamsId");
			}
		}
		#endregion

		#region CTor
		public KalturaCaptionParams()
		{
		}

		public KalturaCaptionParams(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "language":
						this.Language = (KalturaLanguage)KalturaStringEnum.Parse(typeof(KalturaLanguage), txt);
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
					case "sourceParamsId":
						this.SourceParamsId = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringEnumIfNotNull("language", this.Language);
			kparams.AddEnumIfNotNull("isDefault", this.IsDefault);
			kparams.AddStringIfNotNull("label", this.Label);
			kparams.AddStringEnumIfNotNull("format", this.Format);
			kparams.AddIntIfNotNull("sourceParamsId", this.SourceParamsId);
			return kparams;
		}
		#endregion
	}
}

