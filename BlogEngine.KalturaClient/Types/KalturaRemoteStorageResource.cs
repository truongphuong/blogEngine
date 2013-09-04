using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaRemoteStorageResource : KalturaUrlResource
	{
		#region Private Fields
		private int _StorageProfileId = Int32.MinValue;
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
		#endregion

		#region CTor
		public KalturaRemoteStorageResource()
		{
		}

		public KalturaRemoteStorageResource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "storageProfileId":
						this.StorageProfileId = ParseInt(txt);
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
			return kparams;
		}
		#endregion
	}
}

