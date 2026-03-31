namespace Saltoapis.Nebula.Destination.V1.Request
{
    /// <summary>
    /// The request message for [`CreateDestination`][salto.nebula.destination.v1.DestinationService.CreateDestination]
    /// </summary>
    public sealed partial class CreateDestinationRequest : IMessage<CreateDestinationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateDestinationRequest> _parser = new(() => new CreateDestinationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateDestinationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DestinationReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateDestinationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateDestinationRequest(CreateDestinationRequest other) : this()
        {
            parent_ = other.parent_;
            destinationId_ = other.destinationId_;
            destination_ = other.destination_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateDestinationRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource under which the destination is created. For
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

        /// <summary>Field number for the "destination_id" field.</summary>
        public const int DestinationIdFieldNumber = 2;
        private static readonly string DestinationIdDefaultValue = "";

        private string destinationId_;

        /// <summary>
        /// The destination id to use for this destination. If it's empty the server will
        /// autogenerate a unique identifier.
        /// </summary>
        public string DestinationId
        {
            get { return destinationId_ ?? DestinationIdDefaultValue; }
            set
            {
                destinationId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "destination_id" field is set</summary>
        public bool HasDestinationId
        {
            get { return destinationId_ != null; }
        }

        /// <summary>Clears the value of the "destination_id" field</summary>
        public void ClearDestinationId()
        {
            destinationId_ = null;
        }

        /// <summary>Field number for the "destination" field.</summary>
        public const int DestinationFieldNumber = 3;
        private Destination destination_;

        /// <summary>
        /// The destination resource to be created. Client must not set the `Destination.name`
        /// field.
        /// </summary>
        public Destination Destination
        {
            get { return destination_; }
            set
            {
                destination_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateDestinationRequest);
        public bool Equals(CreateDestinationRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (DestinationId != other.DestinationId)) return false;
            if (!Equals(Destination, other.Destination)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasDestinationId) hash ^= DestinationId.GetHashCode();
            if (destination_ != null) hash ^= Destination.GetHashCode();
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
      if (HasDestinationId) {
        output.WriteRawTag(18);
        output.WriteString(DestinationId);
      }
      if (destination_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Destination);
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
            if (HasDestinationId)
            {
                output.WriteRawTag(18);
                output.WriteString(DestinationId);
            }
            if (destination_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Destination);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (HasDestinationId) size += 1 + CodedOutputStream.ComputeStringSize(DestinationId);
            if (destination_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Destination);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateDestinationRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.HasDestinationId) DestinationId = other.DestinationId;
            if (other.destination_ != null)
            {
                if (destination_ == null) Destination = new Destination();
                Destination.MergeFrom(other.Destination);
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
            DestinationId = input.ReadString();
            break;
          }
          case 26: {
            if (destination_ == null) {
              Destination = new Saltoapis.Nebula.Destination.V1.Destination();
            }
            input.ReadMessage(Destination);
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
                            DestinationId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (destination_ == null) Destination = new Destination();
                            input.ReadMessage(Destination);
                            break;
                        }
                }
            }
        }
#endif

    }


}
