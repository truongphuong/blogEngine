using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaBaseEntryBaseFilter : KalturaFilter
	{
		#region Private Fields
		private string _IdEqual = null;
		private string _IdIn = null;
		private string _IdNotIn = null;
		private string _NameLike = null;
		private string _NameMultiLikeOr = null;
		private string _NameMultiLikeAnd = null;
		private string _NameEqual = null;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private string _UserIdEqual = null;
		private string _TagsLike = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private string _AdminTagsLike = null;
		private string _AdminTagsMultiLikeOr = null;
		private string _AdminTagsMultiLikeAnd = null;
		private string _CategoriesMatchAnd = null;
		private string _CategoriesMatchOr = null;
		private string _CategoriesIdsMatchAnd = null;
		private string _CategoriesIdsMatchOr = null;
		private KalturaEntryStatus _StatusEqual = null;
		private KalturaEntryStatus _StatusNotEqual = null;
		private string _StatusIn = null;
		private string _StatusNotIn = null;
		private KalturaEntryModerationStatus _ModerationStatusEqual = (KalturaEntryModerationStatus)Int32.MinValue;
		private KalturaEntryModerationStatus _ModerationStatusNotEqual = (KalturaEntryModerationStatus)Int32.MinValue;
		private string _ModerationStatusIn = null;
		private string _ModerationStatusNotIn = null;
		private KalturaEntryType _TypeEqual = null;
		private string _TypeIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _GroupIdEqual = Int32.MinValue;
		private string _SearchTextMatchAnd = null;
		private string _SearchTextMatchOr = null;
		private int _AccessControlIdEqual = Int32.MinValue;
		private string _AccessControlIdIn = null;
		private int _StartDateGreaterThanOrEqual = Int32.MinValue;
		private int _StartDateLessThanOrEqual = Int32.MinValue;
		private int _StartDateGreaterThanOrEqualOrNull = Int32.MinValue;
		private int _StartDateLessThanOrEqualOrNull = Int32.MinValue;
		private int _EndDateGreaterThanOrEqual = Int32.MinValue;
		private int _EndDateLessThanOrEqual = Int32.MinValue;
		private int _EndDateGreaterThanOrEqualOrNull = Int32.MinValue;
		private int _EndDateLessThanOrEqualOrNull = Int32.MinValue;
		private string _ReferenceIdEqual = null;
		private string _ReferenceIdIn = null;
		private string _ReplacingEntryIdEqual = null;
		private string _ReplacingEntryIdIn = null;
		private string _ReplacedEntryIdEqual = null;
		private string _ReplacedEntryIdIn = null;
		private KalturaEntryReplacementStatus _ReplacementStatusEqual = null;
		private string _ReplacementStatusIn = null;
		private int _PartnerSortValueGreaterThanOrEqual = Int32.MinValue;
		private int _PartnerSortValueLessThanOrEqual = Int32.MinValue;
		private string _RootEntryIdEqual = null;
		private string _RootEntryIdIn = null;
		private string _TagsNameMultiLikeOr = null;
		private string _TagsAdminTagsMultiLikeOr = null;
		private string _TagsAdminTagsNameMultiLikeOr = null;
		private string _TagsNameMultiLikeAnd = null;
		private string _TagsAdminTagsMultiLikeAnd = null;
		private string _TagsAdminTagsNameMultiLikeAnd = null;
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
		public string IdNotIn
		{
			get { return _IdNotIn; }
			set 
			{ 
				_IdNotIn = value;
				OnPropertyChanged("IdNotIn");
			}
		}
		public string NameLike
		{
			get { return _NameLike; }
			set 
			{ 
				_NameLike = value;
				OnPropertyChanged("NameLike");
			}
		}
		public string NameMultiLikeOr
		{
			get { return _NameMultiLikeOr; }
			set 
			{ 
				_NameMultiLikeOr = value;
				OnPropertyChanged("NameMultiLikeOr");
			}
		}
		public string NameMultiLikeAnd
		{
			get { return _NameMultiLikeAnd; }
			set 
			{ 
				_NameMultiLikeAnd = value;
				OnPropertyChanged("NameMultiLikeAnd");
			}
		}
		public string NameEqual
		{
			get { return _NameEqual; }
			set 
			{ 
				_NameEqual = value;
				OnPropertyChanged("NameEqual");
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
		public string PartnerIdIn
		{
			get { return _PartnerIdIn; }
			set 
			{ 
				_PartnerIdIn = value;
				OnPropertyChanged("PartnerIdIn");
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
		public string AdminTagsLike
		{
			get { return _AdminTagsLike; }
			set 
			{ 
				_AdminTagsLike = value;
				OnPropertyChanged("AdminTagsLike");
			}
		}
		public string AdminTagsMultiLikeOr
		{
			get { return _AdminTagsMultiLikeOr; }
			set 
			{ 
				_AdminTagsMultiLikeOr = value;
				OnPropertyChanged("AdminTagsMultiLikeOr");
			}
		}
		public string AdminTagsMultiLikeAnd
		{
			get { return _AdminTagsMultiLikeAnd; }
			set 
			{ 
				_AdminTagsMultiLikeAnd = value;
				OnPropertyChanged("AdminTagsMultiLikeAnd");
			}
		}
		public string CategoriesMatchAnd
		{
			get { return _CategoriesMatchAnd; }
			set 
			{ 
				_CategoriesMatchAnd = value;
				OnPropertyChanged("CategoriesMatchAnd");
			}
		}
		public string CategoriesMatchOr
		{
			get { return _CategoriesMatchOr; }
			set 
			{ 
				_CategoriesMatchOr = value;
				OnPropertyChanged("CategoriesMatchOr");
			}
		}
		public string CategoriesIdsMatchAnd
		{
			get { return _CategoriesIdsMatchAnd; }
			set 
			{ 
				_CategoriesIdsMatchAnd = value;
				OnPropertyChanged("CategoriesIdsMatchAnd");
			}
		}
		public string CategoriesIdsMatchOr
		{
			get { return _CategoriesIdsMatchOr; }
			set 
			{ 
				_CategoriesIdsMatchOr = value;
				OnPropertyChanged("CategoriesIdsMatchOr");
			}
		}
		public KalturaEntryStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public KalturaEntryStatus StatusNotEqual
		{
			get { return _StatusNotEqual; }
			set 
			{ 
				_StatusNotEqual = value;
				OnPropertyChanged("StatusNotEqual");
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
		public string StatusNotIn
		{
			get { return _StatusNotIn; }
			set 
			{ 
				_StatusNotIn = value;
				OnPropertyChanged("StatusNotIn");
			}
		}
		public KalturaEntryModerationStatus ModerationStatusEqual
		{
			get { return _ModerationStatusEqual; }
			set 
			{ 
				_ModerationStatusEqual = value;
				OnPropertyChanged("ModerationStatusEqual");
			}
		}
		public KalturaEntryModerationStatus ModerationStatusNotEqual
		{
			get { return _ModerationStatusNotEqual; }
			set 
			{ 
				_ModerationStatusNotEqual = value;
				OnPropertyChanged("ModerationStatusNotEqual");
			}
		}
		public string ModerationStatusIn
		{
			get { return _ModerationStatusIn; }
			set 
			{ 
				_ModerationStatusIn = value;
				OnPropertyChanged("ModerationStatusIn");
			}
		}
		public string ModerationStatusNotIn
		{
			get { return _ModerationStatusNotIn; }
			set 
			{ 
				_ModerationStatusNotIn = value;
				OnPropertyChanged("ModerationStatusNotIn");
			}
		}
		public KalturaEntryType TypeEqual
		{
			get { return _TypeEqual; }
			set 
			{ 
				_TypeEqual = value;
				OnPropertyChanged("TypeEqual");
			}
		}
		public string TypeIn
		{
			get { return _TypeIn; }
			set 
			{ 
				_TypeIn = value;
				OnPropertyChanged("TypeIn");
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
		public int GroupIdEqual
		{
			get { return _GroupIdEqual; }
			set 
			{ 
				_GroupIdEqual = value;
				OnPropertyChanged("GroupIdEqual");
			}
		}
		public string SearchTextMatchAnd
		{
			get { return _SearchTextMatchAnd; }
			set 
			{ 
				_SearchTextMatchAnd = value;
				OnPropertyChanged("SearchTextMatchAnd");
			}
		}
		public string SearchTextMatchOr
		{
			get { return _SearchTextMatchOr; }
			set 
			{ 
				_SearchTextMatchOr = value;
				OnPropertyChanged("SearchTextMatchOr");
			}
		}
		public int AccessControlIdEqual
		{
			get { return _AccessControlIdEqual; }
			set 
			{ 
				_AccessControlIdEqual = value;
				OnPropertyChanged("AccessControlIdEqual");
			}
		}
		public string AccessControlIdIn
		{
			get { return _AccessControlIdIn; }
			set 
			{ 
				_AccessControlIdIn = value;
				OnPropertyChanged("AccessControlIdIn");
			}
		}
		public int StartDateGreaterThanOrEqual
		{
			get { return _StartDateGreaterThanOrEqual; }
			set 
			{ 
				_StartDateGreaterThanOrEqual = value;
				OnPropertyChanged("StartDateGreaterThanOrEqual");
			}
		}
		public int StartDateLessThanOrEqual
		{
			get { return _StartDateLessThanOrEqual; }
			set 
			{ 
				_StartDateLessThanOrEqual = value;
				OnPropertyChanged("StartDateLessThanOrEqual");
			}
		}
		public int StartDateGreaterThanOrEqualOrNull
		{
			get { return _StartDateGreaterThanOrEqualOrNull; }
			set 
			{ 
				_StartDateGreaterThanOrEqualOrNull = value;
				OnPropertyChanged("StartDateGreaterThanOrEqualOrNull");
			}
		}
		public int StartDateLessThanOrEqualOrNull
		{
			get { return _StartDateLessThanOrEqualOrNull; }
			set 
			{ 
				_StartDateLessThanOrEqualOrNull = value;
				OnPropertyChanged("StartDateLessThanOrEqualOrNull");
			}
		}
		public int EndDateGreaterThanOrEqual
		{
			get { return _EndDateGreaterThanOrEqual; }
			set 
			{ 
				_EndDateGreaterThanOrEqual = value;
				OnPropertyChanged("EndDateGreaterThanOrEqual");
			}
		}
		public int EndDateLessThanOrEqual
		{
			get { return _EndDateLessThanOrEqual; }
			set 
			{ 
				_EndDateLessThanOrEqual = value;
				OnPropertyChanged("EndDateLessThanOrEqual");
			}
		}
		public int EndDateGreaterThanOrEqualOrNull
		{
			get { return _EndDateGreaterThanOrEqualOrNull; }
			set 
			{ 
				_EndDateGreaterThanOrEqualOrNull = value;
				OnPropertyChanged("EndDateGreaterThanOrEqualOrNull");
			}
		}
		public int EndDateLessThanOrEqualOrNull
		{
			get { return _EndDateLessThanOrEqualOrNull; }
			set 
			{ 
				_EndDateLessThanOrEqualOrNull = value;
				OnPropertyChanged("EndDateLessThanOrEqualOrNull");
			}
		}
		public string ReferenceIdEqual
		{
			get { return _ReferenceIdEqual; }
			set 
			{ 
				_ReferenceIdEqual = value;
				OnPropertyChanged("ReferenceIdEqual");
			}
		}
		public string ReferenceIdIn
		{
			get { return _ReferenceIdIn; }
			set 
			{ 
				_ReferenceIdIn = value;
				OnPropertyChanged("ReferenceIdIn");
			}
		}
		public string ReplacingEntryIdEqual
		{
			get { return _ReplacingEntryIdEqual; }
			set 
			{ 
				_ReplacingEntryIdEqual = value;
				OnPropertyChanged("ReplacingEntryIdEqual");
			}
		}
		public string ReplacingEntryIdIn
		{
			get { return _ReplacingEntryIdIn; }
			set 
			{ 
				_ReplacingEntryIdIn = value;
				OnPropertyChanged("ReplacingEntryIdIn");
			}
		}
		public string ReplacedEntryIdEqual
		{
			get { return _ReplacedEntryIdEqual; }
			set 
			{ 
				_ReplacedEntryIdEqual = value;
				OnPropertyChanged("ReplacedEntryIdEqual");
			}
		}
		public string ReplacedEntryIdIn
		{
			get { return _ReplacedEntryIdIn; }
			set 
			{ 
				_ReplacedEntryIdIn = value;
				OnPropertyChanged("ReplacedEntryIdIn");
			}
		}
		public KalturaEntryReplacementStatus ReplacementStatusEqual
		{
			get { return _ReplacementStatusEqual; }
			set 
			{ 
				_ReplacementStatusEqual = value;
				OnPropertyChanged("ReplacementStatusEqual");
			}
		}
		public string ReplacementStatusIn
		{
			get { return _ReplacementStatusIn; }
			set 
			{ 
				_ReplacementStatusIn = value;
				OnPropertyChanged("ReplacementStatusIn");
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
		public string RootEntryIdEqual
		{
			get { return _RootEntryIdEqual; }
			set 
			{ 
				_RootEntryIdEqual = value;
				OnPropertyChanged("RootEntryIdEqual");
			}
		}
		public string RootEntryIdIn
		{
			get { return _RootEntryIdIn; }
			set 
			{ 
				_RootEntryIdIn = value;
				OnPropertyChanged("RootEntryIdIn");
			}
		}
		public string TagsNameMultiLikeOr
		{
			get { return _TagsNameMultiLikeOr; }
			set 
			{ 
				_TagsNameMultiLikeOr = value;
				OnPropertyChanged("TagsNameMultiLikeOr");
			}
		}
		public string TagsAdminTagsMultiLikeOr
		{
			get { return _TagsAdminTagsMultiLikeOr; }
			set 
			{ 
				_TagsAdminTagsMultiLikeOr = value;
				OnPropertyChanged("TagsAdminTagsMultiLikeOr");
			}
		}
		public string TagsAdminTagsNameMultiLikeOr
		{
			get { return _TagsAdminTagsNameMultiLikeOr; }
			set 
			{ 
				_TagsAdminTagsNameMultiLikeOr = value;
				OnPropertyChanged("TagsAdminTagsNameMultiLikeOr");
			}
		}
		public string TagsNameMultiLikeAnd
		{
			get { return _TagsNameMultiLikeAnd; }
			set 
			{ 
				_TagsNameMultiLikeAnd = value;
				OnPropertyChanged("TagsNameMultiLikeAnd");
			}
		}
		public string TagsAdminTagsMultiLikeAnd
		{
			get { return _TagsAdminTagsMultiLikeAnd; }
			set 
			{ 
				_TagsAdminTagsMultiLikeAnd = value;
				OnPropertyChanged("TagsAdminTagsMultiLikeAnd");
			}
		}
		public string TagsAdminTagsNameMultiLikeAnd
		{
			get { return _TagsAdminTagsNameMultiLikeAnd; }
			set 
			{ 
				_TagsAdminTagsNameMultiLikeAnd = value;
				OnPropertyChanged("TagsAdminTagsNameMultiLikeAnd");
			}
		}
		#endregion

		#region CTor
		public KalturaBaseEntryBaseFilter()
		{
		}

		public KalturaBaseEntryBaseFilter(XmlElement node) : base(node)
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
					case "idNotIn":
						this.IdNotIn = txt;
						continue;
					case "nameLike":
						this.NameLike = txt;
						continue;
					case "nameMultiLikeOr":
						this.NameMultiLikeOr = txt;
						continue;
					case "nameMultiLikeAnd":
						this.NameMultiLikeAnd = txt;
						continue;
					case "nameEqual":
						this.NameEqual = txt;
						continue;
					case "partnerIdEqual":
						this.PartnerIdEqual = ParseInt(txt);
						continue;
					case "partnerIdIn":
						this.PartnerIdIn = txt;
						continue;
					case "userIdEqual":
						this.UserIdEqual = txt;
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
					case "adminTagsLike":
						this.AdminTagsLike = txt;
						continue;
					case "adminTagsMultiLikeOr":
						this.AdminTagsMultiLikeOr = txt;
						continue;
					case "adminTagsMultiLikeAnd":
						this.AdminTagsMultiLikeAnd = txt;
						continue;
					case "categoriesMatchAnd":
						this.CategoriesMatchAnd = txt;
						continue;
					case "categoriesMatchOr":
						this.CategoriesMatchOr = txt;
						continue;
					case "categoriesIdsMatchAnd":
						this.CategoriesIdsMatchAnd = txt;
						continue;
					case "categoriesIdsMatchOr":
						this.CategoriesIdsMatchOr = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaEntryStatus)KalturaStringEnum.Parse(typeof(KalturaEntryStatus), txt);
						continue;
					case "statusNotEqual":
						this.StatusNotEqual = (KalturaEntryStatus)KalturaStringEnum.Parse(typeof(KalturaEntryStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "statusNotIn":
						this.StatusNotIn = txt;
						continue;
					case "moderationStatusEqual":
						this.ModerationStatusEqual = (KalturaEntryModerationStatus)ParseEnum(typeof(KalturaEntryModerationStatus), txt);
						continue;
					case "moderationStatusNotEqual":
						this.ModerationStatusNotEqual = (KalturaEntryModerationStatus)ParseEnum(typeof(KalturaEntryModerationStatus), txt);
						continue;
					case "moderationStatusIn":
						this.ModerationStatusIn = txt;
						continue;
					case "moderationStatusNotIn":
						this.ModerationStatusNotIn = txt;
						continue;
					case "typeEqual":
						this.TypeEqual = (KalturaEntryType)KalturaStringEnum.Parse(typeof(KalturaEntryType), txt);
						continue;
					case "typeIn":
						this.TypeIn = txt;
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
					case "groupIdEqual":
						this.GroupIdEqual = ParseInt(txt);
						continue;
					case "searchTextMatchAnd":
						this.SearchTextMatchAnd = txt;
						continue;
					case "searchTextMatchOr":
						this.SearchTextMatchOr = txt;
						continue;
					case "accessControlIdEqual":
						this.AccessControlIdEqual = ParseInt(txt);
						continue;
					case "accessControlIdIn":
						this.AccessControlIdIn = txt;
						continue;
					case "startDateGreaterThanOrEqual":
						this.StartDateGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "startDateLessThanOrEqual":
						this.StartDateLessThanOrEqual = ParseInt(txt);
						continue;
					case "startDateGreaterThanOrEqualOrNull":
						this.StartDateGreaterThanOrEqualOrNull = ParseInt(txt);
						continue;
					case "startDateLessThanOrEqualOrNull":
						this.StartDateLessThanOrEqualOrNull = ParseInt(txt);
						continue;
					case "endDateGreaterThanOrEqual":
						this.EndDateGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "endDateLessThanOrEqual":
						this.EndDateLessThanOrEqual = ParseInt(txt);
						continue;
					case "endDateGreaterThanOrEqualOrNull":
						this.EndDateGreaterThanOrEqualOrNull = ParseInt(txt);
						continue;
					case "endDateLessThanOrEqualOrNull":
						this.EndDateLessThanOrEqualOrNull = ParseInt(txt);
						continue;
					case "referenceIdEqual":
						this.ReferenceIdEqual = txt;
						continue;
					case "referenceIdIn":
						this.ReferenceIdIn = txt;
						continue;
					case "replacingEntryIdEqual":
						this.ReplacingEntryIdEqual = txt;
						continue;
					case "replacingEntryIdIn":
						this.ReplacingEntryIdIn = txt;
						continue;
					case "replacedEntryIdEqual":
						this.ReplacedEntryIdEqual = txt;
						continue;
					case "replacedEntryIdIn":
						this.ReplacedEntryIdIn = txt;
						continue;
					case "replacementStatusEqual":
						this.ReplacementStatusEqual = (KalturaEntryReplacementStatus)KalturaStringEnum.Parse(typeof(KalturaEntryReplacementStatus), txt);
						continue;
					case "replacementStatusIn":
						this.ReplacementStatusIn = txt;
						continue;
					case "partnerSortValueGreaterThanOrEqual":
						this.PartnerSortValueGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "partnerSortValueLessThanOrEqual":
						this.PartnerSortValueLessThanOrEqual = ParseInt(txt);
						continue;
					case "rootEntryIdEqual":
						this.RootEntryIdEqual = txt;
						continue;
					case "rootEntryIdIn":
						this.RootEntryIdIn = txt;
						continue;
					case "tagsNameMultiLikeOr":
						this.TagsNameMultiLikeOr = txt;
						continue;
					case "tagsAdminTagsMultiLikeOr":
						this.TagsAdminTagsMultiLikeOr = txt;
						continue;
					case "tagsAdminTagsNameMultiLikeOr":
						this.TagsAdminTagsNameMultiLikeOr = txt;
						continue;
					case "tagsNameMultiLikeAnd":
						this.TagsNameMultiLikeAnd = txt;
						continue;
					case "tagsAdminTagsMultiLikeAnd":
						this.TagsAdminTagsMultiLikeAnd = txt;
						continue;
					case "tagsAdminTagsNameMultiLikeAnd":
						this.TagsAdminTagsNameMultiLikeAnd = txt;
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
			kparams.AddStringIfNotNull("idNotIn", this.IdNotIn);
			kparams.AddStringIfNotNull("nameLike", this.NameLike);
			kparams.AddStringIfNotNull("nameMultiLikeOr", this.NameMultiLikeOr);
			kparams.AddStringIfNotNull("nameMultiLikeAnd", this.NameMultiLikeAnd);
			kparams.AddStringIfNotNull("nameEqual", this.NameEqual);
			kparams.AddIntIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddStringIfNotNull("partnerIdIn", this.PartnerIdIn);
			kparams.AddStringIfNotNull("userIdEqual", this.UserIdEqual);
			kparams.AddStringIfNotNull("tagsLike", this.TagsLike);
			kparams.AddStringIfNotNull("tagsMultiLikeOr", this.TagsMultiLikeOr);
			kparams.AddStringIfNotNull("tagsMultiLikeAnd", this.TagsMultiLikeAnd);
			kparams.AddStringIfNotNull("adminTagsLike", this.AdminTagsLike);
			kparams.AddStringIfNotNull("adminTagsMultiLikeOr", this.AdminTagsMultiLikeOr);
			kparams.AddStringIfNotNull("adminTagsMultiLikeAnd", this.AdminTagsMultiLikeAnd);
			kparams.AddStringIfNotNull("categoriesMatchAnd", this.CategoriesMatchAnd);
			kparams.AddStringIfNotNull("categoriesMatchOr", this.CategoriesMatchOr);
			kparams.AddStringIfNotNull("categoriesIdsMatchAnd", this.CategoriesIdsMatchAnd);
			kparams.AddStringIfNotNull("categoriesIdsMatchOr", this.CategoriesIdsMatchOr);
			kparams.AddStringEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddStringEnumIfNotNull("statusNotEqual", this.StatusNotEqual);
			kparams.AddStringIfNotNull("statusIn", this.StatusIn);
			kparams.AddStringIfNotNull("statusNotIn", this.StatusNotIn);
			kparams.AddEnumIfNotNull("moderationStatusEqual", this.ModerationStatusEqual);
			kparams.AddEnumIfNotNull("moderationStatusNotEqual", this.ModerationStatusNotEqual);
			kparams.AddStringIfNotNull("moderationStatusIn", this.ModerationStatusIn);
			kparams.AddStringIfNotNull("moderationStatusNotIn", this.ModerationStatusNotIn);
			kparams.AddStringEnumIfNotNull("typeEqual", this.TypeEqual);
			kparams.AddStringIfNotNull("typeIn", this.TypeIn);
			kparams.AddIntIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("groupIdEqual", this.GroupIdEqual);
			kparams.AddStringIfNotNull("searchTextMatchAnd", this.SearchTextMatchAnd);
			kparams.AddStringIfNotNull("searchTextMatchOr", this.SearchTextMatchOr);
			kparams.AddIntIfNotNull("accessControlIdEqual", this.AccessControlIdEqual);
			kparams.AddStringIfNotNull("accessControlIdIn", this.AccessControlIdIn);
			kparams.AddIntIfNotNull("startDateGreaterThanOrEqual", this.StartDateGreaterThanOrEqual);
			kparams.AddIntIfNotNull("startDateLessThanOrEqual", this.StartDateLessThanOrEqual);
			kparams.AddIntIfNotNull("startDateGreaterThanOrEqualOrNull", this.StartDateGreaterThanOrEqualOrNull);
			kparams.AddIntIfNotNull("startDateLessThanOrEqualOrNull", this.StartDateLessThanOrEqualOrNull);
			kparams.AddIntIfNotNull("endDateGreaterThanOrEqual", this.EndDateGreaterThanOrEqual);
			kparams.AddIntIfNotNull("endDateLessThanOrEqual", this.EndDateLessThanOrEqual);
			kparams.AddIntIfNotNull("endDateGreaterThanOrEqualOrNull", this.EndDateGreaterThanOrEqualOrNull);
			kparams.AddIntIfNotNull("endDateLessThanOrEqualOrNull", this.EndDateLessThanOrEqualOrNull);
			kparams.AddStringIfNotNull("referenceIdEqual", this.ReferenceIdEqual);
			kparams.AddStringIfNotNull("referenceIdIn", this.ReferenceIdIn);
			kparams.AddStringIfNotNull("replacingEntryIdEqual", this.ReplacingEntryIdEqual);
			kparams.AddStringIfNotNull("replacingEntryIdIn", this.ReplacingEntryIdIn);
			kparams.AddStringIfNotNull("replacedEntryIdEqual", this.ReplacedEntryIdEqual);
			kparams.AddStringIfNotNull("replacedEntryIdIn", this.ReplacedEntryIdIn);
			kparams.AddStringEnumIfNotNull("replacementStatusEqual", this.ReplacementStatusEqual);
			kparams.AddStringIfNotNull("replacementStatusIn", this.ReplacementStatusIn);
			kparams.AddIntIfNotNull("partnerSortValueGreaterThanOrEqual", this.PartnerSortValueGreaterThanOrEqual);
			kparams.AddIntIfNotNull("partnerSortValueLessThanOrEqual", this.PartnerSortValueLessThanOrEqual);
			kparams.AddStringIfNotNull("rootEntryIdEqual", this.RootEntryIdEqual);
			kparams.AddStringIfNotNull("rootEntryIdIn", this.RootEntryIdIn);
			kparams.AddStringIfNotNull("tagsNameMultiLikeOr", this.TagsNameMultiLikeOr);
			kparams.AddStringIfNotNull("tagsAdminTagsMultiLikeOr", this.TagsAdminTagsMultiLikeOr);
			kparams.AddStringIfNotNull("tagsAdminTagsNameMultiLikeOr", this.TagsAdminTagsNameMultiLikeOr);
			kparams.AddStringIfNotNull("tagsNameMultiLikeAnd", this.TagsNameMultiLikeAnd);
			kparams.AddStringIfNotNull("tagsAdminTagsMultiLikeAnd", this.TagsAdminTagsMultiLikeAnd);
			kparams.AddStringIfNotNull("tagsAdminTagsNameMultiLikeAnd", this.TagsAdminTagsNameMultiLikeAnd);
			return kparams;
		}
		#endregion
	}
}

