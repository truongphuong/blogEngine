using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaShortLinkFilter : KalturaShortLinkBaseFilter
	{
		#region Private Fields
		private KalturaShortLinkOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaShortLinkOrderBy OrderBy
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
		public KalturaShortLinkFilter()
		{
		}

		public KalturaShortLinkFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaShortLinkOrderBy)KalturaStringEnum.Parse(typeof(KalturaShortLinkOrderBy), txt);
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

