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
    /// TeamEventStatus
    /// </summary>
    [DataContract]
    public partial class TeamEventStatus :  IEquatable<TeamEventStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamEventStatus" /> class.
        /// </summary>
        /// <param name="qual">qual.</param>
        /// <param name="alliance">alliance.</param>
        /// <param name="playoff">playoff.</param>
        /// <param name="allianceStatusStr">An HTML formatted string suitable for display to the user containing the team&#39;s alliance pick status..</param>
        /// <param name="playoffStatusStr">An HTML formatter string suitable for display to the user containing the team&#39;s playoff status..</param>
        /// <param name="overallStatusStr">An HTML formatted string suitable for display to the user containing the team&#39;s overall status summary of the event..</param>
        /// <param name="nextMatchKey">TBA match key for the next match the team is scheduled to play in at this event, or null..</param>
        /// <param name="lastMatchKey">TBA match key for the last match the team played in at this event, or null..</param>
        public TeamEventStatus(TeamEventStatusRank qual = default(TeamEventStatusRank), TeamEventStatusAlliance alliance = default(TeamEventStatusAlliance), TeamEventStatusPlayoff playoff = default(TeamEventStatusPlayoff), string allianceStatusStr = default(string), string playoffStatusStr = default(string), string overallStatusStr = default(string), string nextMatchKey = default(string), string lastMatchKey = default(string))
        {
            this.Qual = qual;
            this.Alliance = alliance;
            this.Playoff = playoff;
            this.AllianceStatusStr = allianceStatusStr;
            this.PlayoffStatusStr = playoffStatusStr;
            this.OverallStatusStr = overallStatusStr;
            this.NextMatchKey = nextMatchKey;
            this.LastMatchKey = lastMatchKey;
        }
        
        /// <summary>
        /// Gets or Sets Qual
        /// </summary>
        [DataMember(Name="qual", EmitDefaultValue=false)]
        public TeamEventStatusRank Qual { get; set; }

        /// <summary>
        /// Gets or Sets Alliance
        /// </summary>
        [DataMember(Name="alliance", EmitDefaultValue=false)]
        public TeamEventStatusAlliance Alliance { get; set; }

        /// <summary>
        /// Gets or Sets Playoff
        /// </summary>
        [DataMember(Name="playoff", EmitDefaultValue=false)]
        public TeamEventStatusPlayoff Playoff { get; set; }

        /// <summary>
        /// An HTML formatted string suitable for display to the user containing the team&#39;s alliance pick status.
        /// </summary>
        /// <value>An HTML formatted string suitable for display to the user containing the team&#39;s alliance pick status.</value>
        [DataMember(Name="alliance_status_str", EmitDefaultValue=false)]
        public string AllianceStatusStr { get; set; }

        /// <summary>
        /// An HTML formatter string suitable for display to the user containing the team&#39;s playoff status.
        /// </summary>
        /// <value>An HTML formatter string suitable for display to the user containing the team&#39;s playoff status.</value>
        [DataMember(Name="playoff_status_str", EmitDefaultValue=false)]
        public string PlayoffStatusStr { get; set; }

        /// <summary>
        /// An HTML formatted string suitable for display to the user containing the team&#39;s overall status summary of the event.
        /// </summary>
        /// <value>An HTML formatted string suitable for display to the user containing the team&#39;s overall status summary of the event.</value>
        [DataMember(Name="overall_status_str", EmitDefaultValue=false)]
        public string OverallStatusStr { get; set; }

        /// <summary>
        /// TBA match key for the next match the team is scheduled to play in at this event, or null.
        /// </summary>
        /// <value>TBA match key for the next match the team is scheduled to play in at this event, or null.</value>
        [DataMember(Name="next_match_key", EmitDefaultValue=false)]
        public string NextMatchKey { get; set; }

        /// <summary>
        /// TBA match key for the last match the team played in at this event, or null.
        /// </summary>
        /// <value>TBA match key for the last match the team played in at this event, or null.</value>
        [DataMember(Name="last_match_key", EmitDefaultValue=false)]
        public string LastMatchKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamEventStatus {\n");
            sb.Append("  Qual: ").Append(Qual).Append("\n");
            sb.Append("  Alliance: ").Append(Alliance).Append("\n");
            sb.Append("  Playoff: ").Append(Playoff).Append("\n");
            sb.Append("  AllianceStatusStr: ").Append(AllianceStatusStr).Append("\n");
            sb.Append("  PlayoffStatusStr: ").Append(PlayoffStatusStr).Append("\n");
            sb.Append("  OverallStatusStr: ").Append(OverallStatusStr).Append("\n");
            sb.Append("  NextMatchKey: ").Append(NextMatchKey).Append("\n");
            sb.Append("  LastMatchKey: ").Append(LastMatchKey).Append("\n");
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
            return this.Equals(input as TeamEventStatus);
        }

        /// <summary>
        /// Returns true if TeamEventStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamEventStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamEventStatus input)
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
                    this.Alliance == input.Alliance ||
                    (this.Alliance != null &&
                    this.Alliance.Equals(input.Alliance))
                ) && 
                (
                    this.Playoff == input.Playoff ||
                    (this.Playoff != null &&
                    this.Playoff.Equals(input.Playoff))
                ) && 
                (
                    this.AllianceStatusStr == input.AllianceStatusStr ||
                    (this.AllianceStatusStr != null &&
                    this.AllianceStatusStr.Equals(input.AllianceStatusStr))
                ) && 
                (
                    this.PlayoffStatusStr == input.PlayoffStatusStr ||
                    (this.PlayoffStatusStr != null &&
                    this.PlayoffStatusStr.Equals(input.PlayoffStatusStr))
                ) && 
                (
                    this.OverallStatusStr == input.OverallStatusStr ||
                    (this.OverallStatusStr != null &&
                    this.OverallStatusStr.Equals(input.OverallStatusStr))
                ) && 
                (
                    this.NextMatchKey == input.NextMatchKey ||
                    (this.NextMatchKey != null &&
                    this.NextMatchKey.Equals(input.NextMatchKey))
                ) && 
                (
                    this.LastMatchKey == input.LastMatchKey ||
                    (this.LastMatchKey != null &&
                    this.LastMatchKey.Equals(input.LastMatchKey))
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
                if (this.Alliance != null)
                    hashCode = hashCode * 59 + this.Alliance.GetHashCode();
                if (this.Playoff != null)
                    hashCode = hashCode * 59 + this.Playoff.GetHashCode();
                if (this.AllianceStatusStr != null)
                    hashCode = hashCode * 59 + this.AllianceStatusStr.GetHashCode();
                if (this.PlayoffStatusStr != null)
                    hashCode = hashCode * 59 + this.PlayoffStatusStr.GetHashCode();
                if (this.OverallStatusStr != null)
                    hashCode = hashCode * 59 + this.OverallStatusStr.GetHashCode();
                if (this.NextMatchKey != null)
                    hashCode = hashCode * 59 + this.NextMatchKey.GetHashCode();
                if (this.LastMatchKey != null)
                    hashCode = hashCode * 59 + this.LastMatchKey.GetHashCode();
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
