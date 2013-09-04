using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaReportTable : KalturaObjectBase
	{
		#region Private Fields
		private string _Header = null;
		private string _Data = null;
		private int _TotalCount = Int32.MinValue;
		#endregion

		#region Properties
		public string Header
		{
			get { return _Header; }
			set 
			{ 
				_Header = value;
				OnPropertyChanged("Header");
			}
		}
		public string Data
		{
			get { return _Data; }
			set 
			{ 
				_Data = value;
				OnPropertyChanged("Data");
			}
		}
		public int TotalCount
		{
			get { return _TotalCount; }
			set 
			{ 
				_TotalCount = value;
				OnPropertyChanged("TotalCount");
			}
		}
		#endregion

		#region CTor
		public KalturaReportTable()
		{
		}

		public KalturaReportTable(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "header":
						this.Header = txt;
						continue;
					case "data":
						this.Data = txt;
						continue;
					case "totalCount":
						this.TotalCount = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("header", this.Header);
			kparams.AddStringIfNotNull("data", this.Data);
			kparams.AddIntIfNotNull("totalCount", this.TotalCount);
			return kparams;
		}
		#endregion
	}
}

