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
    ///  Class for testing MatchAlliance
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MatchAllianceTests
    {
        // TODO uncomment below to declare an instance variable for MatchAlliance
        //private MatchAlliance instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MatchAlliance
            //instance = new MatchAlliance();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MatchAlliance
        /// </summary>
        [Test]
        public void MatchAllianceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MatchAlliance
            //Assert.IsInstanceOfType<MatchAlliance> (instance, "variable 'instance' is a MatchAlliance");
        }


        /// <summary>
        /// Test the property 'Score'
        /// </summary>
        [Test]
        public void ScoreTest()
        {
            // TODO unit test for the property 'Score'
        }
        /// <summary>
        /// Test the property 'TeamKeys'
        /// </summary>
        [Test]
        public void TeamKeysTest()
        {
            // TODO unit test for the property 'TeamKeys'
        }
        /// <summary>
        /// Test the property 'SurrogateTeamKeys'
        /// </summary>
        [Test]
        public void SurrogateTeamKeysTest()
        {
            // TODO unit test for the property 'SurrogateTeamKeys'
        }
        /// <summary>
        /// Test the property 'DqTeamKeys'
        /// </summary>
        [Test]
        public void DqTeamKeysTest()
        {
            // TODO unit test for the property 'DqTeamKeys'
        }

    }

}
