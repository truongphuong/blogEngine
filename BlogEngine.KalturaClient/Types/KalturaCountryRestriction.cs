using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaCountryRestriction : KalturaBaseRestriction
	{
		#region Private Fields
		private KalturaCountryRestrictionType _CountryRestrictionType = (KalturaCountryRestrictionType)Int32.MinValue;
		private string _CountryList = null;
		#endregion

		#region Properties
		public KalturaCountryRestrictionType CountryRestrictionType
		{
			get { return _CountryRestrictionType; }
			set 
			{ 
				_CountryRestrictionType = value;
				OnPropertyChanged("CountryRestrictionType");
			}
		}
		public string CountryList
		{
			get { return _CountryList; }
			set 
			{ 
				_CountryList = value;
				OnPropertyChanged("CountryList");
			}
		}
		#endregion

		#region CTor
		public KalturaCountryRestriction()
		{
		}

		public KalturaCountryRestriction(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "countryRestrictionType":
						this.CountryRestrictionType = (KalturaCountryRestrictionType)ParseEnum(typeof(KalturaCountryRestrictionType), txt);
						continue;
					case "countryList":
						this.CountryList = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddEnumIfNotNull("countryRestrictionType", this.CountryRestrictionType);
			kparams.AddStringIfNotNull("countryList", this.CountryList);
			return kparams;
		}
		#endregion
	}
}

