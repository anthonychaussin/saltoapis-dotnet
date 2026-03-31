namespace Saltoapis.Nebula.Gateway.V1
{
    /// <summary>
    /// IPv4 (Internet Protocol version 4) settings
    /// </summary>
    public sealed partial class IPv4Settings : IMessage<IPv4Settings>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<IPv4Settings> _parser = new(() => new IPv4Settings());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<IPv4Settings> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return GatewayReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public IPv4Settings()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public IPv4Settings(IPv4Settings other) : this()
        {
            ipAddress_ = other.ipAddress_;
            mask_ = other.mask_;
            routerAddress_ = other.routerAddress_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public IPv4Settings Clone() => new(this);
        /// <summary>Field number for the "ip_address" field.</summary>
        public const int IpAddressFieldNumber = 1;
        private static readonly string IpAddressDefaultValue = "";

        private string ipAddress_;

        /// <summary>
        /// IP address
        ///
        /// If unset, an automatic value given by the network will be used.
        /// </summary>
        public string IpAddress
        {
            get { return ipAddress_ ?? IpAddressDefaultValue; }
            set
            {
                ipAddress_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "ip_address" field is set</summary>
        public bool HasIpAddress
        {
            get { return ipAddress_ != null; }
        }

        /// <summary>Clears the value of the "ip_address" field</summary>
        public void ClearIpAddress()
        {
            ipAddress_ = null;
        }

        /// <summary>Field number for the "mask" field.</summary>
        public const int MaskFieldNumber = 2;
        private static readonly string MaskDefaultValue = "";

        private string mask_;

        /// <summary>
        /// Subnet mask is expressed in dot-decimal notation like an address.
        /// For example: 255.255.255.0 is the subnet mask for the prefix
        /// 198.51.100.0/24.
        ///
        /// If unset, an automatic value given by the network will be used.
        /// </summary>
        public string Mask
        {
            get { return mask_ ?? MaskDefaultValue; }
            set
            {
                mask_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "mask" field is set</summary>
        public bool HasMask
        {
            get { return mask_ != null; }
        }

        /// <summary>Clears the value of the "mask" field</summary>
        public void ClearMask()
        {
            mask_ = null;
        }

        /// <summary>Field number for the "router_address" field.</summary>
        public const int RouterAddressFieldNumber = 3;
        private static readonly string RouterAddressDefaultValue = "";

        private string routerAddress_;

        /// <summary>
        /// Default network router's IP address
        ///
        /// If unset, an automatic value given by the network will be used.
        /// </summary>
        public string RouterAddress
        {
            get { return routerAddress_ ?? RouterAddressDefaultValue; }
            set
            {
                routerAddress_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "router_address" field is set</summary>
        public bool HasRouterAddress
        {
            get { return routerAddress_ != null; }
        }

        /// <summary>Clears the value of the "router_address" field</summary>
        public void ClearRouterAddress()
        {
            routerAddress_ = null;
        }

        public override bool Equals(object other) => Equals(other as IPv4Settings);
        public bool Equals(IPv4Settings other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((IpAddress != other.IpAddress) || (Mask != other.Mask)) return false;
            if (RouterAddress != other.RouterAddress) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (HasIpAddress) hash ^= IpAddress.GetHashCode();
            if (HasMask) hash ^= Mask.GetHashCode();
            if (HasRouterAddress) hash ^= RouterAddress.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (HasIpAddress) {
        output.WriteRawTag(10);
        output.WriteString(IpAddress);
      }
      if (HasMask) {
        output.WriteRawTag(18);
        output.WriteString(Mask);
      }
      if (HasRouterAddress) {
        output.WriteRawTag(26);
        output.WriteString(RouterAddress);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (HasIpAddress)
            {
                output.WriteRawTag(10);
                output.WriteString(IpAddress);
            }
            if (HasMask)
            {
                output.WriteRawTag(18);
                output.WriteString(Mask);
            }
            if (HasRouterAddress)
            {
                output.WriteRawTag(26);
                output.WriteString(RouterAddress);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (HasIpAddress) size += 1 + CodedOutputStream.ComputeStringSize(IpAddress);
            if (HasMask) size += 1 + CodedOutputStream.ComputeStringSize(Mask);
            if (HasRouterAddress) size += 1 + CodedOutputStream.ComputeStringSize(RouterAddress);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(IPv4Settings other)
        {
            if (other == null) return;
            if (other.HasIpAddress) IpAddress = other.IpAddress;
            if (other.HasMask) Mask = other.Mask;
            if (other.HasRouterAddress) RouterAddress = other.RouterAddress;
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
            IpAddress = input.ReadString();
            break;
          }
          case 18: {
            Mask = input.ReadString();
            break;
          }
          case 26: {
            RouterAddress = input.ReadString();
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
                            IpAddress = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Mask = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            RouterAddress = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }


}
