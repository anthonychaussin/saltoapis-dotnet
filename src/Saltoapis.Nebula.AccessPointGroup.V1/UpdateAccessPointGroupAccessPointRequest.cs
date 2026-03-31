using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.AccessPointGroup.V1
{
    /// <summary>
    /// The request message for [`UpdateAccessPointGroupAccessPoint`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.UpdateAccessPointGroupAccessPoint]
    /// </summary>
    public sealed partial class UpdateAccessPointGroupAccessPointRequest : IMessage<UpdateAccessPointGroupAccessPointRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateAccessPointGroupAccessPointRequest> _parser = new(() => new UpdateAccessPointGroupAccessPointRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateAccessPointGroupAccessPointRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[14]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateAccessPointGroupAccessPointRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateAccessPointGroupAccessPointRequest(UpdateAccessPointGroupAccessPointRequest other) : this()
        {
            accessPointGroupAccessPoint_ = other.accessPointGroupAccessPoint_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateAccessPointGroupAccessPointRequest Clone() => new(this);
        /// <summary>Field number for the "access_point_group_access_point" field.</summary>
        public const int AccessPointGroupAccessPointFieldNumber = 1;
        private AccessPointGroupAccessPoint accessPointGroupAccessPoint_;

        /// <summary>
        /// The access point group's access point resource which replaces the resource on
        /// the server.
        /// </summary>
        public AccessPointGroupAccessPoint AccessPointGroupAccessPoint
        {
            get { return accessPointGroupAccessPoint_; }
            set
            {
                accessPointGroupAccessPoint_ = value;
            }
        }

        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;

        /// <summary>
        /// The update mask applied to the resource.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get { return updateMask_; }
            set
            {
                updateMask_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateAccessPointGroupAccessPointRequest);
        public bool Equals(UpdateAccessPointGroupAccessPointRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessPointGroupAccessPoint, other.AccessPointGroupAccessPoint)) || (!Equals(UpdateMask, other.UpdateMask))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessPointGroupAccessPoint_ != null) hash ^= AccessPointGroupAccessPoint.GetHashCode();
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
      if (accessPointGroupAccessPoint_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessPointGroupAccessPoint);
      }
      if (updateMask_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UpdateMask);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (accessPointGroupAccessPoint_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessPointGroupAccessPoint);
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
            if (accessPointGroupAccessPoint_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessPointGroupAccessPoint);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateAccessPointGroupAccessPointRequest other)
        {
            if (other == null) return;
            if (other.accessPointGroupAccessPoint_ != null)
            {
                if (accessPointGroupAccessPoint_ == null) AccessPointGroupAccessPoint = new AccessPointGroupAccessPoint();
                AccessPointGroupAccessPoint.MergeFrom(other.AccessPointGroupAccessPoint);
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
            if (accessPointGroupAccessPoint_ == null) {
              AccessPointGroupAccessPoint = new Saltoapis.Nebula.AccessPointGroup.V1.AccessPointGroupAccessPoint();
            }
            input.ReadMessage(AccessPointGroupAccessPoint);
            break;
          }
          case 18: {
            if (updateMask_ == null) {
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
                            if (accessPointGroupAccessPoint_ == null) AccessPointGroupAccessPoint = new AccessPointGroupAccessPoint();
                            input.ReadMessage(AccessPointGroupAccessPoint);
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
