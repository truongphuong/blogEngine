using System;

namespace Kaltura
{
	public class KalturaClient : KalturaClientBase
	{
		public KalturaClient(KalturaConfiguration config)
			: base(config)
		{
				_ApiVersion = "3.1.4";
		}

		KalturaAccessControlService _AccessControlService;
		public KalturaAccessControlService AccessControlService
		{
			get
			{
				if (_AccessControlService == null)
					_AccessControlService = new KalturaAccessControlService(this);

				return _AccessControlService;
			}
		}

		KalturaAdminUserService _AdminUserService;
		public KalturaAdminUserService AdminUserService
		{
			get
			{
				if (_AdminUserService == null)
					_AdminUserService = new KalturaAdminUserService(this);

				return _AdminUserService;
			}
		}

		KalturaBaseEntryService _BaseEntryService;
		public KalturaBaseEntryService BaseEntryService
		{
			get
			{
				if (_BaseEntryService == null)
					_BaseEntryService = new KalturaBaseEntryService(this);

				return _BaseEntryService;
			}
		}

		KalturaBulkUploadService _BulkUploadService;
		public KalturaBulkUploadService BulkUploadService
		{
			get
			{
				if (_BulkUploadService == null)
					_BulkUploadService = new KalturaBulkUploadService(this);

				return _BulkUploadService;
			}
		}

		KalturaCategoryService _CategoryService;
		public KalturaCategoryService CategoryService
		{
			get
			{
				if (_CategoryService == null)
					_CategoryService = new KalturaCategoryService(this);

				return _CategoryService;
			}
		}

		KalturaConversionProfileAssetParamsService _ConversionProfileAssetParamsService;
		public KalturaConversionProfileAssetParamsService ConversionProfileAssetParamsService
		{
			get
			{
				if (_ConversionProfileAssetParamsService == null)
					_ConversionProfileAssetParamsService = new KalturaConversionProfileAssetParamsService(this);

				return _ConversionProfileAssetParamsService;
			}
		}

		KalturaConversionProfileService _ConversionProfileService;
		public KalturaConversionProfileService ConversionProfileService
		{
			get
			{
				if (_ConversionProfileService == null)
					_ConversionProfileService = new KalturaConversionProfileService(this);

				return _ConversionProfileService;
			}
		}

		KalturaDataService _DataService;
		public KalturaDataService DataService
		{
			get
			{
				if (_DataService == null)
					_DataService = new KalturaDataService(this);

				return _DataService;
			}
		}

		KalturaDocumentService _DocumentService;
		public KalturaDocumentService DocumentService
		{
			get
			{
				if (_DocumentService == null)
					_DocumentService = new KalturaDocumentService(this);

				return _DocumentService;
			}
		}

		KalturaEmailIngestionProfileService _EmailIngestionProfileService;
		public KalturaEmailIngestionProfileService EmailIngestionProfileService
		{
			get
			{
				if (_EmailIngestionProfileService == null)
					_EmailIngestionProfileService = new KalturaEmailIngestionProfileService(this);

				return _EmailIngestionProfileService;
			}
		}

		KalturaFlavorAssetService _FlavorAssetService;
		public KalturaFlavorAssetService FlavorAssetService
		{
			get
			{
				if (_FlavorAssetService == null)
					_FlavorAssetService = new KalturaFlavorAssetService(this);

				return _FlavorAssetService;
			}
		}

		KalturaFlavorParamsService _FlavorParamsService;
		public KalturaFlavorParamsService FlavorParamsService
		{
			get
			{
				if (_FlavorParamsService == null)
					_FlavorParamsService = new KalturaFlavorParamsService(this);

				return _FlavorParamsService;
			}
		}

		KalturaLiveStreamService _LiveStreamService;
		public KalturaLiveStreamService LiveStreamService
		{
			get
			{
				if (_LiveStreamService == null)
					_LiveStreamService = new KalturaLiveStreamService(this);

				return _LiveStreamService;
			}
		}

