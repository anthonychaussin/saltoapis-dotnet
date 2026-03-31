using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Destination.V1.Response
{
    /// <summary>
    /// The response message for [`BatchGetDestinations`][salto.nebula.destination.v1.DestinationService.BatchGetDestinations]
    /// </summary>
    public sealed partial class BatchGetDestinationsResponse : IMessage<BatchGetDestinationsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchGetDestinationsResponse> _parser = new(() => new BatchGetDestinationsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchGetDestinationsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DestinationReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchGetDestinationsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchGetDestinationsResponse(BatchGetDestinationsResponse other) : this()
        {
            destinations_ = other.destinations_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchGetDestinationsResponse Clone() => new(this);
        /// <summary>Field number for the "destinations" field.</summary>
        public const int DestinationsFieldNumber = 1;
        private static readonly FieldCodec<Destination> _repeated_destinations_codec
            = FieldCodec.ForMessage(10, Destination.Parser);
        private readonly RepeatedField<Destination> destinations_ = [];

        /// <summary>
        /// Destinations requested.
        /// </summary>
        public RepeatedField<Destination> Destinations
        {
            get { return destinations_; }
        }

        public override bool Equals(object other) => Equals(other as BatchGetDestinationsResponse);
        public bool Equals(BatchGetDestinationsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!destinations_.Equals(other.destinations_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= destinations_.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      destinations_.WriteTo(output, _repeated_destinations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            destinations_.WriteTo(ref output, _repeated_destinations_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += destinations_.CalculateSize(_repeated_destinations_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(BatchGetDestinationsResponse other)
        {
            if (other == null) return;
            destinations_.Add(other.destinations_);
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
            destinations_.AddEntriesFrom(input, _repeated_destinations_codec);
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
                            destinations_.AddEntriesFrom(ref input, _repeated_destinations_codec);
                            break;
                        }
                }
            }
        }
#endif

    }


}
