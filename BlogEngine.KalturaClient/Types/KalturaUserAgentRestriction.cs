using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaUserAgentRestriction : KalturaBaseRestriction
	{
		#region Private Fields
		private KalturaUserAgentRestrictionType _UserAgentRestrictionType = (KalturaUserAgentRestrictionType)Int32.MinValue;
		private string _UserAgentRegexList = null;
		#endregion

		#region Properties
		public KalturaUserAgentRestrictionType UserAgentRestrictionType
		{
			get { return _UserAgentRestrictionType; }
			set 
			{ 
				_UserAgentRestrictionType = value;
				OnPropertyChanged("UserAgentRestrictionType");
			}
		}
		public string UserAgentRegexList
		{
			get { return _UserAgentRegexList; }
			set 
			{ 
				_UserAgentRegexList = value;
				OnPropertyChanged("UserAgentRegexList");
			}
		}
		#endregion

		#region CTor
		public KalturaUserAgentRestriction()
		{
		}

		public KalturaUserAgentRestriction(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "userAgentRestrictionType":
						this.UserAgentRestrictionType = (KalturaUserAgentRestrictionType)ParseEnum(typeof(KalturaUserAgentRestrictionType), txt);
						continue;
					case "userAgentRegexList":
						this.UserAgentRegexList = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddEnumIfNotNull("userAgentRestrictionType", this.UserAgentRestrictionType);
			kparams.AddStringIfNotNull("userAgentRegexList", this.UserAgentRegexList);
			return kparams;
		}
		#endregion
	}
}

