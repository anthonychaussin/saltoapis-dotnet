using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Installation.V1.Request
{
    /// <summary>
    /// The request message for [`UnapplyCoupon`][salto.nebula.installation.v1.InstallationService.UnapplyCoupon]
    /// </summary>
    public sealed partial class UnapplyCouponRequest : IMessage<UnapplyCouponRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnapplyCouponRequest> _parser = new(() => new UnapplyCouponRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnapplyCouponRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[37]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnapplyCouponRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnapplyCouponRequest(UnapplyCouponRequest other) : this()
        {
            subscription_ = other.subscription_;
            coupon_ = other.coupon_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnapplyCouponRequest Clone() => new(this);
        /// <summary>Field number for the "subscription" field.</summary>
        public const int SubscriptionFieldNumber = 1;
        private string subscription_ = "";

        /// <summary>
        /// The resource name of the subscription for which the coupon is being
        /// requested to be unapplied. For example:
        /// `installations/surelock-homes-hq/subscription`.
        /// </summary>
        public string Subscription
        {
            get { return subscription_; }
            set
            {
                subscription_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "coupon" field.</summary>
        public const int CouponFieldNumber = 2;
        private string coupon_ = "";

        /// <summary>
        /// The resource name of the coupon that is requested to be unapplied.
        /// For example: `installations/surelock-homes-hq/subscription/coupons/01HCD0YB`.
        /// </summary>
        public string Coupon
        {
            get { return coupon_; }
            set
            {
                coupon_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as UnapplyCouponRequest);
        public bool Equals(UnapplyCouponRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Subscription != other.Subscription) || (Coupon != other.Coupon)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Subscription.Length != 0) hash ^= Subscription.GetHashCode();
            if (Coupon.Length != 0) hash ^= Coupon.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Subscription.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Subscription);
      }
      if (Coupon.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Coupon);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Subscription.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Subscription);
            }
            if (Coupon.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Coupon);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Subscription.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Subscription);
            if (Coupon.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Coupon);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UnapplyCouponRequest other)
        {
            if (other == null) return;
            if (other.Subscription.Length != 0) Subscription = other.Subscription;
            if (other.Coupon.Length != 0) Coupon = other.Coupon;
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
            Subscription = input.ReadString();
            break;
          }
          case 18: {
            Coupon = input.ReadString();
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
                            Subscription = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Coupon = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }


}
