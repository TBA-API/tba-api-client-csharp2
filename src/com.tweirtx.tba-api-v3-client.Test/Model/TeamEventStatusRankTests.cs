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
using com.tweirtx.tba-api-v3-client.Api;
using com.tweirtx.tba-api-v3-client.Model;
using com.tweirtx.tba-api-v3-client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace com.tweirtx.tba-api-v3-client.Test
{
    /// <summary>
    ///  Class for testing TeamEventStatusRank
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TeamEventStatusRankTests
    {
        // TODO uncomment below to declare an instance variable for TeamEventStatusRank
        //private TeamEventStatusRank instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TeamEventStatusRank
            //instance = new TeamEventStatusRank();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TeamEventStatusRank
        /// </summary>
        [Test]
        public void TeamEventStatusRankInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TeamEventStatusRank
            //Assert.IsInstanceOfType<TeamEventStatusRank> (instance, "variable 'instance' is a TeamEventStatusRank");
        }


        /// <summary>
        /// Test the property 'NumTeams'
        /// </summary>
        [Test]
        public void NumTeamsTest()
        {
            // TODO unit test for the property 'NumTeams'
        }
        /// <summary>
        /// Test the property 'Ranking'
        /// </summary>
        [Test]
        public void RankingTest()
        {
            // TODO unit test for the property 'Ranking'
        }
        /// <summary>
        /// Test the property 'SortOrderInfo'
        /// </summary>
        [Test]
        public void SortOrderInfoTest()
        {
            // TODO unit test for the property 'SortOrderInfo'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }

    }

}
