using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaBulkUploadResult : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _BulkUploadJobId = Int32.MinValue;
		private int _LineIndex = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private KalturaBulkUploadAction _Action = (KalturaBulkUploadAction)Int32.MinValue;
		private string _EntryId = null;
		private string _ObjectId = null;
		private KalturaBulkUploadResultObjectType _BulkUploadResultObjectType = null;
		private int _EntryStatus = Int32.MinValue;
		private string _RowData = null;
		private string _Title = null;
		private string _Description = null;
		private string _Tags = null;
		private string _Url = null;
		private string _ContentType = null;
		private int _ConversionProfileId = Int32.MinValue;
		private int _AccessControlProfileId = Int32.MinValue;
		private string _Category = null;
		private int _ScheduleStartDate = Int32.MinValue;
		private int _ScheduleEndDate = Int32.MinValue;
		private string _ThumbnailUrl = null;
		private bool? _ThumbnailSaved = false;
		private string _PartnerData = null;
		private string _ErrorDescription = null;
		private IList<KalturaBulkUploadPluginData> _PluginsData;
		private string _SshPrivateKey = null;
		private string _SshPublicKey = null;
		private string _SshKeyPassphrase = null;
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
		public int BulkUploadJobId
		{
			get { return _BulkUploadJobId; }
			set 
			{ 
				_BulkUploadJobId = value;
				OnPropertyChanged("BulkUploadJobId");
			}
		}
		public int LineIndex
		{
			get { return _LineIndex; }
			set 
			{ 
				_LineIndex = value;
				OnPropertyChanged("LineIndex");
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
		public KalturaBulkUploadAction Action
		{
			get { return _Action; }
			set 
			{ 
				_Action = value;
				OnPropertyChanged("Action");
			}
		}
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public string ObjectId
		{
			get { return _ObjectId; }
			set 
			{ 
				_ObjectId = value;
				OnPropertyChanged("ObjectId");
			}
		}
		public KalturaBulkUploadResultObjectType BulkUploadResultObjectType
		{
			get { return _BulkUploadResultObjectType; }
			set 
			{ 
				_BulkUploadResultObjectType = value;
				OnPropertyChanged("BulkUploadResultObjectType");
			}
		}
		public int EntryStatus
		{
			get { return _EntryStatus; }
			set 
			{ 
				_EntryStatus = value;
				OnPropertyChanged("EntryStatus");
			}
		}
		public string RowData
		{
			get { return _RowData; }
			set 
			{ 
				_RowData = value;
				OnPropertyChanged("RowData");
			}
		}
		public string Title
		{
			get { return _Title; }
			set 
			{ 
				_Title = value;
				OnPropertyChanged("Title");
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
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public string Url
		{
			get { return _Url; }
			set 
			{ 
				_Url = value;
				OnPropertyChanged("Url");
			}
		}
		public string ContentType
		{
			get { return _ContentType; }
			set 
			{ 
				_ContentType = value;
				OnPropertyChanged("ContentType");
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
		public int AccessControlProfileId
		{
			get { return _AccessControlProfileId; }
			set 
			{ 
				_AccessControlProfileId = value;
				OnPropertyChanged("AccessControlProfileId");
			}
		}
		public string Category
		{
			get { return _Category; }
			set 
			{ 
				_Category = value;
				OnPropertyChanged("Category");
			}
		}
		public int ScheduleStartDate
		{
			get { return _ScheduleStartDate; }
			set 
			{ 
				_ScheduleStartDate = value;
				OnPropertyChanged("ScheduleStartDate");
			}
		}
		public int ScheduleEndDate
		{
			get { return _ScheduleEndDate; }
			set 
			{ 
				_ScheduleEndDate = value;
				OnPropertyChanged("ScheduleEndDate");
			}
		}
		public string ThumbnailUrl
		{
			get { return _ThumbnailUrl; }
			set 
			{ 
				_ThumbnailUrl = value;
				OnPropertyChanged("ThumbnailUrl");
			}
		}
		public bool? ThumbnailSaved
		{
			get { return _ThumbnailSaved; }
			set 
			{ 
				_ThumbnailSaved = value;
				OnPropertyChanged("ThumbnailSaved");
			}
		}
		public string PartnerData
		{
			get { return _PartnerData; }
			set 
			{ 
				_PartnerData = value;
				OnPropertyChanged("PartnerData");
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
		public IList<KalturaBulkUploadPluginData> PluginsData
		{
			get { return _PluginsData; }
			set 
			{ 
				_PluginsData = value;
				OnPropertyChanged("PluginsData");
			}
		}
		public string SshPrivateKey
		{
			get { return _SshPrivateKey; }
			set 
			{ 
				_SshPrivateKey = value;
				OnPropertyChanged("SshPrivateKey");
			}
		}
		public string SshPublicKey
		{
			get { return _SshPublicKey; }
			set 
			{ 
				_SshPublicKey = value;
				OnPropertyChanged("SshPublicKey");
			}
		}
		public string SshKeyPassphrase
		{
			get { return _SshKeyPassphrase; }
			set 
			{ 
				_SshKeyPassphrase = value;
				OnPropertyChanged("SshKeyPassphrase");
			}
		}
		#endregion

		#region CTor
		public KalturaBulkUploadResult()
		{
		}

		public KalturaBulkUploadResult(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "bulkUploadJobId":
						this.BulkUploadJobId = ParseInt(txt);
						continue;
					case "lineIndex":
						this.LineIndex = ParseInt(txt);
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "action":
						this.Action = (KalturaBulkUploadAction)ParseEnum(typeof(KalturaBulkUploadAction), txt);
						continue;
					case "entryId":
						this.EntryId = txt;
						continue;
					case "objectId":
						this.ObjectId = txt;
						continue;
					case "bulkUploadResultObjectType":
						this.BulkUploadResultObjectType = (KalturaBulkUploadResultObjectType)KalturaStringEnum.Parse(typeof(KalturaBulkUploadResultObjectType), txt);
						continue;
					case "entryStatus":
						this.EntryStatus = ParseInt(txt);
						continue;
					case "rowData":
						this.RowData = txt;
						continue;
					case "title":
						this.Title = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "tags":
						this.Tags = txt;
						continue;
					case "url":
						this.Url = txt;
						continue;
					case "contentType":
						this.ContentType = txt;
						continue;
					case "conversionProfileId":
						this.ConversionProfileId = ParseInt(txt);
						continue;
					case "accessControlProfileId":
						this.AccessControlProfileId = ParseInt(txt);
						continue;
					case "category":
						this.Category = txt;
						continue;
					case "scheduleStartDate":
						this.ScheduleStartDate = ParseInt(txt);
						continue;
					case "scheduleEndDate":
						this.ScheduleEndDate = ParseInt(txt);
						continue;
					case "thumbnailUrl":
						this.ThumbnailUrl = txt;
						continue;
					case "thumbnailSaved":
						this.ThumbnailSaved = ParseBool(txt);
						continue;
					case "partnerData":
						this.PartnerData = txt;
						continue;
					case "errorDescription":
						this.ErrorDescription = txt;
						continue;
					case "pluginsData":
						this.PluginsData = new List<KalturaBulkUploadPluginData>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.PluginsData.Add((KalturaBulkUploadPluginData)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "sshPrivateKey":
						this.SshPrivateKey = txt;
						continue;
					case "sshPublicKey":
						this.SshPublicKey = txt;
						continue;
					case "sshKeyPassphrase":
						this.SshKeyPassphrase = txt;
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
			kparams.AddIntIfNotNull("bulkUploadJobId", this.BulkUploadJobId);
			kparams.AddIntIfNotNull("lineIndex", this.LineIndex);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddEnumIfNotNull("action", this.Action);
			kparams.AddStringIfNotNull("entryId", this.EntryId);
			kparams.AddStringIfNotNull("objectId", this.ObjectId);
			kparams.AddStringEnumIfNotNull("bulkUploadResultObjectType", this.BulkUploadResultObjectType);
			kparams.AddIntIfNotNull("entryStatus", this.EntryStatus);
			kparams.AddStringIfNotNull("rowData", this.RowData);
			kparams.AddStringIfNotNull("title", this.Title);
			kparams.AddStringIfNotNull("description", this.Description);
			kparams.AddStringIfNotNull("tags", this.Tags);
			kparams.AddStringIfNotNull("url", this.Url);
			kparams.AddStringIfNotNull("contentType", this.ContentType);
			kparams.AddIntIfNotNull("conversionProfileId", this.ConversionProfileId);
			kparams.AddIntIfNotNull("accessControlProfileId", this.AccessControlProfileId);
			kparams.AddStringIfNotNull("category", this.Category);
			kparams.AddIntIfNotNull("scheduleStartDate", this.ScheduleStartDate);
			kparams.AddIntIfNotNull("scheduleEndDate", this.ScheduleEndDate);
			kparams.AddStringIfNotNull("thumbnailUrl", this.ThumbnailUrl);
			kparams.AddBoolIfNotNull("thumbnailSaved", this.ThumbnailSaved);
			kparams.AddStringIfNotNull("partnerData", this.PartnerData);
			kparams.AddStringIfNotNull("errorDescription", this.ErrorDescription);
			if (this.PluginsData != null)
			{
				if (this.PluginsData.Count == 0)
				{
					kparams.Add("pluginsData:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaBulkUploadPluginData item in this.PluginsData)
					{
						kparams.Add("pluginsData:" + i + ":objectType", item.GetType().Name);
						kparams.Add("pluginsData:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddStringIfNotNull("sshPrivateKey", this.SshPrivateKey);
			kparams.AddStringIfNotNull("sshPublicKey", this.SshPublicKey);
			kparams.AddStringIfNotNull("sshKeyPassphrase", this.SshKeyPassphrase);
			return kparams;
		}
		#endregion
	}
}

