using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.OpeningModeSchedule.V1.Request
{
    /// <summary>
    /// The request message for [`CreateOpeningModeSchedule`][salto.nebula.openingmodeschedule.v1.OpeningModeScheduleService.CreateOpeningModeSchedule]
    /// </summary>
    public sealed partial class CreateOpeningModeScheduleRequest : IMessage<CreateOpeningModeScheduleRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateOpeningModeScheduleRequest> _parser = new(() => new CreateOpeningModeScheduleRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateOpeningModeScheduleRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return OpeningModeScheduleReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateOpeningModeScheduleRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateOpeningModeScheduleRequest(CreateOpeningModeScheduleRequest other) : this()
        {
            parent_ = other.parent_;
            openingModeScheduleId_ = other.openingModeScheduleId_;
            openingModeSchedule_ = other.openingModeSchedule_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateOpeningModeScheduleRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where to create the opening mode
        /// schedule. For example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "opening_mode_schedule_id" field.</summary>
        public const int OpeningModeScheduleIdFieldNumber = 2;
        private string openingModeScheduleId_ = "";

        /// <summary>
        /// The opening mode schedule ID to use for this opening mode schedule. In
        /// case it's empty the server will autogenerate a unique identifier.
        /// </summary>
        public string OpeningModeScheduleId
        {
            get { return openingModeScheduleId_; }
            set
            {
                openingModeScheduleId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "opening_mode_schedule" field.</summary>
        public const int OpeningModeScheduleFieldNumber = 3;
        private OpeningModeSchedule openingModeSchedule_;

        /// <summary>
        /// The opening mode schedule resource to be created. Client must not set the
        /// `OpeningModeSchedule.name` field.
        /// </summary>
        public OpeningModeSchedule OpeningModeSchedule
        {
            get { return openingModeSchedule_; }
            set
            {
                openingModeSchedule_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateOpeningModeScheduleRequest);
        public bool Equals(CreateOpeningModeScheduleRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (OpeningModeScheduleId != other.OpeningModeScheduleId)) return false;
            if (!Equals(OpeningModeSchedule, other.OpeningModeSchedule)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (OpeningModeScheduleId.Length != 0) hash ^= OpeningModeScheduleId.GetHashCode();
            if (openingModeSchedule_ != null) hash ^= OpeningModeSchedule.GetHashCode();
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
      if (OpeningModeScheduleId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(OpeningModeScheduleId);
      }
      if (openingModeSchedule_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(OpeningModeSchedule);
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
            if (OpeningModeScheduleId.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(OpeningModeScheduleId);
            }
            if (openingModeSchedule_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(OpeningModeSchedule);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (OpeningModeScheduleId.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(OpeningModeScheduleId);
            if (openingModeSchedule_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(OpeningModeSchedule);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateOpeningModeScheduleRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.OpeningModeScheduleId.Length != 0) OpeningModeScheduleId = other.OpeningModeScheduleId;
            if (other.openingModeSchedule_ != null)
            {
                if (openingModeSchedule_ == null) OpeningModeSchedule = new OpeningModeSchedule();
                OpeningModeSchedule.MergeFrom(other.OpeningModeSchedule);
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
            OpeningModeScheduleId = input.ReadString();
            break;
          }
          case 26: {
            if (openingModeSchedule_ == null) {
              OpeningModeSchedule = new Saltoapis.Nebula.OpeningModeSchedule.V1.OpeningModeSchedule();
            }
            input.ReadMessage(OpeningModeSchedule);
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
                            OpeningModeScheduleId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (openingModeSchedule_ == null) OpeningModeSchedule = new OpeningModeSchedule();
                            input.ReadMessage(OpeningModeSchedule);
                            break;
                        }
                }
            }
        }
#endif

    }


}
