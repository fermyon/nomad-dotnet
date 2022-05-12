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
    /// Attribute
    /// </summary>
    [DataContract(Name = "Attribute")]
    public partial class Attribute : IEquatable<Attribute>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attribute" /> class.
        /// </summary>
        /// <param name="_bool">_bool.</param>
        /// <param name="_float">_float.</param>
        /// <param name="_int">_int.</param>
        /// <param name="_string">_string.</param>
        /// <param name="unit">unit.</param>
        public Attribute(bool _bool = default(bool), double _float = default(double), long _int = default(long), string _string = default(string), string unit = default(string))
        {
            this.Bool = _bool;
            this.Float = _float;
            this.Int = _int;
            this.String = _string;
            this.Unit = unit;
        }

        /// <summary>
        /// Gets or Sets Bool
        /// </summary>
        [DataMember(Name = "Bool", EmitDefaultValue = true)]
        public bool Bool { get; set; }

        /// <summary>
        /// Gets or Sets Float
        /// </summary>
        [DataMember(Name = "Float", EmitDefaultValue = false)]
        public double Float { get; set; }

        /// <summary>
        /// Gets or Sets Int
        /// </summary>
        [DataMember(Name = "Int", EmitDefaultValue = false)]
        public long Int { get; set; }

        /// <summary>
        /// Gets or Sets String
        /// </summary>
        [DataMember(Name = "String", EmitDefaultValue = false)]
        public string String { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name = "Unit", EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attribute {\n");
            sb.Append("  Bool: ").Append(Bool).Append("\n");
            sb.Append("  Float: ").Append(Float).Append("\n");
            sb.Append("  Int: ").Append(Int).Append("\n");
            sb.Append("  String: ").Append(String).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as Attribute);
        }

        /// <summary>
        /// Returns true if Attribute instances are equal
        /// </summary>
        /// <param name="input">Instance of Attribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Attribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bool == input.Bool ||
                    this.Bool.Equals(input.Bool)
                ) && 
                (
                    this.Float == input.Float ||
                    this.Float.Equals(input.Float)
                ) && 
                (
                    this.Int == input.Int ||
                    this.Int.Equals(input.Int)
                ) && 
                (
                    this.String == input.String ||
                    (this.String != null &&
                    this.String.Equals(input.String))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                hashCode = hashCode * 59 + this.Bool.GetHashCode();
                hashCode = hashCode * 59 + this.Float.GetHashCode();
                hashCode = hashCode * 59 + this.Int.GetHashCode();
                if (this.String != null)
                    hashCode = hashCode * 59 + this.String.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
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
