namespace Saltoapis.Nebula.IntercomAdaptor.V1.Request
{
    /// <summary>
    /// The request message for [`GenerateFirmwareDownloadUri`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.GenerateFirmwareDownloadUri]
    /// </summary>
    public sealed partial class GenerateFirmwareDownloadUriRequest : IMessage<GenerateFirmwareDownloadUriRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GenerateFirmwareDownloadUriRequest> _parser = new(() => new GenerateFirmwareDownloadUriRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GenerateFirmwareDownloadUriRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => IntercomAdaptorReflection.Descriptor.MessageTypes[26];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public GenerateFirmwareDownloadUriRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GenerateFirmwareDownloadUriRequest(GenerateFirmwareDownloadUriRequest other) : this()
        {
            intercomAdaptor_ = other.intercomAdaptor_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateFirmwareDownloadUriRequest Clone() => new(this);
        /// <summary>Field number for the "intercom_adaptor" field.</summary>
        public const int IntercomAdaptorFieldNumber = 1;
        private string intercomAdaptor_ = "";
        /// <summary>
        /// The resource name of the intercom adaptor to get the firmware download URI.
        /// For example: `installations/surelock-homes-hq/intercom-adaptors/baker-street-entrance`.
        /// </summary>
        public string IntercomAdaptor
        {
            get => intercomAdaptor_; set => intercomAdaptor_ = ProtoPreconditions.CheckNotNull(value, "value");}

        public override bool Equals(object other) => Equals(other as GenerateFirmwareDownloadUriRequest);
        public bool Equals(GenerateFirmwareDownloadUriRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
return IntercomAdaptor != other.IntercomAdaptor ? false : Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (IntercomAdaptor.Length != 0) hash ^= IntercomAdaptor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (IntercomAdaptor.Length != 0)
      {
        output.WriteRawTag(10);
        output.WriteString(IntercomAdaptor);
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
            if (IntercomAdaptor.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(IntercomAdaptor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (IntercomAdaptor.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(IntercomAdaptor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(GenerateFirmwareDownloadUriRequest other)
        {
            if (other == null) return;
            if (other.IntercomAdaptor.Length != 0) IntercomAdaptor = other.IntercomAdaptor;
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
            IntercomAdaptor = input.ReadString();
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
                            IntercomAdaptor = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif
    }

}