using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDistributionValidationErrorMissingMetadata : KalturaDistributionValidationError
	{
		#region Private Fields
		private string _FieldName = null;
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
		#endregion

		#region CTor
		public KalturaDistributionValidationErrorMissingMetadata()
		{
		}

		public KalturaDistributionValidationErrorMissingMetadata(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "fieldName":
						this.FieldName = txt;
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
			return kparams;
		}
		#endregion
	}
}

