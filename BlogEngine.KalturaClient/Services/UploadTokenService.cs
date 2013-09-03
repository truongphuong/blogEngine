using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaUploadTokenService : KalturaServiceBase
	{
	public KalturaUploadTokenService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaUploadToken Add()
		{
			return this.Add(null);
		}

		public KalturaUploadToken Add(KalturaUploadToken uploadToken)
		{
			KalturaParams kparams = new KalturaParams();
			if (uploadToken != null)
				kparams.Add("uploadToken", uploadToken.ToParams());
			_Client.QueueServiceCall("uploadtoken", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUploadToken)KalturaObjectFactory.Create(result);
		}

		public KalturaUploadToken Get(string uploadTokenId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("uploadTokenId", uploadTokenId);
			_Client.QueueServiceCall("uploadtoken", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUploadToken)KalturaObjectFactory.Create(result);
		}

		public KalturaUploadToken Upload(string uploadTokenId, FileStream fileData)
		{
			return this.Upload(uploadTokenId, fileData, false);
		}

		public KalturaUploadToken Upload(string uploadTokenId, FileStream fileData, bool resume)
		{
			return this.Upload(uploadTokenId, fileData, resume, true);
		}

		public KalturaUploadToken Upload(string uploadTokenId, FileStream fileData, bool resume, bool finalChunk)
		{
			return this.Upload(uploadTokenId, fileData, resume, finalChunk, -1);
		}

		public KalturaUploadToken Upload(string uploadTokenId, FileStream fileData, bool resume, bool finalChunk, int resumeAt)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("uploadTokenId", uploadTokenId);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			kparams.AddBoolIfNotNull("resume", resume);
			kparams.AddBoolIfNotNull("finalChunk", finalChunk);
			kparams.AddIntIfNotNull("resumeAt", resumeAt);
			_Client.QueueServiceCall("uploadtoken", "upload", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUploadToken)KalturaObjectFactory.Create(result);
		}

		public void Delete(string uploadTokenId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("uploadTokenId", uploadTokenId);
			_Client.QueueServiceCall("uploadtoken", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaUploadTokenListResponse List()
		{
			return this.List(null);
		}

		public KalturaUploadTokenListResponse List(KalturaUploadTokenFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaUploadTokenListResponse List(KalturaUploadTokenFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("uploadtoken", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUploadTokenListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
