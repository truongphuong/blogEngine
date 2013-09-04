using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDoubleClickDistributionProfile : KalturaConfigurableDistributionProfile
	{
		#region Private Fields
		private string _ChannelTitle = null;
		private string _ChannelLink = null;
		private string _ChannelDescription = null;
		private string _FeedUrl = null;
		private string _CuePointsProvider = null;
		private string _ItemsPerPage = null;
		#endregion

		#region Properties
		public string ChannelTitle
		{
			get { return _ChannelTitle; }
			set 
			{ 
				_ChannelTitle = value;
				OnPropertyChanged("ChannelTitle");
			}
		}
		public string ChannelLink
		{
			get { return _ChannelLink; }
			set 
			{ 
				_ChannelLink = value;
				OnPropertyChanged("ChannelLink");
			}
		}
		public string ChannelDescription
		{
			get { return _ChannelDescription; }
			set 
			{ 
				_ChannelDescription = value;
				OnPropertyChanged("ChannelDescription");
			}
		}
		public string FeedUrl
		{
			get { return _FeedUrl; }
			set 
			{ 
				_FeedUrl = value;
				OnPropertyChanged("FeedUrl");
			}
		}
		public string CuePointsProvider
		{
			get { return _CuePointsProvider; }
			set 
			{ 
				_CuePointsProvider = value;
				OnPropertyChanged("CuePointsProvider");
			}
		}
		public string ItemsPerPage
		{
			get { return _ItemsPerPage; }
			set 
			{ 
				_ItemsPerPage = value;
				OnPropertyChanged("ItemsPerPage");
			}
		}
		#endregion

		#region CTor
		public KalturaDoubleClickDistributionProfile()
		{
		}

		public KalturaDoubleClickDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "channelTitle":
						this.ChannelTitle = txt;
						continue;
					case "channelLink":
						this.ChannelLink = txt;
						continue;
					case "channelDescription":
						this.ChannelDescription = txt;
						continue;
					case "feedUrl":
						this.FeedUrl = txt;
						continue;
					case "cuePointsProvider":
						this.CuePointsProvider = txt;
						continue;
					case "itemsPerPage":
						this.ItemsPerPage = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("channelTitle", this.ChannelTitle);
			kparams.AddStringIfNotNull("channelLink", this.ChannelLink);
			kparams.AddStringIfNotNull("channelDescription", this.ChannelDescription);
			kparams.AddStringIfNotNull("feedUrl", this.FeedUrl);
			kparams.AddStringIfNotNull("cuePointsProvider", this.CuePointsProvider);
			kparams.AddStringIfNotNull("itemsPerPage", this.ItemsPerPage);
			return kparams;
		}
		#endregion
	}
}

