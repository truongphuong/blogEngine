using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDistributionValidationErrorInvalidMetadata : KalturaDistributionValidationErrorInvalidData
	{
		#region Private Fields
		private int _MetadataProfileId = Int32.MinValue;
		#endregion

		#region Properties
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
		#endregion

		#region CTor
		public KalturaDistributionValidationErrorInvalidMetadata()
		{
		}

		public KalturaDistributionValidationErrorInvalidMetadata(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "metadataProfileId":
						this.MetadataProfileId = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("metadataProfileId", this.MetadataProfileId);
			return kparams;
		}
		#endregion
	}
}

