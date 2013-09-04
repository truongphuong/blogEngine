namespace Kaltura
{
	public enum KalturaBatchJobStatus
	{
		PENDING = 0,
		QUEUED = 1,
		PROCESSING = 2,
		PROCESSED = 3,
		MOVEFILE = 4,
		FINISHED = 5,
		FAILED = 6,
		ABORTED = 7,
		ALMOST_DONE = 8,
		RETRY = 9,
		FATAL = 10,
		DONT_PROCESS = 11,
	}
}
