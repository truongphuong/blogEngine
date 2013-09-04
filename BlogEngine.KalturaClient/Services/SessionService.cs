using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaSessionService : KalturaServiceBase
	{
	public KalturaSessionService(KalturaClient client)
			: base(client)
		{
		}

		public string Start(string secret)
		{
			return this.Start(secret, "");
		}

		public string Start(string secret, string userId)
		{
			return this.Start(secret, userId, (KalturaSessionType)(0));
		}

		public string Start(string secret, string userId, KalturaSessionType type)
		{
			return this.Start(secret, userId, type, Int32.MinValue);
		}

		public string Start(string secret, string userId, KalturaSessionType type, int partnerId)
		{
			return this.Start(secret, userId, type, partnerId, 86400);
		}

		public string Start(string secret, string userId, KalturaSessionType type, int partnerId, int expiry)
		{
			return this.Start(secret, userId, type, partnerId, expiry, null);
		}

		public string Start(string secret, string userId, KalturaSessionType type, int partnerId, int expiry, string privileges)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("secret", secret);
			kparams.AddStringIfNotNull("userId", userId);
			kparams.AddEnumIfNotNull("type", type);
			kparams.AddIntIfNotNull("partnerId", partnerId);
			kparams.AddIntIfNotNull("expiry", expiry);
			kparams.AddStringIfNotNull("privileges", privileges);
			_Client.QueueServiceCall("session", "start", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public void End()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("session", "end", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public string Impersonate(string secret, int impersonatedPartnerId)
		{
			return this.Impersonate(secret, impersonatedPartnerId, "");
		}

		public string Impersonate(string secret, int impersonatedPartnerId, string userId)
		{
			return this.Impersonate(secret, impersonatedPartnerId, userId, (KalturaSessionType)(0));
		}

		public string Impersonate(string secret, int impersonatedPartnerId, string userId, KalturaSessionType type)
		{
			return this.Impersonate(secret, impersonatedPartnerId, userId, type, Int32.MinValue);
		}

		public string Impersonate(string secret, int impersonatedPartnerId, string userId, KalturaSessionType type, int partnerId)
		{
			return this.Impersonate(secret, impersonatedPartnerId, userId, type, partnerId, 86400);
		}

		public string Impersonate(string secret, int impersonatedPartnerId, string userId, KalturaSessionType type, int partnerId, int expiry)
		{
			return this.Impersonate(secret, impersonatedPartnerId, userId, type, partnerId, expiry, null);
		}

		public string Impersonate(string secret, int impersonatedPartnerId, string userId, KalturaSessionType type, int partnerId, int expiry, string privileges)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("secret", secret);
			kparams.AddIntIfNotNull("impersonatedPartnerId", impersonatedPartnerId);
			kparams.AddStringIfNotNull("userId", userId);
			kparams.AddEnumIfNotNull("type", type);
			kparams.AddIntIfNotNull("partnerId", partnerId);
			kparams.AddIntIfNotNull("expiry", expiry);
			kparams.AddStringIfNotNull("privileges", privileges);
			_Client.QueueServiceCall("session", "impersonate", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaStartWidgetSessionResponse StartWidgetSession(string widgetId)
		{
			return this.StartWidgetSession(widgetId, 86400);
		}

		public KalturaStartWidgetSessionResponse StartWidgetSession(string widgetId, int expiry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("widgetId", widgetId);
			kparams.AddIntIfNotNull("expiry", expiry);
			_Client.QueueServiceCall("session", "startWidgetSession", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaStartWidgetSessionResponse)KalturaObjectFactory.Create(result);
		}
	}
}
