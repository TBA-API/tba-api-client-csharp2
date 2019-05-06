/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * OpenAPI spec version: 3.04.1
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
    /// EventDistrictPointsPoints
    /// </summary>
    [DataContract]
    public partial class EventDistrictPointsPoints :  IEquatable<EventDistrictPointsPoints>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventDistrictPointsPoints" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventDistrictPointsPoints() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventDistrictPointsPoints" /> class.
        /// </summary>
        /// <param name="total">Total points awarded at this event. (required).</param>
        /// <param name="alliancePoints">Points awarded for alliance selection (required).</param>
        /// <param name="elimPoints">Points awarded for elimination match performance. (required).</param>
        /// <param name="awardPoints">Points awarded for event awards. (required).</param>
        /// <param name="qualPoints">Points awarded for qualification match performance. (required).</param>
        public EventDistrictPointsPoints(int? total = default(int?), int? alliancePoints = default(int?), int? elimPoints = default(int?), int? awardPoints = default(int?), int? qualPoints = default(int?))
        {
            // to ensure "total" is required (not null)
            if (total == null)
            {
                throw new InvalidDataException("total is a required property for EventDistrictPointsPoints and cannot be null");
            }
            else
            {
                this.Total = total;
            }
            // to ensure "alliancePoints" is required (not null)
            if (alliancePoints == null)
            {
                throw new InvalidDataException("alliancePoints is a required property for EventDistrictPointsPoints and cannot be null");
            }
            else
            {
                this.AlliancePoints = alliancePoints;
            }
            // to ensure "elimPoints" is required (not null)
            if (elimPoints == null)
            {
                throw new InvalidDataException("elimPoints is a required property for EventDistrictPointsPoints and cannot be null");
            }
            else
            {
                this.ElimPoints = elimPoints;
            }
            // to ensure "awardPoints" is required (not null)
            if (awardPoints == null)
            {
                throw new InvalidDataException("awardPoints is a required property for EventDistrictPointsPoints and cannot be null");
            }
            else
            {
                this.AwardPoints = awardPoints;
            }
            // to ensure "qualPoints" is required (not null)
            if (qualPoints == null)
            {
                throw new InvalidDataException("qualPoints is a required property for EventDistrictPointsPoints and cannot be null");
            }
            else
            {
                this.QualPoints = qualPoints;
            }
        }
        
        /// <summary>
        /// Total points awarded at this event.
        /// </summary>
        /// <value>Total points awarded at this event.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// Points awarded for alliance selection
        /// </summary>
        /// <value>Points awarded for alliance selection</value>
        [DataMember(Name="alliance_points", EmitDefaultValue=false)]
        public int? AlliancePoints { get; set; }

        /// <summary>
        /// Points awarded for elimination match performance.
        /// </summary>
        /// <value>Points awarded for elimination match performance.</value>
        [DataMember(Name="elim_points", EmitDefaultValue=false)]
        public int? ElimPoints { get; set; }

        /// <summary>
        /// Points awarded for event awards.
        /// </summary>
        /// <value>Points awarded for event awards.</value>
        [DataMember(Name="award_points", EmitDefaultValue=false)]
        public int? AwardPoints { get; set; }

        /// <summary>
        /// Points awarded for qualification match performance.
        /// </summary>
        /// <value>Points awarded for qualification match performance.</value>
        [DataMember(Name="qual_points", EmitDefaultValue=false)]
        public int? QualPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventDistrictPointsPoints {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  AlliancePoints: ").Append(AlliancePoints).Append("\n");
            sb.Append("  ElimPoints: ").Append(ElimPoints).Append("\n");
            sb.Append("  AwardPoints: ").Append(AwardPoints).Append("\n");
            sb.Append("  QualPoints: ").Append(QualPoints).Append("\n");
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
            return this.Equals(input as EventDistrictPointsPoints);
        }

        /// <summary>
        /// Returns true if EventDistrictPointsPoints instances are equal
        /// </summary>
        /// <param name="input">Instance of EventDistrictPointsPoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventDistrictPointsPoints input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.AlliancePoints == input.AlliancePoints ||
                    (this.AlliancePoints != null &&
                    this.AlliancePoints.Equals(input.AlliancePoints))
                ) && 
                (
                    this.ElimPoints == input.ElimPoints ||
                    (this.ElimPoints != null &&
                    this.ElimPoints.Equals(input.ElimPoints))
                ) && 
                (
                    this.AwardPoints == input.AwardPoints ||
                    (this.AwardPoints != null &&
                    this.AwardPoints.Equals(input.AwardPoints))
                ) && 
                (
                    this.QualPoints == input.QualPoints ||
                    (this.QualPoints != null &&
                    this.QualPoints.Equals(input.QualPoints))
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.AlliancePoints != null)
                    hashCode = hashCode * 59 + this.AlliancePoints.GetHashCode();
                if (this.ElimPoints != null)
                    hashCode = hashCode * 59 + this.ElimPoints.GetHashCode();
                if (this.AwardPoints != null)
                    hashCode = hashCode * 59 + this.AwardPoints.GetHashCode();
                if (this.QualPoints != null)
                    hashCode = hashCode * 59 + this.QualPoints.GetHashCode();
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
