using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaEntryDistributionService : KalturaServiceBase
	{
	public KalturaEntryDistributionService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaEntryDistribution Add(KalturaEntryDistribution entryDistribution)
		{
			KalturaParams kparams = new KalturaParams();
			if (entryDistribution != null)
				kparams.Add("entryDistribution", entryDistribution.ToParams());
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistribution)KalturaObjectFactory.Create(result);
		}

		public KalturaEntryDistribution Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistribution)KalturaObjectFactory.Create(result);
		}

		public KalturaEntryDistribution Validate(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "validate", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistribution)KalturaObjectFactory.Create(result);
		}

		public KalturaEntryDistribution Update(int id, KalturaEntryDistribution entryDistribution)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (entryDistribution != null)
				kparams.Add("entryDistribution", entryDistribution.ToParams());
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistribution)KalturaObjectFactory.Create(result);
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaEntryDistributionListResponse List()
		{
			return this.List(null);
		}

		public KalturaEntryDistributionListResponse List(KalturaEntryDistributionFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaEntryDistributionListResponse List(KalturaEntryDistributionFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistributionListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaEntryDistribution SubmitAdd(int id)
		{
			return this.SubmitAdd(id, false);
		}

		public KalturaEntryDistribution SubmitAdd(int id, bool submitWhenReady)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			kparams.AddBoolIfNotNull("submitWhenReady", submitWhenReady);
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "submitAdd", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistribution)KalturaObjectFactory.Create(result);
		}

		public KalturaEntryDistribution SubmitUpdate(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "submitUpdate", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistribution)KalturaObjectFactory.Create(result);
		}

		public KalturaEntryDistribution SubmitFetchReport(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "submitFetchReport", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistribution)KalturaObjectFactory.Create(result);
		}

		public KalturaEntryDistribution SubmitDelete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "submitDelete", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistribution)KalturaObjectFactory.Create(result);
		}

		public KalturaEntryDistribution RetrySubmit(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_entrydistribution", "retrySubmit", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryDistribution)KalturaObjectFactory.Create(result);
		}
	}
}
