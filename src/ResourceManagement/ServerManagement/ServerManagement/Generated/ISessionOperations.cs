
namespace Microsoft.Azure.Management.ServerManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// SessionOperations operations.
    /// </summary>
    public partial interface ISessionOperations
    {
        /// <summary>
        /// Creates a session for a node
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='nodeName'>
        /// The node name (256 characters maximum).
        /// </param>
        /// <param name='session'>
        /// The sessionId from the user
        /// </param>
        /// <param name='userName'>
        /// User name to be used to connect to node
        /// </param>
        /// <param name='password'>
        /// Password associated with user name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<SessionResource>> CreateWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, string userName = default(string), string password = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a session for a node
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='nodeName'>
        /// The node name (256 characters maximum).
        /// </param>
        /// <param name='session'>
        /// The sessionId from the user
        /// </param>
        /// <param name='userName'>
        /// User name to be used to connect to node
        /// </param>
        /// <param name='password'>
        /// Password associated with user name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<SessionResource>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, string userName = default(string), string password = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a session for a node
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='nodeName'>
        /// The node name (256 characters maximum).
        /// </param>
        /// <param name='session'>
        /// The sessionId from the user
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a session for a node
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='nodeName'>
        /// The node name (256 characters maximum).
        /// </param>
        /// <param name='session'>
        /// The sessionId from the user
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<SessionResource>> GetWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
