namespace Saltoapis.Nebula.AccessRight.V1.Request
{
    /// <summary>
    /// The request message for [`CreateAccessRightDestination`][salto.nebula.accessright.v1.AccessRightService.CreateAccessRightDestination]
    /// </summary>
    public sealed partial class CreateAccessRightDestinationRequest : IMessage<CreateAccessRightDestinationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateAccessRightDestinationRequest> _parser = new(() => new CreateAccessRightDestinationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateAccessRightDestinationRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => AccessRightReflection.Descriptor.MessageTypes[30];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public CreateAccessRightDestinationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateAccessRightDestinationRequest(CreateAccessRightDestinationRequest other) : this()
        {
            parent_ = other.parent_;
            accessRightDestination_ = other.accessRightDestination_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateAccessRightDestinationRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";
        /// <summary>
        /// Resource name of the parent resource where the access right's destination
        /// association is to be created. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville`.
        /// </summary>
        public string Parent
        {
            get => parent_; set => parent_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "access_right_destination" field.</summary>
        public const int AccessRightDestinationFieldNumber = 2;
        private AccessRightDestination accessRightDestination_;
        /// <summary>
        /// The access right's destination association resource to be created.
        /// Client must not set the `AccessRightDestination.name` field.
        /// </summary>
        public AccessRightDestination AccessRightDestination
        {
            get => accessRightDestination_; set => accessRightDestination_ = value;}

        public override bool Equals(object other) => Equals(other as CreateAccessRightDestinationRequest);
        public bool Equals(CreateAccessRightDestinationRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (!Equals(AccessRightDestination, other.AccessRightDestination))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (accessRightDestination_ != null) hash ^= AccessRightDestination.GetHashCode();
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
      if (accessRightDestination_ != null)
      {
        output.WriteRawTag(18);
        output.WriteMessage(AccessRightDestination);
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
            if (accessRightDestination_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(AccessRightDestination);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (accessRightDestination_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessRightDestination);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateAccessRightDestinationRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.accessRightDestination_ != null)
            {
                if (accessRightDestination_ == null) AccessRightDestination = new AccessRightDestination();
                AccessRightDestination.MergeFrom(other.AccessRightDestination);
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
            if (accessRightDestination_ == null)
            {
              AccessRightDestination = new Saltoapis.Nebula.AccessRight.V1.AccessRightDestination();
            }
            input.ReadMessage(AccessRightDestination);
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
                            if (accessRightDestination_ == null) AccessRightDestination = new AccessRightDestination();
                            input.ReadMessage(AccessRightDestination);
                            break;
                        }
                }
            }
        }
#endif
    }

}