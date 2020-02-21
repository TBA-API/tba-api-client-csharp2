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
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Model;
using com.tweirtx.TBAAPIv3client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace com.tweirtx.TBAAPIv3client.Test
{
    /// <summary>
    ///  Class for testing MatchScoreBreakdown2020Alliance
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MatchScoreBreakdown2020AllianceTests
    {
        // TODO uncomment below to declare an instance variable for MatchScoreBreakdown2020Alliance
        //private MatchScoreBreakdown2020Alliance instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MatchScoreBreakdown2020Alliance
            //instance = new MatchScoreBreakdown2020Alliance();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MatchScoreBreakdown2020Alliance
        /// </summary>
        [Test]
        public void MatchScoreBreakdown2020AllianceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" MatchScoreBreakdown2020Alliance
            //Assert.IsInstanceOf(typeof(MatchScoreBreakdown2020Alliance), instance);
        }


        /// <summary>
        /// Test the property 'InitLineRobot1'
        /// </summary>
        [Test]
        public void InitLineRobot1Test()
        {
            // TODO unit test for the property 'InitLineRobot1'
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
        /// Test the property 'InitLineRobot2'
        /// </summary>
        [Test]
        public void InitLineRobot2Test()
        {
            // TODO unit test for the property 'InitLineRobot2'
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
        /// Test the property 'InitLineRobot3'
        /// </summary>
        [Test]
        public void InitLineRobot3Test()
        {
            // TODO unit test for the property 'InitLineRobot3'
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
        /// Test the property 'AutoCellsBottom'
        /// </summary>
        [Test]
        public void AutoCellsBottomTest()
        {
            // TODO unit test for the property 'AutoCellsBottom'
        }
        /// <summary>
        /// Test the property 'AutoCellsOuter'
        /// </summary>
        [Test]
        public void AutoCellsOuterTest()
        {
            // TODO unit test for the property 'AutoCellsOuter'
        }
        /// <summary>
        /// Test the property 'AutoCellsInner'
        /// </summary>
        [Test]
        public void AutoCellsInnerTest()
        {
            // TODO unit test for the property 'AutoCellsInner'
        }
        /// <summary>
        /// Test the property 'TeleopCellsBottom'
        /// </summary>
        [Test]
        public void TeleopCellsBottomTest()
        {
            // TODO unit test for the property 'TeleopCellsBottom'
        }
        /// <summary>
        /// Test the property 'TeleopCellsOuter'
        /// </summary>
        [Test]
        public void TeleopCellsOuterTest()
        {
            // TODO unit test for the property 'TeleopCellsOuter'
        }
        /// <summary>
        /// Test the property 'TeleopCellsInner'
        /// </summary>
        [Test]
        public void TeleopCellsInnerTest()
        {
            // TODO unit test for the property 'TeleopCellsInner'
        }
        /// <summary>
        /// Test the property 'Stage1Activated'
        /// </summary>
        [Test]
        public void Stage1ActivatedTest()
        {
            // TODO unit test for the property 'Stage1Activated'
        }
        /// <summary>
        /// Test the property 'Stage2Activated'
        /// </summary>
        [Test]
        public void Stage2ActivatedTest()
        {
            // TODO unit test for the property 'Stage2Activated'
        }
        /// <summary>
        /// Test the property 'Stage3Activated'
        /// </summary>
        [Test]
        public void Stage3ActivatedTest()
        {
            // TODO unit test for the property 'Stage3Activated'
        }
        /// <summary>
        /// Test the property 'Stage3TargetColor'
        /// </summary>
        [Test]
        public void Stage3TargetColorTest()
        {
            // TODO unit test for the property 'Stage3TargetColor'
        }
        /// <summary>
        /// Test the property 'EndgameRungIsLevel'
        /// </summary>
        [Test]
        public void EndgameRungIsLevelTest()
        {
            // TODO unit test for the property 'EndgameRungIsLevel'
        }
        /// <summary>
        /// Test the property 'AutoInitLinePoints'
        /// </summary>
        [Test]
        public void AutoInitLinePointsTest()
        {
            // TODO unit test for the property 'AutoInitLinePoints'
        }
        /// <summary>
        /// Test the property 'AutoCellPoints'
        /// </summary>
        [Test]
        public void AutoCellPointsTest()
        {
            // TODO unit test for the property 'AutoCellPoints'
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
        /// Test the property 'TeleopCellPoints'
        /// </summary>
        [Test]
        public void TeleopCellPointsTest()
        {
            // TODO unit test for the property 'TeleopCellPoints'
        }
        /// <summary>
        /// Test the property 'ControlPanelPoints'
        /// </summary>
        [Test]
        public void ControlPanelPointsTest()
        {
            // TODO unit test for the property 'ControlPanelPoints'
        }
        /// <summary>
        /// Test the property 'EndgamePoints'
        /// </summary>
        [Test]
        public void EndgamePointsTest()
        {
            // TODO unit test for the property 'EndgamePoints'
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
        /// Test the property 'ShieldOperationalRankingPoint'
        /// </summary>
        [Test]
        public void ShieldOperationalRankingPointTest()
        {
            // TODO unit test for the property 'ShieldOperationalRankingPoint'
        }
        /// <summary>
        /// Test the property 'ShieldEnergizedRankingPoint'
        /// </summary>
        [Test]
        public void ShieldEnergizedRankingPointTest()
        {
            // TODO unit test for the property 'ShieldEnergizedRankingPoint'
        }
        /// <summary>
        /// Test the property 'TbaShieldEnergizedRankingPointFromFoul'
        /// </summary>
        [Test]
        public void TbaShieldEnergizedRankingPointFromFoulTest()
        {
            // TODO unit test for the property 'TbaShieldEnergizedRankingPointFromFoul'
        }
        /// <summary>
        /// Test the property 'TbaNumRobotsHanging'
        /// </summary>
        [Test]
        public void TbaNumRobotsHangingTest()
        {
            // TODO unit test for the property 'TbaNumRobotsHanging'
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
        /// Test the property 'TechFoulCount'
        /// </summary>
        [Test]
        public void TechFoulCountTest()
        {
            // TODO unit test for the property 'TechFoulCount'
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
        /// Test the property 'FoulPoints'
        /// </summary>
        [Test]
        public void FoulPointsTest()
        {
            // TODO unit test for the property 'FoulPoints'
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
        /// Test the property 'TotalPoints'
        /// </summary>
        [Test]
        public void TotalPointsTest()
        {
            // TODO unit test for the property 'TotalPoints'
        }

    }

}
