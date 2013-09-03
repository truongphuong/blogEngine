using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaStorageProfileFilter : KalturaStorageProfileBaseFilter
	{
		#region Private Fields
		private KalturaStorageProfileOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaStorageProfileOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public KalturaStorageProfileFilter()
		{
		}

		public KalturaStorageProfileFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaStorageProfileOrderBy)KalturaStringEnum.Parse(typeof(KalturaStorageProfileOrderBy), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringEnumIfNotNull("orderBy", this.OrderBy);
			return kparams;
		}
		#endregion
	}
}

