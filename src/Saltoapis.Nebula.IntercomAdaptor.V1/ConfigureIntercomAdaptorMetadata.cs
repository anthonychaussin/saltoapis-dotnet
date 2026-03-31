using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.IntercomAdaptor.V1
{
    /// <summary>
    /// The metadata message for [`ConfigureIntercomAdaptor`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.ConfigureIntercomAdaptor]
    /// </summary>
    public sealed partial class ConfigureIntercomAdaptorMetadata : IMessage<ConfigureIntercomAdaptorMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureIntercomAdaptorMetadata> _parser = new(() => new ConfigureIntercomAdaptorMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureIntercomAdaptorMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[17]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureIntercomAdaptorMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureIntercomAdaptorMetadata(ConfigureIntercomAdaptorMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureIntercomAdaptorMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ConfigureIntercomAdaptorMetadata);
        public bool Equals(ConfigureIntercomAdaptorMetadata other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ConfigureIntercomAdaptorMetadata other)
        {
            if (other == null) return;
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
                _unknownFields = tag switch
                {
                    _ => UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input),
                };
            }
        }
#endif

    }


}
