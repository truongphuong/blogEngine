using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAttachmentAssetFilter : KalturaAttachmentAssetBaseFilter
	{
		#region Private Fields
		private KalturaAttachmentAssetOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaAttachmentAssetOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public KalturaAttachmentAssetFilter()
		{
		}

		public KalturaAttachmentAssetFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaAttachmentAssetOrderBy)KalturaStringEnum.Parse(typeof(KalturaAttachmentAssetOrderBy), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringEnumIfNotNull("orderBy", this.OrderBy);
			return kparams;
		}
		#endregion
	}
}

