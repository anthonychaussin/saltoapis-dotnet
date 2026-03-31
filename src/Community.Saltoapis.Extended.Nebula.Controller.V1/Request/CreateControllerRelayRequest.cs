namespace Saltoapis.Nebula.Controller.V1.Request
{
    /// <summary>
    /// The request message for [`CreateControllerRelay`][salto.nebula.controller.v1.ControllerService.CreateControllerRelay]
    /// </summary>
    public sealed partial class CreateControllerRelayRequest : IMessage<CreateControllerRelayRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateControllerRelayRequest> _parser = new(() => new CreateControllerRelayRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateControllerRelayRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[29]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateControllerRelayRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateControllerRelayRequest(CreateControllerRelayRequest other) : this()
        {
            parent_ = other.parent_;
            controllerRelayId_ = other.controllerRelayId_;
            controllerRelay_ = other.controllerRelay_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateControllerRelayRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the controller relay is to be created. For
        /// example: `installations/surelock-homes-hq/controllers/dancing-men`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "controller_relay_id" field.</summary>
        public const int ControllerRelayIdFieldNumber = 2;
        private readonly static string ControllerRelayIdDefaultValue = "";

        private string controllerRelayId_;

        /// <summary>
        /// The controller relay ID to use for this controller relay. In case it's empty the
        /// server will autogenerate a unique identifier.
        /// </summary>
        public string ControllerRelayId
        {
            get { return controllerRelayId_ ?? ControllerRelayIdDefaultValue; }
            set
            {
                controllerRelayId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "controller_relay_id" field is set</summary>
        public bool HasControllerRelayId
        {
            get { return controllerRelayId_ != null; }
        }

        /// <summary>Clears the value of the "controller_relay_id" field</summary>
        public void ClearControllerRelayId()
        {
            controllerRelayId_ = null;
        }

        /// <summary>Field number for the "controller_relay" field.</summary>
        public const int ControllerRelayFieldNumber = 3;
        private ControllerRelay controllerRelay_;

        /// <summary>
        /// The controller relay resource to be created. Client must not set the
        /// `ControllerRelay.name` field.
        /// </summary>
        public ControllerRelay ControllerRelay
        {
            get { return controllerRelay_; }
            set
            {
                controllerRelay_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateControllerRelayRequest);
        public bool Equals(CreateControllerRelayRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (ControllerRelayId != other.ControllerRelayId)) return false;
            if (!Equals(ControllerRelay, other.ControllerRelay)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasControllerRelayId) hash ^= ControllerRelayId.GetHashCode();
            if (controllerRelay_ != null) hash ^= ControllerRelay.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (HasControllerRelayId) {
        output.WriteRawTag(18);
        output.WriteString(ControllerRelayId);
      }
      if (controllerRelay_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ControllerRelay);
      }
      if (_unknownFields != null) {
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
            if (HasControllerRelayId)
            {
                output.WriteRawTag(18);
                output.WriteString(ControllerRelayId);
            }
            if (controllerRelay_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(ControllerRelay);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (HasControllerRelayId) size += 1 + CodedOutputStream.ComputeStringSize(ControllerRelayId);
            if (controllerRelay_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(ControllerRelay);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateControllerRelayRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.HasControllerRelayId) ControllerRelayId = other.ControllerRelayId;
            if (other.controllerRelay_ != null)
            {
                if (controllerRelay_ == null) ControllerRelay = new ControllerRelay();
                ControllerRelay.MergeFrom(other.ControllerRelay);
            }
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
            Parent = input.ReadString();
            break;
          }
          case 18: {
            ControllerRelayId = input.ReadString();
            break;
          }
          case 26: {
            if (controllerRelay_ == null) {
              ControllerRelay = new Saltoapis.Nebula.Controller.V1.ControllerRelay();
            }
            input.ReadMessage(ControllerRelay);
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
                            ControllerRelayId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (controllerRelay_ == null) ControllerRelay = new ControllerRelay();
                            input.ReadMessage(ControllerRelay);
                            break;
                        }
                }
            }
        }
#endif

    }


}
