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
    /// Award
    /// </summary>
    [DataContract]
    public partial class Award :  IEquatable<Award>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Award" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Award() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Award" /> class.
        /// </summary>
        /// <param name="Name">The name of the award as provided by FIRST. May vary for the same award type. (required).</param>
        /// <param name="AwardType">Type of award given. See https://github.com/the-blue-alliance/the-blue-alliance/blob/master/consts/award_type.py#L6 (required).</param>
        /// <param name="EventKey">The event_key of the event the award was won at. (required).</param>
        /// <param name="RecipientList">A list of recipients of the award at the event. Either team_key and/or awardee for individual awards. (required).</param>
        /// <param name="Year">The year this award was won. (required).</param>
        public Award(string Name = default(string), int? AwardType = default(int?), string EventKey = default(string), List<AwardRecipient> RecipientList = default(List<AwardRecipient>), int? Year = default(int?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Award and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "AwardType" is required (not null)
            if (AwardType == null)
            {
                throw new InvalidDataException("AwardType is a required property for Award and cannot be null");
            }
            else
            {
                this.AwardType = AwardType;
            }
            // to ensure "EventKey" is required (not null)
            if (EventKey == null)
            {
                throw new InvalidDataException("EventKey is a required property for Award and cannot be null");
            }
            else
            {
                this.EventKey = EventKey;
            }
            // to ensure "RecipientList" is required (not null)
            if (RecipientList == null)
            {
                throw new InvalidDataException("RecipientList is a required property for Award and cannot be null");
            }
            else
            {
                this.RecipientList = RecipientList;
            }
            // to ensure "Year" is required (not null)
            if (Year == null)
            {
                throw new InvalidDataException("Year is a required property for Award and cannot be null");
            }
            else
            {
                this.Year = Year;
            }
        }
        
        /// <summary>
        /// The name of the award as provided by FIRST. May vary for the same award type.
        /// </summary>
        /// <value>The name of the award as provided by FIRST. May vary for the same award type.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Type of award given. See https://github.com/the-blue-alliance/the-blue-alliance/blob/master/consts/award_type.py#L6
        /// </summary>
        /// <value>Type of award given. See https://github.com/the-blue-alliance/the-blue-alliance/blob/master/consts/award_type.py#L6</value>
        [DataMember(Name="award_type", EmitDefaultValue=false)]
        public int? AwardType { get; set; }

        /// <summary>
        /// The event_key of the event the award was won at.
        /// </summary>
        /// <value>The event_key of the event the award was won at.</value>
        [DataMember(Name="event_key", EmitDefaultValue=false)]
        public string EventKey { get; set; }

        /// <summary>
        /// A list of recipients of the award at the event. Either team_key and/or awardee for individual awards.
        /// </summary>
        /// <value>A list of recipients of the award at the event. Either team_key and/or awardee for individual awards.</value>
        [DataMember(Name="recipient_list", EmitDefaultValue=false)]
        public List<AwardRecipient> RecipientList { get; set; }

        /// <summary>
        /// The year this award was won.
        /// </summary>
        /// <value>The year this award was won.</value>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Award {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AwardType: ").Append(AwardType).Append("\n");
            sb.Append("  EventKey: ").Append(EventKey).Append("\n");
            sb.Append("  RecipientList: ").Append(RecipientList).Append("\n");
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
            return this.Equals(input as Award);
        }

        /// <summary>
        /// Returns true if Award instances are equal
        /// </summary>
        /// <param name="input">Instance of Award to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Award input)
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
                    this.AwardType == input.AwardType ||
                    (this.AwardType != null &&
                    this.AwardType.Equals(input.AwardType))
                ) && 
                (
                    this.EventKey == input.EventKey ||
                    (this.EventKey != null &&
                    this.EventKey.Equals(input.EventKey))
                ) && 
                (
                    this.RecipientList == input.RecipientList ||
                    this.RecipientList != null &&
                    this.RecipientList.SequenceEqual(input.RecipientList)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AwardType != null)
                    hashCode = hashCode * 59 + this.AwardType.GetHashCode();
                if (this.EventKey != null)
                    hashCode = hashCode * 59 + this.EventKey.GetHashCode();
                if (this.RecipientList != null)
                    hashCode = hashCode * 59 + this.RecipientList.GetHashCode();
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