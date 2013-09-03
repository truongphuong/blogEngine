using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaPdfFlavorParamsFilter : KalturaPdfFlavorParamsBaseFilter
	{
		#region Private Fields
		private KalturaPdfFlavorParamsOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaPdfFlavorParamsOrderBy OrderBy
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
		public KalturaPdfFlavorParamsFilter()
		{
		}

		public KalturaPdfFlavorParamsFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaPdfFlavorParamsOrderBy)KalturaStringEnum.Parse(typeof(KalturaPdfFlavorParamsOrderBy), txt);
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

