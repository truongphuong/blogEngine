using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaRemoteStorageResources : KalturaContentResource
	{
		#region Private Fields
		private IList<KalturaRemoteStorageResource> _Resources;
		#endregion

		#region Properties
		public IList<KalturaRemoteStorageResource> Resources
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
		public KalturaRemoteStorageResources()
		{
		}

		public KalturaRemoteStorageResources(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "resources":
						this.Resources = new List<KalturaRemoteStorageResource>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Resources.Add((KalturaRemoteStorageResource)KalturaObjectFactory.Create(arrayNode));
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
					foreach (KalturaRemoteStorageResource item in this.Resources)
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

