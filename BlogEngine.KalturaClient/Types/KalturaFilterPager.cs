using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFilterPager : KalturaObjectBase
	{
		#region Private Fields
		private int _PageSize = Int32.MinValue;
		private int _PageIndex = Int32.MinValue;
		#endregion

		#region Properties
		public int PageSize
		{
			get { return _PageSize; }
			set 
			{ 
				_PageSize = value;
				OnPropertyChanged("PageSize");
			}
		}
		public int PageIndex
		{
			get { return _PageIndex; }
			set 
			{ 
				_PageIndex = value;
				OnPropertyChanged("PageIndex");
			}
		}
		#endregion

		#region CTor
		public KalturaFilterPager()
		{
		}

		public KalturaFilterPager(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "pageSize":
						this.PageSize = ParseInt(txt);
						continue;
					case "pageIndex":
						this.PageIndex = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("pageSize", this.PageSize);
			kparams.AddIntIfNotNull("pageIndex", this.PageIndex);
			return kparams;
		}
		#endregion
	}
}

