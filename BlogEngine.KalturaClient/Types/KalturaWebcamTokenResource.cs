using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaWebcamTokenResource : KalturaDataCenterContentResource
	{
		#region Private Fields
		private string _Token = null;
		#endregion

		#region Properties
		public string Token
		{
			get { return _Token; }
			set 
			{ 
				_Token = value;
				OnPropertyChanged("Token");
			}
		}
		#endregion

		#region CTor
		public KalturaWebcamTokenResource()
		{
		}

		public KalturaWebcamTokenResource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "token":
						this.Token = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("token", this.Token);
			return kparams;
		}
		#endregion
	}
}

