namespace Saltoapis.Nebula.Installation.V1.Request
{
    /// <summary>
    /// The request message for [`TransferInstallationOwnership`][salto.nebula.installation.v1.InstallationService.TransferInstallationOwnership]
    /// </summary>
    public sealed partial class TransferInstallationOwnershipRequest : IMessage<TransferInstallationOwnershipRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<TransferInstallationOwnershipRequest> _parser = new(() => new TransferInstallationOwnershipRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<TransferInstallationOwnershipRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[23]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public TransferInstallationOwnershipRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public TransferInstallationOwnershipRequest(TransferInstallationOwnershipRequest other) : this()
        {
            installation_ = other.installation_;
            email_ = other.email_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public TransferInstallationOwnershipRequest Clone() => new(this);
        /// <summary>Field number for the "installation" field.</summary>
        public const int InstallationFieldNumber = 1;
        private string installation_ = "";

        /// <summary>
        /// The resource name for which the transfer ownership is being requested.
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

        /// <summary>Field number for the "email" field.</summary>
        public const int EmailFieldNumber = 2;
        private string email_ = "";

        /// <summary>
        /// Email address for the proposed installation owner.
        /// </summary>
        public string Email
        {
            get { return email_; }
            set
            {
                email_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as TransferInstallationOwnershipRequest);
        public bool Equals(TransferInstallationOwnershipRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Installation != other.Installation) || (Email != other.Email)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Installation.Length != 0) hash ^= Installation.GetHashCode();
            if (Email.Length != 0) hash ^= Email.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
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
      if (Email.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Email);
      }
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
            if (Email.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Email);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Installation.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Installation);
            if (Email.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Email);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(TransferInstallationOwnershipRequest other)
        {
            if (other == null) return;
            if (other.Installation.Length != 0) Installation = other.Installation;
            if (other.Email.Length != 0) Email = other.Email;
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
            Email = input.ReadString();
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
                            Email = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }


}
