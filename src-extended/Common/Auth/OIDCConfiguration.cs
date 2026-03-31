namespace Saltoapis.Auth
{
    class OIDCConfiguration
    {
        [JsonPropertyName("token_endpoint")]
        public string TokenEndpoint
        { get; set; }
    }

}
