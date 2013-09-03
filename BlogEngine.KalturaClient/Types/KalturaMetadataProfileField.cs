using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaMetadataProfileField : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _XPath = null;
		private string _Key = null;
		private string _Label = null;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public string XPath
		{
			get { return _XPath; }
			set 
			{ 
				_XPath = value;
				OnPropertyChanged("XPath");
			}
		}
		public string Key
		{
			get { return _Key; }
			set 
			{ 
				_Key = value;
				OnPropertyChanged("Key");
			}
		}
		public string Label
		{
			get { return _Label; }
			set 
			{ 
				_Label = value;
				OnPropertyChanged("Label");
			}
		}
		#endregion

		#region CTor
		public KalturaMetadataProfileField()
		{
		}

		public KalturaMetadataProfileField(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "xPath":
						this.XPath = txt;
						continue;
					case "key":
						this.Key = txt;
						continue;
					case "label":
						this.Label = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("id", this.Id);
			kparams.AddStringIfNotNull("xPath", this.XPath);
			kparams.AddStringIfNotNull("key", this.Key);
			kparams.AddStringIfNotNull("label", this.Label);
			return kparams;
		}
		#endregion
	}
}

