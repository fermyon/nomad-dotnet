/*
 * Nomad
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.1.4
 * Contact: support@hashicorp.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Fermyon.Nomad.Client;
using Fermyon.Nomad.Api;
// uncomment below to import models
//using Fermyon.Nomad.Model;

namespace Fermyon.Nomad.Test.Api
{
    /// <summary>
    ///  Class for testing SearchApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SearchApiTests : IDisposable
    {
        private SearchApi instance;

        public SearchApiTests()
        {
            instance = new SearchApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SearchApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SearchApi
            //Assert.IsType<SearchApi>(instance);
        }

        /// <summary>
        /// Test GetFuzzySearch
        /// </summary>
        [Fact]
        public void GetFuzzySearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FuzzySearchRequest fuzzySearchRequest = null;
            //string region = null;
            //string _namespace = null;
            //int? index = null;
            //string wait = null;
            //string stale = null;
            //string prefix = null;
            //string xNomadToken = null;
            //int? perPage = null;
            //string nextToken = null;
            //var response = instance.GetFuzzySearch(fuzzySearchRequest, region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<FuzzySearchResponse>(response);
        }

        /// <summary>
        /// Test GetSearch
        /// </summary>
        [Fact]
        public void GetSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SearchRequest searchRequest = null;
            //string region = null;
            //string _namespace = null;
            //int? index = null;
            //string wait = null;
            //string stale = null;
            //string prefix = null;
            //string xNomadToken = null;
            //int? perPage = null;
            //string nextToken = null;
            //var response = instance.GetSearch(searchRequest, region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<SearchResponse>(response);
        }
    }
}
