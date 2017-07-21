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
    /// The type SiteRequest.
    /// </summary>
    public partial class SiteRequest : BaseRequest, ISiteRequest
    {
        /// <summary>
        /// Constructs a new SiteRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SiteRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Site using POST.
        /// </summary>
        /// <param name="siteToCreate">The Site to create.</param>
        /// <returns>The created Site.</returns>
        public System.Threading.Tasks.Task<Site> CreateAsync(Site siteToCreate)
        {
            return this.CreateAsync(siteToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Site using POST.
        /// </summary>
        /// <param name="siteToCreate">The Site to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Site.</returns>
        public async System.Threading.Tasks.Task<Site> CreateAsync(Site siteToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Site>(siteToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Site.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Site.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Site>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Site.
        /// </summary>
        /// <returns>The Site.</returns>
        public System.Threading.Tasks.Task<Site> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Site.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Site.</returns>
        public async System.Threading.Tasks.Task<Site> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Site>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Site using PATCH.
        /// </summary>
        /// <param name="siteToUpdate">The Site to update.</param>
        /// <returns>The updated Site.</returns>
        public System.Threading.Tasks.Task<Site> UpdateAsync(Site siteToUpdate)
        {
            return this.UpdateAsync(siteToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Site using PATCH.
        /// </summary>
        /// <param name="siteToUpdate">The Site to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Site.</returns>
        public async System.Threading.Tasks.Task<Site> UpdateAsync(Site siteToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Site>(siteToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISiteRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISiteRequest Expand(Expression<Func<Site, object>> expandExpression)
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
        public ISiteRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISiteRequest Select(Expression<Func<Site, object>> selectExpression)
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
        /// <param name="siteToInitialize">The <see cref="Site"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Site siteToInitialize)
        {

            if (siteToInitialize != null && siteToInitialize.AdditionalData != null)
            {

                if (siteToInitialize.Columns != null && siteToInitialize.Columns.CurrentPage != null)
                {
                    siteToInitialize.Columns.AdditionalData = siteToInitialize.AdditionalData;

                    object nextPageLink;
                    siteToInitialize.AdditionalData.TryGetValue("columns@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        siteToInitialize.Columns.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (siteToInitialize.Drives != null && siteToInitialize.Drives.CurrentPage != null)
                {
                    siteToInitialize.Drives.AdditionalData = siteToInitialize.AdditionalData;

                    object nextPageLink;
                    siteToInitialize.AdditionalData.TryGetValue("drives@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        siteToInitialize.Drives.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (siteToInitialize.Items != null && siteToInitialize.Items.CurrentPage != null)
                {
                    siteToInitialize.Items.AdditionalData = siteToInitialize.AdditionalData;

                    object nextPageLink;
                    siteToInitialize.AdditionalData.TryGetValue("items@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        siteToInitialize.Items.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (siteToInitialize.Lists != null && siteToInitialize.Lists.CurrentPage != null)
                {
                    siteToInitialize.Lists.AdditionalData = siteToInitialize.AdditionalData;

                    object nextPageLink;
                    siteToInitialize.AdditionalData.TryGetValue("lists@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        siteToInitialize.Lists.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (siteToInitialize.Sites != null && siteToInitialize.Sites.CurrentPage != null)
                {
                    siteToInitialize.Sites.AdditionalData = siteToInitialize.AdditionalData;

                    object nextPageLink;
                    siteToInitialize.AdditionalData.TryGetValue("sites@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        siteToInitialize.Sites.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
