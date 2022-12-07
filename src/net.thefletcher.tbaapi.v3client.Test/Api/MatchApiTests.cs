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
    ///  Class for testing MatchApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MatchApiTests
    {
        private MatchApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MatchApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MatchApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' MatchApi
            //Assert.IsInstanceOf(typeof(MatchApi), instance);
        }

        
        /// <summary>
        /// Test GetEventMatchTimeseries
        /// </summary>
        [Test]
        public void GetEventMatchTimeseriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventMatchTimeseries(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<string>), response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetEventMatches
        /// </summary>
        [Test]
        public void GetEventMatchesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventMatches(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<Match>), response, "response is List<Match>");
        }
        
        /// <summary>
        /// Test GetEventMatchesKeys
        /// </summary>
        [Test]
        public void GetEventMatchesKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventMatchesKeys(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<string>), response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetEventMatchesSimple
        /// </summary>
        [Test]
        public void GetEventMatchesSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventMatchesSimple(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<MatchSimple>), response, "response is List<MatchSimple>");
        }
        
        /// <summary>
        /// Test GetMatch
        /// </summary>
        [Test]
        public void GetMatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string matchKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetMatch(matchKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(Match), response, "response is Match");
        }
        
        /// <summary>
        /// Test GetMatchSimple
        /// </summary>
        [Test]
        public void GetMatchSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string matchKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetMatchSimple(matchKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(MatchSimple), response, "response is MatchSimple");
        }
        
        /// <summary>
        /// Test GetMatchTimeseries
        /// </summary>
        [Test]
        public void GetMatchTimeseriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string matchKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetMatchTimeseries(matchKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<Object>), response, "response is List<Object>");
        }
        
        /// <summary>
        /// Test GetMatchZebra
        /// </summary>
        [Test]
        public void GetMatchZebraTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string matchKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetMatchZebra(matchKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(Zebra), response, "response is Zebra");
        }
        
        /// <summary>
        /// Test GetTeamEventMatches
        /// </summary>
        [Test]
        public void GetTeamEventMatchesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventMatches(teamKey, eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<Match>), response, "response is List<Match>");
        }
        
        /// <summary>
        /// Test GetTeamEventMatchesKeys
        /// </summary>
        [Test]
        public void GetTeamEventMatchesKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventMatchesKeys(teamKey, eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<string>), response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetTeamEventMatchesSimple
        /// </summary>
        [Test]
        public void GetTeamEventMatchesSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventMatchesSimple(teamKey, eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<Match>), response, "response is List<Match>");
        }
        
        /// <summary>
        /// Test GetTeamMatchesByYear
        /// </summary>
        [Test]
        public void GetTeamMatchesByYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamMatchesByYear(teamKey, year, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<Match>), response, "response is List<Match>");
        }
        
        /// <summary>
        /// Test GetTeamMatchesByYearKeys
        /// </summary>
        [Test]
        public void GetTeamMatchesByYearKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamMatchesByYearKeys(teamKey, year, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<string>), response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetTeamMatchesByYearSimple
        /// </summary>
        [Test]
        public void GetTeamMatchesByYearSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamMatchesByYearSimple(teamKey, year, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<MatchSimple>), response, "response is List<MatchSimple>");
        }
        
    }

}