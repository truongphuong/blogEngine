using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaRemotePath : KalturaObjectBase
	{
		#region Private Fields
		private int _StorageProfileId = Int32.MinValue;
		private string _Uri = null;
		#endregion

		#region Properties
		public int StorageProfileId
		{
			get { return _StorageProfileId; }
			set 
			{ 
				_StorageProfileId = value;
				OnPropertyChanged("StorageProfileId");
			}
		}
		public string Uri
		{
			get { return _Uri; }
			set 
			{ 
				_Uri = value;
				OnPropertyChanged("Uri");
			}
		}
		#endregion

		#region CTor
		public KalturaRemotePath()
		{
		}

		public KalturaRemotePath(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "storageProfileId":
						this.StorageProfileId = ParseInt(txt);
						continue;
					case "uri":
						this.Uri = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("storageProfileId", this.StorageProfileId);
			kparams.AddStringIfNotNull("uri", this.Uri);
			return kparams;
		}
		#endregion
	}
}

