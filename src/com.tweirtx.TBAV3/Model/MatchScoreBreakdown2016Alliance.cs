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
using SwaggerDateConverter = com.tweirtx.TBAV3.Client.SwaggerDateConverter;

namespace com.tweirtx.TBAV3.Model
{
    /// <summary>
    /// MatchScoreBreakdown2016Alliance
    /// </summary>
    [DataContract]
    public partial class MatchScoreBreakdown2016Alliance :  IEquatable<MatchScoreBreakdown2016Alliance>, IValidatableObject
    {
        /// <summary>
        /// Defines Robot1Auto
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Robot1AutoEnum
        {
            
            /// <summary>
            /// Enum Crossed for value: Crossed
            /// </summary>
            [EnumMember(Value = "Crossed")]
            Crossed = 1,
            
            /// <summary>
            /// Enum Reached for value: Reached
            /// </summary>
            [EnumMember(Value = "Reached")]
            Reached = 2,
            
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
            /// Enum Crossed for value: Crossed
            /// </summary>
            [EnumMember(Value = "Crossed")]
            Crossed = 1,
            
            /// <summary>
            /// Enum Reached for value: Reached
            /// </summary>
            [EnumMember(Value = "Reached")]
            Reached = 2,
            
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
            /// Enum Crossed for value: Crossed
            /// </summary>
            [EnumMember(Value = "Crossed")]
            Crossed = 1,
            
            /// <summary>
            /// Enum Reached for value: Reached
            /// </summary>
            [EnumMember(Value = "Reached")]
            Reached = 2,
            
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
        /// Initializes a new instance of the <see cref="MatchScoreBreakdown2016Alliance" /> class.
        /// </summary>
        /// <param name="AutoPoints">AutoPoints.</param>
        /// <param name="TeleopPoints">TeleopPoints.</param>
        /// <param name="BreachPoints">BreachPoints.</param>
        /// <param name="FoulPoints">FoulPoints.</param>
        /// <param name="CapturePoints">CapturePoints.</param>
        /// <param name="AdjustPoints">AdjustPoints.</param>
        /// <param name="TotalPoints">TotalPoints.</param>
        /// <param name="Robot1Auto">Robot1Auto.</param>
        /// <param name="Robot2Auto">Robot2Auto.</param>
        /// <param name="Robot3Auto">Robot3Auto.</param>
        /// <param name="AutoReachPoints">AutoReachPoints.</param>
        /// <param name="AutoCrossingPoints">AutoCrossingPoints.</param>
        /// <param name="AutoBouldersLow">AutoBouldersLow.</param>
        /// <param name="AutoBouldersHigh">AutoBouldersHigh.</param>
        /// <param name="AutoBoulderPoints">AutoBoulderPoints.</param>
        /// <param name="TeleopCrossingPoints">TeleopCrossingPoints.</param>
        /// <param name="TeleopBouldersLow">TeleopBouldersLow.</param>
        /// <param name="TeleopBouldersHigh">TeleopBouldersHigh.</param>
        /// <param name="TeleopBoulderPoints">TeleopBoulderPoints.</param>
        /// <param name="TeleopDefensesBreached">TeleopDefensesBreached.</param>
        /// <param name="TeleopChallengePoints">TeleopChallengePoints.</param>
        /// <param name="TeleopScalePoints">TeleopScalePoints.</param>
        /// <param name="TeleopTowerCaptured">TeleopTowerCaptured.</param>
        /// <param name="TowerFaceA">TowerFaceA.</param>
        /// <param name="TowerFaceB">TowerFaceB.</param>
        /// <param name="TowerFaceC">TowerFaceC.</param>
        /// <param name="TowerEndStrength">TowerEndStrength.</param>
        /// <param name="TechFoulCount">TechFoulCount.</param>
        /// <param name="FoulCount">FoulCount.</param>
        /// <param name="Position2">Position2.</param>
        /// <param name="Position3">Position3.</param>
        /// <param name="Position4">Position4.</param>
        /// <param name="Position5">Position5.</param>
        /// <param name="Position1crossings">Position1crossings.</param>
        /// <param name="Position2crossings">Position2crossings.</param>
        /// <param name="Position3crossings">Position3crossings.</param>
        /// <param name="Position4crossings">Position4crossings.</param>
        /// <param name="Position5crossings">Position5crossings.</param>
        public MatchScoreBreakdown2016Alliance(int? AutoPoints = default(int?), int? TeleopPoints = default(int?), int? BreachPoints = default(int?), int? FoulPoints = default(int?), int? CapturePoints = default(int?), int? AdjustPoints = default(int?), int? TotalPoints = default(int?), Robot1AutoEnum? Robot1Auto = default(Robot1AutoEnum?), Robot2AutoEnum? Robot2Auto = default(Robot2AutoEnum?), Robot3AutoEnum? Robot3Auto = default(Robot3AutoEnum?), int? AutoReachPoints = default(int?), int? AutoCrossingPoints = default(int?), int? AutoBouldersLow = default(int?), int? AutoBouldersHigh = default(int?), int? AutoBoulderPoints = default(int?), int? TeleopCrossingPoints = default(int?), int? TeleopBouldersLow = default(int?), int? TeleopBouldersHigh = default(int?), int? TeleopBoulderPoints = default(int?), bool? TeleopDefensesBreached = default(bool?), int? TeleopChallengePoints = default(int?), int? TeleopScalePoints = default(int?), int? TeleopTowerCaptured = default(int?), string TowerFaceA = default(string), string TowerFaceB = default(string), string TowerFaceC = default(string), int? TowerEndStrength = default(int?), int? TechFoulCount = default(int?), int? FoulCount = default(int?), string Position2 = default(string), string Position3 = default(string), string Position4 = default(string), string Position5 = default(string), int? Position1crossings = default(int?), int? Position2crossings = default(int?), int? Position3crossings = default(int?), int? Position4crossings = default(int?), int? Position5crossings = default(int?))
        {
            this.AutoPoints = AutoPoints;
            this.TeleopPoints = TeleopPoints;
            this.BreachPoints = BreachPoints;
            this.FoulPoints = FoulPoints;
            this.CapturePoints = CapturePoints;
            this.AdjustPoints = AdjustPoints;
            this.TotalPoints = TotalPoints;
            this.Robot1Auto = Robot1Auto;
            this.Robot2Auto = Robot2Auto;
            this.Robot3Auto = Robot3Auto;
            this.AutoReachPoints = AutoReachPoints;
            this.AutoCrossingPoints = AutoCrossingPoints;
            this.AutoBouldersLow = AutoBouldersLow;
            this.AutoBouldersHigh = AutoBouldersHigh;
            this.AutoBoulderPoints = AutoBoulderPoints;
            this.TeleopCrossingPoints = TeleopCrossingPoints;
            this.TeleopBouldersLow = TeleopBouldersLow;
            this.TeleopBouldersHigh = TeleopBouldersHigh;
            this.TeleopBoulderPoints = TeleopBoulderPoints;
            this.TeleopDefensesBreached = TeleopDefensesBreached;
            this.TeleopChallengePoints = TeleopChallengePoints;
            this.TeleopScalePoints = TeleopScalePoints;
            this.TeleopTowerCaptured = TeleopTowerCaptured;
            this.TowerFaceA = TowerFaceA;
            this.TowerFaceB = TowerFaceB;
            this.TowerFaceC = TowerFaceC;
            this.TowerEndStrength = TowerEndStrength;
            this.TechFoulCount = TechFoulCount;
            this.FoulCount = FoulCount;
            this.Position2 = Position2;
            this.Position3 = Position3;
            this.Position4 = Position4;
            this.Position5 = Position5;
            this.Position1crossings = Position1crossings;
            this.Position2crossings = Position2crossings;
            this.Position3crossings = Position3crossings;
            this.Position4crossings = Position4crossings;
            this.Position5crossings = Position5crossings;
        }
        
        /// <summary>
        /// Gets or Sets AutoPoints
        /// </summary>
        [DataMember(Name="autoPoints", EmitDefaultValue=false)]
        public int? AutoPoints { get; set; }

        /// <summary>
        /// Gets or Sets TeleopPoints
        /// </summary>
        [DataMember(Name="teleopPoints", EmitDefaultValue=false)]
        public int? TeleopPoints { get; set; }

        /// <summary>
        /// Gets or Sets BreachPoints
        /// </summary>
        [DataMember(Name="breachPoints", EmitDefaultValue=false)]
        public int? BreachPoints { get; set; }

        /// <summary>
        /// Gets or Sets FoulPoints
        /// </summary>
        [DataMember(Name="foulPoints", EmitDefaultValue=false)]
        public int? FoulPoints { get; set; }

        /// <summary>
        /// Gets or Sets CapturePoints
        /// </summary>
        [DataMember(Name="capturePoints", EmitDefaultValue=false)]
        public int? CapturePoints { get; set; }

        /// <summary>
        /// Gets or Sets AdjustPoints
        /// </summary>
        [DataMember(Name="adjustPoints", EmitDefaultValue=false)]
        public int? AdjustPoints { get; set; }

        /// <summary>
        /// Gets or Sets TotalPoints
        /// </summary>
        [DataMember(Name="totalPoints", EmitDefaultValue=false)]
        public int? TotalPoints { get; set; }




        /// <summary>
        /// Gets or Sets AutoReachPoints
        /// </summary>
        [DataMember(Name="autoReachPoints", EmitDefaultValue=false)]
        public int? AutoReachPoints { get; set; }

        /// <summary>
        /// Gets or Sets AutoCrossingPoints
        /// </summary>
        [DataMember(Name="autoCrossingPoints", EmitDefaultValue=false)]
        public int? AutoCrossingPoints { get; set; }

        /// <summary>
        /// Gets or Sets AutoBouldersLow
        /// </summary>
        [DataMember(Name="autoBouldersLow", EmitDefaultValue=false)]
        public int? AutoBouldersLow { get; set; }

        /// <summary>
        /// Gets or Sets AutoBouldersHigh
        /// </summary>
        [DataMember(Name="autoBouldersHigh", EmitDefaultValue=false)]
        public int? AutoBouldersHigh { get; set; }

        /// <summary>
        /// Gets or Sets AutoBoulderPoints
        /// </summary>
        [DataMember(Name="autoBoulderPoints", EmitDefaultValue=false)]
        public int? AutoBoulderPoints { get; set; }

        /// <summary>
        /// Gets or Sets TeleopCrossingPoints
        /// </summary>
        [DataMember(Name="teleopCrossingPoints", EmitDefaultValue=false)]
        public int? TeleopCrossingPoints { get; set; }

        /// <summary>
        /// Gets or Sets TeleopBouldersLow
        /// </summary>
        [DataMember(Name="teleopBouldersLow", EmitDefaultValue=false)]
        public int? TeleopBouldersLow { get; set; }

        /// <summary>
        /// Gets or Sets TeleopBouldersHigh
        /// </summary>
        [DataMember(Name="teleopBouldersHigh", EmitDefaultValue=false)]
        public int? TeleopBouldersHigh { get; set; }

        /// <summary>
        /// Gets or Sets TeleopBoulderPoints
        /// </summary>
        [DataMember(Name="teleopBoulderPoints", EmitDefaultValue=false)]
        public int? TeleopBoulderPoints { get; set; }

        /// <summary>
        /// Gets or Sets TeleopDefensesBreached
        /// </summary>
        [DataMember(Name="teleopDefensesBreached", EmitDefaultValue=false)]
        public bool? TeleopDefensesBreached { get; set; }

        /// <summary>
        /// Gets or Sets TeleopChallengePoints
        /// </summary>
        [DataMember(Name="teleopChallengePoints", EmitDefaultValue=false)]
        public int? TeleopChallengePoints { get; set; }

        /// <summary>
        /// Gets or Sets TeleopScalePoints
        /// </summary>
        [DataMember(Name="teleopScalePoints", EmitDefaultValue=false)]
        public int? TeleopScalePoints { get; set; }

        /// <summary>
        /// Gets or Sets TeleopTowerCaptured
        /// </summary>
        [DataMember(Name="teleopTowerCaptured", EmitDefaultValue=false)]
        public int? TeleopTowerCaptured { get; set; }

        /// <summary>
        /// Gets or Sets TowerFaceA
        /// </summary>
        [DataMember(Name="towerFaceA", EmitDefaultValue=false)]
        public string TowerFaceA { get; set; }

        /// <summary>
        /// Gets or Sets TowerFaceB
        /// </summary>
        [DataMember(Name="towerFaceB", EmitDefaultValue=false)]
        public string TowerFaceB { get; set; }

        /// <summary>
        /// Gets or Sets TowerFaceC
        /// </summary>
        [DataMember(Name="towerFaceC", EmitDefaultValue=false)]
        public string TowerFaceC { get; set; }

        /// <summary>
        /// Gets or Sets TowerEndStrength
        /// </summary>
        [DataMember(Name="towerEndStrength", EmitDefaultValue=false)]
        public int? TowerEndStrength { get; set; }

        /// <summary>
        /// Gets or Sets TechFoulCount
        /// </summary>
        [DataMember(Name="techFoulCount", EmitDefaultValue=false)]
        public int? TechFoulCount { get; set; }

        /// <summary>
        /// Gets or Sets FoulCount
        /// </summary>
        [DataMember(Name="foulCount", EmitDefaultValue=false)]
        public int? FoulCount { get; set; }

        /// <summary>
        /// Gets or Sets Position2
        /// </summary>
        [DataMember(Name="position2", EmitDefaultValue=false)]
        public string Position2 { get; set; }

        /// <summary>
        /// Gets or Sets Position3
        /// </summary>
        [DataMember(Name="position3", EmitDefaultValue=false)]
        public string Position3 { get; set; }

        /// <summary>
        /// Gets or Sets Position4
        /// </summary>
        [DataMember(Name="position4", EmitDefaultValue=false)]
        public string Position4 { get; set; }

        /// <summary>
        /// Gets or Sets Position5
        /// </summary>
        [DataMember(Name="position5", EmitDefaultValue=false)]
        public string Position5 { get; set; }

        /// <summary>
        /// Gets or Sets Position1crossings
        /// </summary>
        [DataMember(Name="position1crossings", EmitDefaultValue=false)]
        public int? Position1crossings { get; set; }

        /// <summary>
        /// Gets or Sets Position2crossings
        /// </summary>
        [DataMember(Name="position2crossings", EmitDefaultValue=false)]
        public int? Position2crossings { get; set; }

        /// <summary>
        /// Gets or Sets Position3crossings
        /// </summary>
        [DataMember(Name="position3crossings", EmitDefaultValue=false)]
        public int? Position3crossings { get; set; }

        /// <summary>
        /// Gets or Sets Position4crossings
        /// </summary>
        [DataMember(Name="position4crossings", EmitDefaultValue=false)]
        public int? Position4crossings { get; set; }

        /// <summary>
        /// Gets or Sets Position5crossings
        /// </summary>
        [DataMember(Name="position5crossings", EmitDefaultValue=false)]
        public int? Position5crossings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchScoreBreakdown2016Alliance {\n");
            sb.Append("  AutoPoints: ").Append(AutoPoints).Append("\n");
            sb.Append("  TeleopPoints: ").Append(TeleopPoints).Append("\n");
            sb.Append("  BreachPoints: ").Append(BreachPoints).Append("\n");
            sb.Append("  FoulPoints: ").Append(FoulPoints).Append("\n");
            sb.Append("  CapturePoints: ").Append(CapturePoints).Append("\n");
            sb.Append("  AdjustPoints: ").Append(AdjustPoints).Append("\n");
            sb.Append("  TotalPoints: ").Append(TotalPoints).Append("\n");
            sb.Append("  Robot1Auto: ").Append(Robot1Auto).Append("\n");
            sb.Append("  Robot2Auto: ").Append(Robot2Auto).Append("\n");
            sb.Append("  Robot3Auto: ").Append(Robot3Auto).Append("\n");
            sb.Append("  AutoReachPoints: ").Append(AutoReachPoints).Append("\n");
            sb.Append("  AutoCrossingPoints: ").Append(AutoCrossingPoints).Append("\n");
            sb.Append("  AutoBouldersLow: ").Append(AutoBouldersLow).Append("\n");
            sb.Append("  AutoBouldersHigh: ").Append(AutoBouldersHigh).Append("\n");
            sb.Append("  AutoBoulderPoints: ").Append(AutoBoulderPoints).Append("\n");
            sb.Append("  TeleopCrossingPoints: ").Append(TeleopCrossingPoints).Append("\n");
            sb.Append("  TeleopBouldersLow: ").Append(TeleopBouldersLow).Append("\n");
            sb.Append("  TeleopBouldersHigh: ").Append(TeleopBouldersHigh).Append("\n");
            sb.Append("  TeleopBoulderPoints: ").Append(TeleopBoulderPoints).Append("\n");
            sb.Append("  TeleopDefensesBreached: ").Append(TeleopDefensesBreached).Append("\n");
            sb.Append("  TeleopChallengePoints: ").Append(TeleopChallengePoints).Append("\n");
            sb.Append("  TeleopScalePoints: ").Append(TeleopScalePoints).Append("\n");
            sb.Append("  TeleopTowerCaptured: ").Append(TeleopTowerCaptured).Append("\n");
            sb.Append("  TowerFaceA: ").Append(TowerFaceA).Append("\n");
            sb.Append("  TowerFaceB: ").Append(TowerFaceB).Append("\n");
            sb.Append("  TowerFaceC: ").Append(TowerFaceC).Append("\n");
            sb.Append("  TowerEndStrength: ").Append(TowerEndStrength).Append("\n");
            sb.Append("  TechFoulCount: ").Append(TechFoulCount).Append("\n");
            sb.Append("  FoulCount: ").Append(FoulCount).Append("\n");
            sb.Append("  Position2: ").Append(Position2).Append("\n");
            sb.Append("  Position3: ").Append(Position3).Append("\n");
            sb.Append("  Position4: ").Append(Position4).Append("\n");
            sb.Append("  Position5: ").Append(Position5).Append("\n");
            sb.Append("  Position1crossings: ").Append(Position1crossings).Append("\n");
            sb.Append("  Position2crossings: ").Append(Position2crossings).Append("\n");
            sb.Append("  Position3crossings: ").Append(Position3crossings).Append("\n");
            sb.Append("  Position4crossings: ").Append(Position4crossings).Append("\n");
            sb.Append("  Position5crossings: ").Append(Position5crossings).Append("\n");
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
            return this.Equals(input as MatchScoreBreakdown2016Alliance);
        }

        /// <summary>
        /// Returns true if MatchScoreBreakdown2016Alliance instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchScoreBreakdown2016Alliance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchScoreBreakdown2016Alliance input)
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
                    this.BreachPoints == input.BreachPoints ||
                    (this.BreachPoints != null &&
                    this.BreachPoints.Equals(input.BreachPoints))
                ) && 
                (
                    this.FoulPoints == input.FoulPoints ||
                    (this.FoulPoints != null &&
                    this.FoulPoints.Equals(input.FoulPoints))
                ) && 
                (
                    this.CapturePoints == input.CapturePoints ||
                    (this.CapturePoints != null &&
                    this.CapturePoints.Equals(input.CapturePoints))
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
                    this.AutoReachPoints == input.AutoReachPoints ||
                    (this.AutoReachPoints != null &&
                    this.AutoReachPoints.Equals(input.AutoReachPoints))
                ) && 
                (
                    this.AutoCrossingPoints == input.AutoCrossingPoints ||
                    (this.AutoCrossingPoints != null &&
                    this.AutoCrossingPoints.Equals(input.AutoCrossingPoints))
                ) && 
                (
                    this.AutoBouldersLow == input.AutoBouldersLow ||
                    (this.AutoBouldersLow != null &&
                    this.AutoBouldersLow.Equals(input.AutoBouldersLow))
                ) && 
                (
                    this.AutoBouldersHigh == input.AutoBouldersHigh ||
                    (this.AutoBouldersHigh != null &&
                    this.AutoBouldersHigh.Equals(input.AutoBouldersHigh))
                ) && 
                (
                    this.AutoBoulderPoints == input.AutoBoulderPoints ||
                    (this.AutoBoulderPoints != null &&
                    this.AutoBoulderPoints.Equals(input.AutoBoulderPoints))
                ) && 
                (
                    this.TeleopCrossingPoints == input.TeleopCrossingPoints ||
                    (this.TeleopCrossingPoints != null &&
                    this.TeleopCrossingPoints.Equals(input.TeleopCrossingPoints))
                ) && 
                (
                    this.TeleopBouldersLow == input.TeleopBouldersLow ||
                    (this.TeleopBouldersLow != null &&
                    this.TeleopBouldersLow.Equals(input.TeleopBouldersLow))
                ) && 
                (
                    this.TeleopBouldersHigh == input.TeleopBouldersHigh ||
                    (this.TeleopBouldersHigh != null &&
                    this.TeleopBouldersHigh.Equals(input.TeleopBouldersHigh))
                ) && 
                (
                    this.TeleopBoulderPoints == input.TeleopBoulderPoints ||
                    (this.TeleopBoulderPoints != null &&
                    this.TeleopBoulderPoints.Equals(input.TeleopBoulderPoints))
                ) && 
                (
                    this.TeleopDefensesBreached == input.TeleopDefensesBreached ||
                    (this.TeleopDefensesBreached != null &&
                    this.TeleopDefensesBreached.Equals(input.TeleopDefensesBreached))
                ) && 
                (
                    this.TeleopChallengePoints == input.TeleopChallengePoints ||
                    (this.TeleopChallengePoints != null &&
                    this.TeleopChallengePoints.Equals(input.TeleopChallengePoints))
                ) && 
                (
                    this.TeleopScalePoints == input.TeleopScalePoints ||
                    (this.TeleopScalePoints != null &&
                    this.TeleopScalePoints.Equals(input.TeleopScalePoints))
                ) && 
                (
                    this.TeleopTowerCaptured == input.TeleopTowerCaptured ||
                    (this.TeleopTowerCaptured != null &&
                    this.TeleopTowerCaptured.Equals(input.TeleopTowerCaptured))
                ) && 
                (
                    this.TowerFaceA == input.TowerFaceA ||
                    (this.TowerFaceA != null &&
                    this.TowerFaceA.Equals(input.TowerFaceA))
                ) && 
                (
                    this.TowerFaceB == input.TowerFaceB ||
                    (this.TowerFaceB != null &&
                    this.TowerFaceB.Equals(input.TowerFaceB))
                ) && 
                (
                    this.TowerFaceC == input.TowerFaceC ||
                    (this.TowerFaceC != null &&
                    this.TowerFaceC.Equals(input.TowerFaceC))
                ) && 
                (
                    this.TowerEndStrength == input.TowerEndStrength ||
                    (this.TowerEndStrength != null &&
                    this.TowerEndStrength.Equals(input.TowerEndStrength))
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
                    this.Position2 == input.Position2 ||
                    (this.Position2 != null &&
                    this.Position2.Equals(input.Position2))
                ) && 
                (
                    this.Position3 == input.Position3 ||
                    (this.Position3 != null &&
                    this.Position3.Equals(input.Position3))
                ) && 
                (
                    this.Position4 == input.Position4 ||
                    (this.Position4 != null &&
                    this.Position4.Equals(input.Position4))
                ) && 
                (
                    this.Position5 == input.Position5 ||
                    (this.Position5 != null &&
                    this.Position5.Equals(input.Position5))
                ) && 
                (
                    this.Position1crossings == input.Position1crossings ||
                    (this.Position1crossings != null &&
                    this.Position1crossings.Equals(input.Position1crossings))
                ) && 
                (
                    this.Position2crossings == input.Position2crossings ||
                    (this.Position2crossings != null &&
                    this.Position2crossings.Equals(input.Position2crossings))
                ) && 
                (
                    this.Position3crossings == input.Position3crossings ||
                    (this.Position3crossings != null &&
                    this.Position3crossings.Equals(input.Position3crossings))
                ) && 
                (
                    this.Position4crossings == input.Position4crossings ||
                    (this.Position4crossings != null &&
                    this.Position4crossings.Equals(input.Position4crossings))
                ) && 
                (
                    this.Position5crossings == input.Position5crossings ||
                    (this.Position5crossings != null &&
                    this.Position5crossings.Equals(input.Position5crossings))
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
                if (this.BreachPoints != null)
                    hashCode = hashCode * 59 + this.BreachPoints.GetHashCode();
                if (this.FoulPoints != null)
                    hashCode = hashCode * 59 + this.FoulPoints.GetHashCode();
                if (this.CapturePoints != null)
                    hashCode = hashCode * 59 + this.CapturePoints.GetHashCode();
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
                if (this.AutoReachPoints != null)
                    hashCode = hashCode * 59 + this.AutoReachPoints.GetHashCode();
                if (this.AutoCrossingPoints != null)
                    hashCode = hashCode * 59 + this.AutoCrossingPoints.GetHashCode();
                if (this.AutoBouldersLow != null)
                    hashCode = hashCode * 59 + this.AutoBouldersLow.GetHashCode();
                if (this.AutoBouldersHigh != null)
                    hashCode = hashCode * 59 + this.AutoBouldersHigh.GetHashCode();
                if (this.AutoBoulderPoints != null)
                    hashCode = hashCode * 59 + this.AutoBoulderPoints.GetHashCode();
                if (this.TeleopCrossingPoints != null)
                    hashCode = hashCode * 59 + this.TeleopCrossingPoints.GetHashCode();
                if (this.TeleopBouldersLow != null)
                    hashCode = hashCode * 59 + this.TeleopBouldersLow.GetHashCode();
                if (this.TeleopBouldersHigh != null)
                    hashCode = hashCode * 59 + this.TeleopBouldersHigh.GetHashCode();
                if (this.TeleopBoulderPoints != null)
                    hashCode = hashCode * 59 + this.TeleopBoulderPoints.GetHashCode();
                if (this.TeleopDefensesBreached != null)
                    hashCode = hashCode * 59 + this.TeleopDefensesBreached.GetHashCode();
                if (this.TeleopChallengePoints != null)
                    hashCode = hashCode * 59 + this.TeleopChallengePoints.GetHashCode();
                if (this.TeleopScalePoints != null)
                    hashCode = hashCode * 59 + this.TeleopScalePoints.GetHashCode();
                if (this.TeleopTowerCaptured != null)
                    hashCode = hashCode * 59 + this.TeleopTowerCaptured.GetHashCode();
                if (this.TowerFaceA != null)
                    hashCode = hashCode * 59 + this.TowerFaceA.GetHashCode();
                if (this.TowerFaceB != null)
                    hashCode = hashCode * 59 + this.TowerFaceB.GetHashCode();
                if (this.TowerFaceC != null)
                    hashCode = hashCode * 59 + this.TowerFaceC.GetHashCode();
                if (this.TowerEndStrength != null)
                    hashCode = hashCode * 59 + this.TowerEndStrength.GetHashCode();
                if (this.TechFoulCount != null)
                    hashCode = hashCode * 59 + this.TechFoulCount.GetHashCode();
                if (this.FoulCount != null)
                    hashCode = hashCode * 59 + this.FoulCount.GetHashCode();
                if (this.Position2 != null)
                    hashCode = hashCode * 59 + this.Position2.GetHashCode();
                if (this.Position3 != null)
                    hashCode = hashCode * 59 + this.Position3.GetHashCode();
                if (this.Position4 != null)
                    hashCode = hashCode * 59 + this.Position4.GetHashCode();
                if (this.Position5 != null)
                    hashCode = hashCode * 59 + this.Position5.GetHashCode();
                if (this.Position1crossings != null)
                    hashCode = hashCode * 59 + this.Position1crossings.GetHashCode();
                if (this.Position2crossings != null)
                    hashCode = hashCode * 59 + this.Position2crossings.GetHashCode();
                if (this.Position3crossings != null)
                    hashCode = hashCode * 59 + this.Position3crossings.GetHashCode();
                if (this.Position4crossings != null)
                    hashCode = hashCode * 59 + this.Position4crossings.GetHashCode();
                if (this.Position5crossings != null)
                    hashCode = hashCode * 59 + this.Position5crossings.GetHashCode();
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
