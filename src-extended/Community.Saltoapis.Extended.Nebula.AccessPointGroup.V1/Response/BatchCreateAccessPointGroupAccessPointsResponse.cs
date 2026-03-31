namespace Saltoapis.Nebula.AccessPointGroup.V1.Response
{
    /// <summary>
    /// The response message for [`BatchCreateAccessPointGroupAccessPoints`][salto.nebula.user.v1.AccessPointGroupService.BatchCreateAccessPointGroupAccessPoints]
    /// </summary>
    public sealed partial class BatchCreateAccessPointGroupAccessPointsResponse : IMessage<BatchCreateAccessPointGroupAccessPointsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchCreateAccessPointGroupAccessPointsResponse> _parser = new(() => new BatchCreateAccessPointGroupAccessPointsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchCreateAccessPointGroupAccessPointsResponse> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => AccessPointGroupReflection.Descriptor.MessageTypes[10];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public BatchCreateAccessPointGroupAccessPointsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchCreateAccessPointGroupAccessPointsResponse(BatchCreateAccessPointGroupAccessPointsResponse other) : this()
        {
            accessPointGroupAccessPoints_ = other.accessPointGroupAccessPoints_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchCreateAccessPointGroupAccessPointsResponse Clone() => new(this);
        /// <summary>Field number for the "access_point_group_access_points" field.</summary>
        public const int AccessPointGroupAccessPointsFieldNumber = 1;
        private static readonly FieldCodec<AccessPointGroupAccessPoint> _repeated_accessPointGroupAccessPoints_codec
            = FieldCodec.ForMessage(10, AccessPointGroupAccessPoint.Parser);
        private readonly RepeatedField<AccessPointGroupAccessPoint> accessPointGroupAccessPoints_ = [];
        /// <summary>
        /// Access point group access points created.
        /// </summary>
        public RepeatedField<AccessPointGroupAccessPoint> AccessPointGroupAccessPoints
        {
            get => accessPointGroupAccessPoints_;}

        public override bool Equals(object other) => Equals(other as BatchCreateAccessPointGroupAccessPointsResponse);
        public bool Equals(BatchCreateAccessPointGroupAccessPointsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!accessPointGroupAccessPoints_.Equals(other.accessPointGroupAccessPoints_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= accessPointGroupAccessPoints_.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      accessPointGroupAccessPoints_.WriteTo(output, _repeated_accessPointGroupAccessPoints_codec);
      if (_unknownFields != null)
      {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            accessPointGroupAccessPoints_.WriteTo(ref output, _repeated_accessPointGroupAccessPoints_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += accessPointGroupAccessPoints_.CalculateSize(_repeated_accessPointGroupAccessPoints_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(BatchCreateAccessPointGroupAccessPointsResponse other)
        {
            if (other == null) return;
            accessPointGroupAccessPoints_.Add(other.accessPointGroupAccessPoints_);
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
            accessPointGroupAccessPoints_.AddEntriesFrom(input, _repeated_accessPointGroupAccessPoints_codec);
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
                            accessPointGroupAccessPoints_.AddEntriesFrom(ref input, _repeated_accessPointGroupAccessPoints_codec);
                            break;
                        }
                }
            }
        }
#endif
    }

}