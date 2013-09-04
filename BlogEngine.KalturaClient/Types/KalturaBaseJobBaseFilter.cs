using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaBaseJobBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private int _IdGreaterThanOrEqual = Int32.MinValue;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private string _PartnerIdNotIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _ProcessorExpirationGreaterThanOrEqual = Int32.MinValue;
		private int _ProcessorExpirationLessThanOrEqual = Int32.MinValue;
		private int _ExecutionAttemptsGreaterThanOrEqual = Int32.MinValue;
		private int _ExecutionAttemptsLessThanOrEqual = Int32.MinValue;
		private int _LockVersionGreaterThanOrEqual = Int32.MinValue;
		private int _LockVersionLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		public int IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		public int IdGreaterThanOrEqual
		{
			get { return _IdGreaterThanOrEqual; }
			set 
			{ 
				_IdGreaterThanOrEqual = value;
				OnPropertyChanged("IdGreaterThanOrEqual");
			}
		}
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public string PartnerIdIn
		{
			get { return _PartnerIdIn; }
			set 
			{ 
				_PartnerIdIn = value;
				OnPropertyChanged("PartnerIdIn");
			}
		}
		public string PartnerIdNotIn
		{
			get { return _PartnerIdNotIn; }
			set 
			{ 
				_PartnerIdNotIn = value;
				OnPropertyChanged("PartnerIdNotIn");
			}
		}
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		public int ProcessorExpirationGreaterThanOrEqual
		{
			get { return _ProcessorExpirationGreaterThanOrEqual; }
			set 
			{ 
				_ProcessorExpirationGreaterThanOrEqual = value;
				OnPropertyChanged("ProcessorExpirationGreaterThanOrEqual");
			}
		}
		public int ProcessorExpirationLessThanOrEqual
		{
			get { return _ProcessorExpirationLessThanOrEqual; }
			set 
			{ 
				_ProcessorExpirationLessThanOrEqual = value;
				OnPropertyChanged("ProcessorExpirationLessThanOrEqual");
			}
		}
		public int ExecutionAttemptsGreaterThanOrEqual
		{
			get { return _ExecutionAttemptsGreaterThanOrEqual; }
			set 
			{ 
				_ExecutionAttemptsGreaterThanOrEqual = value;
				OnPropertyChanged("ExecutionAttemptsGreaterThanOrEqual");
			}
		}
		public int ExecutionAttemptsLessThanOrEqual
		{
			get { return _ExecutionAttemptsLessThanOrEqual; }
			set 
			{ 
				_ExecutionAttemptsLessThanOrEqual = value;
				OnPropertyChanged("ExecutionAttemptsLessThanOrEqual");
			}
		}
		public int LockVersionGreaterThanOrEqual
		{
			get { return _LockVersionGreaterThanOrEqual; }
			set 
			{ 
				_LockVersionGreaterThanOrEqual = value;
				OnPropertyChanged("LockVersionGreaterThanOrEqual");
			}
		}
		public int LockVersionLessThanOrEqual
		{
			get { return _LockVersionLessThanOrEqual; }
			set 
			{ 
				_LockVersionLessThanOrEqual = value;
				OnPropertyChanged("LockVersionLessThanOrEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaBaseJobBaseFilter()
		{
		}

		public KalturaBaseJobBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this.IdEqual = ParseInt(txt);
						continue;
					case "idGreaterThanOrEqual":
						this.IdGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "partnerIdEqual":
						this.PartnerIdEqual = ParseInt(txt);
						continue;
					case "partnerIdIn":
						this.PartnerIdIn = txt;
						continue;
					case "partnerIdNotIn":
						this.PartnerIdNotIn = txt;
						continue;
					case "createdAtGreaterThanOrEqual":
						this.CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this.CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this.UpdatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtLessThanOrEqual":
						this.UpdatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "processorExpirationGreaterThanOrEqual":
						this.ProcessorExpirationGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "processorExpirationLessThanOrEqual":
						this.ProcessorExpirationLessThanOrEqual = ParseInt(txt);
						continue;
					case "executionAttemptsGreaterThanOrEqual":
						this.ExecutionAttemptsGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "executionAttemptsLessThanOrEqual":
						this.ExecutionAttemptsLessThanOrEqual = ParseInt(txt);
						continue;
					case "lockVersionGreaterThanOrEqual":
						this.LockVersionGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "lockVersionLessThanOrEqual":
						this.LockVersionLessThanOrEqual = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("idEqual", this.IdEqual);
			kparams.AddIntIfNotNull("idGreaterThanOrEqual", this.IdGreaterThanOrEqual);
			kparams.AddIntIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddStringIfNotNull("partnerIdIn", this.PartnerIdIn);
			kparams.AddStringIfNotNull("partnerIdNotIn", this.PartnerIdNotIn);
			kparams.AddIntIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("processorExpirationGreaterThanOrEqual", this.ProcessorExpirationGreaterThanOrEqual);
			kparams.AddIntIfNotNull("processorExpirationLessThanOrEqual", this.ProcessorExpirationLessThanOrEqual);
			kparams.AddIntIfNotNull("executionAttemptsGreaterThanOrEqual", this.ExecutionAttemptsGreaterThanOrEqual);
			kparams.AddIntIfNotNull("executionAttemptsLessThanOrEqual", this.ExecutionAttemptsLessThanOrEqual);
			kparams.AddIntIfNotNull("lockVersionGreaterThanOrEqual", this.LockVersionGreaterThanOrEqual);
			kparams.AddIntIfNotNull("lockVersionLessThanOrEqual", this.LockVersionLessThanOrEqual);
			return kparams;
		}
		#endregion
	}
}

