using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaCaptionAssetItemFilter : KalturaCaptionAssetFilter
	{
		#region Private Fields
		private string _ContentLike = null;
		private string _ContentMultiLikeOr = null;
		private string _ContentMultiLikeAnd = null;
		private string _PartnerDescriptionLike = null;
		private string _PartnerDescriptionMultiLikeOr = null;
		private string _PartnerDescriptionMultiLikeAnd = null;
		private KalturaLanguage _LanguageEqual = null;
		private string _LanguageIn = null;
		private string _LabelEqual = null;
		private string _LabelIn = null;
		private int _StartTimeGreaterThanOrEqual = Int32.MinValue;
		private int _StartTimeLessThanOrEqual = Int32.MinValue;
		private int _EndTimeGreaterThanOrEqual = Int32.MinValue;
		private int _EndTimeLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		public string ContentLike
		{
			get { return _ContentLike; }
			set 
			{ 
				_ContentLike = value;
				OnPropertyChanged("ContentLike");
			}
		}
		public string ContentMultiLikeOr
		{
			get { return _ContentMultiLikeOr; }
			set 
			{ 
				_ContentMultiLikeOr = value;
				OnPropertyChanged("ContentMultiLikeOr");
			}
		}
		public string ContentMultiLikeAnd
		{
			get { return _ContentMultiLikeAnd; }
			set 
			{ 
				_ContentMultiLikeAnd = value;
				OnPropertyChanged("ContentMultiLikeAnd");
			}
		}
		public string PartnerDescriptionLike
		{
			get { return _PartnerDescriptionLike; }
			set 
			{ 
				_PartnerDescriptionLike = value;
				OnPropertyChanged("PartnerDescriptionLike");
			}
		}
		public string PartnerDescriptionMultiLikeOr
		{
			get { return _PartnerDescriptionMultiLikeOr; }
			set 
			{ 
				_PartnerDescriptionMultiLikeOr = value;
				OnPropertyChanged("PartnerDescriptionMultiLikeOr");
			}
		}
		public string PartnerDescriptionMultiLikeAnd
		{
			get { return _PartnerDescriptionMultiLikeAnd; }
			set 
			{ 
				_PartnerDescriptionMultiLikeAnd = value;
				OnPropertyChanged("PartnerDescriptionMultiLikeAnd");
			}
		}
		public KalturaLanguage LanguageEqual
		{
			get { return _LanguageEqual; }
			set 
			{ 
				_LanguageEqual = value;
				OnPropertyChanged("LanguageEqual");
			}
		}
		public string LanguageIn
		{
			get { return _LanguageIn; }
			set 
			{ 
				_LanguageIn = value;
				OnPropertyChanged("LanguageIn");
			}
		}
		public string LabelEqual
		{
			get { return _LabelEqual; }
			set 
			{ 
				_LabelEqual = value;
				OnPropertyChanged("LabelEqual");
			}
		}
		public string LabelIn
		{
			get { return _LabelIn; }
			set 
			{ 
				_LabelIn = value;
				OnPropertyChanged("LabelIn");
			}
		}
		public int StartTimeGreaterThanOrEqual
		{
			get { return _StartTimeGreaterThanOrEqual; }
			set 
			{ 
				_StartTimeGreaterThanOrEqual = value;
				OnPropertyChanged("StartTimeGreaterThanOrEqual");
			}
		}
		public int StartTimeLessThanOrEqual
		{
			get { return _StartTimeLessThanOrEqual; }
			set 
			{ 
				_StartTimeLessThanOrEqual = value;
				OnPropertyChanged("StartTimeLessThanOrEqual");
			}
		}
		public int EndTimeGreaterThanOrEqual
		{
			get { return _EndTimeGreaterThanOrEqual; }
			set 
			{ 
				_EndTimeGreaterThanOrEqual = value;
				OnPropertyChanged("EndTimeGreaterThanOrEqual");
			}
		}
		public int EndTimeLessThanOrEqual
		{
			get { return _EndTimeLessThanOrEqual; }
			set 
			{ 
				_EndTimeLessThanOrEqual = value;
				OnPropertyChanged("EndTimeLessThanOrEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaCaptionAssetItemFilter()
		{
		}

		public KalturaCaptionAssetItemFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "contentLike":
						this.ContentLike = txt;
						continue;
					case "contentMultiLikeOr":
						this.ContentMultiLikeOr = txt;
						continue;
					case "contentMultiLikeAnd":
						this.ContentMultiLikeAnd = txt;
						continue;
					case "partnerDescriptionLike":
						this.PartnerDescriptionLike = txt;
						continue;
					case "partnerDescriptionMultiLikeOr":
						this.PartnerDescriptionMultiLikeOr = txt;
						continue;
					case "partnerDescriptionMultiLikeAnd":
						this.PartnerDescriptionMultiLikeAnd = txt;
						continue;
					case "languageEqual":
						this.LanguageEqual = (KalturaLanguage)KalturaStringEnum.Parse(typeof(KalturaLanguage), txt);
						continue;
					case "languageIn":
						this.LanguageIn = txt;
						continue;
					case "labelEqual":
						this.LabelEqual = txt;
						continue;
					case "labelIn":
						this.LabelIn = txt;
						continue;
					case "startTimeGreaterThanOrEqual":
						this.StartTimeGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "startTimeLessThanOrEqual":
						this.StartTimeLessThanOrEqual = ParseInt(txt);
						continue;
					case "endTimeGreaterThanOrEqual":
						this.EndTimeGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "endTimeLessThanOrEqual":
						this.EndTimeLessThanOrEqual = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("contentLike", this.ContentLike);
			kparams.AddStringIfNotNull("contentMultiLikeOr", this.ContentMultiLikeOr);
			kparams.AddStringIfNotNull("contentMultiLikeAnd", this.ContentMultiLikeAnd);
			kparams.AddStringIfNotNull("partnerDescriptionLike", this.PartnerDescriptionLike);
			kparams.AddStringIfNotNull("partnerDescriptionMultiLikeOr", this.PartnerDescriptionMultiLikeOr);
			kparams.AddStringIfNotNull("partnerDescriptionMultiLikeAnd", this.PartnerDescriptionMultiLikeAnd);
			kparams.AddStringEnumIfNotNull("languageEqual", this.LanguageEqual);
			kparams.AddStringIfNotNull("languageIn", this.LanguageIn);
			kparams.AddStringIfNotNull("labelEqual", this.LabelEqual);
			kparams.AddStringIfNotNull("labelIn", this.LabelIn);
			kparams.AddIntIfNotNull("startTimeGreaterThanOrEqual", this.StartTimeGreaterThanOrEqual);
			kparams.AddIntIfNotNull("startTimeLessThanOrEqual", this.StartTimeLessThanOrEqual);
			kparams.AddIntIfNotNull("endTimeGreaterThanOrEqual", this.EndTimeGreaterThanOrEqual);
			kparams.AddIntIfNotNull("endTimeLessThanOrEqual", this.EndTimeLessThanOrEqual);
			return kparams;
		}
		#endregion
	}
}

