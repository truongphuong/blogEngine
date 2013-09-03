using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDirectoryRestriction : KalturaBaseRestriction
	{
		#region Private Fields
		private KalturaDirectoryRestrictionType _DirectoryRestrictionType = (KalturaDirectoryRestrictionType)Int32.MinValue;
		#endregion

		#region Properties
		public KalturaDirectoryRestrictionType DirectoryRestrictionType
		{
			get { return _DirectoryRestrictionType; }
			set 
			{ 
				_DirectoryRestrictionType = value;
				OnPropertyChanged("DirectoryRestrictionType");
			}
		}
		#endregion

		#region CTor
		public KalturaDirectoryRestriction()
		{
		}

		public KalturaDirectoryRestriction(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "directoryRestrictionType":
						this.DirectoryRestrictionType = (KalturaDirectoryRestrictionType)ParseEnum(typeof(KalturaDirectoryRestrictionType), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddEnumIfNotNull("directoryRestrictionType", this.DirectoryRestrictionType);
			return kparams;
		}
		#endregion
	}
}

