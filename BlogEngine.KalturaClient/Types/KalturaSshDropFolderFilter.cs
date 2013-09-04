using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSshDropFolderFilter : KalturaSshDropFolderBaseFilter
	{
		#region Private Fields
		private KalturaSshDropFolderOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaSshDropFolderOrderBy OrderBy
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
		public KalturaSshDropFolderFilter()
		{
		}

		public KalturaSshDropFolderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaSshDropFolderOrderBy)KalturaStringEnum.Parse(typeof(KalturaSshDropFolderOrderBy), txt);
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

