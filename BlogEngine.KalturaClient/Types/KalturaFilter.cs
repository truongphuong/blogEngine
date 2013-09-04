using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFilter : KalturaObjectBase
	{
		#region Private Fields
		private string _OrderBy = null;
		private KalturaSearchItem _AdvancedSearch;
		#endregion

		#region Properties
		public string OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		public KalturaSearchItem AdvancedSearch
		{
			get { return _AdvancedSearch; }
			set 
			{ 
				_AdvancedSearch = value;
				OnPropertyChanged("AdvancedSearch");
			}
		}
		#endregion

		#region CTor
		public KalturaFilter()
		{
		}

		public KalturaFilter(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = txt;
						continue;
					case "advancedSearch":
						this.AdvancedSearch = (KalturaSearchItem)KalturaObjectFactory.Create(propertyNode);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("orderBy", this.OrderBy);
			if (this.AdvancedSearch != null)
				kparams.Add("advancedSearch", this.AdvancedSearch.ToParams());
			return kparams;
		}
		#endregion
	}
}

