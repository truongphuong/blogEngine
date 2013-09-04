using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaStorageProfileService : KalturaServiceBase
	{
	public KalturaStorageProfileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaStorageProfile Add(KalturaStorageProfile storageProfile)
		{
			KalturaParams kparams = new KalturaParams();
			if (storageProfile != null)
				kparams.Add("storageProfile", storageProfile.ToParams());
			_Client.QueueServiceCall("storageprofile", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaStorageProfile)KalturaObjectFactory.Create(result);
		}

		public void UpdateStatus(int storageId, KalturaStorageProfileStatus status)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("storageId", storageId);
			kparams.AddEnumIfNotNull("status", status);
			_Client.QueueServiceCall("storageprofile", "updateStatus", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaStorageProfile Get(int storageProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("storageProfileId", storageProfileId);
			_Client.QueueServiceCall("storageprofile", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaStorageProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaStorageProfile Update(int storageProfileId, KalturaStorageProfile storageProfile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("storageProfileId", storageProfileId);
			if (storageProfile != null)
				kparams.Add("storageProfile", storageProfile.ToParams());
			_Client.QueueServiceCall("storageprofile", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaStorageProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaStorageProfileListResponse List()
		{
			return this.List(null);
		}

		public KalturaStorageProfileListResponse List(KalturaStorageProfileFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaStorageProfileListResponse List(KalturaStorageProfileFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("storageprofile", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaStorageProfileListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
