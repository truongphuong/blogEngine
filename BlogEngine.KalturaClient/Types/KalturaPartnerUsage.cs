using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaPartnerUsage : KalturaObjectBase
	{
		#region Private Fields
		private float _HostingGB = Single.MinValue;
		private float _Percent = Single.MinValue;
		private int _PackageBW = Int32.MinValue;
		private int _UsageGB = Int32.MinValue;
		private int _ReachedLimitDate = Int32.MinValue;
		private string _UsageGraph = null;
		#endregion

		#region Properties
		public float HostingGB
		{
			get { return _HostingGB; }
			set 
			{ 
				_HostingGB = value;
				OnPropertyChanged("HostingGB");
			}
		}
		public float Percent
		{
			get { return _Percent; }
			set 
			{ 
				_Percent = value;
				OnPropertyChanged("Percent");
			}
		}
		public int PackageBW
		{
			get { return _PackageBW; }
			set 
			{ 
				_PackageBW = value;
				OnPropertyChanged("PackageBW");
			}
		}
		public int UsageGB
		{
			get { return _UsageGB; }
			set 
			{ 
				_UsageGB = value;
				OnPropertyChanged("UsageGB");
			}
		}
		public int ReachedLimitDate
		{
			get { return _ReachedLimitDate; }
			set 
			{ 
				_ReachedLimitDate = value;
				OnPropertyChanged("ReachedLimitDate");
			}
		}
		public string UsageGraph
		{
			get { return _UsageGraph; }
			set 
			{ 
				_UsageGraph = value;
				OnPropertyChanged("UsageGraph");
			}
		}
		#endregion

		#region CTor
		public KalturaPartnerUsage()
		{
		}

		public KalturaPartnerUsage(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "hostingGB":
						this.HostingGB = ParseFloat(txt);
						continue;
					case "Percent":
						this.Percent = ParseFloat(txt);
						continue;
					case "packageBW":
						this.PackageBW = ParseInt(txt);
						continue;
					case "usageGB":
						this.UsageGB = ParseInt(txt);
						continue;
					case "reachedLimitDate":
						this.ReachedLimitDate = ParseInt(txt);
						continue;
					case "usageGraph":
						this.UsageGraph = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddFloatIfNotNull("hostingGB", this.HostingGB);
			kparams.AddFloatIfNotNull("Percent", this.Percent);
			kparams.AddIntIfNotNull("packageBW", this.PackageBW);
			kparams.AddIntIfNotNull("usageGB", this.UsageGB);
			kparams.AddIntIfNotNull("reachedLimitDate", this.ReachedLimitDate);
			kparams.AddStringIfNotNull("usageGraph", this.UsageGraph);
			return kparams;
		}
		#endregion
	}
}

