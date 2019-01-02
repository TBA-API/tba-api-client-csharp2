/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * OpenAPI spec version: 3.04.0
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
using SwaggerDateConverter = com.tweirtx.TBAAPIv3client.Client.SwaggerDateConverter;

namespace com.tweirtx.TBAAPIv3client.Model
{
    /// <summary>
    /// See the 2017 FMS API documentation for a description of each value.
    /// </summary>
    [DataContract]
    public partial class MatchScoreBreakdown2017 :  IEquatable<MatchScoreBreakdown2017>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchScoreBreakdown2017" /> class.
        /// </summary>
        /// <param name="Blue">Blue.</param>
        /// <param name="Red">Red.</param>
        public MatchScoreBreakdown2017(MatchScoreBreakdown2017Alliance Blue = default(MatchScoreBreakdown2017Alliance), MatchScoreBreakdown2017Alliance Red = default(MatchScoreBreakdown2017Alliance))
        {
            this.Blue = Blue;
            this.Red = Red;
        }
        
        /// <summary>
        /// Gets or Sets Blue
        /// </summary>
        [DataMember(Name="blue", EmitDefaultValue=false)]
        public MatchScoreBreakdown2017Alliance Blue { get; set; }

        /// <summary>
        /// Gets or Sets Red
        /// </summary>
        [DataMember(Name="red", EmitDefaultValue=false)]
        public MatchScoreBreakdown2017Alliance Red { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchScoreBreakdown2017 {\n");
            sb.Append("  Blue: ").Append(Blue).Append("\n");
            sb.Append("  Red: ").Append(Red).Append("\n");
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
            return this.Equals(input as MatchScoreBreakdown2017);
        }

        /// <summary>
        /// Returns true if MatchScoreBreakdown2017 instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchScoreBreakdown2017 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchScoreBreakdown2017 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Blue == input.Blue ||
                    (this.Blue != null &&
                    this.Blue.Equals(input.Blue))
                ) && 
                (
                    this.Red == input.Red ||
                    (this.Red != null &&
                    this.Red.Equals(input.Red))
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
                if (this.Blue != null)
                    hashCode = hashCode * 59 + this.Blue.GetHashCode();
                if (this.Red != null)
                    hashCode = hashCode * 59 + this.Red.GetHashCode();
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
