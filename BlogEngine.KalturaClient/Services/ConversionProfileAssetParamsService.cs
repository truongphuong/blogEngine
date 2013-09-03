using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaConversionProfileAssetParamsService : KalturaServiceBase
	{
	public KalturaConversionProfileAssetParamsService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaConversionProfileAssetParamsListResponse List()
		{
			return this.List(null);
		}

		public KalturaConversionProfileAssetParamsListResponse List(KalturaConversionProfileAssetParamsFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaConversionProfileAssetParamsListResponse List(KalturaConversionProfileAssetParamsFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("conversionprofileassetparams", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaConversionProfileAssetParamsListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaConversionProfileAssetParams Update(int conversionProfileId, int assetParamsId, KalturaConversionProfileAssetParams conversionProfileAssetParams)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("conversionProfileId", conversionProfileId);
			kparams.AddIntIfNotNull("assetParamsId", assetParamsId);
			if (conversionProfileAssetParams != null)
				kparams.Add("conversionProfileAssetParams", conversionProfileAssetParams.ToParams());
			_Client.QueueServiceCall("conversionprofileassetparams", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaConversionProfileAssetParams)KalturaObjectFactory.Create(result);
		}
	}
}
