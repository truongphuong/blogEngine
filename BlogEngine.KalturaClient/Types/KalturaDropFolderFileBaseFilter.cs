using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDropFolderFileBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private int _DropFolderIdEqual = Int32.MinValue;
		private string _DropFolderIdIn = null;
		private string _FileNameEqual = null;
		private string _FileNameIn = null;
		private string _FileNameLike = null;
		private KalturaDropFolderFileStatus _StatusEqual = (KalturaDropFolderFileStatus)Int32.MinValue;
		private string _StatusIn = null;
		private string _ParsedSlugEqual = null;
		private string _ParsedSlugIn = null;
		private string _ParsedSlugLike = null;
		private string _ParsedFlavorEqual = null;
		private string _ParsedFlavorIn = null;
		private string _ParsedFlavorLike = null;
		private KalturaDropFolderFileErrorCode _ErrorCodeEqual = null;
		private string _ErrorCodeIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
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
		public int DropFolderIdEqual
		{
			get { return _DropFolderIdEqual; }
			set 
			{ 
				_DropFolderIdEqual = value;
				OnPropertyChanged("DropFolderIdEqual");
			}
		}
		public string DropFolderIdIn
		{
			get { return _DropFolderIdIn; }
			set 
			{ 
				_DropFolderIdIn = value;
				OnPropertyChanged("DropFolderIdIn");
			}
		}
		public string FileNameEqual
		{
			get { return _FileNameEqual; }
			set 
			{ 
				_FileNameEqual = value;
				OnPropertyChanged("FileNameEqual");
			}
		}
		public string FileNameIn
		{
			get { return _FileNameIn; }
			set 
			{ 
				_FileNameIn = value;
				OnPropertyChanged("FileNameIn");
			}
		}
		public string FileNameLike
		{
			get { return _FileNameLike; }
			set 
			{ 
				_FileNameLike = value;
				OnPropertyChanged("FileNameLike");
			}
		}
		public KalturaDropFolderFileStatus StatusEqual
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
		public string ParsedSlugEqual
		{
			get { return _ParsedSlugEqual; }
			set 
			{ 
				_ParsedSlugEqual = value;
				OnPropertyChanged("ParsedSlugEqual");
			}
		}
		public string ParsedSlugIn
		{
			get { return _ParsedSlugIn; }
			set 
			{ 
				_ParsedSlugIn = value;
				OnPropertyChanged("ParsedSlugIn");
			}
		}
		public string ParsedSlugLike
		{
			get { return _ParsedSlugLike; }
			set 
			{ 
				_ParsedSlugLike = value;
				OnPropertyChanged("ParsedSlugLike");
			}
		}
		public string ParsedFlavorEqual
		{
			get { return _ParsedFlavorEqual; }
			set 
			{ 
				_ParsedFlavorEqual = value;
				OnPropertyChanged("ParsedFlavorEqual");
			}
		}
		public string ParsedFlavorIn
		{
			get { return _ParsedFlavorIn; }
			set 
			{ 
				_ParsedFlavorIn = value;
				OnPropertyChanged("ParsedFlavorIn");
			}
		}
		public string ParsedFlavorLike
		{
			get { return _ParsedFlavorLike; }
			set 
			{ 
				_ParsedFlavorLike = value;
				OnPropertyChanged("ParsedFlavorLike");
			}
		}
		public KalturaDropFolderFileErrorCode ErrorCodeEqual
		{
			get { return _ErrorCodeEqual; }
			set 
			{ 
				_ErrorCodeEqual = value;
				OnPropertyChanged("ErrorCodeEqual");
			}
		}
		public string ErrorCodeIn
		{
			get { return _ErrorCodeIn; }
			set 
			{ 
				_ErrorCodeIn = value;
				OnPropertyChanged("ErrorCodeIn");
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
		#endregion

		#region CTor
		public KalturaDropFolderFileBaseFilter()
		{
		}

		public KalturaDropFolderFileBaseFilter(XmlElement node) : base(node)
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
					case "partnerIdEqual":
						this.PartnerIdEqual = ParseInt(txt);
						continue;
					case "partnerIdIn":
						this.PartnerIdIn = txt;
						continue;
					case "dropFolderIdEqual":
						this.DropFolderIdEqual = ParseInt(txt);
						continue;
					case "dropFolderIdIn":
						this.DropFolderIdIn = txt;
						continue;
					case "fileNameEqual":
						this.FileNameEqual = txt;
						continue;
					case "fileNameIn":
						this.FileNameIn = txt;
						continue;
					case "fileNameLike":
						this.FileNameLike = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaDropFolderFileStatus)ParseEnum(typeof(KalturaDropFolderFileStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "parsedSlugEqual":
						this.ParsedSlugEqual = txt;
						continue;
					case "parsedSlugIn":
						this.ParsedSlugIn = txt;
						continue;
					case "parsedSlugLike":
						this.ParsedSlugLike = txt;
						continue;
					case "parsedFlavorEqual":
						this.ParsedFlavorEqual = txt;
						continue;
					case "parsedFlavorIn":
						this.ParsedFlavorIn = txt;
						continue;
					case "parsedFlavorLike":
						this.ParsedFlavorLike = txt;
						continue;
					case "errorCodeEqual":
						this.ErrorCodeEqual = (KalturaDropFolderFileErrorCode)KalturaStringEnum.Parse(typeof(KalturaDropFolderFileErrorCode), txt);
						continue;
					case "errorCodeIn":
						this.ErrorCodeIn = txt;
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
			kparams.AddIntIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddStringIfNotNull("partnerIdIn", this.PartnerIdIn);
			kparams.AddIntIfNotNull("dropFolderIdEqual", this.DropFolderIdEqual);
			kparams.AddStringIfNotNull("dropFolderIdIn", this.DropFolderIdIn);
			kparams.AddStringIfNotNull("fileNameEqual", this.FileNameEqual);
			kparams.AddStringIfNotNull("fileNameIn", this.FileNameIn);
			kparams.AddStringIfNotNull("fileNameLike", this.FileNameLike);
			kparams.AddEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddStringIfNotNull("statusIn", this.StatusIn);
			kparams.AddStringIfNotNull("parsedSlugEqual", this.ParsedSlugEqual);
			kparams.AddStringIfNotNull("parsedSlugIn", this.ParsedSlugIn);
			kparams.AddStringIfNotNull("parsedSlugLike", this.ParsedSlugLike);
			kparams.AddStringIfNotNull("parsedFlavorEqual", this.ParsedFlavorEqual);
			kparams.AddStringIfNotNull("parsedFlavorIn", this.ParsedFlavorIn);
			kparams.AddStringIfNotNull("parsedFlavorLike", this.ParsedFlavorLike);
			kparams.AddStringEnumIfNotNull("errorCodeEqual", this.ErrorCodeEqual);
			kparams.AddStringIfNotNull("errorCodeIn", this.ErrorCodeIn);
			kparams.AddIntIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			return kparams;
		}
		#endregion
	}
}

