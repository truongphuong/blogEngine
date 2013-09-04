using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaStartWidgetSessionResponse : KalturaObjectBase
	{
		#region Private Fields
		private int _PartnerId = Int32.MinValue;
		private string _Ks = null;
		private string _UserId = null;
		#endregion

		#region Properties
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public string Ks
		{
			get { return _Ks; }
			set 
			{ 
				_Ks = value;
				OnPropertyChanged("Ks");
			}
		}
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		#endregion

		#region CTor
		public KalturaStartWidgetSessionResponse()
		{
		}

		public KalturaStartWidgetSessionResponse(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "ks":
						this.Ks = txt;
						continue;
					case "userId":
						this.UserId = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddStringIfNotNull("ks", this.Ks);
			kparams.AddStringIfNotNull("userId", this.UserId);
			return kparams;
		}
		#endregion
	}
}

