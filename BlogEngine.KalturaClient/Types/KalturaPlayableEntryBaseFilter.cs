using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaPlayableEntryBaseFilter : KalturaBaseEntryFilter
	{
		#region Private Fields
		private int _DurationLessThan = Int32.MinValue;
		private int _DurationGreaterThan = Int32.MinValue;
		private int _DurationLessThanOrEqual = Int32.MinValue;
		private int _DurationGreaterThanOrEqual = Int32.MinValue;
		private int _MsDurationLessThan = Int32.MinValue;
		private int _MsDurationGreaterThan = Int32.MinValue;
		private int _MsDurationLessThanOrEqual = Int32.MinValue;
		private int _MsDurationGreaterThanOrEqual = Int32.MinValue;
		private string _DurationTypeMatchOr = null;
		#endregion

		#region Properties
		public int DurationLessThan
		{
			get { return _DurationLessThan; }
			set 
			{ 
				_DurationLessThan = value;
				OnPropertyChanged("DurationLessThan");
			}
		}
		public int DurationGreaterThan
		{
			get { return _DurationGreaterThan; }
			set 
			{ 
				_DurationGreaterThan = value;
				OnPropertyChanged("DurationGreaterThan");
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
		public int DurationGreaterThanOrEqual
		{
			get { return _DurationGreaterThanOrEqual; }
			set 
			{ 
				_DurationGreaterThanOrEqual = value;
				OnPropertyChanged("DurationGreaterThanOrEqual");
			}
		}
		public int MsDurationLessThan
		{
			get { return _MsDurationLessThan; }
			set 
			{ 
				_MsDurationLessThan = value;
				OnPropertyChanged("MsDurationLessThan");
			}
		}
		public int MsDurationGreaterThan
		{
			get { return _MsDurationGreaterThan; }
			set 
			{ 
				_MsDurationGreaterThan = value;
				OnPropertyChanged("MsDurationGreaterThan");
			}
		}
		public int MsDurationLessThanOrEqual
		{
			get { return _MsDurationLessThanOrEqual; }
			set 
			{ 
				_MsDurationLessThanOrEqual = value;
				OnPropertyChanged("MsDurationLessThanOrEqual");
			}
		}
		public int MsDurationGreaterThanOrEqual
		{
			get { return _MsDurationGreaterThanOrEqual; }
			set 
			{ 
				_MsDurationGreaterThanOrEqual = value;
				OnPropertyChanged("MsDurationGreaterThanOrEqual");
			}
		}
		public string DurationTypeMatchOr
		{
			get { return _DurationTypeMatchOr; }
			set 
			{ 
				_DurationTypeMatchOr = value;
				OnPropertyChanged("DurationTypeMatchOr");
			}
		}
		#endregion

		#region CTor
		public KalturaPlayableEntryBaseFilter()
		{
		}

		public KalturaPlayableEntryBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "durationLessThan":
						this.DurationLessThan = ParseInt(txt);
						continue;
					case "durationGreaterThan":
						this.DurationGreaterThan = ParseInt(txt);
						continue;
					case "durationLessThanOrEqual":
						this.DurationLessThanOrEqual = ParseInt(txt);
						continue;
					case "durationGreaterThanOrEqual":
						this.DurationGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "msDurationLessThan":
						this.MsDurationLessThan = ParseInt(txt);
						continue;
					case "msDurationGreaterThan":
						this.MsDurationGreaterThan = ParseInt(txt);
						continue;
					case "msDurationLessThanOrEqual":
						this.MsDurationLessThanOrEqual = ParseInt(txt);
						continue;
					case "msDurationGreaterThanOrEqual":
						this.MsDurationGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "durationTypeMatchOr":
						this.DurationTypeMatchOr = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("durationLessThan", this.DurationLessThan);
			kparams.AddIntIfNotNull("durationGreaterThan", this.DurationGreaterThan);
			kparams.AddIntIfNotNull("durationLessThanOrEqual", this.DurationLessThanOrEqual);
			kparams.AddIntIfNotNull("durationGreaterThanOrEqual", this.DurationGreaterThanOrEqual);
			kparams.AddIntIfNotNull("msDurationLessThan", this.MsDurationLessThan);
			kparams.AddIntIfNotNull("msDurationGreaterThan", this.MsDurationGreaterThan);
			kparams.AddIntIfNotNull("msDurationLessThanOrEqual", this.MsDurationLessThanOrEqual);
			kparams.AddIntIfNotNull("msDurationGreaterThanOrEqual", this.MsDurationGreaterThanOrEqual);
			kparams.AddStringIfNotNull("durationTypeMatchOr", this.DurationTypeMatchOr);
			return kparams;
		}
		#endregion
	}
}

