using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaEntryContextDataResult : KalturaObjectBase
	{
		#region Private Fields
		private bool? _IsSiteRestricted = false;
		private bool? _IsCountryRestricted = false;
		private bool? _IsSessionRestricted = false;
		private bool? _IsIpAddressRestricted = false;
		private bool? _IsUserAgentRestricted = false;
		private int _PreviewLength = Int32.MinValue;
		private bool? _IsScheduledNow = false;
		private bool? _IsAdmin = false;
		private string _StreamerType = null;
		private string _MediaProtocol = null;
		private string _StorageProfileIds = null;
		#endregion

		#region Properties
		public bool? IsSiteRestricted
		{
			get { return _IsSiteRestricted; }
			set 
			{ 
				_IsSiteRestricted = value;
				OnPropertyChanged("IsSiteRestricted");
			}
		}
		public bool? IsCountryRestricted
		{
			get { return _IsCountryRestricted; }
			set 
			{ 
				_IsCountryRestricted = value;
				OnPropertyChanged("IsCountryRestricted");
			}
		}
		public bool? IsSessionRestricted
		{
			get { return _IsSessionRestricted; }
			set 
			{ 
				_IsSessionRestricted = value;
				OnPropertyChanged("IsSessionRestricted");
			}
		}
		public bool? IsIpAddressRestricted
		{
			get { return _IsIpAddressRestricted; }
			set 
			{ 
				_IsIpAddressRestricted = value;
				OnPropertyChanged("IsIpAddressRestricted");
			}
		}
		public bool? IsUserAgentRestricted
		{
			get { return _IsUserAgentRestricted; }
			set 
			{ 
				_IsUserAgentRestricted = value;
				OnPropertyChanged("IsUserAgentRestricted");
			}
		}
		public int PreviewLength
		{
			get { return _PreviewLength; }
			set 
			{ 
				_PreviewLength = value;
				OnPropertyChanged("PreviewLength");
			}
		}
		public bool? IsScheduledNow
		{
			get { return _IsScheduledNow; }
			set 
			{ 
				_IsScheduledNow = value;
				OnPropertyChanged("IsScheduledNow");
			}
		}
		public bool? IsAdmin
		{
			get { return _IsAdmin; }
			set 
			{ 
				_IsAdmin = value;
				OnPropertyChanged("IsAdmin");
			}
		}
		public string StreamerType
		{
			get { return _StreamerType; }
			set 
			{ 
				_StreamerType = value;
				OnPropertyChanged("StreamerType");
			}
		}
		public string MediaProtocol
		{
			get { return _MediaProtocol; }
			set 
			{ 
				_MediaProtocol = value;
				OnPropertyChanged("MediaProtocol");
			}
		}
		public string StorageProfileIds
		{
			get { return _StorageProfileIds; }
			set 
			{ 
				_StorageProfileIds = value;
				OnPropertyChanged("StorageProfileIds");
			}
		}
		#endregion

		#region CTor
		public KalturaEntryContextDataResult()
		{
		}

		public KalturaEntryContextDataResult(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "isSiteRestricted":
						this.IsSiteRestricted = ParseBool(txt);
						continue;
					case "isCountryRestricted":
						this.IsCountryRestricted = ParseBool(txt);
						continue;
					case "isSessionRestricted":
						this.IsSessionRestricted = ParseBool(txt);
						continue;
					case "isIpAddressRestricted":
						this.IsIpAddressRestricted = ParseBool(txt);
						continue;
					case "isUserAgentRestricted":
						this.IsUserAgentRestricted = ParseBool(txt);
						continue;
					case "previewLength":
						this.PreviewLength = ParseInt(txt);
						continue;
					case "isScheduledNow":
						this.IsScheduledNow = ParseBool(txt);
						continue;
					case "isAdmin":
						this.IsAdmin = ParseBool(txt);
						continue;
					case "streamerType":
						this.StreamerType = txt;
						continue;
					case "mediaProtocol":
						this.MediaProtocol = txt;
						continue;
					case "storageProfileIds":
						this.StorageProfileIds = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddBoolIfNotNull("isSiteRestricted", this.IsSiteRestricted);
			kparams.AddBoolIfNotNull("isCountryRestricted", this.IsCountryRestricted);
			kparams.AddBoolIfNotNull("isSessionRestricted", this.IsSessionRestricted);
			kparams.AddBoolIfNotNull("isIpAddressRestricted", this.IsIpAddressRestricted);
			kparams.AddBoolIfNotNull("isUserAgentRestricted", this.IsUserAgentRestricted);
			kparams.AddIntIfNotNull("previewLength", this.PreviewLength);
			kparams.AddBoolIfNotNull("isScheduledNow", this.IsScheduledNow);
			kparams.AddBoolIfNotNull("isAdmin", this.IsAdmin);
			kparams.AddStringIfNotNull("streamerType", this.StreamerType);
			kparams.AddStringIfNotNull("mediaProtocol", this.MediaProtocol);
			kparams.AddStringIfNotNull("storageProfileIds", this.StorageProfileIds);
			return kparams;
		}
		#endregion
	}
}

