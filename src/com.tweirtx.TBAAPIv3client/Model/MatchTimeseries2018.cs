/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.04.1
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
    /// Timeseries data for the 2018 game *FIRST* POWER UP. *WARNING:* This is *not* official data, and is subject to a significant possibility of error, or missing data. Do not rely on this data for any purpose. In fact, pretend we made it up. *WARNING:* This model is currently under active development and may change at any time, including in breaking ways.
    /// </summary>
    [DataContract]
    public partial class MatchTimeseries2018 :  IEquatable<MatchTimeseries2018>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchTimeseries2018" /> class.
        /// </summary>
        /// <param name="eventKey">TBA event key with the format yyyy[EVENT_CODE], where yyyy is the year, and EVENT_CODE is the event code of the event..</param>
        /// <param name="matchId">Match ID consisting of the level, match number, and set number, eg &#x60;qm45&#x60; or &#x60;f1m1&#x60;..</param>
        /// <param name="mode">Current mode of play, can be &#x60;pre_match&#x60;, &#x60;auto&#x60;, &#x60;telop&#x60;, or &#x60;post_match&#x60;..</param>
        /// <param name="play">play.</param>
        /// <param name="timeRemaining">Amount of time remaining in the match, only valid during &#x60;auto&#x60; and &#x60;teleop&#x60; modes..</param>
        /// <param name="blueAutoQuest">1 if the blue alliance is credited with the AUTO QUEST, 0 if not..</param>
        /// <param name="blueBoostCount">Number of POWER CUBES in the BOOST section of the blue alliance VAULT..</param>
        /// <param name="blueBoostPlayed">Returns 1 if the blue alliance BOOST was played, or 0 if not played..</param>
        /// <param name="blueCurrentPowerup">Name of the current blue alliance POWER UP being played, or &#x60;null&#x60;..</param>
        /// <param name="blueFaceTheBoss">1 if the blue alliance is credited with FACING THE BOSS, 0 if not..</param>
        /// <param name="blueForceCount">Number of POWER CUBES in the FORCE section of the blue alliance VAULT..</param>
        /// <param name="blueForcePlayed">Returns 1 if the blue alliance FORCE was played, or 0 if not played..</param>
        /// <param name="blueLevitateCount">Number of POWER CUBES in the LEVITATE section of the blue alliance VAULT..</param>
        /// <param name="blueLevitatePlayed">Returns 1 if the blue alliance LEVITATE was played, or 0 if not played..</param>
        /// <param name="bluePowerupTimeRemaining">Number of seconds remaining in the blue alliance POWER UP time, or 0 if none is active..</param>
        /// <param name="blueScaleOwned">1 if the blue alliance owns the SCALE, 0 if not..</param>
        /// <param name="blueScore">Current score for the blue alliance..</param>
        /// <param name="blueSwitchOwned">1 if the blue alliance owns their SWITCH, 0 if not..</param>
        /// <param name="redAutoQuest">1 if the red alliance is credited with the AUTO QUEST, 0 if not..</param>
        /// <param name="redBoostCount">Number of POWER CUBES in the BOOST section of the red alliance VAULT..</param>
        /// <param name="redBoostPlayed">Returns 1 if the red alliance BOOST was played, or 0 if not played..</param>
        /// <param name="redCurrentPowerup">Name of the current red alliance POWER UP being played, or &#x60;null&#x60;..</param>
        /// <param name="redFaceTheBoss">1 if the red alliance is credited with FACING THE BOSS, 0 if not..</param>
        /// <param name="redForceCount">Number of POWER CUBES in the FORCE section of the red alliance VAULT..</param>
        /// <param name="redForcePlayed">Returns 1 if the red alliance FORCE was played, or 0 if not played..</param>
        /// <param name="redLevitateCount">Number of POWER CUBES in the LEVITATE section of the red alliance VAULT..</param>
        /// <param name="redLevitatePlayed">Returns 1 if the red alliance LEVITATE was played, or 0 if not played..</param>
        /// <param name="redPowerupTimeRemaining">Number of seconds remaining in the red alliance POWER UP time, or 0 if none is active..</param>
        /// <param name="redScaleOwned">1 if the red alliance owns the SCALE, 0 if not..</param>
        /// <param name="redScore">Current score for the red alliance..</param>
        /// <param name="redSwitchOwned">1 if the red alliance owns their SWITCH, 0 if not..</param>
        public MatchTimeseries2018(string eventKey = default(string), string matchId = default(string), string mode = default(string), int? play = default(int?), int? timeRemaining = default(int?), int? blueAutoQuest = default(int?), int? blueBoostCount = default(int?), int? blueBoostPlayed = default(int?), string blueCurrentPowerup = default(string), int? blueFaceTheBoss = default(int?), int? blueForceCount = default(int?), int? blueForcePlayed = default(int?), int? blueLevitateCount = default(int?), int? blueLevitatePlayed = default(int?), string bluePowerupTimeRemaining = default(string), int? blueScaleOwned = default(int?), int? blueScore = default(int?), int? blueSwitchOwned = default(int?), int? redAutoQuest = default(int?), int? redBoostCount = default(int?), int? redBoostPlayed = default(int?), string redCurrentPowerup = default(string), int? redFaceTheBoss = default(int?), int? redForceCount = default(int?), int? redForcePlayed = default(int?), int? redLevitateCount = default(int?), int? redLevitatePlayed = default(int?), string redPowerupTimeRemaining = default(string), int? redScaleOwned = default(int?), int? redScore = default(int?), int? redSwitchOwned = default(int?))
        {
            this.EventKey = eventKey;
            this.MatchId = matchId;
            this.Mode = mode;
            this.Play = play;
            this.TimeRemaining = timeRemaining;
            this.BlueAutoQuest = blueAutoQuest;
            this.BlueBoostCount = blueBoostCount;
            this.BlueBoostPlayed = blueBoostPlayed;
            this.BlueCurrentPowerup = blueCurrentPowerup;
            this.BlueFaceTheBoss = blueFaceTheBoss;
            this.BlueForceCount = blueForceCount;
            this.BlueForcePlayed = blueForcePlayed;
            this.BlueLevitateCount = blueLevitateCount;
            this.BlueLevitatePlayed = blueLevitatePlayed;
            this.BluePowerupTimeRemaining = bluePowerupTimeRemaining;
            this.BlueScaleOwned = blueScaleOwned;
            this.BlueScore = blueScore;
            this.BlueSwitchOwned = blueSwitchOwned;
            this.RedAutoQuest = redAutoQuest;
            this.RedBoostCount = redBoostCount;
            this.RedBoostPlayed = redBoostPlayed;
            this.RedCurrentPowerup = redCurrentPowerup;
            this.RedFaceTheBoss = redFaceTheBoss;
            this.RedForceCount = redForceCount;
            this.RedForcePlayed = redForcePlayed;
            this.RedLevitateCount = redLevitateCount;
            this.RedLevitatePlayed = redLevitatePlayed;
            this.RedPowerupTimeRemaining = redPowerupTimeRemaining;
            this.RedScaleOwned = redScaleOwned;
            this.RedScore = redScore;
            this.RedSwitchOwned = redSwitchOwned;
        }
        
        /// <summary>
        /// TBA event key with the format yyyy[EVENT_CODE], where yyyy is the year, and EVENT_CODE is the event code of the event.
        /// </summary>
        /// <value>TBA event key with the format yyyy[EVENT_CODE], where yyyy is the year, and EVENT_CODE is the event code of the event.</value>
        [DataMember(Name="event_key", EmitDefaultValue=false)]
        public string EventKey { get; set; }

        /// <summary>
        /// Match ID consisting of the level, match number, and set number, eg &#x60;qm45&#x60; or &#x60;f1m1&#x60;.
        /// </summary>
        /// <value>Match ID consisting of the level, match number, and set number, eg &#x60;qm45&#x60; or &#x60;f1m1&#x60;.</value>
        [DataMember(Name="match_id", EmitDefaultValue=false)]
        public string MatchId { get; set; }

        /// <summary>
        /// Current mode of play, can be &#x60;pre_match&#x60;, &#x60;auto&#x60;, &#x60;telop&#x60;, or &#x60;post_match&#x60;.
        /// </summary>
        /// <value>Current mode of play, can be &#x60;pre_match&#x60;, &#x60;auto&#x60;, &#x60;telop&#x60;, or &#x60;post_match&#x60;.</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or Sets Play
        /// </summary>
        [DataMember(Name="play", EmitDefaultValue=false)]
        public int? Play { get; set; }

        /// <summary>
        /// Amount of time remaining in the match, only valid during &#x60;auto&#x60; and &#x60;teleop&#x60; modes.
        /// </summary>
        /// <value>Amount of time remaining in the match, only valid during &#x60;auto&#x60; and &#x60;teleop&#x60; modes.</value>
        [DataMember(Name="time_remaining", EmitDefaultValue=false)]
        public int? TimeRemaining { get; set; }

        /// <summary>
        /// 1 if the blue alliance is credited with the AUTO QUEST, 0 if not.
        /// </summary>
        /// <value>1 if the blue alliance is credited with the AUTO QUEST, 0 if not.</value>
        [DataMember(Name="blue_auto_quest", EmitDefaultValue=false)]
        public int? BlueAutoQuest { get; set; }

        /// <summary>
        /// Number of POWER CUBES in the BOOST section of the blue alliance VAULT.
        /// </summary>
        /// <value>Number of POWER CUBES in the BOOST section of the blue alliance VAULT.</value>
        [DataMember(Name="blue_boost_count", EmitDefaultValue=false)]
        public int? BlueBoostCount { get; set; }

        /// <summary>
        /// Returns 1 if the blue alliance BOOST was played, or 0 if not played.
        /// </summary>
        /// <value>Returns 1 if the blue alliance BOOST was played, or 0 if not played.</value>
        [DataMember(Name="blue_boost_played", EmitDefaultValue=false)]
        public int? BlueBoostPlayed { get; set; }

        /// <summary>
        /// Name of the current blue alliance POWER UP being played, or &#x60;null&#x60;.
        /// </summary>
        /// <value>Name of the current blue alliance POWER UP being played, or &#x60;null&#x60;.</value>
        [DataMember(Name="blue_current_powerup", EmitDefaultValue=false)]
        public string BlueCurrentPowerup { get; set; }

        /// <summary>
        /// 1 if the blue alliance is credited with FACING THE BOSS, 0 if not.
        /// </summary>
        /// <value>1 if the blue alliance is credited with FACING THE BOSS, 0 if not.</value>
        [DataMember(Name="blue_face_the_boss", EmitDefaultValue=false)]
        public int? BlueFaceTheBoss { get; set; }

        /// <summary>
        /// Number of POWER CUBES in the FORCE section of the blue alliance VAULT.
        /// </summary>
        /// <value>Number of POWER CUBES in the FORCE section of the blue alliance VAULT.</value>
        [DataMember(Name="blue_force_count", EmitDefaultValue=false)]
        public int? BlueForceCount { get; set; }

        /// <summary>
        /// Returns 1 if the blue alliance FORCE was played, or 0 if not played.
        /// </summary>
        /// <value>Returns 1 if the blue alliance FORCE was played, or 0 if not played.</value>
        [DataMember(Name="blue_force_played", EmitDefaultValue=false)]
        public int? BlueForcePlayed { get; set; }

        /// <summary>
        /// Number of POWER CUBES in the LEVITATE section of the blue alliance VAULT.
        /// </summary>
        /// <value>Number of POWER CUBES in the LEVITATE section of the blue alliance VAULT.</value>
        [DataMember(Name="blue_levitate_count", EmitDefaultValue=false)]
        public int? BlueLevitateCount { get; set; }

        /// <summary>
        /// Returns 1 if the blue alliance LEVITATE was played, or 0 if not played.
        /// </summary>
        /// <value>Returns 1 if the blue alliance LEVITATE was played, or 0 if not played.</value>
        [DataMember(Name="blue_levitate_played", EmitDefaultValue=false)]
        public int? BlueLevitatePlayed { get; set; }

        /// <summary>
        /// Number of seconds remaining in the blue alliance POWER UP time, or 0 if none is active.
        /// </summary>
        /// <value>Number of seconds remaining in the blue alliance POWER UP time, or 0 if none is active.</value>
        [DataMember(Name="blue_powerup_time_remaining", EmitDefaultValue=false)]
        public string BluePowerupTimeRemaining { get; set; }

        /// <summary>
        /// 1 if the blue alliance owns the SCALE, 0 if not.
        /// </summary>
        /// <value>1 if the blue alliance owns the SCALE, 0 if not.</value>
        [DataMember(Name="blue_scale_owned", EmitDefaultValue=false)]
        public int? BlueScaleOwned { get; set; }

        /// <summary>
        /// Current score for the blue alliance.
        /// </summary>
        /// <value>Current score for the blue alliance.</value>
        [DataMember(Name="blue_score", EmitDefaultValue=false)]
        public int? BlueScore { get; set; }

        /// <summary>
        /// 1 if the blue alliance owns their SWITCH, 0 if not.
        /// </summary>
        /// <value>1 if the blue alliance owns their SWITCH, 0 if not.</value>
        [DataMember(Name="blue_switch_owned", EmitDefaultValue=false)]
        public int? BlueSwitchOwned { get; set; }

        /// <summary>
        /// 1 if the red alliance is credited with the AUTO QUEST, 0 if not.
        /// </summary>
        /// <value>1 if the red alliance is credited with the AUTO QUEST, 0 if not.</value>
        [DataMember(Name="red_auto_quest", EmitDefaultValue=false)]
        public int? RedAutoQuest { get; set; }

        /// <summary>
        /// Number of POWER CUBES in the BOOST section of the red alliance VAULT.
        /// </summary>
        /// <value>Number of POWER CUBES in the BOOST section of the red alliance VAULT.</value>
        [DataMember(Name="red_boost_count", EmitDefaultValue=false)]
        public int? RedBoostCount { get; set; }

        /// <summary>
        /// Returns 1 if the red alliance BOOST was played, or 0 if not played.
        /// </summary>
        /// <value>Returns 1 if the red alliance BOOST was played, or 0 if not played.</value>
        [DataMember(Name="red_boost_played", EmitDefaultValue=false)]
        public int? RedBoostPlayed { get; set; }

        /// <summary>
        /// Name of the current red alliance POWER UP being played, or &#x60;null&#x60;.
        /// </summary>
        /// <value>Name of the current red alliance POWER UP being played, or &#x60;null&#x60;.</value>
        [DataMember(Name="red_current_powerup", EmitDefaultValue=false)]
        public string RedCurrentPowerup { get; set; }

        /// <summary>
        /// 1 if the red alliance is credited with FACING THE BOSS, 0 if not.
        /// </summary>
        /// <value>1 if the red alliance is credited with FACING THE BOSS, 0 if not.</value>
        [DataMember(Name="red_face_the_boss", EmitDefaultValue=false)]
        public int? RedFaceTheBoss { get; set; }

        /// <summary>
        /// Number of POWER CUBES in the FORCE section of the red alliance VAULT.
        /// </summary>
        /// <value>Number of POWER CUBES in the FORCE section of the red alliance VAULT.</value>
        [DataMember(Name="red_force_count", EmitDefaultValue=false)]
        public int? RedForceCount { get; set; }

        /// <summary>
        /// Returns 1 if the red alliance FORCE was played, or 0 if not played.
        /// </summary>
        /// <value>Returns 1 if the red alliance FORCE was played, or 0 if not played.</value>
        [DataMember(Name="red_force_played", EmitDefaultValue=false)]
        public int? RedForcePlayed { get; set; }

        /// <summary>
        /// Number of POWER CUBES in the LEVITATE section of the red alliance VAULT.
        /// </summary>
        /// <value>Number of POWER CUBES in the LEVITATE section of the red alliance VAULT.</value>
        [DataMember(Name="red_levitate_count", EmitDefaultValue=false)]
        public int? RedLevitateCount { get; set; }

        /// <summary>
        /// Returns 1 if the red alliance LEVITATE was played, or 0 if not played.
        /// </summary>
        /// <value>Returns 1 if the red alliance LEVITATE was played, or 0 if not played.</value>
        [DataMember(Name="red_levitate_played", EmitDefaultValue=false)]
        public int? RedLevitatePlayed { get; set; }

        /// <summary>
        /// Number of seconds remaining in the red alliance POWER UP time, or 0 if none is active.
        /// </summary>
        /// <value>Number of seconds remaining in the red alliance POWER UP time, or 0 if none is active.</value>
        [DataMember(Name="red_powerup_time_remaining", EmitDefaultValue=false)]
        public string RedPowerupTimeRemaining { get; set; }

        /// <summary>
        /// 1 if the red alliance owns the SCALE, 0 if not.
        /// </summary>
        /// <value>1 if the red alliance owns the SCALE, 0 if not.</value>
        [DataMember(Name="red_scale_owned", EmitDefaultValue=false)]
        public int? RedScaleOwned { get; set; }

        /// <summary>
        /// Current score for the red alliance.
        /// </summary>
        /// <value>Current score for the red alliance.</value>
        [DataMember(Name="red_score", EmitDefaultValue=false)]
        public int? RedScore { get; set; }

        /// <summary>
        /// 1 if the red alliance owns their SWITCH, 0 if not.
        /// </summary>
        /// <value>1 if the red alliance owns their SWITCH, 0 if not.</value>
        [DataMember(Name="red_switch_owned", EmitDefaultValue=false)]
        public int? RedSwitchOwned { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchTimeseries2018 {\n");
            sb.Append("  EventKey: ").Append(EventKey).Append("\n");
            sb.Append("  MatchId: ").Append(MatchId).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Play: ").Append(Play).Append("\n");
            sb.Append("  TimeRemaining: ").Append(TimeRemaining).Append("\n");
            sb.Append("  BlueAutoQuest: ").Append(BlueAutoQuest).Append("\n");
            sb.Append("  BlueBoostCount: ").Append(BlueBoostCount).Append("\n");
            sb.Append("  BlueBoostPlayed: ").Append(BlueBoostPlayed).Append("\n");
            sb.Append("  BlueCurrentPowerup: ").Append(BlueCurrentPowerup).Append("\n");
            sb.Append("  BlueFaceTheBoss: ").Append(BlueFaceTheBoss).Append("\n");
            sb.Append("  BlueForceCount: ").Append(BlueForceCount).Append("\n");
            sb.Append("  BlueForcePlayed: ").Append(BlueForcePlayed).Append("\n");
            sb.Append("  BlueLevitateCount: ").Append(BlueLevitateCount).Append("\n");
            sb.Append("  BlueLevitatePlayed: ").Append(BlueLevitatePlayed).Append("\n");
            sb.Append("  BluePowerupTimeRemaining: ").Append(BluePowerupTimeRemaining).Append("\n");
            sb.Append("  BlueScaleOwned: ").Append(BlueScaleOwned).Append("\n");
            sb.Append("  BlueScore: ").Append(BlueScore).Append("\n");
            sb.Append("  BlueSwitchOwned: ").Append(BlueSwitchOwned).Append("\n");
            sb.Append("  RedAutoQuest: ").Append(RedAutoQuest).Append("\n");
            sb.Append("  RedBoostCount: ").Append(RedBoostCount).Append("\n");
            sb.Append("  RedBoostPlayed: ").Append(RedBoostPlayed).Append("\n");
            sb.Append("  RedCurrentPowerup: ").Append(RedCurrentPowerup).Append("\n");
            sb.Append("  RedFaceTheBoss: ").Append(RedFaceTheBoss).Append("\n");
            sb.Append("  RedForceCount: ").Append(RedForceCount).Append("\n");
            sb.Append("  RedForcePlayed: ").Append(RedForcePlayed).Append("\n");
            sb.Append("  RedLevitateCount: ").Append(RedLevitateCount).Append("\n");
            sb.Append("  RedLevitatePlayed: ").Append(RedLevitatePlayed).Append("\n");
            sb.Append("  RedPowerupTimeRemaining: ").Append(RedPowerupTimeRemaining).Append("\n");
            sb.Append("  RedScaleOwned: ").Append(RedScaleOwned).Append("\n");
            sb.Append("  RedScore: ").Append(RedScore).Append("\n");
            sb.Append("  RedSwitchOwned: ").Append(RedSwitchOwned).Append("\n");
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
            return this.Equals(input as MatchTimeseries2018);
        }

        /// <summary>
        /// Returns true if MatchTimeseries2018 instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchTimeseries2018 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchTimeseries2018 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventKey == input.EventKey ||
                    (this.EventKey != null &&
                    this.EventKey.Equals(input.EventKey))
                ) && 
                (
                    this.MatchId == input.MatchId ||
                    (this.MatchId != null &&
                    this.MatchId.Equals(input.MatchId))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Play == input.Play ||
                    (this.Play != null &&
                    this.Play.Equals(input.Play))
                ) && 
                (
                    this.TimeRemaining == input.TimeRemaining ||
                    (this.TimeRemaining != null &&
                    this.TimeRemaining.Equals(input.TimeRemaining))
                ) && 
                (
                    this.BlueAutoQuest == input.BlueAutoQuest ||
                    (this.BlueAutoQuest != null &&
                    this.BlueAutoQuest.Equals(input.BlueAutoQuest))
                ) && 
                (
                    this.BlueBoostCount == input.BlueBoostCount ||
                    (this.BlueBoostCount != null &&
                    this.BlueBoostCount.Equals(input.BlueBoostCount))
                ) && 
                (
                    this.BlueBoostPlayed == input.BlueBoostPlayed ||
                    (this.BlueBoostPlayed != null &&
                    this.BlueBoostPlayed.Equals(input.BlueBoostPlayed))
                ) && 
                (
                    this.BlueCurrentPowerup == input.BlueCurrentPowerup ||
                    (this.BlueCurrentPowerup != null &&
                    this.BlueCurrentPowerup.Equals(input.BlueCurrentPowerup))
                ) && 
                (
                    this.BlueFaceTheBoss == input.BlueFaceTheBoss ||
                    (this.BlueFaceTheBoss != null &&
                    this.BlueFaceTheBoss.Equals(input.BlueFaceTheBoss))
                ) && 
                (
                    this.BlueForceCount == input.BlueForceCount ||
                    (this.BlueForceCount != null &&
                    this.BlueForceCount.Equals(input.BlueForceCount))
                ) && 
                (
                    this.BlueForcePlayed == input.BlueForcePlayed ||
                    (this.BlueForcePlayed != null &&
                    this.BlueForcePlayed.Equals(input.BlueForcePlayed))
                ) && 
                (
                    this.BlueLevitateCount == input.BlueLevitateCount ||
                    (this.BlueLevitateCount != null &&
                    this.BlueLevitateCount.Equals(input.BlueLevitateCount))
                ) && 
                (
                    this.BlueLevitatePlayed == input.BlueLevitatePlayed ||
                    (this.BlueLevitatePlayed != null &&
                    this.BlueLevitatePlayed.Equals(input.BlueLevitatePlayed))
                ) && 
                (
                    this.BluePowerupTimeRemaining == input.BluePowerupTimeRemaining ||
                    (this.BluePowerupTimeRemaining != null &&
                    this.BluePowerupTimeRemaining.Equals(input.BluePowerupTimeRemaining))
                ) && 
                (
                    this.BlueScaleOwned == input.BlueScaleOwned ||
                    (this.BlueScaleOwned != null &&
                    this.BlueScaleOwned.Equals(input.BlueScaleOwned))
                ) && 
                (
                    this.BlueScore == input.BlueScore ||
                    (this.BlueScore != null &&
                    this.BlueScore.Equals(input.BlueScore))
                ) && 
                (
                    this.BlueSwitchOwned == input.BlueSwitchOwned ||
                    (this.BlueSwitchOwned != null &&
                    this.BlueSwitchOwned.Equals(input.BlueSwitchOwned))
                ) && 
                (
                    this.RedAutoQuest == input.RedAutoQuest ||
                    (this.RedAutoQuest != null &&
                    this.RedAutoQuest.Equals(input.RedAutoQuest))
                ) && 
                (
                    this.RedBoostCount == input.RedBoostCount ||
                    (this.RedBoostCount != null &&
                    this.RedBoostCount.Equals(input.RedBoostCount))
                ) && 
                (
                    this.RedBoostPlayed == input.RedBoostPlayed ||
                    (this.RedBoostPlayed != null &&
                    this.RedBoostPlayed.Equals(input.RedBoostPlayed))
                ) && 
                (
                    this.RedCurrentPowerup == input.RedCurrentPowerup ||
                    (this.RedCurrentPowerup != null &&
                    this.RedCurrentPowerup.Equals(input.RedCurrentPowerup))
                ) && 
                (
                    this.RedFaceTheBoss == input.RedFaceTheBoss ||
                    (this.RedFaceTheBoss != null &&
                    this.RedFaceTheBoss.Equals(input.RedFaceTheBoss))
                ) && 
                (
                    this.RedForceCount == input.RedForceCount ||
                    (this.RedForceCount != null &&
                    this.RedForceCount.Equals(input.RedForceCount))
                ) && 
                (
                    this.RedForcePlayed == input.RedForcePlayed ||
                    (this.RedForcePlayed != null &&
                    this.RedForcePlayed.Equals(input.RedForcePlayed))
                ) && 
                (
                    this.RedLevitateCount == input.RedLevitateCount ||
                    (this.RedLevitateCount != null &&
                    this.RedLevitateCount.Equals(input.RedLevitateCount))
                ) && 
                (
                    this.RedLevitatePlayed == input.RedLevitatePlayed ||
                    (this.RedLevitatePlayed != null &&
                    this.RedLevitatePlayed.Equals(input.RedLevitatePlayed))
                ) && 
                (
                    this.RedPowerupTimeRemaining == input.RedPowerupTimeRemaining ||
                    (this.RedPowerupTimeRemaining != null &&
                    this.RedPowerupTimeRemaining.Equals(input.RedPowerupTimeRemaining))
                ) && 
                (
                    this.RedScaleOwned == input.RedScaleOwned ||
                    (this.RedScaleOwned != null &&
                    this.RedScaleOwned.Equals(input.RedScaleOwned))
                ) && 
                (
                    this.RedScore == input.RedScore ||
                    (this.RedScore != null &&
                    this.RedScore.Equals(input.RedScore))
                ) && 
                (
                    this.RedSwitchOwned == input.RedSwitchOwned ||
                    (this.RedSwitchOwned != null &&
                    this.RedSwitchOwned.Equals(input.RedSwitchOwned))
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
                if (this.EventKey != null)
                    hashCode = hashCode * 59 + this.EventKey.GetHashCode();
                if (this.MatchId != null)
                    hashCode = hashCode * 59 + this.MatchId.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Play != null)
                    hashCode = hashCode * 59 + this.Play.GetHashCode();
                if (this.TimeRemaining != null)
                    hashCode = hashCode * 59 + this.TimeRemaining.GetHashCode();
                if (this.BlueAutoQuest != null)
                    hashCode = hashCode * 59 + this.BlueAutoQuest.GetHashCode();
                if (this.BlueBoostCount != null)
                    hashCode = hashCode * 59 + this.BlueBoostCount.GetHashCode();
                if (this.BlueBoostPlayed != null)
                    hashCode = hashCode * 59 + this.BlueBoostPlayed.GetHashCode();
                if (this.BlueCurrentPowerup != null)
                    hashCode = hashCode * 59 + this.BlueCurrentPowerup.GetHashCode();
                if (this.BlueFaceTheBoss != null)
                    hashCode = hashCode * 59 + this.BlueFaceTheBoss.GetHashCode();
                if (this.BlueForceCount != null)
                    hashCode = hashCode * 59 + this.BlueForceCount.GetHashCode();
                if (this.BlueForcePlayed != null)
                    hashCode = hashCode * 59 + this.BlueForcePlayed.GetHashCode();
                if (this.BlueLevitateCount != null)
                    hashCode = hashCode * 59 + this.BlueLevitateCount.GetHashCode();
                if (this.BlueLevitatePlayed != null)
                    hashCode = hashCode * 59 + this.BlueLevitatePlayed.GetHashCode();
                if (this.BluePowerupTimeRemaining != null)
                    hashCode = hashCode * 59 + this.BluePowerupTimeRemaining.GetHashCode();
                if (this.BlueScaleOwned != null)
                    hashCode = hashCode * 59 + this.BlueScaleOwned.GetHashCode();
                if (this.BlueScore != null)
                    hashCode = hashCode * 59 + this.BlueScore.GetHashCode();
                if (this.BlueSwitchOwned != null)
                    hashCode = hashCode * 59 + this.BlueSwitchOwned.GetHashCode();
                if (this.RedAutoQuest != null)
                    hashCode = hashCode * 59 + this.RedAutoQuest.GetHashCode();
                if (this.RedBoostCount != null)
                    hashCode = hashCode * 59 + this.RedBoostCount.GetHashCode();
                if (this.RedBoostPlayed != null)
                    hashCode = hashCode * 59 + this.RedBoostPlayed.GetHashCode();
                if (this.RedCurrentPowerup != null)
                    hashCode = hashCode * 59 + this.RedCurrentPowerup.GetHashCode();
                if (this.RedFaceTheBoss != null)
                    hashCode = hashCode * 59 + this.RedFaceTheBoss.GetHashCode();
                if (this.RedForceCount != null)
                    hashCode = hashCode * 59 + this.RedForceCount.GetHashCode();
                if (this.RedForcePlayed != null)
                    hashCode = hashCode * 59 + this.RedForcePlayed.GetHashCode();
                if (this.RedLevitateCount != null)
                    hashCode = hashCode * 59 + this.RedLevitateCount.GetHashCode();
                if (this.RedLevitatePlayed != null)
                    hashCode = hashCode * 59 + this.RedLevitatePlayed.GetHashCode();
                if (this.RedPowerupTimeRemaining != null)
                    hashCode = hashCode * 59 + this.RedPowerupTimeRemaining.GetHashCode();
                if (this.RedScaleOwned != null)
                    hashCode = hashCode * 59 + this.RedScaleOwned.GetHashCode();
                if (this.RedScore != null)
                    hashCode = hashCode * 59 + this.RedScore.GetHashCode();
                if (this.RedSwitchOwned != null)
                    hashCode = hashCode * 59 + this.RedSwitchOwned.GetHashCode();
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
