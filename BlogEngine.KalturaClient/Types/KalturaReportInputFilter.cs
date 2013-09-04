using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaReportInputFilter : KalturaObjectBase
	{
		#region Private Fields
		private int _FromDate = Int32.MinValue;
		private int _ToDate = Int32.MinValue;
		private string _Keywords = null;
		private bool? _SearchInTags = false;
		private bool? _SearchInAdminTags = false;
		private string _Categories = null;
		private int _TimeZoneOffset = Int32.MinValue;
		#endregion

		#region Properties
		public int FromDate
		{
			get { return _FromDate; }
			set 
			{ 
				_FromDate = value;
				OnPropertyChanged("FromDate");
			}
		}
		public int ToDate
		{
			get { return _ToDate; }
			set 
			{ 
				_ToDate = value;
				OnPropertyChanged("ToDate");
			}
		}
		public string Keywords
		{
			get { return _Keywords; }
			set 
			{ 
				_Keywords = value;
				OnPropertyChanged("Keywords");
			}
		}
		public bool? SearchInTags
		{
			get { return _SearchInTags; }
			set 
			{ 
				_SearchInTags = value;
				OnPropertyChanged("SearchInTags");
			}
		}
		public bool? SearchInAdminTags
		{
			get { return _SearchInAdminTags; }
			set 
			{ 
				_SearchInAdminTags = value;
				OnPropertyChanged("SearchInAdminTags");
			}
		}
		public string Categories
		{
			get { return _Categories; }
			set 
			{ 
				_Categories = value;
				OnPropertyChanged("Categories");
			}
		}
		public int TimeZoneOffset
		{
			get { return _TimeZoneOffset; }
			set 
			{ 
				_TimeZoneOffset = value;
				OnPropertyChanged("TimeZoneOffset");
			}
		}
		#endregion

		#region CTor
		public KalturaReportInputFilter()
		{
		}

		public KalturaReportInputFilter(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "fromDate":
						this.FromDate = ParseInt(txt);
						continue;
					case "toDate":
						this.ToDate = ParseInt(txt);
						continue;
					case "keywords":
						this.Keywords = txt;
						continue;
					case "searchInTags":
						this.SearchInTags = ParseBool(txt);
						continue;
					case "searchInAdminTags":
						this.SearchInAdminTags = ParseBool(txt);
						continue;
					case "categories":
						this.Categories = txt;
						continue;
					case "timeZoneOffset":
						this.TimeZoneOffset = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("fromDate", this.FromDate);
			kparams.AddIntIfNotNull("toDate", this.ToDate);
			kparams.AddStringIfNotNull("keywords", this.Keywords);
			kparams.AddBoolIfNotNull("searchInTags", this.SearchInTags);
			kparams.AddBoolIfNotNull("searchInAdminTags", this.SearchInAdminTags);
			kparams.AddStringIfNotNull("categories", this.Categories);
			kparams.AddIntIfNotNull("timeZoneOffset", this.TimeZoneOffset);
			return kparams;
		}
		#endregion
	}
}

