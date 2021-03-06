using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaThumbAssetFilter : KalturaThumbAssetBaseFilter
	{
		#region Private Fields
		private KalturaThumbAssetOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaThumbAssetOrderBy OrderBy
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
		public KalturaThumbAssetFilter()
		{
		}

		public KalturaThumbAssetFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaThumbAssetOrderBy)KalturaStringEnum.Parse(typeof(KalturaThumbAssetOrderBy), txt);
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

