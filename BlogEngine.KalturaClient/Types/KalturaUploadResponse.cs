using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaUploadResponse : KalturaObjectBase
	{
		#region Private Fields
		private string _UploadTokenId = null;
		private int _FileSize = Int32.MinValue;
		private KalturaUploadErrorCode _ErrorCode = (KalturaUploadErrorCode)Int32.MinValue;
		private string _ErrorDescription = null;
		#endregion

		#region Properties
		public string UploadTokenId
		{
			get { return _UploadTokenId; }
			set 
			{ 
				_UploadTokenId = value;
				OnPropertyChanged("UploadTokenId");
			}
		}
		public int FileSize
		{
			get { return _FileSize; }
			set 
			{ 
				_FileSize = value;
				OnPropertyChanged("FileSize");
			}
		}
		public KalturaUploadErrorCode ErrorCode
		{
			get { return _ErrorCode; }
			set 
			{ 
				_ErrorCode = value;
				OnPropertyChanged("ErrorCode");
			}
		}
		public string ErrorDescription
		{
			get { return _ErrorDescription; }
			set 
			{ 
				_ErrorDescription = value;
				OnPropertyChanged("ErrorDescription");
			}
		}
		#endregion

		#region CTor
		public KalturaUploadResponse()
		{
		}

		public KalturaUploadResponse(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "uploadTokenId":
						this.UploadTokenId = txt;
						continue;
					case "fileSize":
						this.FileSize = ParseInt(txt);
						continue;
					case "errorCode":
						this.ErrorCode = (KalturaUploadErrorCode)ParseEnum(typeof(KalturaUploadErrorCode), txt);
						continue;
					case "errorDescription":
						this.ErrorDescription = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("uploadTokenId", this.UploadTokenId);
			kparams.AddIntIfNotNull("fileSize", this.FileSize);
			kparams.AddEnumIfNotNull("errorCode", this.ErrorCode);
			kparams.AddStringIfNotNull("errorDescription", this.ErrorDescription);
			return kparams;
		}
		#endregion
	}
}

