namespace Saltoapis.Nebula.Unit.V1.Request
{
    /// <summary>
    /// The request message for [`GetPolicy`][salto.nebula.unit.v1.UnitService.GetPolicy]
    /// </summary>
    public sealed partial class GetPolicyRequest : IMessage<GetPolicyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetPolicyRequest> _parser = new(() => new GetPolicyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetPolicyRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => UnitReflection.Descriptor.MessageTypes[15];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public GetPolicyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetPolicyRequest(GetPolicyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetPolicyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        /// <summary>
        /// The name of the requested policy resource. For example:
        /// `installations/surelock-homes-hq/units/101/iam-policies/standard`.
        /// </summary>
        public string Name
        {
            get => name_; set => name_ = ProtoPreconditions.CheckNotNull(value, "value");}

        public override bool Equals(object other) => Equals(other as GetPolicyRequest);
        public bool Equals(GetPolicyRequest other)
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

        public void MergeFrom(GetPolicyRequest other)
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