
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
    /// PowerShellOperations operations.
    /// </summary>
    public partial interface IPowerShellOperations
    {
        /// <summary>
        /// Gets a list of the active sessions.
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
        Task<AzureOperationResponse<PowerShellSessionResources>> ListSessionWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a PowerShell session
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
        /// <param name='pssession'>
        /// The PowerShell sessionId from the user
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PowerShellSessionResource>> CreateSessionWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, string pssession, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a PowerShell session
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
        /// <param name='pssession'>
        /// The PowerShell sessionId from the user
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PowerShellSessionResource>> BeginCreateSessionWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, string pssession, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the status of a command.
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
        /// <param name='pssession'>
        /// The PowerShell sessionId from the user
        /// </param>
        /// <param name='expand'>
        /// Gets current output from an ongoing call. Possible values include:
        /// 'output'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PowerShellCommandStatus>> GetCommandStatusWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, string pssession, PowerShellExpandOption? expand = default(PowerShellExpandOption?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// updates a running PowerShell command with more data.
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
        /// <param name='pssession'>
        /// The PowerShell sessionId from the user
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PowerShellCommandResults>> UpdateCommandWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, string pssession, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// updates a running PowerShell command with more data.
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
        /// <param name='pssession'>
        /// The PowerShell sessionId from the user
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PowerShellCommandResults>> BeginUpdateCommandWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, string pssession, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a PowerShell script and invokes it.
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
        /// <param name='pssession'>
        /// The PowerShell sessionId from the user
        /// </param>
        /// <param name='command'>
        /// Script to execute
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PowerShellCommandResults>> InvokeCommandWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, string pssession, string command = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a PowerShell script and invokes it.
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
        /// <param name='pssession'>
        /// The PowerShell sessionId from the user
        /// </param>
        /// <param name='command'>
        /// Script to execute
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PowerShellCommandResults>> BeginInvokeCommandWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, string pssession, string command = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancels a PowerShell command.
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
        /// <param name='pssession'>
        /// The PowerShell sessionId from the user
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PowerShellCommandResults>> CancelCommandWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, string pssession, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancels a PowerShell command.
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
        /// <param name='pssession'>
        /// The PowerShell sessionId from the user
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PowerShellCommandResults>> BeginCancelCommandWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, string pssession, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// gets tab completion values for a command.
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
        /// <param name='pssession'>
        /// The PowerShell sessionId from the user
        /// </param>
        /// <param name='command'>
        /// Command to get tab completion for.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PowerShellTabCompletionResults>> TabCompletionWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, string pssession, string command = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
