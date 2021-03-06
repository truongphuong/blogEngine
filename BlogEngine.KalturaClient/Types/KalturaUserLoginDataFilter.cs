using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaUserLoginDataFilter : KalturaUserLoginDataBaseFilter
	{
		#region Private Fields
		private KalturaUserLoginDataOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaUserLoginDataOrderBy OrderBy
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
		public KalturaUserLoginDataFilter()
		{
		}

		public KalturaUserLoginDataFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaUserLoginDataOrderBy)KalturaStringEnum.Parse(typeof(KalturaUserLoginDataOrderBy), txt);
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

