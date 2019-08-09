/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.5
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
    /// Insights for FIRST Stronghold qualification and elimination matches.
    /// </summary>
    [DataContract]
    public partial class EventInsights2016 :  IEquatable<EventInsights2016>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventInsights2016" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventInsights2016() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventInsights2016" /> class.
        /// </summary>
        /// <param name="lowBar">For the Low Bar - An array with three values, number of times damaged, number of opportunities to damage, and percentage. (required).</param>
        /// <param name="aChevalDeFrise">For the Cheval De Frise - An array with three values, number of times damaged, number of opportunities to damage, and percentage. (required).</param>
        /// <param name="aPortcullis">For the Portcullis - An array with three values, number of times damaged, number of opportunities to damage, and percentage. (required).</param>
        /// <param name="bRamparts">For the Ramparts - An array with three values, number of times damaged, number of opportunities to damage, and percentage. (required).</param>
        /// <param name="bMoat">For the Moat - An array with three values, number of times damaged, number of opportunities to damage, and percentage. (required).</param>
        /// <param name="cSallyPort">For the Sally Port - An array with three values, number of times damaged, number of opportunities to damage, and percentage. (required).</param>
        /// <param name="cDrawbridge">For the Drawbridge - An array with three values, number of times damaged, number of opportunities to damage, and percentage. (required).</param>
        /// <param name="dRoughTerrain">For the Rough Terrain - An array with three values, number of times damaged, number of opportunities to damage, and percentage. (required).</param>
        /// <param name="dRockWall">For the Rock Wall - An array with three values, number of times damaged, number of opportunities to damage, and percentage. (required).</param>
        /// <param name="averageHighGoals">Average number of high goals scored. (required).</param>
        /// <param name="averageLowGoals">Average number of low goals scored. (required).</param>
        /// <param name="breaches">An array with three values, number of times breached, number of opportunities to breach, and percentage. (required).</param>
        /// <param name="scales">An array with three values, number of times scaled, number of opportunities to scale, and percentage. (required).</param>
        /// <param name="challenges">An array with three values, number of times challenged, number of opportunities to challenge, and percentage. (required).</param>
        /// <param name="captures">An array with three values, number of times captured, number of opportunities to capture, and percentage. (required).</param>
        /// <param name="averageWinScore">Average winning score. (required).</param>
        /// <param name="averageWinMargin">Average margin of victory. (required).</param>
        /// <param name="averageScore">Average total score. (required).</param>
        /// <param name="averageAutoScore">Average autonomous score. (required).</param>
        /// <param name="averageCrossingScore">Average crossing score. (required).</param>
        /// <param name="averageBoulderScore">Average boulder score. (required).</param>
        /// <param name="averageTowerScore">Average tower score. (required).</param>
        /// <param name="averageFoulScore">Average foul score. (required).</param>
        /// <param name="highScore">An array with three values, high score, match key from the match with the high score, and the name of the match. (required).</param>
        public EventInsights2016(List<float> lowBar = default(List<float>), List<float> aChevalDeFrise = default(List<float>), List<float> aPortcullis = default(List<float>), List<float> bRamparts = default(List<float>), List<float> bMoat = default(List<float>), List<float> cSallyPort = default(List<float>), List<float> cDrawbridge = default(List<float>), List<float> dRoughTerrain = default(List<float>), List<float> dRockWall = default(List<float>), float averageHighGoals = default(float), float averageLowGoals = default(float), List<float> breaches = default(List<float>), List<float> scales = default(List<float>), List<float> challenges = default(List<float>), List<float> captures = default(List<float>), float averageWinScore = default(float), float averageWinMargin = default(float), float averageScore = default(float), float averageAutoScore = default(float), float averageCrossingScore = default(float), float averageBoulderScore = default(float), float averageTowerScore = default(float), float averageFoulScore = default(float), List<string> highScore = default(List<string>))
        {
            // to ensure "lowBar" is required (not null)
            if (lowBar == null)
            {
                throw new InvalidDataException("lowBar is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.LowBar = lowBar;
            }
            
            // to ensure "aChevalDeFrise" is required (not null)
            if (aChevalDeFrise == null)
            {
                throw new InvalidDataException("aChevalDeFrise is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.AChevalDeFrise = aChevalDeFrise;
            }
            
            // to ensure "aPortcullis" is required (not null)
            if (aPortcullis == null)
            {
                throw new InvalidDataException("aPortcullis is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.APortcullis = aPortcullis;
            }
            
            // to ensure "bRamparts" is required (not null)
            if (bRamparts == null)
            {
                throw new InvalidDataException("bRamparts is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.BRamparts = bRamparts;
            }
            
            // to ensure "bMoat" is required (not null)
            if (bMoat == null)
            {
                throw new InvalidDataException("bMoat is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.BMoat = bMoat;
            }
            
            // to ensure "cSallyPort" is required (not null)
            if (cSallyPort == null)
            {
                throw new InvalidDataException("cSallyPort is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.CSallyPort = cSallyPort;
            }
            
            // to ensure "cDrawbridge" is required (not null)
            if (cDrawbridge == null)
            {
                throw new InvalidDataException("cDrawbridge is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.CDrawbridge = cDrawbridge;
            }
            
            // to ensure "dRoughTerrain" is required (not null)
            if (dRoughTerrain == null)
            {
                throw new InvalidDataException("dRoughTerrain is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.DRoughTerrain = dRoughTerrain;
            }
            
            // to ensure "dRockWall" is required (not null)
            if (dRockWall == null)
            {
                throw new InvalidDataException("dRockWall is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.DRockWall = dRockWall;
            }
            
            // to ensure "averageHighGoals" is required (not null)
            if (averageHighGoals == null)
            {
                throw new InvalidDataException("averageHighGoals is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.AverageHighGoals = averageHighGoals;
            }
            
            // to ensure "averageLowGoals" is required (not null)
            if (averageLowGoals == null)
            {
                throw new InvalidDataException("averageLowGoals is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.AverageLowGoals = averageLowGoals;
            }
            
            // to ensure "breaches" is required (not null)
            if (breaches == null)
            {
                throw new InvalidDataException("breaches is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.Breaches = breaches;
            }
            
            // to ensure "scales" is required (not null)
            if (scales == null)
            {
                throw new InvalidDataException("scales is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.Scales = scales;
            }
            
            // to ensure "challenges" is required (not null)
            if (challenges == null)
            {
                throw new InvalidDataException("challenges is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.Challenges = challenges;
            }
            
            // to ensure "captures" is required (not null)
            if (captures == null)
            {
                throw new InvalidDataException("captures is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.Captures = captures;
            }
            
            // to ensure "averageWinScore" is required (not null)
            if (averageWinScore == null)
            {
                throw new InvalidDataException("averageWinScore is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.AverageWinScore = averageWinScore;
            }
            
            // to ensure "averageWinMargin" is required (not null)
            if (averageWinMargin == null)
            {
                throw new InvalidDataException("averageWinMargin is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.AverageWinMargin = averageWinMargin;
            }
            
            // to ensure "averageScore" is required (not null)
            if (averageScore == null)
            {
                throw new InvalidDataException("averageScore is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.AverageScore = averageScore;
            }
            
            // to ensure "averageAutoScore" is required (not null)
            if (averageAutoScore == null)
            {
                throw new InvalidDataException("averageAutoScore is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.AverageAutoScore = averageAutoScore;
            }
            
            // to ensure "averageCrossingScore" is required (not null)
            if (averageCrossingScore == null)
            {
                throw new InvalidDataException("averageCrossingScore is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.AverageCrossingScore = averageCrossingScore;
            }
            
            // to ensure "averageBoulderScore" is required (not null)
            if (averageBoulderScore == null)
            {
                throw new InvalidDataException("averageBoulderScore is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.AverageBoulderScore = averageBoulderScore;
            }
            
            // to ensure "averageTowerScore" is required (not null)
            if (averageTowerScore == null)
            {
                throw new InvalidDataException("averageTowerScore is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.AverageTowerScore = averageTowerScore;
            }
            
            // to ensure "averageFoulScore" is required (not null)
            if (averageFoulScore == null)
            {
                throw new InvalidDataException("averageFoulScore is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.AverageFoulScore = averageFoulScore;
            }
            
            // to ensure "highScore" is required (not null)
            if (highScore == null)
            {
                throw new InvalidDataException("highScore is a required property for EventInsights2016 and cannot be null");
            }
            else
            {
                this.HighScore = highScore;
            }
            
        }
        
        /// <summary>
        /// For the Low Bar - An array with three values, number of times damaged, number of opportunities to damage, and percentage.
        /// </summary>
        /// <value>For the Low Bar - An array with three values, number of times damaged, number of opportunities to damage, and percentage.</value>
        [DataMember(Name="LowBar", EmitDefaultValue=false)]
        public List<float> LowBar { get; set; }

        /// <summary>
        /// For the Cheval De Frise - An array with three values, number of times damaged, number of opportunities to damage, and percentage.
        /// </summary>
        /// <value>For the Cheval De Frise - An array with three values, number of times damaged, number of opportunities to damage, and percentage.</value>
        [DataMember(Name="A_ChevalDeFrise", EmitDefaultValue=false)]
        public List<float> AChevalDeFrise { get; set; }

        /// <summary>
        /// For the Portcullis - An array with three values, number of times damaged, number of opportunities to damage, and percentage.
        /// </summary>
        /// <value>For the Portcullis - An array with three values, number of times damaged, number of opportunities to damage, and percentage.</value>
        [DataMember(Name="A_Portcullis", EmitDefaultValue=false)]
        public List<float> APortcullis { get; set; }

        /// <summary>
        /// For the Ramparts - An array with three values, number of times damaged, number of opportunities to damage, and percentage.
        /// </summary>
        /// <value>For the Ramparts - An array with three values, number of times damaged, number of opportunities to damage, and percentage.</value>
        [DataMember(Name="B_Ramparts", EmitDefaultValue=false)]
        public List<float> BRamparts { get; set; }

        /// <summary>
        /// For the Moat - An array with three values, number of times damaged, number of opportunities to damage, and percentage.
        /// </summary>
        /// <value>For the Moat - An array with three values, number of times damaged, number of opportunities to damage, and percentage.</value>
        [DataMember(Name="B_Moat", EmitDefaultValue=false)]
        public List<float> BMoat { get; set; }

        /// <summary>
        /// For the Sally Port - An array with three values, number of times damaged, number of opportunities to damage, and percentage.
        /// </summary>
        /// <value>For the Sally Port - An array with three values, number of times damaged, number of opportunities to damage, and percentage.</value>
        [DataMember(Name="C_SallyPort", EmitDefaultValue=false)]
        public List<float> CSallyPort { get; set; }

        /// <summary>
        /// For the Drawbridge - An array with three values, number of times damaged, number of opportunities to damage, and percentage.
        /// </summary>
        /// <value>For the Drawbridge - An array with three values, number of times damaged, number of opportunities to damage, and percentage.</value>
        [DataMember(Name="C_Drawbridge", EmitDefaultValue=false)]
        public List<float> CDrawbridge { get; set; }

        /// <summary>
        /// For the Rough Terrain - An array with three values, number of times damaged, number of opportunities to damage, and percentage.
        /// </summary>
        /// <value>For the Rough Terrain - An array with three values, number of times damaged, number of opportunities to damage, and percentage.</value>
        [DataMember(Name="D_RoughTerrain", EmitDefaultValue=false)]
        public List<float> DRoughTerrain { get; set; }

        /// <summary>
        /// For the Rock Wall - An array with three values, number of times damaged, number of opportunities to damage, and percentage.
        /// </summary>
        /// <value>For the Rock Wall - An array with three values, number of times damaged, number of opportunities to damage, and percentage.</value>
        [DataMember(Name="D_RockWall", EmitDefaultValue=false)]
        public List<float> DRockWall { get; set; }

        /// <summary>
        /// Average number of high goals scored.
        /// </summary>
        /// <value>Average number of high goals scored.</value>
        [DataMember(Name="average_high_goals", EmitDefaultValue=false)]
        public float AverageHighGoals { get; set; }

        /// <summary>
        /// Average number of low goals scored.
        /// </summary>
        /// <value>Average number of low goals scored.</value>
        [DataMember(Name="average_low_goals", EmitDefaultValue=false)]
        public float AverageLowGoals { get; set; }

        /// <summary>
        /// An array with three values, number of times breached, number of opportunities to breach, and percentage.
        /// </summary>
        /// <value>An array with three values, number of times breached, number of opportunities to breach, and percentage.</value>
        [DataMember(Name="breaches", EmitDefaultValue=false)]
        public List<float> Breaches { get; set; }

        /// <summary>
        /// An array with three values, number of times scaled, number of opportunities to scale, and percentage.
        /// </summary>
        /// <value>An array with three values, number of times scaled, number of opportunities to scale, and percentage.</value>
        [DataMember(Name="scales", EmitDefaultValue=false)]
        public List<float> Scales { get; set; }

        /// <summary>
        /// An array with three values, number of times challenged, number of opportunities to challenge, and percentage.
        /// </summary>
        /// <value>An array with three values, number of times challenged, number of opportunities to challenge, and percentage.</value>
        [DataMember(Name="challenges", EmitDefaultValue=false)]
        public List<float> Challenges { get; set; }

        /// <summary>
        /// An array with three values, number of times captured, number of opportunities to capture, and percentage.
        /// </summary>
        /// <value>An array with three values, number of times captured, number of opportunities to capture, and percentage.</value>
        [DataMember(Name="captures", EmitDefaultValue=false)]
        public List<float> Captures { get; set; }

        /// <summary>
        /// Average winning score.
        /// </summary>
        /// <value>Average winning score.</value>
        [DataMember(Name="average_win_score", EmitDefaultValue=false)]
        public float AverageWinScore { get; set; }

        /// <summary>
        /// Average margin of victory.
        /// </summary>
        /// <value>Average margin of victory.</value>
        [DataMember(Name="average_win_margin", EmitDefaultValue=false)]
        public float AverageWinMargin { get; set; }

        /// <summary>
        /// Average total score.
        /// </summary>
        /// <value>Average total score.</value>
        [DataMember(Name="average_score", EmitDefaultValue=false)]
        public float AverageScore { get; set; }

        /// <summary>
        /// Average autonomous score.
        /// </summary>
        /// <value>Average autonomous score.</value>
        [DataMember(Name="average_auto_score", EmitDefaultValue=false)]
        public float AverageAutoScore { get; set; }

        /// <summary>
        /// Average crossing score.
        /// </summary>
        /// <value>Average crossing score.</value>
        [DataMember(Name="average_crossing_score", EmitDefaultValue=false)]
        public float AverageCrossingScore { get; set; }

        /// <summary>
        /// Average boulder score.
        /// </summary>
        /// <value>Average boulder score.</value>
        [DataMember(Name="average_boulder_score", EmitDefaultValue=false)]
        public float AverageBoulderScore { get; set; }

        /// <summary>
        /// Average tower score.
        /// </summary>
        /// <value>Average tower score.</value>
        [DataMember(Name="average_tower_score", EmitDefaultValue=false)]
        public float AverageTowerScore { get; set; }

        /// <summary>
        /// Average foul score.
        /// </summary>
        /// <value>Average foul score.</value>
        [DataMember(Name="average_foul_score", EmitDefaultValue=false)]
        public float AverageFoulScore { get; set; }

        /// <summary>
        /// An array with three values, high score, match key from the match with the high score, and the name of the match.
        /// </summary>
        /// <value>An array with three values, high score, match key from the match with the high score, and the name of the match.</value>
        [DataMember(Name="high_score", EmitDefaultValue=false)]
        public List<string> HighScore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventInsights2016 {\n");
            sb.Append("  LowBar: ").Append(LowBar).Append("\n");
            sb.Append("  AChevalDeFrise: ").Append(AChevalDeFrise).Append("\n");
            sb.Append("  APortcullis: ").Append(APortcullis).Append("\n");
            sb.Append("  BRamparts: ").Append(BRamparts).Append("\n");
            sb.Append("  BMoat: ").Append(BMoat).Append("\n");
            sb.Append("  CSallyPort: ").Append(CSallyPort).Append("\n");
            sb.Append("  CDrawbridge: ").Append(CDrawbridge).Append("\n");
            sb.Append("  DRoughTerrain: ").Append(DRoughTerrain).Append("\n");
            sb.Append("  DRockWall: ").Append(DRockWall).Append("\n");
            sb.Append("  AverageHighGoals: ").Append(AverageHighGoals).Append("\n");
            sb.Append("  AverageLowGoals: ").Append(AverageLowGoals).Append("\n");
            sb.Append("  Breaches: ").Append(Breaches).Append("\n");
            sb.Append("  Scales: ").Append(Scales).Append("\n");
            sb.Append("  Challenges: ").Append(Challenges).Append("\n");
            sb.Append("  Captures: ").Append(Captures).Append("\n");
            sb.Append("  AverageWinScore: ").Append(AverageWinScore).Append("\n");
            sb.Append("  AverageWinMargin: ").Append(AverageWinMargin).Append("\n");
            sb.Append("  AverageScore: ").Append(AverageScore).Append("\n");
            sb.Append("  AverageAutoScore: ").Append(AverageAutoScore).Append("\n");
            sb.Append("  AverageCrossingScore: ").Append(AverageCrossingScore).Append("\n");
            sb.Append("  AverageBoulderScore: ").Append(AverageBoulderScore).Append("\n");
            sb.Append("  AverageTowerScore: ").Append(AverageTowerScore).Append("\n");
            sb.Append("  AverageFoulScore: ").Append(AverageFoulScore).Append("\n");
            sb.Append("  HighScore: ").Append(HighScore).Append("\n");
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
            return this.Equals(input as EventInsights2016);
        }

        /// <summary>
        /// Returns true if EventInsights2016 instances are equal
        /// </summary>
        /// <param name="input">Instance of EventInsights2016 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventInsights2016 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LowBar == input.LowBar ||
                    this.LowBar != null &&
                    input.LowBar != null &&
                    this.LowBar.SequenceEqual(input.LowBar)
                ) && 
                (
                    this.AChevalDeFrise == input.AChevalDeFrise ||
                    this.AChevalDeFrise != null &&
                    input.AChevalDeFrise != null &&
                    this.AChevalDeFrise.SequenceEqual(input.AChevalDeFrise)
                ) && 
                (
                    this.APortcullis == input.APortcullis ||
                    this.APortcullis != null &&
                    input.APortcullis != null &&
                    this.APortcullis.SequenceEqual(input.APortcullis)
                ) && 
                (
                    this.BRamparts == input.BRamparts ||
                    this.BRamparts != null &&
                    input.BRamparts != null &&
                    this.BRamparts.SequenceEqual(input.BRamparts)
                ) && 
                (
                    this.BMoat == input.BMoat ||
                    this.BMoat != null &&
                    input.BMoat != null &&
                    this.BMoat.SequenceEqual(input.BMoat)
                ) && 
                (
                    this.CSallyPort == input.CSallyPort ||
                    this.CSallyPort != null &&
                    input.CSallyPort != null &&
                    this.CSallyPort.SequenceEqual(input.CSallyPort)
                ) && 
                (
                    this.CDrawbridge == input.CDrawbridge ||
                    this.CDrawbridge != null &&
                    input.CDrawbridge != null &&
                    this.CDrawbridge.SequenceEqual(input.CDrawbridge)
                ) && 
                (
                    this.DRoughTerrain == input.DRoughTerrain ||
                    this.DRoughTerrain != null &&
                    input.DRoughTerrain != null &&
                    this.DRoughTerrain.SequenceEqual(input.DRoughTerrain)
                ) && 
                (
                    this.DRockWall == input.DRockWall ||
                    this.DRockWall != null &&
                    input.DRockWall != null &&
                    this.DRockWall.SequenceEqual(input.DRockWall)
                ) && 
                (
                    this.AverageHighGoals == input.AverageHighGoals ||
                    (this.AverageHighGoals != null &&
                    this.AverageHighGoals.Equals(input.AverageHighGoals))
                ) && 
                (
                    this.AverageLowGoals == input.AverageLowGoals ||
                    (this.AverageLowGoals != null &&
                    this.AverageLowGoals.Equals(input.AverageLowGoals))
                ) && 
                (
                    this.Breaches == input.Breaches ||
                    this.Breaches != null &&
                    input.Breaches != null &&
                    this.Breaches.SequenceEqual(input.Breaches)
                ) && 
                (
                    this.Scales == input.Scales ||
                    this.Scales != null &&
                    input.Scales != null &&
                    this.Scales.SequenceEqual(input.Scales)
                ) && 
                (
                    this.Challenges == input.Challenges ||
                    this.Challenges != null &&
                    input.Challenges != null &&
                    this.Challenges.SequenceEqual(input.Challenges)
                ) && 
                (
                    this.Captures == input.Captures ||
                    this.Captures != null &&
                    input.Captures != null &&
                    this.Captures.SequenceEqual(input.Captures)
                ) && 
                (
                    this.AverageWinScore == input.AverageWinScore ||
                    (this.AverageWinScore != null &&
                    this.AverageWinScore.Equals(input.AverageWinScore))
                ) && 
                (
                    this.AverageWinMargin == input.AverageWinMargin ||
                    (this.AverageWinMargin != null &&
                    this.AverageWinMargin.Equals(input.AverageWinMargin))
                ) && 
                (
                    this.AverageScore == input.AverageScore ||
                    (this.AverageScore != null &&
                    this.AverageScore.Equals(input.AverageScore))
                ) && 
                (
                    this.AverageAutoScore == input.AverageAutoScore ||
                    (this.AverageAutoScore != null &&
                    this.AverageAutoScore.Equals(input.AverageAutoScore))
                ) && 
                (
                    this.AverageCrossingScore == input.AverageCrossingScore ||
                    (this.AverageCrossingScore != null &&
                    this.AverageCrossingScore.Equals(input.AverageCrossingScore))
                ) && 
                (
                    this.AverageBoulderScore == input.AverageBoulderScore ||
                    (this.AverageBoulderScore != null &&
                    this.AverageBoulderScore.Equals(input.AverageBoulderScore))
                ) && 
                (
                    this.AverageTowerScore == input.AverageTowerScore ||
                    (this.AverageTowerScore != null &&
                    this.AverageTowerScore.Equals(input.AverageTowerScore))
                ) && 
                (
                    this.AverageFoulScore == input.AverageFoulScore ||
                    (this.AverageFoulScore != null &&
                    this.AverageFoulScore.Equals(input.AverageFoulScore))
                ) && 
                (
                    this.HighScore == input.HighScore ||
                    this.HighScore != null &&
                    input.HighScore != null &&
                    this.HighScore.SequenceEqual(input.HighScore)
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
                if (this.LowBar != null)
                    hashCode = hashCode * 59 + this.LowBar.GetHashCode();
                if (this.AChevalDeFrise != null)
                    hashCode = hashCode * 59 + this.AChevalDeFrise.GetHashCode();
                if (this.APortcullis != null)
                    hashCode = hashCode * 59 + this.APortcullis.GetHashCode();
                if (this.BRamparts != null)
                    hashCode = hashCode * 59 + this.BRamparts.GetHashCode();
                if (this.BMoat != null)
                    hashCode = hashCode * 59 + this.BMoat.GetHashCode();
                if (this.CSallyPort != null)
                    hashCode = hashCode * 59 + this.CSallyPort.GetHashCode();
                if (this.CDrawbridge != null)
                    hashCode = hashCode * 59 + this.CDrawbridge.GetHashCode();
                if (this.DRoughTerrain != null)
                    hashCode = hashCode * 59 + this.DRoughTerrain.GetHashCode();
                if (this.DRockWall != null)
                    hashCode = hashCode * 59 + this.DRockWall.GetHashCode();
                if (this.AverageHighGoals != null)
                    hashCode = hashCode * 59 + this.AverageHighGoals.GetHashCode();
                if (this.AverageLowGoals != null)
                    hashCode = hashCode * 59 + this.AverageLowGoals.GetHashCode();
                if (this.Breaches != null)
                    hashCode = hashCode * 59 + this.Breaches.GetHashCode();
                if (this.Scales != null)
                    hashCode = hashCode * 59 + this.Scales.GetHashCode();
                if (this.Challenges != null)
                    hashCode = hashCode * 59 + this.Challenges.GetHashCode();
                if (this.Captures != null)
                    hashCode = hashCode * 59 + this.Captures.GetHashCode();
                if (this.AverageWinScore != null)
                    hashCode = hashCode * 59 + this.AverageWinScore.GetHashCode();
                if (this.AverageWinMargin != null)
                    hashCode = hashCode * 59 + this.AverageWinMargin.GetHashCode();
                if (this.AverageScore != null)
                    hashCode = hashCode * 59 + this.AverageScore.GetHashCode();
                if (this.AverageAutoScore != null)
                    hashCode = hashCode * 59 + this.AverageAutoScore.GetHashCode();
                if (this.AverageCrossingScore != null)
                    hashCode = hashCode * 59 + this.AverageCrossingScore.GetHashCode();
                if (this.AverageBoulderScore != null)
                    hashCode = hashCode * 59 + this.AverageBoulderScore.GetHashCode();
                if (this.AverageTowerScore != null)
                    hashCode = hashCode * 59 + this.AverageTowerScore.GetHashCode();
                if (this.AverageFoulScore != null)
                    hashCode = hashCode * 59 + this.AverageFoulScore.GetHashCode();
                if (this.HighScore != null)
                    hashCode = hashCode * 59 + this.HighScore.GetHashCode();
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
