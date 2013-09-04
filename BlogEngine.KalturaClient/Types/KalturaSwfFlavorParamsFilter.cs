using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSwfFlavorParamsFilter : KalturaSwfFlavorParamsBaseFilter
	{
		#region Private Fields
		private KalturaSwfFlavorParamsOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaSwfFlavorParamsOrderBy OrderBy
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
		public KalturaSwfFlavorParamsFilter()
		{
		}

		public KalturaSwfFlavorParamsFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaSwfFlavorParamsOrderBy)KalturaStringEnum.Parse(typeof(KalturaSwfFlavorParamsOrderBy), txt);
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

