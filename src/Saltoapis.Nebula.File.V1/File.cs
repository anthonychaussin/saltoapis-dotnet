using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.File.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/file/v1/file.proto</summary>
    public static partial class FileReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/file/v1/file.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static FileReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "Ch9zYWx0by9uZWJ1bGEvZmlsZS92MS9maWxlLnByb3RvEhRzYWx0by5uZWJ1",
                  "bGEuZmlsZS52MSIoCgRGaWxlEgwKBG5hbWUYASABKAkSEgoKdXBsb2FkX3Vy",
                  "aRgCIAEoCSIjChFDcmVhdGVGaWxlUmVxdWVzdBIOCgZwYXJlbnQYASABKAky",
                  "YAoLRmlsZVNlcnZpY2USUQoKQ3JlYXRlRmlsZRInLnNhbHRvLm5lYnVsYS5m",
                  "aWxlLnYxLkNyZWF0ZUZpbGVSZXF1ZXN0Ghouc2FsdG8ubmVidWxhLmZpbGUu",
                  "djEuRmlsZULIAQocY29tLnNhbHRvYXBpcy5uZWJ1bGEuZmlsZS52MUIJRmls",
                  "ZVByb3RvUAFaPmdpdGh1Yi5jb20vc2FsdG9hcGlzLWludGVybmFsL3NhbHRv",
                  "YXBpcy1nby9uZWJ1bGEvZmlsZS92MTtmaWxlqgIYU2FsdG9hcGlzLk5lYnVs",
                  "YS5GaWxlLlYxygIYU2FsdG9hcGlzXE5lYnVsYVxGaWxlXFYx4gIkR1BCTWV0",
                  "YWRhdGFcU2FsdG9hcGlzXE5lYnVsYVxGaWxlXFYxYgZwcm90bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(File), File.Parser, ["Name", "UploadUri"], null, null, null, null),
            new(typeof(CreateFileRequest), CreateFileRequest.Parser, ["Parent"], null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
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
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            if (UploadUri != other.UploadUri) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (UploadUri.Length != 0) hash ^= UploadUri.GetHashCode();
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
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (UploadUri.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(UploadUri);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(File other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.UploadUri.Length != 0)
            {
                UploadUri = other.UploadUri;
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

    /// <summary>
    /// The request message for [CreateFile][salto.nebula.file.v1.FileService.CreateFile]
    /// </summary>
    public sealed partial class CreateFileRequest : IMessage<CreateFileRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateFileRequest> _parser = new(() => new CreateFileRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateFileRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return FileReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateFileRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateFileRequest(CreateFileRequest other) : this()
        {
            parent_ = other.parent_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateFileRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where to create the file. For
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

        public override bool Equals(object other) => Equals(other as CreateFileRequest);
        public bool Equals(CreateFileRequest other)
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
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
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
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateFileRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
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
                }
            }
        }
#endif

    }

    #endregion

}
