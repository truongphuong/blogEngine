using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaBaseEntryFilter : KalturaBaseEntryBaseFilter
	{
		#region Private Fields
		private string _FreeText = null;
		private KalturaNullableBoolean _IsRoot = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaBaseEntryOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public string FreeText
		{
			get { return _FreeText; }
			set 
			{ 
				_FreeText = value;
				OnPropertyChanged("FreeText");
			}
		}
		public KalturaNullableBoolean IsRoot
		{
			get { return _IsRoot; }
			set 
			{ 
				_IsRoot = value;
				OnPropertyChanged("IsRoot");
			}
		}
		public new KalturaBaseEntryOrderBy OrderBy
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
		public KalturaBaseEntryFilter()
		{
		}

		public KalturaBaseEntryFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "freeText":
						this.FreeText = txt;
						continue;
					case "isRoot":
						this.IsRoot = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "orderBy":
						this.OrderBy = (KalturaBaseEntryOrderBy)KalturaStringEnum.Parse(typeof(KalturaBaseEntryOrderBy), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("freeText", this.FreeText);
			kparams.AddEnumIfNotNull("isRoot", this.IsRoot);
			kparams.AddStringEnumIfNotNull("orderBy", this.OrderBy);
			return kparams;
		}
		#endregion
	}
}

