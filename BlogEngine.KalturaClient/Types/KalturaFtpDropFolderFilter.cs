using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFtpDropFolderFilter : KalturaFtpDropFolderBaseFilter
	{
		#region Private Fields
		private KalturaFtpDropFolderOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaFtpDropFolderOrderBy OrderBy
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
		public KalturaFtpDropFolderFilter()
		{
		}

		public KalturaFtpDropFolderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaFtpDropFolderOrderBy)KalturaStringEnum.Parse(typeof(KalturaFtpDropFolderOrderBy), txt);
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

