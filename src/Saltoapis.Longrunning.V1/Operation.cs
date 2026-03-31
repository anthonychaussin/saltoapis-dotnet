using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Longrunning.V1
{

    /// <summary>Holder for reflection information generated from salto/longrunning/v1/operation.proto</summary>
    public static partial class OperationReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/longrunning/v1/operation.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static OperationReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CiRzYWx0by9sb25ncnVubmluZy92MS9vcGVyYXRpb24ucHJvdG8SFHNhbHRv",
                  "LmxvbmdydW5uaW5nLnYxGhlnb29nbGUvcHJvdG9idWYvYW55LnByb3RvGhtn",
                  "b29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8aF2dvb2dsZS9ycGMvc3RhdHVz",
                  "LnByb3RvIqgBCglPcGVyYXRpb24SDAoEbmFtZRgBIAEoCRImCghtZXRhZGF0",
                  "YRgCIAEoCzIULmdvb2dsZS5wcm90b2J1Zi5BbnkSDAoEZG9uZRgDIAEoCBIj",
                  "CgVlcnJvchgEIAEoCzISLmdvb2dsZS5ycGMuU3RhdHVzSAASKAoIcmVzcG9u",
                  "c2UYBSABKAsyFC5nb29nbGUucHJvdG9idWYuQW55SABCCAoGcmVzdWx0IiMK",
                  "E0dldE9wZXJhdGlvblJlcXVlc3QSDAoEbmFtZRgBIAEoCSJOChVMaXN0T3Bl",
                  "cmF0aW9uc1JlcXVlc3QSEQoJcGFnZV9zaXplGAEgASgFEhIKCnBhZ2VfdG9r",
                  "ZW4YAiABKAkSDgoGZmlsdGVyGAMgASgJImYKFkxpc3RPcGVyYXRpb25zUmVz",
                  "cG9uc2USMwoKb3BlcmF0aW9ucxgBIAMoCzIfLnNhbHRvLmxvbmdydW5uaW5n",
                  "LnYxLk9wZXJhdGlvbhIXCg9uZXh0X3BhZ2VfdG9rZW4YAiABKAkiJgoWRGVs",
                  "ZXRlT3BlcmF0aW9uUmVxdWVzdBIMCgRuYW1lGAEgASgJIiYKFkNhbmNlbE9w",
                  "ZXJhdGlvblJlcXVlc3QSDAoEbmFtZRgBIAEoCTKNAwoQT3BlcmF0aW9uU2Vy",
                  "dmljZRJaCgxHZXRPcGVyYXRpb24SKS5zYWx0by5sb25ncnVubmluZy52MS5H",
                  "ZXRPcGVyYXRpb25SZXF1ZXN0Gh8uc2FsdG8ubG9uZ3J1bm5pbmcudjEuT3Bl",
                  "cmF0aW9uEmsKDkxpc3RPcGVyYXRpb25zEisuc2FsdG8ubG9uZ3J1bm5pbmcu",
                  "djEuTGlzdE9wZXJhdGlvbnNSZXF1ZXN0Giwuc2FsdG8ubG9uZ3J1bm5pbmcu",
                  "djEuTGlzdE9wZXJhdGlvbnNSZXNwb25zZRJXCg9EZWxldGVPcGVyYXRpb24S",
                  "LC5zYWx0by5sb25ncnVubmluZy52MS5EZWxldGVPcGVyYXRpb25SZXF1ZXN0",
                  "GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5ElcKD0NhbmNlbE9wZXJhdGlvbhIs",
                  "LnNhbHRvLmxvbmdydW5uaW5nLnYxLkNhbmNlbE9wZXJhdGlvblJlcXVlc3Qa",
                  "Fi5nb29nbGUucHJvdG9idWYuRW1wdHlC1AEKHGNvbS5zYWx0b2FwaXMubG9u",
                  "Z3J1bm5pbmcudjFCDk9wZXJhdGlvblByb3RvUAFaRWdpdGh1Yi5jb20vc2Fs",
                  "dG9hcGlzLWludGVybmFsL3NhbHRvYXBpcy1nby9sb25ncnVubmluZy92MTts",
                  "b25ncnVubmluZ6oCGFNhbHRvYXBpcy5Mb25ncnVubmluZy5WMcoCGFNhbHRv",
                  "YXBpc1xMb25ncnVubmluZ1xWMeICJEdQQk1ldGFkYXRhXFNhbHRvYXBpc1xM",
                  "b25ncnVubmluZ1xWMWIGcHJvdG8z"));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Rpc.StatusReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Operation), Operation.Parser, ["Name", "Metadata", "Done", "Error", "Response"], ["Result"], null, null, null),
            new(typeof(GetOperationRequest), GetOperationRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListOperationsRequest), ListOperationsRequest.Parser, ["PageSize", "PageToken", "Filter"], null, null, null, null),
            new(typeof(ListOperationsResponse), ListOperationsResponse.Parser, ["Operations", "NextPageToken"], null, null, null, null),
            new(typeof(DeleteOperationRequest), DeleteOperationRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(CancelOperationRequest), CancelOperationRequest.Parser, ["Name"], null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
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
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Name != other.Name) return false;
            if (!Equals(Metadata, other.Metadata)) return false;
            if (Done != other.Done) return false;
            if (!Equals(Error, other.Error)) return false;
            if (!Equals(Response, other.Response)) return false;
            if (ResultCase != other.ResultCase) return false;
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
            if (Name.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Name);
            }
            if (metadata_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Metadata);
            }
            if (Done != false)
            {
                size += 1 + 1;
            }
            if (resultCase_ == ResultOneofCase.Error)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Error);
            }
            if (resultCase_ == ResultOneofCase.Response)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Response);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(Operation other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.metadata_ != null)
            {
                if (metadata_ == null)
                {
                    Metadata = new Google.Protobuf.WellKnownTypes.Any();
                }
                Metadata.MergeFrom(other.Metadata);
            }
            if (other.Done != false)
            {
                Done = other.Done;
            }
            switch (other.ResultCase)
            {
                case ResultOneofCase.Error:
                    if (Error == null)
                    {
                        Error = new Google.Rpc.Status();
                    }
                    Error.MergeFrom(other.Error);
                    break;
                case ResultOneofCase.Response:
                    if (Response == null)
                    {
                        Response = new Google.Protobuf.WellKnownTypes.Any();
                    }
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
                            if (metadata_ == null)
                            {
                                Metadata = new Google.Protobuf.WellKnownTypes.Any();
                            }
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
                            if (resultCase_ == ResultOneofCase.Error)
                            {
                                subBuilder.MergeFrom(Error);
                            }
                            input.ReadMessage(subBuilder);
                            Error = subBuilder;
                            break;
                        }
                    case 42:
                        {
                            Google.Protobuf.WellKnownTypes.Any subBuilder = new();
                            if (resultCase_ == ResultOneofCase.Response)
                            {
                                subBuilder.MergeFrom(Response);
                            }
                            input.ReadMessage(subBuilder);
                            Response = subBuilder;
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for
    /// [`OperationService.GetOperation`][salto.longrunning.v1.OperationService.GetOperation].
    /// </summary>
    public sealed partial class GetOperationRequest : IMessage<GetOperationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetOperationRequest> _parser = new(() => new GetOperationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetOperationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return OperationReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetOperationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetOperationRequest(GetOperationRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetOperationRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the operation resource.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetOperationRequest);
        public bool Equals(GetOperationRequest other)
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

        public void MergeFrom(GetOperationRequest other)
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
    /// The request message for
    /// [`OperationService.ListOperations`][salto.longrunning.v1.OperationService.ListOperations].
    /// </summary>
    public sealed partial class ListOperationsRequest : IMessage<ListOperationsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListOperationsRequest> _parser = new(() => new ListOperationsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListOperationsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return OperationReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListOperationsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListOperationsRequest(ListOperationsRequest other) : this()
        {
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListOperationsRequest Clone() => new(this);
        /// <summary>Field number for the "page_size" field.</summary>
        public const int PageSizeFieldNumber = 1;
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
        public const int PageTokenFieldNumber = 2;
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
        public const int FilterFieldNumber = 3;
        private string filter_ = "";

        /// <summary>
        /// A filter that chooses which operations to return. The maximum
        /// length of the filter is 20000 characters.
        /// </summary>
        public string Filter
        {
            get { return filter_; }
            set
            {
                filter_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListOperationsRequest);
        public bool Equals(ListOperationsRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (PageSize != other.PageSize) return false;
            if (PageToken != other.PageToken) return false;
            if (Filter != other.Filter) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (PageSize != 0) hash ^= PageSize.GetHashCode();
            if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
            if (Filter.Length != 0) hash ^= Filter.GetHashCode();
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
      if (PageSize != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PageToken);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Filter);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (PageSize != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(PageSize);
            }
            if (PageToken.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(PageToken);
            }
            if (Filter.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(Filter);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
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
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ListOperationsRequest other)
        {
            if (other == null)
            {
                return;
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
          case 8: {
            PageSize = input.ReadInt32();
            break;
          }
          case 18: {
            PageToken = input.ReadString();
            break;
          }
          case 26: {
            Filter = input.ReadString();
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
                    case 8:
                        {
                            PageSize = input.ReadInt32();
                            break;
                        }
                    case 18:
                        {
                            PageToken = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            Filter = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for
    /// [`Operations.ListOperations`][salto.longrunning.v1.OperationService.ListOperations].
    /// </summary>
    public sealed partial class ListOperationsResponse : IMessage<ListOperationsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListOperationsResponse> _parser = new(() => new ListOperationsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListOperationsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return OperationReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListOperationsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListOperationsResponse(ListOperationsResponse other) : this()
        {
            operations_ = other.operations_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListOperationsResponse Clone() => new(this);
        /// <summary>Field number for the "operations" field.</summary>
        public const int OperationsFieldNumber = 1;
        private static readonly FieldCodec<Operation> _repeated_operations_codec
            = FieldCodec.ForMessage(10, Operation.Parser);
        private readonly RepeatedField<Operation> operations_ = [];

        /// <summary>
        /// A list of operations that matches the specified filter in the request.
        /// </summary>
        public RepeatedField<Operation> Operations
        {
            get { return operations_; }
        }

        /// <summary>Field number for the "next_page_token" field.</summary>
        public const int NextPageTokenFieldNumber = 2;
        private string nextPageToken_ = "";

        /// <summary>
        /// The standard List next-page token.
        /// </summary>
        public string NextPageToken
        {
            get { return nextPageToken_; }
            set
            {
                nextPageToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListOperationsResponse);
        public bool Equals(ListOperationsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!operations_.Equals(other.operations_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= operations_.GetHashCode();
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
      operations_.WriteTo(output, _repeated_operations_codec);
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
            operations_.WriteTo(ref output, _repeated_operations_codec);
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
            size += operations_.CalculateSize(_repeated_operations_codec);
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

        public void MergeFrom(ListOperationsResponse other)
        {
            if (other == null)
            {
                return;
            }
            operations_.Add(other.operations_);
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
            operations_.AddEntriesFrom(input, _repeated_operations_codec);
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
                            operations_.AddEntriesFrom(ref input, _repeated_operations_codec);
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
    /// The request message for
    /// [`OperationService.DeleteOperation`][salto.longrunning.v1.OperationService.DeleteOperation].
    /// </summary>
    public sealed partial class DeleteOperationRequest : IMessage<DeleteOperationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteOperationRequest> _parser = new(() => new DeleteOperationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteOperationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return OperationReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteOperationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteOperationRequest(DeleteOperationRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteOperationRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the operation to be deleted. For example:
        /// `operations/01ds5r5cbjr9hvke5f6c5s7nm0`.
        /// Format: operations/{operation}

        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteOperationRequest);
        public bool Equals(DeleteOperationRequest other)
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

        public void MergeFrom(DeleteOperationRequest other)
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
    /// The request message for
    /// [`OperationService.CancelOperation`][salto.longrunning.v1.OperationService.CancelOperation].
    /// </summary>
    public sealed partial class CancelOperationRequest : IMessage<CancelOperationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CancelOperationRequest> _parser = new(() => new CancelOperationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CancelOperationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return OperationReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CancelOperationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CancelOperationRequest(CancelOperationRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CancelOperationRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the operation resource to be cancelled. For example:
        /// `operations/01ds5r5cbjr9hvke5f6c5s7nm0`.
        /// Format: operations/{operation}

        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as CancelOperationRequest);
        public bool Equals(CancelOperationRequest other)
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

        public void MergeFrom(CancelOperationRequest other)
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
