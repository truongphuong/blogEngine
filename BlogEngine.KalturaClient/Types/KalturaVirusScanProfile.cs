using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaVirusScanProfile : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private KalturaVirusScanProfileStatus _Status = (KalturaVirusScanProfileStatus)Int32.MinValue;
		private KalturaVirusScanEngineType _EngineType = null;
		private KalturaBaseEntryFilter _EntryFilter;
		private KalturaVirusFoundAction _ActionIfInfected = (KalturaVirusFoundAction)Int32.MinValue;
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
		public KalturaVirusScanProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public KalturaVirusScanEngineType EngineType
		{
			get { return _EngineType; }
			set 
			{ 
				_EngineType = value;
				OnPropertyChanged("EngineType");
			}
		}
		public KalturaBaseEntryFilter EntryFilter
		{
			get { return _EntryFilter; }
			set 
			{ 
				_EntryFilter = value;
				OnPropertyChanged("EntryFilter");
			}
		}
		public KalturaVirusFoundAction ActionIfInfected
		{
			get { return _ActionIfInfected; }
			set 
			{ 
				_ActionIfInfected = value;
				OnPropertyChanged("ActionIfInfected");
			}
		}
		#endregion

		#region CTor
		public KalturaVirusScanProfile()
		{
		}

		public KalturaVirusScanProfile(XmlElement node)
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
					case "status":
						this.Status = (KalturaVirusScanProfileStatus)ParseEnum(typeof(KalturaVirusScanProfileStatus), txt);
						continue;
					case "engineType":
						this.EngineType = (KalturaVirusScanEngineType)KalturaStringEnum.Parse(typeof(KalturaVirusScanEngineType), txt);
						continue;
					case "entryFilter":
						this.EntryFilter = (KalturaBaseEntryFilter)KalturaObjectFactory.Create(propertyNode);
						continue;
					case "actionIfInfected":
						this.ActionIfInfected = (KalturaVirusFoundAction)ParseEnum(typeof(KalturaVirusFoundAction), txt);
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
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddStringEnumIfNotNull("engineType", this.EngineType);
			if (this.EntryFilter != null)
				kparams.Add("entryFilter", this.EntryFilter.ToParams());
			kparams.AddEnumIfNotNull("actionIfInfected", this.ActionIfInfected);
			return kparams;
		}
		#endregion
	}
}

