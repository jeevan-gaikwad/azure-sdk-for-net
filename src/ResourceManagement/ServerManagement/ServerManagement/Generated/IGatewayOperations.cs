
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
    /// GatewayOperations operations.
    /// </summary>
    public partial interface IGatewayOperations
    {
        /// <summary>
        /// Creates or updates a ManagementService gateway.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='location'>
        /// location of the resource
        /// </param>
        /// <param name='tags'>
        /// resource tags
        /// </param>
        /// <param name='autoUpgrade'>
        /// The autoUpgrade property gives the flexibility to gateway to auto
        /// upgrade itself. If properties value not specified, then we assume
        /// autoUpgrade = Off. Possible values include: 'On', 'Off'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<GatewayResource>> CreateWithHttpMessagesAsync(string resourceGroupName, string gatewayName, string location = default(string), object tags = default(object), AutoUpgrade? autoUpgrade = default(AutoUpgrade?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a ManagementService gateway.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='location'>
        /// location of the resource
        /// </param>
        /// <param name='tags'>
        /// resource tags
        /// </param>
        /// <param name='autoUpgrade'>
        /// The autoUpgrade property gives the flexibility to gateway to auto
        /// upgrade itself. If properties value not specified, then we assume
        /// autoUpgrade = Off. Possible values include: 'On', 'Off'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<GatewayResource>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string gatewayName, string location = default(string), object tags = default(object), AutoUpgrade? autoUpgrade = default(AutoUpgrade?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a gateway belonging to a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='location'>
        /// location of the resource
        /// </param>
        /// <param name='tags'>
        /// resource tags
        /// </param>
        /// <param name='autoUpgrade'>
        /// The autoUpgrade property gives the flexibility to gateway to auto
        /// upgrade itself. If properties value not specified, then we assume
        /// autoUpgrade = Off. Possible values include: 'On', 'Off'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<GatewayResource>> UpdateWithHttpMessagesAsync(string resourceGroupName, string gatewayName, string location = default(string), object tags = default(object), AutoUpgrade? autoUpgrade = default(AutoUpgrade?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a gateway belonging to a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='location'>
        /// location of the resource
        /// </param>
        /// <param name='tags'>
        /// resource tags
        /// </param>
        /// <param name='autoUpgrade'>
        /// The autoUpgrade property gives the flexibility to gateway to auto
        /// upgrade itself. If properties value not specified, then we assume
        /// autoUpgrade = Off. Possible values include: 'On', 'Off'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<GatewayResource>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string gatewayName, string location = default(string), object tags = default(object), AutoUpgrade? autoUpgrade = default(AutoUpgrade?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a gateway from a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string gatewayName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a gateway
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum)
        /// </param>
        /// <param name='expand'>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call. Possible values include: 'status'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<GatewayResource>> GetWithHttpMessagesAsync(string resourceGroupName, string gatewayName, GatewayExpandOption? expand = default(GatewayExpandOption?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns gateways in a subscription
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<GatewayResource>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns gateways in a resource group
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
        Task<AzureOperationResponse<IPage<GatewayResource>>> ListForResourceGroupWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Upgrade a gateway
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> UpgradeWithHttpMessagesAsync(string resourceGroupName, string gatewayName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Upgrade a gateway
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginUpgradeWithHttpMessagesAsync(string resourceGroupName, string gatewayName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Regenerate a gateway's profile
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> RegenerateProfileWithHttpMessagesAsync(string resourceGroupName, string gatewayName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Regenerate a gateway's profile
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginRegenerateProfileWithHttpMessagesAsync(string resourceGroupName, string gatewayName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a gateway profile
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<GatewayProfile>> GetProfileWithHttpMessagesAsync(string resourceGroupName, string gatewayName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a gateway profile
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='gatewayName'>
        /// The gateway name (256 characters maximum).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<GatewayProfile>> BeginGetProfileWithHttpMessagesAsync(string resourceGroupName, string gatewayName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns gateways in a subscription
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
        Task<AzureOperationResponse<IPage<GatewayResource>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns gateways in a resource group
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
        Task<AzureOperationResponse<IPage<GatewayResource>>> ListForResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
