namespace Saltoapis.Nebula.File.V1
{
    /// <summary>
    /// A file is a representation of a digital file. It does not store
    /// the actual file data but rather serves as a reference for files
    /// stored elsewhere.
    /// </summary>
    public sealed partial class File : IMessage<File>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<File> _parser = new(() => new File());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<File> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return FileReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public File()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public File(File other) : this()
        {
            name_ = other.name_;
            uploadUri_ = other.uploadUri_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public File Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the file. It must have the format
        /// `installations/*/files/*`. For example:
        /// `installations/surelock-homes-hq/files/01DSYSJ1PR36VVC3MRFRV4DC7G`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "upload_uri" field.</summary>
        public const int UploadUriFieldNumber = 2;
        private string uploadUri_ = "";

        /// <summary>
        /// The private URL to upload the file to.
        /// </summary>
        public string UploadUri
        {
            get { return uploadUri_; }
            set
            {
                uploadUri_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as File);
        public bool Equals(File other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (UploadUri != other.UploadUri)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (UploadUri.Length != 0) hash ^= UploadUri.GetHashCode();
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
      if (UploadUri.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(UploadUri);
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
            if (UploadUri.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(UploadUri);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (UploadUri.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(UploadUri);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(File other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.UploadUri.Length != 0) UploadUri = other.UploadUri;
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
            UploadUri = input.ReadString();
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
                            UploadUri = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }
}
