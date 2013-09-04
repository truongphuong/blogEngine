using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDocumentFlavorParamsFilter : KalturaDocumentFlavorParamsBaseFilter
	{
		#region Private Fields
		private KalturaDocumentFlavorParamsOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaDocumentFlavorParamsOrderBy OrderBy
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
		public KalturaDocumentFlavorParamsFilter()
		{
		}

		public KalturaDocumentFlavorParamsFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaDocumentFlavorParamsOrderBy)KalturaStringEnum.Parse(typeof(KalturaDocumentFlavorParamsOrderBy), txt);
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

