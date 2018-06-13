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
using SwaggerDateConverter = com.tweirtx.TBAAPIv3client.Client.SwaggerDateConverter;

namespace com.tweirtx.TBAAPIv3client.Model
{
    /// <summary>
    /// APIStatus
    /// </summary>
    [DataContract]
    public partial class APIStatus :  IEquatable<APIStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected APIStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="APIStatus" /> class.
        /// </summary>
        /// <param name="CurrentSeason">Year of the current FRC season. (required).</param>
        /// <param name="MaxSeason">Maximum FRC season year for valid queries. (required).</param>
        /// <param name="IsDatafeedDown">True if the entire FMS API provided by FIRST is down. (required).</param>
        /// <param name="DownEvents">An array of strings containing event keys of any active events that are no longer updating. (required).</param>
        /// <param name="Ios">Ios (required).</param>
        /// <param name="Android">Android (required).</param>
        public APIStatus(int? CurrentSeason = default(int?), int? MaxSeason = default(int?), bool? IsDatafeedDown = default(bool?), List<string> DownEvents = default(List<string>), APIStatusAppVersion Ios = default(APIStatusAppVersion), APIStatusAppVersion Android = default(APIStatusAppVersion))
        {
            // to ensure "CurrentSeason" is required (not null)
            if (CurrentSeason == null)
            {
                throw new InvalidDataException("CurrentSeason is a required property for APIStatus and cannot be null");
            }
            else
            {
                this.CurrentSeason = CurrentSeason;
            }
            // to ensure "MaxSeason" is required (not null)
            if (MaxSeason == null)
            {
                throw new InvalidDataException("MaxSeason is a required property for APIStatus and cannot be null");
            }
            else
            {
                this.MaxSeason = MaxSeason;
            }
            // to ensure "IsDatafeedDown" is required (not null)
            if (IsDatafeedDown == null)
            {
                throw new InvalidDataException("IsDatafeedDown is a required property for APIStatus and cannot be null");
            }
            else
            {
                this.IsDatafeedDown = IsDatafeedDown;
            }
            // to ensure "DownEvents" is required (not null)
            if (DownEvents == null)
            {
                throw new InvalidDataException("DownEvents is a required property for APIStatus and cannot be null");
            }
            else
            {
                this.DownEvents = DownEvents;
            }
            // to ensure "Ios" is required (not null)
            if (Ios == null)
            {
                throw new InvalidDataException("Ios is a required property for APIStatus and cannot be null");
            }
            else
            {
                this.Ios = Ios;
            }
            // to ensure "Android" is required (not null)
            if (Android == null)
            {
                throw new InvalidDataException("Android is a required property for APIStatus and cannot be null");
            }
            else
            {
                this.Android = Android;
            }
        }
        
        /// <summary>
        /// Year of the current FRC season.
        /// </summary>
        /// <value>Year of the current FRC season.</value>
        [DataMember(Name="current_season", EmitDefaultValue=false)]
        public int? CurrentSeason { get; set; }

        /// <summary>
        /// Maximum FRC season year for valid queries.
        /// </summary>
        /// <value>Maximum FRC season year for valid queries.</value>
        [DataMember(Name="max_season", EmitDefaultValue=false)]
        public int? MaxSeason { get; set; }

        /// <summary>
        /// True if the entire FMS API provided by FIRST is down.
        /// </summary>
        /// <value>True if the entire FMS API provided by FIRST is down.</value>
        [DataMember(Name="is_datafeed_down", EmitDefaultValue=false)]
        public bool? IsDatafeedDown { get; set; }

        /// <summary>
        /// An array of strings containing event keys of any active events that are no longer updating.
        /// </summary>
        /// <value>An array of strings containing event keys of any active events that are no longer updating.</value>
        [DataMember(Name="down_events", EmitDefaultValue=false)]
        public List<string> DownEvents { get; set; }

        /// <summary>
        /// Gets or Sets Ios
        /// </summary>
        [DataMember(Name="ios", EmitDefaultValue=false)]
        public APIStatusAppVersion Ios { get; set; }

        /// <summary>
        /// Gets or Sets Android
        /// </summary>
        [DataMember(Name="android", EmitDefaultValue=false)]
        public APIStatusAppVersion Android { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class APIStatus {\n");
            sb.Append("  CurrentSeason: ").Append(CurrentSeason).Append("\n");
            sb.Append("  MaxSeason: ").Append(MaxSeason).Append("\n");
            sb.Append("  IsDatafeedDown: ").Append(IsDatafeedDown).Append("\n");
            sb.Append("  DownEvents: ").Append(DownEvents).Append("\n");
            sb.Append("  Ios: ").Append(Ios).Append("\n");
            sb.Append("  Android: ").Append(Android).Append("\n");
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
            return this.Equals(input as APIStatus);
        }

        /// <summary>
        /// Returns true if APIStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of APIStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentSeason == input.CurrentSeason ||
                    (this.CurrentSeason != null &&
                    this.CurrentSeason.Equals(input.CurrentSeason))
                ) && 
                (
                    this.MaxSeason == input.MaxSeason ||
                    (this.MaxSeason != null &&
                    this.MaxSeason.Equals(input.MaxSeason))
                ) && 
                (
                    this.IsDatafeedDown == input.IsDatafeedDown ||
                    (this.IsDatafeedDown != null &&
                    this.IsDatafeedDown.Equals(input.IsDatafeedDown))
                ) && 
                (
                    this.DownEvents == input.DownEvents ||
                    this.DownEvents != null &&
                    this.DownEvents.SequenceEqual(input.DownEvents)
                ) && 
                (
                    this.Ios == input.Ios ||
                    (this.Ios != null &&
                    this.Ios.Equals(input.Ios))
                ) && 
                (
                    this.Android == input.Android ||
                    (this.Android != null &&
                    this.Android.Equals(input.Android))
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
                if (this.CurrentSeason != null)
                    hashCode = hashCode * 59 + this.CurrentSeason.GetHashCode();
                if (this.MaxSeason != null)
                    hashCode = hashCode * 59 + this.MaxSeason.GetHashCode();
                if (this.IsDatafeedDown != null)
                    hashCode = hashCode * 59 + this.IsDatafeedDown.GetHashCode();
                if (this.DownEvents != null)
                    hashCode = hashCode * 59 + this.DownEvents.GetHashCode();
                if (this.Ios != null)
                    hashCode = hashCode * 59 + this.Ios.GetHashCode();
                if (this.Android != null)
                    hashCode = hashCode * 59 + this.Android.GetHashCode();
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
