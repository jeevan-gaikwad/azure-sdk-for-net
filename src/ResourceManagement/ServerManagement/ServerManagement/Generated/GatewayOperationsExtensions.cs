
namespace Microsoft.Azure.Management.ServerManagement
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for GatewayOperations.
    /// </summary>
    public static partial class GatewayOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a ManagementService gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
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
            /// The autoUpgrade property gives the flexibility to gateway to auto upgrade
            /// itself. If properties value not specified, then we assume autoUpgrade =
            /// Off. Possible values include: 'On', 'Off'
            /// </param>
            public static GatewayResource Create(this IGatewayOperations operations, string resourceGroupName, string gatewayName, string location = default(string), object tags = default(object), AutoUpgrade? autoUpgrade = default(AutoUpgrade?))
            {
                return Task.Factory.StartNew(s => ((IGatewayOperations)s).CreateAsync(resourceGroupName, gatewayName, location, tags, autoUpgrade), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a ManagementService gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
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
            /// The autoUpgrade property gives the flexibility to gateway to auto upgrade
            /// itself. If properties value not specified, then we assume autoUpgrade =
            /// Off. Possible values include: 'On', 'Off'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GatewayResource> CreateAsync(this IGatewayOperations operations, string resourceGroupName, string gatewayName, string location = default(string), object tags = default(object), AutoUpgrade? autoUpgrade = default(AutoUpgrade?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, gatewayName, location, tags, autoUpgrade, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a ManagementService gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
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
            /// The autoUpgrade property gives the flexibility to gateway to auto upgrade
            /// itself. If properties value not specified, then we assume autoUpgrade =
            /// Off. Possible values include: 'On', 'Off'
            /// </param>
            public static GatewayResource BeginCreate(this IGatewayOperations operations, string resourceGroupName, string gatewayName, string location = default(string), object tags = default(object), AutoUpgrade? autoUpgrade = default(AutoUpgrade?))
            {
                return Task.Factory.StartNew(s => ((IGatewayOperations)s).BeginCreateAsync(resourceGroupName, gatewayName, location, tags, autoUpgrade), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a ManagementService gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
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
            /// The autoUpgrade property gives the flexibility to gateway to auto upgrade
            /// itself. If properties value not specified, then we assume autoUpgrade =
            /// Off. Possible values include: 'On', 'Off'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GatewayResource> BeginCreateAsync(this IGatewayOperations operations, string resourceGroupName, string gatewayName, string location = default(string), object tags = default(object), AutoUpgrade? autoUpgrade = default(AutoUpgrade?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, gatewayName, location, tags, autoUpgrade, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a gateway belonging to a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
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
            /// The autoUpgrade property gives the flexibility to gateway to auto upgrade
            /// itself. If properties value not specified, then we assume autoUpgrade =
            /// Off. Possible values include: 'On', 'Off'
            /// </param>
            public static GatewayResource Update(this IGatewayOperations operations, string resourceGroupName, string gatewayName, string location = default(string), object tags = default(object), AutoUpgrade? autoUpgrade = default(AutoUpgrade?))
            {
                return Task.Factory.StartNew(s => ((IGatewayOperations)s).UpdateAsync(resourceGroupName, gatewayName, location, tags, autoUpgrade), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a gateway belonging to a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
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
            /// The autoUpgrade property gives the flexibility to gateway to auto upgrade
            /// itself. If properties value not specified, then we assume autoUpgrade =
            /// Off. Possible values include: 'On', 'Off'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GatewayResource> UpdateAsync(this IGatewayOperations operations, string resourceGroupName, string gatewayName, string location = default(string), object tags = default(object), AutoUpgrade? autoUpgrade = default(AutoUpgrade?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, gatewayName, location, tags, autoUpgrade, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a gateway belonging to a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
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
            /// The autoUpgrade property gives the flexibility to gateway to auto upgrade
            /// itself. If properties value not specified, then we assume autoUpgrade =
            /// Off. Possible values include: 'On', 'Off'
            /// </param>
            public static GatewayResource BeginUpdate(this IGatewayOperations operations, string resourceGroupName, string gatewayName, string location = default(string), object tags = default(object), AutoUpgrade? autoUpgrade = default(AutoUpgrade?))
            {
                return Task.Factory.StartNew(s => ((IGatewayOperations)s).BeginUpdateAsync(resourceGroupName, gatewayName, location, tags, autoUpgrade), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a gateway belonging to a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
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
            /// The autoUpgrade property gives the flexibility to gateway to auto upgrade
            /// itself. If properties value not specified, then we assume autoUpgrade =
            /// Off. Possible values include: 'On', 'Off'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GatewayResource> BeginUpdateAsync(this IGatewayOperations operations, string resourceGroupName, string gatewayName, string location = default(string), object tags = default(object), AutoUpgrade? autoUpgrade = default(AutoUpgrade?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, gatewayName, location, tags, autoUpgrade, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a gateway from a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='gatewayName'>
            /// The gateway name (256 characters maximum).
            /// </param>
            public static void Delete(this IGatewayOperations operations, string resourceGroupName, string gatewayName)
            {
                Task.Factory.StartNew(s => ((IGatewayOperations)s).DeleteAsync(resourceGroupName, gatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a gateway from a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='gatewayName'>
            /// The gateway name (256 characters maximum).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IGatewayOperations operations, string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, gatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns a gateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='gatewayName'>
            /// The gateway name (256 characters maximum)
            /// </param>
            /// <param name='expand'>
            /// Gets subscription credentials which uniquely identify Microsoft Azure
            /// subscription. The subscription ID forms part of the URI for every service
            /// call. Possible values include: 'status'
            /// </param>
            public static GatewayResource Get(this IGatewayOperations operations, string resourceGroupName, string gatewayName, GatewayExpandOption? expand = default(GatewayExpandOption?))
            {
                return Task.Factory.StartNew(s => ((IGatewayOperations)s).GetAsync(resourceGroupName, gatewayName, expand), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a gateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='gatewayName'>
            /// The gateway name (256 characters maximum)
            /// </param>
            /// <param name='expand'>
            /// Gets subscription credentials which uniquely identify Microsoft Azure
            /// subscription. The subscription ID forms part of the URI for every service
            /// call. Possible values include: 'status'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GatewayResource> GetAsync(this IGatewayOperations operations, string resourceGroupName, string gatewayName, GatewayExpandOption? expand = default(GatewayExpandOption?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, gatewayName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns gateways in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<GatewayResource> List(this IGatewayOperations operations)
            {
                return Task.Factory.StartNew(s => ((IGatewayOperations)s).ListAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns gateways in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<GatewayResource>> ListAsync(this IGatewayOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns gateways in a resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            public static IPage<GatewayResource> ListForResourceGroup(this IGatewayOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IGatewayOperations)s).ListForResourceGroupAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns gateways in a resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<GatewayResource>> ListForResourceGroupAsync(this IGatewayOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Upgrade a gateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='gatewayName'>
            /// The gateway name (256 characters maximum).
            /// </param>
            public static void Upgrade(this IGatewayOperations operations, string resourceGroupName, string gatewayName)
            {
                Task.Factory.StartNew(s => ((IGatewayOperations)s).UpgradeAsync(resourceGroupName, gatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Upgrade a gateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='gatewayName'>
            /// The gateway name (256 characters maximum).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpgradeAsync(this IGatewayOperations operations, string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.UpgradeWithHttpMessagesAsync(resourceGroupName, gatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Upgrade a gateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='gatewayName'>
            /// The gateway name (256 characters maximum).
            /// </param>
            public static void BeginUpgrade(this IGatewayOperations operations, string resourceGroupName, string gatewayName)
            {
                Task.Factory.StartNew(s => ((IGatewayOperations)s).BeginUpgradeAsync(resourceGroupName, gatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Upgrade a gateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='gatewayName'>
            /// The gateway name (256 characters maximum).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginUpgradeAsync(this IGatewayOperations operations, string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginUpgradeWithHttpMessagesAsync(resourceGroupName, gatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Regenerate a gateway's profile
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='gatewayName'>
            /// The gateway name (256 characters maximum).
            /// </param>
            public static void RegenerateProfile(this IGatewayOperations operations, string resourceGroupName, string gatewayName)
            {
                Task.Factory.StartNew(s => ((IGatewayOperations)s).RegenerateProfileAsync(resourceGroupName, gatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerate a gateway's profile
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='gatewayName'>
            /// The gateway name (256 characters maximum).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RegenerateProfileAsync(this IGatewayOperations operations, string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.RegenerateProfileWithHttpMessagesAsync(resourceGroupName, gatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Regenerate a gateway's profile
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='gatewayName'>
            /// The gateway name (256 characters maximum).
            /// </param>
            public static void BeginRegenerateProfile(this IGatewayOperations operations, string resourceGroupName, string gatewayName)
            {
                Task.Factory.StartNew(s => ((IGatewayOperations)s).BeginRegenerateProfileAsync(resourceGroupName, gatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerate a gateway's profile
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='gatewayName'>
            /// The gateway name (256 characters maximum).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginRegenerateProfileAsync(this IGatewayOperations operations, string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginRegenerateProfileWithHttpMessagesAsync(resourceGroupName, gatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets a gateway profile
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='gatewayName'>
            /// The gateway name (256 characters maximum).
            /// </param>
            public static GatewayProfile GetProfile(this IGatewayOperations operations, string resourceGroupName, string gatewayName)
            {
                return Task.Factory.StartNew(s => ((IGatewayOperations)s).GetProfileAsync(resourceGroupName, gatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a gateway profile
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='gatewayName'>
            /// The gateway name (256 characters maximum).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GatewayProfile> GetProfileAsync(this IGatewayOperations operations, string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetProfileWithHttpMessagesAsync(resourceGroupName, gatewayName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a gateway profile
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='gatewayName'>
            /// The gateway name (256 characters maximum).
            /// </param>
            public static GatewayProfile BeginGetProfile(this IGatewayOperations operations, string resourceGroupName, string gatewayName)
            {
                return Task.Factory.StartNew(s => ((IGatewayOperations)s).BeginGetProfileAsync(resourceGroupName, gatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a gateway profile
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='gatewayName'>
            /// The gateway name (256 characters maximum).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GatewayProfile> BeginGetProfileAsync(this IGatewayOperations operations, string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginGetProfileWithHttpMessagesAsync(resourceGroupName, gatewayName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns gateways in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<GatewayResource> ListNext(this IGatewayOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IGatewayOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns gateways in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<GatewayResource>> ListNextAsync(this IGatewayOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns gateways in a resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<GatewayResource> ListForResourceGroupNext(this IGatewayOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IGatewayOperations)s).ListForResourceGroupNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns gateways in a resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<GatewayResource>> ListForResourceGroupNextAsync(this IGatewayOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
