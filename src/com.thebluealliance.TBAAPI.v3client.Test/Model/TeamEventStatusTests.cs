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
    ///  Class for testing TeamEventStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TeamEventStatusTests
    {
        // TODO uncomment below to declare an instance variable for TeamEventStatus
        //private TeamEventStatus instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TeamEventStatus
            //instance = new TeamEventStatus();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TeamEventStatus
        /// </summary>
        [Test]
        public void TeamEventStatusInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" TeamEventStatus
            //Assert.IsInstanceOf(typeof(TeamEventStatus), instance);
        }


        /// <summary>
        /// Test the property 'Qual'
        /// </summary>
        [Test]
        public void QualTest()
        {
            // TODO unit test for the property 'Qual'
        }
        /// <summary>
        /// Test the property 'Alliance'
        /// </summary>
        [Test]
        public void AllianceTest()
        {
            // TODO unit test for the property 'Alliance'
        }
        /// <summary>
        /// Test the property 'Playoff'
        /// </summary>
        [Test]
        public void PlayoffTest()
        {
            // TODO unit test for the property 'Playoff'
        }
        /// <summary>
        /// Test the property 'AllianceStatusStr'
        /// </summary>
        [Test]
        public void AllianceStatusStrTest()
        {
            // TODO unit test for the property 'AllianceStatusStr'
        }
        /// <summary>
        /// Test the property 'PlayoffStatusStr'
        /// </summary>
        [Test]
        public void PlayoffStatusStrTest()
        {
            // TODO unit test for the property 'PlayoffStatusStr'
        }
        /// <summary>
        /// Test the property 'OverallStatusStr'
        /// </summary>
        [Test]
        public void OverallStatusStrTest()
        {
            // TODO unit test for the property 'OverallStatusStr'
        }
        /// <summary>
        /// Test the property 'NextMatchKey'
        /// </summary>
        [Test]
        public void NextMatchKeyTest()
        {
            // TODO unit test for the property 'NextMatchKey'
        }
        /// <summary>
        /// Test the property 'LastMatchKey'
        /// </summary>
        [Test]
        public void LastMatchKeyTest()
        {
            // TODO unit test for the property 'LastMatchKey'
        }

    }

}
