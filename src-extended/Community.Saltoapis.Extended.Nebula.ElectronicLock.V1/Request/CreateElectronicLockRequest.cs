namespace Saltoapis.Nebula.ElectronicLock.V1.Request
{
    /// <summary>
    /// The request message for [CreateElectronicLock][salto.nebula.electroniclock.v1.ElectronicLockService.CreateElectronicLock]
    /// </summary>
    public sealed partial class CreateElectronicLockRequest : IMessage<CreateElectronicLockRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateElectronicLockRequest> _parser = new(() => new CreateElectronicLockRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateElectronicLockRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => ElectronicLockReflection.Descriptor.MessageTypes[1];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public CreateElectronicLockRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateElectronicLockRequest(CreateElectronicLockRequest other) : this()
        {
            parent_ = other.parent_;
            electronicLockId_ = other.electronicLockId_;
            electronicLock_ = other.electronicLock_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateElectronicLockRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";
        /// <summary>
        /// Resource name of the parent resource where to create the electronic lock. For
        /// example, `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get => parent_; set => parent_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "electronic_lock_id" field.</summary>
        public const int ElectronicLockIdFieldNumber = 2;
        private static readonly string ElectronicLockIdDefaultValue = "";

        private string electronicLockId_;
        /// <summary>
        /// The electronic lock ID to use for this electronic lock. In case it's empty the
        /// server will autogenerate a unique identifier.
        /// </summary>
        public string ElectronicLockId
        {
            get => electronicLockId_ ?? ElectronicLockIdDefaultValue; set => electronicLockId_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Gets whether the "electronic_lock_id" field is set</summary>
        public bool HasElectronicLockId => electronicLockId_ != null;
        /// <summary>Clears the value of the "electronic_lock_id" field</summary>
        public void ClearElectronicLockId() => electronicLockId_ = null;
        /// <summary>Field number for the "electronic_lock" field.</summary>
        public const int ElectronicLockFieldNumber = 3;
        private ElectronicLock electronicLock_;
        /// <summary>
        /// The electronic lock resource to be created. Client must not set the
        /// `ElectronicLock.name` field.
        /// </summary>
        public ElectronicLock ElectronicLock
        {
            get => electronicLock_; set => electronicLock_ = value;}

        public override bool Equals(object other) => Equals(other as CreateElectronicLockRequest);
        public bool Equals(CreateElectronicLockRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (ElectronicLockId != other.ElectronicLockId) || !Equals(ElectronicLock, other.ElectronicLock)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasElectronicLockId) hash ^= ElectronicLockId.GetHashCode();
            if (electronicLock_ != null) hash ^= ElectronicLock.GetHashCode();
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
      if (HasElectronicLockId)
      {
        output.WriteRawTag(18);
        output.WriteString(ElectronicLockId);
      }
      if (electronicLock_ != null)
      {
        output.WriteRawTag(26);
        output.WriteMessage(ElectronicLock);
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
            if (HasElectronicLockId)
            {
                output.WriteRawTag(18);
                output.WriteString(ElectronicLockId);
            }
            if (electronicLock_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(ElectronicLock);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (HasElectronicLockId) size += 1 + CodedOutputStream.ComputeStringSize(ElectronicLockId);
            if (electronicLock_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(ElectronicLock);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateElectronicLockRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.HasElectronicLockId) ElectronicLockId = other.ElectronicLockId;
            if (other.electronicLock_ != null)
            {
                if (electronicLock_ == null) ElectronicLock = new ElectronicLock();
                ElectronicLock.MergeFrom(other.ElectronicLock);
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
            ElectronicLockId = input.ReadString();
            break;
          }
          case 26:
          {
            if (electronicLock_ == null)
            {
              ElectronicLock = new Saltoapis.Nebula.ElectronicLock.V1.ElectronicLock();
            }
            input.ReadMessage(ElectronicLock);
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
                            ElectronicLockId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (electronicLock_ == null) ElectronicLock = new ElectronicLock();
                            input.ReadMessage(ElectronicLock);
                            break;
                        }
                }
            }
        }
#endif
    }

}