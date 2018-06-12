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
    /// Backup status, may be null.
    /// </summary>
    [DataContract]
    public partial class TeamEventStatusAllianceBackup :  IEquatable<TeamEventStatusAllianceBackup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamEventStatusAllianceBackup" /> class.
        /// </summary>
        /// <param name="_Out">TBA key for the team replaced by the backup..</param>
        /// <param name="_In">TBA key for the backup team called in..</param>
        public TeamEventStatusAllianceBackup(string _Out = default(string), string _In = default(string))
        {
            this._Out = _Out;
            this._In = _In;
        }
        
        /// <summary>
        /// TBA key for the team replaced by the backup.
        /// </summary>
        /// <value>TBA key for the team replaced by the backup.</value>
        [DataMember(Name="out", EmitDefaultValue=false)]
        public string _Out { get; set; }

        /// <summary>
        /// TBA key for the backup team called in.
        /// </summary>
        /// <value>TBA key for the backup team called in.</value>
        [DataMember(Name="in", EmitDefaultValue=false)]
        public string _In { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamEventStatusAllianceBackup {\n");
            sb.Append("  _Out: ").Append(_Out).Append("\n");
            sb.Append("  _In: ").Append(_In).Append("\n");
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
            return this.Equals(input as TeamEventStatusAllianceBackup);
        }

        /// <summary>
        /// Returns true if TeamEventStatusAllianceBackup instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamEventStatusAllianceBackup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamEventStatusAllianceBackup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Out == input._Out ||
                    (this._Out != null &&
                    this._Out.Equals(input._Out))
                ) && 
                (
                    this._In == input._In ||
                    (this._In != null &&
                    this._In.Equals(input._In))
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
                if (this._Out != null)
                    hashCode = hashCode * 59 + this._Out.GetHashCode();
                if (this._In != null)
                    hashCode = hashCode * 59 + this._In.GetHashCode();
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
