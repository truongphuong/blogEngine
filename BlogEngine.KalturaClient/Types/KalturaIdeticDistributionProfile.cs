using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaIdeticDistributionProfile : KalturaConfigurableDistributionProfile
	{
		#region Private Fields
		private string _Username = null;
		private string _Password = null;
		private string _Domain = null;
		#endregion

		#region Properties
		public string Username
		{
			get { return _Username; }
			set 
			{ 
				_Username = value;
				OnPropertyChanged("Username");
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
		public string Domain
		{
			get { return _Domain; }
			set 
			{ 
				_Domain = value;
				OnPropertyChanged("Domain");
			}
		}
		#endregion

		#region CTor
		public KalturaIdeticDistributionProfile()
		{
		}

		public KalturaIdeticDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "username":
						this.Username = txt;
						continue;
					case "password":
						this.Password = txt;
						continue;
					case "domain":
						this.Domain = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("username", this.Username);
			kparams.AddStringIfNotNull("password", this.Password);
			kparams.AddStringIfNotNull("domain", this.Domain);
			return kparams;
		}
		#endregion
	}
}

