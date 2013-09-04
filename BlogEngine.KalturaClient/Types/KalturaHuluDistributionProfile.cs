using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaHuluDistributionProfile : KalturaConfigurableDistributionProfile
	{
		#region Private Fields
		private string _SftpHost = null;
		private string _SftpLogin = null;
		private string _SftpPass = null;
		private string _SeriesChannel = null;
		private string _SeriesPrimaryCategory = null;
		private IList<KalturaString> _SeriesAdditionalCategories;
		private string _SeasonNumber = null;
		private string _SeasonSynopsis = null;
		private string _SeasonTuneInInformation = null;
		private string _VideoMediaType = null;
		#endregion

		#region Properties
		public string SftpHost
		{
			get { return _SftpHost; }
			set 
			{ 
				_SftpHost = value;
				OnPropertyChanged("SftpHost");
			}
		}
		public string SftpLogin
		{
			get { return _SftpLogin; }
			set 
			{ 
				_SftpLogin = value;
				OnPropertyChanged("SftpLogin");
			}
		}
		public string SftpPass
		{
			get { return _SftpPass; }
			set 
			{ 
				_SftpPass = value;
				OnPropertyChanged("SftpPass");
			}
		}
		public string SeriesChannel
		{
			get { return _SeriesChannel; }
			set 
			{ 
				_SeriesChannel = value;
				OnPropertyChanged("SeriesChannel");
			}
		}
		public string SeriesPrimaryCategory
		{
			get { return _SeriesPrimaryCategory; }
			set 
			{ 
				_SeriesPrimaryCategory = value;
				OnPropertyChanged("SeriesPrimaryCategory");
			}
		}
		public IList<KalturaString> SeriesAdditionalCategories
		{
			get { return _SeriesAdditionalCategories; }
			set 
			{ 
				_SeriesAdditionalCategories = value;
				OnPropertyChanged("SeriesAdditionalCategories");
			}
		}
		public string SeasonNumber
		{
			get { return _SeasonNumber; }
			set 
			{ 
				_SeasonNumber = value;
				OnPropertyChanged("SeasonNumber");
			}
		}
		public string SeasonSynopsis
		{
			get { return _SeasonSynopsis; }
			set 
			{ 
				_SeasonSynopsis = value;
				OnPropertyChanged("SeasonSynopsis");
			}
		}
		public string SeasonTuneInInformation
		{
			get { return _SeasonTuneInInformation; }
			set 
			{ 
				_SeasonTuneInInformation = value;
				OnPropertyChanged("SeasonTuneInInformation");
			}
		}
		public string VideoMediaType
		{
			get { return _VideoMediaType; }
			set 
			{ 
				_VideoMediaType = value;
				OnPropertyChanged("VideoMediaType");
			}
		}
		#endregion

		#region CTor
		public KalturaHuluDistributionProfile()
		{
		}

		public KalturaHuluDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "sftpHost":
						this.SftpHost = txt;
						continue;
					case "sftpLogin":
						this.SftpLogin = txt;
						continue;
					case "sftpPass":
						this.SftpPass = txt;
						continue;
					case "seriesChannel":
						this.SeriesChannel = txt;
						continue;
					case "seriesPrimaryCategory":
						this.SeriesPrimaryCategory = txt;
						continue;
					case "seriesAdditionalCategories":
						this.SeriesAdditionalCategories = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.SeriesAdditionalCategories.Add((KalturaString)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "seasonNumber":
						this.SeasonNumber = txt;
						continue;
					case "seasonSynopsis":
						this.SeasonSynopsis = txt;
						continue;
					case "seasonTuneInInformation":
						this.SeasonTuneInInformation = txt;
						continue;
					case "videoMediaType":
						this.VideoMediaType = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("sftpHost", this.SftpHost);
			kparams.AddStringIfNotNull("sftpLogin", this.SftpLogin);
			kparams.AddStringIfNotNull("sftpPass", this.SftpPass);
			kparams.AddStringIfNotNull("seriesChannel", this.SeriesChannel);
			kparams.AddStringIfNotNull("seriesPrimaryCategory", this.SeriesPrimaryCategory);
			if (this.SeriesAdditionalCategories != null)
			{
				if (this.SeriesAdditionalCategories.Count == 0)
				{
					kparams.Add("seriesAdditionalCategories:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaString item in this.SeriesAdditionalCategories)
					{
						kparams.Add("seriesAdditionalCategories:" + i + ":objectType", item.GetType().Name);
						kparams.Add("seriesAdditionalCategories:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddStringIfNotNull("seasonNumber", this.SeasonNumber);
			kparams.AddStringIfNotNull("seasonSynopsis", this.SeasonSynopsis);
			kparams.AddStringIfNotNull("seasonTuneInInformation", this.SeasonTuneInInformation);
			kparams.AddStringIfNotNull("videoMediaType", this.VideoMediaType);
			return kparams;
		}
		#endregion
	}
}

