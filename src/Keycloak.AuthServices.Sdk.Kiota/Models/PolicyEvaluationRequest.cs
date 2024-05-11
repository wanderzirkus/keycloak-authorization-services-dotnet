// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Models {
    public class PolicyEvaluationRequest : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The clientId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientId { get; set; }
#nullable restore
#else
        public string ClientId { get; set; }
#endif
        /// <summary>The context property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyEvaluationRequest_context? Context { get; set; }
#nullable restore
#else
        public PolicyEvaluationRequest_context Context { get; set; }
#endif
        /// <summary>The entitlements property</summary>
        public bool? Entitlements { get; set; }
        /// <summary>The resources property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ResourceRepresentation>? Resources { get; set; }
#nullable restore
#else
        public List<ResourceRepresentation> Resources { get; set; }
#endif
        /// <summary>The roleIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleIds { get; set; }
#nullable restore
#else
        public List<string> RoleIds { get; set; }
#endif
        /// <summary>The userId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PolicyEvaluationRequest"/> and sets the default values.
        /// </summary>
        public PolicyEvaluationRequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PolicyEvaluationRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PolicyEvaluationRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PolicyEvaluationRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"clientId", n => { ClientId = n.GetStringValue(); } },
                {"context", n => { Context = n.GetObjectValue<PolicyEvaluationRequest_context>(PolicyEvaluationRequest_context.CreateFromDiscriminatorValue); } },
                {"entitlements", n => { Entitlements = n.GetBoolValue(); } },
                {"resources", n => { Resources = n.GetCollectionOfObjectValues<ResourceRepresentation>(ResourceRepresentation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleIds", n => { RoleIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("clientId", ClientId);
            writer.WriteObjectValue<PolicyEvaluationRequest_context>("context", Context);
            writer.WriteBoolValue("entitlements", Entitlements);
            writer.WriteCollectionOfObjectValues<ResourceRepresentation>("resources", Resources);
            writer.WriteCollectionOfPrimitiveValues<string>("roleIds", RoleIds);
            writer.WriteStringValue("userId", UserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
