namespace Saltoapis.Nebula.ElectronicLock.V1.Request
{
    /// <summary>
    /// The request message for [UpdateElectronicLock][salto.nebula.electroniclock.v1.ElectronicLockService.UpdateElectronicLock]
    /// </summary>
    public sealed partial class UpdateElectronicLockRequest : IMessage<UpdateElectronicLockRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateElectronicLockRequest> _parser = new(() => new UpdateElectronicLockRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateElectronicLockRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => ElectronicLockReflection.Descriptor.MessageTypes[5];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public UpdateElectronicLockRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateElectronicLockRequest(UpdateElectronicLockRequest other) : this()
        {
            electronicLock_ = other.electronicLock_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateElectronicLockRequest Clone() => new(this);
        /// <summary>Field number for the "electronic_lock" field.</summary>
        public const int ElectronicLockFieldNumber = 1;
        private ElectronicLock electronicLock_;
        /// <summary>
        /// The electronic lock resource which replaces the resource on the server.
        /// </summary>
        public ElectronicLock ElectronicLock
        {
            get => electronicLock_; set => electronicLock_ = value;}
        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;
        /// <summary>
        /// The update mask applied to the resource.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get => updateMask_; set => updateMask_ = value;}

        public override bool Equals(object other) => Equals(other as UpdateElectronicLockRequest);
        public bool Equals(UpdateElectronicLockRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(ElectronicLock, other.ElectronicLock)) || (!Equals(UpdateMask, other.UpdateMask))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (electronicLock_ != null) hash ^= ElectronicLock.GetHashCode();
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
      if (electronicLock_ != null)
      {
        output.WriteRawTag(10);
        output.WriteMessage(ElectronicLock);
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
            if (electronicLock_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(ElectronicLock);
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
            if (electronicLock_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(ElectronicLock);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateElectronicLockRequest other)
        {
            if (other == null) return;
            if (other.electronicLock_ != null)
            {
                if (electronicLock_ == null) ElectronicLock = new ElectronicLock();
                ElectronicLock.MergeFrom(other.ElectronicLock);
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
            if (electronicLock_ == null)
            {
              ElectronicLock = new Saltoapis.Nebula.ElectronicLock.V1.ElectronicLock();
            }
            input.ReadMessage(ElectronicLock);
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
                            if (electronicLock_ == null) ElectronicLock = new ElectronicLock();
                            input.ReadMessage(ElectronicLock);
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