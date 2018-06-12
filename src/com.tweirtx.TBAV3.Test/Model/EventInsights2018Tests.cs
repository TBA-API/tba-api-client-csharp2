/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * OpenAPI spec version: 3.03.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Model;
using com.tweirtx.TBAV3.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace com.tweirtx.TBAV3.Test
{
    /// <summary>
    ///  Class for testing EventInsights2018
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class EventInsights2018Tests
    {
        // TODO uncomment below to declare an instance variable for EventInsights2018
        //private EventInsights2018 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of EventInsights2018
            //instance = new EventInsights2018();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EventInsights2018
        /// </summary>
        [Test]
        public void EventInsights2018InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" EventInsights2018
            //Assert.IsInstanceOfType<EventInsights2018> (instance, "variable 'instance' is a EventInsights2018");
        }


        /// <summary>
        /// Test the property 'AutoQuestAchieved'
        /// </summary>
        [Test]
        public void AutoQuestAchievedTest()
        {
            // TODO unit test for the property 'AutoQuestAchieved'
        }
        /// <summary>
        /// Test the property 'AverageBoostPlayed'
        /// </summary>
        [Test]
        public void AverageBoostPlayedTest()
        {
            // TODO unit test for the property 'AverageBoostPlayed'
        }
        /// <summary>
        /// Test the property 'AverageEndgamePoints'
        /// </summary>
        [Test]
        public void AverageEndgamePointsTest()
        {
            // TODO unit test for the property 'AverageEndgamePoints'
        }
        /// <summary>
        /// Test the property 'AverageForcePlayed'
        /// </summary>
        [Test]
        public void AverageForcePlayedTest()
        {
            // TODO unit test for the property 'AverageForcePlayed'
        }
        /// <summary>
        /// Test the property 'AverageFoulScore'
        /// </summary>
        [Test]
        public void AverageFoulScoreTest()
        {
            // TODO unit test for the property 'AverageFoulScore'
        }
        /// <summary>
        /// Test the property 'AveragePointsAuto'
        /// </summary>
        [Test]
        public void AveragePointsAutoTest()
        {
            // TODO unit test for the property 'AveragePointsAuto'
        }
        /// <summary>
        /// Test the property 'AveragePointsTeleop'
        /// </summary>
        [Test]
        public void AveragePointsTeleopTest()
        {
            // TODO unit test for the property 'AveragePointsTeleop'
        }
        /// <summary>
        /// Test the property 'AverageRunPointsAuto'
        /// </summary>
        [Test]
        public void AverageRunPointsAutoTest()
        {
            // TODO unit test for the property 'AverageRunPointsAuto'
        }
        /// <summary>
        /// Test the property 'AverageScaleOwnershipPoints'
        /// </summary>
        [Test]
        public void AverageScaleOwnershipPointsTest()
        {
            // TODO unit test for the property 'AverageScaleOwnershipPoints'
        }
        /// <summary>
        /// Test the property 'AverageScaleOwnershipPointsAuto'
        /// </summary>
        [Test]
        public void AverageScaleOwnershipPointsAutoTest()
        {
            // TODO unit test for the property 'AverageScaleOwnershipPointsAuto'
        }
        /// <summary>
        /// Test the property 'AverageScaleOwnershipPointsTeleop'
        /// </summary>
        [Test]
        public void AverageScaleOwnershipPointsTeleopTest()
        {
            // TODO unit test for the property 'AverageScaleOwnershipPointsTeleop'
        }
        /// <summary>
        /// Test the property 'AverageScore'
        /// </summary>
        [Test]
        public void AverageScoreTest()
        {
            // TODO unit test for the property 'AverageScore'
        }
        /// <summary>
        /// Test the property 'AverageSwitchOwnershipPoints'
        /// </summary>
        [Test]
        public void AverageSwitchOwnershipPointsTest()
        {
            // TODO unit test for the property 'AverageSwitchOwnershipPoints'
        }
        /// <summary>
        /// Test the property 'AverageSwitchOwnershipPointsAuto'
        /// </summary>
        [Test]
        public void AverageSwitchOwnershipPointsAutoTest()
        {
            // TODO unit test for the property 'AverageSwitchOwnershipPointsAuto'
        }
        /// <summary>
        /// Test the property 'AverageSwitchOwnershipPointsTeleop'
        /// </summary>
        [Test]
        public void AverageSwitchOwnershipPointsTeleopTest()
        {
            // TODO unit test for the property 'AverageSwitchOwnershipPointsTeleop'
        }
        /// <summary>
        /// Test the property 'AverageVaultPoints'
        /// </summary>
        [Test]
        public void AverageVaultPointsTest()
        {
            // TODO unit test for the property 'AverageVaultPoints'
        }
        /// <summary>
        /// Test the property 'AverageWinMargin'
        /// </summary>
        [Test]
        public void AverageWinMarginTest()
        {
            // TODO unit test for the property 'AverageWinMargin'
        }
        /// <summary>
        /// Test the property 'AverageWinScore'
        /// </summary>
        [Test]
        public void AverageWinScoreTest()
        {
            // TODO unit test for the property 'AverageWinScore'
        }
        /// <summary>
        /// Test the property 'BoostPlayedCounts'
        /// </summary>
        [Test]
        public void BoostPlayedCountsTest()
        {
            // TODO unit test for the property 'BoostPlayedCounts'
        }
        /// <summary>
        /// Test the property 'ClimbCounts'
        /// </summary>
        [Test]
        public void ClimbCountsTest()
        {
            // TODO unit test for the property 'ClimbCounts'
        }
        /// <summary>
        /// Test the property 'FaceTheBossAchieved'
        /// </summary>
        [Test]
        public void FaceTheBossAchievedTest()
        {
            // TODO unit test for the property 'FaceTheBossAchieved'
        }
        /// <summary>
        /// Test the property 'ForcePlayedCounts'
        /// </summary>
        [Test]
        public void ForcePlayedCountsTest()
        {
            // TODO unit test for the property 'ForcePlayedCounts'
        }
        /// <summary>
        /// Test the property 'HighScore'
        /// </summary>
        [Test]
        public void HighScoreTest()
        {
            // TODO unit test for the property 'HighScore'
        }
        /// <summary>
        /// Test the property 'LevitatePlayedCounts'
        /// </summary>
        [Test]
        public void LevitatePlayedCountsTest()
        {
            // TODO unit test for the property 'LevitatePlayedCounts'
        }
        /// <summary>
        /// Test the property 'RunCountsAuto'
        /// </summary>
        [Test]
        public void RunCountsAutoTest()
        {
            // TODO unit test for the property 'RunCountsAuto'
        }
        /// <summary>
        /// Test the property 'ScaleNeutralPercentage'
        /// </summary>
        [Test]
        public void ScaleNeutralPercentageTest()
        {
            // TODO unit test for the property 'ScaleNeutralPercentage'
        }
        /// <summary>
        /// Test the property 'ScaleNeutralPercentageAuto'
        /// </summary>
        [Test]
        public void ScaleNeutralPercentageAutoTest()
        {
            // TODO unit test for the property 'ScaleNeutralPercentageAuto'
        }
        /// <summary>
        /// Test the property 'ScaleNeutralPercentageTeleop'
        /// </summary>
        [Test]
        public void ScaleNeutralPercentageTeleopTest()
        {
            // TODO unit test for the property 'ScaleNeutralPercentageTeleop'
        }
        /// <summary>
        /// Test the property 'SwitchOwnedCountsAuto'
        /// </summary>
        [Test]
        public void SwitchOwnedCountsAutoTest()
        {
            // TODO unit test for the property 'SwitchOwnedCountsAuto'
        }
        /// <summary>
        /// Test the property 'UnicornMatches'
        /// </summary>
        [Test]
        public void UnicornMatchesTest()
        {
            // TODO unit test for the property 'UnicornMatches'
        }
        /// <summary>
        /// Test the property 'WinningOppSwitchDenialPercentageTeleop'
        /// </summary>
        [Test]
        public void WinningOppSwitchDenialPercentageTeleopTest()
        {
            // TODO unit test for the property 'WinningOppSwitchDenialPercentageTeleop'
        }
        /// <summary>
        /// Test the property 'WinningOwnSwitchOwnershipPercentage'
        /// </summary>
        [Test]
        public void WinningOwnSwitchOwnershipPercentageTest()
        {
            // TODO unit test for the property 'WinningOwnSwitchOwnershipPercentage'
        }
        /// <summary>
        /// Test the property 'WinningOwnSwitchOwnershipPercentageAuto'
        /// </summary>
        [Test]
        public void WinningOwnSwitchOwnershipPercentageAutoTest()
        {
            // TODO unit test for the property 'WinningOwnSwitchOwnershipPercentageAuto'
        }
        /// <summary>
        /// Test the property 'WinningOwnSwitchOwnershipPercentageTeleop'
        /// </summary>
        [Test]
        public void WinningOwnSwitchOwnershipPercentageTeleopTest()
        {
            // TODO unit test for the property 'WinningOwnSwitchOwnershipPercentageTeleop'
        }
        /// <summary>
        /// Test the property 'WinningScaleOwnershipPercentage'
        /// </summary>
        [Test]
        public void WinningScaleOwnershipPercentageTest()
        {
            // TODO unit test for the property 'WinningScaleOwnershipPercentage'
        }
        /// <summary>
        /// Test the property 'WinningScaleOwnershipPercentageAuto'
        /// </summary>
        [Test]
        public void WinningScaleOwnershipPercentageAutoTest()
        {
            // TODO unit test for the property 'WinningScaleOwnershipPercentageAuto'
        }
        /// <summary>
        /// Test the property 'WinningScaleOwnershipPercentageTeleop'
        /// </summary>
        [Test]
        public void WinningScaleOwnershipPercentageTeleopTest()
        {
            // TODO unit test for the property 'WinningScaleOwnershipPercentageTeleop'
        }

    }

}
