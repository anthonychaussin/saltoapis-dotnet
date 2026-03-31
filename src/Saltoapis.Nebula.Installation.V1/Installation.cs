using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Installation.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/installation/v1/installation.proto</summary>
    public static partial class InstallationReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/installation/v1/installation.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static InstallationReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "Ci9zYWx0by9uZWJ1bGEvaW5zdGFsbGF0aW9uL3YxL2luc3RhbGxhdGlvbi5w",
                  "cm90bxIcc2FsdG8ubmVidWxhLmluc3RhbGxhdGlvbi52MRoeZ29vZ2xlL3By",
                  "b3RvYnVmL2R1cmF0aW9uLnByb3RvGhtnb29nbGUvcHJvdG9idWYvZW1wdHku",
                  "cHJvdG8aIGdvb2dsZS9wcm90b2J1Zi9maWVsZF9tYXNrLnByb3RvGh9nb29n",
                  "bGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvGhZzYWx0by90eXBlL2NvbG9y",
                  "LnByb3RvGhVzYWx0by90eXBlL2RhdGUucHJvdG8ihAcKDEluc3RhbGxhdGlv",
                  "bhIMCgRuYW1lGAEgASgJEhQKDGRpc3BsYXlfbmFtZRgCIAEoCRISCgVwaG90",
                  "bxgDIAEoCUgAiAEBEhEKCXBob3RvX3VyaRgEIAEoCRIPCgdhZGRyZXNzGAUg",
                  "ASgJEhEKCXRpbWVfem9uZRgGIAEoCRJRCg9kaWdpdGFsX2tleV9hcnQYByAB",
                  "KAsyOC5zYWx0by5uZWJ1bGEuaW5zdGFsbGF0aW9uLnYxLkluc3RhbGxhdGlv",
                  "bi5EaWdpdGFsS2V5QXJ0EmMKGHRyYW5zZmVyX293bmVyc2hpcF9zdGF0ZRgI",
                  "IAEoCzJBLnNhbHRvLm5lYnVsYS5pbnN0YWxsYXRpb24udjEuSW5zdGFsbGF0",
                  "aW9uLlRyYW5zZmVyT3duZXJzaGlwU3RhdGUSLwoLZGVsZXRlX3RpbWUYDCAB",
                  "KAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wElEKDHBhcnRuZXJfaW5m",
                  "bxgJIAEoCzI2LnNhbHRvLm5lYnVsYS5pbnN0YWxsYXRpb24udjEuSW5zdGFs",
                  "bGF0aW9uLlBhcnRuZXJJbmZvSAGIAQESMwoKYmxvY2tfdGltZRgLIAEoCzIa",
                  "Lmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBIAogBARI3ChRrZXlfcmVuZXdh",
                  "bF9kdXJhdGlvbhgKIAEoCzIZLmdvb2dsZS5wcm90b2J1Zi5EdXJhdGlvbhqc",
                  "AQoNRGlnaXRhbEtleUFydBIdChBiYWNrZ3JvdW5kX2ltYWdlGAEgASgJSACI",
                  "AQESHAoUYmFja2dyb3VuZF9pbWFnZV91cmkYAiABKAkSKgoKdGV4dF9jb2xv",
                  "chgDIAEoCzIRLnNhbHRvLnR5cGUuQ29sb3JIAYgBAUITChFfYmFja2dyb3Vu",
                  "ZF9pbWFnZUINCgtfdGV4dF9jb2xvchpYChZUcmFuc2Zlck93bmVyc2hpcFN0",
                  "YXRlEg0KBWVtYWlsGAEgASgJEi8KC2V4cGlyZV90aW1lGAIgASgLMhouZ29v",
                  "Z2xlLnByb3RvYnVmLlRpbWVzdGFtcBo4CgtQYXJ0bmVySW5mbxISCgpwYXJ0",
                  "bmVyX2lkGAEgASgJEhUKDWN1cnJlbmN5X2NvZGUYAiABKAlCCAoGX3Bob3Rv",
                  "Qg8KDV9wYXJ0bmVyX2luZm9CDQoLX2Jsb2NrX3RpbWUipQIKDFN1YnNjcmlw",
                  "dGlvbhIMCgRuYW1lGAEgASgJEjcKDnRyaWFsX2VuZF90aW1lGAMgASgLMhou",
                  "Z29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcEgAiAEBEj8KDGJpbGxpbmdfaW5m",
                  "bxgEIAEoCzIpLnNhbHRvLm5lYnVsYS5pbnN0YWxsYXRpb24udjEuQmlsbGlu",
                  "Z0luZm8SQwoOcGF5bWVudF9tZXRob2QYBSABKAsyKy5zYWx0by5uZWJ1bGEu",
                  "aW5zdGFsbGF0aW9uLnYxLlBheW1lbnRNZXRob2QSNQoHY291cG9ucxgGIAMo",
                  "CzIkLnNhbHRvLm5lYnVsYS5pbnN0YWxsYXRpb24udjEuQ291cG9uQhEKD190",
                  "cmlhbF9lbmRfdGltZSK9AQoLQmlsbGluZ0luZm8SDAoEbmFtZRgBIAEoCRIP",
                  "Cgdjb21wYW55GAIgASgJEg8KB2FkZHJlc3MYAyADKAkSEwoLcmVnaW9uX2Nv",
                  "ZGUYBCABKAkSDAoEY2l0eRgFIAEoCRIXCgpzdGF0ZV9jb2RlGAYgASgJSACI",
                  "AQESCwoDemlwGAcgASgJEhcKCnZhdF9udW1iZXIYCCABKAlIAYgBAUINCgtf",
                  "c3RhdGVfY29kZUINCgtfdmF0X251bWJlciLTAwoNUGF5bWVudE1ldGhvZBIM",
                  "CgRuYW1lGAEgASgJEkAKBGNhcmQYAiABKAsyMC5zYWx0by5uZWJ1bGEuaW5z",
                  "dGFsbGF0aW9uLnYxLlBheW1lbnRNZXRob2QuQ2FyZEgAEk8KDGRpcmVjdF9k",
                  "ZWJpdBgDIAEoCzI3LnNhbHRvLm5lYnVsYS5pbnN0YWxsYXRpb24udjEuUGF5",
                  "bWVudE1ldGhvZC5EaXJlY3REZWJpdEgAGm4KBENhcmQSJQoLZXhwaXJlX2Rh",
                  "dGUYASABKAsyEC5zYWx0by50eXBlLkRhdGUSEQoJbGFzdF9mb3VyGAIgASgJ",
                  "Eg0KBWJyYW5kGAMgASgJEh0KFXBheW1lbnRfYXV0aG9yaXphdGlvbhgEIAEo",
                  "CRqmAQoLRGlyZWN0RGViaXQSTAoEc2VwYRgBIAEoCzI8LnNhbHRvLm5lYnVs",
                  "YS5pbnN0YWxsYXRpb24udjEuUGF5bWVudE1ldGhvZC5EaXJlY3REZWJpdC5T",
                  "RVBBSAAaPwoEU0VQQRIRCglsYXN0X2ZvdXIYASABKAkSFgoOYWNjb3VudF9o",
                  "b2xkZXIYAiABKAkSDAoEaWJhbhgDIAEoCUIICgZzY2hlbWVCCAoGbWV0aG9k",
                  "IiQKFFBheW1lbnRBdXRob3JpemF0aW9uEgwKBG5hbWUYASABKAkiFgoGQ291",
                  "cG9uEgwKBG5hbWUYASABKAki8wIKB0ludm9pY2USDAoEbmFtZRgBIAEoCRIu",
                  "CgpzdGFydF90aW1lGAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFt",
                  "cBIsCghlbmRfdGltZRgDIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3Rh",
                  "bXASQgoKbGluZV9pdGVtcxgEIAMoCzIuLnNhbHRvLm5lYnVsYS5pbnN0YWxs",
                  "YXRpb24udjEuSW52b2ljZS5MaW5lSXRlbRINCgV0b3RhbBgFIAEoAxI6CgVz",
                  "dGF0ZRgGIAEoDjIrLnNhbHRvLm5lYnVsYS5pbnN0YWxsYXRpb24udjEuSW52",
                  "b2ljZS5TdGF0ZRo3CghMaW5lSXRlbRIKCgJpZBgBIAEoCRIQCghxdWFudGl0",
                  "eRgCIAEoBRINCgVwcmljZRgDIAEoAyI0CgVTdGF0ZRIVChFTVEFURV9VTlNQ",
                  "RUNJRklFRBAAEgoKBlVOUEFJRBABEggKBFBBSUQQAiI1CgZQb2xpY3kSDAoE",
                  "bmFtZRgBIAEoCRIOCgZtZW1iZXIYAiABKAkSDQoFcm9sZXMYAyADKAkivQEK",
                  "GUNyZWF0ZUluc3RhbGxhdGlvblJlcXVlc3QSHAoPaW5zdGFsbGF0aW9uX2lk",
                  "GAEgASgJSACIAQESQAoMaW5zdGFsbGF0aW9uGAIgASgLMiouc2FsdG8ubmVi",
                  "dWxhLmluc3RhbGxhdGlvbi52MS5JbnN0YWxsYXRpb24SGgoNdmFsaWRhdGVf",
                  "b25seRgFIAEoCEgBiAEBQhIKEF9pbnN0YWxsYXRpb25faWRCEAoOX3ZhbGlk",
                  "YXRlX29ubHkiJgoWR2V0SW5zdGFsbGF0aW9uUmVxdWVzdBIMCgRuYW1lGAEg",
                  "ASgJInkKGExpc3RJbnN0YWxsYXRpb25zUmVxdWVzdBIRCglwYWdlX3NpemUY",
                  "ASABKAUSEgoKcGFnZV90b2tlbhgCIAEoCRIOCgZmaWx0ZXIYAyABKAkSEAoI",
                  "b3JkZXJfYnkYBCABKAkSFAoMc2hvd19kZWxldGVkGAUgASgIIncKGUxpc3RJ",
                  "bnN0YWxsYXRpb25zUmVzcG9uc2USQQoNaW5zdGFsbGF0aW9ucxgBIAMoCzIq",
                  "LnNhbHRvLm5lYnVsYS5pbnN0YWxsYXRpb24udjEuSW5zdGFsbGF0aW9uEhcK",
                  "D25leHRfcGFnZV90b2tlbhgCIAEoCSKOAQoZVXBkYXRlSW5zdGFsbGF0aW9u",
                  "UmVxdWVzdBJACgxpbnN0YWxsYXRpb24YASABKAsyKi5zYWx0by5uZWJ1bGEu",
                  "aW5zdGFsbGF0aW9uLnYxLkluc3RhbGxhdGlvbhIvCgt1cGRhdGVfbWFzaxgC",
                  "IAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE1hc2sigQEKGURlbGV0ZUlu",
                  "c3RhbGxhdGlvblJlcXVlc3QSDAoEbmFtZRgBIAEoCRIaCg12YWxpZGF0ZV9v",
                  "bmx5GAIgASgISACIAQESGAoLZGVsYXlfaG91cnMYAyABKAVIAYgBAUIQCg5f",
                  "dmFsaWRhdGVfb25seUIOCgxfZGVsYXlfaG91cnMiKwobVW5kZWxldGVJbnN0",
                  "YWxsYXRpb25SZXF1ZXN0EgwKBG5hbWUYASABKAkibgoTQ3JlYXRlUG9saWN5",
                  "UmVxdWVzdBIOCgZwYXJlbnQYASABKAkSEQoJcG9saWN5X2lkGAIgASgJEjQK",
                  "BnBvbGljeRgDIAEoCzIkLnNhbHRvLm5lYnVsYS5pbnN0YWxsYXRpb24udjEu",
                  "UG9saWN5IiAKEEdldFBvbGljeVJlcXVlc3QSDAoEbmFtZRgBIAEoCSJuChNM",
                  "aXN0UG9saWNpZXNSZXF1ZXN0Eg4KBnBhcmVudBgBIAEoCRIRCglwYWdlX3Np",
                  "emUYAiABKAUSEgoKcGFnZV90b2tlbhgDIAEoCRIOCgZmaWx0ZXIYBCABKAkS",
                  "EAoIb3JkZXJfYnkYBSABKAkiZwoUTGlzdFBvbGljaWVzUmVzcG9uc2USNgoI",
                  "cG9saWNpZXMYASADKAsyJC5zYWx0by5uZWJ1bGEuaW5zdGFsbGF0aW9uLnYx",
                  "LlBvbGljeRIXCg9uZXh0X3BhZ2VfdG9rZW4YAiABKAkifAoTVXBkYXRlUG9s",
                  "aWN5UmVxdWVzdBI0CgZwb2xpY3kYASABKAsyJC5zYWx0by5uZWJ1bGEuaW5z",
                  "dGFsbGF0aW9uLnYxLlBvbGljeRIvCgt1cGRhdGVfbWFzaxgCIAEoCzIaLmdv",
                  "b2dsZS5wcm90b2J1Zi5GaWVsZE1hc2siIwoTRGVsZXRlUG9saWN5UmVxdWVz",
                  "dBIMCgRuYW1lGAEgASgJIkMKFlRlc3RQZXJtaXNzaW9uc1JlcXVlc3QSFAoM",
                  "aW5zdGFsbGF0aW9uGAEgASgJEhMKC3Blcm1pc3Npb25zGAIgAygJIi4KF1Rl",
                  "c3RQZXJtaXNzaW9uc1Jlc3BvbnNlEhMKC3Blcm1pc3Npb25zGAEgAygJIksK",
                  "JFRyYW5zZmVySW5zdGFsbGF0aW9uT3duZXJzaGlwUmVxdWVzdBIUCgxpbnN0",
                  "YWxsYXRpb24YASABKAkSDQoFZW1haWwYAiABKAkiJwolVHJhbnNmZXJJbnN0",
                  "YWxsYXRpb25Pd25lcnNoaXBSZXNwb25zZSKRAQoiQWNjZXB0SW5zdGFsbGF0",
                  "aW9uT3duZXJzaGlwUmVxdWVzdBIUCgxpbnN0YWxsYXRpb24YASABKAkSRAoM",
                  "YmlsbGluZ19pbmZvGAIgASgLMikuc2FsdG8ubmVidWxhLmluc3RhbGxhdGlv",
                  "bi52MS5CaWxsaW5nSW5mb0gAiAEBQg8KDV9iaWxsaW5nX2luZm8iJQojQWNj",
                  "ZXB0SW5zdGFsbGF0aW9uT3duZXJzaGlwUmVzcG9uc2UiJgoWR2V0U3Vic2Ny",
                  "aXB0aW9uUmVxdWVzdBIMCgRuYW1lGAEgASgJIlsKGFVwZGF0ZUJpbGxpbmdJ",
                  "bmZvUmVxdWVzdBI/CgxiaWxsaW5nX2luZm8YASABKAsyKS5zYWx0by5uZWJ1",
                  "bGEuaW5zdGFsbGF0aW9uLnYxLkJpbGxpbmdJbmZvImEKGlVwZGF0ZVBheW1l",
                  "bnRNZXRob2RSZXF1ZXN0EkMKDnBheW1lbnRfbWV0aG9kGAEgASgLMisuc2Fs",
                  "dG8ubmVidWxhLmluc3RhbGxhdGlvbi52MS5QYXltZW50TWV0aG9kIjoKEVVw",
                  "ZGF0ZUNhcmRSZXF1ZXN0EhYKDnBheW1lbnRfbWV0aG9kGAEgASgJEg0KBXRv",
                  "a2VuGAIgASgJIhQKElVwZGF0ZUNhcmRSZXNwb25zZSKGAQohQ3JlYXRlUGF5",
                  "bWVudEF1dGhvcml6YXRpb25SZXF1ZXN0Eg4KBnBhcmVudBgBIAEoCRJRChVw",
                  "YXltZW50X2F1dGhvcml6YXRpb24YAiABKAsyMi5zYWx0by5uZWJ1bGEuaW5z",
                  "dGFsbGF0aW9uLnYxLlBheW1lbnRBdXRob3JpemF0aW9uIiUKE0xpc3RJbnZv",
                  "aWNlc1JlcXVlc3QSDgoGcGFyZW50GAEgASgJIk8KFExpc3RJbnZvaWNlc1Jl",
                  "c3BvbnNlEjcKCGludm9pY2VzGAEgAygLMiUuc2FsdG8ubmVidWxhLmluc3Rh",
                  "bGxhdGlvbi52MS5JbnZvaWNlIjoKEkFwcGx5Q291cG9uUmVxdWVzdBIUCgxz",
                  "dWJzY3JpcHRpb24YASABKAkSDgoGY291cG9uGAIgASgJIhUKE0FwcGx5Q291",
                  "cG9uUmVzcG9uc2UiPAoUVW5hcHBseUNvdXBvblJlcXVlc3QSFAoMc3Vic2Ny",
                  "aXB0aW9uGAEgASgJEg4KBmNvdXBvbhgCIAEoCSIXChVVbmFwcGx5Q291cG9u",
                  "UmVzcG9uc2UiOQohR2VuZXJhdGVBdXRob3JpemF0aW9uVG9rZW5SZXF1ZXN0",
                  "EhQKDGluc3RhbGxhdGlvbhgBIAEoCSJBCiJHZW5lcmF0ZUF1dGhvcml6YXRp",
                  "b25Ub2tlblJlc3BvbnNlEhsKE2F1dGhvcml6YXRpb25fdG9rZW4YASABKAwy",
                  "zxYKE0luc3RhbGxhdGlvblNlcnZpY2USeQoSQ3JlYXRlSW5zdGFsbGF0aW9u",
                  "Ejcuc2FsdG8ubmVidWxhLmluc3RhbGxhdGlvbi52MS5DcmVhdGVJbnN0YWxs",
                  "YXRpb25SZXF1ZXN0Giouc2FsdG8ubmVidWxhLmluc3RhbGxhdGlvbi52MS5J",
                  "bnN0YWxsYXRpb24ScwoPR2V0SW5zdGFsbGF0aW9uEjQuc2FsdG8ubmVidWxh",
                  "Lmluc3RhbGxhdGlvbi52MS5HZXRJbnN0YWxsYXRpb25SZXF1ZXN0Giouc2Fs",
                  "dG8ubmVidWxhLmluc3RhbGxhdGlvbi52MS5JbnN0YWxsYXRpb24ShAEKEUxp",
                  "c3RJbnN0YWxsYXRpb25zEjYuc2FsdG8ubmVidWxhLmluc3RhbGxhdGlvbi52",
                  "MS5MaXN0SW5zdGFsbGF0aW9uc1JlcXVlc3QaNy5zYWx0by5uZWJ1bGEuaW5z",
                  "dGFsbGF0aW9uLnYxLkxpc3RJbnN0YWxsYXRpb25zUmVzcG9uc2USeQoSVXBk",
                  "YXRlSW5zdGFsbGF0aW9uEjcuc2FsdG8ubmVidWxhLmluc3RhbGxhdGlvbi52",
                  "MS5VcGRhdGVJbnN0YWxsYXRpb25SZXF1ZXN0Giouc2FsdG8ubmVidWxhLmlu",
                  "c3RhbGxhdGlvbi52MS5JbnN0YWxsYXRpb24SeQoSRGVsZXRlSW5zdGFsbGF0",
                  "aW9uEjcuc2FsdG8ubmVidWxhLmluc3RhbGxhdGlvbi52MS5EZWxldGVJbnN0",
                  "YWxsYXRpb25SZXF1ZXN0Giouc2FsdG8ubmVidWxhLmluc3RhbGxhdGlvbi52",
                  "MS5JbnN0YWxsYXRpb24SfQoUVW5kZWxldGVJbnN0YWxsYXRpb24SOS5zYWx0",
                  "by5uZWJ1bGEuaW5zdGFsbGF0aW9uLnYxLlVuZGVsZXRlSW5zdGFsbGF0aW9u",
                  "UmVxdWVzdBoqLnNhbHRvLm5lYnVsYS5pbnN0YWxsYXRpb24udjEuSW5zdGFs",
                  "bGF0aW9uEmcKDENyZWF0ZVBvbGljeRIxLnNhbHRvLm5lYnVsYS5pbnN0YWxs",
                  "YXRpb24udjEuQ3JlYXRlUG9saWN5UmVxdWVzdBokLnNhbHRvLm5lYnVsYS5p",
                  "bnN0YWxsYXRpb24udjEuUG9saWN5EmEKCUdldFBvbGljeRIuLnNhbHRvLm5l",
                  "YnVsYS5pbnN0YWxsYXRpb24udjEuR2V0UG9saWN5UmVxdWVzdBokLnNhbHRv",
                  "Lm5lYnVsYS5pbnN0YWxsYXRpb24udjEuUG9saWN5EnUKDExpc3RQb2xpY2ll",
                  "cxIxLnNhbHRvLm5lYnVsYS5pbnN0YWxsYXRpb24udjEuTGlzdFBvbGljaWVz",
                  "UmVxdWVzdBoyLnNhbHRvLm5lYnVsYS5pbnN0YWxsYXRpb24udjEuTGlzdFBv",
                  "bGljaWVzUmVzcG9uc2USZwoMVXBkYXRlUG9saWN5EjEuc2FsdG8ubmVidWxh",
                  "Lmluc3RhbGxhdGlvbi52MS5VcGRhdGVQb2xpY3lSZXF1ZXN0GiQuc2FsdG8u",
                  "bmVidWxhLmluc3RhbGxhdGlvbi52MS5Qb2xpY3kSWQoMRGVsZXRlUG9saWN5",
                  "EjEuc2FsdG8ubmVidWxhLmluc3RhbGxhdGlvbi52MS5EZWxldGVQb2xpY3lS",
                  "ZXF1ZXN0GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5En4KD1Rlc3RQZXJtaXNz",
                  "aW9ucxI0LnNhbHRvLm5lYnVsYS5pbnN0YWxsYXRpb24udjEuVGVzdFBlcm1p",
                  "c3Npb25zUmVxdWVzdBo1LnNhbHRvLm5lYnVsYS5pbnN0YWxsYXRpb24udjEu",
                  "VGVzdFBlcm1pc3Npb25zUmVzcG9uc2USqAEKHVRyYW5zZmVySW5zdGFsbGF0",
                  "aW9uT3duZXJzaGlwEkIuc2FsdG8ubmVidWxhLmluc3RhbGxhdGlvbi52MS5U",
                  "cmFuc2Zlckluc3RhbGxhdGlvbk93bmVyc2hpcFJlcXVlc3QaQy5zYWx0by5u",
                  "ZWJ1bGEuaW5zdGFsbGF0aW9uLnYxLlRyYW5zZmVySW5zdGFsbGF0aW9uT3du",
                  "ZXJzaGlwUmVzcG9uc2USogEKG0FjY2VwdEluc3RhbGxhdGlvbk93bmVyc2hp",
                  "cBJALnNhbHRvLm5lYnVsYS5pbnN0YWxsYXRpb24udjEuQWNjZXB0SW5zdGFs",
                  "bGF0aW9uT3duZXJzaGlwUmVxdWVzdBpBLnNhbHRvLm5lYnVsYS5pbnN0YWxs",
                  "YXRpb24udjEuQWNjZXB0SW5zdGFsbGF0aW9uT3duZXJzaGlwUmVzcG9uc2US",
                  "cwoPR2V0U3Vic2NyaXB0aW9uEjQuc2FsdG8ubmVidWxhLmluc3RhbGxhdGlv",
                  "bi52MS5HZXRTdWJzY3JpcHRpb25SZXF1ZXN0Giouc2FsdG8ubmVidWxhLmlu",
                  "c3RhbGxhdGlvbi52MS5TdWJzY3JpcHRpb24SdgoRVXBkYXRlQmlsbGluZ0lu",
                  "Zm8SNi5zYWx0by5uZWJ1bGEuaW5zdGFsbGF0aW9uLnYxLlVwZGF0ZUJpbGxp",
                  "bmdJbmZvUmVxdWVzdBopLnNhbHRvLm5lYnVsYS5pbnN0YWxsYXRpb24udjEu",
                  "QmlsbGluZ0luZm8SfAoTVXBkYXRlUGF5bWVudE1ldGhvZBI4LnNhbHRvLm5l",
                  "YnVsYS5pbnN0YWxsYXRpb24udjEuVXBkYXRlUGF5bWVudE1ldGhvZFJlcXVl",
                  "c3QaKy5zYWx0by5uZWJ1bGEuaW5zdGFsbGF0aW9uLnYxLlBheW1lbnRNZXRo",
                  "b2QSbwoKVXBkYXRlQ2FyZBIvLnNhbHRvLm5lYnVsYS5pbnN0YWxsYXRpb24u",
                  "djEuVXBkYXRlQ2FyZFJlcXVlc3QaMC5zYWx0by5uZWJ1bGEuaW5zdGFsbGF0",
                  "aW9uLnYxLlVwZGF0ZUNhcmRSZXNwb25zZRKRAQoaQ3JlYXRlUGF5bWVudEF1",
                  "dGhvcml6YXRpb24SPy5zYWx0by5uZWJ1bGEuaW5zdGFsbGF0aW9uLnYxLkNy",
                  "ZWF0ZVBheW1lbnRBdXRob3JpemF0aW9uUmVxdWVzdBoyLnNhbHRvLm5lYnVs",
                  "YS5pbnN0YWxsYXRpb24udjEuUGF5bWVudEF1dGhvcml6YXRpb24SdQoMTGlz",
                  "dEludm9pY2VzEjEuc2FsdG8ubmVidWxhLmluc3RhbGxhdGlvbi52MS5MaXN0",
                  "SW52b2ljZXNSZXF1ZXN0GjIuc2FsdG8ubmVidWxhLmluc3RhbGxhdGlvbi52",
                  "MS5MaXN0SW52b2ljZXNSZXNwb25zZRJyCgtBcHBseUNvdXBvbhIwLnNhbHRv",
                  "Lm5lYnVsYS5pbnN0YWxsYXRpb24udjEuQXBwbHlDb3Vwb25SZXF1ZXN0GjEu",
                  "c2FsdG8ubmVidWxhLmluc3RhbGxhdGlvbi52MS5BcHBseUNvdXBvblJlc3Bv",
                  "bnNlEngKDVVuYXBwbHlDb3Vwb24SMi5zYWx0by5uZWJ1bGEuaW5zdGFsbGF0",
                  "aW9uLnYxLlVuYXBwbHlDb3Vwb25SZXF1ZXN0GjMuc2FsdG8ubmVidWxhLmlu",
                  "c3RhbGxhdGlvbi52MS5VbmFwcGx5Q291cG9uUmVzcG9uc2USnwEKGkdlbmVy",
                  "YXRlQXV0aG9yaXphdGlvblRva2VuEj8uc2FsdG8ubmVidWxhLmluc3RhbGxh",
                  "dGlvbi52MS5HZW5lcmF0ZUF1dGhvcml6YXRpb25Ub2tlblJlcXVlc3QaQC5z",
                  "YWx0by5uZWJ1bGEuaW5zdGFsbGF0aW9uLnYxLkdlbmVyYXRlQXV0aG9yaXph",
                  "dGlvblRva2VuUmVzcG9uc2VCgAIKJGNvbS5zYWx0b2FwaXMubmVidWxhLmlu",
                  "c3RhbGxhdGlvbi52MUIRSW5zdGFsbGF0aW9uUHJvdG9QAVpOZ2l0aHViLmNv",
                  "bS9zYWx0b2FwaXMtaW50ZXJuYWwvc2FsdG9hcGlzLWdvL25lYnVsYS9pbnN0",
                  "YWxsYXRpb24vdjE7aW5zdGFsbGF0aW9uqgIgU2FsdG9hcGlzLk5lYnVsYS5J",
                  "bnN0YWxsYXRpb24uVjHKAiBTYWx0b2FwaXNcTmVidWxhXEluc3RhbGxhdGlv",
                  "blxWMeICLEdQQk1ldGFkYXRhXFNhbHRvYXBpc1xOZWJ1bGFcSW5zdGFsbGF0",
                  "aW9uXFYxYgZwcm90bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, Type.ColorReflection.Descriptor, Type.DateReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Installation), Installation.Parser, ["Name", "DisplayName", "Photo", "PhotoUri", "Address", "TimeZone", "DigitalKeyArt", "TransferOwnershipState", "DeleteTime", "PartnerInfo", "BlockTime", "KeyRenewalDuration"], ["Photo", "PartnerInfo", "BlockTime"], null, null, [ new(typeof(Installation.Types.DigitalKeyArt), Installation.Types.DigitalKeyArt.Parser, ["BackgroundImage", "BackgroundImageUri", "TextColor"], ["BackgroundImage", "TextColor"], null, null, null),
            new(typeof(Installation.Types.TransferOwnershipState), Installation.Types.TransferOwnershipState.Parser, ["Email", "ExpireTime"], null, null, null, null),
            new(typeof(Installation.Types.PartnerInfo), Installation.Types.PartnerInfo.Parser, ["PartnerId", "CurrencyCode"], null, null, null, null)]),
            new(typeof(Subscription), Subscription.Parser, ["Name", "TrialEndTime", "BillingInfo", "PaymentMethod", "Coupons"], ["TrialEndTime"], null, null, null),
            new(typeof(BillingInfo), BillingInfo.Parser, ["Name", "Company", "Address", "RegionCode", "City", "StateCode", "Zip", "VatNumber"], ["StateCode", "VatNumber"], null, null, null),
            new(typeof(PaymentMethod), PaymentMethod.Parser, ["Name", "Card", "DirectDebit"], ["Method"], null, null, [ new(typeof(PaymentMethod.Types.Card), PaymentMethod.Types.Card.Parser, ["ExpireDate", "LastFour", "Brand", "PaymentAuthorization"], null, null, null, null),
            new(typeof(PaymentMethod.Types.DirectDebit), PaymentMethod.Types.DirectDebit.Parser, ["Sepa"], ["Scheme"], null, null, [new(typeof(PaymentMethod.Types.DirectDebit.Types.SEPA), PaymentMethod.Types.DirectDebit.Types.SEPA.Parser, ["LastFour", "AccountHolder", "Iban"], null, null, null, null)])]),
            new(typeof(PaymentAuthorization), PaymentAuthorization.Parser, ["Name"], null, null, null, null),
            new(typeof(Coupon), Coupon.Parser, ["Name"], null, null, null, null),
            new(typeof(Invoice), Invoice.Parser, ["Name", "StartTime", "EndTime", "LineItems", "Total", "State"], null, [typeof(Invoice.Types.State)], null, [new(typeof(Invoice.Types.LineItem), Invoice.Types.LineItem.Parser, ["Id", "Quantity", "Price"], null, null, null, null)]),
            new(typeof(Policy), Policy.Parser, ["Name", "Member", "Roles"], null, null, null, null),
            new(typeof(CreateInstallationRequest), CreateInstallationRequest.Parser, ["InstallationId", "Installation", "ValidateOnly"], ["InstallationId", "ValidateOnly"], null, null, null),
            new(typeof(GetInstallationRequest), GetInstallationRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListInstallationsRequest), ListInstallationsRequest.Parser, ["PageSize", "PageToken", "Filter", "OrderBy", "ShowDeleted"], null, null, null, null),
            new(typeof(ListInstallationsResponse), ListInstallationsResponse.Parser, ["Installations", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateInstallationRequest), UpdateInstallationRequest.Parser, ["Installation", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteInstallationRequest), DeleteInstallationRequest.Parser, ["Name", "ValidateOnly", "DelayHours"], ["ValidateOnly", "DelayHours"], null, null, null),
            new(typeof(UndeleteInstallationRequest), UndeleteInstallationRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(CreatePolicyRequest), CreatePolicyRequest.Parser, ["Parent", "PolicyId", "Policy"], null, null, null, null),
            new(typeof(GetPolicyRequest), GetPolicyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListPoliciesRequest), ListPoliciesRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListPoliciesResponse), ListPoliciesResponse.Parser, ["Policies", "NextPageToken"], null, null, null, null),
            new(typeof(UpdatePolicyRequest), UpdatePolicyRequest.Parser, ["Policy", "UpdateMask"], null, null, null, null),
            new(typeof(DeletePolicyRequest), DeletePolicyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(TestPermissionsRequest), TestPermissionsRequest.Parser, ["Installation", "Permissions"], null, null, null, null),
            new(typeof(TestPermissionsResponse), TestPermissionsResponse.Parser, ["Permissions"], null, null, null, null),
            new(typeof(TransferInstallationOwnershipRequest), TransferInstallationOwnershipRequest.Parser, ["Installation", "Email"], null, null, null, null),
            new(typeof(TransferInstallationOwnershipResponse), TransferInstallationOwnershipResponse.Parser, null, null, null, null, null),
            new(typeof(AcceptInstallationOwnershipRequest), AcceptInstallationOwnershipRequest.Parser, ["Installation", "BillingInfo"], ["BillingInfo"], null, null, null),
            new(typeof(AcceptInstallationOwnershipResponse), AcceptInstallationOwnershipResponse.Parser, null, null, null, null, null),
            new(typeof(GetSubscriptionRequest), GetSubscriptionRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(UpdateBillingInfoRequest), UpdateBillingInfoRequest.Parser, ["BillingInfo"], null, null, null, null),
            new(typeof(UpdatePaymentMethodRequest), UpdatePaymentMethodRequest.Parser, ["PaymentMethod"], null, null, null, null),
            new(typeof(UpdateCardRequest), UpdateCardRequest.Parser, ["PaymentMethod", "Token"], null, null, null, null),
            new(typeof(UpdateCardResponse), UpdateCardResponse.Parser, null, null, null, null, null),
            new(typeof(CreatePaymentAuthorizationRequest), CreatePaymentAuthorizationRequest.Parser, ["Parent", "PaymentAuthorization"], null, null, null, null),
            new(typeof(ListInvoicesRequest), ListInvoicesRequest.Parser, ["Parent"], null, null, null, null),
            new(typeof(ListInvoicesResponse), ListInvoicesResponse.Parser, ["Invoices"], null, null, null, null),
            new(typeof(ApplyCouponRequest), ApplyCouponRequest.Parser, ["Subscription", "Coupon"], null, null, null, null),
            new(typeof(ApplyCouponResponse), ApplyCouponResponse.Parser, null, null, null, null, null),
            new(typeof(UnapplyCouponRequest), UnapplyCouponRequest.Parser, ["Subscription", "Coupon"], null, null, null, null),
            new(typeof(UnapplyCouponResponse), UnapplyCouponResponse.Parser, null, null, null, null, null),
            new(typeof(GenerateAuthorizationTokenRequest), GenerateAuthorizationTokenRequest.Parser, ["Installation"], null, null, null, null),
            new(typeof(GenerateAuthorizationTokenResponse), GenerateAuthorizationTokenResponse.Parser, ["AuthorizationToken"], null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// The installation object
    /// </summary>
    public sealed partial class Installation : IMessage<Installation>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Installation> _parser = new(() => new Installation());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Installation> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Installation()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Installation(Installation other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            photo_ = other.photo_;
            photoUri_ = other.photoUri_;
            address_ = other.address_;
            timeZone_ = other.timeZone_;
            digitalKeyArt_ = other.digitalKeyArt_?.Clone();
            transferOwnershipState_ = other.transferOwnershipState_?.Clone();
            deleteTime_ = other.deleteTime_?.Clone();
            partnerInfo_ = other.partnerInfo_?.Clone();
            blockTime_ = other.blockTime_?.Clone();
            keyRenewalDuration_ = other.keyRenewalDuration_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Installation Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the installation. It must have the format
        /// of `installations/*`. For example: `installations/surelock-homes-hq`.
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
        /// Display name of the installation.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "photo" field.</summary>
        public const int PhotoFieldNumber = 3;
        private readonly static string PhotoDefaultValue = "";

        private string photo_;

        /// <summary>
        /// The file resource name for the installation photo. It must have the
        /// format of
        /// `installations/surelock-homes-hq/files/01DSYSJ1PR36VVC3MRFRV4DC7G`.
        /// </summary>
        public string Photo
        {
            get { return photo_ ?? PhotoDefaultValue; }
            set
            {
                photo_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "photo" field is set</summary>
        public bool HasPhoto
        {
            get { return photo_ != null; }
        }

        /// <summary>Clears the value of the "photo" field</summary>
        public void ClearPhoto()
        {
            photo_ = null;
        }

        /// <summary>Field number for the "photo_uri" field.</summary>
        public const int PhotoUriFieldNumber = 4;
        private string photoUri_ = "";

        /// <summary>
        /// The URI to view the installation photo.
        /// </summary>
        public string PhotoUri
        {
            get { return photoUri_; }
            set
            {
                photoUri_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "address" field.</summary>
        public const int AddressFieldNumber = 5;
        private string address_ = "";

        /// <summary>
        /// Unstructured address.
        ///
        /// For example: "1600 Amphitheatre Pkwy, Mountain View, CA 94043,
        /// Sunnyvale, California."
        /// </summary>
        public string Address
        {
            get { return address_; }
            set
            {
                address_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "time_zone" field.</summary>
        public const int TimeZoneFieldNumber = 6;
        private string timeZone_ = "";

        /// <summary>
        /// Time zone where the installation is located. It must follow the IANA Time
        /// Zone Database format. For example, "America/New_York."
        /// </summary>
        public string TimeZone
        {
            get { return timeZone_; }
            set
            {
                timeZone_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "digital_key_art" field.</summary>
        public const int DigitalKeyArtFieldNumber = 7;
        private Types.DigitalKeyArt digitalKeyArt_;

        /// <summary>
        /// The digital key art configuration resource that belongs to the installation.
        /// </summary>
        public Types.DigitalKeyArt DigitalKeyArt
        {
            get { return digitalKeyArt_; }
            set
            {
                digitalKeyArt_ = value;
            }
        }

        /// <summary>Field number for the "transfer_ownership_state" field.</summary>
        public const int TransferOwnershipStateFieldNumber = 8;
        private Types.TransferOwnershipState transferOwnershipState_;

        /// <summary>
        /// Current state of the ownership transfer. Client must not set the
        /// `Installation.transfer_ownership_state` field. This data is only
        /// visible to the current installation owner.
        /// </summary>
        public Types.TransferOwnershipState TransferOwnershipState
        {
            get { return transferOwnershipState_; }
            set
            {
                transferOwnershipState_ = value;
            }
        }

        /// <summary>Field number for the "delete_time" field.</summary>
        public const int DeleteTimeFieldNumber = 12;
        private Google.Protobuf.WellKnownTypes.Timestamp deleteTime_;

        /// <summary>
        /// The time when the installation was soft deleted.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp DeleteTime
        {
            get { return deleteTime_; }
            set
            {
                deleteTime_ = value;
            }
        }

        /// <summary>Field number for the "partner_info" field.</summary>
        public const int PartnerInfoFieldNumber = 9;
        private Types.PartnerInfo partnerInfo_;

        /// <summary>
        /// The information of the partner who created the installation.
        /// </summary>
        public Types.PartnerInfo PartnerInfo
        {
            get { return partnerInfo_; }
            set
            {
                partnerInfo_ = value;
            }
        }

        /// <summary>Field number for the "block_time" field.</summary>
        public const int BlockTimeFieldNumber = 11;
        private Google.Protobuf.WellKnownTypes.Timestamp blockTime_;

        /// <summary>
        /// The time when the installation was blocked.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp BlockTime
        {
            get { return blockTime_; }
            set
            {
                blockTime_ = value;
            }
        }

        /// <summary>Field number for the "key_renewal_duration" field.</summary>
        public const int KeyRenewalDurationFieldNumber = 10;
        private Google.Protobuf.WellKnownTypes.Duration keyRenewalDuration_;

        /// <summary>
        /// The length of time a key remains valid before requiring renewal. This
        /// duration defines the effective lifespan of a key, after which it must be
        /// updated to maintain access privileges. The duration is crucial for
        /// ensuring security in the system, as it determines how frequently keys
        /// need to be renewed.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Duration KeyRenewalDuration
        {
            get { return keyRenewalDuration_; }
            set
            {
                keyRenewalDuration_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as Installation);
        public bool Equals(Installation other)
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
            if (Photo != other.Photo) return false;
            if (PhotoUri != other.PhotoUri) return false;
            if (Address != other.Address) return false;
            if (TimeZone != other.TimeZone) return false;
            if (!Equals(DigitalKeyArt, other.DigitalKeyArt)) return false;
            if (!Equals(TransferOwnershipState, other.TransferOwnershipState)) return false;
            if (!Equals(DeleteTime, other.DeleteTime)) return false;
            if (!Equals(PartnerInfo, other.PartnerInfo)) return false;
            if (!Equals(BlockTime, other.BlockTime)) return false;
            if (!Equals(KeyRenewalDuration, other.KeyRenewalDuration)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            if (HasPhoto) hash ^= Photo.GetHashCode();
            if (PhotoUri.Length != 0) hash ^= PhotoUri.GetHashCode();
            if (Address.Length != 0) hash ^= Address.GetHashCode();
            if (TimeZone.Length != 0) hash ^= TimeZone.GetHashCode();
            if (digitalKeyArt_ != null) hash ^= DigitalKeyArt.GetHashCode();
            if (transferOwnershipState_ != null) hash ^= TransferOwnershipState.GetHashCode();
            if (deleteTime_ != null) hash ^= DeleteTime.GetHashCode();
            if (partnerInfo_ != null) hash ^= PartnerInfo.GetHashCode();
            if (blockTime_ != null) hash ^= BlockTime.GetHashCode();
            if (keyRenewalDuration_ != null) hash ^= KeyRenewalDuration.GetHashCode();
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
      if (HasPhoto) {
        output.WriteRawTag(26);
        output.WriteString(Photo);
      }
      if (PhotoUri.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(PhotoUri);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Address);
      }
      if (TimeZone.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(TimeZone);
      }
      if (digitalKeyArt_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(DigitalKeyArt);
      }
      if (transferOwnershipState_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(TransferOwnershipState);
      }
      if (partnerInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(PartnerInfo);
      }
      if (keyRenewalDuration_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(KeyRenewalDuration);
      }
      if (blockTime_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(BlockTime);
      }
      if (deleteTime_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(DeleteTime);
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
            if (HasPhoto)
            {
                output.WriteRawTag(26);
                output.WriteString(Photo);
            }
            if (PhotoUri.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(PhotoUri);
            }
            if (Address.Length != 0)
            {
                output.WriteRawTag(42);
                output.WriteString(Address);
            }
            if (TimeZone.Length != 0)
            {
                output.WriteRawTag(50);
                output.WriteString(TimeZone);
            }
            if (digitalKeyArt_ != null)
            {
                output.WriteRawTag(58);
                output.WriteMessage(DigitalKeyArt);
            }
            if (transferOwnershipState_ != null)
            {
                output.WriteRawTag(66);
                output.WriteMessage(TransferOwnershipState);
            }
            if (partnerInfo_ != null)
            {
                output.WriteRawTag(74);
                output.WriteMessage(PartnerInfo);
            }
            if (keyRenewalDuration_ != null)
            {
                output.WriteRawTag(82);
                output.WriteMessage(KeyRenewalDuration);
            }
            if (blockTime_ != null)
            {
                output.WriteRawTag(90);
                output.WriteMessage(BlockTime);
            }
            if (deleteTime_ != null)
            {
                output.WriteRawTag(98);
                output.WriteMessage(DeleteTime);
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
            if (HasPhoto)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Photo);
            }
            if (PhotoUri.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(PhotoUri);
            }
            if (Address.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Address);
            }
            if (TimeZone.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(TimeZone);
            }
            if (digitalKeyArt_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(DigitalKeyArt);
            }
            if (transferOwnershipState_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(TransferOwnershipState);
            }
            if (deleteTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(DeleteTime);
            }
            if (partnerInfo_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(PartnerInfo);
            }
            if (blockTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(BlockTime);
            }
            if (keyRenewalDuration_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(KeyRenewalDuration);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(Installation other)
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
            if (other.HasPhoto)
            {
                Photo = other.Photo;
            }
            if (other.PhotoUri.Length != 0)
            {
                PhotoUri = other.PhotoUri;
            }
            if (other.Address.Length != 0)
            {
                Address = other.Address;
            }
            if (other.TimeZone.Length != 0)
            {
                TimeZone = other.TimeZone;
            }
            if (other.digitalKeyArt_ != null)
            {
                if (digitalKeyArt_ == null)
                {
                    DigitalKeyArt = new Types.DigitalKeyArt();
                }
                DigitalKeyArt.MergeFrom(other.DigitalKeyArt);
            }
            if (other.transferOwnershipState_ != null)
            {
                if (transferOwnershipState_ == null)
                {
                    TransferOwnershipState = new Types.TransferOwnershipState();
                }
                TransferOwnershipState.MergeFrom(other.TransferOwnershipState);
            }
            if (other.deleteTime_ != null)
            {
                if (deleteTime_ == null)
                {
                    DeleteTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                DeleteTime.MergeFrom(other.DeleteTime);
            }
            if (other.partnerInfo_ != null)
            {
                if (partnerInfo_ == null)
                {
                    PartnerInfo = new Types.PartnerInfo();
                }
                PartnerInfo.MergeFrom(other.PartnerInfo);
            }
            if (other.blockTime_ != null)
            {
                if (blockTime_ == null)
                {
                    BlockTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                BlockTime.MergeFrom(other.BlockTime);
            }
            if (other.keyRenewalDuration_ != null)
            {
                if (keyRenewalDuration_ == null)
                {
                    KeyRenewalDuration = new Google.Protobuf.WellKnownTypes.Duration();
                }
                KeyRenewalDuration.MergeFrom(other.KeyRenewalDuration);
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
            Photo = input.ReadString();
            break;
          }
          case 34: {
            PhotoUri = input.ReadString();
            break;
          }
          case 42: {
            Address = input.ReadString();
            break;
          }
          case 50: {
            TimeZone = input.ReadString();
            break;
          }
          case 58: {
            if (digitalKeyArt_ == null) {
              DigitalKeyArt = new Saltoapis.Nebula.Installation.V1.Installation.Types.DigitalKeyArt();
            }
            input.ReadMessage(DigitalKeyArt);
            break;
          }
          case 66: {
            if (transferOwnershipState_ == null) {
              TransferOwnershipState = new Saltoapis.Nebula.Installation.V1.Installation.Types.TransferOwnershipState();
            }
            input.ReadMessage(TransferOwnershipState);
            break;
          }
          case 74: {
            if (partnerInfo_ == null) {
              PartnerInfo = new Saltoapis.Nebula.Installation.V1.Installation.Types.PartnerInfo();
            }
            input.ReadMessage(PartnerInfo);
            break;
          }
          case 82: {
            if (keyRenewalDuration_ == null) {
              KeyRenewalDuration = new Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(KeyRenewalDuration);
            break;
          }
          case 90: {
            if (blockTime_ == null) {
              BlockTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(BlockTime);
            break;
          }
          case 98: {
            if (deleteTime_ == null) {
              DeleteTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(DeleteTime);
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
                            Photo = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            PhotoUri = input.ReadString();
                            break;
                        }
                    case 42:
                        {
                            Address = input.ReadString();
                            break;
                        }
                    case 50:
                        {
                            TimeZone = input.ReadString();
                            break;
                        }
                    case 58:
                        {
                            if (digitalKeyArt_ == null)
                            {
                                DigitalKeyArt = new Types.DigitalKeyArt();
                            }
                            input.ReadMessage(DigitalKeyArt);
                            break;
                        }
                    case 66:
                        {
                            if (transferOwnershipState_ == null)
                            {
                                TransferOwnershipState = new Types.TransferOwnershipState();
                            }
                            input.ReadMessage(TransferOwnershipState);
                            break;
                        }
                    case 74:
                        {
                            if (partnerInfo_ == null)
                            {
                                PartnerInfo = new Types.PartnerInfo();
                            }
                            input.ReadMessage(PartnerInfo);
                            break;
                        }
                    case 82:
                        {
                            if (keyRenewalDuration_ == null)
                            {
                                KeyRenewalDuration = new Google.Protobuf.WellKnownTypes.Duration();
                            }
                            input.ReadMessage(KeyRenewalDuration);
                            break;
                        }
                    case 90:
                        {
                            if (blockTime_ == null)
                            {
                                BlockTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(BlockTime);
                            break;
                        }
                    case 98:
                        {
                            if (deleteTime_ == null)
                            {
                                DeleteTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(DeleteTime);
                            break;
                        }
                }
            }
        }
#endif

        #region Nested types
        /// <summary>Container for nested types declared in the Installation message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// The digital key art configuration object associated to the installation
            /// </summary>
            public sealed partial class DigitalKeyArt : IMessage<DigitalKeyArt>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<DigitalKeyArt> _parser = new(() => new DigitalKeyArt());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<DigitalKeyArt> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return Installation.Descriptor.NestedTypes[0]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public DigitalKeyArt()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public DigitalKeyArt(DigitalKeyArt other) : this()
                {
                    backgroundImage_ = other.backgroundImage_;
                    backgroundImageUri_ = other.backgroundImageUri_;
                    textColor_ = other.textColor_?.Clone();
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public DigitalKeyArt Clone() => new(this);
                /// <summary>Field number for the "background_image" field.</summary>
                public const int BackgroundImageFieldNumber = 1;
                private readonly static string BackgroundImageDefaultValue = "";

                private string backgroundImage_;

                /// <summary>
                /// The file resource name for the digital key background image. It must
                /// have the format of
                /// `installations/surelock-homes-hq/files/01DSYSJ1PR36VVC3MRFRV4DC7G`.
                /// </summary>
                public string BackgroundImage
                {
                    get { return backgroundImage_ ?? BackgroundImageDefaultValue; }
                    set
                    {
                        backgroundImage_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Gets whether the "background_image" field is set</summary>
                public bool HasBackgroundImage
                {
                    get { return backgroundImage_ != null; }
                }

                /// <summary>Clears the value of the "background_image" field</summary>
                public void ClearBackgroundImage()
                {
                    backgroundImage_ = null;
                }

                /// <summary>Field number for the "background_image_uri" field.</summary>
                public const int BackgroundImageUriFieldNumber = 2;
                private string backgroundImageUri_ = "";

                /// <summary>
                /// The URI to view the digital key background image.
                /// </summary>
                public string BackgroundImageUri
                {
                    get { return backgroundImageUri_; }
                    set
                    {
                        backgroundImageUri_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Field number for the "text_color" field.</summary>
                public const int TextColorFieldNumber = 3;
                private Type.Color textColor_;

                /// <summary>
                /// The color used to display the installation name text on top of the background image.
                /// </summary>
                public Type.Color TextColor
                {
                    get { return textColor_; }
                    set
                    {
                        textColor_ = value;
                    }
                }

                public override bool Equals(object other) => Equals(other as DigitalKeyArt);
                public bool Equals(DigitalKeyArt other)
                {
                    if (other is null)
                    {
                        return false;
                    }
                    if (ReferenceEquals(other, this))
                    {
                        return true;
                    }
                    if (BackgroundImage != other.BackgroundImage) return false;
                    if (BackgroundImageUri != other.BackgroundImageUri) return false;
                    if (!Equals(TextColor, other.TextColor)) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (HasBackgroundImage) hash ^= BackgroundImage.GetHashCode();
                    if (BackgroundImageUri.Length != 0) hash ^= BackgroundImageUri.GetHashCode();
                    if (textColor_ != null) hash ^= TextColor.GetHashCode();
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
          if (HasBackgroundImage) {
            output.WriteRawTag(10);
            output.WriteString(BackgroundImage);
          }
          if (BackgroundImageUri.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(BackgroundImageUri);
          }
          if (textColor_ != null) {
            output.WriteRawTag(26);
            output.WriteMessage(TextColor);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
                }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                void IBufferMessage.InternalWriteTo(ref WriteContext output)
                {
                    if (HasBackgroundImage)
                    {
                        output.WriteRawTag(10);
                        output.WriteString(BackgroundImage);
                    }
                    if (BackgroundImageUri.Length != 0)
                    {
                        output.WriteRawTag(18);
                        output.WriteString(BackgroundImageUri);
                    }
                    if (textColor_ != null)
                    {
                        output.WriteRawTag(26);
                        output.WriteMessage(TextColor);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (HasBackgroundImage)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(BackgroundImage);
                    }
                    if (BackgroundImageUri.Length != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(BackgroundImageUri);
                    }
                    if (textColor_ != null)
                    {
                        size += 1 + CodedOutputStream.ComputeMessageSize(TextColor);
                    }
                    if (_unknownFields != null)
                    {
                        size += _unknownFields.CalculateSize();
                    }
                    return size;
                }

                public void MergeFrom(DigitalKeyArt other)
                {
                    if (other == null)
                    {
                        return;
                    }
                    if (other.HasBackgroundImage)
                    {
                        BackgroundImage = other.BackgroundImage;
                    }
                    if (other.BackgroundImageUri.Length != 0)
                    {
                        BackgroundImageUri = other.BackgroundImageUri;
                    }
                    if (other.textColor_ != null)
                    {
                        if (textColor_ == null)
                        {
                            TextColor = new Type.Color();
                        }
                        TextColor.MergeFrom(other.TextColor);
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
                BackgroundImage = input.ReadString();
                break;
              }
              case 18: {
                BackgroundImageUri = input.ReadString();
                break;
              }
              case 26: {
                if (textColor_ == null) {
                  TextColor = new Saltoapis.Type.Color();
                }
                input.ReadMessage(TextColor);
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
                                    BackgroundImage = input.ReadString();
                                    break;
                                }
                            case 18:
                                {
                                    BackgroundImageUri = input.ReadString();
                                    break;
                                }
                            case 26:
                                {
                                    if (textColor_ == null)
                                    {
                                        TextColor = new Type.Color();
                                    }
                                    input.ReadMessage(TextColor);
                                    break;
                                }
                        }
                    }
                }
#endif

            }

            /// <summary>
            /// Represents the current state of the ownership transfer.
            /// </summary>
            public sealed partial class TransferOwnershipState : IMessage<TransferOwnershipState>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<TransferOwnershipState> _parser = new(() => new TransferOwnershipState());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<TransferOwnershipState> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return Installation.Descriptor.NestedTypes[1]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public TransferOwnershipState()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public TransferOwnershipState(TransferOwnershipState other) : this()
                {
                    email_ = other.email_;
                    expireTime_ = other.expireTime_?.Clone();
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public TransferOwnershipState Clone() => new(this);
                /// <summary>Field number for the "email" field.</summary>
                public const int EmailFieldNumber = 1;
                private string email_ = "";

                /// <summary>
                /// Email address for the proposed installation owner.
                /// </summary>
                public string Email
                {
                    get { return email_; }
                    set
                    {
                        email_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Field number for the "expire_time" field.</summary>
                public const int ExpireTimeFieldNumber = 2;
                private Google.Protobuf.WellKnownTypes.Timestamp expireTime_;

                /// <summary>
                /// Expiration time of the transfer proposal.
                /// (-- api-linter: core::0214::resource-expiry=disabled  --)
                /// </summary>
                public Google.Protobuf.WellKnownTypes.Timestamp ExpireTime
                {
                    get { return expireTime_; }
                    set
                    {
                        expireTime_ = value;
                    }
                }

                public override bool Equals(object other) => Equals(other as TransferOwnershipState);
                public bool Equals(TransferOwnershipState other)
                {
                    if (other is null)
                    {
                        return false;
                    }
                    if (ReferenceEquals(other, this))
                    {
                        return true;
                    }
                    if (Email != other.Email) return false;
                    if (!Equals(ExpireTime, other.ExpireTime)) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (Email.Length != 0) hash ^= Email.GetHashCode();
                    if (expireTime_ != null) hash ^= ExpireTime.GetHashCode();
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
          if (Email.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Email);
          }
          if (expireTime_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(ExpireTime);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
                }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                void IBufferMessage.InternalWriteTo(ref WriteContext output)
                {
                    if (Email.Length != 0)
                    {
                        output.WriteRawTag(10);
                        output.WriteString(Email);
                    }
                    if (expireTime_ != null)
                    {
                        output.WriteRawTag(18);
                        output.WriteMessage(ExpireTime);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (Email.Length != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(Email);
                    }
                    if (expireTime_ != null)
                    {
                        size += 1 + CodedOutputStream.ComputeMessageSize(ExpireTime);
                    }
                    if (_unknownFields != null)
                    {
                        size += _unknownFields.CalculateSize();
                    }
                    return size;
                }

                public void MergeFrom(TransferOwnershipState other)
                {
                    if (other == null)
                    {
                        return;
                    }
                    if (other.Email.Length != 0)
                    {
                        Email = other.Email;
                    }
                    if (other.expireTime_ != null)
                    {
                        if (expireTime_ == null)
                        {
                            ExpireTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                        }
                        ExpireTime.MergeFrom(other.ExpireTime);
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
                Email = input.ReadString();
                break;
              }
              case 18: {
                if (expireTime_ == null) {
                  ExpireTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                input.ReadMessage(ExpireTime);
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
                                    Email = input.ReadString();
                                    break;
                                }
                            case 18:
                                {
                                    if (expireTime_ == null)
                                    {
                                        ExpireTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                                    }
                                    input.ReadMessage(ExpireTime);
                                    break;
                                }
                        }
                    }
                }
#endif

            }

            /// <summary>
            /// The partner info object.
            /// </summary>
            public sealed partial class PartnerInfo : IMessage<PartnerInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<PartnerInfo> _parser = new(() => new PartnerInfo());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<PartnerInfo> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return Installation.Descriptor.NestedTypes[2]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public PartnerInfo()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public PartnerInfo(PartnerInfo other) : this()
                {
                    partnerId_ = other.partnerId_;
                    currencyCode_ = other.currencyCode_;
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public PartnerInfo Clone() => new(this);
                /// <summary>Field number for the "partner_id" field.</summary>
                public const int PartnerIdFieldNumber = 1;
                private string partnerId_ = "";

                /// <summary>
                /// The identifier of the partner who created the installation.
                /// </summary>
                public string PartnerId
                {
                    get { return partnerId_; }
                    set
                    {
                        partnerId_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Field number for the "currency_code" field.</summary>
                public const int CurrencyCodeFieldNumber = 2;
                private string currencyCode_ = "";

                /// <summary>
                /// The currency code the partner used for the installation (ISO 4217 format).
                /// </summary>
                public string CurrencyCode
                {
                    get { return currencyCode_; }
                    set
                    {
                        currencyCode_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                public override bool Equals(object other) => Equals(other as PartnerInfo);
                public bool Equals(PartnerInfo other)
                {
                    if (other is null)
                    {
                        return false;
                    }
                    if (ReferenceEquals(other, this))
                    {
                        return true;
                    }
                    if (PartnerId != other.PartnerId) return false;
                    if (CurrencyCode != other.CurrencyCode) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (PartnerId.Length != 0) hash ^= PartnerId.GetHashCode();
                    if (CurrencyCode.Length != 0) hash ^= CurrencyCode.GetHashCode();
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
          if (PartnerId.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(PartnerId);
          }
          if (CurrencyCode.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(CurrencyCode);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
                }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                void IBufferMessage.InternalWriteTo(ref WriteContext output)
                {
                    if (PartnerId.Length != 0)
                    {
                        output.WriteRawTag(10);
                        output.WriteString(PartnerId);
                    }
                    if (CurrencyCode.Length != 0)
                    {
                        output.WriteRawTag(18);
                        output.WriteString(CurrencyCode);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (PartnerId.Length != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(PartnerId);
                    }
                    if (CurrencyCode.Length != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(CurrencyCode);
                    }
                    if (_unknownFields != null)
                    {
                        size += _unknownFields.CalculateSize();
                    }
                    return size;
                }

                public void MergeFrom(PartnerInfo other)
                {
                    if (other == null)
                    {
                        return;
                    }
                    if (other.PartnerId.Length != 0)
                    {
                        PartnerId = other.PartnerId;
                    }
                    if (other.CurrencyCode.Length != 0)
                    {
                        CurrencyCode = other.CurrencyCode;
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
                PartnerId = input.ReadString();
                break;
              }
              case 18: {
                CurrencyCode = input.ReadString();
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
                                    PartnerId = input.ReadString();
                                    break;
                                }
                            case 18:
                                {
                                    CurrencyCode = input.ReadString();
                                    break;
                                }
                        }
                    }
                }
#endif

            }

        }
        #endregion

    }

    /// <summary>
    /// The subscription information
    /// </summary>
    public sealed partial class Subscription : IMessage<Subscription>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Subscription> _parser = new(() => new Subscription());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Subscription> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Subscription()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Subscription(Subscription other) : this()
        {
            name_ = other.name_;
            trialEndTime_ = other.trialEndTime_?.Clone();
            billingInfo_ = other.billingInfo_?.Clone();
            paymentMethod_ = other.paymentMethod_?.Clone();
            coupons_ = other.coupons_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Subscription Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the subscription. It must have the format of
        /// `installations/*/subscription`. For example:
        /// `installations/surelock-homes-hq/subscription`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "trial_end_time" field.</summary>
        public const int TrialEndTimeFieldNumber = 3;
        private Google.Protobuf.WellKnownTypes.Timestamp trialEndTime_;

        /// <summary>
        /// End of the trial period for the subscription.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp TrialEndTime
        {
            get { return trialEndTime_; }
            set
            {
                trialEndTime_ = value;
            }
        }

        /// <summary>Field number for the "billing_info" field.</summary>
        public const int BillingInfoFieldNumber = 4;
        private BillingInfo billingInfo_;

        /// <summary>
        /// The billing information of the subscription.
        /// </summary>
        public BillingInfo BillingInfo
        {
            get { return billingInfo_; }
            set
            {
                billingInfo_ = value;
            }
        }

        /// <summary>Field number for the "payment_method" field.</summary>
        public const int PaymentMethodFieldNumber = 5;
        private PaymentMethod paymentMethod_;

        /// <summary>
        /// The payment method of the subscription.
        /// </summary>
        public PaymentMethod PaymentMethod
        {
            get { return paymentMethod_; }
            set
            {
                paymentMethod_ = value;
            }
        }

        /// <summary>Field number for the "coupons" field.</summary>
        public const int CouponsFieldNumber = 6;
        private static readonly FieldCodec<Coupon> _repeated_coupons_codec
            = FieldCodec.ForMessage(50, Coupon.Parser);
        private readonly RepeatedField<Coupon> coupons_ = [];

        /// <summary>
        /// The coupons applied to the subscription.
        /// </summary>
        public RepeatedField<Coupon> Coupons
        {
            get { return coupons_; }
        }

        public override bool Equals(object other) => Equals(other as Subscription);
        public bool Equals(Subscription other)
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
            if (!Equals(TrialEndTime, other.TrialEndTime)) return false;
            if (!Equals(BillingInfo, other.BillingInfo)) return false;
            if (!Equals(PaymentMethod, other.PaymentMethod)) return false;
            if (!coupons_.Equals(other.coupons_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (trialEndTime_ != null) hash ^= TrialEndTime.GetHashCode();
            if (billingInfo_ != null) hash ^= BillingInfo.GetHashCode();
            if (paymentMethod_ != null) hash ^= PaymentMethod.GetHashCode();
            hash ^= coupons_.GetHashCode();
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
      if (trialEndTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(TrialEndTime);
      }
      if (billingInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(BillingInfo);
      }
      if (paymentMethod_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(PaymentMethod);
      }
      coupons_.WriteTo(output, _repeated_coupons_codec);
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
            if (trialEndTime_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(TrialEndTime);
            }
            if (billingInfo_ != null)
            {
                output.WriteRawTag(34);
                output.WriteMessage(BillingInfo);
            }
            if (paymentMethod_ != null)
            {
                output.WriteRawTag(42);
                output.WriteMessage(PaymentMethod);
            }
            coupons_.WriteTo(ref output, _repeated_coupons_codec);
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
            if (trialEndTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(TrialEndTime);
            }
            if (billingInfo_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(BillingInfo);
            }
            if (paymentMethod_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(PaymentMethod);
            }
            size += coupons_.CalculateSize(_repeated_coupons_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(Subscription other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.trialEndTime_ != null)
            {
                if (trialEndTime_ == null)
                {
                    TrialEndTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                TrialEndTime.MergeFrom(other.TrialEndTime);
            }
            if (other.billingInfo_ != null)
            {
                if (billingInfo_ == null)
                {
                    BillingInfo = new BillingInfo();
                }
                BillingInfo.MergeFrom(other.BillingInfo);
            }
            if (other.paymentMethod_ != null)
            {
                if (paymentMethod_ == null)
                {
                    PaymentMethod = new PaymentMethod();
                }
                PaymentMethod.MergeFrom(other.PaymentMethod);
            }
            coupons_.Add(other.coupons_);
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
          case 26: {
            if (trialEndTime_ == null) {
              TrialEndTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(TrialEndTime);
            break;
          }
          case 34: {
            if (billingInfo_ == null) {
              BillingInfo = new Saltoapis.Nebula.Installation.V1.BillingInfo();
            }
            input.ReadMessage(BillingInfo);
            break;
          }
          case 42: {
            if (paymentMethod_ == null) {
              PaymentMethod = new Saltoapis.Nebula.Installation.V1.PaymentMethod();
            }
            input.ReadMessage(PaymentMethod);
            break;
          }
          case 50: {
            coupons_.AddEntriesFrom(input, _repeated_coupons_codec);
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
                    case 26:
                        {
                            if (trialEndTime_ == null)
                            {
                                TrialEndTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(TrialEndTime);
                            break;
                        }
                    case 34:
                        {
                            if (billingInfo_ == null)
                            {
                                BillingInfo = new BillingInfo();
                            }
                            input.ReadMessage(BillingInfo);
                            break;
                        }
                    case 42:
                        {
                            if (paymentMethod_ == null)
                            {
                                PaymentMethod = new PaymentMethod();
                            }
                            input.ReadMessage(PaymentMethod);
                            break;
                        }
                    case 50:
                        {
                            coupons_.AddEntriesFrom(ref input, _repeated_coupons_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Billing info object, belonging to a subscription
    /// </summary>
    public sealed partial class BillingInfo : IMessage<BillingInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BillingInfo> _parser = new(() => new BillingInfo());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BillingInfo> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BillingInfo()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BillingInfo(BillingInfo other) : this()
        {
            name_ = other.name_;
            company_ = other.company_;
            address_ = other.address_.Clone();
            regionCode_ = other.regionCode_;
            city_ = other.city_;
            stateCode_ = other.stateCode_;
            zip_ = other.zip_;
            vatNumber_ = other.vatNumber_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BillingInfo Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the subscription's billing info. It must have the format of
        /// `installations/*/subscription/billing-info`. For example:
        /// `installations/surelock-homes-hq/subscription/billing-info`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "company" field.</summary>
        public const int CompanyFieldNumber = 2;
        private string company_ = "";

        /// <summary>
        /// The company name.
        /// </summary>
        public string Company
        {
            get { return company_; }
            set
            {
                company_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "address" field.</summary>
        public const int AddressFieldNumber = 3;
        private static readonly FieldCodec<string> _repeated_address_codec
            = FieldCodec.ForString(26);
        private readonly RepeatedField<string> address_ = [];

        /// <summary>
        /// The lines of the address. The first line may include the street name,
        /// number, P.O. box, and further lines can include information such as
        /// an apartment number, suite or unit.
        /// </summary>
        public RepeatedField<string> Address
        {
            get { return address_; }
        }

        /// <summary>Field number for the "region_code" field.</summary>
        public const int RegionCodeFieldNumber = 4;
        private string regionCode_ = "";

        /// <summary>
        /// The region, country or territory code. Must be in ISO 3166-1 format.
        /// </summary>
        public string RegionCode
        {
            get { return regionCode_; }
            set
            {
                regionCode_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "city" field.</summary>
        public const int CityFieldNumber = 5;
        private string city_ = "";

        /// <summary>
        /// The city, district, suburb, town, or village name.
        /// </summary>
        public string City
        {
            get { return city_; }
            set
            {
                city_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "state_code" field.</summary>
        public const int StateCodeFieldNumber = 6;
        private readonly static string StateCodeDefaultValue = "";

        private string stateCode_;

        /// <summary>
        /// The state or province code. Must be in ISO 3166-2 format.
        /// Mandatory for the following countries: USA, Canada and India.
        /// For the rest of the countries, it will be ignored.
        /// </summary>
        public string StateCode
        {
            get { return stateCode_ ?? StateCodeDefaultValue; }
            set
            {
                stateCode_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "state_code" field is set</summary>
        public bool HasStateCode
        {
            get { return stateCode_ != null; }
        }

        /// <summary>Clears the value of the "state_code" field</summary>
        public void ClearStateCode()
        {
            stateCode_ = null;
        }

        /// <summary>Field number for the "zip" field.</summary>
        public const int ZipFieldNumber = 7;
        private string zip_ = "";

        /// <summary>
        /// The ZIP or postal code.
        /// </summary>
        public string Zip
        {
            get { return zip_; }
            set
            {
                zip_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "vat_number" field.</summary>
        public const int VatNumberFieldNumber = 8;
        private readonly static string VatNumberDefaultValue = "";

        private string vatNumber_;

        /// <summary>
        /// The VAT or Tax Registration Number (TRN).
        /// </summary>
        public string VatNumber
        {
            get { return vatNumber_ ?? VatNumberDefaultValue; }
            set
            {
                vatNumber_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "vat_number" field is set</summary>
        public bool HasVatNumber
        {
            get { return vatNumber_ != null; }
        }

        /// <summary>Clears the value of the "vat_number" field</summary>
        public void ClearVatNumber()
        {
            vatNumber_ = null;
        }

        public override bool Equals(object other) => Equals(other as BillingInfo);
        public bool Equals(BillingInfo other)
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
            if (Company != other.Company) return false;
            if (!address_.Equals(other.address_)) return false;
            if (RegionCode != other.RegionCode) return false;
            if (City != other.City) return false;
            if (StateCode != other.StateCode) return false;
            if (Zip != other.Zip) return false;
            if (VatNumber != other.VatNumber) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (Company.Length != 0) hash ^= Company.GetHashCode();
            hash ^= address_.GetHashCode();
            if (RegionCode.Length != 0) hash ^= RegionCode.GetHashCode();
            if (City.Length != 0) hash ^= City.GetHashCode();
            if (HasStateCode) hash ^= StateCode.GetHashCode();
            if (Zip.Length != 0) hash ^= Zip.GetHashCode();
            if (HasVatNumber) hash ^= VatNumber.GetHashCode();
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
      if (Company.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Company);
      }
      address_.WriteTo(output, _repeated_address_codec);
      if (RegionCode.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(RegionCode);
      }
      if (City.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(City);
      }
      if (HasStateCode) {
        output.WriteRawTag(50);
        output.WriteString(StateCode);
      }
      if (Zip.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Zip);
      }
      if (HasVatNumber) {
        output.WriteRawTag(66);
        output.WriteString(VatNumber);
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
            if (Company.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Company);
            }
            address_.WriteTo(ref output, _repeated_address_codec);
            if (RegionCode.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(RegionCode);
            }
            if (City.Length != 0)
            {
                output.WriteRawTag(42);
                output.WriteString(City);
            }
            if (HasStateCode)
            {
                output.WriteRawTag(50);
                output.WriteString(StateCode);
            }
            if (Zip.Length != 0)
            {
                output.WriteRawTag(58);
                output.WriteString(Zip);
            }
            if (HasVatNumber)
            {
                output.WriteRawTag(66);
                output.WriteString(VatNumber);
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
            if (Company.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Company);
            }
            size += address_.CalculateSize(_repeated_address_codec);
            if (RegionCode.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(RegionCode);
            }
            if (City.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(City);
            }
            if (HasStateCode)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(StateCode);
            }
            if (Zip.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Zip);
            }
            if (HasVatNumber)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(VatNumber);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BillingInfo other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.Company.Length != 0)
            {
                Company = other.Company;
            }
            address_.Add(other.address_);
            if (other.RegionCode.Length != 0)
            {
                RegionCode = other.RegionCode;
            }
            if (other.City.Length != 0)
            {
                City = other.City;
            }
            if (other.HasStateCode)
            {
                StateCode = other.StateCode;
            }
            if (other.Zip.Length != 0)
            {
                Zip = other.Zip;
            }
            if (other.HasVatNumber)
            {
                VatNumber = other.VatNumber;
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
            Company = input.ReadString();
            break;
          }
          case 26: {
            address_.AddEntriesFrom(input, _repeated_address_codec);
            break;
          }
          case 34: {
            RegionCode = input.ReadString();
            break;
          }
          case 42: {
            City = input.ReadString();
            break;
          }
          case 50: {
            StateCode = input.ReadString();
            break;
          }
          case 58: {
            Zip = input.ReadString();
            break;
          }
          case 66: {
            VatNumber = input.ReadString();
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
                            Company = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            address_.AddEntriesFrom(ref input, _repeated_address_codec);
                            break;
                        }
                    case 34:
                        {
                            RegionCode = input.ReadString();
                            break;
                        }
                    case 42:
                        {
                            City = input.ReadString();
                            break;
                        }
                    case 50:
                        {
                            StateCode = input.ReadString();
                            break;
                        }
                    case 58:
                        {
                            Zip = input.ReadString();
                            break;
                        }
                    case 66:
                        {
                            VatNumber = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Representation of a payment method, belonging to a subscription
    /// </summary>
    public sealed partial class PaymentMethod : IMessage<PaymentMethod>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<PaymentMethod> _parser = new(() => new PaymentMethod());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<PaymentMethod> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public PaymentMethod()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public PaymentMethod(PaymentMethod other) : this()
        {
            name_ = other.name_;
            switch (other.MethodCase)
            {
                case MethodOneofCase.Card:
                    Card = other.Card.Clone();
                    break;
                case MethodOneofCase.DirectDebit:
                    DirectDebit = other.DirectDebit.Clone();
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public PaymentMethod Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the subscription's payment method. It must have the format of
        /// `installations/*/subscription/payment-method`. For example:
        /// `installations/surelock-homes-hq/subscription/payment-method`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "card" field.</summary>
        public const int CardFieldNumber = 2;

        /// <summary>
        /// Card details.
        /// </summary>
        public Types.Card Card
        {
            get { return methodCase_ == MethodOneofCase.Card ? (Types.Card)method_ : null; }
            set
            {
                method_ = value;
                methodCase_ = value == null ? MethodOneofCase.None : MethodOneofCase.Card;
            }
        }

        /// <summary>Field number for the "direct_debit" field.</summary>
        public const int DirectDebitFieldNumber = 3;

        /// <summary>
        /// Direct debit details.
        /// </summary>
        public Types.DirectDebit DirectDebit
        {
            get { return methodCase_ == MethodOneofCase.DirectDebit ? (Types.DirectDebit)method_ : null; }
            set
            {
                method_ = value;
                methodCase_ = value == null ? MethodOneofCase.None : MethodOneofCase.DirectDebit;
            }
        }

        private object method_;

        /// <summary>Enum of possible cases for the "method" oneof.</summary>
        public enum MethodOneofCase
        {
            None = 0,
            Card = 2,
            DirectDebit = 3,
        }

        private MethodOneofCase methodCase_ = MethodOneofCase.None;

        public MethodOneofCase MethodCase
        {
            get { return methodCase_; }
        }

        public void ClearMethod()
        {
            methodCase_ = MethodOneofCase.None;
            method_ = null;
        }

        public override bool Equals(object other) => Equals(other as PaymentMethod);
        public bool Equals(PaymentMethod other)
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
            if (!Equals(Card, other.Card)) return false;
            if (!Equals(DirectDebit, other.DirectDebit)) return false;
            if (MethodCase != other.MethodCase) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (methodCase_ == MethodOneofCase.Card) hash ^= Card.GetHashCode();
            if (methodCase_ == MethodOneofCase.DirectDebit) hash ^= DirectDebit.GetHashCode();
            hash ^= (int)methodCase_;
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
      if (methodCase_ == MethodOneofCase.Card) {
        output.WriteRawTag(18);
        output.WriteMessage(Card);
      }
      if (methodCase_ == MethodOneofCase.DirectDebit) {
        output.WriteRawTag(26);
        output.WriteMessage(DirectDebit);
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
            if (methodCase_ == MethodOneofCase.Card)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Card);
            }
            if (methodCase_ == MethodOneofCase.DirectDebit)
            {
                output.WriteRawTag(26);
                output.WriteMessage(DirectDebit);
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
            if (methodCase_ == MethodOneofCase.Card)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Card);
            }
            if (methodCase_ == MethodOneofCase.DirectDebit)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(DirectDebit);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(PaymentMethod other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            switch (other.MethodCase)
            {
                case MethodOneofCase.Card:
                    if (Card == null)
                    {
                        Card = new Types.Card();
                    }
                    Card.MergeFrom(other.Card);
                    break;
                case MethodOneofCase.DirectDebit:
                    if (DirectDebit == null)
                    {
                        DirectDebit = new Types.DirectDebit();
                    }
                    DirectDebit.MergeFrom(other.DirectDebit);
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
            Saltoapis.Nebula.Installation.V1.PaymentMethod.Types.Card subBuilder = new Saltoapis.Nebula.Installation.V1.PaymentMethod.Types.Card();
            if (methodCase_ == MethodOneofCase.Card) {
              subBuilder.MergeFrom(Card);
            }
            input.ReadMessage(subBuilder);
            Card = subBuilder;
            break;
          }
          case 26: {
            Saltoapis.Nebula.Installation.V1.PaymentMethod.Types.DirectDebit subBuilder = new Saltoapis.Nebula.Installation.V1.PaymentMethod.Types.DirectDebit();
            if (methodCase_ == MethodOneofCase.DirectDebit) {
              subBuilder.MergeFrom(DirectDebit);
            }
            input.ReadMessage(subBuilder);
            DirectDebit = subBuilder;
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
                            Types.Card subBuilder = new();
                            if (methodCase_ == MethodOneofCase.Card)
                            {
                                subBuilder.MergeFrom(Card);
                            }
                            input.ReadMessage(subBuilder);
                            Card = subBuilder;
                            break;
                        }
                    case 26:
                        {
                            Types.DirectDebit subBuilder = new();
                            if (methodCase_ == MethodOneofCase.DirectDebit)
                            {
                                subBuilder.MergeFrom(DirectDebit);
                            }
                            input.ReadMessage(subBuilder);
                            DirectDebit = subBuilder;
                            break;
                        }
                }
            }
        }
#endif

        #region Nested types
        /// <summary>Container for nested types declared in the PaymentMethod message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// Card object
            /// </summary>
            public sealed partial class Card : IMessage<Card>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<Card> _parser = new(() => new Card());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<Card> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return PaymentMethod.Descriptor.NestedTypes[0]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public Card()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public Card(Card other) : this()
                {
                    expireDate_ = other.expireDate_?.Clone();
                    lastFour_ = other.lastFour_;
                    brand_ = other.brand_;
                    paymentAuthorization_ = other.paymentAuthorization_;
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public Card Clone() => new(this);
                /// <summary>Field number for the "expire_date" field.</summary>
                public const int ExpireDateFieldNumber = 1;
                private Type.Date expireDate_;

                /// <summary>
                /// The date the card expires.
                /// </summary>
                public Type.Date ExpireDate
                {
                    get { return expireDate_; }
                    set
                    {
                        expireDate_ = value;
                    }
                }

                /// <summary>Field number for the "last_four" field.</summary>
                public const int LastFourFieldNumber = 2;
                private string lastFour_ = "";

                /// <summary>
                /// The last four digits of the card.
                /// </summary>
                public string LastFour
                {
                    get { return lastFour_; }
                    set
                    {
                        lastFour_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Field number for the "brand" field.</summary>
                public const int BrandFieldNumber = 3;
                private string brand_ = "";

                /// <summary>
                /// The card brand. For example: visa, mastercard, american_express, other.
                /// </summary>
                public string Brand
                {
                    get { return brand_; }
                    set
                    {
                        brand_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Field number for the "payment_authorization" field.</summary>
                public const int PaymentAuthorizationFieldNumber = 4;
                private string paymentAuthorization_ = "";

                /// <summary>
                /// The payment authorization resource reference for updating the card.
                /// It must be authorized by the payment provider before it can be used.
                /// </summary>
                public string PaymentAuthorization
                {
                    get { return paymentAuthorization_; }
                    set
                    {
                        paymentAuthorization_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                public override bool Equals(object other) => Equals(other as Card);
                public bool Equals(Card other)
                {
                    if (other is null)
                    {
                        return false;
                    }
                    if (ReferenceEquals(other, this))
                    {
                        return true;
                    }
                    if (!Equals(ExpireDate, other.ExpireDate)) return false;
                    if (LastFour != other.LastFour) return false;
                    if (Brand != other.Brand) return false;
                    if (PaymentAuthorization != other.PaymentAuthorization) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (expireDate_ != null) hash ^= ExpireDate.GetHashCode();
                    if (LastFour.Length != 0) hash ^= LastFour.GetHashCode();
                    if (Brand.Length != 0) hash ^= Brand.GetHashCode();
                    if (PaymentAuthorization.Length != 0) hash ^= PaymentAuthorization.GetHashCode();
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
          if (expireDate_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(ExpireDate);
          }
          if (LastFour.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(LastFour);
          }
          if (Brand.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(Brand);
          }
          if (PaymentAuthorization.Length != 0) {
            output.WriteRawTag(34);
            output.WriteString(PaymentAuthorization);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
                }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                void IBufferMessage.InternalWriteTo(ref WriteContext output)
                {
                    if (expireDate_ != null)
                    {
                        output.WriteRawTag(10);
                        output.WriteMessage(ExpireDate);
                    }
                    if (LastFour.Length != 0)
                    {
                        output.WriteRawTag(18);
                        output.WriteString(LastFour);
                    }
                    if (Brand.Length != 0)
                    {
                        output.WriteRawTag(26);
                        output.WriteString(Brand);
                    }
                    if (PaymentAuthorization.Length != 0)
                    {
                        output.WriteRawTag(34);
                        output.WriteString(PaymentAuthorization);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (expireDate_ != null)
                    {
                        size += 1 + CodedOutputStream.ComputeMessageSize(ExpireDate);
                    }
                    if (LastFour.Length != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(LastFour);
                    }
                    if (Brand.Length != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(Brand);
                    }
                    if (PaymentAuthorization.Length != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(PaymentAuthorization);
                    }
                    if (_unknownFields != null)
                    {
                        size += _unknownFields.CalculateSize();
                    }
                    return size;
                }

                public void MergeFrom(Card other)
                {
                    if (other == null)
                    {
                        return;
                    }
                    if (other.expireDate_ != null)
                    {
                        if (expireDate_ == null)
                        {
                            ExpireDate = new Type.Date();
                        }
                        ExpireDate.MergeFrom(other.ExpireDate);
                    }
                    if (other.LastFour.Length != 0)
                    {
                        LastFour = other.LastFour;
                    }
                    if (other.Brand.Length != 0)
                    {
                        Brand = other.Brand;
                    }
                    if (other.PaymentAuthorization.Length != 0)
                    {
                        PaymentAuthorization = other.PaymentAuthorization;
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
                if (expireDate_ == null) {
                  ExpireDate = new Saltoapis.Type.Date();
                }
                input.ReadMessage(ExpireDate);
                break;
              }
              case 18: {
                LastFour = input.ReadString();
                break;
              }
              case 26: {
                Brand = input.ReadString();
                break;
              }
              case 34: {
                PaymentAuthorization = input.ReadString();
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
                                    if (expireDate_ == null)
                                    {
                                        ExpireDate = new Type.Date();
                                    }
                                    input.ReadMessage(ExpireDate);
                                    break;
                                }
                            case 18:
                                {
                                    LastFour = input.ReadString();
                                    break;
                                }
                            case 26:
                                {
                                    Brand = input.ReadString();
                                    break;
                                }
                            case 34:
                                {
                                    PaymentAuthorization = input.ReadString();
                                    break;
                                }
                        }
                    }
                }
#endif

            }

            /// <summary>
            /// Direct debit object
            /// </summary>
            public sealed partial class DirectDebit : IMessage<DirectDebit>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<DirectDebit> _parser = new(() => new DirectDebit());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<DirectDebit> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return PaymentMethod.Descriptor.NestedTypes[1]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public DirectDebit()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public DirectDebit(DirectDebit other) : this()
                {
                    switch (other.SchemeCase)
                    {
                        case SchemeOneofCase.Sepa:
                            Sepa = other.Sepa.Clone();
                            break;
                    }

                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public DirectDebit Clone() => new(this);
                /// <summary>Field number for the "sepa" field.</summary>
                public const int SepaFieldNumber = 1;

                /// <summary>
                /// SEPA details.
                /// </summary>
                public Types.SEPA Sepa
                {
                    get { return schemeCase_ == SchemeOneofCase.Sepa ? (Types.SEPA)scheme_ : null; }
                    set
                    {
                        scheme_ = value;
                        schemeCase_ = value == null ? SchemeOneofCase.None : SchemeOneofCase.Sepa;
                    }
                }

                private object scheme_;

                /// <summary>Enum of possible cases for the "scheme" oneof.</summary>
                public enum SchemeOneofCase
                {
                    None = 0,
                    Sepa = 1,
                }

                private SchemeOneofCase schemeCase_ = SchemeOneofCase.None;

                public SchemeOneofCase SchemeCase
                {
                    get { return schemeCase_; }
                }

                public void ClearScheme()
                {
                    schemeCase_ = SchemeOneofCase.None;
                    scheme_ = null;
                }

                public override bool Equals(object other) => Equals(other as DirectDebit);
                public bool Equals(DirectDebit other)
                {
                    if (other is null)
                    {
                        return false;
                    }
                    if (ReferenceEquals(other, this))
                    {
                        return true;
                    }
                    if (!Equals(Sepa, other.Sepa)) return false;
                    if (SchemeCase != other.SchemeCase) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (schemeCase_ == SchemeOneofCase.Sepa) hash ^= Sepa.GetHashCode();
                    hash ^= (int)schemeCase_;
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
          if (schemeCase_ == SchemeOneofCase.Sepa) {
            output.WriteRawTag(10);
            output.WriteMessage(Sepa);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
                }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                void IBufferMessage.InternalWriteTo(ref WriteContext output)
                {
                    if (schemeCase_ == SchemeOneofCase.Sepa)
                    {
                        output.WriteRawTag(10);
                        output.WriteMessage(Sepa);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (schemeCase_ == SchemeOneofCase.Sepa)
                    {
                        size += 1 + CodedOutputStream.ComputeMessageSize(Sepa);
                    }
                    if (_unknownFields != null)
                    {
                        size += _unknownFields.CalculateSize();
                    }
                    return size;
                }

                public void MergeFrom(DirectDebit other)
                {
                    if (other == null)
                    {
                        return;
                    }
                    switch (other.SchemeCase)
                    {
                        case SchemeOneofCase.Sepa:
                            if (Sepa == null)
                            {
                                Sepa = new Types.SEPA();
                            }
                            Sepa.MergeFrom(other.Sepa);
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
                Saltoapis.Nebula.Installation.V1.PaymentMethod.Types.DirectDebit.Types.SEPA subBuilder = new Saltoapis.Nebula.Installation.V1.PaymentMethod.Types.DirectDebit.Types.SEPA();
                if (schemeCase_ == SchemeOneofCase.Sepa) {
                  subBuilder.MergeFrom(Sepa);
                }
                input.ReadMessage(subBuilder);
                Sepa = subBuilder;
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
                                    Types.SEPA subBuilder = new();
                                    if (schemeCase_ == SchemeOneofCase.Sepa)
                                    {
                                        subBuilder.MergeFrom(Sepa);
                                    }
                                    input.ReadMessage(subBuilder);
                                    Sepa = subBuilder;
                                    break;
                                }
                        }
                    }
                }
#endif

                #region Nested types
                /// <summary>Container for nested types declared in the DirectDebit message type.</summary>
                public static partial class Types
                {
                    /// <summary>
                    /// The SEPA object
                    /// </summary>
                    public sealed partial class SEPA : IMessage<SEPA>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                        , IBufferMessage
#endif
                    {
                        private static readonly MessageParser<SEPA> _parser = new(() => new SEPA());
                        private UnknownFieldSet _unknownFields;

                        public static MessageParser<SEPA> Parser { get { return _parser; } }

                        public static MessageDescriptor Descriptor
                        {
                            get { return DirectDebit.Descriptor.NestedTypes[0]; }
                        }

                        MessageDescriptor IMessage.Descriptor
                        {
                            get { return Descriptor; }
                        }

                        public SEPA()
                        {
                            OnConstruction();
                        }

                        partial void OnConstruction();

                        public SEPA(SEPA other) : this()
                        {
                            lastFour_ = other.lastFour_;
                            accountHolder_ = other.accountHolder_;
                            iban_ = other.iban_;
                            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                        }

                        public SEPA Clone() => new(this);
                        /// <summary>Field number for the "last_four" field.</summary>
                        public const int LastFourFieldNumber = 1;
                        private string lastFour_ = "";

                        /// <summary>
                        /// The last four digits of the bank account number used for direct
                        /// debit.
                        /// </summary>
                        public string LastFour
                        {
                            get { return lastFour_; }
                            set
                            {
                                lastFour_ = ProtoPreconditions.CheckNotNull(value, "value");
                            }
                        }

                        /// <summary>Field number for the "account_holder" field.</summary>
                        public const int AccountHolderFieldNumber = 2;
                        private string accountHolder_ = "";

                        /// <summary>
                        /// The name of the person or business that owns the bank account.
                        /// </summary>
                        public string AccountHolder
                        {
                            get { return accountHolder_; }
                            set
                            {
                                accountHolder_ = ProtoPreconditions.CheckNotNull(value, "value");
                            }
                        }

                        /// <summary>Field number for the "iban" field.</summary>
                        public const int IbanFieldNumber = 3;
                        private string iban_ = "";

                        /// <summary>
                        /// The IBAN (International Bank Account Number) of the bank account.
                        /// </summary>
                        public string Iban
                        {
                            get { return iban_; }
                            set
                            {
                                iban_ = ProtoPreconditions.CheckNotNull(value, "value");
                            }
                        }

                        public override bool Equals(object other) => Equals(other as SEPA);
                        public bool Equals(SEPA other)
                        {
                            if (other is null)
                            {
                                return false;
                            }
                            if (ReferenceEquals(other, this))
                            {
                                return true;
                            }
                            if (LastFour != other.LastFour) return false;
                            if (AccountHolder != other.AccountHolder) return false;
                            if (Iban != other.Iban) return false;
                            return Equals(_unknownFields, other._unknownFields);
                        }

                        public override int GetHashCode()
                        {
                            int hash = 1;
                            if (LastFour.Length != 0) hash ^= LastFour.GetHashCode();
                            if (AccountHolder.Length != 0) hash ^= AccountHolder.GetHashCode();
                            if (Iban.Length != 0) hash ^= Iban.GetHashCode();
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
              if (LastFour.Length != 0) {
                output.WriteRawTag(10);
                output.WriteString(LastFour);
              }
              if (AccountHolder.Length != 0) {
                output.WriteRawTag(18);
                output.WriteString(AccountHolder);
              }
              if (Iban.Length != 0) {
                output.WriteRawTag(26);
                output.WriteString(Iban);
              }
              if (_unknownFields != null) {
                _unknownFields.WriteTo(output);
              }
#endif
                        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                        void IBufferMessage.InternalWriteTo(ref WriteContext output)
                        {
                            if (LastFour.Length != 0)
                            {
                                output.WriteRawTag(10);
                                output.WriteString(LastFour);
                            }
                            if (AccountHolder.Length != 0)
                            {
                                output.WriteRawTag(18);
                                output.WriteString(AccountHolder);
                            }
                            if (Iban.Length != 0)
                            {
                                output.WriteRawTag(26);
                                output.WriteString(Iban);
                            }
                            _unknownFields?.WriteTo(ref output);
                        }
#endif

                        public int CalculateSize()
                        {
                            int size = 0;
                            if (LastFour.Length != 0)
                            {
                                size += 1 + CodedOutputStream.ComputeStringSize(LastFour);
                            }
                            if (AccountHolder.Length != 0)
                            {
                                size += 1 + CodedOutputStream.ComputeStringSize(AccountHolder);
                            }
                            if (Iban.Length != 0)
                            {
                                size += 1 + CodedOutputStream.ComputeStringSize(Iban);
                            }
                            if (_unknownFields != null)
                            {
                                size += _unknownFields.CalculateSize();
                            }
                            return size;
                        }

                        public void MergeFrom(SEPA other)
                        {
                            if (other == null)
                            {
                                return;
                            }
                            if (other.LastFour.Length != 0)
                            {
                                LastFour = other.LastFour;
                            }
                            if (other.AccountHolder.Length != 0)
                            {
                                AccountHolder = other.AccountHolder;
                            }
                            if (other.Iban.Length != 0)
                            {
                                Iban = other.Iban;
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
                    LastFour = input.ReadString();
                    break;
                  }
                  case 18: {
                    AccountHolder = input.ReadString();
                    break;
                  }
                  case 26: {
                    Iban = input.ReadString();
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
                                            LastFour = input.ReadString();
                                            break;
                                        }
                                    case 18:
                                        {
                                            AccountHolder = input.ReadString();
                                            break;
                                        }
                                    case 26:
                                        {
                                            Iban = input.ReadString();
                                            break;
                                        }
                                }
                            }
                        }
#endif

                    }

                }
                #endregion

            }

        }
        #endregion

    }

    /// <summary>
    /// Payment authorization for the subscription.
    /// </summary>
    public sealed partial class PaymentAuthorization : IMessage<PaymentAuthorization>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<PaymentAuthorization> _parser = new(() => new PaymentAuthorization());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<PaymentAuthorization> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public PaymentAuthorization()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public PaymentAuthorization(PaymentAuthorization other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public PaymentAuthorization Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the payment authorization. It must have the format of
        /// `installations/*/subscription/payment-authorizations/*`. For example:
        /// `installations/salto-hq/subscription/payment-authorizations/01HCD0YB`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as PaymentAuthorization);
        public bool Equals(PaymentAuthorization other)
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

        public void MergeFrom(PaymentAuthorization other)
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
    /// The coupon object
    /// </summary>
    public sealed partial class Coupon : IMessage<Coupon>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Coupon> _parser = new(() => new Coupon());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Coupon> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Coupon()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Coupon(Coupon other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Coupon Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the coupon. It must have the format of
        /// `installations/*/subscription/coupons/*`. For example:
        /// `installations/salto-hq/subscription/coupons/01HCD0YB`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as Coupon);
        public bool Equals(Coupon other)
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

        public void MergeFrom(Coupon other)
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
    /// The invoice object used for billing
    /// </summary>
    public sealed partial class Invoice : IMessage<Invoice>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Invoice> _parser = new(() => new Invoice());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Invoice> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Invoice()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Invoice(Invoice other) : this()
        {
            name_ = other.name_;
            startTime_ = other.startTime_?.Clone();
            endTime_ = other.endTime_?.Clone();
            lineItems_ = other.lineItems_.Clone();
            total_ = other.total_;
            state_ = other.state_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Invoice Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the invoice. It must have the format of
        /// `installations/*/subscription/invoices/*`. For example:
        /// `installations/salto-hq/subscription/invoices/2023-000015`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "start_time" field.</summary>
        public const int StartTimeFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.Timestamp startTime_;

        /// <summary>
        /// Start time of the invoice. It must be past time.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp StartTime
        {
            get { return startTime_; }
            set
            {
                startTime_ = value;
            }
        }

        /// <summary>Field number for the "end_time" field.</summary>
        public const int EndTimeFieldNumber = 3;
        private Google.Protobuf.WellKnownTypes.Timestamp endTime_;

        /// <summary>
        /// End time of the invoice.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp EndTime
        {
            get { return endTime_; }
            set
            {
                endTime_ = value;
            }
        }

        /// <summary>Field number for the "line_items" field.</summary>
        public const int LineItemsFieldNumber = 4;
        private static readonly FieldCodec<Types.LineItem> _repeated_lineItems_codec
            = FieldCodec.ForMessage(34, Types.LineItem.Parser);
        private readonly RepeatedField<Types.LineItem> lineItems_ = [];

        /// <summary>
        /// The line items included in the invoice. Must include at least one
        /// item and no more than 50.
        /// </summary>
        public RepeatedField<Types.LineItem> LineItems
        {
            get { return lineItems_; }
        }

        /// <summary>Field number for the "total" field.</summary>
        public const int TotalFieldNumber = 5;
        private long total_;

        /// <summary>
        /// The total cost of the invoice.
        /// The value is in the minor unit of the currency. (for example: cents).
        /// </summary>
        public long Total
        {
            get { return total_; }
            set
            {
                total_ = value;
            }
        }

        /// <summary>Field number for the "state" field.</summary>
        public const int StateFieldNumber = 6;
        private Types.State state_ = Types.State.Unspecified;

        /// <summary>
        /// Indicates whether this invoice has been paid or not.
        /// </summary>
        public Types.State State
        {
            get { return state_; }
            set
            {
                state_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as Invoice);
        public bool Equals(Invoice other)
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
            if (!Equals(StartTime, other.StartTime)) return false;
            if (!Equals(EndTime, other.EndTime)) return false;
            if (!lineItems_.Equals(other.lineItems_)) return false;
            if (Total != other.Total) return false;
            if (State != other.State) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (startTime_ != null) hash ^= StartTime.GetHashCode();
            if (endTime_ != null) hash ^= EndTime.GetHashCode();
            hash ^= lineItems_.GetHashCode();
            if (Total != 0L) hash ^= Total.GetHashCode();
            if (State != Types.State.Unspecified) hash ^= State.GetHashCode();
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
      if (startTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(StartTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(EndTime);
      }
      lineItems_.WriteTo(output, _repeated_lineItems_codec);
      if (Total != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(Total);
      }
      if (State != Saltoapis.Nebula.Installation.V1.Invoice.Types.State.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) State);
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
            if (startTime_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(StartTime);
            }
            if (endTime_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(EndTime);
            }
            lineItems_.WriteTo(ref output, _repeated_lineItems_codec);
            if (Total != 0L)
            {
                output.WriteRawTag(40);
                output.WriteInt64(Total);
            }
            if (State != Types.State.Unspecified)
            {
                output.WriteRawTag(48);
                output.WriteEnum((int)State);
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
            if (startTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(StartTime);
            }
            if (endTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(EndTime);
            }
            size += lineItems_.CalculateSize(_repeated_lineItems_codec);
            if (Total != 0L)
            {
                size += 1 + CodedOutputStream.ComputeInt64Size(Total);
            }
            if (State != Types.State.Unspecified)
            {
                size += 1 + CodedOutputStream.ComputeEnumSize((int)State);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(Invoice other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.startTime_ != null)
            {
                if (startTime_ == null)
                {
                    StartTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                StartTime.MergeFrom(other.StartTime);
            }
            if (other.endTime_ != null)
            {
                if (endTime_ == null)
                {
                    EndTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                EndTime.MergeFrom(other.EndTime);
            }
            lineItems_.Add(other.lineItems_);
            if (other.Total != 0L)
            {
                Total = other.Total;
            }
            if (other.State != Types.State.Unspecified)
            {
                State = other.State;
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
            if (startTime_ == null) {
              StartTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 26: {
            if (endTime_ == null) {
              EndTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
          case 34: {
            lineItems_.AddEntriesFrom(input, _repeated_lineItems_codec);
            break;
          }
          case 40: {
            Total = input.ReadInt64();
            break;
          }
          case 48: {
            State = (Saltoapis.Nebula.Installation.V1.Invoice.Types.State) input.ReadEnum();
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
                            if (startTime_ == null)
                            {
                                StartTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(StartTime);
                            break;
                        }
                    case 26:
                        {
                            if (endTime_ == null)
                            {
                                EndTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(EndTime);
                            break;
                        }
                    case 34:
                        {
                            lineItems_.AddEntriesFrom(ref input, _repeated_lineItems_codec);
                            break;
                        }
                    case 40:
                        {
                            Total = input.ReadInt64();
                            break;
                        }
                    case 48:
                        {
                            State = (Types.State)input.ReadEnum();
                            break;
                        }
                }
            }
        }
#endif

        #region Nested types
        /// <summary>Container for nested types declared in the Invoice message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// State for a invoice.
            /// </summary>
            public enum State
            {
                /// <summary>
                /// Sentinel value used to indicate that the state is unknown, omitted,
                /// or is not applicable.
                /// </summary>
                [OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
                /// <summary>
                /// The invoice is unpaid.
                /// </summary>
                [OriginalName("UNPAID")] Unpaid = 1,
                /// <summary>
                /// The invoice has been paid.
                /// </summary>
                [OriginalName("PAID")] Paid = 2,
            }

            /// <summary>
            /// The line item object.
            /// </summary>
            public sealed partial class LineItem : IMessage<LineItem>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<LineItem> _parser = new(() => new LineItem());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<LineItem> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return Invoice.Descriptor.NestedTypes[0]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public LineItem()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public LineItem(LineItem other) : this()
                {
                    id_ = other.id_;
                    quantity_ = other.quantity_;
                    price_ = other.price_;
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public LineItem Clone() => new(this);
                /// <summary>Field number for the "id" field.</summary>
                public const int IdFieldNumber = 1;
                private string id_ = "";

                /// <summary>
                /// The line item ID belonging to the subscription. For example:
                /// `elevators`.
                /// </summary>
                public string Id
                {
                    get { return id_; }
                    set
                    {
                        id_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                /// <summary>Field number for the "quantity" field.</summary>
                public const int QuantityFieldNumber = 2;
                private int quantity_;

                /// <summary>
                /// The quantity of the line item used.
                /// </summary>
                public int Quantity
                {
                    get { return quantity_; }
                    set
                    {
                        quantity_ = value;
                    }
                }

                /// <summary>Field number for the "price" field.</summary>
                public const int PriceFieldNumber = 3;
                private long price_;

                /// <summary>
                /// The cost of the item price when the pricing model is flat fee.
                /// When the pricing model is per unit, it is the price per unit quantity of the item.
                /// The value is in the minor unit of the currency. (for example: cents).
                /// </summary>
                public long Price
                {
                    get { return price_; }
                    set
                    {
                        price_ = value;
                    }
                }

                public override bool Equals(object other) => Equals(other as LineItem);
                public bool Equals(LineItem other)
                {
                    if (other is null)
                    {
                        return false;
                    }
                    if (ReferenceEquals(other, this))
                    {
                        return true;
                    }
                    if (Id != other.Id) return false;
                    if (Quantity != other.Quantity) return false;
                    if (Price != other.Price) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (Id.Length != 0) hash ^= Id.GetHashCode();
                    if (Quantity != 0) hash ^= Quantity.GetHashCode();
                    if (Price != 0L) hash ^= Price.GetHashCode();
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
          if (Id.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Id);
          }
          if (Quantity != 0) {
            output.WriteRawTag(16);
            output.WriteInt32(Quantity);
          }
          if (Price != 0L) {
            output.WriteRawTag(24);
            output.WriteInt64(Price);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
                }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                void IBufferMessage.InternalWriteTo(ref WriteContext output)
                {
                    if (Id.Length != 0)
                    {
                        output.WriteRawTag(10);
                        output.WriteString(Id);
                    }
                    if (Quantity != 0)
                    {
                        output.WriteRawTag(16);
                        output.WriteInt32(Quantity);
                    }
                    if (Price != 0L)
                    {
                        output.WriteRawTag(24);
                        output.WriteInt64(Price);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (Id.Length != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(Id);
                    }
                    if (Quantity != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeInt32Size(Quantity);
                    }
                    if (Price != 0L)
                    {
                        size += 1 + CodedOutputStream.ComputeInt64Size(Price);
                    }
                    if (_unknownFields != null)
                    {
                        size += _unknownFields.CalculateSize();
                    }
                    return size;
                }

                public void MergeFrom(LineItem other)
                {
                    if (other == null)
                    {
                        return;
                    }
                    if (other.Id.Length != 0)
                    {
                        Id = other.Id;
                    }
                    if (other.Quantity != 0)
                    {
                        Quantity = other.Quantity;
                    }
                    if (other.Price != 0L)
                    {
                        Price = other.Price;
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
                Id = input.ReadString();
                break;
              }
              case 16: {
                Quantity = input.ReadInt32();
                break;
              }
              case 24: {
                Price = input.ReadInt64();
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
                                    Id = input.ReadString();
                                    break;
                                }
                            case 16:
                                {
                                    Quantity = input.ReadInt32();
                                    break;
                                }
                            case 24:
                                {
                                    Price = input.ReadInt64();
                                    break;
                                }
                        }
                    }
                }
#endif

            }

        }
        #endregion

    }

    /// <summary>
    /// The IAM policy object
    /// </summary>
    public sealed partial class Policy : IMessage<Policy>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Policy> _parser = new(() => new Policy());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Policy> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Policy()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Policy(Policy other) : this()
        {
            name_ = other.name_;
            member_ = other.member_;
            roles_ = other.roles_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Policy Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the policy. It must have the format of
        /// `installations/*/iam-policies`. For example:
        /// `installations/surelock-homes-hq/iam-policies/standard`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "member" field.</summary>
        public const int MemberFieldNumber = 2;
        private string member_ = "";

        /// <summary>
        /// Specifies the identity requesting access to this resource.
        /// </summary>
        public string Member
        {
            get { return member_; }
            set
            {
                member_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "roles" field.</summary>
        public const int RolesFieldNumber = 3;
        private static readonly FieldCodec<string> _repeated_roles_codec
            = FieldCodec.ForString(26);
        private readonly RepeatedField<string> roles_ = [];

        /// <summary>
        /// The names of the roles this policy grants.
        /// </summary>
        public RepeatedField<string> Roles
        {
            get { return roles_; }
        }

        public override bool Equals(object other) => Equals(other as Policy);
        public bool Equals(Policy other)
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
            if (Member != other.Member) return false;
            if (!roles_.Equals(other.roles_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (Member.Length != 0) hash ^= Member.GetHashCode();
            hash ^= roles_.GetHashCode();
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
      if (Member.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Member);
      }
      roles_.WriteTo(output, _repeated_roles_codec);
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
            if (Member.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Member);
            }
            roles_.WriteTo(ref output, _repeated_roles_codec);
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
            if (Member.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Member);
            }
            size += roles_.CalculateSize(_repeated_roles_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(Policy other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.Member.Length != 0)
            {
                Member = other.Member;
            }
            roles_.Add(other.roles_);
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
            Member = input.ReadString();
            break;
          }
          case 26: {
            roles_.AddEntriesFrom(input, _repeated_roles_codec);
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
                            Member = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            roles_.AddEntriesFrom(ref input, _repeated_roles_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`CreateInstallation`][salto.nebula.installation.v1.InstallationService.CreateInstallation]
    /// </summary>
    public sealed partial class CreateInstallationRequest : IMessage<CreateInstallationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateInstallationRequest> _parser = new(() => new CreateInstallationRequest());
        private UnknownFieldSet _unknownFields;
        private int _hasBits0;

        public static MessageParser<CreateInstallationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateInstallationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateInstallationRequest(CreateInstallationRequest other) : this()
        {
            _hasBits0 = other._hasBits0;
            installationId_ = other.installationId_;
            installation_ = other.installation_?.Clone();
            validateOnly_ = other.validateOnly_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateInstallationRequest Clone() => new(this);
        /// <summary>Field number for the "installation_id" field.</summary>
        public const int InstallationIdFieldNumber = 1;
        private readonly static string InstallationIdDefaultValue = "";

        private string installationId_;

        /// <summary>
        /// The installation ID to use for this installation. In case it's
        /// empty the server will autogenerate a unique identifier.
        /// </summary>
        public string InstallationId
        {
            get { return installationId_ ?? InstallationIdDefaultValue; }
            set
            {
                installationId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "installation_id" field is set</summary>
        public bool HasInstallationId
        {
            get { return installationId_ != null; }
        }

        /// <summary>Clears the value of the "installation_id" field</summary>
        public void ClearInstallationId()
        {
            installationId_ = null;
        }

        /// <summary>Field number for the "installation" field.</summary>
        public const int InstallationFieldNumber = 2;
        private Installation installation_;

        /// <summary>
        /// The installation resource to be created. Client must not set the
        /// `Installation.name` field.
        /// </summary>
        public Installation Installation
        {
            get { return installation_; }
            set
            {
                installation_ = value;
            }
        }

        /// <summary>Field number for the "validate_only" field.</summary>
        public const int ValidateOnlyFieldNumber = 5;
        private readonly static bool ValidateOnlyDefaultValue = false;

        private bool validateOnly_;

        /// <summary>
        /// If set, validate the request but do not actually create the installation.
        /// </summary>
        public bool ValidateOnly
        {
            get { if ((_hasBits0 & 1) != 0) { return validateOnly_; } else { return ValidateOnlyDefaultValue; } }
            set
            {
                _hasBits0 |= 1;
                validateOnly_ = value;
            }
        }

        /// <summary>Gets whether the "validate_only" field is set</summary>
        public bool HasValidateOnly
        {
            get { return (_hasBits0 & 1) != 0; }
        }

        /// <summary>Clears the value of the "validate_only" field</summary>
        public void ClearValidateOnly()
        {
            _hasBits0 &= ~1;
        }

        public override bool Equals(object other) => Equals(other as CreateInstallationRequest);
        public bool Equals(CreateInstallationRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (InstallationId != other.InstallationId) return false;
            if (!Equals(Installation, other.Installation)) return false;
            if (ValidateOnly != other.ValidateOnly) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (HasInstallationId) hash ^= InstallationId.GetHashCode();
            if (installation_ != null) hash ^= Installation.GetHashCode();
            if (HasValidateOnly) hash ^= ValidateOnly.GetHashCode();
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
      if (HasInstallationId) {
        output.WriteRawTag(10);
        output.WriteString(InstallationId);
      }
      if (installation_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Installation);
      }
      if (HasValidateOnly) {
        output.WriteRawTag(40);
        output.WriteBool(ValidateOnly);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (HasInstallationId)
            {
                output.WriteRawTag(10);
                output.WriteString(InstallationId);
            }
            if (installation_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Installation);
            }
            if (HasValidateOnly)
            {
                output.WriteRawTag(40);
                output.WriteBool(ValidateOnly);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (HasInstallationId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(InstallationId);
            }
            if (installation_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Installation);
            }
            if (HasValidateOnly)
            {
                size += 1 + 1;
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateInstallationRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.HasInstallationId)
            {
                InstallationId = other.InstallationId;
            }
            if (other.installation_ != null)
            {
                if (installation_ == null)
                {
                    Installation = new Installation();
                }
                Installation.MergeFrom(other.Installation);
            }
            if (other.HasValidateOnly)
            {
                ValidateOnly = other.ValidateOnly;
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
            InstallationId = input.ReadString();
            break;
          }
          case 18: {
            if (installation_ == null) {
              Installation = new Saltoapis.Nebula.Installation.V1.Installation();
            }
            input.ReadMessage(Installation);
            break;
          }
          case 40: {
            ValidateOnly = input.ReadBool();
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
                            InstallationId = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            if (installation_ == null)
                            {
                                Installation = new Installation();
                            }
                            input.ReadMessage(Installation);
                            break;
                        }
                    case 40:
                        {
                            ValidateOnly = input.ReadBool();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetInstallation`][salto.nebula.installation.v1.InstallationService.GetInstallation]
    /// </summary>
    public sealed partial class GetInstallationRequest : IMessage<GetInstallationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetInstallationRequest> _parser = new(() => new GetInstallationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetInstallationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[9]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetInstallationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetInstallationRequest(GetInstallationRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetInstallationRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested installation resource. For example:
        /// `installations/surelock-homes-hq`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetInstallationRequest);
        public bool Equals(GetInstallationRequest other)
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

        public void MergeFrom(GetInstallationRequest other)
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
    /// The request message for [`ListInstallations`][salto.nebula.installation.v1.InstallationService.ListInstallations]
    /// </summary>
    public sealed partial class ListInstallationsRequest : IMessage<ListInstallationsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListInstallationsRequest> _parser = new(() => new ListInstallationsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListInstallationsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListInstallationsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListInstallationsRequest(ListInstallationsRequest other) : this()
        {
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            showDeleted_ = other.showDeleted_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListInstallationsRequest Clone() => new(this);
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
        /// A filter that chooses which installations to return.
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
        public const int OrderByFieldNumber = 4;
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

        /// <summary>Field number for the "show_deleted" field.</summary>
        public const int ShowDeletedFieldNumber = 5;
        private bool showDeleted_;

        /// <summary>
        /// Show deleted installations.
        /// </summary>
        public bool ShowDeleted
        {
            get { return showDeleted_; }
            set
            {
                showDeleted_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as ListInstallationsRequest);
        public bool Equals(ListInstallationsRequest other)
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
            if (OrderBy != other.OrderBy) return false;
            if (ShowDeleted != other.ShowDeleted) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (PageSize != 0) hash ^= PageSize.GetHashCode();
            if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
            if (Filter.Length != 0) hash ^= Filter.GetHashCode();
            if (OrderBy.Length != 0) hash ^= OrderBy.GetHashCode();
            if (ShowDeleted != false) hash ^= ShowDeleted.GetHashCode();
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
      if (OrderBy.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(OrderBy);
      }
      if (ShowDeleted != false) {
        output.WriteRawTag(40);
        output.WriteBool(ShowDeleted);
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
            if (OrderBy.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(OrderBy);
            }
            if (ShowDeleted != false)
            {
                output.WriteRawTag(40);
                output.WriteBool(ShowDeleted);
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
            if (OrderBy.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(OrderBy);
            }
            if (ShowDeleted != false)
            {
                size += 1 + 1;
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ListInstallationsRequest other)
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
            if (other.OrderBy.Length != 0)
            {
                OrderBy = other.OrderBy;
            }
            if (other.ShowDeleted != false)
            {
                ShowDeleted = other.ShowDeleted;
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
          case 34: {
            OrderBy = input.ReadString();
            break;
          }
          case 40: {
            ShowDeleted = input.ReadBool();
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
                    case 34:
                        {
                            OrderBy = input.ReadString();
                            break;
                        }
                    case 40:
                        {
                            ShowDeleted = input.ReadBool();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`ListInstallations`][salto.nebula.installation.v1.InstallationService.ListInstallations]
    /// </summary>
    public sealed partial class ListInstallationsResponse : IMessage<ListInstallationsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListInstallationsResponse> _parser = new(() => new ListInstallationsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListInstallationsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[11]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListInstallationsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListInstallationsResponse(ListInstallationsResponse other) : this()
        {
            installations_ = other.installations_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListInstallationsResponse Clone() => new(this);
        /// <summary>Field number for the "installations" field.</summary>
        public const int InstallationsFieldNumber = 1;
        private static readonly FieldCodec<Installation> _repeated_installations_codec
            = FieldCodec.ForMessage(10, Installation.Parser);
        private readonly RepeatedField<Installation> installations_ = [];

        /// <summary>
        /// The field name should match the noun `installations` in the method name.
        /// There will be a maximum number of items returned based on the `page_size`
        /// field in the request.
        /// </summary>
        public RepeatedField<Installation> Installations
        {
            get { return installations_; }
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

        public override bool Equals(object other) => Equals(other as ListInstallationsResponse);
        public bool Equals(ListInstallationsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!installations_.Equals(other.installations_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= installations_.GetHashCode();
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
      installations_.WriteTo(output, _repeated_installations_codec);
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
            installations_.WriteTo(ref output, _repeated_installations_codec);
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
            size += installations_.CalculateSize(_repeated_installations_codec);
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

        public void MergeFrom(ListInstallationsResponse other)
        {
            if (other == null)
            {
                return;
            }
            installations_.Add(other.installations_);
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
            installations_.AddEntriesFrom(input, _repeated_installations_codec);
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
                            installations_.AddEntriesFrom(ref input, _repeated_installations_codec);
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
    /// The request message for [`UpdateInstallation`][salto.nebula.installation.v1.InstallationService.UpdateInstallation]
    /// </summary>
    public sealed partial class UpdateInstallationRequest : IMessage<UpdateInstallationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateInstallationRequest> _parser = new(() => new UpdateInstallationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateInstallationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[12]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateInstallationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateInstallationRequest(UpdateInstallationRequest other) : this()
        {
            installation_ = other.installation_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateInstallationRequest Clone() => new(this);
        /// <summary>Field number for the "installation" field.</summary>
        public const int InstallationFieldNumber = 1;
        private Installation installation_;

        /// <summary>
        /// The installation resource which replaces the resource on the server.
        /// </summary>
        public Installation Installation
        {
            get { return installation_; }
            set
            {
                installation_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateInstallationRequest);
        public bool Equals(UpdateInstallationRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Installation, other.Installation)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (installation_ != null) hash ^= Installation.GetHashCode();
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
      if (installation_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Installation);
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
            if (installation_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Installation);
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
            if (installation_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Installation);
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

        public void MergeFrom(UpdateInstallationRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.installation_ != null)
            {
                if (installation_ == null)
                {
                    Installation = new Installation();
                }
                Installation.MergeFrom(other.Installation);
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
            if (installation_ == null) {
              Installation = new Saltoapis.Nebula.Installation.V1.Installation();
            }
            input.ReadMessage(Installation);
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
                            if (installation_ == null)
                            {
                                Installation = new Installation();
                            }
                            input.ReadMessage(Installation);
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
    /// The request message for [`DeleteInstallation`][salto.nebula.installation.v1.InstallationService.DeleteInstallation]
    /// </summary>
    public sealed partial class DeleteInstallationRequest : IMessage<DeleteInstallationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteInstallationRequest> _parser = new(() => new DeleteInstallationRequest());
        private UnknownFieldSet _unknownFields;
        private int _hasBits0;

        public static MessageParser<DeleteInstallationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteInstallationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteInstallationRequest(DeleteInstallationRequest other) : this()
        {
            _hasBits0 = other._hasBits0;
            name_ = other.name_;
            validateOnly_ = other.validateOnly_;
            delayHours_ = other.delayHours_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteInstallationRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the installation to be soft deleted. For example:
        /// `installations/surelock-homes-hq`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "validate_only" field.</summary>
        public const int ValidateOnlyFieldNumber = 2;
        private readonly static bool ValidateOnlyDefaultValue = false;

        private bool validateOnly_;

        /// <summary>
        /// If set, validate the request but do not actually delete the installation.
        /// </summary>
        public bool ValidateOnly
        {
            get { if ((_hasBits0 & 1) != 0) { return validateOnly_; } else { return ValidateOnlyDefaultValue; } }
            set
            {
                _hasBits0 |= 1;
                validateOnly_ = value;
            }
        }

        /// <summary>Gets whether the "validate_only" field is set</summary>
        public bool HasValidateOnly
        {
            get { return (_hasBits0 & 1) != 0; }
        }

        /// <summary>Clears the value of the "validate_only" field</summary>
        public void ClearValidateOnly()
        {
            _hasBits0 &= ~1;
        }

        /// <summary>Field number for the "delay_hours" field.</summary>
        public const int DelayHoursFieldNumber = 3;
        private readonly static int DelayHoursDefaultValue = 0;

        private int delayHours_;

        /// <summary>
        /// The number of hours to wait before permanently deleting the installation.
        /// If unset, the default is 720 (30 days).
        /// </summary>
        public int DelayHours
        {
            get { if ((_hasBits0 & 2) != 0) { return delayHours_; } else { return DelayHoursDefaultValue; } }
            set
            {
                _hasBits0 |= 2;
                delayHours_ = value;
            }
        }

        /// <summary>Gets whether the "delay_hours" field is set</summary>
        public bool HasDelayHours
        {
            get { return (_hasBits0 & 2) != 0; }
        }

        /// <summary>Clears the value of the "delay_hours" field</summary>
        public void ClearDelayHours()
        {
            _hasBits0 &= ~2;
        }

        public override bool Equals(object other) => Equals(other as DeleteInstallationRequest);
        public bool Equals(DeleteInstallationRequest other)
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
            if (ValidateOnly != other.ValidateOnly) return false;
            if (DelayHours != other.DelayHours) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (HasValidateOnly) hash ^= ValidateOnly.GetHashCode();
            if (HasDelayHours) hash ^= DelayHours.GetHashCode();
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
      if (HasValidateOnly) {
        output.WriteRawTag(16);
        output.WriteBool(ValidateOnly);
      }
      if (HasDelayHours) {
        output.WriteRawTag(24);
        output.WriteInt32(DelayHours);
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
            if (HasValidateOnly)
            {
                output.WriteRawTag(16);
                output.WriteBool(ValidateOnly);
            }
            if (HasDelayHours)
            {
                output.WriteRawTag(24);
                output.WriteInt32(DelayHours);
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
            if (HasValidateOnly)
            {
                size += 1 + 1;
            }
            if (HasDelayHours)
            {
                size += 1 + CodedOutputStream.ComputeInt32Size(DelayHours);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(DeleteInstallationRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.HasValidateOnly)
            {
                ValidateOnly = other.ValidateOnly;
            }
            if (other.HasDelayHours)
            {
                DelayHours = other.DelayHours;
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
            ValidateOnly = input.ReadBool();
            break;
          }
          case 24: {
            DelayHours = input.ReadInt32();
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
                            ValidateOnly = input.ReadBool();
                            break;
                        }
                    case 24:
                        {
                            DelayHours = input.ReadInt32();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`UndeleteInstallation`][salto.nebula.installation.v1.InstallationService.UndeleteInstallation]
    /// </summary>
    public sealed partial class UndeleteInstallationRequest : IMessage<UndeleteInstallationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UndeleteInstallationRequest> _parser = new(() => new UndeleteInstallationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UndeleteInstallationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[14]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UndeleteInstallationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UndeleteInstallationRequest(UndeleteInstallationRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UndeleteInstallationRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the installation to be undeleted. For example:
        /// `installations/surelock-homes-hq`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as UndeleteInstallationRequest);
        public bool Equals(UndeleteInstallationRequest other)
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

        public void MergeFrom(UndeleteInstallationRequest other)
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
    /// The request message for [`CreatePolicy`][salto.nebula.installation.v1.InstallationService.CreatePolicy]
    /// </summary>
    public sealed partial class CreatePolicyRequest : IMessage<CreatePolicyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreatePolicyRequest> _parser = new(() => new CreatePolicyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreatePolicyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[15]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreatePolicyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreatePolicyRequest(CreatePolicyRequest other) : this()
        {
            parent_ = other.parent_;
            policyId_ = other.policyId_;
            policy_ = other.policy_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreatePolicyRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where to create the IAM policy. For
        /// example: `installations/salto-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "policy_id" field.</summary>
        public const int PolicyIdFieldNumber = 2;
        private string policyId_ = "";

        /// <summary>
        /// The policy ID to use for the IAM policy. In case it's empty the server
        /// will autogenerate a unique identifier.
        /// </summary>
        public string PolicyId
        {
            get { return policyId_; }
            set
            {
                policyId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "policy" field.</summary>
        public const int PolicyFieldNumber = 3;
        private Policy policy_;

        /// <summary>
        /// The policy resource to be created. Client must not set the `Policy.name`
        /// field.
        /// </summary>
        public Policy Policy
        {
            get { return policy_; }
            set
            {
                policy_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreatePolicyRequest);
        public bool Equals(CreatePolicyRequest other)
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
            if (PolicyId != other.PolicyId) return false;
            if (!Equals(Policy, other.Policy)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (PolicyId.Length != 0) hash ^= PolicyId.GetHashCode();
            if (policy_ != null) hash ^= Policy.GetHashCode();
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
      if (PolicyId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PolicyId);
      }
      if (policy_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Policy);
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
            if (PolicyId.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(PolicyId);
            }
            if (policy_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Policy);
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
            if (PolicyId.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(PolicyId);
            }
            if (policy_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Policy);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreatePolicyRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.PolicyId.Length != 0)
            {
                PolicyId = other.PolicyId;
            }
            if (other.policy_ != null)
            {
                if (policy_ == null)
                {
                    Policy = new Policy();
                }
                Policy.MergeFrom(other.Policy);
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
            PolicyId = input.ReadString();
            break;
          }
          case 26: {
            if (policy_ == null) {
              Policy = new Saltoapis.Nebula.Installation.V1.Policy();
            }
            input.ReadMessage(Policy);
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
                            PolicyId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (policy_ == null)
                            {
                                Policy = new Policy();
                            }
                            input.ReadMessage(Policy);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetPolicy`][salto.nebula.installation.v1.InstallationService.GetPolicy]
    /// </summary>
    public sealed partial class GetPolicyRequest : IMessage<GetPolicyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetPolicyRequest> _parser = new(() => new GetPolicyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetPolicyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[16]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetPolicyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetPolicyRequest(GetPolicyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetPolicyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested policy resource. For example:
        /// `installations/surelock-homes-hq/iam-policies/standard`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetPolicyRequest);
        public bool Equals(GetPolicyRequest other)
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

        public void MergeFrom(GetPolicyRequest other)
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
    /// The request message for [`ListPolicies`][salto.nebula.installation.v1.InstallationService.ListPolicies]
    /// </summary>
    public sealed partial class ListPoliciesRequest : IMessage<ListPoliciesRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListPoliciesRequest> _parser = new(() => new ListPoliciesRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListPoliciesRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[17]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListPoliciesRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListPoliciesRequest(ListPoliciesRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListPoliciesRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name. For example: `installations/surelock-homes-hq`.
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
        /// A filter that chooses which installations to return.
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

        public override bool Equals(object other) => Equals(other as ListPoliciesRequest);
        public bool Equals(ListPoliciesRequest other)
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

        public void MergeFrom(ListPoliciesRequest other)
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
    /// The response message for [`ListPolicies`][salto.nebula.installation.v1.InstallationService.ListPolicies]
    /// </summary>
    public sealed partial class ListPoliciesResponse : IMessage<ListPoliciesResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListPoliciesResponse> _parser = new(() => new ListPoliciesResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListPoliciesResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[18]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListPoliciesResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListPoliciesResponse(ListPoliciesResponse other) : this()
        {
            policies_ = other.policies_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListPoliciesResponse Clone() => new(this);
        /// <summary>Field number for the "policies" field.</summary>
        public const int PoliciesFieldNumber = 1;
        private static readonly FieldCodec<Policy> _repeated_policies_codec
            = FieldCodec.ForMessage(10, Policy.Parser);
        private readonly RepeatedField<Policy> policies_ = [];

        /// <summary>
        /// The field name should match the noun `policies` in the method name.
        /// There will be a maximum number of items returned based on the `page_size`
        /// field in the request.
        /// </summary>
        public RepeatedField<Policy> Policies
        {
            get { return policies_; }
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

        public override bool Equals(object other) => Equals(other as ListPoliciesResponse);
        public bool Equals(ListPoliciesResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!policies_.Equals(other.policies_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= policies_.GetHashCode();
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
      policies_.WriteTo(output, _repeated_policies_codec);
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
            policies_.WriteTo(ref output, _repeated_policies_codec);
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
            size += policies_.CalculateSize(_repeated_policies_codec);
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

        public void MergeFrom(ListPoliciesResponse other)
        {
            if (other == null)
            {
                return;
            }
            policies_.Add(other.policies_);
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
            policies_.AddEntriesFrom(input, _repeated_policies_codec);
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
                            policies_.AddEntriesFrom(ref input, _repeated_policies_codec);
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
    /// The request message for [`UpdatePolicy`][salto.nebula.installation.v1.InstallationService.UpdatePolicy]
    /// </summary>
    public sealed partial class UpdatePolicyRequest : IMessage<UpdatePolicyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdatePolicyRequest> _parser = new(() => new UpdatePolicyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdatePolicyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[19]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdatePolicyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdatePolicyRequest(UpdatePolicyRequest other) : this()
        {
            policy_ = other.policy_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdatePolicyRequest Clone() => new(this);
        /// <summary>Field number for the "policy" field.</summary>
        public const int PolicyFieldNumber = 1;
        private Policy policy_;

        /// <summary>
        /// The policy resource which replaces the resource on the server.
        /// </summary>
        public Policy Policy
        {
            get { return policy_; }
            set
            {
                policy_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdatePolicyRequest);
        public bool Equals(UpdatePolicyRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Policy, other.Policy)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (policy_ != null) hash ^= Policy.GetHashCode();
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
      if (policy_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Policy);
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
            if (policy_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Policy);
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
            if (policy_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Policy);
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

        public void MergeFrom(UpdatePolicyRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.policy_ != null)
            {
                if (policy_ == null)
                {
                    Policy = new Policy();
                }
                Policy.MergeFrom(other.Policy);
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
            if (policy_ == null) {
              Policy = new Saltoapis.Nebula.Installation.V1.Policy();
            }
            input.ReadMessage(Policy);
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
                            if (policy_ == null)
                            {
                                Policy = new Policy();
                            }
                            input.ReadMessage(Policy);
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
    /// The request message for [`DeletePolicy`][salto.nebula.installation.v1.InstallationService.DeletePolicy]
    /// </summary>
    public sealed partial class DeletePolicyRequest : IMessage<DeletePolicyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeletePolicyRequest> _parser = new(() => new DeletePolicyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeletePolicyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[20]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeletePolicyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeletePolicyRequest(DeletePolicyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeletePolicyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the policy to be deleted. For example:
        /// `installations/surelock-homes-hq/iam-policies/standard`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeletePolicyRequest);
        public bool Equals(DeletePolicyRequest other)
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

        public void MergeFrom(DeletePolicyRequest other)
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
    /// The request message for [`TestPermissions`][salto.nebula.installation.v1.InstallationService.TestPermissions]
    /// </summary>
    public sealed partial class TestPermissionsRequest : IMessage<TestPermissionsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<TestPermissionsRequest> _parser = new(() => new TestPermissionsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<TestPermissionsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[21]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public TestPermissionsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public TestPermissionsRequest(TestPermissionsRequest other) : this()
        {
            installation_ = other.installation_;
            permissions_ = other.permissions_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public TestPermissionsRequest Clone() => new(this);
        /// <summary>Field number for the "installation" field.</summary>
        public const int InstallationFieldNumber = 1;
        private string installation_ = "";

        /// <summary>
        /// The resource name for which the policy detail is being requested. For
        /// example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Installation
        {
            get { return installation_; }
            set
            {
                installation_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "permissions" field.</summary>
        public const int PermissionsFieldNumber = 2;
        private static readonly FieldCodec<string> _repeated_permissions_codec
            = FieldCodec.ForString(18);
        private readonly RepeatedField<string> permissions_ = [];

        /// <summary>
        /// The set of permissions to check for the `resource_name`. Permissions with
        /// wildcards (such as '*' or 'nebula.access-point.*') are not allowed.
        /// </summary>
        public RepeatedField<string> Permissions
        {
            get { return permissions_; }
        }

        public override bool Equals(object other) => Equals(other as TestPermissionsRequest);
        public bool Equals(TestPermissionsRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Installation != other.Installation) return false;
            if (!permissions_.Equals(other.permissions_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Installation.Length != 0) hash ^= Installation.GetHashCode();
            hash ^= permissions_.GetHashCode();
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
      if (Installation.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Installation);
      }
      permissions_.WriteTo(output, _repeated_permissions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Installation.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Installation);
            }
            permissions_.WriteTo(ref output, _repeated_permissions_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Installation.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Installation);
            }
            size += permissions_.CalculateSize(_repeated_permissions_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(TestPermissionsRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Installation.Length != 0)
            {
                Installation = other.Installation;
            }
            permissions_.Add(other.permissions_);
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
            Installation = input.ReadString();
            break;
          }
          case 18: {
            permissions_.AddEntriesFrom(input, _repeated_permissions_codec);
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
                            Installation = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            permissions_.AddEntriesFrom(ref input, _repeated_permissions_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`TestPermissions`][salto.nebula.installation.v1.InstallationService.TestPermissions]
    /// </summary>
    public sealed partial class TestPermissionsResponse : IMessage<TestPermissionsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<TestPermissionsResponse> _parser = new(() => new TestPermissionsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<TestPermissionsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[22]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public TestPermissionsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public TestPermissionsResponse(TestPermissionsResponse other) : this()
        {
            permissions_ = other.permissions_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public TestPermissionsResponse Clone() => new(this);
        /// <summary>Field number for the "permissions" field.</summary>
        public const int PermissionsFieldNumber = 1;
        private static readonly FieldCodec<string> _repeated_permissions_codec
            = FieldCodec.ForString(10);
        private readonly RepeatedField<string> permissions_ = [];

        /// <summary>
        /// A subset of `TestPermissionsRequest.permissions` that the caller is
        /// allowed.
        /// </summary>
        public RepeatedField<string> Permissions
        {
            get { return permissions_; }
        }

        public override bool Equals(object other) => Equals(other as TestPermissionsResponse);
        public bool Equals(TestPermissionsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!permissions_.Equals(other.permissions_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= permissions_.GetHashCode();
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
      permissions_.WriteTo(output, _repeated_permissions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            permissions_.WriteTo(ref output, _repeated_permissions_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += permissions_.CalculateSize(_repeated_permissions_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(TestPermissionsResponse other)
        {
            if (other == null)
            {
                return;
            }
            permissions_.Add(other.permissions_);
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
            permissions_.AddEntriesFrom(input, _repeated_permissions_codec);
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
                            permissions_.AddEntriesFrom(ref input, _repeated_permissions_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`TransferInstallationOwnership`][salto.nebula.installation.v1.InstallationService.TransferInstallationOwnership]
    /// </summary>
    public sealed partial class TransferInstallationOwnershipRequest : IMessage<TransferInstallationOwnershipRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<TransferInstallationOwnershipRequest> _parser = new(() => new TransferInstallationOwnershipRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<TransferInstallationOwnershipRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[23]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public TransferInstallationOwnershipRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public TransferInstallationOwnershipRequest(TransferInstallationOwnershipRequest other) : this()
        {
            installation_ = other.installation_;
            email_ = other.email_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public TransferInstallationOwnershipRequest Clone() => new(this);
        /// <summary>Field number for the "installation" field.</summary>
        public const int InstallationFieldNumber = 1;
        private string installation_ = "";

        /// <summary>
        /// The resource name for which the transfer ownership is being requested.
        /// For example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Installation
        {
            get { return installation_; }
            set
            {
                installation_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "email" field.</summary>
        public const int EmailFieldNumber = 2;
        private string email_ = "";

        /// <summary>
        /// Email address for the proposed installation owner.
        /// </summary>
        public string Email
        {
            get { return email_; }
            set
            {
                email_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as TransferInstallationOwnershipRequest);
        public bool Equals(TransferInstallationOwnershipRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Installation != other.Installation) return false;
            if (Email != other.Email) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Installation.Length != 0) hash ^= Installation.GetHashCode();
            if (Email.Length != 0) hash ^= Email.GetHashCode();
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
      if (Installation.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Installation);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Email);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Installation.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Installation);
            }
            if (Email.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Email);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Installation.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Installation);
            }
            if (Email.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Email);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(TransferInstallationOwnershipRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Installation.Length != 0)
            {
                Installation = other.Installation;
            }
            if (other.Email.Length != 0)
            {
                Email = other.Email;
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
            Installation = input.ReadString();
            break;
          }
          case 18: {
            Email = input.ReadString();
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
                            Installation = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Email = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`TransferInstallationOwnership`][salto.nebula.installation.v1.InstallationService.TransferInstallationOwnership]
    /// </summary>
    public sealed partial class TransferInstallationOwnershipResponse : IMessage<TransferInstallationOwnershipResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<TransferInstallationOwnershipResponse> _parser = new(() => new TransferInstallationOwnershipResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<TransferInstallationOwnershipResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[24]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public TransferInstallationOwnershipResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public TransferInstallationOwnershipResponse(TransferInstallationOwnershipResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public TransferInstallationOwnershipResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as TransferInstallationOwnershipResponse);
        public bool Equals(TransferInstallationOwnershipResponse other)
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

        public void MergeFrom(TransferInstallationOwnershipResponse other)
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
    /// The request message for [`AcceptInstallationOwnership`][salto.nebula.installation.v1.InstallationService.AcceptInstallationOwnership]
    /// </summary>
    public sealed partial class AcceptInstallationOwnershipRequest : IMessage<AcceptInstallationOwnershipRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AcceptInstallationOwnershipRequest> _parser = new(() => new AcceptInstallationOwnershipRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AcceptInstallationOwnershipRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[25]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AcceptInstallationOwnershipRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AcceptInstallationOwnershipRequest(AcceptInstallationOwnershipRequest other) : this()
        {
            installation_ = other.installation_;
            billingInfo_ = other.billingInfo_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AcceptInstallationOwnershipRequest Clone() => new(this);
        /// <summary>Field number for the "installation" field.</summary>
        public const int InstallationFieldNumber = 1;
        private string installation_ = "";

        /// <summary>
        /// The resource name for which the accept ownership is being requested.
        /// For example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Installation
        {
            get { return installation_; }
            set
            {
                installation_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "billing_info" field.</summary>
        public const int BillingInfoFieldNumber = 2;
        private BillingInfo billingInfo_;

        /// <summary>
        /// The billing info resource for the subscription billing.
        /// </summary>
        public BillingInfo BillingInfo
        {
            get { return billingInfo_; }
            set
            {
                billingInfo_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AcceptInstallationOwnershipRequest);
        public bool Equals(AcceptInstallationOwnershipRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Installation != other.Installation) return false;
            if (!Equals(BillingInfo, other.BillingInfo)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Installation.Length != 0) hash ^= Installation.GetHashCode();
            if (billingInfo_ != null) hash ^= BillingInfo.GetHashCode();
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
      if (Installation.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Installation);
      }
      if (billingInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(BillingInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Installation.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Installation);
            }
            if (billingInfo_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(BillingInfo);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Installation.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Installation);
            }
            if (billingInfo_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(BillingInfo);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(AcceptInstallationOwnershipRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Installation.Length != 0)
            {
                Installation = other.Installation;
            }
            if (other.billingInfo_ != null)
            {
                if (billingInfo_ == null)
                {
                    BillingInfo = new BillingInfo();
                }
                BillingInfo.MergeFrom(other.BillingInfo);
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
            Installation = input.ReadString();
            break;
          }
          case 18: {
            if (billingInfo_ == null) {
              BillingInfo = new Saltoapis.Nebula.Installation.V1.BillingInfo();
            }
            input.ReadMessage(BillingInfo);
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
                            Installation = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            if (billingInfo_ == null)
                            {
                                BillingInfo = new BillingInfo();
                            }
                            input.ReadMessage(BillingInfo);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`AcceptInstallationOwnership`][salto.nebula.installation.v1.InstallationService.AcceptInstallationOwnership]
    /// </summary>
    public sealed partial class AcceptInstallationOwnershipResponse : IMessage<AcceptInstallationOwnershipResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AcceptInstallationOwnershipResponse> _parser = new(() => new AcceptInstallationOwnershipResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AcceptInstallationOwnershipResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[26]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AcceptInstallationOwnershipResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AcceptInstallationOwnershipResponse(AcceptInstallationOwnershipResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AcceptInstallationOwnershipResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as AcceptInstallationOwnershipResponse);
        public bool Equals(AcceptInstallationOwnershipResponse other)
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

        public void MergeFrom(AcceptInstallationOwnershipResponse other)
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
    /// The request message for [`GetSubscription`][salto.nebula.installation.v1.InstallationService.GetSubscription]
    /// </summary>
    public sealed partial class GetSubscriptionRequest : IMessage<GetSubscriptionRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetSubscriptionRequest> _parser = new(() => new GetSubscriptionRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetSubscriptionRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[27]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetSubscriptionRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetSubscriptionRequest(GetSubscriptionRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetSubscriptionRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested subscription resource. For example:
        /// `installations/surelock-homes-hq/subscription`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetSubscriptionRequest);
        public bool Equals(GetSubscriptionRequest other)
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

        public void MergeFrom(GetSubscriptionRequest other)
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
    /// (-- api-linter: core::0134::request-mask-required=disabled
    ///     aip.dev/not-precedent: We need to do this to simplify the update operation. --)
    /// The request message for [`UpdateBillingInfo`][salto.nebula.installation.v1.InstallationService.UpdateBillingInfo]
    /// </summary>
    public sealed partial class UpdateBillingInfoRequest : IMessage<UpdateBillingInfoRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateBillingInfoRequest> _parser = new(() => new UpdateBillingInfoRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateBillingInfoRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[28]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateBillingInfoRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateBillingInfoRequest(UpdateBillingInfoRequest other) : this()
        {
            billingInfo_ = other.billingInfo_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateBillingInfoRequest Clone() => new(this);
        /// <summary>Field number for the "billing_info" field.</summary>
        public const int BillingInfoFieldNumber = 1;
        private BillingInfo billingInfo_;

        /// <summary>
        /// The billing info resource which replaces the resource on the server.
        /// </summary>
        public BillingInfo BillingInfo
        {
            get { return billingInfo_; }
            set
            {
                billingInfo_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateBillingInfoRequest);
        public bool Equals(UpdateBillingInfoRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(BillingInfo, other.BillingInfo)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (billingInfo_ != null) hash ^= BillingInfo.GetHashCode();
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
      if (billingInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(BillingInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (billingInfo_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(BillingInfo);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (billingInfo_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(BillingInfo);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdateBillingInfoRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.billingInfo_ != null)
            {
                if (billingInfo_ == null)
                {
                    BillingInfo = new BillingInfo();
                }
                BillingInfo.MergeFrom(other.BillingInfo);
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
            if (billingInfo_ == null) {
              BillingInfo = new Saltoapis.Nebula.Installation.V1.BillingInfo();
            }
            input.ReadMessage(BillingInfo);
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
                            if (billingInfo_ == null)
                            {
                                BillingInfo = new BillingInfo();
                            }
                            input.ReadMessage(BillingInfo);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// (-- api-linter: core::0134::request-mask-required=disabled
    ///     aip.dev/not-precedent: We need to do this to simplify the update operation. --)
    /// The request message for [`UpdatePaymentMethod`][salto.nebula.installation.v1.InstallationService.UpdatePaymentMethod]
    /// </summary>
    public sealed partial class UpdatePaymentMethodRequest : IMessage<UpdatePaymentMethodRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdatePaymentMethodRequest> _parser = new(() => new UpdatePaymentMethodRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdatePaymentMethodRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[29]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdatePaymentMethodRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdatePaymentMethodRequest(UpdatePaymentMethodRequest other) : this()
        {
            paymentMethod_ = other.paymentMethod_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdatePaymentMethodRequest Clone() => new(this);
        /// <summary>Field number for the "payment_method" field.</summary>
        public const int PaymentMethodFieldNumber = 1;
        private PaymentMethod paymentMethod_;

        /// <summary>
        /// The payment method resource which replaces the resource on the server.
        /// </summary>
        public PaymentMethod PaymentMethod
        {
            get { return paymentMethod_; }
            set
            {
                paymentMethod_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UpdatePaymentMethodRequest);
        public bool Equals(UpdatePaymentMethodRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(PaymentMethod, other.PaymentMethod)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (paymentMethod_ != null) hash ^= PaymentMethod.GetHashCode();
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
      if (paymentMethod_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PaymentMethod);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (paymentMethod_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(PaymentMethod);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (paymentMethod_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(PaymentMethod);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdatePaymentMethodRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.paymentMethod_ != null)
            {
                if (paymentMethod_ == null)
                {
                    PaymentMethod = new PaymentMethod();
                }
                PaymentMethod.MergeFrom(other.PaymentMethod);
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
            if (paymentMethod_ == null) {
              PaymentMethod = new Saltoapis.Nebula.Installation.V1.PaymentMethod();
            }
            input.ReadMessage(PaymentMethod);
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
                            if (paymentMethod_ == null)
                            {
                                PaymentMethod = new PaymentMethod();
                            }
                            input.ReadMessage(PaymentMethod);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`UpdateCard`][salto.nebula.installation.v1.InstallationService.UpdateCard]
    /// </summary>
    public sealed partial class UpdateCardRequest : IMessage<UpdateCardRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateCardRequest> _parser = new(() => new UpdateCardRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateCardRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[30]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateCardRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateCardRequest(UpdateCardRequest other) : this()
        {
            paymentMethod_ = other.paymentMethod_;
            token_ = other.token_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateCardRequest Clone() => new(this);
        /// <summary>Field number for the "payment_method" field.</summary>
        public const int PaymentMethodFieldNumber = 1;
        private string paymentMethod_ = "";

        /// <summary>
        /// The resource name of the subscription's payment method for which the card is being
        /// requested to be updated. For example:
        /// `installations/surelock-homes-hq/subscription/payment-method`.
        /// </summary>
        public string PaymentMethod
        {
            get { return paymentMethod_; }
            set
            {
                paymentMethod_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "token" field.</summary>
        public const int TokenFieldNumber = 2;
        private string token_ = "";

        /// <summary>
        /// The token provided for the operation.
        /// </summary>
        public string Token
        {
            get { return token_; }
            set
            {
                token_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateCardRequest);
        public bool Equals(UpdateCardRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (PaymentMethod != other.PaymentMethod) return false;
            if (Token != other.Token) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (PaymentMethod.Length != 0) hash ^= PaymentMethod.GetHashCode();
            if (Token.Length != 0) hash ^= Token.GetHashCode();
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
      if (PaymentMethod.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PaymentMethod);
      }
      if (Token.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Token);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (PaymentMethod.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(PaymentMethod);
            }
            if (Token.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Token);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (PaymentMethod.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(PaymentMethod);
            }
            if (Token.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Token);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdateCardRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.PaymentMethod.Length != 0)
            {
                PaymentMethod = other.PaymentMethod;
            }
            if (other.Token.Length != 0)
            {
                Token = other.Token;
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
            PaymentMethod = input.ReadString();
            break;
          }
          case 18: {
            Token = input.ReadString();
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
                            PaymentMethod = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Token = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`UpdateCard`][salto.nebula.installation.v1.InstallationService.UpdateCard]
    /// </summary>
    public sealed partial class UpdateCardResponse : IMessage<UpdateCardResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateCardResponse> _parser = new(() => new UpdateCardResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateCardResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[31]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateCardResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateCardResponse(UpdateCardResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateCardResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as UpdateCardResponse);
        public bool Equals(UpdateCardResponse other)
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

        public void MergeFrom(UpdateCardResponse other)
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
    /// The request message for [`CreatePaymentAuthorization`][salto.nebula.installation.v1.InstallationService.CreatePaymentAuthorization]
    /// </summary>
    public sealed partial class CreatePaymentAuthorizationRequest : IMessage<CreatePaymentAuthorizationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreatePaymentAuthorizationRequest> _parser = new(() => new CreatePaymentAuthorizationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreatePaymentAuthorizationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[32]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreatePaymentAuthorizationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreatePaymentAuthorizationRequest(CreatePaymentAuthorizationRequest other) : this()
        {
            parent_ = other.parent_;
            paymentAuthorization_ = other.paymentAuthorization_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreatePaymentAuthorizationRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The resource name of the subscription for which the payment authorization is being
        /// requested to be created. For example:
        /// `installations/surelock-homes-hq/subscription`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "payment_authorization" field.</summary>
        public const int PaymentAuthorizationFieldNumber = 2;
        private PaymentAuthorization paymentAuthorization_;

        /// <summary>
        /// The payment authorization resource to be created. Client must not set the
        /// `PaymentAuthorization.name` field.
        /// </summary>
        public PaymentAuthorization PaymentAuthorization
        {
            get { return paymentAuthorization_; }
            set
            {
                paymentAuthorization_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreatePaymentAuthorizationRequest);
        public bool Equals(CreatePaymentAuthorizationRequest other)
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
            if (!Equals(PaymentAuthorization, other.PaymentAuthorization)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (paymentAuthorization_ != null) hash ^= PaymentAuthorization.GetHashCode();
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
      if (paymentAuthorization_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PaymentAuthorization);
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
            if (paymentAuthorization_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(PaymentAuthorization);
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
            if (paymentAuthorization_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(PaymentAuthorization);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreatePaymentAuthorizationRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.paymentAuthorization_ != null)
            {
                if (paymentAuthorization_ == null)
                {
                    PaymentAuthorization = new PaymentAuthorization();
                }
                PaymentAuthorization.MergeFrom(other.PaymentAuthorization);
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
            if (paymentAuthorization_ == null) {
              PaymentAuthorization = new Saltoapis.Nebula.Installation.V1.PaymentAuthorization();
            }
            input.ReadMessage(PaymentAuthorization);
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
                            if (paymentAuthorization_ == null)
                            {
                                PaymentAuthorization = new PaymentAuthorization();
                            }
                            input.ReadMessage(PaymentAuthorization);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// (-- api-linter: core::0158::request-page-size-field=disabled
    ///     aip.dev/not-precedent: We need to do this because there is no paging yet. --)
    /// (-- api-linter: core::0158::request-page-token-field=disabled
    ///     aip.dev/not-precedent: We need to do this because there is no paging yet. --)
    /// The request message for [`ListInvoices`][salto.nebula.installation.v1.InstallationService.ListInvoices]
    /// </summary>
    public sealed partial class ListInvoicesRequest : IMessage<ListInvoicesRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListInvoicesRequest> _parser = new(() => new ListInvoicesRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListInvoicesRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[33]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListInvoicesRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListInvoicesRequest(ListInvoicesRequest other) : this()
        {
            parent_ = other.parent_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListInvoicesRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name. It must have the format of
        /// `installations/*/subscription`. For example: `installations/surelock-homes-hq/subscription`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ListInvoicesRequest);
        public bool Equals(ListInvoicesRequest other)
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

        public void MergeFrom(ListInvoicesRequest other)
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

    /// <summary>
    /// (-- api-linter: core::0158::response-next-page-token-field=disabled
    ///     aip.dev/not-precedent: We need to do this because there is no paging yet. --)
    /// The response message for [`ListInvoices`][salto.nebula.installation.v1.InstallationService.ListInvoices]
    /// </summary>
    public sealed partial class ListInvoicesResponse : IMessage<ListInvoicesResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListInvoicesResponse> _parser = new(() => new ListInvoicesResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListInvoicesResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[34]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListInvoicesResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListInvoicesResponse(ListInvoicesResponse other) : this()
        {
            invoices_ = other.invoices_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListInvoicesResponse Clone() => new(this);
        /// <summary>Field number for the "invoices" field.</summary>
        public const int InvoicesFieldNumber = 1;
        private static readonly FieldCodec<Invoice> _repeated_invoices_codec
            = FieldCodec.ForMessage(10, Invoice.Parser);
        private readonly RepeatedField<Invoice> invoices_ = [];

        /// <summary>
        /// The field name should match the noun `invoices` in the method name.
        /// </summary>
        public RepeatedField<Invoice> Invoices
        {
            get { return invoices_; }
        }

        public override bool Equals(object other) => Equals(other as ListInvoicesResponse);
        public bool Equals(ListInvoicesResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!invoices_.Equals(other.invoices_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= invoices_.GetHashCode();
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
      invoices_.WriteTo(output, _repeated_invoices_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            invoices_.WriteTo(ref output, _repeated_invoices_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += invoices_.CalculateSize(_repeated_invoices_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ListInvoicesResponse other)
        {
            if (other == null)
            {
                return;
            }
            invoices_.Add(other.invoices_);
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
            invoices_.AddEntriesFrom(input, _repeated_invoices_codec);
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
                            invoices_.AddEntriesFrom(ref input, _repeated_invoices_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`ApplyCoupon`][salto.nebula.installation.v1.InstallationService.ApplyCoupon]
    /// </summary>
    public sealed partial class ApplyCouponRequest : IMessage<ApplyCouponRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ApplyCouponRequest> _parser = new(() => new ApplyCouponRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ApplyCouponRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[35]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ApplyCouponRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ApplyCouponRequest(ApplyCouponRequest other) : this()
        {
            subscription_ = other.subscription_;
            coupon_ = other.coupon_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ApplyCouponRequest Clone() => new(this);
        /// <summary>Field number for the "subscription" field.</summary>
        public const int SubscriptionFieldNumber = 1;
        private string subscription_ = "";

        /// <summary>
        /// The resource name of the subscription for which the coupon is being
        /// requested to be applied. For example:
        /// `installations/surelock-homes-hq/subscription`.
        /// </summary>
        public string Subscription
        {
            get { return subscription_; }
            set
            {
                subscription_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "coupon" field.</summary>
        public const int CouponFieldNumber = 2;
        private string coupon_ = "";

        /// <summary>
        /// The resource name of the coupon that is requested to be applied.
        /// For example: `installations/surelock-homes-hq/subscription/coupons/01HCD0YB`.
        /// </summary>
        public string Coupon
        {
            get { return coupon_; }
            set
            {
                coupon_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ApplyCouponRequest);
        public bool Equals(ApplyCouponRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Subscription != other.Subscription) return false;
            if (Coupon != other.Coupon) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Subscription.Length != 0) hash ^= Subscription.GetHashCode();
            if (Coupon.Length != 0) hash ^= Coupon.GetHashCode();
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
      if (Subscription.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Subscription);
      }
      if (Coupon.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Coupon);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Subscription.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Subscription);
            }
            if (Coupon.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Coupon);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Subscription.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Subscription);
            }
            if (Coupon.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Coupon);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ApplyCouponRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Subscription.Length != 0)
            {
                Subscription = other.Subscription;
            }
            if (other.Coupon.Length != 0)
            {
                Coupon = other.Coupon;
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
            Subscription = input.ReadString();
            break;
          }
          case 18: {
            Coupon = input.ReadString();
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
                            Subscription = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Coupon = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`ApplyCoupon`][salto.nebula.installation.v1.InstallationService.ApplyCoupon]
    /// </summary>
    public sealed partial class ApplyCouponResponse : IMessage<ApplyCouponResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ApplyCouponResponse> _parser = new(() => new ApplyCouponResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ApplyCouponResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[36]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ApplyCouponResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ApplyCouponResponse(ApplyCouponResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ApplyCouponResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ApplyCouponResponse);
        public bool Equals(ApplyCouponResponse other)
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

        public void MergeFrom(ApplyCouponResponse other)
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
    /// The request message for [`UnapplyCoupon`][salto.nebula.installation.v1.InstallationService.UnapplyCoupon]
    /// </summary>
    public sealed partial class UnapplyCouponRequest : IMessage<UnapplyCouponRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnapplyCouponRequest> _parser = new(() => new UnapplyCouponRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnapplyCouponRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[37]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnapplyCouponRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnapplyCouponRequest(UnapplyCouponRequest other) : this()
        {
            subscription_ = other.subscription_;
            coupon_ = other.coupon_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnapplyCouponRequest Clone() => new(this);
        /// <summary>Field number for the "subscription" field.</summary>
        public const int SubscriptionFieldNumber = 1;
        private string subscription_ = "";

        /// <summary>
        /// The resource name of the subscription for which the coupon is being
        /// requested to be unapplied. For example:
        /// `installations/surelock-homes-hq/subscription`.
        /// </summary>
        public string Subscription
        {
            get { return subscription_; }
            set
            {
                subscription_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "coupon" field.</summary>
        public const int CouponFieldNumber = 2;
        private string coupon_ = "";

        /// <summary>
        /// The resource name of the coupon that is requested to be unapplied.
        /// For example: `installations/surelock-homes-hq/subscription/coupons/01HCD0YB`.
        /// </summary>
        public string Coupon
        {
            get { return coupon_; }
            set
            {
                coupon_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as UnapplyCouponRequest);
        public bool Equals(UnapplyCouponRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Subscription != other.Subscription) return false;
            if (Coupon != other.Coupon) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Subscription.Length != 0) hash ^= Subscription.GetHashCode();
            if (Coupon.Length != 0) hash ^= Coupon.GetHashCode();
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
      if (Subscription.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Subscription);
      }
      if (Coupon.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Coupon);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Subscription.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Subscription);
            }
            if (Coupon.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Coupon);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Subscription.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Subscription);
            }
            if (Coupon.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Coupon);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UnapplyCouponRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Subscription.Length != 0)
            {
                Subscription = other.Subscription;
            }
            if (other.Coupon.Length != 0)
            {
                Coupon = other.Coupon;
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
            Subscription = input.ReadString();
            break;
          }
          case 18: {
            Coupon = input.ReadString();
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
                            Subscription = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Coupon = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`UnapplyCoupon`][salto.nebula.installation.v1.InstallationService.UnapplyCoupon]
    /// </summary>
    public sealed partial class UnapplyCouponResponse : IMessage<UnapplyCouponResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnapplyCouponResponse> _parser = new(() => new UnapplyCouponResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnapplyCouponResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return InstallationReflection.Descriptor.MessageTypes[38]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnapplyCouponResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnapplyCouponResponse(UnapplyCouponResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnapplyCouponResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as UnapplyCouponResponse);
        public bool Equals(UnapplyCouponResponse other)
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

        public void MergeFrom(UnapplyCouponResponse other)
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
    /// The request message for [`GenerateAuthorizationToken`][salto.nebula.controller.v1.InstallationService.GenerateAuthorizationToken]
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
            get { return InstallationReflection.Descriptor.MessageTypes[39]; }
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
            installation_ = other.installation_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateAuthorizationTokenRequest Clone() => new(this);
        /// <summary>Field number for the "installation" field.</summary>
        public const int InstallationFieldNumber = 1;
        private string installation_ = "";

        /// <summary>
        /// The resource name of the installation that the authorization token is
        /// generated for. For example:
        /// `installations/surelock-homes-hq`.
        /// </summary>
        public string Installation
        {
            get { return installation_; }
            set
            {
                installation_ = ProtoPreconditions.CheckNotNull(value, "value");
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
            if (Installation != other.Installation) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Installation.Length != 0) hash ^= Installation.GetHashCode();
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
      if (Installation.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Installation);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Installation.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Installation);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Installation.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Installation);
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
            if (other.Installation.Length != 0)
            {
                Installation = other.Installation;
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
            Installation = input.ReadString();
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
                            Installation = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`GenerateAuthorizationToken`][salto.nebula.controller.v1.InstallationService.GenerateAuthorizationToken]
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
            get { return InstallationReflection.Descriptor.MessageTypes[40]; }
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
        /// Authorization token to be used for connecting against a not initialized device.
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

    #endregion

}
