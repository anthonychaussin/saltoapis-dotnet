using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Event.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/event/v1/types.proto</summary>
    public static partial class TypesReflection
    {

        /// <summary>File descriptor for salto/nebula/event/v1/types.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static TypesReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CiFzYWx0by9uZWJ1bGEvZXZlbnQvdjEvdHlwZXMucHJvdG8SFXNhbHRvLm5l",
                  "YnVsYS5ldmVudC52MRocZ29vZ2xlL3Byb3RvYnVmL3N0cnVjdC5wcm90bxou",
                  "c2FsdG8vbmVidWxhL2FjY2Vzc3BvaW50L3YxL2FjY2Vzc19wb2ludC5wcm90",
                  "bxouc2FsdG8vbmVidWxhL2FjY2Vzc3JpZ2h0L3YxL2FjY2Vzc19yaWdodC5w",
                  "cm90bxolc2FsdG8vbmVidWxhL2Jvb2tpbmcvdjEvYm9va2luZy5wcm90bxor",
                  "c2FsdG8vbmVidWxhL2NvbnRyb2xsZXIvdjEvY29udHJvbGxlci5wcm90bxow",
                  "c2FsdG8vbmVidWxhL2VtZXJnZW5jeWtleS92MS9lbWVyZ2VuY3lfa2V5LnBy",
                  "b3RvGh9zYWx0by9uZWJ1bGEvdW5pdC92MS91bml0LnByb3RvGh9zYWx0by9u",
                  "ZWJ1bGEvdXNlci92MS91c2VyLnByb3RvIj8KCVByaW5jaXBhbBIqCgR1c2Vy",
                  "GAEgASgLMhouc2FsdG8ubmVidWxhLnVzZXIudjEuVXNlckgAQgYKBHR5cGUi",
                  "mgEKDlByZXZpb3VzVmFsdWVzEkEKBnZhbHVlcxgBIAMoCzIxLnNhbHRvLm5l",
                  "YnVsYS5ldmVudC52MS5QcmV2aW91c1ZhbHVlcy5WYWx1ZXNFbnRyeRpFCgtW",
                  "YWx1ZXNFbnRyeRILCgNrZXkYASABKAkSJQoFdmFsdWUYAiABKAsyFi5nb29n",
                  "bGUucHJvdG9idWYuVmFsdWU6AjgBIoUBChJBY2Nlc3NQb2ludENyZWF0ZWQS",
                  "PgoMYWNjZXNzX3BvaW50GAEgASgLMiguc2FsdG8ubmVidWxhLmFjY2Vzc3Bv",
                  "aW50LnYxLkFjY2Vzc1BvaW50Ei8KBWFjdG9yGAIgASgLMiAuc2FsdG8ubmVi",
                  "dWxhLmV2ZW50LnYxLlByaW5jaXBhbCLFAQoSQWNjZXNzUG9pbnRVcGRhdGVk",
                  "Ej4KDGFjY2Vzc19wb2ludBgBIAEoCzIoLnNhbHRvLm5lYnVsYS5hY2Nlc3Nw",
                  "b2ludC52MS5BY2Nlc3NQb2ludBIvCgVhY3RvchgCIAEoCzIgLnNhbHRvLm5l",
                  "YnVsYS5ldmVudC52MS5QcmluY2lwYWwSPgoPcHJldmlvdXNfdmFsdWVzGAMg",
                  "ASgLMiUuc2FsdG8ubmVidWxhLmV2ZW50LnYxLlByZXZpb3VzVmFsdWVzIoUB",
                  "ChJBY2Nlc3NQb2ludERlbGV0ZWQSPgoMYWNjZXNzX3BvaW50GAEgASgLMigu",
                  "c2FsdG8ubmVidWxhLmFjY2Vzc3BvaW50LnYxLkFjY2Vzc1BvaW50Ei8KBWFj",
                  "dG9yGAIgASgLMiAuc2FsdG8ubmVidWxhLmV2ZW50LnYxLlByaW5jaXBhbCLm",
                  "BAoTQWNjZXNzUG9pbnRVbmxvY2tlZBI+CgxhY2Nlc3NfcG9pbnQYASABKAsy",
                  "KC5zYWx0by5uZWJ1bGEuYWNjZXNzcG9pbnQudjEuQWNjZXNzUG9pbnQSKAoE",
                  "dXNlchgCIAEoCzIaLnNhbHRvLm5lYnVsYS51c2VyLnYxLlVzZXISQwoNZW1l",
                  "cmdlbmN5X2tleRgDIAEoCzIqLnNhbHRvLm5lYnVsYS5lbWVyZ2VuY3lrZXku",
                  "djEuRW1lcmdlbmN5S2V5SAASMQoIY2FyZF9rZXkYBCABKAsyHS5zYWx0by5u",
                  "ZWJ1bGEudXNlci52MS5DYXJkS2V5SAASLwoHYXBwX2tleRgFIAEoCzIcLnNh",
                  "bHRvLm5lYnVsYS51c2VyLnYxLkFwcEtleUgAEjUKCndhbGxldF9rZXkYBiAB",
                  "KAsyHy5zYWx0by5uZWJ1bGEudXNlci52MS5XYWxsZXRLZXlIABIyCghwYXNz",
                  "Y29kZRgHIAEoCzIeLnNhbHRvLm5lYnVsYS51c2VyLnYxLlBhc3Njb2RlSAAS",
                  "PQoOZWxlY3Ryb25pY19rZXkYCSABKAsyIy5zYWx0by5uZWJ1bGEudXNlci52",
                  "MS5FbGVjdHJvbmljS2V5SAASRwoJZGlyZWN0aW9uGAggASgOMjQuc2FsdG8u",
                  "bmVidWxhLmV2ZW50LnYxLkFjY2Vzc1BvaW50VW5sb2NrZWQuRGlyZWN0aW9u",
                  "IjsKCURpcmVjdGlvbhIZChVESVJFQ1RJT05fVU5TUEVDSUZJRUQQABIJCgVF",
                  "TlRSWRABEggKBEVYSVQQAkIMCgpjcmVkZW50aWFsIt4DChFBY2Nlc3NQb2lu",
                  "dExvY2tlZBI+CgxhY2Nlc3NfcG9pbnQYASABKAsyKC5zYWx0by5uZWJ1bGEu",
                  "YWNjZXNzcG9pbnQudjEuQWNjZXNzUG9pbnQSKAoEdXNlchgCIAEoCzIaLnNh",
                  "bHRvLm5lYnVsYS51c2VyLnYxLlVzZXISQwoNZW1lcmdlbmN5X2tleRgDIAEo",
                  "CzIqLnNhbHRvLm5lYnVsYS5lbWVyZ2VuY3lrZXkudjEuRW1lcmdlbmN5S2V5",
                  "SAASMQoIY2FyZF9rZXkYBCABKAsyHS5zYWx0by5uZWJ1bGEudXNlci52MS5D",
                  "YXJkS2V5SAASLwoHYXBwX2tleRgFIAEoCzIcLnNhbHRvLm5lYnVsYS51c2Vy",
                  "LnYxLkFwcEtleUgAEjUKCndhbGxldF9rZXkYBiABKAsyHy5zYWx0by5uZWJ1",
                  "bGEudXNlci52MS5XYWxsZXRLZXlIABIyCghwYXNzY29kZRgHIAEoCzIeLnNh",
                  "bHRvLm5lYnVsYS51c2VyLnYxLlBhc3Njb2RlSAASPQoOZWxlY3Ryb25pY19r",
                  "ZXkYCCABKAsyIy5zYWx0by5uZWJ1bGEudXNlci52MS5FbGVjdHJvbmljS2V5",
                  "SABCDAoKY3JlZGVudGlhbCJXChVBY2Nlc3NQb2ludEZvcmNlZE9wZW4SPgoM",
                  "YWNjZXNzX3BvaW50GAEgASgLMiguc2FsdG8ubmVidWxhLmFjY2Vzc3BvaW50",
                  "LnYxLkFjY2Vzc1BvaW50IlMKEUFjY2Vzc1BvaW50Q2xvc2VkEj4KDGFjY2Vz",
                  "c19wb2ludBgBIAEoCzIoLnNhbHRvLm5lYnVsYS5hY2Nlc3Nwb2ludC52MS5B",
                  "Y2Nlc3NQb2ludCKvBwoMQWNjZXNzRGVuaWVkEkAKDGFjY2Vzc19wb2ludBgB",
                  "IAEoCzIoLnNhbHRvLm5lYnVsYS5hY2Nlc3Nwb2ludC52MS5BY2Nlc3NQb2lu",
                  "dEgAEjwKCmNvbnRyb2xsZXIYCiABKAsyJi5zYWx0by5uZWJ1bGEuY29udHJv",
                  "bGxlci52MS5Db250cm9sbGVySAASKAoEdXNlchgCIAEoCzIaLnNhbHRvLm5l",
                  "YnVsYS51c2VyLnYxLlVzZXISOgoGcmVhc29uGAMgASgOMiouc2FsdG8ubmVi",
                  "dWxhLmV2ZW50LnYxLkFjY2Vzc0RlbmllZC5SZWFzb24SQwoNZW1lcmdlbmN5",
                  "X2tleRgEIAEoCzIqLnNhbHRvLm5lYnVsYS5lbWVyZ2VuY3lrZXkudjEuRW1l",
                  "cmdlbmN5S2V5SAESMQoIY2FyZF9rZXkYBSABKAsyHS5zYWx0by5uZWJ1bGEu",
                  "dXNlci52MS5DYXJkS2V5SAESLwoHYXBwX2tleRgGIAEoCzIcLnNhbHRvLm5l",
                  "YnVsYS51c2VyLnYxLkFwcEtleUgBEjUKCndhbGxldF9rZXkYByABKAsyHy5z",
                  "YWx0by5uZWJ1bGEudXNlci52MS5XYWxsZXRLZXlIARIyCghwYXNzY29kZRgI",
                  "IAEoCzIeLnNhbHRvLm5lYnVsYS51c2VyLnYxLlBhc3Njb2RlSAESPQoOZWxl",
                  "Y3Ryb25pY19rZXkYCSABKAsyIy5zYWx0by5uZWJ1bGEudXNlci52MS5FbGVj",
                  "dHJvbmljS2V5SAEizQIKBlJlYXNvbhIWChJSRUFTT05fVU5TUEVDSUZJRUQQ",
                  "ABIWChJDUkVERU5USUFMX0VYUElSRUQQARIaChZDUkVERU5USUFMX1VOQUNU",
                  "SVZBVEVEEAISJgoiQ1JFREVOVElBTF9QRVJNSVNTSU9OX0lOU1VGRklDSUVO",
                  "VBADEioKJkNSRURFTlRJQUxfUEVSTUlTU0lPTl9PVVRTSURFX1ZBTElESVRZ",
                  "EAQSKgomQ1JFREVOVElBTF9QRVJNSVNTSU9OX09VVFNJREVfU0NIRURVTEUQ",
                  "BRIXChNJTlZBTElEX0FDQ0VTU19DT0RFEAYSHwobREVWSUNFX0JBVFRFUllf",
                  "SU5TVUZGSUNJRU5UEAcSPQo5Q1JFREVOVElBTF9ET19OT1RfRElTVFVSQl9P",
                  "VkVSUklERV9QRVJNSVNTSU9OX05PVF9QUkVTRU5UEAhCCAoGc291cmNlQgwK",
                  "CmNyZWRlbnRpYWwiVQoTQWNjZXNzUG9pbnRMZWZ0T3BlbhI+CgxhY2Nlc3Nf",
                  "cG9pbnQYASABKAsyKC5zYWx0by5uZWJ1bGEuYWNjZXNzcG9pbnQudjEuQWNj",
                  "ZXNzUG9pbnQihQEKEkFjY2Vzc1JpZ2h0Q3JlYXRlZBI+CgxhY2Nlc3Nfcmln",
                  "aHQYASABKAsyKC5zYWx0by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEuQWNjZXNz",
                  "UmlnaHQSLwoFYWN0b3IYAiABKAsyIC5zYWx0by5uZWJ1bGEuZXZlbnQudjEu",
                  "UHJpbmNpcGFsIsUBChJBY2Nlc3NSaWdodFVwZGF0ZWQSPgoMYWNjZXNzX3Jp",
                  "Z2h0GAEgASgLMiguc2FsdG8ubmVidWxhLmFjY2Vzc3JpZ2h0LnYxLkFjY2Vz",
                  "c1JpZ2h0Ei8KBWFjdG9yGAIgASgLMiAuc2FsdG8ubmVidWxhLmV2ZW50LnYx",
                  "LlByaW5jaXBhbBI+Cg9wcmV2aW91c192YWx1ZXMYAyABKAsyJS5zYWx0by5u",
                  "ZWJ1bGEuZXZlbnQudjEuUHJldmlvdXNWYWx1ZXMihQEKEkFjY2Vzc1JpZ2h0",
                  "RGVsZXRlZBI+CgxhY2Nlc3NfcmlnaHQYASABKAsyKC5zYWx0by5uZWJ1bGEu",
                  "YWNjZXNzcmlnaHQudjEuQWNjZXNzUmlnaHQSLwoFYWN0b3IYAiABKAsyIC5z",
                  "YWx0by5uZWJ1bGEuZXZlbnQudjEuUHJpbmNpcGFsItABCh1BY2Nlc3NSaWdo",
                  "dEFjY2Vzc1BvaW50Q3JlYXRlZBI+CgxhY2Nlc3NfcmlnaHQYASABKAsyKC5z",
                  "YWx0by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEuQWNjZXNzUmlnaHQSPgoMYWNj",
                  "ZXNzX3BvaW50GAIgASgLMiguc2FsdG8ubmVidWxhLmFjY2Vzc3BvaW50LnYx",
                  "LkFjY2Vzc1BvaW50Ei8KBWFjdG9yGAMgASgLMiAuc2FsdG8ubmVidWxhLmV2",
                  "ZW50LnYxLlByaW5jaXBhbCLXAQojQWNjZXNzUmlnaHRBY2Nlc3NQb2ludHNC",
                  "YXRjaENyZWF0ZWQSPgoMYWNjZXNzX3JpZ2h0GAEgASgLMiguc2FsdG8ubmVi",
                  "dWxhLmFjY2Vzc3JpZ2h0LnYxLkFjY2Vzc1JpZ2h0Ej8KDWFjY2Vzc19wb2lu",
                  "dHMYAiADKAsyKC5zYWx0by5uZWJ1bGEuYWNjZXNzcG9pbnQudjEuQWNjZXNz",
                  "UG9pbnQSLwoFYWN0b3IYAyABKAsyIC5zYWx0by5uZWJ1bGEuZXZlbnQudjEu",
                  "UHJpbmNpcGFsItABCh1BY2Nlc3NSaWdodEFjY2Vzc1BvaW50RGVsZXRlZBI+",
                  "CgxhY2Nlc3NfcmlnaHQYASABKAsyKC5zYWx0by5uZWJ1bGEuYWNjZXNzcmln",
                  "aHQudjEuQWNjZXNzUmlnaHQSPgoMYWNjZXNzX3BvaW50GAIgASgLMiguc2Fs",
                  "dG8ubmVidWxhLmFjY2Vzc3BvaW50LnYxLkFjY2Vzc1BvaW50Ei8KBWFjdG9y",
                  "GAMgASgLMiAuc2FsdG8ubmVidWxhLmV2ZW50LnYxLlByaW5jaXBhbCLXAQoj",
                  "QWNjZXNzUmlnaHRBY2Nlc3NQb2ludHNCYXRjaERlbGV0ZWQSPgoMYWNjZXNz",
                  "X3JpZ2h0GAEgASgLMiguc2FsdG8ubmVidWxhLmFjY2Vzc3JpZ2h0LnYxLkFj",
                  "Y2Vzc1JpZ2h0Ej8KDWFjY2Vzc19wb2ludHMYAiADKAsyKC5zYWx0by5uZWJ1",
                  "bGEuYWNjZXNzcG9pbnQudjEuQWNjZXNzUG9pbnQSLwoFYWN0b3IYAyABKAsy",
                  "IC5zYWx0by5uZWJ1bGEuZXZlbnQudjEuUHJpbmNpcGFsImgKC1VzZXJDcmVh",
                  "dGVkEigKBHVzZXIYASABKAsyGi5zYWx0by5uZWJ1bGEudXNlci52MS5Vc2Vy",
                  "Ei8KBWFjdG9yGAIgASgLMiAuc2FsdG8ubmVidWxhLmV2ZW50LnYxLlByaW5j",
                  "aXBhbCKoAQoLVXNlclVwZGF0ZWQSKAoEdXNlchgBIAEoCzIaLnNhbHRvLm5l",
                  "YnVsYS51c2VyLnYxLlVzZXISLwoFYWN0b3IYAiABKAsyIC5zYWx0by5uZWJ1",
                  "bGEuZXZlbnQudjEuUHJpbmNpcGFsEj4KD3ByZXZpb3VzX3ZhbHVlcxgDIAEo",
                  "CzIlLnNhbHRvLm5lYnVsYS5ldmVudC52MS5QcmV2aW91c1ZhbHVlcyJoCgtV",
                  "c2VyQmxvY2tlZBIoCgR1c2VyGAEgASgLMhouc2FsdG8ubmVidWxhLnVzZXIu",
                  "djEuVXNlchIvCgVhY3RvchgCIAEoCzIgLnNhbHRvLm5lYnVsYS5ldmVudC52",
                  "MS5QcmluY2lwYWwiagoNVXNlclVuYmxvY2tlZBIoCgR1c2VyGAEgASgLMhou",
                  "c2FsdG8ubmVidWxhLnVzZXIudjEuVXNlchIvCgVhY3RvchgCIAEoCzIgLnNh",
                  "bHRvLm5lYnVsYS5ldmVudC52MS5QcmluY2lwYWwiaAoLVXNlckRlbGV0ZWQS",
                  "KAoEdXNlchgBIAEoCzIaLnNhbHRvLm5lYnVsYS51c2VyLnYxLlVzZXISLwoF",
                  "YWN0b3IYAiABKAsyIC5zYWx0by5uZWJ1bGEuZXZlbnQudjEuUHJpbmNpcGFs",
                  "IrMBChZVc2VyQWNjZXNzUmlnaHRDcmVhdGVkEigKBHVzZXIYASABKAsyGi5z",
                  "YWx0by5uZWJ1bGEudXNlci52MS5Vc2VyEj4KDGFjY2Vzc19yaWdodBgCIAEo",
                  "CzIoLnNhbHRvLm5lYnVsYS5hY2Nlc3NyaWdodC52MS5BY2Nlc3NSaWdodBIv",
                  "CgVhY3RvchgDIAEoCzIgLnNhbHRvLm5lYnVsYS5ldmVudC52MS5QcmluY2lw",
                  "YWwiswEKFlVzZXJBY2Nlc3NSaWdodFVwZGF0ZWQSKAoEdXNlchgBIAEoCzIa",
                  "LnNhbHRvLm5lYnVsYS51c2VyLnYxLlVzZXISPgoMYWNjZXNzX3JpZ2h0GAIg",
                  "ASgLMiguc2FsdG8ubmVidWxhLmFjY2Vzc3JpZ2h0LnYxLkFjY2Vzc1JpZ2h0",
                  "Ei8KBWFjdG9yGAMgASgLMiAuc2FsdG8ubmVidWxhLmV2ZW50LnYxLlByaW5j",
                  "aXBhbCKzAQoWVXNlckFjY2Vzc1JpZ2h0RGVsZXRlZBIoCgR1c2VyGAEgASgL",
                  "Mhouc2FsdG8ubmVidWxhLnVzZXIudjEuVXNlchI+CgxhY2Nlc3NfcmlnaHQY",
                  "AiABKAsyKC5zYWx0by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEuQWNjZXNzUmln",
                  "aHQSLwoFYWN0b3IYAyABKAsyIC5zYWx0by5uZWJ1bGEuZXZlbnQudjEuUHJp",
                  "bmNpcGFsIp0BCg9DYXJkS2V5QXNzaWduZWQSKAoEdXNlchgBIAEoCzIaLnNh",
                  "bHRvLm5lYnVsYS51c2VyLnYxLlVzZXISLwoIY2FyZF9rZXkYAiABKAsyHS5z",
                  "YWx0by5uZWJ1bGEudXNlci52MS5DYXJkS2V5Ei8KBWFjdG9yGAMgASgLMiAu",
                  "c2FsdG8ubmVidWxhLmV2ZW50LnYxLlByaW5jaXBhbCKdAQoPQ2FyZEtleUNh",
                  "bmNlbGVkEigKBHVzZXIYASABKAsyGi5zYWx0by5uZWJ1bGEudXNlci52MS5V",
                  "c2VyEi8KCGNhcmRfa2V5GAIgASgLMh0uc2FsdG8ubmVidWxhLnVzZXIudjEu",
                  "Q2FyZEtleRIvCgVhY3RvchgDIAEoCzIgLnNhbHRvLm5lYnVsYS5ldmVudC52",
                  "MS5QcmluY2lwYWwimgEKDkFwcEtleUFzc2lnbmVkEigKBHVzZXIYASABKAsy",
                  "Gi5zYWx0by5uZWJ1bGEudXNlci52MS5Vc2VyEi0KB2FwcF9rZXkYAiABKAsy",
                  "HC5zYWx0by5uZWJ1bGEudXNlci52MS5BcHBLZXkSLwoFYWN0b3IYAyABKAsy",
                  "IC5zYWx0by5uZWJ1bGEuZXZlbnQudjEuUHJpbmNpcGFsIpoBCg5BcHBLZXlD",
                  "YW5jZWxlZBIoCgR1c2VyGAEgASgLMhouc2FsdG8ubmVidWxhLnVzZXIudjEu",
                  "VXNlchItCgdhcHBfa2V5GAIgASgLMhwuc2FsdG8ubmVidWxhLnVzZXIudjEu",
                  "QXBwS2V5Ei8KBWFjdG9yGAMgASgLMiAuc2FsdG8ubmVidWxhLmV2ZW50LnYx",
                  "LlByaW5jaXBhbCKjAQoRV2FsbGV0S2V5QXNzaWduZWQSKAoEdXNlchgBIAEo",
                  "CzIaLnNhbHRvLm5lYnVsYS51c2VyLnYxLlVzZXISMwoKd2FsbGV0X2tleRgC",
                  "IAEoCzIfLnNhbHRvLm5lYnVsYS51c2VyLnYxLldhbGxldEtleRIvCgVhY3Rv",
                  "chgDIAEoCzIgLnNhbHRvLm5lYnVsYS5ldmVudC52MS5QcmluY2lwYWwiowEK",
                  "EVdhbGxldEtleUNhbmNlbGVkEigKBHVzZXIYASABKAsyGi5zYWx0by5uZWJ1",
                  "bGEudXNlci52MS5Vc2VyEjMKCndhbGxldF9rZXkYAiABKAsyHy5zYWx0by5u",
                  "ZWJ1bGEudXNlci52MS5XYWxsZXRLZXkSLwoFYWN0b3IYAyABKAsyIC5zYWx0",
                  "by5uZWJ1bGEuZXZlbnQudjEuUHJpbmNpcGFsImgKC1VuaXRNb3ZlZEluEigK",
                  "BHVuaXQYASABKAsyGi5zYWx0by5uZWJ1bGEudW5pdC52MS5Vbml0Ei8KBWFj",
                  "dG9yGAIgASgLMiAuc2FsdG8ubmVidWxhLmV2ZW50LnYxLlByaW5jaXBhbCJp",
                  "CgxVbml0TW92ZWRPdXQSKAoEdW5pdBgBIAEoCzIaLnNhbHRvLm5lYnVsYS51",
                  "bml0LnYxLlVuaXQSLwoFYWN0b3IYAiABKAsyIC5zYWx0by5uZWJ1bGEuZXZl",
                  "bnQudjEuUHJpbmNpcGFsImgKC1VuaXRDcmVhdGVkEigKBHVuaXQYASABKAsy",
                  "Gi5zYWx0by5uZWJ1bGEudW5pdC52MS5Vbml0Ei8KBWFjdG9yGAIgASgLMiAu",
                  "c2FsdG8ubmVidWxhLmV2ZW50LnYxLlByaW5jaXBhbCKoAQoLVW5pdFVwZGF0",
                  "ZWQSKAoEdW5pdBgBIAEoCzIaLnNhbHRvLm5lYnVsYS51bml0LnYxLlVuaXQS",
                  "LwoFYWN0b3IYAiABKAsyIC5zYWx0by5uZWJ1bGEuZXZlbnQudjEuUHJpbmNp",
                  "cGFsEj4KD3ByZXZpb3VzX3ZhbHVlcxgDIAEoCzIlLnNhbHRvLm5lYnVsYS5l",
                  "dmVudC52MS5QcmV2aW91c1ZhbHVlcyJoCgtVbml0RGVsZXRlZBIoCgR1bml0",
                  "GAEgASgLMhouc2FsdG8ubmVidWxhLnVuaXQudjEuVW5pdBIvCgVhY3RvchgC",
                  "IAEoCzIgLnNhbHRvLm5lYnVsYS5ldmVudC52MS5QcmluY2lwYWwiiQEKE0Vt",
                  "ZXJnZW5jeUtleUNyZWF0ZWQSQQoNZW1lcmdlbmN5X2tleRgBIAEoCzIqLnNh",
                  "bHRvLm5lYnVsYS5lbWVyZ2VuY3lrZXkudjEuRW1lcmdlbmN5S2V5Ei8KBWFj",
                  "dG9yGAIgASgLMiAuc2FsdG8ubmVidWxhLmV2ZW50LnYxLlByaW5jaXBhbCLJ",
                  "AQoTRW1lcmdlbmN5S2V5VXBkYXRlZBJBCg1lbWVyZ2VuY3lfa2V5GAEgASgL",
                  "Miouc2FsdG8ubmVidWxhLmVtZXJnZW5jeWtleS52MS5FbWVyZ2VuY3lLZXkS",
                  "LwoFYWN0b3IYAiABKAsyIC5zYWx0by5uZWJ1bGEuZXZlbnQudjEuUHJpbmNp",
                  "cGFsEj4KD3ByZXZpb3VzX3ZhbHVlcxgDIAEoCzIlLnNhbHRvLm5lYnVsYS5l",
                  "dmVudC52MS5QcmV2aW91c1ZhbHVlcyKJAQoTRW1lcmdlbmN5S2V5RGVsZXRl",
                  "ZBJBCg1lbWVyZ2VuY3lfa2V5GAEgASgLMiouc2FsdG8ubmVidWxhLmVtZXJn",
                  "ZW5jeWtleS52MS5FbWVyZ2VuY3lLZXkSLwoFYWN0b3IYAiABKAsyIC5zYWx0",
                  "by5uZWJ1bGEuZXZlbnQudjEuUHJpbmNpcGFsIq8BChVFbGVjdHJvbmljS2V5",
                  "QXNzaWduZWQSKAoEdXNlchgBIAEoCzIaLnNhbHRvLm5lYnVsYS51c2VyLnYx",
                  "LlVzZXISOwoOZWxlY3Ryb25pY19rZXkYAiABKAsyIy5zYWx0by5uZWJ1bGEu",
                  "dXNlci52MS5FbGVjdHJvbmljS2V5Ei8KBWFjdG9yGAMgASgLMiAuc2FsdG8u",
                  "bmVidWxhLmV2ZW50LnYxLlByaW5jaXBhbCKvAQoVRWxlY3Ryb25pY0tleUNh",
                  "bmNlbGVkEigKBHVzZXIYASABKAsyGi5zYWx0by5uZWJ1bGEudXNlci52MS5V",
                  "c2VyEjsKDmVsZWN0cm9uaWNfa2V5GAIgASgLMiMuc2FsdG8ubmVidWxhLnVz",
                  "ZXIudjEuRWxlY3Ryb25pY0tleRIvCgVhY3RvchgDIAEoCzIgLnNhbHRvLm5l",
                  "YnVsYS5ldmVudC52MS5QcmluY2lwYWwi4gMKDUFjY2Vzc0dyYW50ZWQSPAoK",
                  "Y29udHJvbGxlchgBIAEoCzImLnNhbHRvLm5lYnVsYS5jb250cm9sbGVyLnYx",
                  "LkNvbnRyb2xsZXJIABIoCgR1c2VyGAIgASgLMhouc2FsdG8ubmVidWxhLnVz",
                  "ZXIudjEuVXNlchJDCg1lbWVyZ2VuY3lfa2V5GAMgASgLMiouc2FsdG8ubmVi",
                  "dWxhLmVtZXJnZW5jeWtleS52MS5FbWVyZ2VuY3lLZXlIARIxCghjYXJkX2tl",
                  "eRgEIAEoCzIdLnNhbHRvLm5lYnVsYS51c2VyLnYxLkNhcmRLZXlIARIvCgdh",
                  "cHBfa2V5GAUgASgLMhwuc2FsdG8ubmVidWxhLnVzZXIudjEuQXBwS2V5SAES",
                  "NQoKd2FsbGV0X2tleRgGIAEoCzIfLnNhbHRvLm5lYnVsYS51c2VyLnYxLldh",
                  "bGxldEtleUgBEjIKCHBhc3Njb2RlGAcgASgLMh4uc2FsdG8ubmVidWxhLnVz",
                  "ZXIudjEuUGFzc2NvZGVIARI9Cg5lbGVjdHJvbmljX2tleRgIIAEoCzIjLnNh",
                  "bHRvLm5lYnVsYS51c2VyLnYxLkVsZWN0cm9uaWNLZXlIAUIICgZkZXZpY2VC",
                  "DAoKY3JlZGVudGlhbCJ2ChBCb29raW5nQ2hlY2tlZEluEjEKB2Jvb2tpbmcY",
                  "ASABKAsyIC5zYWx0by5uZWJ1bGEuYm9va2luZy52MS5Cb29raW5nEi8KBWFj",
                  "dG9yGAIgASgLMiAuc2FsdG8ubmVidWxhLmV2ZW50LnYxLlByaW5jaXBhbCJ3",
                  "ChFCb29raW5nQ2hlY2tlZE91dBIxCgdib29raW5nGAEgASgLMiAuc2FsdG8u",
                  "bmVidWxhLmJvb2tpbmcudjEuQm9va2luZxIvCgVhY3RvchgCIAEoCzIgLnNh",
                  "bHRvLm5lYnVsYS5ldmVudC52MS5QcmluY2lwYWxCzwEKHWNvbS5zYWx0b2Fw",
                  "aXMubmVidWxhLmV2ZW50LnYxQgpUeXBlc1Byb3RvUAFaQGdpdGh1Yi5jb20v",
                  "c2FsdG9hcGlzLWludGVybmFsL3NhbHRvYXBpcy1nby9uZWJ1bGEvZXZlbnQv",
                  "djE7ZXZlbnSqAhlTYWx0b2FwaXMuTmVidWxhLkV2ZW50LlYxygIZU2FsdG9h",
                  "cGlzXE5lYnVsYVxFdmVudFxWMeICJUdQQk1ldGFkYXRhXFNhbHRvYXBpc1xO",
                  "ZWJ1bGFcRXZlbnRcVjFiBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, AccessPoint.V1.AccessPointReflection.Descriptor, AccessRight.V1.AccessRightReflection.Descriptor, Booking.V1.BookingReflection.Descriptor, Controller.V1.ControllerReflection.Descriptor, Salto.Nebula.EmergencyKey.V1.EmergencyKeyReflection.Descriptor, Unit.V1.UnitReflection.Descriptor, User.V1.UserReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Principal), Principal.Parser, ["User"], ["Type"], null, null, null),
            new(typeof(PreviousValues), PreviousValues.Parser, ["Values"], null, null, null, [null,]),
            new(typeof(AccessPointCreated), AccessPointCreated.Parser, ["AccessPoint", "Actor"], null, null, null, null),
            new(typeof(AccessPointUpdated), AccessPointUpdated.Parser, ["AccessPoint", "Actor", "PreviousValues"], null, null, null, null),
            new(typeof(AccessPointDeleted), AccessPointDeleted.Parser, ["AccessPoint", "Actor"], null, null, null, null),
            new(typeof(AccessPointUnlocked), AccessPointUnlocked.Parser, ["AccessPoint", "User", "EmergencyKey", "CardKey", "AppKey", "WalletKey", "Passcode", "ElectronicKey", "Direction"], ["Credential"], [typeof(AccessPointUnlocked.Types.Direction)], null, null),
            new(typeof(AccessPointLocked), AccessPointLocked.Parser, ["AccessPoint", "User", "EmergencyKey", "CardKey", "AppKey", "WalletKey", "Passcode", "ElectronicKey"], ["Credential"], null, null, null),
            new(typeof(AccessPointForcedOpen), AccessPointForcedOpen.Parser, ["AccessPoint"], null, null, null, null),
            new(typeof(AccessPointClosed), AccessPointClosed.Parser, ["AccessPoint"], null, null, null, null),
            new(typeof(AccessDenied), AccessDenied.Parser, ["AccessPoint", "Controller", "User", "Reason", "EmergencyKey", "CardKey", "AppKey", "WalletKey", "Passcode", "ElectronicKey"], ["Source", "Credential"], [typeof(AccessDenied.Types.Reason)], null, null),
            new(typeof(AccessPointLeftOpen), AccessPointLeftOpen.Parser, ["AccessPoint"], null, null, null, null),
            new(typeof(AccessRightCreated), AccessRightCreated.Parser, ["AccessRight", "Actor"], null, null, null, null),
            new(typeof(AccessRightUpdated), AccessRightUpdated.Parser, ["AccessRight", "Actor", "PreviousValues"], null, null, null, null),
            new(typeof(AccessRightDeleted), AccessRightDeleted.Parser, ["AccessRight", "Actor"], null, null, null, null),
            new(typeof(AccessRightAccessPointCreated), AccessRightAccessPointCreated.Parser, ["AccessRight", "AccessPoint", "Actor"], null, null, null, null),
            new(typeof(AccessRightAccessPointsBatchCreated), AccessRightAccessPointsBatchCreated.Parser, ["AccessRight", "AccessPoints", "Actor"], null, null, null, null),
            new(typeof(AccessRightAccessPointDeleted), AccessRightAccessPointDeleted.Parser, ["AccessRight", "AccessPoint", "Actor"], null, null, null, null),
            new(typeof(AccessRightAccessPointsBatchDeleted), AccessRightAccessPointsBatchDeleted.Parser, ["AccessRight", "AccessPoints", "Actor"], null, null, null, null),
            new(typeof(UserCreated), UserCreated.Parser, ["User", "Actor"], null, null, null, null),
            new(typeof(UserUpdated), UserUpdated.Parser, ["User", "Actor", "PreviousValues"], null, null, null, null),
            new(typeof(UserBlocked), UserBlocked.Parser, ["User", "Actor"], null, null, null, null),
            new(typeof(UserUnblocked), UserUnblocked.Parser, ["User", "Actor"], null, null, null, null),
            new(typeof(UserDeleted), UserDeleted.Parser, ["User", "Actor"], null, null, null, null),
            new(typeof(UserAccessRightCreated), UserAccessRightCreated.Parser, ["User", "AccessRight", "Actor"], null, null, null, null),
            new(typeof(UserAccessRightUpdated), UserAccessRightUpdated.Parser, ["User", "AccessRight", "Actor"], null, null, null, null),
            new(typeof(UserAccessRightDeleted), UserAccessRightDeleted.Parser, ["User", "AccessRight", "Actor"], null, null, null, null),
            new(typeof(CardKeyAssigned), CardKeyAssigned.Parser, ["User", "CardKey", "Actor"], null, null, null, null),
            new(typeof(CardKeyCanceled), CardKeyCanceled.Parser, ["User", "CardKey", "Actor"], null, null, null, null),
            new(typeof(AppKeyAssigned), AppKeyAssigned.Parser, ["User", "AppKey", "Actor"], null, null, null, null),
            new(typeof(AppKeyCanceled), AppKeyCanceled.Parser, ["User", "AppKey", "Actor"], null, null, null, null),
            new(typeof(WalletKeyAssigned), WalletKeyAssigned.Parser, ["User", "WalletKey", "Actor"], null, null, null, null),
            new(typeof(WalletKeyCanceled), WalletKeyCanceled.Parser, ["User", "WalletKey", "Actor"], null, null, null, null),
            new(typeof(UnitMovedIn), UnitMovedIn.Parser, ["Unit", "Actor"], null, null, null, null),
            new(typeof(UnitMovedOut), UnitMovedOut.Parser, ["Unit", "Actor"], null, null, null, null),
            new(typeof(UnitCreated), UnitCreated.Parser, ["Unit", "Actor"], null, null, null, null),
            new(typeof(UnitUpdated), UnitUpdated.Parser, ["Unit", "Actor", "PreviousValues"], null, null, null, null),
            new(typeof(UnitDeleted), UnitDeleted.Parser, ["Unit", "Actor"], null, null, null, null),
            new(typeof(EmergencyKeyCreated), EmergencyKeyCreated.Parser, ["EmergencyKey", "Actor"], null, null, null, null),
            new(typeof(EmergencyKeyUpdated), EmergencyKeyUpdated.Parser, ["EmergencyKey", "Actor", "PreviousValues"], null, null, null, null),
            new(typeof(EmergencyKeyDeleted), EmergencyKeyDeleted.Parser, ["EmergencyKey", "Actor"], null, null, null, null),
            new(typeof(ElectronicKeyAssigned), ElectronicKeyAssigned.Parser, ["User", "ElectronicKey", "Actor"], null, null, null, null),
            new(typeof(ElectronicKeyCanceled), ElectronicKeyCanceled.Parser, ["User", "ElectronicKey", "Actor"], null, null, null, null),
            new(typeof(AccessGranted), AccessGranted.Parser, ["Controller", "User", "EmergencyKey", "CardKey", "AppKey", "WalletKey", "Passcode", "ElectronicKey"], ["Device", "Credential"], null, null, null),
            new(typeof(BookingCheckedIn), BookingCheckedIn.Parser, ["Booking", "Actor"], null, null, null, null),
            new(typeof(BookingCheckedOut), BookingCheckedOut.Parser, ["Booking", "Actor"], null, null, null, null)
                ]));
        }

    }
    /// <summary>
    /// Represents the principal entity that initiated or performed an action
    /// associated with an event. This could be a user, a service account, or
    /// potentially other types of entities in the future.
    ///
    /// Implemented as a `oneof` to support future expansion—new principal types may
    /// be added over time without breaking compatibility for existing event
    /// messages. Clients should be prepared to handle additional kind of principals.
    /// </summary>
    public sealed partial class Principal : IMessage<Principal>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Principal> _parser = new(() => new Principal());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Principal> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Principal()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Principal(Principal other) : this()
        {
            switch (other.TypeCase)
            {
                case TypeOneofCase.User:
                    User = other.User.Clone();
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Principal Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;

        /// <summary>
        /// A user represents a human actor within the system.
        /// </summary>
        public User.V1.User User
        {
            get { return typeCase_ == TypeOneofCase.User ? (User.V1.User)type_ : null; }
            set
            {
                type_ = value;
                typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.User;
            }
        }

        private object type_;

        /// <summary>Enum of possible cases for the "type" oneof.</summary>
        public enum TypeOneofCase
        {
            None = 0,
            User = 1,
        }

        private TypeOneofCase typeCase_ = TypeOneofCase.None;

        public TypeOneofCase TypeCase
        {
            get { return typeCase_; }
        }

        public void ClearType()
        {
            typeCase_ = TypeOneofCase.None;
            type_ = null;
        }

        public override bool Equals(object other) => Equals(other as Principal);
        public bool Equals(Principal other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(User, other.User)) || (TypeCase != other.TypeCase)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (typeCase_ == TypeOneofCase.User) hash ^= User.GetHashCode();
            hash ^= (int)typeCase_;
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (typeCase_ == TypeOneofCase.User) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (typeCase_ == TypeOneofCase.User)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (typeCase_ == TypeOneofCase.User) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Principal other)
        {
            if (other == null) return;
            switch (other.TypeCase)
            {
                case TypeOneofCase.User:
                    if (User == null) User = new User.V1.User();
                    User.MergeFrom(other.User);
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
            Saltoapis.Nebula.User.V1.User subBuilder = new Saltoapis.Nebula.User.V1.User();
            if (typeCase_ == TypeOneofCase.User) {
              subBuilder.MergeFrom(User);
            }
            input.ReadMessage(subBuilder);
            User = subBuilder;
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
                            User.V1.User subBuilder = new();
                            if (typeCase_ == TypeOneofCase.User) subBuilder.MergeFrom(User);
                            input.ReadMessage(subBuilder);
                            User = subBuilder;
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// A reusable container that holds the previous values of any fields that were
    /// changed during an update operation. This message is designed to be generic
    /// and can be included in any resource update event (for example,
    /// `AccessPointUpdated`, `UserUpdated`, …) to provide a clear and explicit
    /// diff of what was modified.
    /// </summary>
    public sealed partial class PreviousValues : IMessage<PreviousValues>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<PreviousValues> _parser = new(() => new PreviousValues());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<PreviousValues> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public PreviousValues()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public PreviousValues(PreviousValues other) : this()
        {
            values_ = other.values_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public PreviousValues Clone() => new(this);
        /// <summary>Field number for the "values" field.</summary>
        public const int ValuesFieldNumber = 1;
        private static readonly MapField<string, Google.Protobuf.WellKnownTypes.Value>.Codec _map_values_codec
            = new(FieldCodec.ForString(10, ""), FieldCodec.ForMessage(18, Google.Protobuf.WellKnownTypes.Value.Parser), 10);
        private readonly MapField<string, Google.Protobuf.WellKnownTypes.Value> values_ = [];

        /// <summary>
        /// A map where the key is the field name of the changed attribute (for
        /// example, "display_name") and the value is the field's value before the
        /// update was applied. Only fields that were actually changed will be present
        /// in this map.
        /// </summary>
        public MapField<string, Google.Protobuf.WellKnownTypes.Value> Values
        {
            get { return values_; }
        }

        public override bool Equals(object other) => Equals(other as PreviousValues);
        public bool Equals(PreviousValues other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!Values.Equals(other.Values)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= Values.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      values_.WriteTo(output, _map_values_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            values_.WriteTo(ref output, _map_values_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += values_.CalculateSize(_map_values_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(PreviousValues other)
        {
            if (other == null) return;
            values_.MergeFrom(other.values_);
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
            values_.AddEntriesFrom(input, _map_values_codec);
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
                            values_.AddEntriesFrom(ref input, _map_values_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the creation of an access point.
    /// </summary>
    public sealed partial class AccessPointCreated : IMessage<AccessPointCreated>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessPointCreated> _parser = new(() => new AccessPointCreated());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessPointCreated> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessPointCreated()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessPointCreated(AccessPointCreated other) : this()
        {
            accessPoint_ = other.accessPoint_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessPointCreated Clone() => new(this);
        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 1;
        private AccessPoint.V1.AccessPoint accessPoint_;

        /// <summary>
        /// Access point created.
        /// </summary>
        public AccessPoint.V1.AccessPoint AccessPoint
        {
            get { return accessPoint_; }
            set
            {
                accessPoint_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who created the access point.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AccessPointCreated);
        public bool Equals(AccessPointCreated other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessPoint, other.AccessPoint)) || (!Equals(Actor, other.Actor))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessPoint_ != null) hash ^= AccessPoint.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (accessPoint_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessPoint);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (accessPoint_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessPoint);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (accessPoint_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessPoint);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessPointCreated other)
        {
            if (other == null) return;
            if (other.accessPoint_ != null)
            {
                if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                AccessPoint.MergeFrom(other.AccessPoint);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (accessPoint_ == null) {
              AccessPoint = new Saltoapis.Nebula.AccessPoint.V1.AccessPoint();
            }
            input.ReadMessage(AccessPoint);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                            input.ReadMessage(AccessPoint);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the update of an access point.
    /// </summary>
    public sealed partial class AccessPointUpdated : IMessage<AccessPointUpdated>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessPointUpdated> _parser = new(() => new AccessPointUpdated());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessPointUpdated> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessPointUpdated()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessPointUpdated(AccessPointUpdated other) : this()
        {
            accessPoint_ = other.accessPoint_?.Clone();
            actor_ = other.actor_?.Clone();
            previousValues_ = other.previousValues_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessPointUpdated Clone() => new(this);
        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 1;
        private AccessPoint.V1.AccessPoint accessPoint_;

        /// <summary>
        /// Access point updated.
        /// </summary>
        public AccessPoint.V1.AccessPoint AccessPoint
        {
            get { return accessPoint_; }
            set
            {
                accessPoint_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who updated the access point.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        /// <summary>Field number for the "previous_values" field.</summary>
        public const int PreviousValuesFieldNumber = 3;
        private PreviousValues previousValues_;

        /// <summary>
        /// The previous values of the access point's fields that were changed.
        /// </summary>
        public PreviousValues PreviousValues
        {
            get { return previousValues_; }
            set
            {
                previousValues_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AccessPointUpdated);
        public bool Equals(AccessPointUpdated other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessPoint, other.AccessPoint)) || (!Equals(Actor, other.Actor))) return false;
            if (!Equals(PreviousValues, other.PreviousValues)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessPoint_ != null) hash ^= AccessPoint.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (previousValues_ != null) hash ^= PreviousValues.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (accessPoint_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessPoint);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (previousValues_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PreviousValues);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (accessPoint_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessPoint);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            if (previousValues_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(PreviousValues);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (accessPoint_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessPoint);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (previousValues_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(PreviousValues);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessPointUpdated other)
        {
            if (other == null) return;
            if (other.accessPoint_ != null)
            {
                if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                AccessPoint.MergeFrom(other.AccessPoint);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
            }
            if (other.previousValues_ != null)
            {
                if (previousValues_ == null) PreviousValues = new PreviousValues();
                PreviousValues.MergeFrom(other.PreviousValues);
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
            if (accessPoint_ == null) {
              AccessPoint = new Saltoapis.Nebula.AccessPoint.V1.AccessPoint();
            }
            input.ReadMessage(AccessPoint);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
            break;
          }
          case 26: {
            if (previousValues_ == null) {
              PreviousValues = new Saltoapis.Nebula.Event.V1.PreviousValues();
            }
            input.ReadMessage(PreviousValues);
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
                            if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                            input.ReadMessage(AccessPoint);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                    case 26:
                        {
                            if (previousValues_ == null) PreviousValues = new PreviousValues();
                            input.ReadMessage(PreviousValues);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the deletion of an access point.
    /// </summary>
    public sealed partial class AccessPointDeleted : IMessage<AccessPointDeleted>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessPointDeleted> _parser = new(() => new AccessPointDeleted());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessPointDeleted> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessPointDeleted()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessPointDeleted(AccessPointDeleted other) : this()
        {
            accessPoint_ = other.accessPoint_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessPointDeleted Clone() => new(this);
        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 1;
        private AccessPoint.V1.AccessPoint accessPoint_;

        /// <summary>
        /// Access point deleted.
        /// </summary>
        public AccessPoint.V1.AccessPoint AccessPoint
        {
            get { return accessPoint_; }
            set
            {
                accessPoint_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who deleted the access point.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AccessPointDeleted);
        public bool Equals(AccessPointDeleted other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessPoint, other.AccessPoint)) || (!Equals(Actor, other.Actor))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessPoint_ != null) hash ^= AccessPoint.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (accessPoint_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessPoint);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (accessPoint_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessPoint);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (accessPoint_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessPoint);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessPointDeleted other)
        {
            if (other == null) return;
            if (other.accessPoint_ != null)
            {
                if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                AccessPoint.MergeFrom(other.AccessPoint);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (accessPoint_ == null) {
              AccessPoint = new Saltoapis.Nebula.AccessPoint.V1.AccessPoint();
            }
            input.ReadMessage(AccessPoint);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                            input.ReadMessage(AccessPoint);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the unlocking of an access point.
    /// </summary>
    public sealed partial class AccessPointUnlocked : IMessage<AccessPointUnlocked>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessPointUnlocked> _parser = new(() => new AccessPointUnlocked());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessPointUnlocked> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessPointUnlocked()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessPointUnlocked(AccessPointUnlocked other) : this()
        {
            accessPoint_ = other.accessPoint_?.Clone();
            user_ = other.user_?.Clone();
            direction_ = other.direction_;
            switch (other.CredentialCase)
            {
                case CredentialOneofCase.EmergencyKey:
                    EmergencyKey = other.EmergencyKey.Clone();
                    break;
                case CredentialOneofCase.CardKey:
                    CardKey = other.CardKey.Clone();
                    break;
                case CredentialOneofCase.AppKey:
                    AppKey = other.AppKey.Clone();
                    break;
                case CredentialOneofCase.WalletKey:
                    WalletKey = other.WalletKey.Clone();
                    break;
                case CredentialOneofCase.Passcode:
                    Passcode = other.Passcode.Clone();
                    break;
                case CredentialOneofCase.ElectronicKey:
                    ElectronicKey = other.ElectronicKey.Clone();
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessPointUnlocked Clone() => new(this);
        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 1;
        private AccessPoint.V1.AccessPoint accessPoint_;

        /// <summary>
        /// The access point that's been unlocked.
        /// </summary>
        public AccessPoint.V1.AccessPoint AccessPoint
        {
            get { return accessPoint_; }
            set
            {
                accessPoint_ = value;
            }
        }

        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 2;
        private User.V1.User user_;

        /// <summary>
        /// The user who unlocked the access point, if any.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "emergency_key" field.</summary>
        public const int EmergencyKeyFieldNumber = 3;

        /// <summary>
        /// The emergency key used to unlock the access point.
        /// </summary>
        public Salto.Nebula.EmergencyKey.V1.EmergencyKey EmergencyKey
        {
            get { return credentialCase_ == CredentialOneofCase.EmergencyKey ? (Salto.Nebula.EmergencyKey.V1.EmergencyKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.EmergencyKey;
            }
        }

        /// <summary>Field number for the "card_key" field.</summary>
        public const int CardKeyFieldNumber = 4;

        /// <summary>
        /// The card key used to unlock the access point.
        /// </summary>
        public User.V1.CardKey CardKey
        {
            get { return credentialCase_ == CredentialOneofCase.CardKey ? (User.V1.CardKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.CardKey;
            }
        }

        /// <summary>Field number for the "app_key" field.</summary>
        public const int AppKeyFieldNumber = 5;

        /// <summary>
        /// The app key used to unlock the access point.
        /// </summary>
        public User.V1.AppKey AppKey
        {
            get { return credentialCase_ == CredentialOneofCase.AppKey ? (User.V1.AppKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.AppKey;
            }
        }

        /// <summary>Field number for the "wallet_key" field.</summary>
        public const int WalletKeyFieldNumber = 6;

        /// <summary>
        /// The wallet key used to unlock the access point.
        /// </summary>
        public User.V1.WalletKey WalletKey
        {
            get { return credentialCase_ == CredentialOneofCase.WalletKey ? (User.V1.WalletKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.WalletKey;
            }
        }

        /// <summary>Field number for the "passcode" field.</summary>
        public const int PasscodeFieldNumber = 7;

        /// <summary>
        /// The passcode used to unlock the access point.
        /// </summary>
        public User.V1.Passcode Passcode
        {
            get { return credentialCase_ == CredentialOneofCase.Passcode ? (User.V1.Passcode)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.Passcode;
            }
        }

        /// <summary>Field number for the "electronic_key" field.</summary>
        public const int ElectronicKeyFieldNumber = 9;

        /// <summary>
        /// The electronic key used to unlock the access point.
        /// </summary>
        public User.V1.ElectronicKey ElectronicKey
        {
            get { return credentialCase_ == CredentialOneofCase.ElectronicKey ? (User.V1.ElectronicKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.ElectronicKey;
            }
        }

        /// <summary>Field number for the "direction" field.</summary>
        public const int DirectionFieldNumber = 8;
        private Types.Direction direction_ = Types.Direction.Unspecified;

        /// <summary>
        /// Indicates the direction of passage for this unlock event.
        /// </summary>
        public Types.Direction Direction
        {
            get { return direction_; }
            set
            {
                direction_ = value;
            }
        }

        private object credential_;

        /// <summary>Enum of possible cases for the "credential" oneof.</summary>
        public enum CredentialOneofCase
        {
            None = 0,
            EmergencyKey = 3,
            CardKey = 4,
            AppKey = 5,
            WalletKey = 6,
            Passcode = 7,
            ElectronicKey = 9,
        }

        private CredentialOneofCase credentialCase_ = CredentialOneofCase.None;

        public CredentialOneofCase CredentialCase
        {
            get { return credentialCase_; }
        }

        public void ClearCredential()
        {
            credentialCase_ = CredentialOneofCase.None;
            credential_ = null;
        }

        public override bool Equals(object other) => Equals(other as AccessPointUnlocked);
        public bool Equals(AccessPointUnlocked other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessPoint, other.AccessPoint)) || (!Equals(User, other.User))) return false;
            if ((!Equals(EmergencyKey, other.EmergencyKey)) || (!Equals(CardKey, other.CardKey))) return false;
            if ((!Equals(AppKey, other.AppKey)) || (!Equals(WalletKey, other.WalletKey))) return false;
            if ((!Equals(Passcode, other.Passcode)) || (!Equals(ElectronicKey, other.ElectronicKey))) return false;
            if ((Direction != other.Direction) || (CredentialCase != other.CredentialCase)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessPoint_ != null) hash ^= AccessPoint.GetHashCode();
            if (user_ != null) hash ^= User.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.EmergencyKey) hash ^= EmergencyKey.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.CardKey) hash ^= CardKey.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.AppKey) hash ^= AppKey.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.WalletKey) hash ^= WalletKey.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.Passcode) hash ^= Passcode.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.ElectronicKey) hash ^= ElectronicKey.GetHashCode();
            if (Direction != Types.Direction.Unspecified) hash ^= Direction.GetHashCode();
            hash ^= (int)credentialCase_;
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (accessPoint_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessPoint);
      }
      if (user_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(User);
      }
      if (credentialCase_ == CredentialOneofCase.EmergencyKey) {
        output.WriteRawTag(26);
        output.WriteMessage(EmergencyKey);
      }
      if (credentialCase_ == CredentialOneofCase.CardKey) {
        output.WriteRawTag(34);
        output.WriteMessage(CardKey);
      }
      if (credentialCase_ == CredentialOneofCase.AppKey) {
        output.WriteRawTag(42);
        output.WriteMessage(AppKey);
      }
      if (credentialCase_ == CredentialOneofCase.WalletKey) {
        output.WriteRawTag(50);
        output.WriteMessage(WalletKey);
      }
      if (credentialCase_ == CredentialOneofCase.Passcode) {
        output.WriteRawTag(58);
        output.WriteMessage(Passcode);
      }
      if (Direction != Saltoapis.Nebula.Event.V1.AccessPointUnlocked.Types.Direction.Unspecified) {
        output.WriteRawTag(64);
        output.WriteEnum((int) Direction);
      }
      if (credentialCase_ == CredentialOneofCase.ElectronicKey) {
        output.WriteRawTag(74);
        output.WriteMessage(ElectronicKey);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (accessPoint_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessPoint);
            }
            if (user_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(User);
            }
            if (credentialCase_ == CredentialOneofCase.EmergencyKey)
            {
                output.WriteRawTag(26);
                output.WriteMessage(EmergencyKey);
            }
            if (credentialCase_ == CredentialOneofCase.CardKey)
            {
                output.WriteRawTag(34);
                output.WriteMessage(CardKey);
            }
            if (credentialCase_ == CredentialOneofCase.AppKey)
            {
                output.WriteRawTag(42);
                output.WriteMessage(AppKey);
            }
            if (credentialCase_ == CredentialOneofCase.WalletKey)
            {
                output.WriteRawTag(50);
                output.WriteMessage(WalletKey);
            }
            if (credentialCase_ == CredentialOneofCase.Passcode)
            {
                output.WriteRawTag(58);
                output.WriteMessage(Passcode);
            }
            if (Direction != Types.Direction.Unspecified)
            {
                output.WriteRawTag(64);
                output.WriteEnum((int)Direction);
            }
            if (credentialCase_ == CredentialOneofCase.ElectronicKey)
            {
                output.WriteRawTag(74);
                output.WriteMessage(ElectronicKey);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (accessPoint_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessPoint);
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (credentialCase_ == CredentialOneofCase.EmergencyKey) size += 1 + CodedOutputStream.ComputeMessageSize(EmergencyKey);
            if (credentialCase_ == CredentialOneofCase.CardKey) size += 1 + CodedOutputStream.ComputeMessageSize(CardKey);
            if (credentialCase_ == CredentialOneofCase.AppKey) size += 1 + CodedOutputStream.ComputeMessageSize(AppKey);
            if (credentialCase_ == CredentialOneofCase.WalletKey) size += 1 + CodedOutputStream.ComputeMessageSize(WalletKey);
            if (credentialCase_ == CredentialOneofCase.Passcode) size += 1 + CodedOutputStream.ComputeMessageSize(Passcode);
            if (credentialCase_ == CredentialOneofCase.ElectronicKey) size += 1 + CodedOutputStream.ComputeMessageSize(ElectronicKey);
            if (Direction != Types.Direction.Unspecified) size += 1 + CodedOutputStream.ComputeEnumSize((int)Direction);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessPointUnlocked other)
        {
            if (other == null) return;
            if (other.accessPoint_ != null)
            {
                if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                AccessPoint.MergeFrom(other.AccessPoint);
            }
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            if (other.Direction != Types.Direction.Unspecified) Direction = other.Direction;
            switch (other.CredentialCase)
            {
                case CredentialOneofCase.EmergencyKey:
                    if (EmergencyKey == null) EmergencyKey = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
                    EmergencyKey.MergeFrom(other.EmergencyKey);
                    break;
                case CredentialOneofCase.CardKey:
                    if (CardKey == null) CardKey = new User.V1.CardKey();
                    CardKey.MergeFrom(other.CardKey);
                    break;
                case CredentialOneofCase.AppKey:
                    if (AppKey == null) AppKey = new User.V1.AppKey();
                    AppKey.MergeFrom(other.AppKey);
                    break;
                case CredentialOneofCase.WalletKey:
                    if (WalletKey == null) WalletKey = new User.V1.WalletKey();
                    WalletKey.MergeFrom(other.WalletKey);
                    break;
                case CredentialOneofCase.Passcode:
                    if (Passcode == null) Passcode = new User.V1.Passcode();
                    Passcode.MergeFrom(other.Passcode);
                    break;
                case CredentialOneofCase.ElectronicKey:
                    if (ElectronicKey == null) ElectronicKey = new User.V1.ElectronicKey();
                    ElectronicKey.MergeFrom(other.ElectronicKey);
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
            if (accessPoint_ == null) {
              AccessPoint = new Saltoapis.Nebula.AccessPoint.V1.AccessPoint();
            }
            input.ReadMessage(AccessPoint);
            break;
          }
          case 18: {
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 26: {
            Salto.Nebula.EmergencyKey.V1.EmergencyKey subBuilder = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
            if (credentialCase_ == CredentialOneofCase.EmergencyKey) {
              subBuilder.MergeFrom(EmergencyKey);
            }
            input.ReadMessage(subBuilder);
            EmergencyKey = subBuilder;
            break;
          }
          case 34: {
            Saltoapis.Nebula.User.V1.CardKey subBuilder = new Saltoapis.Nebula.User.V1.CardKey();
            if (credentialCase_ == CredentialOneofCase.CardKey) {
              subBuilder.MergeFrom(CardKey);
            }
            input.ReadMessage(subBuilder);
            CardKey = subBuilder;
            break;
          }
          case 42: {
            Saltoapis.Nebula.User.V1.AppKey subBuilder = new Saltoapis.Nebula.User.V1.AppKey();
            if (credentialCase_ == CredentialOneofCase.AppKey) {
              subBuilder.MergeFrom(AppKey);
            }
            input.ReadMessage(subBuilder);
            AppKey = subBuilder;
            break;
          }
          case 50: {
            Saltoapis.Nebula.User.V1.WalletKey subBuilder = new Saltoapis.Nebula.User.V1.WalletKey();
            if (credentialCase_ == CredentialOneofCase.WalletKey) {
              subBuilder.MergeFrom(WalletKey);
            }
            input.ReadMessage(subBuilder);
            WalletKey = subBuilder;
            break;
          }
          case 58: {
            Saltoapis.Nebula.User.V1.Passcode subBuilder = new Saltoapis.Nebula.User.V1.Passcode();
            if (credentialCase_ == CredentialOneofCase.Passcode) {
              subBuilder.MergeFrom(Passcode);
            }
            input.ReadMessage(subBuilder);
            Passcode = subBuilder;
            break;
          }
          case 64: {
            Direction = (Saltoapis.Nebula.Event.V1.AccessPointUnlocked.Types.Direction) input.ReadEnum();
            break;
          }
          case 74: {
            Saltoapis.Nebula.User.V1.ElectronicKey subBuilder = new Saltoapis.Nebula.User.V1.ElectronicKey();
            if (credentialCase_ == CredentialOneofCase.ElectronicKey) {
              subBuilder.MergeFrom(ElectronicKey);
            }
            input.ReadMessage(subBuilder);
            ElectronicKey = subBuilder;
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
                            if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                            input.ReadMessage(AccessPoint);
                            break;
                        }
                    case 18:
                        {
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 26:
                        {
                            Salto.Nebula.EmergencyKey.V1.EmergencyKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.EmergencyKey) subBuilder.MergeFrom(EmergencyKey);
                            input.ReadMessage(subBuilder);
                            EmergencyKey = subBuilder;
                            break;
                        }
                    case 34:
                        {
                            User.V1.CardKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.CardKey) subBuilder.MergeFrom(CardKey);
                            input.ReadMessage(subBuilder);
                            CardKey = subBuilder;
                            break;
                        }
                    case 42:
                        {
                            User.V1.AppKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.AppKey) subBuilder.MergeFrom(AppKey);
                            input.ReadMessage(subBuilder);
                            AppKey = subBuilder;
                            break;
                        }
                    case 50:
                        {
                            User.V1.WalletKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.WalletKey) subBuilder.MergeFrom(WalletKey);
                            input.ReadMessage(subBuilder);
                            WalletKey = subBuilder;
                            break;
                        }
                    case 58:
                        {
                            User.V1.Passcode subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.Passcode) subBuilder.MergeFrom(Passcode);
                            input.ReadMessage(subBuilder);
                            Passcode = subBuilder;
                            break;
                        }
                    case 64:
                        {
                            Direction = (Types.Direction)input.ReadEnum();
                            break;
                        }
                    case 74:
                        {
                            User.V1.ElectronicKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.ElectronicKey) subBuilder.MergeFrom(ElectronicKey);
                            input.ReadMessage(subBuilder);
                            ElectronicKey = subBuilder;
                            break;
                        }
                }
            }
        }
#endif

        /// <summary>Container for nested types declared in the AccessPointUnlocked message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// Direction of passage through an access point.
            /// </summary>
            public enum Direction
            {
                /// <summary>
                /// Direction is not specified. Used for remote opening.
                /// </summary>
                [OriginalName("DIRECTION_UNSPECIFIED")] Unspecified = 0,
                /// <summary>
                /// Credential used to gain access from outside to inside.
                /// </summary>
                [OriginalName("ENTRY")] Entry = 1,
                /// <summary>
                /// Credential used to leave from inside to outside.
                /// </summary>
                [OriginalName("EXIT")] Exit = 2,
            }

        }

    }

    /// <summary>
    /// Event representing the locking of an access point.
    /// </summary>
    public sealed partial class AccessPointLocked : IMessage<AccessPointLocked>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessPointLocked> _parser = new(() => new AccessPointLocked());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessPointLocked> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessPointLocked()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessPointLocked(AccessPointLocked other) : this()
        {
            accessPoint_ = other.accessPoint_?.Clone();
            user_ = other.user_?.Clone();
            switch (other.CredentialCase)
            {
                case CredentialOneofCase.EmergencyKey:
                    EmergencyKey = other.EmergencyKey.Clone();
                    break;
                case CredentialOneofCase.CardKey:
                    CardKey = other.CardKey.Clone();
                    break;
                case CredentialOneofCase.AppKey:
                    AppKey = other.AppKey.Clone();
                    break;
                case CredentialOneofCase.WalletKey:
                    WalletKey = other.WalletKey.Clone();
                    break;
                case CredentialOneofCase.Passcode:
                    Passcode = other.Passcode.Clone();
                    break;
                case CredentialOneofCase.ElectronicKey:
                    ElectronicKey = other.ElectronicKey.Clone();
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessPointLocked Clone() => new(this);
        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 1;
        private AccessPoint.V1.AccessPoint accessPoint_;

        /// <summary>
        /// The access point that's been locked.
        /// </summary>
        public AccessPoint.V1.AccessPoint AccessPoint
        {
            get { return accessPoint_; }
            set
            {
                accessPoint_ = value;
            }
        }

        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 2;
        private User.V1.User user_;

        /// <summary>
        /// The user who locked the access point, if any.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "emergency_key" field.</summary>
        public const int EmergencyKeyFieldNumber = 3;

        /// <summary>
        /// The emergency key used to lock the access point.
        /// </summary>
        public Salto.Nebula.EmergencyKey.V1.EmergencyKey EmergencyKey
        {
            get { return credentialCase_ == CredentialOneofCase.EmergencyKey ? (Salto.Nebula.EmergencyKey.V1.EmergencyKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.EmergencyKey;
            }
        }

        /// <summary>Field number for the "card_key" field.</summary>
        public const int CardKeyFieldNumber = 4;

        /// <summary>
        /// The card key used to lock the access point.
        /// </summary>
        public User.V1.CardKey CardKey
        {
            get { return credentialCase_ == CredentialOneofCase.CardKey ? (User.V1.CardKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.CardKey;
            }
        }

        /// <summary>Field number for the "app_key" field.</summary>
        public const int AppKeyFieldNumber = 5;

        /// <summary>
        /// The app key used to lock the access point.
        /// </summary>
        public User.V1.AppKey AppKey
        {
            get { return credentialCase_ == CredentialOneofCase.AppKey ? (User.V1.AppKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.AppKey;
            }
        }

        /// <summary>Field number for the "wallet_key" field.</summary>
        public const int WalletKeyFieldNumber = 6;

        /// <summary>
        /// The wallet key used to lock the access point.
        /// </summary>
        public User.V1.WalletKey WalletKey
        {
            get { return credentialCase_ == CredentialOneofCase.WalletKey ? (User.V1.WalletKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.WalletKey;
            }
        }

        /// <summary>Field number for the "passcode" field.</summary>
        public const int PasscodeFieldNumber = 7;

        /// <summary>
        /// The passcode used to lock the access point.
        /// </summary>
        public User.V1.Passcode Passcode
        {
            get { return credentialCase_ == CredentialOneofCase.Passcode ? (User.V1.Passcode)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.Passcode;
            }
        }

        /// <summary>Field number for the "electronic_key" field.</summary>
        public const int ElectronicKeyFieldNumber = 8;

        /// <summary>
        /// The electronic key used to lock the access point.
        /// </summary>
        public User.V1.ElectronicKey ElectronicKey
        {
            get { return credentialCase_ == CredentialOneofCase.ElectronicKey ? (User.V1.ElectronicKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.ElectronicKey;
            }
        }

        private object credential_;

        /// <summary>Enum of possible cases for the "credential" oneof.</summary>
        public enum CredentialOneofCase
        {
            None = 0,
            EmergencyKey = 3,
            CardKey = 4,
            AppKey = 5,
            WalletKey = 6,
            Passcode = 7,
            ElectronicKey = 8,
        }

        private CredentialOneofCase credentialCase_ = CredentialOneofCase.None;

        public CredentialOneofCase CredentialCase
        {
            get { return credentialCase_; }
        }

        public void ClearCredential()
        {
            credentialCase_ = CredentialOneofCase.None;
            credential_ = null;
        }

        public override bool Equals(object other) => Equals(other as AccessPointLocked);
        public bool Equals(AccessPointLocked other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessPoint, other.AccessPoint)) || (!Equals(User, other.User))) return false;
            if ((!Equals(EmergencyKey, other.EmergencyKey)) || (!Equals(CardKey, other.CardKey))) return false;
            if ((!Equals(AppKey, other.AppKey)) || (!Equals(WalletKey, other.WalletKey))) return false;
            if ((!Equals(Passcode, other.Passcode)) || (!Equals(ElectronicKey, other.ElectronicKey))) return false;
            if (CredentialCase != other.CredentialCase) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessPoint_ != null) hash ^= AccessPoint.GetHashCode();
            if (user_ != null) hash ^= User.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.EmergencyKey) hash ^= EmergencyKey.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.CardKey) hash ^= CardKey.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.AppKey) hash ^= AppKey.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.WalletKey) hash ^= WalletKey.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.Passcode) hash ^= Passcode.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.ElectronicKey) hash ^= ElectronicKey.GetHashCode();
            hash ^= (int)credentialCase_;
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (accessPoint_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessPoint);
      }
      if (user_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(User);
      }
      if (credentialCase_ == CredentialOneofCase.EmergencyKey) {
        output.WriteRawTag(26);
        output.WriteMessage(EmergencyKey);
      }
      if (credentialCase_ == CredentialOneofCase.CardKey) {
        output.WriteRawTag(34);
        output.WriteMessage(CardKey);
      }
      if (credentialCase_ == CredentialOneofCase.AppKey) {
        output.WriteRawTag(42);
        output.WriteMessage(AppKey);
      }
      if (credentialCase_ == CredentialOneofCase.WalletKey) {
        output.WriteRawTag(50);
        output.WriteMessage(WalletKey);
      }
      if (credentialCase_ == CredentialOneofCase.Passcode) {
        output.WriteRawTag(58);
        output.WriteMessage(Passcode);
      }
      if (credentialCase_ == CredentialOneofCase.ElectronicKey) {
        output.WriteRawTag(66);
        output.WriteMessage(ElectronicKey);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (accessPoint_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessPoint);
            }
            if (user_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(User);
            }
            if (credentialCase_ == CredentialOneofCase.EmergencyKey)
            {
                output.WriteRawTag(26);
                output.WriteMessage(EmergencyKey);
            }
            if (credentialCase_ == CredentialOneofCase.CardKey)
            {
                output.WriteRawTag(34);
                output.WriteMessage(CardKey);
            }
            if (credentialCase_ == CredentialOneofCase.AppKey)
            {
                output.WriteRawTag(42);
                output.WriteMessage(AppKey);
            }
            if (credentialCase_ == CredentialOneofCase.WalletKey)
            {
                output.WriteRawTag(50);
                output.WriteMessage(WalletKey);
            }
            if (credentialCase_ == CredentialOneofCase.Passcode)
            {
                output.WriteRawTag(58);
                output.WriteMessage(Passcode);
            }
            if (credentialCase_ == CredentialOneofCase.ElectronicKey)
            {
                output.WriteRawTag(66);
                output.WriteMessage(ElectronicKey);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (accessPoint_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessPoint);
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (credentialCase_ == CredentialOneofCase.EmergencyKey) size += 1 + CodedOutputStream.ComputeMessageSize(EmergencyKey);
            if (credentialCase_ == CredentialOneofCase.CardKey) size += 1 + CodedOutputStream.ComputeMessageSize(CardKey);
            if (credentialCase_ == CredentialOneofCase.AppKey) size += 1 + CodedOutputStream.ComputeMessageSize(AppKey);
            if (credentialCase_ == CredentialOneofCase.WalletKey) size += 1 + CodedOutputStream.ComputeMessageSize(WalletKey);
            if (credentialCase_ == CredentialOneofCase.Passcode) size += 1 + CodedOutputStream.ComputeMessageSize(Passcode);
            if (credentialCase_ == CredentialOneofCase.ElectronicKey) size += 1 + CodedOutputStream.ComputeMessageSize(ElectronicKey);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessPointLocked other)
        {
            if (other == null) return;
            if (other.accessPoint_ != null)
            {
                if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                AccessPoint.MergeFrom(other.AccessPoint);
            }
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            switch (other.CredentialCase)
            {
                case CredentialOneofCase.EmergencyKey:
                    if (EmergencyKey == null) EmergencyKey = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
                    EmergencyKey.MergeFrom(other.EmergencyKey);
                    break;
                case CredentialOneofCase.CardKey:
                    if (CardKey == null) CardKey = new User.V1.CardKey();
                    CardKey.MergeFrom(other.CardKey);
                    break;
                case CredentialOneofCase.AppKey:
                    if (AppKey == null) AppKey = new User.V1.AppKey();
                    AppKey.MergeFrom(other.AppKey);
                    break;
                case CredentialOneofCase.WalletKey:
                    if (WalletKey == null) WalletKey = new User.V1.WalletKey();
                    WalletKey.MergeFrom(other.WalletKey);
                    break;
                case CredentialOneofCase.Passcode:
                    if (Passcode == null) Passcode = new User.V1.Passcode();
                    Passcode.MergeFrom(other.Passcode);
                    break;
                case CredentialOneofCase.ElectronicKey:
                    if (ElectronicKey == null) ElectronicKey = new User.V1.ElectronicKey();
                    ElectronicKey.MergeFrom(other.ElectronicKey);
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
            if (accessPoint_ == null) {
              AccessPoint = new Saltoapis.Nebula.AccessPoint.V1.AccessPoint();
            }
            input.ReadMessage(AccessPoint);
            break;
          }
          case 18: {
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 26: {
            Salto.Nebula.EmergencyKey.V1.EmergencyKey subBuilder = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
            if (credentialCase_ == CredentialOneofCase.EmergencyKey) {
              subBuilder.MergeFrom(EmergencyKey);
            }
            input.ReadMessage(subBuilder);
            EmergencyKey = subBuilder;
            break;
          }
          case 34: {
            Saltoapis.Nebula.User.V1.CardKey subBuilder = new Saltoapis.Nebula.User.V1.CardKey();
            if (credentialCase_ == CredentialOneofCase.CardKey) {
              subBuilder.MergeFrom(CardKey);
            }
            input.ReadMessage(subBuilder);
            CardKey = subBuilder;
            break;
          }
          case 42: {
            Saltoapis.Nebula.User.V1.AppKey subBuilder = new Saltoapis.Nebula.User.V1.AppKey();
            if (credentialCase_ == CredentialOneofCase.AppKey) {
              subBuilder.MergeFrom(AppKey);
            }
            input.ReadMessage(subBuilder);
            AppKey = subBuilder;
            break;
          }
          case 50: {
            Saltoapis.Nebula.User.V1.WalletKey subBuilder = new Saltoapis.Nebula.User.V1.WalletKey();
            if (credentialCase_ == CredentialOneofCase.WalletKey) {
              subBuilder.MergeFrom(WalletKey);
            }
            input.ReadMessage(subBuilder);
            WalletKey = subBuilder;
            break;
          }
          case 58: {
            Saltoapis.Nebula.User.V1.Passcode subBuilder = new Saltoapis.Nebula.User.V1.Passcode();
            if (credentialCase_ == CredentialOneofCase.Passcode) {
              subBuilder.MergeFrom(Passcode);
            }
            input.ReadMessage(subBuilder);
            Passcode = subBuilder;
            break;
          }
          case 66: {
            Saltoapis.Nebula.User.V1.ElectronicKey subBuilder = new Saltoapis.Nebula.User.V1.ElectronicKey();
            if (credentialCase_ == CredentialOneofCase.ElectronicKey) {
              subBuilder.MergeFrom(ElectronicKey);
            }
            input.ReadMessage(subBuilder);
            ElectronicKey = subBuilder;
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
                            if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                            input.ReadMessage(AccessPoint);
                            break;
                        }
                    case 18:
                        {
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 26:
                        {
                            Salto.Nebula.EmergencyKey.V1.EmergencyKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.EmergencyKey) subBuilder.MergeFrom(EmergencyKey);
                            input.ReadMessage(subBuilder);
                            EmergencyKey = subBuilder;
                            break;
                        }
                    case 34:
                        {
                            User.V1.CardKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.CardKey) subBuilder.MergeFrom(CardKey);
                            input.ReadMessage(subBuilder);
                            CardKey = subBuilder;
                            break;
                        }
                    case 42:
                        {
                            User.V1.AppKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.AppKey) subBuilder.MergeFrom(AppKey);
                            input.ReadMessage(subBuilder);
                            AppKey = subBuilder;
                            break;
                        }
                    case 50:
                        {
                            User.V1.WalletKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.WalletKey) subBuilder.MergeFrom(WalletKey);
                            input.ReadMessage(subBuilder);
                            WalletKey = subBuilder;
                            break;
                        }
                    case 58:
                        {
                            User.V1.Passcode subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.Passcode) subBuilder.MergeFrom(Passcode);
                            input.ReadMessage(subBuilder);
                            Passcode = subBuilder;
                            break;
                        }
                    case 66:
                        {
                            User.V1.ElectronicKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.ElectronicKey) subBuilder.MergeFrom(ElectronicKey);
                            input.ReadMessage(subBuilder);
                            ElectronicKey = subBuilder;
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing a forced open of an access point.
    /// </summary>
    public sealed partial class AccessPointForcedOpen : IMessage<AccessPointForcedOpen>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessPointForcedOpen> _parser = new(() => new AccessPointForcedOpen());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessPointForcedOpen> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessPointForcedOpen()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessPointForcedOpen(AccessPointForcedOpen other) : this()
        {
            accessPoint_ = other.accessPoint_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessPointForcedOpen Clone() => new(this);
        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 1;
        private AccessPoint.V1.AccessPoint accessPoint_;

        /// <summary>
        /// The access point that's been forced open.
        /// </summary>
        public AccessPoint.V1.AccessPoint AccessPoint
        {
            get { return accessPoint_; }
            set
            {
                accessPoint_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AccessPointForcedOpen);
        public bool Equals(AccessPointForcedOpen other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!Equals(AccessPoint, other.AccessPoint)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessPoint_ != null) hash ^= AccessPoint.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (accessPoint_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessPoint);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (accessPoint_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessPoint);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (accessPoint_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessPoint);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessPointForcedOpen other)
        {
            if (other == null) return;
            if (other.accessPoint_ != null)
            {
                if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                AccessPoint.MergeFrom(other.AccessPoint);
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
            if (accessPoint_ == null) {
              AccessPoint = new Saltoapis.Nebula.AccessPoint.V1.AccessPoint();
            }
            input.ReadMessage(AccessPoint);
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
                            if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                            input.ReadMessage(AccessPoint);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the closing of an access point.
    /// This event might not be triggered with all access point closures, but only
    /// with those that happen after events such as access point left open or forced
    /// open.
    /// </summary>
    public sealed partial class AccessPointClosed : IMessage<AccessPointClosed>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessPointClosed> _parser = new(() => new AccessPointClosed());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessPointClosed> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessPointClosed()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessPointClosed(AccessPointClosed other) : this()
        {
            accessPoint_ = other.accessPoint_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessPointClosed Clone() => new(this);
        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 1;
        private AccessPoint.V1.AccessPoint accessPoint_;

        /// <summary>
        /// The access point that's been closed.
        /// </summary>
        public AccessPoint.V1.AccessPoint AccessPoint
        {
            get { return accessPoint_; }
            set
            {
                accessPoint_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AccessPointClosed);
        public bool Equals(AccessPointClosed other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!Equals(AccessPoint, other.AccessPoint)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessPoint_ != null) hash ^= AccessPoint.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (accessPoint_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessPoint);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (accessPoint_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessPoint);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (accessPoint_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessPoint);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessPointClosed other)
        {
            if (other == null) return;
            if (other.accessPoint_ != null)
            {
                if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                AccessPoint.MergeFrom(other.AccessPoint);
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
            if (accessPoint_ == null) {
              AccessPoint = new Saltoapis.Nebula.AccessPoint.V1.AccessPoint();
            }
            input.ReadMessage(AccessPoint);
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
                            if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                            input.ReadMessage(AccessPoint);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing a denied access to a user by an access point.
    /// </summary>
    public sealed partial class AccessDenied : IMessage<AccessDenied>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessDenied> _parser = new(() => new AccessDenied());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessDenied> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[9]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessDenied()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessDenied(AccessDenied other) : this()
        {
            user_ = other.user_?.Clone();
            reason_ = other.reason_;
            switch (other.SourceCase)
            {
                case SourceOneofCase.AccessPoint:
                    AccessPoint = other.AccessPoint.Clone();
                    break;
                case SourceOneofCase.Controller:
                    Controller = other.Controller.Clone();
                    break;
            }

            switch (other.CredentialCase)
            {
                case CredentialOneofCase.EmergencyKey:
                    EmergencyKey = other.EmergencyKey.Clone();
                    break;
                case CredentialOneofCase.CardKey:
                    CardKey = other.CardKey.Clone();
                    break;
                case CredentialOneofCase.AppKey:
                    AppKey = other.AppKey.Clone();
                    break;
                case CredentialOneofCase.WalletKey:
                    WalletKey = other.WalletKey.Clone();
                    break;
                case CredentialOneofCase.Passcode:
                    Passcode = other.Passcode.Clone();
                    break;
                case CredentialOneofCase.ElectronicKey:
                    ElectronicKey = other.ElectronicKey.Clone();
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessDenied Clone() => new(this);
        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 1;

        /// <summary>
        /// Access denied by the access point.
        /// </summary>
        public AccessPoint.V1.AccessPoint AccessPoint
        {
            get { return sourceCase_ == SourceOneofCase.AccessPoint ? (AccessPoint.V1.AccessPoint)source_ : null; }
            set
            {
                source_ = value;
                sourceCase_ = value == null ? SourceOneofCase.None : SourceOneofCase.AccessPoint;
            }
        }

        /// <summary>Field number for the "controller" field.</summary>
        public const int ControllerFieldNumber = 10;

        /// <summary>
        /// Access denied by the controller.
        /// </summary>
        public Controller.V1.Controller Controller
        {
            get { return sourceCase_ == SourceOneofCase.Controller ? (Controller.V1.Controller)source_ : null; }
            set
            {
                source_ = value;
                sourceCase_ = value == null ? SourceOneofCase.None : SourceOneofCase.Controller;
            }
        }

        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 2;
        private User.V1.User user_;

        /// <summary>
        /// The user whose access was rejected.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "reason" field.</summary>
        public const int ReasonFieldNumber = 3;
        private Types.Reason reason_ = Types.Reason.Unspecified;

        /// <summary>
        /// The reason for the access denial.
        /// </summary>
        public Types.Reason Reason
        {
            get { return reason_; }
            set
            {
                reason_ = value;
            }
        }

        /// <summary>Field number for the "emergency_key" field.</summary>
        public const int EmergencyKeyFieldNumber = 4;

        /// <summary>
        /// The emergency key used to attempt access to the access point.
        /// </summary>
        public Salto.Nebula.EmergencyKey.V1.EmergencyKey EmergencyKey
        {
            get { return credentialCase_ == CredentialOneofCase.EmergencyKey ? (Salto.Nebula.EmergencyKey.V1.EmergencyKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.EmergencyKey;
            }
        }

        /// <summary>Field number for the "card_key" field.</summary>
        public const int CardKeyFieldNumber = 5;

        /// <summary>
        /// The card key used to attempt access to the access point.
        /// </summary>
        public User.V1.CardKey CardKey
        {
            get { return credentialCase_ == CredentialOneofCase.CardKey ? (User.V1.CardKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.CardKey;
            }
        }

        /// <summary>Field number for the "app_key" field.</summary>
        public const int AppKeyFieldNumber = 6;

        /// <summary>
        /// The app key used to attempt access to the access point.
        /// </summary>
        public User.V1.AppKey AppKey
        {
            get { return credentialCase_ == CredentialOneofCase.AppKey ? (User.V1.AppKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.AppKey;
            }
        }

        /// <summary>Field number for the "wallet_key" field.</summary>
        public const int WalletKeyFieldNumber = 7;

        /// <summary>
        /// The wallet key used to attempt access to the access point.
        /// </summary>
        public User.V1.WalletKey WalletKey
        {
            get { return credentialCase_ == CredentialOneofCase.WalletKey ? (User.V1.WalletKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.WalletKey;
            }
        }

        /// <summary>Field number for the "passcode" field.</summary>
        public const int PasscodeFieldNumber = 8;

        /// <summary>
        /// The passcode used to attempt access to the access point.
        /// </summary>
        public User.V1.Passcode Passcode
        {
            get { return credentialCase_ == CredentialOneofCase.Passcode ? (User.V1.Passcode)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.Passcode;
            }
        }

        /// <summary>Field number for the "electronic_key" field.</summary>
        public const int ElectronicKeyFieldNumber = 9;

        /// <summary>
        /// The electronic key used to attempt access to the access point.
        /// </summary>
        public User.V1.ElectronicKey ElectronicKey
        {
            get { return credentialCase_ == CredentialOneofCase.ElectronicKey ? (User.V1.ElectronicKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.ElectronicKey;
            }
        }

        private object source_;

        /// <summary>Enum of possible cases for the "source" oneof.</summary>
        public enum SourceOneofCase
        {
            None = 0,
            AccessPoint = 1,
            Controller = 10,
        }

        private SourceOneofCase sourceCase_ = SourceOneofCase.None;

        public SourceOneofCase SourceCase
        {
            get { return sourceCase_; }
        }

        public void ClearSource()
        {
            sourceCase_ = SourceOneofCase.None;
            source_ = null;
        }

        private object credential_;

        /// <summary>Enum of possible cases for the "credential" oneof.</summary>
        public enum CredentialOneofCase
        {
            None = 0,
            EmergencyKey = 4,
            CardKey = 5,
            AppKey = 6,
            WalletKey = 7,
            Passcode = 8,
            ElectronicKey = 9,
        }

        private CredentialOneofCase credentialCase_ = CredentialOneofCase.None;

        public CredentialOneofCase CredentialCase
        {
            get { return credentialCase_; }
        }

        public void ClearCredential()
        {
            credentialCase_ = CredentialOneofCase.None;
            credential_ = null;
        }

        public override bool Equals(object other) => Equals(other as AccessDenied);
        public bool Equals(AccessDenied other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessPoint, other.AccessPoint)) || (!Equals(Controller, other.Controller))) return false;
            if ((!Equals(User, other.User)) || (Reason != other.Reason)) return false;
            if ((!Equals(EmergencyKey, other.EmergencyKey)) || (!Equals(CardKey, other.CardKey))) return false;
            if ((!Equals(AppKey, other.AppKey)) || (!Equals(WalletKey, other.WalletKey))) return false;
            if ((!Equals(Passcode, other.Passcode)) || (!Equals(ElectronicKey, other.ElectronicKey))) return false;
            if ((SourceCase != other.SourceCase) || (CredentialCase != other.CredentialCase)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (sourceCase_ == SourceOneofCase.AccessPoint) hash ^= AccessPoint.GetHashCode();
            if (sourceCase_ == SourceOneofCase.Controller) hash ^= Controller.GetHashCode();
            if (user_ != null) hash ^= User.GetHashCode();
            if (Reason != Types.Reason.Unspecified) hash ^= Reason.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.EmergencyKey) hash ^= EmergencyKey.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.CardKey) hash ^= CardKey.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.AppKey) hash ^= AppKey.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.WalletKey) hash ^= WalletKey.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.Passcode) hash ^= Passcode.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.ElectronicKey) hash ^= ElectronicKey.GetHashCode();
            hash ^= (int)sourceCase_;
            hash ^= (int)credentialCase_;
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (sourceCase_ == SourceOneofCase.AccessPoint) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessPoint);
      }
      if (user_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(User);
      }
      if (Reason != Saltoapis.Nebula.Event.V1.AccessDenied.Types.Reason.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Reason);
      }
      if (credentialCase_ == CredentialOneofCase.EmergencyKey) {
        output.WriteRawTag(34);
        output.WriteMessage(EmergencyKey);
      }
      if (credentialCase_ == CredentialOneofCase.CardKey) {
        output.WriteRawTag(42);
        output.WriteMessage(CardKey);
      }
      if (credentialCase_ == CredentialOneofCase.AppKey) {
        output.WriteRawTag(50);
        output.WriteMessage(AppKey);
      }
      if (credentialCase_ == CredentialOneofCase.WalletKey) {
        output.WriteRawTag(58);
        output.WriteMessage(WalletKey);
      }
      if (credentialCase_ == CredentialOneofCase.Passcode) {
        output.WriteRawTag(66);
        output.WriteMessage(Passcode);
      }
      if (credentialCase_ == CredentialOneofCase.ElectronicKey) {
        output.WriteRawTag(74);
        output.WriteMessage(ElectronicKey);
      }
      if (sourceCase_ == SourceOneofCase.Controller) {
        output.WriteRawTag(82);
        output.WriteMessage(Controller);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (sourceCase_ == SourceOneofCase.AccessPoint)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessPoint);
            }
            if (user_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(User);
            }
            if (Reason != Types.Reason.Unspecified)
            {
                output.WriteRawTag(24);
                output.WriteEnum((int)Reason);
            }
            if (credentialCase_ == CredentialOneofCase.EmergencyKey)
            {
                output.WriteRawTag(34);
                output.WriteMessage(EmergencyKey);
            }
            if (credentialCase_ == CredentialOneofCase.CardKey)
            {
                output.WriteRawTag(42);
                output.WriteMessage(CardKey);
            }
            if (credentialCase_ == CredentialOneofCase.AppKey)
            {
                output.WriteRawTag(50);
                output.WriteMessage(AppKey);
            }
            if (credentialCase_ == CredentialOneofCase.WalletKey)
            {
                output.WriteRawTag(58);
                output.WriteMessage(WalletKey);
            }
            if (credentialCase_ == CredentialOneofCase.Passcode)
            {
                output.WriteRawTag(66);
                output.WriteMessage(Passcode);
            }
            if (credentialCase_ == CredentialOneofCase.ElectronicKey)
            {
                output.WriteRawTag(74);
                output.WriteMessage(ElectronicKey);
            }
            if (sourceCase_ == SourceOneofCase.Controller)
            {
                output.WriteRawTag(82);
                output.WriteMessage(Controller);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (sourceCase_ == SourceOneofCase.AccessPoint) size += 1 + CodedOutputStream.ComputeMessageSize(AccessPoint);
            if (sourceCase_ == SourceOneofCase.Controller) size += 1 + CodedOutputStream.ComputeMessageSize(Controller);
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (Reason != Types.Reason.Unspecified) size += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
            if (credentialCase_ == CredentialOneofCase.EmergencyKey) size += 1 + CodedOutputStream.ComputeMessageSize(EmergencyKey);
            if (credentialCase_ == CredentialOneofCase.CardKey) size += 1 + CodedOutputStream.ComputeMessageSize(CardKey);
            if (credentialCase_ == CredentialOneofCase.AppKey) size += 1 + CodedOutputStream.ComputeMessageSize(AppKey);
            if (credentialCase_ == CredentialOneofCase.WalletKey) size += 1 + CodedOutputStream.ComputeMessageSize(WalletKey);
            if (credentialCase_ == CredentialOneofCase.Passcode) size += 1 + CodedOutputStream.ComputeMessageSize(Passcode);
            if (credentialCase_ == CredentialOneofCase.ElectronicKey) size += 1 + CodedOutputStream.ComputeMessageSize(ElectronicKey);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessDenied other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            if (other.Reason != Types.Reason.Unspecified) Reason = other.Reason;
            switch (other.SourceCase)
            {
                case SourceOneofCase.AccessPoint:
                    if (AccessPoint == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                    AccessPoint.MergeFrom(other.AccessPoint);
                    break;
                case SourceOneofCase.Controller:
                    if (Controller == null) Controller = new Controller.V1.Controller();
                    Controller.MergeFrom(other.Controller);
                    break;
            }

            switch (other.CredentialCase)
            {
                case CredentialOneofCase.EmergencyKey:
                    if (EmergencyKey == null) EmergencyKey = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
                    EmergencyKey.MergeFrom(other.EmergencyKey);
                    break;
                case CredentialOneofCase.CardKey:
                    if (CardKey == null) CardKey = new User.V1.CardKey();
                    CardKey.MergeFrom(other.CardKey);
                    break;
                case CredentialOneofCase.AppKey:
                    if (AppKey == null) AppKey = new User.V1.AppKey();
                    AppKey.MergeFrom(other.AppKey);
                    break;
                case CredentialOneofCase.WalletKey:
                    if (WalletKey == null) WalletKey = new User.V1.WalletKey();
                    WalletKey.MergeFrom(other.WalletKey);
                    break;
                case CredentialOneofCase.Passcode:
                    if (Passcode == null) Passcode = new User.V1.Passcode();
                    Passcode.MergeFrom(other.Passcode);
                    break;
                case CredentialOneofCase.ElectronicKey:
                    if (ElectronicKey == null) ElectronicKey = new User.V1.ElectronicKey();
                    ElectronicKey.MergeFrom(other.ElectronicKey);
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
            Saltoapis.Nebula.AccessPoint.V1.AccessPoint subBuilder = new Saltoapis.Nebula.AccessPoint.V1.AccessPoint();
            if (sourceCase_ == SourceOneofCase.AccessPoint) {
              subBuilder.MergeFrom(AccessPoint);
            }
            input.ReadMessage(subBuilder);
            AccessPoint = subBuilder;
            break;
          }
          case 18: {
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 24: {
            Reason = (Saltoapis.Nebula.Event.V1.AccessDenied.Types.Reason) input.ReadEnum();
            break;
          }
          case 34: {
            Salto.Nebula.EmergencyKey.V1.EmergencyKey subBuilder = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
            if (credentialCase_ == CredentialOneofCase.EmergencyKey) {
              subBuilder.MergeFrom(EmergencyKey);
            }
            input.ReadMessage(subBuilder);
            EmergencyKey = subBuilder;
            break;
          }
          case 42: {
            Saltoapis.Nebula.User.V1.CardKey subBuilder = new Saltoapis.Nebula.User.V1.CardKey();
            if (credentialCase_ == CredentialOneofCase.CardKey) {
              subBuilder.MergeFrom(CardKey);
            }
            input.ReadMessage(subBuilder);
            CardKey = subBuilder;
            break;
          }
          case 50: {
            Saltoapis.Nebula.User.V1.AppKey subBuilder = new Saltoapis.Nebula.User.V1.AppKey();
            if (credentialCase_ == CredentialOneofCase.AppKey) {
              subBuilder.MergeFrom(AppKey);
            }
            input.ReadMessage(subBuilder);
            AppKey = subBuilder;
            break;
          }
          case 58: {
            Saltoapis.Nebula.User.V1.WalletKey subBuilder = new Saltoapis.Nebula.User.V1.WalletKey();
            if (credentialCase_ == CredentialOneofCase.WalletKey) {
              subBuilder.MergeFrom(WalletKey);
            }
            input.ReadMessage(subBuilder);
            WalletKey = subBuilder;
            break;
          }
          case 66: {
            Saltoapis.Nebula.User.V1.Passcode subBuilder = new Saltoapis.Nebula.User.V1.Passcode();
            if (credentialCase_ == CredentialOneofCase.Passcode) {
              subBuilder.MergeFrom(Passcode);
            }
            input.ReadMessage(subBuilder);
            Passcode = subBuilder;
            break;
          }
          case 74: {
            Saltoapis.Nebula.User.V1.ElectronicKey subBuilder = new Saltoapis.Nebula.User.V1.ElectronicKey();
            if (credentialCase_ == CredentialOneofCase.ElectronicKey) {
              subBuilder.MergeFrom(ElectronicKey);
            }
            input.ReadMessage(subBuilder);
            ElectronicKey = subBuilder;
            break;
          }
          case 82: {
            Saltoapis.Nebula.Controller.V1.Controller subBuilder = new Saltoapis.Nebula.Controller.V1.Controller();
            if (sourceCase_ == SourceOneofCase.Controller) {
              subBuilder.MergeFrom(Controller);
            }
            input.ReadMessage(subBuilder);
            Controller = subBuilder;
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
                            AccessPoint.V1.AccessPoint subBuilder = new();
                            if (sourceCase_ == SourceOneofCase.AccessPoint) subBuilder.MergeFrom(AccessPoint);
                            input.ReadMessage(subBuilder);
                            AccessPoint = subBuilder;
                            break;
                        }
                    case 18:
                        {
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 24:
                        {
                            Reason = (Types.Reason)input.ReadEnum();
                            break;
                        }
                    case 34:
                        {
                            Salto.Nebula.EmergencyKey.V1.EmergencyKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.EmergencyKey) subBuilder.MergeFrom(EmergencyKey);
                            input.ReadMessage(subBuilder);
                            EmergencyKey = subBuilder;
                            break;
                        }
                    case 42:
                        {
                            User.V1.CardKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.CardKey) subBuilder.MergeFrom(CardKey);
                            input.ReadMessage(subBuilder);
                            CardKey = subBuilder;
                            break;
                        }
                    case 50:
                        {
                            User.V1.AppKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.AppKey) subBuilder.MergeFrom(AppKey);
                            input.ReadMessage(subBuilder);
                            AppKey = subBuilder;
                            break;
                        }
                    case 58:
                        {
                            User.V1.WalletKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.WalletKey) subBuilder.MergeFrom(WalletKey);
                            input.ReadMessage(subBuilder);
                            WalletKey = subBuilder;
                            break;
                        }
                    case 66:
                        {
                            User.V1.Passcode subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.Passcode) subBuilder.MergeFrom(Passcode);
                            input.ReadMessage(subBuilder);
                            Passcode = subBuilder;
                            break;
                        }
                    case 74:
                        {
                            User.V1.ElectronicKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.ElectronicKey) subBuilder.MergeFrom(ElectronicKey);
                            input.ReadMessage(subBuilder);
                            ElectronicKey = subBuilder;
                            break;
                        }
                    case 82:
                        {
                            Controller.V1.Controller subBuilder = new();
                            if (sourceCase_ == SourceOneofCase.Controller) subBuilder.MergeFrom(Controller);
                            input.ReadMessage(subBuilder);
                            Controller = subBuilder;
                            break;
                        }
                }
            }
        }
