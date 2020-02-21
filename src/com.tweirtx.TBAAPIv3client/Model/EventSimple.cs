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
    /// EventSimple
    /// </summary>
    [DataContract]
    public partial class EventSimple :  IEquatable<EventSimple>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventSimple" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventSimple() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventSimple" /> class.
        /// </summary>
        /// <param name="key">TBA event key with the format yyyy[EVENT_CODE], where yyyy is the year, and EVENT_CODE is the event code of the event. (required).</param>
        /// <param name="name">Official name of event on record either provided by FIRST or organizers of offseason event. (required).</param>
        /// <param name="eventCode">Event short code, as provided by FIRST. (required).</param>
        /// <param name="eventType">Event Type, as defined here: https://github.com/the-blue-alliance/the-blue-alliance/blob/master/consts/event_type.py#L2 (required).</param>
        /// <param name="district">district.</param>
        /// <param name="city">City, town, village, etc. the event is located in..</param>
        /// <param name="stateProv">State or Province the event is located in..</param>
        /// <param name="country">Country the event is located in..</param>
        /// <param name="startDate">Event start date in &#x60;yyyy-mm-dd&#x60; format. (required).</param>
        /// <param name="endDate">Event end date in &#x60;yyyy-mm-dd&#x60; format. (required).</param>
        /// <param name="year">Year the event data is for. (required).</param>
        public EventSimple(string key = default(string), string name = default(string), string eventCode = default(string), int eventType = default(int), DistrictList district = default(DistrictList), string city = default(string), string stateProv = default(string), string country = default(string), DateTime startDate = default(DateTime), DateTime endDate = default(DateTime), int year = default(int))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for EventSimple and cannot be null");
            }
            else
            {
                this.Key = key;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for EventSimple and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "eventCode" is required (not null)
            if (eventCode == null)
            {
                throw new InvalidDataException("eventCode is a required property for EventSimple and cannot be null");
            }
            else
            {
                this.EventCode = eventCode;
            }
            
            // to ensure "eventType" is required (not null)
            if (eventType == null)
            {
                throw new InvalidDataException("eventType is a required property for EventSimple and cannot be null");
            }
            else
            {
                this.EventType = eventType;
            }
            
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new InvalidDataException("startDate is a required property for EventSimple and cannot be null");
            }
            else
            {
                this.StartDate = startDate;
            }
            
            // to ensure "endDate" is required (not null)
            if (endDate == null)
            {
                throw new InvalidDataException("endDate is a required property for EventSimple and cannot be null");
            }
            else
            {
                this.EndDate = endDate;
            }
            
            // to ensure "year" is required (not null)
            if (year == null)
            {
                throw new InvalidDataException("year is a required property for EventSimple and cannot be null");
            }
            else
            {
                this.Year = year;
            }
            
            this.District = district;
            this.City = city;
            this.StateProv = stateProv;
            this.Country = country;
        }
        
        /// <summary>
        /// TBA event key with the format yyyy[EVENT_CODE], where yyyy is the year, and EVENT_CODE is the event code of the event.
        /// </summary>
        /// <value>TBA event key with the format yyyy[EVENT_CODE], where yyyy is the year, and EVENT_CODE is the event code of the event.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Official name of event on record either provided by FIRST or organizers of offseason event.
        /// </summary>
        /// <value>Official name of event on record either provided by FIRST or organizers of offseason event.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Event short code, as provided by FIRST.
        /// </summary>
        /// <value>Event short code, as provided by FIRST.</value>
        [DataMember(Name="event_code", EmitDefaultValue=false)]
        public string EventCode { get; set; }

        /// <summary>
        /// Event Type, as defined here: https://github.com/the-blue-alliance/the-blue-alliance/blob/master/consts/event_type.py#L2
        /// </summary>
        /// <value>Event Type, as defined here: https://github.com/the-blue-alliance/the-blue-alliance/blob/master/consts/event_type.py#L2</value>
        [DataMember(Name="event_type", EmitDefaultValue=false)]
        public int EventType { get; set; }

        /// <summary>
        /// Gets or Sets District
        /// </summary>
        [DataMember(Name="district", EmitDefaultValue=false)]
        public DistrictList District { get; set; }

        /// <summary>
        /// City, town, village, etc. the event is located in.
        /// </summary>
        /// <value>City, town, village, etc. the event is located in.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// State or Province the event is located in.
        /// </summary>
        /// <value>State or Province the event is located in.</value>
        [DataMember(Name="state_prov", EmitDefaultValue=false)]
        public string StateProv { get; set; }

        /// <summary>
        /// Country the event is located in.
        /// </summary>
        /// <value>Country the event is located in.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Event start date in &#x60;yyyy-mm-dd&#x60; format.
        /// </summary>
        /// <value>Event start date in &#x60;yyyy-mm-dd&#x60; format.</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Event end date in &#x60;yyyy-mm-dd&#x60; format.
        /// </summary>
        /// <value>Event end date in &#x60;yyyy-mm-dd&#x60; format.</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Year the event data is for.
        /// </summary>
        /// <value>Year the event data is for.</value>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int Year { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventSimple {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EventCode: ").Append(EventCode).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  StateProv: ").Append(StateProv).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
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
            return this.Equals(input as EventSimple);
        }

        /// <summary>
        /// Returns true if EventSimple instances are equal
        /// </summary>
        /// <param name="input">Instance of EventSimple to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventSimple input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EventCode == input.EventCode ||
                    (this.EventCode != null &&
                    this.EventCode.Equals(input.EventCode))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.District == input.District ||
                    (this.District != null &&
                    this.District.Equals(input.District))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.StateProv == input.StateProv ||
                    (this.StateProv != null &&
                    this.StateProv.Equals(input.StateProv))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EventCode != null)
                    hashCode = hashCode * 59 + this.EventCode.GetHashCode();
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.District != null)
                    hashCode = hashCode * 59 + this.District.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.StateProv != null)
                    hashCode = hashCode * 59 + this.StateProv.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
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
