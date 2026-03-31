namespace Saltoapis.Nebula.Controller.V1.Request
{
    /// <summary>
    /// The request message for [CreateController][salto.nebula.controller.v1.ControllerService.CreateController]
    /// </summary>
    public sealed partial class CreateControllerRequest : IMessage<CreateControllerRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateControllerRequest> _parser = new(() => new CreateControllerRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateControllerRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => ControllerReflection.Descriptor.MessageTypes[2];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public CreateControllerRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateControllerRequest(CreateControllerRequest other) : this()
        {
            parent_ = other.parent_;
            controllerId_ = other.controllerId_;
            controller_ = other.controller_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateControllerRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";
        /// <summary>
        /// Resource name of the parent resource where to create the controller. For
        /// example, `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get => parent_; set => parent_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "controller_id" field.</summary>
        public const int ControllerIdFieldNumber = 2;
        private static readonly string ControllerIdDefaultValue = "";

        private string controllerId_;
        /// <summary>
        /// The controller ID to use for this controller. In case it's empty the
        /// server will autogenerate a unique identifier.
        /// </summary>
        public string ControllerId
        {
            get => controllerId_ ?? ControllerIdDefaultValue; set => controllerId_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Gets whether the "controller_id" field is set</summary>
        public bool HasControllerId => controllerId_ != null;
        /// <summary>Clears the value of the "controller_id" field</summary>
        public void ClearControllerId() => controllerId_ = null;
        /// <summary>Field number for the "controller" field.</summary>
        public const int ControllerFieldNumber = 3;
        private Controller controller_;
        /// <summary>
        /// The controller resource to be created. Client must not set the
        /// `Controller.name` field.
        /// </summary>
        public Controller Controller
        {
            get => controller_; set => controller_ = value;}

        public override bool Equals(object other) => Equals(other as CreateControllerRequest);
        public bool Equals(CreateControllerRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (ControllerId != other.ControllerId) || !Equals(Controller, other.Controller)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasControllerId) hash ^= ControllerId.GetHashCode();
            if (controller_ != null) hash ^= Controller.GetHashCode();
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
      if (HasControllerId)
      {
        output.WriteRawTag(18);
        output.WriteString(ControllerId);
      }
      if (controller_ != null)
      {
        output.WriteRawTag(26);
        output.WriteMessage(Controller);
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
            if (HasControllerId)
            {
                output.WriteRawTag(18);
                output.WriteString(ControllerId);
            }
            if (controller_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Controller);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (HasControllerId) size += 1 + CodedOutputStream.ComputeStringSize(ControllerId);
            if (controller_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Controller);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateControllerRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.HasControllerId) ControllerId = other.ControllerId;
            if (other.controller_ != null)
            {
                if (controller_ == null) Controller = new Controller();
                Controller.MergeFrom(other.Controller);
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
            ControllerId = input.ReadString();
            break;
          }
          case 26:
          {
            if (controller_ == null)
            {
              Controller = new Saltoapis.Nebula.Controller.V1.Controller();
            }
            input.ReadMessage(Controller);
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
                            ControllerId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (controller_ == null) Controller = new Controller();
                            input.ReadMessage(Controller);
                            break;
                        }
                }
            }
        }
#endif
    }

}