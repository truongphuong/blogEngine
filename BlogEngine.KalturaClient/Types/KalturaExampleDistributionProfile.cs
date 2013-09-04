using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaExampleDistributionProfile : KalturaDistributionProfile
	{
		#region Private Fields
		private string _Username = null;
		private string _Password = null;
		private string _AccountId = null;
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
		public string AccountId
		{
			get { return _AccountId; }
			set 
			{ 
				_AccountId = value;
				OnPropertyChanged("AccountId");
			}
		}
		#endregion

		#region CTor
		public KalturaExampleDistributionProfile()
		{
		}

		public KalturaExampleDistributionProfile(XmlElement node) : base(node)
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
					case "accountId":
						this.AccountId = txt;
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
			kparams.AddStringIfNotNull("accountId", this.AccountId);
			return kparams;
		}
		#endregion
	}
}

