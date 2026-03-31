using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.User.V1.Response
{
    /// <summary>
    /// The response message for [`ListUserAccessRights`][salto.nebula.user.v1.UserService.ListUserAccessRights]
    /// </summary>
    public sealed partial class ListUserAccessRightsResponse : IMessage<ListUserAccessRightsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListUserAccessRightsResponse> _parser = new(() => new ListUserAccessRightsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListUserAccessRightsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[22]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListUserAccessRightsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListUserAccessRightsResponse(ListUserAccessRightsResponse other) : this()
        {
            userAccessRights_ = other.userAccessRights_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListUserAccessRightsResponse Clone() => new(this);
        /// <summary>Field number for the "user_access_rights" field.</summary>
        public const int UserAccessRightsFieldNumber = 1;
        private static readonly FieldCodec<UserAccessRight> _repeated_userAccessRights_codec
            = FieldCodec.ForMessage(10, UserAccessRight.Parser);
        private readonly RepeatedField<UserAccessRight> userAccessRights_ = [];

        /// <summary>
        /// The field name should match the noun `user_access_rights` in the method
        /// name. There will be a maximum number of items returned based on the
        /// `page_size` field in the request.
        /// </summary>
        public RepeatedField<UserAccessRight> UserAccessRights
        {
            get { return userAccessRights_; }
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

        public override bool Equals(object other) => Equals(other as ListUserAccessRightsResponse);
        public bool Equals(ListUserAccessRightsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!userAccessRights_.Equals(other.userAccessRights_)) || (NextPageToken != other.NextPageToken)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= userAccessRights_.GetHashCode();
            if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      userAccessRights_.WriteTo(output, _repeated_userAccessRights_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            userAccessRights_.WriteTo(ref output, _repeated_userAccessRights_codec);
            if (NextPageToken.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(NextPageToken);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += userAccessRights_.CalculateSize(_repeated_userAccessRights_codec);
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListUserAccessRightsResponse other)
        {
            if (other == null) return;
            userAccessRights_.Add(other.userAccessRights_);
            if (other.NextPageToken.Length != 0) NextPageToken = other.NextPageToken;
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
            userAccessRights_.AddEntriesFrom(input, _repeated_userAccessRights_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
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
                            userAccessRights_.AddEntriesFrom(ref input, _repeated_userAccessRights_codec);
                            break;
                        }
                    case 18:
                        {
                            NextPageToken = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }


}
