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
    /// Match
    /// </summary>
    [DataContract]
    public partial class Match :  IEquatable<Match>, IValidatableObject
    {
        /// <summary>
        /// The competition level the match was played at.
        /// </summary>
        /// <value>The competition level the match was played at.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompLevelEnum
        {
            
            /// <summary>
            /// Enum Qm for value: qm
            /// </summary>
            [EnumMember(Value = "qm")]
            Qm = 1,
            
            /// <summary>
            /// Enum Ef for value: ef
            /// </summary>
            [EnumMember(Value = "ef")]
            Ef = 2,
            
            /// <summary>
            /// Enum Qf for value: qf
            /// </summary>
            [EnumMember(Value = "qf")]
            Qf = 3,
            
            /// <summary>
            /// Enum Sf for value: sf
            /// </summary>
            [EnumMember(Value = "sf")]
            Sf = 4,
            
            /// <summary>
            /// Enum F for value: f
            /// </summary>
            [EnumMember(Value = "f")]
            F = 5
        }

        /// <summary>
        /// The competition level the match was played at.
        /// </summary>
        /// <value>The competition level the match was played at.</value>
        [DataMember(Name="comp_level", EmitDefaultValue=false)]
        public CompLevelEnum CompLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Match" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Match() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Match" /> class.
        /// </summary>
        /// <param name="Key">TBA match key with the format &#x60;yyyy[EVENT_CODE]_[COMP_LEVEL]m[MATCH_NUMBER]&#x60;, where &#x60;yyyy&#x60; is the year, and &#x60;EVENT_CODE&#x60; is the event code of the event, &#x60;COMP_LEVEL&#x60; is (qm, ef, qf, sf, f), and &#x60;MATCH_NUMBER&#x60; is the match number in the competition level. A set number may be appended to the competition level if more than one match in required per set. (required).</param>
        /// <param name="CompLevel">The competition level the match was played at. (required).</param>
        /// <param name="SetNumber">The set number in a series of matches where more than one match is required in the match series. (required).</param>
        /// <param name="MatchNumber">The match number of the match in the competition level. (required).</param>
        /// <param name="Alliances">Alliances.</param>
        /// <param name="WinningAlliance">The color (red/blue) of the winning alliance. Will contain an empty string in the event of no winner, or a tie..</param>
        /// <param name="EventKey">Event key of the event the match was played at. (required).</param>
        /// <param name="Time">UNIX timestamp (seconds since 1-Jan-1970 00:00:00) of the scheduled match time, as taken from the published schedule..</param>
        /// <param name="ActualTime">UNIX timestamp (seconds since 1-Jan-1970 00:00:00) of actual match start time..</param>
        /// <param name="PredictedTime">UNIX timestamp (seconds since 1-Jan-1970 00:00:00) of the TBA predicted match start time..</param>
        /// <param name="PostResultTime">UNIX timestamp (seconds since 1-Jan-1970 00:00:00) when the match result was posted..</param>
        /// <param name="ScoreBreakdown">Score breakdown for auto, teleop, etc. points. Varies from year to year. May be null..</param>
        /// <param name="Videos">Array of video objects associated with this match..</param>
        public Match(string Key = default(string), CompLevelEnum CompLevel = default(CompLevelEnum), int? SetNumber = default(int?), int? MatchNumber = default(int?), MatchSimpleAlliances Alliances = default(MatchSimpleAlliances), string WinningAlliance = default(string), string EventKey = default(string), long? Time = default(long?), long? ActualTime = default(long?), long? PredictedTime = default(long?), long? PostResultTime = default(long?), Object ScoreBreakdown = default(Object), List<MatchVideos> Videos = default(List<MatchVideos>))
        {
            // to ensure "Key" is required (not null)
            if (Key == null)
            {
                throw new InvalidDataException("Key is a required property for Match and cannot be null");
            }
            else
            {
                this.Key = Key;
            }
            // to ensure "CompLevel" is required (not null)
            if (CompLevel == null)
            {
                throw new InvalidDataException("CompLevel is a required property for Match and cannot be null");
            }
            else
            {
                this.CompLevel = CompLevel;
            }
            // to ensure "SetNumber" is required (not null)
            if (SetNumber == null)
            {
                throw new InvalidDataException("SetNumber is a required property for Match and cannot be null");
            }
            else
            {
                this.SetNumber = SetNumber;
            }
            // to ensure "MatchNumber" is required (not null)
            if (MatchNumber == null)
            {
                throw new InvalidDataException("MatchNumber is a required property for Match and cannot be null");
            }
            else
            {
                this.MatchNumber = MatchNumber;
            }
            // to ensure "EventKey" is required (not null)
            if (EventKey == null)
            {
                throw new InvalidDataException("EventKey is a required property for Match and cannot be null");
            }
            else
            {
                this.EventKey = EventKey;
            }
            this.Alliances = Alliances;
            this.WinningAlliance = WinningAlliance;
            this.Time = Time;
            this.ActualTime = ActualTime;
            this.PredictedTime = PredictedTime;
            this.PostResultTime = PostResultTime;
            this.ScoreBreakdown = ScoreBreakdown;
            this.Videos = Videos;
        }
        
        /// <summary>
        /// TBA match key with the format &#x60;yyyy[EVENT_CODE]_[COMP_LEVEL]m[MATCH_NUMBER]&#x60;, where &#x60;yyyy&#x60; is the year, and &#x60;EVENT_CODE&#x60; is the event code of the event, &#x60;COMP_LEVEL&#x60; is (qm, ef, qf, sf, f), and &#x60;MATCH_NUMBER&#x60; is the match number in the competition level. A set number may be appended to the competition level if more than one match in required per set.
        /// </summary>
        /// <value>TBA match key with the format &#x60;yyyy[EVENT_CODE]_[COMP_LEVEL]m[MATCH_NUMBER]&#x60;, where &#x60;yyyy&#x60; is the year, and &#x60;EVENT_CODE&#x60; is the event code of the event, &#x60;COMP_LEVEL&#x60; is (qm, ef, qf, sf, f), and &#x60;MATCH_NUMBER&#x60; is the match number in the competition level. A set number may be appended to the competition level if more than one match in required per set.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }


        /// <summary>
        /// The set number in a series of matches where more than one match is required in the match series.
        /// </summary>
        /// <value>The set number in a series of matches where more than one match is required in the match series.</value>
        [DataMember(Name="set_number", EmitDefaultValue=false)]
        public int? SetNumber { get; set; }

        /// <summary>
        /// The match number of the match in the competition level.
        /// </summary>
        /// <value>The match number of the match in the competition level.</value>
        [DataMember(Name="match_number", EmitDefaultValue=false)]
        public int? MatchNumber { get; set; }

        /// <summary>
        /// Gets or Sets Alliances
        /// </summary>
        [DataMember(Name="alliances", EmitDefaultValue=false)]
        public MatchSimpleAlliances Alliances { get; set; }

        /// <summary>
        /// The color (red/blue) of the winning alliance. Will contain an empty string in the event of no winner, or a tie.
        /// </summary>
        /// <value>The color (red/blue) of the winning alliance. Will contain an empty string in the event of no winner, or a tie.</value>
        [DataMember(Name="winning_alliance", EmitDefaultValue=false)]
        public string WinningAlliance { get; set; }

        /// <summary>
        /// Event key of the event the match was played at.
        /// </summary>
        /// <value>Event key of the event the match was played at.</value>
        [DataMember(Name="event_key", EmitDefaultValue=false)]
        public string EventKey { get; set; }

        /// <summary>
        /// UNIX timestamp (seconds since 1-Jan-1970 00:00:00) of the scheduled match time, as taken from the published schedule.
        /// </summary>
        /// <value>UNIX timestamp (seconds since 1-Jan-1970 00:00:00) of the scheduled match time, as taken from the published schedule.</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public long? Time { get; set; }

        /// <summary>
        /// UNIX timestamp (seconds since 1-Jan-1970 00:00:00) of actual match start time.
        /// </summary>
        /// <value>UNIX timestamp (seconds since 1-Jan-1970 00:00:00) of actual match start time.</value>
        [DataMember(Name="actual_time", EmitDefaultValue=false)]
        public long? ActualTime { get; set; }

        /// <summary>
        /// UNIX timestamp (seconds since 1-Jan-1970 00:00:00) of the TBA predicted match start time.
        /// </summary>
        /// <value>UNIX timestamp (seconds since 1-Jan-1970 00:00:00) of the TBA predicted match start time.</value>
        [DataMember(Name="predicted_time", EmitDefaultValue=false)]
        public long? PredictedTime { get; set; }

        /// <summary>
        /// UNIX timestamp (seconds since 1-Jan-1970 00:00:00) when the match result was posted.
        /// </summary>
        /// <value>UNIX timestamp (seconds since 1-Jan-1970 00:00:00) when the match result was posted.</value>
        [DataMember(Name="post_result_time", EmitDefaultValue=false)]
        public long? PostResultTime { get; set; }

        /// <summary>
        /// Score breakdown for auto, teleop, etc. points. Varies from year to year. May be null.
        /// </summary>
        /// <value>Score breakdown for auto, teleop, etc. points. Varies from year to year. May be null.</value>
        [DataMember(Name="score_breakdown", EmitDefaultValue=false)]
        public Object ScoreBreakdown { get; set; }

        /// <summary>
        /// Array of video objects associated with this match.
        /// </summary>
        /// <value>Array of video objects associated with this match.</value>
        [DataMember(Name="videos", EmitDefaultValue=false)]
        public List<MatchVideos> Videos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Match {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  CompLevel: ").Append(CompLevel).Append("\n");
            sb.Append("  SetNumber: ").Append(SetNumber).Append("\n");
            sb.Append("  MatchNumber: ").Append(MatchNumber).Append("\n");
            sb.Append("  Alliances: ").Append(Alliances).Append("\n");
            sb.Append("  WinningAlliance: ").Append(WinningAlliance).Append("\n");
            sb.Append("  EventKey: ").Append(EventKey).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  ActualTime: ").Append(ActualTime).Append("\n");
            sb.Append("  PredictedTime: ").Append(PredictedTime).Append("\n");
            sb.Append("  PostResultTime: ").Append(PostResultTime).Append("\n");
            sb.Append("  ScoreBreakdown: ").Append(ScoreBreakdown).Append("\n");
            sb.Append("  Videos: ").Append(Videos).Append("\n");
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
            return this.Equals(input as Match);
        }

        /// <summary>
        /// Returns true if Match instances are equal
        /// </summary>
        /// <param name="input">Instance of Match to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Match input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.CompLevel == input.CompLevel ||
                    (this.CompLevel != null &&
                    this.CompLevel.Equals(input.CompLevel))
                ) && 
                (
                    this.SetNumber == input.SetNumber ||
                    (this.SetNumber != null &&
                    this.SetNumber.Equals(input.SetNumber))
                ) && 
                (
                    this.MatchNumber == input.MatchNumber ||
                    (this.MatchNumber != null &&
                    this.MatchNumber.Equals(input.MatchNumber))
                ) && 
                (
                    this.Alliances == input.Alliances ||
                    (this.Alliances != null &&
                    this.Alliances.Equals(input.Alliances))
                ) && 
                (
                    this.WinningAlliance == input.WinningAlliance ||
                    (this.WinningAlliance != null &&
                    this.WinningAlliance.Equals(input.WinningAlliance))
                ) && 
                (
                    this.EventKey == input.EventKey ||
                    (this.EventKey != null &&
                    this.EventKey.Equals(input.EventKey))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.ActualTime == input.ActualTime ||
                    (this.ActualTime != null &&
                    this.ActualTime.Equals(input.ActualTime))
                ) && 
                (
                    this.PredictedTime == input.PredictedTime ||
                    (this.PredictedTime != null &&
                    this.PredictedTime.Equals(input.PredictedTime))
                ) && 
                (
                    this.PostResultTime == input.PostResultTime ||
                    (this.PostResultTime != null &&
                    this.PostResultTime.Equals(input.PostResultTime))
                ) && 
                (
                    this.ScoreBreakdown == input.ScoreBreakdown ||
                    (this.ScoreBreakdown != null &&
                    this.ScoreBreakdown.Equals(input.ScoreBreakdown))
                ) && 
                (
                    this.Videos == input.Videos ||
                    this.Videos != null &&
                    this.Videos.SequenceEqual(input.Videos)
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.CompLevel != null)
                    hashCode = hashCode * 59 + this.CompLevel.GetHashCode();
                if (this.SetNumber != null)
                    hashCode = hashCode * 59 + this.SetNumber.GetHashCode();
                if (this.MatchNumber != null)
                    hashCode = hashCode * 59 + this.MatchNumber.GetHashCode();
                if (this.Alliances != null)
                    hashCode = hashCode * 59 + this.Alliances.GetHashCode();
                if (this.WinningAlliance != null)
                    hashCode = hashCode * 59 + this.WinningAlliance.GetHashCode();
                if (this.EventKey != null)
                    hashCode = hashCode * 59 + this.EventKey.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.ActualTime != null)
                    hashCode = hashCode * 59 + this.ActualTime.GetHashCode();
                if (this.PredictedTime != null)
                    hashCode = hashCode * 59 + this.PredictedTime.GetHashCode();
                if (this.PostResultTime != null)
                    hashCode = hashCode * 59 + this.PostResultTime.GetHashCode();
                if (this.ScoreBreakdown != null)
                    hashCode = hashCode * 59 + this.ScoreBreakdown.GetHashCode();
                if (this.Videos != null)
                    hashCode = hashCode * 59 + this.Videos.GetHashCode();
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