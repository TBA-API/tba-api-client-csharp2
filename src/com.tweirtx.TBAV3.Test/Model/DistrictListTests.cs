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
    ///  Class for testing DistrictList
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DistrictListTests
    {
        // TODO uncomment below to declare an instance variable for DistrictList
        //private DistrictList instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DistrictList
            //instance = new DistrictList();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DistrictList
        /// </summary>
        [Test]
        public void DistrictListInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DistrictList
            //Assert.IsInstanceOfType<DistrictList> (instance, "variable 'instance' is a DistrictList");
        }


        /// <summary>
        /// Test the property 'Abbreviation'
        /// </summary>
        [Test]
        public void AbbreviationTest()
        {
            // TODO unit test for the property 'Abbreviation'
        }
        /// <summary>
        /// Test the property 'DisplayName'
        /// </summary>
        [Test]
        public void DisplayNameTest()
        {
            // TODO unit test for the property 'DisplayName'
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
        /// Test the property 'Year'
        /// </summary>
        [Test]
        public void YearTest()
        {
            // TODO unit test for the property 'Year'
        }

    }

}
