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
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Model;
using com.tweirtx.TBAV3.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace com.tweirtx.TBAV3.Test
{
    /// <summary>
    ///  Class for testing DistrictRanking
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DistrictRankingTests
    {
        // TODO uncomment below to declare an instance variable for DistrictRanking
        //private DistrictRanking instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DistrictRanking
            //instance = new DistrictRanking();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DistrictRanking
        /// </summary>
        [Test]
        public void DistrictRankingInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DistrictRanking
            //Assert.IsInstanceOfType<DistrictRanking> (instance, "variable 'instance' is a DistrictRanking");
        }


        /// <summary>
        /// Test the property 'TeamKey'
        /// </summary>
        [Test]
        public void TeamKeyTest()
        {
            // TODO unit test for the property 'TeamKey'
        }
        /// <summary>
        /// Test the property 'Rank'
        /// </summary>
        [Test]
        public void RankTest()
        {
            // TODO unit test for the property 'Rank'
        }
        /// <summary>
        /// Test the property 'RookieBonus'
        /// </summary>
        [Test]
        public void RookieBonusTest()
        {
            // TODO unit test for the property 'RookieBonus'
        }
        /// <summary>
        /// Test the property 'PointTotal'
        /// </summary>
        [Test]
        public void PointTotalTest()
        {
            // TODO unit test for the property 'PointTotal'
        }
        /// <summary>
        /// Test the property 'EventPoints'
        /// </summary>
        [Test]
        public void EventPointsTest()
        {
            // TODO unit test for the property 'EventPoints'
        }

    }

}
