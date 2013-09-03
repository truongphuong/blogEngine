using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSiteRestriction : KalturaBaseRestriction
	{
		#region Private Fields
		private KalturaSiteRestrictionType _SiteRestrictionType = (KalturaSiteRestrictionType)Int32.MinValue;
		private string _SiteList = null;
		#endregion

		#region Properties
		public KalturaSiteRestrictionType SiteRestrictionType
		{
			get { return _SiteRestrictionType; }
			set 
			{ 
				_SiteRestrictionType = value;
				OnPropertyChanged("SiteRestrictionType");
			}
		}
		public string SiteList
		{
			get { return _SiteList; }
			set 
			{ 
				_SiteList = value;
				OnPropertyChanged("SiteList");
			}
		}
		#endregion

		#region CTor
		public KalturaSiteRestriction()
		{
		}

		public KalturaSiteRestriction(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "siteRestrictionType":
						this.SiteRestrictionType = (KalturaSiteRestrictionType)ParseEnum(typeof(KalturaSiteRestrictionType), txt);
						continue;
					case "siteList":
						this.SiteList = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddEnumIfNotNull("siteRestrictionType", this.SiteRestrictionType);
			kparams.AddStringIfNotNull("siteList", this.SiteList);
			return kparams;
		}
		#endregion
	}
}

