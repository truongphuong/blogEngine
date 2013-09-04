using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaPdfFlavorParamsOutputFilter : KalturaPdfFlavorParamsOutputBaseFilter
	{
		#region Private Fields
		private KalturaPdfFlavorParamsOutputOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaPdfFlavorParamsOutputOrderBy OrderBy
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
		public KalturaPdfFlavorParamsOutputFilter()
		{
		}

		public KalturaPdfFlavorParamsOutputFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaPdfFlavorParamsOutputOrderBy)KalturaStringEnum.Parse(typeof(KalturaPdfFlavorParamsOutputOrderBy), txt);
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

