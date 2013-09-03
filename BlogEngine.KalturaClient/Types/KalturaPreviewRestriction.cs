using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaPreviewRestriction : KalturaSessionRestriction
	{
		#region Private Fields
		private int _PreviewLength = Int32.MinValue;
		#endregion

		#region Properties
		public int PreviewLength
		{
			get { return _PreviewLength; }
			set 
			{ 
				_PreviewLength = value;
				OnPropertyChanged("PreviewLength");
			}
		}
		#endregion

		#region CTor
		public KalturaPreviewRestriction()
		{
		}

		public KalturaPreviewRestriction(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "previewLength":
						this.PreviewLength = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("previewLength", this.PreviewLength);
			return kparams;
		}
		#endregion
	}
}

