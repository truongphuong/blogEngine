using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaConversionProfileAssetParams : KalturaObjectBase
	{
		#region Private Fields
		private int _ConversionProfileId = Int32.MinValue;
		private int _AssetParamsId = Int32.MinValue;
		private KalturaFlavorReadyBehaviorType _ReadyBehavior = (KalturaFlavorReadyBehaviorType)Int32.MinValue;
		private KalturaAssetParamsOrigin _Origin = (KalturaAssetParamsOrigin)Int32.MinValue;
		private string _SystemName = null;
		private KalturaNullableBoolean _ForceNoneComplied = (KalturaNullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public int ConversionProfileId
		{
			get { return _ConversionProfileId; }
			set 
			{ 
				_ConversionProfileId = value;
				OnPropertyChanged("ConversionProfileId");
			}
		}
		public int AssetParamsId
		{
			get { return _AssetParamsId; }
			set 
			{ 
				_AssetParamsId = value;
				OnPropertyChanged("AssetParamsId");
			}
		}
		public KalturaFlavorReadyBehaviorType ReadyBehavior
		{
			get { return _ReadyBehavior; }
			set 
			{ 
				_ReadyBehavior = value;
				OnPropertyChanged("ReadyBehavior");
			}
		}
		public KalturaAssetParamsOrigin Origin
		{
			get { return _Origin; }
			set 
			{ 
				_Origin = value;
				OnPropertyChanged("Origin");
			}
		}
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		public KalturaNullableBoolean ForceNoneComplied
		{
			get { return _ForceNoneComplied; }
			set 
			{ 
				_ForceNoneComplied = value;
				OnPropertyChanged("ForceNoneComplied");
			}
		}
		#endregion

		#region CTor
		public KalturaConversionProfileAssetParams()
		{
		}

		public KalturaConversionProfileAssetParams(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "conversionProfileId":
						this.ConversionProfileId = ParseInt(txt);
						continue;
					case "assetParamsId":
						this.AssetParamsId = ParseInt(txt);
						continue;
					case "readyBehavior":
						this.ReadyBehavior = (KalturaFlavorReadyBehaviorType)ParseEnum(typeof(KalturaFlavorReadyBehaviorType), txt);
						continue;
					case "origin":
						this.Origin = (KalturaAssetParamsOrigin)ParseEnum(typeof(KalturaAssetParamsOrigin), txt);
						continue;
					case "systemName":
						this.SystemName = txt;
						continue;
					case "forceNoneComplied":
						this.ForceNoneComplied = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("conversionProfileId", this.ConversionProfileId);
			kparams.AddIntIfNotNull("assetParamsId", this.AssetParamsId);
			kparams.AddEnumIfNotNull("readyBehavior", this.ReadyBehavior);
			kparams.AddEnumIfNotNull("origin", this.Origin);
			kparams.AddStringIfNotNull("systemName", this.SystemName);
			kparams.AddEnumIfNotNull("forceNoneComplied", this.ForceNoneComplied);
			return kparams;
		}
		#endregion
	}
}

