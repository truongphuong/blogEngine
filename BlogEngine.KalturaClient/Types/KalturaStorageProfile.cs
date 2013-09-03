using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaStorageProfile : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private string _Desciption = null;
		private KalturaStorageProfileStatus _Status = (KalturaStorageProfileStatus)Int32.MinValue;
		private KalturaStorageProfileProtocol _Protocol = (KalturaStorageProfileProtocol)Int32.MinValue;
		private string _StorageUrl = null;
		private string _StorageBaseDir = null;
		private string _StorageUsername = null;
		private string _StoragePassword = null;
		private bool? _StorageFtpPassiveMode = false;
		private string _DeliveryHttpBaseUrl = null;
		private string _DeliveryRmpBaseUrl = null;
		private string _DeliveryIisBaseUrl = null;
		private int _MinFileSize = Int32.MinValue;
		private int _MaxFileSize = Int32.MinValue;
		private string _FlavorParamsIds = null;
		private int _MaxConcurrentConnections = Int32.MinValue;
		private string _PathManagerClass = null;
		private string _UrlManagerClass = null;
		private IList<KalturaKeyValue> _UrlManagerParams;
		private int _Trigger = Int32.MinValue;
		private int _DeliveryPriority = Int32.MinValue;
		private KalturaStorageProfileDeliveryStatus _DeliveryStatus = (KalturaStorageProfileDeliveryStatus)Int32.MinValue;
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
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		public string Desciption
		{
			get { return _Desciption; }
			set 
			{ 
				_Desciption = value;
				OnPropertyChanged("Desciption");
			}
		}
		public KalturaStorageProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public KalturaStorageProfileProtocol Protocol
		{
			get { return _Protocol; }
			set 
			{ 
				_Protocol = value;
				OnPropertyChanged("Protocol");
			}
		}
		public string StorageUrl
		{
			get { return _StorageUrl; }
			set 
			{ 
				_StorageUrl = value;
				OnPropertyChanged("StorageUrl");
			}
		}
		public string StorageBaseDir
		{
			get { return _StorageBaseDir; }
			set 
			{ 
				_StorageBaseDir = value;
				OnPropertyChanged("StorageBaseDir");
			}
		}
		public string StorageUsername
		{
			get { return _StorageUsername; }
			set 
			{ 
				_StorageUsername = value;
				OnPropertyChanged("StorageUsername");
			}
		}
		public string StoragePassword
		{
			get { return _StoragePassword; }
			set 
			{ 
				_StoragePassword = value;
				OnPropertyChanged("StoragePassword");
			}
		}
		public bool? StorageFtpPassiveMode
		{
			get { return _StorageFtpPassiveMode; }
			set 
			{ 
				_StorageFtpPassiveMode = value;
				OnPropertyChanged("StorageFtpPassiveMode");
			}
		}
		public string DeliveryHttpBaseUrl
		{
			get { return _DeliveryHttpBaseUrl; }
			set 
			{ 
				_DeliveryHttpBaseUrl = value;
				OnPropertyChanged("DeliveryHttpBaseUrl");
			}
		}
		public string DeliveryRmpBaseUrl
		{
			get { return _DeliveryRmpBaseUrl; }
			set 
			{ 
				_DeliveryRmpBaseUrl = value;
				OnPropertyChanged("DeliveryRmpBaseUrl");
			}
		}
		public string DeliveryIisBaseUrl
		{
			get { return _DeliveryIisBaseUrl; }
			set 
			{ 
				_DeliveryIisBaseUrl = value;
				OnPropertyChanged("DeliveryIisBaseUrl");
			}
		}
		public int MinFileSize
		{
			get { return _MinFileSize; }
			set 
			{ 
				_MinFileSize = value;
				OnPropertyChanged("MinFileSize");
			}
		}
		public int MaxFileSize
		{
			get { return _MaxFileSize; }
			set 
			{ 
				_MaxFileSize = value;
				OnPropertyChanged("MaxFileSize");
			}
		}
		public string FlavorParamsIds
		{
			get { return _FlavorParamsIds; }
			set 
			{ 
				_FlavorParamsIds = value;
				OnPropertyChanged("FlavorParamsIds");
			}
		}
		public int MaxConcurrentConnections
		{
			get { return _MaxConcurrentConnections; }
			set 
			{ 
				_MaxConcurrentConnections = value;
				OnPropertyChanged("MaxConcurrentConnections");
			}
		}
		public string PathManagerClass
		{
			get { return _PathManagerClass; }
			set 
			{ 
				_PathManagerClass = value;
				OnPropertyChanged("PathManagerClass");
			}
		}
		public string UrlManagerClass
		{
			get { return _UrlManagerClass; }
			set 
			{ 
				_UrlManagerClass = value;
				OnPropertyChanged("UrlManagerClass");
			}
		}
		public IList<KalturaKeyValue> UrlManagerParams
		{
			get { return _UrlManagerParams; }
			set 
			{ 
				_UrlManagerParams = value;
				OnPropertyChanged("UrlManagerParams");
			}
		}
		public int Trigger
		{
			get { return _Trigger; }
			set 
			{ 
				_Trigger = value;
				OnPropertyChanged("Trigger");
			}
		}
		public int DeliveryPriority
		{
			get { return _DeliveryPriority; }
			set 
			{ 
				_DeliveryPriority = value;
				OnPropertyChanged("DeliveryPriority");
			}
		}
		public KalturaStorageProfileDeliveryStatus DeliveryStatus
		{
			get { return _DeliveryStatus; }
			set 
			{ 
				_DeliveryStatus = value;
				OnPropertyChanged("DeliveryStatus");
			}
		}
		#endregion

		#region CTor
		public KalturaStorageProfile()
		{
		}

		public KalturaStorageProfile(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "systemName":
						this.SystemName = txt;
						continue;
					case "desciption":
						this.Desciption = txt;
						continue;
					case "status":
						this.Status = (KalturaStorageProfileStatus)ParseEnum(typeof(KalturaStorageProfileStatus), txt);
						continue;
					case "protocol":
						this.Protocol = (KalturaStorageProfileProtocol)ParseEnum(typeof(KalturaStorageProfileProtocol), txt);
						continue;
					case "storageUrl":
						this.StorageUrl = txt;
						continue;
					case "storageBaseDir":
						this.StorageBaseDir = txt;
						continue;
					case "storageUsername":
						this.StorageUsername = txt;
						continue;
					case "storagePassword":
						this.StoragePassword = txt;
						continue;
					case "storageFtpPassiveMode":
						this.StorageFtpPassiveMode = ParseBool(txt);
						continue;
					case "deliveryHttpBaseUrl":
						this.DeliveryHttpBaseUrl = txt;
						continue;
					case "deliveryRmpBaseUrl":
						this.DeliveryRmpBaseUrl = txt;
						continue;
					case "deliveryIisBaseUrl":
						this.DeliveryIisBaseUrl = txt;
						continue;
					case "minFileSize":
						this.MinFileSize = ParseInt(txt);
						continue;
					case "maxFileSize":
						this.MaxFileSize = ParseInt(txt);
						continue;
					case "flavorParamsIds":
						this.FlavorParamsIds = txt;
						continue;
					case "maxConcurrentConnections":
						this.MaxConcurrentConnections = ParseInt(txt);
						continue;
					case "pathManagerClass":
						this.PathManagerClass = txt;
						continue;
					case "urlManagerClass":
						this.UrlManagerClass = txt;
						continue;
					case "urlManagerParams":
						this.UrlManagerParams = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.UrlManagerParams.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "trigger":
						this.Trigger = ParseInt(txt);
						continue;
					case "deliveryPriority":
						this.DeliveryPriority = ParseInt(txt);
						continue;
					case "deliveryStatus":
						this.DeliveryStatus = (KalturaStorageProfileDeliveryStatus)ParseEnum(typeof(KalturaStorageProfileDeliveryStatus), txt);
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
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIntIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddStringIfNotNull("name", this.Name);
			kparams.AddStringIfNotNull("systemName", this.SystemName);
			kparams.AddStringIfNotNull("desciption", this.Desciption);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddEnumIfNotNull("protocol", this.Protocol);
			kparams.AddStringIfNotNull("storageUrl", this.StorageUrl);
			kparams.AddStringIfNotNull("storageBaseDir", this.StorageBaseDir);
			kparams.AddStringIfNotNull("storageUsername", this.StorageUsername);
			kparams.AddStringIfNotNull("storagePassword", this.StoragePassword);
			kparams.AddBoolIfNotNull("storageFtpPassiveMode", this.StorageFtpPassiveMode);
			kparams.AddStringIfNotNull("deliveryHttpBaseUrl", this.DeliveryHttpBaseUrl);
			kparams.AddStringIfNotNull("deliveryRmpBaseUrl", this.DeliveryRmpBaseUrl);
			kparams.AddStringIfNotNull("deliveryIisBaseUrl", this.DeliveryIisBaseUrl);
			kparams.AddIntIfNotNull("minFileSize", this.MinFileSize);
			kparams.AddIntIfNotNull("maxFileSize", this.MaxFileSize);
			kparams.AddStringIfNotNull("flavorParamsIds", this.FlavorParamsIds);
			kparams.AddIntIfNotNull("maxConcurrentConnections", this.MaxConcurrentConnections);
			kparams.AddStringIfNotNull("pathManagerClass", this.PathManagerClass);
			kparams.AddStringIfNotNull("urlManagerClass", this.UrlManagerClass);
			if (this.UrlManagerParams != null)
			{
				if (this.UrlManagerParams.Count == 0)
				{
					kparams.Add("urlManagerParams:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaKeyValue item in this.UrlManagerParams)
					{
						kparams.Add("urlManagerParams:" + i + ":objectType", item.GetType().Name);
						kparams.Add("urlManagerParams:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddIntIfNotNull("trigger", this.Trigger);
			kparams.AddIntIfNotNull("deliveryPriority", this.DeliveryPriority);
			kparams.AddEnumIfNotNull("deliveryStatus", this.DeliveryStatus);
			return kparams;
		}
		#endregion
	}
}

