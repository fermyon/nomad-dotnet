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
    /// ServerHealth
    /// </summary>
    [DataContract(Name = "ServerHealth")]
    public partial class ServerHealth : IEquatable<ServerHealth>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerHealth" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="healthy">healthy.</param>
        /// <param name="iD">iD.</param>
        /// <param name="lastContact">lastContact.</param>
        /// <param name="lastIndex">lastIndex.</param>
        /// <param name="lastTerm">lastTerm.</param>
        /// <param name="leader">leader.</param>
        /// <param name="name">name.</param>
        /// <param name="serfStatus">serfStatus.</param>
        /// <param name="stableSince">stableSince.</param>
        /// <param name="version">version.</param>
        /// <param name="voter">voter.</param>
        public ServerHealth(string address = default(string), bool healthy = default(bool), string iD = default(string), long lastContact = default(long), int lastIndex = default(int), int lastTerm = default(int), bool leader = default(bool), string name = default(string), string serfStatus = default(string), DateTime stableSince = default(DateTime), string version = default(string), bool voter = default(bool))
        {
            this.Address = address;
            this.Healthy = healthy;
            this.ID = iD;
            this.LastContact = lastContact;
            this.LastIndex = lastIndex;
            this.LastTerm = lastTerm;
            this.Leader = leader;
            this.Name = name;
            this.SerfStatus = serfStatus;
            this.StableSince = stableSince;
            this._Version = version;
            this.Voter = voter;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "Address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Healthy
        /// </summary>
        [DataMember(Name = "Healthy", EmitDefaultValue = true)]
        public bool Healthy { get; set; }

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public string ID { get; set; }

        /// <summary>
        /// Gets or Sets LastContact
        /// </summary>
        [DataMember(Name = "LastContact", EmitDefaultValue = false)]
        public long LastContact { get; set; }

        /// <summary>
        /// Gets or Sets LastIndex
        /// </summary>
        [DataMember(Name = "LastIndex", EmitDefaultValue = false)]
        public int LastIndex { get; set; }

        /// <summary>
        /// Gets or Sets LastTerm
        /// </summary>
        [DataMember(Name = "LastTerm", EmitDefaultValue = false)]
        public int LastTerm { get; set; }

        /// <summary>
        /// Gets or Sets Leader
        /// </summary>
        [DataMember(Name = "Leader", EmitDefaultValue = true)]
        public bool Leader { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SerfStatus
        /// </summary>
        [DataMember(Name = "SerfStatus", EmitDefaultValue = false)]
        public string SerfStatus { get; set; }

        /// <summary>
        /// Gets or Sets StableSince
        /// </summary>
        [DataMember(Name = "StableSince", EmitDefaultValue = false)]
        public DateTime StableSince { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "Version", EmitDefaultValue = false)]
        public string _Version { get; set; }

        /// <summary>
        /// Gets or Sets Voter
        /// </summary>
        [DataMember(Name = "Voter", EmitDefaultValue = true)]
        public bool Voter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServerHealth {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Healthy: ").Append(Healthy).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  LastContact: ").Append(LastContact).Append("\n");
            sb.Append("  LastIndex: ").Append(LastIndex).Append("\n");
            sb.Append("  LastTerm: ").Append(LastTerm).Append("\n");
            sb.Append("  Leader: ").Append(Leader).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SerfStatus: ").Append(SerfStatus).Append("\n");
            sb.Append("  StableSince: ").Append(StableSince).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Voter: ").Append(Voter).Append("\n");
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
            return this.Equals(input as ServerHealth);
        }

        /// <summary>
        /// Returns true if ServerHealth instances are equal
        /// </summary>
        /// <param name="input">Instance of ServerHealth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServerHealth input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Healthy == input.Healthy ||
                    this.Healthy.Equals(input.Healthy)
                ) && 
                (
                    this.ID == input.ID ||
                    (this.ID != null &&
                    this.ID.Equals(input.ID))
                ) && 
                (
                    this.LastContact == input.LastContact ||
                    this.LastContact.Equals(input.LastContact)
                ) && 
                (
                    this.LastIndex == input.LastIndex ||
                    this.LastIndex.Equals(input.LastIndex)
                ) && 
                (
                    this.LastTerm == input.LastTerm ||
                    this.LastTerm.Equals(input.LastTerm)
                ) && 
                (
                    this.Leader == input.Leader ||
                    this.Leader.Equals(input.Leader)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SerfStatus == input.SerfStatus ||
                    (this.SerfStatus != null &&
                    this.SerfStatus.Equals(input.SerfStatus))
                ) && 
                (
                    this.StableSince == input.StableSince ||
                    (this.StableSince != null &&
                    this.StableSince.Equals(input.StableSince))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Voter == input.Voter ||
                    this.Voter.Equals(input.Voter)
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Healthy.GetHashCode();
                if (this.ID != null)
                {
                    hashCode = (hashCode * 59) + this.ID.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LastContact.GetHashCode();
                hashCode = (hashCode * 59) + this.LastIndex.GetHashCode();
                hashCode = (hashCode * 59) + this.LastTerm.GetHashCode();
                hashCode = (hashCode * 59) + this.Leader.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.SerfStatus != null)
                {
                    hashCode = (hashCode * 59) + this.SerfStatus.GetHashCode();
                }
                if (this.StableSince != null)
                {
                    hashCode = (hashCode * 59) + this.StableSince.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Voter.GetHashCode();
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

            // LastTerm (int) maximum
            if (this.LastTerm > (int)384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastTerm, must be a value less than or equal to 384.", new [] { "LastTerm" });
            }

            // LastTerm (int) minimum
            if (this.LastTerm < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastTerm, must be a value greater than or equal to 0.", new [] { "LastTerm" });
            }

            yield break;
        }
    }

}