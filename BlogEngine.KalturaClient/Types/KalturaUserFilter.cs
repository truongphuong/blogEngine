using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaUserFilter : KalturaUserBaseFilter
	{
		#region Private Fields
		private string _IdEqual = null;
		private string _IdIn = null;
		private bool? _LoginEnabledEqual = false;
		private KalturaUserOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public string IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		public bool? LoginEnabledEqual
		{
			get { return _LoginEnabledEqual; }
			set 
			{ 
				_LoginEnabledEqual = value;
				OnPropertyChanged("LoginEnabledEqual");
			}
		}
		public new KalturaUserOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public KalturaUserFilter()
		{
		}

		public KalturaUserFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this.IdEqual = txt;
						continue;
					case "idIn":
						this.IdIn = txt;
						continue;
					case "loginEnabledEqual":
						this.LoginEnabledEqual = ParseBool(txt);
						continue;
					case "orderBy":
						this.OrderBy = (KalturaUserOrderBy)KalturaStringEnum.Parse(typeof(KalturaUserOrderBy), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("idEqual", this.IdEqual);
			kparams.AddStringIfNotNull("idIn", this.IdIn);
			kparams.AddBoolIfNotNull("loginEnabledEqual", this.LoginEnabledEqual);
			kparams.AddStringEnumIfNotNull("orderBy", this.OrderBy);
			return kparams;
		}
		#endregion
	}
}

