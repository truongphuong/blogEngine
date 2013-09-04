using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaCodeCuePointBaseFilter : KalturaCuePointFilter
	{
		#region Private Fields
		private string _CodeLike = null;
		private string _CodeMultiLikeOr = null;
		private string _CodeMultiLikeAnd = null;
		private string _CodeEqual = null;
		private string _CodeIn = null;
		private string _DescriptionLike = null;
		private string _DescriptionMultiLikeOr = null;
		private string _DescriptionMultiLikeAnd = null;
		#endregion

		#region Properties
		public string CodeLike
		{
			get { return _CodeLike; }
			set 
			{ 
				_CodeLike = value;
				OnPropertyChanged("CodeLike");
			}
		}
		public string CodeMultiLikeOr
		{
			get { return _CodeMultiLikeOr; }
			set 
			{ 
				_CodeMultiLikeOr = value;
				OnPropertyChanged("CodeMultiLikeOr");
			}
		}
		public string CodeMultiLikeAnd
		{
			get { return _CodeMultiLikeAnd; }
			set 
			{ 
				_CodeMultiLikeAnd = value;
				OnPropertyChanged("CodeMultiLikeAnd");
			}
		}
		public string CodeEqual
		{
			get { return _CodeEqual; }
			set 
			{ 
				_CodeEqual = value;
				OnPropertyChanged("CodeEqual");
			}
		}
		public string CodeIn
		{
			get { return _CodeIn; }
			set 
			{ 
				_CodeIn = value;
				OnPropertyChanged("CodeIn");
			}
		}
		public string DescriptionLike
		{
			get { return _DescriptionLike; }
			set 
			{ 
				_DescriptionLike = value;
				OnPropertyChanged("DescriptionLike");
			}
		}
		public string DescriptionMultiLikeOr
		{
			get { return _DescriptionMultiLikeOr; }
			set 
			{ 
				_DescriptionMultiLikeOr = value;
				OnPropertyChanged("DescriptionMultiLikeOr");
			}
		}
		public string DescriptionMultiLikeAnd
		{
			get { return _DescriptionMultiLikeAnd; }
			set 
			{ 
				_DescriptionMultiLikeAnd = value;
				OnPropertyChanged("DescriptionMultiLikeAnd");
			}
		}
		#endregion

		#region CTor
		public KalturaCodeCuePointBaseFilter()
		{
		}

		public KalturaCodeCuePointBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "codeLike":
						this.CodeLike = txt;
						continue;
					case "codeMultiLikeOr":
						this.CodeMultiLikeOr = txt;
						continue;
					case "codeMultiLikeAnd":
						this.CodeMultiLikeAnd = txt;
						continue;
					case "codeEqual":
						this.CodeEqual = txt;
						continue;
					case "codeIn":
						this.CodeIn = txt;
						continue;
					case "descriptionLike":
						this.DescriptionLike = txt;
						continue;
					case "descriptionMultiLikeOr":
						this.DescriptionMultiLikeOr = txt;
						continue;
					case "descriptionMultiLikeAnd":
						this.DescriptionMultiLikeAnd = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("codeLike", this.CodeLike);
			kparams.AddStringIfNotNull("codeMultiLikeOr", this.CodeMultiLikeOr);
			kparams.AddStringIfNotNull("codeMultiLikeAnd", this.CodeMultiLikeAnd);
			kparams.AddStringIfNotNull("codeEqual", this.CodeEqual);
			kparams.AddStringIfNotNull("codeIn", this.CodeIn);
			kparams.AddStringIfNotNull("descriptionLike", this.DescriptionLike);
			kparams.AddStringIfNotNull("descriptionMultiLikeOr", this.DescriptionMultiLikeOr);
			kparams.AddStringIfNotNull("descriptionMultiLikeAnd", this.DescriptionMultiLikeAnd);
			return kparams;
		}
		#endregion
	}
}

