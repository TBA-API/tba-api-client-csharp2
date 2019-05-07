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
    /// EventRanking
    /// </summary>
    [DataContract]
    public partial class EventRanking :  IEquatable<EventRanking>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventRanking" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventRanking() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventRanking" /> class.
        /// </summary>
        /// <param name="rankings">List of rankings at the event. (required).</param>
        /// <param name="extraStatsInfo">List of special TBA-generated values provided in the &#x60;extra_stats&#x60; array for each item..</param>
        /// <param name="sortOrderInfo">List of year-specific values provided in the &#x60;sort_orders&#x60; array for each team. (required).</param>
        public EventRanking(List<EventRankingRankings> rankings = default(List<EventRankingRankings>), List<EventRankingExtraStatsInfo> extraStatsInfo = default(List<EventRankingExtraStatsInfo>), List<EventRankingSortOrderInfo> sortOrderInfo = default(List<EventRankingSortOrderInfo>))
        {
            // to ensure "rankings" is required (not null)
            if (rankings == null)
            {
                throw new InvalidDataException("rankings is a required property for EventRanking and cannot be null");
            }
            else
            {
                this.Rankings = rankings;
            }
            
            // to ensure "sortOrderInfo" is required (not null)
            if (sortOrderInfo == null)
            {
                throw new InvalidDataException("sortOrderInfo is a required property for EventRanking and cannot be null");
            }
            else
            {
                this.SortOrderInfo = sortOrderInfo;
            }
            
            this.ExtraStatsInfo = extraStatsInfo;
        }
        
        /// <summary>
        /// List of rankings at the event.
        /// </summary>
        /// <value>List of rankings at the event.</value>
        [DataMember(Name="rankings", EmitDefaultValue=false)]
        public List<EventRankingRankings> Rankings { get; set; }

        /// <summary>
        /// List of special TBA-generated values provided in the &#x60;extra_stats&#x60; array for each item.
        /// </summary>
        /// <value>List of special TBA-generated values provided in the &#x60;extra_stats&#x60; array for each item.</value>
        [DataMember(Name="extra_stats_info", EmitDefaultValue=false)]
        public List<EventRankingExtraStatsInfo> ExtraStatsInfo { get; set; }

        /// <summary>
        /// List of year-specific values provided in the &#x60;sort_orders&#x60; array for each team.
        /// </summary>
        /// <value>List of year-specific values provided in the &#x60;sort_orders&#x60; array for each team.</value>
        [DataMember(Name="sort_order_info", EmitDefaultValue=false)]
        public List<EventRankingSortOrderInfo> SortOrderInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventRanking {\n");
            sb.Append("  Rankings: ").Append(Rankings).Append("\n");
            sb.Append("  ExtraStatsInfo: ").Append(ExtraStatsInfo).Append("\n");
            sb.Append("  SortOrderInfo: ").Append(SortOrderInfo).Append("\n");
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
            return this.Equals(input as EventRanking);
        }

        /// <summary>
        /// Returns true if EventRanking instances are equal
        /// </summary>
        /// <param name="input">Instance of EventRanking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventRanking input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rankings == input.Rankings ||
                    this.Rankings != null &&
                    this.Rankings.SequenceEqual(input.Rankings)
                ) && 
                (
                    this.ExtraStatsInfo == input.ExtraStatsInfo ||
                    this.ExtraStatsInfo != null &&
                    this.ExtraStatsInfo.SequenceEqual(input.ExtraStatsInfo)
                ) && 
                (
                    this.SortOrderInfo == input.SortOrderInfo ||
                    this.SortOrderInfo != null &&
                    this.SortOrderInfo.SequenceEqual(input.SortOrderInfo)
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
                if (this.Rankings != null)
                    hashCode = hashCode * 59 + this.Rankings.GetHashCode();
                if (this.ExtraStatsInfo != null)
                    hashCode = hashCode * 59 + this.ExtraStatsInfo.GetHashCode();
                if (this.SortOrderInfo != null)
                    hashCode = hashCode * 59 + this.SortOrderInfo.GetHashCode();
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
