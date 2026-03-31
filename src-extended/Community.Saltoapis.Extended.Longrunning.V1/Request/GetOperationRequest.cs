namespace Saltoapis.Longrunning.V1.Request
{
    /// <summary>
    /// The request message for
    /// [`OperationService.GetOperation`][salto.longrunning.v1.OperationService.GetOperation].
    /// </summary>
    public sealed partial class GetOperationRequest : IMessage<GetOperationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetOperationRequest> _parser = new(() => new GetOperationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetOperationRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => OperationReflection.Descriptor.MessageTypes[1];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public GetOperationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetOperationRequest(GetOperationRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetOperationRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        /// <summary>
        /// The name of the operation resource.
        /// </summary>
        public string Name
        {
            get => name_; set => name_ = ProtoPreconditions.CheckNotNull(value, "value");}

        public override bool Equals(object other) => Equals(other as GetOperationRequest);
        public bool Equals(GetOperationRequest other)
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

        public void MergeFrom(GetOperationRequest other)
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