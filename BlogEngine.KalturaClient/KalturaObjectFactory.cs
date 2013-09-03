using System;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;

namespace Kaltura
{
	public static class KalturaObjectFactory
	{
		public static object Create(XmlElement xmlElement)
		{
			if (xmlElement["objectType"] == null)
			{
				return null;
			}
			switch (xmlElement["objectType"].InnerText)
			{
				case "KalturaBaseRestriction":
					return new KalturaBaseRestriction(xmlElement);
				case "KalturaAccessControl":
					return new KalturaAccessControl(xmlElement);
				case "KalturaSearchItem":
					return new KalturaSearchItem(xmlElement);
				case "KalturaFilter":
					return new KalturaFilter(xmlElement);
				case "KalturaAccessControlBaseFilter":
					return new KalturaAccessControlBaseFilter(xmlElement);
				case "KalturaAccessControlFilter":
					return new KalturaAccessControlFilter(xmlElement);
				case "KalturaFilterPager":
					return new KalturaFilterPager(xmlElement);
				case "KalturaAccessControlListResponse":
					return new KalturaAccessControlListResponse(xmlElement);
				case "KalturaUser":
					return new KalturaUser(xmlElement);
				case "KalturaAdminUser":
					return new KalturaAdminUser(xmlElement);
				case "KalturaDynamicEnum":
					return new KalturaDynamicEnum(xmlElement);
				case "KalturaOperationAttributes":
					return new KalturaOperationAttributes(xmlElement);
				case "KalturaBaseEntry":
					return new KalturaBaseEntry(xmlElement);
				case "KalturaResource":
					return new KalturaResource(xmlElement);
				case "KalturaRemotePath":
					return new KalturaRemotePath(xmlElement);
				case "KalturaRemotePathListResponse":
					return new KalturaRemotePathListResponse(xmlElement);
				case "KalturaBaseEntryBaseFilter":
					return new KalturaBaseEntryBaseFilter(xmlElement);
				case "KalturaBaseEntryFilter":
					return new KalturaBaseEntryFilter(xmlElement);
				case "KalturaBaseEntryListResponse":
					return new KalturaBaseEntryListResponse(xmlElement);
				case "KalturaModerationFlag":
					return new KalturaModerationFlag(xmlElement);
				case "KalturaModerationFlagListResponse":
					return new KalturaModerationFlagListResponse(xmlElement);
				case "KalturaEntryContextDataParams":
					return new KalturaEntryContextDataParams(xmlElement);
				case "KalturaEntryContextDataResult":
					return new KalturaEntryContextDataResult(xmlElement);
				case "KalturaBulkUploadPluginData":
					return new KalturaBulkUploadPluginData(xmlElement);
				case "KalturaBulkUploadResult":
					return new KalturaBulkUploadResult(xmlElement);
				case "KalturaBulkUpload":
					return new KalturaBulkUpload(xmlElement);
				case "KalturaBulkUploadListResponse":
					return new KalturaBulkUploadListResponse(xmlElement);
				case "KalturaCategory":
					return new KalturaCategory(xmlElement);
				case "KalturaCategoryBaseFilter":
					return new KalturaCategoryBaseFilter(xmlElement);
				case "KalturaCategoryFilter":
					return new KalturaCategoryFilter(xmlElement);
				case "KalturaCategoryListResponse":
					return new KalturaCategoryListResponse(xmlElement);
				case "KalturaConversionProfileAssetParamsBaseFilter":
					return new KalturaConversionProfileAssetParamsBaseFilter(xmlElement);
				case "KalturaConversionProfileBaseFilter":
					return new KalturaConversionProfileBaseFilter(xmlElement);
				case "KalturaConversionProfileFilter":
					return new KalturaConversionProfileFilter(xmlElement);
				case "KalturaAssetParamsBaseFilter":
					return new KalturaAssetParamsBaseFilter(xmlElement);
				case "KalturaAssetParamsFilter":
					return new KalturaAssetParamsFilter(xmlElement);
				case "KalturaConversionProfileAssetParamsFilter":
					return new KalturaConversionProfileAssetParamsFilter(xmlElement);
				case "KalturaConversionProfileAssetParams":
					return new KalturaConversionProfileAssetParams(xmlElement);
				case "KalturaConversionProfileAssetParamsListResponse":
					return new KalturaConversionProfileAssetParamsListResponse(xmlElement);
				case "KalturaCropDimensions":
					return new KalturaCropDimensions(xmlElement);
				case "KalturaConversionProfile":
					return new KalturaConversionProfile(xmlElement);
				case "KalturaConversionProfileListResponse":
					return new KalturaConversionProfileListResponse(xmlElement);
				case "KalturaDataEntry":
					return new KalturaDataEntry(xmlElement);
				case "KalturaDataEntryBaseFilter":
					return new KalturaDataEntryBaseFilter(xmlElement);
				case "KalturaDataEntryFilter":
					return new KalturaDataEntryFilter(xmlElement);
				case "KalturaDataListResponse":
					return new KalturaDataListResponse(xmlElement);
				case "KalturaDocumentEntry":
					return new KalturaDocumentEntry(xmlElement);
				case "KalturaConversionAttribute":
					return new KalturaConversionAttribute(xmlElement);
				case "KalturaDocumentEntryBaseFilter":
					return new KalturaDocumentEntryBaseFilter(xmlElement);
				case "KalturaDocumentEntryFilter":
					return new KalturaDocumentEntryFilter(xmlElement);
				case "KalturaDocumentListResponse":
					return new KalturaDocumentListResponse(xmlElement);
				case "KalturaEmailIngestionProfile":
					return new KalturaEmailIngestionProfile(xmlElement);
				case "KalturaPlayableEntry":
					return new KalturaPlayableEntry(xmlElement);
				case "KalturaMediaEntry":
					return new KalturaMediaEntry(xmlElement);
				case "KalturaAsset":
					return new KalturaAsset(xmlElement);
				case "KalturaFlavorAsset":
					return new KalturaFlavorAsset(xmlElement);
				case "KalturaContentResource":
					return new KalturaContentResource(xmlElement);
				case "KalturaAssetBaseFilter":
					return new KalturaAssetBaseFilter(xmlElement);
				case "KalturaAssetFilter":
					return new KalturaAssetFilter(xmlElement);
				case "KalturaFlavorAssetListResponse":
					return new KalturaFlavorAssetListResponse(xmlElement);
				case "KalturaString":
					return new KalturaString(xmlElement);
				case "KalturaAssetParams":
					return new KalturaAssetParams(xmlElement);
				case "KalturaFlavorParams":
					return new KalturaFlavorParams(xmlElement);
				case "KalturaFlavorAssetWithParams":
					return new KalturaFlavorAssetWithParams(xmlElement);
				case "KalturaFlavorParamsBaseFilter":
					return new KalturaFlavorParamsBaseFilter(xmlElement);
				case "KalturaFlavorParamsFilter":
					return new KalturaFlavorParamsFilter(xmlElement);
				case "KalturaFlavorParamsListResponse":
					return new KalturaFlavorParamsListResponse(xmlElement);
				case "KalturaLiveStreamBitrate":
					return new KalturaLiveStreamBitrate(xmlElement);
				case "KalturaLiveStreamEntry":
					return new KalturaLiveStreamEntry(xmlElement);
				case "KalturaLiveStreamAdminEntry":
					return new KalturaLiveStreamAdminEntry(xmlElement);
				case "KalturaPlayableEntryBaseFilter":
					return new KalturaPlayableEntryBaseFilter(xmlElement);
				case "KalturaPlayableEntryFilter":
					return new KalturaPlayableEntryFilter(xmlElement);
				case "KalturaMediaEntryBaseFilter":
					return new KalturaMediaEntryBaseFilter(xmlElement);
				case "KalturaMediaEntryFilter":
					return new KalturaMediaEntryFilter(xmlElement);
				case "KalturaLiveStreamEntryBaseFilter":
					return new KalturaLiveStreamEntryBaseFilter(xmlElement);
				case "KalturaLiveStreamEntryFilter":
					return new KalturaLiveStreamEntryFilter(xmlElement);
				case "KalturaLiveStreamListResponse":
					return new KalturaLiveStreamListResponse(xmlElement);
				case "KalturaSearch":
					return new KalturaSearch(xmlElement);
				case "KalturaSearchResult":
					return new KalturaSearchResult(xmlElement);
				case "KalturaMediaListResponse":
					return new KalturaMediaListResponse(xmlElement);
				case "KalturaMixEntry":
					return new KalturaMixEntry(xmlElement);
				case "KalturaMixEntryBaseFilter":
					return new KalturaMixEntryBaseFilter(xmlElement);
				case "KalturaMixEntryFilter":
					return new KalturaMixEntryFilter(xmlElement);
				case "KalturaMixListResponse":
					return new KalturaMixListResponse(xmlElement);
				case "KalturaClientNotification":
					return new KalturaClientNotification(xmlElement);
				case "KalturaKeyValue":
					return new KalturaKeyValue(xmlElement);
				case "KalturaPartner":
					return new KalturaPartner(xmlElement);
				case "KalturaPartnerUsage":
					return new KalturaPartnerUsage(xmlElement);
				case "KalturaPermissionItem":
					return new KalturaPermissionItem(xmlElement);
				case "KalturaPermissionItemBaseFilter":
					return new KalturaPermissionItemBaseFilter(xmlElement);
				case "KalturaPermissionItemFilter":
					return new KalturaPermissionItemFilter(xmlElement);
				case "KalturaPermissionItemListResponse":
					return new KalturaPermissionItemListResponse(xmlElement);
				case "KalturaPermission":
					return new KalturaPermission(xmlElement);
				case "KalturaPermissionBaseFilter":
					return new KalturaPermissionBaseFilter(xmlElement);
				case "KalturaPermissionFilter":
					return new KalturaPermissionFilter(xmlElement);
				case "KalturaPermissionListResponse":
					return new KalturaPermissionListResponse(xmlElement);
				case "KalturaMediaEntryFilterForPlaylist":
					return new KalturaMediaEntryFilterForPlaylist(xmlElement);
				case "KalturaPlaylist":
					return new KalturaPlaylist(xmlElement);
				case "KalturaPlaylistBaseFilter":
					return new KalturaPlaylistBaseFilter(xmlElement);
				case "KalturaPlaylistFilter":
					return new KalturaPlaylistFilter(xmlElement);
				case "KalturaPlaylistListResponse":
					return new KalturaPlaylistListResponse(xmlElement);
				case "KalturaReportInputFilter":
					return new KalturaReportInputFilter(xmlElement);
				case "KalturaReportGraph":
					return new KalturaReportGraph(xmlElement);
				case "KalturaReportTotal":
					return new KalturaReportTotal(xmlElement);
				case "KalturaReportTable":
					return new KalturaReportTable(xmlElement);
				case "KalturaSearchResultResponse":
					return new KalturaSearchResultResponse(xmlElement);
				case "KalturaSearchAuthData":
					return new KalturaSearchAuthData(xmlElement);
				case "KalturaStartWidgetSessionResponse":
					return new KalturaStartWidgetSessionResponse(xmlElement);
				case "KalturaStatsEvent":
					return new KalturaStatsEvent(xmlElement);
				case "KalturaStatsKmcEvent":
					return new KalturaStatsKmcEvent(xmlElement);
				case "KalturaCEError":
					return new KalturaCEError(xmlElement);
				case "KalturaStorageProfile":
					return new KalturaStorageProfile(xmlElement);
				case "KalturaStorageProfileBaseFilter":
					return new KalturaStorageProfileBaseFilter(xmlElement);
				case "KalturaStorageProfileFilter":
					return new KalturaStorageProfileFilter(xmlElement);
				case "KalturaStorageProfileListResponse":
					return new KalturaStorageProfileListResponse(xmlElement);
				case "KalturaBaseSyndicationFeed":
					return new KalturaBaseSyndicationFeed(xmlElement);
				case "KalturaBaseSyndicationFeedBaseFilter":
					return new KalturaBaseSyndicationFeedBaseFilter(xmlElement);
				case "KalturaBaseSyndicationFeedFilter":
					return new KalturaBaseSyndicationFeedFilter(xmlElement);
				case "KalturaBaseSyndicationFeedListResponse":
					return new KalturaBaseSyndicationFeedListResponse(xmlElement);
				case "KalturaSyndicationFeedEntryCount":
					return new KalturaSyndicationFeedEntryCount(xmlElement);
				case "KalturaThumbAsset":
					return new KalturaThumbAsset(xmlElement);
				case "KalturaThumbParams":
					return new KalturaThumbParams(xmlElement);
				case "KalturaThumbAssetListResponse":
					return new KalturaThumbAssetListResponse(xmlElement);
				case "KalturaThumbParamsBaseFilter":
					return new KalturaThumbParamsBaseFilter(xmlElement);
				case "KalturaThumbParamsFilter":
					return new KalturaThumbParamsFilter(xmlElement);
				case "KalturaThumbParamsListResponse":
					return new KalturaThumbParamsListResponse(xmlElement);
				case "KalturaUiConf":
					return new KalturaUiConf(xmlElement);
				case "KalturaUiConfBaseFilter":
					return new KalturaUiConfBaseFilter(xmlElement);
				case "KalturaUiConfFilter":
					return new KalturaUiConfFilter(xmlElement);
				case "KalturaUiConfListResponse":
					return new KalturaUiConfListResponse(xmlElement);
				case "KalturaUiConfTypeInfo":
					return new KalturaUiConfTypeInfo(xmlElement);
				case "KalturaUploadResponse":
					return new KalturaUploadResponse(xmlElement);
				case "KalturaUploadToken":
					return new KalturaUploadToken(xmlElement);
				case "KalturaUploadTokenBaseFilter":
					return new KalturaUploadTokenBaseFilter(xmlElement);
				case "KalturaUploadTokenFilter":
					return new KalturaUploadTokenFilter(xmlElement);
				case "KalturaUploadTokenListResponse":
					return new KalturaUploadTokenListResponse(xmlElement);
				case "KalturaUserRole":
					return new KalturaUserRole(xmlElement);
				case "KalturaUserRoleBaseFilter":
					return new KalturaUserRoleBaseFilter(xmlElement);
				case "KalturaUserRoleFilter":
					return new KalturaUserRoleFilter(xmlElement);
				case "KalturaUserRoleListResponse":
					return new KalturaUserRoleListResponse(xmlElement);
				case "KalturaUserBaseFilter":
					return new KalturaUserBaseFilter(xmlElement);
				case "KalturaUserFilter":
					return new KalturaUserFilter(xmlElement);
				case "KalturaUserListResponse":
					return new KalturaUserListResponse(xmlElement);
				case "KalturaWidget":
					return new KalturaWidget(xmlElement);
				case "KalturaWidgetBaseFilter":
					return new KalturaWidgetBaseFilter(xmlElement);
				case "KalturaWidgetFilter":
					return new KalturaWidgetFilter(xmlElement);
				case "KalturaWidgetListResponse":
					return new KalturaWidgetListResponse(xmlElement);
				case "KalturaMetadataBaseFilter":
					return new KalturaMetadataBaseFilter(xmlElement);
				case "KalturaMetadataFilter":
					return new KalturaMetadataFilter(xmlElement);
				case "KalturaMetadata":
					return new KalturaMetadata(xmlElement);
				case "KalturaMetadataListResponse":
					return new KalturaMetadataListResponse(xmlElement);
				case "KalturaMetadataProfileBaseFilter":
					return new KalturaMetadataProfileBaseFilter(xmlElement);
				case "KalturaMetadataProfileFilter":
					return new KalturaMetadataProfileFilter(xmlElement);
				case "KalturaMetadataProfile":
					return new KalturaMetadataProfile(xmlElement);
				case "KalturaMetadataProfileListResponse":
					return new KalturaMetadataProfileListResponse(xmlElement);
				case "KalturaMetadataProfileField":
					return new KalturaMetadataProfileField(xmlElement);
				case "KalturaMetadataProfileFieldListResponse":
					return new KalturaMetadataProfileFieldListResponse(xmlElement);
				case "KalturaAuditTrailInfo":
					return new KalturaAuditTrailInfo(xmlElement);
				case "KalturaAuditTrail":
					return new KalturaAuditTrail(xmlElement);
				case "KalturaAuditTrailBaseFilter":
					return new KalturaAuditTrailBaseFilter(xmlElement);
				case "KalturaAuditTrailFilter":
					return new KalturaAuditTrailFilter(xmlElement);
				case "KalturaAuditTrailListResponse":
					return new KalturaAuditTrailListResponse(xmlElement);
				case "KalturaVirusScanProfileBaseFilter":
					return new KalturaVirusScanProfileBaseFilter(xmlElement);
				case "KalturaVirusScanProfileFilter":
					return new KalturaVirusScanProfileFilter(xmlElement);
				case "KalturaVirusScanProfile":
					return new KalturaVirusScanProfile(xmlElement);
				case "KalturaVirusScanProfileListResponse":
					return new KalturaVirusScanProfileListResponse(xmlElement);
				case "KalturaDistributionThumbDimensions":
					return new KalturaDistributionThumbDimensions(xmlElement);
				case "KalturaDistributionProfile":
					return new KalturaDistributionProfile(xmlElement);
				case "KalturaDistributionProfileBaseFilter":
					return new KalturaDistributionProfileBaseFilter(xmlElement);
				case "KalturaDistributionProfileFilter":
					return new KalturaDistributionProfileFilter(xmlElement);
				case "KalturaDistributionProfileListResponse":
					return new KalturaDistributionProfileListResponse(xmlElement);
				case "KalturaPartnerBaseFilter":
					return new KalturaPartnerBaseFilter(xmlElement);
				case "KalturaPartnerFilter":
					return new KalturaPartnerFilter(xmlElement);
				case "KalturaDistributionValidationError":
					return new KalturaDistributionValidationError(xmlElement);
				case "KalturaEntryDistribution":
					return new KalturaEntryDistribution(xmlElement);
				case "KalturaEntryDistributionBaseFilter":
					return new KalturaEntryDistributionBaseFilter(xmlElement);
				case "KalturaEntryDistributionFilter":
					return new KalturaEntryDistributionFilter(xmlElement);
				case "KalturaEntryDistributionListResponse":
					return new KalturaEntryDistributionListResponse(xmlElement);
				case "KalturaDistributionProviderBaseFilter":
					return new KalturaDistributionProviderBaseFilter(xmlElement);
				case "KalturaDistributionProviderFilter":
					return new KalturaDistributionProviderFilter(xmlElement);
				case "KalturaDistributionProvider":
					return new KalturaDistributionProvider(xmlElement);
				case "KalturaDistributionProviderListResponse":
					return new KalturaDistributionProviderListResponse(xmlElement);
				case "KalturaGenericDistributionProvider":
					return new KalturaGenericDistributionProvider(xmlElement);
				case "KalturaGenericDistributionProviderBaseFilter":
					return new KalturaGenericDistributionProviderBaseFilter(xmlElement);
				case "KalturaGenericDistributionProviderFilter":
					return new KalturaGenericDistributionProviderFilter(xmlElement);
				case "KalturaGenericDistributionProviderListResponse":
					return new KalturaGenericDistributionProviderListResponse(xmlElement);
				case "KalturaGenericDistributionProviderAction":
					return new KalturaGenericDistributionProviderAction(xmlElement);
				case "KalturaGenericDistributionProviderActionBaseFilter":
					return new KalturaGenericDistributionProviderActionBaseFilter(xmlElement);
				case "KalturaGenericDistributionProviderActionFilter":
					return new KalturaGenericDistributionProviderActionFilter(xmlElement);
				case "KalturaGenericDistributionProviderActionListResponse":
					return new KalturaGenericDistributionProviderActionListResponse(xmlElement);
				case "KalturaCuePoint":
					return new KalturaCuePoint(xmlElement);
				case "KalturaAnnotation":
					return new KalturaAnnotation(xmlElement);
				case "KalturaCuePointBaseFilter":
					return new KalturaCuePointBaseFilter(xmlElement);
				case "KalturaCuePointFilter":
					return new KalturaCuePointFilter(xmlElement);
				case "KalturaAnnotationBaseFilter":
					return new KalturaAnnotationBaseFilter(xmlElement);
				case "KalturaAnnotationFilter":
					return new KalturaAnnotationFilter(xmlElement);
				case "KalturaAnnotationListResponse":
					return new KalturaAnnotationListResponse(xmlElement);
				case "KalturaCuePointListResponse":
					return new KalturaCuePointListResponse(xmlElement);
				case "KalturaShortLinkBaseFilter":
					return new KalturaShortLinkBaseFilter(xmlElement);
				case "KalturaShortLinkFilter":
					return new KalturaShortLinkFilter(xmlElement);
				case "KalturaShortLink":
					return new KalturaShortLink(xmlElement);
				case "KalturaShortLinkListResponse":
					return new KalturaShortLinkListResponse(xmlElement);
				case "KalturaDropFolderFileHandlerConfig":
					return new KalturaDropFolderFileHandlerConfig(xmlElement);
				case "KalturaDropFolder":
					return new KalturaDropFolder(xmlElement);
				case "KalturaDropFolderBaseFilter":
					return new KalturaDropFolderBaseFilter(xmlElement);
				case "KalturaDropFolderFilter":
					return new KalturaDropFolderFilter(xmlElement);
				case "KalturaDropFolderListResponse":
					return new KalturaDropFolderListResponse(xmlElement);
				case "KalturaDropFolderFile":
					return new KalturaDropFolderFile(xmlElement);
				case "KalturaDropFolderFileBaseFilter":
					return new KalturaDropFolderFileBaseFilter(xmlElement);
				case "KalturaDropFolderFileFilter":
					return new KalturaDropFolderFileFilter(xmlElement);
				case "KalturaDropFolderFileListResponse":
					return new KalturaDropFolderFileListResponse(xmlElement);
				case "KalturaCaptionAsset":
					return new KalturaCaptionAsset(xmlElement);
				case "KalturaCaptionAssetListResponse":
					return new KalturaCaptionAssetListResponse(xmlElement);
				case "KalturaCaptionParams":
					return new KalturaCaptionParams(xmlElement);
				case "KalturaCaptionParamsBaseFilter":
					return new KalturaCaptionParamsBaseFilter(xmlElement);
				case "KalturaCaptionParamsFilter":
					return new KalturaCaptionParamsFilter(xmlElement);
				case "KalturaCaptionParamsListResponse":
					return new KalturaCaptionParamsListResponse(xmlElement);
				case "KalturaCaptionAssetBaseFilter":
					return new KalturaCaptionAssetBaseFilter(xmlElement);
				case "KalturaCaptionAssetFilter":
					return new KalturaCaptionAssetFilter(xmlElement);
				case "KalturaCaptionAssetItemFilter":
					return new KalturaCaptionAssetItemFilter(xmlElement);
				case "KalturaCaptionAssetItem":
					return new KalturaCaptionAssetItem(xmlElement);
				case "KalturaCaptionAssetItemListResponse":
					return new KalturaCaptionAssetItemListResponse(xmlElement);
				case "KalturaAttachmentAsset":
					return new KalturaAttachmentAsset(xmlElement);
				case "KalturaAttachmentAssetListResponse":
					return new KalturaAttachmentAssetListResponse(xmlElement);
				case "KalturaCountryRestriction":
					return new KalturaCountryRestriction(xmlElement);
				case "KalturaDirectoryRestriction":
					return new KalturaDirectoryRestriction(xmlElement);
				case "KalturaIpAddressRestriction":
					return new KalturaIpAddressRestriction(xmlElement);
				case "KalturaSessionRestriction":
					return new KalturaSessionRestriction(xmlElement);
				case "KalturaPreviewRestriction":
					return new KalturaPreviewRestriction(xmlElement);
				case "KalturaSiteRestriction":
					return new KalturaSiteRestriction(xmlElement);
				case "KalturaUserAgentRestriction":
					return new KalturaUserAgentRestriction(xmlElement);
				case "KalturaSearchCondition":
					return new KalturaSearchCondition(xmlElement);
				case "KalturaSearchComparableCondition":
					return new KalturaSearchComparableCondition(xmlElement);
				case "KalturaSearchOperator":
					return new KalturaSearchOperator(xmlElement);
				case "KalturaContentDistributionSearchItem":
					return new KalturaContentDistributionSearchItem(xmlElement);
				case "KalturaMetadataSearchItem":
					return new KalturaMetadataSearchItem(xmlElement);
				case "KalturaBaseJobBaseFilter":
					return new KalturaBaseJobBaseFilter(xmlElement);
				case "KalturaBaseJobFilter":
					return new KalturaBaseJobFilter(xmlElement);
				case "KalturaBatchJobBaseFilter":
					return new KalturaBatchJobBaseFilter(xmlElement);
				case "KalturaControlPanelCommandBaseFilter":
					return new KalturaControlPanelCommandBaseFilter(xmlElement);
				case "KalturaMailJobBaseFilter":
					return new KalturaMailJobBaseFilter(xmlElement);
				case "KalturaNotificationBaseFilter":
					return new KalturaNotificationBaseFilter(xmlElement);
				case "KalturaBatchJobFilter":
					return new KalturaBatchJobFilter(xmlElement);
				case "KalturaControlPanelCommandFilter":
					return new KalturaControlPanelCommandFilter(xmlElement);
				case "KalturaMailJobFilter":
					return new KalturaMailJobFilter(xmlElement);
				case "KalturaNotificationFilter":
					return new KalturaNotificationFilter(xmlElement);
				case "KalturaBatchJobFilterExt":
					return new KalturaBatchJobFilterExt(xmlElement);
				case "KalturaAssetParamsOutputBaseFilter":
					return new KalturaAssetParamsOutputBaseFilter(xmlElement);
				case "KalturaFlavorAssetBaseFilter":
					return new KalturaFlavorAssetBaseFilter(xmlElement);
				case "KalturaFlavorParamsOutputBaseFilter":
					return new KalturaFlavorParamsOutputBaseFilter(xmlElement);
				case "KalturaMediaFlavorParamsBaseFilter":
					return new KalturaMediaFlavorParamsBaseFilter(xmlElement);
				case "KalturaFlavorParamsOutputFilter":
					return new KalturaFlavorParamsOutputFilter(xmlElement);
				case "KalturaMediaFlavorParamsOutputBaseFilter":
					return new KalturaMediaFlavorParamsOutputBaseFilter(xmlElement);
				case "KalturaMediaInfoBaseFilter":
					return new KalturaMediaInfoBaseFilter(xmlElement);
				case "KalturaThumbAssetBaseFilter":
					return new KalturaThumbAssetBaseFilter(xmlElement);
				case "KalturaThumbParamsOutputBaseFilter":
					return new KalturaThumbParamsOutputBaseFilter(xmlElement);
				case "KalturaAssetParamsOutputFilter":
					return new KalturaAssetParamsOutputFilter(xmlElement);
				case "KalturaFlavorAssetFilter":
					return new KalturaFlavorAssetFilter(xmlElement);
				case "KalturaMediaFlavorParamsFilter":
					return new KalturaMediaFlavorParamsFilter(xmlElement);
				case "KalturaMediaFlavorParamsOutputFilter":
					return new KalturaMediaFlavorParamsOutputFilter(xmlElement);
				case "KalturaMediaInfoFilter":
					return new KalturaMediaInfoFilter(xmlElement);
				case "KalturaThumbAssetFilter":
					return new KalturaThumbAssetFilter(xmlElement);
				case "KalturaThumbParamsOutputFilter":
					return new KalturaThumbParamsOutputFilter(xmlElement);
				case "KalturaLiveStreamAdminEntryBaseFilter":
					return new KalturaLiveStreamAdminEntryBaseFilter(xmlElement);
				case "KalturaLiveStreamAdminEntryFilter":
					return new KalturaLiveStreamAdminEntryFilter(xmlElement);
				case "KalturaAdminUserBaseFilter":
					return new KalturaAdminUserBaseFilter(xmlElement);
				case "KalturaUserLoginDataBaseFilter":
					return new KalturaUserLoginDataBaseFilter(xmlElement);
				case "KalturaAdminUserFilter":
					return new KalturaAdminUserFilter(xmlElement);
				case "KalturaGoogleVideoSyndicationFeedBaseFilter":
					return new KalturaGoogleVideoSyndicationFeedBaseFilter(xmlElement);
				case "KalturaGoogleVideoSyndicationFeedFilter":
					return new KalturaGoogleVideoSyndicationFeedFilter(xmlElement);
				case "KalturaITunesSyndicationFeedBaseFilter":
					return new KalturaITunesSyndicationFeedBaseFilter(xmlElement);
				case "KalturaITunesSyndicationFeedFilter":
					return new KalturaITunesSyndicationFeedFilter(xmlElement);
				case "KalturaTubeMogulSyndicationFeedBaseFilter":
					return new KalturaTubeMogulSyndicationFeedBaseFilter(xmlElement);
				case "KalturaTubeMogulSyndicationFeedFilter":
					return new KalturaTubeMogulSyndicationFeedFilter(xmlElement);
				case "KalturaUserLoginDataFilter":
					return new KalturaUserLoginDataFilter(xmlElement);
				case "KalturaYahooSyndicationFeedBaseFilter":
					return new KalturaYahooSyndicationFeedBaseFilter(xmlElement);
				case "KalturaYahooSyndicationFeedFilter":
					return new KalturaYahooSyndicationFeedFilter(xmlElement);
				case "KalturaApiActionPermissionItemBaseFilter":
					return new KalturaApiActionPermissionItemBaseFilter(xmlElement);
				case "KalturaApiParameterPermissionItemBaseFilter":
					return new KalturaApiParameterPermissionItemBaseFilter(xmlElement);
				case "KalturaApiActionPermissionItemFilter":
					return new KalturaApiActionPermissionItemFilter(xmlElement);
				case "KalturaApiParameterPermissionItemFilter":
					return new KalturaApiParameterPermissionItemFilter(xmlElement);
				case "KalturaGenericSyndicationFeedBaseFilter":
					return new KalturaGenericSyndicationFeedBaseFilter(xmlElement);
				case "KalturaGenericSyndicationFeedFilter":
					return new KalturaGenericSyndicationFeedFilter(xmlElement);
				case "KalturaGenericXsltSyndicationFeedBaseFilter":
					return new KalturaGenericXsltSyndicationFeedBaseFilter(xmlElement);
				case "KalturaGenericXsltSyndicationFeedFilter":
					return new KalturaGenericXsltSyndicationFeedFilter(xmlElement);
				case "KalturaUiConfAdminBaseFilter":
					return new KalturaUiConfAdminBaseFilter(xmlElement);
				case "KalturaUiConfAdminFilter":
					return new KalturaUiConfAdminFilter(xmlElement);
				case "KalturaAttachmentAssetBaseFilter":
					return new KalturaAttachmentAssetBaseFilter(xmlElement);
				case "KalturaAttachmentAssetFilter":
					return new KalturaAttachmentAssetFilter(xmlElement);
				case "KalturaConfigurableDistributionProfileBaseFilter":
					return new KalturaConfigurableDistributionProfileBaseFilter(xmlElement);
				case "KalturaGenericDistributionProfileBaseFilter":
					return new KalturaGenericDistributionProfileBaseFilter(xmlElement);
				case "KalturaSyndicationDistributionProfileBaseFilter":
					return new KalturaSyndicationDistributionProfileBaseFilter(xmlElement);
				case "KalturaSyndicationDistributionProviderBaseFilter":
					return new KalturaSyndicationDistributionProviderBaseFilter(xmlElement);
				case "KalturaConfigurableDistributionProfileFilter":
					return new KalturaConfigurableDistributionProfileFilter(xmlElement);
				case "KalturaGenericDistributionProfileFilter":
					return new KalturaGenericDistributionProfileFilter(xmlElement);
				case "KalturaSyndicationDistributionProfileFilter":
					return new KalturaSyndicationDistributionProfileFilter(xmlElement);
				case "KalturaSyndicationDistributionProviderFilter":
					return new KalturaSyndicationDistributionProviderFilter(xmlElement);
				case "KalturaAvnDistributionProfileBaseFilter":
					return new KalturaAvnDistributionProfileBaseFilter(xmlElement);
				case "KalturaAvnDistributionProviderBaseFilter":
					return new KalturaAvnDistributionProviderBaseFilter(xmlElement);
				case "KalturaAvnDistributionProfileFilter":
					return new KalturaAvnDistributionProfileFilter(xmlElement);
				case "KalturaAvnDistributionProviderFilter":
					return new KalturaAvnDistributionProviderFilter(xmlElement);
				case "KalturaComcastMrssDistributionProfileBaseFilter":
					return new KalturaComcastMrssDistributionProfileBaseFilter(xmlElement);
				case "KalturaComcastMrssDistributionProviderBaseFilter":
					return new KalturaComcastMrssDistributionProviderBaseFilter(xmlElement);
				case "KalturaComcastMrssDistributionProfileFilter":
					return new KalturaComcastMrssDistributionProfileFilter(xmlElement);
				case "KalturaComcastMrssDistributionProviderFilter":
					return new KalturaComcastMrssDistributionProviderFilter(xmlElement);
				case "KalturaDailymotionDistributionProfileBaseFilter":
					return new KalturaDailymotionDistributionProfileBaseFilter(xmlElement);
				case "KalturaDailymotionDistributionProviderBaseFilter":
					return new KalturaDailymotionDistributionProviderBaseFilter(xmlElement);
				case "KalturaDailymotionDistributionProfileFilter":
					return new KalturaDailymotionDistributionProfileFilter(xmlElement);
				case "KalturaDailymotionDistributionProviderFilter":
					return new KalturaDailymotionDistributionProviderFilter(xmlElement);
				case "KalturaDoubleClickDistributionProfileBaseFilter":
					return new KalturaDoubleClickDistributionProfileBaseFilter(xmlElement);
				case "KalturaDoubleClickDistributionProviderBaseFilter":
					return new KalturaDoubleClickDistributionProviderBaseFilter(xmlElement);
				case "KalturaDoubleClickDistributionProfileFilter":
					return new KalturaDoubleClickDistributionProfileFilter(xmlElement);
				case "KalturaDoubleClickDistributionProviderFilter":
					return new KalturaDoubleClickDistributionProviderFilter(xmlElement);
				case "KalturaExampleDistributionProfileBaseFilter":
					return new KalturaExampleDistributionProfileBaseFilter(xmlElement);
				case "KalturaExampleDistributionProviderBaseFilter":
					return new KalturaExampleDistributionProviderBaseFilter(xmlElement);
				case "KalturaExampleDistributionProfileFilter":
					return new KalturaExampleDistributionProfileFilter(xmlElement);
				case "KalturaExampleDistributionProviderFilter":
					return new KalturaExampleDistributionProviderFilter(xmlElement);
				case "KalturaFreewheelDistributionProfileBaseFilter":
					return new KalturaFreewheelDistributionProfileBaseFilter(xmlElement);
				case "KalturaFreewheelDistributionProviderBaseFilter":
					return new KalturaFreewheelDistributionProviderBaseFilter(xmlElement);
				case "KalturaFreewheelDistributionProfileFilter":
					return new KalturaFreewheelDistributionProfileFilter(xmlElement);
				case "KalturaFreewheelDistributionProviderFilter":
					return new KalturaFreewheelDistributionProviderFilter(xmlElement);
				case "KalturaFreewheelGenericDistributionProfileBaseFilter":
					return new KalturaFreewheelGenericDistributionProfileBaseFilter(xmlElement);
				case "KalturaFreewheelGenericDistributionProviderBaseFilter":
					return new KalturaFreewheelGenericDistributionProviderBaseFilter(xmlElement);
				case "KalturaFreewheelGenericDistributionProfileFilter":
					return new KalturaFreewheelGenericDistributionProfileFilter(xmlElement);
				case "KalturaFreewheelGenericDistributionProviderFilter":
					return new KalturaFreewheelGenericDistributionProviderFilter(xmlElement);
				case "KalturaHuluDistributionProfileBaseFilter":
					return new KalturaHuluDistributionProfileBaseFilter(xmlElement);
				case "KalturaHuluDistributionProviderBaseFilter":
					return new KalturaHuluDistributionProviderBaseFilter(xmlElement);
				case "KalturaHuluDistributionProfileFilter":
					return new KalturaHuluDistributionProfileFilter(xmlElement);
				case "KalturaHuluDistributionProviderFilter":
					return new KalturaHuluDistributionProviderFilter(xmlElement);
				case "KalturaIdeticDistributionProfileBaseFilter":
					return new KalturaIdeticDistributionProfileBaseFilter(xmlElement);
				case "KalturaIdeticDistributionProviderBaseFilter":
					return new KalturaIdeticDistributionProviderBaseFilter(xmlElement);
				case "KalturaIdeticDistributionProfileFilter":
					return new KalturaIdeticDistributionProfileFilter(xmlElement);
				case "KalturaIdeticDistributionProviderFilter":
					return new KalturaIdeticDistributionProviderFilter(xmlElement);
				case "KalturaPodcastDistributionProfileBaseFilter":
					return new KalturaPodcastDistributionProfileBaseFilter(xmlElement);
				case "KalturaPodcastDistributionProviderBaseFilter":
					return new KalturaPodcastDistributionProviderBaseFilter(xmlElement);
				case "KalturaPodcastDistributionProfileFilter":
					return new KalturaPodcastDistributionProfileFilter(xmlElement);
				case "KalturaPodcastDistributionProviderFilter":
					return new KalturaPodcastDistributionProviderFilter(xmlElement);
				case "KalturaSynacorHboDistributionProfileBaseFilter":
					return new KalturaSynacorHboDistributionProfileBaseFilter(xmlElement);
				case "KalturaSynacorHboDistributionProviderBaseFilter":
					return new KalturaSynacorHboDistributionProviderBaseFilter(xmlElement);
				case "KalturaSynacorHboDistributionProfileFilter":
					return new KalturaSynacorHboDistributionProfileFilter(xmlElement);
				case "KalturaSynacorHboDistributionProviderFilter":
					return new KalturaSynacorHboDistributionProviderFilter(xmlElement);
				case "KalturaTVComDistributionProfileBaseFilter":
					return new KalturaTVComDistributionProfileBaseFilter(xmlElement);
				case "KalturaTVComDistributionProviderBaseFilter":
					return new KalturaTVComDistributionProviderBaseFilter(xmlElement);
				case "KalturaTVComDistributionProfileFilter":
					return new KalturaTVComDistributionProfileFilter(xmlElement);
				case "KalturaTVComDistributionProviderFilter":
					return new KalturaTVComDistributionProviderFilter(xmlElement);
				case "KalturaYouTubeDistributionProfileBaseFilter":
					return new KalturaYouTubeDistributionProfileBaseFilter(xmlElement);
				case "KalturaYouTubeDistributionProviderBaseFilter":
					return new KalturaYouTubeDistributionProviderBaseFilter(xmlElement);
				case "KalturaYouTubeDistributionProfileFilter":
					return new KalturaYouTubeDistributionProfileFilter(xmlElement);
				case "KalturaYouTubeDistributionProviderFilter":
					return new KalturaYouTubeDistributionProviderFilter(xmlElement);
				case "KalturaYoutubeApiDistributionProfileBaseFilter":
					return new KalturaYoutubeApiDistributionProfileBaseFilter(xmlElement);
				case "KalturaYoutubeApiDistributionProviderBaseFilter":
					return new KalturaYoutubeApiDistributionProviderBaseFilter(xmlElement);
				case "KalturaYoutubeApiDistributionProfileFilter":
					return new KalturaYoutubeApiDistributionProfileFilter(xmlElement);
				case "KalturaYoutubeApiDistributionProviderFilter":
					return new KalturaYoutubeApiDistributionProviderFilter(xmlElement);
				case "KalturaAdCuePointBaseFilter":
					return new KalturaAdCuePointBaseFilter(xmlElement);
				case "KalturaAdCuePointFilter":
					return new KalturaAdCuePointFilter(xmlElement);
				case "KalturaCodeCuePointBaseFilter":
					return new KalturaCodeCuePointBaseFilter(xmlElement);
				case "KalturaCodeCuePointFilter":
					return new KalturaCodeCuePointFilter(xmlElement);
				case "KalturaDocumentFlavorParamsBaseFilter":
					return new KalturaDocumentFlavorParamsBaseFilter(xmlElement);
				case "KalturaDocumentFlavorParamsOutputBaseFilter":
					return new KalturaDocumentFlavorParamsOutputBaseFilter(xmlElement);
				case "KalturaPdfFlavorParamsBaseFilter":
					return new KalturaPdfFlavorParamsBaseFilter(xmlElement);
				case "KalturaPdfFlavorParamsOutputBaseFilter":
					return new KalturaPdfFlavorParamsOutputBaseFilter(xmlElement);
				case "KalturaSwfFlavorParamsBaseFilter":
					return new KalturaSwfFlavorParamsBaseFilter(xmlElement);
				case "KalturaSwfFlavorParamsOutputBaseFilter":
					return new KalturaSwfFlavorParamsOutputBaseFilter(xmlElement);
				case "KalturaDocumentFlavorParamsFilter":
					return new KalturaDocumentFlavorParamsFilter(xmlElement);
				case "KalturaDocumentFlavorParamsOutputFilter":
					return new KalturaDocumentFlavorParamsOutputFilter(xmlElement);
				case "KalturaPdfFlavorParamsFilter":
					return new KalturaPdfFlavorParamsFilter(xmlElement);
				case "KalturaPdfFlavorParamsOutputFilter":
					return new KalturaPdfFlavorParamsOutputFilter(xmlElement);
				case "KalturaSwfFlavorParamsFilter":
					return new KalturaSwfFlavorParamsFilter(xmlElement);
				case "KalturaSwfFlavorParamsOutputFilter":
					return new KalturaSwfFlavorParamsOutputFilter(xmlElement);
				case "KalturaRemoteDropFolderBaseFilter":
					return new KalturaRemoteDropFolderBaseFilter(xmlElement);
				case "KalturaRemoteDropFolderFilter":
					return new KalturaRemoteDropFolderFilter(xmlElement);
				case "KalturaFtpDropFolderBaseFilter":
					return new KalturaFtpDropFolderBaseFilter(xmlElement);
				case "KalturaSshDropFolderBaseFilter":
					return new KalturaSshDropFolderBaseFilter(xmlElement);
				case "KalturaSshDropFolderFilter":
					return new KalturaSshDropFolderFilter(xmlElement);
				case "KalturaScpDropFolderBaseFilter":
					return new KalturaScpDropFolderBaseFilter(xmlElement);
				case "KalturaSftpDropFolderBaseFilter":
					return new KalturaSftpDropFolderBaseFilter(xmlElement);
				case "KalturaFtpDropFolderFilter":
					return new KalturaFtpDropFolderFilter(xmlElement);
				case "KalturaScpDropFolderFilter":
					return new KalturaScpDropFolderFilter(xmlElement);
				case "KalturaSftpDropFolderFilter":
					return new KalturaSftpDropFolderFilter(xmlElement);
				case "KalturaFileSyncBaseFilter":
					return new KalturaFileSyncBaseFilter(xmlElement);
				case "KalturaFileSyncFilter":
					return new KalturaFileSyncFilter(xmlElement);
				case "KalturaDwhHourlyPartnerBaseFilter":
					return new KalturaDwhHourlyPartnerBaseFilter(xmlElement);
				case "KalturaDwhHourlyPartnerFilter":
					return new KalturaDwhHourlyPartnerFilter(xmlElement);
				case "KalturaSystemPartnerUsageFilter":
					return new KalturaSystemPartnerUsageFilter(xmlElement);
				case "KalturaClipAttributes":
					return new KalturaClipAttributes(xmlElement);
				case "KalturaAssetParamsResourceContainer":
					return new KalturaAssetParamsResourceContainer(xmlElement);
				case "KalturaAssetResource":
					return new KalturaAssetResource(xmlElement);
				case "KalturaAssetsParamsResourceContainers":
					return new KalturaAssetsParamsResourceContainers(xmlElement);
				case "KalturaDataCenterContentResource":
					return new KalturaDataCenterContentResource(xmlElement);
				case "KalturaEntryResource":
					return new KalturaEntryResource(xmlElement);
				case "KalturaFileSyncResource":
					return new KalturaFileSyncResource(xmlElement);
				case "KalturaOperationResource":
					return new KalturaOperationResource(xmlElement);
				case "KalturaUrlResource":
					return new KalturaUrlResource(xmlElement);
				case "KalturaRemoteStorageResource":
					return new KalturaRemoteStorageResource(xmlElement);
				case "KalturaRemoteStorageResources":
					return new KalturaRemoteStorageResources(xmlElement);
				case "KalturaServerFileResource":
					return new KalturaServerFileResource(xmlElement);
				case "KalturaSshUrlResource":
					return new KalturaSshUrlResource(xmlElement);
				case "KalturaUploadedFileTokenResource":
					return new KalturaUploadedFileTokenResource(xmlElement);
				case "KalturaWebcamTokenResource":
					return new KalturaWebcamTokenResource(xmlElement);
				case "KalturaDropFolderFileResource":
					return new KalturaDropFolderFileResource(xmlElement);
				case "KalturaAssetParamsOutput":
					return new KalturaAssetParamsOutput(xmlElement);
				case "KalturaFlavorParamsOutput":
					return new KalturaFlavorParamsOutput(xmlElement);
				case "KalturaMediaFlavorParamsOutput":
					return new KalturaMediaFlavorParamsOutput(xmlElement);
				case "KalturaMediaFlavorParams":
					return new KalturaMediaFlavorParams(xmlElement);
				case "KalturaThumbParamsOutput":
					return new KalturaThumbParamsOutput(xmlElement);
				case "KalturaDocumentFlavorParamsOutput":
					return new KalturaDocumentFlavorParamsOutput(xmlElement);
				case "KalturaDocumentFlavorParams":
					return new KalturaDocumentFlavorParams(xmlElement);
				case "KalturaPdfFlavorParamsOutput":
					return new KalturaPdfFlavorParamsOutput(xmlElement);
				case "KalturaPdfFlavorParams":
					return new KalturaPdfFlavorParams(xmlElement);
				case "KalturaSwfFlavorParamsOutput":
					return new KalturaSwfFlavorParamsOutput(xmlElement);
				case "KalturaSwfFlavorParams":
					return new KalturaSwfFlavorParams(xmlElement);
				case "KalturaApiActionPermissionItem":
					return new KalturaApiActionPermissionItem(xmlElement);
				case "KalturaApiParameterPermissionItem":
					return new KalturaApiParameterPermissionItem(xmlElement);
				case "KalturaGenericSyndicationFeed":
					return new KalturaGenericSyndicationFeed(xmlElement);
				case "KalturaGenericXsltSyndicationFeed":
					return new KalturaGenericXsltSyndicationFeed(xmlElement);
				case "KalturaGoogleVideoSyndicationFeed":
					return new KalturaGoogleVideoSyndicationFeed(xmlElement);
				case "KalturaITunesSyndicationFeed":
					return new KalturaITunesSyndicationFeed(xmlElement);
				case "KalturaTubeMogulSyndicationFeed":
					return new KalturaTubeMogulSyndicationFeed(xmlElement);
				case "KalturaYahooSyndicationFeed":
					return new KalturaYahooSyndicationFeed(xmlElement);
				case "KalturaUiConfAdmin":
					return new KalturaUiConfAdmin(xmlElement);
				case "KalturaAuditTrailChangeItem":
					return new KalturaAuditTrailChangeItem(xmlElement);
				case "KalturaAuditTrailChangeInfo":
					return new KalturaAuditTrailChangeInfo(xmlElement);
				case "KalturaAuditTrailFileSyncCreateInfo":
					return new KalturaAuditTrailFileSyncCreateInfo(xmlElement);
				case "KalturaAuditTrailTextInfo":
					return new KalturaAuditTrailTextInfo(xmlElement);
				case "KalturaDistributionFieldConfig":
					return new KalturaDistributionFieldConfig(xmlElement);
				case "KalturaConfigurableDistributionProfile":
					return new KalturaConfigurableDistributionProfile(xmlElement);
				case "KalturaGenericDistributionProfileAction":
					return new KalturaGenericDistributionProfileAction(xmlElement);
				case "KalturaGenericDistributionProfile":
					return new KalturaGenericDistributionProfile(xmlElement);
				case "KalturaSyndicationDistributionProfile":
					return new KalturaSyndicationDistributionProfile(xmlElement);
				case "KalturaAvnDistributionProfile":
					return new KalturaAvnDistributionProfile(xmlElement);
				case "KalturaComcastMrssDistributionProfile":
					return new KalturaComcastMrssDistributionProfile(xmlElement);
				case "KalturaDailymotionDistributionProfile":
					return new KalturaDailymotionDistributionProfile(xmlElement);
				case "KalturaDoubleClickDistributionProfile":
					return new KalturaDoubleClickDistributionProfile(xmlElement);
				case "KalturaExampleDistributionProfile":
					return new KalturaExampleDistributionProfile(xmlElement);
				case "KalturaFreewheelDistributionProfile":
					return new KalturaFreewheelDistributionProfile(xmlElement);
				case "KalturaFreewheelGenericDistributionProfile":
					return new KalturaFreewheelGenericDistributionProfile(xmlElement);
				case "KalturaHuluDistributionProfile":
					return new KalturaHuluDistributionProfile(xmlElement);
				case "KalturaIdeticDistributionProfile":
					return new KalturaIdeticDistributionProfile(xmlElement);
				case "KalturaPodcastDistributionProfile":
					return new KalturaPodcastDistributionProfile(xmlElement);
				case "KalturaSynacorHboDistributionProfile":
					return new KalturaSynacorHboDistributionProfile(xmlElement);
				case "KalturaTVComDistributionProfile":
					return new KalturaTVComDistributionProfile(xmlElement);
				case "KalturaYouTubeDistributionProfile":
					return new KalturaYouTubeDistributionProfile(xmlElement);
				case "KalturaYoutubeApiDistributionProfile":
					return new KalturaYoutubeApiDistributionProfile(xmlElement);
				case "KalturaDistributionValidationErrorInvalidData":
					return new KalturaDistributionValidationErrorInvalidData(xmlElement);
				case "KalturaDistributionValidationErrorInvalidMetadata":
					return new KalturaDistributionValidationErrorInvalidMetadata(xmlElement);
				case "KalturaDistributionValidationErrorMissingFlavor":
					return new KalturaDistributionValidationErrorMissingFlavor(xmlElement);
				case "KalturaDistributionValidationErrorMissingMetadata":
					return new KalturaDistributionValidationErrorMissingMetadata(xmlElement);
				case "KalturaDistributionValidationErrorMissingThumbnail":
					return new KalturaDistributionValidationErrorMissingThumbnail(xmlElement);
				case "KalturaSyndicationDistributionProvider":
					return new KalturaSyndicationDistributionProvider(xmlElement);
				case "KalturaAvnDistributionProvider":
					return new KalturaAvnDistributionProvider(xmlElement);
				case "KalturaComcastMrssDistributionProvider":
					return new KalturaComcastMrssDistributionProvider(xmlElement);
				case "KalturaDailymotionDistributionProvider":
					return new KalturaDailymotionDistributionProvider(xmlElement);
				case "KalturaDoubleClickDistributionProvider":
					return new KalturaDoubleClickDistributionProvider(xmlElement);
				case "KalturaExampleDistributionProvider":
					return new KalturaExampleDistributionProvider(xmlElement);
				case "KalturaFreewheelDistributionProvider":
					return new KalturaFreewheelDistributionProvider(xmlElement);
				case "KalturaFreewheelGenericDistributionProvider":
					return new KalturaFreewheelGenericDistributionProvider(xmlElement);
				case "KalturaHuluDistributionProvider":
					return new KalturaHuluDistributionProvider(xmlElement);
				case "KalturaIdeticDistributionProvider":
					return new KalturaIdeticDistributionProvider(xmlElement);
				case "KalturaPodcastDistributionProvider":
					return new KalturaPodcastDistributionProvider(xmlElement);
				case "KalturaSynacorHboDistributionProvider":
					return new KalturaSynacorHboDistributionProvider(xmlElement);
				case "KalturaTVComDistributionProvider":
					return new KalturaTVComDistributionProvider(xmlElement);
				case "KalturaYouTubeDistributionProvider":
					return new KalturaYouTubeDistributionProvider(xmlElement);
				case "KalturaYoutubeApiDistributionProvider":
					return new KalturaYoutubeApiDistributionProvider(xmlElement);
				case "KalturaAdCuePoint":
					return new KalturaAdCuePoint(xmlElement);
				case "KalturaCodeCuePoint":
					return new KalturaCodeCuePoint(xmlElement);
				case "KalturaDropFolderXmlBulkUploadFileHandlerConfig":
					return new KalturaDropFolderXmlBulkUploadFileHandlerConfig(xmlElement);
				case "KalturaDropFolderContentFileHandlerConfig":
					return new KalturaDropFolderContentFileHandlerConfig(xmlElement);
				case "KalturaRemoteDropFolder":
					return new KalturaRemoteDropFolder(xmlElement);
				case "KalturaFtpDropFolder":
					return new KalturaFtpDropFolder(xmlElement);
				case "KalturaSshDropFolder":
					return new KalturaSshDropFolder(xmlElement);
				case "KalturaScpDropFolder":
					return new KalturaScpDropFolder(xmlElement);
				case "KalturaSftpDropFolder":
					return new KalturaSftpDropFolder(xmlElement);
			}
			throw new SerializationException("Invalid object type");
		}
	}
}
