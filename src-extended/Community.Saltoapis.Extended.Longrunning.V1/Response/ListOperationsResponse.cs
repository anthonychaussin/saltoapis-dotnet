namespace Saltoapis.Longrunning.V1.Response
{
    /// <summary>
    /// The response message for
    /// [`Operations.ListOperations`][salto.longrunning.v1.OperationService.ListOperations].
    /// </summary>
    public sealed partial class ListOperationsResponse : IMessage<ListOperationsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListOperationsResponse> _parser = new(() => new ListOperationsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListOperationsResponse> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => OperationReflection.Descriptor.MessageTypes[3];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public ListOperationsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListOperationsResponse(ListOperationsResponse other) : this()
        {
            operations_ = other.operations_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListOperationsResponse Clone() => new(this);
        /// <summary>Field number for the "operations" field.</summary>
        public const int OperationsFieldNumber = 1;
        private static readonly FieldCodec<Operation> _repeated_operations_codec
            = FieldCodec.ForMessage(10, Operation.Parser);
        private readonly RepeatedField<Operation> operations_ = [];
        /// <summary>
        /// A list of operations that matches the specified filter in the request.
        /// </summary>
        public RepeatedField<Operation> Operations
        {
            get => operations_;}
        /// <summary>Field number for the "next_page_token" field.</summary>
        public const int NextPageTokenFieldNumber = 2;
        private string nextPageToken_ = "";
        /// <summary>
        /// The standard List next-page token.
        /// </summary>
        public string NextPageToken
        {
            get => nextPageToken_; set => nextPageToken_ = ProtoPreconditions.CheckNotNull(value, "value");}

        public override bool Equals(object other) => Equals(other as ListOperationsResponse);
        public bool Equals(ListOperationsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!operations_.Equals(other.operations_)) || (NextPageToken != other.NextPageToken)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= operations_.GetHashCode();
            if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      operations_.WriteTo(output, _repeated_operations_codec);
      if (NextPageToken.Length != 0)
      {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      if (_unknownFields != null)
      {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            operations_.WriteTo(ref output, _repeated_operations_codec);
            if (NextPageToken.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(NextPageToken);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += operations_.CalculateSize(_repeated_operations_codec);
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListOperationsResponse other)
        {
            if (other == null) return;
            operations_.Add(other.operations_);
            if (other.NextPageToken.Length != 0) NextPageToken = other.NextPageToken;
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
            operations_.AddEntriesFrom(input, _repeated_operations_codec);
            break;
          }
          case 18:
          {
            NextPageToken = input.ReadString();
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
                            operations_.AddEntriesFrom(ref input, _repeated_operations_codec);
                            break;
                        }
                    case 18:
                        {
                            NextPageToken = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif
    }

}