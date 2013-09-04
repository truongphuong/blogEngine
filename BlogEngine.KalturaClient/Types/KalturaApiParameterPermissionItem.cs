using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaApiParameterPermissionItem : KalturaPermissionItem
	{
		#region Private Fields
		private string _Object = null;
		private string _Parameter = null;
		private KalturaApiParameterPermissionItemAction _Action = null;
		#endregion

		#region Properties
		public string Object
		{
			get { return _Object; }
			set 
			{ 
				_Object = value;
				OnPropertyChanged("Object");
			}
		}
		public string Parameter
		{
			get { return _Parameter; }
			set 
			{ 
				_Parameter = value;
				OnPropertyChanged("Parameter");
			}
		}
		public KalturaApiParameterPermissionItemAction Action
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
		public KalturaApiParameterPermissionItem()
		{
		}

		public KalturaApiParameterPermissionItem(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "object":
						this.Object = txt;
						continue;
					case "parameter":
						this.Parameter = txt;
						continue;
					case "action":
						this.Action = (KalturaApiParameterPermissionItemAction)KalturaStringEnum.Parse(typeof(KalturaApiParameterPermissionItemAction), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("object", this.Object);
			kparams.AddStringIfNotNull("parameter", this.Parameter);
			kparams.AddStringEnumIfNotNull("action", this.Action);
			return kparams;
		}
		#endregion
	}
}

