namespace Saltoapis.Nebula.IntercomAdaptor.V1
{
    /// <summary>
    /// The intercom adaptor's access point association
    /// </summary>
    public sealed partial class IntercomAdaptorAccessPoint : IMessage<IntercomAdaptorAccessPoint>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<IntercomAdaptorAccessPoint> _parser = new(() => new IntercomAdaptorAccessPoint());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<IntercomAdaptorAccessPoint> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public IntercomAdaptorAccessPoint()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public IntercomAdaptorAccessPoint(IntercomAdaptorAccessPoint other) : this()
        {
            accessPoint_ = other.accessPoint_;
            frameSettings_ = other.frameSettings_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public IntercomAdaptorAccessPoint Clone() => new(this);
        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 1;
        private string accessPoint_ = "";

        /// <summary>
        /// The access point resource name to bind as an association to the parent
        /// intercom adaptor. For example:
        /// `installations/surelock-homes-hq/access-points/baker-street-entrance`.
        /// </summary>
        public string AccessPoint
        {
            get { return accessPoint_; }
            set
            {
                accessPoint_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "frame_settings" field.</summary>
        public const int FrameSettingsFieldNumber = 2;
        private static readonly ByteString FrameSettingsDefaultValue = ByteString.Empty;

        private ByteString frameSettings_;

        /// <summary>
        /// The set of learnt frames. Left unset for analog intercoms.
        /// </summary>
        public ByteString FrameSettings
        {
            get { return frameSettings_ ?? FrameSettingsDefaultValue; }
            set
            {
                frameSettings_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "frame_settings" field is set</summary>
        public bool HasFrameSettings
        {
            get { return frameSettings_ != null; }
        }

        /// <summary>Clears the value of the "frame_settings" field</summary>
        public void ClearFrameSettings()
        {
            frameSettings_ = null;
        }

        public override bool Equals(object other) => Equals(other as IntercomAdaptorAccessPoint);
        public bool Equals(IntercomAdaptorAccessPoint other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((AccessPoint != other.AccessPoint) || (FrameSettings != other.FrameSettings)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (AccessPoint.Length != 0) hash ^= AccessPoint.GetHashCode();
            if (HasFrameSettings) hash ^= FrameSettings.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (AccessPoint.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AccessPoint);
      }
      if (HasFrameSettings) {
        output.WriteRawTag(18);
        output.WriteBytes(FrameSettings);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (AccessPoint.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(AccessPoint);
            }
            if (HasFrameSettings)
            {
                output.WriteRawTag(18);
                output.WriteBytes(FrameSettings);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (AccessPoint.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(AccessPoint);
            if (HasFrameSettings) size += 1 + CodedOutputStream.ComputeBytesSize(FrameSettings);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(IntercomAdaptorAccessPoint other)
        {
            if (other == null) return;
            if (other.AccessPoint.Length != 0) AccessPoint = other.AccessPoint;
            if (other.HasFrameSettings) FrameSettings = other.FrameSettings;
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
            AccessPoint = input.ReadString();
            break;
          }
          case 18: {
            FrameSettings = input.ReadBytes();
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
                            AccessPoint = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            FrameSettings = input.ReadBytes();
                            break;
                        }
                }
            }
        }
#endif

    }


}
