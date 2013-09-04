using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAuditTrailFileSyncCreateInfo : KalturaAuditTrailInfo
	{
		#region Private Fields
		private string _Version = null;
		private int _ObjectSubType = Int32.MinValue;
		private int _Dc = Int32.MinValue;
		private bool? _Original = false;
		private KalturaAuditTrailFileSyncType _FileType = (KalturaAuditTrailFileSyncType)Int32.MinValue;
		#endregion

		#region Properties
		public string Version
		{
			get { return _Version; }
			set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
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
		public int Dc
		{
			get { return _Dc; }
			set 
			{ 
				_Dc = value;
				OnPropertyChanged("Dc");
			}
		}
		public bool? Original
		{
			get { return _Original; }
			set 
			{ 
				_Original = value;
				OnPropertyChanged("Original");
			}
		}
		public KalturaAuditTrailFileSyncType FileType
		{
			get { return _FileType; }
			set 
			{ 
				_FileType = value;
				OnPropertyChanged("FileType");
			}
		}
		#endregion

		#region CTor
		public KalturaAuditTrailFileSyncCreateInfo()
		{
		}

		public KalturaAuditTrailFileSyncCreateInfo(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "version":
						this.Version = txt;
						continue;
					case "objectSubType":
						this.ObjectSubType = ParseInt(txt);
						continue;
					case "dc":
						this.Dc = ParseInt(txt);
						continue;
					case "original":
						this.Original = ParseBool(txt);
						continue;
					case "fileType":
						this.FileType = (KalturaAuditTrailFileSyncType)ParseEnum(typeof(KalturaAuditTrailFileSyncType), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("version", this.Version);
			kparams.AddIntIfNotNull("objectSubType", this.ObjectSubType);
			kparams.AddIntIfNotNull("dc", this.Dc);
			kparams.AddBoolIfNotNull("original", this.Original);
			kparams.AddEnumIfNotNull("fileType", this.FileType);
			return kparams;
		}
		#endregion
	}
}

