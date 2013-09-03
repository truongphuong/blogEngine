using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDocumentFlavorParamsOutputFilter : KalturaDocumentFlavorParamsOutputBaseFilter
	{
		#region Private Fields
		private KalturaDocumentFlavorParamsOutputOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaDocumentFlavorParamsOutputOrderBy OrderBy
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
		public KalturaDocumentFlavorParamsOutputFilter()
		{
		}

		public KalturaDocumentFlavorParamsOutputFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaDocumentFlavorParamsOutputOrderBy)KalturaStringEnum.Parse(typeof(KalturaDocumentFlavorParamsOutputOrderBy), txt);
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

