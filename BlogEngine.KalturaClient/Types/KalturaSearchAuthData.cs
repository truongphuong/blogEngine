using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSearchAuthData : KalturaObjectBase
	{
		#region Private Fields
		private string _AuthData = null;
		private string _LoginUrl = null;
		private string _Message = null;
		#endregion

		#region Properties
		public string AuthData
		{
			get { return _AuthData; }
			set 
			{ 
				_AuthData = value;
				OnPropertyChanged("AuthData");
			}
		}
		public string LoginUrl
		{
			get { return _LoginUrl; }
			set 
			{ 
				_LoginUrl = value;
				OnPropertyChanged("LoginUrl");
			}
		}
		public string Message
		{
			get { return _Message; }
			set 
			{ 
				_Message = value;
				OnPropertyChanged("Message");
			}
		}
		#endregion

		#region CTor
		public KalturaSearchAuthData()
		{
		}

		public KalturaSearchAuthData(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "authData":
						this.AuthData = txt;
						continue;
					case "loginUrl":
						this.LoginUrl = txt;
						continue;
					case "message":
						this.Message = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("authData", this.AuthData);
			kparams.AddStringIfNotNull("loginUrl", this.LoginUrl);
			kparams.AddStringIfNotNull("message", this.Message);
			return kparams;
		}
		#endregion
	}
}

