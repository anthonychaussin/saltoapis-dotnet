using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Destination.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/destination/v1/destination.proto</summary>
    public static partial class DestinationReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/destination/v1/destination.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static DestinationReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "Ci1zYWx0by9uZWJ1bGEvZGVzdGluYXRpb24vdjEvZGVzdGluYXRpb24ucHJv",
                  "dG8SG3NhbHRvLm5lYnVsYS5kZXN0aW5hdGlvbi52MRobZ29vZ2xlL3Byb3Rv",
                  "YnVmL2VtcHR5LnByb3RvGiBnb29nbGUvcHJvdG9idWYvZmllbGRfbWFzay5w",
                  "cm90byIxCgtEZXN0aW5hdGlvbhIMCgRuYW1lGAEgASgJEhQKDGRpc3BsYXlf",
                  "bmFtZRgCIAEoCSKZAQoYQ3JlYXRlRGVzdGluYXRpb25SZXF1ZXN0Eg4KBnBh",
                  "cmVudBgBIAEoCRIbCg5kZXN0aW5hdGlvbl9pZBgCIAEoCUgAiAEBEj0KC2Rl",
                  "c3RpbmF0aW9uGAMgASgLMiguc2FsdG8ubmVidWxhLmRlc3RpbmF0aW9uLnYx",
                  "LkRlc3RpbmF0aW9uQhEKD19kZXN0aW5hdGlvbl9pZCIlChVHZXREZXN0aW5h",
                  "dGlvblJlcXVlc3QSDAoEbmFtZRgBIAEoCSI8ChtCYXRjaEdldERlc3RpbmF0",
                  "aW9uc1JlcXVlc3QSDgoGcGFyZW50GAEgASgJEg0KBW5hbWVzGAIgAygJIl4K",
                  "HEJhdGNoR2V0RGVzdGluYXRpb25zUmVzcG9uc2USPgoMZGVzdGluYXRpb25z",
                  "GAEgAygLMiguc2FsdG8ubmVidWxhLmRlc3RpbmF0aW9uLnYxLkRlc3RpbmF0",
                  "aW9uIooBChhVcGRhdGVEZXN0aW5hdGlvblJlcXVlc3QSPQoLZGVzdGluYXRp",
                  "b24YASABKAsyKC5zYWx0by5uZWJ1bGEuZGVzdGluYXRpb24udjEuRGVzdGlu",
                  "YXRpb24SLwoLdXBkYXRlX21hc2sYAiABKAsyGi5nb29nbGUucHJvdG9idWYu",
                  "RmllbGRNYXNrInIKF0xpc3REZXN0aW5hdGlvbnNSZXF1ZXN0Eg4KBnBhcmVu",
                  "dBgBIAEoCRIRCglwYWdlX3NpemUYAiABKAUSEgoKcGFnZV90b2tlbhgDIAEo",
                  "CRIOCgZmaWx0ZXIYBCABKAkSEAoIb3JkZXJfYnkYBSABKAkicwoYTGlzdERl",
                  "c3RpbmF0aW9uc1Jlc3BvbnNlEj4KDGRlc3RpbmF0aW9ucxgBIAMoCzIoLnNh",
                  "bHRvLm5lYnVsYS5kZXN0aW5hdGlvbi52MS5EZXN0aW5hdGlvbhIXCg9uZXh0",
                  "X3BhZ2VfdG9rZW4YAiABKAkiKAoYRGVsZXRlRGVzdGluYXRpb25SZXF1ZXN0",
                  "EgwKBG5hbWUYASABKAky4wUKEkRlc3RpbmF0aW9uU2VydmljZRJ0ChFDcmVh",
                  "dGVEZXN0aW5hdGlvbhI1LnNhbHRvLm5lYnVsYS5kZXN0aW5hdGlvbi52MS5D",
                  "cmVhdGVEZXN0aW5hdGlvblJlcXVlc3QaKC5zYWx0by5uZWJ1bGEuZGVzdGlu",
                  "YXRpb24udjEuRGVzdGluYXRpb24SbgoOR2V0RGVzdGluYXRpb24SMi5zYWx0",
                  "by5uZWJ1bGEuZGVzdGluYXRpb24udjEuR2V0RGVzdGluYXRpb25SZXF1ZXN0",
                  "Giguc2FsdG8ubmVidWxhLmRlc3RpbmF0aW9uLnYxLkRlc3RpbmF0aW9uEosB",
                  "ChRCYXRjaEdldERlc3RpbmF0aW9ucxI4LnNhbHRvLm5lYnVsYS5kZXN0aW5h",
                  "dGlvbi52MS5CYXRjaEdldERlc3RpbmF0aW9uc1JlcXVlc3QaOS5zYWx0by5u",
                  "ZWJ1bGEuZGVzdGluYXRpb24udjEuQmF0Y2hHZXREZXN0aW5hdGlvbnNSZXNw",
                  "b25zZRJ0ChFVcGRhdGVEZXN0aW5hdGlvbhI1LnNhbHRvLm5lYnVsYS5kZXN0",
                  "aW5hdGlvbi52MS5VcGRhdGVEZXN0aW5hdGlvblJlcXVlc3QaKC5zYWx0by5u",
                  "ZWJ1bGEuZGVzdGluYXRpb24udjEuRGVzdGluYXRpb24SfwoQTGlzdERlc3Rp",
                  "bmF0aW9ucxI0LnNhbHRvLm5lYnVsYS5kZXN0aW5hdGlvbi52MS5MaXN0RGVz",
                  "dGluYXRpb25zUmVxdWVzdBo1LnNhbHRvLm5lYnVsYS5kZXN0aW5hdGlvbi52",
                  "MS5MaXN0RGVzdGluYXRpb25zUmVzcG9uc2USYgoRRGVsZXRlRGVzdGluYXRp",
                  "b24SNS5zYWx0by5uZWJ1bGEuZGVzdGluYXRpb24udjEuRGVsZXRlRGVzdGlu",
                  "YXRpb25SZXF1ZXN0GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5QvkBCiNjb20u",
                  "c2FsdG9hcGlzLm5lYnVsYS5kZXN0aW5hdGlvbi52MUIQRGVzdGluYXRpb25Q",
                  "cm90b1ABWkxnaXRodWIuY29tL3NhbHRvYXBpcy1pbnRlcm5hbC9zYWx0b2Fw",
                  "aXMtZ28vbmVidWxhL2Rlc3RpbmF0aW9uL3YxO2Rlc3RpbmF0aW9uqgIfU2Fs",
                  "dG9hcGlzLk5lYnVsYS5EZXN0aW5hdGlvbi5WMcoCH1NhbHRvYXBpc1xOZWJ1",
                  "bGFcRGVzdGluYXRpb25cVjHiAitHUEJNZXRhZGF0YVxTYWx0b2FwaXNcTmVi",
                  "dWxhXERlc3RpbmF0aW9uXFYxYgZwcm90bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Destination), Destination.Parser, ["Name", "DisplayName"], null, null, null, null),
            new(typeof(CreateDestinationRequest), CreateDestinationRequest.Parser, ["Parent", "DestinationId", "Destination"], ["DestinationId"], null, null, null),
            new(typeof(GetDestinationRequest), GetDestinationRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(BatchGetDestinationsRequest), BatchGetDestinationsRequest.Parser, ["Parent", "Names"], null, null, null, null),
            new(typeof(BatchGetDestinationsResponse), BatchGetDestinationsResponse.Parser, ["Destinations"], null, null, null, null),
            new(typeof(UpdateDestinationRequest), UpdateDestinationRequest.Parser, ["Destination", "UpdateMask"], null, null, null, null),
            new(typeof(ListDestinationsRequest), ListDestinationsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListDestinationsResponse), ListDestinationsResponse.Parser, ["Destinations", "NextPageToken"], null, null, null, null),
            new(typeof(DeleteDestinationRequest), DeleteDestinationRequest.Parser, ["Name"], null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// Representation of a destination resource inside the API
    /// </summary>
    public sealed partial class Destination : IMessage<Destination>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Destination> _parser = new(() => new Destination());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Destination> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DestinationReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Destination()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Destination(Destination other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Destination Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the destination. It must have the format
        /// `installations/*/destinations/*`, for example:
        /// `installations/surelock-homes-hq/destinations/floor1`.
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
        /// Display name.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as Destination);
        public bool Equals(Destination other)
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
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
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
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
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
            if (DisplayName.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(Destination other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.DisplayName.Length != 0)
            {
                DisplayName = other.DisplayName;
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
          case 18: {
            DisplayName = input.ReadString();
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`CreateDestination`][salto.nebula.destination.v1.DestinationService.CreateDestination]
    /// </summary>
    public sealed partial class CreateDestinationRequest : IMessage<CreateDestinationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateDestinationRequest> _parser = new(() => new CreateDestinationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateDestinationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DestinationReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateDestinationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateDestinationRequest(CreateDestinationRequest other) : this()
        {
            parent_ = other.parent_;
            destinationId_ = other.destinationId_;
            destination_ = other.destination_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateDestinationRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource under which the destination is created. For
        /// example, `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "destination_id" field.</summary>
        public const int DestinationIdFieldNumber = 2;
        private readonly static string DestinationIdDefaultValue = "";

        private string destinationId_;

        /// <summary>
        /// The destination id to use for this destination. If it's empty the server will
        /// autogenerate a unique identifier.
        /// </summary>
        public string DestinationId
        {
            get { return destinationId_ ?? DestinationIdDefaultValue; }
            set
            {
                destinationId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "destination_id" field is set</summary>
        public bool HasDestinationId
        {
            get { return destinationId_ != null; }
        }

        /// <summary>Clears the value of the "destination_id" field</summary>
        public void ClearDestinationId()
        {
            destinationId_ = null;
        }

        /// <summary>Field number for the "destination" field.</summary>
        public const int DestinationFieldNumber = 3;
        private Destination destination_;

        /// <summary>
        /// The destination resource to be created. Client must not set the `Destination.name`
        /// field.
        /// </summary>
        public Destination Destination
        {
            get { return destination_; }
            set
            {
                destination_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateDestinationRequest);
        public bool Equals(CreateDestinationRequest other)
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
            if (DestinationId != other.DestinationId) return false;
            if (!Equals(Destination, other.Destination)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasDestinationId) hash ^= DestinationId.GetHashCode();
            if (destination_ != null) hash ^= Destination.GetHashCode();
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
      if (HasDestinationId) {
        output.WriteRawTag(18);
        output.WriteString(DestinationId);
      }
      if (destination_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Destination);
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
            if (HasDestinationId)
            {
                output.WriteRawTag(18);
                output.WriteString(DestinationId);
            }
            if (destination_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Destination);
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
            if (HasDestinationId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DestinationId);
            }
            if (destination_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Destination);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateDestinationRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.HasDestinationId)
            {
                DestinationId = other.DestinationId;
            }
            if (other.destination_ != null)
            {
                if (destination_ == null)
                {
                    Destination = new Destination();
                }
                Destination.MergeFrom(other.Destination);
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
          case 18: {
            DestinationId = input.ReadString();
            break;
          }
          case 26: {
            if (destination_ == null) {
              Destination = new Saltoapis.Nebula.Destination.V1.Destination();
            }
            input.ReadMessage(Destination);
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
                    case 18:
                        {
                            DestinationId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (destination_ == null)
                            {
                                Destination = new Destination();
                            }
                            input.ReadMessage(Destination);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetDestination`][salto.nebula.destination.v1.DestinationService.GetDestination]
    /// </summary>
    public sealed partial class GetDestinationRequest : IMessage<GetDestinationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetDestinationRequest> _parser = new(() => new GetDestinationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetDestinationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DestinationReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetDestinationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetDestinationRequest(GetDestinationRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetDestinationRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested destination resource. For example:
        /// `installations/surelock-homes-hq/destinations/floor1`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetDestinationRequest);
        public bool Equals(GetDestinationRequest other)
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

        public void MergeFrom(GetDestinationRequest other)
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
    /// The request message for [`BatchGetDestinationsRequest`][salto.nebula.destination.v1.DestinationService.BatchGetDestinations]
    /// </summary>
    public sealed partial class BatchGetDestinationsRequest : IMessage<BatchGetDestinationsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchGetDestinationsRequest> _parser = new(() => new BatchGetDestinationsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchGetDestinationsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DestinationReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchGetDestinationsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchGetDestinationsRequest(BatchGetDestinationsRequest other) : this()
        {
            parent_ = other.parent_;
            names_ = other.names_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchGetDestinationsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent of the destinations to be retreived.
        /// For example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "names" field.</summary>
        public const int NamesFieldNumber = 2;
        private static readonly FieldCodec<string> _repeated_names_codec
            = FieldCodec.ForString(18);
        private readonly RepeatedField<string> names_ = [];

        /// <summary>
        /// The names of the destinations requested.
        /// </summary>
        public RepeatedField<string> Names
        {
            get { return names_; }
        }

        public override bool Equals(object other) => Equals(other as BatchGetDestinationsRequest);
        public bool Equals(BatchGetDestinationsRequest other)
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
            if (!names_.Equals(other.names_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            hash ^= names_.GetHashCode();
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
      names_.WriteTo(output, _repeated_names_codec);
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
            names_.WriteTo(ref output, _repeated_names_codec);
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
            size += names_.CalculateSize(_repeated_names_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BatchGetDestinationsRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            names_.Add(other.names_);
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
          case 18: {
            names_.AddEntriesFrom(input, _repeated_names_codec);
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
                    case 18:
                        {
                            names_.AddEntriesFrom(ref input, _repeated_names_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`BatchGetDestinations`][salto.nebula.destination.v1.DestinationService.BatchGetDestinations]
    /// </summary>
    public sealed partial class BatchGetDestinationsResponse : IMessage<BatchGetDestinationsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchGetDestinationsResponse> _parser = new(() => new BatchGetDestinationsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchGetDestinationsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DestinationReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchGetDestinationsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchGetDestinationsResponse(BatchGetDestinationsResponse other) : this()
        {
            destinations_ = other.destinations_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchGetDestinationsResponse Clone() => new(this);
        /// <summary>Field number for the "destinations" field.</summary>
        public const int DestinationsFieldNumber = 1;
        private static readonly FieldCodec<Destination> _repeated_destinations_codec
            = FieldCodec.ForMessage(10, Destination.Parser);
        private readonly RepeatedField<Destination> destinations_ = [];

        /// <summary>
        /// Destinations requested.
        /// </summary>
        public RepeatedField<Destination> Destinations
        {
            get { return destinations_; }
        }

        public override bool Equals(object other) => Equals(other as BatchGetDestinationsResponse);
        public bool Equals(BatchGetDestinationsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!destinations_.Equals(other.destinations_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= destinations_.GetHashCode();
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
      destinations_.WriteTo(output, _repeated_destinations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            destinations_.WriteTo(ref output, _repeated_destinations_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += destinations_.CalculateSize(_repeated_destinations_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BatchGetDestinationsResponse other)
        {
            if (other == null)
            {
                return;
            }
            destinations_.Add(other.destinations_);
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
            destinations_.AddEntriesFrom(input, _repeated_destinations_codec);
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
                            destinations_.AddEntriesFrom(ref input, _repeated_destinations_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`UpdateDestination`][salto.nebula.destination.v1.DestinationService.UpdateDestination]
    /// </summary>
    public sealed partial class UpdateDestinationRequest : IMessage<UpdateDestinationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateDestinationRequest> _parser = new(() => new UpdateDestinationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateDestinationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DestinationReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateDestinationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateDestinationRequest(UpdateDestinationRequest other) : this()
        {
            destination_ = other.destination_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateDestinationRequest Clone() => new(this);
        /// <summary>Field number for the "destination" field.</summary>
        public const int DestinationFieldNumber = 1;
        private Destination destination_;

        /// <summary>
        /// The destination resource which replaces the resource on the server.
        /// </summary>
        public Destination Destination
        {
            get { return destination_; }
            set
            {
                destination_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateDestinationRequest);
        public bool Equals(UpdateDestinationRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Destination, other.Destination)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (destination_ != null) hash ^= Destination.GetHashCode();
            if (updateMask_ != null) hash ^= UpdateMask.GetHashCode();
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
      if (destination_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Destination);
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
            if (destination_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Destination);
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
            if (destination_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Destination);
            }
            if (updateMask_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdateDestinationRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.destination_ != null)
            {
                if (destination_ == null)
                {
                    Destination = new Destination();
                }
                Destination.MergeFrom(other.Destination);
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
            if (destination_ == null) {
              Destination = new Saltoapis.Nebula.Destination.V1.Destination();
            }
            input.ReadMessage(Destination);
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
                            if (destination_ == null)
                            {
                                Destination = new Destination();
                            }
                            input.ReadMessage(Destination);
                            break;
                        }
                    case 18:
                        {
                            if (updateMask_ == null)
                            {
                                UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                            }
                            input.ReadMessage(UpdateMask);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`ListDestinations`][salto.nebula.destination.v1.DestinationService.ListDestinations]
    /// </summary>
    public sealed partial class ListDestinationsRequest : IMessage<ListDestinationsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListDestinationsRequest> _parser = new(() => new ListDestinationsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListDestinationsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DestinationReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListDestinationsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListDestinationsRequest(ListDestinationsRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListDestinationsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name, for example: `installations/surelock-homes-hq`.
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
        /// The `next_page_token` value returned from a previous `List` request, if
        /// any.
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
        /// A filter that chooses which destinations to return.
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

        public override bool Equals(object other) => Equals(other as ListDestinationsRequest);
        public bool Equals(ListDestinationsRequest other)
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
            if (Parent.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            }
            if (PageSize != 0)
            {
                size += 1 + CodedOutputStream.ComputeInt32Size(PageSize);
            }
            if (PageToken.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(PageToken);
            }
            if (Filter.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Filter);
            }
            if (OrderBy.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(OrderBy);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ListDestinationsRequest other)
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
    /// The response message for [`ListDestinations`][salto.nebula.destination.v1.DestinationService.ListDestinations]
    /// </summary>
    public sealed partial class ListDestinationsResponse : IMessage<ListDestinationsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListDestinationsResponse> _parser = new(() => new ListDestinationsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListDestinationsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DestinationReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListDestinationsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListDestinationsResponse(ListDestinationsResponse other) : this()
        {
            destinations_ = other.destinations_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListDestinationsResponse Clone() => new(this);
        /// <summary>Field number for the "destinations" field.</summary>
        public const int DestinationsFieldNumber = 1;
        private static readonly FieldCodec<Destination> _repeated_destinations_codec
            = FieldCodec.ForMessage(10, Destination.Parser);
        private readonly RepeatedField<Destination> destinations_ = [];

        /// <summary>
        /// The field name should match the noun `destinations` in the method name. There
        /// will be a maximum number of items returned based on the `page_size` field
        /// in the request.
        /// </summary>
        public RepeatedField<Destination> Destinations
        {
            get { return destinations_; }
        }

        /// <summary>Field number for the "next_page_token" field.</summary>
        public const int NextPageTokenFieldNumber = 2;
        private string nextPageToken_ = "";

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more
        /// results in the list.
        /// </summary>
        public string NextPageToken
        {
            get { return nextPageToken_; }
            set
            {
                nextPageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListDestinationsResponse);
        public bool Equals(ListDestinationsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!destinations_.Equals(other.destinations_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= destinations_.GetHashCode();
            if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
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
      destinations_.WriteTo(output, _repeated_destinations_codec);
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
            destinations_.WriteTo(ref output, _repeated_destinations_codec);
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
            size += destinations_.CalculateSize(_repeated_destinations_codec);
            if (NextPageToken.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ListDestinationsResponse other)
        {
            if (other == null)
            {
                return;
            }
            destinations_.Add(other.destinations_);
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
            destinations_.AddEntriesFrom(input, _repeated_destinations_codec);
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
                            destinations_.AddEntriesFrom(ref input, _repeated_destinations_codec);
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
    /// The request message for [`DeleteDestination`][salto.nebula.destination.v1.DestinationService.DeleteDestination]
    /// </summary>
    public sealed partial class DeleteDestinationRequest : IMessage<DeleteDestinationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteDestinationRequest> _parser = new(() => new DeleteDestinationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteDestinationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return DestinationReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteDestinationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteDestinationRequest(DeleteDestinationRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteDestinationRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the destination to be deleted, for example:
        /// `installations/surelock-homes-hq/destinations/floor1`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteDestinationRequest);
        public bool Equals(DeleteDestinationRequest other)
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

        public void MergeFrom(DeleteDestinationRequest other)
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
