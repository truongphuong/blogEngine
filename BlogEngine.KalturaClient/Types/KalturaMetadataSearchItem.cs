using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaMetadataSearchItem : KalturaSearchOperator
	{
		#region Private Fields
		private int _MetadataProfileId = Int32.MinValue;
		private string _OrderBy = null;
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
		public string OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public KalturaMetadataSearchItem()
		{
		}

		public KalturaMetadataSearchItem(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "metadataProfileId":
						this.MetadataProfileId = ParseInt(txt);
						continue;
					case "orderBy":
						this.OrderBy = txt;
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
			kparams.AddStringIfNotNull("orderBy", this.OrderBy);
			return kparams;
		}
		#endregion
	}
}

