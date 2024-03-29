/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * OpenAPI spec version: 3.03.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// A Win-Loss-Tie record for a team, or an alliance.
    /// </summary>
    [DataContract]
    public partial class WLTRecord :  IEquatable<WLTRecord>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WLTRecord" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WLTRecord() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WLTRecord" /> class.
        /// </summary>
        /// <param name="Losses">Number of losses. (required).</param>
        /// <param name="Wins">Number of wins. (required).</param>
        /// <param name="Ties">Number of ties. (required).</param>
        public WLTRecord(int? Losses = default(int?), int? Wins = default(int?), int? Ties = default(int?))
        {
            // to ensure "Losses" is required (not null)
            if (Losses == null)
            {
                throw new InvalidDataException("Losses is a required property for WLTRecord and cannot be null");
            }
            else
            {
                this.Losses = Losses;
            }
            // to ensure "Wins" is required (not null)
            if (Wins == null)
            {
                throw new InvalidDataException("Wins is a required property for WLTRecord and cannot be null");
            }
            else
            {
                this.Wins = Wins;
            }
            // to ensure "Ties" is required (not null)
            if (Ties == null)
            {
                throw new InvalidDataException("Ties is a required property for WLTRecord and cannot be null");
            }
            else
            {
                this.Ties = Ties;
            }
        }
        
        /// <summary>
        /// Number of losses.
        /// </summary>
        /// <value>Number of losses.</value>
        [DataMember(Name="losses", EmitDefaultValue=false)]
        public int? Losses { get; set; }

        /// <summary>
        /// Number of wins.
        /// </summary>
        /// <value>Number of wins.</value>
        [DataMember(Name="wins", EmitDefaultValue=false)]
        public int? Wins { get; set; }

        /// <summary>
        /// Number of ties.
        /// </summary>
        /// <value>Number of ties.</value>
        [DataMember(Name="ties", EmitDefaultValue=false)]
        public int? Ties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WLTRecord {\n");
            sb.Append("  Losses: ").Append(Losses).Append("\n");
            sb.Append("  Wins: ").Append(Wins).Append("\n");
            sb.Append("  Ties: ").Append(Ties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WLTRecord);
        }

        /// <summary>
        /// Returns true if WLTRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of WLTRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WLTRecord input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Losses == input.Losses ||
                    (this.Losses != null &&
                    this.Losses.Equals(input.Losses))
                ) && 
                (
                    this.Wins == input.Wins ||
                    (this.Wins != null &&
                    this.Wins.Equals(input.Wins))
                ) && 
                (
                    this.Ties == input.Ties ||
                    (this.Ties != null &&
                    this.Ties.Equals(input.Ties))
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
                if (this.Losses != null)
                    hashCode = hashCode * 59 + this.Losses.GetHashCode();
                if (this.Wins != null)
                    hashCode = hashCode * 59 + this.Wins.GetHashCode();
                if (this.Ties != null)
                    hashCode = hashCode * 59 + this.Ties.GetHashCode();
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
