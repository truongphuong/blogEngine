using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaRemoteDropFolderFilter : KalturaRemoteDropFolderBaseFilter
	{
		#region Private Fields
		private KalturaRemoteDropFolderOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaRemoteDropFolderOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public KalturaRemoteDropFolderFilter()
		{
		}

		public KalturaRemoteDropFolderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaRemoteDropFolderOrderBy)KalturaStringEnum.Parse(typeof(KalturaRemoteDropFolderOrderBy), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringEnumIfNotNull("orderBy", this.OrderBy);
			return kparams;
		}
		#endregion
	}
}

