using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSearchOperator : KalturaSearchItem
	{
		#region Private Fields
		private KalturaSearchOperatorType _Type = (KalturaSearchOperatorType)Int32.MinValue;
		private IList<KalturaSearchItem> _Items;
		#endregion

		#region Properties
		public KalturaSearchOperatorType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public IList<KalturaSearchItem> Items
		{
			get { return _Items; }
			set 
			{ 
				_Items = value;
				OnPropertyChanged("Items");
			}
		}
		#endregion

		#region CTor
		public KalturaSearchOperator()
		{
		}

		public KalturaSearchOperator(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "type":
						this.Type = (KalturaSearchOperatorType)ParseEnum(typeof(KalturaSearchOperatorType), txt);
						continue;
					case "items":
						this.Items = new List<KalturaSearchItem>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Items.Add((KalturaSearchItem)KalturaObjectFactory.Create(arrayNode));
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
			kparams.AddEnumIfNotNull("type", this.Type);
			if (this.Items != null)
			{
				if (this.Items.Count == 0)
				{
					kparams.Add("items:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaSearchItem item in this.Items)
					{
						kparams.Add("items:" + i + ":objectType", item.GetType().Name);
						kparams.Add("items:" + i, item.ToParams());
						i++;
					}
				}
			}
			return kparams;
		}
		#endregion
	}
}

