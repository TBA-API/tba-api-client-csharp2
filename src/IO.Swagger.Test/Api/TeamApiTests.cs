/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * OpenAPI spec version: 3.03.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing TeamApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TeamApiTests
    {
        private TeamApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TeamApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TeamApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TeamApi
            //Assert.IsInstanceOfType(typeof(TeamApi), instance, "instance is a TeamApi");
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
            //Assert.IsInstanceOf<List<DistrictRanking>> (response, "response is List<DistrictRanking>");
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
            //Assert.IsInstanceOf<List<Team>> (response, "response is List<Team>");
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
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
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
            //Assert.IsInstanceOf<List<TeamSimple>> (response, "response is List<TeamSimple>");
        }
        
        /// <summary>
        /// Test GetEventTeams
        /// </summary>
        [Test]
        public void GetEventTeamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventTeams(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf<List<Team>> (response, "response is List<Team>");
        }
        
        /// <summary>
        /// Test GetEventTeamsKeys
        /// </summary>
        [Test]
        public void GetEventTeamsKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventTeamsKeys(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetEventTeamsSimple
        /// </summary>
        [Test]
        public void GetEventTeamsSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventTeamsSimple(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf<List<TeamSimple>> (response, "response is List<TeamSimple>");
        }
        
        /// <summary>
        /// Test GetEventTeamsStatuses
        /// </summary>
        [Test]
        public void GetEventTeamsStatusesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventTeamsStatuses(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf<Dictionary<string, TeamEventStatus>> (response, "response is Dictionary<string, TeamEventStatus>");
        }
        
        /// <summary>
        /// Test GetTeam
        /// </summary>
        [Test]
        public void GetTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeam(teamKey, ifModifiedSince);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test GetTeamAwards
        /// </summary>
        [Test]
        public void GetTeamAwardsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamAwards(teamKey, ifModifiedSince);
            //Assert.IsInstanceOf<List<Award>> (response, "response is List<Award>");
        }
        
        /// <summary>
        /// Test GetTeamAwardsByYear
        /// </summary>
        [Test]
        public void GetTeamAwardsByYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int? year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamAwardsByYear(teamKey, year, ifModifiedSince);
            //Assert.IsInstanceOf<List<Award>> (response, "response is List<Award>");
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
            //Assert.IsInstanceOf<List<DistrictList>> (response, "response is List<DistrictList>");
        }
        
        /// <summary>
        /// Test GetTeamEventAwards
        /// </summary>
        [Test]
        public void GetTeamEventAwardsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventAwards(teamKey, eventKey, ifModifiedSince);
            //Assert.IsInstanceOf<List<Award>> (response, "response is List<Award>");
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
            //Assert.IsInstanceOf<List<Match>> (response, "response is List<Match>");
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
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
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
            //Assert.IsInstanceOf<List<Match>> (response, "response is List<Match>");
        }
        
        /// <summary>
        /// Test GetTeamEventStatus
        /// </summary>
        [Test]
        public void GetTeamEventStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventStatus(teamKey, eventKey, ifModifiedSince);
            //Assert.IsInstanceOf<TeamEventStatus> (response, "response is TeamEventStatus");
        }
        
        /// <summary>
        /// Test GetTeamEvents
        /// </summary>
        [Test]
        public void GetTeamEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEvents(teamKey, ifModifiedSince);
            //Assert.IsInstanceOf<List<ModelEvent>> (response, "response is List<ModelEvent>");
        }
        
        /// <summary>
        /// Test GetTeamEventsByYear
        /// </summary>
        [Test]
        public void GetTeamEventsByYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int? year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventsByYear(teamKey, year, ifModifiedSince);
            //Assert.IsInstanceOf<List<ModelEvent>> (response, "response is List<ModelEvent>");
        }
        
        /// <summary>
        /// Test GetTeamEventsByYearKeys
        /// </summary>
        [Test]
        public void GetTeamEventsByYearKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int? year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventsByYearKeys(teamKey, year, ifModifiedSince);
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetTeamEventsByYearSimple
        /// </summary>
        [Test]
        public void GetTeamEventsByYearSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int? year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventsByYearSimple(teamKey, year, ifModifiedSince);
            //Assert.IsInstanceOf<List<EventSimple>> (response, "response is List<EventSimple>");
        }
        
        /// <summary>
        /// Test GetTeamEventsKeys
        /// </summary>
        [Test]
        public void GetTeamEventsKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventsKeys(teamKey, ifModifiedSince);
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetTeamEventsSimple
        /// </summary>
        [Test]
        public void GetTeamEventsSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventsSimple(teamKey, ifModifiedSince);
            //Assert.IsInstanceOf<List<EventSimple>> (response, "response is List<EventSimple>");
        }
        
        /// <summary>
        /// Test GetTeamEventsStatusesByYear
        /// </summary>
        [Test]
        public void GetTeamEventsStatusesByYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int? year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventsStatusesByYear(teamKey, year, ifModifiedSince);
            //Assert.IsInstanceOf<Dictionary<string, TeamEventStatus>> (response, "response is Dictionary<string, TeamEventStatus>");
        }
        
        /// <summary>
        /// Test GetTeamMatchesByYear
        /// </summary>
        [Test]
        public void GetTeamMatchesByYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int? year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamMatchesByYear(teamKey, year, ifModifiedSince);
            //Assert.IsInstanceOf<List<Match>> (response, "response is List<Match>");
        }
        
        /// <summary>
        /// Test GetTeamMatchesByYearKeys
        /// </summary>
        [Test]
        public void GetTeamMatchesByYearKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int? year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamMatchesByYearKeys(teamKey, year, ifModifiedSince);
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetTeamMatchesByYearSimple
        /// </summary>
        [Test]
        public void GetTeamMatchesByYearSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int? year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamMatchesByYearSimple(teamKey, year, ifModifiedSince);
            //Assert.IsInstanceOf<List<MatchSimple>> (response, "response is List<MatchSimple>");
        }
        
        /// <summary>
        /// Test GetTeamMediaByTag
        /// </summary>
        [Test]
        public void GetTeamMediaByTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string mediaTag = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamMediaByTag(teamKey, mediaTag, ifModifiedSince);
            //Assert.IsInstanceOf<List<Media>> (response, "response is List<Media>");
        }
        
        /// <summary>
        /// Test GetTeamMediaByTagYear
        /// </summary>
        [Test]
        public void GetTeamMediaByTagYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string mediaTag = null;
            //int? year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamMediaByTagYear(teamKey, mediaTag, year, ifModifiedSince);
            //Assert.IsInstanceOf<List<Media>> (response, "response is List<Media>");
        }
        
        /// <summary>
        /// Test GetTeamMediaByYear
        /// </summary>
        [Test]
        public void GetTeamMediaByYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int? year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamMediaByYear(teamKey, year, ifModifiedSince);
            //Assert.IsInstanceOf<List<Media>> (response, "response is List<Media>");
        }
        
        /// <summary>
        /// Test GetTeamRobots
        /// </summary>
        [Test]
        public void GetTeamRobotsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamRobots(teamKey, ifModifiedSince);
            //Assert.IsInstanceOf<List<TeamRobot>> (response, "response is List<TeamRobot>");
        }
        
        /// <summary>
        /// Test GetTeamSimple
        /// </summary>
        [Test]
        public void GetTeamSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamSimple(teamKey, ifModifiedSince);
            //Assert.IsInstanceOf<TeamSimple> (response, "response is TeamSimple");
        }
        
        /// <summary>
        /// Test GetTeamSocialMedia
        /// </summary>
        [Test]
        public void GetTeamSocialMediaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamSocialMedia(teamKey, ifModifiedSince);
            //Assert.IsInstanceOf<List<Media>> (response, "response is List<Media>");
        }
        
        /// <summary>
        /// Test GetTeamYearsParticipated
        /// </summary>
        [Test]
        public void GetTeamYearsParticipatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamYearsParticipated(teamKey, ifModifiedSince);
            //Assert.IsInstanceOf<List<int?>> (response, "response is List<int?>");
        }
        
        /// <summary>
        /// Test GetTeams
        /// </summary>
        [Test]
        public void GetTeamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pageNum = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeams(pageNum, ifModifiedSince);
            //Assert.IsInstanceOf<List<Team>> (response, "response is List<Team>");
        }
        
        /// <summary>
        /// Test GetTeamsByYear
        /// </summary>
        [Test]
        public void GetTeamsByYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? year = null;
            //int? pageNum = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamsByYear(year, pageNum, ifModifiedSince);
            //Assert.IsInstanceOf<List<Team>> (response, "response is List<Team>");
        }
        
        /// <summary>
        /// Test GetTeamsByYearKeys
        /// </summary>
        [Test]
        public void GetTeamsByYearKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? year = null;
            //int? pageNum = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamsByYearKeys(year, pageNum, ifModifiedSince);
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetTeamsByYearSimple
        /// </summary>
        [Test]
        public void GetTeamsByYearSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? year = null;
            //int? pageNum = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamsByYearSimple(year, pageNum, ifModifiedSince);
            //Assert.IsInstanceOf<List<TeamSimple>> (response, "response is List<TeamSimple>");
        }
        
        /// <summary>
        /// Test GetTeamsKeys
        /// </summary>
        [Test]
        public void GetTeamsKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pageNum = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamsKeys(pageNum, ifModifiedSince);
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetTeamsSimple
        /// </summary>
        [Test]
        public void GetTeamsSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pageNum = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamsSimple(pageNum, ifModifiedSince);
            //Assert.IsInstanceOf<List<TeamSimple>> (response, "response is List<TeamSimple>");
        }
        
    }

}