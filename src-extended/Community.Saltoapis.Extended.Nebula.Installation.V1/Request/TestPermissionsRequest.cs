namespace Saltoapis.Nebula.Installation.V1.Request
{
    /// <summary>
    /// The request message for [`TestPermissions`][salto.nebula.installation.v1.InstallationService.TestPermissions]
    /// </summary>
    public sealed partial class TestPermissionsRequest : IMessage<TestPermissionsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<TestPermissionsRequest> _parser = new(() => new TestPermissionsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<TestPermissionsRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => InstallationReflection.Descriptor.MessageTypes[21];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public TestPermissionsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public TestPermissionsRequest(TestPermissionsRequest other) : this()
        {
            installation_ = other.installation_;
            permissions_ = other.permissions_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public TestPermissionsRequest Clone() => new(this);
        /// <summary>Field number for the "installation" field.</summary>
        public const int InstallationFieldNumber = 1;
        private string installation_ = "";
        /// <summary>
        /// The resource name for which the policy detail is being requested. For
        /// example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Installation
        {
            get => installation_; set => installation_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "permissions" field.</summary>
        public const int PermissionsFieldNumber = 2;
        private static readonly FieldCodec<string> _repeated_permissions_codec
            = FieldCodec.ForString(18);
        private readonly RepeatedField<string> permissions_ = [];
        /// <summary>
        /// The set of permissions to check for the `resource_name`. Permissions with
        /// wildcards (such as '*' or 'nebula.access-point.*') are not allowed.
        /// </summary>
        public RepeatedField<string> Permissions
        {
            get => permissions_;}

        public override bool Equals(object other) => Equals(other as TestPermissionsRequest);
        public bool Equals(TestPermissionsRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Installation != other.Installation) || (!permissions_.Equals(other.permissions_))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Installation.Length != 0) hash ^= Installation.GetHashCode();
            hash ^= permissions_.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Installation.Length != 0)
      {
        output.WriteRawTag(10);
        output.WriteString(Installation);
      }
      permissions_.WriteTo(output, _repeated_permissions_codec);
      if (_unknownFields != null)
      {
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
            permissions_.WriteTo(ref output, _repeated_permissions_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Installation.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Installation);
            size += permissions_.CalculateSize(_repeated_permissions_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(TestPermissionsRequest other)
        {
            if (other == null) return;
            if (other.Installation.Length != 0) Installation = other.Installation;
            permissions_.Add(other.permissions_);
            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0)
      {
      if ((tag & 7) == 4)
      {
        // Abort on any end group tag.
        return;
      }
      switch(tag)
      {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10:
          {
            Installation = input.ReadString();
            break;
          }
          case 18:
          {
            permissions_.AddEntriesFrom(input, _repeated_permissions_codec);
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
                            permissions_.AddEntriesFrom(ref input, _repeated_permissions_codec);
                            break;
                        }
                }
            }
        }
#endif
    }

}