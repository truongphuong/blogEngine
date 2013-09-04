using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAuditTrailChangeItem : KalturaObjectBase
	{
		#region Private Fields
		private string _Descriptor = null;
		private string _OldValue = null;
		private string _NewValue = null;
		#endregion

		#region Properties
		public string Descriptor
		{
			get { return _Descriptor; }
			set 
			{ 
				_Descriptor = value;
				OnPropertyChanged("Descriptor");
			}
		}
		public string OldValue
		{
			get { return _OldValue; }
			set 
			{ 
				_OldValue = value;
				OnPropertyChanged("OldValue");
			}
		}
		public string NewValue
		{
			get { return _NewValue; }
			set 
			{ 
				_NewValue = value;
				OnPropertyChanged("NewValue");
			}
		}
		#endregion

		#region CTor
		public KalturaAuditTrailChangeItem()
		{
		}

		public KalturaAuditTrailChangeItem(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "descriptor":
						this.Descriptor = txt;
						continue;
					case "oldValue":
						this.OldValue = txt;
						continue;
					case "newValue":
						this.NewValue = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("descriptor", this.Descriptor);
			kparams.AddStringIfNotNull("oldValue", this.OldValue);
			kparams.AddStringIfNotNull("newValue", this.NewValue);
			return kparams;
		}
		#endregion
	}
}

