using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaUiConfService : KalturaServiceBase
	{
	public KalturaUiConfService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaUiConf Add(KalturaUiConf uiConf)
		{
			KalturaParams kparams = new KalturaParams();
			if (uiConf != null)
				kparams.Add("uiConf", uiConf.ToParams());
			_Client.QueueServiceCall("uiconf", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUiConf)KalturaObjectFactory.Create(result);
		}

		public KalturaUiConf Update(int id, KalturaUiConf uiConf)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (uiConf != null)
				kparams.Add("uiConf", uiConf.ToParams());
			_Client.QueueServiceCall("uiconf", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUiConf)KalturaObjectFactory.Create(result);
		}

		public KalturaUiConf Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("uiconf", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUiConf)KalturaObjectFactory.Create(result);
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("uiconf", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaUiConf Clone(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("uiconf", "clone", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUiConf)KalturaObjectFactory.Create(result);
		}

		public KalturaUiConfListResponse ListTemplates()
		{
			return this.ListTemplates(null);
		}

		public KalturaUiConfListResponse ListTemplates(KalturaUiConfFilter filter)
		{
			return this.ListTemplates(filter, null);
		}

		public KalturaUiConfListResponse ListTemplates(KalturaUiConfFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("uiconf", "listTemplates", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUiConfListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaUiConfListResponse List()
		{
			return this.List(null);
		}

		public KalturaUiConfListResponse List(KalturaUiConfFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaUiConfListResponse List(KalturaUiConfFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("uiconf", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUiConfListResponse)KalturaObjectFactory.Create(result);
		}

		public IList<KalturaUiConfTypeInfo> GetAvailableTypes()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("uiconf", "getAvailableTypes", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaUiConfTypeInfo> list = new List<KalturaUiConfTypeInfo>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaUiConfTypeInfo)KalturaObjectFactory.Create(node));
			}
			return list;
		}
	}
}
