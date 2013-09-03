using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaMediaEntryFilterForPlaylist : KalturaMediaEntryFilter
	{
		#region Private Fields
		private int _Limit = Int32.MinValue;
		#endregion

		#region Properties
		public int Limit
		{
			get { return _Limit; }
			set 
			{ 
				_Limit = value;
				OnPropertyChanged("Limit");
			}
		}
		#endregion

		#region CTor
		public KalturaMediaEntryFilterForPlaylist()
		{
		}

		public KalturaMediaEntryFilterForPlaylist(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "limit":
						this.Limit = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("limit", this.Limit);
			return kparams;
		}
		#endregion
	}
}

