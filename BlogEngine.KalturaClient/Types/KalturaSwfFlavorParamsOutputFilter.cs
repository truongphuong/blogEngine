using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSwfFlavorParamsOutputFilter : KalturaSwfFlavorParamsOutputBaseFilter
	{
		#region Private Fields
		private KalturaSwfFlavorParamsOutputOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaSwfFlavorParamsOutputOrderBy OrderBy
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
		public KalturaSwfFlavorParamsOutputFilter()
		{
		}

		public KalturaSwfFlavorParamsOutputFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaSwfFlavorParamsOutputOrderBy)KalturaStringEnum.Parse(typeof(KalturaSwfFlavorParamsOutputOrderBy), txt);
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

