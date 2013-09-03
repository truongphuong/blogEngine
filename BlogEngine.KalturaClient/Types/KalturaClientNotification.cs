using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaClientNotification : KalturaObjectBase
	{
		#region Private Fields
		private string _Url = null;
		private string _Data = null;
		#endregion

		#region Properties
		public string Url
		{
			get { return _Url; }
			set 
			{ 
				_Url = value;
				OnPropertyChanged("Url");
			}
		}
		public string Data
		{
			get { return _Data; }
			set 
			{ 
				_Data = value;
				OnPropertyChanged("Data");
			}
		}
		#endregion

		#region CTor
		public KalturaClientNotification()
		{
		}

		public KalturaClientNotification(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "url":
						this.Url = txt;
						continue;
					case "data":
						this.Data = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("url", this.Url);
			kparams.AddStringIfNotNull("data", this.Data);
			return kparams;
		}
		#endregion
	}
}

