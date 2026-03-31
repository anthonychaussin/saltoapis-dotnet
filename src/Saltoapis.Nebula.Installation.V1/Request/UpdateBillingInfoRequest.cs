using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Installation.V1.Request
{
    /// <summary>
    /// (-- api-linter: core::0134::request-mask-required=disabled
    ///     aip.dev/not-precedent: We need to do this to simplify the update operation. --)
    /// The request message for [`UpdateBillingInfo`][salto.nebula.installation.v1.InstallationService.UpdateBillingInfo]
    /// </summary>
    public sealed partial class UpdateBillingInfoRequest : IMessage<UpdateBillingInfoRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateBillingInfoRequest> _parser = new(() => new UpdateBillingInfoRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateBillingInfoRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[28]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateBillingInfoRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateBillingInfoRequest(UpdateBillingInfoRequest other) : this()
        {
            billingInfo_ = other.billingInfo_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateBillingInfoRequest Clone() => new(this);
        /// <summary>Field number for the "billing_info" field.</summary>
        public const int BillingInfoFieldNumber = 1;
        private BillingInfo billingInfo_;

        /// <summary>
        /// The billing info resource which replaces the resource on the server.
        /// </summary>
        public BillingInfo BillingInfo
        {
            get { return billingInfo_; }
            set
            {
                billingInfo_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateBillingInfoRequest);
        public bool Equals(UpdateBillingInfoRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!Equals(BillingInfo, other.BillingInfo)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
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
      if (billingInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(BillingInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (billingInfo_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(BillingInfo);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (billingInfo_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(BillingInfo);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateBillingInfoRequest other)
        {
            if (other == null) return;
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
            if (billingInfo_ == null) {
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
