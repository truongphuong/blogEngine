using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDataEntry : KalturaBaseEntry
	{
		#region Private Fields
		private string _DataContent = null;
		private bool? _RetrieveDataContentByGet = false;
		#endregion

		#region Properties
		public string DataContent
		{
			get { return _DataContent; }
			set 
			{ 
				_DataContent = value;
				OnPropertyChanged("DataContent");
			}
		}
		public bool? RetrieveDataContentByGet
		{
			get { return _RetrieveDataContentByGet; }
			set 
			{ 
				_RetrieveDataContentByGet = value;
				OnPropertyChanged("RetrieveDataContentByGet");
			}
		}
		#endregion

		#region CTor
		public KalturaDataEntry()
		{
		}

		public KalturaDataEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "dataContent":
						this.DataContent = txt;
						continue;
					case "retrieveDataContentByGet":
						this.RetrieveDataContentByGet = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("dataContent", this.DataContent);
			kparams.AddBoolIfNotNull("retrieveDataContentByGet", this.RetrieveDataContentByGet);
			return kparams;
		}
		#endregion
	}
}

