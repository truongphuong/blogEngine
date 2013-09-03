using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaWidgetBaseFilter : KalturaFilter
	{
		#region Private Fields
		private string _IdEqual = null;
		private string _IdIn = null;
		private string _SourceWidgetIdEqual = null;
		private string _RootWidgetIdEqual = null;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _EntryIdEqual = null;
		private int _UiConfIdEqual = Int32.MinValue;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private string _PartnerDataLike = null;
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
		public string SourceWidgetIdEqual
		{
			get { return _SourceWidgetIdEqual; }
			set 
			{ 
				_SourceWidgetIdEqual = value;
				OnPropertyChanged("SourceWidgetIdEqual");
			}
		}
		public string RootWidgetIdEqual
		{
			get { return _RootWidgetIdEqual; }
			set 
			{ 
				_RootWidgetIdEqual = value;
				OnPropertyChanged("RootWidgetIdEqual");
			}
		}
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public string EntryIdEqual
		{
			get { return _EntryIdEqual; }
			set 
			{ 
				_EntryIdEqual = value;
				OnPropertyChanged("EntryIdEqual");
			}
		}
		public int UiConfIdEqual
		{
			get { return _UiConfIdEqual; }
			set 
			{ 
				_UiConfIdEqual = value;
				OnPropertyChanged("UiConfIdEqual");
			}
		}
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		public string PartnerDataLike
		{
			get { return _PartnerDataLike; }
			set 
			{ 
				_PartnerDataLike = value;
				OnPropertyChanged("PartnerDataLike");
			}
		}
		#endregion

		#region CTor
		public KalturaWidgetBaseFilter()
		{
		}

		public KalturaWidgetBaseFilter(XmlElement node) : base(node)
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
					case "sourceWidgetIdEqual":
						this.SourceWidgetIdEqual = txt;
						continue;
					case "rootWidgetIdEqual":
						this.RootWidgetIdEqual = txt;
						continue;
					case "partnerIdEqual":
						this.PartnerIdEqual = ParseInt(txt);
						continue;
					case "entryIdEqual":
						this.EntryIdEqual = txt;
						continue;
					case "uiConfIdEqual":
						this.UiConfIdEqual = ParseInt(txt);
						continue;
					case "createdAtGreaterThanOrEqual":
						this.CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this.CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this.UpdatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtLessThanOrEqual":
						this.UpdatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "partnerDataLike":
						this.PartnerDataLike = txt;
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
			kparams.AddStringIfNotNull("sourceWidgetIdEqual", this.SourceWidgetIdEqual);
			kparams.AddStringIfNotNull("rootWidgetIdEqual", this.RootWidgetIdEqual);
			kparams.AddIntIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddStringIfNotNull("entryIdEqual", this.EntryIdEqual);
			kparams.AddIntIfNotNull("uiConfIdEqual", this.UiConfIdEqual);
			kparams.AddIntIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddStringIfNotNull("partnerDataLike", this.PartnerDataLike);
			return kparams;
		}
		#endregion
	}
}

