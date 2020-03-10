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
using net.thefletcher.tbaapi.v3client.Api;
using net.thefletcher.tbaapi.v3client.Model;
using net.thefletcher.tbaapi.v3client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace net.thefletcher.tbaapi.v3client.Test
{
    /// <summary>
    ///  Class for testing MatchScoreBreakdown2016Alliance
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MatchScoreBreakdown2016AllianceTests
    {
        // TODO uncomment below to declare an instance variable for MatchScoreBreakdown2016Alliance
        //private MatchScoreBreakdown2016Alliance instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MatchScoreBreakdown2016Alliance
            //instance = new MatchScoreBreakdown2016Alliance();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MatchScoreBreakdown2016Alliance
        /// </summary>
        [Test]
        public void MatchScoreBreakdown2016AllianceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" MatchScoreBreakdown2016Alliance
            //Assert.IsInstanceOf(typeof(MatchScoreBreakdown2016Alliance), instance);
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
        /// Test the property 'TeleopPoints'
        /// </summary>
        [Test]
        public void TeleopPointsTest()
        {
            // TODO unit test for the property 'TeleopPoints'
        }
        /// <summary>
        /// Test the property 'BreachPoints'
        /// </summary>
        [Test]
        public void BreachPointsTest()
        {
            // TODO unit test for the property 'BreachPoints'
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
        /// Test the property 'CapturePoints'
        /// </summary>
        [Test]
        public void CapturePointsTest()
        {
            // TODO unit test for the property 'CapturePoints'
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
        /// Test the property 'TotalPoints'
        /// </summary>
        [Test]
        public void TotalPointsTest()
        {
            // TODO unit test for the property 'TotalPoints'
        }
        /// <summary>
        /// Test the property 'Robot1Auto'
        /// </summary>
        [Test]
        public void Robot1AutoTest()
        {
            // TODO unit test for the property 'Robot1Auto'
        }
        /// <summary>
        /// Test the property 'Robot2Auto'
        /// </summary>
        [Test]
        public void Robot2AutoTest()
        {
            // TODO unit test for the property 'Robot2Auto'
        }
        /// <summary>
        /// Test the property 'Robot3Auto'
        /// </summary>
        [Test]
        public void Robot3AutoTest()
        {
            // TODO unit test for the property 'Robot3Auto'
        }
        /// <summary>
        /// Test the property 'AutoReachPoints'
        /// </summary>
        [Test]
        public void AutoReachPointsTest()
        {
            // TODO unit test for the property 'AutoReachPoints'
        }
        /// <summary>
        /// Test the property 'AutoCrossingPoints'
        /// </summary>
        [Test]
        public void AutoCrossingPointsTest()
        {
            // TODO unit test for the property 'AutoCrossingPoints'
        }
        /// <summary>
        /// Test the property 'AutoBouldersLow'
        /// </summary>
        [Test]
        public void AutoBouldersLowTest()
        {
            // TODO unit test for the property 'AutoBouldersLow'
        }
        /// <summary>
        /// Test the property 'AutoBouldersHigh'
        /// </summary>
        [Test]
        public void AutoBouldersHighTest()
        {
            // TODO unit test for the property 'AutoBouldersHigh'
        }
        /// <summary>
        /// Test the property 'AutoBoulderPoints'
        /// </summary>
        [Test]
        public void AutoBoulderPointsTest()
        {
            // TODO unit test for the property 'AutoBoulderPoints'
        }
        /// <summary>
        /// Test the property 'TeleopCrossingPoints'
        /// </summary>
        [Test]
        public void TeleopCrossingPointsTest()
        {
            // TODO unit test for the property 'TeleopCrossingPoints'
        }
        /// <summary>
        /// Test the property 'TeleopBouldersLow'
        /// </summary>
        [Test]
        public void TeleopBouldersLowTest()
        {
            // TODO unit test for the property 'TeleopBouldersLow'
        }
        /// <summary>
        /// Test the property 'TeleopBouldersHigh'
        /// </summary>
        [Test]
        public void TeleopBouldersHighTest()
        {
            // TODO unit test for the property 'TeleopBouldersHigh'
        }
        /// <summary>
        /// Test the property 'TeleopBoulderPoints'
        /// </summary>
        [Test]
        public void TeleopBoulderPointsTest()
        {
            // TODO unit test for the property 'TeleopBoulderPoints'
        }
        /// <summary>
        /// Test the property 'TeleopDefensesBreached'
        /// </summary>
        [Test]
        public void TeleopDefensesBreachedTest()
        {
            // TODO unit test for the property 'TeleopDefensesBreached'
        }
        /// <summary>
        /// Test the property 'TeleopChallengePoints'
        /// </summary>
        [Test]
        public void TeleopChallengePointsTest()
        {
            // TODO unit test for the property 'TeleopChallengePoints'
        }
        /// <summary>
        /// Test the property 'TeleopScalePoints'
        /// </summary>
        [Test]
        public void TeleopScalePointsTest()
        {
            // TODO unit test for the property 'TeleopScalePoints'
        }
        /// <summary>
        /// Test the property 'TeleopTowerCaptured'
        /// </summary>
        [Test]
        public void TeleopTowerCapturedTest()
        {
            // TODO unit test for the property 'TeleopTowerCaptured'
        }
        /// <summary>
        /// Test the property 'TowerFaceA'
        /// </summary>
        [Test]
        public void TowerFaceATest()
        {
            // TODO unit test for the property 'TowerFaceA'
        }
        /// <summary>
        /// Test the property 'TowerFaceB'
        /// </summary>
        [Test]
        public void TowerFaceBTest()
        {
            // TODO unit test for the property 'TowerFaceB'
        }
        /// <summary>
        /// Test the property 'TowerFaceC'
        /// </summary>
        [Test]
        public void TowerFaceCTest()
        {
            // TODO unit test for the property 'TowerFaceC'
        }
        /// <summary>
        /// Test the property 'TowerEndStrength'
        /// </summary>
        [Test]
        public void TowerEndStrengthTest()
        {
            // TODO unit test for the property 'TowerEndStrength'
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
        /// Test the property 'FoulCount'
        /// </summary>
        [Test]
        public void FoulCountTest()
        {
            // TODO unit test for the property 'FoulCount'
        }
        /// <summary>
        /// Test the property 'Position2'
        /// </summary>
        [Test]
        public void Position2Test()
        {
            // TODO unit test for the property 'Position2'
        }
        /// <summary>
        /// Test the property 'Position3'
        /// </summary>
        [Test]
        public void Position3Test()
        {
            // TODO unit test for the property 'Position3'
        }
        /// <summary>
        /// Test the property 'Position4'
        /// </summary>
        [Test]
        public void Position4Test()
        {
            // TODO unit test for the property 'Position4'
        }
        /// <summary>
        /// Test the property 'Position5'
        /// </summary>
        [Test]
        public void Position5Test()
        {
            // TODO unit test for the property 'Position5'
        }
        /// <summary>
        /// Test the property 'Position1crossings'
        /// </summary>
        [Test]
        public void Position1crossingsTest()
        {
            // TODO unit test for the property 'Position1crossings'
        }
        /// <summary>
        /// Test the property 'Position2crossings'
        /// </summary>
        [Test]
        public void Position2crossingsTest()
        {
            // TODO unit test for the property 'Position2crossings'
        }
        /// <summary>
        /// Test the property 'Position3crossings'
        /// </summary>
        [Test]
        public void Position3crossingsTest()
        {
            // TODO unit test for the property 'Position3crossings'
        }
        /// <summary>
        /// Test the property 'Position4crossings'
        /// </summary>
        [Test]
        public void Position4crossingsTest()
        {
            // TODO unit test for the property 'Position4crossings'
        }
        /// <summary>
        /// Test the property 'Position5crossings'
        /// </summary>
        [Test]
        public void Position5crossingsTest()
        {
            // TODO unit test for the property 'Position5crossings'
        }

    }

}
