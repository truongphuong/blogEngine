using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaKeyValue : KalturaObjectBase
	{
		#region Private Fields
		private string _Key = null;
		private string _Value = null;
		#endregion

		#region Properties
		public string Key
		{
			get { return _Key; }
			set 
			{ 
				_Key = value;
				OnPropertyChanged("Key");
			}
		}
		public string Value
		{
			get { return _Value; }
			set 
			{ 
				_Value = value;
				OnPropertyChanged("Value");
			}
		}
		#endregion

		#region CTor
		public KalturaKeyValue()
		{
		}

		public KalturaKeyValue(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "key":
						this.Key = txt;
						continue;
					case "value":
						this.Value = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("key", this.Key);
			kparams.AddStringIfNotNull("value", this.Value);
			return kparams;
		}
		#endregion
	}
}

