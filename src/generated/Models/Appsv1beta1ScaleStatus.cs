// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ScaleStatus represents the current status of a scale subresource.
    /// </summary>
    public partial class Appsv1beta1ScaleStatus
    {
        /// <summary>
        /// Initializes a new instance of the Appsv1beta1ScaleStatus class.
        /// </summary>
        public Appsv1beta1ScaleStatus()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Appsv1beta1ScaleStatus class.
        /// </summary>
        /// <param name="replicas">actual number of observed instances of the
        /// scaled object.</param>
        /// <param name="selector">label query over pods that should match the
        /// replicas count. More info:
        /// http://kubernetes.io/docs/user-guide/labels#label-selectors</param>
        /// <param name="targetSelector">label selector for pods that should
        /// match the replicas count. This is a serializated version of both
        /// map-based and more expressive set-based selectors. This is done to
        /// avoid introspection in the clients. The string will be in the same
        /// format as the query-param syntax. If the target type only supports
        /// map-based selectors, both this field and map-based selector field
        /// are populated. More info:
        /// http://kubernetes.io/docs/user-guide/labels#label-selectors</param>
        public Appsv1beta1ScaleStatus(int replicas, IDictionary<string, string> selector = default(IDictionary<string, string>), string targetSelector = default(string))
        {
            Replicas = replicas;
            Selector = selector;
            TargetSelector = targetSelector;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets actual number of observed instances of the scaled
        /// object.
        /// </summary>
        [JsonProperty(PropertyName = "replicas")]
        public int Replicas { get; set; }

        /// <summary>
        /// Gets or sets label query over pods that should match the replicas
        /// count. More info:
        /// http://kubernetes.io/docs/user-guide/labels#label-selectors
        /// </summary>
        [JsonProperty(PropertyName = "selector")]
        public IDictionary<string, string> Selector { get; set; }

        /// <summary>
        /// Gets or sets label selector for pods that should match the replicas
        /// count. This is a serializated version of both map-based and more
        /// expressive set-based selectors. This is done to avoid introspection
        /// in the clients. The string will be in the same format as the
        /// query-param syntax. If the target type only supports map-based
        /// selectors, both this field and map-based selector field are
        /// populated. More info:
        /// http://kubernetes.io/docs/user-guide/labels#label-selectors
        /// </summary>
        [JsonProperty(PropertyName = "targetSelector")]
        public string TargetSelector { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
