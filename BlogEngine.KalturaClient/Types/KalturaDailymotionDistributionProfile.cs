using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDailymotionDistributionProfile : KalturaDistributionProfile
	{
		#region Private Fields
		private string _User = null;
		private string _Password = null;
		private int _MetadataProfileId = Int32.MinValue;
		#endregion

		#region Properties
		public string User
		{
			get { return _User; }
			set 
			{ 
				_User = value;
				OnPropertyChanged("User");
			}
		}
		public string Password
		{
			get { return _Password; }
			set 
			{ 
				_Password = value;
				OnPropertyChanged("Password");
			}
		}
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
		#endregion

		#region CTor
		public KalturaDailymotionDistributionProfile()
		{
		}

		public KalturaDailymotionDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "user":
						this.User = txt;
						continue;
					case "password":
						this.Password = txt;
						continue;
					case "metadataProfileId":
						this.MetadataProfileId = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("user", this.User);
			kparams.AddStringIfNotNull("password", this.Password);
			kparams.AddIntIfNotNull("metadataProfileId", this.MetadataProfileId);
			return kparams;
		}
		#endregion
	}
}

