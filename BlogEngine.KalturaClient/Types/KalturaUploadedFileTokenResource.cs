using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaUploadedFileTokenResource : KalturaDataCenterContentResource
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
		public KalturaUploadedFileTokenResource()
		{
		}

		public KalturaUploadedFileTokenResource(XmlElement node) : base(node)
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