		KalturaMediaService _MediaService;
		public KalturaMediaService MediaService
		{
			get
			{
				if (_MediaService == null)
					_MediaService = new KalturaMediaService(this);

				return _MediaService;
			}
		}

		KalturaMixingService _MixingService;
		public KalturaMixingService MixingService
		{
			get
			{
				if (_MixingService == null)
					_MixingService = new KalturaMixingService(this);

				return _MixingService;
			}
		}

		KalturaNotificationService _NotificationService;
		public KalturaNotificationService NotificationService
		{
			get
			{
				if (_NotificationService == null)
					_NotificationService = new KalturaNotificationService(this);

				return _NotificationService;
			}
		}

		KalturaPartnerService _PartnerService;
		public KalturaPartnerService PartnerService
		{
			get
			{
				if (_PartnerService == null)
					_PartnerService = new KalturaPartnerService(this);

				return _PartnerService;
			}
		}

		KalturaPermissionItemService _PermissionItemService;
		public KalturaPermissionItemService PermissionItemService
		{
			get
			{
				if (_PermissionItemService == null)
					_PermissionItemService = new KalturaPermissionItemService(this);

				return _PermissionItemService;
			}
		}

		KalturaPermissionService _PermissionService;
		public KalturaPermissionService PermissionService
		{
			get
			{
				if (_PermissionService == null)
					_PermissionService = new KalturaPermissionService(this);

				return _PermissionService;
			}
		}

		KalturaPlaylistService _PlaylistService;
		public KalturaPlaylistService PlaylistService
		{
			get
			{
				if (_PlaylistService == null)
					_PlaylistService = new KalturaPlaylistService(this);

				return _PlaylistService;
			}
		}

		KalturaReportService _ReportService;
		public KalturaReportService ReportService
		{
			get
			{
				if (_ReportService == null)
					_ReportService = new KalturaReportService(this);

				return _ReportService;
			}
		}

		KalturaSchemaService _SchemaService;
		public KalturaSchemaService SchemaService
		{
			get
			{
				if (_SchemaService == null)
					_SchemaService = new KalturaSchemaService(this);

				return _SchemaService;
			}
		}

		KalturaSearchService _SearchService;
		public KalturaSearchService SearchService
		{
			get
			{
				if (_SearchService == null)
					_SearchService = new KalturaSearchService(this);

				return _SearchService;
			}
		}

		KalturaSessionService _SessionService;
		public KalturaSessionService SessionService
		{
			get
			{
				if (_SessionService == null)
					_SessionService = new KalturaSessionService(this);

				return _SessionService;
			}
		}

		KalturaStatsService _StatsService;
		public KalturaStatsService StatsService
		{
			get
			{
				if (_StatsService == null)
					_StatsService = new KalturaStatsService(this);

				return _StatsService;
			}
		}

		KalturaStorageProfileService _StorageProfileService;
		public KalturaStorageProfileService StorageProfileService
		{
			get
			{
				if (_StorageProfileService == null)
					_StorageProfileService = new KalturaStorageProfileService(this);

				return _StorageProfileService;
			}
		}

		KalturaSyndicationFeedService _SyndicationFeedService;
		public KalturaSyndicationFeedService SyndicationFeedService
		{
			get
			{
				if (_SyndicationFeedService == null)
					_SyndicationFeedService = new KalturaSyndicationFeedService(this);

				return _SyndicationFeedService;
			}
		}

		KalturaSystemService _SystemService;
		public KalturaSystemService SystemService
		{
			get
			{
				if (_SystemService == null)
					_SystemService = new KalturaSystemService(this);

				return _SystemService;
			}
		}

		KalturaThumbAssetService _ThumbAssetService;
		public KalturaThumbAssetService ThumbAssetService
		{
			get
			{
				if (_ThumbAssetService == null)
					_ThumbAssetService = new KalturaThumbAssetService(this);

				return _ThumbAssetService;
			}
		}

