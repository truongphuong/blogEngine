using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDocumentEntry : KalturaBaseEntry
	{
		#region Private Fields
		private KalturaDocumentType _DocumentType = (KalturaDocumentType)Int32.MinValue;
		private string _AssetParamsIds = null;
		#endregion

		#region Properties
		public KalturaDocumentType DocumentType
		{
			get { return _DocumentType; }
			set 
			{ 
				_DocumentType = value;
				OnPropertyChanged("DocumentType");
			}
		}
		public string AssetParamsIds
		{
			get { return _AssetParamsIds; }
			set 
			{ 
				_AssetParamsIds = value;
				OnPropertyChanged("AssetParamsIds");
			}
		}
		#endregion

		#region CTor
		public KalturaDocumentEntry()
		{
		}

		public KalturaDocumentEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "documentType":
						this.DocumentType = (KalturaDocumentType)ParseEnum(typeof(KalturaDocumentType), txt);
						continue;
					case "assetParamsIds":
						this.AssetParamsIds = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddEnumIfNotNull("documentType", this.DocumentType);
			kparams.AddStringIfNotNull("assetParamsIds", this.AssetParamsIds);
			return kparams;
		}
		#endregion
	}
}

