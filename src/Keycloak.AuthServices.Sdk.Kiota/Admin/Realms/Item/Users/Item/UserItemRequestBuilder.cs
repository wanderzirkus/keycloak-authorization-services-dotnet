// <auto-generated/>
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users.Item.ConfiguredUserStorageCredentialTypes;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users.Item.Consents;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users.Item.Credentials;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users.Item.DisableCredentialTypes;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users.Item.ExecuteActionsEmail;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users.Item.FederatedIdentity;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users.Item.Groups;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users.Item.Impersonation;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users.Item.Logout;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users.Item.OfflineSessions;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users.Item.ResetPassword;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users.Item.ResetPasswordEmail;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users.Item.RoleMappings;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users.Item.SendVerifyEmail;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users.Item.Sessions;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Users.Item {
    /// <summary>
    /// Builds and executes requests for operations under \admin\realms\{realm}\users\{user-id}
    /// </summary>
    public class UserItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The configuredUserStorageCredentialTypes property</summary>
        public ConfiguredUserStorageCredentialTypesRequestBuilder ConfiguredUserStorageCredentialTypes { get =>
            new ConfiguredUserStorageCredentialTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The consents property</summary>
        public ConsentsRequestBuilder Consents { get =>
            new ConsentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The credentials property</summary>
        public CredentialsRequestBuilder Credentials { get =>
            new CredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The disableCredentialTypes property</summary>
        public DisableCredentialTypesRequestBuilder DisableCredentialTypes { get =>
            new DisableCredentialTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The executeActionsEmail property</summary>
        public ExecuteActionsEmailRequestBuilder ExecuteActionsEmail { get =>
            new ExecuteActionsEmailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The federatedIdentity property</summary>
        public FederatedIdentityRequestBuilder FederatedIdentity { get =>
            new FederatedIdentityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groups property</summary>
        public GroupsRequestBuilder Groups { get =>
            new GroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The impersonation property</summary>
        public ImpersonationRequestBuilder Impersonation { get =>
            new ImpersonationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The logout property</summary>
        public LogoutRequestBuilder Logout { get =>
            new LogoutRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The offlineSessions property</summary>
        public OfflineSessionsRequestBuilder OfflineSessions { get =>
            new OfflineSessionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The resetPassword property</summary>
        public ResetPasswordRequestBuilder ResetPassword { get =>
            new ResetPasswordRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The resetPasswordEmail property</summary>
        public ResetPasswordEmailRequestBuilder ResetPasswordEmail { get =>
            new ResetPasswordEmailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The roleMappings property</summary>
        public RoleMappingsRequestBuilder RoleMappings { get =>
            new RoleMappingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sendVerifyEmail property</summary>
        public SendVerifyEmailRequestBuilder SendVerifyEmail { get =>
            new SendVerifyEmailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sessions property</summary>
        public SessionsRequestBuilder Sessions { get =>
            new SessionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="UserItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/users/{user%2Did}{?userProfileMetadata*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="UserItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/users/{user%2Did}{?userProfileMetadata*}", rawUrl) {
        }
        /// <summary>
        /// Delete the user
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get representation of the user
        /// </summary>
        /// <returns>A <see cref="UserRepresentation"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<UserRepresentation?> GetAsync(Action<RequestConfiguration<UserItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<UserRepresentation> GetAsync(Action<RequestConfiguration<UserItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<UserRepresentation>(requestInfo, UserRepresentation.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the user
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> PutAsync(UserRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> PutAsync(UserRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete the user
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/admin/realms/{realm}/users/{user%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Get representation of the user
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<UserItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<UserItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the user
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(UserRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(UserRepresentation body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, "{+baseurl}/admin/realms/{realm}/users/{user%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="UserItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public UserItemRequestBuilder WithUrl(string rawUrl) {
            return new UserItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get representation of the user
        /// </summary>
        public class UserItemRequestBuilderGetQueryParameters {
            /// <summary>Indicates if the user profile metadata should be added to the response</summary>
            [QueryParameter("userProfileMetadata")]
            public bool? UserProfileMetadata { get; set; }
        }
    }
}
