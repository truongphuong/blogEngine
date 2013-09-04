using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaYouTubeDistributionProfile : KalturaConfigurableDistributionProfile
	{
		#region Private Fields
		private string _Username = null;
		private string _NotificationEmail = null;
		private string _SftpHost = null;
		private string _SftpLogin = null;
		private string _SftpPublicKey = null;
		private string _SftpPrivateKey = null;
		private string _SftpBaseDir = null;
		private string _OwnerName = null;
		private string _DefaultCategory = null;
		private string _AllowComments = null;
		private string _AllowEmbedding = null;
		private string _AllowRatings = null;
		private string _AllowResponses = null;
		private string _CommercialPolicy = null;
		private string _UgcPolicy = null;
		private string _Target = null;
		private string _AdServerPartnerId = null;
		private bool? _EnableAdServer = false;
		private bool? _AllowPreRollAds = false;
		private bool? _AllowPostRollAds = false;
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
		public string NotificationEmail
		{
			get { return _NotificationEmail; }
			set 
			{ 
				_NotificationEmail = value;
				OnPropertyChanged("NotificationEmail");
			}
		}
		public string SftpHost
		{
			get { return _SftpHost; }
			set 
			{ 
				_SftpHost = value;
				OnPropertyChanged("SftpHost");
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
		public string SftpPublicKey
		{
			get { return _SftpPublicKey; }
			set 
			{ 
				_SftpPublicKey = value;
				OnPropertyChanged("SftpPublicKey");
			}
		}
		public string SftpPrivateKey
		{
			get { return _SftpPrivateKey; }
			set 
			{ 
				_SftpPrivateKey = value;
				OnPropertyChanged("SftpPrivateKey");
			}
		}
		public string SftpBaseDir
		{
			get { return _SftpBaseDir; }
			set 
			{ 
				_SftpBaseDir = value;
				OnPropertyChanged("SftpBaseDir");
			}
		}
		public string OwnerName
		{
			get { return _OwnerName; }
			set 
			{ 
				_OwnerName = value;
				OnPropertyChanged("OwnerName");
			}
		}
		public string DefaultCategory
		{
			get { return _DefaultCategory; }
			set 
			{ 
				_DefaultCategory = value;
				OnPropertyChanged("DefaultCategory");
			}
		}
		public string AllowComments
		{
			get { return _AllowComments; }
			set 
			{ 
				_AllowComments = value;
				OnPropertyChanged("AllowComments");
			}
		}
		public string AllowEmbedding
		{
			get { return _AllowEmbedding; }
			set 
			{ 
				_AllowEmbedding = value;
				OnPropertyChanged("AllowEmbedding");
			}
		}
		public string AllowRatings
		{
			get { return _AllowRatings; }
			set 
			{ 
				_AllowRatings = value;
				OnPropertyChanged("AllowRatings");
			}
		}
		public string AllowResponses
		{
			get { return _AllowResponses; }
			set 
			{ 
				_AllowResponses = value;
				OnPropertyChanged("AllowResponses");
			}
		}
		public string CommercialPolicy
		{
			get { return _CommercialPolicy; }
			set 
			{ 
				_CommercialPolicy = value;
				OnPropertyChanged("CommercialPolicy");
			}
		}
		public string UgcPolicy
		{
			get { return _UgcPolicy; }
			set 
			{ 
				_UgcPolicy = value;
				OnPropertyChanged("UgcPolicy");
			}
		}
		public string Target
		{
			get { return _Target; }
			set 
			{ 
				_Target = value;
				OnPropertyChanged("Target");
			}
		}
		public string AdServerPartnerId
		{
			get { return _AdServerPartnerId; }
			set 
			{ 
				_AdServerPartnerId = value;
				OnPropertyChanged("AdServerPartnerId");
			}
		}
		public bool? EnableAdServer
		{
			get { return _EnableAdServer; }
			set 
			{ 
				_EnableAdServer = value;
				OnPropertyChanged("EnableAdServer");
			}
		}
		public bool? AllowPreRollAds
		{
			get { return _AllowPreRollAds; }
			set 
			{ 
				_AllowPreRollAds = value;
				OnPropertyChanged("AllowPreRollAds");
			}
		}
		public bool? AllowPostRollAds
		{
			get { return _AllowPostRollAds; }
			set 
			{ 
				_AllowPostRollAds = value;
				OnPropertyChanged("AllowPostRollAds");
			}
		}
		#endregion

		#region CTor
		public KalturaYouTubeDistributionProfile()
		{
		}

		public KalturaYouTubeDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "username":
						this.Username = txt;
						continue;
					case "notificationEmail":
						this.NotificationEmail = txt;
						continue;
					case "sftpHost":
						this.SftpHost = txt;
						continue;
					case "sftpLogin":
						this.SftpLogin = txt;
						continue;
					case "sftpPublicKey":
						this.SftpPublicKey = txt;
						continue;
					case "sftpPrivateKey":
						this.SftpPrivateKey = txt;
						continue;
					case "sftpBaseDir":
						this.SftpBaseDir = txt;
						continue;
					case "ownerName":
						this.OwnerName = txt;
						continue;
					case "defaultCategory":
						this.DefaultCategory = txt;
						continue;
					case "allowComments":
						this.AllowComments = txt;
						continue;
					case "allowEmbedding":
						this.AllowEmbedding = txt;
						continue;
					case "allowRatings":
						this.AllowRatings = txt;
						continue;
					case "allowResponses":
						this.AllowResponses = txt;
						continue;
					case "commercialPolicy":
						this.CommercialPolicy = txt;
						continue;
					case "ugcPolicy":
						this.UgcPolicy = txt;
						continue;
					case "target":
						this.Target = txt;
						continue;
					case "adServerPartnerId":
						this.AdServerPartnerId = txt;
						continue;
					case "enableAdServer":
						this.EnableAdServer = ParseBool(txt);
						continue;
					case "allowPreRollAds":
						this.AllowPreRollAds = ParseBool(txt);
						continue;
					case "allowPostRollAds":
						this.AllowPostRollAds = ParseBool(txt);
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
			kparams.AddStringIfNotNull("notificationEmail", this.NotificationEmail);
			kparams.AddStringIfNotNull("sftpHost", this.SftpHost);
			kparams.AddStringIfNotNull("sftpLogin", this.SftpLogin);
			kparams.AddStringIfNotNull("sftpPublicKey", this.SftpPublicKey);
			kparams.AddStringIfNotNull("sftpPrivateKey", this.SftpPrivateKey);
			kparams.AddStringIfNotNull("sftpBaseDir", this.SftpBaseDir);
			kparams.AddStringIfNotNull("ownerName", this.OwnerName);
			kparams.AddStringIfNotNull("defaultCategory", this.DefaultCategory);
			kparams.AddStringIfNotNull("allowComments", this.AllowComments);
			kparams.AddStringIfNotNull("allowEmbedding", this.AllowEmbedding);
			kparams.AddStringIfNotNull("allowRatings", this.AllowRatings);
			kparams.AddStringIfNotNull("allowResponses", this.AllowResponses);
			kparams.AddStringIfNotNull("commercialPolicy", this.CommercialPolicy);
			kparams.AddStringIfNotNull("ugcPolicy", this.UgcPolicy);
			kparams.AddStringIfNotNull("target", this.Target);
			kparams.AddStringIfNotNull("adServerPartnerId", this.AdServerPartnerId);
			kparams.AddBoolIfNotNull("enableAdServer", this.EnableAdServer);
			kparams.AddBoolIfNotNull("allowPreRollAds", this.AllowPreRollAds);
			kparams.AddBoolIfNotNull("allowPostRollAds", this.AllowPostRollAds);
			return kparams;
		}
		#endregion
	}
}

