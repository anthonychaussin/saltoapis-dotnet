using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.User.V1.Response
{
    /// <summary>
    /// The response message for [`ListUsers`][salto.nebula.user.v1.UserService.ListUsers]
    /// </summary>
    public sealed partial class ListUsersResponse : IMessage<ListUsersResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListUsersResponse> _parser = new(() => new ListUsersResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListUsersResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[12]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListUsersResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListUsersResponse(ListUsersResponse other) : this()
        {
            users_ = other.users_.Clone();
            nextPageToken_ = other.nextPageToken_;
            totalSize_ = other.totalSize_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListUsersResponse Clone() => new(this);
        /// <summary>Field number for the "users" field.</summary>
        public const int UsersFieldNumber = 1;
        private static readonly FieldCodec<User> _repeated_users_codec
            = FieldCodec.ForMessage(10, User.Parser);
        private readonly RepeatedField<User> users_ = [];

        /// <summary>
        /// The field name should match the noun `users` in the method name. There
        /// will be a maximum number of items returned based on the `page_size` field
        /// in the request.
        /// </summary>
        public RepeatedField<User> Users
        {
            get { return users_; }
        }

        /// <summary>Field number for the "next_page_token" field.</summary>
        public const int NextPageTokenFieldNumber = 2;
        private string nextPageToken_ = "";

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more
        /// results in the list.
        /// </summary>
        public string NextPageToken
        {
            get { return nextPageToken_; }
            set
            {
                nextPageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "total_size" field.</summary>
        public const int TotalSizeFieldNumber = 3;
        private int totalSize_;

        /// <summary>
        /// The total number of users in all pages, irrespective of any pagination.
        /// This is an estimated number based on the requested filter, and it may change in
        /// subsequent pages.
        /// </summary>
        public int TotalSize
        {
            get { return totalSize_; }
            set
            {
                totalSize_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as ListUsersResponse);
        public bool Equals(ListUsersResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!users_.Equals(other.users_)) || (NextPageToken != other.NextPageToken)) return false;
            if (TotalSize != other.TotalSize) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= users_.GetHashCode();
            if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
            if (TotalSize != 0) hash ^= TotalSize.GetHashCode();
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
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      if (TotalSize != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(TotalSize);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            users_.WriteTo(ref output, _repeated_users_codec);
            if (NextPageToken.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(NextPageToken);
            }
            if (TotalSize != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(TotalSize);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += users_.CalculateSize(_repeated_users_codec);
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (TotalSize != 0) size += 1 + CodedOutputStream.ComputeInt32Size(TotalSize);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListUsersResponse other)
        {
            if (other == null) return;
            users_.Add(other.users_);
            if (other.NextPageToken.Length != 0) NextPageToken = other.NextPageToken;
            if (other.TotalSize != 0) TotalSize = other.TotalSize;
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
          case 18: {
            NextPageToken = input.ReadString();
            break;
          }
          case 24: {
            TotalSize = input.ReadInt32();
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
                    case 18:
                        {
                            NextPageToken = input.ReadString();
                            break;
                        }
                    case 24:
                        {
                            TotalSize = input.ReadInt32();
                            break;
                        }
                }
            }
        }
#endif

    }


}
