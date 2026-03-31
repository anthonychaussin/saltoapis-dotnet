namespace Saltoapis.Nebula.AccessPointGroup.V1.Request
{
    /// <summary>
    /// The request message for [`DeleteAccessPointGroupAccessPoint`][salto.nebula.accesspointgroup.v1.AccessPointGroupService.DeleteAccessPointGroupAccessPoint]
    /// </summary>
    public sealed partial class DeleteAccessPointGroupAccessPointRequest : IMessage<DeleteAccessPointGroupAccessPointRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteAccessPointGroupAccessPointRequest> _parser = new(() => new DeleteAccessPointGroupAccessPointRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteAccessPointGroupAccessPointRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => AccessPointGroupReflection.Descriptor.MessageTypes[15];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public DeleteAccessPointGroupAccessPointRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteAccessPointGroupAccessPointRequest(DeleteAccessPointGroupAccessPointRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteAccessPointGroupAccessPointRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        /// <summary>
        /// The resource name of the access point group's access point association to be
        /// deleted. For example:
        /// `installations/surelock-homes-hq/access-point-groups/common-accesses/access-points/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get => name_; set => name_ = ProtoPreconditions.CheckNotNull(value, "value");}

        public override bool Equals(object other) => Equals(other as DeleteAccessPointGroupAccessPointRequest);
        public bool Equals(DeleteAccessPointGroupAccessPointRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
return Name != other.Name ? false : Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Name.Length != 0)
      {
        output.WriteRawTag(10);
        output.WriteString(Name);
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
            if (Name.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Name);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(DeleteAccessPointGroupAccessPointRequest other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
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
            Name = input.ReadString();
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
                            Name = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif
    }

}