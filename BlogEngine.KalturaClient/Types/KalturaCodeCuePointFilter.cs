using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaCodeCuePointFilter : KalturaCodeCuePointBaseFilter
	{
		#region Private Fields
		private KalturaCodeCuePointOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaCodeCuePointOrderBy OrderBy
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
		public KalturaCodeCuePointFilter()
		{
		}

		public KalturaCodeCuePointFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaCodeCuePointOrderBy)KalturaStringEnum.Parse(typeof(KalturaCodeCuePointOrderBy), txt);
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

