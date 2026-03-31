using Saltoapis.Nebula.File.V1.Request;

using Saltoapis.Grpc;
namespace Saltoapis.Nebula.File.V1
{
    /// <summary>
    /// A file represents an object that serves as a reference for files
    /// stored elsewhere. This service is responsible for managing file resources.
    /// </summary>
    public static partial class FileService
    {
        static readonly string __ServiceName = "salto.nebula.file.v1.FileService";

        static readonly Marshaller<CreateFileRequest> __Marshaller_salto_nebula_file_v1_CreateFileRequest = GrpcMessageHelper.CreateMarshaller(CreateFileRequest.Parser);

        static readonly Marshaller<File> __Marshaller_salto_nebula_file_v1_File = GrpcMessageHelper.CreateMarshaller(File.Parser);

        static readonly Method<CreateFileRequest, File> __Method_CreateFile = new(
            MethodType.Unary,
            __ServiceName,
            "CreateFile",
            __Marshaller_salto_nebula_file_v1_CreateFileRequest,
            __Marshaller_salto_nebula_file_v1_File);
        /// <summary>Service descriptor</summary>
        public static ServiceDescriptor Descriptor
        {
            get => FileReflection.Descriptor.Services[0];}
        /// <summary>Client for FileService</summary>
        public partial class FileServiceClient : ClientBase<FileServiceClient>
        {
            /// <summary>Creates a new client for FileService</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public FileServiceClient(ChannelBase channel) : base(channel)
            {
            }
            /// <summary>Creates a new client for FileService that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public FileServiceClient(CallInvoker callInvoker) : base(callInvoker)
            {
            }
            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected FileServiceClient() : base()
            {
            }
            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected FileServiceClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }
            /// <summary>
            /// Create a file
            ///
            /// Creates a new file.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual File CreateFile(CreateFileRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateFile(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a file
            ///
            /// Creates a new file.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual File CreateFile(CreateFileRequest request, CallOptions options) => CallInvoker.BlockingUnaryCall(__Method_CreateFile, null, options, request);
            /// <summary>
            /// Create a file
            ///
            /// Creates a new file.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<File> CreateFileAsync(CreateFileRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default) => CreateFileAsync(request, new CallOptions(headers, deadline, cancellationToken));
            /// <summary>
            /// Create a file
            ///
            /// Creates a new file.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual AsyncUnaryCall<File> CreateFileAsync(CreateFileRequest request, CallOptions options) => CallInvoker.AsyncUnaryCall(__Method_CreateFile, null, options, request);
            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override FileServiceClient NewInstance(ClientBaseConfiguration configuration) => new(configuration);
        }
    }
}