using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDropFolderFileHandlerConfig : KalturaObjectBase
	{
		#region Private Fields
		private KalturaDropFolderFileHandlerType _HandlerType = null;
		#endregion

		#region Properties
		public KalturaDropFolderFileHandlerType HandlerType
		{
			get { return _HandlerType; }
			set 
			{ 
				_HandlerType = value;
				OnPropertyChanged("HandlerType");
			}
		}
		#endregion

		#region CTor
		public KalturaDropFolderFileHandlerConfig()
		{
		}

		public KalturaDropFolderFileHandlerConfig(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "handlerType":
						this.HandlerType = (KalturaDropFolderFileHandlerType)KalturaStringEnum.Parse(typeof(KalturaDropFolderFileHandlerType), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringEnumIfNotNull("handlerType", this.HandlerType);
			return kparams;
		}
		#endregion
	}
}

