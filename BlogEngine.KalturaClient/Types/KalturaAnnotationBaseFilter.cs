using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAnnotationBaseFilter : KalturaCuePointFilter
	{
		#region Private Fields
		private string _ParentIdEqual = null;
		private string _ParentIdIn = null;
		private string _TextLike = null;
		private string _TextMultiLikeOr = null;
		private string _TextMultiLikeAnd = null;
		private int _EndTimeGreaterThanOrEqual = Int32.MinValue;
		private int _EndTimeLessThanOrEqual = Int32.MinValue;
		private int _DurationGreaterThanOrEqual = Int32.MinValue;
		private int _DurationLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		public string ParentIdEqual
		{
			get { return _ParentIdEqual; }
			set 
			{ 
				_ParentIdEqual = value;
				OnPropertyChanged("ParentIdEqual");
			}
		}
		public string ParentIdIn
		{
			get { return _ParentIdIn; }
			set 
			{ 
				_ParentIdIn = value;
				OnPropertyChanged("ParentIdIn");
			}
		}
		public string TextLike
		{
			get { return _TextLike; }
			set 
			{ 
				_TextLike = value;
				OnPropertyChanged("TextLike");
			}
		}
		public string TextMultiLikeOr
		{
			get { return _TextMultiLikeOr; }
			set 
			{ 
				_TextMultiLikeOr = value;
				OnPropertyChanged("TextMultiLikeOr");
			}
		}
		public string TextMultiLikeAnd
		{
			get { return _TextMultiLikeAnd; }
			set 
			{ 
				_TextMultiLikeAnd = value;
				OnPropertyChanged("TextMultiLikeAnd");
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
		public KalturaAnnotationBaseFilter()
		{
		}

		public KalturaAnnotationBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "parentIdEqual":
						this.ParentIdEqual = txt;
						continue;
					case "parentIdIn":
						this.ParentIdIn = txt;
						continue;
					case "textLike":
						this.TextLike = txt;
						continue;
					case "textMultiLikeOr":
						this.TextMultiLikeOr = txt;
						continue;
					case "textMultiLikeAnd":
						this.TextMultiLikeAnd = txt;
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
			kparams.AddStringIfNotNull("parentIdEqual", this.ParentIdEqual);
			kparams.AddStringIfNotNull("parentIdIn", this.ParentIdIn);
			kparams.AddStringIfNotNull("textLike", this.TextLike);
			kparams.AddStringIfNotNull("textMultiLikeOr", this.TextMultiLikeOr);
			kparams.AddStringIfNotNull("textMultiLikeAnd", this.TextMultiLikeAnd);
			kparams.AddIntIfNotNull("endTimeGreaterThanOrEqual", this.EndTimeGreaterThanOrEqual);
			kparams.AddIntIfNotNull("endTimeLessThanOrEqual", this.EndTimeLessThanOrEqual);
			kparams.AddIntIfNotNull("durationGreaterThanOrEqual", this.DurationGreaterThanOrEqual);
			kparams.AddIntIfNotNull("durationLessThanOrEqual", this.DurationLessThanOrEqual);
			return kparams;
		}
		#endregion
	}
}

