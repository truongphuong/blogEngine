using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDwhHourlyPartnerBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _PartnerIdEqual = Int32.MinValue;
		private int _AggregatedTimeLessThanOrEqual = Int32.MinValue;
		private int _AggregatedTimeGreaterThanOrEqual = Int32.MinValue;
		private float _SumTimeViewedLessThanOrEqual = Single.MinValue;
		private float _SumTimeViewedGreaterThanOrEqual = Single.MinValue;
		private float _AverageTimeViewedLessThanOrEqual = Single.MinValue;
		private float _AverageTimeViewedGreaterThanOrEqual = Single.MinValue;
		private int _CountPlaysLessThanOrEqual = Int32.MinValue;
		private int _CountPlaysGreaterThanOrEqual = Int32.MinValue;
		private int _CountLoadsLessThanOrEqual = Int32.MinValue;
		private int _CountLoadsGreaterThanOrEqual = Int32.MinValue;
		private int _CountPlays25LessThanOrEqual = Int32.MinValue;
		private int _CountPlays25GreaterThanOrEqual = Int32.MinValue;
		private int _CountPlays50LessThanOrEqual = Int32.MinValue;
		private int _CountPlays50GreaterThanOrEqual = Int32.MinValue;
		private int _CountPlays75LessThanOrEqual = Int32.MinValue;
		private int _CountPlays75GreaterThanOrEqual = Int32.MinValue;
		private int _CountPlays100LessThanOrEqual = Int32.MinValue;
		private int _CountPlays100GreaterThanOrEqual = Int32.MinValue;
		private int _CountEditLessThanOrEqual = Int32.MinValue;
		private int _CountEditGreaterThanOrEqual = Int32.MinValue;
		private int _CountSharesLessThanOrEqual = Int32.MinValue;
		private int _CountSharesGreaterThanOrEqual = Int32.MinValue;
		private int _CountDownloadLessThanOrEqual = Int32.MinValue;
		private int _CountDownloadGreaterThanOrEqual = Int32.MinValue;
		private int _CountReportAbuseLessThanOrEqual = Int32.MinValue;
		private int _CountReportAbuseGreaterThanOrEqual = Int32.MinValue;
		private int _CountMediaEntriesLessThanOrEqual = Int32.MinValue;
		private int _CountMediaEntriesGreaterThanOrEqual = Int32.MinValue;
		private int _CountVideoEntriesLessThanOrEqual = Int32.MinValue;
		private int _CountVideoEntriesGreaterThanOrEqual = Int32.MinValue;
		private int _CountImageEntriesLessThanOrEqual = Int32.MinValue;
		private int _CountImageEntriesGreaterThanOrEqual = Int32.MinValue;
		private int _CountAudioEntriesLessThanOrEqual = Int32.MinValue;
		private int _CountAudioEntriesGreaterThanOrEqual = Int32.MinValue;
		private int _CountMixEntriesLessThanOrEqual = Int32.MinValue;
		private int _CountMixEntriesGreaterThanOrEqual = Int32.MinValue;
		private int _CountPlaylistsLessThanOrEqual = Int32.MinValue;
		private int _CountPlaylistsGreaterThanOrEqual = Int32.MinValue;
		private string _CountBandwidthLessThanOrEqual = null;
		private string _CountBandwidthGreaterThanOrEqual = null;
		private string _CountStorageLessThanOrEqual = null;
		private string _CountStorageGreaterThanOrEqual = null;
		private int _CountUsersLessThanOrEqual = Int32.MinValue;
		private int _CountUsersGreaterThanOrEqual = Int32.MinValue;
		private int _CountWidgetsLessThanOrEqual = Int32.MinValue;
		private int _CountWidgetsGreaterThanOrEqual = Int32.MinValue;
		private string _AggregatedStorageLessThanOrEqual = null;
		private string _AggregatedStorageGreaterThanOrEqual = null;
		private string _AggregatedBandwidthLessThanOrEqual = null;
		private string _AggregatedBandwidthGreaterThanOrEqual = null;
		private int _CountBufferStartLessThanOrEqual = Int32.MinValue;
		private int _CountBufferStartGreaterThanOrEqual = Int32.MinValue;
		private int _CountBufferEndLessThanOrEqual = Int32.MinValue;
		private int _CountBufferEndGreaterThanOrEqual = Int32.MinValue;
		private int _CountOpenFullScreenLessThanOrEqual = Int32.MinValue;
		private int _CountOpenFullScreenGreaterThanOrEqual = Int32.MinValue;
		private int _CountCloseFullScreenLessThanOrEqual = Int32.MinValue;
		private int _CountCloseFullScreenGreaterThanOrEqual = Int32.MinValue;
		private int _CountReplayLessThanOrEqual = Int32.MinValue;
		private int _CountReplayGreaterThanOrEqual = Int32.MinValue;
		private int _CountSeekLessThanOrEqual = Int32.MinValue;
		private int _CountSeekGreaterThanOrEqual = Int32.MinValue;
		private int _CountOpenUploadLessThanOrEqual = Int32.MinValue;
		private int _CountOpenUploadGreaterThanOrEqual = Int32.MinValue;
		private int _CountSavePublishLessThanOrEqual = Int32.MinValue;
		private int _CountSavePublishGreaterThanOrEqual = Int32.MinValue;
		private int _CountCloseEditorLessThanOrEqual = Int32.MinValue;
		private int _CountCloseEditorGreaterThanOrEqual = Int32.MinValue;
		private int _CountPreBumperPlayedLessThanOrEqual = Int32.MinValue;
		private int _CountPreBumperPlayedGreaterThanOrEqual = Int32.MinValue;
		private int _CountPostBumperPlayedLessThanOrEqual = Int32.MinValue;
		private int _CountPostBumperPlayedGreaterThanOrEqual = Int32.MinValue;
		private int _CountBumperClickedLessThanOrEqual = Int32.MinValue;
		private int _CountBumperClickedGreaterThanOrEqual = Int32.MinValue;
		private int _CountPrerollStartedLessThanOrEqual = Int32.MinValue;
		private int _CountPrerollStartedGreaterThanOrEqual = Int32.MinValue;
		private int _CountMidrollStartedLessThanOrEqual = Int32.MinValue;
		private int _CountMidrollStartedGreaterThanOrEqual = Int32.MinValue;
		private int _CountPostrollStartedLessThanOrEqual = Int32.MinValue;
		private int _CountPostrollStartedGreaterThanOrEqual = Int32.MinValue;
		private int _CountOverlayStartedLessThanOrEqual = Int32.MinValue;
		private int _CountOverlayStartedGreaterThanOrEqual = Int32.MinValue;
		private int _CountPrerollClickedLessThanOrEqual = Int32.MinValue;
		private int _CountPrerollClickedGreaterThanOrEqual = Int32.MinValue;
		private int _CountMidrollClickedLessThanOrEqual = Int32.MinValue;
		private int _CountMidrollClickedGreaterThanOrEqual = Int32.MinValue;
		private int _CountPostrollClickedLessThanOrEqual = Int32.MinValue;
		private int _CountPostrollClickedGreaterThanOrEqual = Int32.MinValue;
		private int _CountOverlayClickedLessThanOrEqual = Int32.MinValue;
		private int _CountOverlayClickedGreaterThanOrEqual = Int32.MinValue;
		private int _CountPreroll25LessThanOrEqual = Int32.MinValue;
		private int _CountPreroll25GreaterThanOrEqual = Int32.MinValue;
		private int _CountPreroll50LessThanOrEqual = Int32.MinValue;
		private int _CountPreroll50GreaterThanOrEqual = Int32.MinValue;
		private int _CountPreroll75LessThanOrEqual = Int32.MinValue;
		private int _CountPreroll75GreaterThanOrEqual = Int32.MinValue;
		private int _CountMidroll25LessThanOrEqual = Int32.MinValue;
		private int _CountMidroll25GreaterThanOrEqual = Int32.MinValue;
		private int _CountMidroll50LessThanOrEqual = Int32.MinValue;
		private int _CountMidroll50GreaterThanOrEqual = Int32.MinValue;
		private int _CountMidroll75LessThanOrEqual = Int32.MinValue;
		private int _CountMidroll75GreaterThanOrEqual = Int32.MinValue;
		private int _CountPostroll25LessThanOrEqual = Int32.MinValue;
		private int _CountPostroll25GreaterThanOrEqual = Int32.MinValue;
		private int _CountPostroll50LessThanOrEqual = Int32.MinValue;
		private int _CountPostroll50GreaterThanOrEqual = Int32.MinValue;
		private int _CountPostroll75LessThanOrEqual = Int32.MinValue;
		private int _CountPostroll75GreaterThanOrEqual = Int32.MinValue;
		private string _CountLiveStreamingBandwidthLessThanOrEqual = null;
		private string _CountLiveStreamingBandwidthGreaterThanOrEqual = null;
		private string _AggregatedLiveStreamingBandwidthLessThanOrEqual = null;
		private string _AggregatedLiveStreamingBandwidthGreaterThanOrEqual = null;
		#endregion

		#region Properties
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public int AggregatedTimeLessThanOrEqual
		{
			get { return _AggregatedTimeLessThanOrEqual; }
			set 
			{ 
				_AggregatedTimeLessThanOrEqual = value;
				OnPropertyChanged("AggregatedTimeLessThanOrEqual");
			}
		}
		public int AggregatedTimeGreaterThanOrEqual
		{
			get { return _AggregatedTimeGreaterThanOrEqual; }
			set 
			{ 
				_AggregatedTimeGreaterThanOrEqual = value;
				OnPropertyChanged("AggregatedTimeGreaterThanOrEqual");
			}
		}
		public float SumTimeViewedLessThanOrEqual
		{
			get { return _SumTimeViewedLessThanOrEqual; }
			set 
			{ 
				_SumTimeViewedLessThanOrEqual = value;
				OnPropertyChanged("SumTimeViewedLessThanOrEqual");
			}
		}
		public float SumTimeViewedGreaterThanOrEqual
		{
			get { return _SumTimeViewedGreaterThanOrEqual; }
			set 
			{ 
				_SumTimeViewedGreaterThanOrEqual = value;
				OnPropertyChanged("SumTimeViewedGreaterThanOrEqual");
			}
		}
		public float AverageTimeViewedLessThanOrEqual
		{
			get { return _AverageTimeViewedLessThanOrEqual; }
			set 
			{ 
				_AverageTimeViewedLessThanOrEqual = value;
				OnPropertyChanged("AverageTimeViewedLessThanOrEqual");
			}
		}
		public float AverageTimeViewedGreaterThanOrEqual
		{
			get { return _AverageTimeViewedGreaterThanOrEqual; }
			set 
			{ 
				_AverageTimeViewedGreaterThanOrEqual = value;
				OnPropertyChanged("AverageTimeViewedGreaterThanOrEqual");
			}
		}
		public int CountPlaysLessThanOrEqual
		{
			get { return _CountPlaysLessThanOrEqual; }
			set 
			{ 
				_CountPlaysLessThanOrEqual = value;
				OnPropertyChanged("CountPlaysLessThanOrEqual");
			}
		}
		public int CountPlaysGreaterThanOrEqual
		{
			get { return _CountPlaysGreaterThanOrEqual; }
			set 
			{ 
				_CountPlaysGreaterThanOrEqual = value;
				OnPropertyChanged("CountPlaysGreaterThanOrEqual");
			}
		}
		public int CountLoadsLessThanOrEqual
		{
			get { return _CountLoadsLessThanOrEqual; }
			set 
			{ 
				_CountLoadsLessThanOrEqual = value;
				OnPropertyChanged("CountLoadsLessThanOrEqual");
			}
		}
		public int CountLoadsGreaterThanOrEqual
		{
			get { return _CountLoadsGreaterThanOrEqual; }
			set 
			{ 
				_CountLoadsGreaterThanOrEqual = value;
				OnPropertyChanged("CountLoadsGreaterThanOrEqual");
			}
		}
		public int CountPlays25LessThanOrEqual
		{
			get { return _CountPlays25LessThanOrEqual; }
			set 
			{ 
				_CountPlays25LessThanOrEqual = value;
				OnPropertyChanged("CountPlays25LessThanOrEqual");
			}
		}
		public int CountPlays25GreaterThanOrEqual
		{
			get { return _CountPlays25GreaterThanOrEqual; }
			set 
			{ 
				_CountPlays25GreaterThanOrEqual = value;
				OnPropertyChanged("CountPlays25GreaterThanOrEqual");
			}
		}
		public int CountPlays50LessThanOrEqual
		{
			get { return _CountPlays50LessThanOrEqual; }
			set 
			{ 
				_CountPlays50LessThanOrEqual = value;
				OnPropertyChanged("CountPlays50LessThanOrEqual");
			}
		}
		public int CountPlays50GreaterThanOrEqual
		{
			get { return _CountPlays50GreaterThanOrEqual; }
			set 
			{ 
				_CountPlays50GreaterThanOrEqual = value;
				OnPropertyChanged("CountPlays50GreaterThanOrEqual");
			}
		}
		public int CountPlays75LessThanOrEqual
		{
			get { return _CountPlays75LessThanOrEqual; }
			set 
			{ 
				_CountPlays75LessThanOrEqual = value;
				OnPropertyChanged("CountPlays75LessThanOrEqual");
			}
		}
		public int CountPlays75GreaterThanOrEqual
		{
			get { return _CountPlays75GreaterThanOrEqual; }
			set 
			{ 
				_CountPlays75GreaterThanOrEqual = value;
				OnPropertyChanged("CountPlays75GreaterThanOrEqual");
			}
		}
		public int CountPlays100LessThanOrEqual
		{
			get { return _CountPlays100LessThanOrEqual; }
			set 
			{ 
				_CountPlays100LessThanOrEqual = value;
				OnPropertyChanged("CountPlays100LessThanOrEqual");
			}
		}
		public int CountPlays100GreaterThanOrEqual
		{
			get { return _CountPlays100GreaterThanOrEqual; }
			set 
			{ 
				_CountPlays100GreaterThanOrEqual = value;
				OnPropertyChanged("CountPlays100GreaterThanOrEqual");
			}
		}
		public int CountEditLessThanOrEqual
		{
			get { return _CountEditLessThanOrEqual; }
			set 
			{ 
				_CountEditLessThanOrEqual = value;
				OnPropertyChanged("CountEditLessThanOrEqual");
			}
		}
		public int CountEditGreaterThanOrEqual
		{
			get { return _CountEditGreaterThanOrEqual; }
			set 
			{ 
				_CountEditGreaterThanOrEqual = value;
				OnPropertyChanged("CountEditGreaterThanOrEqual");
			}
		}
		public int CountSharesLessThanOrEqual
		{
			get { return _CountSharesLessThanOrEqual; }
			set 
			{ 
				_CountSharesLessThanOrEqual = value;
				OnPropertyChanged("CountSharesLessThanOrEqual");
			}
		}
		public int CountSharesGreaterThanOrEqual
		{
			get { return _CountSharesGreaterThanOrEqual; }
			set 
			{ 
				_CountSharesGreaterThanOrEqual = value;
				OnPropertyChanged("CountSharesGreaterThanOrEqual");
			}
		}
		public int CountDownloadLessThanOrEqual
		{
			get { return _CountDownloadLessThanOrEqual; }
			set 
			{ 
				_CountDownloadLessThanOrEqual = value;
				OnPropertyChanged("CountDownloadLessThanOrEqual");
			}
		}
		public int CountDownloadGreaterThanOrEqual
		{
			get { return _CountDownloadGreaterThanOrEqual; }
			set 
			{ 
				_CountDownloadGreaterThanOrEqual = value;
				OnPropertyChanged("CountDownloadGreaterThanOrEqual");
			}
		}
		public int CountReportAbuseLessThanOrEqual
		{
			get { return _CountReportAbuseLessThanOrEqual; }
			set 
			{ 
				_CountReportAbuseLessThanOrEqual = value;
				OnPropertyChanged("CountReportAbuseLessThanOrEqual");
			}
		}
		public int CountReportAbuseGreaterThanOrEqual
		{
			get { return _CountReportAbuseGreaterThanOrEqual; }
			set 
			{ 
				_CountReportAbuseGreaterThanOrEqual = value;
				OnPropertyChanged("CountReportAbuseGreaterThanOrEqual");
			}
		}
		public int CountMediaEntriesLessThanOrEqual
		{
			get { return _CountMediaEntriesLessThanOrEqual; }
			set 
			{ 
				_CountMediaEntriesLessThanOrEqual = value;
				OnPropertyChanged("CountMediaEntriesLessThanOrEqual");
			}
		}
		public int CountMediaEntriesGreaterThanOrEqual
		{
			get { return _CountMediaEntriesGreaterThanOrEqual; }
			set 
			{ 
				_CountMediaEntriesGreaterThanOrEqual = value;
				OnPropertyChanged("CountMediaEntriesGreaterThanOrEqual");
			}
		}
		public int CountVideoEntriesLessThanOrEqual
		{
			get { return _CountVideoEntriesLessThanOrEqual; }
			set 
			{ 
				_CountVideoEntriesLessThanOrEqual = value;
				OnPropertyChanged("CountVideoEntriesLessThanOrEqual");
			}
		}
		public int CountVideoEntriesGreaterThanOrEqual
		{
			get { return _CountVideoEntriesGreaterThanOrEqual; }
			set 
			{ 
				_CountVideoEntriesGreaterThanOrEqual = value;
				OnPropertyChanged("CountVideoEntriesGreaterThanOrEqual");
			}
		}
		public int CountImageEntriesLessThanOrEqual
		{
			get { return _CountImageEntriesLessThanOrEqual; }
			set 
			{ 
				_CountImageEntriesLessThanOrEqual = value;
				OnPropertyChanged("CountImageEntriesLessThanOrEqual");
			}
		}
		public int CountImageEntriesGreaterThanOrEqual
		{
			get { return _CountImageEntriesGreaterThanOrEqual; }
			set 
			{ 
				_CountImageEntriesGreaterThanOrEqual = value;
				OnPropertyChanged("CountImageEntriesGreaterThanOrEqual");
			}
		}
		public int CountAudioEntriesLessThanOrEqual
		{
			get { return _CountAudioEntriesLessThanOrEqual; }
			set 
			{ 
				_CountAudioEntriesLessThanOrEqual = value;
				OnPropertyChanged("CountAudioEntriesLessThanOrEqual");
			}
		}
		public int CountAudioEntriesGreaterThanOrEqual
		{
			get { return _CountAudioEntriesGreaterThanOrEqual; }
			set 
			{ 
				_CountAudioEntriesGreaterThanOrEqual = value;
				OnPropertyChanged("CountAudioEntriesGreaterThanOrEqual");
			}
		}
		public int CountMixEntriesLessThanOrEqual
		{
			get { return _CountMixEntriesLessThanOrEqual; }
			set 
			{ 
				_CountMixEntriesLessThanOrEqual = value;
				OnPropertyChanged("CountMixEntriesLessThanOrEqual");
			}
		}
		public int CountMixEntriesGreaterThanOrEqual
		{
			get { return _CountMixEntriesGreaterThanOrEqual; }
			set 
			{ 
				_CountMixEntriesGreaterThanOrEqual = value;
				OnPropertyChanged("CountMixEntriesGreaterThanOrEqual");
			}
		}
		public int CountPlaylistsLessThanOrEqual
		{
			get { return _CountPlaylistsLessThanOrEqual; }
			set 
			{ 
				_CountPlaylistsLessThanOrEqual = value;
				OnPropertyChanged("CountPlaylistsLessThanOrEqual");
			}
		}
		public int CountPlaylistsGreaterThanOrEqual
		{
			get { return _CountPlaylistsGreaterThanOrEqual; }
			set 
			{ 
				_CountPlaylistsGreaterThanOrEqual = value;
				OnPropertyChanged("CountPlaylistsGreaterThanOrEqual");
			}
		}
		public string CountBandwidthLessThanOrEqual
		{
			get { return _CountBandwidthLessThanOrEqual; }
			set 
			{ 
				_CountBandwidthLessThanOrEqual = value;
				OnPropertyChanged("CountBandwidthLessThanOrEqual");
			}
		}
		public string CountBandwidthGreaterThanOrEqual
		{
			get { return _CountBandwidthGreaterThanOrEqual; }
			set 
			{ 
				_CountBandwidthGreaterThanOrEqual = value;
				OnPropertyChanged("CountBandwidthGreaterThanOrEqual");
			}
		}
		public string CountStorageLessThanOrEqual
		{
			get { return _CountStorageLessThanOrEqual; }
			set 
			{ 
				_CountStorageLessThanOrEqual = value;
				OnPropertyChanged("CountStorageLessThanOrEqual");
			}
		}
		public string CountStorageGreaterThanOrEqual
		{
			get { return _CountStorageGreaterThanOrEqual; }
			set 
			{ 
				_CountStorageGreaterThanOrEqual = value;
				OnPropertyChanged("CountStorageGreaterThanOrEqual");
			}
		}
		public int CountUsersLessThanOrEqual
		{
			get { return _CountUsersLessThanOrEqual; }
			set 
			{ 
				_CountUsersLessThanOrEqual = value;
				OnPropertyChanged("CountUsersLessThanOrEqual");
			}
		}
		public int CountUsersGreaterThanOrEqual
		{
			get { return _CountUsersGreaterThanOrEqual; }
			set 
			{ 
				_CountUsersGreaterThanOrEqual = value;
				OnPropertyChanged("CountUsersGreaterThanOrEqual");
			}
		}
		public int CountWidgetsLessThanOrEqual
		{
			get { return _CountWidgetsLessThanOrEqual; }
			set 
			{ 
				_CountWidgetsLessThanOrEqual = value;
				OnPropertyChanged("CountWidgetsLessThanOrEqual");
			}
		}
		public int CountWidgetsGreaterThanOrEqual
		{
			get { return _CountWidgetsGreaterThanOrEqual; }
			set 
			{ 
				_CountWidgetsGreaterThanOrEqual = value;
				OnPropertyChanged("CountWidgetsGreaterThanOrEqual");
			}
		}
		public string AggregatedStorageLessThanOrEqual
		{
			get { return _AggregatedStorageLessThanOrEqual; }
			set 
			{ 
				_AggregatedStorageLessThanOrEqual = value;
				OnPropertyChanged("AggregatedStorageLessThanOrEqual");
			}
		}
		public string AggregatedStorageGreaterThanOrEqual
		{
			get { return _AggregatedStorageGreaterThanOrEqual; }
			set 
			{ 
				_AggregatedStorageGreaterThanOrEqual = value;
				OnPropertyChanged("AggregatedStorageGreaterThanOrEqual");
			}
		}
		public string AggregatedBandwidthLessThanOrEqual
		{
			get { return _AggregatedBandwidthLessThanOrEqual; }
			set 
			{ 
				_AggregatedBandwidthLessThanOrEqual = value;
				OnPropertyChanged("AggregatedBandwidthLessThanOrEqual");
			}
		}
		public string AggregatedBandwidthGreaterThanOrEqual
		{
			get { return _AggregatedBandwidthGreaterThanOrEqual; }
			set 
			{ 
				_AggregatedBandwidthGreaterThanOrEqual = value;
				OnPropertyChanged("AggregatedBandwidthGreaterThanOrEqual");
			}
		}
		public int CountBufferStartLessThanOrEqual
		{
			get { return _CountBufferStartLessThanOrEqual; }
			set 
			{ 
				_CountBufferStartLessThanOrEqual = value;
				OnPropertyChanged("CountBufferStartLessThanOrEqual");
			}
		}
		public int CountBufferStartGreaterThanOrEqual
		{
			get { return _CountBufferStartGreaterThanOrEqual; }
			set 
			{ 
				_CountBufferStartGreaterThanOrEqual = value;
				OnPropertyChanged("CountBufferStartGreaterThanOrEqual");
			}
		}
		public int CountBufferEndLessThanOrEqual
		{
			get { return _CountBufferEndLessThanOrEqual; }
			set 
			{ 
				_CountBufferEndLessThanOrEqual = value;
				OnPropertyChanged("CountBufferEndLessThanOrEqual");
			}
		}
		public int CountBufferEndGreaterThanOrEqual
		{
			get { return _CountBufferEndGreaterThanOrEqual; }
			set 
			{ 
				_CountBufferEndGreaterThanOrEqual = value;
				OnPropertyChanged("CountBufferEndGreaterThanOrEqual");
			}
		}
		public int CountOpenFullScreenLessThanOrEqual
		{
			get { return _CountOpenFullScreenLessThanOrEqual; }
			set 
			{ 
				_CountOpenFullScreenLessThanOrEqual = value;
				OnPropertyChanged("CountOpenFullScreenLessThanOrEqual");
			}
		}
		public int CountOpenFullScreenGreaterThanOrEqual
		{
			get { return _CountOpenFullScreenGreaterThanOrEqual; }
			set 
			{ 
				_CountOpenFullScreenGreaterThanOrEqual = value;
				OnPropertyChanged("CountOpenFullScreenGreaterThanOrEqual");
			}
		}
		public int CountCloseFullScreenLessThanOrEqual
		{
			get { return _CountCloseFullScreenLessThanOrEqual; }
			set 
			{ 
				_CountCloseFullScreenLessThanOrEqual = value;
				OnPropertyChanged("CountCloseFullScreenLessThanOrEqual");
			}
		}
		public int CountCloseFullScreenGreaterThanOrEqual
		{
			get { return _CountCloseFullScreenGreaterThanOrEqual; }
			set 
			{ 
				_CountCloseFullScreenGreaterThanOrEqual = value;
				OnPropertyChanged("CountCloseFullScreenGreaterThanOrEqual");
			}
		}
		public int CountReplayLessThanOrEqual
		{
			get { return _CountReplayLessThanOrEqual; }
			set 
			{ 
				_CountReplayLessThanOrEqual = value;
				OnPropertyChanged("CountReplayLessThanOrEqual");
			}
		}
		public int CountReplayGreaterThanOrEqual
		{
			get { return _CountReplayGreaterThanOrEqual; }
			set 
			{ 
				_CountReplayGreaterThanOrEqual = value;
				OnPropertyChanged("CountReplayGreaterThanOrEqual");
			}
		}
		public int CountSeekLessThanOrEqual
		{
			get { return _CountSeekLessThanOrEqual; }
			set 
			{ 
				_CountSeekLessThanOrEqual = value;
				OnPropertyChanged("CountSeekLessThanOrEqual");
			}
		}
		public int CountSeekGreaterThanOrEqual
		{
			get { return _CountSeekGreaterThanOrEqual; }
			set 
			{ 
				_CountSeekGreaterThanOrEqual = value;
				OnPropertyChanged("CountSeekGreaterThanOrEqual");
			}
		}
		public int CountOpenUploadLessThanOrEqual
		{
			get { return _CountOpenUploadLessThanOrEqual; }
			set 
			{ 
				_CountOpenUploadLessThanOrEqual = value;
				OnPropertyChanged("CountOpenUploadLessThanOrEqual");
			}
		}
		public int CountOpenUploadGreaterThanOrEqual
		{
			get { return _CountOpenUploadGreaterThanOrEqual; }
			set 
			{ 
				_CountOpenUploadGreaterThanOrEqual = value;
				OnPropertyChanged("CountOpenUploadGreaterThanOrEqual");
			}
		}
		public int CountSavePublishLessThanOrEqual
		{
			get { return _CountSavePublishLessThanOrEqual; }
			set 
			{ 
				_CountSavePublishLessThanOrEqual = value;
				OnPropertyChanged("CountSavePublishLessThanOrEqual");
			}
		}
		public int CountSavePublishGreaterThanOrEqual
		{
			get { return _CountSavePublishGreaterThanOrEqual; }
			set 
			{ 
				_CountSavePublishGreaterThanOrEqual = value;
				OnPropertyChanged("CountSavePublishGreaterThanOrEqual");
			}
		}
		public int CountCloseEditorLessThanOrEqual
		{
			get { return _CountCloseEditorLessThanOrEqual; }
			set 
			{ 
				_CountCloseEditorLessThanOrEqual = value;
				OnPropertyChanged("CountCloseEditorLessThanOrEqual");
			}
		}
		public int CountCloseEditorGreaterThanOrEqual
		{
			get { return _CountCloseEditorGreaterThanOrEqual; }
			set 
			{ 
				_CountCloseEditorGreaterThanOrEqual = value;
				OnPropertyChanged("CountCloseEditorGreaterThanOrEqual");
			}
		}
		public int CountPreBumperPlayedLessThanOrEqual
		{
			get { return _CountPreBumperPlayedLessThanOrEqual; }
			set 
			{ 
				_CountPreBumperPlayedLessThanOrEqual = value;
				OnPropertyChanged("CountPreBumperPlayedLessThanOrEqual");
			}
		}
		public int CountPreBumperPlayedGreaterThanOrEqual
		{
			get { return _CountPreBumperPlayedGreaterThanOrEqual; }
			set 
			{ 
				_CountPreBumperPlayedGreaterThanOrEqual = value;
				OnPropertyChanged("CountPreBumperPlayedGreaterThanOrEqual");
			}
		}
		public int CountPostBumperPlayedLessThanOrEqual
		{
			get { return _CountPostBumperPlayedLessThanOrEqual; }
			set 
			{ 
				_CountPostBumperPlayedLessThanOrEqual = value;
				OnPropertyChanged("CountPostBumperPlayedLessThanOrEqual");
			}
		}
		public int CountPostBumperPlayedGreaterThanOrEqual
		{
			get { return _CountPostBumperPlayedGreaterThanOrEqual; }
			set 
			{ 
				_CountPostBumperPlayedGreaterThanOrEqual = value;
				OnPropertyChanged("CountPostBumperPlayedGreaterThanOrEqual");
			}
		}
		public int CountBumperClickedLessThanOrEqual
		{
			get { return _CountBumperClickedLessThanOrEqual; }
			set 
			{ 
				_CountBumperClickedLessThanOrEqual = value;
				OnPropertyChanged("CountBumperClickedLessThanOrEqual");
			}
		}
		public int CountBumperClickedGreaterThanOrEqual
		{
			get { return _CountBumperClickedGreaterThanOrEqual; }
			set 
			{ 
				_CountBumperClickedGreaterThanOrEqual = value;
				OnPropertyChanged("CountBumperClickedGreaterThanOrEqual");
			}
		}
		public int CountPrerollStartedLessThanOrEqual
		{
			get { return _CountPrerollStartedLessThanOrEqual; }
			set 
			{ 
				_CountPrerollStartedLessThanOrEqual = value;
				OnPropertyChanged("CountPrerollStartedLessThanOrEqual");
			}
		}
		public int CountPrerollStartedGreaterThanOrEqual
		{
			get { return _CountPrerollStartedGreaterThanOrEqual; }
			set 
			{ 
				_CountPrerollStartedGreaterThanOrEqual = value;
				OnPropertyChanged("CountPrerollStartedGreaterThanOrEqual");
			}
		}
		public int CountMidrollStartedLessThanOrEqual
		{
			get { return _CountMidrollStartedLessThanOrEqual; }
			set 
			{ 
				_CountMidrollStartedLessThanOrEqual = value;
				OnPropertyChanged("CountMidrollStartedLessThanOrEqual");
			}
		}
		public int CountMidrollStartedGreaterThanOrEqual
		{
			get { return _CountMidrollStartedGreaterThanOrEqual; }
			set 
			{ 
				_CountMidrollStartedGreaterThanOrEqual = value;
				OnPropertyChanged("CountMidrollStartedGreaterThanOrEqual");
			}
		}
		public int CountPostrollStartedLessThanOrEqual
		{
			get { return _CountPostrollStartedLessThanOrEqual; }
			set 
			{ 
				_CountPostrollStartedLessThanOrEqual = value;
				OnPropertyChanged("CountPostrollStartedLessThanOrEqual");
			}
		}
		public int CountPostrollStartedGreaterThanOrEqual
		{
			get { return _CountPostrollStartedGreaterThanOrEqual; }
			set 
			{ 
				_CountPostrollStartedGreaterThanOrEqual = value;
				OnPropertyChanged("CountPostrollStartedGreaterThanOrEqual");
			}
		}
		public int CountOverlayStartedLessThanOrEqual
		{
			get { return _CountOverlayStartedLessThanOrEqual; }
			set 
			{ 
				_CountOverlayStartedLessThanOrEqual = value;
				OnPropertyChanged("CountOverlayStartedLessThanOrEqual");
			}
		}
		public int CountOverlayStartedGreaterThanOrEqual
		{
			get { return _CountOverlayStartedGreaterThanOrEqual; }
			set 
			{ 
				_CountOverlayStartedGreaterThanOrEqual = value;
				OnPropertyChanged("CountOverlayStartedGreaterThanOrEqual");
			}
		}
		public int CountPrerollClickedLessThanOrEqual
		{
			get { return _CountPrerollClickedLessThanOrEqual; }
			set 
			{ 
				_CountPrerollClickedLessThanOrEqual = value;
				OnPropertyChanged("CountPrerollClickedLessThanOrEqual");
			}
		}
		public int CountPrerollClickedGreaterThanOrEqual
		{
			get { return _CountPrerollClickedGreaterThanOrEqual; }
			set 
			{ 
				_CountPrerollClickedGreaterThanOrEqual = value;
				OnPropertyChanged("CountPrerollClickedGreaterThanOrEqual");
			}
		}
		public int CountMidrollClickedLessThanOrEqual
		{
			get { return _CountMidrollClickedLessThanOrEqual; }
			set 
			{ 
				_CountMidrollClickedLessThanOrEqual = value;
				OnPropertyChanged("CountMidrollClickedLessThanOrEqual");
			}
		}
		public int CountMidrollClickedGreaterThanOrEqual
		{
			get { return _CountMidrollClickedGreaterThanOrEqual; }
			set 
			{ 
				_CountMidrollClickedGreaterThanOrEqual = value;
				OnPropertyChanged("CountMidrollClickedGreaterThanOrEqual");
			}
		}
		public int CountPostrollClickedLessThanOrEqual
		{
			get { return _CountPostrollClickedLessThanOrEqual; }
			set 
			{ 
				_CountPostrollClickedLessThanOrEqual = value;
				OnPropertyChanged("CountPostrollClickedLessThanOrEqual");
			}
		}
		public int CountPostrollClickedGreaterThanOrEqual
		{
			get { return _CountPostrollClickedGreaterThanOrEqual; }
			set 
			{ 
				_CountPostrollClickedGreaterThanOrEqual = value;
				OnPropertyChanged("CountPostrollClickedGreaterThanOrEqual");
			}
		}
		public int CountOverlayClickedLessThanOrEqual
		{
			get { return _CountOverlayClickedLessThanOrEqual; }
			set 
			{ 
				_CountOverlayClickedLessThanOrEqual = value;
				OnPropertyChanged("CountOverlayClickedLessThanOrEqual");
			}
		}
		public int CountOverlayClickedGreaterThanOrEqual
		{
			get { return _CountOverlayClickedGreaterThanOrEqual; }
			set 
			{ 
				_CountOverlayClickedGreaterThanOrEqual = value;
				OnPropertyChanged("CountOverlayClickedGreaterThanOrEqual");
			}
		}
		public int CountPreroll25LessThanOrEqual
		{
			get { return _CountPreroll25LessThanOrEqual; }
			set 
			{ 
				_CountPreroll25LessThanOrEqual = value;
				OnPropertyChanged("CountPreroll25LessThanOrEqual");
			}
		}
		public int CountPreroll25GreaterThanOrEqual
		{
			get { return _CountPreroll25GreaterThanOrEqual; }
			set 
			{ 
				_CountPreroll25GreaterThanOrEqual = value;
				OnPropertyChanged("CountPreroll25GreaterThanOrEqual");
			}
		}
		public int CountPreroll50LessThanOrEqual
		{
			get { return _CountPreroll50LessThanOrEqual; }
			set 
			{ 
				_CountPreroll50LessThanOrEqual = value;
				OnPropertyChanged("CountPreroll50LessThanOrEqual");
			}
		}
		public int CountPreroll50GreaterThanOrEqual
		{
			get { return _CountPreroll50GreaterThanOrEqual; }
			set 
			{ 
				_CountPreroll50GreaterThanOrEqual = value;
				OnPropertyChanged("CountPreroll50GreaterThanOrEqual");
			}
		}
		public int CountPreroll75LessThanOrEqual
		{
			get { return _CountPreroll75LessThanOrEqual; }
			set 
			{ 
				_CountPreroll75LessThanOrEqual = value;
				OnPropertyChanged("CountPreroll75LessThanOrEqual");
			}
		}
		public int CountPreroll75GreaterThanOrEqual
		{
			get { return _CountPreroll75GreaterThanOrEqual; }
			set 
			{ 
				_CountPreroll75GreaterThanOrEqual = value;
				OnPropertyChanged("CountPreroll75GreaterThanOrEqual");
			}
		}
		public int CountMidroll25LessThanOrEqual
		{
			get { return _CountMidroll25LessThanOrEqual; }
			set 
			{ 
				_CountMidroll25LessThanOrEqual = value;
				OnPropertyChanged("CountMidroll25LessThanOrEqual");
			}
		}
		public int CountMidroll25GreaterThanOrEqual
		{
			get { return _CountMidroll25GreaterThanOrEqual; }
			set 
			{ 
				_CountMidroll25GreaterThanOrEqual = value;
				OnPropertyChanged("CountMidroll25GreaterThanOrEqual");
			}
		}
		public int CountMidroll50LessThanOrEqual
		{
			get { return _CountMidroll50LessThanOrEqual; }
			set 
			{ 
				_CountMidroll50LessThanOrEqual = value;
				OnPropertyChanged("CountMidroll50LessThanOrEqual");
			}
		}
		public int CountMidroll50GreaterThanOrEqual
		{
			get { return _CountMidroll50GreaterThanOrEqual; }
			set 
			{ 
				_CountMidroll50GreaterThanOrEqual = value;
				OnPropertyChanged("CountMidroll50GreaterThanOrEqual");
			}
		}
		public int CountMidroll75LessThanOrEqual
		{
			get { return _CountMidroll75LessThanOrEqual; }
			set 
			{ 
				_CountMidroll75LessThanOrEqual = value;
				OnPropertyChanged("CountMidroll75LessThanOrEqual");
			}
		}
		public int CountMidroll75GreaterThanOrEqual
		{
			get { return _CountMidroll75GreaterThanOrEqual; }
			set 
			{ 
				_CountMidroll75GreaterThanOrEqual = value;
				OnPropertyChanged("CountMidroll75GreaterThanOrEqual");
			}
		}
		public int CountPostroll25LessThanOrEqual
		{
			get { return _CountPostroll25LessThanOrEqual; }
			set 
			{ 
				_CountPostroll25LessThanOrEqual = value;
				OnPropertyChanged("CountPostroll25LessThanOrEqual");
			}
		}
		public int CountPostroll25GreaterThanOrEqual
		{
			get { return _CountPostroll25GreaterThanOrEqual; }
			set 
			{ 
				_CountPostroll25GreaterThanOrEqual = value;
				OnPropertyChanged("CountPostroll25GreaterThanOrEqual");
			}
		}
		public int CountPostroll50LessThanOrEqual
		{
			get { return _CountPostroll50LessThanOrEqual; }
			set 
			{ 
				_CountPostroll50LessThanOrEqual = value;
				OnPropertyChanged("CountPostroll50LessThanOrEqual");
			}
		}
		public int CountPostroll50GreaterThanOrEqual
		{
			get { return _CountPostroll50GreaterThanOrEqual; }
			set 
			{ 
				_CountPostroll50GreaterThanOrEqual = value;
				OnPropertyChanged("CountPostroll50GreaterThanOrEqual");
			}
		}
		public int CountPostroll75LessThanOrEqual
		{
			get { return _CountPostroll75LessThanOrEqual; }
			set 
			{ 
				_CountPostroll75LessThanOrEqual = value;
				OnPropertyChanged("CountPostroll75LessThanOrEqual");
			}
		}
		public int CountPostroll75GreaterThanOrEqual
		{
			get { return _CountPostroll75GreaterThanOrEqual; }
			set 
			{ 
				_CountPostroll75GreaterThanOrEqual = value;
				OnPropertyChanged("CountPostroll75GreaterThanOrEqual");
			}
		}
		public string CountLiveStreamingBandwidthLessThanOrEqual
		{
			get { return _CountLiveStreamingBandwidthLessThanOrEqual; }
			set 
			{ 
				_CountLiveStreamingBandwidthLessThanOrEqual = value;
				OnPropertyChanged("CountLiveStreamingBandwidthLessThanOrEqual");
			}
		}
		public string CountLiveStreamingBandwidthGreaterThanOrEqual
		{
			get { return _CountLiveStreamingBandwidthGreaterThanOrEqual; }
			set 
			{ 
				_CountLiveStreamingBandwidthGreaterThanOrEqual = value;
				OnPropertyChanged("CountLiveStreamingBandwidthGreaterThanOrEqual");
			}
		}
		public string AggregatedLiveStreamingBandwidthLessThanOrEqual
		{
			get { return _AggregatedLiveStreamingBandwidthLessThanOrEqual; }
			set 
			{ 
				_AggregatedLiveStreamingBandwidthLessThanOrEqual = value;
				OnPropertyChanged("AggregatedLiveStreamingBandwidthLessThanOrEqual");
			}
		}
		public string AggregatedLiveStreamingBandwidthGreaterThanOrEqual
		{
			get { return _AggregatedLiveStreamingBandwidthGreaterThanOrEqual; }
			set 
			{ 
				_AggregatedLiveStreamingBandwidthGreaterThanOrEqual = value;
				OnPropertyChanged("AggregatedLiveStreamingBandwidthGreaterThanOrEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaDwhHourlyPartnerBaseFilter()
		{
		}

		public KalturaDwhHourlyPartnerBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "partnerIdEqual":
						this.PartnerIdEqual = ParseInt(txt);
						continue;
					case "aggregatedTimeLessThanOrEqual":
						this.AggregatedTimeLessThanOrEqual = ParseInt(txt);
						continue;
					case "aggregatedTimeGreaterThanOrEqual":
						this.AggregatedTimeGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "sumTimeViewedLessThanOrEqual":
						this.SumTimeViewedLessThanOrEqual = ParseFloat(txt);
						continue;
					case "sumTimeViewedGreaterThanOrEqual":
						this.SumTimeViewedGreaterThanOrEqual = ParseFloat(txt);
						continue;
					case "averageTimeViewedLessThanOrEqual":
						this.AverageTimeViewedLessThanOrEqual = ParseFloat(txt);
						continue;
					case "averageTimeViewedGreaterThanOrEqual":
						this.AverageTimeViewedGreaterThanOrEqual = ParseFloat(txt);
						continue;
					case "countPlaysLessThanOrEqual":
						this.CountPlaysLessThanOrEqual = ParseInt(txt);
						continue;
					case "countPlaysGreaterThanOrEqual":
						this.CountPlaysGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countLoadsLessThanOrEqual":
						this.CountLoadsLessThanOrEqual = ParseInt(txt);
						continue;
					case "countLoadsGreaterThanOrEqual":
						this.CountLoadsGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countPlays25LessThanOrEqual":
						this.CountPlays25LessThanOrEqual = ParseInt(txt);
						continue;
					case "countPlays25GreaterThanOrEqual":
						this.CountPlays25GreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countPlays50LessThanOrEqual":
						this.CountPlays50LessThanOrEqual = ParseInt(txt);
						continue;
					case "countPlays50GreaterThanOrEqual":
						this.CountPlays50GreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countPlays75LessThanOrEqual":
						this.CountPlays75LessThanOrEqual = ParseInt(txt);
						continue;
					case "countPlays75GreaterThanOrEqual":
						this.CountPlays75GreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countPlays100LessThanOrEqual":
						this.CountPlays100LessThanOrEqual = ParseInt(txt);
						continue;
					case "countPlays100GreaterThanOrEqual":
						this.CountPlays100GreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countEditLessThanOrEqual":
						this.CountEditLessThanOrEqual = ParseInt(txt);
						continue;
					case "countEditGreaterThanOrEqual":
						this.CountEditGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countSharesLessThanOrEqual":
						this.CountSharesLessThanOrEqual = ParseInt(txt);
						continue;
					case "countSharesGreaterThanOrEqual":
						this.CountSharesGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countDownloadLessThanOrEqual":
						this.CountDownloadLessThanOrEqual = ParseInt(txt);
						continue;
					case "countDownloadGreaterThanOrEqual":
						this.CountDownloadGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countReportAbuseLessThanOrEqual":
						this.CountReportAbuseLessThanOrEqual = ParseInt(txt);
						continue;
					case "countReportAbuseGreaterThanOrEqual":
						this.CountReportAbuseGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countMediaEntriesLessThanOrEqual":
						this.CountMediaEntriesLessThanOrEqual = ParseInt(txt);
						continue;
					case "countMediaEntriesGreaterThanOrEqual":
						this.CountMediaEntriesGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countVideoEntriesLessThanOrEqual":
						this.CountVideoEntriesLessThanOrEqual = ParseInt(txt);
						continue;
					case "countVideoEntriesGreaterThanOrEqual":
						this.CountVideoEntriesGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countImageEntriesLessThanOrEqual":
						this.CountImageEntriesLessThanOrEqual = ParseInt(txt);
						continue;
					case "countImageEntriesGreaterThanOrEqual":
						this.CountImageEntriesGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countAudioEntriesLessThanOrEqual":
						this.CountAudioEntriesLessThanOrEqual = ParseInt(txt);
						continue;
					case "countAudioEntriesGreaterThanOrEqual":
						this.CountAudioEntriesGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countMixEntriesLessThanOrEqual":
						this.CountMixEntriesLessThanOrEqual = ParseInt(txt);
						continue;
					case "countMixEntriesGreaterThanOrEqual":
						this.CountMixEntriesGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countPlaylistsLessThanOrEqual":
						this.CountPlaylistsLessThanOrEqual = ParseInt(txt);
						continue;
					case "countPlaylistsGreaterThanOrEqual":
						this.CountPlaylistsGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countBandwidthLessThanOrEqual":
						this.CountBandwidthLessThanOrEqual = txt;
						continue;
					case "countBandwidthGreaterThanOrEqual":
						this.CountBandwidthGreaterThanOrEqual = txt;
						continue;
					case "countStorageLessThanOrEqual":
						this.CountStorageLessThanOrEqual = txt;
						continue;
					case "countStorageGreaterThanOrEqual":
						this.CountStorageGreaterThanOrEqual = txt;
						continue;
					case "countUsersLessThanOrEqual":
						this.CountUsersLessThanOrEqual = ParseInt(txt);
						continue;
					case "countUsersGreaterThanOrEqual":
						this.CountUsersGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countWidgetsLessThanOrEqual":
						this.CountWidgetsLessThanOrEqual = ParseInt(txt);
						continue;
					case "countWidgetsGreaterThanOrEqual":
						this.CountWidgetsGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "aggregatedStorageLessThanOrEqual":
						this.AggregatedStorageLessThanOrEqual = txt;
						continue;
					case "aggregatedStorageGreaterThanOrEqual":
						this.AggregatedStorageGreaterThanOrEqual = txt;
						continue;
					case "aggregatedBandwidthLessThanOrEqual":
						this.AggregatedBandwidthLessThanOrEqual = txt;
						continue;
					case "aggregatedBandwidthGreaterThanOrEqual":
						this.AggregatedBandwidthGreaterThanOrEqual = txt;
						continue;
					case "countBufferStartLessThanOrEqual":
						this.CountBufferStartLessThanOrEqual = ParseInt(txt);
						continue;
					case "countBufferStartGreaterThanOrEqual":
						this.CountBufferStartGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countBufferEndLessThanOrEqual":
						this.CountBufferEndLessThanOrEqual = ParseInt(txt);
						continue;
					case "countBufferEndGreaterThanOrEqual":
						this.CountBufferEndGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countOpenFullScreenLessThanOrEqual":
						this.CountOpenFullScreenLessThanOrEqual = ParseInt(txt);
						continue;
					case "countOpenFullScreenGreaterThanOrEqual":
						this.CountOpenFullScreenGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countCloseFullScreenLessThanOrEqual":
						this.CountCloseFullScreenLessThanOrEqual = ParseInt(txt);
						continue;
					case "countCloseFullScreenGreaterThanOrEqual":
						this.CountCloseFullScreenGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countReplayLessThanOrEqual":
						this.CountReplayLessThanOrEqual = ParseInt(txt);
						continue;
					case "countReplayGreaterThanOrEqual":
						this.CountReplayGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countSeekLessThanOrEqual":
						this.CountSeekLessThanOrEqual = ParseInt(txt);
						continue;
					case "countSeekGreaterThanOrEqual":
						this.CountSeekGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countOpenUploadLessThanOrEqual":
						this.CountOpenUploadLessThanOrEqual = ParseInt(txt);
						continue;
					case "countOpenUploadGreaterThanOrEqual":
						this.CountOpenUploadGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countSavePublishLessThanOrEqual":
						this.CountSavePublishLessThanOrEqual = ParseInt(txt);
						continue;
					case "countSavePublishGreaterThanOrEqual":
						this.CountSavePublishGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countCloseEditorLessThanOrEqual":
						this.CountCloseEditorLessThanOrEqual = ParseInt(txt);
						continue;
					case "countCloseEditorGreaterThanOrEqual":
						this.CountCloseEditorGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countPreBumperPlayedLessThanOrEqual":
						this.CountPreBumperPlayedLessThanOrEqual = ParseInt(txt);
						continue;
					case "countPreBumperPlayedGreaterThanOrEqual":
						this.CountPreBumperPlayedGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countPostBumperPlayedLessThanOrEqual":
						this.CountPostBumperPlayedLessThanOrEqual = ParseInt(txt);
						continue;
					case "countPostBumperPlayedGreaterThanOrEqual":
						this.CountPostBumperPlayedGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countBumperClickedLessThanOrEqual":
						this.CountBumperClickedLessThanOrEqual = ParseInt(txt);
						continue;
					case "countBumperClickedGreaterThanOrEqual":
						this.CountBumperClickedGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countPrerollStartedLessThanOrEqual":
						this.CountPrerollStartedLessThanOrEqual = ParseInt(txt);
						continue;
					case "countPrerollStartedGreaterThanOrEqual":
						this.CountPrerollStartedGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countMidrollStartedLessThanOrEqual":
						this.CountMidrollStartedLessThanOrEqual = ParseInt(txt);
						continue;
					case "countMidrollStartedGreaterThanOrEqual":
						this.CountMidrollStartedGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countPostrollStartedLessThanOrEqual":
						this.CountPostrollStartedLessThanOrEqual = ParseInt(txt);
						continue;
					case "countPostrollStartedGreaterThanOrEqual":
						this.CountPostrollStartedGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countOverlayStartedLessThanOrEqual":
						this.CountOverlayStartedLessThanOrEqual = ParseInt(txt);
						continue;
					case "countOverlayStartedGreaterThanOrEqual":
						this.CountOverlayStartedGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countPrerollClickedLessThanOrEqual":
						this.CountPrerollClickedLessThanOrEqual = ParseInt(txt);
						continue;
					case "countPrerollClickedGreaterThanOrEqual":
						this.CountPrerollClickedGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countMidrollClickedLessThanOrEqual":
						this.CountMidrollClickedLessThanOrEqual = ParseInt(txt);
						continue;
					case "countMidrollClickedGreaterThanOrEqual":
						this.CountMidrollClickedGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countPostrollClickedLessThanOrEqual":
						this.CountPostrollClickedLessThanOrEqual = ParseInt(txt);
						continue;
					case "countPostrollClickedGreaterThanOrEqual":
						this.CountPostrollClickedGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countOverlayClickedLessThanOrEqual":
						this.CountOverlayClickedLessThanOrEqual = ParseInt(txt);
						continue;
					case "countOverlayClickedGreaterThanOrEqual":
						this.CountOverlayClickedGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countPreroll25LessThanOrEqual":
						this.CountPreroll25LessThanOrEqual = ParseInt(txt);
						continue;
					case "countPreroll25GreaterThanOrEqual":
						this.CountPreroll25GreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countPreroll50LessThanOrEqual":
						this.CountPreroll50LessThanOrEqual = ParseInt(txt);
						continue;
					case "countPreroll50GreaterThanOrEqual":
						this.CountPreroll50GreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countPreroll75LessThanOrEqual":
						this.CountPreroll75LessThanOrEqual = ParseInt(txt);
						continue;
					case "countPreroll75GreaterThanOrEqual":
						this.CountPreroll75GreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countMidroll25LessThanOrEqual":
						this.CountMidroll25LessThanOrEqual = ParseInt(txt);
						continue;
					case "countMidroll25GreaterThanOrEqual":
						this.CountMidroll25GreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countMidroll50LessThanOrEqual":
						this.CountMidroll50LessThanOrEqual = ParseInt(txt);
						continue;
					case "countMidroll50GreaterThanOrEqual":
						this.CountMidroll50GreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countMidroll75LessThanOrEqual":
						this.CountMidroll75LessThanOrEqual = ParseInt(txt);
						continue;
					case "countMidroll75GreaterThanOrEqual":
						this.CountMidroll75GreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countPostroll25LessThanOrEqual":
						this.CountPostroll25LessThanOrEqual = ParseInt(txt);
						continue;
					case "countPostroll25GreaterThanOrEqual":
						this.CountPostroll25GreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countPostroll50LessThanOrEqual":
						this.CountPostroll50LessThanOrEqual = ParseInt(txt);
						continue;
					case "countPostroll50GreaterThanOrEqual":
						this.CountPostroll50GreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countPostroll75LessThanOrEqual":
						this.CountPostroll75LessThanOrEqual = ParseInt(txt);
						continue;
					case "countPostroll75GreaterThanOrEqual":
						this.CountPostroll75GreaterThanOrEqual = ParseInt(txt);
						continue;
					case "countLiveStreamingBandwidthLessThanOrEqual":
						this.CountLiveStreamingBandwidthLessThanOrEqual = txt;
						continue;
					case "countLiveStreamingBandwidthGreaterThanOrEqual":
						this.CountLiveStreamingBandwidthGreaterThanOrEqual = txt;
						continue;
					case "aggregatedLiveStreamingBandwidthLessThanOrEqual":
						this.AggregatedLiveStreamingBandwidthLessThanOrEqual = txt;
						continue;
					case "aggregatedLiveStreamingBandwidthGreaterThanOrEqual":
						this.AggregatedLiveStreamingBandwidthGreaterThanOrEqual = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddIntIfNotNull("aggregatedTimeLessThanOrEqual", this.AggregatedTimeLessThanOrEqual);
			kparams.AddIntIfNotNull("aggregatedTimeGreaterThanOrEqual", this.AggregatedTimeGreaterThanOrEqual);
			kparams.AddFloatIfNotNull("sumTimeViewedLessThanOrEqual", this.SumTimeViewedLessThanOrEqual);
			kparams.AddFloatIfNotNull("sumTimeViewedGreaterThanOrEqual", this.SumTimeViewedGreaterThanOrEqual);
			kparams.AddFloatIfNotNull("averageTimeViewedLessThanOrEqual", this.AverageTimeViewedLessThanOrEqual);
			kparams.AddFloatIfNotNull("averageTimeViewedGreaterThanOrEqual", this.AverageTimeViewedGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countPlaysLessThanOrEqual", this.CountPlaysLessThanOrEqual);
			kparams.AddIntIfNotNull("countPlaysGreaterThanOrEqual", this.CountPlaysGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countLoadsLessThanOrEqual", this.CountLoadsLessThanOrEqual);
			kparams.AddIntIfNotNull("countLoadsGreaterThanOrEqual", this.CountLoadsGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countPlays25LessThanOrEqual", this.CountPlays25LessThanOrEqual);
			kparams.AddIntIfNotNull("countPlays25GreaterThanOrEqual", this.CountPlays25GreaterThanOrEqual);
			kparams.AddIntIfNotNull("countPlays50LessThanOrEqual", this.CountPlays50LessThanOrEqual);
			kparams.AddIntIfNotNull("countPlays50GreaterThanOrEqual", this.CountPlays50GreaterThanOrEqual);
			kparams.AddIntIfNotNull("countPlays75LessThanOrEqual", this.CountPlays75LessThanOrEqual);
			kparams.AddIntIfNotNull("countPlays75GreaterThanOrEqual", this.CountPlays75GreaterThanOrEqual);
			kparams.AddIntIfNotNull("countPlays100LessThanOrEqual", this.CountPlays100LessThanOrEqual);
			kparams.AddIntIfNotNull("countPlays100GreaterThanOrEqual", this.CountPlays100GreaterThanOrEqual);
			kparams.AddIntIfNotNull("countEditLessThanOrEqual", this.CountEditLessThanOrEqual);
			kparams.AddIntIfNotNull("countEditGreaterThanOrEqual", this.CountEditGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countSharesLessThanOrEqual", this.CountSharesLessThanOrEqual);
			kparams.AddIntIfNotNull("countSharesGreaterThanOrEqual", this.CountSharesGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countDownloadLessThanOrEqual", this.CountDownloadLessThanOrEqual);
			kparams.AddIntIfNotNull("countDownloadGreaterThanOrEqual", this.CountDownloadGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countReportAbuseLessThanOrEqual", this.CountReportAbuseLessThanOrEqual);
			kparams.AddIntIfNotNull("countReportAbuseGreaterThanOrEqual", this.CountReportAbuseGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countMediaEntriesLessThanOrEqual", this.CountMediaEntriesLessThanOrEqual);
			kparams.AddIntIfNotNull("countMediaEntriesGreaterThanOrEqual", this.CountMediaEntriesGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countVideoEntriesLessThanOrEqual", this.CountVideoEntriesLessThanOrEqual);
			kparams.AddIntIfNotNull("countVideoEntriesGreaterThanOrEqual", this.CountVideoEntriesGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countImageEntriesLessThanOrEqual", this.CountImageEntriesLessThanOrEqual);
			kparams.AddIntIfNotNull("countImageEntriesGreaterThanOrEqual", this.CountImageEntriesGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countAudioEntriesLessThanOrEqual", this.CountAudioEntriesLessThanOrEqual);
			kparams.AddIntIfNotNull("countAudioEntriesGreaterThanOrEqual", this.CountAudioEntriesGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countMixEntriesLessThanOrEqual", this.CountMixEntriesLessThanOrEqual);
			kparams.AddIntIfNotNull("countMixEntriesGreaterThanOrEqual", this.CountMixEntriesGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countPlaylistsLessThanOrEqual", this.CountPlaylistsLessThanOrEqual);
			kparams.AddIntIfNotNull("countPlaylistsGreaterThanOrEqual", this.CountPlaylistsGreaterThanOrEqual);
			kparams.AddStringIfNotNull("countBandwidthLessThanOrEqual", this.CountBandwidthLessThanOrEqual);
			kparams.AddStringIfNotNull("countBandwidthGreaterThanOrEqual", this.CountBandwidthGreaterThanOrEqual);
			kparams.AddStringIfNotNull("countStorageLessThanOrEqual", this.CountStorageLessThanOrEqual);
			kparams.AddStringIfNotNull("countStorageGreaterThanOrEqual", this.CountStorageGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countUsersLessThanOrEqual", this.CountUsersLessThanOrEqual);
			kparams.AddIntIfNotNull("countUsersGreaterThanOrEqual", this.CountUsersGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countWidgetsLessThanOrEqual", this.CountWidgetsLessThanOrEqual);
			kparams.AddIntIfNotNull("countWidgetsGreaterThanOrEqual", this.CountWidgetsGreaterThanOrEqual);
			kparams.AddStringIfNotNull("aggregatedStorageLessThanOrEqual", this.AggregatedStorageLessThanOrEqual);
			kparams.AddStringIfNotNull("aggregatedStorageGreaterThanOrEqual", this.AggregatedStorageGreaterThanOrEqual);
			kparams.AddStringIfNotNull("aggregatedBandwidthLessThanOrEqual", this.AggregatedBandwidthLessThanOrEqual);
			kparams.AddStringIfNotNull("aggregatedBandwidthGreaterThanOrEqual", this.AggregatedBandwidthGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countBufferStartLessThanOrEqual", this.CountBufferStartLessThanOrEqual);
			kparams.AddIntIfNotNull("countBufferStartGreaterThanOrEqual", this.CountBufferStartGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countBufferEndLessThanOrEqual", this.CountBufferEndLessThanOrEqual);
			kparams.AddIntIfNotNull("countBufferEndGreaterThanOrEqual", this.CountBufferEndGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countOpenFullScreenLessThanOrEqual", this.CountOpenFullScreenLessThanOrEqual);
			kparams.AddIntIfNotNull("countOpenFullScreenGreaterThanOrEqual", this.CountOpenFullScreenGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countCloseFullScreenLessThanOrEqual", this.CountCloseFullScreenLessThanOrEqual);
			kparams.AddIntIfNotNull("countCloseFullScreenGreaterThanOrEqual", this.CountCloseFullScreenGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countReplayLessThanOrEqual", this.CountReplayLessThanOrEqual);
			kparams.AddIntIfNotNull("countReplayGreaterThanOrEqual", this.CountReplayGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countSeekLessThanOrEqual", this.CountSeekLessThanOrEqual);
			kparams.AddIntIfNotNull("countSeekGreaterThanOrEqual", this.CountSeekGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countOpenUploadLessThanOrEqual", this.CountOpenUploadLessThanOrEqual);
			kparams.AddIntIfNotNull("countOpenUploadGreaterThanOrEqual", this.CountOpenUploadGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countSavePublishLessThanOrEqual", this.CountSavePublishLessThanOrEqual);
			kparams.AddIntIfNotNull("countSavePublishGreaterThanOrEqual", this.CountSavePublishGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countCloseEditorLessThanOrEqual", this.CountCloseEditorLessThanOrEqual);
			kparams.AddIntIfNotNull("countCloseEditorGreaterThanOrEqual", this.CountCloseEditorGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countPreBumperPlayedLessThanOrEqual", this.CountPreBumperPlayedLessThanOrEqual);
			kparams.AddIntIfNotNull("countPreBumperPlayedGreaterThanOrEqual", this.CountPreBumperPlayedGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countPostBumperPlayedLessThanOrEqual", this.CountPostBumperPlayedLessThanOrEqual);
			kparams.AddIntIfNotNull("countPostBumperPlayedGreaterThanOrEqual", this.CountPostBumperPlayedGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countBumperClickedLessThanOrEqual", this.CountBumperClickedLessThanOrEqual);
			kparams.AddIntIfNotNull("countBumperClickedGreaterThanOrEqual", this.CountBumperClickedGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countPrerollStartedLessThanOrEqual", this.CountPrerollStartedLessThanOrEqual);
			kparams.AddIntIfNotNull("countPrerollStartedGreaterThanOrEqual", this.CountPrerollStartedGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countMidrollStartedLessThanOrEqual", this.CountMidrollStartedLessThanOrEqual);
			kparams.AddIntIfNotNull("countMidrollStartedGreaterThanOrEqual", this.CountMidrollStartedGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countPostrollStartedLessThanOrEqual", this.CountPostrollStartedLessThanOrEqual);
			kparams.AddIntIfNotNull("countPostrollStartedGreaterThanOrEqual", this.CountPostrollStartedGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countOverlayStartedLessThanOrEqual", this.CountOverlayStartedLessThanOrEqual);
			kparams.AddIntIfNotNull("countOverlayStartedGreaterThanOrEqual", this.CountOverlayStartedGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countPrerollClickedLessThanOrEqual", this.CountPrerollClickedLessThanOrEqual);
			kparams.AddIntIfNotNull("countPrerollClickedGreaterThanOrEqual", this.CountPrerollClickedGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countMidrollClickedLessThanOrEqual", this.CountMidrollClickedLessThanOrEqual);
			kparams.AddIntIfNotNull("countMidrollClickedGreaterThanOrEqual", this.CountMidrollClickedGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countPostrollClickedLessThanOrEqual", this.CountPostrollClickedLessThanOrEqual);
			kparams.AddIntIfNotNull("countPostrollClickedGreaterThanOrEqual", this.CountPostrollClickedGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countOverlayClickedLessThanOrEqual", this.CountOverlayClickedLessThanOrEqual);
			kparams.AddIntIfNotNull("countOverlayClickedGreaterThanOrEqual", this.CountOverlayClickedGreaterThanOrEqual);
			kparams.AddIntIfNotNull("countPreroll25LessThanOrEqual", this.CountPreroll25LessThanOrEqual);
			kparams.AddIntIfNotNull("countPreroll25GreaterThanOrEqual", this.CountPreroll25GreaterThanOrEqual);
			kparams.AddIntIfNotNull("countPreroll50LessThanOrEqual", this.CountPreroll50LessThanOrEqual);
			kparams.AddIntIfNotNull("countPreroll50GreaterThanOrEqual", this.CountPreroll50GreaterThanOrEqual);
			kparams.AddIntIfNotNull("countPreroll75LessThanOrEqual", this.CountPreroll75LessThanOrEqual);
			kparams.AddIntIfNotNull("countPreroll75GreaterThanOrEqual", this.CountPreroll75GreaterThanOrEqual);
			kparams.AddIntIfNotNull("countMidroll25LessThanOrEqual", this.CountMidroll25LessThanOrEqual);
			kparams.AddIntIfNotNull("countMidroll25GreaterThanOrEqual", this.CountMidroll25GreaterThanOrEqual);
			kparams.AddIntIfNotNull("countMidroll50LessThanOrEqual", this.CountMidroll50LessThanOrEqual);
			kparams.AddIntIfNotNull("countMidroll50GreaterThanOrEqual", this.CountMidroll50GreaterThanOrEqual);
			kparams.AddIntIfNotNull("countMidroll75LessThanOrEqual", this.CountMidroll75LessThanOrEqual);
			kparams.AddIntIfNotNull("countMidroll75GreaterThanOrEqual", this.CountMidroll75GreaterThanOrEqual);
			kparams.AddIntIfNotNull("countPostroll25LessThanOrEqual", this.CountPostroll25LessThanOrEqual);
			kparams.AddIntIfNotNull("countPostroll25GreaterThanOrEqual", this.CountPostroll25GreaterThanOrEqual);
			kparams.AddIntIfNotNull("countPostroll50LessThanOrEqual", this.CountPostroll50LessThanOrEqual);
			kparams.AddIntIfNotNull("countPostroll50GreaterThanOrEqual", this.CountPostroll50GreaterThanOrEqual);
			kparams.AddIntIfNotNull("countPostroll75LessThanOrEqual", this.CountPostroll75LessThanOrEqual);
			kparams.AddIntIfNotNull("countPostroll75GreaterThanOrEqual", this.CountPostroll75GreaterThanOrEqual);
			kparams.AddStringIfNotNull("countLiveStreamingBandwidthLessThanOrEqual", this.CountLiveStreamingBandwidthLessThanOrEqual);
			kparams.AddStringIfNotNull("countLiveStreamingBandwidthGreaterThanOrEqual", this.CountLiveStreamingBandwidthGreaterThanOrEqual);
			kparams.AddStringIfNotNull("aggregatedLiveStreamingBandwidthLessThanOrEqual", this.AggregatedLiveStreamingBandwidthLessThanOrEqual);
			kparams.AddStringIfNotNull("aggregatedLiveStreamingBandwidthGreaterThanOrEqual", this.AggregatedLiveStreamingBandwidthGreaterThanOrEqual);
			return kparams;
		}
		#endregion
	}
}

