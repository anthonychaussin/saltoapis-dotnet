using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.AccessPointGroup.V1.Request
{
    /// <summary>
    /// The request message for [`CreateAccessPointGroupAccessPoint`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.CreateAccessPointGroupAccessPoint]
    /// </summary>
    public sealed partial class CreateAccessPointGroupAccessPointRequest : IMessage<CreateAccessPointGroupAccessPointRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateAccessPointGroupAccessPointRequest> _parser = new(() => new CreateAccessPointGroupAccessPointRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateAccessPointGroupAccessPointRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateAccessPointGroupAccessPointRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateAccessPointGroupAccessPointRequest(CreateAccessPointGroupAccessPointRequest other) : this()
        {
            parent_ = other.parent_;
            accessPointGroupAccessPoint_ = other.accessPointGroupAccessPoint_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateAccessPointGroupAccessPointRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the access point group's
        /// access point association is to be created. For example:
        /// `installations/surelock-homes-hq/access-point-groups/common-accesses`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "access_point_group_access_point" field.</summary>
        public const int AccessPointGroupAccessPointFieldNumber = 2;
        private AccessPointGroupAccessPoint accessPointGroupAccessPoint_;

        /// <summary>
        /// The access point group's access point association resource to be created.
        /// Client must not set the `AccessPointGroupAccessPoint.name` field.
        /// </summary>
        public AccessPointGroupAccessPoint AccessPointGroupAccessPoint
        {
            get { return accessPointGroupAccessPoint_; }
            set
            {
                accessPointGroupAccessPoint_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateAccessPointGroupAccessPointRequest);
        public bool Equals(CreateAccessPointGroupAccessPointRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (!Equals(AccessPointGroupAccessPoint, other.AccessPointGroupAccessPoint))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (accessPointGroupAccessPoint_ != null) hash ^= AccessPointGroupAccessPoint.GetHashCode();
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
      if (accessPointGroupAccessPoint_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AccessPointGroupAccessPoint);
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
            if (accessPointGroupAccessPoint_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(AccessPointGroupAccessPoint);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (accessPointGroupAccessPoint_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessPointGroupAccessPoint);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateAccessPointGroupAccessPointRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.accessPointGroupAccessPoint_ != null)
            {
                if (accessPointGroupAccessPoint_ == null) AccessPointGroupAccessPoint = new AccessPointGroupAccessPoint();
                AccessPointGroupAccessPoint.MergeFrom(other.AccessPointGroupAccessPoint);
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
            if (accessPointGroupAccessPoint_ == null) {
              AccessPointGroupAccessPoint = new Saltoapis.Nebula.AccessPointGroup.V1.AccessPointGroupAccessPoint();
            }
            input.ReadMessage(AccessPointGroupAccessPoint);
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
                            if (accessPointGroupAccessPoint_ == null) AccessPointGroupAccessPoint = new AccessPointGroupAccessPoint();
                            input.ReadMessage(AccessPointGroupAccessPoint);
                            break;
                        }
                }
            }
        }
#endif

    }


}
