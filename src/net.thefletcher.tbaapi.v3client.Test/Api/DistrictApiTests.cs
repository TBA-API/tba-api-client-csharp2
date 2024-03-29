/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.8.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using net.thefletcher.tbaapi.v3client.Client;
using net.thefletcher.tbaapi.v3client.Api;
using net.thefletcher.tbaapi.v3client.Model;

namespace net.thefletcher.tbaapi.v3client.Test
{
    /// <summary>
    ///  Class for testing DistrictApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DistrictApiTests
    {
        private DistrictApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DistrictApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DistrictApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' DistrictApi
            //Assert.IsInstanceOf(typeof(DistrictApi), instance);
        }

        
        /// <summary>
        /// Test GetDistrictEvents
        /// </summary>
        [Test]
        public void GetDistrictEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string districtKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictEvents(districtKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<Event>), response, "response is List<Event>");
        }
        
        /// <summary>
        /// Test GetDistrictEventsKeys
        /// </summary>
        [Test]
        public void GetDistrictEventsKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string districtKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictEventsKeys(districtKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<string>), response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetDistrictEventsSimple
        /// </summary>
        [Test]
        public void GetDistrictEventsSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string districtKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictEventsSimple(districtKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<EventSimple>), response, "response is List<EventSimple>");
        }
        
        /// <summary>
        /// Test GetDistrictRankings
        /// </summary>
        [Test]
        public void GetDistrictRankingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string districtKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictRankings(districtKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<DistrictRanking>), response, "response is List<DistrictRanking>");
        }
        
        /// <summary>
        /// Test GetDistrictTeams
        /// </summary>
        [Test]
        public void GetDistrictTeamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string districtKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictTeams(districtKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<Team>), response, "response is List<Team>");
        }
        
        /// <summary>
        /// Test GetDistrictTeamsKeys
        /// </summary>
        [Test]
        public void GetDistrictTeamsKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string districtKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictTeamsKeys(districtKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<string>), response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetDistrictTeamsSimple
        /// </summary>
        [Test]
        public void GetDistrictTeamsSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string districtKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictTeamsSimple(districtKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<TeamSimple>), response, "response is List<TeamSimple>");
        }
        
        /// <summary>
        /// Test GetDistrictsByYear
        /// </summary>
        [Test]
        public void GetDistrictsByYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictsByYear(year, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<DistrictList>), response, "response is List<DistrictList>");
        }
        
        /// <summary>
        /// Test GetEventDistrictPoints
        /// </summary>
        [Test]
        public void GetEventDistrictPointsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventDistrictPoints(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(EventDistrictPoints), response, "response is EventDistrictPoints");
        }
        
        /// <summary>
        /// Test GetTeamDistricts
        /// </summary>
        [Test]
        public void GetTeamDistrictsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamDistricts(teamKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<DistrictList>), response, "response is List<DistrictList>");
        }
        
    }

}
