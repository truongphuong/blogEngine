using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAssetParamsResourceContainer : KalturaResource
	{
		#region Private Fields
		private KalturaContentResource _Resource;
		private int _AssetParamsId = Int32.MinValue;
		#endregion

		#region Properties
		public KalturaContentResource Resource
		{
			get { return _Resource; }
			set 
			{ 
				_Resource = value;
				OnPropertyChanged("Resource");
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
		#endregion

		#region CTor
		public KalturaAssetParamsResourceContainer()
		{
		}

		public KalturaAssetParamsResourceContainer(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "resource":
						this.Resource = (KalturaContentResource)KalturaObjectFactory.Create(propertyNode);
						continue;
					case "assetParamsId":
						this.AssetParamsId = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			if (this.Resource != null)
				kparams.Add("resource", this.Resource.ToParams());
			kparams.AddIntIfNotNull("assetParamsId", this.AssetParamsId);
			return kparams;
		}
		#endregion
	}
}

