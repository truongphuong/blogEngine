using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaGenericXsltSyndicationFeed : KalturaGenericSyndicationFeed
	{
		#region Private Fields
		private string _Xslt = null;
		private IList<KalturaString> _ItemXpathsToExtend;
		#endregion

		#region Properties
		public string Xslt
		{
			get { return _Xslt; }
			set 
			{ 
				_Xslt = value;
				OnPropertyChanged("Xslt");
			}
		}
		public IList<KalturaString> ItemXpathsToExtend
		{
			get { return _ItemXpathsToExtend; }
			set 
			{ 
				_ItemXpathsToExtend = value;
				OnPropertyChanged("ItemXpathsToExtend");
			}
		}
		#endregion

		#region CTor
		public KalturaGenericXsltSyndicationFeed()
		{
		}

		public KalturaGenericXsltSyndicationFeed(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "xslt":
						this.Xslt = txt;
						continue;
					case "itemXpathsToExtend":
						this.ItemXpathsToExtend = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.ItemXpathsToExtend.Add((KalturaString)KalturaObjectFactory.Create(arrayNode));
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
			kparams.AddStringIfNotNull("xslt", this.Xslt);
			if (this.ItemXpathsToExtend != null)
			{
				if (this.ItemXpathsToExtend.Count == 0)
				{
					kparams.Add("itemXpathsToExtend:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaString item in this.ItemXpathsToExtend)
					{
						kparams.Add("itemXpathsToExtend:" + i + ":objectType", item.GetType().Name);
						kparams.Add("itemXpathsToExtend:" + i, item.ToParams());
						i++;
					}
				}
			}
			return kparams;
		}
		#endregion
	}
}

