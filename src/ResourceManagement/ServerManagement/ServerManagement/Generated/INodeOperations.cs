
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
    /// NodeOperations operations.
    /// </summary>
    public partial interface INodeOperations
    {
        /// <summary>
        /// Creates or updates a management node
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='nodeName'>
        /// The node name (256 characters maximum).
        /// </param>
        /// <param name='location'>
        /// location of the resource?
        /// </param>
        /// <param name='tags'>
        /// resource tags
        /// </param>
        /// <param name='gatewayId'>
        /// Gateway id which will manage this node
        /// </param>
        /// <param name='connectionName'>
        /// myhost.domain.com
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
        Task<AzureOperationResponse<NodeResource>> CreateWithHttpMessagesAsync(string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a management node
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='nodeName'>
        /// The node name (256 characters maximum).
        /// </param>
        /// <param name='location'>
        /// location of the resource?
        /// </param>
        /// <param name='tags'>
        /// resource tags
        /// </param>
        /// <param name='gatewayId'>
        /// Gateway id which will manage this node
        /// </param>
        /// <param name='connectionName'>
        /// myhost.domain.com
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
        Task<AzureOperationResponse<NodeResource>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a management node
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='nodeName'>
        /// The node name (256 characters maximum).
        /// </param>
        /// <param name='location'>
        /// location of the resource?
        /// </param>
        /// <param name='tags'>
        /// resource tags
        /// </param>
        /// <param name='gatewayId'>
        /// Gateway id which will manage this node
        /// </param>
        /// <param name='connectionName'>
        /// myhost.domain.com
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
        Task<AzureOperationResponse<NodeResource>> UpdateWithHttpMessagesAsync(string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a management node
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='nodeName'>
        /// The node name (256 characters maximum).
        /// </param>
        /// <param name='location'>
        /// location of the resource?
        /// </param>
        /// <param name='tags'>
        /// resource tags
        /// </param>
        /// <param name='gatewayId'>
        /// Gateway id which will manage this node
        /// </param>
        /// <param name='connectionName'>
        /// myhost.domain.com
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
        Task<AzureOperationResponse<NodeResource>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// deletes a management node
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='nodeName'>
        /// The node name (256 characters maximum).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string nodeName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// gets a management node
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='nodeName'>
        /// The node name (256 characters maximum).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<NodeResource>> GetWithHttpMessagesAsync(string resourceGroupName, string nodeName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns nodes in a subscription
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<NodeResource>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns nodes in a resource group
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<NodeResource>>> ListForResourceGroupWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns nodes in a subscription
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<NodeResource>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns nodes in a resource group
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<NodeResource>>> ListForResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
