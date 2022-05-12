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
    /// CSIVolumeExternalStub
    /// </summary>
    [DataContract(Name = "CSIVolumeExternalStub")]
    public partial class CSIVolumeExternalStub : IEquatable<CSIVolumeExternalStub>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSIVolumeExternalStub" /> class.
        /// </summary>
        /// <param name="capacityBytes">capacityBytes.</param>
        /// <param name="cloneID">cloneID.</param>
        /// <param name="externalID">externalID.</param>
        /// <param name="isAbnormal">isAbnormal.</param>
        /// <param name="publishedExternalNodeIDs">publishedExternalNodeIDs.</param>
        /// <param name="snapshotID">snapshotID.</param>
        /// <param name="status">status.</param>
        /// <param name="volumeContext">volumeContext.</param>
        public CSIVolumeExternalStub(long capacityBytes = default(long), string cloneID = default(string), string externalID = default(string), bool isAbnormal = default(bool), List<string> publishedExternalNodeIDs = default(List<string>), string snapshotID = default(string), string status = default(string), Dictionary<string, string> volumeContext = default(Dictionary<string, string>))
        {
            this.CapacityBytes = capacityBytes;
            this.CloneID = cloneID;
            this.ExternalID = externalID;
            this.IsAbnormal = isAbnormal;
            this.PublishedExternalNodeIDs = publishedExternalNodeIDs;
            this.SnapshotID = snapshotID;
            this.Status = status;
            this.VolumeContext = volumeContext;
        }

        /// <summary>
        /// Gets or Sets CapacityBytes
        /// </summary>
        [DataMember(Name = "CapacityBytes", EmitDefaultValue = false)]
        public long CapacityBytes { get; set; }

        /// <summary>
        /// Gets or Sets CloneID
        /// </summary>
        [DataMember(Name = "CloneID", EmitDefaultValue = false)]
        public string CloneID { get; set; }

        /// <summary>
        /// Gets or Sets ExternalID
        /// </summary>
        [DataMember(Name = "ExternalID", EmitDefaultValue = false)]
        public string ExternalID { get; set; }

        /// <summary>
        /// Gets or Sets IsAbnormal
        /// </summary>
        [DataMember(Name = "IsAbnormal", EmitDefaultValue = true)]
        public bool IsAbnormal { get; set; }

        /// <summary>
        /// Gets or Sets PublishedExternalNodeIDs
        /// </summary>
        [DataMember(Name = "PublishedExternalNodeIDs", EmitDefaultValue = false)]
        public List<string> PublishedExternalNodeIDs { get; set; }

        /// <summary>
        /// Gets or Sets SnapshotID
        /// </summary>
        [DataMember(Name = "SnapshotID", EmitDefaultValue = false)]
        public string SnapshotID { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets VolumeContext
        /// </summary>
        [DataMember(Name = "VolumeContext", EmitDefaultValue = false)]
        public Dictionary<string, string> VolumeContext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CSIVolumeExternalStub {\n");
            sb.Append("  CapacityBytes: ").Append(CapacityBytes).Append("\n");
            sb.Append("  CloneID: ").Append(CloneID).Append("\n");
            sb.Append("  ExternalID: ").Append(ExternalID).Append("\n");
            sb.Append("  IsAbnormal: ").Append(IsAbnormal).Append("\n");
            sb.Append("  PublishedExternalNodeIDs: ").Append(PublishedExternalNodeIDs).Append("\n");
            sb.Append("  SnapshotID: ").Append(SnapshotID).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  VolumeContext: ").Append(VolumeContext).Append("\n");
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
            return this.Equals(input as CSIVolumeExternalStub);
        }

        /// <summary>
        /// Returns true if CSIVolumeExternalStub instances are equal
        /// </summary>
        /// <param name="input">Instance of CSIVolumeExternalStub to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CSIVolumeExternalStub input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CapacityBytes == input.CapacityBytes ||
                    this.CapacityBytes.Equals(input.CapacityBytes)
                ) && 
                (
                    this.CloneID == input.CloneID ||
                    (this.CloneID != null &&
                    this.CloneID.Equals(input.CloneID))
                ) && 
                (
                    this.ExternalID == input.ExternalID ||
                    (this.ExternalID != null &&
                    this.ExternalID.Equals(input.ExternalID))
                ) && 
                (
                    this.IsAbnormal == input.IsAbnormal ||
                    this.IsAbnormal.Equals(input.IsAbnormal)
                ) && 
                (
                    this.PublishedExternalNodeIDs == input.PublishedExternalNodeIDs ||
                    this.PublishedExternalNodeIDs != null &&
                    input.PublishedExternalNodeIDs != null &&
                    this.PublishedExternalNodeIDs.SequenceEqual(input.PublishedExternalNodeIDs)
                ) && 
                (
                    this.SnapshotID == input.SnapshotID ||
                    (this.SnapshotID != null &&
                    this.SnapshotID.Equals(input.SnapshotID))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.VolumeContext == input.VolumeContext ||
                    this.VolumeContext != null &&
                    input.VolumeContext != null &&
                    this.VolumeContext.SequenceEqual(input.VolumeContext)
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
                hashCode = hashCode * 59 + this.CapacityBytes.GetHashCode();
                if (this.CloneID != null)
                    hashCode = hashCode * 59 + this.CloneID.GetHashCode();
                if (this.ExternalID != null)
                    hashCode = hashCode * 59 + this.ExternalID.GetHashCode();
                hashCode = hashCode * 59 + this.IsAbnormal.GetHashCode();
                if (this.PublishedExternalNodeIDs != null)
                    hashCode = hashCode * 59 + this.PublishedExternalNodeIDs.GetHashCode();
                if (this.SnapshotID != null)
                    hashCode = hashCode * 59 + this.SnapshotID.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VolumeContext != null)
                    hashCode = hashCode * 59 + this.VolumeContext.GetHashCode();
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
            yield break;
        }
    }

}
