namespace Saltoapis.Nebula.Controller.V1.Request
{
    /// <summary>
    /// The request message for [UpdateController][salto.nebula.controller.v1.ControllerService.UpdateController]
    /// </summary>
    public sealed partial class UpdateControllerRequest : IMessage<UpdateControllerRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateControllerRequest> _parser = new(() => new UpdateControllerRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateControllerRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => ControllerReflection.Descriptor.MessageTypes[6];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public UpdateControllerRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateControllerRequest(UpdateControllerRequest other) : this()
        {
            controller_ = other.controller_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateControllerRequest Clone() => new(this);
        /// <summary>Field number for the "controller" field.</summary>
        public const int ControllerFieldNumber = 1;
        private Controller controller_;
        /// <summary>
        /// The controller resource which replaces the resource on the server.
        /// </summary>
        public Controller Controller
        {
            get => controller_; set => controller_ = value;}
        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;
        /// <summary>
        /// The update mask applied to the resource.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get => updateMask_; set => updateMask_ = value;}

        public override bool Equals(object other) => Equals(other as UpdateControllerRequest);
        public bool Equals(UpdateControllerRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(Controller, other.Controller)) || (!Equals(UpdateMask, other.UpdateMask))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (controller_ != null) hash ^= Controller.GetHashCode();
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
      if (controller_ != null)
      {
        output.WriteRawTag(10);
        output.WriteMessage(Controller);
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
            if (controller_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Controller);
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
            if (controller_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Controller);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateControllerRequest other)
        {
            if (other == null) return;
            if (other.controller_ != null)
            {
                if (controller_ == null) Controller = new Controller();
                Controller.MergeFrom(other.Controller);
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
            if (controller_ == null)
            {
              Controller = new Saltoapis.Nebula.Controller.V1.Controller();
            }
            input.ReadMessage(Controller);
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
                            if (controller_ == null) Controller = new Controller();
                            input.ReadMessage(Controller);
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