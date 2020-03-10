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
using OpenAPIDateConverter = net.thefletcher.tbaapi.v3client.Client.OpenAPIDateConverter;

namespace net.thefletcher.tbaapi.v3client.Model
{
    /// <summary>
    /// ZebraAlliances
    /// </summary>
    [DataContract]
    public partial class ZebraAlliances :  IEquatable<ZebraAlliances>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZebraAlliances" /> class.
        /// </summary>
        /// <param name="red">Zebra MotionWorks data for teams on the red alliance.</param>
        /// <param name="blue">Zebra data for teams on the blue alliance.</param>
        public ZebraAlliances(List<ZebraTeam> red = default(List<ZebraTeam>), List<ZebraTeam> blue = default(List<ZebraTeam>))
        {
            this.Red = red;
            this.Blue = blue;
        }
        
        /// <summary>
        /// Zebra MotionWorks data for teams on the red alliance
        /// </summary>
        /// <value>Zebra MotionWorks data for teams on the red alliance</value>
        [DataMember(Name="red", EmitDefaultValue=false)]
        public List<ZebraTeam> Red { get; set; }

        /// <summary>
        /// Zebra data for teams on the blue alliance
        /// </summary>
        /// <value>Zebra data for teams on the blue alliance</value>
        [DataMember(Name="blue", EmitDefaultValue=false)]
        public List<ZebraTeam> Blue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZebraAlliances {\n");
            sb.Append("  Red: ").Append(Red).Append("\n");
            sb.Append("  Blue: ").Append(Blue).Append("\n");
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
            return this.Equals(input as ZebraAlliances);
        }

        /// <summary>
        /// Returns true if ZebraAlliances instances are equal
        /// </summary>
        /// <param name="input">Instance of ZebraAlliances to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZebraAlliances input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Red == input.Red ||
                    this.Red != null &&
                    input.Red != null &&
                    this.Red.SequenceEqual(input.Red)
                ) && 
                (
                    this.Blue == input.Blue ||
                    this.Blue != null &&
                    input.Blue != null &&
                    this.Blue.SequenceEqual(input.Blue)
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
                if (this.Red != null)
                    hashCode = hashCode * 59 + this.Red.GetHashCode();
                if (this.Blue != null)
                    hashCode = hashCode * 59 + this.Blue.GetHashCode();
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
