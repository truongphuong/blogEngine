using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaConversionProfileAssetParamsBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _ConversionProfileIdEqual = Int32.MinValue;
		private string _ConversionProfileIdIn = null;
		private int _AssetParamsIdEqual = Int32.MinValue;
		private string _AssetParamsIdIn = null;
		private KalturaFlavorReadyBehaviorType _ReadyBehaviorEqual = (KalturaFlavorReadyBehaviorType)Int32.MinValue;
		private string _ReadyBehaviorIn = null;
		private KalturaAssetParamsOrigin _OriginEqual = (KalturaAssetParamsOrigin)Int32.MinValue;
		private string _OriginIn = null;
		private string _SystemNameEqual = null;
		private string _SystemNameIn = null;
		#endregion

		#region Properties
		public int ConversionProfileIdEqual
		{
			get { return _ConversionProfileIdEqual; }
			set 
			{ 
				_ConversionProfileIdEqual = value;
				OnPropertyChanged("ConversionProfileIdEqual");
			}
		}
		public string ConversionProfileIdIn
		{
			get { return _ConversionProfileIdIn; }
			set 
			{ 
				_ConversionProfileIdIn = value;
				OnPropertyChanged("ConversionProfileIdIn");
			}
		}
		public int AssetParamsIdEqual
		{
			get { return _AssetParamsIdEqual; }
			set 
			{ 
				_AssetParamsIdEqual = value;
				OnPropertyChanged("AssetParamsIdEqual");
			}
		}
		public string AssetParamsIdIn
		{
			get { return _AssetParamsIdIn; }
			set 
			{ 
				_AssetParamsIdIn = value;
				OnPropertyChanged("AssetParamsIdIn");
			}
		}
		public KalturaFlavorReadyBehaviorType ReadyBehaviorEqual
		{
			get { return _ReadyBehaviorEqual; }
			set 
			{ 
				_ReadyBehaviorEqual = value;
				OnPropertyChanged("ReadyBehaviorEqual");
			}
		}
		public string ReadyBehaviorIn
		{
			get { return _ReadyBehaviorIn; }
			set 
			{ 
				_ReadyBehaviorIn = value;
				OnPropertyChanged("ReadyBehaviorIn");
			}
		}
		public KalturaAssetParamsOrigin OriginEqual
		{
			get { return _OriginEqual; }
			set 
			{ 
				_OriginEqual = value;
				OnPropertyChanged("OriginEqual");
			}
		}
		public string OriginIn
		{
			get { return _OriginIn; }
			set 
			{ 
				_OriginIn = value;
				OnPropertyChanged("OriginIn");
			}
		}
		public string SystemNameEqual
		{
			get { return _SystemNameEqual; }
			set 
			{ 
				_SystemNameEqual = value;
				OnPropertyChanged("SystemNameEqual");
			}
		}
		public string SystemNameIn
		{
			get { return _SystemNameIn; }
			set 
			{ 
				_SystemNameIn = value;
				OnPropertyChanged("SystemNameIn");
			}
		}
		#endregion

		#region CTor
		public KalturaConversionProfileAssetParamsBaseFilter()
		{
		}

		public KalturaConversionProfileAssetParamsBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "conversionProfileIdEqual":
						this.ConversionProfileIdEqual = ParseInt(txt);
						continue;
					case "conversionProfileIdIn":
						this.ConversionProfileIdIn = txt;
						continue;
					case "assetParamsIdEqual":
						this.AssetParamsIdEqual = ParseInt(txt);
						continue;
					case "assetParamsIdIn":
						this.AssetParamsIdIn = txt;
						continue;
					case "readyBehaviorEqual":
						this.ReadyBehaviorEqual = (KalturaFlavorReadyBehaviorType)ParseEnum(typeof(KalturaFlavorReadyBehaviorType), txt);
						continue;
					case "readyBehaviorIn":
						this.ReadyBehaviorIn = txt;
						continue;
					case "originEqual":
						this.OriginEqual = (KalturaAssetParamsOrigin)ParseEnum(typeof(KalturaAssetParamsOrigin), txt);
						continue;
					case "originIn":
						this.OriginIn = txt;
						continue;
					case "systemNameEqual":
						this.SystemNameEqual = txt;
						continue;
					case "systemNameIn":
						this.SystemNameIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("conversionProfileIdEqual", this.ConversionProfileIdEqual);
			kparams.AddStringIfNotNull("conversionProfileIdIn", this.ConversionProfileIdIn);
			kparams.AddIntIfNotNull("assetParamsIdEqual", this.AssetParamsIdEqual);
			kparams.AddStringIfNotNull("assetParamsIdIn", this.AssetParamsIdIn);
			kparams.AddEnumIfNotNull("readyBehaviorEqual", this.ReadyBehaviorEqual);
			kparams.AddStringIfNotNull("readyBehaviorIn", this.ReadyBehaviorIn);
			kparams.AddEnumIfNotNull("originEqual", this.OriginEqual);
			kparams.AddStringIfNotNull("originIn", this.OriginIn);
			kparams.AddStringIfNotNull("systemNameEqual", this.SystemNameEqual);
			kparams.AddStringIfNotNull("systemNameIn", this.SystemNameIn);
			return kparams;
		}
		#endregion
	}
}

