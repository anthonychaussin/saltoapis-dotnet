namespace Saltoapis.Nebula.Controller.V1.Response
{
    /// <summary>
    /// The response message for [`BatchCreateControllerRelays`][salto.nebula.controller.v1.ControllerService.BatchCreateControllerRelays]
    /// </summary>
    public sealed partial class BatchCreateControllerRelaysResponse : IMessage<BatchCreateControllerRelaysResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchCreateControllerRelaysResponse> _parser = new(() => new BatchCreateControllerRelaysResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchCreateControllerRelaysResponse> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => ControllerReflection.Descriptor.MessageTypes[38];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public BatchCreateControllerRelaysResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchCreateControllerRelaysResponse(BatchCreateControllerRelaysResponse other) : this()
        {
            controllerRelays_ = other.controllerRelays_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchCreateControllerRelaysResponse Clone() => new(this);
        /// <summary>Field number for the "controller_relays" field.</summary>
        public const int ControllerRelaysFieldNumber = 1;
        private static readonly FieldCodec<ControllerRelay> _repeated_controllerRelays_codec
            = FieldCodec.ForMessage(10, ControllerRelay.Parser);
        private readonly RepeatedField<ControllerRelay> controllerRelays_ = [];
        /// <summary>
        /// The controller relay resources created.
        /// </summary>
        public RepeatedField<ControllerRelay> ControllerRelays
        {
            get => controllerRelays_;}

        public override bool Equals(object other) => Equals(other as BatchCreateControllerRelaysResponse);
        public bool Equals(BatchCreateControllerRelaysResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!controllerRelays_.Equals(other.controllerRelays_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= controllerRelays_.GetHashCode();
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
      if (_unknownFields != null)
      {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            controllerRelays_.WriteTo(ref output, _repeated_controllerRelays_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += controllerRelays_.CalculateSize(_repeated_controllerRelays_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(BatchCreateControllerRelaysResponse other)
        {
            if (other == null) return;
            controllerRelays_.Add(other.controllerRelays_);
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
            controllerRelays_.AddEntriesFrom(input, _repeated_controllerRelays_codec);
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
                }
            }
        }
#endif
    }

}