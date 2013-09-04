using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaEntryContextDataParams : KalturaObjectBase
	{
		#region Private Fields
		private string _Referrer = null;
		private string _FlavorAssetId = null;
		private string _StreamerType = null;
		#endregion

		#region Properties
		public string Referrer
		{
			get { return _Referrer; }
			set 
			{ 
				_Referrer = value;
				OnPropertyChanged("Referrer");
			}
		}
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		public string StreamerType
		{
			get { return _StreamerType; }
			set 
			{ 
				_StreamerType = value;
				OnPropertyChanged("StreamerType");
			}
		}
		#endregion

		#region CTor
		public KalturaEntryContextDataParams()
		{
		}

		public KalturaEntryContextDataParams(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "referrer":
						this.Referrer = txt;
						continue;
					case "flavorAssetId":
						this.FlavorAssetId = txt;
						continue;
					case "streamerType":
						this.StreamerType = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("referrer", this.Referrer);
			kparams.AddStringIfNotNull("flavorAssetId", this.FlavorAssetId);
			kparams.AddStringIfNotNull("streamerType", this.StreamerType);
			return kparams;
		}
		#endregion
	}
}

