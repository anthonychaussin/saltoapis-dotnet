namespace Saltoapis.Nebula.User.V1.Response
{
    /// <summary>
    /// The response message for [`BatchGetUsers`][salto.nebula.accesspoint.v1.UserService.BatchGetUsers]
    /// </summary>
    public sealed partial class BatchGetUsersResponse : IMessage<BatchGetUsersResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchGetUsersResponse> _parser = new(() => new BatchGetUsersResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchGetUsersResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchGetUsersResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchGetUsersResponse(BatchGetUsersResponse other) : this()
        {
            users_ = other.users_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchGetUsersResponse Clone() => new(this);
        /// <summary>Field number for the "users" field.</summary>
        public const int UsersFieldNumber = 1;
        private static readonly FieldCodec<User> _repeated_users_codec
            = FieldCodec.ForMessage(10, User.Parser);
        private readonly RepeatedField<User> users_ = [];

        /// <summary>
        /// Users requested.
        /// </summary>
        public RepeatedField<User> Users
        {
            get { return users_; }
        }

        public override bool Equals(object other) => Equals(other as BatchGetUsersResponse);
        public bool Equals(BatchGetUsersResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!users_.Equals(other.users_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= users_.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      users_.WriteTo(output, _repeated_users_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            users_.WriteTo(ref output, _repeated_users_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += users_.CalculateSize(_repeated_users_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(BatchGetUsersResponse other)
        {
            if (other == null) return;
            users_.Add(other.users_);
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
            users_.AddEntriesFrom(input, _repeated_users_codec);
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
                            users_.AddEntriesFrom(ref input, _repeated_users_codec);
                            break;
                        }
                }
            }
        }
#endif

    }


}
