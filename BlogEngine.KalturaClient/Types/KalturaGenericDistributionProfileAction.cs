using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaGenericDistributionProfileAction : KalturaObjectBase
	{
		#region Private Fields
		private KalturaDistributionProtocol _Protocol = (KalturaDistributionProtocol)Int32.MinValue;
		private string _ServerUrl = null;
		private string _ServerPath = null;
		private string _Username = null;
		private string _Password = null;
		private bool? _FtpPassiveMode = false;
		private string _HttpFieldName = null;
		private string _HttpFileName = null;
		#endregion

		#region Properties
		public KalturaDistributionProtocol Protocol
		{
			get { return _Protocol; }
			set 
			{ 
				_Protocol = value;
				OnPropertyChanged("Protocol");
			}
		}
		public string ServerUrl
		{
			get { return _ServerUrl; }
			set 
			{ 
				_ServerUrl = value;
				OnPropertyChanged("ServerUrl");
			}
		}
		public string ServerPath
		{
			get { return _ServerPath; }
			set 
			{ 
				_ServerPath = value;
				OnPropertyChanged("ServerPath");
			}
		}
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
		public bool? FtpPassiveMode
		{
			get { return _FtpPassiveMode; }
			set 
			{ 
				_FtpPassiveMode = value;
				OnPropertyChanged("FtpPassiveMode");
			}
		}
		public string HttpFieldName
		{
			get { return _HttpFieldName; }
			set 
			{ 
				_HttpFieldName = value;
				OnPropertyChanged("HttpFieldName");
			}
		}
		public string HttpFileName
		{
			get { return _HttpFileName; }
			set 
			{ 
				_HttpFileName = value;
				OnPropertyChanged("HttpFileName");
			}
		}
		#endregion

		#region CTor
		public KalturaGenericDistributionProfileAction()
		{
		}

		public KalturaGenericDistributionProfileAction(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "protocol":
						this.Protocol = (KalturaDistributionProtocol)ParseEnum(typeof(KalturaDistributionProtocol), txt);
						continue;
					case "serverUrl":
						this.ServerUrl = txt;
						continue;
					case "serverPath":
						this.ServerPath = txt;
						continue;
					case "username":
						this.Username = txt;
						continue;
					case "password":
						this.Password = txt;
						continue;
					case "ftpPassiveMode":
						this.FtpPassiveMode = ParseBool(txt);
						continue;
					case "httpFieldName":
						this.HttpFieldName = txt;
						continue;
					case "httpFileName":
						this.HttpFileName = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddEnumIfNotNull("protocol", this.Protocol);
			kparams.AddStringIfNotNull("serverUrl", this.ServerUrl);
			kparams.AddStringIfNotNull("serverPath", this.ServerPath);
			kparams.AddStringIfNotNull("username", this.Username);
			kparams.AddStringIfNotNull("password", this.Password);
			kparams.AddBoolIfNotNull("ftpPassiveMode", this.FtpPassiveMode);
			kparams.AddStringIfNotNull("httpFieldName", this.HttpFieldName);
			kparams.AddStringIfNotNull("httpFileName", this.HttpFileName);
			return kparams;
		}
		#endregion
	}
}

