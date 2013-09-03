using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaBaseSyndicationFeed : KalturaObjectBase
	{
		#region Private Fields
		private string _Id = null;
		private string _FeedUrl = null;
		private int _PartnerId = Int32.MinValue;
		private string _PlaylistId = null;
		private string _Name = null;
		private KalturaSyndicationFeedStatus _Status = (KalturaSyndicationFeedStatus)Int32.MinValue;
		private KalturaSyndicationFeedType _Type = (KalturaSyndicationFeedType)Int32.MinValue;
		private string _LandingPage = null;
		private int _CreatedAt = Int32.MinValue;
		private bool? _AllowEmbed = false;
		private int _PlayerUiconfId = Int32.MinValue;
		private int _FlavorParamId = Int32.MinValue;
		private bool? _TranscodeExistingContent = false;
		private bool? _AddToDefaultConversionProfile = false;
		private string _Categories = null;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
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
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public string PlaylistId
		{
			get { return _PlaylistId; }
			set 
			{ 
				_PlaylistId = value;
				OnPropertyChanged("PlaylistId");
			}
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public KalturaSyndicationFeedStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public KalturaSyndicationFeedType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string LandingPage
		{
			get { return _LandingPage; }
			set 
			{ 
				_LandingPage = value;
				OnPropertyChanged("LandingPage");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		public bool? AllowEmbed
		{
			get { return _AllowEmbed; }
			set 
			{ 
				_AllowEmbed = value;
				OnPropertyChanged("AllowEmbed");
			}
		}
		public int PlayerUiconfId
		{
			get { return _PlayerUiconfId; }
			set 
			{ 
				_PlayerUiconfId = value;
				OnPropertyChanged("PlayerUiconfId");
			}
		}
		public int FlavorParamId
		{
			get { return _FlavorParamId; }
			set 
			{ 
				_FlavorParamId = value;
				OnPropertyChanged("FlavorParamId");
			}
		}
		public bool? TranscodeExistingContent
		{
			get { return _TranscodeExistingContent; }
			set 
			{ 
				_TranscodeExistingContent = value;
				OnPropertyChanged("TranscodeExistingContent");
			}
		}
		public bool? AddToDefaultConversionProfile
		{
			get { return _AddToDefaultConversionProfile; }
			set 
			{ 
				_AddToDefaultConversionProfile = value;
				OnPropertyChanged("AddToDefaultConversionProfile");
			}
		}
		public string Categories
		{
			get { return _Categories; }
			set 
			{ 
				_Categories = value;
				OnPropertyChanged("Categories");
			}
		}
		#endregion

		#region CTor
		public KalturaBaseSyndicationFeed()
		{
		}

		public KalturaBaseSyndicationFeed(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = txt;
						continue;
					case "feedUrl":
						this.FeedUrl = txt;
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "playlistId":
						this.PlaylistId = txt;
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "status":
						this.Status = (KalturaSyndicationFeedStatus)ParseEnum(typeof(KalturaSyndicationFeedStatus), txt);
						continue;
					case "type":
						this.Type = (KalturaSyndicationFeedType)ParseEnum(typeof(KalturaSyndicationFeedType), txt);
						continue;
					case "landingPage":
						this.LandingPage = txt;
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "allowEmbed":
						this.AllowEmbed = ParseBool(txt);
						continue;
					case "playerUiconfId":
						this.PlayerUiconfId = ParseInt(txt);
						continue;
					case "flavorParamId":
						this.FlavorParamId = ParseInt(txt);
						continue;
					case "transcodeExistingContent":
						this.TranscodeExistingContent = ParseBool(txt);
						continue;
					case "addToDefaultConversionProfile":
						this.AddToDefaultConversionProfile = ParseBool(txt);
						continue;
					case "categories":
						this.Categories = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("id", this.Id);
			kparams.AddStringIfNotNull("feedUrl", this.FeedUrl);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddStringIfNotNull("playlistId", this.PlaylistId);
			kparams.AddStringIfNotNull("name", this.Name);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddEnumIfNotNull("type", this.Type);
			kparams.AddStringIfNotNull("landingPage", this.LandingPage);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddBoolIfNotNull("allowEmbed", this.AllowEmbed);
			kparams.AddIntIfNotNull("playerUiconfId", this.PlayerUiconfId);
			kparams.AddIntIfNotNull("flavorParamId", this.FlavorParamId);
			kparams.AddBoolIfNotNull("transcodeExistingContent", this.TranscodeExistingContent);
			kparams.AddBoolIfNotNull("addToDefaultConversionProfile", this.AddToDefaultConversionProfile);
			kparams.AddStringIfNotNull("categories", this.Categories);
			return kparams;
		}
		#endregion
	}
}

