namespace Kaltura
{
	public sealed class KalturaFileSyncOrderBy : KalturaStringEnum
	{
		public static readonly KalturaFileSyncOrderBy CREATED_AT_ASC = new KalturaFileSyncOrderBy("+createdAt");
		public static readonly KalturaFileSyncOrderBy CREATED_AT_DESC = new KalturaFileSyncOrderBy("-createdAt");
		public static readonly KalturaFileSyncOrderBy UPDATED_AT_ASC = new KalturaFileSyncOrderBy("+updatedAt");
		public static readonly KalturaFileSyncOrderBy UPDATED_AT_DESC = new KalturaFileSyncOrderBy("-updatedAt");
		public static readonly KalturaFileSyncOrderBy READY_AT_ASC = new KalturaFileSyncOrderBy("+readyAt");
		public static readonly KalturaFileSyncOrderBy READY_AT_DESC = new KalturaFileSyncOrderBy("-readyAt");
		public static readonly KalturaFileSyncOrderBy SYNC_TIME_ASC = new KalturaFileSyncOrderBy("+syncTime");
		public static readonly KalturaFileSyncOrderBy SYNC_TIME_DESC = new KalturaFileSyncOrderBy("-syncTime");
		public static readonly KalturaFileSyncOrderBy FILE_SIZE_ASC = new KalturaFileSyncOrderBy("+fileSize");
		public static readonly KalturaFileSyncOrderBy FILE_SIZE_DESC = new KalturaFileSyncOrderBy("-fileSize");

		private KalturaFileSyncOrderBy(string name) : base(name) { }
	}
}