#endif

        /// <summary>Container for nested types declared in the AccessDenied message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// The reason for the access denial.
            /// </summary>
            public enum Reason
            {
                /// <summary>
                /// The reason is not specified.
                /// </summary>
                [OriginalName("REASON_UNSPECIFIED")] Unspecified = 0,
                /// <summary>
                /// The presented credential has expired and is no longer valid.
                /// Example: the user's expiration date has passed.
                /// Example: the user's key has expired. To prevent this,
                /// renew the key before the installation's key-renewal-duration ends.
                /// </summary>
                [OriginalName("CREDENTIAL_EXPIRED")] CredentialExpired = 1,
                /// <summary>
                /// The provided key is not yet activated.
                /// The key's activation date and time are scheduled for a future moment.
                /// Example: the user's activation date has not yet been reached.
                /// </summary>
                [OriginalName("CREDENTIAL_UNACTIVATED")] CredentialUnactivated = 2,
                /// <summary>
                /// The provided credential does not have the required permission.
                /// Example: the user does not have permission to access the access point.
                /// </summary>
                [OriginalName("CREDENTIAL_PERMISSION_INSUFFICIENT")] CredentialPermissionInsufficient = 3,
                /// <summary>
                /// The provided credential is permitted within the allowed schedule
                /// but the permission is not activated at this time.
                /// Example: access attempted before the activation date of the permission.
                /// Example: access attempted after the expiration date of the permission.
                /// </summary>
                [OriginalName("CREDENTIAL_PERMISSION_OUTSIDE_VALIDITY")] CredentialPermissionOutsideValidity = 4,
                /// <summary>
                /// The provided credential is not permitted within the allowed schedule.
                /// Example: access attempted on a weekend for a weekday-only schedule.
                /// Example: access attempted at 8 PM for a 9 AM-5 PM schedule).
                /// </summary>
                [OriginalName("CREDENTIAL_PERMISSION_OUTSIDE_SCHEDULE")] CredentialPermissionOutsideSchedule = 5,
                /// <summary>
                /// The provided access code is invalid. Access codes are numeric passcodes
                /// entered by users on a device keypad to gain access.
                /// An access code may be considered invalid either if the entered digits
                /// are incorrect or if the code does not meet required formatting rules.
                /// </summary>
                [OriginalName("INVALID_ACCESS_CODE")] InvalidAccessCode = 6,
                /// <summary>
                /// The device at which the credential was presented has insufficient battery level
                /// and cannot process the access request.
                /// </summary>
                [OriginalName("DEVICE_BATTERY_INSUFFICIENT")] DeviceBatteryInsufficient = 7,
                /// <summary>
                /// The credential does not have permission to override the Do Not Disturb
                /// mode that is active on the device.
                ///
                /// Example: a user without the Do Not Disturb override permission attempts
                /// to unlock a device while its Do Not Disturb mode is active.
                /// </summary>
                [OriginalName("CREDENTIAL_DO_NOT_DISTURB_OVERRIDE_PERMISSION_NOT_PRESENT")] CredentialDoNotDisturbOverridePermissionNotPresent = 8,
            }

        }

    }

    /// <summary>
    /// Event representing the detection of an access point that's been left open.
    /// </summary>
    public sealed partial class AccessPointLeftOpen : IMessage<AccessPointLeftOpen>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessPointLeftOpen> _parser = new(() => new AccessPointLeftOpen());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessPointLeftOpen> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessPointLeftOpen()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessPointLeftOpen(AccessPointLeftOpen other) : this()
        {
            accessPoint_ = other.accessPoint_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessPointLeftOpen Clone() => new(this);
        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 1;
        private AccessPoint.V1.AccessPoint accessPoint_;

        /// <summary>
        /// The access point that's been left open.
        /// </summary>
        public AccessPoint.V1.AccessPoint AccessPoint
        {
            get { return accessPoint_; }
            set
            {
                accessPoint_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AccessPointLeftOpen);
        public bool Equals(AccessPointLeftOpen other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!Equals(AccessPoint, other.AccessPoint)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessPoint_ != null) hash ^= AccessPoint.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (accessPoint_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessPoint);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (accessPoint_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessPoint);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (accessPoint_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessPoint);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessPointLeftOpen other)
        {
            if (other == null) return;
            if (other.accessPoint_ != null)
            {
                if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                AccessPoint.MergeFrom(other.AccessPoint);
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
            if (accessPoint_ == null) {
              AccessPoint = new Saltoapis.Nebula.AccessPoint.V1.AccessPoint();
            }
            input.ReadMessage(AccessPoint);
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
                            if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                            input.ReadMessage(AccessPoint);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the creation of an access right.
    /// </summary>
    public sealed partial class AccessRightCreated : IMessage<AccessRightCreated>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessRightCreated> _parser = new(() => new AccessRightCreated());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessRightCreated> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[11]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessRightCreated()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessRightCreated(AccessRightCreated other) : this()
        {
            accessRight_ = other.accessRight_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessRightCreated Clone() => new(this);
        /// <summary>Field number for the "access_right" field.</summary>
        public const int AccessRightFieldNumber = 1;
        private AccessRight.V1.AccessRight accessRight_;

        /// <summary>
        /// Access right created.
        /// </summary>
        public AccessRight.V1.AccessRight AccessRight
        {
            get { return accessRight_; }
            set
            {
                accessRight_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who created the access right.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AccessRightCreated);
        public bool Equals(AccessRightCreated other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessRight, other.AccessRight)) || (!Equals(Actor, other.Actor))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessRight_ != null) hash ^= AccessRight.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (accessRight_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessRight);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (accessRight_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessRight);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (accessRight_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessRight);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessRightCreated other)
        {
            if (other == null) return;
            if (other.accessRight_ != null)
            {
                if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                AccessRight.MergeFrom(other.AccessRight);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (accessRight_ == null) {
              AccessRight = new Saltoapis.Nebula.AccessRight.V1.AccessRight();
            }
            input.ReadMessage(AccessRight);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                            input.ReadMessage(AccessRight);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the update of an access right.
    /// </summary>
    public sealed partial class AccessRightUpdated : IMessage<AccessRightUpdated>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessRightUpdated> _parser = new(() => new AccessRightUpdated());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessRightUpdated> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[12]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessRightUpdated()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessRightUpdated(AccessRightUpdated other) : this()
        {
            accessRight_ = other.accessRight_?.Clone();
            actor_ = other.actor_?.Clone();
            previousValues_ = other.previousValues_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessRightUpdated Clone() => new(this);
        /// <summary>Field number for the "access_right" field.</summary>
        public const int AccessRightFieldNumber = 1;
        private AccessRight.V1.AccessRight accessRight_;

        /// <summary>
        /// Access right updated.
        /// </summary>
        public AccessRight.V1.AccessRight AccessRight
        {
            get { return accessRight_; }
            set
            {
                accessRight_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who updated the access right.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        /// <summary>Field number for the "previous_values" field.</summary>
        public const int PreviousValuesFieldNumber = 3;
        private PreviousValues previousValues_;

        /// <summary>
        /// The previous values of the access right's fields that were changed.
        /// </summary>
        public PreviousValues PreviousValues
        {
            get { return previousValues_; }
            set
            {
                previousValues_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AccessRightUpdated);
        public bool Equals(AccessRightUpdated other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessRight, other.AccessRight)) || (!Equals(Actor, other.Actor))) return false;
            if (!Equals(PreviousValues, other.PreviousValues)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessRight_ != null) hash ^= AccessRight.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (previousValues_ != null) hash ^= PreviousValues.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (accessRight_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessRight);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (previousValues_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PreviousValues);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (accessRight_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessRight);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            if (previousValues_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(PreviousValues);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (accessRight_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessRight);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (previousValues_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(PreviousValues);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessRightUpdated other)
        {
            if (other == null) return;
            if (other.accessRight_ != null)
            {
                if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                AccessRight.MergeFrom(other.AccessRight);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
            }
            if (other.previousValues_ != null)
            {
                if (previousValues_ == null) PreviousValues = new PreviousValues();
                PreviousValues.MergeFrom(other.PreviousValues);
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
            if (accessRight_ == null) {
              AccessRight = new Saltoapis.Nebula.AccessRight.V1.AccessRight();
            }
            input.ReadMessage(AccessRight);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
            break;
          }
          case 26: {
            if (previousValues_ == null) {
              PreviousValues = new Saltoapis.Nebula.Event.V1.PreviousValues();
            }
            input.ReadMessage(PreviousValues);
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
                            if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                            input.ReadMessage(AccessRight);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                    case 26:
                        {
                            if (previousValues_ == null) PreviousValues = new PreviousValues();
                            input.ReadMessage(PreviousValues);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the deletion of an access right.
    /// </summary>
    public sealed partial class AccessRightDeleted : IMessage<AccessRightDeleted>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessRightDeleted> _parser = new(() => new AccessRightDeleted());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessRightDeleted> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessRightDeleted()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessRightDeleted(AccessRightDeleted other) : this()
        {
            accessRight_ = other.accessRight_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessRightDeleted Clone() => new(this);
        /// <summary>Field number for the "access_right" field.</summary>
        public const int AccessRightFieldNumber = 1;
        private AccessRight.V1.AccessRight accessRight_;

        /// <summary>
        /// Access right deleted.
        /// </summary>
        public AccessRight.V1.AccessRight AccessRight
        {
            get { return accessRight_; }
            set
            {
                accessRight_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who deleted the access right.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AccessRightDeleted);
        public bool Equals(AccessRightDeleted other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessRight, other.AccessRight)) || (!Equals(Actor, other.Actor))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessRight_ != null) hash ^= AccessRight.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (accessRight_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessRight);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (accessRight_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessRight);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (accessRight_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessRight);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessRightDeleted other)
        {
            if (other == null) return;
            if (other.accessRight_ != null)
            {
                if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                AccessRight.MergeFrom(other.AccessRight);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (accessRight_ == null) {
              AccessRight = new Saltoapis.Nebula.AccessRight.V1.AccessRight();
            }
            input.ReadMessage(AccessRight);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                            input.ReadMessage(AccessRight);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the creation of an access right's access point association.
    /// </summary>
    public sealed partial class AccessRightAccessPointCreated : IMessage<AccessRightAccessPointCreated>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessRightAccessPointCreated> _parser = new(() => new AccessRightAccessPointCreated());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessRightAccessPointCreated> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[14]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessRightAccessPointCreated()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessRightAccessPointCreated(AccessRightAccessPointCreated other) : this()
        {
            accessRight_ = other.accessRight_?.Clone();
            accessPoint_ = other.accessPoint_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessRightAccessPointCreated Clone() => new(this);
        /// <summary>Field number for the "access_right" field.</summary>
        public const int AccessRightFieldNumber = 1;
        private AccessRight.V1.AccessRight accessRight_;

        /// <summary>
        /// Access point's access right association created.
        /// </summary>
        public AccessRight.V1.AccessRight AccessRight
        {
            get { return accessRight_; }
            set
            {
                accessRight_ = value;
            }
        }

        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 2;
        private AccessPoint.V1.AccessPoint accessPoint_;

        /// <summary>
        /// Access right's access point association created.
        /// </summary>
        public AccessPoint.V1.AccessPoint AccessPoint
        {
            get { return accessPoint_; }
            set
            {
                accessPoint_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 3;
        private Principal actor_;

        /// <summary>
        /// The actor who created the access right's access point association.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AccessRightAccessPointCreated);
        public bool Equals(AccessRightAccessPointCreated other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessRight, other.AccessRight)) || (!Equals(AccessPoint, other.AccessPoint))) return false;
            if (!Equals(Actor, other.Actor)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessRight_ != null) hash ^= AccessRight.GetHashCode();
            if (accessPoint_ != null) hash ^= AccessPoint.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (accessRight_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessRight);
      }
      if (accessPoint_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AccessPoint);
      }
      if (actor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (accessRight_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessRight);
            }
            if (accessPoint_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(AccessPoint);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (accessRight_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessRight);
            if (accessPoint_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessPoint);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessRightAccessPointCreated other)
        {
            if (other == null) return;
            if (other.accessRight_ != null)
            {
                if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                AccessRight.MergeFrom(other.AccessRight);
            }
            if (other.accessPoint_ != null)
            {
                if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                AccessPoint.MergeFrom(other.AccessPoint);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (accessRight_ == null) {
              AccessRight = new Saltoapis.Nebula.AccessRight.V1.AccessRight();
            }
            input.ReadMessage(AccessRight);
            break;
          }
          case 18: {
            if (accessPoint_ == null) {
              AccessPoint = new Saltoapis.Nebula.AccessPoint.V1.AccessPoint();
            }
            input.ReadMessage(AccessPoint);
            break;
          }
          case 26: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                            input.ReadMessage(AccessRight);
                            break;
                        }
                    case 18:
                        {
                            if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                            input.ReadMessage(AccessPoint);
                            break;
                        }
                    case 26:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the creation of multiple access right's access points association.
    /// </summary>
    public sealed partial class AccessRightAccessPointsBatchCreated : IMessage<AccessRightAccessPointsBatchCreated>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessRightAccessPointsBatchCreated> _parser = new(() => new AccessRightAccessPointsBatchCreated());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessRightAccessPointsBatchCreated> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[15]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessRightAccessPointsBatchCreated()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessRightAccessPointsBatchCreated(AccessRightAccessPointsBatchCreated other) : this()
        {
            accessRight_ = other.accessRight_?.Clone();
            accessPoints_ = other.accessPoints_.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessRightAccessPointsBatchCreated Clone() => new(this);
        /// <summary>Field number for the "access_right" field.</summary>
        public const int AccessRightFieldNumber = 1;
        private AccessRight.V1.AccessRight accessRight_;

        /// <summary>
        /// The access right to which the access points have been added.
        /// </summary>
        public AccessRight.V1.AccessRight AccessRight
        {
            get { return accessRight_; }
            set
            {
                accessRight_ = value;
            }
        }

        /// <summary>Field number for the "access_points" field.</summary>
        public const int AccessPointsFieldNumber = 2;
        private static readonly FieldCodec<AccessPoint.V1.AccessPoint> _repeated_accessPoints_codec
            = FieldCodec.ForMessage(18, AccessPoint.V1.AccessPoint.Parser);
        private readonly RepeatedField<AccessPoint.V1.AccessPoint> accessPoints_ = [];

        /// <summary>
        /// The access points added to the access right.
        /// </summary>
        public RepeatedField<AccessPoint.V1.AccessPoint> AccessPoints
        {
            get { return accessPoints_; }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 3;
        private Principal actor_;

        /// <summary>
        /// The actor who created the multiple access rights access points association.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AccessRightAccessPointsBatchCreated);
        public bool Equals(AccessRightAccessPointsBatchCreated other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessRight, other.AccessRight)) || (!accessPoints_.Equals(other.accessPoints_))) return false;
            if (!Equals(Actor, other.Actor)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessRight_ != null) hash ^= AccessRight.GetHashCode();
            hash ^= accessPoints_.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (accessRight_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessRight);
      }
      accessPoints_.WriteTo(output, _repeated_accessPoints_codec);
      if (actor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (accessRight_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessRight);
            }
            accessPoints_.WriteTo(ref output, _repeated_accessPoints_codec);
            if (actor_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (accessRight_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessRight);
            size += accessPoints_.CalculateSize(_repeated_accessPoints_codec);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessRightAccessPointsBatchCreated other)
        {
            if (other == null) return;
            if (other.accessRight_ != null)
            {
                if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                AccessRight.MergeFrom(other.AccessRight);
            }
            accessPoints_.Add(other.accessPoints_);
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (accessRight_ == null) {
              AccessRight = new Saltoapis.Nebula.AccessRight.V1.AccessRight();
            }
            input.ReadMessage(AccessRight);
            break;
          }
          case 18: {
            accessPoints_.AddEntriesFrom(input, _repeated_accessPoints_codec);
            break;
          }
          case 26: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                            input.ReadMessage(AccessRight);
                            break;
                        }
                    case 18:
                        {
                            accessPoints_.AddEntriesFrom(ref input, _repeated_accessPoints_codec);
                            break;
                        }
                    case 26:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the deletion of an access right's access point association.
    /// </summary>
    public sealed partial class AccessRightAccessPointDeleted : IMessage<AccessRightAccessPointDeleted>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessRightAccessPointDeleted> _parser = new(() => new AccessRightAccessPointDeleted());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessRightAccessPointDeleted> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[16]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessRightAccessPointDeleted()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessRightAccessPointDeleted(AccessRightAccessPointDeleted other) : this()
        {
            accessRight_ = other.accessRight_?.Clone();
            accessPoint_ = other.accessPoint_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessRightAccessPointDeleted Clone() => new(this);
        /// <summary>Field number for the "access_right" field.</summary>
        public const int AccessRightFieldNumber = 1;
        private AccessRight.V1.AccessRight accessRight_;

        /// <summary>
        /// Access point's access right association deleted.
        /// </summary>
        public AccessRight.V1.AccessRight AccessRight
        {
            get { return accessRight_; }
            set
            {
                accessRight_ = value;
            }
        }

        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 2;
        private AccessPoint.V1.AccessPoint accessPoint_;

        /// <summary>
        /// Access right's access point association deleted.
        /// </summary>
        public AccessPoint.V1.AccessPoint AccessPoint
        {
            get { return accessPoint_; }
            set
            {
                accessPoint_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 3;
        private Principal actor_;

        /// <summary>
        /// The actor who deleted the access right's access point association.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AccessRightAccessPointDeleted);
        public bool Equals(AccessRightAccessPointDeleted other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessRight, other.AccessRight)) || (!Equals(AccessPoint, other.AccessPoint))) return false;
            if (!Equals(Actor, other.Actor)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessRight_ != null) hash ^= AccessRight.GetHashCode();
            if (accessPoint_ != null) hash ^= AccessPoint.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (accessRight_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessRight);
      }
      if (accessPoint_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AccessPoint);
      }
      if (actor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (accessRight_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessRight);
            }
            if (accessPoint_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(AccessPoint);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (accessRight_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessRight);
            if (accessPoint_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessPoint);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessRightAccessPointDeleted other)
        {
            if (other == null) return;
            if (other.accessRight_ != null)
            {
                if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                AccessRight.MergeFrom(other.AccessRight);
            }
            if (other.accessPoint_ != null)
            {
                if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                AccessPoint.MergeFrom(other.AccessPoint);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (accessRight_ == null) {
              AccessRight = new Saltoapis.Nebula.AccessRight.V1.AccessRight();
            }
            input.ReadMessage(AccessRight);
            break;
          }
          case 18: {
            if (accessPoint_ == null) {
              AccessPoint = new Saltoapis.Nebula.AccessPoint.V1.AccessPoint();
            }
            input.ReadMessage(AccessPoint);
            break;
          }
          case 26: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                            input.ReadMessage(AccessRight);
                            break;
                        }
                    case 18:
                        {
                            if (accessPoint_ == null) AccessPoint = new AccessPoint.V1.AccessPoint();
                            input.ReadMessage(AccessPoint);
                            break;
                        }
                    case 26:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the deletion of multiple access right's access point association.
    /// </summary>
    public sealed partial class AccessRightAccessPointsBatchDeleted : IMessage<AccessRightAccessPointsBatchDeleted>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessRightAccessPointsBatchDeleted> _parser = new(() => new AccessRightAccessPointsBatchDeleted());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessRightAccessPointsBatchDeleted> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[17]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessRightAccessPointsBatchDeleted()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessRightAccessPointsBatchDeleted(AccessRightAccessPointsBatchDeleted other) : this()
        {
            accessRight_ = other.accessRight_?.Clone();
            accessPoints_ = other.accessPoints_.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessRightAccessPointsBatchDeleted Clone() => new(this);
        /// <summary>Field number for the "access_right" field.</summary>
        public const int AccessRightFieldNumber = 1;
        private AccessRight.V1.AccessRight accessRight_;

        /// <summary>
        /// The access right to which the access points have been removed.
        /// </summary>
        public AccessRight.V1.AccessRight AccessRight
        {
            get { return accessRight_; }
            set
            {
                accessRight_ = value;
            }
        }

        /// <summary>Field number for the "access_points" field.</summary>
        public const int AccessPointsFieldNumber = 2;
        private static readonly FieldCodec<AccessPoint.V1.AccessPoint> _repeated_accessPoints_codec
            = FieldCodec.ForMessage(18, AccessPoint.V1.AccessPoint.Parser);
        private readonly RepeatedField<AccessPoint.V1.AccessPoint> accessPoints_ = [];

        /// <summary>
        /// The access points removed from the access right.
        /// </summary>
        public RepeatedField<AccessPoint.V1.AccessPoint> AccessPoints
        {
            get { return accessPoints_; }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 3;
        private Principal actor_;

        /// <summary>
        /// The actor who deleted the multiple access rights access points association.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AccessRightAccessPointsBatchDeleted);
        public bool Equals(AccessRightAccessPointsBatchDeleted other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(AccessRight, other.AccessRight)) || (!accessPoints_.Equals(other.accessPoints_))) return false;
            if (!Equals(Actor, other.Actor)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessRight_ != null) hash ^= AccessRight.GetHashCode();
            hash ^= accessPoints_.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (accessRight_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessRight);
      }
      accessPoints_.WriteTo(output, _repeated_accessPoints_codec);
      if (actor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (accessRight_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessRight);
            }
            accessPoints_.WriteTo(ref output, _repeated_accessPoints_codec);
            if (actor_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (accessRight_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessRight);
            size += accessPoints_.CalculateSize(_repeated_accessPoints_codec);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessRightAccessPointsBatchDeleted other)
        {
            if (other == null) return;
            if (other.accessRight_ != null)
            {
                if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                AccessRight.MergeFrom(other.AccessRight);
            }
            accessPoints_.Add(other.accessPoints_);
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (accessRight_ == null) {
              AccessRight = new Saltoapis.Nebula.AccessRight.V1.AccessRight();
            }
            input.ReadMessage(AccessRight);
            break;
          }
          case 18: {
            accessPoints_.AddEntriesFrom(input, _repeated_accessPoints_codec);
            break;
          }
          case 26: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                            input.ReadMessage(AccessRight);
                            break;
                        }
                    case 18:
                        {
                            accessPoints_.AddEntriesFrom(ref input, _repeated_accessPoints_codec);
                            break;
                        }
                    case 26:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the creation of a user.
    /// </summary>
    public sealed partial class UserCreated : IMessage<UserCreated>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UserCreated> _parser = new(() => new UserCreated());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UserCreated> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[18]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UserCreated()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UserCreated(UserCreated other) : this()
        {
            user_ = other.user_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UserCreated Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;
        private User.V1.User user_;

        /// <summary>
        /// User created.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who created the user.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UserCreated);
        public bool Equals(UserCreated other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(User, other.User)) || (!Equals(Actor, other.Actor))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (user_ != null) hash ^= User.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (user_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UserCreated other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the update of a user.
    /// </summary>
    public sealed partial class UserUpdated : IMessage<UserUpdated>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UserUpdated> _parser = new(() => new UserUpdated());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UserUpdated> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[19]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UserUpdated()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UserUpdated(UserUpdated other) : this()
        {
            user_ = other.user_?.Clone();
            actor_ = other.actor_?.Clone();
            previousValues_ = other.previousValues_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UserUpdated Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;
        private User.V1.User user_;

        /// <summary>
        /// User updated.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who updated the user.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        /// <summary>Field number for the "previous_values" field.</summary>
        public const int PreviousValuesFieldNumber = 3;
        private PreviousValues previousValues_;

        /// <summary>
        /// The previous values of the user's fields that were changed.
        /// </summary>
        public PreviousValues PreviousValues
        {
            get { return previousValues_; }
            set
            {
                previousValues_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UserUpdated);
        public bool Equals(UserUpdated other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(User, other.User)) || (!Equals(Actor, other.Actor))) return false;
            if (!Equals(PreviousValues, other.PreviousValues)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (user_ != null) hash ^= User.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (previousValues_ != null) hash ^= PreviousValues.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (previousValues_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PreviousValues);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (user_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            if (previousValues_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(PreviousValues);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (previousValues_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(PreviousValues);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UserUpdated other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
            }
            if (other.previousValues_ != null)
            {
                if (previousValues_ == null) PreviousValues = new PreviousValues();
                PreviousValues.MergeFrom(other.PreviousValues);
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
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
            break;
          }
          case 26: {
            if (previousValues_ == null) {
              PreviousValues = new Saltoapis.Nebula.Event.V1.PreviousValues();
            }
            input.ReadMessage(PreviousValues);
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
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                    case 26:
                        {
                            if (previousValues_ == null) PreviousValues = new PreviousValues();
                            input.ReadMessage(PreviousValues);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the block of a user.
    /// </summary>
    public sealed partial class UserBlocked : IMessage<UserBlocked>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UserBlocked> _parser = new(() => new UserBlocked());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UserBlocked> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[20]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UserBlocked()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UserBlocked(UserBlocked other) : this()
        {
            user_ = other.user_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UserBlocked Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;
        private User.V1.User user_;

        /// <summary>
        /// User blocked.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who blocked the user.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UserBlocked);
        public bool Equals(UserBlocked other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(User, other.User)) || (!Equals(Actor, other.Actor))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (user_ != null) hash ^= User.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (user_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UserBlocked other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the unblock of a user.
    /// </summary>
    public sealed partial class UserUnblocked : IMessage<UserUnblocked>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UserUnblocked> _parser = new(() => new UserUnblocked());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UserUnblocked> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[21]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UserUnblocked()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UserUnblocked(UserUnblocked other) : this()
        {
            user_ = other.user_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UserUnblocked Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;
        private User.V1.User user_;

        /// <summary>
        /// User unblocked.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who unblocked the user.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UserUnblocked);
        public bool Equals(UserUnblocked other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(User, other.User)) || (!Equals(Actor, other.Actor))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (user_ != null) hash ^= User.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (user_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UserUnblocked other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the deletion of a user.
    /// </summary>
    public sealed partial class UserDeleted : IMessage<UserDeleted>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UserDeleted> _parser = new(() => new UserDeleted());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UserDeleted> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[22]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UserDeleted()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UserDeleted(UserDeleted other) : this()
        {
            user_ = other.user_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UserDeleted Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;
        private User.V1.User user_;

        /// <summary>
        /// User deleted.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who deleted the user.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UserDeleted);
        public bool Equals(UserDeleted other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(User, other.User)) || (!Equals(Actor, other.Actor))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (user_ != null) hash ^= User.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (user_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UserDeleted other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the creation of a user's access right association.
    /// </summary>
    public sealed partial class UserAccessRightCreated : IMessage<UserAccessRightCreated>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UserAccessRightCreated> _parser = new(() => new UserAccessRightCreated());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UserAccessRightCreated> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[23]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UserAccessRightCreated()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UserAccessRightCreated(UserAccessRightCreated other) : this()
        {
            user_ = other.user_?.Clone();
            accessRight_ = other.accessRight_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UserAccessRightCreated Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;
        private User.V1.User user_;

        /// <summary>
        /// Access right's user association created.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "access_right" field.</summary>
        public const int AccessRightFieldNumber = 2;
        private AccessRight.V1.AccessRight accessRight_;

        /// <summary>
        /// User's access right association created.
        /// </summary>
        public AccessRight.V1.AccessRight AccessRight
        {
            get { return accessRight_; }
            set
            {
                accessRight_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 3;
        private Principal actor_;

        /// <summary>
        /// The actor who created the user access right association.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UserAccessRightCreated);
        public bool Equals(UserAccessRightCreated other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(User, other.User)) || (!Equals(AccessRight, other.AccessRight))) return false;
            if (!Equals(Actor, other.Actor)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (user_ != null) hash ^= User.GetHashCode();
            if (accessRight_ != null) hash ^= AccessRight.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (accessRight_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AccessRight);
      }
      if (actor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (user_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
            }
            if (accessRight_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(AccessRight);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (accessRight_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessRight);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UserAccessRightCreated other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            if (other.accessRight_ != null)
            {
                if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                AccessRight.MergeFrom(other.AccessRight);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 18: {
            if (accessRight_ == null) {
              AccessRight = new Saltoapis.Nebula.AccessRight.V1.AccessRight();
            }
            input.ReadMessage(AccessRight);
            break;
          }
          case 26: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 18:
                        {
                            if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                            input.ReadMessage(AccessRight);
                            break;
                        }
                    case 26:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the update of a user's access right association.
    /// </summary>
    public sealed partial class UserAccessRightUpdated : IMessage<UserAccessRightUpdated>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UserAccessRightUpdated> _parser = new(() => new UserAccessRightUpdated());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UserAccessRightUpdated> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[24]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UserAccessRightUpdated()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UserAccessRightUpdated(UserAccessRightUpdated other) : this()
        {
            user_ = other.user_?.Clone();
            accessRight_ = other.accessRight_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UserAccessRightUpdated Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;
        private User.V1.User user_;

        /// <summary>
        /// Access right's user association updated.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "access_right" field.</summary>
        public const int AccessRightFieldNumber = 2;
        private AccessRight.V1.AccessRight accessRight_;

        /// <summary>
        /// User's access right association updated.
        /// </summary>
        public AccessRight.V1.AccessRight AccessRight
        {
            get { return accessRight_; }
            set
            {
                accessRight_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 3;
        private Principal actor_;

        /// <summary>
        /// The actor who updated the user access right association.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UserAccessRightUpdated);
        public bool Equals(UserAccessRightUpdated other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(User, other.User)) || (!Equals(AccessRight, other.AccessRight))) return false;
            if (!Equals(Actor, other.Actor)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (user_ != null) hash ^= User.GetHashCode();
            if (accessRight_ != null) hash ^= AccessRight.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (accessRight_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AccessRight);
      }
      if (actor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (user_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
            }
            if (accessRight_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(AccessRight);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (accessRight_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessRight);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UserAccessRightUpdated other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            if (other.accessRight_ != null)
            {
                if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                AccessRight.MergeFrom(other.AccessRight);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 18: {
            if (accessRight_ == null) {
              AccessRight = new Saltoapis.Nebula.AccessRight.V1.AccessRight();
            }
            input.ReadMessage(AccessRight);
            break;
          }
          case 26: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 18:
                        {
                            if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                            input.ReadMessage(AccessRight);
                            break;
                        }
                    case 26:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the deletion of a user's access right association.
    /// </summary>
    public sealed partial class UserAccessRightDeleted : IMessage<UserAccessRightDeleted>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UserAccessRightDeleted> _parser = new(() => new UserAccessRightDeleted());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UserAccessRightDeleted> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[25]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UserAccessRightDeleted()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UserAccessRightDeleted(UserAccessRightDeleted other) : this()
        {
            user_ = other.user_?.Clone();
            accessRight_ = other.accessRight_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UserAccessRightDeleted Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;
        private User.V1.User user_;

        /// <summary>
        /// Access right's user association deleted.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "access_right" field.</summary>
        public const int AccessRightFieldNumber = 2;
        private AccessRight.V1.AccessRight accessRight_;

        /// <summary>
        /// User's access right association deleted.
        /// </summary>
        public AccessRight.V1.AccessRight AccessRight
        {
            get { return accessRight_; }
            set
            {
                accessRight_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 3;
        private Principal actor_;

        /// <summary>
        /// The actor who deleted the user access right association.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UserAccessRightDeleted);
        public bool Equals(UserAccessRightDeleted other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(User, other.User)) || (!Equals(AccessRight, other.AccessRight))) return false;
            if (!Equals(Actor, other.Actor)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (user_ != null) hash ^= User.GetHashCode();
            if (accessRight_ != null) hash ^= AccessRight.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (accessRight_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AccessRight);
      }
      if (actor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (user_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
            }
            if (accessRight_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(AccessRight);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (accessRight_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AccessRight);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UserAccessRightDeleted other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            if (other.accessRight_ != null)
            {
                if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                AccessRight.MergeFrom(other.AccessRight);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 18: {
            if (accessRight_ == null) {
              AccessRight = new Saltoapis.Nebula.AccessRight.V1.AccessRight();
            }
            input.ReadMessage(AccessRight);
            break;
          }
          case 26: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 18:
                        {
                            if (accessRight_ == null) AccessRight = new AccessRight.V1.AccessRight();
                            input.ReadMessage(AccessRight);
                            break;
                        }
                    case 26:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the assignment of a user's card key.
    /// </summary>
    public sealed partial class CardKeyAssigned : IMessage<CardKeyAssigned>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CardKeyAssigned> _parser = new(() => new CardKeyAssigned());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CardKeyAssigned> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[26]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CardKeyAssigned()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CardKeyAssigned(CardKeyAssigned other) : this()
        {
            user_ = other.user_?.Clone();
            cardKey_ = other.cardKey_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CardKeyAssigned Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;
        private User.V1.User user_;

        /// <summary>
        /// Card key's user.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "card_key" field.</summary>
        public const int CardKeyFieldNumber = 2;
        private User.V1.CardKey cardKey_;

        /// <summary>
        /// Card key assigned.
        /// </summary>
        public User.V1.CardKey CardKey
        {
            get { return cardKey_; }
            set
            {
                cardKey_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 3;
        private Principal actor_;

        /// <summary>
        /// The actor who assigned a user's card key.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CardKeyAssigned);
        public bool Equals(CardKeyAssigned other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(User, other.User)) || (!Equals(CardKey, other.CardKey))) return false;
            if (!Equals(Actor, other.Actor)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (user_ != null) hash ^= User.GetHashCode();
            if (cardKey_ != null) hash ^= CardKey.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (cardKey_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CardKey);
      }
      if (actor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (user_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
            }
            if (cardKey_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(CardKey);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (cardKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(CardKey);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CardKeyAssigned other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            if (other.cardKey_ != null)
            {
                if (cardKey_ == null) CardKey = new User.V1.CardKey();
                CardKey.MergeFrom(other.CardKey);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 18: {
            if (cardKey_ == null) {
              CardKey = new Saltoapis.Nebula.User.V1.CardKey();
            }
            input.ReadMessage(CardKey);
            break;
          }
          case 26: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 18:
                        {
                            if (cardKey_ == null) CardKey = new User.V1.CardKey();
                            input.ReadMessage(CardKey);
                            break;
                        }
                    case 26:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the cancelation of a user's card key.
    /// </summary>
    public sealed partial class CardKeyCanceled : IMessage<CardKeyCanceled>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CardKeyCanceled> _parser = new(() => new CardKeyCanceled());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CardKeyCanceled> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[27]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CardKeyCanceled()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CardKeyCanceled(CardKeyCanceled other) : this()
        {
            user_ = other.user_?.Clone();
            cardKey_ = other.cardKey_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CardKeyCanceled Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;
        private User.V1.User user_;

        /// <summary>
        /// Card key's user.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "card_key" field.</summary>
        public const int CardKeyFieldNumber = 2;
        private User.V1.CardKey cardKey_;

        /// <summary>
        /// Card key canceled.
        /// </summary>
        public User.V1.CardKey CardKey
        {
            get { return cardKey_; }
            set
            {
                cardKey_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 3;
        private Principal actor_;

        /// <summary>
        /// The actor who canceled a user's card key.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CardKeyCanceled);
        public bool Equals(CardKeyCanceled other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(User, other.User)) || (!Equals(CardKey, other.CardKey))) return false;
            if (!Equals(Actor, other.Actor)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (user_ != null) hash ^= User.GetHashCode();
            if (cardKey_ != null) hash ^= CardKey.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (cardKey_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CardKey);
      }
      if (actor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (user_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
            }
            if (cardKey_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(CardKey);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (cardKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(CardKey);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CardKeyCanceled other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            if (other.cardKey_ != null)
            {
                if (cardKey_ == null) CardKey = new User.V1.CardKey();
                CardKey.MergeFrom(other.CardKey);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 18: {
            if (cardKey_ == null) {
              CardKey = new Saltoapis.Nebula.User.V1.CardKey();
            }
            input.ReadMessage(CardKey);
            break;
          }
          case 26: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 18:
                        {
                            if (cardKey_ == null) CardKey = new User.V1.CardKey();
                            input.ReadMessage(CardKey);
                            break;
                        }
                    case 26:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the assignment of a user's app key.
    /// </summary>
    public sealed partial class AppKeyAssigned : IMessage<AppKeyAssigned>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AppKeyAssigned> _parser = new(() => new AppKeyAssigned());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AppKeyAssigned> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[28]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AppKeyAssigned()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AppKeyAssigned(AppKeyAssigned other) : this()
        {
            user_ = other.user_?.Clone();
            appKey_ = other.appKey_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AppKeyAssigned Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;
        private User.V1.User user_;

        /// <summary>
        /// App key's user.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "app_key" field.</summary>
        public const int AppKeyFieldNumber = 2;
        private User.V1.AppKey appKey_;

        /// <summary>
        /// App key assigned.
        /// </summary>
        public User.V1.AppKey AppKey
        {
            get { return appKey_; }
            set
            {
                appKey_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 3;
        private Principal actor_;

        /// <summary>
        /// The actor who assigned a user's app key.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AppKeyAssigned);
        public bool Equals(AppKeyAssigned other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(User, other.User)) || (!Equals(AppKey, other.AppKey))) return false;
            if (!Equals(Actor, other.Actor)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (user_ != null) hash ^= User.GetHashCode();
            if (appKey_ != null) hash ^= AppKey.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (appKey_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AppKey);
      }
      if (actor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (user_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
            }
            if (appKey_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(AppKey);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (appKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AppKey);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AppKeyAssigned other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            if (other.appKey_ != null)
            {
                if (appKey_ == null) AppKey = new User.V1.AppKey();
                AppKey.MergeFrom(other.AppKey);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 18: {
            if (appKey_ == null) {
              AppKey = new Saltoapis.Nebula.User.V1.AppKey();
            }
            input.ReadMessage(AppKey);
            break;
          }
          case 26: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 18:
                        {
                            if (appKey_ == null) AppKey = new User.V1.AppKey();
                            input.ReadMessage(AppKey);
                            break;
                        }
                    case 26:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the cancelation of a user's app key.
    /// </summary>
    public sealed partial class AppKeyCanceled : IMessage<AppKeyCanceled>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AppKeyCanceled> _parser = new(() => new AppKeyCanceled());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AppKeyCanceled> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[29]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AppKeyCanceled()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AppKeyCanceled(AppKeyCanceled other) : this()
        {
            user_ = other.user_?.Clone();
            appKey_ = other.appKey_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AppKeyCanceled Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;
        private User.V1.User user_;

        /// <summary>
        /// App key's user.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "app_key" field.</summary>
        public const int AppKeyFieldNumber = 2;
        private User.V1.AppKey appKey_;

        /// <summary>
        /// App key canceled.
        /// </summary>
        public User.V1.AppKey AppKey
        {
            get { return appKey_; }
            set
            {
                appKey_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 3;
        private Principal actor_;

        /// <summary>
        /// The actor who canceled a user's app key.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AppKeyCanceled);
        public bool Equals(AppKeyCanceled other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(User, other.User)) || (!Equals(AppKey, other.AppKey))) return false;
            if (!Equals(Actor, other.Actor)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (user_ != null) hash ^= User.GetHashCode();
            if (appKey_ != null) hash ^= AppKey.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (appKey_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AppKey);
      }
      if (actor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (user_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
            }
            if (appKey_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(AppKey);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (appKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(AppKey);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AppKeyCanceled other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            if (other.appKey_ != null)
            {
                if (appKey_ == null) AppKey = new User.V1.AppKey();
                AppKey.MergeFrom(other.AppKey);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 18: {
            if (appKey_ == null) {
              AppKey = new Saltoapis.Nebula.User.V1.AppKey();
            }
            input.ReadMessage(AppKey);
            break;
          }
          case 26: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 18:
                        {
                            if (appKey_ == null) AppKey = new User.V1.AppKey();
                            input.ReadMessage(AppKey);
                            break;
                        }
                    case 26:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the assignment of a user's wallet key.
    /// </summary>
    public sealed partial class WalletKeyAssigned : IMessage<WalletKeyAssigned>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<WalletKeyAssigned> _parser = new(() => new WalletKeyAssigned());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<WalletKeyAssigned> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[30]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public WalletKeyAssigned()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public WalletKeyAssigned(WalletKeyAssigned other) : this()
        {
            user_ = other.user_?.Clone();
            walletKey_ = other.walletKey_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public WalletKeyAssigned Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;
        private User.V1.User user_;

        /// <summary>
        /// Wallet key's user.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "wallet_key" field.</summary>
        public const int WalletKeyFieldNumber = 2;
        private User.V1.WalletKey walletKey_;

        /// <summary>
        /// Wallet key assigned.
        /// </summary>
        public User.V1.WalletKey WalletKey
        {
            get { return walletKey_; }
            set
            {
                walletKey_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 3;
        private Principal actor_;

        /// <summary>
        /// The actor who assigned a user's wallet key.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as WalletKeyAssigned);
        public bool Equals(WalletKeyAssigned other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(User, other.User)) || (!Equals(WalletKey, other.WalletKey))) return false;
            if (!Equals(Actor, other.Actor)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (user_ != null) hash ^= User.GetHashCode();
            if (walletKey_ != null) hash ^= WalletKey.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (walletKey_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(WalletKey);
      }
      if (actor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (user_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
            }
            if (walletKey_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(WalletKey);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (walletKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(WalletKey);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(WalletKeyAssigned other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            if (other.walletKey_ != null)
            {
                if (walletKey_ == null) WalletKey = new User.V1.WalletKey();
                WalletKey.MergeFrom(other.WalletKey);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 18: {
            if (walletKey_ == null) {
              WalletKey = new Saltoapis.Nebula.User.V1.WalletKey();
            }
            input.ReadMessage(WalletKey);
            break;
          }
          case 26: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 18:
                        {
                            if (walletKey_ == null) WalletKey = new User.V1.WalletKey();
                            input.ReadMessage(WalletKey);
                            break;
                        }
                    case 26:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the cancelation of a user's wallet key.
    /// </summary>
    public sealed partial class WalletKeyCanceled : IMessage<WalletKeyCanceled>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<WalletKeyCanceled> _parser = new(() => new WalletKeyCanceled());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<WalletKeyCanceled> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[31]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public WalletKeyCanceled()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public WalletKeyCanceled(WalletKeyCanceled other) : this()
        {
            user_ = other.user_?.Clone();
            walletKey_ = other.walletKey_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public WalletKeyCanceled Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;
        private User.V1.User user_;

        /// <summary>
        /// Wallet key's user.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "wallet_key" field.</summary>
        public const int WalletKeyFieldNumber = 2;
        private User.V1.WalletKey walletKey_;

        /// <summary>
        /// Wallet key canceled.
        /// </summary>
        public User.V1.WalletKey WalletKey
        {
            get { return walletKey_; }
            set
            {
                walletKey_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 3;
        private Principal actor_;

        /// <summary>
        /// The actor who canceled a user's wallet key.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as WalletKeyCanceled);
        public bool Equals(WalletKeyCanceled other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(User, other.User)) || (!Equals(WalletKey, other.WalletKey))) return false;
            if (!Equals(Actor, other.Actor)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (user_ != null) hash ^= User.GetHashCode();
            if (walletKey_ != null) hash ^= WalletKey.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (walletKey_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(WalletKey);
      }
      if (actor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (user_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
            }
            if (walletKey_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(WalletKey);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (walletKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(WalletKey);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(WalletKeyCanceled other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            if (other.walletKey_ != null)
            {
                if (walletKey_ == null) WalletKey = new User.V1.WalletKey();
                WalletKey.MergeFrom(other.WalletKey);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 18: {
            if (walletKey_ == null) {
              WalletKey = new Saltoapis.Nebula.User.V1.WalletKey();
            }
            input.ReadMessage(WalletKey);
            break;
          }
          case 26: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 18:
                        {
                            if (walletKey_ == null) WalletKey = new User.V1.WalletKey();
                            input.ReadMessage(WalletKey);
                            break;
                        }
                    case 26:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the move in of a unit.
    /// </summary>
    public sealed partial class UnitMovedIn : IMessage<UnitMovedIn>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnitMovedIn> _parser = new(() => new UnitMovedIn());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnitMovedIn> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[32]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnitMovedIn()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnitMovedIn(UnitMovedIn other) : this()
        {
            unit_ = other.unit_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnitMovedIn Clone() => new(this);
        /// <summary>Field number for the "unit" field.</summary>
        public const int UnitFieldNumber = 1;
        private Unit.V1.Unit unit_;

        /// <summary>
        /// Unit moved in.
        /// </summary>
        public Unit.V1.Unit Unit
        {
            get { return unit_; }
            set
            {
                unit_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who performed the move in of a unit.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UnitMovedIn);
        public bool Equals(UnitMovedIn other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(Unit, other.Unit)) || (!Equals(Actor, other.Actor))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (unit_ != null) hash ^= Unit.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (unit_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Unit);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (unit_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Unit);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (unit_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Unit);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UnitMovedIn other)
        {
            if (other == null) return;
            if (other.unit_ != null)
            {
                if (unit_ == null) Unit = new Unit.V1.Unit();
                Unit.MergeFrom(other.Unit);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (unit_ == null) {
              Unit = new Saltoapis.Nebula.Unit.V1.Unit();
            }
            input.ReadMessage(Unit);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (unit_ == null) Unit = new Unit.V1.Unit();
                            input.ReadMessage(Unit);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the move out of a unit.
    /// </summary>
    public sealed partial class UnitMovedOut : IMessage<UnitMovedOut>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnitMovedOut> _parser = new(() => new UnitMovedOut());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnitMovedOut> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[33]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnitMovedOut()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnitMovedOut(UnitMovedOut other) : this()
        {
            unit_ = other.unit_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnitMovedOut Clone() => new(this);
        /// <summary>Field number for the "unit" field.</summary>
        public const int UnitFieldNumber = 1;
        private Unit.V1.Unit unit_;

        /// <summary>
        /// Unit moved out.
        /// </summary>
        public Unit.V1.Unit Unit
        {
            get { return unit_; }
            set
            {
                unit_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who performed the move out of a unit.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UnitMovedOut);
        public bool Equals(UnitMovedOut other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(Unit, other.Unit)) || (!Equals(Actor, other.Actor))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (unit_ != null) hash ^= Unit.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (unit_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Unit);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (unit_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Unit);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (unit_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Unit);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UnitMovedOut other)
        {
            if (other == null) return;
            if (other.unit_ != null)
            {
                if (unit_ == null) Unit = new Unit.V1.Unit();
                Unit.MergeFrom(other.Unit);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (unit_ == null) {
              Unit = new Saltoapis.Nebula.Unit.V1.Unit();
            }
            input.ReadMessage(Unit);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (unit_ == null) Unit = new Unit.V1.Unit();
                            input.ReadMessage(Unit);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the creation of a unit.
    /// </summary>
    public sealed partial class UnitCreated : IMessage<UnitCreated>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnitCreated> _parser = new(() => new UnitCreated());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnitCreated> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[34]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnitCreated()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnitCreated(UnitCreated other) : this()
        {
            unit_ = other.unit_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnitCreated Clone() => new(this);
        /// <summary>Field number for the "unit" field.</summary>
        public const int UnitFieldNumber = 1;
        private Unit.V1.Unit unit_;

        /// <summary>
        /// Unit created.
        /// </summary>
        public Unit.V1.Unit Unit
        {
            get { return unit_; }
            set
            {
                unit_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who created the unit.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UnitCreated);
        public bool Equals(UnitCreated other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(Unit, other.Unit)) || (!Equals(Actor, other.Actor))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (unit_ != null) hash ^= Unit.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (unit_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Unit);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (unit_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Unit);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (unit_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Unit);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UnitCreated other)
        {
            if (other == null) return;
            if (other.unit_ != null)
            {
                if (unit_ == null) Unit = new Unit.V1.Unit();
                Unit.MergeFrom(other.Unit);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (unit_ == null) {
              Unit = new Saltoapis.Nebula.Unit.V1.Unit();
            }
            input.ReadMessage(Unit);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (unit_ == null) Unit = new Unit.V1.Unit();
                            input.ReadMessage(Unit);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the update of a unit.
    /// </summary>
    public sealed partial class UnitUpdated : IMessage<UnitUpdated>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnitUpdated> _parser = new(() => new UnitUpdated());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnitUpdated> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[35]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnitUpdated()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnitUpdated(UnitUpdated other) : this()
        {
            unit_ = other.unit_?.Clone();
            actor_ = other.actor_?.Clone();
            previousValues_ = other.previousValues_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnitUpdated Clone() => new(this);
        /// <summary>Field number for the "unit" field.</summary>
        public const int UnitFieldNumber = 1;
        private Unit.V1.Unit unit_;

        /// <summary>
        /// Unit updated.
        /// </summary>
        public Unit.V1.Unit Unit
        {
            get { return unit_; }
            set
            {
                unit_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who updated the unit.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        /// <summary>Field number for the "previous_values" field.</summary>
        public const int PreviousValuesFieldNumber = 3;
        private PreviousValues previousValues_;

        /// <summary>
        /// The previous values of the unit's fields that were changed.
        /// </summary>
        public PreviousValues PreviousValues
        {
            get { return previousValues_; }
            set
            {
                previousValues_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UnitUpdated);
        public bool Equals(UnitUpdated other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(Unit, other.Unit)) || (!Equals(Actor, other.Actor))) return false;
            if (!Equals(PreviousValues, other.PreviousValues)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (unit_ != null) hash ^= Unit.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (previousValues_ != null) hash ^= PreviousValues.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (unit_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Unit);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (previousValues_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PreviousValues);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (unit_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Unit);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            if (previousValues_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(PreviousValues);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (unit_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Unit);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (previousValues_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(PreviousValues);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UnitUpdated other)
        {
            if (other == null) return;
            if (other.unit_ != null)
            {
                if (unit_ == null) Unit = new Unit.V1.Unit();
                Unit.MergeFrom(other.Unit);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
            }
            if (other.previousValues_ != null)
            {
                if (previousValues_ == null) PreviousValues = new PreviousValues();
                PreviousValues.MergeFrom(other.PreviousValues);
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
            if (unit_ == null) {
              Unit = new Saltoapis.Nebula.Unit.V1.Unit();
            }
            input.ReadMessage(Unit);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
            break;
          }
          case 26: {
            if (previousValues_ == null) {
              PreviousValues = new Saltoapis.Nebula.Event.V1.PreviousValues();
            }
            input.ReadMessage(PreviousValues);
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
                            if (unit_ == null) Unit = new Unit.V1.Unit();
                            input.ReadMessage(Unit);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                    case 26:
                        {
                            if (previousValues_ == null) PreviousValues = new PreviousValues();
                            input.ReadMessage(PreviousValues);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the deletion of a unit.
    /// </summary>
    public sealed partial class UnitDeleted : IMessage<UnitDeleted>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnitDeleted> _parser = new(() => new UnitDeleted());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnitDeleted> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[36]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnitDeleted()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnitDeleted(UnitDeleted other) : this()
        {
            unit_ = other.unit_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnitDeleted Clone() => new(this);
        /// <summary>Field number for the "unit" field.</summary>
        public const int UnitFieldNumber = 1;
        private Unit.V1.Unit unit_;

        /// <summary>
        /// Unit deleted.
        /// </summary>
        public Unit.V1.Unit Unit
        {
            get { return unit_; }
            set
            {
                unit_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who updated the unit.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UnitDeleted);
        public bool Equals(UnitDeleted other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(Unit, other.Unit)) || (!Equals(Actor, other.Actor))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (unit_ != null) hash ^= Unit.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (unit_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Unit);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (unit_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Unit);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (unit_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Unit);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UnitDeleted other)
        {
            if (other == null) return;
            if (other.unit_ != null)
            {
                if (unit_ == null) Unit = new Unit.V1.Unit();
                Unit.MergeFrom(other.Unit);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (unit_ == null) {
              Unit = new Saltoapis.Nebula.Unit.V1.Unit();
            }
            input.ReadMessage(Unit);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (unit_ == null) Unit = new Unit.V1.Unit();
                            input.ReadMessage(Unit);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the creation of an emergency key.
    /// </summary>
    public sealed partial class EmergencyKeyCreated : IMessage<EmergencyKeyCreated>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<EmergencyKeyCreated> _parser = new(() => new EmergencyKeyCreated());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<EmergencyKeyCreated> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[37]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EmergencyKeyCreated()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public EmergencyKeyCreated(EmergencyKeyCreated other) : this()
        {
            emergencyKey_ = other.emergencyKey_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public EmergencyKeyCreated Clone() => new(this);
        /// <summary>Field number for the "emergency_key" field.</summary>
        public const int EmergencyKeyFieldNumber = 1;
        private Salto.Nebula.EmergencyKey.V1.EmergencyKey emergencyKey_;

        /// <summary>
        /// Emergency key created.
        /// </summary>
        public Salto.Nebula.EmergencyKey.V1.EmergencyKey EmergencyKey
        {
            get { return emergencyKey_; }
            set
            {
                emergencyKey_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who created the Emergency Key.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as EmergencyKeyCreated);
        public bool Equals(EmergencyKeyCreated other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(EmergencyKey, other.EmergencyKey)) || (!Equals(Actor, other.Actor))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (emergencyKey_ != null) hash ^= EmergencyKey.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (emergencyKey_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(EmergencyKey);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (emergencyKey_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(EmergencyKey);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (emergencyKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(EmergencyKey);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(EmergencyKeyCreated other)
        {
            if (other == null) return;
            if (other.emergencyKey_ != null)
            {
                if (emergencyKey_ == null) EmergencyKey = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
                EmergencyKey.MergeFrom(other.EmergencyKey);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (emergencyKey_ == null) {
              EmergencyKey = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
            }
            input.ReadMessage(EmergencyKey);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (emergencyKey_ == null) EmergencyKey = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
                            input.ReadMessage(EmergencyKey);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the update of an emergency key.
    /// </summary>
    public sealed partial class EmergencyKeyUpdated : IMessage<EmergencyKeyUpdated>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<EmergencyKeyUpdated> _parser = new(() => new EmergencyKeyUpdated());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<EmergencyKeyUpdated> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[38]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EmergencyKeyUpdated()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public EmergencyKeyUpdated(EmergencyKeyUpdated other) : this()
        {
            emergencyKey_ = other.emergencyKey_?.Clone();
            actor_ = other.actor_?.Clone();
            previousValues_ = other.previousValues_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public EmergencyKeyUpdated Clone() => new(this);
        /// <summary>Field number for the "emergency_key" field.</summary>
        public const int EmergencyKeyFieldNumber = 1;
        private Salto.Nebula.EmergencyKey.V1.EmergencyKey emergencyKey_;

        /// <summary>
        /// Emergency key updated.
        /// </summary>
        public Salto.Nebula.EmergencyKey.V1.EmergencyKey EmergencyKey
        {
            get { return emergencyKey_; }
            set
            {
                emergencyKey_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who updated the Emergency Key.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        /// <summary>Field number for the "previous_values" field.</summary>
        public const int PreviousValuesFieldNumber = 3;
        private PreviousValues previousValues_;

        /// <summary>
        /// The previous values of the emergency key's fields that were changed.
        /// </summary>
        public PreviousValues PreviousValues
        {
            get { return previousValues_; }
            set
            {
                previousValues_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as EmergencyKeyUpdated);
        public bool Equals(EmergencyKeyUpdated other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(EmergencyKey, other.EmergencyKey)) || (!Equals(Actor, other.Actor))) return false;
            if (!Equals(PreviousValues, other.PreviousValues)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (emergencyKey_ != null) hash ^= EmergencyKey.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (previousValues_ != null) hash ^= PreviousValues.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (emergencyKey_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(EmergencyKey);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (previousValues_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PreviousValues);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (emergencyKey_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(EmergencyKey);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            if (previousValues_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(PreviousValues);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (emergencyKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(EmergencyKey);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (previousValues_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(PreviousValues);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(EmergencyKeyUpdated other)
        {
            if (other == null) return;
            if (other.emergencyKey_ != null)
            {
                if (emergencyKey_ == null) EmergencyKey = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
                EmergencyKey.MergeFrom(other.EmergencyKey);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
            }
            if (other.previousValues_ != null)
            {
                if (previousValues_ == null) PreviousValues = new PreviousValues();
                PreviousValues.MergeFrom(other.PreviousValues);
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
            if (emergencyKey_ == null) {
              EmergencyKey = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
            }
            input.ReadMessage(EmergencyKey);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
            break;
          }
          case 26: {
            if (previousValues_ == null) {
              PreviousValues = new Saltoapis.Nebula.Event.V1.PreviousValues();
            }
            input.ReadMessage(PreviousValues);
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
                            if (emergencyKey_ == null) EmergencyKey = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
                            input.ReadMessage(EmergencyKey);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                    case 26:
                        {
                            if (previousValues_ == null) PreviousValues = new PreviousValues();
                            input.ReadMessage(PreviousValues);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the deletion of an emergency key.
    /// </summary>
    public sealed partial class EmergencyKeyDeleted : IMessage<EmergencyKeyDeleted>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<EmergencyKeyDeleted> _parser = new(() => new EmergencyKeyDeleted());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<EmergencyKeyDeleted> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[39]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EmergencyKeyDeleted()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public EmergencyKeyDeleted(EmergencyKeyDeleted other) : this()
        {
            emergencyKey_ = other.emergencyKey_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public EmergencyKeyDeleted Clone() => new(this);
        /// <summary>Field number for the "emergency_key" field.</summary>
        public const int EmergencyKeyFieldNumber = 1;
        private Salto.Nebula.EmergencyKey.V1.EmergencyKey emergencyKey_;

        /// <summary>
        /// Emergency key deleted.
        /// </summary>
        public Salto.Nebula.EmergencyKey.V1.EmergencyKey EmergencyKey
        {
            get { return emergencyKey_; }
            set
            {
                emergencyKey_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who deleted the Emergency Key.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as EmergencyKeyDeleted);
        public bool Equals(EmergencyKeyDeleted other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(EmergencyKey, other.EmergencyKey)) || (!Equals(Actor, other.Actor))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (emergencyKey_ != null) hash ^= EmergencyKey.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (emergencyKey_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(EmergencyKey);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (emergencyKey_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(EmergencyKey);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (emergencyKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(EmergencyKey);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(EmergencyKeyDeleted other)
        {
            if (other == null) return;
            if (other.emergencyKey_ != null)
            {
                if (emergencyKey_ == null) EmergencyKey = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
                EmergencyKey.MergeFrom(other.EmergencyKey);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (emergencyKey_ == null) {
              EmergencyKey = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
            }
            input.ReadMessage(EmergencyKey);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (emergencyKey_ == null) EmergencyKey = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
                            input.ReadMessage(EmergencyKey);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the assignment of a user's electronic key.
    /// </summary>
    public sealed partial class ElectronicKeyAssigned : IMessage<ElectronicKeyAssigned>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ElectronicKeyAssigned> _parser = new(() => new ElectronicKeyAssigned());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ElectronicKeyAssigned> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[40]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ElectronicKeyAssigned()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ElectronicKeyAssigned(ElectronicKeyAssigned other) : this()
        {
            user_ = other.user_?.Clone();
            electronicKey_ = other.electronicKey_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ElectronicKeyAssigned Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;
        private User.V1.User user_;

        /// <summary>
        /// Electronic key's user.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "electronic_key" field.</summary>
        public const int ElectronicKeyFieldNumber = 2;
        private User.V1.ElectronicKey electronicKey_;

        /// <summary>
        /// Electronic key assigned.
        /// </summary>
        public User.V1.ElectronicKey ElectronicKey
        {
            get { return electronicKey_; }
            set
            {
                electronicKey_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 3;
        private Principal actor_;

        /// <summary>
        /// The actor who assigned a user's electronic key.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as ElectronicKeyAssigned);
        public bool Equals(ElectronicKeyAssigned other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(User, other.User)) || (!Equals(ElectronicKey, other.ElectronicKey))) return false;
            if (!Equals(Actor, other.Actor)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (user_ != null) hash ^= User.GetHashCode();
            if (electronicKey_ != null) hash ^= ElectronicKey.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (electronicKey_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ElectronicKey);
      }
      if (actor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (user_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
            }
            if (electronicKey_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(ElectronicKey);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (electronicKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(ElectronicKey);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ElectronicKeyAssigned other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            if (other.electronicKey_ != null)
            {
                if (electronicKey_ == null) ElectronicKey = new User.V1.ElectronicKey();
                ElectronicKey.MergeFrom(other.ElectronicKey);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 18: {
            if (electronicKey_ == null) {
              ElectronicKey = new Saltoapis.Nebula.User.V1.ElectronicKey();
            }
            input.ReadMessage(ElectronicKey);
            break;
          }
          case 26: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 18:
                        {
                            if (electronicKey_ == null) ElectronicKey = new User.V1.ElectronicKey();
                            input.ReadMessage(ElectronicKey);
                            break;
                        }
                    case 26:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the cancelation of a user's electronic key.
    /// </summary>
    public sealed partial class ElectronicKeyCanceled : IMessage<ElectronicKeyCanceled>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ElectronicKeyCanceled> _parser = new(() => new ElectronicKeyCanceled());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ElectronicKeyCanceled> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[41]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ElectronicKeyCanceled()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ElectronicKeyCanceled(ElectronicKeyCanceled other) : this()
        {
            user_ = other.user_?.Clone();
            electronicKey_ = other.electronicKey_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ElectronicKeyCanceled Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;
        private User.V1.User user_;

        /// <summary>
        /// Electronic key's user.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "electronic_key" field.</summary>
        public const int ElectronicKeyFieldNumber = 2;
        private User.V1.ElectronicKey electronicKey_;

        /// <summary>
        /// Electronic key canceled.
        /// </summary>
        public User.V1.ElectronicKey ElectronicKey
        {
            get { return electronicKey_; }
            set
            {
                electronicKey_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 3;
        private Principal actor_;

        /// <summary>
        /// The actor who canceled a user's electronic key.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as ElectronicKeyCanceled);
        public bool Equals(ElectronicKeyCanceled other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(User, other.User)) || (!Equals(ElectronicKey, other.ElectronicKey))) return false;
            if (!Equals(Actor, other.Actor)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (user_ != null) hash ^= User.GetHashCode();
            if (electronicKey_ != null) hash ^= ElectronicKey.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (electronicKey_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ElectronicKey);
      }
      if (actor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (user_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
            }
            if (electronicKey_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(ElectronicKey);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (electronicKey_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(ElectronicKey);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(ElectronicKeyCanceled other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            if (other.electronicKey_ != null)
            {
                if (electronicKey_ == null) ElectronicKey = new User.V1.ElectronicKey();
                ElectronicKey.MergeFrom(other.ElectronicKey);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 18: {
            if (electronicKey_ == null) {
              ElectronicKey = new Saltoapis.Nebula.User.V1.ElectronicKey();
            }
            input.ReadMessage(ElectronicKey);
            break;
          }
          case 26: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 18:
                        {
                            if (electronicKey_ == null) ElectronicKey = new User.V1.ElectronicKey();
                            input.ReadMessage(ElectronicKey);
                            break;
                        }
                    case 26:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing access being granted to a user.
    /// This event indicates that a user's key was successfully validated and
    /// access permissions were activated.
    ///
    /// This event is typically used in scenarios where the device manages
    /// multiple destinations and cannot determine the user's final action,
    /// or where it represents a general access grant rather than a
    /// specific door unlock.
    ///
    /// This differs from `AccessPointUnlocked` in that:
    /// - It can enable multiple relays/destinations simultaneously (for example:
    ///   elevator buttons for authorized floors).
    /// - It represents the **granting** of access rights rather than the
    ///   **physical unlocking** of a specific access point.
    ///
    /// Common use cases:
    /// - Controllers (elevators, multi-door, garages): enabling floor buttons,
    ///   granting access to multiple doors, or triggering a garage door.
    /// - Access points (future): could be used for specific access point
    ///   scenarios that fit this "grant" model.
    /// </summary>
    public sealed partial class AccessGranted : IMessage<AccessGranted>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessGranted> _parser = new(() => new AccessGranted());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessGranted> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[42]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessGranted()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessGranted(AccessGranted other) : this()
        {
            user_ = other.user_?.Clone();
            switch (other.DeviceCase)
            {
                case DeviceOneofCase.Controller:
                    Controller = other.Controller.Clone();
                    break;
            }

            switch (other.CredentialCase)
            {
                case CredentialOneofCase.EmergencyKey:
                    EmergencyKey = other.EmergencyKey.Clone();
                    break;
                case CredentialOneofCase.CardKey:
                    CardKey = other.CardKey.Clone();
                    break;
                case CredentialOneofCase.AppKey:
                    AppKey = other.AppKey.Clone();
                    break;
                case CredentialOneofCase.WalletKey:
                    WalletKey = other.WalletKey.Clone();
                    break;
                case CredentialOneofCase.Passcode:
                    Passcode = other.Passcode.Clone();
                    break;
                case CredentialOneofCase.ElectronicKey:
                    ElectronicKey = other.ElectronicKey.Clone();
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessGranted Clone() => new(this);
        /// <summary>Field number for the "controller" field.</summary>
        public const int ControllerFieldNumber = 1;

        /// <summary>
        /// The controller that granted access.
        /// </summary>
        public Controller.V1.Controller Controller
        {
            get { return deviceCase_ == DeviceOneofCase.Controller ? (Controller.V1.Controller)device_ : null; }
            set
            {
                device_ = value;
                deviceCase_ = value == null ? DeviceOneofCase.None : DeviceOneofCase.Controller;
            }
        }

        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 2;
        private User.V1.User user_;

        /// <summary>
        /// The user who was granted access, if any.
        /// </summary>
        public User.V1.User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        /// <summary>Field number for the "emergency_key" field.</summary>
        public const int EmergencyKeyFieldNumber = 3;

        /// <summary>
        /// The emergency key used.
        /// </summary>
        public Salto.Nebula.EmergencyKey.V1.EmergencyKey EmergencyKey
        {
            get { return credentialCase_ == CredentialOneofCase.EmergencyKey ? (Salto.Nebula.EmergencyKey.V1.EmergencyKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.EmergencyKey;
            }
        }

        /// <summary>Field number for the "card_key" field.</summary>
        public const int CardKeyFieldNumber = 4;

        /// <summary>
        /// The card key used.
        /// </summary>
        public User.V1.CardKey CardKey
        {
            get { return credentialCase_ == CredentialOneofCase.CardKey ? (User.V1.CardKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.CardKey;
            }
        }

        /// <summary>Field number for the "app_key" field.</summary>
        public const int AppKeyFieldNumber = 5;

        /// <summary>
        /// The app key used.
        /// </summary>
        public User.V1.AppKey AppKey
        {
            get { return credentialCase_ == CredentialOneofCase.AppKey ? (User.V1.AppKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.AppKey;
            }
        }

        /// <summary>Field number for the "wallet_key" field.</summary>
        public const int WalletKeyFieldNumber = 6;

        /// <summary>
        /// The wallet key used.
        /// </summary>
        public User.V1.WalletKey WalletKey
        {
            get { return credentialCase_ == CredentialOneofCase.WalletKey ? (User.V1.WalletKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.WalletKey;
            }
        }

        /// <summary>Field number for the "passcode" field.</summary>
        public const int PasscodeFieldNumber = 7;

        /// <summary>
        /// The passcode used.
        /// </summary>
        public User.V1.Passcode Passcode
        {
            get { return credentialCase_ == CredentialOneofCase.Passcode ? (User.V1.Passcode)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.Passcode;
            }
        }

        /// <summary>Field number for the "electronic_key" field.</summary>
        public const int ElectronicKeyFieldNumber = 8;

        /// <summary>
        /// The electronic key used.
        /// </summary>
        public User.V1.ElectronicKey ElectronicKey
        {
            get { return credentialCase_ == CredentialOneofCase.ElectronicKey ? (User.V1.ElectronicKey)credential_ : null; }
            set
            {
                credential_ = value;
                credentialCase_ = value == null ? CredentialOneofCase.None : CredentialOneofCase.ElectronicKey;
            }
        }

        private object device_;

        /// <summary>Enum of possible cases for the "device" oneof.</summary>
        public enum DeviceOneofCase
        {
            None = 0,
            Controller = 1,
        }

        private DeviceOneofCase deviceCase_ = DeviceOneofCase.None;

        public DeviceOneofCase DeviceCase
        {
            get { return deviceCase_; }
        }

        public void ClearDevice()
        {
            deviceCase_ = DeviceOneofCase.None;
            device_ = null;
        }

        private object credential_;

        /// <summary>Enum of possible cases for the "credential" oneof.</summary>
        public enum CredentialOneofCase
        {
            None = 0,
            EmergencyKey = 3,
            CardKey = 4,
            AppKey = 5,
            WalletKey = 6,
            Passcode = 7,
            ElectronicKey = 8,
        }

        private CredentialOneofCase credentialCase_ = CredentialOneofCase.None;

        public CredentialOneofCase CredentialCase
        {
            get { return credentialCase_; }
        }

        public void ClearCredential()
        {
            credentialCase_ = CredentialOneofCase.None;
            credential_ = null;
        }

        public override bool Equals(object other) => Equals(other as AccessGranted);
        public bool Equals(AccessGranted other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(Controller, other.Controller)) || (!Equals(User, other.User))) return false;
            if ((!Equals(EmergencyKey, other.EmergencyKey)) || (!Equals(CardKey, other.CardKey))) return false;
            if ((!Equals(AppKey, other.AppKey)) || (!Equals(WalletKey, other.WalletKey))) return false;
            if ((!Equals(Passcode, other.Passcode)) || (!Equals(ElectronicKey, other.ElectronicKey))) return false;
            if ((DeviceCase != other.DeviceCase) || (CredentialCase != other.CredentialCase)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (deviceCase_ == DeviceOneofCase.Controller) hash ^= Controller.GetHashCode();
            if (user_ != null) hash ^= User.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.EmergencyKey) hash ^= EmergencyKey.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.CardKey) hash ^= CardKey.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.AppKey) hash ^= AppKey.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.WalletKey) hash ^= WalletKey.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.Passcode) hash ^= Passcode.GetHashCode();
            if (credentialCase_ == CredentialOneofCase.ElectronicKey) hash ^= ElectronicKey.GetHashCode();
            hash ^= (int)deviceCase_;
            hash ^= (int)credentialCase_;
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (deviceCase_ == DeviceOneofCase.Controller) {
        output.WriteRawTag(10);
        output.WriteMessage(Controller);
      }
      if (user_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(User);
      }
      if (credentialCase_ == CredentialOneofCase.EmergencyKey) {
        output.WriteRawTag(26);
        output.WriteMessage(EmergencyKey);
      }
      if (credentialCase_ == CredentialOneofCase.CardKey) {
        output.WriteRawTag(34);
        output.WriteMessage(CardKey);
      }
      if (credentialCase_ == CredentialOneofCase.AppKey) {
        output.WriteRawTag(42);
        output.WriteMessage(AppKey);
      }
      if (credentialCase_ == CredentialOneofCase.WalletKey) {
        output.WriteRawTag(50);
        output.WriteMessage(WalletKey);
      }
      if (credentialCase_ == CredentialOneofCase.Passcode) {
        output.WriteRawTag(58);
        output.WriteMessage(Passcode);
      }
      if (credentialCase_ == CredentialOneofCase.ElectronicKey) {
        output.WriteRawTag(66);
        output.WriteMessage(ElectronicKey);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (deviceCase_ == DeviceOneofCase.Controller)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Controller);
            }
            if (user_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(User);
            }
            if (credentialCase_ == CredentialOneofCase.EmergencyKey)
            {
                output.WriteRawTag(26);
                output.WriteMessage(EmergencyKey);
            }
            if (credentialCase_ == CredentialOneofCase.CardKey)
            {
                output.WriteRawTag(34);
                output.WriteMessage(CardKey);
            }
            if (credentialCase_ == CredentialOneofCase.AppKey)
            {
                output.WriteRawTag(42);
                output.WriteMessage(AppKey);
            }
            if (credentialCase_ == CredentialOneofCase.WalletKey)
            {
                output.WriteRawTag(50);
                output.WriteMessage(WalletKey);
            }
            if (credentialCase_ == CredentialOneofCase.Passcode)
            {
                output.WriteRawTag(58);
                output.WriteMessage(Passcode);
            }
            if (credentialCase_ == CredentialOneofCase.ElectronicKey)
            {
                output.WriteRawTag(66);
                output.WriteMessage(ElectronicKey);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (deviceCase_ == DeviceOneofCase.Controller) size += 1 + CodedOutputStream.ComputeMessageSize(Controller);
            if (user_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(User);
            if (credentialCase_ == CredentialOneofCase.EmergencyKey) size += 1 + CodedOutputStream.ComputeMessageSize(EmergencyKey);
            if (credentialCase_ == CredentialOneofCase.CardKey) size += 1 + CodedOutputStream.ComputeMessageSize(CardKey);
            if (credentialCase_ == CredentialOneofCase.AppKey) size += 1 + CodedOutputStream.ComputeMessageSize(AppKey);
            if (credentialCase_ == CredentialOneofCase.WalletKey) size += 1 + CodedOutputStream.ComputeMessageSize(WalletKey);
            if (credentialCase_ == CredentialOneofCase.Passcode) size += 1 + CodedOutputStream.ComputeMessageSize(Passcode);
            if (credentialCase_ == CredentialOneofCase.ElectronicKey) size += 1 + CodedOutputStream.ComputeMessageSize(ElectronicKey);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(AccessGranted other)
        {
            if (other == null) return;
            if (other.user_ != null)
            {
                if (user_ == null) User = new User.V1.User();
                User.MergeFrom(other.User);
            }
            switch (other.DeviceCase)
            {
                case DeviceOneofCase.Controller:
                    if (Controller == null) Controller = new Controller.V1.Controller();
                    Controller.MergeFrom(other.Controller);
                    break;
            }

            switch (other.CredentialCase)
            {
                case CredentialOneofCase.EmergencyKey:
                    if (EmergencyKey == null) EmergencyKey = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
                    EmergencyKey.MergeFrom(other.EmergencyKey);
                    break;
                case CredentialOneofCase.CardKey:
                    if (CardKey == null) CardKey = new User.V1.CardKey();
                    CardKey.MergeFrom(other.CardKey);
                    break;
                case CredentialOneofCase.AppKey:
                    if (AppKey == null) AppKey = new User.V1.AppKey();
                    AppKey.MergeFrom(other.AppKey);
                    break;
                case CredentialOneofCase.WalletKey:
                    if (WalletKey == null) WalletKey = new User.V1.WalletKey();
                    WalletKey.MergeFrom(other.WalletKey);
                    break;
                case CredentialOneofCase.Passcode:
                    if (Passcode == null) Passcode = new User.V1.Passcode();
                    Passcode.MergeFrom(other.Passcode);
                    break;
                case CredentialOneofCase.ElectronicKey:
                    if (ElectronicKey == null) ElectronicKey = new User.V1.ElectronicKey();
                    ElectronicKey.MergeFrom(other.ElectronicKey);
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
            Saltoapis.Nebula.Controller.V1.Controller subBuilder = new Saltoapis.Nebula.Controller.V1.Controller();
            if (deviceCase_ == DeviceOneofCase.Controller) {
              subBuilder.MergeFrom(Controller);
            }
            input.ReadMessage(subBuilder);
            Controller = subBuilder;
            break;
          }
          case 18: {
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 26: {
            Salto.Nebula.EmergencyKey.V1.EmergencyKey subBuilder = new Salto.Nebula.EmergencyKey.V1.EmergencyKey();
            if (credentialCase_ == CredentialOneofCase.EmergencyKey) {
              subBuilder.MergeFrom(EmergencyKey);
            }
            input.ReadMessage(subBuilder);
            EmergencyKey = subBuilder;
            break;
          }
          case 34: {
            Saltoapis.Nebula.User.V1.CardKey subBuilder = new Saltoapis.Nebula.User.V1.CardKey();
            if (credentialCase_ == CredentialOneofCase.CardKey) {
              subBuilder.MergeFrom(CardKey);
            }
            input.ReadMessage(subBuilder);
            CardKey = subBuilder;
            break;
          }
          case 42: {
            Saltoapis.Nebula.User.V1.AppKey subBuilder = new Saltoapis.Nebula.User.V1.AppKey();
            if (credentialCase_ == CredentialOneofCase.AppKey) {
              subBuilder.MergeFrom(AppKey);
            }
            input.ReadMessage(subBuilder);
            AppKey = subBuilder;
            break;
          }
          case 50: {
            Saltoapis.Nebula.User.V1.WalletKey subBuilder = new Saltoapis.Nebula.User.V1.WalletKey();
            if (credentialCase_ == CredentialOneofCase.WalletKey) {
              subBuilder.MergeFrom(WalletKey);
            }
            input.ReadMessage(subBuilder);
            WalletKey = subBuilder;
            break;
          }
          case 58: {
            Saltoapis.Nebula.User.V1.Passcode subBuilder = new Saltoapis.Nebula.User.V1.Passcode();
            if (credentialCase_ == CredentialOneofCase.Passcode) {
              subBuilder.MergeFrom(Passcode);
            }
            input.ReadMessage(subBuilder);
            Passcode = subBuilder;
            break;
          }
          case 66: {
            Saltoapis.Nebula.User.V1.ElectronicKey subBuilder = new Saltoapis.Nebula.User.V1.ElectronicKey();
            if (credentialCase_ == CredentialOneofCase.ElectronicKey) {
              subBuilder.MergeFrom(ElectronicKey);
            }
            input.ReadMessage(subBuilder);
            ElectronicKey = subBuilder;
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
                            Controller.V1.Controller subBuilder = new();
                            if (deviceCase_ == DeviceOneofCase.Controller) subBuilder.MergeFrom(Controller);
                            input.ReadMessage(subBuilder);
                            Controller = subBuilder;
                            break;
                        }
                    case 18:
                        {
                            if (user_ == null) User = new User.V1.User();
                            input.ReadMessage(User);
                            break;
                        }
                    case 26:
                        {
                            Salto.Nebula.EmergencyKey.V1.EmergencyKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.EmergencyKey) subBuilder.MergeFrom(EmergencyKey);
                            input.ReadMessage(subBuilder);
                            EmergencyKey = subBuilder;
                            break;
                        }
                    case 34:
                        {
                            User.V1.CardKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.CardKey) subBuilder.MergeFrom(CardKey);
                            input.ReadMessage(subBuilder);
                            CardKey = subBuilder;
                            break;
                        }
                    case 42:
                        {
                            User.V1.AppKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.AppKey) subBuilder.MergeFrom(AppKey);
                            input.ReadMessage(subBuilder);
                            AppKey = subBuilder;
                            break;
                        }
                    case 50:
                        {
                            User.V1.WalletKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.WalletKey) subBuilder.MergeFrom(WalletKey);
                            input.ReadMessage(subBuilder);
                            WalletKey = subBuilder;
                            break;
                        }
                    case 58:
                        {
                            User.V1.Passcode subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.Passcode) subBuilder.MergeFrom(Passcode);
                            input.ReadMessage(subBuilder);
                            Passcode = subBuilder;
                            break;
                        }
                    case 66:
                        {
                            User.V1.ElectronicKey subBuilder = new();
                            if (credentialCase_ == CredentialOneofCase.ElectronicKey) subBuilder.MergeFrom(ElectronicKey);
                            input.ReadMessage(subBuilder);
                            ElectronicKey = subBuilder;
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the check-in of a booking.
    /// </summary>
    public sealed partial class BookingCheckedIn : IMessage<BookingCheckedIn>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BookingCheckedIn> _parser = new(() => new BookingCheckedIn());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BookingCheckedIn> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[43]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BookingCheckedIn()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BookingCheckedIn(BookingCheckedIn other) : this()
        {
            booking_ = other.booking_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BookingCheckedIn Clone() => new(this);
        /// <summary>Field number for the "booking" field.</summary>
        public const int BookingFieldNumber = 1;
        private Booking.V1.Booking booking_;

        /// <summary>
        /// Booking checked in.
        /// </summary>
        public Booking.V1.Booking Booking
        {
            get { return booking_; }
            set
            {
                booking_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who performed the check-in of a booking.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as BookingCheckedIn);
        public bool Equals(BookingCheckedIn other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(Booking, other.Booking)) || (!Equals(Actor, other.Actor))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (booking_ != null) hash ^= Booking.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (booking_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Booking);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (booking_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Booking);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (booking_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Booking);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(BookingCheckedIn other)
        {
            if (other == null) return;
            if (other.booking_ != null)
            {
                if (booking_ == null) Booking = new Booking.V1.Booking();
                Booking.MergeFrom(other.Booking);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (booking_ == null) {
              Booking = new Saltoapis.Nebula.Booking.V1.Booking();
            }
            input.ReadMessage(Booking);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (booking_ == null) Booking = new Booking.V1.Booking();
                            input.ReadMessage(Booking);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Event representing the check-out of a booking.
    /// </summary>
    public sealed partial class BookingCheckedOut : IMessage<BookingCheckedOut>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BookingCheckedOut> _parser = new(() => new BookingCheckedOut());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BookingCheckedOut> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return TypesReflection.Descriptor.MessageTypes[44]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BookingCheckedOut()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BookingCheckedOut(BookingCheckedOut other) : this()
        {
            booking_ = other.booking_?.Clone();
            actor_ = other.actor_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BookingCheckedOut Clone() => new(this);
        /// <summary>Field number for the "booking" field.</summary>
        public const int BookingFieldNumber = 1;
        private Booking.V1.Booking booking_;

        /// <summary>
        /// Booking checked out.
        /// </summary>
        public Booking.V1.Booking Booking
        {
            get { return booking_; }
            set
            {
                booking_ = value;
            }
        }

        /// <summary>Field number for the "actor" field.</summary>
        public const int ActorFieldNumber = 2;
        private Principal actor_;

        /// <summary>
        /// The actor who performed the check-out of a booking.
        /// </summary>
        public Principal Actor
        {
            get { return actor_; }
            set
            {
                actor_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as BookingCheckedOut);
        public bool Equals(BookingCheckedOut other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(Booking, other.Booking)) || (!Equals(Actor, other.Actor))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (booking_ != null) hash ^= Booking.GetHashCode();
            if (actor_ != null) hash ^= Actor.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (booking_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Booking);
      }
      if (actor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Actor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (booking_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Booking);
            }
            if (actor_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Actor);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (booking_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Booking);
            if (actor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Actor);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(BookingCheckedOut other)
        {
            if (other == null) return;
            if (other.booking_ != null)
            {
                if (booking_ == null) Booking = new Booking.V1.Booking();
                Booking.MergeFrom(other.Booking);
            }
            if (other.actor_ != null)
            {
                if (actor_ == null) Actor = new Principal();
                Actor.MergeFrom(other.Actor);
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
            if (booking_ == null) {
              Booking = new Saltoapis.Nebula.Booking.V1.Booking();
            }
            input.ReadMessage(Booking);
            break;
          }
          case 18: {
            if (actor_ == null) {
              Actor = new Saltoapis.Nebula.Event.V1.Principal();
            }
            input.ReadMessage(Actor);
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
                            if (booking_ == null) Booking = new Booking.V1.Booking();
                            input.ReadMessage(Booking);
                            break;
                        }
                    case 18:
                        {
                            if (actor_ == null) Actor = new Principal();
                            input.ReadMessage(Actor);
                            break;
                        }
                }
            }
        }
#endif

    }


}
