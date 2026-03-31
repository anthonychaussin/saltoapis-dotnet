using Google.Protobuf.Reflection;
using Saltoapis.Nebula.Device.V1.Request;
using Saltoapis.Nebula.Device.V1.Response;

namespace Saltoapis.Nebula.Device.V1
{
    /// <summary>Holder for reflection information generated from salto/nebula/device/v1/device.proto</summary>
    public static partial class DeviceReflection
    {

        /// <summary>File descriptor for salto/nebula/device/v1/device.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static DeviceReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CiNzYWx0by9uZWJ1bGEvZGV2aWNlL3YxL2RldmljZS5wcm90bxIWc2FsdG8u",
                  "bmVidWxhLmRldmljZS52MRofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5w",
                  "cm90bxojc2FsdG8vbmVidWxhL3R5cGUvZGV2aWNlX3R5cGUucHJvdG8i+gIK",
                  "BkRldmljZRIMCgRuYW1lGAEgASgJEhQKDGRpc3BsYXlfbmFtZRgCIAEoCRIW",
                  "CglkZXZpY2VfaWQYAyABKAlIAYgBARIyCgtkZXZpY2VfdHlwZRgEIAEoDjId",
                  "LnNhbHRvLm5lYnVsYS50eXBlLkRldmljZVR5cGUSDgoGc291cmNlGAUgASgJ",
                  "EhEKB2dhdGV3YXkYBiABKAlIABISCghleHRlbmRlchgHIAEoCUgAEhAKCG91",
                  "dGRhdGVkGAggASgIEhYKCWNvbm5lY3RlZBgJIAEoCEgCiAEBEhgKC2xvd19i",
                  "YXR0ZXJ5GAogASgISAOIAQESMwoPbGFzdF9ldmVudF90aW1lGAsgASgLMhou",
                  "Z29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBITCgtpbml0aWFsaXplZBgMIAEo",
                  "CEIPCg1wYXJlbnRfZGV2aWNlQgwKCl9kZXZpY2VfaWRCDAoKX2Nvbm5lY3Rl",
                  "ZEIOCgxfbG93X2JhdHRlcnkiIAoQR2V0RGV2aWNlUmVxdWVzdBIMCgRuYW1l",
                  "GAEgASgJIm0KEkxpc3REZXZpY2VzUmVxdWVzdBIOCgZwYXJlbnQYASABKAkS",
                  "EQoJcGFnZV9zaXplGAIgASgFEhIKCnBhZ2VfdG9rZW4YAyABKAkSDgoGZmls",
                  "dGVyGAQgASgJEhAKCG9yZGVyX2J5GAUgASgJInMKE0xpc3REZXZpY2VzUmVz",
                  "cG9uc2USLwoHZGV2aWNlcxgBIAMoCzIeLnNhbHRvLm5lYnVsYS5kZXZpY2Uu",
                  "djEuRGV2aWNlEhcKD25leHRfcGFnZV90b2tlbhgCIAEoCRISCgp0b3RhbF9z",
                  "aXplGAMgASgFMs4BCg1EZXZpY2VTZXJ2aWNlElUKCUdldERldmljZRIoLnNh",
                  "bHRvLm5lYnVsYS5kZXZpY2UudjEuR2V0RGV2aWNlUmVxdWVzdBoeLnNhbHRv",
                  "Lm5lYnVsYS5kZXZpY2UudjEuRGV2aWNlEmYKC0xpc3REZXZpY2VzEiouc2Fs",
                  "dG8ubmVidWxhLmRldmljZS52MS5MaXN0RGV2aWNlc1JlcXVlc3QaKy5zYWx0",
                  "by5uZWJ1bGEuZGV2aWNlLnYxLkxpc3REZXZpY2VzUmVzcG9uc2VC1gEKHmNv",
                  "bS5zYWx0b2FwaXMubmVidWxhLmRldmljZS52MUILRGV2aWNlUHJvdG9QAVpC",
                  "Z2l0aHViLmNvbS9zYWx0b2FwaXMtaW50ZXJuYWwvc2FsdG9hcGlzLWdvL25l",
                  "YnVsYS9kZXZpY2UvdjE7ZGV2aWNlqgIaU2FsdG9hcGlzLk5lYnVsYS5EZXZp",
                  "Y2UuVjHKAhpTYWx0b2FwaXNcTmVidWxhXERldmljZVxWMeICJkdQQk1ldGFk",
                  "YXRhXFNhbHRvYXBpc1xOZWJ1bGFcRGV2aWNlXFYxYgZwcm90bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, Type.DeviceTypeReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Device), Device.Parser, ["Name", "DisplayName", "DeviceId", "DeviceType", "Source", "Gateway", "Extender", "Outdated", "Connected", "LowBattery", "LastEventTime", "Initialized"], ["ParentDevice", "DeviceId", "Connected", "LowBattery"], null, null, null),
            new(typeof(GetDeviceRequest), GetDeviceRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListDevicesRequest), ListDevicesRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListDevicesResponse), ListDevicesResponse.Parser, ["Devices", "NextPageToken", "TotalSize"], null, null, null, null)
                ]));
        }

    }


}
