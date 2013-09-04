using System.Configuration;

namespace BlogEngine.Core.KuyamExtensions.KalturaClient
{

    /// <summary>
    /// Kaltura Config Manager
    /// </summary>
    public static class KalturaConfigManager
    {
        #region Constants and Fields

        private const string KulturaPartnerId = "PARTNER_ID";
        private const string KulturaSecret = "SECRET";
        private const string KulturaAdminSecret = "ADMIN_SECRET";
        private const string KulturaServiceUrl = "SERVICE_URL";
        private const string KulturaUserId = "USER_ID";

        /// <summary>
        /// Meta DataField Name
        /// </summary>
        public const string MetaDataFieldName = "SubtitleFormat";
        /// <summary>
        /// Field Value
        /// </summary>
        public const string FieldValue = "VobSub";
        /// <summary>
        /// Xsd File
        /// </summary>
        public const string XsdFile = "MetadataSchema.xsd";

        #endregion

        #region Properties 

        /// <summary>
        /// Kultura partner id
        /// </summary>
        public static int Kulturapartnerid
        {
            get
            {
                if (ConfigurationManager.AppSettings[KulturaPartnerId] == null)
                {
                    return 0;
                }
                int partnerId;
                int.TryParse(ConfigurationManager.AppSettings[KulturaPartnerId], out partnerId);
                return partnerId;
            }
        }

        /// <summary>
        /// Kultura secret
        /// </summary>
        public static string Kulturasecret
        {
            get {
                return ConfigurationManager.AppSettings[KulturaSecret] ?? string.Empty;
            }
        }

        /// <summary>
        /// Kultura admin secret
        /// </summary>
        public static string Kulturaadminsecret
        {
            get {
                return ConfigurationManager.AppSettings[KulturaAdminSecret] ?? string.Empty;
            }
        }

        /// <summary>
        /// Kultura service url
        /// </summary>
        public static string Kulturaserviceurl
        {
            get {
                return ConfigurationManager.AppSettings[KulturaServiceUrl] ?? string.Empty;
            }
        }

        /// <summary>
        /// Kultura user id
        /// </summary>
        public static string Kulturauserid
        {
            get {
                return ConfigurationManager.AppSettings[KulturaUserId] ?? string.Empty;
            }
        }

        #endregion
    }
}
