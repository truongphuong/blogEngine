using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFlavorParamsFilter : KalturaFlavorParamsBaseFilter
	{
		#region Private Fields
		private KalturaFlavorParamsOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaFlavorParamsOrderBy OrderBy
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
		public KalturaFlavorParamsFilter()
		{
		}

		public KalturaFlavorParamsFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaFlavorParamsOrderBy)KalturaStringEnum.Parse(typeof(KalturaFlavorParamsOrderBy), txt);
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

