using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaBulkUpload : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _UploadedBy = null;
		private string _UploadedByUserId = null;
		private int _UploadedOn = Int32.MinValue;
		private int _NumOfEntries = Int32.MinValue;
		private KalturaBatchJobStatus _Status = (KalturaBatchJobStatus)Int32.MinValue;
		private string _LogFileUrl = null;
		private string _CsvFileUrl = null;
		private string _BulkFileUrl = null;
		private KalturaBulkUploadType _BulkUploadType = null;
		private IList<KalturaBulkUploadResult> _Results;
		private string _Error = null;
		private KalturaBatchJobErrorTypes _ErrorType = (KalturaBatchJobErrorTypes)Int32.MinValue;
		private int _ErrorNumber = Int32.MinValue;
		private string _FileName = null;
		private string _Description = null;
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
		public string UploadedBy
		{
			get { return _UploadedBy; }
			set 
			{ 
				_UploadedBy = value;
				OnPropertyChanged("UploadedBy");
			}
		}
		public string UploadedByUserId
		{
			get { return _UploadedByUserId; }
			set 
			{ 
				_UploadedByUserId = value;
				OnPropertyChanged("UploadedByUserId");
			}
		}
		public int UploadedOn
		{
			get { return _UploadedOn; }
			set 
			{ 
				_UploadedOn = value;
				OnPropertyChanged("UploadedOn");
			}
		}
		public int NumOfEntries
		{
			get { return _NumOfEntries; }
			set 
			{ 
				_NumOfEntries = value;
				OnPropertyChanged("NumOfEntries");
			}
		}
		public KalturaBatchJobStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public string LogFileUrl
		{
			get { return _LogFileUrl; }
			set 
			{ 
				_LogFileUrl = value;
				OnPropertyChanged("LogFileUrl");
			}
		}
		public string CsvFileUrl
		{
			get { return _CsvFileUrl; }
			set 
			{ 
				_CsvFileUrl = value;
				OnPropertyChanged("CsvFileUrl");
			}
		}
		public string BulkFileUrl
		{
			get { return _BulkFileUrl; }
			set 
			{ 
				_BulkFileUrl = value;
				OnPropertyChanged("BulkFileUrl");
			}
		}
		public KalturaBulkUploadType BulkUploadType
		{
			get { return _BulkUploadType; }
			set 
			{ 
				_BulkUploadType = value;
				OnPropertyChanged("BulkUploadType");
			}
		}
		public IList<KalturaBulkUploadResult> Results
		{
			get { return _Results; }
			set 
			{ 
				_Results = value;
				OnPropertyChanged("Results");
			}
		}
		public string Error
		{
			get { return _Error; }
			set 
			{ 
				_Error = value;
				OnPropertyChanged("Error");
			}
		}
		public KalturaBatchJobErrorTypes ErrorType
		{
			get { return _ErrorType; }
			set 
			{ 
				_ErrorType = value;
				OnPropertyChanged("ErrorType");
			}
		}
		public int ErrorNumber
		{
			get { return _ErrorNumber; }
			set 
			{ 
				_ErrorNumber = value;
				OnPropertyChanged("ErrorNumber");
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
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		#endregion

		#region CTor
		public KalturaBulkUpload()
		{
		}

		public KalturaBulkUpload(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "uploadedBy":
						this.UploadedBy = txt;
						continue;
					case "uploadedByUserId":
						this.UploadedByUserId = txt;
						continue;
					case "uploadedOn":
						this.UploadedOn = ParseInt(txt);
						continue;
					case "numOfEntries":
						this.NumOfEntries = ParseInt(txt);
						continue;
					case "status":
						this.Status = (KalturaBatchJobStatus)ParseEnum(typeof(KalturaBatchJobStatus), txt);
						continue;
					case "logFileUrl":
						this.LogFileUrl = txt;
						continue;
					case "csvFileUrl":
						this.CsvFileUrl = txt;
						continue;
					case "bulkFileUrl":
						this.BulkFileUrl = txt;
						continue;
					case "bulkUploadType":
						this.BulkUploadType = (KalturaBulkUploadType)KalturaStringEnum.Parse(typeof(KalturaBulkUploadType), txt);
						continue;
					case "results":
						this.Results = new List<KalturaBulkUploadResult>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Results.Add((KalturaBulkUploadResult)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "error":
						this.Error = txt;
						continue;
					case "errorType":
						this.ErrorType = (KalturaBatchJobErrorTypes)ParseEnum(typeof(KalturaBatchJobErrorTypes), txt);
						continue;
					case "errorNumber":
						this.ErrorNumber = ParseInt(txt);
						continue;
					case "fileName":
						this.FileName = txt;
						continue;
					case "description":
						this.Description = txt;
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
			kparams.AddStringIfNotNull("uploadedBy", this.UploadedBy);
			kparams.AddStringIfNotNull("uploadedByUserId", this.UploadedByUserId);
			kparams.AddIntIfNotNull("uploadedOn", this.UploadedOn);
			kparams.AddIntIfNotNull("numOfEntries", this.NumOfEntries);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddStringIfNotNull("logFileUrl", this.LogFileUrl);
			kparams.AddStringIfNotNull("csvFileUrl", this.CsvFileUrl);
			kparams.AddStringIfNotNull("bulkFileUrl", this.BulkFileUrl);
			kparams.AddStringEnumIfNotNull("bulkUploadType", this.BulkUploadType);
			if (this.Results != null)
			{
				if (this.Results.Count == 0)
				{
					kparams.Add("results:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaBulkUploadResult item in this.Results)
					{
						kparams.Add("results:" + i + ":objectType", item.GetType().Name);
						kparams.Add("results:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddStringIfNotNull("error", this.Error);
			kparams.AddEnumIfNotNull("errorType", this.ErrorType);
			kparams.AddIntIfNotNull("errorNumber", this.ErrorNumber);
			kparams.AddStringIfNotNull("fileName", this.FileName);
			kparams.AddStringIfNotNull("description", this.Description);
			return kparams;
		}
		#endregion
	}
}

