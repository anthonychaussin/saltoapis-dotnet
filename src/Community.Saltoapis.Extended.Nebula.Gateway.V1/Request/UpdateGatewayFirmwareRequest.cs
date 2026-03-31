namespace Saltoapis.Nebula.Gateway.V1.Request
{
    /// <summary>
    /// The request message for [`UpdateGatewayFirmware`][salto.nebula.gateway.v1.GatewayService.UpdateGatewayFirmware]
    /// </summary>
    public sealed partial class UpdateGatewayFirmwareRequest : IMessage<UpdateGatewayFirmwareRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateGatewayFirmwareRequest> _parser = new(() => new UpdateGatewayFirmwareRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateGatewayFirmwareRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[24]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateGatewayFirmwareRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateGatewayFirmwareRequest(UpdateGatewayFirmwareRequest other) : this()
        {
            gateway_ = other.gateway_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateGatewayFirmwareRequest Clone() => new(this);
        /// <summary>Field number for the "gateway" field.</summary>
        public const int GatewayFieldNumber = 1;
        private string gateway_ = "";

        /// <summary>
        /// The resource name of the gateway whose firmware will be updated, for
        /// example:
        /// `installations/surelock-homes-hq/gateways/conan-doyle`.
        /// </summary>
        public string Gateway
        {
            get { return gateway_; }
            set
            {
                gateway_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateGatewayFirmwareRequest);
        public bool Equals(UpdateGatewayFirmwareRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (Gateway != other.Gateway) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Gateway.Length != 0) hash ^= Gateway.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Gateway.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Gateway);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Gateway.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Gateway);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Gateway.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Gateway);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateGatewayFirmwareRequest other)
        {
            if (other == null) return;
            if (other.Gateway.Length != 0) Gateway = other.Gateway;
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
            Gateway = input.ReadString();
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
                            Gateway = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }


}
