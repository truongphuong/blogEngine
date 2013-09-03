using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAuditTrailTextInfo : KalturaAuditTrailInfo
	{
		#region Private Fields
		private string _Info = null;
		#endregion

		#region Properties
		public string Info
		{
			get { return _Info; }
			set 
			{ 
				_Info = value;
				OnPropertyChanged("Info");
			}
		}
		#endregion

		#region CTor
		public KalturaAuditTrailTextInfo()
		{
		}

		public KalturaAuditTrailTextInfo(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "info":
						this.Info = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("info", this.Info);
			return kparams;
		}
		#endregion
	}
}

