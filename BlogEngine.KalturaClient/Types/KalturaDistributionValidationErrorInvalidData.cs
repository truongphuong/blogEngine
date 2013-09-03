using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDistributionValidationErrorInvalidData : KalturaDistributionValidationError
	{
		#region Private Fields
		private string _FieldName = null;
		private KalturaDistributionValidationErrorType _ValidationErrorType = (KalturaDistributionValidationErrorType)Int32.MinValue;
		private string _ValidationErrorParam = null;
		#endregion

		#region Properties
		public string FieldName
		{
			get { return _FieldName; }
			set 
			{ 
				_FieldName = value;
				OnPropertyChanged("FieldName");
			}
		}
		public KalturaDistributionValidationErrorType ValidationErrorType
		{
			get { return _ValidationErrorType; }
			set 
			{ 
				_ValidationErrorType = value;
				OnPropertyChanged("ValidationErrorType");
			}
		}
		public string ValidationErrorParam
		{
			get { return _ValidationErrorParam; }
			set 
			{ 
				_ValidationErrorParam = value;
				OnPropertyChanged("ValidationErrorParam");
			}
		}
		#endregion

		#region CTor
		public KalturaDistributionValidationErrorInvalidData()
		{
		}

		public KalturaDistributionValidationErrorInvalidData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "fieldName":
						this.FieldName = txt;
						continue;
					case "validationErrorType":
						this.ValidationErrorType = (KalturaDistributionValidationErrorType)ParseEnum(typeof(KalturaDistributionValidationErrorType), txt);
						continue;
					case "validationErrorParam":
						this.ValidationErrorParam = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("fieldName", this.FieldName);
			kparams.AddEnumIfNotNull("validationErrorType", this.ValidationErrorType);
			kparams.AddStringIfNotNull("validationErrorParam", this.ValidationErrorParam);
			return kparams;
		}
		#endregion
	}
}

