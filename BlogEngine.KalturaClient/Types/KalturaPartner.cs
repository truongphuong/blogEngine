using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaPartner : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _Name = null;
		private string _Website = null;
		private string _NotificationUrl = null;
		private int _AppearInSearch = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private string _AdminName = null;
		private string _AdminEmail = null;
		private string _Description = null;
		private KalturaCommercialUseType _CommercialUse = (KalturaCommercialUseType)Int32.MinValue;
		private string _LandingPage = null;
		private string _UserLandingPage = null;
		private string _ContentCategories = null;
		private KalturaPartnerType _Type = (KalturaPartnerType)Int32.MinValue;
		private string _Phone = null;
		private string _DescribeYourself = null;
		private bool? _AdultContent = false;
		private string _DefConversionProfileType = null;
		private int _Notify = Int32.MinValue;
		private KalturaPartnerStatus _Status = (KalturaPartnerStatus)Int32.MinValue;
		private int _AllowQuickEdit = Int32.MinValue;
		private int _MergeEntryLists = Int32.MinValue;
		private string _NotificationsConfig = null;
		private int _MaxUploadSize = Int32.MinValue;
		private int _PartnerPackage = Int32.MinValue;
		private string _Secret = null;
		private string _AdminSecret = null;
		private string _CmsPassword = null;
		private int _AllowMultiNotification = Int32.MinValue;
		private int _AdminLoginUsersQuota = Int32.MinValue;
		private string _AdminUserId = null;
		private string _FirstName = null;
		private string _LastName = null;
		private string _Country = null;
		private string _State = null;
		private IList<KalturaKeyValue> _AdditionalParams;
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
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string Website
		{
			get { return _Website; }
			set 
			{ 
				_Website = value;
				OnPropertyChanged("Website");
			}
		}
		public string NotificationUrl
		{
			get { return _NotificationUrl; }
			set 
			{ 
				_NotificationUrl = value;
				OnPropertyChanged("NotificationUrl");
			}
		}
		public int AppearInSearch
		{
			get { return _AppearInSearch; }
			set 
			{ 
				_AppearInSearch = value;
				OnPropertyChanged("AppearInSearch");
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
		public string AdminName
		{
			get { return _AdminName; }
			set 
			{ 
				_AdminName = value;
				OnPropertyChanged("AdminName");
			}
		}
		public string AdminEmail
		{
			get { return _AdminEmail; }
			set 
			{ 
				_AdminEmail = value;
				OnPropertyChanged("AdminEmail");
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
		public KalturaCommercialUseType CommercialUse
		{
			get { return _CommercialUse; }
			set 
			{ 
				_CommercialUse = value;
				OnPropertyChanged("CommercialUse");
			}
		}
		public string LandingPage
		{
			get { return _LandingPage; }
			set 
			{ 
				_LandingPage = value;
				OnPropertyChanged("LandingPage");
			}
		}
		public string UserLandingPage
		{
			get { return _UserLandingPage; }
			set 
			{ 
				_UserLandingPage = value;
				OnPropertyChanged("UserLandingPage");
			}
		}
		public string ContentCategories
		{
			get { return _ContentCategories; }
			set 
			{ 
				_ContentCategories = value;
				OnPropertyChanged("ContentCategories");
			}
		}
		public KalturaPartnerType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string Phone
		{
			get { return _Phone; }
			set 
			{ 
				_Phone = value;
				OnPropertyChanged("Phone");
			}
		}
		public string DescribeYourself
		{
			get { return _DescribeYourself; }
			set 
			{ 
				_DescribeYourself = value;
				OnPropertyChanged("DescribeYourself");
			}
		}
		public bool? AdultContent
		{
			get { return _AdultContent; }
			set 
			{ 
				_AdultContent = value;
				OnPropertyChanged("AdultContent");
			}
		}
		public string DefConversionProfileType
		{
			get { return _DefConversionProfileType; }
			set 
			{ 
				_DefConversionProfileType = value;
				OnPropertyChanged("DefConversionProfileType");
			}
		}
		public int Notify
		{
			get { return _Notify; }
			set 
			{ 
				_Notify = value;
				OnPropertyChanged("Notify");
			}
		}
		public KalturaPartnerStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public int AllowQuickEdit
		{
			get { return _AllowQuickEdit; }
			set 
			{ 
				_AllowQuickEdit = value;
				OnPropertyChanged("AllowQuickEdit");
			}
		}
		public int MergeEntryLists
		{
			get { return _MergeEntryLists; }
			set 
			{ 
				_MergeEntryLists = value;
				OnPropertyChanged("MergeEntryLists");
			}
		}
		public string NotificationsConfig
		{
			get { return _NotificationsConfig; }
			set 
			{ 
				_NotificationsConfig = value;
				OnPropertyChanged("NotificationsConfig");
			}
		}
		public int MaxUploadSize
		{
			get { return _MaxUploadSize; }
			set 
			{ 
				_MaxUploadSize = value;
				OnPropertyChanged("MaxUploadSize");
			}
		}
		public int PartnerPackage
		{
			get { return _PartnerPackage; }
			set 
			{ 
				_PartnerPackage = value;
				OnPropertyChanged("PartnerPackage");
			}
		}
		public string Secret
		{
			get { return _Secret; }
			set 
			{ 
				_Secret = value;
				OnPropertyChanged("Secret");
			}
		}
		public string AdminSecret
		{
			get { return _AdminSecret; }
			set 
			{ 
				_AdminSecret = value;
				OnPropertyChanged("AdminSecret");
			}
		}
		public string CmsPassword
		{
			get { return _CmsPassword; }
			set 
			{ 
				_CmsPassword = value;
				OnPropertyChanged("CmsPassword");
			}
		}
		public int AllowMultiNotification
		{
			get { return _AllowMultiNotification; }
			set 
			{ 
				_AllowMultiNotification = value;
				OnPropertyChanged("AllowMultiNotification");
			}
		}
		public int AdminLoginUsersQuota
		{
			get { return _AdminLoginUsersQuota; }
			set 
			{ 
				_AdminLoginUsersQuota = value;
				OnPropertyChanged("AdminLoginUsersQuota");
			}
		}
		public string AdminUserId
		{
			get { return _AdminUserId; }
			set 
			{ 
				_AdminUserId = value;
				OnPropertyChanged("AdminUserId");
			}
		}
		public string FirstName
		{
			get { return _FirstName; }
			set 
			{ 
				_FirstName = value;
				OnPropertyChanged("FirstName");
			}
		}
		public string LastName
		{
			get { return _LastName; }
			set 
			{ 
				_LastName = value;
				OnPropertyChanged("LastName");
			}
		}
		public string Country
		{
			get { return _Country; }
			set 
			{ 
				_Country = value;
				OnPropertyChanged("Country");
			}
		}
		public string State
		{
			get { return _State; }
			set 
			{ 
				_State = value;
				OnPropertyChanged("State");
			}
		}
		public IList<KalturaKeyValue> AdditionalParams
		{
			get { return _AdditionalParams; }
			set 
			{ 
				_AdditionalParams = value;
				OnPropertyChanged("AdditionalParams");
			}
		}
		#endregion

		#region CTor
		public KalturaPartner()
		{
		}

		public KalturaPartner(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "website":
						this.Website = txt;
						continue;
					case "notificationUrl":
						this.NotificationUrl = txt;
						continue;
					case "appearInSearch":
						this.AppearInSearch = ParseInt(txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "adminName":
						this.AdminName = txt;
						continue;
					case "adminEmail":
						this.AdminEmail = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "commercialUse":
						this.CommercialUse = (KalturaCommercialUseType)ParseEnum(typeof(KalturaCommercialUseType), txt);
						continue;
					case "landingPage":
						this.LandingPage = txt;
						continue;
					case "userLandingPage":
						this.UserLandingPage = txt;
						continue;
					case "contentCategories":
						this.ContentCategories = txt;
						continue;
					case "type":
						this.Type = (KalturaPartnerType)ParseEnum(typeof(KalturaPartnerType), txt);
						continue;
					case "phone":
						this.Phone = txt;
						continue;
					case "describeYourself":
						this.DescribeYourself = txt;
						continue;
					case "adultContent":
						this.AdultContent = ParseBool(txt);
						continue;
					case "defConversionProfileType":
						this.DefConversionProfileType = txt;
						continue;
					case "notify":
						this.Notify = ParseInt(txt);
						continue;
					case "status":
						this.Status = (KalturaPartnerStatus)ParseEnum(typeof(KalturaPartnerStatus), txt);
						continue;
					case "allowQuickEdit":
						this.AllowQuickEdit = ParseInt(txt);
						continue;
					case "mergeEntryLists":
						this.MergeEntryLists = ParseInt(txt);
						continue;
					case "notificationsConfig":
						this.NotificationsConfig = txt;
						continue;
					case "maxUploadSize":
						this.MaxUploadSize = ParseInt(txt);
						continue;
					case "partnerPackage":
						this.PartnerPackage = ParseInt(txt);
						continue;
					case "secret":
						this.Secret = txt;
						continue;
					case "adminSecret":
						this.AdminSecret = txt;
						continue;
					case "cmsPassword":
						this.CmsPassword = txt;
						continue;
					case "allowMultiNotification":
						this.AllowMultiNotification = ParseInt(txt);
						continue;
					case "adminLoginUsersQuota":
						this.AdminLoginUsersQuota = ParseInt(txt);
						continue;
					case "adminUserId":
						this.AdminUserId = txt;
						continue;
					case "firstName":
						this.FirstName = txt;
						continue;
					case "lastName":
						this.LastName = txt;
						continue;
					case "country":
						this.Country = txt;
						continue;
					case "state":
						this.State = txt;
						continue;
					case "additionalParams":
						this.AdditionalParams = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.AdditionalParams.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode));
						}
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
			kparams.AddStringIfNotNull("name", this.Name);
			kparams.AddStringIfNotNull("website", this.Website);
			kparams.AddStringIfNotNull("notificationUrl", this.NotificationUrl);
			kparams.AddIntIfNotNull("appearInSearch", this.AppearInSearch);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddStringIfNotNull("adminName", this.AdminName);
			kparams.AddStringIfNotNull("adminEmail", this.AdminEmail);
			kparams.AddStringIfNotNull("description", this.Description);
			kparams.AddEnumIfNotNull("commercialUse", this.CommercialUse);
			kparams.AddStringIfNotNull("landingPage", this.LandingPage);
			kparams.AddStringIfNotNull("userLandingPage", this.UserLandingPage);
			kparams.AddStringIfNotNull("contentCategories", this.ContentCategories);
			kparams.AddEnumIfNotNull("type", this.Type);
			kparams.AddStringIfNotNull("phone", this.Phone);
			kparams.AddStringIfNotNull("describeYourself", this.DescribeYourself);
			kparams.AddBoolIfNotNull("adultContent", this.AdultContent);
			kparams.AddStringIfNotNull("defConversionProfileType", this.DefConversionProfileType);
			kparams.AddIntIfNotNull("notify", this.Notify);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddIntIfNotNull("allowQuickEdit", this.AllowQuickEdit);
			kparams.AddIntIfNotNull("mergeEntryLists", this.MergeEntryLists);
			kparams.AddStringIfNotNull("notificationsConfig", this.NotificationsConfig);
			kparams.AddIntIfNotNull("maxUploadSize", this.MaxUploadSize);
			kparams.AddIntIfNotNull("partnerPackage", this.PartnerPackage);
			kparams.AddStringIfNotNull("secret", this.Secret);
			kparams.AddStringIfNotNull("adminSecret", this.AdminSecret);
			kparams.AddStringIfNotNull("cmsPassword", this.CmsPassword);
			kparams.AddIntIfNotNull("allowMultiNotification", this.AllowMultiNotification);
			kparams.AddIntIfNotNull("adminLoginUsersQuota", this.AdminLoginUsersQuota);
			kparams.AddStringIfNotNull("adminUserId", this.AdminUserId);
			kparams.AddStringIfNotNull("firstName", this.FirstName);
			kparams.AddStringIfNotNull("lastName", this.LastName);
			kparams.AddStringIfNotNull("country", this.Country);
			kparams.AddStringIfNotNull("state", this.State);
			if (this.AdditionalParams != null)
			{
				if (this.AdditionalParams.Count == 0)
				{
					kparams.Add("additionalParams:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaKeyValue item in this.AdditionalParams)
					{
						kparams.Add("additionalParams:" + i + ":objectType", item.GetType().Name);
						kparams.Add("additionalParams:" + i, item.ToParams());
						i++;
					}
				}
			}
			return kparams;
		}
		#endregion
	}
}

