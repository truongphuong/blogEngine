using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaUserService : KalturaServiceBase
	{
	public KalturaUserService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaUser Add(KalturaUser user)
		{
			KalturaParams kparams = new KalturaParams();
			if (user != null)
				kparams.Add("user", user.ToParams());
			_Client.QueueServiceCall("user", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result);
		}

		public KalturaUser Update(string userId, KalturaUser user)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("userId", userId);
			if (user != null)
				kparams.Add("user", user.ToParams());
			_Client.QueueServiceCall("user", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result);
		}

		public KalturaUser Get(string userId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("userId", userId);
			_Client.QueueServiceCall("user", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result);
		}

		public KalturaUser GetByLoginId(string loginId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("loginId", loginId);
			_Client.QueueServiceCall("user", "getByLoginId", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result);
		}

		public KalturaUser Delete(string userId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("userId", userId);
			_Client.QueueServiceCall("user", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result);
		}

		public KalturaUserListResponse List()
		{
			return this.List(null);
		}

		public KalturaUserListResponse List(KalturaUserFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaUserListResponse List(KalturaUserFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("user", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserListResponse)KalturaObjectFactory.Create(result);
		}

		public void NotifyBan(string userId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("userId", userId);
			_Client.QueueServiceCall("user", "notifyBan", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public string Login(int partnerId, string userId, string password)
		{
			return this.Login(partnerId, userId, password, 86400);
		}

		public string Login(int partnerId, string userId, string password, int expiry)
		{
			return this.Login(partnerId, userId, password, expiry, "*");
		}

		public string Login(int partnerId, string userId, string password, int expiry, string privileges)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("partnerId", partnerId);
			kparams.AddStringIfNotNull("userId", userId);
			kparams.AddStringIfNotNull("password", password);
			kparams.AddIntIfNotNull("expiry", expiry);
			kparams.AddStringIfNotNull("privileges", privileges);
			_Client.QueueServiceCall("user", "login", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public string LoginByLoginId(string loginId, string password)
		{
			return this.LoginByLoginId(loginId, password, Int32.MinValue);
		}

		public string LoginByLoginId(string loginId, string password, int partnerId)
		{
			return this.LoginByLoginId(loginId, password, partnerId, 86400);
		}

		public string LoginByLoginId(string loginId, string password, int partnerId, int expiry)
		{
			return this.LoginByLoginId(loginId, password, partnerId, expiry, "*");
		}

		public string LoginByLoginId(string loginId, string password, int partnerId, int expiry, string privileges)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("loginId", loginId);
			kparams.AddStringIfNotNull("password", password);
			kparams.AddIntIfNotNull("partnerId", partnerId);
			kparams.AddIntIfNotNull("expiry", expiry);
			kparams.AddStringIfNotNull("privileges", privileges);
			_Client.QueueServiceCall("user", "loginByLoginId", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public void UpdateLoginData(string oldLoginId, string password)
		{
			this.UpdateLoginData(oldLoginId, password, "");
		}

		public void UpdateLoginData(string oldLoginId, string password, string newLoginId)
		{
			this.UpdateLoginData(oldLoginId, password, newLoginId, "");
		}

		public void UpdateLoginData(string oldLoginId, string password, string newLoginId, string newPassword)
		{
			this.UpdateLoginData(oldLoginId, password, newLoginId, newPassword, null);
		}

		public void UpdateLoginData(string oldLoginId, string password, string newLoginId, string newPassword, string newFirstName)
		{
			this.UpdateLoginData(oldLoginId, password, newLoginId, newPassword, newFirstName, null);
		}

		public void UpdateLoginData(string oldLoginId, string password, string newLoginId, string newPassword, string newFirstName, string newLastName)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("oldLoginId", oldLoginId);
			kparams.AddStringIfNotNull("password", password);
			kparams.AddStringIfNotNull("newLoginId", newLoginId);
			kparams.AddStringIfNotNull("newPassword", newPassword);
			kparams.AddStringIfNotNull("newFirstName", newFirstName);
			kparams.AddStringIfNotNull("newLastName", newLastName);
			_Client.QueueServiceCall("user", "updateLoginData", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void ResetPassword(string email)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("email", email);
			_Client.QueueServiceCall("user", "resetPassword", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void SetInitialPassword(string hashKey, string newPassword)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("hashKey", hashKey);
			kparams.AddStringIfNotNull("newPassword", newPassword);
			_Client.QueueServiceCall("user", "setInitialPassword", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaUser EnableLogin(string userId, string loginId)
		{
			return this.EnableLogin(userId, loginId, null);
		}

		public KalturaUser EnableLogin(string userId, string loginId, string password)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("userId", userId);
			kparams.AddStringIfNotNull("loginId", loginId);
			kparams.AddStringIfNotNull("password", password);
			_Client.QueueServiceCall("user", "enableLogin", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result);
		}

		public KalturaUser DisableLogin()
		{
			return this.DisableLogin(null);
		}

		public KalturaUser DisableLogin(string userId)
		{
			return this.DisableLogin(userId, null);
		}

		public KalturaUser DisableLogin(string userId, string loginId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("userId", userId);
			kparams.AddStringIfNotNull("loginId", loginId);
			_Client.QueueServiceCall("user", "disableLogin", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result);
		}
	}
}
