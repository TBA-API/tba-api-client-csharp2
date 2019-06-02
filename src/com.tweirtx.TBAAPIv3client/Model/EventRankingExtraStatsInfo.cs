/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.04.1
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
using OpenAPIDateConverter = com.tweirtx.TBAAPIv3client.Client.OpenAPIDateConverter;

namespace com.tweirtx.TBAAPIv3client.Model
{
    /// <summary>
    /// EventRankingExtraStatsInfo
    /// </summary>
    [DataContract]
    public partial class EventRankingExtraStatsInfo :  IEquatable<EventRankingExtraStatsInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventRankingExtraStatsInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventRankingExtraStatsInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventRankingExtraStatsInfo" /> class.
        /// </summary>
        /// <param name="precision">Integer expressing the number of digits of precision in the number provided in &#x60;sort_orders&#x60;. (required).</param>
        /// <param name="name">Name of the field used in the &#x60;extra_stats&#x60; array. (required).</param>
        public EventRankingExtraStatsInfo(decimal? precision = default(decimal?), string name = default(string))
        {
            // to ensure "precision" is required (not null)
            if (precision == null)
            {
                throw new InvalidDataException("precision is a required property for EventRankingExtraStatsInfo and cannot be null");
            }
            else
            {
                this.Precision = precision;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for EventRankingExtraStatsInfo and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
        }
        
        /// <summary>
        /// Integer expressing the number of digits of precision in the number provided in &#x60;sort_orders&#x60;.
        /// </summary>
        /// <value>Integer expressing the number of digits of precision in the number provided in &#x60;sort_orders&#x60;.</value>
        [DataMember(Name="precision", EmitDefaultValue=false)]
        public decimal? Precision { get; set; }

        /// <summary>
        /// Name of the field used in the &#x60;extra_stats&#x60; array.
        /// </summary>
        /// <value>Name of the field used in the &#x60;extra_stats&#x60; array.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventRankingExtraStatsInfo {\n");
            sb.Append("  Precision: ").Append(Precision).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as EventRankingExtraStatsInfo);
        }

        /// <summary>
        /// Returns true if EventRankingExtraStatsInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of EventRankingExtraStatsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventRankingExtraStatsInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Precision == input.Precision ||
                    (this.Precision != null &&
                    this.Precision.Equals(input.Precision))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Precision != null)
                    hashCode = hashCode * 59 + this.Precision.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
