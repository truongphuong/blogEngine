using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaOperationResource : KalturaContentResource
	{
		#region Private Fields
		private KalturaContentResource _Resource;
		private IList<KalturaOperationAttributes> _OperationAttributes;
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
		public IList<KalturaOperationAttributes> OperationAttributes
		{
			get { return _OperationAttributes; }
			set 
			{ 
				_OperationAttributes = value;
				OnPropertyChanged("OperationAttributes");
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
		public KalturaOperationResource()
		{
		}

		public KalturaOperationResource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "resource":
						this.Resource = (KalturaContentResource)KalturaObjectFactory.Create(propertyNode);
						continue;
					case "operationAttributes":
						this.OperationAttributes = new List<KalturaOperationAttributes>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.OperationAttributes.Add((KalturaOperationAttributes)KalturaObjectFactory.Create(arrayNode));
						}
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
			if (this.OperationAttributes != null)
			{
				if (this.OperationAttributes.Count == 0)
				{
					kparams.Add("operationAttributes:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaOperationAttributes item in this.OperationAttributes)
					{
						kparams.Add("operationAttributes:" + i + ":objectType", item.GetType().Name);
						kparams.Add("operationAttributes:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddIntIfNotNull("assetParamsId", this.AssetParamsId);
			return kparams;
		}
		#endregion
	}
}

