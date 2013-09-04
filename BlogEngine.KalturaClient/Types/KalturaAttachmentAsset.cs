using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAttachmentAsset : KalturaAsset
	{
		#region Private Fields
		private string _Filename = null;
		private string _Title = null;
		private KalturaAttachmentType _Format = null;
		private KalturaAttachmentAssetStatus _Status = (KalturaAttachmentAssetStatus)Int32.MinValue;
		#endregion

		#region Properties
		public string Filename
		{
			get { return _Filename; }
			set 
			{ 
				_Filename = value;
				OnPropertyChanged("Filename");
			}
		}
		public string Title
		{
			get { return _Title; }
			set 
			{ 
				_Title = value;
				OnPropertyChanged("Title");
			}
		}
		public KalturaAttachmentType Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		public KalturaAttachmentAssetStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		#endregion

		#region CTor
		public KalturaAttachmentAsset()
		{
		}

		public KalturaAttachmentAsset(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "filename":
						this.Filename = txt;
						continue;
					case "title":
						this.Title = txt;
						continue;
					case "format":
						this.Format = (KalturaAttachmentType)KalturaStringEnum.Parse(typeof(KalturaAttachmentType), txt);
						continue;
					case "status":
						this.Status = (KalturaAttachmentAssetStatus)ParseEnum(typeof(KalturaAttachmentAssetStatus), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("filename", this.Filename);
			kparams.AddStringIfNotNull("title", this.Title);
			kparams.AddStringEnumIfNotNull("format", this.Format);
			kparams.AddEnumIfNotNull("status", this.Status);
			return kparams;
		}
		#endregion
	}
}

