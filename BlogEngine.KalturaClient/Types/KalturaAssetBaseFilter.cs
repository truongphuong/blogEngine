using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAssetBaseFilter : KalturaFilter
	{
		#region Private Fields
		private string _IdEqual = null;
		private string _IdIn = null;
		private string _EntryIdEqual = null;
		private string _EntryIdIn = null;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private int _SizeGreaterThanOrEqual = Int32.MinValue;
		private int _SizeLessThanOrEqual = Int32.MinValue;
		private string _TagsLike = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _DeletedAtGreaterThanOrEqual = Int32.MinValue;
		private int _DeletedAtLessThanOrEqual = Int32.MinValue;
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
		public int SizeGreaterThanOrEqual
		{
			get { return _SizeGreaterThanOrEqual; }
			set 
			{ 
				_SizeGreaterThanOrEqual = value;
				OnPropertyChanged("SizeGreaterThanOrEqual");
			}
		}
		public int SizeLessThanOrEqual
		{
			get { return _SizeLessThanOrEqual; }
			set 
			{ 
				_SizeLessThanOrEqual = value;
				OnPropertyChanged("SizeLessThanOrEqual");
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
		public int DeletedAtGreaterThanOrEqual
		{
			get { return _DeletedAtGreaterThanOrEqual; }
			set 
			{ 
				_DeletedAtGreaterThanOrEqual = value;
				OnPropertyChanged("DeletedAtGreaterThanOrEqual");
			}
		}
		public int DeletedAtLessThanOrEqual
		{
			get { return _DeletedAtLessThanOrEqual; }
			set 
			{ 
				_DeletedAtLessThanOrEqual = value;
				OnPropertyChanged("DeletedAtLessThanOrEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaAssetBaseFilter()
		{
		}

		public KalturaAssetBaseFilter(XmlElement node) : base(node)
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
					case "entryIdEqual":
						this.EntryIdEqual = txt;
						continue;
					case "entryIdIn":
						this.EntryIdIn = txt;
						continue;
					case "partnerIdEqual":
						this.PartnerIdEqual = ParseInt(txt);
						continue;
					case "partnerIdIn":
						this.PartnerIdIn = txt;
						continue;
					case "sizeGreaterThanOrEqual":
						this.SizeGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "sizeLessThanOrEqual":
						this.SizeLessThanOrEqual = ParseInt(txt);
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
					case "deletedAtGreaterThanOrEqual":
						this.DeletedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "deletedAtLessThanOrEqual":
						this.DeletedAtLessThanOrEqual = ParseInt(txt);
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
			kparams.AddStringIfNotNull("entryIdEqual", this.EntryIdEqual);
			kparams.AddStringIfNotNull("entryIdIn", this.EntryIdIn);
			kparams.AddIntIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddStringIfNotNull("partnerIdIn", this.PartnerIdIn);
			kparams.AddIntIfNotNull("sizeGreaterThanOrEqual", this.SizeGreaterThanOrEqual);
			kparams.AddIntIfNotNull("sizeLessThanOrEqual", this.SizeLessThanOrEqual);
			kparams.AddStringIfNotNull("tagsLike", this.TagsLike);
			kparams.AddStringIfNotNull("tagsMultiLikeOr", this.TagsMultiLikeOr);
			kparams.AddStringIfNotNull("tagsMultiLikeAnd", this.TagsMultiLikeAnd);
			kparams.AddIntIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("deletedAtGreaterThanOrEqual", this.DeletedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("deletedAtLessThanOrEqual", this.DeletedAtLessThanOrEqual);
			return kparams;
		}
		#endregion
	}
}

