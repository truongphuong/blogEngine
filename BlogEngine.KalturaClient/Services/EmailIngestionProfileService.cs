using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaEmailIngestionProfileService : KalturaServiceBase
	{
	public KalturaEmailIngestionProfileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaEmailIngestionProfile Add(KalturaEmailIngestionProfile EmailIP)
		{
			KalturaParams kparams = new KalturaParams();
			if (EmailIP != null)
				kparams.Add("EmailIP", EmailIP.ToParams());
			_Client.QueueServiceCall("emailingestionprofile", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEmailIngestionProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaEmailIngestionProfile GetByEmailAddress(string emailAddress)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("emailAddress", emailAddress);
			_Client.QueueServiceCall("emailingestionprofile", "getByEmailAddress", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEmailIngestionProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaEmailIngestionProfile Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("emailingestionprofile", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEmailIngestionProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaEmailIngestionProfile Update(int id, KalturaEmailIngestionProfile EmailIP)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (EmailIP != null)
				kparams.Add("EmailIP", EmailIP.ToParams());
			_Client.QueueServiceCall("emailingestionprofile", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEmailIngestionProfile)KalturaObjectFactory.Create(result);
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("emailingestionprofile", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaMediaEntry AddMediaEntry(KalturaMediaEntry mediaEntry, string uploadTokenId, int emailProfId, string fromAddress, string emailMsgId)
		{
			KalturaParams kparams = new KalturaParams();
			if (mediaEntry != null)
				kparams.Add("mediaEntry", mediaEntry.ToParams());
			kparams.AddStringIfNotNull("uploadTokenId", uploadTokenId);
			kparams.AddIntIfNotNull("emailProfId", emailProfId);
			kparams.AddStringIfNotNull("fromAddress", fromAddress);
			kparams.AddStringIfNotNull("emailMsgId", emailMsgId);
			_Client.QueueServiceCall("emailingestionprofile", "addMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result);
		}
	}
}
