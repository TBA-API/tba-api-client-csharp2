/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.8.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using com.thebluealliance.TBAAPI.v3client.Api;
using com.thebluealliance.TBAAPI.v3client.Model;
using com.thebluealliance.TBAAPI.v3client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace com.thebluealliance.TBAAPI.v3client.Test
{
    /// <summary>
    ///  Class for testing MatchScoreBreakdown2019Alliance
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MatchScoreBreakdown2019AllianceTests
    {
        // TODO uncomment below to declare an instance variable for MatchScoreBreakdown2019Alliance
        //private MatchScoreBreakdown2019Alliance instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MatchScoreBreakdown2019Alliance
            //instance = new MatchScoreBreakdown2019Alliance();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MatchScoreBreakdown2019Alliance
        /// </summary>
        [Test]
        public void MatchScoreBreakdown2019AllianceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" MatchScoreBreakdown2019Alliance
            //Assert.IsInstanceOf(typeof(MatchScoreBreakdown2019Alliance), instance);
        }


        /// <summary>
        /// Test the property 'AdjustPoints'
        /// </summary>
        [Test]
        public void AdjustPointsTest()
        {
            // TODO unit test for the property 'AdjustPoints'
        }
        /// <summary>
        /// Test the property 'AutoPoints'
        /// </summary>
        [Test]
        public void AutoPointsTest()
        {
            // TODO unit test for the property 'AutoPoints'
        }
        /// <summary>
        /// Test the property 'Bay1'
        /// </summary>
        [Test]
        public void Bay1Test()
        {
            // TODO unit test for the property 'Bay1'
        }
        /// <summary>
        /// Test the property 'Bay2'
        /// </summary>
        [Test]
        public void Bay2Test()
        {
            // TODO unit test for the property 'Bay2'
        }
        /// <summary>
        /// Test the property 'Bay3'
        /// </summary>
        [Test]
        public void Bay3Test()
        {
            // TODO unit test for the property 'Bay3'
        }
        /// <summary>
        /// Test the property 'Bay4'
        /// </summary>
        [Test]
        public void Bay4Test()
        {
            // TODO unit test for the property 'Bay4'
        }
        /// <summary>
        /// Test the property 'Bay5'
        /// </summary>
        [Test]
        public void Bay5Test()
        {
            // TODO unit test for the property 'Bay5'
        }
        /// <summary>
        /// Test the property 'Bay6'
        /// </summary>
        [Test]
        public void Bay6Test()
        {
            // TODO unit test for the property 'Bay6'
        }
        /// <summary>
        /// Test the property 'Bay7'
        /// </summary>
        [Test]
        public void Bay7Test()
        {
            // TODO unit test for the property 'Bay7'
        }
        /// <summary>
        /// Test the property 'Bay8'
        /// </summary>
        [Test]
        public void Bay8Test()
        {
            // TODO unit test for the property 'Bay8'
        }
        /// <summary>
        /// Test the property 'CargoPoints'
        /// </summary>
        [Test]
        public void CargoPointsTest()
        {
            // TODO unit test for the property 'CargoPoints'
        }
        /// <summary>
        /// Test the property 'CompleteRocketRankingPoint'
        /// </summary>
        [Test]
        public void CompleteRocketRankingPointTest()
        {
            // TODO unit test for the property 'CompleteRocketRankingPoint'
        }
        /// <summary>
        /// Test the property 'CompletedRocketFar'
        /// </summary>
        [Test]
        public void CompletedRocketFarTest()
        {
            // TODO unit test for the property 'CompletedRocketFar'
        }
        /// <summary>
        /// Test the property 'CompletedRocketNear'
        /// </summary>
        [Test]
        public void CompletedRocketNearTest()
        {
            // TODO unit test for the property 'CompletedRocketNear'
        }
        /// <summary>
        /// Test the property 'EndgameRobot1'
        /// </summary>
        [Test]
        public void EndgameRobot1Test()
        {
            // TODO unit test for the property 'EndgameRobot1'
        }
        /// <summary>
        /// Test the property 'EndgameRobot2'
        /// </summary>
        [Test]
        public void EndgameRobot2Test()
        {
            // TODO unit test for the property 'EndgameRobot2'
        }
        /// <summary>
        /// Test the property 'EndgameRobot3'
        /// </summary>
        [Test]
        public void EndgameRobot3Test()
        {
            // TODO unit test for the property 'EndgameRobot3'
        }
        /// <summary>
        /// Test the property 'FoulCount'
        /// </summary>
        [Test]
        public void FoulCountTest()
        {
            // TODO unit test for the property 'FoulCount'
        }
        /// <summary>
        /// Test the property 'FoulPoints'
        /// </summary>
        [Test]
        public void FoulPointsTest()
        {
            // TODO unit test for the property 'FoulPoints'
        }
        /// <summary>
        /// Test the property 'HabClimbPoints'
        /// </summary>
        [Test]
        public void HabClimbPointsTest()
        {
            // TODO unit test for the property 'HabClimbPoints'
        }
        /// <summary>
        /// Test the property 'HabDockingRankingPoint'
        /// </summary>
        [Test]
        public void HabDockingRankingPointTest()
        {
            // TODO unit test for the property 'HabDockingRankingPoint'
        }
        /// <summary>
        /// Test the property 'HabLineRobot1'
        /// </summary>
        [Test]
        public void HabLineRobot1Test()
        {
            // TODO unit test for the property 'HabLineRobot1'
        }
        /// <summary>
        /// Test the property 'HabLineRobot2'
        /// </summary>
        [Test]
        public void HabLineRobot2Test()
        {
            // TODO unit test for the property 'HabLineRobot2'
        }
        /// <summary>
        /// Test the property 'HabLineRobot3'
        /// </summary>
        [Test]
        public void HabLineRobot3Test()
        {
            // TODO unit test for the property 'HabLineRobot3'
        }
        /// <summary>
        /// Test the property 'HatchPanelPoints'
        /// </summary>
        [Test]
        public void HatchPanelPointsTest()
        {
            // TODO unit test for the property 'HatchPanelPoints'
        }
        /// <summary>
        /// Test the property 'LowLeftRocketFar'
        /// </summary>
        [Test]
        public void LowLeftRocketFarTest()
        {
            // TODO unit test for the property 'LowLeftRocketFar'
        }
        /// <summary>
        /// Test the property 'LowLeftRocketNear'
        /// </summary>
        [Test]
        public void LowLeftRocketNearTest()
        {
            // TODO unit test for the property 'LowLeftRocketNear'
        }
        /// <summary>
        /// Test the property 'LowRightRocketFar'
        /// </summary>
        [Test]
        public void LowRightRocketFarTest()
        {
            // TODO unit test for the property 'LowRightRocketFar'
        }
        /// <summary>
        /// Test the property 'LowRightRocketNear'
        /// </summary>
        [Test]
        public void LowRightRocketNearTest()
        {
            // TODO unit test for the property 'LowRightRocketNear'
        }
        /// <summary>
        /// Test the property 'MidLeftRocketFar'
        /// </summary>
        [Test]
        public void MidLeftRocketFarTest()
        {
            // TODO unit test for the property 'MidLeftRocketFar'
        }
        /// <summary>
        /// Test the property 'MidLeftRocketNear'
        /// </summary>
        [Test]
        public void MidLeftRocketNearTest()
        {
            // TODO unit test for the property 'MidLeftRocketNear'
        }
        /// <summary>
        /// Test the property 'MidRightRocketFar'
        /// </summary>
        [Test]
        public void MidRightRocketFarTest()
        {
            // TODO unit test for the property 'MidRightRocketFar'
        }
        /// <summary>
        /// Test the property 'MidRightRocketNear'
        /// </summary>
        [Test]
        public void MidRightRocketNearTest()
        {
            // TODO unit test for the property 'MidRightRocketNear'
        }
        /// <summary>
        /// Test the property 'PreMatchBay1'
        /// </summary>
        [Test]
        public void PreMatchBay1Test()
        {
            // TODO unit test for the property 'PreMatchBay1'
        }
        /// <summary>
        /// Test the property 'PreMatchBay2'
        /// </summary>
        [Test]
        public void PreMatchBay2Test()
        {
            // TODO unit test for the property 'PreMatchBay2'
        }
        /// <summary>
        /// Test the property 'PreMatchBay3'
        /// </summary>
        [Test]
        public void PreMatchBay3Test()
        {
            // TODO unit test for the property 'PreMatchBay3'
        }
        /// <summary>
        /// Test the property 'PreMatchBay6'
        /// </summary>
        [Test]
        public void PreMatchBay6Test()
        {
            // TODO unit test for the property 'PreMatchBay6'
        }
        /// <summary>
        /// Test the property 'PreMatchBay7'
        /// </summary>
        [Test]
        public void PreMatchBay7Test()
        {
            // TODO unit test for the property 'PreMatchBay7'
        }
        /// <summary>
        /// Test the property 'PreMatchBay8'
        /// </summary>
        [Test]
        public void PreMatchBay8Test()
        {
            // TODO unit test for the property 'PreMatchBay8'
        }
        /// <summary>
        /// Test the property 'PreMatchLevelRobot1'
        /// </summary>
        [Test]
        public void PreMatchLevelRobot1Test()
        {
            // TODO unit test for the property 'PreMatchLevelRobot1'
        }
        /// <summary>
        /// Test the property 'PreMatchLevelRobot2'
        /// </summary>
        [Test]
        public void PreMatchLevelRobot2Test()
        {
            // TODO unit test for the property 'PreMatchLevelRobot2'
        }
        /// <summary>
        /// Test the property 'PreMatchLevelRobot3'
        /// </summary>
        [Test]
        public void PreMatchLevelRobot3Test()
        {
            // TODO unit test for the property 'PreMatchLevelRobot3'
        }
        /// <summary>
        /// Test the property 'Rp'
        /// </summary>
        [Test]
        public void RpTest()
        {
            // TODO unit test for the property 'Rp'
        }
        /// <summary>
        /// Test the property 'SandStormBonusPoints'
        /// </summary>
        [Test]
        public void SandStormBonusPointsTest()
        {
            // TODO unit test for the property 'SandStormBonusPoints'
        }
        /// <summary>
        /// Test the property 'TechFoulCount'
        /// </summary>
        [Test]
        public void TechFoulCountTest()
        {
            // TODO unit test for the property 'TechFoulCount'
        }
        /// <summary>
        /// Test the property 'TeleopPoints'
        /// </summary>
        [Test]
        public void TeleopPointsTest()
        {
            // TODO unit test for the property 'TeleopPoints'
        }
        /// <summary>
        /// Test the property 'TopLeftRocketFar'
        /// </summary>
        [Test]
        public void TopLeftRocketFarTest()
        {
            // TODO unit test for the property 'TopLeftRocketFar'
        }
        /// <summary>
        /// Test the property 'TopLeftRocketNear'
        /// </summary>
        [Test]
        public void TopLeftRocketNearTest()
        {
            // TODO unit test for the property 'TopLeftRocketNear'
        }
        /// <summary>
        /// Test the property 'TopRightRocketFar'
        /// </summary>
        [Test]
        public void TopRightRocketFarTest()
        {
            // TODO unit test for the property 'TopRightRocketFar'
        }
        /// <summary>
        /// Test the property 'TopRightRocketNear'
        /// </summary>
        [Test]
        public void TopRightRocketNearTest()
        {
            // TODO unit test for the property 'TopRightRocketNear'
        }
        /// <summary>
        /// Test the property 'TotalPoints'
        /// </summary>
        [Test]
        public void TotalPointsTest()
        {
            // TODO unit test for the property 'TotalPoints'
        }

    }

}
