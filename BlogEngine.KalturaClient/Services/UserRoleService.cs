using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaUserRoleService : KalturaServiceBase
	{
	public KalturaUserRoleService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaUserRole Add(KalturaUserRole userRole)
		{
			KalturaParams kparams = new KalturaParams();
			if (userRole != null)
				kparams.Add("userRole", userRole.ToParams());
			_Client.QueueServiceCall("userrole", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserRole)KalturaObjectFactory.Create(result);
		}

		public KalturaUserRole Get(int userRoleId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("userRoleId", userRoleId);
			_Client.QueueServiceCall("userrole", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserRole)KalturaObjectFactory.Create(result);
		}

		public KalturaUserRole Update(int userRoleId, KalturaUserRole userRole)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("userRoleId", userRoleId);
			if (userRole != null)
				kparams.Add("userRole", userRole.ToParams());
			_Client.QueueServiceCall("userrole", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserRole)KalturaObjectFactory.Create(result);
		}

		public KalturaUserRole Delete(int userRoleId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("userRoleId", userRoleId);
			_Client.QueueServiceCall("userrole", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserRole)KalturaObjectFactory.Create(result);
		}

		public KalturaUserRoleListResponse List()
		{
			return this.List(null);
		}

		public KalturaUserRoleListResponse List(KalturaUserRoleFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaUserRoleListResponse List(KalturaUserRoleFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("userrole", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserRoleListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaUserRole Clone(int userRoleId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("userRoleId", userRoleId);
			_Client.QueueServiceCall("userrole", "clone", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserRole)KalturaObjectFactory.Create(result);
		}
	}
}
