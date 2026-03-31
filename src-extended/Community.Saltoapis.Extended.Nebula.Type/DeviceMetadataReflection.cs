namespace Saltoapis.Nebula.Type
{
    /// <summary>Holder for reflection information generated from salto/nebula/type/device_metadata.proto</summary>
    public static partial class DeviceMetadataReflection
    {
        /// <summary>File descriptor for salto/nebula/type/device_metadata.proto</summary>
        public static FileDescriptor Descriptor
        {
            get => descriptor;}

        private static FileDescriptor descriptor;

        static DeviceMetadataReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CidzYWx0by9uZWJ1bGEvdHlwZS9kZXZpY2VfbWV0YWRhdGEucHJvdG8SEXNh",
                  "bHRvLm5lYnVsYS50eXBlGhVzYWx0by90eXBlL2RhdGUucHJvdG8itwIKDkRl",
                  "dmljZU1ldGFkYXRhEkYKDmNpcmN1aXRfYm9hcmRzGAEgAygLMi4uc2FsdG8u",
                  "bmVidWxhLnR5cGUuRGV2aWNlTWV0YWRhdGEuQ2lyY3VpdEJvYXJkGtwBCgxD",
                  "aXJjdWl0Qm9hcmQSKgoQbWFudWZhY3R1cmVfZGF0ZRgCIAEoCzIQLnNhbHRv",
                  "LnR5cGUuRGF0ZRIVCg1zZXJpYWxfbnVtYmVyGAMgASgJEkoKCWZpcm13YXJl",
                  "cxgEIAMoCzI3LnNhbHRvLm5lYnVsYS50eXBlLkRldmljZU1ldGFkYXRhLkNp",
                  "cmN1aXRCb2FyZC5GaXJtd2FyZRo9CghGaXJtd2FyZRIOCgZudW1iZXIYASAB",
                  "KAkSDwoHdmVyc2lvbhgCIAEoCRIQCghyZXZpc2lvbhgDIAEoCULcAQoZY29t",
                  "LnNhbHRvYXBpcy5uZWJ1bGEudHlwZUITRGV2aWNlTWV0YWRhdGFQcm90b1AB",
                  "WlRnaXRodWIuY29tL3NhbHRvYXBpcy1pbnRlcm5hbC9zYWx0b2FwaXMtZ28v",
                  "bmVidWxhL3R5cGUvZGV2aWNlbWV0YWRhdGE7ZGV2aWNlbWV0YWRhdGGqAhVT",
                  "YWx0b2FwaXMuTmVidWxhLlR5cGXKAhVTYWx0b2FwaXNcTmVidWxhXFR5cGXi",
                  "AiFHUEJNZXRhZGF0YVxTYWx0b2FwaXNcTmVidWxhXFR5cGViBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Saltoapis.Type.DateReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(DeviceMetadata), DeviceMetadata.Parser, ["CircuitBoards"], null, null, null, [new(typeof(DeviceMetadata.Types.CircuitBoard), DeviceMetadata.Types.CircuitBoard.Parser, ["ManufactureDate", "SerialNumber", "Firmwares"], null, null, null, [new(typeof(DeviceMetadata.Types.CircuitBoard.Types.Firmware), DeviceMetadata.Types.CircuitBoard.Types.Firmware.Parser, ["Number", "Version", "Revision"], null, null, null, null)])])
                ]));
        }
    }

}