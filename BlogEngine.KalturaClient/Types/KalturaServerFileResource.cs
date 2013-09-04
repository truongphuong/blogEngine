using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaServerFileResource : KalturaDataCenterContentResource
	{
		#region Private Fields
		private string _LocalFilePath = null;
		#endregion

		#region Properties
		public string LocalFilePath
		{
			get { return _LocalFilePath; }
			set 
			{ 
				_LocalFilePath = value;
				OnPropertyChanged("LocalFilePath");
			}
		}
		#endregion

		#region CTor
		public KalturaServerFileResource()
		{
		}

		public KalturaServerFileResource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "localFilePath":
						this.LocalFilePath = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("localFilePath", this.LocalFilePath);
			return kparams;
		}
		#endregion
	}
}

