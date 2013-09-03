using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSystemPartnerUsageFilter : KalturaFilter
	{
		#region Private Fields
		private int _FromDate = Int32.MinValue;
		private int _ToDate = Int32.MinValue;
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
		#endregion

		#region CTor
		public KalturaSystemPartnerUsageFilter()
		{
		}

		public KalturaSystemPartnerUsageFilter(XmlElement node) : base(node)
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
			return kparams;
		}
		#endregion
	}
}

