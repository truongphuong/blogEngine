using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaEntryDistributionBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _SubmittedAtGreaterThanOrEqual = Int32.MinValue;
		private int _SubmittedAtLessThanOrEqual = Int32.MinValue;
		private string _EntryIdEqual = null;
		private string _EntryIdIn = null;
		private int _DistributionProfileIdEqual = Int32.MinValue;
		private string _DistributionProfileIdIn = null;
		private KalturaEntryDistributionStatus _StatusEqual = (KalturaEntryDistributionStatus)Int32.MinValue;
		private string _StatusIn = null;
		private KalturaEntryDistributionFlag _DirtyStatusEqual = (KalturaEntryDistributionFlag)Int32.MinValue;
		private string _DirtyStatusIn = null;
		private int _SunriseGreaterThanOrEqual = Int32.MinValue;
		private int _SunriseLessThanOrEqual = Int32.MinValue;
		private int _SunsetGreaterThanOrEqual = Int32.MinValue;
		private int _SunsetLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		public int IdEqual
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
		public int SubmittedAtGreaterThanOrEqual
		{
			get { return _SubmittedAtGreaterThanOrEqual; }
			set 
			{ 
				_SubmittedAtGreaterThanOrEqual = value;
				OnPropertyChanged("SubmittedAtGreaterThanOrEqual");
			}
		}
		public int SubmittedAtLessThanOrEqual
		{
			get { return _SubmittedAtLessThanOrEqual; }
			set 
			{ 
				_SubmittedAtLessThanOrEqual = value;
				OnPropertyChanged("SubmittedAtLessThanOrEqual");
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
		public string EntryIdIn
		{
			get { return _EntryIdIn; }
			set 
			{ 
				_EntryIdIn = value;
				OnPropertyChanged("EntryIdIn");
			}
		}
		public int DistributionProfileIdEqual
		{
			get { return _DistributionProfileIdEqual; }
			set 
			{ 
				_DistributionProfileIdEqual = value;
				OnPropertyChanged("DistributionProfileIdEqual");
			}
		}
		public string DistributionProfileIdIn
		{
			get { return _DistributionProfileIdIn; }
			set 
			{ 
				_DistributionProfileIdIn = value;
				OnPropertyChanged("DistributionProfileIdIn");
			}
		}
		public KalturaEntryDistributionStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		public KalturaEntryDistributionFlag DirtyStatusEqual
		{
			get { return _DirtyStatusEqual; }
			set 
			{ 
				_DirtyStatusEqual = value;
				OnPropertyChanged("DirtyStatusEqual");
			}
		}
		public string DirtyStatusIn
		{
			get { return _DirtyStatusIn; }
			set 
			{ 
				_DirtyStatusIn = value;
				OnPropertyChanged("DirtyStatusIn");
			}
		}
		public int SunriseGreaterThanOrEqual
		{
			get { return _SunriseGreaterThanOrEqual; }
			set 
			{ 
				_SunriseGreaterThanOrEqual = value;
				OnPropertyChanged("SunriseGreaterThanOrEqual");
			}
		}
		public int SunriseLessThanOrEqual
		{
			get { return _SunriseLessThanOrEqual; }
			set 
			{ 
				_SunriseLessThanOrEqual = value;
				OnPropertyChanged("SunriseLessThanOrEqual");
			}
		}
		public int SunsetGreaterThanOrEqual
		{
			get { return _SunsetGreaterThanOrEqual; }
			set 
			{ 
				_SunsetGreaterThanOrEqual = value;
				OnPropertyChanged("SunsetGreaterThanOrEqual");
			}
		}
		public int SunsetLessThanOrEqual
		{
			get { return _SunsetLessThanOrEqual; }
			set 
			{ 
				_SunsetLessThanOrEqual = value;
				OnPropertyChanged("SunsetLessThanOrEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaEntryDistributionBaseFilter()
		{
		}

		public KalturaEntryDistributionBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this.IdEqual = ParseInt(txt);
						continue;
					case "idIn":
						this.IdIn = txt;
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
					case "submittedAtGreaterThanOrEqual":
						this.SubmittedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "submittedAtLessThanOrEqual":
						this.SubmittedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "entryIdEqual":
						this.EntryIdEqual = txt;
						continue;
					case "entryIdIn":
						this.EntryIdIn = txt;
						continue;
					case "distributionProfileIdEqual":
						this.DistributionProfileIdEqual = ParseInt(txt);
						continue;
					case "distributionProfileIdIn":
						this.DistributionProfileIdIn = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaEntryDistributionStatus)ParseEnum(typeof(KalturaEntryDistributionStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "dirtyStatusEqual":
						this.DirtyStatusEqual = (KalturaEntryDistributionFlag)ParseEnum(typeof(KalturaEntryDistributionFlag), txt);
						continue;
					case "dirtyStatusIn":
						this.DirtyStatusIn = txt;
						continue;
					case "sunriseGreaterThanOrEqual":
						this.SunriseGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "sunriseLessThanOrEqual":
						this.SunriseLessThanOrEqual = ParseInt(txt);
						continue;
					case "sunsetGreaterThanOrEqual":
						this.SunsetGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "sunsetLessThanOrEqual":
						this.SunsetLessThanOrEqual = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("idEqual", this.IdEqual);
			kparams.AddStringIfNotNull("idIn", this.IdIn);
			kparams.AddIntIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("submittedAtGreaterThanOrEqual", this.SubmittedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("submittedAtLessThanOrEqual", this.SubmittedAtLessThanOrEqual);
			kparams.AddStringIfNotNull("entryIdEqual", this.EntryIdEqual);
			kparams.AddStringIfNotNull("entryIdIn", this.EntryIdIn);
			kparams.AddIntIfNotNull("distributionProfileIdEqual", this.DistributionProfileIdEqual);
			kparams.AddStringIfNotNull("distributionProfileIdIn", this.DistributionProfileIdIn);
			kparams.AddEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddStringIfNotNull("statusIn", this.StatusIn);
			kparams.AddEnumIfNotNull("dirtyStatusEqual", this.DirtyStatusEqual);
			kparams.AddStringIfNotNull("dirtyStatusIn", this.DirtyStatusIn);
			kparams.AddIntIfNotNull("sunriseGreaterThanOrEqual", this.SunriseGreaterThanOrEqual);
			kparams.AddIntIfNotNull("sunriseLessThanOrEqual", this.SunriseLessThanOrEqual);
			kparams.AddIntIfNotNull("sunsetGreaterThanOrEqual", this.SunsetGreaterThanOrEqual);
			kparams.AddIntIfNotNull("sunsetLessThanOrEqual", this.SunsetLessThanOrEqual);
			return kparams;
		}
		#endregion
	}
}

