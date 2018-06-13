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
using SwaggerDateConverter = com.tweirtx.TBAAPIv3client.Client.SwaggerDateConverter;

namespace com.tweirtx.TBAAPIv3client.Model
{
    /// <summary>
    /// TeamEventStatusRankSortOrderInfo
    /// </summary>
    [DataContract]
    public partial class TeamEventStatusRankSortOrderInfo :  IEquatable<TeamEventStatusRankSortOrderInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamEventStatusRankSortOrderInfo" /> class.
        /// </summary>
        /// <param name="Name">The descriptive name of the value used to sort the ranking..</param>
        /// <param name="Precision">The number of digits of precision used for this value, eg &#x60;2&#x60; would correspond to a value of &#x60;101.11&#x60; while &#x60;0&#x60; would correspond to &#x60;101&#x60;..</param>
        public TeamEventStatusRankSortOrderInfo(string Name = default(string), int? Precision = default(int?))
        {
            this.Name = Name;
            this.Precision = Precision;
        }
        
        /// <summary>
        /// The descriptive name of the value used to sort the ranking.
        /// </summary>
        /// <value>The descriptive name of the value used to sort the ranking.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of digits of precision used for this value, eg &#x60;2&#x60; would correspond to a value of &#x60;101.11&#x60; while &#x60;0&#x60; would correspond to &#x60;101&#x60;.
        /// </summary>
        /// <value>The number of digits of precision used for this value, eg &#x60;2&#x60; would correspond to a value of &#x60;101.11&#x60; while &#x60;0&#x60; would correspond to &#x60;101&#x60;.</value>
        [DataMember(Name="precision", EmitDefaultValue=false)]
        public int? Precision { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamEventStatusRankSortOrderInfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Precision: ").Append(Precision).Append("\n");
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
            return this.Equals(input as TeamEventStatusRankSortOrderInfo);
        }

        /// <summary>
        /// Returns true if TeamEventStatusRankSortOrderInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamEventStatusRankSortOrderInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamEventStatusRankSortOrderInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Precision == input.Precision ||
                    (this.Precision != null &&
                    this.Precision.Equals(input.Precision))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Precision != null)
                    hashCode = hashCode * 59 + this.Precision.GetHashCode();
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
