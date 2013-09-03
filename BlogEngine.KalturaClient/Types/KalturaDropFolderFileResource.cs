using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDropFolderFileResource : KalturaDataCenterContentResource
	{
		#region Private Fields
		private int _DropFolderFileId = Int32.MinValue;
		#endregion

		#region Properties
		public int DropFolderFileId
		{
			get { return _DropFolderFileId; }
			set 
			{ 
				_DropFolderFileId = value;
				OnPropertyChanged("DropFolderFileId");
			}
		}
		#endregion

		#region CTor
		public KalturaDropFolderFileResource()
		{
		}

		public KalturaDropFolderFileResource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "dropFolderFileId":
						this.DropFolderFileId = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("dropFolderFileId", this.DropFolderFileId);
			return kparams;
		}
		#endregion
	}
}

