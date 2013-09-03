using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaPodcastDistributionProfile : KalturaDistributionProfile
	{
		#region Private Fields
		private string _Xsl = null;
		private string _FeedId = null;
		private int _MetadataProfileId = Int32.MinValue;
		#endregion

		#region Properties
		public string Xsl
		{
			get { return _Xsl; }
			set 
			{ 
				_Xsl = value;
				OnPropertyChanged("Xsl");
			}
		}
		public string FeedId
		{
			get { return _FeedId; }
			set 
			{ 
				_FeedId = value;
				OnPropertyChanged("FeedId");
			}
		}
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
		#endregion

		#region CTor
		public KalturaPodcastDistributionProfile()
		{
		}

		public KalturaPodcastDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "xsl":
						this.Xsl = txt;
						continue;
					case "feedId":
						this.FeedId = txt;
						continue;
					case "metadataProfileId":
						this.MetadataProfileId = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("xsl", this.Xsl);
			kparams.AddStringIfNotNull("feedId", this.FeedId);
			kparams.AddIntIfNotNull("metadataProfileId", this.MetadataProfileId);
			return kparams;
		}
		#endregion
	}
}

