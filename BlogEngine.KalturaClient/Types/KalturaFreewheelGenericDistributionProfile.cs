using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFreewheelGenericDistributionProfile : KalturaConfigurableDistributionProfile
	{
		#region Private Fields
		private string _Apikey = null;
		private string _Email = null;
		private string _SftpPass = null;
		private string _SftpLogin = null;
		private string _ContentOwner = null;
		private string _UpstreamVideoId = null;
		private string _UpstreamNetworkName = null;
		private string _UpstreamNetworkId = null;
		private string _CategoryId = null;
		private bool? _ReplaceGroup = false;
		private bool? _ReplaceAirDates = false;
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
		public string ContentOwner
		{
			get { return _ContentOwner; }
			set 
			{ 
				_ContentOwner = value;
				OnPropertyChanged("ContentOwner");
			}
		}
		public string UpstreamVideoId
		{
			get { return _UpstreamVideoId; }
			set 
			{ 
				_UpstreamVideoId = value;
				OnPropertyChanged("UpstreamVideoId");
			}
		}
		public string UpstreamNetworkName
		{
			get { return _UpstreamNetworkName; }
			set 
			{ 
				_UpstreamNetworkName = value;
				OnPropertyChanged("UpstreamNetworkName");
			}
		}
		public string UpstreamNetworkId
		{
			get { return _UpstreamNetworkId; }
			set 
			{ 
				_UpstreamNetworkId = value;
				OnPropertyChanged("UpstreamNetworkId");
			}
		}
		public string CategoryId
		{
			get { return _CategoryId; }
			set 
			{ 
				_CategoryId = value;
				OnPropertyChanged("CategoryId");
			}
		}
		public bool? ReplaceGroup
		{
			get { return _ReplaceGroup; }
			set 
			{ 
				_ReplaceGroup = value;
				OnPropertyChanged("ReplaceGroup");
			}
		}
		public bool? ReplaceAirDates
		{
			get { return _ReplaceAirDates; }
			set 
			{ 
				_ReplaceAirDates = value;
				OnPropertyChanged("ReplaceAirDates");
			}
		}
		#endregion

		#region CTor
		public KalturaFreewheelGenericDistributionProfile()
		{
		}

		public KalturaFreewheelGenericDistributionProfile(XmlElement node) : base(node)
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
					case "contentOwner":
						this.ContentOwner = txt;
						continue;
					case "upstreamVideoId":
						this.UpstreamVideoId = txt;
						continue;
					case "upstreamNetworkName":
						this.UpstreamNetworkName = txt;
						continue;
					case "upstreamNetworkId":
						this.UpstreamNetworkId = txt;
						continue;
					case "categoryId":
						this.CategoryId = txt;
						continue;
					case "replaceGroup":
						this.ReplaceGroup = ParseBool(txt);
						continue;
					case "replaceAirDates":
						this.ReplaceAirDates = ParseBool(txt);
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
			kparams.AddStringIfNotNull("contentOwner", this.ContentOwner);
			kparams.AddStringIfNotNull("upstreamVideoId", this.UpstreamVideoId);
			kparams.AddStringIfNotNull("upstreamNetworkName", this.UpstreamNetworkName);
			kparams.AddStringIfNotNull("upstreamNetworkId", this.UpstreamNetworkId);
			kparams.AddStringIfNotNull("categoryId", this.CategoryId);
			kparams.AddBoolIfNotNull("replaceGroup", this.ReplaceGroup);
			kparams.AddBoolIfNotNull("replaceAirDates", this.ReplaceAirDates);
			return kparams;
		}
		#endregion
	}
}

