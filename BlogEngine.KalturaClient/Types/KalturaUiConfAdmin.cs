using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaUiConfAdmin : KalturaUiConf
	{
		#region Private Fields
		private bool? _IsPublic = false;
		#endregion

		#region Properties
		public bool? IsPublic
		{
			get { return _IsPublic; }
			set 
			{ 
				_IsPublic = value;
				OnPropertyChanged("IsPublic");
			}
		}
		#endregion

		#region CTor
		public KalturaUiConfAdmin()
		{
		}

		public KalturaUiConfAdmin(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "isPublic":
						this.IsPublic = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddBoolIfNotNull("isPublic", this.IsPublic);
			return kparams;
		}
		#endregion
	}
}

