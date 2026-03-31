using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Installation.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/installation/v1/encrypted_payload.proto</summary>
    public static partial class EncryptedPayloadReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/installation/v1/encrypted_payload.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static EncryptedPayloadReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CjRzYWx0by9uZWJ1bGEvaW5zdGFsbGF0aW9uL3YxL2VuY3J5cHRlZF9wYXls",
                  "b2FkLnByb3RvEhxzYWx0by5uZWJ1bGEuaW5zdGFsbGF0aW9uLnYxIlIKHklu",
                  "Z2VzdEVuY3J5cHRlZFBheWxvYWRzUmVxdWVzdBIUCgxpbnN0YWxsYXRpb24Y",
                  "ASABKAkSGgoSZW5jcnlwdGVkX3BheWxvYWRzGAIgAygMIiEKH0luZ2VzdEVu",
                  "Y3J5cHRlZFBheWxvYWRzUmVzcG9uc2UysgEKF0VuY3J5cHRlZFBheWxvYWRT",
                  "ZXJ2aWNlEpYBChdJbmdlc3RFbmNyeXB0ZWRQYXlsb2FkcxI8LnNhbHRvLm5l",
                  "YnVsYS5pbnN0YWxsYXRpb24udjEuSW5nZXN0RW5jcnlwdGVkUGF5bG9hZHNS",
                  "ZXF1ZXN0Gj0uc2FsdG8ubmVidWxhLmluc3RhbGxhdGlvbi52MS5Jbmdlc3RF",
                  "bmNyeXB0ZWRQYXlsb2Fkc1Jlc3BvbnNlQoQCCiRjb20uc2FsdG9hcGlzLm5l",
                  "YnVsYS5pbnN0YWxsYXRpb24udjFCFUVuY3J5cHRlZFBheWxvYWRQcm90b1AB",
                  "Wk5naXRodWIuY29tL3NhbHRvYXBpcy1pbnRlcm5hbC9zYWx0b2FwaXMtZ28v",
                  "bmVidWxhL2luc3RhbGxhdGlvbi92MTtpbnN0YWxsYXRpb26qAiBTYWx0b2Fw",
                  "aXMuTmVidWxhLkluc3RhbGxhdGlvbi5WMcoCIFNhbHRvYXBpc1xOZWJ1bGFc",
                  "SW5zdGFsbGF0aW9uXFYx4gIsR1BCTWV0YWRhdGFcU2FsdG9hcGlzXE5lYnVs",
                  "YVxJbnN0YWxsYXRpb25cVjFiBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(IngestEncryptedPayloadsRequest), IngestEncryptedPayloadsRequest.Parser, ["Installation", "EncryptedPayloads"], null, null, null, null),
            new(typeof(IngestEncryptedPayloadsResponse), IngestEncryptedPayloadsResponse.Parser, null, null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// The request message for [`IngestEncryptedPayloads`][salto.nebula.installation.v1.EncryptedPayloadService.IngestEncryptedPayloads]
    /// </summary>
    public sealed partial class IngestEncryptedPayloadsRequest : IMessage<IngestEncryptedPayloadsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<IngestEncryptedPayloadsRequest> _parser = new(() => new IngestEncryptedPayloadsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<IngestEncryptedPayloadsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncryptedPayloadReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public IngestEncryptedPayloadsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public IngestEncryptedPayloadsRequest(IngestEncryptedPayloadsRequest other) : this()
        {
            installation_ = other.installation_;
            encryptedPayloads_ = other.encryptedPayloads_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public IngestEncryptedPayloadsRequest Clone() => new(this);
        /// <summary>Field number for the "installation" field.</summary>
        public const int InstallationFieldNumber = 1;
        private string installation_ = "";

        /// <summary>
        /// The parent installation resource name.
        /// For example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Installation
        {
            get { return installation_; }
            set
            {
                installation_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "encrypted_payloads" field.</summary>
        public const int EncryptedPayloadsFieldNumber = 2;
        private static readonly FieldCodec<ByteString> _repeated_encryptedPayloads_codec
            = FieldCodec.ForBytes(18);
        private readonly RepeatedField<ByteString> encryptedPayloads_ = [];

        /// <summary>
        /// The encrypted payloads to be ingested.
        /// </summary>
        public RepeatedField<ByteString> EncryptedPayloads
        {
            get { return encryptedPayloads_; }
        }

        public override bool Equals(object other) => Equals(other as IngestEncryptedPayloadsRequest);
        public bool Equals(IngestEncryptedPayloadsRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Installation != other.Installation) return false;
            if (!encryptedPayloads_.Equals(other.encryptedPayloads_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Installation.Length != 0) hash ^= Installation.GetHashCode();
            hash ^= encryptedPayloads_.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Installation.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Installation);
      }
      encryptedPayloads_.WriteTo(output, _repeated_encryptedPayloads_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Installation.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Installation);
            }
            encryptedPayloads_.WriteTo(ref output, _repeated_encryptedPayloads_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Installation.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Installation);
            }
            size += encryptedPayloads_.CalculateSize(_repeated_encryptedPayloads_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(IngestEncryptedPayloadsRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Installation.Length != 0)
            {
                Installation = other.Installation;
            }
            encryptedPayloads_.Add(other.encryptedPayloads_);
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Installation = input.ReadString();
            break;
          }
          case 18: {
            encryptedPayloads_.AddEntriesFrom(input, _repeated_encryptedPayloads_codec);
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            Installation = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            encryptedPayloads_.AddEntriesFrom(ref input, _repeated_encryptedPayloads_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`IngestEncryptedPayloads`][salto.nebula.installation.v1.EncryptedPayloadService.IngestEncryptedPayloads]
    /// </summary>
    public sealed partial class IngestEncryptedPayloadsResponse : IMessage<IngestEncryptedPayloadsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<IngestEncryptedPayloadsResponse> _parser = new(() => new IngestEncryptedPayloadsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<IngestEncryptedPayloadsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EncryptedPayloadReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public IngestEncryptedPayloadsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public IngestEncryptedPayloadsResponse(IngestEncryptedPayloadsResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public IngestEncryptedPayloadsResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as IngestEncryptedPayloadsResponse);
        public bool Equals(IngestEncryptedPayloadsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(IngestEncryptedPayloadsResponse other)
        {
            if (other == null)
            {
                return;
            }
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalMergeFrom(ref ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                if ((tag & 7) == 4)
                {
                    // Abort on any end group tag.
                    return;
                }
                switch (tag)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                }
            }
        }
#endif

    }

    #endregion

}
