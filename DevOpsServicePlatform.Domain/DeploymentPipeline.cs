namespace DevOpsServicePlatform.Domain;

    public class DeploymentPipeline
    {
        public int Id { get; set; }
        public int DevProjectId { get; set; }
        public DevProject DevProject { get; set; } = default!;
        public PipelineStatus Status { get; set; } = PipelineStatus.Queued;
        public string? ExecutionLog { get; set; }
        public DateTime TriggeredAtUtc { get; set; } = DateTime.UtcNow;
        public DateTime? FinishedAtUtc { get; set; }
    }

