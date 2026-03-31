using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Unit.V1
{
    /// <summary>
    /// Representation of an IAM policy inside the API
    /// </summary>
    public sealed partial class Policy : IMessage<Policy>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Policy> _parser = new(() => new Policy());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Policy> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Policy()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Policy(Policy other) : this()
        {
            name_ = other.name_;
            member_ = other.member_;
            roles_ = other.roles_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Policy Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the policy. It must have the format of
        /// `installations/*/units/*/iam-policies`, for example:
        /// `installations/surelock-homes-hq/units/101/iam-policies/standard`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "member" field.</summary>
        public const int MemberFieldNumber = 2;
        private string member_ = "";

        /// <summary>
        /// Specifies the identity requesting access to this resource.
        /// </summary>
        public string Member
        {
            get { return member_; }
            set
            {
                member_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "roles" field.</summary>
        public const int RolesFieldNumber = 3;
        private static readonly FieldCodec<string> _repeated_roles_codec
            = FieldCodec.ForString(26);
        private readonly RepeatedField<string> roles_ = [];

        /// <summary>
        /// The names of the roles this policy grants.
        /// </summary>
        public RepeatedField<string> Roles
        {
            get { return roles_; }
        }

        public override bool Equals(object other) => Equals(other as Policy);
        public bool Equals(Policy other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (Member != other.Member)) return false;
            if (!roles_.Equals(other.roles_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (Member.Length != 0) hash ^= Member.GetHashCode();
            hash ^= roles_.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Member.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Member);
      }
      roles_.WriteTo(output, _repeated_roles_codec);
      if (_unknownFields != null) {
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
            if (Member.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Member);
            }
            roles_.WriteTo(ref output, _repeated_roles_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (Member.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Member);
            size += roles_.CalculateSize(_repeated_roles_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Policy other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.Member.Length != 0) Member = other.Member;
            roles_.Add(other.roles_);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            Member = input.ReadString();
            break;
          }
          case 26: {
            roles_.AddEntriesFrom(input, _repeated_roles_codec);
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
                    case 18:
                        {
                            Member = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            roles_.AddEntriesFrom(ref input, _repeated_roles_codec);
                            break;
                        }
                }
            }
        }
#endif

    }


}
