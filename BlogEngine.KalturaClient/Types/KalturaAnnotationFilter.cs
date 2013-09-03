using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAnnotationFilter : KalturaAnnotationBaseFilter
	{
		#region Private Fields
		private KalturaAnnotationOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaAnnotationOrderBy OrderBy
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
		public KalturaAnnotationFilter()
		{
		}

		public KalturaAnnotationFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaAnnotationOrderBy)KalturaStringEnum.Parse(typeof(KalturaAnnotationOrderBy), txt);
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

