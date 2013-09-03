using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaConversionProfileAssetParamsFilter : KalturaConversionProfileAssetParamsBaseFilter
	{
		#region Private Fields
		private KalturaConversionProfileFilter _ConversionProfileIdFilter;
		private KalturaAssetParamsFilter _AssetParamsIdFilter;
		private KalturaConversionProfileAssetParamsOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public KalturaConversionProfileFilter ConversionProfileIdFilter
		{
			get { return _ConversionProfileIdFilter; }
			set 
			{ 
				_ConversionProfileIdFilter = value;
				OnPropertyChanged("ConversionProfileIdFilter");
			}
		}
		public KalturaAssetParamsFilter AssetParamsIdFilter
		{
			get { return _AssetParamsIdFilter; }
			set 
			{ 
				_AssetParamsIdFilter = value;
				OnPropertyChanged("AssetParamsIdFilter");
			}
		}
		public new KalturaConversionProfileAssetParamsOrderBy OrderBy
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
		public KalturaConversionProfileAssetParamsFilter()
		{
		}

		public KalturaConversionProfileAssetParamsFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "conversionProfileIdFilter":
						this.ConversionProfileIdFilter = (KalturaConversionProfileFilter)KalturaObjectFactory.Create(propertyNode);
						continue;
					case "assetParamsIdFilter":
						this.AssetParamsIdFilter = (KalturaAssetParamsFilter)KalturaObjectFactory.Create(propertyNode);
						continue;
					case "orderBy":
						this.OrderBy = (KalturaConversionProfileAssetParamsOrderBy)KalturaStringEnum.Parse(typeof(KalturaConversionProfileAssetParamsOrderBy), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			if (this.ConversionProfileIdFilter != null)
				kparams.Add("conversionProfileIdFilter", this.ConversionProfileIdFilter.ToParams());
			if (this.AssetParamsIdFilter != null)
				kparams.Add("assetParamsIdFilter", this.AssetParamsIdFilter.ToParams());
			kparams.AddStringEnumIfNotNull("orderBy", this.OrderBy);
			return kparams;
		}
		#endregion
	}
}

