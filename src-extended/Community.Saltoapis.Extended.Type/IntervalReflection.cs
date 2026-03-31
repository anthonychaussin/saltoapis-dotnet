namespace Saltoapis.Type
{
    /// <summary>Holder for reflection information generated from salto/type/interval.proto
    /// Represents a time interval with a start and end time.
    /// </summary>
    public static partial class IntervalReflection
    {
        /// <summary>File descriptor for salto/type/interval.proto</summary>
        public static FileDescriptor Descriptor
        {
            get => descriptor;}

        private static FileDescriptor descriptor;

        static IntervalReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "ChlzYWx0by90eXBlL2ludGVydmFsLnByb3RvEgpzYWx0by50eXBlGh9nb29n",
                  "bGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvImgKCEludGVydmFsEi4KCnN0",
                  "YXJ0X3RpbWUYASABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEiwK",
                  "CGVuZF90aW1lGAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcEKn",
                  "AQoSY29tLnNhbHRvYXBpcy50eXBlQg1JbnRlcnZhbFByb3RvUAFaQWdpdGh1",
                  "Yi5jb20vc2FsdG9hcGlzLWludGVybmFsL3NhbHRvYXBpcy1nby90eXBlL2lu",
                  "dGVydmFsO2ludGVydmFsqgIOU2FsdG9hcGlzLlR5cGXKAg5TYWx0b2FwaXNc",
                  "VHlwZeICGkdQQk1ldGFkYXRhXFNhbHRvYXBpc1xUeXBlYgZwcm90bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Interval), Interval.Parser, ["StartTime", "EndTime"], null, null, null, null)
                ]));
        }
    }
}