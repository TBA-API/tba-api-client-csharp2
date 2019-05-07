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
    /// EliminationAlliance
    /// </summary>
    [DataContract]
    public partial class EliminationAlliance :  IEquatable<EliminationAlliance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EliminationAlliance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EliminationAlliance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EliminationAlliance" /> class.
        /// </summary>
        /// <param name="name">Alliance name, may be null..</param>
        /// <param name="backup">backup.</param>
        /// <param name="declines">List of teams that declined the alliance..</param>
        /// <param name="picks">List of team keys picked for the alliance. First pick is captain. (required).</param>
        /// <param name="status">status.</param>
        public EliminationAlliance(string name = default(string), EliminationAllianceBackup backup = default(EliminationAllianceBackup), List<string> declines = default(List<string>), List<string> picks = default(List<string>), EliminationAllianceStatus status = default(EliminationAllianceStatus))
        {
            // to ensure "picks" is required (not null)
            if (picks == null)
            {
                throw new InvalidDataException("picks is a required property for EliminationAlliance and cannot be null");
            }
            else
            {
                this.Picks = picks;
            }
            
            this.Name = name;
            this.Backup = backup;
            this.Declines = declines;
            this.Status = status;
        }
        
        /// <summary>
        /// Alliance name, may be null.
        /// </summary>
        /// <value>Alliance name, may be null.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Backup
        /// </summary>
        [DataMember(Name="backup", EmitDefaultValue=false)]
        public EliminationAllianceBackup Backup { get; set; }

        /// <summary>
        /// List of teams that declined the alliance.
        /// </summary>
        /// <value>List of teams that declined the alliance.</value>
        [DataMember(Name="declines", EmitDefaultValue=false)]
        public List<string> Declines { get; set; }

        /// <summary>
        /// List of team keys picked for the alliance. First pick is captain.
        /// </summary>
        /// <value>List of team keys picked for the alliance. First pick is captain.</value>
        [DataMember(Name="picks", EmitDefaultValue=false)]
        public List<string> Picks { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public EliminationAllianceStatus Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EliminationAlliance {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Backup: ").Append(Backup).Append("\n");
            sb.Append("  Declines: ").Append(Declines).Append("\n");
            sb.Append("  Picks: ").Append(Picks).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as EliminationAlliance);
        }

        /// <summary>
        /// Returns true if EliminationAlliance instances are equal
        /// </summary>
        /// <param name="input">Instance of EliminationAlliance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EliminationAlliance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Backup == input.Backup ||
                    (this.Backup != null &&
                    this.Backup.Equals(input.Backup))
                ) && 
                (
                    this.Declines == input.Declines ||
                    this.Declines != null &&
                    this.Declines.SequenceEqual(input.Declines)
                ) && 
                (
                    this.Picks == input.Picks ||
                    this.Picks != null &&
                    this.Picks.SequenceEqual(input.Picks)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Backup != null)
                    hashCode = hashCode * 59 + this.Backup.GetHashCode();
                if (this.Declines != null)
                    hashCode = hashCode * 59 + this.Declines.GetHashCode();
                if (this.Picks != null)
                    hashCode = hashCode * 59 + this.Picks.GetHashCode();
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
