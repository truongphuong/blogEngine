using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFileSyncBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _PartnerIdEqual = Int32.MinValue;
		private KalturaFileSyncObjectType _FileObjectTypeEqual = null;
		private string _FileObjectTypeIn = null;
		private string _ObjectIdEqual = null;
		private string _ObjectIdIn = null;
		private string _VersionEqual = null;
		private string _VersionIn = null;
		private int _ObjectSubTypeEqual = Int32.MinValue;
		private string _ObjectSubTypeIn = null;
		private string _DcEqual = null;
		private string _DcIn = null;
		private int _OriginalEqual = Int32.MinValue;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _ReadyAtGreaterThanOrEqual = Int32.MinValue;
		private int _ReadyAtLessThanOrEqual = Int32.MinValue;
		private int _SyncTimeGreaterThanOrEqual = Int32.MinValue;
		private int _SyncTimeLessThanOrEqual = Int32.MinValue;
		private KalturaFileSyncStatus _StatusEqual = (KalturaFileSyncStatus)Int32.MinValue;
		private string _StatusIn = null;
		private KalturaFileSyncType _FileTypeEqual = (KalturaFileSyncType)Int32.MinValue;
		private string _FileTypeIn = null;
		private int _LinkedIdEqual = Int32.MinValue;
		private int _LinkCountGreaterThanOrEqual = Int32.MinValue;
		private int _LinkCountLessThanOrEqual = Int32.MinValue;
		private int _FileSizeGreaterThanOrEqual = Int32.MinValue;
		private int _FileSizeLessThanOrEqual = Int32.MinValue;
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
		public KalturaFileSyncObjectType FileObjectTypeEqual
		{
			get { return _FileObjectTypeEqual; }
			set 
			{ 
				_FileObjectTypeEqual = value;
				OnPropertyChanged("FileObjectTypeEqual");
			}
		}
		public string FileObjectTypeIn
		{
			get { return _FileObjectTypeIn; }
			set 
			{ 
				_FileObjectTypeIn = value;
				OnPropertyChanged("FileObjectTypeIn");
			}
		}
		public string ObjectIdEqual
		{
			get { return _ObjectIdEqual; }
			set 
			{ 
				_ObjectIdEqual = value;
				OnPropertyChanged("ObjectIdEqual");
			}
		}
		public string ObjectIdIn
		{
			get { return _ObjectIdIn; }
			set 
			{ 
				_ObjectIdIn = value;
				OnPropertyChanged("ObjectIdIn");
			}
		}
		public string VersionEqual
		{
			get { return _VersionEqual; }
			set 
			{ 
				_VersionEqual = value;
				OnPropertyChanged("VersionEqual");
			}
		}
		public string VersionIn
		{
			get { return _VersionIn; }
			set 
			{ 
				_VersionIn = value;
				OnPropertyChanged("VersionIn");
			}
		}
		public int ObjectSubTypeEqual
		{
			get { return _ObjectSubTypeEqual; }
			set 
			{ 
				_ObjectSubTypeEqual = value;
				OnPropertyChanged("ObjectSubTypeEqual");
			}
		}
		public string ObjectSubTypeIn
		{
			get { return _ObjectSubTypeIn; }
			set 
			{ 
				_ObjectSubTypeIn = value;
				OnPropertyChanged("ObjectSubTypeIn");
			}
		}
		public string DcEqual
		{
			get { return _DcEqual; }
			set 
			{ 
				_DcEqual = value;
				OnPropertyChanged("DcEqual");
			}
		}
		public string DcIn
		{
			get { return _DcIn; }
			set 
			{ 
				_DcIn = value;
				OnPropertyChanged("DcIn");
			}
		}
		public int OriginalEqual
		{
			get { return _OriginalEqual; }
			set 
			{ 
				_OriginalEqual = value;
				OnPropertyChanged("OriginalEqual");
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
		public int ReadyAtGreaterThanOrEqual
		{
			get { return _ReadyAtGreaterThanOrEqual; }
			set 
			{ 
				_ReadyAtGreaterThanOrEqual = value;
				OnPropertyChanged("ReadyAtGreaterThanOrEqual");
			}
		}
		public int ReadyAtLessThanOrEqual
		{
			get { return _ReadyAtLessThanOrEqual; }
			set 
			{ 
				_ReadyAtLessThanOrEqual = value;
				OnPropertyChanged("ReadyAtLessThanOrEqual");
			}
		}
		public int SyncTimeGreaterThanOrEqual
		{
			get { return _SyncTimeGreaterThanOrEqual; }
			set 
			{ 
				_SyncTimeGreaterThanOrEqual = value;
				OnPropertyChanged("SyncTimeGreaterThanOrEqual");
			}
		}
		public int SyncTimeLessThanOrEqual
		{
			get { return _SyncTimeLessThanOrEqual; }
			set 
			{ 
				_SyncTimeLessThanOrEqual = value;
				OnPropertyChanged("SyncTimeLessThanOrEqual");
			}
		}
		public KalturaFileSyncStatus StatusEqual
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
		public KalturaFileSyncType FileTypeEqual
		{
			get { return _FileTypeEqual; }
			set 
			{ 
				_FileTypeEqual = value;
				OnPropertyChanged("FileTypeEqual");
			}
		}
		public string FileTypeIn
		{
			get { return _FileTypeIn; }
			set 
			{ 
				_FileTypeIn = value;
				OnPropertyChanged("FileTypeIn");
			}
		}
		public int LinkedIdEqual
		{
			get { return _LinkedIdEqual; }
			set 
			{ 
				_LinkedIdEqual = value;
				OnPropertyChanged("LinkedIdEqual");
			}
		}
		public int LinkCountGreaterThanOrEqual
		{
			get { return _LinkCountGreaterThanOrEqual; }
			set 
			{ 
				_LinkCountGreaterThanOrEqual = value;
				OnPropertyChanged("LinkCountGreaterThanOrEqual");
			}
		}
		public int LinkCountLessThanOrEqual
		{
			get { return _LinkCountLessThanOrEqual; }
			set 
			{ 
				_LinkCountLessThanOrEqual = value;
				OnPropertyChanged("LinkCountLessThanOrEqual");
			}
		}
		public int FileSizeGreaterThanOrEqual
		{
			get { return _FileSizeGreaterThanOrEqual; }
			set 
			{ 
				_FileSizeGreaterThanOrEqual = value;
				OnPropertyChanged("FileSizeGreaterThanOrEqual");
			}
		}
		public int FileSizeLessThanOrEqual
		{
			get { return _FileSizeLessThanOrEqual; }
			set 
			{ 
				_FileSizeLessThanOrEqual = value;
				OnPropertyChanged("FileSizeLessThanOrEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaFileSyncBaseFilter()
		{
		}

		public KalturaFileSyncBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "partnerIdEqual":
						this.PartnerIdEqual = ParseInt(txt);
						continue;
					case "fileObjectTypeEqual":
						this.FileObjectTypeEqual = (KalturaFileSyncObjectType)KalturaStringEnum.Parse(typeof(KalturaFileSyncObjectType), txt);
						continue;
					case "fileObjectTypeIn":
						this.FileObjectTypeIn = txt;
						continue;
					case "objectIdEqual":
						this.ObjectIdEqual = txt;
						continue;
					case "objectIdIn":
						this.ObjectIdIn = txt;
						continue;
					case "versionEqual":
						this.VersionEqual = txt;
						continue;
					case "versionIn":
						this.VersionIn = txt;
						continue;
					case "objectSubTypeEqual":
						this.ObjectSubTypeEqual = ParseInt(txt);
						continue;
					case "objectSubTypeIn":
						this.ObjectSubTypeIn = txt;
						continue;
					case "dcEqual":
						this.DcEqual = txt;
						continue;
					case "dcIn":
						this.DcIn = txt;
						continue;
					case "originalEqual":
						this.OriginalEqual = ParseInt(txt);
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
					case "readyAtGreaterThanOrEqual":
						this.ReadyAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "readyAtLessThanOrEqual":
						this.ReadyAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "syncTimeGreaterThanOrEqual":
						this.SyncTimeGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "syncTimeLessThanOrEqual":
						this.SyncTimeLessThanOrEqual = ParseInt(txt);
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaFileSyncStatus)ParseEnum(typeof(KalturaFileSyncStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "fileTypeEqual":
						this.FileTypeEqual = (KalturaFileSyncType)ParseEnum(typeof(KalturaFileSyncType), txt);
						continue;
					case "fileTypeIn":
						this.FileTypeIn = txt;
						continue;
					case "linkedIdEqual":
						this.LinkedIdEqual = ParseInt(txt);
						continue;
					case "linkCountGreaterThanOrEqual":
						this.LinkCountGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "linkCountLessThanOrEqual":
						this.LinkCountLessThanOrEqual = ParseInt(txt);
						continue;
					case "fileSizeGreaterThanOrEqual":
						this.FileSizeGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "fileSizeLessThanOrEqual":
						this.FileSizeLessThanOrEqual = ParseInt(txt);
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
			kparams.AddStringEnumIfNotNull("fileObjectTypeEqual", this.FileObjectTypeEqual);
			kparams.AddStringIfNotNull("fileObjectTypeIn", this.FileObjectTypeIn);
			kparams.AddStringIfNotNull("objectIdEqual", this.ObjectIdEqual);
			kparams.AddStringIfNotNull("objectIdIn", this.ObjectIdIn);
			kparams.AddStringIfNotNull("versionEqual", this.VersionEqual);
			kparams.AddStringIfNotNull("versionIn", this.VersionIn);
			kparams.AddIntIfNotNull("objectSubTypeEqual", this.ObjectSubTypeEqual);
			kparams.AddStringIfNotNull("objectSubTypeIn", this.ObjectSubTypeIn);
			kparams.AddStringIfNotNull("dcEqual", this.DcEqual);
			kparams.AddStringIfNotNull("dcIn", this.DcIn);
			kparams.AddIntIfNotNull("originalEqual", this.OriginalEqual);
			kparams.AddIntIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("readyAtGreaterThanOrEqual", this.ReadyAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("readyAtLessThanOrEqual", this.ReadyAtLessThanOrEqual);
			kparams.AddIntIfNotNull("syncTimeGreaterThanOrEqual", this.SyncTimeGreaterThanOrEqual);
			kparams.AddIntIfNotNull("syncTimeLessThanOrEqual", this.SyncTimeLessThanOrEqual);
			kparams.AddEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddStringIfNotNull("statusIn", this.StatusIn);
			kparams.AddEnumIfNotNull("fileTypeEqual", this.FileTypeEqual);
			kparams.AddStringIfNotNull("fileTypeIn", this.FileTypeIn);
			kparams.AddIntIfNotNull("linkedIdEqual", this.LinkedIdEqual);
			kparams.AddIntIfNotNull("linkCountGreaterThanOrEqual", this.LinkCountGreaterThanOrEqual);
			kparams.AddIntIfNotNull("linkCountLessThanOrEqual", this.LinkCountLessThanOrEqual);
			kparams.AddIntIfNotNull("fileSizeGreaterThanOrEqual", this.FileSizeGreaterThanOrEqual);
			kparams.AddIntIfNotNull("fileSizeLessThanOrEqual", this.FileSizeLessThanOrEqual);
			return kparams;
		}
		#endregion
	}
}

