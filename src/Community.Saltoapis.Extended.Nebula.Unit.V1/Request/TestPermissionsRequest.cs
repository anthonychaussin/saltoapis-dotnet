namespace Saltoapis.Nebula.Unit.V1.Request
{
    /// <summary>
    /// The request message for [`TestPermissions`][salto.nebula.unit.v1.UnitService.TestPermissions]
    /// </summary>
    public sealed partial class TestPermissionsRequest : IMessage<TestPermissionsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<TestPermissionsRequest> _parser = new(() => new TestPermissionsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<TestPermissionsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[20]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public TestPermissionsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public TestPermissionsRequest(TestPermissionsRequest other) : this()
        {
            unit_ = other.unit_;
            permissions_ = other.permissions_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public TestPermissionsRequest Clone() => new(this);
        /// <summary>Field number for the "unit" field.</summary>
        public const int UnitFieldNumber = 1;
        private string unit_ = "";

        /// <summary>
        /// The resource name for which the policy detail is being requested, for
        /// example: `installations/surelock-homes-hq/units/101`.
        /// </summary>
        public string Unit
        {
            get { return unit_; }
            set
            {
                unit_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

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
            get { return permissions_; }
        }

        public override bool Equals(object other) => Equals(other as TestPermissionsRequest);
        public bool Equals(TestPermissionsRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Unit != other.Unit) || (!permissions_.Equals(other.permissions_))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Unit.Length != 0) hash ^= Unit.GetHashCode();
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
      if (Unit.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Unit);
      }
      permissions_.WriteTo(output, _repeated_permissions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Unit.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Unit);
            }
            permissions_.WriteTo(ref output, _repeated_permissions_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Unit.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Unit);
            size += permissions_.CalculateSize(_repeated_permissions_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(TestPermissionsRequest other)
        {
            if (other == null) return;
            if (other.Unit.Length != 0) Unit = other.Unit;
            permissions_.Add(other.permissions_);
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
            Unit = input.ReadString();
            break;
          }
          case 18: {
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
                            Unit = input.ReadString();
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
