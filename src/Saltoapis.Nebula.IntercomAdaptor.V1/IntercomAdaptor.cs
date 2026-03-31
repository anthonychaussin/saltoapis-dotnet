using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.IntercomAdaptor.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/intercomadaptor/v1/intercom_adaptor.proto</summary>
    public static partial class IntercomAdaptorReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/intercomadaptor/v1/intercom_adaptor.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static IntercomAdaptorReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CjZzYWx0by9uZWJ1bGEvaW50ZXJjb21hZGFwdG9yL3YxL2ludGVyY29tX2Fk",
                  "YXB0b3IucHJvdG8SH3NhbHRvLm5lYnVsYS5pbnRlcmNvbWFkYXB0b3IudjEa",
                  "G2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90bxogZ29vZ2xlL3Byb3RvYnVm",
                  "L2ZpZWxkX21hc2sucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAu",
                  "cHJvdG8aJHNhbHRvL2xvbmdydW5uaW5nL3YxL29wZXJhdGlvbi5wcm90bxon",
                  "c2FsdG8vbmVidWxhL3R5cGUvZGV2aWNlX21ldGFkYXRhLnByb3RvIoEECg9J",
                  "bnRlcmNvbUFkYXB0b3ISDAoEbmFtZRgBIAEoCRIUCgxkaXNwbGF5X25hbWUY",
                  "AiABKAkSFgoJZGV2aWNlX2lkGAMgASgJSAGIAQESEQoHZ2F0ZXdheRgEIAEo",
                  "CUgAEhIKCGV4dGVuZGVyGAUgASgJSAASUgoNYWNjZXNzX3BvaW50cxgGIAMo",
                  "CzI7LnNhbHRvLm5lYnVsYS5pbnRlcmNvbWFkYXB0b3IudjEuSW50ZXJjb21B",
                  "ZGFwdG9yQWNjZXNzUG9pbnQSEwoLaW5pdGlhbGl6ZWQYByABKAgSOgoPZGV2",
                  "aWNlX21ldGFkYXRhGBAgASgLMiEuc2FsdG8ubmVidWxhLnR5cGUuRGV2aWNl",
                  "TWV0YWRhdGESEAoIb3V0ZGF0ZWQYCCABKAgSEQoJY29ubmVjdGVkGAkgASgI",
                  "EhMKC2xvd19iYXR0ZXJ5GAogASgIEjMKD2xhc3RfZXZlbnRfdGltZRgLIAEo",
                  "CzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASFQoIaW50ZXJjb20YDCAB",
                  "KAlIAogBARIOCgZwaG90b3MYDSADKAkSEgoKcGhvdG9fdXJpcxgOIAMoCRIQ",
                  "CghyZWFkaW5ncxgPIAMoCUIPCg1wYXJlbnRfZGV2aWNlQgwKCl9kZXZpY2Vf",
                  "aWRCCwoJX2ludGVyY29tImIKGkludGVyY29tQWRhcHRvckFjY2Vzc1BvaW50",
                  "EhQKDGFjY2Vzc19wb2ludBgBIAEoCRIbCg5mcmFtZV9zZXR0aW5ncxgCIAEo",
                  "DEgAiAEBQhEKD19mcmFtZV9zZXR0aW5ncyK0AQocQ3JlYXRlSW50ZXJjb21B",
                  "ZGFwdG9yUmVxdWVzdBIOCgZwYXJlbnQYASABKAkSIAoTaW50ZXJjb21fYWRh",
                  "cHRvcl9pZBgCIAEoCUgAiAEBEkoKEGludGVyY29tX2FkYXB0b3IYAyABKAsy",
                  "MC5zYWx0by5uZWJ1bGEuaW50ZXJjb21hZGFwdG9yLnYxLkludGVyY29tQWRh",
                  "cHRvckIWChRfaW50ZXJjb21fYWRhcHRvcl9pZCIpChlHZXRJbnRlcmNvbUFk",
                  "YXB0b3JSZXF1ZXN0EgwKBG5hbWUYASABKAkidgobTGlzdEludGVyY29tQWRh",
                  "cHRvcnNSZXF1ZXN0Eg4KBnBhcmVudBgBIAEoCRIRCglwYWdlX3NpemUYAiAB",
                  "KAUSEgoKcGFnZV90b2tlbhgDIAEoCRIOCgZmaWx0ZXIYBCABKAkSEAoIb3Jk",
                  "ZXJfYnkYBSABKAkihAEKHExpc3RJbnRlcmNvbUFkYXB0b3JzUmVzcG9uc2US",
                  "SwoRaW50ZXJjb21fYWRhcHRvcnMYASADKAsyMC5zYWx0by5uZWJ1bGEuaW50",
                  "ZXJjb21hZGFwdG9yLnYxLkludGVyY29tQWRhcHRvchIXCg9uZXh0X3BhZ2Vf",
                  "dG9rZW4YAiABKAkimwEKHFVwZGF0ZUludGVyY29tQWRhcHRvclJlcXVlc3QS",
                  "SgoQaW50ZXJjb21fYWRhcHRvchgBIAEoCzIwLnNhbHRvLm5lYnVsYS5pbnRl",
                  "cmNvbWFkYXB0b3IudjEuSW50ZXJjb21BZGFwdG9yEi8KC3VwZGF0ZV9tYXNr",
                  "GAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLkZpZWxkTWFzayIsChxEZWxldGVJ",
                  "bnRlcmNvbUFkYXB0b3JSZXF1ZXN0EgwKBG5hbWUYASABKAkiPQoaQmluZElu",
                  "dGVyY29tQWRhcHRvclJlcXVlc3QSDAoEbmFtZRgBIAEoCRIRCglkZXZpY2Vf",
                  "aWQYAiABKAkiHQobQmluZEludGVyY29tQWRhcHRvclJlc3BvbnNlIjsKHFVu",
                  "YmluZEludGVyY29tQWRhcHRvclJlcXVlc3QSDAoEbmFtZRgBIAEoCRINCgVm",
                  "b3JjZRgCIAEoCCIfCh1VbmJpbmRJbnRlcmNvbUFkYXB0b3JSZXNwb25zZSIw",
                  "CiBJbml0aWFsaXplSW50ZXJjb21BZGFwdG9yUmVxdWVzdBIMCgRuYW1lGAEg",
                  "ASgJIiMKIUluaXRpYWxpemVJbnRlcmNvbUFkYXB0b3JSZXNwb25zZSI9CiFJ",
                  "bml0aWFsaXplSW50ZXJjb21BZGFwdG9yTWV0YWRhdGESGAoQcHJvZ3Jlc3Nf",
                  "cGVyY2VudBgBIAEoBSIvCh9Db25maWd1cmVJbnRlcmNvbUFkYXB0b3JSZXF1",
                  "ZXN0EgwKBG5hbWUYASABKAkiIgogQ29uZmlndXJlSW50ZXJjb21BZGFwdG9y",
                  "UmVzcG9uc2UiIgogQ29uZmlndXJlSW50ZXJjb21BZGFwdG9yTWV0YWRhdGEi",
                  "KwobUmVzZXRJbnRlcmNvbUFkYXB0b3JSZXF1ZXN0EgwKBG5hbWUYASABKAki",
                  "HgocUmVzZXRJbnRlcmNvbUFkYXB0b3JSZXNwb25zZSIeChxSZXNldEludGVy",
                  "Y29tQWRhcHRvck1ldGFkYXRhIkAKJFVwZGF0ZUludGVyY29tQWRhcHRvckZp",
                  "cm13YXJlUmVxdWVzdBIYChBpbnRlcmNvbV9hZGFwdG9yGAEgASgJIicKJVVw",
                  "ZGF0ZUludGVyY29tQWRhcHRvckZpcm13YXJlUmVzcG9uc2UiQQolVXBkYXRl",
                  "SW50ZXJjb21BZGFwdG9yRmlybXdhcmVNZXRhZGF0YRIYChBwcm9ncmVzc19w",
                  "ZXJjZW50GAEgASgFIj0KIUdlbmVyYXRlQXV0aG9yaXphdGlvblRva2VuUmVx",
                  "dWVzdBIYChBpbnRlcmNvbV9hZGFwdG9yGAEgASgJIkEKIkdlbmVyYXRlQXV0",
                  "aG9yaXphdGlvblRva2VuUmVzcG9uc2USGwoTYXV0aG9yaXphdGlvbl90b2tl",
                  "bhgBIAEoDCI+CiJHZW5lcmF0ZUZpcm13YXJlRG93bmxvYWRVcmlSZXF1ZXN0",
                  "EhgKEGludGVyY29tX2FkYXB0b3IYASABKAkiSwojR2VuZXJhdGVGaXJtd2Fy",
                  "ZURvd25sb2FkVXJpUmVzcG9uc2USFAoMZG93bmxvYWRfdXJpGAEgASgJEg4K",
                  "BmRpZ2VzdBgCIAEoCSIlCiNHZW5lcmF0ZUZpcm13YXJlRG93bmxvYWRVcmlN",
                  "ZXRhZGF0YTKUDgoWSW50ZXJjb21BZGFwdG9yU2VydmljZRKIAQoVQ3JlYXRl",
                  "SW50ZXJjb21BZGFwdG9yEj0uc2FsdG8ubmVidWxhLmludGVyY29tYWRhcHRv",
                  "ci52MS5DcmVhdGVJbnRlcmNvbUFkYXB0b3JSZXF1ZXN0GjAuc2FsdG8ubmVi",
                  "dWxhLmludGVyY29tYWRhcHRvci52MS5JbnRlcmNvbUFkYXB0b3ISggEKEkdl",
                  "dEludGVyY29tQWRhcHRvchI6LnNhbHRvLm5lYnVsYS5pbnRlcmNvbWFkYXB0",
                  "b3IudjEuR2V0SW50ZXJjb21BZGFwdG9yUmVxdWVzdBowLnNhbHRvLm5lYnVs",
                  "YS5pbnRlcmNvbWFkYXB0b3IudjEuSW50ZXJjb21BZGFwdG9yEpMBChRMaXN0",
                  "SW50ZXJjb21BZGFwdG9ycxI8LnNhbHRvLm5lYnVsYS5pbnRlcmNvbWFkYXB0",
                  "b3IudjEuTGlzdEludGVyY29tQWRhcHRvcnNSZXF1ZXN0Gj0uc2FsdG8ubmVi",
                  "dWxhLmludGVyY29tYWRhcHRvci52MS5MaXN0SW50ZXJjb21BZGFwdG9yc1Jl",
                  "c3BvbnNlEogBChVVcGRhdGVJbnRlcmNvbUFkYXB0b3ISPS5zYWx0by5uZWJ1",
                  "bGEuaW50ZXJjb21hZGFwdG9yLnYxLlVwZGF0ZUludGVyY29tQWRhcHRvclJl",
                  "cXVlc3QaMC5zYWx0by5uZWJ1bGEuaW50ZXJjb21hZGFwdG9yLnYxLkludGVy",
                  "Y29tQWRhcHRvchJuChVEZWxldGVJbnRlcmNvbUFkYXB0b3ISPS5zYWx0by5u",
                  "ZWJ1bGEuaW50ZXJjb21hZGFwdG9yLnYxLkRlbGV0ZUludGVyY29tQWRhcHRv",
                  "clJlcXVlc3QaFi5nb29nbGUucHJvdG9idWYuRW1wdHkSkAEKE0JpbmRJbnRl",
                  "cmNvbUFkYXB0b3ISOy5zYWx0by5uZWJ1bGEuaW50ZXJjb21hZGFwdG9yLnYx",
                  "LkJpbmRJbnRlcmNvbUFkYXB0b3JSZXF1ZXN0Gjwuc2FsdG8ubmVidWxhLmlu",
                  "dGVyY29tYWRhcHRvci52MS5CaW5kSW50ZXJjb21BZGFwdG9yUmVzcG9uc2US",
                  "lgEKFVVuYmluZEludGVyY29tQWRhcHRvchI9LnNhbHRvLm5lYnVsYS5pbnRl",
                  "cmNvbWFkYXB0b3IudjEuVW5iaW5kSW50ZXJjb21BZGFwdG9yUmVxdWVzdBo+",
                  "LnNhbHRvLm5lYnVsYS5pbnRlcmNvbWFkYXB0b3IudjEuVW5iaW5kSW50ZXJj",
                  "b21BZGFwdG9yUmVzcG9uc2USfwoZSW5pdGlhbGl6ZUludGVyY29tQWRhcHRv",
                  "chJBLnNhbHRvLm5lYnVsYS5pbnRlcmNvbWFkYXB0b3IudjEuSW5pdGlhbGl6",
                  "ZUludGVyY29tQWRhcHRvclJlcXVlc3QaHy5zYWx0by5sb25ncnVubmluZy52",
                  "MS5PcGVyYXRpb24SfQoYQ29uZmlndXJlSW50ZXJjb21BZGFwdG9yEkAuc2Fs",
                  "dG8ubmVidWxhLmludGVyY29tYWRhcHRvci52MS5Db25maWd1cmVJbnRlcmNv",
                  "bUFkYXB0b3JSZXF1ZXN0Gh8uc2FsdG8ubG9uZ3J1bm5pbmcudjEuT3BlcmF0",
                  "aW9uEnUKFFJlc2V0SW50ZXJjb21BZGFwdG9yEjwuc2FsdG8ubmVidWxhLmlu",
                  "dGVyY29tYWRhcHRvci52MS5SZXNldEludGVyY29tQWRhcHRvclJlcXVlc3Qa",
                  "Hy5zYWx0by5sb25ncnVubmluZy52MS5PcGVyYXRpb24ShwEKHVVwZGF0ZUlu",
                  "dGVyY29tQWRhcHRvckZpcm13YXJlEkUuc2FsdG8ubmVidWxhLmludGVyY29t",
                  "YWRhcHRvci52MS5VcGRhdGVJbnRlcmNvbUFkYXB0b3JGaXJtd2FyZVJlcXVl",
                  "c3QaHy5zYWx0by5sb25ncnVubmluZy52MS5PcGVyYXRpb24SpQEKGkdlbmVy",
                  "YXRlQXV0aG9yaXphdGlvblRva2VuEkIuc2FsdG8ubmVidWxhLmludGVyY29t",
                  "YWRhcHRvci52MS5HZW5lcmF0ZUF1dGhvcml6YXRpb25Ub2tlblJlcXVlc3Qa",
                  "Qy5zYWx0by5uZWJ1bGEuaW50ZXJjb21hZGFwdG9yLnYxLkdlbmVyYXRlQXV0",
                  "aG9yaXphdGlvblRva2VuUmVzcG9uc2USgwEKG0dlbmVyYXRlRmlybXdhcmVE",
                  "b3dubG9hZFVyaRJDLnNhbHRvLm5lYnVsYS5pbnRlcmNvbWFkYXB0b3IudjEu",
                  "R2VuZXJhdGVGaXJtd2FyZURvd25sb2FkVXJpUmVxdWVzdBofLnNhbHRvLmxv",
                  "bmdydW5uaW5nLnYxLk9wZXJhdGlvbkKVAgonY29tLnNhbHRvYXBpcy5uZWJ1",
                  "bGEuaW50ZXJjb21hZGFwdG9yLnYxQhRJbnRlcmNvbUFkYXB0b3JQcm90b1AB",
                  "WlRnaXRodWIuY29tL3NhbHRvYXBpcy1pbnRlcm5hbC9zYWx0b2FwaXMtZ28v",
                  "bmVidWxhL2ludGVyY29tYWRhcHRvci92MTtpbnRlcmNvbWFkYXB0b3KqAiNT",
                  "YWx0b2FwaXMuTmVidWxhLkludGVyY29tQWRhcHRvci5WMcoCI1NhbHRvYXBp",
                  "c1xOZWJ1bGFcSW50ZXJjb21BZGFwdG9yXFYx4gIvR1BCTWV0YWRhdGFcU2Fs",
                  "dG9hcGlzXE5lYnVsYVxJbnRlcmNvbUFkYXB0b3JcVjFiBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, Longrunning.V1.OperationReflection.Descriptor, Type.DeviceMetadataReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(IntercomAdaptor), IntercomAdaptor.Parser, ["Name", "DisplayName", "DeviceId", "Gateway", "Extender", "AccessPoints", "Initialized", "DeviceMetadata", "Outdated", "Connected", "LowBattery", "LastEventTime", "Intercom", "Photos", "PhotoUris", "Readings"], ["ParentDevice", "DeviceId", "Intercom"], null, null, null),
            new(typeof(IntercomAdaptorAccessPoint), IntercomAdaptorAccessPoint.Parser, ["AccessPoint", "FrameSettings"], ["FrameSettings"], null, null, null),
            new(typeof(CreateIntercomAdaptorRequest), CreateIntercomAdaptorRequest.Parser, ["Parent", "IntercomAdaptorId", "IntercomAdaptor"], ["IntercomAdaptorId"], null, null, null),
            new(typeof(GetIntercomAdaptorRequest), GetIntercomAdaptorRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListIntercomAdaptorsRequest), ListIntercomAdaptorsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListIntercomAdaptorsResponse), ListIntercomAdaptorsResponse.Parser, ["IntercomAdaptors", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateIntercomAdaptorRequest), UpdateIntercomAdaptorRequest.Parser, ["IntercomAdaptor", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteIntercomAdaptorRequest), DeleteIntercomAdaptorRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(BindIntercomAdaptorRequest), BindIntercomAdaptorRequest.Parser, ["Name", "DeviceId"], null, null, null, null),
            new(typeof(BindIntercomAdaptorResponse), BindIntercomAdaptorResponse.Parser, null, null, null, null, null),
            new(typeof(UnbindIntercomAdaptorRequest), UnbindIntercomAdaptorRequest.Parser, ["Name", "Force"], null, null, null, null),
            new(typeof(UnbindIntercomAdaptorResponse), UnbindIntercomAdaptorResponse.Parser, null, null, null, null, null),
            new(typeof(InitializeIntercomAdaptorRequest), InitializeIntercomAdaptorRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(InitializeIntercomAdaptorResponse), InitializeIntercomAdaptorResponse.Parser, null, null, null, null, null),
            new(typeof(InitializeIntercomAdaptorMetadata), InitializeIntercomAdaptorMetadata.Parser, ["ProgressPercent"], null, null, null, null),
            new(typeof(ConfigureIntercomAdaptorRequest), ConfigureIntercomAdaptorRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ConfigureIntercomAdaptorResponse), ConfigureIntercomAdaptorResponse.Parser, null, null, null, null, null),
            new(typeof(ConfigureIntercomAdaptorMetadata), ConfigureIntercomAdaptorMetadata.Parser, null, null, null, null, null),
            new(typeof(ResetIntercomAdaptorRequest), ResetIntercomAdaptorRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ResetIntercomAdaptorResponse), ResetIntercomAdaptorResponse.Parser, null, null, null, null, null),
            new(typeof(ResetIntercomAdaptorMetadata), ResetIntercomAdaptorMetadata.Parser, null, null, null, null, null),
            new(typeof(UpdateIntercomAdaptorFirmwareRequest), UpdateIntercomAdaptorFirmwareRequest.Parser, ["IntercomAdaptor"], null, null, null, null),
            new(typeof(UpdateIntercomAdaptorFirmwareResponse), UpdateIntercomAdaptorFirmwareResponse.Parser, null, null, null, null, null),
            new(typeof(UpdateIntercomAdaptorFirmwareMetadata), UpdateIntercomAdaptorFirmwareMetadata.Parser, ["ProgressPercent"], null, null, null, null),
            new(typeof(GenerateAuthorizationTokenRequest), GenerateAuthorizationTokenRequest.Parser, ["IntercomAdaptor"], null, null, null, null),
            new(typeof(GenerateAuthorizationTokenResponse), GenerateAuthorizationTokenResponse.Parser, ["AuthorizationToken"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriRequest), GenerateFirmwareDownloadUriRequest.Parser, ["IntercomAdaptor"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriResponse), GenerateFirmwareDownloadUriResponse.Parser, ["DownloadUri", "Digest"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriMetadata), GenerateFirmwareDownloadUriMetadata.Parser, null, null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// The intercom adaptor object
    /// </summary>
    public sealed partial class IntercomAdaptor : IMessage<IntercomAdaptor>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<IntercomAdaptor> _parser = new(() => new IntercomAdaptor());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<IntercomAdaptor> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public IntercomAdaptor()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public IntercomAdaptor(IntercomAdaptor other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            deviceId_ = other.deviceId_;
            accessPoints_ = other.accessPoints_.Clone();
            initialized_ = other.initialized_;
            deviceMetadata_ = other.deviceMetadata_?.Clone();
            outdated_ = other.outdated_;
            connected_ = other.connected_;
            lowBattery_ = other.lowBattery_;
            lastEventTime_ = other.lastEventTime_?.Clone();
            intercom_ = other.intercom_;
            photos_ = other.photos_.Clone();
            photoUris_ = other.photoUris_.Clone();
            readings_ = other.readings_.Clone();
            switch (other.ParentDeviceCase)
            {
                case ParentDeviceOneofCase.Gateway:
                    Gateway = other.Gateway;
                    break;
                case ParentDeviceOneofCase.Extender:
                    Extender = other.Extender;
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public IntercomAdaptor Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the intercom adaptor. It must have the format of
        /// `installations/*/intercom-adaptors/*`. For example:
        /// `installations/surelock-homes-hq/intercom-adaptors/dancing-men`.
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
        /// Display name of the intercom adaptor.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "device_id" field.</summary>
        public const int DeviceIdFieldNumber = 3;
        private readonly static string DeviceIdDefaultValue = "";

        private string deviceId_;

        /// <summary>
        /// Globally unique identifier that is used across all devices manufactured
        /// by SALTO, including gateways, extenders, intercom adaptors and so on.
        /// </summary>
        public string DeviceId
        {
            get { return deviceId_ ?? DeviceIdDefaultValue; }
            set
            {
                deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "device_id" field is set</summary>
        public bool HasDeviceId
        {
            get { return deviceId_ != null; }
        }

        /// <summary>Clears the value of the "device_id" field</summary>
        public void ClearDeviceId()
        {
            deviceId_ = null;
        }

        /// <summary>Field number for the "gateway" field.</summary>
        public const int GatewayFieldNumber = 4;

        /// <summary>
        /// Parent name, when intercom adaptor is connected to a gateway
        /// </summary>
        public string Gateway
        {
            get { return HasGateway ? (string)parentDevice_ : ""; }
            set
            {
                parentDevice_ = ProtoPreconditions.CheckNotNull(value, "value");
                parentDeviceCase_ = ParentDeviceOneofCase.Gateway;
            }
        }

        /// <summary>Gets whether the "gateway" field is set</summary>
        public bool HasGateway
        {
            get { return parentDeviceCase_ == ParentDeviceOneofCase.Gateway; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "gateway" </summary>
        public void ClearGateway()
        {
            if (HasGateway)
            {
                ClearParentDevice();
            }
        }

        /// <summary>Field number for the "extender" field.</summary>
        public const int ExtenderFieldNumber = 5;

        /// <summary>
        /// Parent name, when intercom adaptor is connected to an extender
        /// </summary>
        public string Extender
        {
            get { return HasExtender ? (string)parentDevice_ : ""; }
            set
            {
                parentDevice_ = ProtoPreconditions.CheckNotNull(value, "value");
                parentDeviceCase_ = ParentDeviceOneofCase.Extender;
            }
        }

        /// <summary>Gets whether the "extender" field is set</summary>
        public bool HasExtender
        {
            get { return parentDeviceCase_ == ParentDeviceOneofCase.Extender; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "extender" </summary>
        public void ClearExtender()
        {
            if (HasExtender)
            {
                ClearParentDevice();
            }
        }

        /// <summary>Field number for the "access_points" field.</summary>
        public const int AccessPointsFieldNumber = 6;
        private static readonly FieldCodec<IntercomAdaptorAccessPoint> _repeated_accessPoints_codec
            = FieldCodec.ForMessage(50, IntercomAdaptorAccessPoint.Parser);
        private readonly RepeatedField<IntercomAdaptorAccessPoint> accessPoints_ = [];

        /// <summary>
        /// The access points that the intercom adaptor gives coverage to.
        /// </summary>
        public RepeatedField<IntercomAdaptorAccessPoint> AccessPoints
        {
            get { return accessPoints_; }
        }

        /// <summary>Field number for the "initialized" field.</summary>
        public const int InitializedFieldNumber = 7;
        private bool initialized_;

        /// <summary>
        /// Indicates whether this intercom adaptor has been initialized or not. This
        /// field cannot be modified using a standard
        /// [`UpdateIntercomAdaptor`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.UpdateIntercomAdaptor]
        /// operation. To change the value of this field, you must call
        /// [`InitializeIntercomAdaptor`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.InitializeIntercomAdaptor].
        ///
        /// If the value is `false` also applies to the case where the
        /// initialization process has been initiated but where it has not finished.
        /// </summary>
        public bool Initialized
        {
            get { return initialized_; }
            set
            {
                initialized_ = value;
            }
        }

        /// <summary>Field number for the "device_metadata" field.</summary>
        public const int DeviceMetadataFieldNumber = 16;
        private Type.DeviceMetadata deviceMetadata_;

        /// <summary>
        /// Device metadata contains information about a device hardware and firmware.
        /// </summary>
        public Type.DeviceMetadata DeviceMetadata
        {
            get { return deviceMetadata_; }
            set
            {
                deviceMetadata_ = value;
            }
        }

        /// <summary>Field number for the "outdated" field.</summary>
        public const int OutdatedFieldNumber = 8;
        private bool outdated_;

        /// <summary>
        /// Indicates whether this intercom adaptor has pending updates or not. This
        /// could be because there was a pending configuration or a firmware update
        /// and is conditionally set based on the current installation settings.
        /// </summary>
        public bool Outdated
        {
            get { return outdated_; }
            set
            {
                outdated_ = value;
            }
        }

        /// <summary>Field number for the "connected" field.</summary>
        public const int ConnectedFieldNumber = 9;
        private bool connected_;

        /// <summary>
        /// Indicates whether this intercom adaptor is connected or not. It's
        /// considered connected if there has been at least one communication with it
        /// within the last 10 minutes.
        /// </summary>
        public bool Connected
        {
            get { return connected_; }
            set
            {
                connected_ = value;
            }
        }

        /// <summary>Field number for the "low_battery" field.</summary>
        public const int LowBatteryFieldNumber = 10;
        private bool lowBattery_;

        /// <summary>
        /// Indicates whether the battery of this intercom adaptor is low, and needs
        /// replacing, or is normal and doesn't need replacing.
        /// </summary>
        public bool LowBattery
        {
            get { return lowBattery_; }
            set
            {
                lowBattery_ = value;
            }
        }

        /// <summary>Field number for the "last_event_time" field.</summary>
        public const int LastEventTimeFieldNumber = 11;
        private Google.Protobuf.WellKnownTypes.Timestamp lastEventTime_;

        /// <summary>
        /// The last time an event was received.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp LastEventTime
        {
            get { return lastEventTime_; }
            set
            {
                lastEventTime_ = value;
            }
        }

        /// <summary>Field number for the "intercom" field.</summary>
        public const int IntercomFieldNumber = 12;
        private readonly static string IntercomDefaultValue = "";

        private string intercom_;

        /// <summary>
        /// Reference to intercom system model it is connected to. It will be used to
        /// know which parametrization to apply when configuring it.
        /// </summary>
        public string Intercom
        {
            get { return intercom_ ?? IntercomDefaultValue; }
            set
            {
                intercom_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "intercom" field is set</summary>
        public bool HasIntercom
        {
            get { return intercom_ != null; }
        }

        /// <summary>Clears the value of the "intercom" field</summary>
        public void ClearIntercom()
        {
            intercom_ = null;
        }

        /// <summary>Field number for the "photos" field.</summary>
        public const int PhotosFieldNumber = 13;
        private static readonly FieldCodec<string> _repeated_photos_codec
            = FieldCodec.ForString(106);
        private readonly RepeatedField<string> photos_ = [];

        /// <summary>
        /// The file resource names for the intercom adaptor photos. It must have the
        /// format of
        /// `installations/surelock-homes-hq/files/01DSYSJ1PR36VVC3MRFRV4DC7G`.
        /// </summary>
        public RepeatedField<string> Photos
        {
            get { return photos_; }
        }

        /// <summary>Field number for the "photo_uris" field.</summary>
        public const int PhotoUrisFieldNumber = 14;
        private static readonly FieldCodec<string> _repeated_photoUris_codec
            = FieldCodec.ForString(114);
        private readonly RepeatedField<string> photoUris_ = [];

        /// <summary>
        /// The URIs to view the intercom adaptor photos.
        /// </summary>
        public RepeatedField<string> PhotoUris
        {
            get { return photoUris_; }
        }

        /// <summary>Field number for the "readings" field.</summary>
        public const int ReadingsFieldNumber = 15;
        private static readonly FieldCodec<string> _repeated_readings_codec
            = FieldCodec.ForString(122);
        private readonly RepeatedField<string> readings_ = [];

        /// <summary>
        /// The file resource names for intercom adaptor readings retrieved from the device's bus.
        /// It comes into play when the learning process encounters unexpected issues, prompting expert
        /// analysis of the readings. It must have the
        /// format of
        /// `installations/surelock-homes-hq/files/01DSYSJ1PR36VVC3MRFRV4DC7G`.
        /// </summary>
        public RepeatedField<string> Readings
        {
            get { return readings_; }
        }

        private object parentDevice_;

        /// <summary>Enum of possible cases for the "parent_device" oneof.</summary>
        public enum ParentDeviceOneofCase
        {
            None = 0,
            Gateway = 4,
            Extender = 5,
        }

        private ParentDeviceOneofCase parentDeviceCase_ = ParentDeviceOneofCase.None;

        public ParentDeviceOneofCase ParentDeviceCase
        {
            get { return parentDeviceCase_; }
        }

        public void ClearParentDevice()
        {
            parentDeviceCase_ = ParentDeviceOneofCase.None;
            parentDevice_ = null;
        }

        public override bool Equals(object other) => Equals(other as IntercomAdaptor);
        public bool Equals(IntercomAdaptor other)
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
            if (DeviceId != other.DeviceId) return false;
            if (Gateway != other.Gateway) return false;
            if (Extender != other.Extender) return false;
            if (!accessPoints_.Equals(other.accessPoints_)) return false;
            if (Initialized != other.Initialized) return false;
            if (!Equals(DeviceMetadata, other.DeviceMetadata)) return false;
            if (Outdated != other.Outdated) return false;
            if (Connected != other.Connected) return false;
            if (LowBattery != other.LowBattery) return false;
            if (!Equals(LastEventTime, other.LastEventTime)) return false;
            if (Intercom != other.Intercom) return false;
            if (!photos_.Equals(other.photos_)) return false;
            if (!photoUris_.Equals(other.photoUris_)) return false;
            if (!readings_.Equals(other.readings_)) return false;
            if (ParentDeviceCase != other.ParentDeviceCase) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            if (HasDeviceId) hash ^= DeviceId.GetHashCode();
            if (HasGateway) hash ^= Gateway.GetHashCode();
            if (HasExtender) hash ^= Extender.GetHashCode();
            hash ^= accessPoints_.GetHashCode();
            if (Initialized != false) hash ^= Initialized.GetHashCode();
            if (deviceMetadata_ != null) hash ^= DeviceMetadata.GetHashCode();
            if (Outdated != false) hash ^= Outdated.GetHashCode();
            if (Connected != false) hash ^= Connected.GetHashCode();
            if (LowBattery != false) hash ^= LowBattery.GetHashCode();
            if (lastEventTime_ != null) hash ^= LastEventTime.GetHashCode();
            if (HasIntercom) hash ^= Intercom.GetHashCode();
            hash ^= photos_.GetHashCode();
            hash ^= photoUris_.GetHashCode();
            hash ^= readings_.GetHashCode();
            hash ^= (int)parentDeviceCase_;
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
      if (HasDeviceId) {
        output.WriteRawTag(26);
        output.WriteString(DeviceId);
      }
      if (HasGateway) {
        output.WriteRawTag(34);
        output.WriteString(Gateway);
      }
      if (HasExtender) {
        output.WriteRawTag(42);
        output.WriteString(Extender);
      }
      accessPoints_.WriteTo(output, _repeated_accessPoints_codec);
      if (Initialized != false) {
        output.WriteRawTag(56);
        output.WriteBool(Initialized);
      }
      if (Outdated != false) {
        output.WriteRawTag(64);
        output.WriteBool(Outdated);
      }
      if (Connected != false) {
        output.WriteRawTag(72);
        output.WriteBool(Connected);
      }
      if (LowBattery != false) {
        output.WriteRawTag(80);
        output.WriteBool(LowBattery);
      }
      if (lastEventTime_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(LastEventTime);
      }
      if (HasIntercom) {
        output.WriteRawTag(98);
        output.WriteString(Intercom);
      }
      photos_.WriteTo(output, _repeated_photos_codec);
      photoUris_.WriteTo(output, _repeated_photoUris_codec);
      readings_.WriteTo(output, _repeated_readings_codec);
      if (deviceMetadata_ != null) {
        output.WriteRawTag(130, 1);
        output.WriteMessage(DeviceMetadata);
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
            if (HasDeviceId)
            {
                output.WriteRawTag(26);
                output.WriteString(DeviceId);
            }
            if (HasGateway)
            {
                output.WriteRawTag(34);
                output.WriteString(Gateway);
            }
            if (HasExtender)
            {
                output.WriteRawTag(42);
                output.WriteString(Extender);
            }
            accessPoints_.WriteTo(ref output, _repeated_accessPoints_codec);
            if (Initialized != false)
            {
                output.WriteRawTag(56);
                output.WriteBool(Initialized);
            }
            if (Outdated != false)
            {
                output.WriteRawTag(64);
                output.WriteBool(Outdated);
            }
            if (Connected != false)
            {
                output.WriteRawTag(72);
                output.WriteBool(Connected);
            }
            if (LowBattery != false)
            {
                output.WriteRawTag(80);
                output.WriteBool(LowBattery);
            }
            if (lastEventTime_ != null)
            {
                output.WriteRawTag(90);
                output.WriteMessage(LastEventTime);
            }
            if (HasIntercom)
            {
                output.WriteRawTag(98);
                output.WriteString(Intercom);
            }
            photos_.WriteTo(ref output, _repeated_photos_codec);
            photoUris_.WriteTo(ref output, _repeated_photoUris_codec);
            readings_.WriteTo(ref output, _repeated_readings_codec);
            if (deviceMetadata_ != null)
            {
                output.WriteRawTag(130, 1);
                output.WriteMessage(DeviceMetadata);
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
            if (HasDeviceId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
            }
            if (HasGateway)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Gateway);
            }
            if (HasExtender)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Extender);
            }
            size += accessPoints_.CalculateSize(_repeated_accessPoints_codec);
            if (Initialized != false)
            {
                size += 1 + 1;
            }
            if (deviceMetadata_ != null)
            {
                size += 2 + CodedOutputStream.ComputeMessageSize(DeviceMetadata);
            }
            if (Outdated != false)
            {
                size += 1 + 1;
            }
            if (Connected != false)
            {
                size += 1 + 1;
            }
            if (LowBattery != false)
            {
                size += 1 + 1;
            }
            if (lastEventTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(LastEventTime);
            }
            if (HasIntercom)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Intercom);
            }
            size += photos_.CalculateSize(_repeated_photos_codec);
            size += photoUris_.CalculateSize(_repeated_photoUris_codec);
            size += readings_.CalculateSize(_repeated_readings_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(IntercomAdaptor other)
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
            if (other.HasDeviceId)
            {
                DeviceId = other.DeviceId;
            }
            accessPoints_.Add(other.accessPoints_);
            if (other.Initialized != false)
            {
                Initialized = other.Initialized;
            }
            if (other.deviceMetadata_ != null)
            {
                if (deviceMetadata_ == null)
                {
                    DeviceMetadata = new Type.DeviceMetadata();
                }
                DeviceMetadata.MergeFrom(other.DeviceMetadata);
            }
            if (other.Outdated != false)
            {
                Outdated = other.Outdated;
            }
            if (other.Connected != false)
            {
                Connected = other.Connected;
            }
            if (other.LowBattery != false)
            {
                LowBattery = other.LowBattery;
            }
            if (other.lastEventTime_ != null)
            {
                if (lastEventTime_ == null)
                {
                    LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                LastEventTime.MergeFrom(other.LastEventTime);
            }
            if (other.HasIntercom)
            {
                Intercom = other.Intercom;
            }
            photos_.Add(other.photos_);
            photoUris_.Add(other.photoUris_);
            readings_.Add(other.readings_);
            switch (other.ParentDeviceCase)
            {
                case ParentDeviceOneofCase.Gateway:
                    Gateway = other.Gateway;
                    break;
                case ParentDeviceOneofCase.Extender:
                    Extender = other.Extender;
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
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            DeviceId = input.ReadString();
            break;
          }
          case 34: {
            Gateway = input.ReadString();
            break;
          }
          case 42: {
            Extender = input.ReadString();
            break;
          }
          case 50: {
            accessPoints_.AddEntriesFrom(input, _repeated_accessPoints_codec);
            break;
          }
          case 56: {
            Initialized = input.ReadBool();
            break;
          }
          case 64: {
            Outdated = input.ReadBool();
            break;
          }
          case 72: {
            Connected = input.ReadBool();
            break;
          }
          case 80: {
            LowBattery = input.ReadBool();
            break;
          }
          case 90: {
            if (lastEventTime_ == null) {
              LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastEventTime);
            break;
          }
          case 98: {
            Intercom = input.ReadString();
            break;
          }
          case 106: {
            photos_.AddEntriesFrom(input, _repeated_photos_codec);
            break;
          }
          case 114: {
            photoUris_.AddEntriesFrom(input, _repeated_photoUris_codec);
            break;
          }
          case 122: {
            readings_.AddEntriesFrom(input, _repeated_readings_codec);
            break;
          }
          case 130: {
            if (deviceMetadata_ == null) {
              DeviceMetadata = new Saltoapis.Nebula.Type.DeviceMetadata();
            }
            input.ReadMessage(DeviceMetadata);
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
                    case 26:
                        {
                            DeviceId = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            Gateway = input.ReadString();
                            break;
                        }
                    case 42:
                        {
                            Extender = input.ReadString();
                            break;
                        }
                    case 50:
                        {
                            accessPoints_.AddEntriesFrom(ref input, _repeated_accessPoints_codec);
                            break;
                        }
                    case 56:
                        {
                            Initialized = input.ReadBool();
                            break;
                        }
                    case 64:
                        {
                            Outdated = input.ReadBool();
                            break;
                        }
                    case 72:
                        {
                            Connected = input.ReadBool();
                            break;
                        }
                    case 80:
                        {
                            LowBattery = input.ReadBool();
                            break;
                        }
                    case 90:
                        {
                            if (lastEventTime_ == null)
                            {
                                LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(LastEventTime);
                            break;
                        }
                    case 98:
                        {
                            Intercom = input.ReadString();
                            break;
                        }
                    case 106:
                        {
                            photos_.AddEntriesFrom(ref input, _repeated_photos_codec);
                            break;
                        }
                    case 114:
                        {
                            photoUris_.AddEntriesFrom(ref input, _repeated_photoUris_codec);
                            break;
                        }
                    case 122:
                        {
                            readings_.AddEntriesFrom(ref input, _repeated_readings_codec);
                            break;
                        }
                    case 130:
                        {
                            if (deviceMetadata_ == null)
                            {
                                DeviceMetadata = new Type.DeviceMetadata();
                            }
                            input.ReadMessage(DeviceMetadata);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The intercom adaptor's access point association
    /// </summary>
    public sealed partial class IntercomAdaptorAccessPoint : IMessage<IntercomAdaptorAccessPoint>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<IntercomAdaptorAccessPoint> _parser = new(() => new IntercomAdaptorAccessPoint());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<IntercomAdaptorAccessPoint> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public IntercomAdaptorAccessPoint()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public IntercomAdaptorAccessPoint(IntercomAdaptorAccessPoint other) : this()
        {
            accessPoint_ = other.accessPoint_;
            frameSettings_ = other.frameSettings_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public IntercomAdaptorAccessPoint Clone() => new(this);
        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 1;
        private string accessPoint_ = "";

        /// <summary>
        /// The access point resource name to bind as an association to the parent
        /// intercom adaptor. For example:
        /// `installations/surelock-homes-hq/access-points/baker-street-entrance`.
        /// </summary>
        public string AccessPoint
        {
            get { return accessPoint_; }
            set
            {
                accessPoint_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "frame_settings" field.</summary>
        public const int FrameSettingsFieldNumber = 2;
        private readonly static ByteString FrameSettingsDefaultValue = ByteString.Empty;

        private ByteString frameSettings_;

        /// <summary>
        /// The set of learnt frames. Left unset for analog intercoms.
        /// </summary>
        public ByteString FrameSettings
        {
            get { return frameSettings_ ?? FrameSettingsDefaultValue; }
            set
            {
                frameSettings_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "frame_settings" field is set</summary>
        public bool HasFrameSettings
        {
            get { return frameSettings_ != null; }
        }

        /// <summary>Clears the value of the "frame_settings" field</summary>
        public void ClearFrameSettings()
        {
            frameSettings_ = null;
        }

        public override bool Equals(object other) => Equals(other as IntercomAdaptorAccessPoint);
        public bool Equals(IntercomAdaptorAccessPoint other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (AccessPoint != other.AccessPoint) return false;
            if (FrameSettings != other.FrameSettings) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (AccessPoint.Length != 0) hash ^= AccessPoint.GetHashCode();
            if (HasFrameSettings) hash ^= FrameSettings.GetHashCode();
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
      if (AccessPoint.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AccessPoint);
      }
      if (HasFrameSettings) {
        output.WriteRawTag(18);
        output.WriteBytes(FrameSettings);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (AccessPoint.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(AccessPoint);
            }
            if (HasFrameSettings)
            {
                output.WriteRawTag(18);
                output.WriteBytes(FrameSettings);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (AccessPoint.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(AccessPoint);
            }
            if (HasFrameSettings)
            {
                size += 1 + CodedOutputStream.ComputeBytesSize(FrameSettings);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(IntercomAdaptorAccessPoint other)
        {
            if (other == null)
            {
                return;
            }
            if (other.AccessPoint.Length != 0)
            {
                AccessPoint = other.AccessPoint;
            }
            if (other.HasFrameSettings)
            {
                FrameSettings = other.FrameSettings;
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
            AccessPoint = input.ReadString();
            break;
          }
          case 18: {
            FrameSettings = input.ReadBytes();
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
                            AccessPoint = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            FrameSettings = input.ReadBytes();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [CreateIntercomAdaptor][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.CreateIntercomAdaptor]
    /// </summary>
    public sealed partial class CreateIntercomAdaptorRequest : IMessage<CreateIntercomAdaptorRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateIntercomAdaptorRequest> _parser = new(() => new CreateIntercomAdaptorRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateIntercomAdaptorRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateIntercomAdaptorRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateIntercomAdaptorRequest(CreateIntercomAdaptorRequest other) : this()
        {
            parent_ = other.parent_;
            intercomAdaptorId_ = other.intercomAdaptorId_;
            intercomAdaptor_ = other.intercomAdaptor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateIntercomAdaptorRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where to create the intercom adaptor. For
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

        /// <summary>Field number for the "intercom_adaptor_id" field.</summary>
        public const int IntercomAdaptorIdFieldNumber = 2;
        private readonly static string IntercomAdaptorIdDefaultValue = "";

        private string intercomAdaptorId_;

        /// <summary>
        /// The intercom adaptor ID to use for this intercom adaptor. In case it's empty the
        /// server will autogenerate a unique identifier.
        /// </summary>
        public string IntercomAdaptorId
        {
            get { return intercomAdaptorId_ ?? IntercomAdaptorIdDefaultValue; }
            set
            {
                intercomAdaptorId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "intercom_adaptor_id" field is set</summary>
        public bool HasIntercomAdaptorId
        {
            get { return intercomAdaptorId_ != null; }
        }

        /// <summary>Clears the value of the "intercom_adaptor_id" field</summary>
        public void ClearIntercomAdaptorId()
        {
            intercomAdaptorId_ = null;
        }

        /// <summary>Field number for the "intercom_adaptor" field.</summary>
        public const int IntercomAdaptorFieldNumber = 3;
        private IntercomAdaptor intercomAdaptor_;

        /// <summary>
        /// The intercom adaptor resource to be created. Client must not set the
        /// `IntercomAdaptor.name` field.
        /// </summary>
        public IntercomAdaptor IntercomAdaptor
        {
            get { return intercomAdaptor_; }
            set
            {
                intercomAdaptor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateIntercomAdaptorRequest);
        public bool Equals(CreateIntercomAdaptorRequest other)
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
            if (IntercomAdaptorId != other.IntercomAdaptorId) return false;
            if (!Equals(IntercomAdaptor, other.IntercomAdaptor)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasIntercomAdaptorId) hash ^= IntercomAdaptorId.GetHashCode();
            if (intercomAdaptor_ != null) hash ^= IntercomAdaptor.GetHashCode();
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
      if (HasIntercomAdaptorId) {
        output.WriteRawTag(18);
        output.WriteString(IntercomAdaptorId);
      }
      if (intercomAdaptor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(IntercomAdaptor);
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
            if (HasIntercomAdaptorId)
            {
                output.WriteRawTag(18);
                output.WriteString(IntercomAdaptorId);
            }
            if (intercomAdaptor_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(IntercomAdaptor);
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
            if (HasIntercomAdaptorId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(IntercomAdaptorId);
            }
            if (intercomAdaptor_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(IntercomAdaptor);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateIntercomAdaptorRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.HasIntercomAdaptorId)
            {
                IntercomAdaptorId = other.IntercomAdaptorId;
            }
            if (other.intercomAdaptor_ != null)
            {
                if (intercomAdaptor_ == null)
                {
                    IntercomAdaptor = new IntercomAdaptor();
                }
                IntercomAdaptor.MergeFrom(other.IntercomAdaptor);
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
            IntercomAdaptorId = input.ReadString();
            break;
          }
          case 26: {
            if (intercomAdaptor_ == null) {
              IntercomAdaptor = new Saltoapis.Nebula.IntercomAdaptor.V1.IntercomAdaptor();
            }
            input.ReadMessage(IntercomAdaptor);
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
                            IntercomAdaptorId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (intercomAdaptor_ == null)
                            {
                                IntercomAdaptor = new IntercomAdaptor();
                            }
                            input.ReadMessage(IntercomAdaptor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [GetIntercomAdaptor][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.GetIntercomAdaptor]
    /// </summary>
    public sealed partial class GetIntercomAdaptorRequest : IMessage<GetIntercomAdaptorRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetIntercomAdaptorRequest> _parser = new(() => new GetIntercomAdaptorRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetIntercomAdaptorRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetIntercomAdaptorRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetIntercomAdaptorRequest(GetIntercomAdaptorRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetIntercomAdaptorRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested intercom adaptor resource. For example:
        /// `installations/surelock-homes-hq/intercom-adaptors/dancing-men`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetIntercomAdaptorRequest);
        public bool Equals(GetIntercomAdaptorRequest other)
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

        public void MergeFrom(GetIntercomAdaptorRequest other)
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
    /// The request message for [ListIntercomAdaptors][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.ListIntercomAdaptor]
    /// </summary>
    public sealed partial class ListIntercomAdaptorsRequest : IMessage<ListIntercomAdaptorsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListIntercomAdaptorsRequest> _parser = new(() => new ListIntercomAdaptorsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListIntercomAdaptorsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListIntercomAdaptorsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListIntercomAdaptorsRequest(ListIntercomAdaptorsRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListIntercomAdaptorsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name. For example, `installations/surelock-homes-hq`.
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
        /// A filter that chooses which intercom adaptors to return.
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

        public override bool Equals(object other) => Equals(other as ListIntercomAdaptorsRequest);
        public bool Equals(ListIntercomAdaptorsRequest other)
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

        public void MergeFrom(ListIntercomAdaptorsRequest other)
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
    /// The response message for [ListIntercomAdaptors][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.ListIntercomAdaptors]
    /// </summary>
    public sealed partial class ListIntercomAdaptorsResponse : IMessage<ListIntercomAdaptorsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListIntercomAdaptorsResponse> _parser = new(() => new ListIntercomAdaptorsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListIntercomAdaptorsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListIntercomAdaptorsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListIntercomAdaptorsResponse(ListIntercomAdaptorsResponse other) : this()
        {
            intercomAdaptors_ = other.intercomAdaptors_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListIntercomAdaptorsResponse Clone() => new(this);
        /// <summary>Field number for the "intercom_adaptors" field.</summary>
        public const int IntercomAdaptorsFieldNumber = 1;
        private static readonly FieldCodec<IntercomAdaptor> _repeated_intercomAdaptors_codec
            = FieldCodec.ForMessage(10, IntercomAdaptor.Parser);
        private readonly RepeatedField<IntercomAdaptor> intercomAdaptors_ = [];

        /// <summary>
        /// The field name should match the noun `intercom_adaptors` in the method name. There
        /// will be a maximum number of items returned based on the `page_size` field
        /// in the request.
        /// </summary>
        public RepeatedField<IntercomAdaptor> IntercomAdaptors
        {
            get { return intercomAdaptors_; }
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

        public override bool Equals(object other) => Equals(other as ListIntercomAdaptorsResponse);
        public bool Equals(ListIntercomAdaptorsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!intercomAdaptors_.Equals(other.intercomAdaptors_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= intercomAdaptors_.GetHashCode();
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
      intercomAdaptors_.WriteTo(output, _repeated_intercomAdaptors_codec);
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
            intercomAdaptors_.WriteTo(ref output, _repeated_intercomAdaptors_codec);
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
            size += intercomAdaptors_.CalculateSize(_repeated_intercomAdaptors_codec);
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

        public void MergeFrom(ListIntercomAdaptorsResponse other)
        {
            if (other == null)
            {
                return;
            }
            intercomAdaptors_.Add(other.intercomAdaptors_);
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
            intercomAdaptors_.AddEntriesFrom(input, _repeated_intercomAdaptors_codec);
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
                            intercomAdaptors_.AddEntriesFrom(ref input, _repeated_intercomAdaptors_codec);
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
    /// The request message for [UpdateIntercomAdaptor][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.UpdateIntercomAdaptor]
    /// </summary>
    public sealed partial class UpdateIntercomAdaptorRequest : IMessage<UpdateIntercomAdaptorRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateIntercomAdaptorRequest> _parser = new(() => new UpdateIntercomAdaptorRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateIntercomAdaptorRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateIntercomAdaptorRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateIntercomAdaptorRequest(UpdateIntercomAdaptorRequest other) : this()
        {
            intercomAdaptor_ = other.intercomAdaptor_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateIntercomAdaptorRequest Clone() => new(this);
        /// <summary>Field number for the "intercom_adaptor" field.</summary>
        public const int IntercomAdaptorFieldNumber = 1;
        private IntercomAdaptor intercomAdaptor_;

        /// <summary>
        /// The intercom adaptor resource which replaces the resource on the server.
        /// </summary>
        public IntercomAdaptor IntercomAdaptor
        {
            get { return intercomAdaptor_; }
            set
            {
                intercomAdaptor_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateIntercomAdaptorRequest);
        public bool Equals(UpdateIntercomAdaptorRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(IntercomAdaptor, other.IntercomAdaptor)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (intercomAdaptor_ != null) hash ^= IntercomAdaptor.GetHashCode();
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
      if (intercomAdaptor_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(IntercomAdaptor);
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
            if (intercomAdaptor_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(IntercomAdaptor);
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
            if (intercomAdaptor_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(IntercomAdaptor);
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

        public void MergeFrom(UpdateIntercomAdaptorRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.intercomAdaptor_ != null)
            {
                if (intercomAdaptor_ == null)
                {
                    IntercomAdaptor = new IntercomAdaptor();
                }
                IntercomAdaptor.MergeFrom(other.IntercomAdaptor);
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
            if (intercomAdaptor_ == null) {
              IntercomAdaptor = new Saltoapis.Nebula.IntercomAdaptor.V1.IntercomAdaptor();
            }
            input.ReadMessage(IntercomAdaptor);
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
                            if (intercomAdaptor_ == null)
                            {
                                IntercomAdaptor = new IntercomAdaptor();
                            }
                            input.ReadMessage(IntercomAdaptor);
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
    /// The request message for [DeleteIntercomAdaptor][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.DeleteIntercomAdaptor]
    /// </summary>
    public sealed partial class DeleteIntercomAdaptorRequest : IMessage<DeleteIntercomAdaptorRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteIntercomAdaptorRequest> _parser = new(() => new DeleteIntercomAdaptorRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteIntercomAdaptorRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteIntercomAdaptorRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteIntercomAdaptorRequest(DeleteIntercomAdaptorRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteIntercomAdaptorRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the intercom adaptor to be deleted. For example:
        /// `installations/surelock-homes-hq/intercom-adaptors/dancing-men`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteIntercomAdaptorRequest);
        public bool Equals(DeleteIntercomAdaptorRequest other)
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

        public void MergeFrom(DeleteIntercomAdaptorRequest other)
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
    /// The request message for [`BindIntercomAdaptor`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.BindIntercomAdaptor]
    /// </summary>
    public sealed partial class BindIntercomAdaptorRequest : IMessage<BindIntercomAdaptorRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BindIntercomAdaptorRequest> _parser = new(() => new BindIntercomAdaptorRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BindIntercomAdaptorRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BindIntercomAdaptorRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BindIntercomAdaptorRequest(BindIntercomAdaptorRequest other) : this()
        {
            name_ = other.name_;
            deviceId_ = other.deviceId_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BindIntercomAdaptorRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the intercom adaptor to be bound. For example:
        /// `installations/surelock-homes-hq/intercom-adaptors/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "device_id" field.</summary>
        public const int DeviceIdFieldNumber = 2;
        private string deviceId_ = "";

        /// <summary>
        /// Globally unique identifier that is used across all devices manufactured
        /// by SALTO, including gateways, extenders, intercom adaptors and so on.
        /// </summary>
        public string DeviceId
        {
            get { return deviceId_; }
            set
            {
                deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as BindIntercomAdaptorRequest);
        public bool Equals(BindIntercomAdaptorRequest other)
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
            if (DeviceId != other.DeviceId) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DeviceId.Length != 0) hash ^= DeviceId.GetHashCode();
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
      if (DeviceId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DeviceId);
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
            if (DeviceId.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(DeviceId);
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
            if (DeviceId.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BindIntercomAdaptorRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.DeviceId.Length != 0)
            {
                DeviceId = other.DeviceId;
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
            DeviceId = input.ReadString();
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
                            DeviceId = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The empty response message for [`BindIntercomAdaptor`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.BindIntercomAdaptor]
    /// </summary>
    public sealed partial class BindIntercomAdaptorResponse : IMessage<BindIntercomAdaptorResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BindIntercomAdaptorResponse> _parser = new(() => new BindIntercomAdaptorResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BindIntercomAdaptorResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[9]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BindIntercomAdaptorResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BindIntercomAdaptorResponse(BindIntercomAdaptorResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BindIntercomAdaptorResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as BindIntercomAdaptorResponse);
        public bool Equals(BindIntercomAdaptorResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BindIntercomAdaptorResponse other)
        {
            if (other == null)
            {
                return;
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`UnbindIntercomAdaptor`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.UnbindIntercomAdaptor]
    /// </summary>
    public sealed partial class UnbindIntercomAdaptorRequest : IMessage<UnbindIntercomAdaptorRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnbindIntercomAdaptorRequest> _parser = new(() => new UnbindIntercomAdaptorRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnbindIntercomAdaptorRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnbindIntercomAdaptorRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnbindIntercomAdaptorRequest(UnbindIntercomAdaptorRequest other) : this()
        {
            name_ = other.name_;
            force_ = other.force_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnbindIntercomAdaptorRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the intercom adaptor to be bound. For example:
        /// `installations/surelock-homes-hq/intercom-adaptors/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "force" field.</summary>
        public const int ForceFieldNumber = 2;
        private bool force_;

        /// <summary>
        /// If set to true, the device identifier is removed (unbound) from the
        /// intercom adaptor. Otherwise, the request will only work if the intercom
        /// adaptor isn't bound to any previous device identifier.
        /// </summary>
        public bool Force
        {
            get { return force_; }
            set
            {
                force_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UnbindIntercomAdaptorRequest);
        public bool Equals(UnbindIntercomAdaptorRequest other)
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
            if (Force != other.Force) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (Force != false) hash ^= Force.GetHashCode();
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
      if (Force != false) {
        output.WriteRawTag(16);
        output.WriteBool(Force);
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
            if (Force != false)
            {
                output.WriteRawTag(16);
                output.WriteBool(Force);
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
            if (Force != false)
            {
                size += 1 + 1;
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UnbindIntercomAdaptorRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.Force != false)
            {
                Force = other.Force;
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
          case 16: {
            Force = input.ReadBool();
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
                    case 16:
                        {
                            Force = input.ReadBool();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The empty response message for [`UnbindIntercomAdaptor`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.UnbindIntercomAdaptor]
    /// </summary>
    public sealed partial class UnbindIntercomAdaptorResponse : IMessage<UnbindIntercomAdaptorResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnbindIntercomAdaptorResponse> _parser = new(() => new UnbindIntercomAdaptorResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnbindIntercomAdaptorResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[11]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnbindIntercomAdaptorResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnbindIntercomAdaptorResponse(UnbindIntercomAdaptorResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnbindIntercomAdaptorResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as UnbindIntercomAdaptorResponse);
        public bool Equals(UnbindIntercomAdaptorResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UnbindIntercomAdaptorResponse other)
        {
            if (other == null)
            {
                return;
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`InitializeIntercomAdaptor`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.InitializeIntercomAdaptor]
    /// </summary>
    public sealed partial class InitializeIntercomAdaptorRequest : IMessage<InitializeIntercomAdaptorRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeIntercomAdaptorRequest> _parser = new(() => new InitializeIntercomAdaptorRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeIntercomAdaptorRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[12]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeIntercomAdaptorRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeIntercomAdaptorRequest(InitializeIntercomAdaptorRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeIntercomAdaptorRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the intercom adaptor to be initialized. For example:
        /// `installations/surelock-homes-hq/intercom-adaptors/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as InitializeIntercomAdaptorRequest);
        public bool Equals(InitializeIntercomAdaptorRequest other)
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

        public void MergeFrom(InitializeIntercomAdaptorRequest other)
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
    /// The empty response message for [`InitializeIntercomAdaptor`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.InitializeIntercomAdaptor]
    /// </summary>
    public sealed partial class InitializeIntercomAdaptorResponse : IMessage<InitializeIntercomAdaptorResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeIntercomAdaptorResponse> _parser = new(() => new InitializeIntercomAdaptorResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeIntercomAdaptorResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeIntercomAdaptorResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeIntercomAdaptorResponse(InitializeIntercomAdaptorResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeIntercomAdaptorResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as InitializeIntercomAdaptorResponse);
        public bool Equals(InitializeIntercomAdaptorResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(InitializeIntercomAdaptorResponse other)
        {
            if (other == null)
            {
                return;
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
                }
            }
        }
#endif

    }

    public sealed partial class InitializeIntercomAdaptorMetadata : IMessage<InitializeIntercomAdaptorMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeIntercomAdaptorMetadata> _parser = new(() => new InitializeIntercomAdaptorMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeIntercomAdaptorMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[14]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeIntercomAdaptorMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeIntercomAdaptorMetadata(InitializeIntercomAdaptorMetadata other) : this()
        {
            progressPercent_ = other.progressPercent_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeIntercomAdaptorMetadata Clone() => new(this);
        /// <summary>Field number for the "progress_percent" field.</summary>
        public const int ProgressPercentFieldNumber = 1;
        private int progressPercent_;

        /// <summary>
        /// Progress of operation. Range: [0, 100].
        /// </summary>
        public int ProgressPercent
        {
            get { return progressPercent_; }
            set
            {
                progressPercent_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as InitializeIntercomAdaptorMetadata);
        public bool Equals(InitializeIntercomAdaptorMetadata other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (ProgressPercent != other.ProgressPercent) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (ProgressPercent != 0) hash ^= ProgressPercent.GetHashCode();
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
      if (ProgressPercent != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ProgressPercent);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (ProgressPercent != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(ProgressPercent);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (ProgressPercent != 0)
            {
                size += 1 + CodedOutputStream.ComputeInt32Size(ProgressPercent);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(InitializeIntercomAdaptorMetadata other)
        {
            if (other == null)
            {
                return;
            }
            if (other.ProgressPercent != 0)
            {
                ProgressPercent = other.ProgressPercent;
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
            ProgressPercent = input.ReadInt32();
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
                            ProgressPercent = input.ReadInt32();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`ConfigureIntercomAdaptor`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.ConfigureIntercomAdaptor]
    /// </summary>
    public sealed partial class ConfigureIntercomAdaptorRequest : IMessage<ConfigureIntercomAdaptorRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureIntercomAdaptorRequest> _parser = new(() => new ConfigureIntercomAdaptorRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureIntercomAdaptorRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[15]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureIntercomAdaptorRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureIntercomAdaptorRequest(ConfigureIntercomAdaptorRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureIntercomAdaptorRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the intercom adaptor to be configured. For example:
        /// `installations/surelock-homes-hq/intercom-adaptors/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ConfigureIntercomAdaptorRequest);
        public bool Equals(ConfigureIntercomAdaptorRequest other)
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

        public void MergeFrom(ConfigureIntercomAdaptorRequest other)
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
    /// The empty response message for [`ConfigureIntercomAdaptor`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.ConfigureIntercomAdaptor]
    /// </summary>
    public sealed partial class ConfigureIntercomAdaptorResponse : IMessage<ConfigureIntercomAdaptorResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureIntercomAdaptorResponse> _parser = new(() => new ConfigureIntercomAdaptorResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureIntercomAdaptorResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[16]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureIntercomAdaptorResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureIntercomAdaptorResponse(ConfigureIntercomAdaptorResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureIntercomAdaptorResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ConfigureIntercomAdaptorResponse);
        public bool Equals(ConfigureIntercomAdaptorResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ConfigureIntercomAdaptorResponse other)
        {
            if (other == null)
            {
                return;
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The metadata message for [`ConfigureIntercomAdaptor`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.ConfigureIntercomAdaptor]
    /// </summary>
    public sealed partial class ConfigureIntercomAdaptorMetadata : IMessage<ConfigureIntercomAdaptorMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureIntercomAdaptorMetadata> _parser = new(() => new ConfigureIntercomAdaptorMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureIntercomAdaptorMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[17]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureIntercomAdaptorMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureIntercomAdaptorMetadata(ConfigureIntercomAdaptorMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureIntercomAdaptorMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ConfigureIntercomAdaptorMetadata);
        public bool Equals(ConfigureIntercomAdaptorMetadata other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ConfigureIntercomAdaptorMetadata other)
        {
            if (other == null)
            {
                return;
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`ResetIntercomAdaptor`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.ResetIntercomAdaptor]
    /// </summary>
    public sealed partial class ResetIntercomAdaptorRequest : IMessage<ResetIntercomAdaptorRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetIntercomAdaptorRequest> _parser = new(() => new ResetIntercomAdaptorRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetIntercomAdaptorRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[18]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetIntercomAdaptorRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetIntercomAdaptorRequest(ResetIntercomAdaptorRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetIntercomAdaptorRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the intercom adaptor to be reset. For example:
        /// `installations/surelock-homes-hq/intercom-adaptors/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ResetIntercomAdaptorRequest);
        public bool Equals(ResetIntercomAdaptorRequest other)
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

        public void MergeFrom(ResetIntercomAdaptorRequest other)
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
    /// The empty response message for [`ResetIntercomAdaptor`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.ResetIntercomAdaptor]
    /// </summary>
    public sealed partial class ResetIntercomAdaptorResponse : IMessage<ResetIntercomAdaptorResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetIntercomAdaptorResponse> _parser = new(() => new ResetIntercomAdaptorResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetIntercomAdaptorResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[19]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetIntercomAdaptorResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetIntercomAdaptorResponse(ResetIntercomAdaptorResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetIntercomAdaptorResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ResetIntercomAdaptorResponse);
        public bool Equals(ResetIntercomAdaptorResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ResetIntercomAdaptorResponse other)
        {
            if (other == null)
            {
                return;
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The metadata message for [`ResetIntercomAdaptor`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.ResetIntercomAdaptor]
    /// </summary>
    public sealed partial class ResetIntercomAdaptorMetadata : IMessage<ResetIntercomAdaptorMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetIntercomAdaptorMetadata> _parser = new(() => new ResetIntercomAdaptorMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetIntercomAdaptorMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[20]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetIntercomAdaptorMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetIntercomAdaptorMetadata(ResetIntercomAdaptorMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetIntercomAdaptorMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ResetIntercomAdaptorMetadata);
        public bool Equals(ResetIntercomAdaptorMetadata other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ResetIntercomAdaptorMetadata other)
        {
            if (other == null)
            {
                return;
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`UpdateIntercomAdaptorFirmware`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.UpdateIntercomAdaptorFirmware]
    /// </summary>
    public sealed partial class UpdateIntercomAdaptorFirmwareRequest : IMessage<UpdateIntercomAdaptorFirmwareRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateIntercomAdaptorFirmwareRequest> _parser = new(() => new UpdateIntercomAdaptorFirmwareRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateIntercomAdaptorFirmwareRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[21]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateIntercomAdaptorFirmwareRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateIntercomAdaptorFirmwareRequest(UpdateIntercomAdaptorFirmwareRequest other) : this()
        {
            intercomAdaptor_ = other.intercomAdaptor_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateIntercomAdaptorFirmwareRequest Clone() => new(this);
        /// <summary>Field number for the "intercom_adaptor" field.</summary>
        public const int IntercomAdaptorFieldNumber = 1;
        private string intercomAdaptor_ = "";

        /// <summary>
        /// The resource name of the intercom adaptor whose firmware will be updated. For
        /// example:
        /// `installations/surelock-homes-hq/intercom-adaptors/baker-street-entrance`.
        /// </summary>
        public string IntercomAdaptor
        {
            get { return intercomAdaptor_; }
            set
            {
                intercomAdaptor_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateIntercomAdaptorFirmwareRequest);
        public bool Equals(UpdateIntercomAdaptorFirmwareRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (IntercomAdaptor != other.IntercomAdaptor) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (IntercomAdaptor.Length != 0) hash ^= IntercomAdaptor.GetHashCode();
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
      if (IntercomAdaptor.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(IntercomAdaptor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (IntercomAdaptor.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(IntercomAdaptor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (IntercomAdaptor.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(IntercomAdaptor);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdateIntercomAdaptorFirmwareRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.IntercomAdaptor.Length != 0)
            {
                IntercomAdaptor = other.IntercomAdaptor;
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
            IntercomAdaptor = input.ReadString();
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
                            IntercomAdaptor = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`UpdateIntercomAdaptorFirmware`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.UpdateIntercomAdaptorFirmware]
    /// </summary>
    public sealed partial class UpdateIntercomAdaptorFirmwareResponse : IMessage<UpdateIntercomAdaptorFirmwareResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateIntercomAdaptorFirmwareResponse> _parser = new(() => new UpdateIntercomAdaptorFirmwareResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateIntercomAdaptorFirmwareResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[22]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateIntercomAdaptorFirmwareResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateIntercomAdaptorFirmwareResponse(UpdateIntercomAdaptorFirmwareResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateIntercomAdaptorFirmwareResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as UpdateIntercomAdaptorFirmwareResponse);
        public bool Equals(UpdateIntercomAdaptorFirmwareResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdateIntercomAdaptorFirmwareResponse other)
        {
            if (other == null)
            {
                return;
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
                }
            }
        }
#endif

    }

    /// <summary>
    /// The metadata message for [`UpdateIntercomAdaptorFirmware`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.UpdateIntercomAdaptorFirmware]
    /// </summary>
    public sealed partial class UpdateIntercomAdaptorFirmwareMetadata : IMessage<UpdateIntercomAdaptorFirmwareMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateIntercomAdaptorFirmwareMetadata> _parser = new(() => new UpdateIntercomAdaptorFirmwareMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateIntercomAdaptorFirmwareMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[23]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateIntercomAdaptorFirmwareMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateIntercomAdaptorFirmwareMetadata(UpdateIntercomAdaptorFirmwareMetadata other) : this()
        {
            progressPercent_ = other.progressPercent_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateIntercomAdaptorFirmwareMetadata Clone() => new(this);
        /// <summary>Field number for the "progress_percent" field.</summary>
        public const int ProgressPercentFieldNumber = 1;
        private int progressPercent_;

        /// <summary>
        /// Progress of operation. Range: [0, 100].
        /// </summary>
        public int ProgressPercent
        {
            get { return progressPercent_; }
            set
            {
                progressPercent_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateIntercomAdaptorFirmwareMetadata);
        public bool Equals(UpdateIntercomAdaptorFirmwareMetadata other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (ProgressPercent != other.ProgressPercent) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (ProgressPercent != 0) hash ^= ProgressPercent.GetHashCode();
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
      if (ProgressPercent != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ProgressPercent);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (ProgressPercent != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(ProgressPercent);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (ProgressPercent != 0)
            {
                size += 1 + CodedOutputStream.ComputeInt32Size(ProgressPercent);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdateIntercomAdaptorFirmwareMetadata other)
        {
            if (other == null)
            {
                return;
            }
            if (other.ProgressPercent != 0)
            {
                ProgressPercent = other.ProgressPercent;
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
            ProgressPercent = input.ReadInt32();
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
                            ProgressPercent = input.ReadInt32();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GenerateAuthorizationToken`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.GenerateAuthorizationToken]
    /// </summary>
    public sealed partial class GenerateAuthorizationTokenRequest : IMessage<GenerateAuthorizationTokenRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GenerateAuthorizationTokenRequest> _parser = new(() => new GenerateAuthorizationTokenRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GenerateAuthorizationTokenRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[24]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GenerateAuthorizationTokenRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GenerateAuthorizationTokenRequest(GenerateAuthorizationTokenRequest other) : this()
        {
            intercomAdaptor_ = other.intercomAdaptor_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateAuthorizationTokenRequest Clone() => new(this);
        /// <summary>Field number for the "intercom_adaptor" field.</summary>
        public const int IntercomAdaptorFieldNumber = 1;
        private string intercomAdaptor_ = "";

        /// <summary>
        /// The resource name of the intercom adaptor that the authorization token is
        /// generated for. For example:
        /// `installations/surelock-homes-hq/intercom-adaptors/baker-street-entrance`.
        /// </summary>
        public string IntercomAdaptor
        {
            get { return intercomAdaptor_; }
            set
            {
                intercomAdaptor_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GenerateAuthorizationTokenRequest);
        public bool Equals(GenerateAuthorizationTokenRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (IntercomAdaptor != other.IntercomAdaptor) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (IntercomAdaptor.Length != 0) hash ^= IntercomAdaptor.GetHashCode();
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
      if (IntercomAdaptor.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(IntercomAdaptor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (IntercomAdaptor.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(IntercomAdaptor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (IntercomAdaptor.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(IntercomAdaptor);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GenerateAuthorizationTokenRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.IntercomAdaptor.Length != 0)
            {
                IntercomAdaptor = other.IntercomAdaptor;
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
            IntercomAdaptor = input.ReadString();
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
                            IntercomAdaptor = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`GenerateAuthorizationToken`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.GenerateAuthorizationToken]
    /// </summary>
    public sealed partial class GenerateAuthorizationTokenResponse : IMessage<GenerateAuthorizationTokenResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GenerateAuthorizationTokenResponse> _parser = new(() => new GenerateAuthorizationTokenResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GenerateAuthorizationTokenResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[25]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GenerateAuthorizationTokenResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GenerateAuthorizationTokenResponse(GenerateAuthorizationTokenResponse other) : this()
        {
            authorizationToken_ = other.authorizationToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateAuthorizationTokenResponse Clone() => new(this);
        /// <summary>Field number for the "authorization_token" field.</summary>
        public const int AuthorizationTokenFieldNumber = 1;
        private ByteString authorizationToken_ = ByteString.Empty;

        /// <summary>
        /// Authorization token to be used for connecting against an intercom
        /// adaptor.
        /// </summary>
        public ByteString AuthorizationToken
        {
            get { return authorizationToken_; }
            set
            {
                authorizationToken_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GenerateAuthorizationTokenResponse);
        public bool Equals(GenerateAuthorizationTokenResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (AuthorizationToken != other.AuthorizationToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (AuthorizationToken.Length != 0) hash ^= AuthorizationToken.GetHashCode();
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
      if (AuthorizationToken.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(AuthorizationToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (AuthorizationToken.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteBytes(AuthorizationToken);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (AuthorizationToken.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeBytesSize(AuthorizationToken);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GenerateAuthorizationTokenResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.AuthorizationToken.Length != 0)
            {
                AuthorizationToken = other.AuthorizationToken;
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
            AuthorizationToken = input.ReadBytes();
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
                            AuthorizationToken = input.ReadBytes();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GenerateFirmwareDownloadUri`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.GenerateFirmwareDownloadUri]
    /// </summary>
    public sealed partial class GenerateFirmwareDownloadUriRequest : IMessage<GenerateFirmwareDownloadUriRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GenerateFirmwareDownloadUriRequest> _parser = new(() => new GenerateFirmwareDownloadUriRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GenerateFirmwareDownloadUriRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[26]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GenerateFirmwareDownloadUriRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GenerateFirmwareDownloadUriRequest(GenerateFirmwareDownloadUriRequest other) : this()
        {
            intercomAdaptor_ = other.intercomAdaptor_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateFirmwareDownloadUriRequest Clone() => new(this);
        /// <summary>Field number for the "intercom_adaptor" field.</summary>
        public const int IntercomAdaptorFieldNumber = 1;
        private string intercomAdaptor_ = "";

        /// <summary>
        /// The resource name of the intercom adaptor to get the firmware download URI.
        /// For example: `installations/surelock-homes-hq/intercom-adaptors/baker-street-entrance`.
        /// </summary>
        public string IntercomAdaptor
        {
            get { return intercomAdaptor_; }
            set
            {
                intercomAdaptor_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GenerateFirmwareDownloadUriRequest);
        public bool Equals(GenerateFirmwareDownloadUriRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (IntercomAdaptor != other.IntercomAdaptor) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (IntercomAdaptor.Length != 0) hash ^= IntercomAdaptor.GetHashCode();
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
      if (IntercomAdaptor.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(IntercomAdaptor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (IntercomAdaptor.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(IntercomAdaptor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (IntercomAdaptor.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(IntercomAdaptor);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GenerateFirmwareDownloadUriRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.IntercomAdaptor.Length != 0)
            {
                IntercomAdaptor = other.IntercomAdaptor;
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
            IntercomAdaptor = input.ReadString();
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
                            IntercomAdaptor = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`GenerateFirmwareDownloadUri`][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.GenerateFirmwareDownloadUri]
    /// </summary>
    public sealed partial class GenerateFirmwareDownloadUriResponse : IMessage<GenerateFirmwareDownloadUriResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GenerateFirmwareDownloadUriResponse> _parser = new(() => new GenerateFirmwareDownloadUriResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GenerateFirmwareDownloadUriResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[27]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GenerateFirmwareDownloadUriResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GenerateFirmwareDownloadUriResponse(GenerateFirmwareDownloadUriResponse other) : this()
        {
            downloadUri_ = other.downloadUri_;
            digest_ = other.digest_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateFirmwareDownloadUriResponse Clone() => new(this);
        /// <summary>Field number for the "download_uri" field.</summary>
        public const int DownloadUriFieldNumber = 1;
        private string downloadUri_ = "";

        /// <summary>
        /// The URI to download the firmware bundle. The URI will be valid for 15
        /// minutes.
        /// </summary>
        public string DownloadUri
        {
            get { return downloadUri_; }
            set
            {
                downloadUri_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "digest" field.</summary>
        public const int DigestFieldNumber = 2;
        private string digest_ = "";

        /// <summary>
        /// Digest of the file to be download. This can be used to cache the file and
        /// avoid downloading it multiple times.
        /// The digest has the following format: `&lt;algorithm>:&lt;digest>`.
        /// For example: `sha256:8ff2483f2fbaa6c8dfd4e3556dbde298eb5e342b5e46f84eabdccc8e1cbe2d5a`.
        /// </summary>
        public string Digest
        {
            get { return digest_; }
            set
            {
                digest_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GenerateFirmwareDownloadUriResponse);
        public bool Equals(GenerateFirmwareDownloadUriResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (DownloadUri != other.DownloadUri) return false;
            if (Digest != other.Digest) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (DownloadUri.Length != 0) hash ^= DownloadUri.GetHashCode();
            if (Digest.Length != 0) hash ^= Digest.GetHashCode();
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
      if (DownloadUri.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DownloadUri);
      }
      if (Digest.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Digest);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (DownloadUri.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(DownloadUri);
            }
            if (Digest.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Digest);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (DownloadUri.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DownloadUri);
            }
            if (Digest.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Digest);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GenerateFirmwareDownloadUriResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.DownloadUri.Length != 0)
            {
                DownloadUri = other.DownloadUri;
            }
            if (other.Digest.Length != 0)
            {
                Digest = other.Digest;
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
            DownloadUri = input.ReadString();
            break;
          }
          case 18: {
            Digest = input.ReadString();
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
                            DownloadUri = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Digest = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The metadata message for [`GenerateFirmwareDownloadUri`][salto.nebula.intercomadaptor.v1.IntercomAdaptorLockService.GenerateFirmwareDownloadUri]
    /// </summary>
    public sealed partial class GenerateFirmwareDownloadUriMetadata : IMessage<GenerateFirmwareDownloadUriMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GenerateFirmwareDownloadUriMetadata> _parser = new(() => new GenerateFirmwareDownloadUriMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GenerateFirmwareDownloadUriMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[28]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GenerateFirmwareDownloadUriMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GenerateFirmwareDownloadUriMetadata(GenerateFirmwareDownloadUriMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateFirmwareDownloadUriMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as GenerateFirmwareDownloadUriMetadata);
        public bool Equals(GenerateFirmwareDownloadUriMetadata other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(GenerateFirmwareDownloadUriMetadata other)
        {
            if (other == null)
            {
                return;
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
                }
            }
        }
#endif

    }

    #endregion

}
