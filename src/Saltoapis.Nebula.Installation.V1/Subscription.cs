using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Installation.V1
{
    /// <summary>
    /// The subscription information
    /// </summary>
    public sealed partial class Subscription : IMessage<Subscription>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Subscription> _parser = new(() => new Subscription());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Subscription> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Subscription()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Subscription(Subscription other) : this()
        {
            name_ = other.name_;
            trialEndTime_ = other.trialEndTime_?.Clone();
            billingInfo_ = other.billingInfo_?.Clone();
            paymentMethod_ = other.paymentMethod_?.Clone();
            coupons_ = other.coupons_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Subscription Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the subscription. It must have the format of
        /// `installations/*/subscription`. For example:
        /// `installations/surelock-homes-hq/subscription`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "trial_end_time" field.</summary>
        public const int TrialEndTimeFieldNumber = 3;
        private Google.Protobuf.WellKnownTypes.Timestamp trialEndTime_;

        /// <summary>
        /// End of the trial period for the subscription.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp TrialEndTime
        {
            get { return trialEndTime_; }
            set
            {
                trialEndTime_ = value;
            }
        }

        /// <summary>Field number for the "billing_info" field.</summary>
        public const int BillingInfoFieldNumber = 4;
        private BillingInfo billingInfo_;

        /// <summary>
        /// The billing information of the subscription.
        /// </summary>
        public BillingInfo BillingInfo
        {
            get { return billingInfo_; }
            set
            {
                billingInfo_ = value;
            }
        }

        /// <summary>Field number for the "payment_method" field.</summary>
        public const int PaymentMethodFieldNumber = 5;
        private PaymentMethod paymentMethod_;

        /// <summary>
        /// The payment method of the subscription.
        /// </summary>
        public PaymentMethod PaymentMethod
        {
            get { return paymentMethod_; }
            set
            {
                paymentMethod_ = value;
            }
        }

        /// <summary>Field number for the "coupons" field.</summary>
        public const int CouponsFieldNumber = 6;
        private static readonly FieldCodec<Coupon> _repeated_coupons_codec
            = FieldCodec.ForMessage(50, Coupon.Parser);
        private readonly RepeatedField<Coupon> coupons_ = [];

        /// <summary>
        /// The coupons applied to the subscription.
        /// </summary>
        public RepeatedField<Coupon> Coupons
        {
            get { return coupons_; }
        }

        public override bool Equals(object other) => Equals(other as Subscription);
        public bool Equals(Subscription other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (!Equals(TrialEndTime, other.TrialEndTime))) return false;
            if ((!Equals(BillingInfo, other.BillingInfo)) || (!Equals(PaymentMethod, other.PaymentMethod))) return false;
            if (!coupons_.Equals(other.coupons_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (trialEndTime_ != null) hash ^= TrialEndTime.GetHashCode();
            if (billingInfo_ != null) hash ^= BillingInfo.GetHashCode();
            if (paymentMethod_ != null) hash ^= PaymentMethod.GetHashCode();
            hash ^= coupons_.GetHashCode();
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
      if (trialEndTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(TrialEndTime);
      }
      if (billingInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(BillingInfo);
      }
      if (paymentMethod_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(PaymentMethod);
      }
      coupons_.WriteTo(output, _repeated_coupons_codec);
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
            if (trialEndTime_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(TrialEndTime);
            }
            if (billingInfo_ != null)
            {
                output.WriteRawTag(34);
                output.WriteMessage(BillingInfo);
            }
            if (paymentMethod_ != null)
            {
                output.WriteRawTag(42);
                output.WriteMessage(PaymentMethod);
            }
            coupons_.WriteTo(ref output, _repeated_coupons_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (trialEndTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(TrialEndTime);
            if (billingInfo_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(BillingInfo);
            if (paymentMethod_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(PaymentMethod);
            size += coupons_.CalculateSize(_repeated_coupons_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Subscription other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.trialEndTime_ != null)
            {
                if (trialEndTime_ == null) TrialEndTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                TrialEndTime.MergeFrom(other.TrialEndTime);
            }
            if (other.billingInfo_ != null)
            {
                if (billingInfo_ == null) BillingInfo = new BillingInfo();
                BillingInfo.MergeFrom(other.BillingInfo);
            }
            if (other.paymentMethod_ != null)
            {
                if (paymentMethod_ == null) PaymentMethod = new PaymentMethod();
                PaymentMethod.MergeFrom(other.PaymentMethod);
            }
            coupons_.Add(other.coupons_);
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
          case 26: {
            if (trialEndTime_ == null) {
              TrialEndTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(TrialEndTime);
            break;
          }
          case 34: {
            if (billingInfo_ == null) {
              BillingInfo = new Saltoapis.Nebula.Installation.V1.BillingInfo();
            }
            input.ReadMessage(BillingInfo);
            break;
          }
          case 42: {
            if (paymentMethod_ == null) {
              PaymentMethod = new Saltoapis.Nebula.Installation.V1.PaymentMethod();
            }
            input.ReadMessage(PaymentMethod);
            break;
          }
          case 50: {
            coupons_.AddEntriesFrom(input, _repeated_coupons_codec);
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
                    case 26:
                        {
                            if (trialEndTime_ == null) TrialEndTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(TrialEndTime);
                            break;
                        }
                    case 34:
                        {
                            if (billingInfo_ == null) BillingInfo = new BillingInfo();
                            input.ReadMessage(BillingInfo);
                            break;
                        }
                    case 42:
                        {
                            if (paymentMethod_ == null) PaymentMethod = new PaymentMethod();
                            input.ReadMessage(PaymentMethod);
                            break;
                        }
                    case 50:
                        {
                            coupons_.AddEntriesFrom(ref input, _repeated_coupons_codec);
                            break;
                        }
                }
            }
        }
#endif

    }


}
