using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaDropFolderService : KalturaServiceBase
	{
	public KalturaDropFolderService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaDropFolder Add(KalturaDropFolder dropFolder)
		{
			KalturaParams kparams = new KalturaParams();
			if (dropFolder != null)
				kparams.Add("dropFolder", dropFolder.ToParams());
			_Client.QueueServiceCall("dropfolder_dropfolder", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolder)KalturaObjectFactory.Create(result);
		}

		public KalturaDropFolder Get(int dropFolderId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("dropFolderId", dropFolderId);
			_Client.QueueServiceCall("dropfolder_dropfolder", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolder)KalturaObjectFactory.Create(result);
		}

		public KalturaDropFolder Update(int dropFolderId, KalturaDropFolder dropFolder)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("dropFolderId", dropFolderId);
			if (dropFolder != null)
				kparams.Add("dropFolder", dropFolder.ToParams());
			_Client.QueueServiceCall("dropfolder_dropfolder", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolder)KalturaObjectFactory.Create(result);
		}

		public KalturaDropFolder Delete(int dropFolderId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("dropFolderId", dropFolderId);
			_Client.QueueServiceCall("dropfolder_dropfolder", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolder)KalturaObjectFactory.Create(result);
		}

		public KalturaDropFolderListResponse List()
		{
			return this.List(null);
		}

		public KalturaDropFolderListResponse List(KalturaDropFolderFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaDropFolderListResponse List(KalturaDropFolderFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("dropfolder_dropfolder", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolderListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
