namespace Saltoapis.Nebula.Controller.V1.Request
{
    /// <summary>
    /// The request message for [`UpdateControllerFirmware`][salto.nebula.controller.v1.ControllerService.UpdateControllerFirmware]
    /// </summary>
    public sealed partial class UpdateControllerFirmwareRequest : IMessage<UpdateControllerFirmwareRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateControllerFirmwareRequest> _parser = new(() => new UpdateControllerFirmwareRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateControllerFirmwareRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => ControllerReflection.Descriptor.MessageTypes[21];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public UpdateControllerFirmwareRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateControllerFirmwareRequest(UpdateControllerFirmwareRequest other) : this()
        {
            controller_ = other.controller_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateControllerFirmwareRequest Clone() => new(this);
        /// <summary>Field number for the "controller" field.</summary>
        public const int ControllerFieldNumber = 1;
        private string controller_ = "";
        /// <summary>
        /// The resource name of the controller whose firmware will be updated. For
        /// example:
        /// `installations/surelock-homes-hq/controllers/main-controller`.
        /// </summary>
        public string Controller
        {
            get => controller_; set => controller_ = ProtoPreconditions.CheckNotNull(value, "value");}

        public override bool Equals(object other) => Equals(other as UpdateControllerFirmwareRequest);
        public bool Equals(UpdateControllerFirmwareRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
return Controller != other.Controller ? false : Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Controller.Length != 0) hash ^= Controller.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Controller.Length != 0)
      {
        output.WriteRawTag(10);
        output.WriteString(Controller);
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
            if (Controller.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Controller);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Controller.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Controller);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateControllerFirmwareRequest other)
        {
            if (other == null) return;
            if (other.Controller.Length != 0) Controller = other.Controller;
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
            Controller = input.ReadString();
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
                            Controller = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif
    }

}