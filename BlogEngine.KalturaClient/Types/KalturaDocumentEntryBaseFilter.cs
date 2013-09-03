using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDocumentEntryBaseFilter : KalturaBaseEntryFilter
	{
		#region Private Fields
		private KalturaDocumentType _DocumentTypeEqual = (KalturaDocumentType)Int32.MinValue;
		private string _DocumentTypeIn = null;
		private string _AssetParamsIdsMatchOr = null;
		private string _AssetParamsIdsMatchAnd = null;
		#endregion

		#region Properties
		public KalturaDocumentType DocumentTypeEqual
		{
			get { return _DocumentTypeEqual; }
			set 
			{ 
				_DocumentTypeEqual = value;
				OnPropertyChanged("DocumentTypeEqual");
			}
		}
		public string DocumentTypeIn
		{
			get { return _DocumentTypeIn; }
			set 
			{ 
				_DocumentTypeIn = value;
				OnPropertyChanged("DocumentTypeIn");
			}
		}
		public string AssetParamsIdsMatchOr
		{
			get { return _AssetParamsIdsMatchOr; }
			set 
			{ 
				_AssetParamsIdsMatchOr = value;
				OnPropertyChanged("AssetParamsIdsMatchOr");
			}
		}
		public string AssetParamsIdsMatchAnd
		{
			get { return _AssetParamsIdsMatchAnd; }
			set 
			{ 
				_AssetParamsIdsMatchAnd = value;
				OnPropertyChanged("AssetParamsIdsMatchAnd");
			}
		}
		#endregion

		#region CTor
		public KalturaDocumentEntryBaseFilter()
		{
		}

		public KalturaDocumentEntryBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "documentTypeEqual":
						this.DocumentTypeEqual = (KalturaDocumentType)ParseEnum(typeof(KalturaDocumentType), txt);
						continue;
					case "documentTypeIn":
						this.DocumentTypeIn = txt;
						continue;
					case "assetParamsIdsMatchOr":
						this.AssetParamsIdsMatchOr = txt;
						continue;
					case "assetParamsIdsMatchAnd":
						this.AssetParamsIdsMatchAnd = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddEnumIfNotNull("documentTypeEqual", this.DocumentTypeEqual);
			kparams.AddStringIfNotNull("documentTypeIn", this.DocumentTypeIn);
			kparams.AddStringIfNotNull("assetParamsIdsMatchOr", this.AssetParamsIdsMatchOr);
			kparams.AddStringIfNotNull("assetParamsIdsMatchAnd", this.AssetParamsIdsMatchAnd);
			return kparams;
		}
		#endregion
	}
}

