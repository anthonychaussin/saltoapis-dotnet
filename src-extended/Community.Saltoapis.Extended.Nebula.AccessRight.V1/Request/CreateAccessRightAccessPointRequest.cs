namespace Saltoapis.Nebula.AccessRight.V1.Request
{
    /// <summary>
    /// The request message for [`CreateAccessRightAccessPoint`][salto.nebula.accessright.v1.AccessRightService.CreateAccessRightAccessPoint]
    /// </summary>
    public sealed partial class CreateAccessRightAccessPointRequest : IMessage<CreateAccessRightAccessPointRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateAccessRightAccessPointRequest> _parser = new(() => new CreateAccessRightAccessPointRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateAccessRightAccessPointRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => AccessRightReflection.Descriptor.MessageTypes[10];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public CreateAccessRightAccessPointRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateAccessRightAccessPointRequest(CreateAccessRightAccessPointRequest other) : this()
        {
            parent_ = other.parent_;
            accessRightAccessPoint_ = other.accessRightAccessPoint_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateAccessRightAccessPointRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";
        /// <summary>
        /// Resource name of the parent resource where the access right's access
        /// point association is to be created. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville`.
        /// </summary>
        public string Parent
        {
            get => parent_; set => parent_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "access_right_access_point" field.</summary>
        public const int AccessRightAccessPointFieldNumber = 2;
        private AccessRightAccessPoint accessRightAccessPoint_;
        /// <summary>
        /// The access right's access point association resource to be created.
        /// Client must not set the `AccessRightAccessPoint.name` field.
        /// </summary>
        public AccessRightAccessPoint AccessRightAccessPoint
        {
            get => accessRightAccessPoint_; set => accessRightAccessPoint_ = value;}

        public override bool Equals(object other) => Equals(other as CreateAccessRightAccessPointRequest);
        public bool Equals(CreateAccessRightAccessPointRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (!Equals(AccessRightAccessPoint, other.AccessRightAccessPoint))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (accessRightAccessPoint_ != null) hash ^= AccessRightAccessPoint.GetHashCode();
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
      if (accessRightAccessPoint_ != null)
      {
        output.WriteRawTag(18);
        output.WriteMessage(AccessRightAccessPoint);
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
            if (accessRightAccessPoint_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(AccessRightAccessPoint);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (accessRightAccessPoint_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessRightAccessPoint);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateAccessRightAccessPointRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.accessRightAccessPoint_ != null)
            {
                if (accessRightAccessPoint_ == null) AccessRightAccessPoint = new AccessRightAccessPoint();
                AccessRightAccessPoint.MergeFrom(other.AccessRightAccessPoint);
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
            if (accessRightAccessPoint_ == null)
            {
              AccessRightAccessPoint = new Saltoapis.Nebula.AccessRight.V1.AccessRightAccessPoint();
            }
            input.ReadMessage(AccessRightAccessPoint);
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
                            if (accessRightAccessPoint_ == null) AccessRightAccessPoint = new AccessRightAccessPoint();
                            input.ReadMessage(AccessRightAccessPoint);
                            break;
                        }
                }
            }
        }
#endif
    }

}