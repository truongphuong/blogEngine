using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaPermissionItemService : KalturaServiceBase
	{
	public KalturaPermissionItemService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaPermissionItem Add(KalturaPermissionItem permissionItem)
		{
			KalturaParams kparams = new KalturaParams();
			if (permissionItem != null)
				kparams.Add("permissionItem", permissionItem.ToParams());
			_Client.QueueServiceCall("permissionitem", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPermissionItem)KalturaObjectFactory.Create(result);
		}

		public KalturaPermissionItem Get(int permissionItemId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("permissionItemId", permissionItemId);
			_Client.QueueServiceCall("permissionitem", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPermissionItem)KalturaObjectFactory.Create(result);
		}

		public KalturaPermissionItem Update(int permissionItemId, KalturaPermissionItem permissionItem)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("permissionItemId", permissionItemId);
			if (permissionItem != null)
				kparams.Add("permissionItem", permissionItem.ToParams());
			_Client.QueueServiceCall("permissionitem", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPermissionItem)KalturaObjectFactory.Create(result);
		}

		public KalturaPermissionItem Delete(int permissionItemId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("permissionItemId", permissionItemId);
			_Client.QueueServiceCall("permissionitem", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPermissionItem)KalturaObjectFactory.Create(result);
		}

		public KalturaPermissionItemListResponse List()
		{
			return this.List(null);
		}

		public KalturaPermissionItemListResponse List(KalturaPermissionItemFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaPermissionItemListResponse List(KalturaPermissionItemFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("permissionitem", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPermissionItemListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
