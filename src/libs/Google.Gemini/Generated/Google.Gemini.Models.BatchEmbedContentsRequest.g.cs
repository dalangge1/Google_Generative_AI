
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Batch request to get embeddings from the model for a list of prompts.
    /// </summary>
    public sealed partial class BatchEmbedContentsRequest
    {
        /// <summary>
        /// Required. Embed requests for the batch. The model in each of these requests must match the model specified `BatchEmbedContentsRequest.model`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.EmbedContentRequest>? Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}