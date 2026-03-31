using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Extender.V1.Request
{
    /// <summary>
    /// The request message for [CreateExtender][salto.nebula.extender.v1.ExtenderService.CreateExtender]
    /// </summary>
    public sealed partial class CreateExtenderRequest : IMessage<CreateExtenderRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateExtenderRequest> _parser = new(() => new CreateExtenderRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateExtenderRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ExtenderReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateExtenderRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateExtenderRequest(CreateExtenderRequest other) : this()
        {
            parent_ = other.parent_;
            extenderId_ = other.extenderId_;
            extender_ = other.extender_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateExtenderRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where to create the extender. For
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

        /// <summary>Field number for the "extender_id" field.</summary>
        public const int ExtenderIdFieldNumber = 2;
        private readonly static string ExtenderIdDefaultValue = "";

        private string extenderId_;

        /// <summary>
        /// The extender ID to use for this extender. In case it's empty
        /// the server will autogenerate a unique identifier.
        /// </summary>
        public string ExtenderId
        {
            get { return extenderId_ ?? ExtenderIdDefaultValue; }
            set
            {
                extenderId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "extender_id" field is set</summary>
        public bool HasExtenderId
        {
            get { return extenderId_ != null; }
        }

        /// <summary>Clears the value of the "extender_id" field</summary>
        public void ClearExtenderId()
        {
            extenderId_ = null;
        }

        /// <summary>Field number for the "extender" field.</summary>
        public const int ExtenderFieldNumber = 3;
        private Extender extender_;

        /// <summary>
        /// The extender resource to be created. Client must not set the
        /// `Extender.name` field.
        /// </summary>
        public Extender Extender
        {
            get { return extender_; }
            set
            {
                extender_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateExtenderRequest);
        public bool Equals(CreateExtenderRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (ExtenderId != other.ExtenderId)) return false;
            if (!Equals(Extender, other.Extender)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasExtenderId) hash ^= ExtenderId.GetHashCode();
            if (extender_ != null) hash ^= Extender.GetHashCode();
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
      if (HasExtenderId) {
        output.WriteRawTag(18);
        output.WriteString(ExtenderId);
      }
      if (extender_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Extender);
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
            if (HasExtenderId)
            {
                output.WriteRawTag(18);
                output.WriteString(ExtenderId);
            }
            if (extender_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Extender);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (HasExtenderId) size += 1 + CodedOutputStream.ComputeStringSize(ExtenderId);
            if (extender_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Extender);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateExtenderRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.HasExtenderId) ExtenderId = other.ExtenderId;
            if (other.extender_ != null)
            {
                if (extender_ == null) Extender = new Extender();
                Extender.MergeFrom(other.Extender);
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
            ExtenderId = input.ReadString();
            break;
          }
          case 26: {
            if (extender_ == null) {
              Extender = new Saltoapis.Nebula.Extender.V1.Extender();
            }
            input.ReadMessage(Extender);
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
                            ExtenderId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (extender_ == null) Extender = new Extender();
                            input.ReadMessage(Extender);
                            break;
                        }
                }
            }
        }
#endif

    }


}
