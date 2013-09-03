using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaIpAddressRestriction : KalturaBaseRestriction
	{
		#region Private Fields
		private KalturaIpAddressRestrictionType _IpAddressRestrictionType = (KalturaIpAddressRestrictionType)Int32.MinValue;
		private string _IpAddressList = null;
		#endregion

		#region Properties
		public KalturaIpAddressRestrictionType IpAddressRestrictionType
		{
			get { return _IpAddressRestrictionType; }
			set 
			{ 
				_IpAddressRestrictionType = value;
				OnPropertyChanged("IpAddressRestrictionType");
			}
		}
		public string IpAddressList
		{
			get { return _IpAddressList; }
			set 
			{ 
				_IpAddressList = value;
				OnPropertyChanged("IpAddressList");
			}
		}
		#endregion

		#region CTor
		public KalturaIpAddressRestriction()
		{
		}

		public KalturaIpAddressRestriction(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "ipAddressRestrictionType":
						this.IpAddressRestrictionType = (KalturaIpAddressRestrictionType)ParseEnum(typeof(KalturaIpAddressRestrictionType), txt);
						continue;
					case "ipAddressList":
						this.IpAddressList = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddEnumIfNotNull("ipAddressRestrictionType", this.IpAddressRestrictionType);
			kparams.AddStringIfNotNull("ipAddressList", this.IpAddressList);
			return kparams;
		}
		#endregion
	}
}

