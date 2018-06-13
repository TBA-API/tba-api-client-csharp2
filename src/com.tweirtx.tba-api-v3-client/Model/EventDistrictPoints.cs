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
using SwaggerDateConverter = com.tweirtx.tba-api-v3-client.Client.SwaggerDateConverter;

namespace com.tweirtx.tba-api-v3-client.Model
{
    /// <summary>
    /// EventDistrictPoints
    /// </summary>
    [DataContract]
    public partial class EventDistrictPoints :  IEquatable<EventDistrictPoints>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventDistrictPoints" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventDistrictPoints() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventDistrictPoints" /> class.
        /// </summary>
        /// <param name="Points">Points gained for each team at the event. Stored as a key-value pair with the team key as the key, and an object describing the points as its value. (required).</param>
        /// <param name="Tiebreakers">Tiebreaker values for each team at the event. Stored as a key-value pair with the team key as the key, and an object describing the tiebreaker elements as its value..</param>
        public EventDistrictPoints(Dictionary<string, EventDistrictPointsPoints> Points = default(Dictionary<string, EventDistrictPointsPoints>), Dictionary<string, EventDistrictPointsTiebreakers> Tiebreakers = default(Dictionary<string, EventDistrictPointsTiebreakers>))
        {
            // to ensure "Points" is required (not null)
            if (Points == null)
            {
                throw new InvalidDataException("Points is a required property for EventDistrictPoints and cannot be null");
            }
            else
            {
                this.Points = Points;
            }
            this.Tiebreakers = Tiebreakers;
        }
        
        /// <summary>
        /// Points gained for each team at the event. Stored as a key-value pair with the team key as the key, and an object describing the points as its value.
        /// </summary>
        /// <value>Points gained for each team at the event. Stored as a key-value pair with the team key as the key, and an object describing the points as its value.</value>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public Dictionary<string, EventDistrictPointsPoints> Points { get; set; }

        /// <summary>
        /// Tiebreaker values for each team at the event. Stored as a key-value pair with the team key as the key, and an object describing the tiebreaker elements as its value.
        /// </summary>
        /// <value>Tiebreaker values for each team at the event. Stored as a key-value pair with the team key as the key, and an object describing the tiebreaker elements as its value.</value>
        [DataMember(Name="tiebreakers", EmitDefaultValue=false)]
        public Dictionary<string, EventDistrictPointsTiebreakers> Tiebreakers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventDistrictPoints {\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  Tiebreakers: ").Append(Tiebreakers).Append("\n");
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
            return this.Equals(input as EventDistrictPoints);
        }

        /// <summary>
        /// Returns true if EventDistrictPoints instances are equal
        /// </summary>
        /// <param name="input">Instance of EventDistrictPoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventDistrictPoints input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Points == input.Points ||
                    this.Points != null &&
                    this.Points.SequenceEqual(input.Points)
                ) && 
                (
                    this.Tiebreakers == input.Tiebreakers ||
                    this.Tiebreakers != null &&
                    this.Tiebreakers.SequenceEqual(input.Tiebreakers)
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
                if (this.Points != null)
                    hashCode = hashCode * 59 + this.Points.GetHashCode();
                if (this.Tiebreakers != null)
                    hashCode = hashCode * 59 + this.Tiebreakers.GetHashCode();
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
