using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Installation.V1.Request
{
    /// <summary>
    /// The request message for [`CreateInstallation`][salto.nebula.installation.v1.InstallationService.CreateInstallation]
    /// </summary>
    public sealed partial class CreateInstallationRequest : IMessage<CreateInstallationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateInstallationRequest> _parser = new(() => new CreateInstallationRequest());
        private UnknownFieldSet _unknownFields;
        private int _hasBits0;

        public static MessageParser<CreateInstallationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateInstallationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateInstallationRequest(CreateInstallationRequest other) : this()
        {
            _hasBits0 = other._hasBits0;
            installationId_ = other.installationId_;
            installation_ = other.installation_?.Clone();
            validateOnly_ = other.validateOnly_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateInstallationRequest Clone() => new(this);
        /// <summary>Field number for the "installation_id" field.</summary>
        public const int InstallationIdFieldNumber = 1;
        private readonly static string InstallationIdDefaultValue = "";

        private string installationId_;

        /// <summary>
        /// The installation ID to use for this installation. In case it's
        /// empty the server will autogenerate a unique identifier.
        /// </summary>
        public string InstallationId
        {
            get { return installationId_ ?? InstallationIdDefaultValue; }
            set
            {
                installationId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "installation_id" field is set</summary>
        public bool HasInstallationId
        {
            get { return installationId_ != null; }
        }

        /// <summary>Clears the value of the "installation_id" field</summary>
        public void ClearInstallationId()
        {
            installationId_ = null;
        }

        /// <summary>Field number for the "installation" field.</summary>
        public const int InstallationFieldNumber = 2;
        private Installation installation_;

        /// <summary>
        /// The installation resource to be created. Client must not set the
        /// `Installation.name` field.
        /// </summary>
        public Installation Installation
        {
            get { return installation_; }
            set
            {
                installation_ = value;
            }
        }

        /// <summary>Field number for the "validate_only" field.</summary>
        public const int ValidateOnlyFieldNumber = 5;
        private readonly static bool ValidateOnlyDefaultValue = false;

        private bool validateOnly_;

        /// <summary>
        /// If set, validate the request but do not actually create the installation.
        /// </summary>
        public bool ValidateOnly
        {
            get { if ((_hasBits0 & 1) != 0) { return validateOnly_; } else { return ValidateOnlyDefaultValue; } }
            set
            {
                _hasBits0 |= 1;
                validateOnly_ = value;
            }
        }

        /// <summary>Gets whether the "validate_only" field is set</summary>
        public bool HasValidateOnly
        {
            get { return (_hasBits0 & 1) != 0; }
        }

        /// <summary>Clears the value of the "validate_only" field</summary>
        public void ClearValidateOnly()
        {
            _hasBits0 &= ~1;
        }

        public override bool Equals(object other) => Equals(other as CreateInstallationRequest);
        public bool Equals(CreateInstallationRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((InstallationId != other.InstallationId) || (!Equals(Installation, other.Installation))) return false;
            if (ValidateOnly != other.ValidateOnly) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (HasInstallationId) hash ^= InstallationId.GetHashCode();
            if (installation_ != null) hash ^= Installation.GetHashCode();
            if (HasValidateOnly) hash ^= ValidateOnly.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (HasInstallationId) {
        output.WriteRawTag(10);
        output.WriteString(InstallationId);
      }
      if (installation_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Installation);
      }
      if (HasValidateOnly) {
        output.WriteRawTag(40);
        output.WriteBool(ValidateOnly);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (HasInstallationId)
            {
                output.WriteRawTag(10);
                output.WriteString(InstallationId);
            }
            if (installation_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Installation);
            }
            if (HasValidateOnly)
            {
                output.WriteRawTag(40);
                output.WriteBool(ValidateOnly);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (HasInstallationId) size += 1 + CodedOutputStream.ComputeStringSize(InstallationId);
            if (installation_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Installation);
            if (HasValidateOnly) size += 1 + 1;
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateInstallationRequest other)
        {
            if (other == null) return;
            if (other.HasInstallationId) InstallationId = other.InstallationId;
            if (other.installation_ != null)
            {
                if (installation_ == null) Installation = new Installation();
                Installation.MergeFrom(other.Installation);
            }
            if (other.HasValidateOnly) ValidateOnly = other.ValidateOnly;
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
            InstallationId = input.ReadString();
            break;
          }
          case 18: {
            if (installation_ == null) {
              Installation = new Saltoapis.Nebula.Installation.V1.Installation();
            }
            input.ReadMessage(Installation);
            break;
          }
          case 40: {
            ValidateOnly = input.ReadBool();
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
                            InstallationId = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            if (installation_ == null) Installation = new Installation();
                            input.ReadMessage(Installation);
                            break;
                        }
                    case 40:
                        {
                            ValidateOnly = input.ReadBool();
                            break;
                        }
                }
            }
        }
#endif

    }


}
