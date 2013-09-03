using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFlavorParamsOutputFilter : KalturaFlavorParamsOutputBaseFilter
	{
		#region Private Fields
		private KalturaFlavorParamsOutputOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaFlavorParamsOutputOrderBy OrderBy
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
		public KalturaFlavorParamsOutputFilter()
		{
		}

		public KalturaFlavorParamsOutputFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaFlavorParamsOutputOrderBy)KalturaStringEnum.Parse(typeof(KalturaFlavorParamsOutputOrderBy), txt);
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

