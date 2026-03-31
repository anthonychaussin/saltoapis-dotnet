namespace Saltoapis.Nebula.Extender.V1.Request
{
    /// <summary>
    /// The request message for [`UpdateExtenderFirmware`][salto.nebula.extender.v1.ExtenderService.UpdateExtenderFirmware]
    /// </summary>
    public sealed partial class UpdateExtenderFirmwareRequest : IMessage<UpdateExtenderFirmwareRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateExtenderFirmwareRequest> _parser = new(() => new UpdateExtenderFirmwareRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateExtenderFirmwareRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[11]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateExtenderFirmwareRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateExtenderFirmwareRequest(UpdateExtenderFirmwareRequest other) : this()
        {
            extender_ = other.extender_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateExtenderFirmwareRequest Clone() => new(this);
        /// <summary>Field number for the "extender" field.</summary>
        public const int ExtenderFieldNumber = 1;
        private string extender_ = "";

        /// <summary>
        /// The resource name of the extender whose firmware will be updated, for
        /// example:
        /// `installations/surelock-homes-hq/extenders/elementary`.
        /// </summary>
        public string Extender
        {
            get { return extender_; }
            set
            {
                extender_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateExtenderFirmwareRequest);
        public bool Equals(UpdateExtenderFirmwareRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (Extender != other.Extender) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Extender.Length != 0) hash ^= Extender.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Extender.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Extender);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Extender.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Extender);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Extender.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Extender);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateExtenderFirmwareRequest other)
        {
            if (other == null) return;
            if (other.Extender.Length != 0) Extender = other.Extender;
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
            Extender = input.ReadString();
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
                            Extender = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }


}
