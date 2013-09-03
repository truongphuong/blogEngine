using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSyndicationFeedEntryCount : KalturaObjectBase
	{
		#region Private Fields
		private int _TotalEntryCount = Int32.MinValue;
		private int _ActualEntryCount = Int32.MinValue;
		private int _RequireTranscodingCount = Int32.MinValue;
		#endregion

		#region Properties
		public int TotalEntryCount
		{
			get { return _TotalEntryCount; }
			set 
			{ 
				_TotalEntryCount = value;
				OnPropertyChanged("TotalEntryCount");
			}
		}
		public int ActualEntryCount
		{
			get { return _ActualEntryCount; }
			set 
			{ 
				_ActualEntryCount = value;
				OnPropertyChanged("ActualEntryCount");
			}
		}
		public int RequireTranscodingCount
		{
			get { return _RequireTranscodingCount; }
			set 
			{ 
				_RequireTranscodingCount = value;
				OnPropertyChanged("RequireTranscodingCount");
			}
		}
		#endregion

		#region CTor
		public KalturaSyndicationFeedEntryCount()
		{
		}

		public KalturaSyndicationFeedEntryCount(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "totalEntryCount":
						this.TotalEntryCount = ParseInt(txt);
						continue;
					case "actualEntryCount":
						this.ActualEntryCount = ParseInt(txt);
						continue;
					case "requireTranscodingCount":
						this.RequireTranscodingCount = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("totalEntryCount", this.TotalEntryCount);
			kparams.AddIntIfNotNull("actualEntryCount", this.ActualEntryCount);
			kparams.AddIntIfNotNull("requireTranscodingCount", this.RequireTranscodingCount);
			return kparams;
		}
		#endregion
	}
}

