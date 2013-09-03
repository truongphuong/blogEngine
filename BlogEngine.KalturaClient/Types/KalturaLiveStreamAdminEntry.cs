using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaLiveStreamAdminEntry : KalturaLiveStreamEntry
	{
		#region Private Fields
		private string _EncodingIP1 = null;
		private string _EncodingIP2 = null;
		private string _StreamPassword = null;
		private string _StreamUsername = null;
		#endregion

		#region Properties
		public string EncodingIP1
		{
			get { return _EncodingIP1; }
			set 
			{ 
				_EncodingIP1 = value;
				OnPropertyChanged("EncodingIP1");
			}
		}
		public string EncodingIP2
		{
			get { return _EncodingIP2; }
			set 
			{ 
				_EncodingIP2 = value;
				OnPropertyChanged("EncodingIP2");
			}
		}
		public string StreamPassword
		{
			get { return _StreamPassword; }
			set 
			{ 
				_StreamPassword = value;
				OnPropertyChanged("StreamPassword");
			}
		}
		public string StreamUsername
		{
			get { return _StreamUsername; }
			set 
			{ 
				_StreamUsername = value;
				OnPropertyChanged("StreamUsername");
			}
		}
		#endregion

		#region CTor
		public KalturaLiveStreamAdminEntry()
		{
		}

		public KalturaLiveStreamAdminEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "encodingIP1":
						this.EncodingIP1 = txt;
						continue;
					case "encodingIP2":
						this.EncodingIP2 = txt;
						continue;
					case "streamPassword":
						this.StreamPassword = txt;
						continue;
					case "streamUsername":
						this.StreamUsername = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("encodingIP1", this.EncodingIP1);
			kparams.AddStringIfNotNull("encodingIP2", this.EncodingIP2);
			kparams.AddStringIfNotNull("streamPassword", this.StreamPassword);
			kparams.AddStringIfNotNull("streamUsername", this.StreamUsername);
			return kparams;
		}
		#endregion
	}
}

