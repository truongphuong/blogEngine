using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaVirusScanProfileService : KalturaServiceBase
	{
	public KalturaVirusScanProfileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaVirusScanProfileListResponse List()
		{
			return this.List(null);
		}

		public KalturaVirusScanProfileListResponse List(KalturaVirusScanProfileFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaVirusScanProfileListResponse List(KalturaVirusScanProfileFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("virusscan_virusscanprofile", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaVirusScanProfileListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaVirusScanProfile Add(KalturaVirusScanProfile virusScanProfile)
		{
			KalturaParams kparams = new KalturaParams();
			if (virusScanProfile != null)
				kparams.Add("virusScanProfile", virusScanProfile.ToParams());
			_Client.QueueServiceCall("virusscan_virusscanprofile", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaVirusScanProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaVirusScanProfile Get(int virusScanProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("virusScanProfileId", virusScanProfileId);
			_Client.QueueServiceCall("virusscan_virusscanprofile", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaVirusScanProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaVirusScanProfile Update(int virusScanProfileId, KalturaVirusScanProfile virusScanProfile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("virusScanProfileId", virusScanProfileId);
			if (virusScanProfile != null)
				kparams.Add("virusScanProfile", virusScanProfile.ToParams());
			_Client.QueueServiceCall("virusscan_virusscanprofile", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaVirusScanProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaVirusScanProfile Delete(int virusScanProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("virusScanProfileId", virusScanProfileId);
			_Client.QueueServiceCall("virusscan_virusscanprofile", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaVirusScanProfile)KalturaObjectFactory.Create(result);
		}

		public int Scan(string flavorAssetId)
		{
			return this.Scan(flavorAssetId, Int32.MinValue);
		}

		public int Scan(string flavorAssetId, int virusScanProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("flavorAssetId", flavorAssetId);
			kparams.AddIntIfNotNull("virusScanProfileId", virusScanProfileId);
			_Client.QueueServiceCall("virusscan_virusscanprofile", "scan", kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}
	}
}
