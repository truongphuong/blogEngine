using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaDistributionProfileService : KalturaServiceBase
	{
	public KalturaDistributionProfileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaDistributionProfile Add(KalturaDistributionProfile distributionProfile)
		{
			KalturaParams kparams = new KalturaParams();
			if (distributionProfile != null)
				kparams.Add("distributionProfile", distributionProfile.ToParams());
			_Client.QueueServiceCall("contentdistribution_distributionprofile", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDistributionProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaDistributionProfile Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_distributionprofile", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDistributionProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaDistributionProfile Update(int id, KalturaDistributionProfile distributionProfile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (distributionProfile != null)
				kparams.Add("distributionProfile", distributionProfile.ToParams());
			_Client.QueueServiceCall("contentdistribution_distributionprofile", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDistributionProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaDistributionProfile UpdateStatus(int id, KalturaDistributionProfileStatus status)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			kparams.AddEnumIfNotNull("status", status);
			_Client.QueueServiceCall("contentdistribution_distributionprofile", "updateStatus", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDistributionProfile)KalturaObjectFactory.Create(result);
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_distributionprofile", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaDistributionProfileListResponse List()
		{
			return this.List(null);
		}

		public KalturaDistributionProfileListResponse List(KalturaDistributionProfileFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaDistributionProfileListResponse List(KalturaDistributionProfileFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("contentdistribution_distributionprofile", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDistributionProfileListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaDistributionProfileListResponse ListByPartner()
		{
			return this.ListByPartner(null);
		}

		public KalturaDistributionProfileListResponse ListByPartner(KalturaPartnerFilter filter)
		{
			return this.ListByPartner(filter, null);
		}

		public KalturaDistributionProfileListResponse ListByPartner(KalturaPartnerFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("contentdistribution_distributionprofile", "listByPartner", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDistributionProfileListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
