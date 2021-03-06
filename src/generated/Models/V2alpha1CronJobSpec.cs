// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// CronJobSpec describes how the job execution will look like and when it
    /// will actually run.
    /// </summary>
    public partial class V2alpha1CronJobSpec
    {
        /// <summary>
        /// Initializes a new instance of the V2alpha1CronJobSpec class.
        /// </summary>
        public V2alpha1CronJobSpec()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V2alpha1CronJobSpec class.
        /// </summary>
        /// <param name="jobTemplate">JobTemplate is the object that describes
        /// the job that will be created when executing a CronJob.</param>
        /// <param name="schedule">Schedule contains the schedule in Cron
        /// format, see https://en.wikipedia.org/wiki/Cron.</param>
        /// <param name="concurrencyPolicy">ConcurrencyPolicy specifies how to
        /// treat concurrent executions of a Job.</param>
        /// <param name="failedJobsHistoryLimit">The number of failed finished
        /// jobs to retain. This is a pointer to distinguish between explicit
        /// zero and not specified.</param>
        /// <param name="startingDeadlineSeconds">Optional deadline in seconds
        /// for starting the job if it misses scheduled time for any reason.
        /// Missed jobs executions will be counted as failed ones.</param>
        /// <param name="successfulJobsHistoryLimit">The number of successful
        /// finished jobs to retain. This is a pointer to distinguish between
        /// explicit zero and not specified.</param>
        /// <param name="suspend">Suspend flag tells the controller to suspend
        /// subsequent executions, it does not apply to already started
        /// executions.  Defaults to false.</param>
        public V2alpha1CronJobSpec(V2alpha1JobTemplateSpec jobTemplate, string schedule, string concurrencyPolicy = default(string), int? failedJobsHistoryLimit = default(int?), long? startingDeadlineSeconds = default(long?), int? successfulJobsHistoryLimit = default(int?), bool? suspend = default(bool?))
        {
            ConcurrencyPolicy = concurrencyPolicy;
            FailedJobsHistoryLimit = failedJobsHistoryLimit;
            JobTemplate = jobTemplate;
            Schedule = schedule;
            StartingDeadlineSeconds = startingDeadlineSeconds;
            SuccessfulJobsHistoryLimit = successfulJobsHistoryLimit;
            Suspend = suspend;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets concurrencyPolicy specifies how to treat concurrent
        /// executions of a Job.
        /// </summary>
        [JsonProperty(PropertyName = "concurrencyPolicy")]
        public string ConcurrencyPolicy { get; set; }

        /// <summary>
        /// Gets or sets the number of failed finished jobs to retain. This is
        /// a pointer to distinguish between explicit zero and not specified.
        /// </summary>
        [JsonProperty(PropertyName = "failedJobsHistoryLimit")]
        public int? FailedJobsHistoryLimit { get; set; }

        /// <summary>
        /// Gets or sets jobTemplate is the object that describes the job that
        /// will be created when executing a CronJob.
        /// </summary>
        [JsonProperty(PropertyName = "jobTemplate")]
        public V2alpha1JobTemplateSpec JobTemplate { get; set; }

        /// <summary>
        /// Gets or sets schedule contains the schedule in Cron format, see
        /// https://en.wikipedia.org/wiki/Cron.
        /// </summary>
        [JsonProperty(PropertyName = "schedule")]
        public string Schedule { get; set; }

        /// <summary>
        /// Gets or sets optional deadline in seconds for starting the job if
        /// it misses scheduled time for any reason.  Missed jobs executions
        /// will be counted as failed ones.
        /// </summary>
        [JsonProperty(PropertyName = "startingDeadlineSeconds")]
        public long? StartingDeadlineSeconds { get; set; }

        /// <summary>
        /// Gets or sets the number of successful finished jobs to retain. This
        /// is a pointer to distinguish between explicit zero and not
        /// specified.
        /// </summary>
        [JsonProperty(PropertyName = "successfulJobsHistoryLimit")]
        public int? SuccessfulJobsHistoryLimit { get; set; }

        /// <summary>
        /// Gets or sets suspend flag tells the controller to suspend
        /// subsequent executions, it does not apply to already started
        /// executions.  Defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "suspend")]
        public bool? Suspend { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (JobTemplate == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "JobTemplate");
            }
            if (Schedule == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Schedule");
            }
            if (JobTemplate != null)
            {
                JobTemplate.Validate();
            }
        }
    }
}
