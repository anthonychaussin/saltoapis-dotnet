using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Salto.Nebula.EmergencyKey.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/emergencykey/v1/emergency_key.proto</summary>
    public static partial class EmergencyKeyReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/emergencykey/v1/emergency_key.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static EmergencyKeyReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CjBzYWx0by9uZWJ1bGEvZW1lcmdlbmN5a2V5L3YxL2VtZXJnZW5jeV9rZXku",
                  "cHJvdG8SHHNhbHRvLm5lYnVsYS5lbWVyZ2VuY3lrZXkudjEaG2dvb2dsZS9w",
                  "cm90b2J1Zi9lbXB0eS5wcm90bxogZ29vZ2xlL3Byb3RvYnVmL2ZpZWxkX21h",
                  "c2sucHJvdG8iPwoMRW1lcmdlbmN5S2V5EgwKBG5hbWUYASABKAkSFAoMZGlz",
                  "cGxheV9uYW1lGAIgASgJEgsKA3VpZBgDIAEoCSJuChlDcmVhdGVFbWVyZ2Vu",
                  "Y3lLZXlSZXF1ZXN0Eg4KBnBhcmVudBgBIAEoCRJBCg1lbWVyZ2VuY3lfa2V5",
                  "GAMgASgLMiouc2FsdG8ubmVidWxhLmVtZXJnZW5jeWtleS52MS5FbWVyZ2Vu",
                  "Y3lLZXkiJgoWR2V0RW1lcmdlbmN5S2V5UmVxdWVzdBIMCgRuYW1lGAEgASgJ",
                  "InMKGExpc3RFbWVyZ2VuY3lLZXlzUmVxdWVzdBIOCgZwYXJlbnQYASABKAkS",
                  "EQoJcGFnZV9zaXplGAIgASgFEhIKCnBhZ2VfdG9rZW4YAyABKAkSDgoGZmls",
                  "dGVyGAQgASgJEhAKCG9yZGVyX2J5GAUgASgJIngKGUxpc3RFbWVyZ2VuY3lL",
                  "ZXlzUmVzcG9uc2USQgoOZW1lcmdlbmN5X2tleXMYASADKAsyKi5zYWx0by5u",
                  "ZWJ1bGEuZW1lcmdlbmN5a2V5LnYxLkVtZXJnZW5jeUtleRIXCg9uZXh0X3Bh",
                  "Z2VfdG9rZW4YAiABKAkijwEKGVVwZGF0ZUVtZXJnZW5jeUtleVJlcXVlc3QS",
                  "QQoNZW1lcmdlbmN5X2tleRgBIAEoCzIqLnNhbHRvLm5lYnVsYS5lbWVyZ2Vu",
                  "Y3lrZXkudjEuRW1lcmdlbmN5S2V5Ei8KC3VwZGF0ZV9tYXNrGAIgASgLMhou",
                  "Z29vZ2xlLnByb3RvYnVmLkZpZWxkTWFzayIpChlEZWxldGVFbWVyZ2VuY3lL",
                  "ZXlSZXF1ZXN0EgwKBG5hbWUYASABKAky7gQKE0VtZXJnZW5jeUtleVNlcnZp",
                  "Y2USeQoSQ3JlYXRlRW1lcmdlbmN5S2V5Ejcuc2FsdG8ubmVidWxhLmVtZXJn",
                  "ZW5jeWtleS52MS5DcmVhdGVFbWVyZ2VuY3lLZXlSZXF1ZXN0Giouc2FsdG8u",
                  "bmVidWxhLmVtZXJnZW5jeWtleS52MS5FbWVyZ2VuY3lLZXkScwoPR2V0RW1l",
                  "cmdlbmN5S2V5EjQuc2FsdG8ubmVidWxhLmVtZXJnZW5jeWtleS52MS5HZXRF",
                  "bWVyZ2VuY3lLZXlSZXF1ZXN0Giouc2FsdG8ubmVidWxhLmVtZXJnZW5jeWtl",
                  "eS52MS5FbWVyZ2VuY3lLZXkShAEKEUxpc3RFbWVyZ2VuY3lLZXlzEjYuc2Fs",
                  "dG8ubmVidWxhLmVtZXJnZW5jeWtleS52MS5MaXN0RW1lcmdlbmN5S2V5c1Jl",
                  "cXVlc3QaNy5zYWx0by5uZWJ1bGEuZW1lcmdlbmN5a2V5LnYxLkxpc3RFbWVy",
                  "Z2VuY3lLZXlzUmVzcG9uc2USeQoSVXBkYXRlRW1lcmdlbmN5S2V5Ejcuc2Fs",
                  "dG8ubmVidWxhLmVtZXJnZW5jeWtleS52MS5VcGRhdGVFbWVyZ2VuY3lLZXlS",
                  "ZXF1ZXN0Giouc2FsdG8ubmVidWxhLmVtZXJnZW5jeWtleS52MS5FbWVyZ2Vu",
                  "Y3lLZXkSZQoSRGVsZXRlRW1lcmdlbmN5S2V5Ejcuc2FsdG8ubmVidWxhLmVt",
                  "ZXJnZW5jeWtleS52MS5EZWxldGVFbWVyZ2VuY3lLZXlSZXF1ZXN0GhYuZ29v",
                  "Z2xlLnByb3RvYnVmLkVtcHR5QvgBCiBjb20uc2FsdG8ubmVidWxhLmVtZXJn",
                  "ZW5jeWtleS52MUIRRW1lcmdlbmN5S2V5UHJvdG9QAVpOZ2l0aHViLmNvbS9z",
                  "YWx0b2FwaXMtaW50ZXJuYWwvc2FsdG9hcGlzLWdvL25lYnVsYS9lbWVyZ2Vu",
                  "Y3lrZXkvdjE7ZW1lcmdlbmN5a2V5qgIcU2FsdG8uTmVidWxhLkVtZXJnZW5j",
                  "eUtleS5WMcoCIFNhbHRvYXBpc1xOZWJ1bGFcRW1lcmdlbmN5S2V5XFYx4gIs",
                  "R1BCTWV0YWRhdGFcU2FsdG9hcGlzXE5lYnVsYVxFbWVyZ2VuY3lLZXlcVjFi",
                  "BnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(EmergencyKey), EmergencyKey.Parser, ["Name", "DisplayName", "Uid"], null, null, null, null),
            new(typeof(CreateEmergencyKeyRequest), CreateEmergencyKeyRequest.Parser, ["Parent", "EmergencyKey"], null, null, null, null),
            new(typeof(GetEmergencyKeyRequest), GetEmergencyKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListEmergencyKeysRequest), ListEmergencyKeysRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListEmergencyKeysResponse), ListEmergencyKeysResponse.Parser, ["EmergencyKeys", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateEmergencyKeyRequest), UpdateEmergencyKeyRequest.Parser, ["EmergencyKey", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteEmergencyKeyRequest), DeleteEmergencyKeyRequest.Parser, ["Name"], null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// The emergency key object
    /// </summary>
    public sealed partial class EmergencyKey : IMessage<EmergencyKey>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<EmergencyKey> _parser = new(() => new EmergencyKey());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<EmergencyKey> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EmergencyKeyReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EmergencyKey()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public EmergencyKey(EmergencyKey other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            uid_ = other.uid_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public EmergencyKey Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the emergency key. It must have the format
        /// `installations/*/emergency-keys/*`. For example:
        /// `installations/surelock-homes-hq/emergency-keys/firefighters`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 2;
        private string displayName_ = "";

        /// <summary>
        /// Display name of the emergency key.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "uid" field.</summary>
        public const int UidFieldNumber = 3;
        private string uid_ = "";

        /// <summary>
        /// Unique identifier of the physical card. Length dependent of technology.
        /// Max length for ISO14443-3 is 10 bytes.
        /// </summary>
        public string Uid
        {
            get { return uid_; }
            set
            {
                uid_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as EmergencyKey);
        public bool Equals(EmergencyKey other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            if (DisplayName != other.DisplayName) return false;
            if (Uid != other.Uid) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            if (Uid.Length != 0) hash ^= Uid.GetHashCode();
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
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (Uid.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Uid);
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
            if (DisplayName.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(DisplayName);
            }
            if (Uid.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(Uid);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (DisplayName.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            if (Uid.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Uid);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(EmergencyKey other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.DisplayName.Length != 0) DisplayName = other.DisplayName;
            if (other.Uid.Length != 0) Uid = other.Uid;
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
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            Uid = input.ReadString();
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
                            DisplayName = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            Uid = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`CreateEmergencyKey`][salto.nebula.emergencykey.v1.EmergencyKeyService.CreateEmergencyKey].
    /// </summary>
    public sealed partial class CreateEmergencyKeyRequest : IMessage<CreateEmergencyKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateEmergencyKeyRequest> _parser = new(() => new CreateEmergencyKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateEmergencyKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EmergencyKeyReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateEmergencyKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateEmergencyKeyRequest(CreateEmergencyKeyRequest other) : this()
        {
            parent_ = other.parent_;
            emergencyKey_ = other.emergencyKey_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateEmergencyKeyRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the access right is to be
        /// created. For example: ìnstallations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "emergency_key" field.</summary>
        public const int EmergencyKeyFieldNumber = 3;
        private EmergencyKey emergencyKey_;

        /// <summary>
        /// The emergency key resource to be created. Client must not set the
        /// `EmergencyKey.name` field.
        /// </summary>
        public EmergencyKey EmergencyKey
        {
            get { return emergencyKey_; }
            set
            {
                emergencyKey_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateEmergencyKeyRequest);
        public bool Equals(CreateEmergencyKeyRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Parent != other.Parent) return false;
            if (!Equals(EmergencyKey, other.EmergencyKey)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (emergencyKey_ != null) hash ^= EmergencyKey.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (emergencyKey_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(EmergencyKey);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Parent.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Parent);
            }
            if (emergencyKey_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(EmergencyKey);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            }
            if (emergencyKey_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(EmergencyKey);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateEmergencyKeyRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.emergencyKey_ != null)
            {
                if (emergencyKey_ == null)
                {
                    EmergencyKey = new EmergencyKey();
                }
                EmergencyKey.MergeFrom(other.EmergencyKey);
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
            Parent = input.ReadString();
            break;
          }
          case 26: {
            if (emergencyKey_ == null) {
              EmergencyKey = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
            }
            input.ReadMessage(EmergencyKey);
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
                            Parent = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (emergencyKey_ == null)
                            {
                                EmergencyKey = new EmergencyKey();
                            }
                            input.ReadMessage(EmergencyKey);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetEmergencyKey`][salto.nebula.emergencykey.v1.EmergencyKeyService.GetEmergencyKey].
    /// </summary>
    public sealed partial class GetEmergencyKeyRequest : IMessage<GetEmergencyKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetEmergencyKeyRequest> _parser = new(() => new GetEmergencyKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetEmergencyKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EmergencyKeyReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetEmergencyKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetEmergencyKeyRequest(GetEmergencyKeyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetEmergencyKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested emergency key resource. For example:
        /// `installations/surelock-homes-hq/emergency-keys/firefighters`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetEmergencyKeyRequest);
        public bool Equals(GetEmergencyKeyRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
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
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GetEmergencyKeyRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
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
            Name = input.ReadString();
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`ListEmergencyKeys`][salto.nebula.emergencykey.v1.EmergencyKeyService.ListEmergencyKeys].
    /// </summary>
    public sealed partial class ListEmergencyKeysRequest : IMessage<ListEmergencyKeysRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListEmergencyKeysRequest> _parser = new(() => new ListEmergencyKeysRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListEmergencyKeysRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EmergencyKeyReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListEmergencyKeysRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListEmergencyKeysRequest(ListEmergencyKeysRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListEmergencyKeysRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name. For example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "page_size" field.</summary>
        public const int PageSizeFieldNumber = 2;
        private int pageSize_;

        /// <summary>
        /// The maximum number of items to return.
        /// </summary>
        public int PageSize
        {
            get { return pageSize_; }
            set
            {
                pageSize_ = value;
            }
        }

        /// <summary>Field number for the "page_token" field.</summary>
        public const int PageTokenFieldNumber = 3;
        private string pageToken_ = "";

        /// <summary>
        /// The `next_page_token` value returned from a previous `List`` request, if any.
        /// </summary>
        public string PageToken
        {
            get { return pageToken_; }
            set
            {
                pageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "filter" field.</summary>
        public const int FilterFieldNumber = 4;
        private string filter_ = "";

        /// <summary>
        /// A filter that chooses which emergency keys to return.
        /// </summary>
        public string Filter
        {
            get { return filter_; }
            set
            {
                filter_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "order_by" field.</summary>
        public const int OrderByFieldNumber = 5;
        private string orderBy_ = "";

        /// <summary>
        /// How the results should be sorted.
        /// </summary>
        public string OrderBy
        {
            get { return orderBy_; }
            set
            {
                orderBy_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListEmergencyKeysRequest);
        public bool Equals(ListEmergencyKeysRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Parent != other.Parent) return false;
            if (PageSize != other.PageSize) return false;
            if (PageToken != other.PageToken) return false;
            if (Filter != other.Filter) return false;
            if (OrderBy != other.OrderBy) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (PageSize != 0) hash ^= PageSize.GetHashCode();
            if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
            if (Filter.Length != 0) hash ^= Filter.GetHashCode();
            if (OrderBy.Length != 0) hash ^= OrderBy.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (PageSize != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PageToken);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Filter);
      }
      if (OrderBy.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OrderBy);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Parent.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Parent);
            }
            if (PageSize != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(PageSize);
            }
            if (PageToken.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(PageToken);
            }
            if (Filter.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(Filter);
            }
            if (OrderBy.Length != 0)
            {
                output.WriteRawTag(42);
                output.WriteString(OrderBy);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (PageSize != 0) size += 1 + CodedOutputStream.ComputeInt32Size(PageSize);
            if (PageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(PageToken);
            if (Filter.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Filter);
            if (OrderBy.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(OrderBy);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListEmergencyKeysRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.PageSize != 0)
            {
                PageSize = other.PageSize;
            }
            if (other.PageToken.Length != 0)
            {
                PageToken = other.PageToken;
            }
            if (other.Filter.Length != 0)
            {
                Filter = other.Filter;
            }
            if (other.OrderBy.Length != 0)
            {
                OrderBy = other.OrderBy;
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
            Parent = input.ReadString();
            break;
          }
          case 16: {
            PageSize = input.ReadInt32();
            break;
          }
          case 26: {
            PageToken = input.ReadString();
            break;
          }
          case 34: {
            Filter = input.ReadString();
            break;
          }
          case 42: {
            OrderBy = input.ReadString();
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
                            Parent = input.ReadString();
                            break;
                        }
                    case 16:
                        {
                            PageSize = input.ReadInt32();
                            break;
                        }
                    case 26:
                        {
                            PageToken = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            Filter = input.ReadString();
                            break;
                        }
                    case 42:
                        {
                            OrderBy = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`ListEmergencyKeys`][salto.nebula.emergencykey.v1.EmergencyKeyService.ListEmergencyKeys].
    /// </summary>
    public sealed partial class ListEmergencyKeysResponse : IMessage<ListEmergencyKeysResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListEmergencyKeysResponse> _parser = new(() => new ListEmergencyKeysResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListEmergencyKeysResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EmergencyKeyReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListEmergencyKeysResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListEmergencyKeysResponse(ListEmergencyKeysResponse other) : this()
        {
            emergencyKeys_ = other.emergencyKeys_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListEmergencyKeysResponse Clone() => new(this);
        /// <summary>Field number for the "emergency_keys" field.</summary>
        public const int EmergencyKeysFieldNumber = 1;
        private static readonly FieldCodec<EmergencyKey> _repeated_emergencyKeys_codec
            = FieldCodec.ForMessage(10, EmergencyKey.Parser);
        private readonly RepeatedField<EmergencyKey> emergencyKeys_ = [];

        /// <summary>
        /// The field name should match the noun `emergency_keys` in the method name.
        /// There will be a maximum number of items returned based on the `page_size`
        /// field in the request.
        /// </summary>
        public RepeatedField<EmergencyKey> EmergencyKeys
        {
            get { return emergencyKeys_; }
        }

        /// <summary>Field number for the "next_page_token" field.</summary>
        public const int NextPageTokenFieldNumber = 2;
        private string nextPageToken_ = "";

        /// <summary>
        /// The token to retrieve the next page of emergency keys.
        /// </summary>
        public string NextPageToken
        {
            get { return nextPageToken_; }
            set
            {
                nextPageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListEmergencyKeysResponse);
        public bool Equals(ListEmergencyKeysResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!emergencyKeys_.Equals(other.emergencyKeys_) || NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= emergencyKeys_.GetHashCode();
            if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      emergencyKeys_.WriteTo(output, _repeated_emergencyKeys_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            emergencyKeys_.WriteTo(ref output, _repeated_emergencyKeys_codec);
            if (NextPageToken.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(NextPageToken);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += emergencyKeys_.CalculateSize(_repeated_emergencyKeys_codec);
            if (NextPageToken.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ListEmergencyKeysResponse other)
        {
            if (other == null)
            {
                return;
            }
            emergencyKeys_.Add(other.emergencyKeys_);
            if (other.NextPageToken.Length != 0)
            {
                NextPageToken = other.NextPageToken;
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
            emergencyKeys_.AddEntriesFrom(input, _repeated_emergencyKeys_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
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
                            emergencyKeys_.AddEntriesFrom(ref input, _repeated_emergencyKeys_codec);
                            break;
                        }
                    case 18:
                        {
                            NextPageToken = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`UpdateEmergencyKey`][salto.nebula.emergencykey.v1.EmergencyKeyService.UpdateEmergencyKey].
    /// </summary>
    public sealed partial class UpdateEmergencyKeyRequest : IMessage<UpdateEmergencyKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateEmergencyKeyRequest> _parser = new(() => new UpdateEmergencyKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateEmergencyKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EmergencyKeyReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateEmergencyKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateEmergencyKeyRequest(UpdateEmergencyKeyRequest other) : this()
        {
            emergencyKey_ = other.emergencyKey_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateEmergencyKeyRequest Clone() => new(this);
        /// <summary>Field number for the "emergency_key" field.</summary>
        public const int EmergencyKeyFieldNumber = 1;
        private EmergencyKey emergencyKey_;

        /// <summary>
        /// The emergency key resource which replaces the resource on the server.
        /// </summary>
        public EmergencyKey EmergencyKey
        {
            get { return emergencyKey_; }
            set
            {
                emergencyKey_ = value;
            }
        }

        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;

        /// <summary>
        /// The update mask applied to the resource.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get { return updateMask_; }
            set
            {
                updateMask_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateEmergencyKeyRequest);
        public bool Equals(UpdateEmergencyKeyRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(EmergencyKey, other.EmergencyKey) || !Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (emergencyKey_ != null) hash ^= EmergencyKey.GetHashCode();
            if (updateMask_ != null) hash ^= UpdateMask.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (emergencyKey_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(EmergencyKey);
      }
      if (updateMask_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UpdateMask);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (emergencyKey_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(EmergencyKey);
            }
            if (updateMask_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(UpdateMask);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (emergencyKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(EmergencyKey);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateEmergencyKeyRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.emergencyKey_ != null)
            {
                if (emergencyKey_ == null)
                {
                    EmergencyKey = new EmergencyKey();
                }
                EmergencyKey.MergeFrom(other.EmergencyKey);
            }
            if (other.updateMask_ != null)
            {
                if (updateMask_ == null)
                {
                    UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                }
                UpdateMask.MergeFrom(other.UpdateMask);
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
            if (emergencyKey_ == null) {
              EmergencyKey = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
            }
            input.ReadMessage(EmergencyKey);
            break;
          }
          case 18: {
            if (updateMask_ == null) {
              UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
            }
            input.ReadMessage(UpdateMask);
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
                            input.ReadMessage(EmergencyKey ?? new EmergencyKey());
                            break;
                        }
                    case 18:
                        {
                            input.ReadMessage(UpdateMask ?? new Google.Protobuf.WellKnownTypes.FieldMask());
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`DeleteEmergencyKey`][salto.nebula.emergencykey.v1.EmergencyKeyService.DeleteEmergencyKey].
    /// </summary>
    public sealed partial class DeleteEmergencyKeyRequest : IMessage<DeleteEmergencyKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteEmergencyKeyRequest> _parser = new(() => new DeleteEmergencyKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteEmergencyKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return EmergencyKeyReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteEmergencyKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteEmergencyKeyRequest(DeleteEmergencyKeyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteEmergencyKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the emergency key to delete. For example:
        /// `installations/surelock-homes-hq/emergency-keys/firefighters`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteEmergencyKeyRequest);
        public bool Equals(DeleteEmergencyKeyRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
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
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(DeleteEmergencyKeyRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
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
            Name = input.ReadString();
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
                }
            }
        }
#endif

    }

    #endregion

}
