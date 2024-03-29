/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.8.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = net.thefletcher.tbaapi.v3client.Client.OpenAPIDateConverter;

namespace net.thefletcher.tbaapi.v3client.Model
{
    /// <summary>
    /// A list of alliances, the teams on the alliances, and their score.
    /// </summary>
    [DataContract]
    public partial class MatchSimpleAlliances :  IEquatable<MatchSimpleAlliances>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchSimpleAlliances" /> class.
        /// </summary>
        /// <param name="red">red.</param>
        /// <param name="blue">blue.</param>
        public MatchSimpleAlliances(MatchAlliance red = default(MatchAlliance), MatchAlliance blue = default(MatchAlliance))
        {
            this.Red = red;
            this.Blue = blue;
        }
        
        /// <summary>
        /// Gets or Sets Red
        /// </summary>
        [DataMember(Name="red", EmitDefaultValue=false)]
        public MatchAlliance Red { get; set; }

        /// <summary>
        /// Gets or Sets Blue
        /// </summary>
        [DataMember(Name="blue", EmitDefaultValue=false)]
        public MatchAlliance Blue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchSimpleAlliances {\n");
            sb.Append("  Red: ").Append(Red).Append("\n");
            sb.Append("  Blue: ").Append(Blue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as MatchSimpleAlliances);
        }

        /// <summary>
        /// Returns true if MatchSimpleAlliances instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchSimpleAlliances to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchSimpleAlliances input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Red == input.Red ||
                    (this.Red != null &&
                    this.Red.Equals(input.Red))
                ) && 
                (
                    this.Blue == input.Blue ||
                    (this.Blue != null &&
                    this.Blue.Equals(input.Blue))
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
                if (this.Red != null)
                    hashCode = hashCode * 59 + this.Red.GetHashCode();
                if (this.Blue != null)
                    hashCode = hashCode * 59 + this.Blue.GetHashCode();
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
