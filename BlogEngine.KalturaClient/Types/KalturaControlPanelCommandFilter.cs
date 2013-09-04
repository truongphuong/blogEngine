using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaControlPanelCommandFilter : KalturaControlPanelCommandBaseFilter
	{
		#region Private Fields
		private KalturaControlPanelCommandOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaControlPanelCommandOrderBy OrderBy
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
		public KalturaControlPanelCommandFilter()
		{
		}

		public KalturaControlPanelCommandFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaControlPanelCommandOrderBy)KalturaStringEnum.Parse(typeof(KalturaControlPanelCommandOrderBy), txt);
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

