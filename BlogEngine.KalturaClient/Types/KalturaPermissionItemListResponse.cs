using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaPermissionItemListResponse : KalturaObjectBase
	{
		#region Private Fields
		private IList<KalturaPermissionItem> _Objects;
		private int _TotalCount = Int32.MinValue;
		#endregion

		#region Properties
		public IList<KalturaPermissionItem> Objects
		{
			get { return _Objects; }
			set 
			{ 
				_Objects = value;
				OnPropertyChanged("Objects");
			}
		}
		public int TotalCount
		{
			get { return _TotalCount; }
			set 
			{ 
				_TotalCount = value;
				OnPropertyChanged("TotalCount");
			}
		}
		#endregion

		#region CTor
		public KalturaPermissionItemListResponse()
		{
		}

		public KalturaPermissionItemListResponse(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "objects":
						this.Objects = new List<KalturaPermissionItem>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Objects.Add((KalturaPermissionItem)KalturaObjectFactory.Create(arrayNode));
						}
						continue;
					case "totalCount":
						this.TotalCount = ParseInt(txt);
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
					foreach (KalturaPermissionItem item in this.Objects)
					{
						kparams.Add("objects:" + i + ":objectType", item.GetType().Name);
						kparams.Add("objects:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddIntIfNotNull("totalCount", this.TotalCount);
			return kparams;
		}
		#endregion
	}
}

