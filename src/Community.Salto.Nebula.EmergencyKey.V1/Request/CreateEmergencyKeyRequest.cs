namespace Salto.Nebula.EmergencyKey.V1.Request
{
    /// <summary>
    /// The request message for [`CreateEmergencyKey`][salto.nebula.emergencykey.v1.EmergencyKeyService.CreateEmergencyKey].
    /// </summary>
    public sealed partial class CreateEmergencyKeyRequest : IMessage<CreateEmergencyKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateEmergencyKeyRequest> _parser = new(() => new CreateEmergencyKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateEmergencyKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EmergencyKeyReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateEmergencyKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateEmergencyKeyRequest(CreateEmergencyKeyRequest other) : this()
        {
            parent_ = other.parent_;
            emergencyKey_ = other.emergencyKey_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateEmergencyKeyRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the access right is to be
        /// created. For example: ìnstallations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "emergency_key" field.</summary>
        public const int EmergencyKeyFieldNumber = 3;
        private EmergencyKey emergencyKey_;

        /// <summary>
        /// The emergency key resource to be created. Client must not set the
        /// `EmergencyKey.name` field.
        /// </summary>
        public EmergencyKey EmergencyKey
        {
            get { return emergencyKey_; }
            set
            {
                emergencyKey_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateEmergencyKeyRequest);
        public bool Equals(CreateEmergencyKeyRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (!Equals(EmergencyKey, other.EmergencyKey))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (emergencyKey_ != null) hash ^= EmergencyKey.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (emergencyKey_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(EmergencyKey);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Parent.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Parent);
            }
            if (emergencyKey_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(EmergencyKey);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (emergencyKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(EmergencyKey);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateEmergencyKeyRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.emergencyKey_ != null)
            {
                if (emergencyKey_ == null) EmergencyKey = new EmergencyKey();
                EmergencyKey.MergeFrom(other.EmergencyKey);
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
          case 10: {
            Parent = input.ReadString();
            break;
          }
          case 26: {
            if (emergencyKey_ == null) {
              EmergencyKey = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
            }
            input.ReadMessage(EmergencyKey);
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
                            Parent = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (emergencyKey_ == null) EmergencyKey = new EmergencyKey();
                            input.ReadMessage(EmergencyKey);
                            break;
                        }
                }
            }
        }
#endif

    }

}
