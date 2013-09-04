using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaLiveStreamEntry : KalturaMediaEntry
	{
		#region Private Fields
		private string _OfflineMessage = null;
		private string _StreamRemoteId = null;
		private string _StreamRemoteBackupId = null;
		private IList<KalturaLiveStreamBitrate> _Bitrates;
		private string _PrimaryBroadcastingUrl = null;
		private string _SecondaryBroadcastingUrl = null;
		private string _StreamName = null;
		#endregion

		#region Properties
		public string OfflineMessage
		{
			get { return _OfflineMessage; }
			set 
			{ 
				_OfflineMessage = value;
				OnPropertyChanged("OfflineMessage");
			}
		}
		public string StreamRemoteId
		{
			get { return _StreamRemoteId; }
			set 
			{ 
				_StreamRemoteId = value;
				OnPropertyChanged("StreamRemoteId");
			}
		}
		public string StreamRemoteBackupId
		{
			get { return _StreamRemoteBackupId; }
			set 
			{ 
				_StreamRemoteBackupId = value;
				OnPropertyChanged("StreamRemoteBackupId");
			}
		}
		public IList<KalturaLiveStreamBitrate> Bitrates
		{
			get { return _Bitrates; }
			set 
			{ 
				_Bitrates = value;
				OnPropertyChanged("Bitrates");
			}
		}
		public string PrimaryBroadcastingUrl
		{
			get { return _PrimaryBroadcastingUrl; }
			set 
			{ 
				_PrimaryBroadcastingUrl = value;
				OnPropertyChanged("PrimaryBroadcastingUrl");
			}
		}
		public string SecondaryBroadcastingUrl
		{
			get { return _SecondaryBroadcastingUrl; }
			set 
			{ 
				_SecondaryBroadcastingUrl = value;
				OnPropertyChanged("SecondaryBroadcastingUrl");
			}
		}
		public string StreamName
		{
			get { return _StreamName; }
			set 
			{ 
				_StreamName = value;
				OnPropertyChanged("StreamName");
			}
		}
		#endregion

		#region CTor
		public KalturaLiveStreamEntry()
		{
		}

		public KalturaLiveStreamEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "offlineMessage":
						this.OfflineMessage = txt;
						continue;
					case "streamRemoteId":
						this.StreamRemoteId = txt;
						continue;
					case "streamRemoteBackupId":
						this.StreamRemoteBackupId = txt;
						continue;
					case "bitrates":
						this.Bitrates = new List<KalturaLiveStreamBitrate>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Bitrates.Add((KalturaLiveStreamBitrate)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "primaryBroadcastingUrl":
						this.PrimaryBroadcastingUrl = txt;
						continue;
					case "secondaryBroadcastingUrl":
						this.SecondaryBroadcastingUrl = txt;
						continue;
					case "streamName":
						this.StreamName = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("offlineMessage", this.OfflineMessage);
			kparams.AddStringIfNotNull("streamRemoteId", this.StreamRemoteId);
			kparams.AddStringIfNotNull("streamRemoteBackupId", this.StreamRemoteBackupId);
			if (this.Bitrates != null)
			{
				if (this.Bitrates.Count == 0)
				{
					kparams.Add("bitrates:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaLiveStreamBitrate item in this.Bitrates)
					{
						kparams.Add("bitrates:" + i + ":objectType", item.GetType().Name);
						kparams.Add("bitrates:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddStringIfNotNull("primaryBroadcastingUrl", this.PrimaryBroadcastingUrl);
			kparams.AddStringIfNotNull("secondaryBroadcastingUrl", this.SecondaryBroadcastingUrl);
			kparams.AddStringIfNotNull("streamName", this.StreamName);
			return kparams;
		}
		#endregion
	}
}

