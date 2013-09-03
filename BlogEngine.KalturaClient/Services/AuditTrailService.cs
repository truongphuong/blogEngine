using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaAuditTrailService : KalturaServiceBase
	{
	public KalturaAuditTrailService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaAuditTrail Add(KalturaAuditTrail auditTrail)
		{
			KalturaParams kparams = new KalturaParams();
			if (auditTrail != null)
				kparams.Add("auditTrail", auditTrail.ToParams());
			_Client.QueueServiceCall("audit_audittrail", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAuditTrail)KalturaObjectFactory.Create(result);
		}

		public KalturaAuditTrail Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("audit_audittrail", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAuditTrail)KalturaObjectFactory.Create(result);
		}

		public KalturaAuditTrailListResponse List()
		{
			return this.List(null);
		}

		public KalturaAuditTrailListResponse List(KalturaAuditTrailFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaAuditTrailListResponse List(KalturaAuditTrailFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("audit_audittrail", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAuditTrailListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
