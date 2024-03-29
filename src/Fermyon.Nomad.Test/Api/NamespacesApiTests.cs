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
    ///  Class for testing NamespacesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class NamespacesApiTests : IDisposable
    {
        private NamespacesApi instance;

        public NamespacesApiTests()
        {
            instance = new NamespacesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NamespacesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' NamespacesApi
            //Assert.IsType<NamespacesApi>(instance);
        }

        /// <summary>
        /// Test CreateNamespace
        /// </summary>
        [Fact]
        public void CreateNamespaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? region = null;
            //string? _namespace = null;
            //string? xNomadToken = null;
            //string? idempotencyToken = null;
            //instance.CreateNamespace(region, _namespace, xNomadToken, idempotencyToken);
        }

        /// <summary>
        /// Test DeleteNamespace
        /// </summary>
        [Fact]
        public void DeleteNamespaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string namespaceName = null;
            //string? region = null;
            //string? _namespace = null;
            //string? xNomadToken = null;
            //string? idempotencyToken = null;
            //instance.DeleteNamespace(namespaceName, region, _namespace, xNomadToken, idempotencyToken);
        }

        /// <summary>
        /// Test GetNamespace
        /// </summary>
        [Fact]
        public void GetNamespaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string namespaceName = null;
            //string? region = null;
            //string? _namespace = null;
            //int? index = null;
            //string? wait = null;
            //string? stale = null;
            //string? prefix = null;
            //string? xNomadToken = null;
            //int? perPage = null;
            //string? nextToken = null;
            //var response = instance.GetNamespace(namespaceName, region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<Namespace>(response);
        }

        /// <summary>
        /// Test GetNamespaces
        /// </summary>
        [Fact]
        public void GetNamespacesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? region = null;
            //string? _namespace = null;
            //int? index = null;
            //string? wait = null;
            //string? stale = null;
            //string? prefix = null;
            //string? xNomadToken = null;
            //int? perPage = null;
            //string? nextToken = null;
            //var response = instance.GetNamespaces(region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<List<Namespace>>(response);
        }

        /// <summary>
        /// Test PostNamespace
        /// </summary>
        [Fact]
        public void PostNamespaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string namespaceName = null;
            //Namespace _namespace2 = null;
            //string? region = null;
            //string? _namespace = null;
            //string? xNomadToken = null;
            //string? idempotencyToken = null;
            //instance.PostNamespace(namespaceName, _namespace2, region, _namespace, xNomadToken, idempotencyToken);
        }
    }
}
