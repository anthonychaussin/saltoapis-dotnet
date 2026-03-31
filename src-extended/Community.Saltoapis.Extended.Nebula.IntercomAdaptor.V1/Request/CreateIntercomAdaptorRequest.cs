namespace Saltoapis.Nebula.IntercomAdaptor.V1.Request
{
    /// <summary>
    /// The request message for [CreateIntercomAdaptor][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.CreateIntercomAdaptor]
    /// </summary>
    public sealed partial class CreateIntercomAdaptorRequest : IMessage<CreateIntercomAdaptorRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateIntercomAdaptorRequest> _parser = new(() => new CreateIntercomAdaptorRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateIntercomAdaptorRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateIntercomAdaptorRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateIntercomAdaptorRequest(CreateIntercomAdaptorRequest other) : this()
        {
            parent_ = other.parent_;
            intercomAdaptorId_ = other.intercomAdaptorId_;
            intercomAdaptor_ = other.intercomAdaptor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateIntercomAdaptorRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where to create the intercom adaptor. For
        /// example, `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "intercom_adaptor_id" field.</summary>
        public const int IntercomAdaptorIdFieldNumber = 2;
        private static readonly string IntercomAdaptorIdDefaultValue = "";

        private string intercomAdaptorId_;

        /// <summary>
        /// The intercom adaptor ID to use for this intercom adaptor. In case it's empty the
        /// server will autogenerate a unique identifier.
        /// </summary>
        public string IntercomAdaptorId
        {
            get { return intercomAdaptorId_ ?? IntercomAdaptorIdDefaultValue; }
            set
            {
                intercomAdaptorId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "intercom_adaptor_id" field is set</summary>
        public bool HasIntercomAdaptorId
        {
            get { return intercomAdaptorId_ != null; }
        }

        /// <summary>Clears the value of the "intercom_adaptor_id" field</summary>
        public void ClearIntercomAdaptorId()
        {
            intercomAdaptorId_ = null;
        }

        /// <summary>Field number for the "intercom_adaptor" field.</summary>
        public const int IntercomAdaptorFieldNumber = 3;
        private IntercomAdaptor intercomAdaptor_;

        /// <summary>
        /// The intercom adaptor resource to be created. Client must not set the
        /// `IntercomAdaptor.name` field.
        /// </summary>
        public IntercomAdaptor IntercomAdaptor
        {
            get { return intercomAdaptor_; }
            set
            {
                intercomAdaptor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateIntercomAdaptorRequest);
        public bool Equals(CreateIntercomAdaptorRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (IntercomAdaptorId != other.IntercomAdaptorId)) return false;
            if (!Equals(IntercomAdaptor, other.IntercomAdaptor)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasIntercomAdaptorId) hash ^= IntercomAdaptorId.GetHashCode();
            if (intercomAdaptor_ != null) hash ^= IntercomAdaptor.GetHashCode();
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
      if (HasIntercomAdaptorId) {
        output.WriteRawTag(18);
        output.WriteString(IntercomAdaptorId);
      }
      if (intercomAdaptor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(IntercomAdaptor);
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
            if (HasIntercomAdaptorId)
            {
                output.WriteRawTag(18);
                output.WriteString(IntercomAdaptorId);
            }
            if (intercomAdaptor_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(IntercomAdaptor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (HasIntercomAdaptorId) size += 1 + CodedOutputStream.ComputeStringSize(IntercomAdaptorId);
            if (intercomAdaptor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(IntercomAdaptor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateIntercomAdaptorRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.HasIntercomAdaptorId) IntercomAdaptorId = other.IntercomAdaptorId;
            if (other.intercomAdaptor_ != null)
            {
                if (intercomAdaptor_ == null) IntercomAdaptor = new IntercomAdaptor();
                IntercomAdaptor.MergeFrom(other.IntercomAdaptor);
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
            IntercomAdaptorId = input.ReadString();
            break;
          }
          case 26: {
            if (intercomAdaptor_ == null) {
              IntercomAdaptor = new Saltoapis.Nebula.IntercomAdaptor.V1.IntercomAdaptor();
            }
            input.ReadMessage(IntercomAdaptor);
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
                            IntercomAdaptorId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (intercomAdaptor_ == null) IntercomAdaptor = new IntercomAdaptor();
                            input.ReadMessage(IntercomAdaptor);
                            break;
                        }
                }
            }
        }
#endif

    }


}
