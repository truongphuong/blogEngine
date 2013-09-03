using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDropFolderContentFileHandlerConfig : KalturaDropFolderFileHandlerConfig
	{
		#region Private Fields
		private KalturaDropFolderContentFileHandlerMatchPolicy _ContentMatchPolicy = (KalturaDropFolderContentFileHandlerMatchPolicy)Int32.MinValue;
		private string _SlugRegex = null;
		#endregion

		#region Properties
		public KalturaDropFolderContentFileHandlerMatchPolicy ContentMatchPolicy
		{
			get { return _ContentMatchPolicy; }
			set 
			{ 
				_ContentMatchPolicy = value;
				OnPropertyChanged("ContentMatchPolicy");
			}
		}
		public string SlugRegex
		{
			get { return _SlugRegex; }
			set 
			{ 
				_SlugRegex = value;
				OnPropertyChanged("SlugRegex");
			}
		}
		#endregion

		#region CTor
		public KalturaDropFolderContentFileHandlerConfig()
		{
		}

		public KalturaDropFolderContentFileHandlerConfig(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "contentMatchPolicy":
						this.ContentMatchPolicy = (KalturaDropFolderContentFileHandlerMatchPolicy)ParseEnum(typeof(KalturaDropFolderContentFileHandlerMatchPolicy), txt);
						continue;
					case "slugRegex":
						this.SlugRegex = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddEnumIfNotNull("contentMatchPolicy", this.ContentMatchPolicy);
			kparams.AddStringIfNotNull("slugRegex", this.SlugRegex);
			return kparams;
		}
		#endregion
	}
}

