/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.5
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
    /// Event
    /// </summary>
    [DataContract]
    public partial class Event :  IEquatable<Event>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Event() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
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
        /// <param name="shortName">Same as &#x60;name&#x60; but doesn&#39;t include event specifiers, such as &#39;Regional&#39; or &#39;District&#39;. May be null..</param>
        /// <param name="eventTypeString">Event Type, eg Regional, District, or Offseason. (required).</param>
        /// <param name="week">Week of the event relative to the first official season event, zero-indexed. Only valid for Regionals, Districts, and District Championships. Null otherwise. (Eg. A season with a week 0 &#39;preseason&#39; event does not count, and week 1 events will show 0 here. Seasons with a week 0.5 regional event will show week 0 for those event(s) and week 1 for week 1 events and so on.).</param>
        /// <param name="address">Address of the event&#39;s venue, if available..</param>
        /// <param name="postalCode">Postal code from the event address..</param>
        /// <param name="gmapsPlaceId">Google Maps Place ID for the event address..</param>
        /// <param name="gmapsUrl">Link to address location on Google Maps..</param>
        /// <param name="lat">Latitude for the event address..</param>
        /// <param name="lng">Longitude for the event address..</param>
        /// <param name="locationName">Name of the location at the address for the event, eg. Blue Alliance High School..</param>
        /// <param name="timezone">Timezone name..</param>
        /// <param name="website">The event&#39;s website, if any..</param>
        /// <param name="firstEventId">The FIRST internal Event ID, used to link to the event on the FRC webpage..</param>
        /// <param name="firstEventCode">Public facing event code used by FIRST (on frc-events.firstinspires.org, for example).</param>
        /// <param name="webcasts">webcasts.</param>
        /// <param name="divisionKeys">An array of event keys for the divisions at this event..</param>
        /// <param name="parentEventKey">The TBA Event key that represents the event&#39;s parent. Used to link back to the event from a division event. It is also the inverse relation of &#x60;divison_keys&#x60;..</param>
        /// <param name="playoffType">Playoff Type, as defined here: https://github.com/the-blue-alliance/the-blue-alliance/blob/master/consts/playoff_type.py#L4, or null..</param>
        /// <param name="playoffTypeString">String representation of the &#x60;playoff_type&#x60;, or null..</param>
        public Event(string key = default(string), string name = default(string), string eventCode = default(string), int eventType = default(int), DistrictList district = default(DistrictList), string city = default(string), string stateProv = default(string), string country = default(string), DateTime startDate = default(DateTime), DateTime endDate = default(DateTime), int year = default(int), string shortName = default(string), string eventTypeString = default(string), int week = default(int), string address = default(string), string postalCode = default(string), string gmapsPlaceId = default(string), string gmapsUrl = default(string), double lat = default(double), double lng = default(double), string locationName = default(string), string timezone = default(string), string website = default(string), string firstEventId = default(string), string firstEventCode = default(string), List<Webcast> webcasts = default(List<Webcast>), List<string> divisionKeys = default(List<string>), string parentEventKey = default(string), int playoffType = default(int), string playoffTypeString = default(string))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for Event and cannot be null");
            }
            else
            {
                this.Key = key;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Event and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "eventCode" is required (not null)
            if (eventCode == null)
            {
                throw new InvalidDataException("eventCode is a required property for Event and cannot be null");
            }
            else
            {
                this.EventCode = eventCode;
            }
            
            // to ensure "eventType" is required (not null)
            if (eventType == null)
            {
                throw new InvalidDataException("eventType is a required property for Event and cannot be null");
            }
            else
            {
                this.EventType = eventType;
            }
            
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new InvalidDataException("startDate is a required property for Event and cannot be null");
            }
            else
            {
                this.StartDate = startDate;
            }
            
            // to ensure "endDate" is required (not null)
            if (endDate == null)
            {
                throw new InvalidDataException("endDate is a required property for Event and cannot be null");
            }
            else
            {
                this.EndDate = endDate;
            }
            
            // to ensure "year" is required (not null)
            if (year == null)
            {
                throw new InvalidDataException("year is a required property for Event and cannot be null");
            }
            else
            {
                this.Year = year;
            }
            
            // to ensure "eventTypeString" is required (not null)
            if (eventTypeString == null)
            {
                throw new InvalidDataException("eventTypeString is a required property for Event and cannot be null");
            }
            else
            {
                this.EventTypeString = eventTypeString;
            }
            
            this.District = district;
            this.City = city;
            this.StateProv = stateProv;
            this.Country = country;
            this.ShortName = shortName;
            this.Week = week;
            this.Address = address;
            this.PostalCode = postalCode;
            this.GmapsPlaceId = gmapsPlaceId;
            this.GmapsUrl = gmapsUrl;
            this.Lat = lat;
            this.Lng = lng;
            this.LocationName = locationName;
            this.Timezone = timezone;
            this.Website = website;
            this.FirstEventId = firstEventId;
            this.FirstEventCode = firstEventCode;
            this.Webcasts = webcasts;
            this.DivisionKeys = divisionKeys;
            this.ParentEventKey = parentEventKey;
            this.PlayoffType = playoffType;
            this.PlayoffTypeString = playoffTypeString;
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
        /// Same as &#x60;name&#x60; but doesn&#39;t include event specifiers, such as &#39;Regional&#39; or &#39;District&#39;. May be null.
        /// </summary>
        /// <value>Same as &#x60;name&#x60; but doesn&#39;t include event specifiers, such as &#39;Regional&#39; or &#39;District&#39;. May be null.</value>
        [DataMember(Name="short_name", EmitDefaultValue=false)]
        public string ShortName { get; set; }

        /// <summary>
        /// Event Type, eg Regional, District, or Offseason.
        /// </summary>
        /// <value>Event Type, eg Regional, District, or Offseason.</value>
        [DataMember(Name="event_type_string", EmitDefaultValue=false)]
        public string EventTypeString { get; set; }

        /// <summary>
        /// Week of the event relative to the first official season event, zero-indexed. Only valid for Regionals, Districts, and District Championships. Null otherwise. (Eg. A season with a week 0 &#39;preseason&#39; event does not count, and week 1 events will show 0 here. Seasons with a week 0.5 regional event will show week 0 for those event(s) and week 1 for week 1 events and so on.)
        /// </summary>
        /// <value>Week of the event relative to the first official season event, zero-indexed. Only valid for Regionals, Districts, and District Championships. Null otherwise. (Eg. A season with a week 0 &#39;preseason&#39; event does not count, and week 1 events will show 0 here. Seasons with a week 0.5 regional event will show week 0 for those event(s) and week 1 for week 1 events and so on.)</value>
        [DataMember(Name="week", EmitDefaultValue=false)]
        public int Week { get; set; }

        /// <summary>
        /// Address of the event&#39;s venue, if available.
        /// </summary>
        /// <value>Address of the event&#39;s venue, if available.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Postal code from the event address.
        /// </summary>
        /// <value>Postal code from the event address.</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Google Maps Place ID for the event address.
        /// </summary>
        /// <value>Google Maps Place ID for the event address.</value>
        [DataMember(Name="gmaps_place_id", EmitDefaultValue=false)]
        public string GmapsPlaceId { get; set; }

        /// <summary>
        /// Link to address location on Google Maps.
        /// </summary>
        /// <value>Link to address location on Google Maps.</value>
        [DataMember(Name="gmaps_url", EmitDefaultValue=false)]
        public string GmapsUrl { get; set; }

        /// <summary>
        /// Latitude for the event address.
        /// </summary>
        /// <value>Latitude for the event address.</value>
        [DataMember(Name="lat", EmitDefaultValue=false)]
        public double Lat { get; set; }

        /// <summary>
        /// Longitude for the event address.
        /// </summary>
        /// <value>Longitude for the event address.</value>
        [DataMember(Name="lng", EmitDefaultValue=false)]
        public double Lng { get; set; }

        /// <summary>
        /// Name of the location at the address for the event, eg. Blue Alliance High School.
        /// </summary>
        /// <value>Name of the location at the address for the event, eg. Blue Alliance High School.</value>
        [DataMember(Name="location_name", EmitDefaultValue=false)]
        public string LocationName { get; set; }

        /// <summary>
        /// Timezone name.
        /// </summary>
        /// <value>Timezone name.</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// The event&#39;s website, if any.
        /// </summary>
        /// <value>The event&#39;s website, if any.</value>
        [DataMember(Name="website", EmitDefaultValue=false)]
        public string Website { get; set; }

        /// <summary>
        /// The FIRST internal Event ID, used to link to the event on the FRC webpage.
        /// </summary>
        /// <value>The FIRST internal Event ID, used to link to the event on the FRC webpage.</value>
        [DataMember(Name="first_event_id", EmitDefaultValue=false)]
        public string FirstEventId { get; set; }

        /// <summary>
        /// Public facing event code used by FIRST (on frc-events.firstinspires.org, for example)
        /// </summary>
        /// <value>Public facing event code used by FIRST (on frc-events.firstinspires.org, for example)</value>
        [DataMember(Name="first_event_code", EmitDefaultValue=false)]
        public string FirstEventCode { get; set; }

        /// <summary>
        /// Gets or Sets Webcasts
        /// </summary>
        [DataMember(Name="webcasts", EmitDefaultValue=false)]
        public List<Webcast> Webcasts { get; set; }

        /// <summary>
        /// An array of event keys for the divisions at this event.
        /// </summary>
        /// <value>An array of event keys for the divisions at this event.</value>
        [DataMember(Name="division_keys", EmitDefaultValue=false)]
        public List<string> DivisionKeys { get; set; }

        /// <summary>
        /// The TBA Event key that represents the event&#39;s parent. Used to link back to the event from a division event. It is also the inverse relation of &#x60;divison_keys&#x60;.
        /// </summary>
        /// <value>The TBA Event key that represents the event&#39;s parent. Used to link back to the event from a division event. It is also the inverse relation of &#x60;divison_keys&#x60;.</value>
        [DataMember(Name="parent_event_key", EmitDefaultValue=false)]
        public string ParentEventKey { get; set; }

        /// <summary>
        /// Playoff Type, as defined here: https://github.com/the-blue-alliance/the-blue-alliance/blob/master/consts/playoff_type.py#L4, or null.
        /// </summary>
        /// <value>Playoff Type, as defined here: https://github.com/the-blue-alliance/the-blue-alliance/blob/master/consts/playoff_type.py#L4, or null.</value>
        [DataMember(Name="playoff_type", EmitDefaultValue=false)]
        public int PlayoffType { get; set; }

        /// <summary>
        /// String representation of the &#x60;playoff_type&#x60;, or null.
        /// </summary>
        /// <value>String representation of the &#x60;playoff_type&#x60;, or null.</value>
        [DataMember(Name="playoff_type_string", EmitDefaultValue=false)]
        public string PlayoffTypeString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Event {\n");
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
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  EventTypeString: ").Append(EventTypeString).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  GmapsPlaceId: ").Append(GmapsPlaceId).Append("\n");
            sb.Append("  GmapsUrl: ").Append(GmapsUrl).Append("\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Lng: ").Append(Lng).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  FirstEventId: ").Append(FirstEventId).Append("\n");
            sb.Append("  FirstEventCode: ").Append(FirstEventCode).Append("\n");
            sb.Append("  Webcasts: ").Append(Webcasts).Append("\n");
            sb.Append("  DivisionKeys: ").Append(DivisionKeys).Append("\n");
            sb.Append("  ParentEventKey: ").Append(ParentEventKey).Append("\n");
            sb.Append("  PlayoffType: ").Append(PlayoffType).Append("\n");
            sb.Append("  PlayoffTypeString: ").Append(PlayoffTypeString).Append("\n");
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
            return this.Equals(input as Event);
        }

        /// <summary>
        /// Returns true if Event instances are equal
        /// </summary>
        /// <param name="input">Instance of Event to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Event input)
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
                ) && 
                (
                    this.ShortName == input.ShortName ||
                    (this.ShortName != null &&
                    this.ShortName.Equals(input.ShortName))
                ) && 
                (
                    this.EventTypeString == input.EventTypeString ||
                    (this.EventTypeString != null &&
                    this.EventTypeString.Equals(input.EventTypeString))
                ) && 
                (
                    this.Week == input.Week ||
                    (this.Week != null &&
                    this.Week.Equals(input.Week))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.GmapsPlaceId == input.GmapsPlaceId ||
                    (this.GmapsPlaceId != null &&
                    this.GmapsPlaceId.Equals(input.GmapsPlaceId))
                ) && 
                (
                    this.GmapsUrl == input.GmapsUrl ||
                    (this.GmapsUrl != null &&
                    this.GmapsUrl.Equals(input.GmapsUrl))
                ) && 
                (
                    this.Lat == input.Lat ||
                    (this.Lat != null &&
                    this.Lat.Equals(input.Lat))
                ) && 
                (
                    this.Lng == input.Lng ||
                    (this.Lng != null &&
                    this.Lng.Equals(input.Lng))
                ) && 
                (
                    this.LocationName == input.LocationName ||
                    (this.LocationName != null &&
                    this.LocationName.Equals(input.LocationName))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) && 
                (
                    this.FirstEventId == input.FirstEventId ||
                    (this.FirstEventId != null &&
                    this.FirstEventId.Equals(input.FirstEventId))
                ) && 
                (
                    this.FirstEventCode == input.FirstEventCode ||
                    (this.FirstEventCode != null &&
                    this.FirstEventCode.Equals(input.FirstEventCode))
                ) && 
                (
                    this.Webcasts == input.Webcasts ||
                    this.Webcasts != null &&
                    input.Webcasts != null &&
                    this.Webcasts.SequenceEqual(input.Webcasts)
                ) && 
                (
                    this.DivisionKeys == input.DivisionKeys ||
                    this.DivisionKeys != null &&
                    input.DivisionKeys != null &&
                    this.DivisionKeys.SequenceEqual(input.DivisionKeys)
                ) && 
                (
                    this.ParentEventKey == input.ParentEventKey ||
                    (this.ParentEventKey != null &&
                    this.ParentEventKey.Equals(input.ParentEventKey))
                ) && 
                (
                    this.PlayoffType == input.PlayoffType ||
                    (this.PlayoffType != null &&
                    this.PlayoffType.Equals(input.PlayoffType))
                ) && 
                (
                    this.PlayoffTypeString == input.PlayoffTypeString ||
                    (this.PlayoffTypeString != null &&
                    this.PlayoffTypeString.Equals(input.PlayoffTypeString))
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
                if (this.ShortName != null)
                    hashCode = hashCode * 59 + this.ShortName.GetHashCode();
                if (this.EventTypeString != null)
                    hashCode = hashCode * 59 + this.EventTypeString.GetHashCode();
                if (this.Week != null)
                    hashCode = hashCode * 59 + this.Week.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.GmapsPlaceId != null)
                    hashCode = hashCode * 59 + this.GmapsPlaceId.GetHashCode();
                if (this.GmapsUrl != null)
                    hashCode = hashCode * 59 + this.GmapsUrl.GetHashCode();
                if (this.Lat != null)
                    hashCode = hashCode * 59 + this.Lat.GetHashCode();
                if (this.Lng != null)
                    hashCode = hashCode * 59 + this.Lng.GetHashCode();
                if (this.LocationName != null)
                    hashCode = hashCode * 59 + this.LocationName.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.Website != null)
                    hashCode = hashCode * 59 + this.Website.GetHashCode();
                if (this.FirstEventId != null)
                    hashCode = hashCode * 59 + this.FirstEventId.GetHashCode();
                if (this.FirstEventCode != null)
                    hashCode = hashCode * 59 + this.FirstEventCode.GetHashCode();
                if (this.Webcasts != null)
                    hashCode = hashCode * 59 + this.Webcasts.GetHashCode();
                if (this.DivisionKeys != null)
                    hashCode = hashCode * 59 + this.DivisionKeys.GetHashCode();
                if (this.ParentEventKey != null)
                    hashCode = hashCode * 59 + this.ParentEventKey.GetHashCode();
                if (this.PlayoffType != null)
                    hashCode = hashCode * 59 + this.PlayoffType.GetHashCode();
                if (this.PlayoffTypeString != null)
                    hashCode = hashCode * 59 + this.PlayoffTypeString.GetHashCode();
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
