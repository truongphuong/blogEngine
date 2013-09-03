using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaCaptionParamsFilter : KalturaCaptionParamsBaseFilter
	{
		#region Private Fields
		private KalturaCaptionParamsOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaCaptionParamsOrderBy OrderBy
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
		public KalturaCaptionParamsFilter()
		{
		}

		public KalturaCaptionParamsFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaCaptionParamsOrderBy)KalturaStringEnum.Parse(typeof(KalturaCaptionParamsOrderBy), txt);
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

