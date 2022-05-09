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
    /// JobValidateResponse
    /// </summary>
    [DataContract(Name = "JobValidateResponse")]
    public partial class JobValidateResponse : IEquatable<JobValidateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobValidateResponse" /> class.
        /// </summary>
        /// <param name="driverConfigValidated">driverConfigValidated.</param>
        /// <param name="error">error.</param>
        /// <param name="validationErrors">validationErrors.</param>
        /// <param name="warnings">warnings.</param>
        public JobValidateResponse(bool driverConfigValidated = default(bool), string error = default(string), List<string> validationErrors = default(List<string>), string warnings = default(string))
        {
            this.DriverConfigValidated = driverConfigValidated;
            this.Error = error;
            this.ValidationErrors = validationErrors;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Gets or Sets DriverConfigValidated
        /// </summary>
        [DataMember(Name = "DriverConfigValidated", EmitDefaultValue = true)]
        public bool DriverConfigValidated { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "Error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets ValidationErrors
        /// </summary>
        [DataMember(Name = "ValidationErrors", EmitDefaultValue = false)]
        public List<string> ValidationErrors { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [DataMember(Name = "Warnings", EmitDefaultValue = false)]
        public string Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobValidateResponse {\n");
            sb.Append("  DriverConfigValidated: ").Append(DriverConfigValidated).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return this.Equals(input as JobValidateResponse);
        }

        /// <summary>
        /// Returns true if JobValidateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of JobValidateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobValidateResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DriverConfigValidated == input.DriverConfigValidated ||
                    this.DriverConfigValidated.Equals(input.DriverConfigValidated)
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    input.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    (this.Warnings != null &&
                    this.Warnings.Equals(input.Warnings))
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
                hashCode = (hashCode * 59) + this.DriverConfigValidated.GetHashCode();
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                if (this.ValidationErrors != null)
                {
                    hashCode = (hashCode * 59) + this.ValidationErrors.GetHashCode();
                }
                if (this.Warnings != null)
                {
                    hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
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