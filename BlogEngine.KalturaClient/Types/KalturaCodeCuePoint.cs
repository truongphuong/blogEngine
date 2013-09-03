using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaCodeCuePoint : KalturaCuePoint
	{
		#region Private Fields
		private string _Code = null;
		private string _Description = null;
		#endregion

		#region Properties
		public string Code
		{
			get { return _Code; }
			set 
			{ 
				_Code = value;
				OnPropertyChanged("Code");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		#endregion

		#region CTor
		public KalturaCodeCuePoint()
		{
		}

		public KalturaCodeCuePoint(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "code":
						this.Code = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("code", this.Code);
			kparams.AddStringIfNotNull("description", this.Description);
			return kparams;
		}
		#endregion
	}
}

