using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaConfigurableDistributionProfile : KalturaDistributionProfile
	{
		#region Private Fields
		private IList<KalturaDistributionFieldConfig> _FieldConfigArray;
		private IList<KalturaString> _ItemXpathsToExtend;
		#endregion

		#region Properties
		public IList<KalturaDistributionFieldConfig> FieldConfigArray
		{
			get { return _FieldConfigArray; }
			set 
			{ 
				_FieldConfigArray = value;
				OnPropertyChanged("FieldConfigArray");
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
		public KalturaConfigurableDistributionProfile()
		{
		}

		public KalturaConfigurableDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "fieldConfigArray":
						this.FieldConfigArray = new List<KalturaDistributionFieldConfig>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.FieldConfigArray.Add((KalturaDistributionFieldConfig)KalturaObjectFactory.Create(arrayNode));
						}
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
			if (this.FieldConfigArray != null)
			{
				if (this.FieldConfigArray.Count == 0)
				{
					kparams.Add("fieldConfigArray:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaDistributionFieldConfig item in this.FieldConfigArray)
					{
						kparams.Add("fieldConfigArray:" + i + ":objectType", item.GetType().Name);
						kparams.Add("fieldConfigArray:" + i, item.ToParams());
						i++;
					}
				}
			}
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

