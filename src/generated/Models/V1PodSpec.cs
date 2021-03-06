// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// PodSpec is a description of a pod.
    /// </summary>
    public partial class V1PodSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1PodSpec class.
        /// </summary>
        public V1PodSpec()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1PodSpec class.
        /// </summary>
        /// <param name="containers">List of containers belonging to the pod.
        /// Containers cannot currently be added or removed. There must be at
        /// least one container in a Pod. Cannot be updated. More info:
        /// http://kubernetes.io/docs/user-guide/containers</param>
        /// <param name="activeDeadlineSeconds">Optional duration in seconds
        /// the pod may be active on the node relative to StartTime before the
        /// system will actively try to mark it failed and kill associated
        /// containers. Value must be a positive integer.</param>
        /// <param name="affinity">If specified, the pod's scheduling
        /// constraints</param>
        /// <param
        /// name="automountServiceAccountToken">AutomountServiceAccountToken
        /// indicates whether a service account token should be automatically
        /// mounted.</param>
        /// <param name="dnsPolicy">Set DNS policy for containers within the
        /// pod. One of 'ClusterFirstWithHostNet', 'ClusterFirst' or 'Default'.
        /// Defaults to "ClusterFirst". To have DNS options set along with
        /// hostNetwork, you have to specify DNS policy explicitly to
        /// 'ClusterFirstWithHostNet'.</param>
        /// <param name="hostIPC">Use the host's ipc namespace. Optional:
        /// Default to false.</param>
        /// <param name="hostNetwork">Host networking requested for this pod.
        /// Use the host's network namespace. If this option is set, the ports
        /// that will be used must be specified. Default to false.</param>
        /// <param name="hostPID">Use the host's pid namespace. Optional:
        /// Default to false.</param>
        /// <param name="hostname">Specifies the hostname of the Pod If not
        /// specified, the pod's hostname will be set to a system-defined
        /// value.</param>
        /// <param name="imagePullSecrets">ImagePullSecrets is an optional list
        /// of references to secrets in the same namespace to use for pulling
        /// any of the images used by this PodSpec. If specified, these secrets
        /// will be passed to individual puller implementations for them to
        /// use. For example, in the case of docker, only DockerConfig type
        /// secrets are honored. More info:
        /// http://kubernetes.io/docs/user-guide/images#specifying-imagepullsecrets-on-a-pod</param>
        /// <param name="initContainers">List of initialization containers
        /// belonging to the pod. Init containers are executed in order prior
        /// to containers being started. If any init container fails, the pod
        /// is considered to have failed and is handled according to its
        /// restartPolicy. The name for an init container or normal container
        /// must be unique among all containers. Init containers may not have
        /// Lifecycle actions, Readiness probes, or Liveness probes. The
        /// resourceRequirements of an init container are taken into account
        /// during scheduling by finding the highest request/limit for each
        /// resource type, and then using the max of of that value or the sum
        /// of the normal containers. Limits are applied to init containers in
        /// a similar fashion. Init containers cannot currently be added or
        /// removed. Cannot be updated. More info:
        /// http://kubernetes.io/docs/user-guide/containers</param>
        /// <param name="nodeName">NodeName is a request to schedule this pod
        /// onto a specific node. If it is non-empty, the scheduler simply
        /// schedules this pod onto that node, assuming that it fits resource
        /// requirements.</param>
        /// <param name="nodeSelector">NodeSelector is a selector which must be
        /// true for the pod to fit on a node. Selector which must match a
        /// node's labels for the pod to be scheduled on that node. More info:
        /// http://kubernetes.io/docs/user-guide/node-selection/README</param>
        /// <param name="restartPolicy">Restart policy for all containers
        /// within the pod. One of Always, OnFailure, Never. Default to Always.
        /// More info:
        /// http://kubernetes.io/docs/user-guide/pod-states#restartpolicy</param>
        /// <param name="schedulerName">If specified, the pod will be
        /// dispatched by specified scheduler. If not specified, the pod will
        /// be dispatched by default scheduler.</param>
        /// <param name="securityContext">SecurityContext holds pod-level
        /// security attributes and common container settings. Optional:
        /// Defaults to empty.  See type description for default values of each
        /// field.</param>
        /// <param name="serviceAccount">DeprecatedServiceAccount is a
        /// depreciated alias for ServiceAccountName. Deprecated: Use
        /// serviceAccountName instead.</param>
        /// <param name="serviceAccountName">ServiceAccountName is the name of
        /// the ServiceAccount to use to run this pod. More info:
        /// http://releases.k8s.io/HEAD/docs/design/service_accounts.md</param>
        /// <param name="subdomain">If specified, the fully qualified Pod
        /// hostname will be "&lt;hostname&gt;.&lt;subdomain&gt;.&lt;pod
        /// namespace&gt;.svc.&lt;cluster domain&gt;". If not specified, the
        /// pod will not have a domainname at all.</param>
        /// <param name="terminationGracePeriodSeconds">Optional duration in
        /// seconds the pod needs to terminate gracefully. May be decreased in
        /// delete request. Value must be non-negative integer. The value zero
        /// indicates delete immediately. If this value is nil, the default
        /// grace period will be used instead. The grace period is the duration
        /// in seconds after the processes running in the pod are sent a
        /// termination signal and the time when the processes are forcibly
        /// halted with a kill signal. Set this value longer than the expected
        /// cleanup time for your process. Defaults to 30 seconds.</param>
        /// <param name="tolerations">If specified, the pod's
        /// tolerations.</param>
        /// <param name="volumes">List of volumes that can be mounted by
        /// containers belonging to the pod. More info:
        /// http://kubernetes.io/docs/user-guide/volumes</param>
        public V1PodSpec(IList<V1Container> containers, long? activeDeadlineSeconds = default(long?), V1Affinity affinity = default(V1Affinity), bool? automountServiceAccountToken = default(bool?), string dnsPolicy = default(string), bool? hostIPC = default(bool?), bool? hostNetwork = default(bool?), bool? hostPID = default(bool?), string hostname = default(string), IList<V1LocalObjectReference> imagePullSecrets = default(IList<V1LocalObjectReference>), IList<V1Container> initContainers = default(IList<V1Container>), string nodeName = default(string), IDictionary<string, string> nodeSelector = default(IDictionary<string, string>), string restartPolicy = default(string), string schedulerName = default(string), V1PodSecurityContext securityContext = default(V1PodSecurityContext), string serviceAccount = default(string), string serviceAccountName = default(string), string subdomain = default(string), long? terminationGracePeriodSeconds = default(long?), IList<V1Toleration> tolerations = default(IList<V1Toleration>), IList<V1Volume> volumes = default(IList<V1Volume>))
        {
            ActiveDeadlineSeconds = activeDeadlineSeconds;
            Affinity = affinity;
            AutomountServiceAccountToken = automountServiceAccountToken;
            Containers = containers;
            DnsPolicy = dnsPolicy;
            HostIPC = hostIPC;
            HostNetwork = hostNetwork;
            HostPID = hostPID;
            Hostname = hostname;
            ImagePullSecrets = imagePullSecrets;
            InitContainers = initContainers;
            NodeName = nodeName;
            NodeSelector = nodeSelector;
            RestartPolicy = restartPolicy;
            SchedulerName = schedulerName;
            SecurityContext = securityContext;
            ServiceAccount = serviceAccount;
            ServiceAccountName = serviceAccountName;
            Subdomain = subdomain;
            TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            Tolerations = tolerations;
            Volumes = volumes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets optional duration in seconds the pod may be active on
        /// the node relative to StartTime before the system will actively try
        /// to mark it failed and kill associated containers. Value must be a
        /// positive integer.
        /// </summary>
        [JsonProperty(PropertyName = "activeDeadlineSeconds")]
        public long? ActiveDeadlineSeconds { get; set; }

        /// <summary>
        /// Gets or sets if specified, the pod's scheduling constraints
        /// </summary>
        [JsonProperty(PropertyName = "affinity")]
        public V1Affinity Affinity { get; set; }

        /// <summary>
        /// Gets or sets automountServiceAccountToken indicates whether a
        /// service account token should be automatically mounted.
        /// </summary>
        [JsonProperty(PropertyName = "automountServiceAccountToken")]
        public bool? AutomountServiceAccountToken { get; set; }

        /// <summary>
        /// Gets or sets list of containers belonging to the pod. Containers
        /// cannot currently be added or removed. There must be at least one
        /// container in a Pod. Cannot be updated. More info:
        /// http://kubernetes.io/docs/user-guide/containers
        /// </summary>
        [JsonProperty(PropertyName = "containers")]
        public IList<V1Container> Containers { get; set; }

        /// <summary>
        /// Gets or sets set DNS policy for containers within the pod. One of
        /// 'ClusterFirstWithHostNet', 'ClusterFirst' or 'Default'. Defaults to
        /// "ClusterFirst". To have DNS options set along with hostNetwork, you
        /// have to specify DNS policy explicitly to 'ClusterFirstWithHostNet'.
        /// </summary>
        [JsonProperty(PropertyName = "dnsPolicy")]
        public string DnsPolicy { get; set; }

        /// <summary>
        /// Gets or sets use the host's ipc namespace. Optional: Default to
        /// false.
        /// </summary>
        [JsonProperty(PropertyName = "hostIPC")]
        public bool? HostIPC { get; set; }

        /// <summary>
        /// Gets or sets host networking requested for this pod. Use the host's
        /// network namespace. If this option is set, the ports that will be
        /// used must be specified. Default to false.
        /// </summary>
        [JsonProperty(PropertyName = "hostNetwork")]
        public bool? HostNetwork { get; set; }

        /// <summary>
        /// Gets or sets use the host's pid namespace. Optional: Default to
        /// false.
        /// </summary>
        [JsonProperty(PropertyName = "hostPID")]
        public bool? HostPID { get; set; }

        /// <summary>
        /// Gets or sets specifies the hostname of the Pod If not specified,
        /// the pod's hostname will be set to a system-defined value.
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// Gets or sets imagePullSecrets is an optional list of references to
        /// secrets in the same namespace to use for pulling any of the images
        /// used by this PodSpec. If specified, these secrets will be passed to
        /// individual puller implementations for them to use. For example, in
        /// the case of docker, only DockerConfig type secrets are honored.
        /// More info:
        /// http://kubernetes.io/docs/user-guide/images#specifying-imagepullsecrets-on-a-pod
        /// </summary>
        [JsonProperty(PropertyName = "imagePullSecrets")]
        public IList<V1LocalObjectReference> ImagePullSecrets { get; set; }

        /// <summary>
        /// Gets or sets list of initialization containers belonging to the
        /// pod. Init containers are executed in order prior to containers
        /// being started. If any init container fails, the pod is considered
        /// to have failed and is handled according to its restartPolicy. The
        /// name for an init container or normal container must be unique among
        /// all containers. Init containers may not have Lifecycle actions,
        /// Readiness probes, or Liveness probes. The resourceRequirements of
        /// an init container are taken into account during scheduling by
        /// finding the highest request/limit for each resource type, and then
        /// using the max of of that value or the sum of the normal containers.
        /// Limits are applied to init containers in a similar fashion. Init
        /// containers cannot currently be added or removed. Cannot be updated.
        /// More info: http://kubernetes.io/docs/user-guide/containers
        /// </summary>
        [JsonProperty(PropertyName = "initContainers")]
        public IList<V1Container> InitContainers { get; set; }

        /// <summary>
        /// Gets or sets nodeName is a request to schedule this pod onto a
        /// specific node. If it is non-empty, the scheduler simply schedules
        /// this pod onto that node, assuming that it fits resource
        /// requirements.
        /// </summary>
        [JsonProperty(PropertyName = "nodeName")]
        public string NodeName { get; set; }

        /// <summary>
        /// Gets or sets nodeSelector is a selector which must be true for the
        /// pod to fit on a node. Selector which must match a node's labels for
        /// the pod to be scheduled on that node. More info:
        /// http://kubernetes.io/docs/user-guide/node-selection/README
        /// </summary>
        [JsonProperty(PropertyName = "nodeSelector")]
        public IDictionary<string, string> NodeSelector { get; set; }

        /// <summary>
        /// Gets or sets restart policy for all containers within the pod. One
        /// of Always, OnFailure, Never. Default to Always. More info:
        /// http://kubernetes.io/docs/user-guide/pod-states#restartpolicy
        /// </summary>
        [JsonProperty(PropertyName = "restartPolicy")]
        public string RestartPolicy { get; set; }

        /// <summary>
        /// Gets or sets if specified, the pod will be dispatched by specified
        /// scheduler. If not specified, the pod will be dispatched by default
        /// scheduler.
        /// </summary>
        [JsonProperty(PropertyName = "schedulerName")]
        public string SchedulerName { get; set; }

        /// <summary>
        /// Gets or sets securityContext holds pod-level security attributes
        /// and common container settings. Optional: Defaults to empty.  See
        /// type description for default values of each field.
        /// </summary>
        [JsonProperty(PropertyName = "securityContext")]
        public V1PodSecurityContext SecurityContext { get; set; }

        /// <summary>
        /// Gets or sets deprecatedServiceAccount is a depreciated alias for
        /// ServiceAccountName. Deprecated: Use serviceAccountName instead.
        /// </summary>
        [JsonProperty(PropertyName = "serviceAccount")]
        public string ServiceAccount { get; set; }

        /// <summary>
        /// Gets or sets serviceAccountName is the name of the ServiceAccount
        /// to use to run this pod. More info:
        /// http://releases.k8s.io/HEAD/docs/design/service_accounts.md
        /// </summary>
        [JsonProperty(PropertyName = "serviceAccountName")]
        public string ServiceAccountName { get; set; }

        /// <summary>
        /// Gets or sets if specified, the fully qualified Pod hostname will be
        /// "&amp;lt;hostname&amp;gt;.&amp;lt;subdomain&amp;gt;.&amp;lt;pod
        /// namespace&amp;gt;.svc.&amp;lt;cluster domain&amp;gt;". If not
        /// specified, the pod will not have a domainname at all.
        /// </summary>
        [JsonProperty(PropertyName = "subdomain")]
        public string Subdomain { get; set; }

        /// <summary>
        /// Gets or sets optional duration in seconds the pod needs to
        /// terminate gracefully. May be decreased in delete request. Value
        /// must be non-negative integer. The value zero indicates delete
        /// immediately. If this value is nil, the default grace period will be
        /// used instead. The grace period is the duration in seconds after the
        /// processes running in the pod are sent a termination signal and the
        /// time when the processes are forcibly halted with a kill signal. Set
        /// this value longer than the expected cleanup time for your process.
        /// Defaults to 30 seconds.
        /// </summary>
        [JsonProperty(PropertyName = "terminationGracePeriodSeconds")]
        public long? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// Gets or sets if specified, the pod's tolerations.
        /// </summary>
        [JsonProperty(PropertyName = "tolerations")]
        public IList<V1Toleration> Tolerations { get; set; }

        /// <summary>
        /// Gets or sets list of volumes that can be mounted by containers
        /// belonging to the pod. More info:
        /// http://kubernetes.io/docs/user-guide/volumes
        /// </summary>
        [JsonProperty(PropertyName = "volumes")]
        public IList<V1Volume> Volumes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Containers == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Containers");
            }
            if (Affinity != null)
            {
                Affinity.Validate();
            }
            if (Containers != null)
            {
                foreach (var element in Containers)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (InitContainers != null)
            {
                foreach (var element1 in InitContainers)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (Volumes != null)
            {
                foreach (var element2 in Volumes)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
