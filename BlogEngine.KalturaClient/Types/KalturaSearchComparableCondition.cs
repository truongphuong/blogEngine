using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSearchComparableCondition : KalturaSearchCondition
	{
		#region Private Fields
		private KalturaSearchConditionComparison _Comparison = (KalturaSearchConditionComparison)Int32.MinValue;
		#endregion

		#region Properties
		public KalturaSearchConditionComparison Comparison
		{
			get { return _Comparison; }
			set 
			{ 
				_Comparison = value;
				OnPropertyChanged("Comparison");
			}
		}
		#endregion

		#region CTor
		public KalturaSearchComparableCondition()
		{
		}

		public KalturaSearchComparableCondition(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "comparison":
						this.Comparison = (KalturaSearchConditionComparison)ParseEnum(typeof(KalturaSearchConditionComparison), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddEnumIfNotNull("comparison", this.Comparison);
			return kparams;
		}
		#endregion
	}
}

