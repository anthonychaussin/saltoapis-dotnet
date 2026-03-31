namespace Saltoapis.Longrunning.V1
{
    /// <summary>
    /// The long-running operation object
    /// </summary>
    public sealed partial class Operation : IMessage<Operation>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Operation> _parser = new(() => new Operation());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Operation> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return OperationReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Operation()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Operation(Operation other) : this()
        {
            name_ = other.name_;
            metadata_ = other.metadata_?.Clone();
            done_ = other.done_;
            switch (other.ResultCase)
            {
                case ResultOneofCase.Error:
                    Error = other.Error.Clone();
                    break;
                case ResultOneofCase.Response:
                    Response = other.Response.Clone();
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Operation Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The server-assigned name, which is only unique within the same service
        /// that originally returns it. If you use the default HTTP mapping, the
        /// `name` should have the format of `operations/some/unique/name`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "metadata" field.</summary>
        public const int MetadataFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.Any metadata_;

        /// <summary>
        /// Service-specific metadata associated with the operation.  It typically
        /// contains progress information and common metadata such as create time.
        /// Some services might not provide such metadata. Any method that returns a
        /// long-running operation should document the metadata type, if any.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Any Metadata
        {
            get { return metadata_; }
            set
            {
                metadata_ = value;
            }
        }

        /// <summary>Field number for the "done" field.</summary>
        public const int DoneFieldNumber = 3;
        private bool done_;

        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If
        /// true, the operation is completed, and either `error` or `response` is
        /// available.
        /// </summary>
        public bool Done
        {
            get { return done_; }
            set
            {
                done_ = value;
            }
        }

        /// <summary>Field number for the "error" field.</summary>
        public const int ErrorFieldNumber = 4;

        /// <summary>
        /// The error result of the operation in case of failure or cancellation.
        /// </summary>
        public Google.Rpc.Status Error
        {
            get { return resultCase_ == ResultOneofCase.Error ? (Google.Rpc.Status)result_ : null; }
            set
            {
                result_ = value;
                resultCase_ = value == null ? ResultOneofCase.None : ResultOneofCase.Error;
            }
        }

        /// <summary>Field number for the "response" field.</summary>
        public const int ResponseFieldNumber = 5;

        /// <summary>
        /// The normal response of the operation in case of success. If the
        /// original method returns no data on success, such as `Delete`, the
        /// response is `google.protobuf.Empty`. If the original method is
        /// standard `Get`/`Create`/`Update`, the response should be the
        /// resource. For other methods, the response should have the type
        /// `XxxResponse`, where `Xxx` is the original method name. For example:
        /// if the original method name is `AssignMobileKey()`, the inferred
        /// response type is `AssignMobileKeyResponse`.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Any Response
        {
            get { return resultCase_ == ResultOneofCase.Response ? (Google.Protobuf.WellKnownTypes.Any)result_ : null; }
            set
            {
                result_ = value;
                resultCase_ = value == null ? ResultOneofCase.None : ResultOneofCase.Response;
            }
        }

        private object result_;

        /// <summary>Enum of possible cases for the "result" oneof.</summary>
        public enum ResultOneofCase
        {
            None = 0,
            Error = 4,
            Response = 5,
        }

        private ResultOneofCase resultCase_ = ResultOneofCase.None;

        public ResultOneofCase ResultCase
        {
            get { return resultCase_; }
        }

        public void ClearResult()
        {
            resultCase_ = ResultOneofCase.None;
            result_ = null;
        }

        public override bool Equals(object other) => Equals(other as Operation);
        public bool Equals(Operation other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (!Equals(Metadata, other.Metadata))) return false;
            if ((Done != other.Done) || (!Equals(Error, other.Error))) return false;
            if ((!Equals(Response, other.Response)) || (ResultCase != other.ResultCase)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (metadata_ != null) hash ^= Metadata.GetHashCode();
            if (Done != false) hash ^= Done.GetHashCode();
            if (resultCase_ == ResultOneofCase.Error) hash ^= Error.GetHashCode();
            if (resultCase_ == ResultOneofCase.Response) hash ^= Response.GetHashCode();
            hash ^= (int)resultCase_;
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
      if (metadata_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Metadata);
      }
      if (Done != false) {
        output.WriteRawTag(24);
        output.WriteBool(Done);
      }
      if (resultCase_ == ResultOneofCase.Error) {
        output.WriteRawTag(34);
        output.WriteMessage(Error);
      }
      if (resultCase_ == ResultOneofCase.Response) {
        output.WriteRawTag(42);
        output.WriteMessage(Response);
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
            if (metadata_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Metadata);
            }
            if (Done != false)
            {
                output.WriteRawTag(24);
                output.WriteBool(Done);
            }
            if (resultCase_ == ResultOneofCase.Error)
            {
                output.WriteRawTag(34);
                output.WriteMessage(Error);
            }
            if (resultCase_ == ResultOneofCase.Response)
            {
                output.WriteRawTag(42);
                output.WriteMessage(Response);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (metadata_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Metadata);
            if (Done != false) size += 1 + 1;
            if (resultCase_ == ResultOneofCase.Error) size += 1 + CodedOutputStream.ComputeMessageSize(Error);
            if (resultCase_ == ResultOneofCase.Response) size += 1 + CodedOutputStream.ComputeMessageSize(Response);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Operation other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.metadata_ != null)
            {
                if (metadata_ == null) Metadata = new Google.Protobuf.WellKnownTypes.Any();
                Metadata.MergeFrom(other.Metadata);
            }
            if (other.Done != false) Done = other.Done;
            switch (other.ResultCase)
            {
                case ResultOneofCase.Error:
                    Error ??= new Google.Rpc.Status();
                    Error.MergeFrom(other.Error);
                    break;
                case ResultOneofCase.Response:
                    Response ??= new Google.Protobuf.WellKnownTypes.Any();
                    Response.MergeFrom(other.Response);
                    break;
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
            if (metadata_ == null) {
              Metadata = new Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(Metadata);
            break;
          }
          case 24: {
            Done = input.ReadBool();
            break;
          }
          case 34: {
            Google.Rpc.Status subBuilder = new Google.Rpc.Status();
            if (resultCase_ == ResultOneofCase.Error) {
              subBuilder.MergeFrom(Error);
            }
            input.ReadMessage(subBuilder);
            Error = subBuilder;
            break;
          }
          case 42: {
            Google.Protobuf.WellKnownTypes.Any subBuilder = new Google.Protobuf.WellKnownTypes.Any();
            if (resultCase_ == ResultOneofCase.Response) {
              subBuilder.MergeFrom(Response);
            }
            input.ReadMessage(subBuilder);
            Response = subBuilder;
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
                            if (metadata_ == null) Metadata = new Google.Protobuf.WellKnownTypes.Any();
                            input.ReadMessage(Metadata);
                            break;
                        }
                    case 24:
                        {
                            Done = input.ReadBool();
                            break;
                        }
                    case 34:
                        {
                            Google.Rpc.Status subBuilder = new();
                            if (resultCase_ == ResultOneofCase.Error) subBuilder.MergeFrom(Error);
                            input.ReadMessage(subBuilder);
                            Error = subBuilder;
                            break;
                        }
                    case 42:
                        {
                            Google.Protobuf.WellKnownTypes.Any subBuilder = new();
                            if (resultCase_ == ResultOneofCase.Response) subBuilder.MergeFrom(Response);
                            input.ReadMessage(subBuilder);
                            Response = subBuilder;
                            break;
                        }
                }
            }
        }
#endif

    }
}
