
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
    /// Extension methods for PowerShellOperations.
    /// </summary>
    public static partial class PowerShellOperationsExtensions
    {
            /// <summary>
            /// Gets a list of the active sessions.
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            public static PowerShellSessionResources ListSession(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session)
            {
                return Task.Factory.StartNew(s => ((IPowerShellOperations)s).ListSessionAsync(resourceGroupName, nodeName, session), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of the active sessions.
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PowerShellSessionResources> ListSessionAsync(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSessionWithHttpMessagesAsync(resourceGroupName, nodeName, session, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a PowerShell session
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            public static PowerShellSessionResource CreateSession(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession)
            {
                return Task.Factory.StartNew(s => ((IPowerShellOperations)s).CreateSessionAsync(resourceGroupName, nodeName, session, pssession), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a PowerShell session
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PowerShellSessionResource> CreateSessionAsync(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateSessionWithHttpMessagesAsync(resourceGroupName, nodeName, session, pssession, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a PowerShell session
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            public static PowerShellSessionResource BeginCreateSession(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession)
            {
                return Task.Factory.StartNew(s => ((IPowerShellOperations)s).BeginCreateSessionAsync(resourceGroupName, nodeName, session, pssession), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a PowerShell session
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PowerShellSessionResource> BeginCreateSessionAsync(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateSessionWithHttpMessagesAsync(resourceGroupName, nodeName, session, pssession, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the status of a command.
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            /// <param name='expand'>
            /// Gets current output from an ongoing call. Possible values include: 'output'
            /// </param>
            public static PowerShellCommandStatus GetCommandStatus(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession, PowerShellExpandOption? expand = default(PowerShellExpandOption?))
            {
                return Task.Factory.StartNew(s => ((IPowerShellOperations)s).GetCommandStatusAsync(resourceGroupName, nodeName, session, pssession, expand), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the status of a command.
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            /// <param name='expand'>
            /// Gets current output from an ongoing call. Possible values include: 'output'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PowerShellCommandStatus> GetCommandStatusAsync(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession, PowerShellExpandOption? expand = default(PowerShellExpandOption?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCommandStatusWithHttpMessagesAsync(resourceGroupName, nodeName, session, pssession, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// updates a running PowerShell command with more data.
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            public static PowerShellCommandResults UpdateCommand(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession)
            {
                return Task.Factory.StartNew(s => ((IPowerShellOperations)s).UpdateCommandAsync(resourceGroupName, nodeName, session, pssession), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// updates a running PowerShell command with more data.
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PowerShellCommandResults> UpdateCommandAsync(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateCommandWithHttpMessagesAsync(resourceGroupName, nodeName, session, pssession, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// updates a running PowerShell command with more data.
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            public static PowerShellCommandResults BeginUpdateCommand(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession)
            {
                return Task.Factory.StartNew(s => ((IPowerShellOperations)s).BeginUpdateCommandAsync(resourceGroupName, nodeName, session, pssession), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// updates a running PowerShell command with more data.
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PowerShellCommandResults> BeginUpdateCommandAsync(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateCommandWithHttpMessagesAsync(resourceGroupName, nodeName, session, pssession, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a PowerShell script and invokes it.
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            /// <param name='command'>
            /// Script to execute
            /// </param>
            public static PowerShellCommandResults InvokeCommand(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession, string command = default(string))
            {
                return Task.Factory.StartNew(s => ((IPowerShellOperations)s).InvokeCommandAsync(resourceGroupName, nodeName, session, pssession, command), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a PowerShell script and invokes it.
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            /// <param name='command'>
            /// Script to execute
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PowerShellCommandResults> InvokeCommandAsync(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession, string command = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.InvokeCommandWithHttpMessagesAsync(resourceGroupName, nodeName, session, pssession, command, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a PowerShell script and invokes it.
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            /// <param name='command'>
            /// Script to execute
            /// </param>
            public static PowerShellCommandResults BeginInvokeCommand(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession, string command = default(string))
            {
                return Task.Factory.StartNew(s => ((IPowerShellOperations)s).BeginInvokeCommandAsync(resourceGroupName, nodeName, session, pssession, command), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a PowerShell script and invokes it.
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            /// <param name='command'>
            /// Script to execute
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PowerShellCommandResults> BeginInvokeCommandAsync(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession, string command = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginInvokeCommandWithHttpMessagesAsync(resourceGroupName, nodeName, session, pssession, command, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancels a PowerShell command.
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            public static PowerShellCommandResults CancelCommand(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession)
            {
                return Task.Factory.StartNew(s => ((IPowerShellOperations)s).CancelCommandAsync(resourceGroupName, nodeName, session, pssession), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancels a PowerShell command.
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PowerShellCommandResults> CancelCommandAsync(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CancelCommandWithHttpMessagesAsync(resourceGroupName, nodeName, session, pssession, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancels a PowerShell command.
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            public static PowerShellCommandResults BeginCancelCommand(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession)
            {
                return Task.Factory.StartNew(s => ((IPowerShellOperations)s).BeginCancelCommandAsync(resourceGroupName, nodeName, session, pssession), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancels a PowerShell command.
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PowerShellCommandResults> BeginCancelCommandAsync(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCancelCommandWithHttpMessagesAsync(resourceGroupName, nodeName, session, pssession, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// gets tab completion values for a command.
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            /// <param name='command'>
            /// Command to get tab completion for.
            /// </param>
            public static PowerShellTabCompletionResults TabCompletion(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession, string command = default(string))
            {
                return Task.Factory.StartNew(s => ((IPowerShellOperations)s).TabCompletionAsync(resourceGroupName, nodeName, session, pssession, command), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// gets tab completion values for a command.
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
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='pssession'>
            /// The PowerShell sessionId from the user
            /// </param>
            /// <param name='command'>
            /// Command to get tab completion for.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PowerShellTabCompletionResults> TabCompletionAsync(this IPowerShellOperations operations, string resourceGroupName, string nodeName, string session, string pssession, string command = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.TabCompletionWithHttpMessagesAsync(resourceGroupName, nodeName, session, pssession, command, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
