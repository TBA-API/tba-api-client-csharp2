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
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Model;
using com.tweirtx.TBAAPIv3client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace com.tweirtx.TBAAPIv3client.Test
{
    /// <summary>
    ///  Class for testing EventInsights2016
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class EventInsights2016Tests
    {
        // TODO uncomment below to declare an instance variable for EventInsights2016
        //private EventInsights2016 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of EventInsights2016
            //instance = new EventInsights2016();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EventInsights2016
        /// </summary>
        [Test]
        public void EventInsights2016InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" EventInsights2016
            //Assert.IsInstanceOfType<EventInsights2016> (instance, "variable 'instance' is a EventInsights2016");
        }


        /// <summary>
        /// Test the property 'LowBar'
        /// </summary>
        [Test]
        public void LowBarTest()
        {
            // TODO unit test for the property 'LowBar'
        }
        /// <summary>
        /// Test the property 'AChevalDeFrise'
        /// </summary>
        [Test]
        public void AChevalDeFriseTest()
        {
            // TODO unit test for the property 'AChevalDeFrise'
        }
        /// <summary>
        /// Test the property 'APortcullis'
        /// </summary>
        [Test]
        public void APortcullisTest()
        {
            // TODO unit test for the property 'APortcullis'
        }
        /// <summary>
        /// Test the property 'BRamparts'
        /// </summary>
        [Test]
        public void BRampartsTest()
        {
            // TODO unit test for the property 'BRamparts'
        }
        /// <summary>
        /// Test the property 'BMoat'
        /// </summary>
        [Test]
        public void BMoatTest()
        {
            // TODO unit test for the property 'BMoat'
        }
        /// <summary>
        /// Test the property 'CSallyPort'
        /// </summary>
        [Test]
        public void CSallyPortTest()
        {
            // TODO unit test for the property 'CSallyPort'
        }
        /// <summary>
        /// Test the property 'CDrawbridge'
        /// </summary>
        [Test]
        public void CDrawbridgeTest()
        {
            // TODO unit test for the property 'CDrawbridge'
        }
        /// <summary>
        /// Test the property 'DRoughTerrain'
        /// </summary>
        [Test]
        public void DRoughTerrainTest()
        {
            // TODO unit test for the property 'DRoughTerrain'
        }
        /// <summary>
        /// Test the property 'DRockWall'
        /// </summary>
        [Test]
        public void DRockWallTest()
        {
            // TODO unit test for the property 'DRockWall'
        }
        /// <summary>
        /// Test the property 'AverageHighGoals'
        /// </summary>
        [Test]
        public void AverageHighGoalsTest()
        {
            // TODO unit test for the property 'AverageHighGoals'
        }
        /// <summary>
        /// Test the property 'AverageLowGoals'
        /// </summary>
        [Test]
        public void AverageLowGoalsTest()
        {
            // TODO unit test for the property 'AverageLowGoals'
        }
        /// <summary>
        /// Test the property 'Breaches'
        /// </summary>
        [Test]
        public void BreachesTest()
        {
            // TODO unit test for the property 'Breaches'
        }
        /// <summary>
        /// Test the property 'Scales'
        /// </summary>
        [Test]
        public void ScalesTest()
        {
            // TODO unit test for the property 'Scales'
        }
        /// <summary>
        /// Test the property 'Challenges'
        /// </summary>
        [Test]
        public void ChallengesTest()
        {
            // TODO unit test for the property 'Challenges'
        }
        /// <summary>
        /// Test the property 'Captures'
        /// </summary>
        [Test]
        public void CapturesTest()
        {
            // TODO unit test for the property 'Captures'
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
        /// Test the property 'AverageWinMargin'
        /// </summary>
        [Test]
        public void AverageWinMarginTest()
        {
            // TODO unit test for the property 'AverageWinMargin'
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
        /// Test the property 'AverageAutoScore'
        /// </summary>
        [Test]
        public void AverageAutoScoreTest()
        {
            // TODO unit test for the property 'AverageAutoScore'
        }
        /// <summary>
        /// Test the property 'AverageCrossingScore'
        /// </summary>
        [Test]
        public void AverageCrossingScoreTest()
        {
            // TODO unit test for the property 'AverageCrossingScore'
        }
        /// <summary>
        /// Test the property 'AverageBoulderScore'
        /// </summary>
        [Test]
        public void AverageBoulderScoreTest()
        {
            // TODO unit test for the property 'AverageBoulderScore'
        }
        /// <summary>
        /// Test the property 'AverageTowerScore'
        /// </summary>
        [Test]
        public void AverageTowerScoreTest()
        {
            // TODO unit test for the property 'AverageTowerScore'
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
        /// Test the property 'HighScore'
        /// </summary>
        [Test]
        public void HighScoreTest()
        {
            // TODO unit test for the property 'HighScore'
        }

    }

}