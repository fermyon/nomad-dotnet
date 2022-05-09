/*
 * Nomad
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.1.4
 * Contact: support@hashicorp.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Fermyon.Nomad.Client.OpenAPIDateConverter;

namespace Fermyon.Nomad.Model
{
    /// <summary>
    /// NamespaceCapabilities
    /// </summary>
    [DataContract(Name = "NamespaceCapabilities")]
    public partial class NamespaceCapabilities : IEquatable<NamespaceCapabilities>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceCapabilities" /> class.
        /// </summary>
        /// <param name="disabledTaskDrivers">disabledTaskDrivers.</param>
        /// <param name="enabledTaskDrivers">enabledTaskDrivers.</param>
        public NamespaceCapabilities(List<string> disabledTaskDrivers = default(List<string>), List<string> enabledTaskDrivers = default(List<string>))
        {
            this.DisabledTaskDrivers = disabledTaskDrivers;
            this.EnabledTaskDrivers = enabledTaskDrivers;
        }

        /// <summary>
        /// Gets or Sets DisabledTaskDrivers
        /// </summary>
        [DataMember(Name = "DisabledTaskDrivers", EmitDefaultValue = false)]
        public List<string> DisabledTaskDrivers { get; set; }

        /// <summary>
        /// Gets or Sets EnabledTaskDrivers
        /// </summary>
        [DataMember(Name = "EnabledTaskDrivers", EmitDefaultValue = false)]
        public List<string> EnabledTaskDrivers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NamespaceCapabilities {\n");
            sb.Append("  DisabledTaskDrivers: ").Append(DisabledTaskDrivers).Append("\n");
            sb.Append("  EnabledTaskDrivers: ").Append(EnabledTaskDrivers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NamespaceCapabilities);
        }

        /// <summary>
        /// Returns true if NamespaceCapabilities instances are equal
        /// </summary>
        /// <param name="input">Instance of NamespaceCapabilities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NamespaceCapabilities input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisabledTaskDrivers == input.DisabledTaskDrivers ||
                    this.DisabledTaskDrivers != null &&
                    input.DisabledTaskDrivers != null &&
                    this.DisabledTaskDrivers.SequenceEqual(input.DisabledTaskDrivers)
                ) && 
                (
                    this.EnabledTaskDrivers == input.EnabledTaskDrivers ||
                    this.EnabledTaskDrivers != null &&
                    input.EnabledTaskDrivers != null &&
                    this.EnabledTaskDrivers.SequenceEqual(input.EnabledTaskDrivers)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DisabledTaskDrivers != null)
                {
                    hashCode = (hashCode * 59) + this.DisabledTaskDrivers.GetHashCode();
                }
                if (this.EnabledTaskDrivers != null)
                {
                    hashCode = (hashCode * 59) + this.EnabledTaskDrivers.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}