		KalturaThumbParamsService _ThumbParamsService;
		public KalturaThumbParamsService ThumbParamsService
		{
			get
			{
				if (_ThumbParamsService == null)
					_ThumbParamsService = new KalturaThumbParamsService(this);

				return _ThumbParamsService;
			}
		}

		KalturaUiConfService _UiConfService;
		public KalturaUiConfService UiConfService
		{
			get
			{
				if (_UiConfService == null)
					_UiConfService = new KalturaUiConfService(this);

				return _UiConfService;
			}
		}

		KalturaUploadService _UploadService;
		public KalturaUploadService UploadService
		{
			get
			{
				if (_UploadService == null)
					_UploadService = new KalturaUploadService(this);

				return _UploadService;
			}
		}

		KalturaUploadTokenService _UploadTokenService;
		public KalturaUploadTokenService UploadTokenService
		{
			get
			{
				if (_UploadTokenService == null)
					_UploadTokenService = new KalturaUploadTokenService(this);

				return _UploadTokenService;
			}
		}

		KalturaUserRoleService _UserRoleService;
		public KalturaUserRoleService UserRoleService
		{
			get
			{
				if (_UserRoleService == null)
					_UserRoleService = new KalturaUserRoleService(this);

				return _UserRoleService;
			}
		}

		KalturaUserService _UserService;
		public KalturaUserService UserService
		{
			get
			{
				if (_UserService == null)
					_UserService = new KalturaUserService(this);

				return _UserService;
			}
		}

		KalturaWidgetService _WidgetService;
		public KalturaWidgetService WidgetService
		{
			get
			{
				if (_WidgetService == null)
					_WidgetService = new KalturaWidgetService(this);

				return _WidgetService;
			}
		}

		KalturaXInternalService _XInternalService;
		public KalturaXInternalService XInternalService
		{
			get
			{
				if (_XInternalService == null)
					_XInternalService = new KalturaXInternalService(this);

				return _XInternalService;
			}
		}

		KalturaMetadataService _MetadataService;
		public KalturaMetadataService MetadataService
		{
			get
			{
				if (_MetadataService == null)
					_MetadataService = new KalturaMetadataService(this);

				return _MetadataService;
			}
		}

		KalturaMetadataProfileService _MetadataProfileService;
		public KalturaMetadataProfileService MetadataProfileService
		{
			get
			{
				if (_MetadataProfileService == null)
					_MetadataProfileService = new KalturaMetadataProfileService(this);

				return _MetadataProfileService;
			}
		}

		KalturaDocumentsService _DocumentsService;
		public KalturaDocumentsService DocumentsService
		{
			get
			{
				if (_DocumentsService == null)
					_DocumentsService = new KalturaDocumentsService(this);

				return _DocumentsService;
			}
		}

		KalturaAuditTrailService _AuditTrailService;
		public KalturaAuditTrailService AuditTrailService
		{
			get
			{
				if (_AuditTrailService == null)
					_AuditTrailService = new KalturaAuditTrailService(this);

				return _AuditTrailService;
			}
		}

		KalturaVirusScanProfileService _VirusScanProfileService;
		public KalturaVirusScanProfileService VirusScanProfileService
		{
			get
			{
				if (_VirusScanProfileService == null)
					_VirusScanProfileService = new KalturaVirusScanProfileService(this);

				return _VirusScanProfileService;
			}
		}

		KalturaDistributionProfileService _DistributionProfileService;
		public KalturaDistributionProfileService DistributionProfileService
		{
			get
			{
				if (_DistributionProfileService == null)
					_DistributionProfileService = new KalturaDistributionProfileService(this);

				return _DistributionProfileService;
			}
		}

		KalturaEntryDistributionService _EntryDistributionService;
		public KalturaEntryDistributionService EntryDistributionService
		{
			get
			{
				if (_EntryDistributionService == null)
					_EntryDistributionService = new KalturaEntryDistributionService(this);

				return _EntryDistributionService;
			}
		}

		KalturaDistributionProviderService _DistributionProviderService;
		public KalturaDistributionProviderService DistributionProviderService
		{
			get
			{
				if (_DistributionProviderService == null)
					_DistributionProviderService = new KalturaDistributionProviderService(this);

				return _DistributionProviderService;
			}
		}

