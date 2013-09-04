using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaCuePointBaseFilter : KalturaFilter
	{
		#region Private Fields
		private string _IdEqual = null;
		private string _IdIn = null;
		private KalturaCuePointType _CuePointTypeEqual = null;
		private string _CuePointTypeIn = null;
		private KalturaCuePointStatus _StatusEqual = (KalturaCuePointStatus)Int32.MinValue;
		private string _StatusIn = null;
		private string _EntryIdEqual = null;
		private string _EntryIdIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private string _TagsLike = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private int _StartTimeGreaterThanOrEqual = Int32.MinValue;
		private int _StartTimeLessThanOrEqual = Int32.MinValue;
		private string _UserIdEqual = null;
		private string _UserIdIn = null;
		private int _PartnerSortValueEqual = Int32.MinValue;
		private string _PartnerSortValueIn = null;
		private int _PartnerSortValueGreaterThanOrEqual = Int32.MinValue;
		private int _PartnerSortValueLessThanOrEqual = Int32.MinValue;
		private KalturaNullableBoolean _ForceStopEqual = (KalturaNullableBoolean)Int32.MinValue;
		private string _SystemNameEqual = null;
		private string _SystemNameIn = null;
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
		public KalturaCuePointType CuePointTypeEqual
		{
			get { return _CuePointTypeEqual; }
			set 
			{ 
				_CuePointTypeEqual = value;
				OnPropertyChanged("CuePointTypeEqual");
			}
		}
		public string CuePointTypeIn
		{
			get { return _CuePointTypeIn; }
			set 
			{ 
				_CuePointTypeIn = value;
				OnPropertyChanged("CuePointTypeIn");
			}
		}
		public KalturaCuePointStatus StatusEqual
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
		public string TagsLike
		{
			get { return _TagsLike; }
			set 
			{ 
				_TagsLike = value;
				OnPropertyChanged("TagsLike");
			}
		}
		public string TagsMultiLikeOr
		{
			get { return _TagsMultiLikeOr; }
			set 
			{ 
				_TagsMultiLikeOr = value;
				OnPropertyChanged("TagsMultiLikeOr");
			}
		}
		public string TagsMultiLikeAnd
		{
			get { return _TagsMultiLikeAnd; }
			set 
			{ 
				_TagsMultiLikeAnd = value;
				OnPropertyChanged("TagsMultiLikeAnd");
			}
		}
		public int StartTimeGreaterThanOrEqual
		{
			get { return _StartTimeGreaterThanOrEqual; }
			set 
			{ 
				_StartTimeGreaterThanOrEqual = value;
				OnPropertyChanged("StartTimeGreaterThanOrEqual");
			}
		}
		public int StartTimeLessThanOrEqual
		{
			get { return _StartTimeLessThanOrEqual; }
			set 
			{ 
				_StartTimeLessThanOrEqual = value;
				OnPropertyChanged("StartTimeLessThanOrEqual");
			}
		}
		public string UserIdEqual
		{
			get { return _UserIdEqual; }
			set 
			{ 
				_UserIdEqual = value;
				OnPropertyChanged("UserIdEqual");
			}
		}
		public string UserIdIn
		{
			get { return _UserIdIn; }
			set 
			{ 
				_UserIdIn = value;
				OnPropertyChanged("UserIdIn");
			}
		}
		public int PartnerSortValueEqual
		{
			get { return _PartnerSortValueEqual; }
			set 
			{ 
				_PartnerSortValueEqual = value;
				OnPropertyChanged("PartnerSortValueEqual");
			}
		}
		public string PartnerSortValueIn
		{
			get { return _PartnerSortValueIn; }
			set 
			{ 
				_PartnerSortValueIn = value;
				OnPropertyChanged("PartnerSortValueIn");
			}
		}
		public int PartnerSortValueGreaterThanOrEqual
		{
			get { return _PartnerSortValueGreaterThanOrEqual; }
			set 
			{ 
				_PartnerSortValueGreaterThanOrEqual = value;
				OnPropertyChanged("PartnerSortValueGreaterThanOrEqual");
			}
		}
		public int PartnerSortValueLessThanOrEqual
		{
			get { return _PartnerSortValueLessThanOrEqual; }
			set 
			{ 
				_PartnerSortValueLessThanOrEqual = value;
				OnPropertyChanged("PartnerSortValueLessThanOrEqual");
			}
		}
		public KalturaNullableBoolean ForceStopEqual
		{
			get { return _ForceStopEqual; }
			set 
			{ 
				_ForceStopEqual = value;
				OnPropertyChanged("ForceStopEqual");
			}
		}
		public string SystemNameEqual
		{
			get { return _SystemNameEqual; }
			set 
			{ 
				_SystemNameEqual = value;
				OnPropertyChanged("SystemNameEqual");
			}
		}
		public string SystemNameIn
		{
			get { return _SystemNameIn; }
			set 
			{ 
				_SystemNameIn = value;
				OnPropertyChanged("SystemNameIn");
			}
		}
		#endregion

		#region CTor
		public KalturaCuePointBaseFilter()
		{
		}

		public KalturaCuePointBaseFilter(XmlElement node) : base(node)
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
					case "cuePointTypeEqual":
						this.CuePointTypeEqual = (KalturaCuePointType)KalturaStringEnum.Parse(typeof(KalturaCuePointType), txt);
						continue;
					case "cuePointTypeIn":
						this.CuePointTypeIn = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaCuePointStatus)ParseEnum(typeof(KalturaCuePointStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "entryIdEqual":
						this.EntryIdEqual = txt;
						continue;
					case "entryIdIn":
						this.EntryIdIn = txt;
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
					case "tagsLike":
						this.TagsLike = txt;
						continue;
					case "tagsMultiLikeOr":
						this.TagsMultiLikeOr = txt;
						continue;
					case "tagsMultiLikeAnd":
						this.TagsMultiLikeAnd = txt;
						continue;
					case "startTimeGreaterThanOrEqual":
						this.StartTimeGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "startTimeLessThanOrEqual":
						this.StartTimeLessThanOrEqual = ParseInt(txt);
						continue;
					case "userIdEqual":
						this.UserIdEqual = txt;
						continue;
					case "userIdIn":
						this.UserIdIn = txt;
						continue;
					case "partnerSortValueEqual":
						this.PartnerSortValueEqual = ParseInt(txt);
						continue;
					case "partnerSortValueIn":
						this.PartnerSortValueIn = txt;
						continue;
					case "partnerSortValueGreaterThanOrEqual":
						this.PartnerSortValueGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "partnerSortValueLessThanOrEqual":
						this.PartnerSortValueLessThanOrEqual = ParseInt(txt);
						continue;
					case "forceStopEqual":
						this.ForceStopEqual = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "systemNameEqual":
						this.SystemNameEqual = txt;
						continue;
					case "systemNameIn":
						this.SystemNameIn = txt;
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
			kparams.AddStringEnumIfNotNull("cuePointTypeEqual", this.CuePointTypeEqual);
			kparams.AddStringIfNotNull("cuePointTypeIn", this.CuePointTypeIn);
			kparams.AddEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddStringIfNotNull("statusIn", this.StatusIn);
			kparams.AddStringIfNotNull("entryIdEqual", this.EntryIdEqual);
			kparams.AddStringIfNotNull("entryIdIn", this.EntryIdIn);
			kparams.AddIntIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddStringIfNotNull("tagsLike", this.TagsLike);
			kparams.AddStringIfNotNull("tagsMultiLikeOr", this.TagsMultiLikeOr);
			kparams.AddStringIfNotNull("tagsMultiLikeAnd", this.TagsMultiLikeAnd);
			kparams.AddIntIfNotNull("startTimeGreaterThanOrEqual", this.StartTimeGreaterThanOrEqual);
			kparams.AddIntIfNotNull("startTimeLessThanOrEqual", this.StartTimeLessThanOrEqual);
			kparams.AddStringIfNotNull("userIdEqual", this.UserIdEqual);
			kparams.AddStringIfNotNull("userIdIn", this.UserIdIn);
			kparams.AddIntIfNotNull("partnerSortValueEqual", this.PartnerSortValueEqual);
			kparams.AddStringIfNotNull("partnerSortValueIn", this.PartnerSortValueIn);
			kparams.AddIntIfNotNull("partnerSortValueGreaterThanOrEqual", this.PartnerSortValueGreaterThanOrEqual);
			kparams.AddIntIfNotNull("partnerSortValueLessThanOrEqual", this.PartnerSortValueLessThanOrEqual);
			kparams.AddEnumIfNotNull("forceStopEqual", this.ForceStopEqual);
			kparams.AddStringIfNotNull("systemNameEqual", this.SystemNameEqual);
			kparams.AddStringIfNotNull("systemNameIn", this.SystemNameIn);
			return kparams;
		}
		#endregion
	}
}

