using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSearchResultResponse : KalturaObjectBase
	{
		#region Private Fields
		private IList<KalturaSearchResult> _Objects;
		private bool? _NeedMediaInfo = false;
		#endregion

		#region Properties
		public IList<KalturaSearchResult> Objects
		{
			get { return _Objects; }
			set 
			{ 
				_Objects = value;
				OnPropertyChanged("Objects");
			}
		}
		public bool? NeedMediaInfo
		{
			get { return _NeedMediaInfo; }
			set 
			{ 
				_NeedMediaInfo = value;
				OnPropertyChanged("NeedMediaInfo");
			}
		}
		#endregion

		#region CTor
		public KalturaSearchResultResponse()
		{
		}

		public KalturaSearchResultResponse(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "objects":
						this.Objects = new List<KalturaSearchResult>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Objects.Add((KalturaSearchResult)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "needMediaInfo":
						this.NeedMediaInfo = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			if (this.Objects != null)
			{
				if (this.Objects.Count == 0)
				{
					kparams.Add("objects:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaSearchResult item in this.Objects)
					{
						kparams.Add("objects:" + i + ":objectType", item.GetType().Name);
						kparams.Add("objects:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddBoolIfNotNull("needMediaInfo", this.NeedMediaInfo);
			return kparams;
		}
		#endregion
	}
}

