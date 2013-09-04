using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAdCuePointBaseFilter : KalturaCuePointFilter
	{
		#region Private Fields
		private KalturaAdProtocolType _ProtocolTypeEqual = null;
		private string _ProtocolTypeIn = null;
		private string _TitleLike = null;
		private string _TitleMultiLikeOr = null;
		private string _TitleMultiLikeAnd = null;
		private int _EndTimeGreaterThanOrEqual = Int32.MinValue;
		private int _EndTimeLessThanOrEqual = Int32.MinValue;
		private int _DurationGreaterThanOrEqual = Int32.MinValue;
		private int _DurationLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		public KalturaAdProtocolType ProtocolTypeEqual
		{
			get { return _ProtocolTypeEqual; }
			set 
			{ 
				_ProtocolTypeEqual = value;
				OnPropertyChanged("ProtocolTypeEqual");
			}
		}
		public string ProtocolTypeIn
		{
			get { return _ProtocolTypeIn; }
			set 
			{ 
				_ProtocolTypeIn = value;
				OnPropertyChanged("ProtocolTypeIn");
			}
		}
		public string TitleLike
		{
			get { return _TitleLike; }
			set 
			{ 
				_TitleLike = value;
				OnPropertyChanged("TitleLike");
			}
		}
		public string TitleMultiLikeOr
		{
			get { return _TitleMultiLikeOr; }
			set 
			{ 
				_TitleMultiLikeOr = value;
				OnPropertyChanged("TitleMultiLikeOr");
			}
		}
		public string TitleMultiLikeAnd
		{
			get { return _TitleMultiLikeAnd; }
			set 
			{ 
				_TitleMultiLikeAnd = value;
				OnPropertyChanged("TitleMultiLikeAnd");
			}
		}
		public int EndTimeGreaterThanOrEqual
		{
			get { return _EndTimeGreaterThanOrEqual; }
			set 
			{ 
				_EndTimeGreaterThanOrEqual = value;
				OnPropertyChanged("EndTimeGreaterThanOrEqual");
			}
		}
		public int EndTimeLessThanOrEqual
		{
			get { return _EndTimeLessThanOrEqual; }
			set 
			{ 
				_EndTimeLessThanOrEqual = value;
				OnPropertyChanged("EndTimeLessThanOrEqual");
			}
		}
		public int DurationGreaterThanOrEqual
		{
			get { return _DurationGreaterThanOrEqual; }
			set 
			{ 
				_DurationGreaterThanOrEqual = value;
				OnPropertyChanged("DurationGreaterThanOrEqual");
			}
		}
		public int DurationLessThanOrEqual
		{
			get { return _DurationLessThanOrEqual; }
			set 
			{ 
				_DurationLessThanOrEqual = value;
				OnPropertyChanged("DurationLessThanOrEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaAdCuePointBaseFilter()
		{
		}

		public KalturaAdCuePointBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "protocolTypeEqual":
						this.ProtocolTypeEqual = (KalturaAdProtocolType)KalturaStringEnum.Parse(typeof(KalturaAdProtocolType), txt);
						continue;
					case "protocolTypeIn":
						this.ProtocolTypeIn = txt;
						continue;
					case "titleLike":
						this.TitleLike = txt;
						continue;
					case "titleMultiLikeOr":
						this.TitleMultiLikeOr = txt;
						continue;
					case "titleMultiLikeAnd":
						this.TitleMultiLikeAnd = txt;
						continue;
					case "endTimeGreaterThanOrEqual":
						this.EndTimeGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "endTimeLessThanOrEqual":
						this.EndTimeLessThanOrEqual = ParseInt(txt);
						continue;
					case "durationGreaterThanOrEqual":
						this.DurationGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "durationLessThanOrEqual":
						this.DurationLessThanOrEqual = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringEnumIfNotNull("protocolTypeEqual", this.ProtocolTypeEqual);
			kparams.AddStringIfNotNull("protocolTypeIn", this.ProtocolTypeIn);
			kparams.AddStringIfNotNull("titleLike", this.TitleLike);
			kparams.AddStringIfNotNull("titleMultiLikeOr", this.TitleMultiLikeOr);
			kparams.AddStringIfNotNull("titleMultiLikeAnd", this.TitleMultiLikeAnd);
			kparams.AddIntIfNotNull("endTimeGreaterThanOrEqual", this.EndTimeGreaterThanOrEqual);
			kparams.AddIntIfNotNull("endTimeLessThanOrEqual", this.EndTimeLessThanOrEqual);
			kparams.AddIntIfNotNull("durationGreaterThanOrEqual", this.DurationGreaterThanOrEqual);
			kparams.AddIntIfNotNull("durationLessThanOrEqual", this.DurationLessThanOrEqual);
			return kparams;
		}
		#endregion
	}
}

