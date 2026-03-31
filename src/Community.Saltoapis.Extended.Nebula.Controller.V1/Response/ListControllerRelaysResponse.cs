namespace Saltoapis.Nebula.Controller.V1.Response
{
    /// <summary>
    /// The response message for [ListControllerRelays][salto.nebula.controllers.v1.ControllerService.ListControllerRelays]
    /// </summary>
    public sealed partial class ListControllerRelaysResponse : IMessage<ListControllerRelaysResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListControllerRelaysResponse> _parser = new(() => new ListControllerRelaysResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListControllerRelaysResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[32]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListControllerRelaysResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListControllerRelaysResponse(ListControllerRelaysResponse other) : this()
        {
            controllerRelays_ = other.controllerRelays_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListControllerRelaysResponse Clone() => new(this);
        /// <summary>Field number for the "controller_relays" field.</summary>
        public const int ControllerRelaysFieldNumber = 1;
        private static readonly FieldCodec<ControllerRelay> _repeated_controllerRelays_codec
            = FieldCodec.ForMessage(10, ControllerRelay.Parser);
        private readonly RepeatedField<ControllerRelay> controllerRelays_ = [];

        /// <summary>
        /// The field name should match the noun `relays` in the method name. There
        /// will be a maximum number of items returned based on the `page_size` field
        /// in the request.
        /// </summary>
        public RepeatedField<ControllerRelay> ControllerRelays
        {
            get { return controllerRelays_; }
        }

        /// <summary>Field number for the "next_page_token" field.</summary>
        public const int NextPageTokenFieldNumber = 2;
        private string nextPageToken_ = "";

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more
        /// results in the list.
        /// </summary>
        public string NextPageToken
        {
            get { return nextPageToken_; }
            set
            {
                nextPageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListControllerRelaysResponse);
        public bool Equals(ListControllerRelaysResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!controllerRelays_.Equals(other.controllerRelays_)) || (NextPageToken != other.NextPageToken)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= controllerRelays_.GetHashCode();
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
      controllerRelays_.WriteTo(output, _repeated_controllerRelays_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            controllerRelays_.WriteTo(ref output, _repeated_controllerRelays_codec);
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
            size += controllerRelays_.CalculateSize(_repeated_controllerRelays_codec);
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListControllerRelaysResponse other)
        {
            if (other == null) return;
            controllerRelays_.Add(other.controllerRelays_);
            if (other.NextPageToken.Length != 0) NextPageToken = other.NextPageToken;
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
            controllerRelays_.AddEntriesFrom(input, _repeated_controllerRelays_codec);
            break;
          }
          case 18: {
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
                            controllerRelays_.AddEntriesFrom(ref input, _repeated_controllerRelays_codec);
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
