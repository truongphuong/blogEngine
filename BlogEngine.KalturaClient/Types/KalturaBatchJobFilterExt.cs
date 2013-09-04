using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaBatchJobFilterExt : KalturaBatchJobFilter
	{
		#region Private Fields
		private string _JobTypeAndSubTypeIn = null;
		#endregion

		#region Properties
		public string JobTypeAndSubTypeIn
		{
			get { return _JobTypeAndSubTypeIn; }
			set 
			{ 
				_JobTypeAndSubTypeIn = value;
				OnPropertyChanged("JobTypeAndSubTypeIn");
			}
		}
		#endregion

		#region CTor
		public KalturaBatchJobFilterExt()
		{
		}

		public KalturaBatchJobFilterExt(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "jobTypeAndSubTypeIn":
						this.JobTypeAndSubTypeIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("jobTypeAndSubTypeIn", this.JobTypeAndSubTypeIn);
			return kparams;
		}
		#endregion
	}
}

