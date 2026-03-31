namespace Saltoapis.Nebula.Installation.V1.Request
{
    /// <summary>
    /// The request message for [`AcceptInstallationOwnership`][salto.nebula.installation.v1.InstallationService.AcceptInstallationOwnership]
    /// </summary>
    public sealed partial class AcceptInstallationOwnershipRequest : IMessage<AcceptInstallationOwnershipRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AcceptInstallationOwnershipRequest> _parser = new(() => new AcceptInstallationOwnershipRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AcceptInstallationOwnershipRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => InstallationReflection.Descriptor.MessageTypes[25];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public AcceptInstallationOwnershipRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AcceptInstallationOwnershipRequest(AcceptInstallationOwnershipRequest other) : this()
        {
            installation_ = other.installation_;
            billingInfo_ = other.billingInfo_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AcceptInstallationOwnershipRequest Clone() => new(this);
        /// <summary>Field number for the "installation" field.</summary>
        public const int InstallationFieldNumber = 1;
        private string installation_ = "";
        /// <summary>
        /// The resource name for which the accept ownership is being requested.
        /// For example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Installation
        {
            get => installation_; set => installation_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "billing_info" field.</summary>
        public const int BillingInfoFieldNumber = 2;
        private BillingInfo billingInfo_;
        /// <summary>
        /// The billing info resource for the subscription billing.
        /// </summary>
        public BillingInfo BillingInfo
        {
            get => billingInfo_; set => billingInfo_ = value;}

        public override bool Equals(object other) => Equals(other as AcceptInstallationOwnershipRequest);
        public bool Equals(AcceptInstallationOwnershipRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Installation != other.Installation) || (!Equals(BillingInfo, other.BillingInfo))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Installation.Length != 0) hash ^= Installation.GetHashCode();
            if (billingInfo_ != null) hash ^= BillingInfo.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Installation.Length != 0)
      {
        output.WriteRawTag(10);
        output.WriteString(Installation);
      }
      if (billingInfo_ != null)
      {
        output.WriteRawTag(18);
        output.WriteMessage(BillingInfo);
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
            if (Installation.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Installation);
            }
            if (billingInfo_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(BillingInfo);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Installation.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Installation);
            if (billingInfo_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(BillingInfo);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AcceptInstallationOwnershipRequest other)
        {
            if (other == null) return;
            if (other.Installation.Length != 0) Installation = other.Installation;
            if (other.billingInfo_ != null)
            {
                if (billingInfo_ == null) BillingInfo = new BillingInfo();
                BillingInfo.MergeFrom(other.BillingInfo);
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
            Installation = input.ReadString();
            break;
          }
          case 18:
          {
            if (billingInfo_ == null)
            {
              BillingInfo = new Saltoapis.Nebula.Installation.V1.BillingInfo();
            }
            input.ReadMessage(BillingInfo);
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
                            Installation = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            if (billingInfo_ == null) BillingInfo = new BillingInfo();
                            input.ReadMessage(BillingInfo);
                            break;
                        }
                }
            }
        }
#endif
    }

}