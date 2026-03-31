using Grpc.Core;
using Google.Protobuf;

namespace Saltoapis.Grpc
{
    internal static class GrpcMessageHelper
    {
        internal static readonly Marshaller<Google.Protobuf.WellKnownTypes.Empty> EmptyMarshaller =
            CreateMarshaller(Google.Protobuf.WellKnownTypes.Empty.Parser);

        internal static Marshaller<T> CreateMarshaller<T>(MessageParser<T> parser) where T : IMessage<T>
            => Marshallers.Create(SerializeMessage, context => DeserializeMessage(context, parser));

        internal static void SerializeMessage<T>(T message, SerializationContext context) where T : IMessage<T>
        {
#if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
            if (message is IBufferMessage)
            {
                context.SetPayloadLength(message.CalculateSize());
                MessageExtensions.WriteTo(message, context.GetBufferWriter());
                context.Complete();
                return;
            }
#endif
            context.Complete(MessageExtensions.ToByteArray(message));
        }

        static class MessageCache<T>
        {
            public static readonly bool IsBufferMessage = IntrospectionExtensions.GetTypeInfo(typeof(IBufferMessage)).IsAssignableFrom(typeof(T));
        }

        internal static T DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
        {
#if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
            if (MessageCache<T>.IsBufferMessage) return parser.ParseFrom(context.PayloadAsReadOnlySequence());
#endif
            return parser.ParseFrom(context.PayloadAsNewBuffer());
        }
    }
}
