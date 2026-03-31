namespace Saltoapis.Auth
{
    class TokenError
    {
        [JsonPropertyName("error")]
        public string Error
        { get; set; }

        [JsonPropertyName("error_hint")]
        public string ErrorHint
        { get; set; }

        [JsonPropertyName("error_description")]
        public string ErrorDescription
        { get; set; }
    }

}
