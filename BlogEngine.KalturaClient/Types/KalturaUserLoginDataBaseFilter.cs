using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaUserLoginDataBaseFilter : KalturaFilter
	{
		#region Private Fields
		private string _LoginEmailEqual = null;
		#endregion

		#region Properties
		public string LoginEmailEqual
		{
			get { return _LoginEmailEqual; }
			set 
			{ 
				_LoginEmailEqual = value;
				OnPropertyChanged("LoginEmailEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaUserLoginDataBaseFilter()
		{
		}

		public KalturaUserLoginDataBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "loginEmailEqual":
						this.LoginEmailEqual = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("loginEmailEqual", this.LoginEmailEqual);
			return kparams;
		}
		#endregion
	}
}

