using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaConversionProfile : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private KalturaConversionProfileStatus _Status = null;
		private string _Name = null;
		private string _SystemName = null;
		private string _Tags = null;
		private string _Description = null;
		private string _DefaultEntryId = null;
		private int _CreatedAt = Int32.MinValue;
		private string _FlavorParamsIds = null;
		private KalturaNullableBoolean _IsDefault = (KalturaNullableBoolean)Int32.MinValue;
		private bool? _IsPartnerDefault = false;
		private KalturaCropDimensions _CropDimensions;
		private int _ClipStart = Int32.MinValue;
		private int _ClipDuration = Int32.MinValue;
		private string _XslTransformation = null;
		private int _StorageProfileId = Int32.MinValue;
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
		public KalturaConversionProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
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
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
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
		public string DefaultEntryId
		{
			get { return _DefaultEntryId; }
			set 
			{ 
				_DefaultEntryId = value;
				OnPropertyChanged("DefaultEntryId");
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
		public string FlavorParamsIds
		{
			get { return _FlavorParamsIds; }
			set 
			{ 
				_FlavorParamsIds = value;
				OnPropertyChanged("FlavorParamsIds");
			}
		}
		public KalturaNullableBoolean IsDefault
		{
			get { return _IsDefault; }
			set 
			{ 
				_IsDefault = value;
				OnPropertyChanged("IsDefault");
			}
		}
		public bool? IsPartnerDefault
		{
			get { return _IsPartnerDefault; }
			set 
			{ 
				_IsPartnerDefault = value;
				OnPropertyChanged("IsPartnerDefault");
			}
		}
		public KalturaCropDimensions CropDimensions
		{
			get { return _CropDimensions; }
			set 
			{ 
				_CropDimensions = value;
				OnPropertyChanged("CropDimensions");
			}
		}
		public int ClipStart
		{
			get { return _ClipStart; }
			set 
			{ 
				_ClipStart = value;
				OnPropertyChanged("ClipStart");
			}
		}
		public int ClipDuration
		{
			get { return _ClipDuration; }
			set 
			{ 
				_ClipDuration = value;
				OnPropertyChanged("ClipDuration");
			}
		}
		public string XslTransformation
		{
			get { return _XslTransformation; }
			set 
			{ 
				_XslTransformation = value;
				OnPropertyChanged("XslTransformation");
			}
		}
		public int StorageProfileId
		{
			get { return _StorageProfileId; }
			set 
			{ 
				_StorageProfileId = value;
				OnPropertyChanged("StorageProfileId");
			}
		}
		#endregion

		#region CTor
		public KalturaConversionProfile()
		{
		}

		public KalturaConversionProfile(XmlElement node)
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
					case "status":
						this.Status = (KalturaConversionProfileStatus)KalturaStringEnum.Parse(typeof(KalturaConversionProfileStatus), txt);
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "systemName":
						this.SystemName = txt;
						continue;
					case "tags":
						this.Tags = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "defaultEntryId":
						this.DefaultEntryId = txt;
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "flavorParamsIds":
						this.FlavorParamsIds = txt;
						continue;
					case "isDefault":
						this.IsDefault = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "isPartnerDefault":
						this.IsPartnerDefault = ParseBool(txt);
						continue;
					case "cropDimensions":
						this.CropDimensions = (KalturaCropDimensions)KalturaObjectFactory.Create(propertyNode);
						continue;
					case "clipStart":
						this.ClipStart = ParseInt(txt);
						continue;
					case "clipDuration":
						this.ClipDuration = ParseInt(txt);
						continue;
					case "xslTransformation":
						this.XslTransformation = txt;
						continue;
					case "storageProfileId":
						this.StorageProfileId = ParseInt(txt);
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
			kparams.AddStringEnumIfNotNull("status", this.Status);
			kparams.AddStringIfNotNull("name", this.Name);
			kparams.AddStringIfNotNull("systemName", this.SystemName);
			kparams.AddStringIfNotNull("tags", this.Tags);
			kparams.AddStringIfNotNull("description", this.Description);
			kparams.AddStringIfNotNull("defaultEntryId", this.DefaultEntryId);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddStringIfNotNull("flavorParamsIds", this.FlavorParamsIds);
			kparams.AddEnumIfNotNull("isDefault", this.IsDefault);
			kparams.AddBoolIfNotNull("isPartnerDefault", this.IsPartnerDefault);
			if (this.CropDimensions != null)
				kparams.Add("cropDimensions", this.CropDimensions.ToParams());
			kparams.AddIntIfNotNull("clipStart", this.ClipStart);
			kparams.AddIntIfNotNull("clipDuration", this.ClipDuration);
			kparams.AddStringIfNotNull("xslTransformation", this.XslTransformation);
			kparams.AddIntIfNotNull("storageProfileId", this.StorageProfileId);
			return kparams;
		}
		#endregion
	}
}

