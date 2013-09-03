using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDropFolderFile : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private int _DropFolderId = Int32.MinValue;
		private string _FileName = null;
		private int _FileSize = Int32.MinValue;
		private int _FileSizeLastSetAt = Int32.MinValue;
		private KalturaDropFolderFileStatus _Status = (KalturaDropFolderFileStatus)Int32.MinValue;
		private string _ParsedSlug = null;
		private string _ParsedFlavor = null;
		private KalturaDropFolderFileErrorCode _ErrorCode = null;
		private string _ErrorDescription = null;
		private string _LastModificationTime = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public int DropFolderId
		{
			get { return _DropFolderId; }
			set 
			{ 
				_DropFolderId = value;
				OnPropertyChanged("DropFolderId");
			}
		}
		public string FileName
		{
			get { return _FileName; }
			set 
			{ 
				_FileName = value;
				OnPropertyChanged("FileName");
			}
		}
		public int FileSize
		{
			get { return _FileSize; }
			set 
			{ 
				_FileSize = value;
				OnPropertyChanged("FileSize");
			}
		}
		public int FileSizeLastSetAt
		{
			get { return _FileSizeLastSetAt; }
			set 
			{ 
				_FileSizeLastSetAt = value;
				OnPropertyChanged("FileSizeLastSetAt");
			}
		}
		public KalturaDropFolderFileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public string ParsedSlug
		{
			get { return _ParsedSlug; }
			set 
			{ 
				_ParsedSlug = value;
				OnPropertyChanged("ParsedSlug");
			}
		}
		public string ParsedFlavor
		{
			get { return _ParsedFlavor; }
			set 
			{ 
				_ParsedFlavor = value;
				OnPropertyChanged("ParsedFlavor");
			}
		}
		public KalturaDropFolderFileErrorCode ErrorCode
		{
			get { return _ErrorCode; }
			set 
			{ 
				_ErrorCode = value;
				OnPropertyChanged("ErrorCode");
			}
		}
		public string ErrorDescription
		{
			get { return _ErrorDescription; }
			set 
			{ 
				_ErrorDescription = value;
				OnPropertyChanged("ErrorDescription");
			}
		}
		public string LastModificationTime
		{
			get { return _LastModificationTime; }
			set 
			{ 
				_LastModificationTime = value;
				OnPropertyChanged("LastModificationTime");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		#endregion

		#region CTor
		public KalturaDropFolderFile()
		{
		}

		public KalturaDropFolderFile(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "dropFolderId":
						this.DropFolderId = ParseInt(txt);
						continue;
					case "fileName":
						this.FileName = txt;
						continue;
					case "fileSize":
						this.FileSize = ParseInt(txt);
						continue;
					case "fileSizeLastSetAt":
						this.FileSizeLastSetAt = ParseInt(txt);
						continue;
					case "status":
						this.Status = (KalturaDropFolderFileStatus)ParseEnum(typeof(KalturaDropFolderFileStatus), txt);
						continue;
					case "parsedSlug":
						this.ParsedSlug = txt;
						continue;
					case "parsedFlavor":
						this.ParsedFlavor = txt;
						continue;
					case "errorCode":
						this.ErrorCode = (KalturaDropFolderFileErrorCode)KalturaStringEnum.Parse(typeof(KalturaDropFolderFileErrorCode), txt);
						continue;
					case "errorDescription":
						this.ErrorDescription = txt;
						continue;
					case "lastModificationTime":
						this.LastModificationTime = txt;
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("id", this.Id);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddIntIfNotNull("dropFolderId", this.DropFolderId);
			kparams.AddStringIfNotNull("fileName", this.FileName);
			kparams.AddIntIfNotNull("fileSize", this.FileSize);
			kparams.AddIntIfNotNull("fileSizeLastSetAt", this.FileSizeLastSetAt);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddStringIfNotNull("parsedSlug", this.ParsedSlug);
			kparams.AddStringIfNotNull("parsedFlavor", this.ParsedFlavor);
			kparams.AddStringEnumIfNotNull("errorCode", this.ErrorCode);
			kparams.AddStringIfNotNull("errorDescription", this.ErrorDescription);
			kparams.AddStringIfNotNull("lastModificationTime", this.LastModificationTime);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIntIfNotNull("updatedAt", this.UpdatedAt);
			return kparams;
		}
		#endregion
	}
}

