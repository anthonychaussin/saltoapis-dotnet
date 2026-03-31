namespace Saltoapis.Nebula.Gateway.V1.Request
{
    /// <summary>
    /// The request message for [CreateGateway][salto.nebula.gateway.v1.GatewayService.CreateGateway]
    /// </summary>
    public sealed partial class CreateGatewayRequest : IMessage<CreateGatewayRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateGatewayRequest> _parser = new(() => new CreateGatewayRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateGatewayRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => GatewayReflection.Descriptor.MessageTypes[5];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public CreateGatewayRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateGatewayRequest(CreateGatewayRequest other) : this()
        {
            parent_ = other.parent_;
            gatewayId_ = other.gatewayId_;
            gateway_ = other.gateway_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateGatewayRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";
        /// <summary>
        /// Resource name of the parent resource where to create the gateway. For
        /// example, `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get => parent_; set => parent_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "gateway_id" field.</summary>
        public const int GatewayIdFieldNumber = 2;
        private static readonly string GatewayIdDefaultValue = "";

        private string gatewayId_;
        /// <summary>
        /// The gateway ID to use for this gateway. In case it's empty the
        /// server will autogenerate a unique identifier.
        /// </summary>
        public string GatewayId
        {
            get => gatewayId_ ?? GatewayIdDefaultValue; set => gatewayId_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Gets whether the "gateway_id" field is set</summary>
        public bool HasGatewayId => gatewayId_ != null;
        /// <summary>Clears the value of the "gateway_id" field</summary>
        public void ClearGatewayId() => gatewayId_ = null;
        /// <summary>Field number for the "gateway" field.</summary>
        public const int GatewayFieldNumber = 3;
        private Gateway gateway_;
        /// <summary>
        /// The gateway resource to be created. Client must not set the
        /// `Gateway.name` field.
        /// </summary>
        public Gateway Gateway
        {
            get => gateway_; set => gateway_ = value;}

        public override bool Equals(object other) => Equals(other as CreateGatewayRequest);
        public bool Equals(CreateGatewayRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (GatewayId != other.GatewayId) || !Equals(Gateway, other.Gateway)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasGatewayId) hash ^= GatewayId.GetHashCode();
            if (gateway_ != null) hash ^= Gateway.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Parent.Length != 0)
      {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (HasGatewayId)
      {
        output.WriteRawTag(18);
        output.WriteString(GatewayId);
      }
      if (gateway_ != null)
      {
        output.WriteRawTag(26);
        output.WriteMessage(Gateway);
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
            if (Parent.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Parent);
            }
            if (HasGatewayId)
            {
                output.WriteRawTag(18);
                output.WriteString(GatewayId);
            }
            if (gateway_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Gateway);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (HasGatewayId) size += 1 + CodedOutputStream.ComputeStringSize(GatewayId);
            if (gateway_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Gateway);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateGatewayRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.HasGatewayId) GatewayId = other.GatewayId;
            if (other.gateway_ != null)
            {
                if (gateway_ == null) Gateway = new Gateway();
                Gateway.MergeFrom(other.Gateway);
            }
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
            Parent = input.ReadString();
            break;
          }
          case 18:
          {
            GatewayId = input.ReadString();
            break;
          }
          case 26:
          {
            if (gateway_ == null)
            {
              Gateway = new Saltoapis.Nebula.Gateway.V1.Gateway();
            }
            input.ReadMessage(Gateway);
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
                            GatewayId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (gateway_ == null) Gateway = new Gateway();
                            input.ReadMessage(Gateway);
                            break;
                        }
                }
            }
        }
#endif
    }

}