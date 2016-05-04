
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
    /// Extension methods for NodeOperations.
    /// </summary>
    public static partial class NodeOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a management node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
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
            public static NodeResource Create(this INodeOperations operations, string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string))
            {
                return Task.Factory.StartNew(s => ((INodeOperations)s).CreateAsync(resourceGroupName, nodeName, location, tags, gatewayId, connectionName, userName, password), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a management node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NodeResource> CreateAsync(this INodeOperations operations, string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, nodeName, location, tags, gatewayId, connectionName, userName, password, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a management node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
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
            public static NodeResource BeginCreate(this INodeOperations operations, string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string))
            {
                return Task.Factory.StartNew(s => ((INodeOperations)s).BeginCreateAsync(resourceGroupName, nodeName, location, tags, gatewayId, connectionName, userName, password), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a management node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NodeResource> BeginCreateAsync(this INodeOperations operations, string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, nodeName, location, tags, gatewayId, connectionName, userName, password, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a management node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
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
            public static NodeResource Update(this INodeOperations operations, string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string))
            {
                return Task.Factory.StartNew(s => ((INodeOperations)s).UpdateAsync(resourceGroupName, nodeName, location, tags, gatewayId, connectionName, userName, password), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a management node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NodeResource> UpdateAsync(this INodeOperations operations, string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, nodeName, location, tags, gatewayId, connectionName, userName, password, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a management node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
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
            public static NodeResource BeginUpdate(this INodeOperations operations, string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string))
            {
                return Task.Factory.StartNew(s => ((INodeOperations)s).BeginUpdateAsync(resourceGroupName, nodeName, location, tags, gatewayId, connectionName, userName, password), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a management node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NodeResource> BeginUpdateAsync(this INodeOperations operations, string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, nodeName, location, tags, gatewayId, connectionName, userName, password, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// deletes a management node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            public static void Delete(this INodeOperations operations, string resourceGroupName, string nodeName)
            {
                Task.Factory.StartNew(s => ((INodeOperations)s).DeleteAsync(resourceGroupName, nodeName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// deletes a management node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this INodeOperations operations, string resourceGroupName, string nodeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, nodeName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// gets a management node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            public static NodeResource Get(this INodeOperations operations, string resourceGroupName, string nodeName)
            {
                return Task.Factory.StartNew(s => ((INodeOperations)s).GetAsync(resourceGroupName, nodeName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// gets a management node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NodeResource> GetAsync(this INodeOperations operations, string resourceGroupName, string nodeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, nodeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns nodes in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<NodeResource> List(this INodeOperations operations)
            {
                return Task.Factory.StartNew(s => ((INodeOperations)s).ListAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns nodes in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NodeResource>> ListAsync(this INodeOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns nodes in a resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            public static IPage<NodeResource> ListForResourceGroup(this INodeOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((INodeOperations)s).ListForResourceGroupAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns nodes in a resource group
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
            public static async Task<IPage<NodeResource>> ListForResourceGroupAsync(this INodeOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns nodes in a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NodeResource> ListNext(this INodeOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INodeOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns nodes in a subscription
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
            public static async Task<IPage<NodeResource>> ListNextAsync(this INodeOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns nodes in a resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NodeResource> ListForResourceGroupNext(this INodeOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((INodeOperations)s).ListForResourceGroupNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns nodes in a resource group
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
            public static async Task<IPage<NodeResource>> ListForResourceGroupNextAsync(this INodeOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
