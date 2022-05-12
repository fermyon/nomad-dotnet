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
    /// JobRegisterRequest
    /// </summary>
    [DataContract(Name = "JobRegisterRequest")]
    public partial class JobRegisterRequest : IEquatable<JobRegisterRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobRegisterRequest" /> class.
        /// </summary>
        /// <param name="enforceIndex">enforceIndex.</param>
        /// <param name="evalPriority">evalPriority.</param>
        /// <param name="job">job.</param>
        /// <param name="jobModifyIndex">jobModifyIndex.</param>
        /// <param name="_namespace">_namespace.</param>
        /// <param name="policyOverride">policyOverride.</param>
        /// <param name="preserveCounts">preserveCounts.</param>
        /// <param name="region">region.</param>
        /// <param name="secretID">secretID.</param>
        public JobRegisterRequest(bool enforceIndex = default(bool), int evalPriority = default(int), Job job = default(Job), int jobModifyIndex = default(int), string _namespace = default(string), bool policyOverride = default(bool), bool preserveCounts = default(bool), string region = default(string), string secretID = default(string))
        {
            this.EnforceIndex = enforceIndex;
            this.EvalPriority = evalPriority;
            this.Job = job;
            this.JobModifyIndex = jobModifyIndex;
            this.Namespace = _namespace;
            this.PolicyOverride = policyOverride;
            this.PreserveCounts = preserveCounts;
            this.Region = region;
            this.SecretID = secretID;
        }

        /// <summary>
        /// Gets or Sets EnforceIndex
        /// </summary>
        [DataMember(Name = "EnforceIndex", EmitDefaultValue = true)]
        public bool EnforceIndex { get; set; }

        /// <summary>
        /// Gets or Sets EvalPriority
        /// </summary>
        [DataMember(Name = "EvalPriority", EmitDefaultValue = false)]
        public int EvalPriority { get; set; }

        /// <summary>
        /// Gets or Sets Job
        /// </summary>
        [DataMember(Name = "Job", EmitDefaultValue = false)]
        public Job Job { get; set; }

        /// <summary>
        /// Gets or Sets JobModifyIndex
        /// </summary>
        [DataMember(Name = "JobModifyIndex", EmitDefaultValue = false)]
        public int JobModifyIndex { get; set; }

        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [DataMember(Name = "Namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets PolicyOverride
        /// </summary>
        [DataMember(Name = "PolicyOverride", EmitDefaultValue = true)]
        public bool PolicyOverride { get; set; }

        /// <summary>
        /// Gets or Sets PreserveCounts
        /// </summary>
        [DataMember(Name = "PreserveCounts", EmitDefaultValue = true)]
        public bool PreserveCounts { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name = "Region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or Sets SecretID
        /// </summary>
        [DataMember(Name = "SecretID", EmitDefaultValue = false)]
        public string SecretID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobRegisterRequest {\n");
            sb.Append("  EnforceIndex: ").Append(EnforceIndex).Append("\n");
            sb.Append("  EvalPriority: ").Append(EvalPriority).Append("\n");
            sb.Append("  Job: ").Append(Job).Append("\n");
            sb.Append("  JobModifyIndex: ").Append(JobModifyIndex).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  PolicyOverride: ").Append(PolicyOverride).Append("\n");
            sb.Append("  PreserveCounts: ").Append(PreserveCounts).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  SecretID: ").Append(SecretID).Append("\n");
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
            return this.Equals(input as JobRegisterRequest);
        }

        /// <summary>
        /// Returns true if JobRegisterRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of JobRegisterRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobRegisterRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnforceIndex == input.EnforceIndex ||
                    this.EnforceIndex.Equals(input.EnforceIndex)
                ) && 
                (
                    this.EvalPriority == input.EvalPriority ||
                    this.EvalPriority.Equals(input.EvalPriority)
                ) && 
                (
                    this.Job == input.Job ||
                    (this.Job != null &&
                    this.Job.Equals(input.Job))
                ) && 
                (
                    this.JobModifyIndex == input.JobModifyIndex ||
                    this.JobModifyIndex.Equals(input.JobModifyIndex)
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.PolicyOverride == input.PolicyOverride ||
                    this.PolicyOverride.Equals(input.PolicyOverride)
                ) && 
                (
                    this.PreserveCounts == input.PreserveCounts ||
                    this.PreserveCounts.Equals(input.PreserveCounts)
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.SecretID == input.SecretID ||
                    (this.SecretID != null &&
                    this.SecretID.Equals(input.SecretID))
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
                hashCode = hashCode * 59 + this.EnforceIndex.GetHashCode();
                hashCode = hashCode * 59 + this.EvalPriority.GetHashCode();
                if (this.Job != null)
                    hashCode = hashCode * 59 + this.Job.GetHashCode();
                hashCode = hashCode * 59 + this.JobModifyIndex.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                hashCode = hashCode * 59 + this.PolicyOverride.GetHashCode();
                hashCode = hashCode * 59 + this.PreserveCounts.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.SecretID != null)
                    hashCode = hashCode * 59 + this.SecretID.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // JobModifyIndex (int) maximum
            if(this.JobModifyIndex > (int)384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for JobModifyIndex, must be a value less than or equal to 384.", new [] { "JobModifyIndex" });
            }

            // JobModifyIndex (int) minimum
            if(this.JobModifyIndex < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for JobModifyIndex, must be a value greater than or equal to 0.", new [] { "JobModifyIndex" });
            }

            yield break;
        }
    }

}
