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
    ///  Class for testing MatchVideos
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MatchVideosTests
    {
        // TODO uncomment below to declare an instance variable for MatchVideos
        //private MatchVideos instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MatchVideos
            //instance = new MatchVideos();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MatchVideos
        /// </summary>
        [Test]
        public void MatchVideosInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MatchVideos
            //Assert.IsInstanceOfType<MatchVideos> (instance, "variable 'instance' is a MatchVideos");
        }


        /// <summary>
        /// Test the property 'Key'
        /// </summary>
        [Test]
        public void KeyTest()
        {
            // TODO unit test for the property 'Key'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }

    }

}
