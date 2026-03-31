using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.AccessPointGroup.V1.Request
{
    /// <summary>
    /// The request message for [`UpdateAccessPointGroup`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.UpdateAccessPointGroup]
    /// </summary>
    public sealed partial class UpdateAccessPointGroupRequest : IMessage<UpdateAccessPointGroupRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateAccessPointGroupRequest> _parser = new(() => new UpdateAccessPointGroupRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateAccessPointGroupRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessPointGroupReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateAccessPointGroupRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateAccessPointGroupRequest(UpdateAccessPointGroupRequest other) : this()
        {
            accessPointGroup_ = other.accessPointGroup_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateAccessPointGroupRequest Clone() => new(this);
        /// <summary>Field number for the "access_point_group" field.</summary>
        public const int AccessPointGroupFieldNumber = 1;
        private AccessPointGroup accessPointGroup_;

        /// <summary>
        /// The access point group resource which replaces the resource on the server.
        /// </summary>
        public AccessPointGroup AccessPointGroup
        {
            get { return accessPointGroup_; }
            set
            {
                accessPointGroup_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateAccessPointGroupRequest);
        public bool Equals(UpdateAccessPointGroupRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessPointGroup, other.AccessPointGroup)) || (!Equals(UpdateMask, other.UpdateMask))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessPointGroup_ != null) hash ^= AccessPointGroup.GetHashCode();
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
      if (accessPointGroup_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessPointGroup);
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
            if (accessPointGroup_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessPointGroup);
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
            if (accessPointGroup_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessPointGroup);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateAccessPointGroupRequest other)
        {
            if (other == null) return;
            if (other.accessPointGroup_ != null)
            {
                if (accessPointGroup_ == null) AccessPointGroup = new AccessPointGroup();
                AccessPointGroup.MergeFrom(other.AccessPointGroup);
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
            if (accessPointGroup_ == null) {
              AccessPointGroup = new Saltoapis.Nebula.AccessPointGroup.V1.AccessPointGroup();
            }
            input.ReadMessage(AccessPointGroup);
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
                            if (accessPointGroup_ == null) AccessPointGroup = new AccessPointGroup();
                            input.ReadMessage(AccessPointGroup);
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
