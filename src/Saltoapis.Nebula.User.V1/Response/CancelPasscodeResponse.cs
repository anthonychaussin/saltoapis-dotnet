using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.User.V1
{
    /// <summary>
    /// The response message for [`CancelPasscode`][salto.nebula.user.v1.UserService.CancelPasscode]
    /// </summary>
    public sealed partial class CancelPasscodeResponse : IMessage<CancelPasscodeResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CancelPasscodeResponse> _parser = new(() => new CancelPasscodeResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CancelPasscodeResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[41]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CancelPasscodeResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CancelPasscodeResponse(CancelPasscodeResponse other) : this()
        {
            passcode_ = other.passcode_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CancelPasscodeResponse Clone() => new(this);
        /// <summary>Field number for the "passcode" field.</summary>
        public const int PasscodeFieldNumber = 1;
        private Passcode passcode_;

        /// <summary>
        /// The canceled passcode.
        /// </summary>
        public Passcode Passcode
        {
            get { return passcode_; }
            set
            {
                passcode_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CancelPasscodeResponse);
        public bool Equals(CancelPasscodeResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!Equals(Passcode, other.Passcode)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (passcode_ != null) hash ^= Passcode.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (passcode_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Passcode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (passcode_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Passcode);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (passcode_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Passcode);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CancelPasscodeResponse other)
        {
            if (other == null) return;
            if (other.passcode_ != null)
            {
                if (passcode_ == null) Passcode = new Passcode();
                Passcode.MergeFrom(other.Passcode);
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
            if (passcode_ == null) {
              Passcode = new Saltoapis.Nebula.User.V1.Passcode();
            }
            input.ReadMessage(Passcode);
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
                            if (passcode_ == null) Passcode = new Passcode();
                            input.ReadMessage(Passcode);
                            break;
                        }
                }
            }
        }
#endif

    }


}
