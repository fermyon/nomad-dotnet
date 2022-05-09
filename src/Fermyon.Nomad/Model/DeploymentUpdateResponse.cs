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
    /// DeploymentUpdateResponse
    /// </summary>
    [DataContract(Name = "DeploymentUpdateResponse")]
    public partial class DeploymentUpdateResponse : IEquatable<DeploymentUpdateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentUpdateResponse" /> class.
        /// </summary>
        /// <param name="deploymentModifyIndex">deploymentModifyIndex.</param>
        /// <param name="evalCreateIndex">evalCreateIndex.</param>
        /// <param name="evalID">evalID.</param>
        /// <param name="lastIndex">lastIndex.</param>
        /// <param name="requestTime">requestTime.</param>
        /// <param name="revertedJobVersion">revertedJobVersion.</param>
        public DeploymentUpdateResponse(int deploymentModifyIndex = default(int), int evalCreateIndex = default(int), string evalID = default(string), int lastIndex = default(int), long requestTime = default(long), int revertedJobVersion = default(int))
        {
            this.DeploymentModifyIndex = deploymentModifyIndex;
            this.EvalCreateIndex = evalCreateIndex;
            this.EvalID = evalID;
            this.LastIndex = lastIndex;
            this.RequestTime = requestTime;
            this.RevertedJobVersion = revertedJobVersion;
        }

        /// <summary>
        /// Gets or Sets DeploymentModifyIndex
        /// </summary>
        [DataMember(Name = "DeploymentModifyIndex", EmitDefaultValue = false)]
        public int DeploymentModifyIndex { get; set; }

        /// <summary>
        /// Gets or Sets EvalCreateIndex
        /// </summary>
        [DataMember(Name = "EvalCreateIndex", EmitDefaultValue = false)]
        public int EvalCreateIndex { get; set; }

        /// <summary>
        /// Gets or Sets EvalID
        /// </summary>
        [DataMember(Name = "EvalID", EmitDefaultValue = false)]
        public string EvalID { get; set; }

        /// <summary>
        /// Gets or Sets LastIndex
        /// </summary>
        [DataMember(Name = "LastIndex", EmitDefaultValue = false)]
        public int LastIndex { get; set; }

        /// <summary>
        /// Gets or Sets RequestTime
        /// </summary>
        [DataMember(Name = "RequestTime", EmitDefaultValue = false)]
        public long RequestTime { get; set; }

        /// <summary>
        /// Gets or Sets RevertedJobVersion
        /// </summary>
        [DataMember(Name = "RevertedJobVersion", EmitDefaultValue = false)]
        public int RevertedJobVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeploymentUpdateResponse {\n");
            sb.Append("  DeploymentModifyIndex: ").Append(DeploymentModifyIndex).Append("\n");
            sb.Append("  EvalCreateIndex: ").Append(EvalCreateIndex).Append("\n");
            sb.Append("  EvalID: ").Append(EvalID).Append("\n");
            sb.Append("  LastIndex: ").Append(LastIndex).Append("\n");
            sb.Append("  RequestTime: ").Append(RequestTime).Append("\n");
            sb.Append("  RevertedJobVersion: ").Append(RevertedJobVersion).Append("\n");
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
            return this.Equals(input as DeploymentUpdateResponse);
        }

        /// <summary>
        /// Returns true if DeploymentUpdateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DeploymentUpdateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeploymentUpdateResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeploymentModifyIndex == input.DeploymentModifyIndex ||
                    this.DeploymentModifyIndex.Equals(input.DeploymentModifyIndex)
                ) && 
                (
                    this.EvalCreateIndex == input.EvalCreateIndex ||
                    this.EvalCreateIndex.Equals(input.EvalCreateIndex)
                ) && 
                (
                    this.EvalID == input.EvalID ||
                    (this.EvalID != null &&
                    this.EvalID.Equals(input.EvalID))
                ) && 
                (
                    this.LastIndex == input.LastIndex ||
                    this.LastIndex.Equals(input.LastIndex)
                ) && 
                (
                    this.RequestTime == input.RequestTime ||
                    this.RequestTime.Equals(input.RequestTime)
                ) && 
                (
                    this.RevertedJobVersion == input.RevertedJobVersion ||
                    this.RevertedJobVersion.Equals(input.RevertedJobVersion)
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
                hashCode = (hashCode * 59) + this.DeploymentModifyIndex.GetHashCode();
                hashCode = (hashCode * 59) + this.EvalCreateIndex.GetHashCode();
                if (this.EvalID != null)
                {
                    hashCode = (hashCode * 59) + this.EvalID.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LastIndex.GetHashCode();
                hashCode = (hashCode * 59) + this.RequestTime.GetHashCode();
                hashCode = (hashCode * 59) + this.RevertedJobVersion.GetHashCode();
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
            // DeploymentModifyIndex (int) maximum
            if (this.DeploymentModifyIndex > (int)384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeploymentModifyIndex, must be a value less than or equal to 384.", new [] { "DeploymentModifyIndex" });
            }

            // DeploymentModifyIndex (int) minimum
            if (this.DeploymentModifyIndex < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeploymentModifyIndex, must be a value greater than or equal to 0.", new [] { "DeploymentModifyIndex" });
            }

            // EvalCreateIndex (int) maximum
            if (this.EvalCreateIndex > (int)384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvalCreateIndex, must be a value less than or equal to 384.", new [] { "EvalCreateIndex" });
            }

            // EvalCreateIndex (int) minimum
            if (this.EvalCreateIndex < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvalCreateIndex, must be a value greater than or equal to 0.", new [] { "EvalCreateIndex" });
            }

            // LastIndex (int) maximum
            if (this.LastIndex > (int)384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastIndex, must be a value less than or equal to 384.", new [] { "LastIndex" });
            }

            // LastIndex (int) minimum
            if (this.LastIndex < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastIndex, must be a value greater than or equal to 0.", new [] { "LastIndex" });
            }

            // RevertedJobVersion (int) maximum
            if (this.RevertedJobVersion > (int)384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RevertedJobVersion, must be a value less than or equal to 384.", new [] { "RevertedJobVersion" });
            }

            // RevertedJobVersion (int) minimum
            if (this.RevertedJobVersion < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RevertedJobVersion, must be a value greater than or equal to 0.", new [] { "RevertedJobVersion" });
            }

            yield break;
        }
    }

}