namespace Saltoapis.Nebula.Installation.V1.Request
{
    /// <summary>
    /// The request message for [`UpdatePolicy`][salto.nebula.installation.v1.InstallationService.UpdatePolicy]
    /// </summary>
    public sealed partial class UpdatePolicyRequest : IMessage<UpdatePolicyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdatePolicyRequest> _parser = new(() => new UpdatePolicyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdatePolicyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[19]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdatePolicyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdatePolicyRequest(UpdatePolicyRequest other) : this()
        {
            policy_ = other.policy_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdatePolicyRequest Clone() => new(this);
        /// <summary>Field number for the "policy" field.</summary>
        public const int PolicyFieldNumber = 1;
        private Policy policy_;

        /// <summary>
        /// The policy resource which replaces the resource on the server.
        /// </summary>
        public Policy Policy
        {
            get { return policy_; }
            set
            {
                policy_ = value;
            }
        }

        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;

        /// <summary>
        /// The update mask applied to the resource.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get { return updateMask_; }
            set
            {
                updateMask_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UpdatePolicyRequest);
        public bool Equals(UpdatePolicyRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(Policy, other.Policy)) || (!Equals(UpdateMask, other.UpdateMask))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (policy_ != null) hash ^= Policy.GetHashCode();
            if (updateMask_ != null) hash ^= UpdateMask.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (policy_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Policy);
      }
      if (updateMask_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UpdateMask);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (policy_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Policy);
            }
            if (updateMask_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(UpdateMask);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (policy_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Policy);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdatePolicyRequest other)
        {
            if (other == null) return;
            if (other.policy_ != null)
            {
                if (policy_ == null) Policy = new Policy();
                Policy.MergeFrom(other.Policy);
            }
            if (other.updateMask_ != null)
            {
                if (updateMask_ == null) UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                UpdateMask.MergeFrom(other.UpdateMask);
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
            if (policy_ == null) {
              Policy = new Saltoapis.Nebula.Installation.V1.Policy();
            }
            input.ReadMessage(Policy);
            break;
          }
          case 18: {
            if (updateMask_ == null) {
              UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
            }
            input.ReadMessage(UpdateMask);
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
                            if (policy_ == null) Policy = new Policy();
                            input.ReadMessage(Policy);
                            break;
                        }
                    case 18:
                        {
                            if (updateMask_ == null) UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                            input.ReadMessage(UpdateMask);
                            break;
                        }
                }
            }
        }
#endif

    }


}
