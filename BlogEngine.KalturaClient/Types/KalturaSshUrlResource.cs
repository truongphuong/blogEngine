using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSshUrlResource : KalturaUrlResource
	{
		#region Private Fields
		private string _PrivateKey = null;
		private string _PublicKey = null;
		private string _KeyPassphrase = null;
		#endregion

		#region Properties
		public string PrivateKey
		{
			get { return _PrivateKey; }
			set 
			{ 
				_PrivateKey = value;
				OnPropertyChanged("PrivateKey");
			}
		}
		public string PublicKey
		{
			get { return _PublicKey; }
			set 
			{ 
				_PublicKey = value;
				OnPropertyChanged("PublicKey");
			}
		}
		public string KeyPassphrase
		{
			get { return _KeyPassphrase; }
			set 
			{ 
				_KeyPassphrase = value;
				OnPropertyChanged("KeyPassphrase");
			}
		}
		#endregion

		#region CTor
		public KalturaSshUrlResource()
		{
		}

		public KalturaSshUrlResource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "privateKey":
						this.PrivateKey = txt;
						continue;
					case "publicKey":
						this.PublicKey = txt;
						continue;
					case "keyPassphrase":
						this.KeyPassphrase = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("privateKey", this.PrivateKey);
			kparams.AddStringIfNotNull("publicKey", this.PublicKey);
			kparams.AddStringIfNotNull("keyPassphrase", this.KeyPassphrase);
			return kparams;
		}
		#endregion
	}
}

