using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFlavorAssetWithParams : KalturaObjectBase
	{
		#region Private Fields
		private KalturaFlavorAsset _FlavorAsset;
		private KalturaFlavorParams _FlavorParams;
		private string _EntryId = null;
		#endregion

		#region Properties
		public KalturaFlavorAsset FlavorAsset
		{
			get { return _FlavorAsset; }
			set 
			{ 
				_FlavorAsset = value;
				OnPropertyChanged("FlavorAsset");
			}
		}
		public KalturaFlavorParams FlavorParams
		{
			get { return _FlavorParams; }
			set 
			{ 
				_FlavorParams = value;
				OnPropertyChanged("FlavorParams");
			}
		}
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		#endregion

		#region CTor
		public KalturaFlavorAssetWithParams()
		{
		}

		public KalturaFlavorAssetWithParams(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "flavorAsset":
						this.FlavorAsset = (KalturaFlavorAsset)KalturaObjectFactory.Create(propertyNode);
						continue;
					case "flavorParams":
						this.FlavorParams = (KalturaFlavorParams)KalturaObjectFactory.Create(propertyNode);
						continue;
					case "entryId":
						this.EntryId = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			if (this.FlavorAsset != null)
				kparams.Add("flavorAsset", this.FlavorAsset.ToParams());
			if (this.FlavorParams != null)
				kparams.Add("flavorParams", this.FlavorParams.ToParams());
			kparams.AddStringIfNotNull("entryId", this.EntryId);
			return kparams;
		}
		#endregion
	}
}

