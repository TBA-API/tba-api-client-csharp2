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
    /// EliminationAllianceStatus
    /// </summary>
    [DataContract]
    public partial class EliminationAllianceStatus :  IEquatable<EliminationAllianceStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EliminationAllianceStatus" /> class.
        /// </summary>
        /// <param name="CurrentLevelRecord">CurrentLevelRecord.</param>
        /// <param name="Level">Level.</param>
        /// <param name="PlayoffAverage">PlayoffAverage.</param>
        /// <param name="Record">Record.</param>
        /// <param name="Status">Status.</param>
        public EliminationAllianceStatus(WLTRecord CurrentLevelRecord = default(WLTRecord), string Level = default(string), double? PlayoffAverage = default(double?), WLTRecord Record = default(WLTRecord), string Status = default(string))
        {
            this.CurrentLevelRecord = CurrentLevelRecord;
            this.Level = Level;
            this.PlayoffAverage = PlayoffAverage;
            this.Record = Record;
            this.Status = Status;
        }
        
        /// <summary>
        /// Gets or Sets CurrentLevelRecord
        /// </summary>
        [DataMember(Name="current_level_record", EmitDefaultValue=false)]
        public WLTRecord CurrentLevelRecord { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public string Level { get; set; }

        /// <summary>
        /// Gets or Sets PlayoffAverage
        /// </summary>
        [DataMember(Name="playoff_average", EmitDefaultValue=false)]
        public double? PlayoffAverage { get; set; }

        /// <summary>
        /// Gets or Sets Record
        /// </summary>
        [DataMember(Name="record", EmitDefaultValue=false)]
        public WLTRecord Record { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EliminationAllianceStatus {\n");
            sb.Append("  CurrentLevelRecord: ").Append(CurrentLevelRecord).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  PlayoffAverage: ").Append(PlayoffAverage).Append("\n");
            sb.Append("  Record: ").Append(Record).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as EliminationAllianceStatus);
        }

        /// <summary>
        /// Returns true if EliminationAllianceStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of EliminationAllianceStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EliminationAllianceStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentLevelRecord == input.CurrentLevelRecord ||
                    (this.CurrentLevelRecord != null &&
                    this.CurrentLevelRecord.Equals(input.CurrentLevelRecord))
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.PlayoffAverage == input.PlayoffAverage ||
                    (this.PlayoffAverage != null &&
                    this.PlayoffAverage.Equals(input.PlayoffAverage))
                ) && 
                (
                    this.Record == input.Record ||
                    (this.Record != null &&
                    this.Record.Equals(input.Record))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.CurrentLevelRecord != null)
                    hashCode = hashCode * 59 + this.CurrentLevelRecord.GetHashCode();
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.PlayoffAverage != null)
                    hashCode = hashCode * 59 + this.PlayoffAverage.GetHashCode();
                if (this.Record != null)
                    hashCode = hashCode * 59 + this.Record.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
