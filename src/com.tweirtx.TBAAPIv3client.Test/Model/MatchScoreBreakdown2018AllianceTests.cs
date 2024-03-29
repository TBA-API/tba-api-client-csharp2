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
    ///  Class for testing MatchScoreBreakdown2018Alliance
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MatchScoreBreakdown2018AllianceTests
    {
        // TODO uncomment below to declare an instance variable for MatchScoreBreakdown2018Alliance
        //private MatchScoreBreakdown2018Alliance instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MatchScoreBreakdown2018Alliance
            //instance = new MatchScoreBreakdown2018Alliance();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MatchScoreBreakdown2018Alliance
        /// </summary>
        [Test]
        public void MatchScoreBreakdown2018AllianceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MatchScoreBreakdown2018Alliance
            //Assert.IsInstanceOfType<MatchScoreBreakdown2018Alliance> (instance, "variable 'instance' is a MatchScoreBreakdown2018Alliance");
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
        /// Test the property 'AutoOwnershipPoints'
        /// </summary>
        [Test]
        public void AutoOwnershipPointsTest()
        {
            // TODO unit test for the property 'AutoOwnershipPoints'
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
        /// Test the property 'AutoQuestRankingPoint'
        /// </summary>
        [Test]
        public void AutoQuestRankingPointTest()
        {
            // TODO unit test for the property 'AutoQuestRankingPoint'
        }
        /// <summary>
        /// Test the property 'AutoRobot1'
        /// </summary>
        [Test]
        public void AutoRobot1Test()
        {
            // TODO unit test for the property 'AutoRobot1'
        }
        /// <summary>
        /// Test the property 'AutoRobot2'
        /// </summary>
        [Test]
        public void AutoRobot2Test()
        {
            // TODO unit test for the property 'AutoRobot2'
        }
        /// <summary>
        /// Test the property 'AutoRobot3'
        /// </summary>
        [Test]
        public void AutoRobot3Test()
        {
            // TODO unit test for the property 'AutoRobot3'
        }
        /// <summary>
        /// Test the property 'AutoRunPoints'
        /// </summary>
        [Test]
        public void AutoRunPointsTest()
        {
            // TODO unit test for the property 'AutoRunPoints'
        }
        /// <summary>
        /// Test the property 'AutoScaleOwnershipSec'
        /// </summary>
        [Test]
        public void AutoScaleOwnershipSecTest()
        {
            // TODO unit test for the property 'AutoScaleOwnershipSec'
        }
        /// <summary>
        /// Test the property 'AutoSwitchAtZero'
        /// </summary>
        [Test]
        public void AutoSwitchAtZeroTest()
        {
            // TODO unit test for the property 'AutoSwitchAtZero'
        }
        /// <summary>
        /// Test the property 'AutoSwitchOwnershipSec'
        /// </summary>
        [Test]
        public void AutoSwitchOwnershipSecTest()
        {
            // TODO unit test for the property 'AutoSwitchOwnershipSec'
        }
        /// <summary>
        /// Test the property 'EndgamePoints'
        /// </summary>
        [Test]
        public void EndgamePointsTest()
        {
            // TODO unit test for the property 'EndgamePoints'
        }
        /// <summary>
        /// Test the property 'EndgameRobot1'
        /// </summary>
        [Test]
        public void EndgameRobot1Test()
        {
            // TODO unit test for the property 'EndgameRobot1'
        }
        /// <summary>
        /// Test the property 'EndgameRobot2'
        /// </summary>
        [Test]
        public void EndgameRobot2Test()
        {
            // TODO unit test for the property 'EndgameRobot2'
        }
        /// <summary>
        /// Test the property 'EndgameRobot3'
        /// </summary>
        [Test]
        public void EndgameRobot3Test()
        {
            // TODO unit test for the property 'EndgameRobot3'
        }
        /// <summary>
        /// Test the property 'FaceTheBossRankingPoint'
        /// </summary>
        [Test]
        public void FaceTheBossRankingPointTest()
        {
            // TODO unit test for the property 'FaceTheBossRankingPoint'
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
        /// Test the property 'FoulPoints'
        /// </summary>
        [Test]
        public void FoulPointsTest()
        {
            // TODO unit test for the property 'FoulPoints'
        }
        /// <summary>
        /// Test the property 'Rp'
        /// </summary>
        [Test]
        public void RpTest()
        {
            // TODO unit test for the property 'Rp'
        }
        /// <summary>
        /// Test the property 'TechFoulCount'
        /// </summary>
        [Test]
        public void TechFoulCountTest()
        {
            // TODO unit test for the property 'TechFoulCount'
        }
        /// <summary>
        /// Test the property 'TeleopOwnershipPoints'
        /// </summary>
        [Test]
        public void TeleopOwnershipPointsTest()
        {
            // TODO unit test for the property 'TeleopOwnershipPoints'
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
        /// Test the property 'TeleopScaleBoostSec'
        /// </summary>
        [Test]
        public void TeleopScaleBoostSecTest()
        {
            // TODO unit test for the property 'TeleopScaleBoostSec'
        }
        /// <summary>
        /// Test the property 'TeleopScaleForceSec'
        /// </summary>
        [Test]
        public void TeleopScaleForceSecTest()
        {
            // TODO unit test for the property 'TeleopScaleForceSec'
        }
        /// <summary>
        /// Test the property 'TeleopScaleOwnershipSec'
        /// </summary>
        [Test]
        public void TeleopScaleOwnershipSecTest()
        {
            // TODO unit test for the property 'TeleopScaleOwnershipSec'
        }
        /// <summary>
        /// Test the property 'TeleopSwitchBoostSec'
        /// </summary>
        [Test]
        public void TeleopSwitchBoostSecTest()
        {
            // TODO unit test for the property 'TeleopSwitchBoostSec'
        }
        /// <summary>
        /// Test the property 'TeleopSwitchForceSec'
        /// </summary>
        [Test]
        public void TeleopSwitchForceSecTest()
        {
            // TODO unit test for the property 'TeleopSwitchForceSec'
        }
        /// <summary>
        /// Test the property 'TeleopSwitchOwnershipSec'
        /// </summary>
        [Test]
        public void TeleopSwitchOwnershipSecTest()
        {
            // TODO unit test for the property 'TeleopSwitchOwnershipSec'
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
        /// Test the property 'VaultBoostPlayed'
        /// </summary>
        [Test]
        public void VaultBoostPlayedTest()
        {
            // TODO unit test for the property 'VaultBoostPlayed'
        }
        /// <summary>
        /// Test the property 'VaultBoostTotal'
        /// </summary>
        [Test]
        public void VaultBoostTotalTest()
        {
            // TODO unit test for the property 'VaultBoostTotal'
        }
        /// <summary>
        /// Test the property 'VaultForcePlayed'
        /// </summary>
        [Test]
        public void VaultForcePlayedTest()
        {
            // TODO unit test for the property 'VaultForcePlayed'
        }
        /// <summary>
        /// Test the property 'VaultForceTotal'
        /// </summary>
        [Test]
        public void VaultForceTotalTest()
        {
            // TODO unit test for the property 'VaultForceTotal'
        }
        /// <summary>
        /// Test the property 'VaultLevitatePlayed'
        /// </summary>
        [Test]
        public void VaultLevitatePlayedTest()
        {
            // TODO unit test for the property 'VaultLevitatePlayed'
        }
        /// <summary>
        /// Test the property 'VaultLevitateTotal'
        /// </summary>
        [Test]
        public void VaultLevitateTotalTest()
        {
            // TODO unit test for the property 'VaultLevitateTotal'
        }
        /// <summary>
        /// Test the property 'VaultPoints'
        /// </summary>
        [Test]
        public void VaultPointsTest()
        {
            // TODO unit test for the property 'VaultPoints'
        }
        /// <summary>
        /// Test the property 'TbaGameData'
        /// </summary>
        [Test]
        public void TbaGameDataTest()
        {
            // TODO unit test for the property 'TbaGameData'
        }

    }

}
