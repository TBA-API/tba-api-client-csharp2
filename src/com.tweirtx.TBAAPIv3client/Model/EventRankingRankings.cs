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
using OpenAPIDateConverter = com.tweirtx.TBAAPIv3client.Client.OpenAPIDateConverter;

namespace com.tweirtx.TBAAPIv3client.Model
{
    /// <summary>
    /// EventRankingRankings
    /// </summary>
    [DataContract]
    public partial class EventRankingRankings :  IEquatable<EventRankingRankings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventRankingRankings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventRankingRankings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventRankingRankings" /> class.
        /// </summary>
        /// <param name="matchesPlayed">Number of matches played by this team. (required).</param>
        /// <param name="qualAverage">The average match score during qualifications. Year specific. May be null if not relevant for a given year..</param>
        /// <param name="extraStats">Additional special data on the team&#39;s performance calculated by TBA..</param>
        /// <param name="sortOrders">Additional year-specific information, may be null. See parent &#x60;sort_order_info&#x60; for details..</param>
        /// <param name="record">record (required).</param>
        /// <param name="rank">The team&#39;s rank at the event as provided by FIRST. (required).</param>
        /// <param name="dq">Number of times disqualified. (required).</param>
        /// <param name="teamKey">The team with this rank. (required).</param>
        public EventRankingRankings(int matchesPlayed = default(int), int qualAverage = default(int), List<decimal> extraStats = default(List<decimal>), List<decimal> sortOrders = default(List<decimal>), WLTRecord record = default(WLTRecord), int rank = default(int), int dq = default(int), string teamKey = default(string))
        {
            // to ensure "matchesPlayed" is required (not null)
            if (matchesPlayed == null)
            {
                throw new InvalidDataException("matchesPlayed is a required property for EventRankingRankings and cannot be null");
            }
            else
            {
                this.MatchesPlayed = matchesPlayed;
            }
            
            // to ensure "record" is required (not null)
            if (record == null)
            {
                throw new InvalidDataException("record is a required property for EventRankingRankings and cannot be null");
            }
            else
            {
                this.Record = record;
            }
            
            // to ensure "rank" is required (not null)
            if (rank == null)
            {
                throw new InvalidDataException("rank is a required property for EventRankingRankings and cannot be null");
            }
            else
            {
                this.Rank = rank;
            }
            
            // to ensure "dq" is required (not null)
            if (dq == null)
            {
                throw new InvalidDataException("dq is a required property for EventRankingRankings and cannot be null");
            }
            else
            {
                this.Dq = dq;
            }
            
            // to ensure "teamKey" is required (not null)
            if (teamKey == null)
            {
                throw new InvalidDataException("teamKey is a required property for EventRankingRankings and cannot be null");
            }
            else
            {
                this.TeamKey = teamKey;
            }
            
            this.QualAverage = qualAverage;
            this.ExtraStats = extraStats;
            this.SortOrders = sortOrders;
        }
        
        /// <summary>
        /// Number of matches played by this team.
        /// </summary>
        /// <value>Number of matches played by this team.</value>
        [DataMember(Name="matches_played", EmitDefaultValue=false)]
        public int MatchesPlayed { get; set; }

        /// <summary>
        /// The average match score during qualifications. Year specific. May be null if not relevant for a given year.
        /// </summary>
        /// <value>The average match score during qualifications. Year specific. May be null if not relevant for a given year.</value>
        [DataMember(Name="qual_average", EmitDefaultValue=false)]
        public int QualAverage { get; set; }

        /// <summary>
        /// Additional special data on the team&#39;s performance calculated by TBA.
        /// </summary>
        /// <value>Additional special data on the team&#39;s performance calculated by TBA.</value>
        [DataMember(Name="extra_stats", EmitDefaultValue=false)]
        public List<decimal> ExtraStats { get; set; }

        /// <summary>
        /// Additional year-specific information, may be null. See parent &#x60;sort_order_info&#x60; for details.
        /// </summary>
        /// <value>Additional year-specific information, may be null. See parent &#x60;sort_order_info&#x60; for details.</value>
        [DataMember(Name="sort_orders", EmitDefaultValue=false)]
        public List<decimal> SortOrders { get; set; }

