using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaAdminUserService : KalturaServiceBase
	{
	public KalturaAdminUserService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaAdminUser UpdatePassword(string email, string password)
		{
			return this.UpdatePassword(email, password, "");
		}

		public KalturaAdminUser UpdatePassword(string email, string password, string newEmail)
		{
			return this.UpdatePassword(email, password, newEmail, "");
		}

		public KalturaAdminUser UpdatePassword(string email, string password, string newEmail, string newPassword)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("email", email);
			kparams.AddStringIfNotNull("password", password);
			kparams.AddStringIfNotNull("newEmail", newEmail);
			kparams.AddStringIfNotNull("newPassword", newPassword);
			_Client.QueueServiceCall("adminuser", "updatePassword", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAdminUser)KalturaObjectFactory.Create(result);
		}

		public void ResetPassword(string email)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("email", email);
			_Client.QueueServiceCall("adminuser", "resetPassword", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public string Login(string email, string password)
		{
			return this.Login(email, password, Int32.MinValue);
		}

		public string Login(string email, string password, int partnerId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("email", email);
			kparams.AddStringIfNotNull("password", password);
			kparams.AddIntIfNotNull("partnerId", partnerId);
			_Client.QueueServiceCall("adminuser", "login", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public void SetInitialPassword(string hashKey, string newPassword)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("hashKey", hashKey);
			kparams.AddStringIfNotNull("newPassword", newPassword);
			_Client.QueueServiceCall("adminuser", "setInitialPassword", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}
	}
}
