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
    /// TeamRobot
    /// </summary>
    [DataContract]
    public partial class TeamRobot :  IEquatable<TeamRobot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRobot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeamRobot() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRobot" /> class.
        /// </summary>
        /// <param name="Year">Year this robot competed in. (required).</param>
        /// <param name="RobotName">Name of the robot as provided by the team. (required).</param>
        /// <param name="Key">Internal TBA identifier for this robot. (required).</param>
        /// <param name="TeamKey">TBA team key for this robot. (required).</param>
        public TeamRobot(int? Year = default(int?), string RobotName = default(string), string Key = default(string), string TeamKey = default(string))
        {
            // to ensure "Year" is required (not null)
            if (Year == null)
            {
                throw new InvalidDataException("Year is a required property for TeamRobot and cannot be null");
            }
            else
            {
                this.Year = Year;
            }
            // to ensure "RobotName" is required (not null)
            if (RobotName == null)
            {
                throw new InvalidDataException("RobotName is a required property for TeamRobot and cannot be null");
            }
            else
            {
                this.RobotName = RobotName;
            }
            // to ensure "Key" is required (not null)
            if (Key == null)
            {
                throw new InvalidDataException("Key is a required property for TeamRobot and cannot be null");
            }
            else
            {
                this.Key = Key;
            }
            // to ensure "TeamKey" is required (not null)
            if (TeamKey == null)
            {
                throw new InvalidDataException("TeamKey is a required property for TeamRobot and cannot be null");
            }
            else
            {
                this.TeamKey = TeamKey;
            }
        }
        
        /// <summary>
        /// Year this robot competed in.
        /// </summary>
        /// <value>Year this robot competed in.</value>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Name of the robot as provided by the team.
        /// </summary>
        /// <value>Name of the robot as provided by the team.</value>
        [DataMember(Name="robot_name", EmitDefaultValue=false)]
        public string RobotName { get; set; }

        /// <summary>
        /// Internal TBA identifier for this robot.
        /// </summary>
        /// <value>Internal TBA identifier for this robot.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// TBA team key for this robot.
        /// </summary>
        /// <value>TBA team key for this robot.</value>
        [DataMember(Name="team_key", EmitDefaultValue=false)]
        public string TeamKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamRobot {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  RobotName: ").Append(RobotName).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  TeamKey: ").Append(TeamKey).Append("\n");
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
            return this.Equals(input as TeamRobot);
        }

        /// <summary>
        /// Returns true if TeamRobot instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamRobot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamRobot input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.RobotName == input.RobotName ||
                    (this.RobotName != null &&
                    this.RobotName.Equals(input.RobotName))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.RobotName != null)
                    hashCode = hashCode * 59 + this.RobotName.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
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
