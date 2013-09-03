using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAnnotation : KalturaCuePoint
	{
		#region Private Fields
		private string _ParentId = null;
		private string _Text = null;
		private int _EndTime = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		#endregion

		#region Properties
		public string ParentId
		{
			get { return _ParentId; }
			set 
			{ 
				_ParentId = value;
				OnPropertyChanged("ParentId");
			}
		}
		public string Text
		{
			get { return _Text; }
			set 
			{ 
				_Text = value;
				OnPropertyChanged("Text");
			}
		}
		public int EndTime
		{
			get { return _EndTime; }
			set 
			{ 
				_EndTime = value;
				OnPropertyChanged("EndTime");
			}
		}
		public int Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		#endregion

		#region CTor
		public KalturaAnnotation()
		{
		}

		public KalturaAnnotation(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "parentId":
						this.ParentId = txt;
						continue;
					case "text":
						this.Text = txt;
						continue;
					case "endTime":
						this.EndTime = ParseInt(txt);
						continue;
					case "duration":
						this.Duration = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("parentId", this.ParentId);
			kparams.AddStringIfNotNull("text", this.Text);
			kparams.AddIntIfNotNull("endTime", this.EndTime);
			kparams.AddIntIfNotNull("duration", this.Duration);
			return kparams;
		}
		#endregion
	}
}

