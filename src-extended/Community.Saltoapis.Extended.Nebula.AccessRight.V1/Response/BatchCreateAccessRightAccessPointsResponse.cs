namespace Saltoapis.Nebula.AccessRight.V1.Response
{
    /// <summary>
    /// The response message for [`BatchCreateAccessRightAccessPoints`][salto.nebula.user.v1.AccessRightService.BatchCreateAccessRightAccessPoints]
    /// </summary>
    public sealed partial class BatchCreateAccessRightAccessPointsResponse : IMessage<BatchCreateAccessRightAccessPointsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchCreateAccessRightAccessPointsResponse> _parser = new(() => new BatchCreateAccessRightAccessPointsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchCreateAccessRightAccessPointsResponse> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => AccessRightReflection.Descriptor.MessageTypes[12];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public BatchCreateAccessRightAccessPointsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchCreateAccessRightAccessPointsResponse(BatchCreateAccessRightAccessPointsResponse other) : this()
        {
            accessRightAccessPoints_ = other.accessRightAccessPoints_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchCreateAccessRightAccessPointsResponse Clone() => new(this);
        /// <summary>Field number for the "access_right_access_points" field.</summary>
        public const int AccessRightAccessPointsFieldNumber = 1;
        private static readonly FieldCodec<AccessRightAccessPoint> _repeated_accessRightAccessPoints_codec
            = FieldCodec.ForMessage(10, AccessRightAccessPoint.Parser);
        private readonly RepeatedField<AccessRightAccessPoint> accessRightAccessPoints_ = [];
        /// <summary>
        /// Access right access points created.
        /// </summary>
        public RepeatedField<AccessRightAccessPoint> AccessRightAccessPoints
        {
            get => accessRightAccessPoints_;}

        public override bool Equals(object other) => Equals(other as BatchCreateAccessRightAccessPointsResponse);
        public bool Equals(BatchCreateAccessRightAccessPointsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!accessRightAccessPoints_.Equals(other.accessRightAccessPoints_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= accessRightAccessPoints_.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      accessRightAccessPoints_.WriteTo(output, _repeated_accessRightAccessPoints_codec);
      if (_unknownFields != null)
      {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            accessRightAccessPoints_.WriteTo(ref output, _repeated_accessRightAccessPoints_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += accessRightAccessPoints_.CalculateSize(_repeated_accessRightAccessPoints_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(BatchCreateAccessRightAccessPointsResponse other)
        {
            if (other == null) return;
            accessRightAccessPoints_.Add(other.accessRightAccessPoints_);
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
            accessRightAccessPoints_.AddEntriesFrom(input, _repeated_accessRightAccessPoints_codec);
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
                            accessRightAccessPoints_.AddEntriesFrom(ref input, _repeated_accessRightAccessPoints_codec);
                            break;
                        }
                }
            }
        }
#endif
    }

}