using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaString : KalturaObjectBase
	{
		#region Private Fields
		private string _Value = null;
		#endregion

		#region Properties
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
		public KalturaString()
		{
		}

		public KalturaString(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
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
			kparams.AddStringIfNotNull("value", this.Value);
			return kparams;
		}
		#endregion
	}
}

