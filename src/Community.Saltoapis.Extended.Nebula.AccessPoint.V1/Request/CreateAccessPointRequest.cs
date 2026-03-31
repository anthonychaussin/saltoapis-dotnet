namespace Saltoapis.Nebula.AccessPoint.V1.Request
{
    /// <summary>
    /// The request message for [`CreateAccessPoint`][salto.nebula.accesspoint.v1.AccessPointService.CreateAccessPoint]
    /// </summary>
    public sealed partial class CreateAccessPointRequest : IMessage<CreateAccessPointRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateAccessPointRequest> _parser = new(() => new CreateAccessPointRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateAccessPointRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateAccessPointRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateAccessPointRequest(CreateAccessPointRequest other) : this()
        {
            parent_ = other.parent_;
            accessPointId_ = other.accessPointId_;
            accessPoint_ = other.accessPoint_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateAccessPointRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource under which the access point is created.
        /// For example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "access_point_id" field.</summary>
        public const int AccessPointIdFieldNumber = 2;
        private readonly static string AccessPointIdDefaultValue = "";

        private string accessPointId_;

        /// <summary>
        /// The access point id to use for this access point. If it's
        /// empty the server will autogenerate a unique identifier.
        /// </summary>
        public string AccessPointId
        {
            get { return accessPointId_ ?? AccessPointIdDefaultValue; }
            set
            {
                accessPointId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "access_point_id" field is set</summary>
        public bool HasAccessPointId
        {
            get { return accessPointId_ != null; }
        }

        /// <summary>Clears the value of the "access_point_id" field</summary>
        public void ClearAccessPointId()
        {
            accessPointId_ = null;
        }

        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 3;
        private AccessPoint accessPoint_;

        /// <summary>
        /// The access point resource to be created. Client must not set the
        /// `AccessPoint.name` field.
        /// </summary>
        public AccessPoint AccessPoint
        {
            get { return accessPoint_; }
            set
            {
                accessPoint_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateAccessPointRequest);
        public bool Equals(CreateAccessPointRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (AccessPointId != other.AccessPointId)) return false;
            if (!Equals(AccessPoint, other.AccessPoint)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasAccessPointId) hash ^= AccessPointId.GetHashCode();
            if (accessPoint_ != null) hash ^= AccessPoint.GetHashCode();
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
      if (HasAccessPointId) {
        output.WriteRawTag(18);
        output.WriteString(AccessPointId);
      }
      if (accessPoint_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(AccessPoint);
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
            if (HasAccessPointId)
            {
                output.WriteRawTag(18);
                output.WriteString(AccessPointId);
            }
            if (accessPoint_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(AccessPoint);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (HasAccessPointId) size += 1 + CodedOutputStream.ComputeStringSize(AccessPointId);
            if (accessPoint_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessPoint);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateAccessPointRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.HasAccessPointId) AccessPointId = other.AccessPointId;
            if (other.accessPoint_ != null)
            {
                if (accessPoint_ == null) AccessPoint = new AccessPoint();
                AccessPoint.MergeFrom(other.AccessPoint);
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
            AccessPointId = input.ReadString();
            break;
          }
          case 26: {
            if (accessPoint_ == null) {
              AccessPoint = new Saltoapis.Nebula.AccessPoint.V1.AccessPoint();
            }
            input.ReadMessage(AccessPoint);
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
                            AccessPointId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (accessPoint_ == null) AccessPoint = new AccessPoint();
                            input.ReadMessage(AccessPoint);
                            break;
                        }
                }
            }
        }
#endif

    }


}
