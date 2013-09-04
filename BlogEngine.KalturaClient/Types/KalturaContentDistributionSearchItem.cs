using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaContentDistributionSearchItem : KalturaSearchItem
	{
		#region Private Fields
		private bool? _NoDistributionProfiles = false;
		private int _DistributionProfileId = Int32.MinValue;
		private KalturaEntryDistributionSunStatus _DistributionSunStatus = (KalturaEntryDistributionSunStatus)Int32.MinValue;
		private KalturaEntryDistributionFlag _EntryDistributionFlag = (KalturaEntryDistributionFlag)Int32.MinValue;
		private KalturaEntryDistributionStatus _EntryDistributionStatus = (KalturaEntryDistributionStatus)Int32.MinValue;
		private bool? _HasEntryDistributionValidationErrors = false;
		private string _EntryDistributionValidationErrors = null;
		#endregion

		#region Properties
		public bool? NoDistributionProfiles
		{
			get { return _NoDistributionProfiles; }
			set 
			{ 
				_NoDistributionProfiles = value;
				OnPropertyChanged("NoDistributionProfiles");
			}
		}
		public int DistributionProfileId
		{
			get { return _DistributionProfileId; }
			set 
			{ 
				_DistributionProfileId = value;
				OnPropertyChanged("DistributionProfileId");
			}
		}
		public KalturaEntryDistributionSunStatus DistributionSunStatus
		{
			get { return _DistributionSunStatus; }
			set 
			{ 
				_DistributionSunStatus = value;
				OnPropertyChanged("DistributionSunStatus");
			}
		}
		public KalturaEntryDistributionFlag EntryDistributionFlag
		{
			get { return _EntryDistributionFlag; }
			set 
			{ 
				_EntryDistributionFlag = value;
				OnPropertyChanged("EntryDistributionFlag");
			}
		}
		public KalturaEntryDistributionStatus EntryDistributionStatus
		{
			get { return _EntryDistributionStatus; }
			set 
			{ 
				_EntryDistributionStatus = value;
				OnPropertyChanged("EntryDistributionStatus");
			}
		}
		public bool? HasEntryDistributionValidationErrors
		{
			get { return _HasEntryDistributionValidationErrors; }
			set 
			{ 
				_HasEntryDistributionValidationErrors = value;
				OnPropertyChanged("HasEntryDistributionValidationErrors");
			}
		}
		public string EntryDistributionValidationErrors
		{
			get { return _EntryDistributionValidationErrors; }
			set 
			{ 
				_EntryDistributionValidationErrors = value;
				OnPropertyChanged("EntryDistributionValidationErrors");
			}
		}
		#endregion

		#region CTor
		public KalturaContentDistributionSearchItem()
		{
		}

		public KalturaContentDistributionSearchItem(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "noDistributionProfiles":
						this.NoDistributionProfiles = ParseBool(txt);
						continue;
					case "distributionProfileId":
						this.DistributionProfileId = ParseInt(txt);
						continue;
					case "distributionSunStatus":
						this.DistributionSunStatus = (KalturaEntryDistributionSunStatus)ParseEnum(typeof(KalturaEntryDistributionSunStatus), txt);
						continue;
					case "entryDistributionFlag":
						this.EntryDistributionFlag = (KalturaEntryDistributionFlag)ParseEnum(typeof(KalturaEntryDistributionFlag), txt);
						continue;
					case "entryDistributionStatus":
						this.EntryDistributionStatus = (KalturaEntryDistributionStatus)ParseEnum(typeof(KalturaEntryDistributionStatus), txt);
						continue;
					case "hasEntryDistributionValidationErrors":
						this.HasEntryDistributionValidationErrors = ParseBool(txt);
						continue;
					case "entryDistributionValidationErrors":
						this.EntryDistributionValidationErrors = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddBoolIfNotNull("noDistributionProfiles", this.NoDistributionProfiles);
			kparams.AddIntIfNotNull("distributionProfileId", this.DistributionProfileId);
			kparams.AddEnumIfNotNull("distributionSunStatus", this.DistributionSunStatus);
			kparams.AddEnumIfNotNull("entryDistributionFlag", this.EntryDistributionFlag);
			kparams.AddEnumIfNotNull("entryDistributionStatus", this.EntryDistributionStatus);
			kparams.AddBoolIfNotNull("hasEntryDistributionValidationErrors", this.HasEntryDistributionValidationErrors);
			kparams.AddStringIfNotNull("entryDistributionValidationErrors", this.EntryDistributionValidationErrors);
			return kparams;
		}
		#endregion
	}
}

