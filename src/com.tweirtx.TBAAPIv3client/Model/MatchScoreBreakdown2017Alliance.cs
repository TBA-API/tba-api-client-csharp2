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
    /// MatchScoreBreakdown2017Alliance
    /// </summary>
    [DataContract]
    public partial class MatchScoreBreakdown2017Alliance :  IEquatable<MatchScoreBreakdown2017Alliance>, IValidatableObject
    {
        /// <summary>
        /// Defines Robot1Auto
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Robot1AutoEnum
        {
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum Mobility for value: Mobility
            /// </summary>
            [EnumMember(Value = "Mobility")]
            Mobility = 2,

            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 3

        }

        /// <summary>
        /// Gets or Sets Robot1Auto
        /// </summary>
        [DataMember(Name="robot1Auto", EmitDefaultValue=false)]
        public Robot1AutoEnum? Robot1Auto { get; set; }
        /// <summary>
        /// Defines Robot2Auto
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Robot2AutoEnum
        {
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum Mobility for value: Mobility
            /// </summary>
            [EnumMember(Value = "Mobility")]
            Mobility = 2,

            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 3

        }

        /// <summary>
        /// Gets or Sets Robot2Auto
        /// </summary>
        [DataMember(Name="robot2Auto", EmitDefaultValue=false)]
        public Robot2AutoEnum? Robot2Auto { get; set; }
        /// <summary>
        /// Defines Robot3Auto
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Robot3AutoEnum
        {
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum Mobility for value: Mobility
            /// </summary>
            [EnumMember(Value = "Mobility")]
            Mobility = 2,

            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 3

        }

        /// <summary>
        /// Gets or Sets Robot3Auto
        /// </summary>
        [DataMember(Name="robot3Auto", EmitDefaultValue=false)]
        public Robot3AutoEnum? Robot3Auto { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchScoreBreakdown2017Alliance" /> class.
        /// </summary>
        /// <param name="autoPoints">autoPoints.</param>
        /// <param name="teleopPoints">teleopPoints.</param>
        /// <param name="foulPoints">foulPoints.</param>
        /// <param name="adjustPoints">adjustPoints.</param>
        /// <param name="totalPoints">totalPoints.</param>
        /// <param name="robot1Auto">robot1Auto.</param>
        /// <param name="robot2Auto">robot2Auto.</param>
        /// <param name="robot3Auto">robot3Auto.</param>
        /// <param name="rotor1Auto">rotor1Auto.</param>
        /// <param name="rotor2Auto">rotor2Auto.</param>
        /// <param name="autoFuelLow">autoFuelLow.</param>
        /// <param name="autoFuelHigh">autoFuelHigh.</param>
        /// <param name="autoMobilityPoints">autoMobilityPoints.</param>
        /// <param name="autoRotorPoints">autoRotorPoints.</param>
        /// <param name="autoFuelPoints">autoFuelPoints.</param>
        /// <param name="teleopFuelPoints">teleopFuelPoints.</param>
        /// <param name="teleopFuelLow">teleopFuelLow.</param>
        /// <param name="teleopFuelHigh">teleopFuelHigh.</param>
        /// <param name="teleopRotorPoints">teleopRotorPoints.</param>
        /// <param name="kPaRankingPointAchieved">kPaRankingPointAchieved.</param>
        /// <param name="teleopTakeoffPoints">teleopTakeoffPoints.</param>
        /// <param name="kPaBonusPoints">kPaBonusPoints.</param>
        /// <param name="rotorBonusPoints">rotorBonusPoints.</param>
        /// <param name="rotor1Engaged">rotor1Engaged.</param>
        /// <param name="rotor2Engaged">rotor2Engaged.</param>
        /// <param name="rotor3Engaged">rotor3Engaged.</param>
        /// <param name="rotor4Engaged">rotor4Engaged.</param>
        /// <param name="rotorRankingPointAchieved">rotorRankingPointAchieved.</param>
        /// <param name="techFoulCount">techFoulCount.</param>
        /// <param name="foulCount">foulCount.</param>
        /// <param name="touchpadNear">touchpadNear.</param>
        /// <param name="touchpadMiddle">touchpadMiddle.</param>
        /// <param name="touchpadFar">touchpadFar.</param>
        public MatchScoreBreakdown2017Alliance(int autoPoints = default(int), int teleopPoints = default(int), int foulPoints = default(int), int adjustPoints = default(int), int totalPoints = default(int), Robot1AutoEnum? robot1Auto = default(Robot1AutoEnum?), Robot2AutoEnum? robot2Auto = default(Robot2AutoEnum?), Robot3AutoEnum? robot3Auto = default(Robot3AutoEnum?), bool rotor1Auto = default(bool), bool rotor2Auto = default(bool), int autoFuelLow = default(int), int autoFuelHigh = default(int), int autoMobilityPoints = default(int), int autoRotorPoints = default(int), int autoFuelPoints = default(int), int teleopFuelPoints = default(int), int teleopFuelLow = default(int), int teleopFuelHigh = default(int), int teleopRotorPoints = default(int), bool kPaRankingPointAchieved = default(bool), int teleopTakeoffPoints = default(int), int kPaBonusPoints = default(int), int rotorBonusPoints = default(int), bool rotor1Engaged = default(bool), bool rotor2Engaged = default(bool), bool rotor3Engaged = default(bool), bool rotor4Engaged = default(bool), bool rotorRankingPointAchieved = default(bool), int techFoulCount = default(int), int foulCount = default(int), string touchpadNear = default(string), string touchpadMiddle = default(string), string touchpadFar = default(string))
        {
            this.AutoPoints = autoPoints;
            this.TeleopPoints = teleopPoints;
            this.FoulPoints = foulPoints;
            this.AdjustPoints = adjustPoints;
            this.TotalPoints = totalPoints;
            this.Robot1Auto = robot1Auto;
            this.Robot2Auto = robot2Auto;
            this.Robot3Auto = robot3Auto;
            this.Rotor1Auto = rotor1Auto;
            this.Rotor2Auto = rotor2Auto;
            this.AutoFuelLow = autoFuelLow;
            this.AutoFuelHigh = autoFuelHigh;
            this.AutoMobilityPoints = autoMobilityPoints;
            this.AutoRotorPoints = autoRotorPoints;
            this.AutoFuelPoints = autoFuelPoints;
            this.TeleopFuelPoints = teleopFuelPoints;
            this.TeleopFuelLow = teleopFuelLow;
            this.TeleopFuelHigh = teleopFuelHigh;
            this.TeleopRotorPoints = teleopRotorPoints;
            this.KPaRankingPointAchieved = kPaRankingPointAchieved;
            this.TeleopTakeoffPoints = teleopTakeoffPoints;
            this.KPaBonusPoints = kPaBonusPoints;
            this.RotorBonusPoints = rotorBonusPoints;
            this.Rotor1Engaged = rotor1Engaged;
            this.Rotor2Engaged = rotor2Engaged;
            this.Rotor3Engaged = rotor3Engaged;
            this.Rotor4Engaged = rotor4Engaged;
            this.RotorRankingPointAchieved = rotorRankingPointAchieved;
            this.TechFoulCount = techFoulCount;
            this.FoulCount = foulCount;
            this.TouchpadNear = touchpadNear;
            this.TouchpadMiddle = touchpadMiddle;
            this.TouchpadFar = touchpadFar;
        }
        
        /// <summary>
        /// Gets or Sets AutoPoints
        /// </summary>
        [DataMember(Name="autoPoints", EmitDefaultValue=false)]
        public int AutoPoints { get; set; }

        /// <summary>
        /// Gets or Sets TeleopPoints
        /// </summary>
        [DataMember(Name="teleopPoints", EmitDefaultValue=false)]
        public int TeleopPoints { get; set; }

        /// <summary>
        /// Gets or Sets FoulPoints
        /// </summary>
        [DataMember(Name="foulPoints", EmitDefaultValue=false)]
        public int FoulPoints { get; set; }

        /// <summary>
        /// Gets or Sets AdjustPoints
        /// </summary>
        [DataMember(Name="adjustPoints", EmitDefaultValue=false)]
        public int AdjustPoints { get; set; }

        /// <summary>
        /// Gets or Sets TotalPoints
        /// </summary>
        [DataMember(Name="totalPoints", EmitDefaultValue=false)]
        public int TotalPoints { get; set; }




        /// <summary>
        /// Gets or Sets Rotor1Auto
        /// </summary>
        [DataMember(Name="rotor1Auto", EmitDefaultValue=false)]
        public bool Rotor1Auto { get; set; }

        /// <summary>
        /// Gets or Sets Rotor2Auto
        /// </summary>
        [DataMember(Name="rotor2Auto", EmitDefaultValue=false)]
        public bool Rotor2Auto { get; set; }

        /// <summary>
        /// Gets or Sets AutoFuelLow
        /// </summary>
        [DataMember(Name="autoFuelLow", EmitDefaultValue=false)]
        public int AutoFuelLow { get; set; }

        /// <summary>
        /// Gets or Sets AutoFuelHigh
        /// </summary>
        [DataMember(Name="autoFuelHigh", EmitDefaultValue=false)]
        public int AutoFuelHigh { get; set; }

        /// <summary>
        /// Gets or Sets AutoMobilityPoints
        /// </summary>
        [DataMember(Name="autoMobilityPoints", EmitDefaultValue=false)]
        public int AutoMobilityPoints { get; set; }

        /// <summary>
        /// Gets or Sets AutoRotorPoints
        /// </summary>
        [DataMember(Name="autoRotorPoints", EmitDefaultValue=false)]
        public int AutoRotorPoints { get; set; }

        /// <summary>
        /// Gets or Sets AutoFuelPoints
        /// </summary>
        [DataMember(Name="autoFuelPoints", EmitDefaultValue=false)]
        public int AutoFuelPoints { get; set; }

        /// <summary>
        /// Gets or Sets TeleopFuelPoints
        /// </summary>
        [DataMember(Name="teleopFuelPoints", EmitDefaultValue=false)]
        public int TeleopFuelPoints { get; set; }

        /// <summary>
        /// Gets or Sets TeleopFuelLow
        /// </summary>
        [DataMember(Name="teleopFuelLow", EmitDefaultValue=false)]
        public int TeleopFuelLow { get; set; }

        /// <summary>
        /// Gets or Sets TeleopFuelHigh
        /// </summary>
        [DataMember(Name="teleopFuelHigh", EmitDefaultValue=false)]
        public int TeleopFuelHigh { get; set; }

        /// <summary>
        /// Gets or Sets TeleopRotorPoints
        /// </summary>
        [DataMember(Name="teleopRotorPoints", EmitDefaultValue=false)]
        public int TeleopRotorPoints { get; set; }

        /// <summary>
        /// Gets or Sets KPaRankingPointAchieved
        /// </summary>
        [DataMember(Name="kPaRankingPointAchieved", EmitDefaultValue=false)]
        public bool KPaRankingPointAchieved { get; set; }

        /// <summary>
        /// Gets or Sets TeleopTakeoffPoints
        /// </summary>
        [DataMember(Name="teleopTakeoffPoints", EmitDefaultValue=false)]
        public int TeleopTakeoffPoints { get; set; }

        /// <summary>
        /// Gets or Sets KPaBonusPoints
        /// </summary>
        [DataMember(Name="kPaBonusPoints", EmitDefaultValue=false)]
        public int KPaBonusPoints { get; set; }

        /// <summary>
        /// Gets or Sets RotorBonusPoints
        /// </summary>
        [DataMember(Name="rotorBonusPoints", EmitDefaultValue=false)]
        public int RotorBonusPoints { get; set; }

        /// <summary>
        /// Gets or Sets Rotor1Engaged
        /// </summary>
        [DataMember(Name="rotor1Engaged", EmitDefaultValue=false)]
        public bool Rotor1Engaged { get; set; }

        /// <summary>
        /// Gets or Sets Rotor2Engaged
        /// </summary>
        [DataMember(Name="rotor2Engaged", EmitDefaultValue=false)]
        public bool Rotor2Engaged { get; set; }

        /// <summary>
        /// Gets or Sets Rotor3Engaged
        /// </summary>
        [DataMember(Name="rotor3Engaged", EmitDefaultValue=false)]
        public bool Rotor3Engaged { get; set; }

        /// <summary>
        /// Gets or Sets Rotor4Engaged
        /// </summary>
        [DataMember(Name="rotor4Engaged", EmitDefaultValue=false)]
        public bool Rotor4Engaged { get; set; }

        /// <summary>
        /// Gets or Sets RotorRankingPointAchieved
        /// </summary>
        [DataMember(Name="rotorRankingPointAchieved", EmitDefaultValue=false)]
        public bool RotorRankingPointAchieved { get; set; }

        /// <summary>
        /// Gets or Sets TechFoulCount
        /// </summary>
        [DataMember(Name="techFoulCount", EmitDefaultValue=false)]
        public int TechFoulCount { get; set; }

        /// <summary>
        /// Gets or Sets FoulCount
        /// </summary>
        [DataMember(Name="foulCount", EmitDefaultValue=false)]
        public int FoulCount { get; set; }

        /// <summary>
        /// Gets or Sets TouchpadNear
        /// </summary>
        [DataMember(Name="touchpadNear", EmitDefaultValue=false)]
        public string TouchpadNear { get; set; }

        /// <summary>
        /// Gets or Sets TouchpadMiddle
        /// </summary>
        [DataMember(Name="touchpadMiddle", EmitDefaultValue=false)]
        public string TouchpadMiddle { get; set; }

        /// <summary>
        /// Gets or Sets TouchpadFar
        /// </summary>
        [DataMember(Name="touchpadFar", EmitDefaultValue=false)]
        public string TouchpadFar { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchScoreBreakdown2017Alliance {\n");
            sb.Append("  AutoPoints: ").Append(AutoPoints).Append("\n");
            sb.Append("  TeleopPoints: ").Append(TeleopPoints).Append("\n");
            sb.Append("  FoulPoints: ").Append(FoulPoints).Append("\n");
            sb.Append("  AdjustPoints: ").Append(AdjustPoints).Append("\n");
            sb.Append("  TotalPoints: ").Append(TotalPoints).Append("\n");
            sb.Append("  Robot1Auto: ").Append(Robot1Auto).Append("\n");
            sb.Append("  Robot2Auto: ").Append(Robot2Auto).Append("\n");
            sb.Append("  Robot3Auto: ").Append(Robot3Auto).Append("\n");
            sb.Append("  Rotor1Auto: ").Append(Rotor1Auto).Append("\n");
            sb.Append("  Rotor2Auto: ").Append(Rotor2Auto).Append("\n");
            sb.Append("  AutoFuelLow: ").Append(AutoFuelLow).Append("\n");
            sb.Append("  AutoFuelHigh: ").Append(AutoFuelHigh).Append("\n");
            sb.Append("  AutoMobilityPoints: ").Append(AutoMobilityPoints).Append("\n");
            sb.Append("  AutoRotorPoints: ").Append(AutoRotorPoints).Append("\n");
            sb.Append("  AutoFuelPoints: ").Append(AutoFuelPoints).Append("\n");
            sb.Append("  TeleopFuelPoints: ").Append(TeleopFuelPoints).Append("\n");
            sb.Append("  TeleopFuelLow: ").Append(TeleopFuelLow).Append("\n");
            sb.Append("  TeleopFuelHigh: ").Append(TeleopFuelHigh).Append("\n");
            sb.Append("  TeleopRotorPoints: ").Append(TeleopRotorPoints).Append("\n");
            sb.Append("  KPaRankingPointAchieved: ").Append(KPaRankingPointAchieved).Append("\n");
            sb.Append("  TeleopTakeoffPoints: ").Append(TeleopTakeoffPoints).Append("\n");
            sb.Append("  KPaBonusPoints: ").Append(KPaBonusPoints).Append("\n");
            sb.Append("  RotorBonusPoints: ").Append(RotorBonusPoints).Append("\n");
            sb.Append("  Rotor1Engaged: ").Append(Rotor1Engaged).Append("\n");
            sb.Append("  Rotor2Engaged: ").Append(Rotor2Engaged).Append("\n");
            sb.Append("  Rotor3Engaged: ").Append(Rotor3Engaged).Append("\n");
            sb.Append("  Rotor4Engaged: ").Append(Rotor4Engaged).Append("\n");
            sb.Append("  RotorRankingPointAchieved: ").Append(RotorRankingPointAchieved).Append("\n");
            sb.Append("  TechFoulCount: ").Append(TechFoulCount).Append("\n");
            sb.Append("  FoulCount: ").Append(FoulCount).Append("\n");
            sb.Append("  TouchpadNear: ").Append(TouchpadNear).Append("\n");
            sb.Append("  TouchpadMiddle: ").Append(TouchpadMiddle).Append("\n");
            sb.Append("  TouchpadFar: ").Append(TouchpadFar).Append("\n");
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
            return this.Equals(input as MatchScoreBreakdown2017Alliance);
        }

        /// <summary>
        /// Returns true if MatchScoreBreakdown2017Alliance instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchScoreBreakdown2017Alliance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchScoreBreakdown2017Alliance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoPoints == input.AutoPoints ||
                    (this.AutoPoints != null &&
                    this.AutoPoints.Equals(input.AutoPoints))
                ) && 
                (
                    this.TeleopPoints == input.TeleopPoints ||
                    (this.TeleopPoints != null &&
                    this.TeleopPoints.Equals(input.TeleopPoints))
                ) && 
                (
                    this.FoulPoints == input.FoulPoints ||
                    (this.FoulPoints != null &&
                    this.FoulPoints.Equals(input.FoulPoints))
                ) && 
                (
                    this.AdjustPoints == input.AdjustPoints ||
                    (this.AdjustPoints != null &&
                    this.AdjustPoints.Equals(input.AdjustPoints))
                ) && 
                (
                    this.TotalPoints == input.TotalPoints ||
                    (this.TotalPoints != null &&
                    this.TotalPoints.Equals(input.TotalPoints))
                ) && 
                (
                    this.Robot1Auto == input.Robot1Auto ||
                    (this.Robot1Auto != null &&
                    this.Robot1Auto.Equals(input.Robot1Auto))
                ) && 
                (
                    this.Robot2Auto == input.Robot2Auto ||
                    (this.Robot2Auto != null &&
                    this.Robot2Auto.Equals(input.Robot2Auto))
                ) && 
                (
                    this.Robot3Auto == input.Robot3Auto ||
                    (this.Robot3Auto != null &&
                    this.Robot3Auto.Equals(input.Robot3Auto))
                ) && 
                (
                    this.Rotor1Auto == input.Rotor1Auto ||
                    (this.Rotor1Auto != null &&
                    this.Rotor1Auto.Equals(input.Rotor1Auto))
                ) && 
                (
                    this.Rotor2Auto == input.Rotor2Auto ||
                    (this.Rotor2Auto != null &&
                    this.Rotor2Auto.Equals(input.Rotor2Auto))
                ) && 
                (
                    this.AutoFuelLow == input.AutoFuelLow ||
                    (this.AutoFuelLow != null &&
                    this.AutoFuelLow.Equals(input.AutoFuelLow))
                ) && 
                (
                    this.AutoFuelHigh == input.AutoFuelHigh ||
                    (this.AutoFuelHigh != null &&
                    this.AutoFuelHigh.Equals(input.AutoFuelHigh))
                ) && 
                (
                    this.AutoMobilityPoints == input.AutoMobilityPoints ||
                    (this.AutoMobilityPoints != null &&
                    this.AutoMobilityPoints.Equals(input.AutoMobilityPoints))
                ) && 
                (
                    this.AutoRotorPoints == input.AutoRotorPoints ||
                    (this.AutoRotorPoints != null &&
                    this.AutoRotorPoints.Equals(input.AutoRotorPoints))
                ) && 
                (
                    this.AutoFuelPoints == input.AutoFuelPoints ||
                    (this.AutoFuelPoints != null &&
                    this.AutoFuelPoints.Equals(input.AutoFuelPoints))
                ) && 
                (
                    this.TeleopFuelPoints == input.TeleopFuelPoints ||
                    (this.TeleopFuelPoints != null &&
                    this.TeleopFuelPoints.Equals(input.TeleopFuelPoints))
                ) && 
                (
                    this.TeleopFuelLow == input.TeleopFuelLow ||
                    (this.TeleopFuelLow != null &&
                    this.TeleopFuelLow.Equals(input.TeleopFuelLow))
                ) && 
                (
                    this.TeleopFuelHigh == input.TeleopFuelHigh ||
                    (this.TeleopFuelHigh != null &&
                    this.TeleopFuelHigh.Equals(input.TeleopFuelHigh))
                ) && 
                (
                    this.TeleopRotorPoints == input.TeleopRotorPoints ||
                    (this.TeleopRotorPoints != null &&
                    this.TeleopRotorPoints.Equals(input.TeleopRotorPoints))
                ) && 
                (
                    this.KPaRankingPointAchieved == input.KPaRankingPointAchieved ||
                    (this.KPaRankingPointAchieved != null &&
                    this.KPaRankingPointAchieved.Equals(input.KPaRankingPointAchieved))
                ) && 
                (
                    this.TeleopTakeoffPoints == input.TeleopTakeoffPoints ||
                    (this.TeleopTakeoffPoints != null &&
                    this.TeleopTakeoffPoints.Equals(input.TeleopTakeoffPoints))
                ) && 
                (
                    this.KPaBonusPoints == input.KPaBonusPoints ||
                    (this.KPaBonusPoints != null &&
                    this.KPaBonusPoints.Equals(input.KPaBonusPoints))
                ) && 
                (
                    this.RotorBonusPoints == input.RotorBonusPoints ||
                    (this.RotorBonusPoints != null &&
                    this.RotorBonusPoints.Equals(input.RotorBonusPoints))
                ) && 
                (
                    this.Rotor1Engaged == input.Rotor1Engaged ||
                    (this.Rotor1Engaged != null &&
                    this.Rotor1Engaged.Equals(input.Rotor1Engaged))
                ) && 
                (
                    this.Rotor2Engaged == input.Rotor2Engaged ||
                    (this.Rotor2Engaged != null &&
                    this.Rotor2Engaged.Equals(input.Rotor2Engaged))
                ) && 
                (
                    this.Rotor3Engaged == input.Rotor3Engaged ||
                    (this.Rotor3Engaged != null &&
                    this.Rotor3Engaged.Equals(input.Rotor3Engaged))
                ) && 
                (
                    this.Rotor4Engaged == input.Rotor4Engaged ||
                    (this.Rotor4Engaged != null &&
                    this.Rotor4Engaged.Equals(input.Rotor4Engaged))
                ) && 
                (
                    this.RotorRankingPointAchieved == input.RotorRankingPointAchieved ||
                    (this.RotorRankingPointAchieved != null &&
                    this.RotorRankingPointAchieved.Equals(input.RotorRankingPointAchieved))
                ) && 
                (
                    this.TechFoulCount == input.TechFoulCount ||
                    (this.TechFoulCount != null &&
                    this.TechFoulCount.Equals(input.TechFoulCount))
                ) && 
                (
                    this.FoulCount == input.FoulCount ||
                    (this.FoulCount != null &&
                    this.FoulCount.Equals(input.FoulCount))
                ) && 
                (
                    this.TouchpadNear == input.TouchpadNear ||
                    (this.TouchpadNear != null &&
                    this.TouchpadNear.Equals(input.TouchpadNear))
                ) && 
                (
                    this.TouchpadMiddle == input.TouchpadMiddle ||
                    (this.TouchpadMiddle != null &&
                    this.TouchpadMiddle.Equals(input.TouchpadMiddle))
                ) && 
                (
                    this.TouchpadFar == input.TouchpadFar ||
                    (this.TouchpadFar != null &&
                    this.TouchpadFar.Equals(input.TouchpadFar))
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
                if (this.AutoPoints != null)
                    hashCode = hashCode * 59 + this.AutoPoints.GetHashCode();
                if (this.TeleopPoints != null)
                    hashCode = hashCode * 59 + this.TeleopPoints.GetHashCode();
                if (this.FoulPoints != null)
                    hashCode = hashCode * 59 + this.FoulPoints.GetHashCode();
                if (this.AdjustPoints != null)
                    hashCode = hashCode * 59 + this.AdjustPoints.GetHashCode();
                if (this.TotalPoints != null)
                    hashCode = hashCode * 59 + this.TotalPoints.GetHashCode();
                if (this.Robot1Auto != null)
                    hashCode = hashCode * 59 + this.Robot1Auto.GetHashCode();
                if (this.Robot2Auto != null)
                    hashCode = hashCode * 59 + this.Robot2Auto.GetHashCode();
                if (this.Robot3Auto != null)
                    hashCode = hashCode * 59 + this.Robot3Auto.GetHashCode();
                if (this.Rotor1Auto != null)
                    hashCode = hashCode * 59 + this.Rotor1Auto.GetHashCode();
                if (this.Rotor2Auto != null)
                    hashCode = hashCode * 59 + this.Rotor2Auto.GetHashCode();
                if (this.AutoFuelLow != null)
                    hashCode = hashCode * 59 + this.AutoFuelLow.GetHashCode();
                if (this.AutoFuelHigh != null)
                    hashCode = hashCode * 59 + this.AutoFuelHigh.GetHashCode();
                if (this.AutoMobilityPoints != null)
                    hashCode = hashCode * 59 + this.AutoMobilityPoints.GetHashCode();
                if (this.AutoRotorPoints != null)
                    hashCode = hashCode * 59 + this.AutoRotorPoints.GetHashCode();
                if (this.AutoFuelPoints != null)
                    hashCode = hashCode * 59 + this.AutoFuelPoints.GetHashCode();
                if (this.TeleopFuelPoints != null)
                    hashCode = hashCode * 59 + this.TeleopFuelPoints.GetHashCode();
                if (this.TeleopFuelLow != null)
                    hashCode = hashCode * 59 + this.TeleopFuelLow.GetHashCode();
                if (this.TeleopFuelHigh != null)
                    hashCode = hashCode * 59 + this.TeleopFuelHigh.GetHashCode();
                if (this.TeleopRotorPoints != null)
                    hashCode = hashCode * 59 + this.TeleopRotorPoints.GetHashCode();
                if (this.KPaRankingPointAchieved != null)
                    hashCode = hashCode * 59 + this.KPaRankingPointAchieved.GetHashCode();
                if (this.TeleopTakeoffPoints != null)
                    hashCode = hashCode * 59 + this.TeleopTakeoffPoints.GetHashCode();
                if (this.KPaBonusPoints != null)
                    hashCode = hashCode * 59 + this.KPaBonusPoints.GetHashCode();
                if (this.RotorBonusPoints != null)
                    hashCode = hashCode * 59 + this.RotorBonusPoints.GetHashCode();
                if (this.Rotor1Engaged != null)
                    hashCode = hashCode * 59 + this.Rotor1Engaged.GetHashCode();
                if (this.Rotor2Engaged != null)
                    hashCode = hashCode * 59 + this.Rotor2Engaged.GetHashCode();
                if (this.Rotor3Engaged != null)
                    hashCode = hashCode * 59 + this.Rotor3Engaged.GetHashCode();
                if (this.Rotor4Engaged != null)
                    hashCode = hashCode * 59 + this.Rotor4Engaged.GetHashCode();
                if (this.RotorRankingPointAchieved != null)
                    hashCode = hashCode * 59 + this.RotorRankingPointAchieved.GetHashCode();
                if (this.TechFoulCount != null)
                    hashCode = hashCode * 59 + this.TechFoulCount.GetHashCode();
                if (this.FoulCount != null)
                    hashCode = hashCode * 59 + this.FoulCount.GetHashCode();
                if (this.TouchpadNear != null)
                    hashCode = hashCode * 59 + this.TouchpadNear.GetHashCode();
                if (this.TouchpadMiddle != null)
                    hashCode = hashCode * 59 + this.TouchpadMiddle.GetHashCode();
                if (this.TouchpadFar != null)
                    hashCode = hashCode * 59 + this.TouchpadFar.GetHashCode();
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
