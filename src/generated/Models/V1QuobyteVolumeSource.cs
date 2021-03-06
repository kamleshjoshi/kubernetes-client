// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a Quobyte mount that lasts the lifetime of a pod. Quobyte
    /// volumes do not support ownership management or SELinux relabeling.
    /// </summary>
    public partial class V1QuobyteVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the V1QuobyteVolumeSource class.
        /// </summary>
        public V1QuobyteVolumeSource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1QuobyteVolumeSource class.
        /// </summary>
        /// <param name="registry">Registry represents a single or multiple
        /// Quobyte Registry services specified as a string as host:port pair
        /// (multiple entries are separated with commas) which acts as the
        /// central registry for volumes</param>
        /// <param name="volume">Volume is a string that references an already
        /// created Quobyte volume by name.</param>
        /// <param name="group">Group to map volume access to Default is no
        /// group</param>
        /// <param name="readOnlyProperty">ReadOnly here will force the Quobyte
        /// volume to be mounted with read-only permissions. Defaults to
        /// false.</param>
        /// <param name="user">User to map volume access to Defaults to
        /// serivceaccount user</param>
        public V1QuobyteVolumeSource(string registry, string volume, string group = default(string), bool? readOnlyProperty = default(bool?), string user = default(string))
        {
            Group = group;
            ReadOnlyProperty = readOnlyProperty;
            Registry = registry;
            User = user;
            Volume = volume;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets group to map volume access to Default is no group
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets readOnly here will force the Quobyte volume to be
        /// mounted with read-only permissions. Defaults to false.
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Gets or sets registry represents a single or multiple Quobyte
        /// Registry services specified as a string as host:port pair (multiple
        /// entries are separated with commas) which acts as the central
        /// registry for volumes
        /// </summary>
        [JsonProperty(PropertyName = "registry")]
        public string Registry { get; set; }

        /// <summary>
        /// Gets or sets user to map volume access to Defaults to
        /// serivceaccount user
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        /// <summary>
        /// Gets or sets volume is a string that references an already created
        /// Quobyte volume by name.
        /// </summary>
        [JsonProperty(PropertyName = "volume")]
        public string Volume { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Registry == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Registry");
            }
            if (Volume == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Volume");
            }
        }
    }
}
