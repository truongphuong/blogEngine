using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaBulkUploadPluginData : KalturaObjectBase
	{
		#region Private Fields
		private string _Field = null;
		private string _Value = null;
		#endregion

		#region Properties
		public string Field
		{
			get { return _Field; }
			set 
			{ 
				_Field = value;
				OnPropertyChanged("Field");
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
		public KalturaBulkUploadPluginData()
		{
		}

		public KalturaBulkUploadPluginData(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "field":
						this.Field = txt;
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
			kparams.AddStringIfNotNull("field", this.Field);
			kparams.AddStringIfNotNull("value", this.Value);
			return kparams;
		}
		#endregion
	}
}

