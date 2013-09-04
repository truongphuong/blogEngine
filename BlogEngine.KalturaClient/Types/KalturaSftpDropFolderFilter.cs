using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSftpDropFolderFilter : KalturaSftpDropFolderBaseFilter
	{
		#region Private Fields
		private KalturaSftpDropFolderOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaSftpDropFolderOrderBy OrderBy
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
		public KalturaSftpDropFolderFilter()
		{
		}

		public KalturaSftpDropFolderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaSftpDropFolderOrderBy)KalturaStringEnum.Parse(typeof(KalturaSftpDropFolderOrderBy), txt);
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

