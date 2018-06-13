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
    /// DistrictList
    /// </summary>
    [DataContract]
    public partial class DistrictList :  IEquatable<DistrictList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DistrictList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DistrictList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DistrictList" /> class.
        /// </summary>
        /// <param name="Abbreviation">The short identifier for the district. (required).</param>
        /// <param name="DisplayName">The long name for the district. (required).</param>
        /// <param name="Key">Key for this district, e.g. &#x60;2016ne&#x60;. (required).</param>
        /// <param name="Year">Year this district participated. (required).</param>
        public DistrictList(string Abbreviation = default(string), string DisplayName = default(string), string Key = default(string), int? Year = default(int?))
        {
            // to ensure "Abbreviation" is required (not null)
            if (Abbreviation == null)
            {
                throw new InvalidDataException("Abbreviation is a required property for DistrictList and cannot be null");
            }
            else
            {
                this.Abbreviation = Abbreviation;
            }
            // to ensure "DisplayName" is required (not null)
            if (DisplayName == null)
            {
                throw new InvalidDataException("DisplayName is a required property for DistrictList and cannot be null");
            }
            else
            {
                this.DisplayName = DisplayName;
            }
            // to ensure "Key" is required (not null)
            if (Key == null)
            {
                throw new InvalidDataException("Key is a required property for DistrictList and cannot be null");
            }
            else
            {
                this.Key = Key;
            }
            // to ensure "Year" is required (not null)
            if (Year == null)
            {
                throw new InvalidDataException("Year is a required property for DistrictList and cannot be null");
            }
            else
            {
                this.Year = Year;
            }
        }
        
        /// <summary>
        /// The short identifier for the district.
        /// </summary>
        /// <value>The short identifier for the district.</value>
        [DataMember(Name="abbreviation", EmitDefaultValue=false)]
        public string Abbreviation { get; set; }

        /// <summary>
        /// The long name for the district.
        /// </summary>
        /// <value>The long name for the district.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Key for this district, e.g. &#x60;2016ne&#x60;.
        /// </summary>
        /// <value>Key for this district, e.g. &#x60;2016ne&#x60;.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Year this district participated.
        /// </summary>
        /// <value>Year this district participated.</value>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DistrictList {\n");
            sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
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
            return this.Equals(input as DistrictList);
        }

        /// <summary>
        /// Returns true if DistrictList instances are equal
        /// </summary>
        /// <param name="input">Instance of DistrictList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistrictList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Abbreviation == input.Abbreviation ||
                    (this.Abbreviation != null &&
                    this.Abbreviation.Equals(input.Abbreviation))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
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
                if (this.Abbreviation != null)
                    hashCode = hashCode * 59 + this.Abbreviation.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
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
