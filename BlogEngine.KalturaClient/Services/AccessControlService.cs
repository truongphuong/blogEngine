using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaAccessControlService : KalturaServiceBase
	{
	public KalturaAccessControlService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaAccessControl Add(KalturaAccessControl accessControl)
		{
			KalturaParams kparams = new KalturaParams();
			if (accessControl != null)
				kparams.Add("accessControl", accessControl.ToParams());
			_Client.QueueServiceCall("accesscontrol", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAccessControl)KalturaObjectFactory.Create(result);
		}

		public KalturaAccessControl Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("accesscontrol", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAccessControl)KalturaObjectFactory.Create(result);
		}

		public KalturaAccessControl Update(int id, KalturaAccessControl accessControl)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (accessControl != null)
				kparams.Add("accessControl", accessControl.ToParams());
			_Client.QueueServiceCall("accesscontrol", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAccessControl)KalturaObjectFactory.Create(result);
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("accesscontrol", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaAccessControlListResponse List()
		{
			return this.List(null);
		}

		public KalturaAccessControlListResponse List(KalturaAccessControlFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaAccessControlListResponse List(KalturaAccessControlFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("accesscontrol", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAccessControlListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
