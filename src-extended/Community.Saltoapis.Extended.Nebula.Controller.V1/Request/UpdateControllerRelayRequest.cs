namespace Saltoapis.Nebula.Controller.V1.Request
{
    /// <summary>
    /// The request message for [UpdateControllerRelay][salto.nebula.controller.v1.ControllerService.UpdateControllerRelay]
    /// </summary>
    public sealed partial class UpdateControllerRelayRequest : IMessage<UpdateControllerRelayRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateControllerRelayRequest> _parser = new(() => new UpdateControllerRelayRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateControllerRelayRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => ControllerReflection.Descriptor.MessageTypes[33];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public UpdateControllerRelayRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateControllerRelayRequest(UpdateControllerRelayRequest other) : this()
        {
            controllerRelay_ = other.controllerRelay_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateControllerRelayRequest Clone() => new(this);
        /// <summary>Field number for the "controller_relay" field.</summary>
        public const int ControllerRelayFieldNumber = 1;
        private ControllerRelay controllerRelay_;
        /// <summary>
        /// The controller relay resource which replaces the resource on the server.
        /// </summary>
        public ControllerRelay ControllerRelay
        {
            get => controllerRelay_; set => controllerRelay_ = value;}
        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;
        /// <summary>
        /// The update mask applied to the resource.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get => updateMask_; set => updateMask_ = value;}

        public override bool Equals(object other) => Equals(other as UpdateControllerRelayRequest);
        public bool Equals(UpdateControllerRelayRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(ControllerRelay, other.ControllerRelay)) || (!Equals(UpdateMask, other.UpdateMask))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (controllerRelay_ != null) hash ^= ControllerRelay.GetHashCode();
            if (updateMask_ != null) hash ^= UpdateMask.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (controllerRelay_ != null)
      {
        output.WriteRawTag(10);
        output.WriteMessage(ControllerRelay);
      }
      if (updateMask_ != null)
      {
        output.WriteRawTag(18);
        output.WriteMessage(UpdateMask);
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
            if (controllerRelay_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(ControllerRelay);
            }
            if (updateMask_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(UpdateMask);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (controllerRelay_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(ControllerRelay);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateControllerRelayRequest other)
        {
            if (other == null) return;
            if (other.controllerRelay_ != null)
            {
                if (controllerRelay_ == null) ControllerRelay = new ControllerRelay();
                ControllerRelay.MergeFrom(other.ControllerRelay);
            }
            if (other.updateMask_ != null)
            {
                if (updateMask_ == null) UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                UpdateMask.MergeFrom(other.UpdateMask);
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
            if (controllerRelay_ == null)
            {
              ControllerRelay = new Saltoapis.Nebula.Controller.V1.ControllerRelay();
            }
            input.ReadMessage(ControllerRelay);
            break;
          }
          case 18:
          {
            if (updateMask_ == null)
            {
              UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
            }
            input.ReadMessage(UpdateMask);
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
                            if (controllerRelay_ == null) ControllerRelay = new ControllerRelay();
                            input.ReadMessage(ControllerRelay);
                            break;
                        }
                    case 18:
                        {
                            if (updateMask_ == null) UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                            input.ReadMessage(UpdateMask);
                            break;
                        }
                }
            }
        }
#endif
    }

}