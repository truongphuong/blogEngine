using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaMediaFlavorParamsFilter : KalturaMediaFlavorParamsBaseFilter
	{
		#region Private Fields
		private KalturaMediaFlavorParamsOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaMediaFlavorParamsOrderBy OrderBy
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
		public KalturaMediaFlavorParamsFilter()
		{
		}

		public KalturaMediaFlavorParamsFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaMediaFlavorParamsOrderBy)KalturaStringEnum.Parse(typeof(KalturaMediaFlavorParamsOrderBy), txt);
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

