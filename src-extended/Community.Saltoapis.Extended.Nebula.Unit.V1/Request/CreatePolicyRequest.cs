namespace Saltoapis.Nebula.Unit.V1.Request
{
    /// <summary>
    /// The request message for [`CreatePolicy`][salto.nebula.unit.v1.UnitService.CreatePolicy]
    /// </summary>
    public sealed partial class CreatePolicyRequest : IMessage<CreatePolicyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreatePolicyRequest> _parser = new(() => new CreatePolicyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreatePolicyRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => UnitReflection.Descriptor.MessageTypes[14];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public CreatePolicyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreatePolicyRequest(CreatePolicyRequest other) : this()
        {
            parent_ = other.parent_;
            policyId_ = other.policyId_;
            policy_ = other.policy_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreatePolicyRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";
        /// <summary>
        /// Resource name of the parent resource where to create the policy. For
        /// example: `installations/salto-hq/units/101`.
        /// </summary>
        public string Parent
        {
            get => parent_; set => parent_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "policy_id" field.</summary>
        public const int PolicyIdFieldNumber = 2;
        private string policyId_ = "";
        /// <summary>
        /// The policy ID to use for policy. In case it's empty the server
        /// will autogenerate a unique identifier.
        /// </summary>
        public string PolicyId
        {
            get => policyId_; set => policyId_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "policy" field.</summary>
        public const int PolicyFieldNumber = 3;
        private Policy policy_;
        /// <summary>
        /// The policy resource to be created. Client must not set the `Policy.name`
        /// field.
        /// </summary>
        public Policy Policy
        {
            get => policy_; set => policy_ = value;}

        public override bool Equals(object other) => Equals(other as CreatePolicyRequest);
        public bool Equals(CreatePolicyRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (PolicyId != other.PolicyId) || !Equals(Policy, other.Policy)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (PolicyId.Length != 0) hash ^= PolicyId.GetHashCode();
            if (policy_ != null) hash ^= Policy.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Parent.Length != 0)
      {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (PolicyId.Length != 0)
      {
        output.WriteRawTag(18);
        output.WriteString(PolicyId);
      }
      if (policy_ != null)
      {
        output.WriteRawTag(26);
        output.WriteMessage(Policy);
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
            if (Parent.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Parent);
            }
            if (PolicyId.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(PolicyId);
            }
            if (policy_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Policy);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (PolicyId.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(PolicyId);
            if (policy_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Policy);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreatePolicyRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.PolicyId.Length != 0) PolicyId = other.PolicyId;
            if (other.policy_ != null)
            {
                if (policy_ == null) Policy = new Policy();
                Policy.MergeFrom(other.Policy);
            }
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
            Parent = input.ReadString();
            break;
          }
          case 18:
          {
            PolicyId = input.ReadString();
            break;
          }
          case 26:
          {
            if (policy_ == null)
            {
              Policy = new Saltoapis.Nebula.Unit.V1.Policy();
            }
            input.ReadMessage(Policy);
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
                            PolicyId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (policy_ == null) Policy = new Policy();
                            input.ReadMessage(Policy);
                            break;
                        }
                }
            }
        }
#endif
    }

}