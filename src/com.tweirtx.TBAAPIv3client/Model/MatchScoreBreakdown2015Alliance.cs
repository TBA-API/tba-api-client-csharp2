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
    /// MatchScoreBreakdown2015Alliance
    /// </summary>
    [DataContract]
    public partial class MatchScoreBreakdown2015Alliance :  IEquatable<MatchScoreBreakdown2015Alliance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchScoreBreakdown2015Alliance" /> class.
        /// </summary>
        /// <param name="autoPoints">autoPoints.</param>
        /// <param name="teleopPoints">teleopPoints.</param>
        /// <param name="containerPoints">containerPoints.</param>
        /// <param name="totePoints">totePoints.</param>
        /// <param name="litterPoints">litterPoints.</param>
        /// <param name="foulPoints">foulPoints.</param>
        /// <param name="adjustPoints">adjustPoints.</param>
        /// <param name="totalPoints">totalPoints.</param>
        /// <param name="foulCount">foulCount.</param>
        /// <param name="toteCountFar">toteCountFar.</param>
        /// <param name="toteCountNear">toteCountNear.</param>
        /// <param name="toteSet">toteSet.</param>
        /// <param name="toteStack">toteStack.</param>
        /// <param name="containerCountLevel1">containerCountLevel1.</param>
        /// <param name="containerCountLevel2">containerCountLevel2.</param>
        /// <param name="containerCountLevel3">containerCountLevel3.</param>
        /// <param name="containerCountLevel4">containerCountLevel4.</param>
        /// <param name="containerCountLevel5">containerCountLevel5.</param>
        /// <param name="containerCountLevel6">containerCountLevel6.</param>
        /// <param name="containerSet">containerSet.</param>
        /// <param name="litterCountContainer">litterCountContainer.</param>
        /// <param name="litterCountLandfill">litterCountLandfill.</param>
        /// <param name="litterCountUnprocessed">litterCountUnprocessed.</param>
        /// <param name="robotSet">robotSet.</param>
        public MatchScoreBreakdown2015Alliance(int? autoPoints = default(int?), int? teleopPoints = default(int?), int? containerPoints = default(int?), int? totePoints = default(int?), int? litterPoints = default(int?), int? foulPoints = default(int?), int? adjustPoints = default(int?), int? totalPoints = default(int?), int? foulCount = default(int?), int? toteCountFar = default(int?), int? toteCountNear = default(int?), bool? toteSet = default(bool?), bool? toteStack = default(bool?), int? containerCountLevel1 = default(int?), int? containerCountLevel2 = default(int?), int? containerCountLevel3 = default(int?), int? containerCountLevel4 = default(int?), int? containerCountLevel5 = default(int?), int? containerCountLevel6 = default(int?), bool? containerSet = default(bool?), int? litterCountContainer = default(int?), int? litterCountLandfill = default(int?), int? litterCountUnprocessed = default(int?), bool? robotSet = default(bool?))
        {
            this.AutoPoints = autoPoints;
            this.TeleopPoints = teleopPoints;
            this.ContainerPoints = containerPoints;
            this.TotePoints = totePoints;
            this.LitterPoints = litterPoints;
            this.FoulPoints = foulPoints;
            this.AdjustPoints = adjustPoints;
            this.TotalPoints = totalPoints;
            this.FoulCount = foulCount;
            this.ToteCountFar = toteCountFar;
            this.ToteCountNear = toteCountNear;
            this.ToteSet = toteSet;
            this.ToteStack = toteStack;
            this.ContainerCountLevel1 = containerCountLevel1;
            this.ContainerCountLevel2 = containerCountLevel2;
            this.ContainerCountLevel3 = containerCountLevel3;
            this.ContainerCountLevel4 = containerCountLevel4;
            this.ContainerCountLevel5 = containerCountLevel5;
            this.ContainerCountLevel6 = containerCountLevel6;
            this.ContainerSet = containerSet;
            this.LitterCountContainer = litterCountContainer;
            this.LitterCountLandfill = litterCountLandfill;
            this.LitterCountUnprocessed = litterCountUnprocessed;
            this.RobotSet = robotSet;
        }
        
        /// <summary>
        /// Gets or Sets AutoPoints
        /// </summary>
        [DataMember(Name="auto_points", EmitDefaultValue=false)]
        public int? AutoPoints { get; set; }

        /// <summary>
        /// Gets or Sets TeleopPoints
        /// </summary>
        [DataMember(Name="teleop_points", EmitDefaultValue=false)]
        public int? TeleopPoints { get; set; }

        /// <summary>
        /// Gets or Sets ContainerPoints
        /// </summary>
        [DataMember(Name="container_points", EmitDefaultValue=false)]
        public int? ContainerPoints { get; set; }

        /// <summary>
        /// Gets or Sets TotePoints
        /// </summary>
        [DataMember(Name="tote_points", EmitDefaultValue=false)]
        public int? TotePoints { get; set; }

        /// <summary>
        /// Gets or Sets LitterPoints
        /// </summary>
        [DataMember(Name="litter_points", EmitDefaultValue=false)]
        public int? LitterPoints { get; set; }

        /// <summary>
        /// Gets or Sets FoulPoints
        /// </summary>
        [DataMember(Name="foul_points", EmitDefaultValue=false)]
        public int? FoulPoints { get; set; }

        /// <summary>
        /// Gets or Sets AdjustPoints
        /// </summary>
        [DataMember(Name="adjust_points", EmitDefaultValue=false)]
        public int? AdjustPoints { get; set; }

        /// <summary>
        /// Gets or Sets TotalPoints
        /// </summary>
        [DataMember(Name="total_points", EmitDefaultValue=false)]
        public int? TotalPoints { get; set; }

        /// <summary>
        /// Gets or Sets FoulCount
        /// </summary>
        [DataMember(Name="foul_count", EmitDefaultValue=false)]
        public int? FoulCount { get; set; }

        /// <summary>
        /// Gets or Sets ToteCountFar
        /// </summary>
        [DataMember(Name="tote_count_far", EmitDefaultValue=false)]
        public int? ToteCountFar { get; set; }

        /// <summary>
        /// Gets or Sets ToteCountNear
        /// </summary>
        [DataMember(Name="tote_count_near", EmitDefaultValue=false)]
        public int? ToteCountNear { get; set; }

        /// <summary>
        /// Gets or Sets ToteSet
        /// </summary>
        [DataMember(Name="tote_set", EmitDefaultValue=false)]
        public bool? ToteSet { get; set; }

        /// <summary>
        /// Gets or Sets ToteStack
        /// </summary>
        [DataMember(Name="tote_stack", EmitDefaultValue=false)]
        public bool? ToteStack { get; set; }

        /// <summary>
        /// Gets or Sets ContainerCountLevel1
        /// </summary>
        [DataMember(Name="container_count_level1", EmitDefaultValue=false)]
        public int? ContainerCountLevel1 { get; set; }

        /// <summary>
        /// Gets or Sets ContainerCountLevel2
        /// </summary>
        [DataMember(Name="container_count_level2", EmitDefaultValue=false)]
        public int? ContainerCountLevel2 { get; set; }

        /// <summary>
        /// Gets or Sets ContainerCountLevel3
        /// </summary>
        [DataMember(Name="container_count_level3", EmitDefaultValue=false)]
        public int? ContainerCountLevel3 { get; set; }

        /// <summary>
        /// Gets or Sets ContainerCountLevel4
        /// </summary>
        [DataMember(Name="container_count_level4", EmitDefaultValue=false)]
        public int? ContainerCountLevel4 { get; set; }

        /// <summary>
        /// Gets or Sets ContainerCountLevel5
        /// </summary>
        [DataMember(Name="container_count_level5", EmitDefaultValue=false)]
        public int? ContainerCountLevel5 { get; set; }

        /// <summary>
        /// Gets or Sets ContainerCountLevel6
        /// </summary>
        [DataMember(Name="container_count_level6", EmitDefaultValue=false)]
        public int? ContainerCountLevel6 { get; set; }

        /// <summary>
        /// Gets or Sets ContainerSet
        /// </summary>
        [DataMember(Name="container_set", EmitDefaultValue=false)]
        public bool? ContainerSet { get; set; }

        /// <summary>
        /// Gets or Sets LitterCountContainer
        /// </summary>
        [DataMember(Name="litter_count_container", EmitDefaultValue=false)]
        public int? LitterCountContainer { get; set; }

        /// <summary>
        /// Gets or Sets LitterCountLandfill
        /// </summary>
        [DataMember(Name="litter_count_landfill", EmitDefaultValue=false)]
        public int? LitterCountLandfill { get; set; }

        /// <summary>
        /// Gets or Sets LitterCountUnprocessed
        /// </summary>
        [DataMember(Name="litter_count_unprocessed", EmitDefaultValue=false)]
        public int? LitterCountUnprocessed { get; set; }

        /// <summary>
        /// Gets or Sets RobotSet
        /// </summary>
        [DataMember(Name="robot_set", EmitDefaultValue=false)]
        public bool? RobotSet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchScoreBreakdown2015Alliance {\n");
            sb.Append("  AutoPoints: ").Append(AutoPoints).Append("\n");
            sb.Append("  TeleopPoints: ").Append(TeleopPoints).Append("\n");
            sb.Append("  ContainerPoints: ").Append(ContainerPoints).Append("\n");
            sb.Append("  TotePoints: ").Append(TotePoints).Append("\n");
            sb.Append("  LitterPoints: ").Append(LitterPoints).Append("\n");
            sb.Append("  FoulPoints: ").Append(FoulPoints).Append("\n");
            sb.Append("  AdjustPoints: ").Append(AdjustPoints).Append("\n");
            sb.Append("  TotalPoints: ").Append(TotalPoints).Append("\n");
            sb.Append("  FoulCount: ").Append(FoulCount).Append("\n");
            sb.Append("  ToteCountFar: ").Append(ToteCountFar).Append("\n");
            sb.Append("  ToteCountNear: ").Append(ToteCountNear).Append("\n");
            sb.Append("  ToteSet: ").Append(ToteSet).Append("\n");
            sb.Append("  ToteStack: ").Append(ToteStack).Append("\n");
            sb.Append("  ContainerCountLevel1: ").Append(ContainerCountLevel1).Append("\n");
            sb.Append("  ContainerCountLevel2: ").Append(ContainerCountLevel2).Append("\n");
            sb.Append("  ContainerCountLevel3: ").Append(ContainerCountLevel3).Append("\n");
            sb.Append("  ContainerCountLevel4: ").Append(ContainerCountLevel4).Append("\n");
            sb.Append("  ContainerCountLevel5: ").Append(ContainerCountLevel5).Append("\n");
            sb.Append("  ContainerCountLevel6: ").Append(ContainerCountLevel6).Append("\n");
            sb.Append("  ContainerSet: ").Append(ContainerSet).Append("\n");
            sb.Append("  LitterCountContainer: ").Append(LitterCountContainer).Append("\n");
            sb.Append("  LitterCountLandfill: ").Append(LitterCountLandfill).Append("\n");
            sb.Append("  LitterCountUnprocessed: ").Append(LitterCountUnprocessed).Append("\n");
            sb.Append("  RobotSet: ").Append(RobotSet).Append("\n");
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
            return this.Equals(input as MatchScoreBreakdown2015Alliance);
        }

        /// <summary>
        /// Returns true if MatchScoreBreakdown2015Alliance instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchScoreBreakdown2015Alliance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchScoreBreakdown2015Alliance input)
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
                    this.ContainerPoints == input.ContainerPoints ||
                    (this.ContainerPoints != null &&
                    this.ContainerPoints.Equals(input.ContainerPoints))
                ) && 
                (
                    this.TotePoints == input.TotePoints ||
                    (this.TotePoints != null &&
                    this.TotePoints.Equals(input.TotePoints))
                ) && 
                (
                    this.LitterPoints == input.LitterPoints ||
                    (this.LitterPoints != null &&
                    this.LitterPoints.Equals(input.LitterPoints))
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
                    this.FoulCount == input.FoulCount ||
                    (this.FoulCount != null &&
                    this.FoulCount.Equals(input.FoulCount))
                ) && 
                (
                    this.ToteCountFar == input.ToteCountFar ||
                    (this.ToteCountFar != null &&
                    this.ToteCountFar.Equals(input.ToteCountFar))
                ) && 
                (
                    this.ToteCountNear == input.ToteCountNear ||
                    (this.ToteCountNear != null &&
                    this.ToteCountNear.Equals(input.ToteCountNear))
                ) && 
                (
                    this.ToteSet == input.ToteSet ||
                    (this.ToteSet != null &&
                    this.ToteSet.Equals(input.ToteSet))
                ) && 
                (
                    this.ToteStack == input.ToteStack ||
                    (this.ToteStack != null &&
                    this.ToteStack.Equals(input.ToteStack))
                ) && 
                (
                    this.ContainerCountLevel1 == input.ContainerCountLevel1 ||
                    (this.ContainerCountLevel1 != null &&
                    this.ContainerCountLevel1.Equals(input.ContainerCountLevel1))
                ) && 
                (
                    this.ContainerCountLevel2 == input.ContainerCountLevel2 ||
                    (this.ContainerCountLevel2 != null &&
                    this.ContainerCountLevel2.Equals(input.ContainerCountLevel2))
                ) && 
                (
                    this.ContainerCountLevel3 == input.ContainerCountLevel3 ||
                    (this.ContainerCountLevel3 != null &&
                    this.ContainerCountLevel3.Equals(input.ContainerCountLevel3))
                ) && 
                (
                    this.ContainerCountLevel4 == input.ContainerCountLevel4 ||
                    (this.ContainerCountLevel4 != null &&
                    this.ContainerCountLevel4.Equals(input.ContainerCountLevel4))
                ) && 
                (
                    this.ContainerCountLevel5 == input.ContainerCountLevel5 ||
                    (this.ContainerCountLevel5 != null &&
                    this.ContainerCountLevel5.Equals(input.ContainerCountLevel5))
                ) && 
                (
                    this.ContainerCountLevel6 == input.ContainerCountLevel6 ||
                    (this.ContainerCountLevel6 != null &&
                    this.ContainerCountLevel6.Equals(input.ContainerCountLevel6))
                ) && 
                (
                    this.ContainerSet == input.ContainerSet ||
                    (this.ContainerSet != null &&
                    this.ContainerSet.Equals(input.ContainerSet))
                ) && 
                (
                    this.LitterCountContainer == input.LitterCountContainer ||
                    (this.LitterCountContainer != null &&
                    this.LitterCountContainer.Equals(input.LitterCountContainer))
                ) && 
                (
                    this.LitterCountLandfill == input.LitterCountLandfill ||
                    (this.LitterCountLandfill != null &&
                    this.LitterCountLandfill.Equals(input.LitterCountLandfill))
                ) && 
                (
                    this.LitterCountUnprocessed == input.LitterCountUnprocessed ||
                    (this.LitterCountUnprocessed != null &&
                    this.LitterCountUnprocessed.Equals(input.LitterCountUnprocessed))
                ) && 
                (
                    this.RobotSet == input.RobotSet ||
                    (this.RobotSet != null &&
                    this.RobotSet.Equals(input.RobotSet))
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
                if (this.ContainerPoints != null)
                    hashCode = hashCode * 59 + this.ContainerPoints.GetHashCode();
                if (this.TotePoints != null)
                    hashCode = hashCode * 59 + this.TotePoints.GetHashCode();
                if (this.LitterPoints != null)
                    hashCode = hashCode * 59 + this.LitterPoints.GetHashCode();
                if (this.FoulPoints != null)
                    hashCode = hashCode * 59 + this.FoulPoints.GetHashCode();
                if (this.AdjustPoints != null)
                    hashCode = hashCode * 59 + this.AdjustPoints.GetHashCode();
                if (this.TotalPoints != null)
                    hashCode = hashCode * 59 + this.TotalPoints.GetHashCode();
                if (this.FoulCount != null)
                    hashCode = hashCode * 59 + this.FoulCount.GetHashCode();
                if (this.ToteCountFar != null)
                    hashCode = hashCode * 59 + this.ToteCountFar.GetHashCode();
                if (this.ToteCountNear != null)
                    hashCode = hashCode * 59 + this.ToteCountNear.GetHashCode();
                if (this.ToteSet != null)
                    hashCode = hashCode * 59 + this.ToteSet.GetHashCode();
                if (this.ToteStack != null)
                    hashCode = hashCode * 59 + this.ToteStack.GetHashCode();
                if (this.ContainerCountLevel1 != null)
                    hashCode = hashCode * 59 + this.ContainerCountLevel1.GetHashCode();
                if (this.ContainerCountLevel2 != null)
                    hashCode = hashCode * 59 + this.ContainerCountLevel2.GetHashCode();
                if (this.ContainerCountLevel3 != null)
                    hashCode = hashCode * 59 + this.ContainerCountLevel3.GetHashCode();
                if (this.ContainerCountLevel4 != null)
                    hashCode = hashCode * 59 + this.ContainerCountLevel4.GetHashCode();
                if (this.ContainerCountLevel5 != null)
                    hashCode = hashCode * 59 + this.ContainerCountLevel5.GetHashCode();
                if (this.ContainerCountLevel6 != null)
                    hashCode = hashCode * 59 + this.ContainerCountLevel6.GetHashCode();
                if (this.ContainerSet != null)
                    hashCode = hashCode * 59 + this.ContainerSet.GetHashCode();
                if (this.LitterCountContainer != null)
                    hashCode = hashCode * 59 + this.LitterCountContainer.GetHashCode();
                if (this.LitterCountLandfill != null)
                    hashCode = hashCode * 59 + this.LitterCountLandfill.GetHashCode();
                if (this.LitterCountUnprocessed != null)
                    hashCode = hashCode * 59 + this.LitterCountUnprocessed.GetHashCode();
                if (this.RobotSet != null)
                    hashCode = hashCode * 59 + this.RobotSet.GetHashCode();
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
