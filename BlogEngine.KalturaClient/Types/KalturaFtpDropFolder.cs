using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFtpDropFolder : KalturaRemoteDropFolder
	{
		#region Private Fields
		private string _Host = null;
		private int _Port = Int32.MinValue;
		private string _Username = null;
		private string _Password = null;
		#endregion

		#region Properties
		public string Host
		{
			get { return _Host; }
			set 
			{ 
				_Host = value;
				OnPropertyChanged("Host");
			}
		}
		public int Port
		{
			get { return _Port; }
			set 
			{ 
				_Port = value;
				OnPropertyChanged("Port");
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
		#endregion

		#region CTor
		public KalturaFtpDropFolder()
		{
		}

		public KalturaFtpDropFolder(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "host":
						this.Host = txt;
						continue;
					case "port":
						this.Port = ParseInt(txt);
						continue;
					case "username":
						this.Username = txt;
						continue;
					case "password":
						this.Password = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("host", this.Host);
			kparams.AddIntIfNotNull("port", this.Port);
			kparams.AddStringIfNotNull("username", this.Username);
			kparams.AddStringIfNotNull("password", this.Password);
			return kparams;
		}
		#endregion
	}
}

