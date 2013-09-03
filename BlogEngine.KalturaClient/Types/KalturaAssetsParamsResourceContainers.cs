using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAssetsParamsResourceContainers : KalturaResource
	{
		#region Private Fields
		private IList<KalturaAssetParamsResourceContainer> _Resources;
		#endregion

		#region Properties
		public IList<KalturaAssetParamsResourceContainer> Resources
		{
			get { return _Resources; }
			set 
			{ 
				_Resources = value;
				OnPropertyChanged("Resources");
			}
		}
		#endregion

		#region CTor
		public KalturaAssetsParamsResourceContainers()
		{
		}

		public KalturaAssetsParamsResourceContainers(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "resources":
						this.Resources = new List<KalturaAssetParamsResourceContainer>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Resources.Add((KalturaAssetParamsResourceContainer)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			if (this.Resources != null)
			{
				if (this.Resources.Count == 0)
				{
					kparams.Add("resources:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaAssetParamsResourceContainer item in this.Resources)
					{
						kparams.Add("resources:" + i + ":objectType", item.GetType().Name);
						kparams.Add("resources:" + i, item.ToParams());
						i++;
					}
				}
			}
			return kparams;
		}
		#endregion
	}
}

