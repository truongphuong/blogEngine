using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaGenericDistributionProfile : KalturaDistributionProfile
	{
		#region Private Fields
		private int _GenericProviderId = Int32.MinValue;
		private KalturaGenericDistributionProfileAction _SubmitAction;
		private KalturaGenericDistributionProfileAction _UpdateAction;
		private KalturaGenericDistributionProfileAction _DeleteAction;
		private KalturaGenericDistributionProfileAction _FetchReportAction;
		private string _UpdateRequiredEntryFields = null;
		private string _UpdateRequiredMetadataXPaths = null;
		#endregion

		#region Properties
		public int GenericProviderId
		{
			get { return _GenericProviderId; }
			set 
			{ 
				_GenericProviderId = value;
				OnPropertyChanged("GenericProviderId");
			}
		}
		public KalturaGenericDistributionProfileAction SubmitAction
		{
			get { return _SubmitAction; }
			set 
			{ 
				_SubmitAction = value;
				OnPropertyChanged("SubmitAction");
			}
		}
		public KalturaGenericDistributionProfileAction UpdateAction
		{
			get { return _UpdateAction; }
			set 
			{ 
				_UpdateAction = value;
				OnPropertyChanged("UpdateAction");
			}
		}
		public KalturaGenericDistributionProfileAction DeleteAction
		{
			get { return _DeleteAction; }
			set 
			{ 
				_DeleteAction = value;
				OnPropertyChanged("DeleteAction");
			}
		}
		public KalturaGenericDistributionProfileAction FetchReportAction
		{
			get { return _FetchReportAction; }
			set 
			{ 
				_FetchReportAction = value;
				OnPropertyChanged("FetchReportAction");
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
		public KalturaGenericDistributionProfile()
		{
		}

		public KalturaGenericDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "genericProviderId":
						this.GenericProviderId = ParseInt(txt);
						continue;
					case "submitAction":
						this.SubmitAction = (KalturaGenericDistributionProfileAction)KalturaObjectFactory.Create(propertyNode);
						continue;
					case "updateAction":
						this.UpdateAction = (KalturaGenericDistributionProfileAction)KalturaObjectFactory.Create(propertyNode);
						continue;
					case "deleteAction":
						this.DeleteAction = (KalturaGenericDistributionProfileAction)KalturaObjectFactory.Create(propertyNode);
						continue;
					case "fetchReportAction":
						this.FetchReportAction = (KalturaGenericDistributionProfileAction)KalturaObjectFactory.Create(propertyNode);
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
			kparams.AddIntIfNotNull("genericProviderId", this.GenericProviderId);
			if (this.SubmitAction != null)
				kparams.Add("submitAction", this.SubmitAction.ToParams());
			if (this.UpdateAction != null)
				kparams.Add("updateAction", this.UpdateAction.ToParams());
			if (this.DeleteAction != null)
				kparams.Add("deleteAction", this.DeleteAction.ToParams());
			if (this.FetchReportAction != null)
				kparams.Add("fetchReportAction", this.FetchReportAction.ToParams());
			kparams.AddStringIfNotNull("updateRequiredEntryFields", this.UpdateRequiredEntryFields);
			kparams.AddStringIfNotNull("updateRequiredMetadataXPaths", this.UpdateRequiredMetadataXPaths);
			return kparams;
		}
		#endregion
	}
}

