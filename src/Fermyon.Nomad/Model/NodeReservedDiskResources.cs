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
    /// NodeReservedDiskResources
    /// </summary>
    [DataContract(Name = "NodeReservedDiskResources")]
    public partial class NodeReservedDiskResources : IEquatable<NodeReservedDiskResources>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeReservedDiskResources" /> class.
        /// </summary>
        /// <param name="diskMB">diskMB.</param>
        public NodeReservedDiskResources(int diskMB = default(int))
        {
            this.DiskMB = diskMB;
        }

        /// <summary>
        /// Gets or Sets DiskMB
        /// </summary>
        [DataMember(Name = "DiskMB", EmitDefaultValue = false)]
        public int DiskMB { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NodeReservedDiskResources {\n");
            sb.Append("  DiskMB: ").Append(DiskMB).Append("\n");
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
            return this.Equals(input as NodeReservedDiskResources);
        }

        /// <summary>
        /// Returns true if NodeReservedDiskResources instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeReservedDiskResources to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeReservedDiskResources input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DiskMB == input.DiskMB ||
                    this.DiskMB.Equals(input.DiskMB)
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
                hashCode = (hashCode * 59) + this.DiskMB.GetHashCode();
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
            // DiskMB (int) maximum
            if (this.DiskMB > (int)384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DiskMB, must be a value less than or equal to 384.", new [] { "DiskMB" });
            }

            // DiskMB (int) minimum
            if (this.DiskMB < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DiskMB, must be a value greater than or equal to 0.", new [] { "DiskMB" });
            }

            yield break;
        }
    }

}