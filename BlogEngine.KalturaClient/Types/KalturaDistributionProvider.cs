using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDistributionProvider : KalturaObjectBase
	{
		#region Private Fields
		private KalturaDistributionProviderType _Type = null;
		private string _Name = null;
		private bool? _ScheduleUpdateEnabled = false;
		private bool? _AvailabilityUpdateEnabled = false;
		private bool? _DeleteInsteadUpdate = false;
		private int _IntervalBeforeSunrise = Int32.MinValue;
		private int _IntervalBeforeSunset = Int32.MinValue;
		private string _UpdateRequiredEntryFields = null;
		private string _UpdateRequiredMetadataXPaths = null;
		#endregion

		#region Properties
		public KalturaDistributionProviderType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
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
		public bool? ScheduleUpdateEnabled
		{
			get { return _ScheduleUpdateEnabled; }
			set 
			{ 
				_ScheduleUpdateEnabled = value;
				OnPropertyChanged("ScheduleUpdateEnabled");
			}
		}
		public bool? AvailabilityUpdateEnabled
		{
			get { return _AvailabilityUpdateEnabled; }
			set 
			{ 
				_AvailabilityUpdateEnabled = value;
				OnPropertyChanged("AvailabilityUpdateEnabled");
			}
		}
		public bool? DeleteInsteadUpdate
		{
			get { return _DeleteInsteadUpdate; }
			set 
			{ 
				_DeleteInsteadUpdate = value;
				OnPropertyChanged("DeleteInsteadUpdate");
			}
		}
		public int IntervalBeforeSunrise
		{
			get { return _IntervalBeforeSunrise; }
			set 
			{ 
				_IntervalBeforeSunrise = value;
				OnPropertyChanged("IntervalBeforeSunrise");
			}
		}
		public int IntervalBeforeSunset
		{
			get { return _IntervalBeforeSunset; }
			set 
			{ 
				_IntervalBeforeSunset = value;
				OnPropertyChanged("IntervalBeforeSunset");
			}
		}
		public string UpdateRequiredEntryFields
		{
			get { return _UpdateRequiredEntryFields; }
			set 
			{ 
				_UpdateRequiredEntryFields = value;
				OnPropertyChanged("UpdateRequiredEntryFields");
			}
		}
		public string UpdateRequiredMetadataXPaths
		{
			get { return _UpdateRequiredMetadataXPaths; }
			set 
			{ 
				_UpdateRequiredMetadataXPaths = value;
				OnPropertyChanged("UpdateRequiredMetadataXPaths");
			}
		}
		#endregion

		#region CTor
		public KalturaDistributionProvider()
		{
		}

		public KalturaDistributionProvider(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "type":
						this.Type = (KalturaDistributionProviderType)KalturaStringEnum.Parse(typeof(KalturaDistributionProviderType), txt);
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "scheduleUpdateEnabled":
						this.ScheduleUpdateEnabled = ParseBool(txt);
						continue;
					case "availabilityUpdateEnabled":
						this.AvailabilityUpdateEnabled = ParseBool(txt);
						continue;
					case "deleteInsteadUpdate":
						this.DeleteInsteadUpdate = ParseBool(txt);
						continue;
					case "intervalBeforeSunrise":
						this.IntervalBeforeSunrise = ParseInt(txt);
						continue;
					case "intervalBeforeSunset":
						this.IntervalBeforeSunset = ParseInt(txt);
						continue;
					case "updateRequiredEntryFields":
						this.UpdateRequiredEntryFields = txt;
						continue;
					case "updateRequiredMetadataXPaths":
						this.UpdateRequiredMetadataXPaths = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringEnumIfNotNull("type", this.Type);
			kparams.AddStringIfNotNull("name", this.Name);
			kparams.AddBoolIfNotNull("scheduleUpdateEnabled", this.ScheduleUpdateEnabled);
			kparams.AddBoolIfNotNull("availabilityUpdateEnabled", this.AvailabilityUpdateEnabled);
			kparams.AddBoolIfNotNull("deleteInsteadUpdate", this.DeleteInsteadUpdate);
			kparams.AddIntIfNotNull("intervalBeforeSunrise", this.IntervalBeforeSunrise);
			kparams.AddIntIfNotNull("intervalBeforeSunset", this.IntervalBeforeSunset);
			kparams.AddStringIfNotNull("updateRequiredEntryFields", this.UpdateRequiredEntryFields);
			kparams.AddStringIfNotNull("updateRequiredMetadataXPaths", this.UpdateRequiredMetadataXPaths);
			return kparams;
		}
		#endregion
	}
}

