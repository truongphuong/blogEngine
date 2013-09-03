using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFreewheelDistributionProfile : KalturaDistributionProfile
	{
		#region Private Fields
		private string _Apikey = null;
		private string _Email = null;
		private string _SftpPass = null;
		private string _SftpLogin = null;
		private string _AccountId = null;
		private int _MetadataProfileId = Int32.MinValue;
		#endregion

		#region Properties
		public string Apikey
		{
			get { return _Apikey; }
			set 
			{ 
				_Apikey = value;
				OnPropertyChanged("Apikey");
			}
		}
		public string Email
		{
			get { return _Email; }
			set 
			{ 
				_Email = value;
				OnPropertyChanged("Email");
			}
		}
		public string SftpPass
		{
			get { return _SftpPass; }
			set 
			{ 
				_SftpPass = value;
				OnPropertyChanged("SftpPass");
			}
		}
		public string SftpLogin
		{
			get { return _SftpLogin; }
			set 
			{ 
				_SftpLogin = value;
				OnPropertyChanged("SftpLogin");
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
		public KalturaFreewheelDistributionProfile()
		{
		}

		public KalturaFreewheelDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "apikey":
						this.Apikey = txt;
						continue;
					case "email":
						this.Email = txt;
						continue;
					case "sftpPass":
						this.SftpPass = txt;
						continue;
					case "sftpLogin":
						this.SftpLogin = txt;
						continue;
					case "accountId":
						this.AccountId = txt;
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
			kparams.AddStringIfNotNull("apikey", this.Apikey);
			kparams.AddStringIfNotNull("email", this.Email);
			kparams.AddStringIfNotNull("sftpPass", this.SftpPass);
			kparams.AddStringIfNotNull("sftpLogin", this.SftpLogin);
			kparams.AddStringIfNotNull("accountId", this.AccountId);
			kparams.AddIntIfNotNull("metadataProfileId", this.MetadataProfileId);
			return kparams;
		}
		#endregion
	}
}

