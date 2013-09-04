using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaUserBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _PartnerIdEqual = Int32.MinValue;
		private string _ScreenNameLike = null;
		private string _ScreenNameStartsWith = null;
		private string _EmailLike = null;
		private string _EmailStartsWith = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private KalturaUserStatus _StatusEqual = (KalturaUserStatus)Int32.MinValue;
		private string _StatusIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private bool? _IsAdminEqual = false;
		#endregion

		#region Properties
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public string ScreenNameLike
		{
			get { return _ScreenNameLike; }
			set 
			{ 
				_ScreenNameLike = value;
				OnPropertyChanged("ScreenNameLike");
			}
		}
		public string ScreenNameStartsWith
		{
			get { return _ScreenNameStartsWith; }
			set 
			{ 
				_ScreenNameStartsWith = value;
				OnPropertyChanged("ScreenNameStartsWith");
			}
		}
		public string EmailLike
		{
			get { return _EmailLike; }
			set 
			{ 
				_EmailLike = value;
				OnPropertyChanged("EmailLike");
			}
		}
		public string EmailStartsWith
		{
			get { return _EmailStartsWith; }
			set 
			{ 
				_EmailStartsWith = value;
				OnPropertyChanged("EmailStartsWith");
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
		public KalturaUserStatus StatusEqual
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
		public bool? IsAdminEqual
		{
			get { return _IsAdminEqual; }
			set 
			{ 
				_IsAdminEqual = value;
				OnPropertyChanged("IsAdminEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaUserBaseFilter()
		{
		}

		public KalturaUserBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "partnerIdEqual":
						this.PartnerIdEqual = ParseInt(txt);
						continue;
					case "screenNameLike":
						this.ScreenNameLike = txt;
						continue;
					case "screenNameStartsWith":
						this.ScreenNameStartsWith = txt;
						continue;
					case "emailLike":
						this.EmailLike = txt;
						continue;
					case "emailStartsWith":
						this.EmailStartsWith = txt;
						continue;
					case "tagsMultiLikeOr":
						this.TagsMultiLikeOr = txt;
						continue;
					case "tagsMultiLikeAnd":
						this.TagsMultiLikeAnd = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaUserStatus)ParseEnum(typeof(KalturaUserStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "createdAtGreaterThanOrEqual":
						this.CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this.CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "isAdminEqual":
						this.IsAdminEqual = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddStringIfNotNull("screenNameLike", this.ScreenNameLike);
			kparams.AddStringIfNotNull("screenNameStartsWith", this.ScreenNameStartsWith);
			kparams.AddStringIfNotNull("emailLike", this.EmailLike);
			kparams.AddStringIfNotNull("emailStartsWith", this.EmailStartsWith);
			kparams.AddStringIfNotNull("tagsMultiLikeOr", this.TagsMultiLikeOr);
			kparams.AddStringIfNotNull("tagsMultiLikeAnd", this.TagsMultiLikeAnd);
			kparams.AddEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddStringIfNotNull("statusIn", this.StatusIn);
			kparams.AddIntIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddBoolIfNotNull("isAdminEqual", this.IsAdminEqual);
			return kparams;
		}
		#endregion
	}
}

