using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaStatsEvent : KalturaObjectBase
	{
		#region Private Fields
		private string _ClientVer = null;
		private KalturaStatsEventType _EventType = (KalturaStatsEventType)Int32.MinValue;
		private float _EventTimestamp = Single.MinValue;
		private string _SessionId = null;
		private int _PartnerId = Int32.MinValue;
		private string _EntryId = null;
		private string _UniqueViewer = null;
		private string _WidgetId = null;
		private int _UiconfId = Int32.MinValue;
		private string _UserId = null;
		private int _CurrentPoint = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		private string _UserIp = null;
		private int _ProcessDuration = Int32.MinValue;
		private string _ControlId = null;
		private bool? _Seek = false;
		private int _NewPoint = Int32.MinValue;
		private string _Referrer = null;
		private bool? _IsFirstInSession = false;
		#endregion

		#region Properties
		public string ClientVer
		{
			get { return _ClientVer; }
			set 
			{ 
				_ClientVer = value;
				OnPropertyChanged("ClientVer");
			}
		}
		public KalturaStatsEventType EventType
		{
			get { return _EventType; }
			set 
			{ 
				_EventType = value;
				OnPropertyChanged("EventType");
			}
		}
		public float EventTimestamp
		{
			get { return _EventTimestamp; }
			set 
			{ 
				_EventTimestamp = value;
				OnPropertyChanged("EventTimestamp");
			}
		}
		public string SessionId
		{
			get { return _SessionId; }
			set 
			{ 
				_SessionId = value;
				OnPropertyChanged("SessionId");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public string UniqueViewer
		{
			get { return _UniqueViewer; }
			set 
			{ 
				_UniqueViewer = value;
				OnPropertyChanged("UniqueViewer");
			}
		}
		public string WidgetId
		{
			get { return _WidgetId; }
			set 
			{ 
				_WidgetId = value;
				OnPropertyChanged("WidgetId");
			}
		}
		public int UiconfId
		{
			get { return _UiconfId; }
			set 
			{ 
				_UiconfId = value;
				OnPropertyChanged("UiconfId");
			}
		}
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		public int CurrentPoint
		{
			get { return _CurrentPoint; }
			set 
			{ 
				_CurrentPoint = value;
				OnPropertyChanged("CurrentPoint");
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
		public string UserIp
		{
			get { return _UserIp; }
			set 
			{ 
				_UserIp = value;
				OnPropertyChanged("UserIp");
			}
		}
		public int ProcessDuration
		{
			get { return _ProcessDuration; }
			set 
			{ 
				_ProcessDuration = value;
				OnPropertyChanged("ProcessDuration");
			}
		}
		public string ControlId
		{
			get { return _ControlId; }
			set 
			{ 
				_ControlId = value;
				OnPropertyChanged("ControlId");
			}
		}
		public bool? Seek
		{
			get { return _Seek; }
			set 
			{ 
				_Seek = value;
				OnPropertyChanged("Seek");
			}
		}
		public int NewPoint
		{
			get { return _NewPoint; }
			set 
			{ 
				_NewPoint = value;
				OnPropertyChanged("NewPoint");
			}
		}
		public string Referrer
		{
			get { return _Referrer; }
			set 
			{ 
				_Referrer = value;
				OnPropertyChanged("Referrer");
			}
		}
		public bool? IsFirstInSession
		{
			get { return _IsFirstInSession; }
			set 
			{ 
				_IsFirstInSession = value;
				OnPropertyChanged("IsFirstInSession");
			}
		}
		#endregion

		#region CTor
		public KalturaStatsEvent()
		{
		}

		public KalturaStatsEvent(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "clientVer":
						this.ClientVer = txt;
						continue;
					case "eventType":
						this.EventType = (KalturaStatsEventType)ParseEnum(typeof(KalturaStatsEventType), txt);
						continue;
					case "eventTimestamp":
						this.EventTimestamp = ParseFloat(txt);
						continue;
					case "sessionId":
						this.SessionId = txt;
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "entryId":
						this.EntryId = txt;
						continue;
					case "uniqueViewer":
						this.UniqueViewer = txt;
						continue;
					case "widgetId":
						this.WidgetId = txt;
						continue;
					case "uiconfId":
						this.UiconfId = ParseInt(txt);
						continue;
					case "userId":
						this.UserId = txt;
						continue;
					case "currentPoint":
						this.CurrentPoint = ParseInt(txt);
						continue;
					case "duration":
						this.Duration = ParseInt(txt);
						continue;
					case "userIp":
						this.UserIp = txt;
						continue;
					case "processDuration":
						this.ProcessDuration = ParseInt(txt);
						continue;
					case "controlId":
						this.ControlId = txt;
						continue;
					case "seek":
						this.Seek = ParseBool(txt);
						continue;
					case "newPoint":
						this.NewPoint = ParseInt(txt);
						continue;
					case "referrer":
						this.Referrer = txt;
						continue;
					case "isFirstInSession":
						this.IsFirstInSession = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("clientVer", this.ClientVer);
			kparams.AddEnumIfNotNull("eventType", this.EventType);
			kparams.AddFloatIfNotNull("eventTimestamp", this.EventTimestamp);
			kparams.AddStringIfNotNull("sessionId", this.SessionId);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddStringIfNotNull("entryId", this.EntryId);
			kparams.AddStringIfNotNull("uniqueViewer", this.UniqueViewer);
			kparams.AddStringIfNotNull("widgetId", this.WidgetId);
			kparams.AddIntIfNotNull("uiconfId", this.UiconfId);
			kparams.AddStringIfNotNull("userId", this.UserId);
			kparams.AddIntIfNotNull("currentPoint", this.CurrentPoint);
			kparams.AddIntIfNotNull("duration", this.Duration);
			kparams.AddStringIfNotNull("userIp", this.UserIp);
			kparams.AddIntIfNotNull("processDuration", this.ProcessDuration);
			kparams.AddStringIfNotNull("controlId", this.ControlId);
			kparams.AddBoolIfNotNull("seek", this.Seek);
			kparams.AddIntIfNotNull("newPoint", this.NewPoint);
			kparams.AddStringIfNotNull("referrer", this.Referrer);
			kparams.AddBoolIfNotNull("isFirstInSession", this.IsFirstInSession);
			return kparams;
		}
		#endregion
	}
}

