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
        /// <param name="AlliancePoints">Points awarded for alliance selection (required).</param>
        /// <param name="AwardPoints">Points awarded for event awards. (required).</param>
        /// <param name="QualPoints">Points awarded for qualification match performance. (required).</param>
        /// <param name="ElimPoints">Points awarded for elimination match performance. (required).</param>
        /// <param name="Total">Total points awarded at this event. (required).</param>
        public EventDistrictPointsPoints(int? AlliancePoints = default(int?), int? AwardPoints = default(int?), int? QualPoints = default(int?), int? ElimPoints = default(int?), int? Total = default(int?))
        {
            // to ensure "AlliancePoints" is required (not null)
            if (AlliancePoints == null)
            {
                throw new InvalidDataException("AlliancePoints is a required property for EventDistrictPointsPoints and cannot be null");
            }
            else
            {
                this.AlliancePoints = AlliancePoints;
            }
            // to ensure "AwardPoints" is required (not null)
            if (AwardPoints == null)
            {
                throw new InvalidDataException("AwardPoints is a required property for EventDistrictPointsPoints and cannot be null");
            }
            else
            {
                this.AwardPoints = AwardPoints;
            }
            // to ensure "QualPoints" is required (not null)
            if (QualPoints == null)
            {
                throw new InvalidDataException("QualPoints is a required property for EventDistrictPointsPoints and cannot be null");
            }
            else
            {
                this.QualPoints = QualPoints;
            }
            // to ensure "ElimPoints" is required (not null)
            if (ElimPoints == null)
            {
                throw new InvalidDataException("ElimPoints is a required property for EventDistrictPointsPoints and cannot be null");
            }
            else
            {
                this.ElimPoints = ElimPoints;
            }
            // to ensure "Total" is required (not null)
            if (Total == null)
            {
                throw new InvalidDataException("Total is a required property for EventDistrictPointsPoints and cannot be null");
            }
            else
            {
                this.Total = Total;
            }
        }
        
        /// <summary>
        /// Points awarded for alliance selection
        /// </summary>
        /// <value>Points awarded for alliance selection</value>
        [DataMember(Name="alliance_points", EmitDefaultValue=false)]
        public int? AlliancePoints { get; set; }

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
        /// Points awarded for elimination match performance.
        /// </summary>
        /// <value>Points awarded for elimination match performance.</value>
        [DataMember(Name="elim_points", EmitDefaultValue=false)]
        public int? ElimPoints { get; set; }

        /// <summary>
        /// Total points awarded at this event.
        /// </summary>
        /// <value>Total points awarded at this event.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventDistrictPointsPoints {\n");
            sb.Append("  AlliancePoints: ").Append(AlliancePoints).Append("\n");
            sb.Append("  AwardPoints: ").Append(AwardPoints).Append("\n");
            sb.Append("  QualPoints: ").Append(QualPoints).Append("\n");
            sb.Append("  ElimPoints: ").Append(ElimPoints).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
                    this.AlliancePoints == input.AlliancePoints ||
                    (this.AlliancePoints != null &&
                    this.AlliancePoints.Equals(input.AlliancePoints))
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
                ) && 
                (
                    this.ElimPoints == input.ElimPoints ||
                    (this.ElimPoints != null &&
                    this.ElimPoints.Equals(input.ElimPoints))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.AlliancePoints != null)
                    hashCode = hashCode * 59 + this.AlliancePoints.GetHashCode();
                if (this.AwardPoints != null)
                    hashCode = hashCode * 59 + this.AwardPoints.GetHashCode();
                if (this.QualPoints != null)
                    hashCode = hashCode * 59 + this.QualPoints.GetHashCode();
                if (this.ElimPoints != null)
                    hashCode = hashCode * 59 + this.ElimPoints.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
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
