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
    ///  Class for testing MatchScoreBreakdown2017Alliance
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MatchScoreBreakdown2017AllianceTests
    {
        // TODO uncomment below to declare an instance variable for MatchScoreBreakdown2017Alliance
        //private MatchScoreBreakdown2017Alliance instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MatchScoreBreakdown2017Alliance
            //instance = new MatchScoreBreakdown2017Alliance();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MatchScoreBreakdown2017Alliance
        /// </summary>
        [Test]
        public void MatchScoreBreakdown2017AllianceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" MatchScoreBreakdown2017Alliance
            //Assert.IsInstanceOf(typeof(MatchScoreBreakdown2017Alliance), instance);
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
        /// Test the property 'FoulPoints'
        /// </summary>
        [Test]
        public void FoulPointsTest()
        {
            // TODO unit test for the property 'FoulPoints'
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
        /// Test the property 'Rotor1Auto'
        /// </summary>
        [Test]
        public void Rotor1AutoTest()
        {
            // TODO unit test for the property 'Rotor1Auto'
        }
        /// <summary>
        /// Test the property 'Rotor2Auto'
        /// </summary>
        [Test]
        public void Rotor2AutoTest()
        {
            // TODO unit test for the property 'Rotor2Auto'
        }
        /// <summary>
        /// Test the property 'AutoFuelLow'
        /// </summary>
        [Test]
        public void AutoFuelLowTest()
        {
            // TODO unit test for the property 'AutoFuelLow'
        }
        /// <summary>
        /// Test the property 'AutoFuelHigh'
        /// </summary>
        [Test]
        public void AutoFuelHighTest()
        {
            // TODO unit test for the property 'AutoFuelHigh'
        }
        /// <summary>
        /// Test the property 'AutoMobilityPoints'
        /// </summary>
        [Test]
        public void AutoMobilityPointsTest()
        {
            // TODO unit test for the property 'AutoMobilityPoints'
        }
        /// <summary>
        /// Test the property 'AutoRotorPoints'
        /// </summary>
        [Test]
        public void AutoRotorPointsTest()
        {
            // TODO unit test for the property 'AutoRotorPoints'
        }
        /// <summary>
        /// Test the property 'AutoFuelPoints'
        /// </summary>
        [Test]
        public void AutoFuelPointsTest()
        {
            // TODO unit test for the property 'AutoFuelPoints'
        }
        /// <summary>
        /// Test the property 'TeleopFuelPoints'
        /// </summary>
        [Test]
        public void TeleopFuelPointsTest()
        {
            // TODO unit test for the property 'TeleopFuelPoints'
        }
        /// <summary>
        /// Test the property 'TeleopFuelLow'
        /// </summary>
        [Test]
        public void TeleopFuelLowTest()
        {
            // TODO unit test for the property 'TeleopFuelLow'
        }
        /// <summary>
        /// Test the property 'TeleopFuelHigh'
        /// </summary>
        [Test]
        public void TeleopFuelHighTest()
        {
            // TODO unit test for the property 'TeleopFuelHigh'
        }
        /// <summary>
        /// Test the property 'TeleopRotorPoints'
        /// </summary>
        [Test]
        public void TeleopRotorPointsTest()
        {
            // TODO unit test for the property 'TeleopRotorPoints'
        }
        /// <summary>
        /// Test the property 'KPaRankingPointAchieved'
        /// </summary>
        [Test]
        public void KPaRankingPointAchievedTest()
        {
            // TODO unit test for the property 'KPaRankingPointAchieved'
        }
        /// <summary>
        /// Test the property 'TeleopTakeoffPoints'
        /// </summary>
        [Test]
        public void TeleopTakeoffPointsTest()
        {
            // TODO unit test for the property 'TeleopTakeoffPoints'
        }
        /// <summary>
        /// Test the property 'KPaBonusPoints'
        /// </summary>
        [Test]
        public void KPaBonusPointsTest()
        {
            // TODO unit test for the property 'KPaBonusPoints'
        }
        /// <summary>
        /// Test the property 'RotorBonusPoints'
        /// </summary>
        [Test]
        public void RotorBonusPointsTest()
        {
            // TODO unit test for the property 'RotorBonusPoints'
        }
        /// <summary>
        /// Test the property 'Rotor1Engaged'
        /// </summary>
        [Test]
        public void Rotor1EngagedTest()
        {
            // TODO unit test for the property 'Rotor1Engaged'
        }
        /// <summary>
        /// Test the property 'Rotor2Engaged'
        /// </summary>
        [Test]
        public void Rotor2EngagedTest()
        {
            // TODO unit test for the property 'Rotor2Engaged'
        }
        /// <summary>
        /// Test the property 'Rotor3Engaged'
        /// </summary>
        [Test]
        public void Rotor3EngagedTest()
        {
            // TODO unit test for the property 'Rotor3Engaged'
        }
        /// <summary>
        /// Test the property 'Rotor4Engaged'
        /// </summary>
        [Test]
        public void Rotor4EngagedTest()
        {
            // TODO unit test for the property 'Rotor4Engaged'
        }
        /// <summary>
        /// Test the property 'RotorRankingPointAchieved'
        /// </summary>
        [Test]
        public void RotorRankingPointAchievedTest()
        {
            // TODO unit test for the property 'RotorRankingPointAchieved'
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
        /// Test the property 'TouchpadNear'
        /// </summary>
        [Test]
        public void TouchpadNearTest()
        {
            // TODO unit test for the property 'TouchpadNear'
        }
        /// <summary>
        /// Test the property 'TouchpadMiddle'
        /// </summary>
        [Test]
        public void TouchpadMiddleTest()
        {
            // TODO unit test for the property 'TouchpadMiddle'
        }
        /// <summary>
        /// Test the property 'TouchpadFar'
        /// </summary>
        [Test]
        public void TouchpadFarTest()
        {
            // TODO unit test for the property 'TouchpadFar'
        }

    }

}
