// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type DeviceManagementScriptRequest.
    /// </summary>
    public partial class DeviceManagementScriptRequest : BaseRequest, IDeviceManagementScriptRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementScriptRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementScriptRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementScript using POST.
        /// </summary>
        /// <param name="deviceManagementScriptToCreate">The DeviceManagementScript to create.</param>
        /// <returns>The created DeviceManagementScript.</returns>
        public System.Threading.Tasks.Task<DeviceManagementScript> CreateAsync(DeviceManagementScript deviceManagementScriptToCreate)
        {
            return this.CreateAsync(deviceManagementScriptToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceManagementScript using POST.
        /// </summary>
        /// <param name="deviceManagementScriptToCreate">The DeviceManagementScript to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementScript.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementScript> CreateAsync(DeviceManagementScript deviceManagementScriptToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceManagementScript>(deviceManagementScriptToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified DeviceManagementScript.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementScript.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceManagementScript>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DeviceManagementScript.
        /// </summary>
        /// <returns>The DeviceManagementScript.</returns>
        public System.Threading.Tasks.Task<DeviceManagementScript> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceManagementScript.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementScript.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementScript> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceManagementScript>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementScript using PATCH.
        /// </summary>
        /// <param name="deviceManagementScriptToUpdate">The DeviceManagementScript to update.</param>
        /// <returns>The updated DeviceManagementScript.</returns>
        public System.Threading.Tasks.Task<DeviceManagementScript> UpdateAsync(DeviceManagementScript deviceManagementScriptToUpdate)
        {
            return this.UpdateAsync(deviceManagementScriptToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceManagementScript using PATCH.
        /// </summary>
        /// <param name="deviceManagementScriptToUpdate">The DeviceManagementScript to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DeviceManagementScript.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementScript> UpdateAsync(DeviceManagementScript deviceManagementScriptToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceManagementScript>(deviceManagementScriptToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementScriptRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementScriptRequest Expand(Expression<Func<DeviceManagementScript, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementScriptRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementScriptRequest Select(Expression<Func<DeviceManagementScript, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="deviceManagementScriptToInitialize">The <see cref="DeviceManagementScript"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementScript deviceManagementScriptToInitialize)
        {

            if (deviceManagementScriptToInitialize != null && deviceManagementScriptToInitialize.AdditionalData != null)
            {

                if (deviceManagementScriptToInitialize.GroupAssignments != null && deviceManagementScriptToInitialize.GroupAssignments.CurrentPage != null)
                {
                    deviceManagementScriptToInitialize.GroupAssignments.AdditionalData = deviceManagementScriptToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementScriptToInitialize.AdditionalData.TryGetValue("groupAssignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementScriptToInitialize.GroupAssignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementScriptToInitialize.DeviceRunStates != null && deviceManagementScriptToInitialize.DeviceRunStates.CurrentPage != null)
                {
                    deviceManagementScriptToInitialize.DeviceRunStates.AdditionalData = deviceManagementScriptToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementScriptToInitialize.AdditionalData.TryGetValue("deviceRunStates@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementScriptToInitialize.DeviceRunStates.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementScriptToInitialize.UserRunStates != null && deviceManagementScriptToInitialize.UserRunStates.CurrentPage != null)
                {
                    deviceManagementScriptToInitialize.UserRunStates.AdditionalData = deviceManagementScriptToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementScriptToInitialize.AdditionalData.TryGetValue("userRunStates@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementScriptToInitialize.UserRunStates.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
