namespace Saltoapis.Nebula.ElectronicKey.V1.Request
{
    /// <summary>
    /// The request message for [CreateElectronicKey][salto.nebula.electronickey.v1.ElectronicKeyService.CreateElectronicKey]
    /// </summary>
    public sealed partial class CreateElectronicKeyRequest : IMessage<CreateElectronicKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateElectronicKeyRequest> _parser = new(() => new CreateElectronicKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateElectronicKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ElectronicKeyReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateElectronicKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateElectronicKeyRequest(CreateElectronicKeyRequest other) : this()
        {
            parent_ = other.parent_;
            electronicKeyId_ = other.electronicKeyId_;
            electronicKey_ = other.electronicKey_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateElectronicKeyRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where to create the electronic key. For
        /// example, `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "electronic_key_id" field.</summary>
        public const int ElectronicKeyIdFieldNumber = 2;
        private readonly static string ElectronicKeyIdDefaultValue = "";

        private string electronicKeyId_;

        /// <summary>
        /// The electronic key ID to use for this electronic key. In case it's empty the
        /// server will autogenerate a unique identifier.
        /// </summary>
        public string ElectronicKeyId
        {
            get { return electronicKeyId_ ?? ElectronicKeyIdDefaultValue; }
            set
            {
                electronicKeyId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "electronic_key_id" field is set</summary>
        public bool HasElectronicKeyId
        {
            get { return electronicKeyId_ != null; }
        }

        /// <summary>Clears the value of the "electronic_key_id" field</summary>
        public void ClearElectronicKeyId()
        {
            electronicKeyId_ = null;
        }

        /// <summary>Field number for the "electronic_key" field.</summary>
        public const int ElectronicKeyFieldNumber = 3;
        private ElectronicKey electronicKey_;

        /// <summary>
        /// The electronic key resource to be created. Client must not set the
        /// `ElectronicKey.name` field.
        /// </summary>
        public ElectronicKey ElectronicKey
        {
            get { return electronicKey_; }
            set
            {
                electronicKey_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateElectronicKeyRequest);
        public bool Equals(CreateElectronicKeyRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (ElectronicKeyId != other.ElectronicKeyId)) return false;
            if (!Equals(ElectronicKey, other.ElectronicKey)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasElectronicKeyId) hash ^= ElectronicKeyId.GetHashCode();
            if (electronicKey_ != null) hash ^= ElectronicKey.GetHashCode();
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
      if (HasElectronicKeyId) {
        output.WriteRawTag(18);
        output.WriteString(ElectronicKeyId);
      }
      if (electronicKey_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ElectronicKey);
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
            if (HasElectronicKeyId)
            {
                output.WriteRawTag(18);
                output.WriteString(ElectronicKeyId);
            }
            if (electronicKey_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(ElectronicKey);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (HasElectronicKeyId) size += 1 + CodedOutputStream.ComputeStringSize(ElectronicKeyId);
            if (electronicKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(ElectronicKey);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateElectronicKeyRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.HasElectronicKeyId) ElectronicKeyId = other.ElectronicKeyId;
            if (other.electronicKey_ != null)
            {
                if (electronicKey_ == null) ElectronicKey = new ElectronicKey();
                ElectronicKey.MergeFrom(other.ElectronicKey);
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
          case 18: {
            ElectronicKeyId = input.ReadString();
            break;
          }
          case 26: {
            if (electronicKey_ == null) {
              ElectronicKey = new Saltoapis.Nebula.ElectronicKey.V1.ElectronicKey();
            }
            input.ReadMessage(ElectronicKey);
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
                    case 18:
                        {
                            ElectronicKeyId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (electronicKey_ == null) ElectronicKey = new ElectronicKey();
                            input.ReadMessage(ElectronicKey);
                            break;
                        }
                }
            }
        }
#endif

    }


}
