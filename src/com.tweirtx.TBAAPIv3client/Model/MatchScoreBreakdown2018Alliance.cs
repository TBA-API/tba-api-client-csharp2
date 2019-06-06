/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.04.1
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
    /// MatchScoreBreakdown2018Alliance
    /// </summary>
    [DataContract]
    public partial class MatchScoreBreakdown2018Alliance :  IEquatable<MatchScoreBreakdown2018Alliance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchScoreBreakdown2018Alliance" /> class.
        /// </summary>
        /// <param name="adjustPoints">adjustPoints.</param>
        /// <param name="autoOwnershipPoints">autoOwnershipPoints.</param>
        /// <param name="autoPoints">autoPoints.</param>
        /// <param name="autoQuestRankingPoint">autoQuestRankingPoint.</param>
        /// <param name="autoRobot1">autoRobot1.</param>
        /// <param name="autoRobot2">autoRobot2.</param>
        /// <param name="autoRobot3">autoRobot3.</param>
        /// <param name="autoRunPoints">autoRunPoints.</param>
        /// <param name="autoScaleOwnershipSec">autoScaleOwnershipSec.</param>
        /// <param name="autoSwitchAtZero">autoSwitchAtZero.</param>
        /// <param name="autoSwitchOwnershipSec">autoSwitchOwnershipSec.</param>
        /// <param name="endgamePoints">endgamePoints.</param>
        /// <param name="endgameRobot1">endgameRobot1.</param>
        /// <param name="endgameRobot2">endgameRobot2.</param>
        /// <param name="endgameRobot3">endgameRobot3.</param>
        /// <param name="faceTheBossRankingPoint">faceTheBossRankingPoint.</param>
        /// <param name="foulCount">foulCount.</param>
        /// <param name="foulPoints">foulPoints.</param>
        /// <param name="rp">rp.</param>
        /// <param name="techFoulCount">techFoulCount.</param>
        /// <param name="teleopOwnershipPoints">teleopOwnershipPoints.</param>
        /// <param name="teleopPoints">teleopPoints.</param>
        /// <param name="teleopScaleBoostSec">teleopScaleBoostSec.</param>
        /// <param name="teleopScaleForceSec">teleopScaleForceSec.</param>
        /// <param name="teleopScaleOwnershipSec">teleopScaleOwnershipSec.</param>
        /// <param name="teleopSwitchBoostSec">teleopSwitchBoostSec.</param>
        /// <param name="teleopSwitchForceSec">teleopSwitchForceSec.</param>
        /// <param name="teleopSwitchOwnershipSec">teleopSwitchOwnershipSec.</param>
        /// <param name="totalPoints">totalPoints.</param>
        /// <param name="vaultBoostPlayed">vaultBoostPlayed.</param>
        /// <param name="vaultBoostTotal">vaultBoostTotal.</param>
        /// <param name="vaultForcePlayed">vaultForcePlayed.</param>
        /// <param name="vaultForceTotal">vaultForceTotal.</param>
        /// <param name="vaultLevitatePlayed">vaultLevitatePlayed.</param>
        /// <param name="vaultLevitateTotal">vaultLevitateTotal.</param>
        /// <param name="vaultPoints">vaultPoints.</param>
        /// <param name="tbaGameData">Unofficial TBA-computed value of the FMS provided GameData given to the alliance teams at the start of the match. 3 Character String containing &#x60;L&#x60; and &#x60;R&#x60; only. The first character represents the near switch, the 2nd the scale, and the 3rd the far, opposing, switch from the alliance&#39;s perspective. An &#x60;L&#x60; in a position indicates the platform on the left will be lit for the alliance while an &#x60;R&#x60; will indicate the right platform will be lit for the alliance. See also [WPI Screen Steps](https://wpilib.screenstepslive.com/s/currentCS/m/getting_started/l/826278-2018-game-data-details)..</param>
        public MatchScoreBreakdown2018Alliance(int? adjustPoints = default(int?), int? autoOwnershipPoints = default(int?), int? autoPoints = default(int?), bool? autoQuestRankingPoint = default(bool?), string autoRobot1 = default(string), string autoRobot2 = default(string), string autoRobot3 = default(string), int? autoRunPoints = default(int?), int? autoScaleOwnershipSec = default(int?), bool? autoSwitchAtZero = default(bool?), int? autoSwitchOwnershipSec = default(int?), int? endgamePoints = default(int?), string endgameRobot1 = default(string), string endgameRobot2 = default(string), string endgameRobot3 = default(string), bool? faceTheBossRankingPoint = default(bool?), int? foulCount = default(int?), int? foulPoints = default(int?), int? rp = default(int?), int? techFoulCount = default(int?), int? teleopOwnershipPoints = default(int?), int? teleopPoints = default(int?), int? teleopScaleBoostSec = default(int?), int? teleopScaleForceSec = default(int?), int? teleopScaleOwnershipSec = default(int?), int? teleopSwitchBoostSec = default(int?), int? teleopSwitchForceSec = default(int?), int? teleopSwitchOwnershipSec = default(int?), int? totalPoints = default(int?), int? vaultBoostPlayed = default(int?), int? vaultBoostTotal = default(int?), int? vaultForcePlayed = default(int?), int? vaultForceTotal = default(int?), int? vaultLevitatePlayed = default(int?), int? vaultLevitateTotal = default(int?), int? vaultPoints = default(int?), string tbaGameData = default(string))
        {
            this.AdjustPoints = adjustPoints;
            this.AutoOwnershipPoints = autoOwnershipPoints;
            this.AutoPoints = autoPoints;
            this.AutoQuestRankingPoint = autoQuestRankingPoint;
            this.AutoRobot1 = autoRobot1;
            this.AutoRobot2 = autoRobot2;
            this.AutoRobot3 = autoRobot3;
            this.AutoRunPoints = autoRunPoints;
            this.AutoScaleOwnershipSec = autoScaleOwnershipSec;
            this.AutoSwitchAtZero = autoSwitchAtZero;
            this.AutoSwitchOwnershipSec = autoSwitchOwnershipSec;
            this.EndgamePoints = endgamePoints;
            this.EndgameRobot1 = endgameRobot1;
            this.EndgameRobot2 = endgameRobot2;
            this.EndgameRobot3 = endgameRobot3;
            this.FaceTheBossRankingPoint = faceTheBossRankingPoint;
            this.FoulCount = foulCount;
            this.FoulPoints = foulPoints;
            this.Rp = rp;
            this.TechFoulCount = techFoulCount;
            this.TeleopOwnershipPoints = teleopOwnershipPoints;
            this.TeleopPoints = teleopPoints;
            this.TeleopScaleBoostSec = teleopScaleBoostSec;
            this.TeleopScaleForceSec = teleopScaleForceSec;
            this.TeleopScaleOwnershipSec = teleopScaleOwnershipSec;
            this.TeleopSwitchBoostSec = teleopSwitchBoostSec;
            this.TeleopSwitchForceSec = teleopSwitchForceSec;
            this.TeleopSwitchOwnershipSec = teleopSwitchOwnershipSec;
            this.TotalPoints = totalPoints;
            this.VaultBoostPlayed = vaultBoostPlayed;
            this.VaultBoostTotal = vaultBoostTotal;
            this.VaultForcePlayed = vaultForcePlayed;
            this.VaultForceTotal = vaultForceTotal;
            this.VaultLevitatePlayed = vaultLevitatePlayed;
            this.VaultLevitateTotal = vaultLevitateTotal;
            this.VaultPoints = vaultPoints;
            this.TbaGameData = tbaGameData;
        }
        
        /// <summary>
        /// Gets or Sets AdjustPoints
        /// </summary>
        [DataMember(Name="adjustPoints", EmitDefaultValue=false)]
        public int? AdjustPoints { get; set; }

        /// <summary>
        /// Gets or Sets AutoOwnershipPoints
        /// </summary>
        [DataMember(Name="autoOwnershipPoints", EmitDefaultValue=false)]
        public int? AutoOwnershipPoints { get; set; }

        /// <summary>
        /// Gets or Sets AutoPoints
        /// </summary>
        [DataMember(Name="autoPoints", EmitDefaultValue=false)]
        public int? AutoPoints { get; set; }

        /// <summary>
        /// Gets or Sets AutoQuestRankingPoint
        /// </summary>
        [DataMember(Name="autoQuestRankingPoint", EmitDefaultValue=false)]
        public bool? AutoQuestRankingPoint { get; set; }

        /// <summary>
        /// Gets or Sets AutoRobot1
        /// </summary>
        [DataMember(Name="autoRobot1", EmitDefaultValue=false)]
        public string AutoRobot1 { get; set; }

        /// <summary>
        /// Gets or Sets AutoRobot2
        /// </summary>
        [DataMember(Name="autoRobot2", EmitDefaultValue=false)]
        public string AutoRobot2 { get; set; }

        /// <summary>
        /// Gets or Sets AutoRobot3
        /// </summary>
        [DataMember(Name="autoRobot3", EmitDefaultValue=false)]
        public string AutoRobot3 { get; set; }

        /// <summary>
        /// Gets or Sets AutoRunPoints
        /// </summary>
        [DataMember(Name="autoRunPoints", EmitDefaultValue=false)]
        public int? AutoRunPoints { get; set; }

        /// <summary>
        /// Gets or Sets AutoScaleOwnershipSec
        /// </summary>
        [DataMember(Name="autoScaleOwnershipSec", EmitDefaultValue=false)]
        public int? AutoScaleOwnershipSec { get; set; }

        /// <summary>
        /// Gets or Sets AutoSwitchAtZero
        /// </summary>
        [DataMember(Name="autoSwitchAtZero", EmitDefaultValue=false)]
        public bool? AutoSwitchAtZero { get; set; }

        /// <summary>
        /// Gets or Sets AutoSwitchOwnershipSec
        /// </summary>
        [DataMember(Name="autoSwitchOwnershipSec", EmitDefaultValue=false)]
        public int? AutoSwitchOwnershipSec { get; set; }

        /// <summary>
        /// Gets or Sets EndgamePoints
        /// </summary>
        [DataMember(Name="endgamePoints", EmitDefaultValue=false)]
        public int? EndgamePoints { get; set; }

        /// <summary>
        /// Gets or Sets EndgameRobot1
        /// </summary>
        [DataMember(Name="endgameRobot1", EmitDefaultValue=false)]
        public string EndgameRobot1 { get; set; }

        /// <summary>
        /// Gets or Sets EndgameRobot2
        /// </summary>
        [DataMember(Name="endgameRobot2", EmitDefaultValue=false)]
        public string EndgameRobot2 { get; set; }

        /// <summary>
        /// Gets or Sets EndgameRobot3
        /// </summary>
        [DataMember(Name="endgameRobot3", EmitDefaultValue=false)]
        public string EndgameRobot3 { get; set; }

        /// <summary>
        /// Gets or Sets FaceTheBossRankingPoint
        /// </summary>
        [DataMember(Name="faceTheBossRankingPoint", EmitDefaultValue=false)]
        public bool? FaceTheBossRankingPoint { get; set; }

        /// <summary>
        /// Gets or Sets FoulCount
        /// </summary>
        [DataMember(Name="foulCount", EmitDefaultValue=false)]
        public int? FoulCount { get; set; }

        /// <summary>
        /// Gets or Sets FoulPoints
        /// </summary>
        [DataMember(Name="foulPoints", EmitDefaultValue=false)]
        public int? FoulPoints { get; set; }

        /// <summary>
        /// Gets or Sets Rp
        /// </summary>
        [DataMember(Name="rp", EmitDefaultValue=false)]
        public int? Rp { get; set; }

        /// <summary>
        /// Gets or Sets TechFoulCount
        /// </summary>
        [DataMember(Name="techFoulCount", EmitDefaultValue=false)]
        public int? TechFoulCount { get; set; }

        /// <summary>
        /// Gets or Sets TeleopOwnershipPoints
        /// </summary>
        [DataMember(Name="teleopOwnershipPoints", EmitDefaultValue=false)]
        public int? TeleopOwnershipPoints { get; set; }

        /// <summary>
        /// Gets or Sets TeleopPoints
        /// </summary>
        [DataMember(Name="teleopPoints", EmitDefaultValue=false)]
        public int? TeleopPoints { get; set; }

        /// <summary>
        /// Gets or Sets TeleopScaleBoostSec
        /// </summary>
        [DataMember(Name="teleopScaleBoostSec", EmitDefaultValue=false)]
        public int? TeleopScaleBoostSec { get; set; }

        /// <summary>
        /// Gets or Sets TeleopScaleForceSec
        /// </summary>
        [DataMember(Name="teleopScaleForceSec", EmitDefaultValue=false)]
        public int? TeleopScaleForceSec { get; set; }

        /// <summary>
        /// Gets or Sets TeleopScaleOwnershipSec
        /// </summary>
        [DataMember(Name="teleopScaleOwnershipSec", EmitDefaultValue=false)]
        public int? TeleopScaleOwnershipSec { get; set; }

        /// <summary>
        /// Gets or Sets TeleopSwitchBoostSec
        /// </summary>
        [DataMember(Name="teleopSwitchBoostSec", EmitDefaultValue=false)]
        public int? TeleopSwitchBoostSec { get; set; }

        /// <summary>
        /// Gets or Sets TeleopSwitchForceSec
        /// </summary>
        [DataMember(Name="teleopSwitchForceSec", EmitDefaultValue=false)]
        public int? TeleopSwitchForceSec { get; set; }

        /// <summary>
        /// Gets or Sets TeleopSwitchOwnershipSec
        /// </summary>
        [DataMember(Name="teleopSwitchOwnershipSec", EmitDefaultValue=false)]
        public int? TeleopSwitchOwnershipSec { get; set; }

        /// <summary>
        /// Gets or Sets TotalPoints
        /// </summary>
        [DataMember(Name="totalPoints", EmitDefaultValue=false)]
        public int? TotalPoints { get; set; }

        /// <summary>
        /// Gets or Sets VaultBoostPlayed
        /// </summary>
        [DataMember(Name="vaultBoostPlayed", EmitDefaultValue=false)]
        public int? VaultBoostPlayed { get; set; }

        /// <summary>
        /// Gets or Sets VaultBoostTotal
        /// </summary>
        [DataMember(Name="vaultBoostTotal", EmitDefaultValue=false)]
        public int? VaultBoostTotal { get; set; }

        /// <summary>
        /// Gets or Sets VaultForcePlayed
        /// </summary>
        [DataMember(Name="vaultForcePlayed", EmitDefaultValue=false)]
        public int? VaultForcePlayed { get; set; }

        /// <summary>
        /// Gets or Sets VaultForceTotal
        /// </summary>
        [DataMember(Name="vaultForceTotal", EmitDefaultValue=false)]
        public int? VaultForceTotal { get; set; }

        /// <summary>
        /// Gets or Sets VaultLevitatePlayed
        /// </summary>
        [DataMember(Name="vaultLevitatePlayed", EmitDefaultValue=false)]
        public int? VaultLevitatePlayed { get; set; }

        /// <summary>
        /// Gets or Sets VaultLevitateTotal
        /// </summary>
        [DataMember(Name="vaultLevitateTotal", EmitDefaultValue=false)]
        public int? VaultLevitateTotal { get; set; }

        /// <summary>
        /// Gets or Sets VaultPoints
        /// </summary>
        [DataMember(Name="vaultPoints", EmitDefaultValue=false)]
        public int? VaultPoints { get; set; }

        /// <summary>
        /// Unofficial TBA-computed value of the FMS provided GameData given to the alliance teams at the start of the match. 3 Character String containing &#x60;L&#x60; and &#x60;R&#x60; only. The first character represents the near switch, the 2nd the scale, and the 3rd the far, opposing, switch from the alliance&#39;s perspective. An &#x60;L&#x60; in a position indicates the platform on the left will be lit for the alliance while an &#x60;R&#x60; will indicate the right platform will be lit for the alliance. See also [WPI Screen Steps](https://wpilib.screenstepslive.com/s/currentCS/m/getting_started/l/826278-2018-game-data-details).
        /// </summary>
        /// <value>Unofficial TBA-computed value of the FMS provided GameData given to the alliance teams at the start of the match. 3 Character String containing &#x60;L&#x60; and &#x60;R&#x60; only. The first character represents the near switch, the 2nd the scale, and the 3rd the far, opposing, switch from the alliance&#39;s perspective. An &#x60;L&#x60; in a position indicates the platform on the left will be lit for the alliance while an &#x60;R&#x60; will indicate the right platform will be lit for the alliance. See also [WPI Screen Steps](https://wpilib.screenstepslive.com/s/currentCS/m/getting_started/l/826278-2018-game-data-details).</value>
        [DataMember(Name="tba_gameData", EmitDefaultValue=false)]
        public string TbaGameData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchScoreBreakdown2018Alliance {\n");
            sb.Append("  AdjustPoints: ").Append(AdjustPoints).Append("\n");
            sb.Append("  AutoOwnershipPoints: ").Append(AutoOwnershipPoints).Append("\n");
            sb.Append("  AutoPoints: ").Append(AutoPoints).Append("\n");
            sb.Append("  AutoQuestRankingPoint: ").Append(AutoQuestRankingPoint).Append("\n");
            sb.Append("  AutoRobot1: ").Append(AutoRobot1).Append("\n");
            sb.Append("  AutoRobot2: ").Append(AutoRobot2).Append("\n");
            sb.Append("  AutoRobot3: ").Append(AutoRobot3).Append("\n");
            sb.Append("  AutoRunPoints: ").Append(AutoRunPoints).Append("\n");
            sb.Append("  AutoScaleOwnershipSec: ").Append(AutoScaleOwnershipSec).Append("\n");
            sb.Append("  AutoSwitchAtZero: ").Append(AutoSwitchAtZero).Append("\n");
            sb.Append("  AutoSwitchOwnershipSec: ").Append(AutoSwitchOwnershipSec).Append("\n");
            sb.Append("  EndgamePoints: ").Append(EndgamePoints).Append("\n");
            sb.Append("  EndgameRobot1: ").Append(EndgameRobot1).Append("\n");
            sb.Append("  EndgameRobot2: ").Append(EndgameRobot2).Append("\n");
            sb.Append("  EndgameRobot3: ").Append(EndgameRobot3).Append("\n");
            sb.Append("  FaceTheBossRankingPoint: ").Append(FaceTheBossRankingPoint).Append("\n");
            sb.Append("  FoulCount: ").Append(FoulCount).Append("\n");
            sb.Append("  FoulPoints: ").Append(FoulPoints).Append("\n");
            sb.Append("  Rp: ").Append(Rp).Append("\n");
            sb.Append("  TechFoulCount: ").Append(TechFoulCount).Append("\n");
            sb.Append("  TeleopOwnershipPoints: ").Append(TeleopOwnershipPoints).Append("\n");
            sb.Append("  TeleopPoints: ").Append(TeleopPoints).Append("\n");
            sb.Append("  TeleopScaleBoostSec: ").Append(TeleopScaleBoostSec).Append("\n");
            sb.Append("  TeleopScaleForceSec: ").Append(TeleopScaleForceSec).Append("\n");
            sb.Append("  TeleopScaleOwnershipSec: ").Append(TeleopScaleOwnershipSec).Append("\n");
            sb.Append("  TeleopSwitchBoostSec: ").Append(TeleopSwitchBoostSec).Append("\n");
            sb.Append("  TeleopSwitchForceSec: ").Append(TeleopSwitchForceSec).Append("\n");
            sb.Append("  TeleopSwitchOwnershipSec: ").Append(TeleopSwitchOwnershipSec).Append("\n");
            sb.Append("  TotalPoints: ").Append(TotalPoints).Append("\n");
            sb.Append("  VaultBoostPlayed: ").Append(VaultBoostPlayed).Append("\n");
            sb.Append("  VaultBoostTotal: ").Append(VaultBoostTotal).Append("\n");
            sb.Append("  VaultForcePlayed: ").Append(VaultForcePlayed).Append("\n");
            sb.Append("  VaultForceTotal: ").Append(VaultForceTotal).Append("\n");
            sb.Append("  VaultLevitatePlayed: ").Append(VaultLevitatePlayed).Append("\n");
            sb.Append("  VaultLevitateTotal: ").Append(VaultLevitateTotal).Append("\n");
            sb.Append("  VaultPoints: ").Append(VaultPoints).Append("\n");
            sb.Append("  TbaGameData: ").Append(TbaGameData).Append("\n");
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
            return this.Equals(input as MatchScoreBreakdown2018Alliance);
        }

        /// <summary>
        /// Returns true if MatchScoreBreakdown2018Alliance instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchScoreBreakdown2018Alliance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchScoreBreakdown2018Alliance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdjustPoints == input.AdjustPoints ||
                    (this.AdjustPoints != null &&
                    this.AdjustPoints.Equals(input.AdjustPoints))
                ) && 
                (
                    this.AutoOwnershipPoints == input.AutoOwnershipPoints ||
                    (this.AutoOwnershipPoints != null &&
                    this.AutoOwnershipPoints.Equals(input.AutoOwnershipPoints))
                ) && 
                (
                    this.AutoPoints == input.AutoPoints ||
                    (this.AutoPoints != null &&
                    this.AutoPoints.Equals(input.AutoPoints))
                ) && 
                (
                    this.AutoQuestRankingPoint == input.AutoQuestRankingPoint ||
                    (this.AutoQuestRankingPoint != null &&
                    this.AutoQuestRankingPoint.Equals(input.AutoQuestRankingPoint))
                ) && 
                (
                    this.AutoRobot1 == input.AutoRobot1 ||
                    (this.AutoRobot1 != null &&
                    this.AutoRobot1.Equals(input.AutoRobot1))
                ) && 
                (
                    this.AutoRobot2 == input.AutoRobot2 ||
                    (this.AutoRobot2 != null &&
                    this.AutoRobot2.Equals(input.AutoRobot2))
                ) && 
                (
                    this.AutoRobot3 == input.AutoRobot3 ||
                    (this.AutoRobot3 != null &&
                    this.AutoRobot3.Equals(input.AutoRobot3))
                ) && 
                (
                    this.AutoRunPoints == input.AutoRunPoints ||
                    (this.AutoRunPoints != null &&
                    this.AutoRunPoints.Equals(input.AutoRunPoints))
                ) && 
                (
                    this.AutoScaleOwnershipSec == input.AutoScaleOwnershipSec ||
                    (this.AutoScaleOwnershipSec != null &&
                    this.AutoScaleOwnershipSec.Equals(input.AutoScaleOwnershipSec))
                ) && 
                (
                    this.AutoSwitchAtZero == input.AutoSwitchAtZero ||
                    (this.AutoSwitchAtZero != null &&
                    this.AutoSwitchAtZero.Equals(input.AutoSwitchAtZero))
                ) && 
                (
                    this.AutoSwitchOwnershipSec == input.AutoSwitchOwnershipSec ||
                    (this.AutoSwitchOwnershipSec != null &&
                    this.AutoSwitchOwnershipSec.Equals(input.AutoSwitchOwnershipSec))
                ) && 
                (
                    this.EndgamePoints == input.EndgamePoints ||
                    (this.EndgamePoints != null &&
                    this.EndgamePoints.Equals(input.EndgamePoints))
                ) && 
                (
                    this.EndgameRobot1 == input.EndgameRobot1 ||
                    (this.EndgameRobot1 != null &&
                    this.EndgameRobot1.Equals(input.EndgameRobot1))
                ) && 
                (
                    this.EndgameRobot2 == input.EndgameRobot2 ||
                    (this.EndgameRobot2 != null &&
                    this.EndgameRobot2.Equals(input.EndgameRobot2))
                ) && 
                (
                    this.EndgameRobot3 == input.EndgameRobot3 ||
                    (this.EndgameRobot3 != null &&
                    this.EndgameRobot3.Equals(input.EndgameRobot3))
                ) && 
                (
                    this.FaceTheBossRankingPoint == input.FaceTheBossRankingPoint ||
                    (this.FaceTheBossRankingPoint != null &&
                    this.FaceTheBossRankingPoint.Equals(input.FaceTheBossRankingPoint))
                ) && 
                (
                    this.FoulCount == input.FoulCount ||
                    (this.FoulCount != null &&
                    this.FoulCount.Equals(input.FoulCount))
                ) && 
                (
                    this.FoulPoints == input.FoulPoints ||
                    (this.FoulPoints != null &&
                    this.FoulPoints.Equals(input.FoulPoints))
                ) && 
                (
                    this.Rp == input.Rp ||
                    (this.Rp != null &&
                    this.Rp.Equals(input.Rp))
                ) && 
                (
                    this.TechFoulCount == input.TechFoulCount ||
                    (this.TechFoulCount != null &&
                    this.TechFoulCount.Equals(input.TechFoulCount))
                ) && 
                (
                    this.TeleopOwnershipPoints == input.TeleopOwnershipPoints ||
                    (this.TeleopOwnershipPoints != null &&
                    this.TeleopOwnershipPoints.Equals(input.TeleopOwnershipPoints))
                ) && 
                (
                    this.TeleopPoints == input.TeleopPoints ||
                    (this.TeleopPoints != null &&
                    this.TeleopPoints.Equals(input.TeleopPoints))
                ) && 
                (
                    this.TeleopScaleBoostSec == input.TeleopScaleBoostSec ||
                    (this.TeleopScaleBoostSec != null &&
                    this.TeleopScaleBoostSec.Equals(input.TeleopScaleBoostSec))
                ) && 
                (
                    this.TeleopScaleForceSec == input.TeleopScaleForceSec ||
                    (this.TeleopScaleForceSec != null &&
                    this.TeleopScaleForceSec.Equals(input.TeleopScaleForceSec))
                ) && 
                (
                    this.TeleopScaleOwnershipSec == input.TeleopScaleOwnershipSec ||
                    (this.TeleopScaleOwnershipSec != null &&
                    this.TeleopScaleOwnershipSec.Equals(input.TeleopScaleOwnershipSec))
                ) && 
                (
                    this.TeleopSwitchBoostSec == input.TeleopSwitchBoostSec ||
                    (this.TeleopSwitchBoostSec != null &&
                    this.TeleopSwitchBoostSec.Equals(input.TeleopSwitchBoostSec))
                ) && 
                (
                    this.TeleopSwitchForceSec == input.TeleopSwitchForceSec ||
                    (this.TeleopSwitchForceSec != null &&
                    this.TeleopSwitchForceSec.Equals(input.TeleopSwitchForceSec))
                ) && 
                (
                    this.TeleopSwitchOwnershipSec == input.TeleopSwitchOwnershipSec ||
                    (this.TeleopSwitchOwnershipSec != null &&
                    this.TeleopSwitchOwnershipSec.Equals(input.TeleopSwitchOwnershipSec))
                ) && 
                (
                    this.TotalPoints == input.TotalPoints ||
                    (this.TotalPoints != null &&
                    this.TotalPoints.Equals(input.TotalPoints))
                ) && 
                (
                    this.VaultBoostPlayed == input.VaultBoostPlayed ||
                    (this.VaultBoostPlayed != null &&
                    this.VaultBoostPlayed.Equals(input.VaultBoostPlayed))
                ) && 
                (
                    this.VaultBoostTotal == input.VaultBoostTotal ||
                    (this.VaultBoostTotal != null &&
                    this.VaultBoostTotal.Equals(input.VaultBoostTotal))
                ) && 
                (
                    this.VaultForcePlayed == input.VaultForcePlayed ||
                    (this.VaultForcePlayed != null &&
                    this.VaultForcePlayed.Equals(input.VaultForcePlayed))
                ) && 
                (
                    this.VaultForceTotal == input.VaultForceTotal ||
                    (this.VaultForceTotal != null &&
                    this.VaultForceTotal.Equals(input.VaultForceTotal))
                ) && 
                (
                    this.VaultLevitatePlayed == input.VaultLevitatePlayed ||
                    (this.VaultLevitatePlayed != null &&
                    this.VaultLevitatePlayed.Equals(input.VaultLevitatePlayed))
                ) && 
                (
                    this.VaultLevitateTotal == input.VaultLevitateTotal ||
                    (this.VaultLevitateTotal != null &&
                    this.VaultLevitateTotal.Equals(input.VaultLevitateTotal))
                ) && 
                (
                    this.VaultPoints == input.VaultPoints ||
                    (this.VaultPoints != null &&
                    this.VaultPoints.Equals(input.VaultPoints))
                ) && 
                (
                    this.TbaGameData == input.TbaGameData ||
                    (this.TbaGameData != null &&
                    this.TbaGameData.Equals(input.TbaGameData))
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
                if (this.AdjustPoints != null)
                    hashCode = hashCode * 59 + this.AdjustPoints.GetHashCode();
                if (this.AutoOwnershipPoints != null)
                    hashCode = hashCode * 59 + this.AutoOwnershipPoints.GetHashCode();
                if (this.AutoPoints != null)
                    hashCode = hashCode * 59 + this.AutoPoints.GetHashCode();
                if (this.AutoQuestRankingPoint != null)
                    hashCode = hashCode * 59 + this.AutoQuestRankingPoint.GetHashCode();
                if (this.AutoRobot1 != null)
                    hashCode = hashCode * 59 + this.AutoRobot1.GetHashCode();
                if (this.AutoRobot2 != null)
                    hashCode = hashCode * 59 + this.AutoRobot2.GetHashCode();
                if (this.AutoRobot3 != null)
                    hashCode = hashCode * 59 + this.AutoRobot3.GetHashCode();
                if (this.AutoRunPoints != null)
                    hashCode = hashCode * 59 + this.AutoRunPoints.GetHashCode();
                if (this.AutoScaleOwnershipSec != null)
                    hashCode = hashCode * 59 + this.AutoScaleOwnershipSec.GetHashCode();
                if (this.AutoSwitchAtZero != null)
                    hashCode = hashCode * 59 + this.AutoSwitchAtZero.GetHashCode();
                if (this.AutoSwitchOwnershipSec != null)
                    hashCode = hashCode * 59 + this.AutoSwitchOwnershipSec.GetHashCode();
                if (this.EndgamePoints != null)
                    hashCode = hashCode * 59 + this.EndgamePoints.GetHashCode();
                if (this.EndgameRobot1 != null)
                    hashCode = hashCode * 59 + this.EndgameRobot1.GetHashCode();
                if (this.EndgameRobot2 != null)
                    hashCode = hashCode * 59 + this.EndgameRobot2.GetHashCode();
                if (this.EndgameRobot3 != null)
                    hashCode = hashCode * 59 + this.EndgameRobot3.GetHashCode();
                if (this.FaceTheBossRankingPoint != null)
                    hashCode = hashCode * 59 + this.FaceTheBossRankingPoint.GetHashCode();
                if (this.FoulCount != null)
                    hashCode = hashCode * 59 + this.FoulCount.GetHashCode();
                if (this.FoulPoints != null)
                    hashCode = hashCode * 59 + this.FoulPoints.GetHashCode();
                if (this.Rp != null)
                    hashCode = hashCode * 59 + this.Rp.GetHashCode();
                if (this.TechFoulCount != null)
                    hashCode = hashCode * 59 + this.TechFoulCount.GetHashCode();
                if (this.TeleopOwnershipPoints != null)
                    hashCode = hashCode * 59 + this.TeleopOwnershipPoints.GetHashCode();
                if (this.TeleopPoints != null)
                    hashCode = hashCode * 59 + this.TeleopPoints.GetHashCode();
                if (this.TeleopScaleBoostSec != null)
                    hashCode = hashCode * 59 + this.TeleopScaleBoostSec.GetHashCode();
                if (this.TeleopScaleForceSec != null)
                    hashCode = hashCode * 59 + this.TeleopScaleForceSec.GetHashCode();
                if (this.TeleopScaleOwnershipSec != null)
                    hashCode = hashCode * 59 + this.TeleopScaleOwnershipSec.GetHashCode();
                if (this.TeleopSwitchBoostSec != null)
                    hashCode = hashCode * 59 + this.TeleopSwitchBoostSec.GetHashCode();
                if (this.TeleopSwitchForceSec != null)
                    hashCode = hashCode * 59 + this.TeleopSwitchForceSec.GetHashCode();
                if (this.TeleopSwitchOwnershipSec != null)
                    hashCode = hashCode * 59 + this.TeleopSwitchOwnershipSec.GetHashCode();
                if (this.TotalPoints != null)
                    hashCode = hashCode * 59 + this.TotalPoints.GetHashCode();
                if (this.VaultBoostPlayed != null)
                    hashCode = hashCode * 59 + this.VaultBoostPlayed.GetHashCode();
                if (this.VaultBoostTotal != null)
                    hashCode = hashCode * 59 + this.VaultBoostTotal.GetHashCode();
                if (this.VaultForcePlayed != null)
                    hashCode = hashCode * 59 + this.VaultForcePlayed.GetHashCode();
                if (this.VaultForceTotal != null)
                    hashCode = hashCode * 59 + this.VaultForceTotal.GetHashCode();
                if (this.VaultLevitatePlayed != null)
                    hashCode = hashCode * 59 + this.VaultLevitatePlayed.GetHashCode();
                if (this.VaultLevitateTotal != null)
                    hashCode = hashCode * 59 + this.VaultLevitateTotal.GetHashCode();
                if (this.VaultPoints != null)
                    hashCode = hashCode * 59 + this.VaultPoints.GetHashCode();
                if (this.TbaGameData != null)
                    hashCode = hashCode * 59 + this.TbaGameData.GetHashCode();
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
