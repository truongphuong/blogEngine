using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDistributionValidationErrorMissingThumbnail : KalturaDistributionValidationError
	{
		#region Private Fields
		private KalturaDistributionThumbDimensions _Dimensions;
		#endregion

		#region Properties
		public KalturaDistributionThumbDimensions Dimensions
		{
			get { return _Dimensions; }
			set 
			{ 
				_Dimensions = value;
				OnPropertyChanged("Dimensions");
			}
		}
		#endregion

		#region CTor
		public KalturaDistributionValidationErrorMissingThumbnail()
		{
		}

		public KalturaDistributionValidationErrorMissingThumbnail(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "dimensions":
						this.Dimensions = (KalturaDistributionThumbDimensions)KalturaObjectFactory.Create(propertyNode);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			if (this.Dimensions != null)
				kparams.Add("dimensions", this.Dimensions.ToParams());
			return kparams;
		}
		#endregion
	}
}

