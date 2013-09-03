using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDistributionValidationError : KalturaObjectBase
	{
		#region Private Fields
		private KalturaDistributionAction _Action = (KalturaDistributionAction)Int32.MinValue;
		private KalturaDistributionErrorType _ErrorType = (KalturaDistributionErrorType)Int32.MinValue;
		private string _Description = null;
		#endregion

		#region Properties
		public KalturaDistributionAction Action
		{
			get { return _Action; }
			set 
			{ 
				_Action = value;
				OnPropertyChanged("Action");
			}
		}
		public KalturaDistributionErrorType ErrorType
		{
			get { return _ErrorType; }
			set 
			{ 
				_ErrorType = value;
				OnPropertyChanged("ErrorType");
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
		public KalturaDistributionValidationError()
		{
		}

		public KalturaDistributionValidationError(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "action":
						this.Action = (KalturaDistributionAction)ParseEnum(typeof(KalturaDistributionAction), txt);
						continue;
					case "errorType":
						this.ErrorType = (KalturaDistributionErrorType)ParseEnum(typeof(KalturaDistributionErrorType), txt);
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
			kparams.AddEnumIfNotNull("action", this.Action);
			kparams.AddEnumIfNotNull("errorType", this.ErrorType);
			kparams.AddStringIfNotNull("description", this.Description);
			return kparams;
		}
		#endregion
	}
}

