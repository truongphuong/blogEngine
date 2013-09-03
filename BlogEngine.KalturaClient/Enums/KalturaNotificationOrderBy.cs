namespace Kaltura
{
	public sealed class KalturaNotificationOrderBy : KalturaStringEnum
	{
		public static readonly KalturaNotificationOrderBy CREATED_AT_ASC = new KalturaNotificationOrderBy("+createdAt");
		public static readonly KalturaNotificationOrderBy CREATED_AT_DESC = new KalturaNotificationOrderBy("-createdAt");
		public static readonly KalturaNotificationOrderBy UPDATED_AT_ASC = new KalturaNotificationOrderBy("+updatedAt");
		public static readonly KalturaNotificationOrderBy UPDATED_AT_DESC = new KalturaNotificationOrderBy("-updatedAt");
		public static readonly KalturaNotificationOrderBy PROCESSOR_EXPIRATION_ASC = new KalturaNotificationOrderBy("+processorExpiration");
		public static readonly KalturaNotificationOrderBy PROCESSOR_EXPIRATION_DESC = new KalturaNotificationOrderBy("-processorExpiration");
		public static readonly KalturaNotificationOrderBy EXECUTION_ATTEMPTS_ASC = new KalturaNotificationOrderBy("+executionAttempts");
		public static readonly KalturaNotificationOrderBy EXECUTION_ATTEMPTS_DESC = new KalturaNotificationOrderBy("-executionAttempts");
		public static readonly KalturaNotificationOrderBy LOCK_VERSION_ASC = new KalturaNotificationOrderBy("+lockVersion");
		public static readonly KalturaNotificationOrderBy LOCK_VERSION_DESC = new KalturaNotificationOrderBy("-lockVersion");

		private KalturaNotificationOrderBy(string name) : base(name) { }
	}
}
