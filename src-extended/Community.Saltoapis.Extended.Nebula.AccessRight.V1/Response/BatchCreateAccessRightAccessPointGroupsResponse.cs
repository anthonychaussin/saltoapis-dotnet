namespace Saltoapis.Nebula.AccessRight.V1.Response
{
    /// <summary>
    /// The response message for [`BatchCreateAccessRightAccessPointGroups`][salto.nebula.user.v1.AccessRightService.BatchCreateAccessRightAccessPointGroups]
    /// </summary>
    public sealed partial class BatchCreateAccessRightAccessPointGroupsResponse : IMessage<BatchCreateAccessRightAccessPointGroupsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchCreateAccessRightAccessPointGroupsResponse> _parser = new(() => new BatchCreateAccessRightAccessPointGroupsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchCreateAccessRightAccessPointGroupsResponse> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => AccessRightReflection.Descriptor.MessageTypes[20];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public BatchCreateAccessRightAccessPointGroupsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchCreateAccessRightAccessPointGroupsResponse(BatchCreateAccessRightAccessPointGroupsResponse other) : this()
        {
            accessRightAccessPointGroups_ = other.accessRightAccessPointGroups_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchCreateAccessRightAccessPointGroupsResponse Clone() => new(this);
        /// <summary>Field number for the "access_right_access_point_groups" field.</summary>
        public const int AccessRightAccessPointGroupsFieldNumber = 1;
        private static readonly FieldCodec<AccessRightAccessPointGroup> _repeated_accessRightAccessPointGroups_codec
            = FieldCodec.ForMessage(10, AccessRightAccessPointGroup.Parser);
        private readonly RepeatedField<AccessRightAccessPointGroup> accessRightAccessPointGroups_ = [];
        /// <summary>
        /// Access right's access point groups created.
        /// </summary>
        public RepeatedField<AccessRightAccessPointGroup> AccessRightAccessPointGroups
        {
            get => accessRightAccessPointGroups_;}

        public override bool Equals(object other) => Equals(other as BatchCreateAccessRightAccessPointGroupsResponse);
        public bool Equals(BatchCreateAccessRightAccessPointGroupsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!accessRightAccessPointGroups_.Equals(other.accessRightAccessPointGroups_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= accessRightAccessPointGroups_.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      accessRightAccessPointGroups_.WriteTo(output, _repeated_accessRightAccessPointGroups_codec);
      if (_unknownFields != null)
      {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            accessRightAccessPointGroups_.WriteTo(ref output, _repeated_accessRightAccessPointGroups_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += accessRightAccessPointGroups_.CalculateSize(_repeated_accessRightAccessPointGroups_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(BatchCreateAccessRightAccessPointGroupsResponse other)
        {
            if (other == null) return;
            accessRightAccessPointGroups_.Add(other.accessRightAccessPointGroups_);
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
            accessRightAccessPointGroups_.AddEntriesFrom(input, _repeated_accessRightAccessPointGroups_codec);
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
                            accessRightAccessPointGroups_.AddEntriesFrom(ref input, _repeated_accessRightAccessPointGroups_codec);
                            break;
                        }
                }
            }
        }
#endif
    }

}