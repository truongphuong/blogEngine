using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDistributionProfile : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private KalturaDistributionProviderType _ProviderType = null;
		private string _Name = null;
		private KalturaDistributionProfileStatus _Status = (KalturaDistributionProfileStatus)Int32.MinValue;
		private KalturaDistributionProfileActionStatus _SubmitEnabled = (KalturaDistributionProfileActionStatus)Int32.MinValue;
		private KalturaDistributionProfileActionStatus _UpdateEnabled = (KalturaDistributionProfileActionStatus)Int32.MinValue;
		private KalturaDistributionProfileActionStatus _DeleteEnabled = (KalturaDistributionProfileActionStatus)Int32.MinValue;
		private KalturaDistributionProfileActionStatus _ReportEnabled = (KalturaDistributionProfileActionStatus)Int32.MinValue;
		private string _AutoCreateFlavors = null;
		private string _AutoCreateThumb = null;
		private string _OptionalFlavorParamsIds = null;
		private string _RequiredFlavorParamsIds = null;
		private IList<KalturaDistributionThumbDimensions> _OptionalThumbDimensions;
		private IList<KalturaDistributionThumbDimensions> _RequiredThumbDimensions;
		private int _SunriseDefaultOffset = Int32.MinValue;
		private int _SunsetDefaultOffset = Int32.MinValue;
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
		public KalturaDistributionProviderType ProviderType
		{
			get { return _ProviderType; }
			set 
			{ 
				_ProviderType = value;
				OnPropertyChanged("ProviderType");
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
		public KalturaDistributionProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public KalturaDistributionProfileActionStatus SubmitEnabled
		{
			get { return _SubmitEnabled; }
			set 
			{ 
				_SubmitEnabled = value;
				OnPropertyChanged("SubmitEnabled");
			}
		}
		public KalturaDistributionProfileActionStatus UpdateEnabled
		{
			get { return _UpdateEnabled; }
			set 
			{ 
				_UpdateEnabled = value;
				OnPropertyChanged("UpdateEnabled");
			}
		}
		public KalturaDistributionProfileActionStatus DeleteEnabled
		{
			get { return _DeleteEnabled; }
			set 
			{ 
				_DeleteEnabled = value;
				OnPropertyChanged("DeleteEnabled");
			}
		}
		public KalturaDistributionProfileActionStatus ReportEnabled
		{
			get { return _ReportEnabled; }
			set 
			{ 
				_ReportEnabled = value;
				OnPropertyChanged("ReportEnabled");
			}
		}
		public string AutoCreateFlavors
		{
			get { return _AutoCreateFlavors; }
			set 
			{ 
				_AutoCreateFlavors = value;
				OnPropertyChanged("AutoCreateFlavors");
			}
		}
		public string AutoCreateThumb
		{
			get { return _AutoCreateThumb; }
			set 
			{ 
				_AutoCreateThumb = value;
				OnPropertyChanged("AutoCreateThumb");
			}
		}
		public string OptionalFlavorParamsIds
		{
			get { return _OptionalFlavorParamsIds; }
			set 
			{ 
				_OptionalFlavorParamsIds = value;
				OnPropertyChanged("OptionalFlavorParamsIds");
			}
		}
		public string RequiredFlavorParamsIds
		{
			get { return _RequiredFlavorParamsIds; }
			set 
			{ 
				_RequiredFlavorParamsIds = value;
				OnPropertyChanged("RequiredFlavorParamsIds");
			}
		}
		public IList<KalturaDistributionThumbDimensions> OptionalThumbDimensions
		{
			get { return _OptionalThumbDimensions; }
			set 
			{ 
				_OptionalThumbDimensions = value;
				OnPropertyChanged("OptionalThumbDimensions");
			}
		}
		public IList<KalturaDistributionThumbDimensions> RequiredThumbDimensions
		{
			get { return _RequiredThumbDimensions; }
			set 
			{ 
				_RequiredThumbDimensions = value;
				OnPropertyChanged("RequiredThumbDimensions");
			}
		}
		public int SunriseDefaultOffset
		{
			get { return _SunriseDefaultOffset; }
			set 
			{ 
				_SunriseDefaultOffset = value;
				OnPropertyChanged("SunriseDefaultOffset");
			}
		}
		public int SunsetDefaultOffset
		{
			get { return _SunsetDefaultOffset; }
			set 
			{ 
				_SunsetDefaultOffset = value;
				OnPropertyChanged("SunsetDefaultOffset");
			}
		}
		#endregion

		#region CTor
		public KalturaDistributionProfile()
		{
		}

		public KalturaDistributionProfile(XmlElement node)
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
					case "providerType":
						this.ProviderType = (KalturaDistributionProviderType)KalturaStringEnum.Parse(typeof(KalturaDistributionProviderType), txt);
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "status":
						this.Status = (KalturaDistributionProfileStatus)ParseEnum(typeof(KalturaDistributionProfileStatus), txt);
						continue;
					case "submitEnabled":
						this.SubmitEnabled = (KalturaDistributionProfileActionStatus)ParseEnum(typeof(KalturaDistributionProfileActionStatus), txt);
						continue;
					case "updateEnabled":
						this.UpdateEnabled = (KalturaDistributionProfileActionStatus)ParseEnum(typeof(KalturaDistributionProfileActionStatus), txt);
						continue;
					case "deleteEnabled":
						this.DeleteEnabled = (KalturaDistributionProfileActionStatus)ParseEnum(typeof(KalturaDistributionProfileActionStatus), txt);
						continue;
					case "reportEnabled":
						this.ReportEnabled = (KalturaDistributionProfileActionStatus)ParseEnum(typeof(KalturaDistributionProfileActionStatus), txt);
						continue;
					case "autoCreateFlavors":
						this.AutoCreateFlavors = txt;
						continue;
					case "autoCreateThumb":
						this.AutoCreateThumb = txt;
						continue;
					case "optionalFlavorParamsIds":
						this.OptionalFlavorParamsIds = txt;
						continue;
					case "requiredFlavorParamsIds":
						this.RequiredFlavorParamsIds = txt;
						continue;
					case "optionalThumbDimensions":
						this.OptionalThumbDimensions = new List<KalturaDistributionThumbDimensions>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.OptionalThumbDimensions.Add((KalturaDistributionThumbDimensions)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "requiredThumbDimensions":
						this.RequiredThumbDimensions = new List<KalturaDistributionThumbDimensions>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.RequiredThumbDimensions.Add((KalturaDistributionThumbDimensions)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "sunriseDefaultOffset":
						this.SunriseDefaultOffset = ParseInt(txt);
						continue;
					case "sunsetDefaultOffset":
						this.SunsetDefaultOffset = ParseInt(txt);
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
			kparams.AddStringEnumIfNotNull("providerType", this.ProviderType);
			kparams.AddStringIfNotNull("name", this.Name);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddEnumIfNotNull("submitEnabled", this.SubmitEnabled);
			kparams.AddEnumIfNotNull("updateEnabled", this.UpdateEnabled);
			kparams.AddEnumIfNotNull("deleteEnabled", this.DeleteEnabled);
			kparams.AddEnumIfNotNull("reportEnabled", this.ReportEnabled);
			kparams.AddStringIfNotNull("autoCreateFlavors", this.AutoCreateFlavors);
			kparams.AddStringIfNotNull("autoCreateThumb", this.AutoCreateThumb);
			kparams.AddStringIfNotNull("optionalFlavorParamsIds", this.OptionalFlavorParamsIds);
			kparams.AddStringIfNotNull("requiredFlavorParamsIds", this.RequiredFlavorParamsIds);
			if (this.OptionalThumbDimensions != null)
			{
				if (this.OptionalThumbDimensions.Count == 0)
				{
					kparams.Add("optionalThumbDimensions:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaDistributionThumbDimensions item in this.OptionalThumbDimensions)
					{
						kparams.Add("optionalThumbDimensions:" + i + ":objectType", item.GetType().Name);
						kparams.Add("optionalThumbDimensions:" + i, item.ToParams());
						i++;
					}
				}
			}
			if (this.RequiredThumbDimensions != null)
			{
				if (this.RequiredThumbDimensions.Count == 0)
				{
					kparams.Add("requiredThumbDimensions:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaDistributionThumbDimensions item in this.RequiredThumbDimensions)
					{
						kparams.Add("requiredThumbDimensions:" + i + ":objectType", item.GetType().Name);
						kparams.Add("requiredThumbDimensions:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddIntIfNotNull("sunriseDefaultOffset", this.SunriseDefaultOffset);
			kparams.AddIntIfNotNull("sunsetDefaultOffset", this.SunsetDefaultOffset);
			return kparams;
		}
		#endregion
	}
}

