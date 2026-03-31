namespace Saltoapis.Nebula.AccessRight.V1.Request
{
    /// <summary>
    /// The request message for [`BatchCreateAccessRightAccessPointGroupsRequest`][salto.nebula.user.v1.AccessRightService.BatchCreateAccessRightAccessPointGroups]
    /// </summary>
    public sealed partial class BatchCreateAccessRightAccessPointGroupsRequest : IMessage<BatchCreateAccessRightAccessPointGroupsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchCreateAccessRightAccessPointGroupsRequest> _parser = new(() => new BatchCreateAccessRightAccessPointGroupsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchCreateAccessRightAccessPointGroupsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[19]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchCreateAccessRightAccessPointGroupsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchCreateAccessRightAccessPointGroupsRequest(BatchCreateAccessRightAccessPointGroupsRequest other) : this()
        {
            parent_ = other.parent_;
            requests_ = other.requests_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchCreateAccessRightAccessPointGroupsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the access right's access point groups
        /// associations are to be created. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "requests" field.</summary>
        public const int RequestsFieldNumber = 2;
        private static readonly FieldCodec<CreateAccessRightAccessPointGroupRequest> _repeated_requests_codec
            = FieldCodec.ForMessage(18, CreateAccessRightAccessPointGroupRequest.Parser);
        private readonly RepeatedField<CreateAccessRightAccessPointGroupRequest> requests_ = [];

        /// <summary>
        /// The request message specifying the resources to create.
        /// A maximum of 100 access right's access point groups can be created in a batch.
        /// </summary>
        public RepeatedField<CreateAccessRightAccessPointGroupRequest> Requests
        {
            get { return requests_; }
        }

        public override bool Equals(object other) => Equals(other as BatchCreateAccessRightAccessPointGroupsRequest);
        public bool Equals(BatchCreateAccessRightAccessPointGroupsRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (!requests_.Equals(other.requests_))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            hash ^= requests_.GetHashCode();
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
      requests_.WriteTo(output, _repeated_requests_codec);
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
            requests_.WriteTo(ref output, _repeated_requests_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            size += requests_.CalculateSize(_repeated_requests_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(BatchCreateAccessRightAccessPointGroupsRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            requests_.Add(other.requests_);
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
            requests_.AddEntriesFrom(input, _repeated_requests_codec);
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
                            requests_.AddEntriesFrom(ref input, _repeated_requests_codec);
                            break;
                        }
                }
            }
        }
#endif

    }


}
