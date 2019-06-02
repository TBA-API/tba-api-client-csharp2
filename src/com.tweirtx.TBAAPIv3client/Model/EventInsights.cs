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
    /// A year-specific event insight object expressed as a JSON string, separated in to &#x60;qual&#x60; and &#x60;playoff&#x60; fields. See also Event_Insights_2016, Event_Insights_2017, etc.
    /// </summary>
    [DataContract]
    public partial class EventInsights :  IEquatable<EventInsights>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventInsights" /> class.
        /// </summary>
        /// <param name="qual">Inights for the qualification round of an event.</param>
        /// <param name="playoff">Insights for the playoff round of an event.</param>
        public EventInsights(Object qual = default(Object), Object playoff = default(Object))
        {
            this.Qual = qual;
            this.Playoff = playoff;
        }
        
        /// <summary>
        /// Inights for the qualification round of an event
        /// </summary>
        /// <value>Inights for the qualification round of an event</value>
        [DataMember(Name="qual", EmitDefaultValue=false)]
        public Object Qual { get; set; }

        /// <summary>
        /// Insights for the playoff round of an event
        /// </summary>
        /// <value>Insights for the playoff round of an event</value>
        [DataMember(Name="playoff", EmitDefaultValue=false)]
        public Object Playoff { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventInsights {\n");
            sb.Append("  Qual: ").Append(Qual).Append("\n");
            sb.Append("  Playoff: ").Append(Playoff).Append("\n");
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
            return this.Equals(input as EventInsights);
        }

        /// <summary>
        /// Returns true if EventInsights instances are equal
        /// </summary>
        /// <param name="input">Instance of EventInsights to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventInsights input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Qual == input.Qual ||
                    (this.Qual != null &&
                    this.Qual.Equals(input.Qual))
                ) && 
                (
                    this.Playoff == input.Playoff ||
                    (this.Playoff != null &&
                    this.Playoff.Equals(input.Playoff))
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
                if (this.Qual != null)
                    hashCode = hashCode * 59 + this.Qual.GetHashCode();
                if (this.Playoff != null)
                    hashCode = hashCode * 59 + this.Playoff.GetHashCode();
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
