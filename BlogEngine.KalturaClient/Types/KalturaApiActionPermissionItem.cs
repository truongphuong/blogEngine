using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaApiActionPermissionItem : KalturaPermissionItem
	{
		#region Private Fields
		private string _Service = null;
		private string _Action = null;
		#endregion

		#region Properties
		public string Service
		{
			get { return _Service; }
			set 
			{ 
				_Service = value;
				OnPropertyChanged("Service");
			}
		}
		public string Action
		{
			get { return _Action; }
			set 
			{ 
				_Action = value;
				OnPropertyChanged("Action");
			}
		}
		#endregion

		#region CTor
		public KalturaApiActionPermissionItem()
		{
		}

		public KalturaApiActionPermissionItem(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "service":
						this.Service = txt;
						continue;
					case "action":
						this.Action = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("service", this.Service);
			kparams.AddStringIfNotNull("action", this.Action);
			return kparams;
		}
		#endregion
	}
}