		KalturaGenericDistributionProviderService _GenericDistributionProviderService;
		public KalturaGenericDistributionProviderService GenericDistributionProviderService
		{
			get
			{
				if (_GenericDistributionProviderService == null)
					_GenericDistributionProviderService = new KalturaGenericDistributionProviderService(this);

				return _GenericDistributionProviderService;
			}
		}

		KalturaGenericDistributionProviderActionService _GenericDistributionProviderActionService;
		public KalturaGenericDistributionProviderActionService GenericDistributionProviderActionService
		{
			get
			{
				if (_GenericDistributionProviderActionService == null)
					_GenericDistributionProviderActionService = new KalturaGenericDistributionProviderActionService(this);

				return _GenericDistributionProviderActionService;
			}
		}

		KalturaAnnotationService _AnnotationService;
		public KalturaAnnotationService AnnotationService
		{
			get
			{
				if (_AnnotationService == null)
					_AnnotationService = new KalturaAnnotationService(this);

				return _AnnotationService;
			}
		}

		KalturaShortLinkService _ShortLinkService;
		public KalturaShortLinkService ShortLinkService
		{
			get
			{
				if (_ShortLinkService == null)
					_ShortLinkService = new KalturaShortLinkService(this);

				return _ShortLinkService;
			}
		}

		KalturaDropFolderService _DropFolderService;
		public KalturaDropFolderService DropFolderService
		{
			get
			{
				if (_DropFolderService == null)
					_DropFolderService = new KalturaDropFolderService(this);

				return _DropFolderService;
			}
		}

		KalturaDropFolderFileService _DropFolderFileService;
		public KalturaDropFolderFileService DropFolderFileService
		{
			get
			{
				if (_DropFolderFileService == null)
					_DropFolderFileService = new KalturaDropFolderFileService(this);

				return _DropFolderFileService;
			}
		}

		KalturaTvComService _TvComService;
		public KalturaTvComService TvComService
		{
			get
			{
				if (_TvComService == null)
					_TvComService = new KalturaTvComService(this);

				return _TvComService;
			}
		}

		KalturaCuePointService _CuePointService;
		public KalturaCuePointService CuePointService
		{
			get
			{
				if (_CuePointService == null)
					_CuePointService = new KalturaCuePointService(this);

				return _CuePointService;
			}
		}

		KalturaCaptionAssetService _CaptionAssetService;
		public KalturaCaptionAssetService CaptionAssetService
		{
			get
			{
				if (_CaptionAssetService == null)
					_CaptionAssetService = new KalturaCaptionAssetService(this);

				return _CaptionAssetService;
			}
		}

		KalturaCaptionParamsService _CaptionParamsService;
		public KalturaCaptionParamsService CaptionParamsService
		{
			get
			{
				if (_CaptionParamsService == null)
					_CaptionParamsService = new KalturaCaptionParamsService(this);

				return _CaptionParamsService;
			}
		}

		KalturaCaptionAssetItemService _CaptionAssetItemService;
		public KalturaCaptionAssetItemService CaptionAssetItemService
		{
			get
			{
				if (_CaptionAssetItemService == null)
					_CaptionAssetItemService = new KalturaCaptionAssetItemService(this);

				return _CaptionAssetItemService;
			}
		}

		KalturaAttachmentAssetService _AttachmentAssetService;
		public KalturaAttachmentAssetService AttachmentAssetService
		{
			get
			{
				if (_AttachmentAssetService == null)
					_AttachmentAssetService = new KalturaAttachmentAssetService(this);

				return _AttachmentAssetService;
			}
		}

		KalturaDoubleClickService _DoubleClickService;
		public KalturaDoubleClickService DoubleClickService
		{
			get
			{
				if (_DoubleClickService == null)
					_DoubleClickService = new KalturaDoubleClickService(this);

				return _DoubleClickService;
			}
		}
	}
}
