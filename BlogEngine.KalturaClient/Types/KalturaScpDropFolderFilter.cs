using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaScpDropFolderFilter : KalturaScpDropFolderBaseFilter
	{
		#region Private Fields
		private KalturaScpDropFolderOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaScpDropFolderOrderBy OrderBy
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
		public KalturaScpDropFolderFilter()
		{
		}

		public KalturaScpDropFolderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaScpDropFolderOrderBy)KalturaStringEnum.Parse(typeof(KalturaScpDropFolderOrderBy), txt);
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

