using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDistributionValidationErrorMissingFlavor : KalturaDistributionValidationError
	{
		#region Private Fields
		private string _FlavorParamsId = null;
		#endregion

		#region Properties
		public string FlavorParamsId
		{
			get { return _FlavorParamsId; }
			set 
			{ 
				_FlavorParamsId = value;
				OnPropertyChanged("FlavorParamsId");
			}
		}
		#endregion

		#region CTor
		public KalturaDistributionValidationErrorMissingFlavor()
		{
		}

		public KalturaDistributionValidationErrorMissingFlavor(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "flavorParamsId":
						this.FlavorParamsId = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("flavorParamsId", this.FlavorParamsId);
			return kparams;
		}
		#endregion
	}
}

