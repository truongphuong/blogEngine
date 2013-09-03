using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaConversionAttribute : KalturaObjectBase
	{
		#region Private Fields
		private int _FlavorParamsId = Int32.MinValue;
		private string _Name = null;
		private string _Value = null;
		#endregion

		#region Properties
		public int FlavorParamsId
		{
			get { return _FlavorParamsId; }
			set 
			{ 
				_FlavorParamsId = value;
				OnPropertyChanged("FlavorParamsId");
			}
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
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
		public KalturaConversionAttribute()
		{
		}

		public KalturaConversionAttribute(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "flavorParamsId":
						this.FlavorParamsId = ParseInt(txt);
						continue;
					case "name":
						this.Name = txt;
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
			kparams.AddIntIfNotNull("flavorParamsId", this.FlavorParamsId);
			kparams.AddStringIfNotNull("name", this.Name);
			kparams.AddStringIfNotNull("value", this.Value);
			return kparams;
		}
		#endregion
	}
}

