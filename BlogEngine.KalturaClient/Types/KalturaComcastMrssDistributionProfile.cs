using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaComcastMrssDistributionProfile : KalturaConfigurableDistributionProfile
	{
		#region Private Fields
		private int _MetadataProfileId = Int32.MinValue;
		private string _FeedUrl = null;
		private string _FeedTitle = null;
		private string _FeedLink = null;
		private string _FeedDescription = null;
		private string _FeedLastBuildDate = null;
		private string _ItemLink = null;
		private IList<KalturaKeyValue> _CPlatformTvSeries;
		private string _CPlatformTvSeriesField = null;
		#endregion

		#region Properties
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
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
		public string FeedTitle
		{
			get { return _FeedTitle; }
			set 
			{ 
				_FeedTitle = value;
				OnPropertyChanged("FeedTitle");
			}
		}
		public string FeedLink
		{
			get { return _FeedLink; }
			set 
			{ 
				_FeedLink = value;
				OnPropertyChanged("FeedLink");
			}
		}
		public string FeedDescription
		{
			get { return _FeedDescription; }
			set 
			{ 
				_FeedDescription = value;
				OnPropertyChanged("FeedDescription");
			}
		}
		public string FeedLastBuildDate
		{
			get { return _FeedLastBuildDate; }
			set 
			{ 
				_FeedLastBuildDate = value;
				OnPropertyChanged("FeedLastBuildDate");
			}
		}
		public string ItemLink
		{
			get { return _ItemLink; }
			set 
			{ 
				_ItemLink = value;
				OnPropertyChanged("ItemLink");
			}
		}
		public IList<KalturaKeyValue> CPlatformTvSeries
		{
			get { return _CPlatformTvSeries; }
			set 
			{ 
				_CPlatformTvSeries = value;
				OnPropertyChanged("CPlatformTvSeries");
			}
		}
		public string CPlatformTvSeriesField
		{
			get { return _CPlatformTvSeriesField; }
			set 
			{ 
				_CPlatformTvSeriesField = value;
				OnPropertyChanged("CPlatformTvSeriesField");
			}
		}
		#endregion

		#region CTor
		public KalturaComcastMrssDistributionProfile()
		{
		}

		public KalturaComcastMrssDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "metadataProfileId":
						this.MetadataProfileId = ParseInt(txt);
						continue;
					case "feedUrl":
						this.FeedUrl = txt;
						continue;
					case "feedTitle":
						this.FeedTitle = txt;
						continue;
					case "feedLink":
						this.FeedLink = txt;
						continue;
					case "feedDescription":
						this.FeedDescription = txt;
						continue;
					case "feedLastBuildDate":
						this.FeedLastBuildDate = txt;
						continue;
					case "itemLink":
						this.ItemLink = txt;
						continue;
					case "cPlatformTvSeries":
						this.CPlatformTvSeries = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.CPlatformTvSeries.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "cPlatformTvSeriesField":
						this.CPlatformTvSeriesField = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("metadataProfileId", this.MetadataProfileId);
			kparams.AddStringIfNotNull("feedUrl", this.FeedUrl);
			kparams.AddStringIfNotNull("feedTitle", this.FeedTitle);
			kparams.AddStringIfNotNull("feedLink", this.FeedLink);
			kparams.AddStringIfNotNull("feedDescription", this.FeedDescription);
			kparams.AddStringIfNotNull("feedLastBuildDate", this.FeedLastBuildDate);
			kparams.AddStringIfNotNull("itemLink", this.ItemLink);
			if (this.CPlatformTvSeries != null)
			{
				if (this.CPlatformTvSeries.Count == 0)
				{
					kparams.Add("cPlatformTvSeries:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaKeyValue item in this.CPlatformTvSeries)
					{
						kparams.Add("cPlatformTvSeries:" + i + ":objectType", item.GetType().Name);
						kparams.Add("cPlatformTvSeries:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddStringIfNotNull("cPlatformTvSeriesField", this.CPlatformTvSeriesField);
			return kparams;
		}
		#endregion
	}
}

