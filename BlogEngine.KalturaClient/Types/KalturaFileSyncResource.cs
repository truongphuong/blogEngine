using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFileSyncResource : KalturaContentResource
	{
		#region Private Fields
		private int _FileSyncObjectType = Int32.MinValue;
		private int _ObjectSubType = Int32.MinValue;
		private string _ObjectId = null;
		private string _Version = null;
		#endregion

		#region Properties
		public int FileSyncObjectType
		{
			get { return _FileSyncObjectType; }
			set 
			{ 
				_FileSyncObjectType = value;
				OnPropertyChanged("FileSyncObjectType");
			}
		}
		public int ObjectSubType
		{
			get { return _ObjectSubType; }
			set 
			{ 
				_ObjectSubType = value;
				OnPropertyChanged("ObjectSubType");
			}
		}
		public string ObjectId
		{
			get { return _ObjectId; }
			set 
			{ 
				_ObjectId = value;
				OnPropertyChanged("ObjectId");
			}
		}
		public string Version
		{
			get { return _Version; }
			set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
			}
		}
		#endregion

		#region CTor
		public KalturaFileSyncResource()
		{
		}

		public KalturaFileSyncResource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "fileSyncObjectType":
						this.FileSyncObjectType = ParseInt(txt);
						continue;
					case "objectSubType":
						this.ObjectSubType = ParseInt(txt);
						continue;
					case "objectId":
						this.ObjectId = txt;
						continue;
					case "version":
						this.Version = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("fileSyncObjectType", this.FileSyncObjectType);
			kparams.AddIntIfNotNull("objectSubType", this.ObjectSubType);
			kparams.AddStringIfNotNull("objectId", this.ObjectId);
			kparams.AddStringIfNotNull("version", this.Version);
			return kparams;
		}
		#endregion
	}
}

