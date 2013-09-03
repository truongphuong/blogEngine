using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDropFolder : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _Description = null;
		private KalturaDropFolderType _Type = null;
		private KalturaDropFolderStatus _Status = (KalturaDropFolderStatus)Int32.MinValue;
		private int _ConversionProfileId = Int32.MinValue;
		private int _Dc = Int32.MinValue;
		private string _Path = null;
		private int _FileSizeCheckInterval = Int32.MinValue;
		private KalturaDropFolderFileDeletePolicy _FileDeletePolicy = (KalturaDropFolderFileDeletePolicy)Int32.MinValue;
		private int _AutoFileDeleteDays = Int32.MinValue;
		private KalturaDropFolderFileHandlerType _FileHandlerType = null;
		private string _FileNamePatterns = null;
		private KalturaDropFolderFileHandlerConfig _FileHandlerConfig;
		private string _Tags = null;
		private string _IgnoreFileNamePatterns = null;
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
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public KalturaDropFolderType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public KalturaDropFolderStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public int ConversionProfileId
		{
			get { return _ConversionProfileId; }
			set 
			{ 
				_ConversionProfileId = value;
				OnPropertyChanged("ConversionProfileId");
			}
		}
		public int Dc
		{
			get { return _Dc; }
			set 
			{ 
				_Dc = value;
				OnPropertyChanged("Dc");
			}
		}
		public string Path
		{
			get { return _Path; }
			set 
			{ 
				_Path = value;
				OnPropertyChanged("Path");
			}
		}
		public int FileSizeCheckInterval
		{
			get { return _FileSizeCheckInterval; }
			set 
			{ 
				_FileSizeCheckInterval = value;
				OnPropertyChanged("FileSizeCheckInterval");
			}
		}
		public KalturaDropFolderFileDeletePolicy FileDeletePolicy
		{
			get { return _FileDeletePolicy; }
			set 
			{ 
				_FileDeletePolicy = value;
				OnPropertyChanged("FileDeletePolicy");
			}
		}
		public int AutoFileDeleteDays
		{
			get { return _AutoFileDeleteDays; }
			set 
			{ 
				_AutoFileDeleteDays = value;
				OnPropertyChanged("AutoFileDeleteDays");
			}
		}
		public KalturaDropFolderFileHandlerType FileHandlerType
		{
			get { return _FileHandlerType; }
			set 
			{ 
				_FileHandlerType = value;
				OnPropertyChanged("FileHandlerType");
			}
		}
		public string FileNamePatterns
		{
			get { return _FileNamePatterns; }
			set 
			{ 
				_FileNamePatterns = value;
				OnPropertyChanged("FileNamePatterns");
			}
		}
		public KalturaDropFolderFileHandlerConfig FileHandlerConfig
		{
			get { return _FileHandlerConfig; }
			set 
			{ 
				_FileHandlerConfig = value;
				OnPropertyChanged("FileHandlerConfig");
			}
		}
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public string IgnoreFileNamePatterns
		{
			get { return _IgnoreFileNamePatterns; }
			set 
			{ 
				_IgnoreFileNamePatterns = value;
				OnPropertyChanged("IgnoreFileNamePatterns");
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
		public KalturaDropFolder()
		{
		}

		public KalturaDropFolder(XmlElement node)
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
					case "name":
						this.Name = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "type":
						this.Type = (KalturaDropFolderType)KalturaStringEnum.Parse(typeof(KalturaDropFolderType), txt);
						continue;
					case "status":
						this.Status = (KalturaDropFolderStatus)ParseEnum(typeof(KalturaDropFolderStatus), txt);
						continue;
					case "conversionProfileId":
						this.ConversionProfileId = ParseInt(txt);
						continue;
					case "dc":
						this.Dc = ParseInt(txt);
						continue;
					case "path":
						this.Path = txt;
						continue;
					case "fileSizeCheckInterval":
						this.FileSizeCheckInterval = ParseInt(txt);
						continue;
					case "fileDeletePolicy":
						this.FileDeletePolicy = (KalturaDropFolderFileDeletePolicy)ParseEnum(typeof(KalturaDropFolderFileDeletePolicy), txt);
						continue;
					case "autoFileDeleteDays":
						this.AutoFileDeleteDays = ParseInt(txt);
						continue;
					case "fileHandlerType":
						this.FileHandlerType = (KalturaDropFolderFileHandlerType)KalturaStringEnum.Parse(typeof(KalturaDropFolderFileHandlerType), txt);
						continue;
					case "fileNamePatterns":
						this.FileNamePatterns = txt;
						continue;
					case "fileHandlerConfig":
						this.FileHandlerConfig = (KalturaDropFolderFileHandlerConfig)KalturaObjectFactory.Create(propertyNode);
						continue;
					case "tags":
						this.Tags = txt;
						continue;
					case "ignoreFileNamePatterns":
						this.IgnoreFileNamePatterns = txt;
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
			kparams.AddStringIfNotNull("name", this.Name);
			kparams.AddStringIfNotNull("description", this.Description);
			kparams.AddStringEnumIfNotNull("type", this.Type);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddIntIfNotNull("conversionProfileId", this.ConversionProfileId);
			kparams.AddIntIfNotNull("dc", this.Dc);
			kparams.AddStringIfNotNull("path", this.Path);
			kparams.AddIntIfNotNull("fileSizeCheckInterval", this.FileSizeCheckInterval);
			kparams.AddEnumIfNotNull("fileDeletePolicy", this.FileDeletePolicy);
			kparams.AddIntIfNotNull("autoFileDeleteDays", this.AutoFileDeleteDays);
			kparams.AddStringEnumIfNotNull("fileHandlerType", this.FileHandlerType);
			kparams.AddStringIfNotNull("fileNamePatterns", this.FileNamePatterns);
			if (this.FileHandlerConfig != null)
				kparams.Add("fileHandlerConfig", this.FileHandlerConfig.ToParams());
			kparams.AddStringIfNotNull("tags", this.Tags);
			kparams.AddStringIfNotNull("ignoreFileNamePatterns", this.IgnoreFileNamePatterns);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIntIfNotNull("updatedAt", this.UpdatedAt);
			return kparams;
		}
		#endregion
	}
}

