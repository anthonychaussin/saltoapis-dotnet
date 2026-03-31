namespace Saltoapis.Nebula.Installation.V1.Request
{
    /// <summary>
    /// The request message for [`DeleteInstallation`][salto.nebula.installation.v1.InstallationService.DeleteInstallation]
    /// </summary>
    public sealed partial class DeleteInstallationRequest : IMessage<DeleteInstallationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteInstallationRequest> _parser = new(() => new DeleteInstallationRequest());
        private UnknownFieldSet _unknownFields;
        private int _hasBits0;

        public static MessageParser<DeleteInstallationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteInstallationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteInstallationRequest(DeleteInstallationRequest other) : this()
        {
            _hasBits0 = other._hasBits0;
            name_ = other.name_;
            validateOnly_ = other.validateOnly_;
            delayHours_ = other.delayHours_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteInstallationRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the installation to be soft deleted. For example:
        /// `installations/surelock-homes-hq`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "validate_only" field.</summary>
        public const int ValidateOnlyFieldNumber = 2;
        private static readonly bool ValidateOnlyDefaultValue = false;

        private bool validateOnly_;

        /// <summary>
        /// If set, validate the request but do not actually delete the installation.
        /// </summary>
        public bool ValidateOnly
        {
            get { if ((_hasBits0 & 1) != 0) { return validateOnly_; } else { return ValidateOnlyDefaultValue; } }
            set
            {
                _hasBits0 |= 1;
                validateOnly_ = value;
            }
        }

        /// <summary>Gets whether the "validate_only" field is set</summary>
        public bool HasValidateOnly
        {
            get { return (_hasBits0 & 1) != 0; }
        }

        /// <summary>Clears the value of the "validate_only" field</summary>
        public void ClearValidateOnly()
        {
            _hasBits0 &= ~1;
        }

        /// <summary>Field number for the "delay_hours" field.</summary>
        public const int DelayHoursFieldNumber = 3;
        private static readonly int DelayHoursDefaultValue = 0;

        private int delayHours_;

        /// <summary>
        /// The number of hours to wait before permanently deleting the installation.
        /// If unset, the default is 720 (30 days).
        /// </summary>
        public int DelayHours
        {
            get { if ((_hasBits0 & 2) != 0) { return delayHours_; } else { return DelayHoursDefaultValue; } }
            set
            {
                _hasBits0 |= 2;
                delayHours_ = value;
            }
        }

        /// <summary>Gets whether the "delay_hours" field is set</summary>
        public bool HasDelayHours
        {
            get { return (_hasBits0 & 2) != 0; }
        }

        /// <summary>Clears the value of the "delay_hours" field</summary>
        public void ClearDelayHours()
        {
            _hasBits0 &= ~2;
        }

        public override bool Equals(object other) => Equals(other as DeleteInstallationRequest);
        public bool Equals(DeleteInstallationRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (ValidateOnly != other.ValidateOnly)) return false;
            if (DelayHours != other.DelayHours) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (HasValidateOnly) hash ^= ValidateOnly.GetHashCode();
            if (HasDelayHours) hash ^= DelayHours.GetHashCode();
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
      if (HasValidateOnly) {
        output.WriteRawTag(16);
        output.WriteBool(ValidateOnly);
      }
      if (HasDelayHours) {
        output.WriteRawTag(24);
        output.WriteInt32(DelayHours);
      }
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
            if (HasValidateOnly)
            {
                output.WriteRawTag(16);
                output.WriteBool(ValidateOnly);
            }
            if (HasDelayHours)
            {
                output.WriteRawTag(24);
                output.WriteInt32(DelayHours);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (HasValidateOnly) size += 1 + 1;
            if (HasDelayHours) size += 1 + CodedOutputStream.ComputeInt32Size(DelayHours);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(DeleteInstallationRequest other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.HasValidateOnly) ValidateOnly = other.ValidateOnly;
            if (other.HasDelayHours) DelayHours = other.DelayHours;
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
          case 16: {
            ValidateOnly = input.ReadBool();
            break;
          }
          case 24: {
            DelayHours = input.ReadInt32();
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
                    case 16:
                        {
                            ValidateOnly = input.ReadBool();
                            break;
                        }
                    case 24:
                        {
                            DelayHours = input.ReadInt32();
                            break;
                        }
                }
            }
        }
#endif

    }


}
