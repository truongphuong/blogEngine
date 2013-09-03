using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaDropFolderFileService : KalturaServiceBase
	{
	public KalturaDropFolderFileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaDropFolderFile Add(KalturaDropFolderFile dropFolderFile)
		{
			KalturaParams kparams = new KalturaParams();
			if (dropFolderFile != null)
				kparams.Add("dropFolderFile", dropFolderFile.ToParams());
			_Client.QueueServiceCall("dropfolder_dropfolderfile", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolderFile)KalturaObjectFactory.Create(result);
		}

		public KalturaDropFolderFile Get(int dropFolderFileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("dropFolderFileId", dropFolderFileId);
			_Client.QueueServiceCall("dropfolder_dropfolderfile", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolderFile)KalturaObjectFactory.Create(result);
		}

		public KalturaDropFolderFile Update(int dropFolderFileId, KalturaDropFolderFile dropFolderFile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("dropFolderFileId", dropFolderFileId);
			if (dropFolderFile != null)
				kparams.Add("dropFolderFile", dropFolderFile.ToParams());
			_Client.QueueServiceCall("dropfolder_dropfolderfile", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolderFile)KalturaObjectFactory.Create(result);
		}

		public KalturaDropFolderFile Delete(int dropFolderFileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("dropFolderFileId", dropFolderFileId);
			_Client.QueueServiceCall("dropfolder_dropfolderfile", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolderFile)KalturaObjectFactory.Create(result);
		}

		public KalturaDropFolderFileListResponse List()
		{
			return this.List(null);
		}

		public KalturaDropFolderFileListResponse List(KalturaDropFolderFileFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaDropFolderFileListResponse List(KalturaDropFolderFileFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("dropfolder_dropfolderfile", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolderFileListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaDropFolderFile Ignore(int dropFolderFileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("dropFolderFileId", dropFolderFileId);
			_Client.QueueServiceCall("dropfolder_dropfolderfile", "ignore", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolderFile)KalturaObjectFactory.Create(result);
		}
	}
}
