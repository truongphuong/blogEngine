using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAuditTrailChangeInfo : KalturaAuditTrailInfo
	{
		#region Private Fields
		private IList<KalturaAuditTrailChangeItem> _ChangedItems;
		#endregion

		#region Properties
		public IList<KalturaAuditTrailChangeItem> ChangedItems
		{
			get { return _ChangedItems; }
			set 
			{ 
				_ChangedItems = value;
				OnPropertyChanged("ChangedItems");
			}
		}
		#endregion

		#region CTor
		public KalturaAuditTrailChangeInfo()
		{
		}

		public KalturaAuditTrailChangeInfo(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "changedItems":
						this.ChangedItems = new List<KalturaAuditTrailChangeItem>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.ChangedItems.Add((KalturaAuditTrailChangeItem)KalturaObjectFactory.Create(arrayNode));
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
			if (this.ChangedItems != null)
			{
				if (this.ChangedItems.Count == 0)
				{
					kparams.Add("changedItems:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaAuditTrailChangeItem item in this.ChangedItems)
					{
						kparams.Add("changedItems:" + i + ":objectType", item.GetType().Name);
						kparams.Add("changedItems:" + i, item.ToParams());
						i++;
					}
				}
			}
			return kparams;
		}
		#endregion
	}
}

