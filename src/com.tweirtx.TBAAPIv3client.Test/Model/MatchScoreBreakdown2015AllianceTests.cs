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
    ///  Class for testing MatchScoreBreakdown2015Alliance
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MatchScoreBreakdown2015AllianceTests
    {
        // TODO uncomment below to declare an instance variable for MatchScoreBreakdown2015Alliance
        //private MatchScoreBreakdown2015Alliance instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MatchScoreBreakdown2015Alliance
            //instance = new MatchScoreBreakdown2015Alliance();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MatchScoreBreakdown2015Alliance
        /// </summary>
        [Test]
        public void MatchScoreBreakdown2015AllianceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MatchScoreBreakdown2015Alliance
            //Assert.IsInstanceOfType<MatchScoreBreakdown2015Alliance> (instance, "variable 'instance' is a MatchScoreBreakdown2015Alliance");
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
        /// Test the property 'ContainerPoints'
        /// </summary>
        [Test]
        public void ContainerPointsTest()
        {
            // TODO unit test for the property 'ContainerPoints'
        }
        /// <summary>
        /// Test the property 'TotePoints'
        /// </summary>
        [Test]
        public void TotePointsTest()
        {
            // TODO unit test for the property 'TotePoints'
        }
        /// <summary>
        /// Test the property 'LitterPoints'
        /// </summary>
        [Test]
        public void LitterPointsTest()
        {
            // TODO unit test for the property 'LitterPoints'
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
        /// Test the property 'FoulCount'
        /// </summary>
        [Test]
        public void FoulCountTest()
        {
            // TODO unit test for the property 'FoulCount'
        }
        /// <summary>
        /// Test the property 'ToteCountFar'
        /// </summary>
        [Test]
        public void ToteCountFarTest()
        {
            // TODO unit test for the property 'ToteCountFar'
        }
        /// <summary>
        /// Test the property 'ToteCountNear'
        /// </summary>
        [Test]
        public void ToteCountNearTest()
        {
            // TODO unit test for the property 'ToteCountNear'
        }
        /// <summary>
        /// Test the property 'ToteSet'
        /// </summary>
        [Test]
        public void ToteSetTest()
        {
            // TODO unit test for the property 'ToteSet'
        }
        /// <summary>
        /// Test the property 'ToteStack'
        /// </summary>
        [Test]
        public void ToteStackTest()
        {
            // TODO unit test for the property 'ToteStack'
        }
        /// <summary>
        /// Test the property 'ContainerCountLevel1'
        /// </summary>
        [Test]
        public void ContainerCountLevel1Test()
        {
            // TODO unit test for the property 'ContainerCountLevel1'
        }
        /// <summary>
        /// Test the property 'ContainerCountLevel2'
        /// </summary>
        [Test]
        public void ContainerCountLevel2Test()
        {
            // TODO unit test for the property 'ContainerCountLevel2'
        }
        /// <summary>
        /// Test the property 'ContainerCountLevel3'
        /// </summary>
        [Test]
        public void ContainerCountLevel3Test()
        {
            // TODO unit test for the property 'ContainerCountLevel3'
        }
        /// <summary>
        /// Test the property 'ContainerCountLevel4'
        /// </summary>
        [Test]
        public void ContainerCountLevel4Test()
        {
            // TODO unit test for the property 'ContainerCountLevel4'
        }
        /// <summary>
        /// Test the property 'ContainerCountLevel5'
        /// </summary>
        [Test]
        public void ContainerCountLevel5Test()
        {
            // TODO unit test for the property 'ContainerCountLevel5'
        }
        /// <summary>
        /// Test the property 'ContainerCountLevel6'
        /// </summary>
        [Test]
        public void ContainerCountLevel6Test()
        {
            // TODO unit test for the property 'ContainerCountLevel6'
        }
        /// <summary>
        /// Test the property 'ContainerSet'
        /// </summary>
        [Test]
        public void ContainerSetTest()
        {
            // TODO unit test for the property 'ContainerSet'
        }
        /// <summary>
        /// Test the property 'LitterCountContainer'
        /// </summary>
        [Test]
        public void LitterCountContainerTest()
        {
            // TODO unit test for the property 'LitterCountContainer'
        }
        /// <summary>
        /// Test the property 'LitterCountLandfill'
        /// </summary>
        [Test]
        public void LitterCountLandfillTest()
        {
            // TODO unit test for the property 'LitterCountLandfill'
        }
        /// <summary>
        /// Test the property 'LitterCountUnprocessed'
        /// </summary>
        [Test]
        public void LitterCountUnprocessedTest()
        {
            // TODO unit test for the property 'LitterCountUnprocessed'
        }
        /// <summary>
        /// Test the property 'RobotSet'
        /// </summary>
        [Test]
        public void RobotSetTest()
        {
            // TODO unit test for the property 'RobotSet'
        }

    }

}
