using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaMediaFlavorParamsOutputFilter : KalturaMediaFlavorParamsOutputBaseFilter
	{
		#region Private Fields
		private KalturaMediaFlavorParamsOutputOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaMediaFlavorParamsOutputOrderBy OrderBy
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
		public KalturaMediaFlavorParamsOutputFilter()
		{
		}

		public KalturaMediaFlavorParamsOutputFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaMediaFlavorParamsOutputOrderBy)KalturaStringEnum.Parse(typeof(KalturaMediaFlavorParamsOutputOrderBy), txt);
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