        /// <summary>
        /// Gets or Sets Record
        /// </summary>
        [DataMember(Name="record", EmitDefaultValue=false)]
        public WLTRecord Record { get; set; }

        /// <summary>
        /// The team&#39;s rank at the event as provided by FIRST.
        /// </summary>
        /// <value>The team&#39;s rank at the event as provided by FIRST.</value>
        [DataMember(Name="rank", EmitDefaultValue=false)]
        public int Rank { get; set; }

        /// <summary>
        /// Number of times disqualified.
        /// </summary>
        /// <value>Number of times disqualified.</value>
        [DataMember(Name="dq", EmitDefaultValue=false)]
        public int Dq { get; set; }

        /// <summary>
        /// The team with this rank.
        /// </summary>
        /// <value>The team with this rank.</value>
        [DataMember(Name="team_key", EmitDefaultValue=false)]
        public string TeamKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventRankingRankings {\n");
            sb.Append("  MatchesPlayed: ").Append(MatchesPlayed).Append("\n");
            sb.Append("  QualAverage: ").Append(QualAverage).Append("\n");
            sb.Append("  ExtraStats: ").Append(ExtraStats).Append("\n");
            sb.Append("  SortOrders: ").Append(SortOrders).Append("\n");
            sb.Append("  Record: ").Append(Record).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Dq: ").Append(Dq).Append("\n");
            sb.Append("  TeamKey: ").Append(TeamKey).Append("\n");
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
            return this.Equals(input as EventRankingRankings);
        }

        /// <summary>
        /// Returns true if EventRankingRankings instances are equal
        /// </summary>
        /// <param name="input">Instance of EventRankingRankings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventRankingRankings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MatchesPlayed == input.MatchesPlayed ||
                    (this.MatchesPlayed != null &&
                    this.MatchesPlayed.Equals(input.MatchesPlayed))
                ) && 
                (
                    this.QualAverage == input.QualAverage ||
                    (this.QualAverage != null &&
                    this.QualAverage.Equals(input.QualAverage))
                ) && 
                (
                    this.ExtraStats == input.ExtraStats ||
                    this.ExtraStats != null &&
                    input.ExtraStats != null &&
                    this.ExtraStats.SequenceEqual(input.ExtraStats)
                ) && 
                (
                    this.SortOrders == input.SortOrders ||
                    this.SortOrders != null &&
                    input.SortOrders != null &&
                    this.SortOrders.SequenceEqual(input.SortOrders)
                ) && 
                (
                    this.Record == input.Record ||
                    (this.Record != null &&
                    this.Record.Equals(input.Record))
                ) && 
                (
                    this.Rank == input.Rank ||
                    (this.Rank != null &&
                    this.Rank.Equals(input.Rank))
                ) && 
                (
                    this.Dq == input.Dq ||
                    (this.Dq != null &&
                    this.Dq.Equals(input.Dq))
                ) && 
                (
                    this.TeamKey == input.TeamKey ||
                    (this.TeamKey != null &&
                    this.TeamKey.Equals(input.TeamKey))
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
                if (this.MatchesPlayed != null)
                    hashCode = hashCode * 59 + this.MatchesPlayed.GetHashCode();
                if (this.QualAverage != null)
                    hashCode = hashCode * 59 + this.QualAverage.GetHashCode();
                if (this.ExtraStats != null)
                    hashCode = hashCode * 59 + this.ExtraStats.GetHashCode();
                if (this.SortOrders != null)
                    hashCode = hashCode * 59 + this.SortOrders.GetHashCode();
                if (this.Record != null)
                    hashCode = hashCode * 59 + this.Record.GetHashCode();
                if (this.Rank != null)
                    hashCode = hashCode * 59 + this.Rank.GetHashCode();
                if (this.Dq != null)
                    hashCode = hashCode * 59 + this.Dq.GetHashCode();
                if (this.TeamKey != null)
                    hashCode = hashCode * 59 + this.TeamKey.GetHashCode();
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
