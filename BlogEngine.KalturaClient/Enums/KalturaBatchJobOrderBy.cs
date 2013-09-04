namespace Kaltura
{
	public sealed class KalturaBatchJobOrderBy : KalturaStringEnum
	{
		public static readonly KalturaBatchJobOrderBy STATUS_ASC = new KalturaBatchJobOrderBy("+status");
		public static readonly KalturaBatchJobOrderBy STATUS_DESC = new KalturaBatchJobOrderBy("-status");
		public static readonly KalturaBatchJobOrderBy CHECK_AGAIN_TIMEOUT_ASC = new KalturaBatchJobOrderBy("+checkAgainTimeout");
		public static readonly KalturaBatchJobOrderBy CHECK_AGAIN_TIMEOUT_DESC = new KalturaBatchJobOrderBy("-checkAgainTimeout");
		public static readonly KalturaBatchJobOrderBy PROGRESS_ASC = new KalturaBatchJobOrderBy("+progress");
		public static readonly KalturaBatchJobOrderBy PROGRESS_DESC = new KalturaBatchJobOrderBy("-progress");
		public static readonly KalturaBatchJobOrderBy UPDATES_COUNT_ASC = new KalturaBatchJobOrderBy("+updatesCount");
		public static readonly KalturaBatchJobOrderBy UPDATES_COUNT_DESC = new KalturaBatchJobOrderBy("-updatesCount");
		public static readonly KalturaBatchJobOrderBy PRIORITY_ASC = new KalturaBatchJobOrderBy("+priority");
		public static readonly KalturaBatchJobOrderBy PRIORITY_DESC = new KalturaBatchJobOrderBy("-priority");
		public static readonly KalturaBatchJobOrderBy QUEUE_TIME_ASC = new KalturaBatchJobOrderBy("+queueTime");
		public static readonly KalturaBatchJobOrderBy QUEUE_TIME_DESC = new KalturaBatchJobOrderBy("-queueTime");
		public static readonly KalturaBatchJobOrderBy FINISH_TIME_ASC = new KalturaBatchJobOrderBy("+finishTime");
		public static readonly KalturaBatchJobOrderBy FINISH_TIME_DESC = new KalturaBatchJobOrderBy("-finishTime");
		public static readonly KalturaBatchJobOrderBy FILE_SIZE_ASC = new KalturaBatchJobOrderBy("+fileSize");
		public static readonly KalturaBatchJobOrderBy FILE_SIZE_DESC = new KalturaBatchJobOrderBy("-fileSize");
		public static readonly KalturaBatchJobOrderBy CREATED_AT_ASC = new KalturaBatchJobOrderBy("+createdAt");
		public static readonly KalturaBatchJobOrderBy CREATED_AT_DESC = new KalturaBatchJobOrderBy("-createdAt");
		public static readonly KalturaBatchJobOrderBy UPDATED_AT_ASC = new KalturaBatchJobOrderBy("+updatedAt");
		public static readonly KalturaBatchJobOrderBy UPDATED_AT_DESC = new KalturaBatchJobOrderBy("-updatedAt");
		public static readonly KalturaBatchJobOrderBy PROCESSOR_EXPIRATION_ASC = new KalturaBatchJobOrderBy("+processorExpiration");
		public static readonly KalturaBatchJobOrderBy PROCESSOR_EXPIRATION_DESC = new KalturaBatchJobOrderBy("-processorExpiration");
		public static readonly KalturaBatchJobOrderBy EXECUTION_ATTEMPTS_ASC = new KalturaBatchJobOrderBy("+executionAttempts");
		public static readonly KalturaBatchJobOrderBy EXECUTION_ATTEMPTS_DESC = new KalturaBatchJobOrderBy("-executionAttempts");
		public static readonly KalturaBatchJobOrderBy LOCK_VERSION_ASC = new KalturaBatchJobOrderBy("+lockVersion");
		public static readonly KalturaBatchJobOrderBy LOCK_VERSION_DESC = new KalturaBatchJobOrderBy("-lockVersion");

		private KalturaBatchJobOrderBy(string name) : base(name) { }
	}
}
