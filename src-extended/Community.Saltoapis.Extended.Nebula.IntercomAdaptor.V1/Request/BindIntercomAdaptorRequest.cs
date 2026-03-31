namespace Saltoapis.Nebula.IntercomAdaptor.V1.Request
{
    /// <summary>
    /// The request message for [`BindIntercomAdaptor`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.BindIntercomAdaptor]
    /// </summary>
    public sealed partial class BindIntercomAdaptorRequest : IMessage<BindIntercomAdaptorRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BindIntercomAdaptorRequest> _parser = new(() => new BindIntercomAdaptorRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BindIntercomAdaptorRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => IntercomAdaptorReflection.Descriptor.MessageTypes[8];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public BindIntercomAdaptorRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BindIntercomAdaptorRequest(BindIntercomAdaptorRequest other) : this()
        {
            name_ = other.name_;
            deviceId_ = other.deviceId_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BindIntercomAdaptorRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        /// <summary>
        /// The resource name of the intercom adaptor to be bound. For example:
        /// `installations/surelock-homes-hq/intercom-adaptors/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get => name_; set => name_ = ProtoPreconditions.CheckNotNull(value, "value");}
        /// <summary>Field number for the "device_id" field.</summary>
        public const int DeviceIdFieldNumber = 2;
        private string deviceId_ = "";
        /// <summary>
        /// Globally unique identifier that is used across all devices manufactured
        /// by SALTO, including gateways, extenders, intercom adaptors and so on.
        /// </summary>
        public string DeviceId
        {
            get => deviceId_; set => deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");}

        public override bool Equals(object other) => Equals(other as BindIntercomAdaptorRequest);
        public bool Equals(BindIntercomAdaptorRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (DeviceId != other.DeviceId)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DeviceId.Length != 0) hash ^= DeviceId.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Name.Length != 0)
      {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DeviceId.Length != 0)
      {
        output.WriteRawTag(18);
        output.WriteString(DeviceId);
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
            if (Name.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Name);
            }
            if (DeviceId.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(DeviceId);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (DeviceId.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(BindIntercomAdaptorRequest other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.DeviceId.Length != 0) DeviceId = other.DeviceId;
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
            Name = input.ReadString();
            break;
          }
          case 18:
          {
            DeviceId = input.ReadString();
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
                            DeviceId = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif
    }

}