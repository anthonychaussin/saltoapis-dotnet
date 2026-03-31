using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.User.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/user/v1/user.proto</summary>
    public static partial class UserReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/user/v1/user.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static UserReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "Ch9zYWx0by9uZWJ1bGEvdXNlci92MS91c2VyLnByb3RvEhRzYWx0by5uZWJ1",
                  "bGEudXNlci52MRobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvGiBnb29n",
                  "bGUvcHJvdG9idWYvZmllbGRfbWFzay5wcm90bxofZ29vZ2xlL3Byb3RvYnVm",
                  "L3RpbWVzdGFtcC5wcm90bxokc2FsdG8vbG9uZ3J1bm5pbmcvdjEvb3BlcmF0",
                  "aW9uLnByb3RvGiBzYWx0by9uZWJ1bGEvdHlwZS9zY2hlZHVsZS5wcm90byLy",
                  "BAoEVXNlchIMCgRuYW1lGAEgASgJEhMKBnBhcmVudBgCIAEoCUgAiAEBEhIK",
                  "CmdpdmVuX25hbWUYAyABKAkSGAoLZmFtaWx5X25hbWUYBCABKAlIAYgBARIU",
                  "CgxkaXNwbGF5X25hbWUYBSABKAkSEgoFZW1haWwYBiABKAlIAogBARIxCg1h",
                  "Y3RpdmF0ZV90aW1lGAcgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFt",
                  "cBIvCgtleHBpcmVfdGltZRgIIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1l",
                  "c3RhbXASEgoFcGhvdG8YCSABKAlIA4gBARIRCglwaG90b191cmkYCiABKAkS",
                  "LwoIY2FyZF9rZXkYCyABKAsyHS5zYWx0by5uZWJ1bGEudXNlci52MS5DYXJk",
                  "S2V5EjsKDmVsZWN0cm9uaWNfa2V5GBAgASgLMiMuc2FsdG8ubmVidWxhLnVz",
                  "ZXIudjEuRWxlY3Ryb25pY0tleRItCgdhcHBfa2V5GAwgASgLMhwuc2FsdG8u",
                  "bmVidWxhLnVzZXIudjEuQXBwS2V5EjMKCndhbGxldF9rZXkYDSABKAsyHy5z",
                  "YWx0by5uZWJ1bGEudXNlci52MS5XYWxsZXRLZXkSMAoIcGFzc2NvZGUYDyAB",
                  "KAsyHi5zYWx0by5uZWJ1bGEudXNlci52MS5QYXNzY29kZRIPCgdibG9ja2Vk",
                  "GA4gASgIEhQKB21hbmFnZXIYESABKAlIBIgBAUIJCgdfcGFyZW50Qg4KDF9m",
                  "YW1pbHlfbmFtZUIICgZfZW1haWxCCAoGX3Bob3RvQgoKCF9tYW5hZ2VyIucC",
                  "Cg9Vc2VyQWNjZXNzUmlnaHQSDAoEbmFtZRgBIAEoCRIUCgxhY2Nlc3Nfcmln",
                  "aHQYAiABKAkSFAoMZGlzcGxheV9uYW1lGAMgASgJEi4KCXNjaGVkdWxlcxgE",
                  "IAMoCzIbLnNhbHRvLm5lYnVsYS50eXBlLlNjaGVkdWxlEjgKE2VmZmVjdGl2",
                  "ZV9zY2hlZHVsZXMYBSADKAsyGy5zYWx0by5uZWJ1bGEudHlwZS5TY2hlZHVs",
                  "ZRI2Cg1hY3RpdmF0ZV90aW1lGAYgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRp",
                  "bWVzdGFtcEgAiAEBEjQKC2V4cGlyZV90aW1lGAcgASgLMhouZ29vZ2xlLnBy",
                  "b3RvYnVmLlRpbWVzdGFtcEgBiAEBEhQKB21hbmFnZXIYCCABKAlIAogBAUIQ",
                  "Cg5fYWN0aXZhdGVfdGltZUIOCgxfZXhwaXJlX3RpbWVCCgoIX21hbmFnZXIi",
                  "tQEKB0NhcmRLZXkSDAoEbmFtZRgBIAEoCRILCgN1aWQYAiABKAkSMgoFc3Rh",
                  "dGUYAyABKA4yIy5zYWx0by5uZWJ1bGEudXNlci52MS5DYXJkS2V5LlN0YXRl",
                  "EhAKCG91dGRhdGVkGAQgASgIIkkKBVN0YXRlEhUKEVNUQVRFX1VOU1BFQ0lG",
                  "SUVEEAASEAoMTk9UX0FTU0lHTkVEEAESCwoHUEVORElORxACEgoKBkFDVElW",
                  "RRADIqYBCgZBcHBLZXkSDAoEbmFtZRgBIAEoCRIxCgVzdGF0ZRgCIAEoDjIi",
                  "LnNhbHRvLm5lYnVsYS51c2VyLnYxLkFwcEtleS5TdGF0ZRIQCghvdXRkYXRl",
                  "ZBgDIAEoCCJJCgVTdGF0ZRIVChFTVEFURV9VTlNQRUNJRklFRBAAEhAKDE5P",
                  "VF9BU1NJR05FRBABEgsKB1BFTkRJTkcQAhIKCgZBQ1RJVkUQAyKsAQoJV2Fs",
                  "bGV0S2V5EgwKBG5hbWUYASABKAkSNAoFc3RhdGUYAiABKA4yJS5zYWx0by5u",
                  "ZWJ1bGEudXNlci52MS5XYWxsZXRLZXkuU3RhdGUSEAoIb3V0ZGF0ZWQYAyAB",
                  "KAgiSQoFU3RhdGUSFQoRU1RBVEVfVU5TUEVDSUZJRUQQABIQCgxOT1RfQVNT",
                  "SUdORUQQARILCgdQRU5ESU5HEAISCgoGQUNUSVZFEAMiiwEKCFBhc3Njb2Rl",
                  "EgwKBG5hbWUYASABKAkSMwoFc3RhdGUYAiABKA4yJC5zYWx0by5uZWJ1bGEu",
                  "dXNlci52MS5QYXNzY29kZS5TdGF0ZSI8CgVTdGF0ZRIVChFTVEFURV9VTlNQ",
                  "RUNJRklFRBAAEhAKDE5PVF9BU1NJR05FRBABEgoKBkFDVElWRRACIscBCg1F",
                  "bGVjdHJvbmljS2V5EgwKBG5hbWUYASABKAkSEQoJZGV2aWNlX2lkGAIgASgJ",
                  "EjgKBXN0YXRlGAMgASgOMikuc2FsdG8ubmVidWxhLnVzZXIudjEuRWxlY3Ry",
                  "b25pY0tleS5TdGF0ZRIQCghvdXRkYXRlZBgEIAEoCCJJCgVTdGF0ZRIVChFT",
                  "VEFURV9VTlNQRUNJRklFRBAAEhAKDE5PVF9BU1NJR05FRBABEgsKB1BFTkRJ",
                  "TkcQAhIKCgZBQ1RJVkUQAyJvChFDcmVhdGVVc2VyUmVxdWVzdBIOCgZwYXJl",
                  "bnQYASABKAkSFAoHdXNlcl9pZBgCIAEoCUgAiAEBEigKBHVzZXIYAyABKAsy",
                  "Gi5zYWx0by5uZWJ1bGEudXNlci52MS5Vc2VyQgoKCF91c2VyX2lkIh4KDkdl",
                  "dFVzZXJSZXF1ZXN0EgwKBG5hbWUYASABKAkiNQoUQmF0Y2hHZXRVc2Vyc1Jl",
                  "cXVlc3QSDgoGcGFyZW50GAEgASgJEg0KBW5hbWVzGAIgAygJIkIKFUJhdGNo",
                  "R2V0VXNlcnNSZXNwb25zZRIpCgV1c2VycxgBIAMoCzIaLnNhbHRvLm5lYnVs",
                  "YS51c2VyLnYxLlVzZXIiawoQTGlzdFVzZXJzUmVxdWVzdBIOCgZwYXJlbnQY",
                  "ASABKAkSEQoJcGFnZV9zaXplGAIgASgFEhIKCnBhZ2VfdG9rZW4YAyABKAkS",
                  "DgoGZmlsdGVyGAQgASgJEhAKCG9yZGVyX2J5GAUgASgJImsKEUxpc3RVc2Vy",
                  "c1Jlc3BvbnNlEikKBXVzZXJzGAEgAygLMhouc2FsdG8ubmVidWxhLnVzZXIu",
                  "djEuVXNlchIXCg9uZXh0X3BhZ2VfdG9rZW4YAiABKAkSEgoKdG90YWxfc2l6",
                  "ZRgDIAEoBSJuChFVcGRhdGVVc2VyUmVxdWVzdBIoCgR1c2VyGAEgASgLMhou",
                  "c2FsdG8ubmVidWxhLnVzZXIudjEuVXNlchIvCgt1cGRhdGVfbWFzaxgCIAEo",
                  "CzIaLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE1hc2siIQoRRGVsZXRlVXNlclJl",
                  "cXVlc3QSDAoEbmFtZRgBIAEoCSIgChBCbG9ja1VzZXJSZXF1ZXN0EgwKBG5h",
                  "bWUYASABKAkiEwoRQmxvY2tVc2VyUmVzcG9uc2UiIgoSVW5ibG9ja1VzZXJS",
                  "ZXF1ZXN0EgwKBG5hbWUYASABKAkiFQoTVW5ibG9ja1VzZXJSZXNwb25zZSJw",
                  "ChxDcmVhdGVVc2VyQWNjZXNzUmlnaHRSZXF1ZXN0Eg4KBnBhcmVudBgBIAEo",
                  "CRJAChF1c2VyX2FjY2Vzc19yaWdodBgCIAEoCzIlLnNhbHRvLm5lYnVsYS51",
                  "c2VyLnYxLlVzZXJBY2Nlc3NSaWdodCIpChlHZXRVc2VyQWNjZXNzUmlnaHRS",
                  "ZXF1ZXN0EgwKBG5hbWUYASABKAkidgobTGlzdFVzZXJBY2Nlc3NSaWdodHNS",
                  "ZXF1ZXN0Eg4KBnBhcmVudBgBIAEoCRIRCglwYWdlX3NpemUYAiABKAUSEgoK",
                  "cGFnZV90b2tlbhgDIAEoCRIOCgZmaWx0ZXIYBCABKAkSEAoIb3JkZXJfYnkY",
                  "BSABKAkiegocTGlzdFVzZXJBY2Nlc3NSaWdodHNSZXNwb25zZRJBChJ1c2Vy",
                  "X2FjY2Vzc19yaWdodHMYASADKAsyJS5zYWx0by5uZWJ1bGEudXNlci52MS5V",
                  "c2VyQWNjZXNzUmlnaHQSFwoPbmV4dF9wYWdlX3Rva2VuGAIgASgJIpEBChxV",
                  "cGRhdGVVc2VyQWNjZXNzUmlnaHRSZXF1ZXN0EkAKEXVzZXJfYWNjZXNzX3Jp",
                  "Z2h0GAEgASgLMiUuc2FsdG8ubmVidWxhLnVzZXIudjEuVXNlckFjY2Vzc1Jp",
                  "Z2h0Ei8KC3VwZGF0ZV9tYXNrGAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLkZp",
                  "ZWxkTWFzayIsChxEZWxldGVVc2VyQWNjZXNzUmlnaHRSZXF1ZXN0EgwKBG5h",
                  "bWUYASABKAkiMQoUQXNzaWduQ2FyZEtleVJlcXVlc3QSDAoEbmFtZRgBIAEo",
                  "CRILCgN1aWQYAiABKAkiJAoUQ2FuY2VsQ2FyZEtleVJlcXVlc3QSDAoEbmFt",
                  "ZRgBIAEoCSJyChRFbmNvZGVDYXJkS2V5UmVxdWVzdBIMCgRuYW1lGAEgASgJ",
                  "EhEKB2VuY29kZXIYAiABKAlIABIZCg9lbGVjdHJvbmljX2xvY2sYAyABKAlI",
                  "ABIUCgpjb250cm9sbGVyGAQgASgJSABCCAoGZGV2aWNlIhcKFUVuY29kZUNh",
                  "cmRLZXlSZXNwb25zZSIXChVFbmNvZGVDYXJkS2V5TWV0YWRhdGEiIwoTQXNz",
                  "aWduQXBwS2V5UmVxdWVzdBIMCgRuYW1lGAEgASgJIiMKE0NhbmNlbEFwcEtl",
                  "eVJlcXVlc3QSDAoEbmFtZRgBIAEoCSIoChhDb21wdXRlQXBwS2V5RGF0YVJl",
                  "cXVlc3QSDAoEbmFtZRgBIAEoCSIpChlDb21wdXRlQXBwS2V5RGF0YVJlc3Bv",
                  "bnNlEgwKBGRhdGEYASABKAwiJgoWQXNzaWduV2FsbGV0S2V5UmVxdWVzdBIM",
                  "CgRuYW1lGAEgASgJImIKF0Fzc2lnbldhbGxldEtleVJlc3BvbnNlEjMKCndh",
                  "bGxldF9rZXkYASABKAsyHy5zYWx0by5uZWJ1bGEudXNlci52MS5XYWxsZXRL",
                  "ZXkSEgoKYWNjZXNzX3VyaRgCIAEoCSImChZDYW5jZWxXYWxsZXRLZXlSZXF1",
                  "ZXN0EgwKBG5hbWUYASABKAkiTgoXQ2FuY2VsV2FsbGV0S2V5UmVzcG9uc2US",
                  "MwoKd2FsbGV0X2tleRgBIAEoCzIfLnNhbHRvLm5lYnVsYS51c2VyLnYxLldh",
                  "bGxldEtleSIlChVBc3NpZ25QYXNzY29kZVJlcXVlc3QSDAoEbmFtZRgBIAEo",
                  "CSJZChZBc3NpZ25QYXNzY29kZVJlc3BvbnNlEjAKCHBhc3Njb2RlGAEgASgL",
                  "Mh4uc2FsdG8ubmVidWxhLnVzZXIudjEuUGFzc2NvZGUSDQoFdmFsdWUYAiAB",
                  "KAkiJQoVQ2FuY2VsUGFzc2NvZGVSZXF1ZXN0EgwKBG5hbWUYASABKAkiSgoW",
                  "Q2FuY2VsUGFzc2NvZGVSZXNwb25zZRIwCghwYXNzY29kZRgBIAEoCzIeLnNh",
                  "bHRvLm5lYnVsYS51c2VyLnYxLlBhc3Njb2RlIj0KGkFzc2lnbkVsZWN0cm9u",
                  "aWNLZXlSZXF1ZXN0EgwKBG5hbWUYASABKAkSEQoJZGV2aWNlX2lkGAIgASgJ",
                  "IloKG0Fzc2lnbkVsZWN0cm9uaWNLZXlSZXNwb25zZRI7Cg5lbGVjdHJvbmlj",
                  "X2tleRgBIAEoCzIjLnNhbHRvLm5lYnVsYS51c2VyLnYxLkVsZWN0cm9uaWNL",
                  "ZXkiKgoaQ2FuY2VsRWxlY3Ryb25pY0tleVJlcXVlc3QSDAoEbmFtZRgBIAEo",
                  "CSJaChtDYW5jZWxFbGVjdHJvbmljS2V5UmVzcG9uc2USOwoOZWxlY3Ryb25p",
                  "Y19rZXkYASABKAsyIy5zYWx0by5uZWJ1bGEudXNlci52MS5FbGVjdHJvbmlj",
                  "S2V5IngKGkVuY29kZUVsZWN0cm9uaWNLZXlSZXF1ZXN0EgwKBG5hbWUYASAB",
                  "KAkSEQoHZW5jb2RlchgCIAEoCUgAEhkKD2VsZWN0cm9uaWNfbG9jaxgDIAEo",
                  "CUgAEhQKCmNvbnRyb2xsZXIYBCABKAlIAEIICgZkZXZpY2UiHQobRW5jb2Rl",
                  "RWxlY3Ryb25pY0tleVJlc3BvbnNlIh0KG0VuY29kZUVsZWN0cm9uaWNLZXlN",
                  "ZXRhZGF0YTLtFAoLVXNlclNlcnZpY2USUQoKQ3JlYXRlVXNlchInLnNhbHRv",
                  "Lm5lYnVsYS51c2VyLnYxLkNyZWF0ZVVzZXJSZXF1ZXN0Ghouc2FsdG8ubmVi",
                  "dWxhLnVzZXIudjEuVXNlchJLCgdHZXRVc2VyEiQuc2FsdG8ubmVidWxhLnVz",
                  "ZXIudjEuR2V0VXNlclJlcXVlc3QaGi5zYWx0by5uZWJ1bGEudXNlci52MS5V",
                  "c2VyEmgKDUJhdGNoR2V0VXNlcnMSKi5zYWx0by5uZWJ1bGEudXNlci52MS5C",
                  "YXRjaEdldFVzZXJzUmVxdWVzdBorLnNhbHRvLm5lYnVsYS51c2VyLnYxLkJh",
                  "dGNoR2V0VXNlcnNSZXNwb25zZRJcCglMaXN0VXNlcnMSJi5zYWx0by5uZWJ1",
                  "bGEudXNlci52MS5MaXN0VXNlcnNSZXF1ZXN0Gicuc2FsdG8ubmVidWxhLnVz",
                  "ZXIudjEuTGlzdFVzZXJzUmVzcG9uc2USUQoKVXBkYXRlVXNlchInLnNhbHRv",
                  "Lm5lYnVsYS51c2VyLnYxLlVwZGF0ZVVzZXJSZXF1ZXN0Ghouc2FsdG8ubmVi",
                  "dWxhLnVzZXIudjEuVXNlchJNCgpEZWxldGVVc2VyEicuc2FsdG8ubmVidWxh",
                  "LnVzZXIudjEuRGVsZXRlVXNlclJlcXVlc3QaFi5nb29nbGUucHJvdG9idWYu",
                  "RW1wdHkSXAoJQmxvY2tVc2VyEiYuc2FsdG8ubmVidWxhLnVzZXIudjEuQmxv",
                  "Y2tVc2VyUmVxdWVzdBonLnNhbHRvLm5lYnVsYS51c2VyLnYxLkJsb2NrVXNl",
                  "clJlc3BvbnNlEmIKC1VuYmxvY2tVc2VyEiguc2FsdG8ubmVidWxhLnVzZXIu",
                  "djEuVW5ibG9ja1VzZXJSZXF1ZXN0Gikuc2FsdG8ubmVidWxhLnVzZXIudjEu",
                  "VW5ibG9ja1VzZXJSZXNwb25zZRJyChVDcmVhdGVVc2VyQWNjZXNzUmlnaHQS",
                  "Mi5zYWx0by5uZWJ1bGEudXNlci52MS5DcmVhdGVVc2VyQWNjZXNzUmlnaHRS",
                  "ZXF1ZXN0GiUuc2FsdG8ubmVidWxhLnVzZXIudjEuVXNlckFjY2Vzc1JpZ2h0",
                  "EmwKEkdldFVzZXJBY2Nlc3NSaWdodBIvLnNhbHRvLm5lYnVsYS51c2VyLnYx",
                  "LkdldFVzZXJBY2Nlc3NSaWdodFJlcXVlc3QaJS5zYWx0by5uZWJ1bGEudXNl",
                  "ci52MS5Vc2VyQWNjZXNzUmlnaHQSfQoUTGlzdFVzZXJBY2Nlc3NSaWdodHMS",
                  "MS5zYWx0by5uZWJ1bGEudXNlci52MS5MaXN0VXNlckFjY2Vzc1JpZ2h0c1Jl",
                  "cXVlc3QaMi5zYWx0by5uZWJ1bGEudXNlci52MS5MaXN0VXNlckFjY2Vzc1Jp",
                  "Z2h0c1Jlc3BvbnNlEnIKFVVwZGF0ZVVzZXJBY2Nlc3NSaWdodBIyLnNhbHRv",
                  "Lm5lYnVsYS51c2VyLnYxLlVwZGF0ZVVzZXJBY2Nlc3NSaWdodFJlcXVlc3Qa",
                  "JS5zYWx0by5uZWJ1bGEudXNlci52MS5Vc2VyQWNjZXNzUmlnaHQSYwoVRGVs",
                  "ZXRlVXNlckFjY2Vzc1JpZ2h0EjIuc2FsdG8ubmVidWxhLnVzZXIudjEuRGVs",
                  "ZXRlVXNlckFjY2Vzc1JpZ2h0UmVxdWVzdBoWLmdvb2dsZS5wcm90b2J1Zi5F",
                  "bXB0eRJaCg1Bc3NpZ25DYXJkS2V5Eiouc2FsdG8ubmVidWxhLnVzZXIudjEu",
                  "QXNzaWduQ2FyZEtleVJlcXVlc3QaHS5zYWx0by5uZWJ1bGEudXNlci52MS5D",
                  "YXJkS2V5EloKDUNhbmNlbENhcmRLZXkSKi5zYWx0by5uZWJ1bGEudXNlci52",
                  "MS5DYW5jZWxDYXJkS2V5UmVxdWVzdBodLnNhbHRvLm5lYnVsYS51c2VyLnYx",
                  "LkNhcmRLZXkSXAoNRW5jb2RlQ2FyZEtleRIqLnNhbHRvLm5lYnVsYS51c2Vy",
                  "LnYxLkVuY29kZUNhcmRLZXlSZXF1ZXN0Gh8uc2FsdG8ubG9uZ3J1bm5pbmcu",
                  "djEuT3BlcmF0aW9uElcKDEFzc2lnbkFwcEtleRIpLnNhbHRvLm5lYnVsYS51",
                  "c2VyLnYxLkFzc2lnbkFwcEtleVJlcXVlc3QaHC5zYWx0by5uZWJ1bGEudXNl",
                  "ci52MS5BcHBLZXkSVwoMQ2FuY2VsQXBwS2V5Eikuc2FsdG8ubmVidWxhLnVz",
                  "ZXIudjEuQ2FuY2VsQXBwS2V5UmVxdWVzdBocLnNhbHRvLm5lYnVsYS51c2Vy",
                  "LnYxLkFwcEtleRJ0ChFDb21wdXRlQXBwS2V5RGF0YRIuLnNhbHRvLm5lYnVs",
                  "YS51c2VyLnYxLkNvbXB1dGVBcHBLZXlEYXRhUmVxdWVzdBovLnNhbHRvLm5l",
                  "YnVsYS51c2VyLnYxLkNvbXB1dGVBcHBLZXlEYXRhUmVzcG9uc2USbgoPQXNz",
                  "aWduV2FsbGV0S2V5Eiwuc2FsdG8ubmVidWxhLnVzZXIudjEuQXNzaWduV2Fs",
                  "bGV0S2V5UmVxdWVzdBotLnNhbHRvLm5lYnVsYS51c2VyLnYxLkFzc2lnbldh",
                  "bGxldEtleVJlc3BvbnNlEm4KD0NhbmNlbFdhbGxldEtleRIsLnNhbHRvLm5l",
                  "YnVsYS51c2VyLnYxLkNhbmNlbFdhbGxldEtleVJlcXVlc3QaLS5zYWx0by5u",
                  "ZWJ1bGEudXNlci52MS5DYW5jZWxXYWxsZXRLZXlSZXNwb25zZRJrCg5Bc3Np",
                  "Z25QYXNzY29kZRIrLnNhbHRvLm5lYnVsYS51c2VyLnYxLkFzc2lnblBhc3Nj",
                  "b2RlUmVxdWVzdBosLnNhbHRvLm5lYnVsYS51c2VyLnYxLkFzc2lnblBhc3Nj",
                  "b2RlUmVzcG9uc2USawoOQ2FuY2VsUGFzc2NvZGUSKy5zYWx0by5uZWJ1bGEu",
                  "dXNlci52MS5DYW5jZWxQYXNzY29kZVJlcXVlc3QaLC5zYWx0by5uZWJ1bGEu",
                  "dXNlci52MS5DYW5jZWxQYXNzY29kZVJlc3BvbnNlEnoKE0Fzc2lnbkVsZWN0",
                  "cm9uaWNLZXkSMC5zYWx0by5uZWJ1bGEudXNlci52MS5Bc3NpZ25FbGVjdHJv",
                  "bmljS2V5UmVxdWVzdBoxLnNhbHRvLm5lYnVsYS51c2VyLnYxLkFzc2lnbkVs",
                  "ZWN0cm9uaWNLZXlSZXNwb25zZRJ6ChNDYW5jZWxFbGVjdHJvbmljS2V5EjAu",
                  "c2FsdG8ubmVidWxhLnVzZXIudjEuQ2FuY2VsRWxlY3Ryb25pY0tleVJlcXVl",
                  "c3QaMS5zYWx0by5uZWJ1bGEudXNlci52MS5DYW5jZWxFbGVjdHJvbmljS2V5",
                  "UmVzcG9uc2USaAoTRW5jb2RlRWxlY3Ryb25pY0tleRIwLnNhbHRvLm5lYnVs",
                  "YS51c2VyLnYxLkVuY29kZUVsZWN0cm9uaWNLZXlSZXF1ZXN0Gh8uc2FsdG8u",
                  "bG9uZ3J1bm5pbmcudjEuT3BlcmF0aW9uQsgBChxjb20uc2FsdG9hcGlzLm5l",
                  "YnVsYS51c2VyLnYxQglVc2VyUHJvdG9QAVo+Z2l0aHViLmNvbS9zYWx0b2Fw",
                  "aXMtaW50ZXJuYWwvc2FsdG9hcGlzLWdvL25lYnVsYS91c2VyL3YxO3VzZXKq",
                  "AhhTYWx0b2FwaXMuTmVidWxhLlVzZXIuVjHKAhhTYWx0b2FwaXNcTmVidWxh",
                  "XFVzZXJcVjHiAiRHUEJNZXRhZGF0YVxTYWx0b2FwaXNcTmVidWxhXFVzZXJc",
                  "VjFiBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, Longrunning.V1.OperationReflection.Descriptor, Type.ScheduleReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(User), User.Parser, ["Name", "Parent", "GivenName", "FamilyName", "DisplayName", "Email", "ActivateTime", "ExpireTime", "Photo", "PhotoUri", "CardKey", "ElectronicKey", "AppKey", "WalletKey", "Passcode", "Blocked", "Manager"], ["Parent", "FamilyName", "Email", "Photo", "Manager"], null, null, null),
            new(typeof(UserAccessRight), UserAccessRight.Parser, ["Name", "AccessRight", "DisplayName", "Schedules", "EffectiveSchedules", "ActivateTime", "ExpireTime", "Manager"], ["ActivateTime", "ExpireTime", "Manager"], null, null, null),
            new(typeof(CardKey), CardKey.Parser, ["Name", "Uid", "State", "Outdated"], null, [typeof(CardKey.Types.State)], null, null),
            new(typeof(AppKey), AppKey.Parser, ["Name", "State", "Outdated"], null, [typeof(AppKey.Types.State)], null, null),
            new(typeof(WalletKey), WalletKey.Parser, ["Name", "State", "Outdated"], null, [typeof(WalletKey.Types.State)], null, null),
            new(typeof(Passcode), Passcode.Parser, ["Name", "State"], null, [typeof(Passcode.Types.State)], null, null),
            new(typeof(ElectronicKey), ElectronicKey.Parser, ["Name", "DeviceId", "State", "Outdated"], null, [typeof(ElectronicKey.Types.State)], null, null),
            new(typeof(CreateUserRequest), CreateUserRequest.Parser, ["Parent", "UserId", "User"], ["UserId"], null, null, null),
            new(typeof(GetUserRequest), GetUserRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(BatchGetUsersRequest), BatchGetUsersRequest.Parser, ["Parent", "Names"], null, null, null, null),
            new(typeof(BatchGetUsersResponse), BatchGetUsersResponse.Parser, ["Users"], null, null, null, null),
            new(typeof(ListUsersRequest), ListUsersRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListUsersResponse), ListUsersResponse.Parser, ["Users", "NextPageToken", "TotalSize"], null, null, null, null),
            new(typeof(UpdateUserRequest), UpdateUserRequest.Parser, ["User", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteUserRequest), DeleteUserRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(BlockUserRequest), BlockUserRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(BlockUserResponse), BlockUserResponse.Parser, null, null, null, null, null),
            new(typeof(UnblockUserRequest), UnblockUserRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(UnblockUserResponse), UnblockUserResponse.Parser, null, null, null, null, null),
            new(typeof(CreateUserAccessRightRequest), CreateUserAccessRightRequest.Parser, ["Parent", "UserAccessRight"], null, null, null, null),
            new(typeof(GetUserAccessRightRequest), GetUserAccessRightRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListUserAccessRightsRequest), ListUserAccessRightsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListUserAccessRightsResponse), ListUserAccessRightsResponse.Parser, ["UserAccessRights", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateUserAccessRightRequest), UpdateUserAccessRightRequest.Parser, ["UserAccessRight", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteUserAccessRightRequest), DeleteUserAccessRightRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(AssignCardKeyRequest), AssignCardKeyRequest.Parser, ["Name", "Uid"], null, null, null, null),
            new(typeof(CancelCardKeyRequest), CancelCardKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(EncodeCardKeyRequest), EncodeCardKeyRequest.Parser, ["Name", "Encoder", "ElectronicLock", "Controller"], ["Device"], null, null, null),
            new(typeof(EncodeCardKeyResponse), EncodeCardKeyResponse.Parser, null, null, null, null, null),
            new(typeof(EncodeCardKeyMetadata), EncodeCardKeyMetadata.Parser, null, null, null, null, null),
            new(typeof(AssignAppKeyRequest), AssignAppKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(CancelAppKeyRequest), CancelAppKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ComputeAppKeyDataRequest), ComputeAppKeyDataRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ComputeAppKeyDataResponse), ComputeAppKeyDataResponse.Parser, ["Data"], null, null, null, null),
            new(typeof(AssignWalletKeyRequest), AssignWalletKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(AssignWalletKeyResponse), AssignWalletKeyResponse.Parser, ["WalletKey", "AccessUri"], null, null, null, null),
            new(typeof(CancelWalletKeyRequest), CancelWalletKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(CancelWalletKeyResponse), CancelWalletKeyResponse.Parser, ["WalletKey"], null, null, null, null),
            new(typeof(AssignPasscodeRequest), AssignPasscodeRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(AssignPasscodeResponse), AssignPasscodeResponse.Parser, ["Passcode", "Value"], null, null, null, null),
            new(typeof(CancelPasscodeRequest), CancelPasscodeRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(CancelPasscodeResponse), CancelPasscodeResponse.Parser, ["Passcode"], null, null, null, null),
            new(typeof(AssignElectronicKeyRequest), AssignElectronicKeyRequest.Parser, ["Name", "DeviceId"], null, null, null, null),
            new(typeof(AssignElectronicKeyResponse), AssignElectronicKeyResponse.Parser, ["ElectronicKey"], null, null, null, null),
            new(typeof(CancelElectronicKeyRequest), CancelElectronicKeyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(CancelElectronicKeyResponse), CancelElectronicKeyResponse.Parser, ["ElectronicKey"], null, null, null, null),
            new(typeof(EncodeElectronicKeyRequest), EncodeElectronicKeyRequest.Parser, ["Name", "Encoder", "ElectronicLock", "Controller"], ["Device"], null, null, null),
            new(typeof(EncodeElectronicKeyResponse), EncodeElectronicKeyResponse.Parser, null, null, null, null, null),
            new(typeof(EncodeElectronicKeyMetadata), EncodeElectronicKeyMetadata.Parser, null, null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// The user object
    /// </summary>
    public sealed partial class User : IMessage<User>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<User> _parser = new(() => new User());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<User> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public User()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public User(User other) : this()
        {
            name_ = other.name_;
            parent_ = other.parent_;
            givenName_ = other.givenName_;
            familyName_ = other.familyName_;
            displayName_ = other.displayName_;
            email_ = other.email_;
            activateTime_ = other.activateTime_?.Clone();
            expireTime_ = other.expireTime_?.Clone();
            photo_ = other.photo_;
            photoUri_ = other.photoUri_;
            cardKey_ = other.cardKey_?.Clone();
            electronicKey_ = other.electronicKey_?.Clone();
            appKey_ = other.appKey_?.Clone();
            walletKey_ = other.walletKey_?.Clone();
            passcode_ = other.passcode_?.Clone();
            blocked_ = other.blocked_;
            manager_ = other.manager_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public User Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the user. It must have the format of
        /// `installations/*/users/*`. For example:
        /// `installations/surelock-homes-hq/users/john-watson`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 2;
        private readonly static string ParentDefaultValue = "";

        private string parent_;

        /// <summary>
        /// The name of the parent user of this user.
        /// Only users who have had keys shared with them will have this field set.
        /// </summary>
        public string Parent
        {
            get { return parent_ ?? ParentDefaultValue; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "parent" field is set</summary>
        public bool HasParent
        {
            get { return parent_ != null; }
        }

        /// <summary>Clears the value of the "parent" field</summary>
        public void ClearParent()
        {
            parent_ = null;
        }

        /// <summary>Field number for the "given_name" field.</summary>
        public const int GivenNameFieldNumber = 3;
        private string givenName_ = "";

        /// <summary>
        /// The personal name, forename or given name ("first name"). It could
        /// also contain a middle name. First name is not used because the given
        /// name is not placed first in some cultures.
        /// </summary>
        public string GivenName
        {
            get { return givenName_; }
            set
            {
                givenName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "family_name" field.</summary>
        public const int FamilyNameFieldNumber = 4;
        private readonly static string FamilyNameDefaultValue = "";

        private string familyName_;

        /// <summary>
        /// The surname or family name ("last name"). It could also contain more than
        /// one surname so that both matrilineal and patrilineal surnames can be
        /// included in one place. Last name is not used because the family name is
        /// not placed last in some cultures.
        /// </summary>
        public string FamilyName
        {
            get { return familyName_ ?? FamilyNameDefaultValue; }
            set
            {
                familyName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "family_name" field is set</summary>
        public bool HasFamilyName
        {
            get { return familyName_ != null; }
        }

        /// <summary>Clears the value of the "family_name" field</summary>
        public void ClearFamilyName()
        {
            familyName_ = null;
        }

        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 5;
        private string displayName_ = "";

        /// <summary>
        /// The display name of the user, formed by concatenating the first and last
        /// name values.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "email" field.</summary>
        public const int EmailFieldNumber = 6;
        private readonly static string EmailDefaultValue = "";

        private string email_;

        /// <summary>
        /// Email address.
        /// </summary>
        public string Email
        {
            get { return email_ ?? EmailDefaultValue; }
            set
            {
                email_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "email" field is set</summary>
        public bool HasEmail
        {
            get { return email_ != null; }
        }

        /// <summary>Clears the value of the "email" field</summary>
        public void ClearEmail()
        {
            email_ = null;
        }

        /// <summary>Field number for the "activate_time" field.</summary>
        public const int ActivateTimeFieldNumber = 7;
        private Google.Protobuf.WellKnownTypes.Timestamp activateTime_;

        /// <summary>
        /// Activation time independent of any time zone or calendar.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp ActivateTime
        {
            get { return activateTime_; }
            set
            {
                activateTime_ = value;
            }
        }

        /// <summary>Field number for the "expire_time" field.</summary>
        public const int ExpireTimeFieldNumber = 8;
        private Google.Protobuf.WellKnownTypes.Timestamp expireTime_;

        /// <summary>
        /// Expiration time independent of any time zone or calendar.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp ExpireTime
        {
            get { return expireTime_; }
            set
            {
                expireTime_ = value;
            }
        }

        /// <summary>Field number for the "photo" field.</summary>
        public const int PhotoFieldNumber = 9;
        private readonly static string PhotoDefaultValue = "";

        private string photo_;

        /// <summary>
        /// The file resource name for the user photo. It must have the
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
        public const int PhotoUriFieldNumber = 10;
        private string photoUri_ = "";

        /// <summary>
        /// The URI to view the user photo.
        /// </summary>
        public string PhotoUri
        {
            get { return photoUri_; }
            set
            {
                photoUri_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "card_key" field.</summary>
        public const int CardKeyFieldNumber = 11;
        private CardKey cardKey_;

        /// <summary>
        /// The card key resource that belongs to the user.
        /// </summary>
        public CardKey CardKey
        {
            get { return cardKey_; }
            set
            {
                cardKey_ = value;
            }
        }

        /// <summary>Field number for the "electronic_key" field.</summary>
        public const int ElectronicKeyFieldNumber = 16;
        private ElectronicKey electronicKey_;

        /// <summary>
        /// The electronic key resource that belongs to the user.
        /// </summary>
        public ElectronicKey ElectronicKey
        {
            get { return electronicKey_; }
            set
            {
                electronicKey_ = value;
            }
        }

        /// <summary>Field number for the "app_key" field.</summary>
        public const int AppKeyFieldNumber = 12;
        private AppKey appKey_;

        /// <summary>
        /// The app key resource that belongs to the user.
        /// </summary>
        public AppKey AppKey
        {
            get { return appKey_; }
            set
            {
                appKey_ = value;
            }
        }

        /// <summary>Field number for the "wallet_key" field.</summary>
        public const int WalletKeyFieldNumber = 13;
        private WalletKey walletKey_;

        /// <summary>
        /// The wallet key resource that belongs to the user.
        /// </summary>
        public WalletKey WalletKey
        {
            get { return walletKey_; }
            set
            {
                walletKey_ = value;
            }
        }

        /// <summary>Field number for the "passcode" field.</summary>
        public const int PasscodeFieldNumber = 15;
        private Passcode passcode_;

        /// <summary>
        /// The passcode resource that belongs to the user.
        /// </summary>
        public Passcode Passcode
        {
            get { return passcode_; }
            set
            {
                passcode_ = value;
            }
        }

        /// <summary>Field number for the "blocked" field.</summary>
        public const int BlockedFieldNumber = 14;
        private bool blocked_;

        /// <summary>
        /// Indicates whether this user is blocked or not. A blocked user cannot
        /// perform any admin actions, that is, if they have a management role this
        /// will no longer be valid. If the user has a key then it will no longer
        /// unlock access points.
        /// </summary>
        public bool Blocked
        {
            get { return blocked_; }
            set
            {
                blocked_ = value;
            }
        }

        /// <summary>Field number for the "manager" field.</summary>
        public const int ManagerFieldNumber = 17;
        private readonly static string ManagerDefaultValue = "";

        private string manager_;

        /// <summary>
        /// The resource name of the manager resource that owns this user. A manager
        /// resource is any resource (such as a booking) that creates and governs the
        /// lifecycle of this user.
        ///
        /// Example: "installations/surelock-homes-hq/bookings/watson-family-booking"
        ///
        /// If set, this user is considered "managed" and cannot be modified directly.
        /// It behaves as a side-effect of the manager resource.
        /// </summary>
        public string Manager
        {
            get { return manager_ ?? ManagerDefaultValue; }
            set
            {
                manager_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "manager" field is set</summary>
        public bool HasManager
        {
            get { return manager_ != null; }
        }

        /// <summary>Clears the value of the "manager" field</summary>
        public void ClearManager()
        {
            manager_ = null;
        }

        public override bool Equals(object other) => Equals(other as User);
        public bool Equals(User other)
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
            if (Parent != other.Parent) return false;
            if (GivenName != other.GivenName) return false;
            if (FamilyName != other.FamilyName) return false;
            if (DisplayName != other.DisplayName) return false;
            if (Email != other.Email) return false;
            if (!Equals(ActivateTime, other.ActivateTime)) return false;
            if (!Equals(ExpireTime, other.ExpireTime)) return false;
            if (Photo != other.Photo) return false;
            if (PhotoUri != other.PhotoUri) return false;
            if (!Equals(CardKey, other.CardKey)) return false;
            if (!Equals(ElectronicKey, other.ElectronicKey)) return false;
            if (!Equals(AppKey, other.AppKey)) return false;
            if (!Equals(WalletKey, other.WalletKey)) return false;
            if (!Equals(Passcode, other.Passcode)) return false;
            if (Blocked != other.Blocked) return false;
            if (Manager != other.Manager) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (HasParent) hash ^= Parent.GetHashCode();
            if (GivenName.Length != 0) hash ^= GivenName.GetHashCode();
            if (HasFamilyName) hash ^= FamilyName.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            if (HasEmail) hash ^= Email.GetHashCode();
            if (activateTime_ != null) hash ^= ActivateTime.GetHashCode();
            if (expireTime_ != null) hash ^= ExpireTime.GetHashCode();
            if (HasPhoto) hash ^= Photo.GetHashCode();
            if (PhotoUri.Length != 0) hash ^= PhotoUri.GetHashCode();
            if (cardKey_ != null) hash ^= CardKey.GetHashCode();
            if (electronicKey_ != null) hash ^= ElectronicKey.GetHashCode();
            if (appKey_ != null) hash ^= AppKey.GetHashCode();
            if (walletKey_ != null) hash ^= WalletKey.GetHashCode();
            if (passcode_ != null) hash ^= Passcode.GetHashCode();
            if (Blocked != false) hash ^= Blocked.GetHashCode();
            if (HasManager) hash ^= Manager.GetHashCode();
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
      if (HasParent) {
        output.WriteRawTag(18);
        output.WriteString(Parent);
      }
      if (GivenName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(GivenName);
      }
      if (HasFamilyName) {
        output.WriteRawTag(34);
        output.WriteString(FamilyName);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(DisplayName);
      }
      if (HasEmail) {
        output.WriteRawTag(50);
        output.WriteString(Email);
      }
      if (activateTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ActivateTime);
      }
      if (expireTime_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ExpireTime);
      }
      if (HasPhoto) {
        output.WriteRawTag(74);
        output.WriteString(Photo);
      }
      if (PhotoUri.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(PhotoUri);
      }
      if (cardKey_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CardKey);
      }
      if (appKey_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(AppKey);
      }
      if (walletKey_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(WalletKey);
      }
      if (Blocked != false) {
        output.WriteRawTag(112);
        output.WriteBool(Blocked);
      }
      if (passcode_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Passcode);
      }
      if (electronicKey_ != null) {
        output.WriteRawTag(130, 1);
        output.WriteMessage(ElectronicKey);
      }
      if (HasManager) {
        output.WriteRawTag(138, 1);
        output.WriteString(Manager);
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
            if (HasParent)
            {
                output.WriteRawTag(18);
                output.WriteString(Parent);
            }
            if (GivenName.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(GivenName);
            }
            if (HasFamilyName)
            {
                output.WriteRawTag(34);
                output.WriteString(FamilyName);
            }
            if (DisplayName.Length != 0)
            {
                output.WriteRawTag(42);
                output.WriteString(DisplayName);
            }
            if (HasEmail)
            {
                output.WriteRawTag(50);
                output.WriteString(Email);
            }
            if (activateTime_ != null)
            {
                output.WriteRawTag(58);
                output.WriteMessage(ActivateTime);
            }
            if (expireTime_ != null)
            {
                output.WriteRawTag(66);
                output.WriteMessage(ExpireTime);
            }
            if (HasPhoto)
            {
                output.WriteRawTag(74);
                output.WriteString(Photo);
            }
            if (PhotoUri.Length != 0)
            {
                output.WriteRawTag(82);
                output.WriteString(PhotoUri);
            }
            if (cardKey_ != null)
            {
                output.WriteRawTag(90);
                output.WriteMessage(CardKey);
            }
            if (appKey_ != null)
            {
                output.WriteRawTag(98);
                output.WriteMessage(AppKey);
            }
            if (walletKey_ != null)
            {
                output.WriteRawTag(106);
                output.WriteMessage(WalletKey);
            }
            if (Blocked != false)
            {
                output.WriteRawTag(112);
                output.WriteBool(Blocked);
            }
            if (passcode_ != null)
            {
                output.WriteRawTag(122);
                output.WriteMessage(Passcode);
            }
            if (electronicKey_ != null)
            {
                output.WriteRawTag(130, 1);
                output.WriteMessage(ElectronicKey);
            }
            if (HasManager)
            {
                output.WriteRawTag(138, 1);
                output.WriteString(Manager);
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
            if (HasParent)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            }
            if (GivenName.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(GivenName);
            }
            if (HasFamilyName)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(FamilyName);
            }
            if (DisplayName.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            }
            if (HasEmail)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Email);
            }
            if (activateTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(ActivateTime);
            }
            if (expireTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(ExpireTime);
            }
            if (HasPhoto)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Photo);
            }
            if (PhotoUri.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(PhotoUri);
            }
            if (cardKey_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(CardKey);
            }
            if (electronicKey_ != null)
            {
                size += 2 + CodedOutputStream.ComputeMessageSize(ElectronicKey);
            }
            if (appKey_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(AppKey);
            }
            if (walletKey_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(WalletKey);
            }
            if (passcode_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Passcode);
            }
            if (Blocked != false)
            {
                size += 1 + 1;
            }
            if (HasManager)
            {
                size += 2 + CodedOutputStream.ComputeStringSize(Manager);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(User other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.HasParent)
            {
                Parent = other.Parent;
            }
            if (other.GivenName.Length != 0)
            {
                GivenName = other.GivenName;
            }
            if (other.HasFamilyName)
            {
                FamilyName = other.FamilyName;
            }
            if (other.DisplayName.Length != 0)
            {
                DisplayName = other.DisplayName;
            }
            if (other.HasEmail)
            {
                Email = other.Email;
            }
            if (other.activateTime_ != null)
            {
                if (activateTime_ == null)
                {
                    ActivateTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                ActivateTime.MergeFrom(other.ActivateTime);
            }
            if (other.expireTime_ != null)
            {
                if (expireTime_ == null)
                {
                    ExpireTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                ExpireTime.MergeFrom(other.ExpireTime);
            }
            if (other.HasPhoto)
            {
                Photo = other.Photo;
            }
            if (other.PhotoUri.Length != 0)
            {
                PhotoUri = other.PhotoUri;
            }
            if (other.cardKey_ != null)
            {
                if (cardKey_ == null)
                {
                    CardKey = new CardKey();
                }
                CardKey.MergeFrom(other.CardKey);
            }
            if (other.electronicKey_ != null)
            {
                if (electronicKey_ == null)
                {
                    ElectronicKey = new ElectronicKey();
                }
                ElectronicKey.MergeFrom(other.ElectronicKey);
            }
            if (other.appKey_ != null)
            {
                if (appKey_ == null)
                {
                    AppKey = new AppKey();
                }
                AppKey.MergeFrom(other.AppKey);
            }
            if (other.walletKey_ != null)
            {
                if (walletKey_ == null)
                {
                    WalletKey = new WalletKey();
                }
                WalletKey.MergeFrom(other.WalletKey);
            }
            if (other.passcode_ != null)
            {
                if (passcode_ == null)
                {
                    Passcode = new Passcode();
                }
                Passcode.MergeFrom(other.Passcode);
            }
            if (other.Blocked != false)
            {
                Blocked = other.Blocked;
            }
            if (other.HasManager)
            {
                Manager = other.Manager;
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
            Parent = input.ReadString();
            break;
          }
          case 26: {
            GivenName = input.ReadString();
            break;
          }
          case 34: {
            FamilyName = input.ReadString();
            break;
          }
          case 42: {
            DisplayName = input.ReadString();
            break;
          }
          case 50: {
            Email = input.ReadString();
            break;
          }
          case 58: {
            if (activateTime_ == null) {
              ActivateTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ActivateTime);
            break;
          }
          case 66: {
            if (expireTime_ == null) {
              ExpireTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ExpireTime);
            break;
          }
          case 74: {
            Photo = input.ReadString();
            break;
          }
          case 82: {
            PhotoUri = input.ReadString();
            break;
          }
          case 90: {
            if (cardKey_ == null) {
              CardKey = new Saltoapis.Nebula.User.V1.CardKey();
            }
            input.ReadMessage(CardKey);
            break;
          }
          case 98: {
            if (appKey_ == null) {
              AppKey = new Saltoapis.Nebula.User.V1.AppKey();
            }
            input.ReadMessage(AppKey);
            break;
          }
          case 106: {
            if (walletKey_ == null) {
              WalletKey = new Saltoapis.Nebula.User.V1.WalletKey();
            }
            input.ReadMessage(WalletKey);
            break;
          }
          case 112: {
            Blocked = input.ReadBool();
            break;
          }
          case 122: {
            if (passcode_ == null) {
              Passcode = new Saltoapis.Nebula.User.V1.Passcode();
            }
            input.ReadMessage(Passcode);
            break;
          }
          case 130: {
            if (electronicKey_ == null) {
              ElectronicKey = new Saltoapis.Nebula.User.V1.ElectronicKey();
            }
            input.ReadMessage(ElectronicKey);
            break;
          }
          case 138: {
            Manager = input.ReadString();
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
                            Parent = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            GivenName = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            FamilyName = input.ReadString();
                            break;
                        }
                    case 42:
                        {
                            DisplayName = input.ReadString();
                            break;
                        }
                    case 50:
                        {
                            Email = input.ReadString();
                            break;
                        }
                    case 58:
                        {
                            if (activateTime_ == null)
                            {
                                ActivateTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(ActivateTime);
                            break;
                        }
                    case 66:
                        {
                            if (expireTime_ == null)
                            {
                                ExpireTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(ExpireTime);
                            break;
                        }
                    case 74:
                        {
                            Photo = input.ReadString();
                            break;
                        }
                    case 82:
                        {
                            PhotoUri = input.ReadString();
                            break;
                        }
                    case 90:
                        {
                            if (cardKey_ == null)
                            {
                                CardKey = new CardKey();
                            }
                            input.ReadMessage(CardKey);
                            break;
                        }
                    case 98:
                        {
                            if (appKey_ == null)
                            {
                                AppKey = new AppKey();
                            }
                            input.ReadMessage(AppKey);
                            break;
                        }
                    case 106:
                        {
                            if (walletKey_ == null)
                            {
                                WalletKey = new WalletKey();
                            }
                            input.ReadMessage(WalletKey);
                            break;
                        }
                    case 112:
                        {
                            Blocked = input.ReadBool();
                            break;
                        }
                    case 122:
                        {
                            if (passcode_ == null)
                            {
                                Passcode = new Passcode();
                            }
                            input.ReadMessage(Passcode);
                            break;
                        }
                    case 130:
                        {
                            if (electronicKey_ == null)
                            {
                                ElectronicKey = new ElectronicKey();
                            }
                            input.ReadMessage(ElectronicKey);
                            break;
                        }
                    case 138:
                        {
                            Manager = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The user's access right association
    /// </summary>
    public sealed partial class UserAccessRight : IMessage<UserAccessRight>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UserAccessRight> _parser = new(() => new UserAccessRight());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UserAccessRight> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UserAccessRight()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UserAccessRight(UserAccessRight other) : this()
        {
            name_ = other.name_;
            accessRight_ = other.accessRight_;
            displayName_ = other.displayName_;
            schedules_ = other.schedules_.Clone();
            effectiveSchedules_ = other.effectiveSchedules_.Clone();
            activateTime_ = other.activateTime_?.Clone();
            expireTime_ = other.expireTime_?.Clone();
            manager_ = other.manager_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UserAccessRight Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the user's access right association. It
        /// must have the format of `installations/*/users/*/access-rights/*`. For
        /// example:
        /// `installations/surelock-homes-hq/users/john-watson/access-rights/baskerville`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "access_right" field.</summary>
        public const int AccessRightFieldNumber = 2;
        private string accessRight_ = "";

        /// <summary>
        /// The access right resource name to bind as an association to the parent
        /// access point. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville`.
        /// </summary>
        public string AccessRight
        {
            get { return accessRight_; }
            set
            {
                accessRight_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 3;
        private string displayName_ = "";

        /// <summary>
        /// Display name of the associated entity. In this case an access right.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "schedules" field.</summary>
        public const int SchedulesFieldNumber = 4;
        private static readonly FieldCodec<Type.Schedule> _repeated_schedules_codec
            = FieldCodec.ForMessage(34, Type.Schedule.Parser);
        private readonly RepeatedField<Type.Schedule> schedules_ = [];

        /// <summary>
        /// The schedules for the user's access right. If set, this can only be more
        /// restrictive than the schedules defined in the associated access right.
        /// </summary>
        public RepeatedField<Type.Schedule> Schedules
        {
            get { return schedules_; }
        }

        /// <summary>Field number for the "effective_schedules" field.</summary>
        public const int EffectiveSchedulesFieldNumber = 5;
        private static readonly FieldCodec<Type.Schedule> _repeated_effectiveSchedules_codec
            = FieldCodec.ForMessage(42, Type.Schedule.Parser);
        private readonly RepeatedField<Type.Schedule> effectiveSchedules_ = [];

        /// <summary>
        /// The computed effective schedules for the user's access right based on the
        /// given parent resource.
        /// </summary>
        public RepeatedField<Type.Schedule> EffectiveSchedules
        {
            get { return effectiveSchedules_; }
        }

        /// <summary>Field number for the "activate_time" field.</summary>
        public const int ActivateTimeFieldNumber = 6;
        private Google.Protobuf.WellKnownTypes.Timestamp activateTime_;

        /// <summary>
        /// Activation time independent of any time zone or calendar.
        /// User access right's association activation time rules:
        /// 1. Activation time must be specified in multiples of 10 minutes.
        ///    Valid examples: 07:40, 12:30, 18:10. Invalid examples: 12:32, 10:15.
        /// 2. If no activation time is provided, the current time is used, truncated to the nearest earlier multiple of 10 minutes.
        ///    For example, if the current time is 14:46, the system will use 14:40.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp ActivateTime
        {
            get { return activateTime_; }
            set
            {
                activateTime_ = value;
            }
        }

        /// <summary>Field number for the "expire_time" field.</summary>
        public const int ExpireTimeFieldNumber = 7;
        private Google.Protobuf.WellKnownTypes.Timestamp expireTime_;

        /// <summary>
        /// Expiration time independent of any time zone or calendar.
        /// User access right's association expiration time rules:
        /// 1. Expiration time must be specified in multiples of 10 minutes.
        ///    Valid examples: 07:40, 12:30, 18:10. Invalid examples: 12:32, 10:15.
        /// 2. When specifying expiration time, it must:
        ///    - Be at least 10 minutes after activation time.
        ///    - Always be a multiple of 10 minutes. The system does not round or adjust expiration time for you.
        ///      For example, if you attempt to set 10:15, the system will reject it.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp ExpireTime
        {
            get { return expireTime_; }
            set
            {
                expireTime_ = value;
            }
        }

        /// <summary>Field number for the "manager" field.</summary>
        public const int ManagerFieldNumber = 8;
        private readonly static string ManagerDefaultValue = "";

        private string manager_;

        /// <summary>
        /// The resource name of the manager resource that owns this user access right. A manager
        /// resource is any resource (such as a booking) that creates and governs the
        /// lifecycle of this user access right.
        ///
        /// Example: "installations/surelock-homes-hq/bookings/watson-family-booking"
        ///
        /// If set, this user access right is considered "managed" and cannot be modified directly.
        /// It behaves as a side-effect of the manager resource.
        /// </summary>
        public string Manager
        {
            get { return manager_ ?? ManagerDefaultValue; }
            set
            {
                manager_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "manager" field is set</summary>
        public bool HasManager
        {
            get { return manager_ != null; }
        }

        /// <summary>Clears the value of the "manager" field</summary>
        public void ClearManager()
        {
            manager_ = null;
        }

        public override bool Equals(object other) => Equals(other as UserAccessRight);
        public bool Equals(UserAccessRight other)
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
            if (AccessRight != other.AccessRight) return false;
            if (DisplayName != other.DisplayName) return false;
            if (!schedules_.Equals(other.schedules_)) return false;
            if (!effectiveSchedules_.Equals(other.effectiveSchedules_)) return false;
            if (!Equals(ActivateTime, other.ActivateTime)) return false;
            if (!Equals(ExpireTime, other.ExpireTime)) return false;
            if (Manager != other.Manager) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (AccessRight.Length != 0) hash ^= AccessRight.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            hash ^= schedules_.GetHashCode();
            hash ^= effectiveSchedules_.GetHashCode();
            if (activateTime_ != null) hash ^= ActivateTime.GetHashCode();
            if (expireTime_ != null) hash ^= ExpireTime.GetHashCode();
            if (HasManager) hash ^= Manager.GetHashCode();
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
      if (AccessRight.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AccessRight);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DisplayName);
      }
      schedules_.WriteTo(output, _repeated_schedules_codec);
      effectiveSchedules_.WriteTo(output, _repeated_effectiveSchedules_codec);
      if (activateTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ActivateTime);
      }
      if (expireTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ExpireTime);
      }
      if (HasManager) {
        output.WriteRawTag(66);
        output.WriteString(Manager);
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
            if (AccessRight.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(AccessRight);
            }
            if (DisplayName.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(DisplayName);
            }
            schedules_.WriteTo(ref output, _repeated_schedules_codec);
            effectiveSchedules_.WriteTo(ref output, _repeated_effectiveSchedules_codec);
            if (activateTime_ != null)
            {
                output.WriteRawTag(50);
                output.WriteMessage(ActivateTime);
            }
            if (expireTime_ != null)
            {
                output.WriteRawTag(58);
                output.WriteMessage(ExpireTime);
            }
            if (HasManager)
            {
                output.WriteRawTag(66);
                output.WriteString(Manager);
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
            if (AccessRight.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(AccessRight);
            }
            if (DisplayName.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            }
            size += schedules_.CalculateSize(_repeated_schedules_codec);
            size += effectiveSchedules_.CalculateSize(_repeated_effectiveSchedules_codec);
            if (activateTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(ActivateTime);
            }
            if (expireTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(ExpireTime);
            }
            if (HasManager)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Manager);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UserAccessRight other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.AccessRight.Length != 0)
            {
                AccessRight = other.AccessRight;
            }
            if (other.DisplayName.Length != 0)
            {
                DisplayName = other.DisplayName;
            }
            schedules_.Add(other.schedules_);
            effectiveSchedules_.Add(other.effectiveSchedules_);
            if (other.activateTime_ != null)
            {
                if (activateTime_ == null)
                {
                    ActivateTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                ActivateTime.MergeFrom(other.ActivateTime);
            }
            if (other.expireTime_ != null)
            {
                if (expireTime_ == null)
                {
                    ExpireTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                ExpireTime.MergeFrom(other.ExpireTime);
            }
            if (other.HasManager)
            {
                Manager = other.Manager;
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
            AccessRight = input.ReadString();
            break;
          }
          case 26: {
            DisplayName = input.ReadString();
            break;
          }
          case 34: {
            schedules_.AddEntriesFrom(input, _repeated_schedules_codec);
            break;
          }
          case 42: {
            effectiveSchedules_.AddEntriesFrom(input, _repeated_effectiveSchedules_codec);
            break;
          }
          case 50: {
            if (activateTime_ == null) {
              ActivateTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ActivateTime);
            break;
          }
          case 58: {
            if (expireTime_ == null) {
              ExpireTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ExpireTime);
            break;
          }
          case 66: {
            Manager = input.ReadString();
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
                            AccessRight = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            DisplayName = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            schedules_.AddEntriesFrom(ref input, _repeated_schedules_codec);
                            break;
                        }
                    case 42:
                        {
                            effectiveSchedules_.AddEntriesFrom(ref input, _repeated_effectiveSchedules_codec);
                            break;
                        }
                    case 50:
                        {
                            if (activateTime_ == null)
                            {
                                ActivateTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(ActivateTime);
                            break;
                        }
                    case 58:
                        {
                            if (expireTime_ == null)
                            {
                                ExpireTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(ExpireTime);
                            break;
                        }
                    case 66:
                        {
                            Manager = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Representation of a card key, belonging to a user
    /// </summary>
    public sealed partial class CardKey : IMessage<CardKey>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CardKey> _parser = new(() => new CardKey());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CardKey> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CardKey()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CardKey(CardKey other) : this()
        {
            name_ = other.name_;
            uid_ = other.uid_;
            state_ = other.state_;
            outdated_ = other.outdated_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CardKey Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the user's card key. It must have the
        /// format of `installations/*/users/*/card-key`. For example:
        /// `installations/surelock-homes-hq/users/john-watson/card-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "uid" field.</summary>
        public const int UidFieldNumber = 2;
        private string uid_ = "";

        /// <summary>
        /// Unique identifier of the physical card. Length dependent of technology.
        /// Max length for ISO14443-3 is 10 bytes.
        /// </summary>
        public string Uid
        {
            get { return uid_; }
            set
            {
                uid_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "state" field.</summary>
        public const int StateFieldNumber = 3;
        private Types.State state_ = Types.State.Unspecified;

        /// <summary>
        /// Indicates whether this card key has been assigned, not assigned or is
        /// active and ready for use. This field cannot be modified using a standard
        /// [`UpdateCardKey`][salto.nebula.user.v1.UserService.UpdateCardKey]
        /// operation. To change the value of this field, you must call
        /// [`EncodeCardKey`][salto.nebula.user.v1.UserService.EncodeCardKey].
        ///
        /// If the value is `NOT_ASSIGNED` it also applies to cases where the
        /// assignation process has been initiated, but not completed.
        /// </summary>
        public Types.State State
        {
            get { return state_; }
            set
            {
                state_ = value;
            }
        }

        /// <summary>Field number for the "outdated" field.</summary>
        public const int OutdatedFieldNumber = 4;
        private bool outdated_;

        /// <summary>
        /// Indicates whether this card key has pending updates or not.
        /// This field cannot be modified using a standard
        /// [`UpdateCardKey`][salto.nebula.user.v1.UserService.UpdateCardKey]
        /// operation. To change the value of this field, you must call
        /// [`OutdateCardKey`][salto.nebula.user.v1.UserService.OutdateCardKey].
        /// </summary>
        public bool Outdated
        {
            get { return outdated_; }
            set
            {
                outdated_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CardKey);
        public bool Equals(CardKey other)
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
            if (Uid != other.Uid) return false;
            if (State != other.State) return false;
            if (Outdated != other.Outdated) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (Uid.Length != 0) hash ^= Uid.GetHashCode();
            if (State != Types.State.Unspecified) hash ^= State.GetHashCode();
            if (Outdated != false) hash ^= Outdated.GetHashCode();
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
      if (Uid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Uid);
      }
      if (State != Saltoapis.Nebula.User.V1.CardKey.Types.State.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) State);
      }
      if (Outdated != false) {
        output.WriteRawTag(32);
        output.WriteBool(Outdated);
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
            if (Uid.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Uid);
            }
            if (State != Types.State.Unspecified)
            {
                output.WriteRawTag(24);
                output.WriteEnum((int)State);
            }
            if (Outdated != false)
            {
                output.WriteRawTag(32);
                output.WriteBool(Outdated);
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
            if (Uid.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Uid);
            }
            if (State != Types.State.Unspecified)
            {
                size += 1 + CodedOutputStream.ComputeEnumSize((int)State);
            }
            if (Outdated != false)
            {
                size += 1 + 1;
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CardKey other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.Uid.Length != 0)
            {
                Uid = other.Uid;
            }
            if (other.State != Types.State.Unspecified)
            {
                State = other.State;
            }
            if (other.Outdated != false)
            {
                Outdated = other.Outdated;
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
            Uid = input.ReadString();
            break;
          }
          case 24: {
            State = (Saltoapis.Nebula.User.V1.CardKey.Types.State) input.ReadEnum();
            break;
          }
          case 32: {
            Outdated = input.ReadBool();
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
                            Uid = input.ReadString();
                            break;
                        }
                    case 24:
                        {
                            State = (Types.State)input.ReadEnum();
                            break;
                        }
                    case 32:
                        {
                            Outdated = input.ReadBool();
                            break;
                        }
                }
            }
        }
#endif

        #region Nested types
        /// <summary>Container for nested types declared in the CardKey message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// State for a card key.
            /// </summary>
            public enum State
            {
                /// <summary>
                /// Sentinel value used to indicate that the state is unknown, omitted,
                /// or is not applicable.
                /// </summary>
                [OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
                /// <summary>
                /// The card key is not assigned to a physical card.
                /// </summary>
                [OriginalName("NOT_ASSIGNED")] NotAssigned = 1,
                /// <summary>
                /// The card key is pending activation.
                /// </summary>
                [OriginalName("PENDING")] Pending = 2,
                /// <summary>
                /// The card key is active and ready to be used.
                /// </summary>
                [OriginalName("ACTIVE")] Active = 3,
            }

        }
        #endregion

    }

    /// <summary>
    /// Representation of an app key, belonging to a user
    /// </summary>
    public sealed partial class AppKey : IMessage<AppKey>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AppKey> _parser = new(() => new AppKey());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AppKey> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AppKey()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AppKey(AppKey other) : this()
        {
            name_ = other.name_;
            state_ = other.state_;
            outdated_ = other.outdated_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AppKey Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the user's app key. It must have the
        /// format of `installations/*/users/*/app-key`. For example:
        /// `installations/surelock-homes-hq/users/john-watson/app-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "state" field.</summary>
        public const int StateFieldNumber = 2;
        private Types.State state_ = Types.State.Unspecified;

        /// <summary>
        /// Indicates whether this app key has been assigned or not. This field
        /// cannot be modified using a standard
        /// [`UpdateAppKey`][salto.nebula.user.v1.UserService.UpdateAppKey]
        /// operation. To change the value of this field, you must call
        /// [`AssignAppKey`][salto.nebula.user.v1.UserService.AssignAppKey].
        /// </summary>
        public Types.State State
        {
            get { return state_; }
            set
            {
                state_ = value;
            }
        }

        /// <summary>Field number for the "outdated" field.</summary>
        public const int OutdatedFieldNumber = 3;
        private bool outdated_;

        /// <summary>
        /// Indicates whether this app key has pending updates or not.
        /// This field cannot be modified using a standard
        /// [`UpdateAppKey`][salto.nebula.user.v1.UserService.UpdateAppKey]
        /// operation. To change the value of this field, you must call
        /// [`OutdateAppKey`][salto.nebula.user.v1.UserService.OutdateAppKey].
        /// </summary>
        public bool Outdated
        {
            get { return outdated_; }
            set
            {
                outdated_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AppKey);
        public bool Equals(AppKey other)
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
            if (State != other.State) return false;
            if (Outdated != other.Outdated) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (State != Types.State.Unspecified) hash ^= State.GetHashCode();
            if (Outdated != false) hash ^= Outdated.GetHashCode();
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
      if (State != Saltoapis.Nebula.User.V1.AppKey.Types.State.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) State);
      }
      if (Outdated != false) {
        output.WriteRawTag(24);
        output.WriteBool(Outdated);
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
            if (State != Types.State.Unspecified)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)State);
            }
            if (Outdated != false)
            {
                output.WriteRawTag(24);
                output.WriteBool(Outdated);
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
            if (State != Types.State.Unspecified)
            {
                size += 1 + CodedOutputStream.ComputeEnumSize((int)State);
            }
            if (Outdated != false)
            {
                size += 1 + 1;
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(AppKey other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.State != Types.State.Unspecified)
            {
                State = other.State;
            }
            if (other.Outdated != false)
            {
                Outdated = other.Outdated;
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
            State = (Saltoapis.Nebula.User.V1.AppKey.Types.State) input.ReadEnum();
            break;
          }
          case 24: {
            Outdated = input.ReadBool();
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
                            State = (Types.State)input.ReadEnum();
                            break;
                        }
                    case 24:
                        {
                            Outdated = input.ReadBool();
                            break;
                        }
                }
            }
        }
#endif

        #region Nested types
        /// <summary>Container for nested types declared in the AppKey message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// State for an app key.
            /// </summary>
            public enum State
            {
                /// <summary>
                /// Sentinel value used to indicate that the state is unknown, omitted,
                /// or is not applicable.
                /// </summary>
                [OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
                /// <summary>
                /// The app key is not assigned.
                /// </summary>
                [OriginalName("NOT_ASSIGNED")] NotAssigned = 1,
                /// <summary>
                /// The app key is pending activation.
                /// </summary>
                [OriginalName("PENDING")] Pending = 2,
                /// <summary>
                /// The app key is active and ready to be used.
                /// </summary>
                [OriginalName("ACTIVE")] Active = 3,
            }

        }
        #endregion

    }

    /// <summary>
    /// Representation of a wallet key, belonging to a user
    /// </summary>
    public sealed partial class WalletKey : IMessage<WalletKey>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<WalletKey> _parser = new(() => new WalletKey());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<WalletKey> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public WalletKey()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public WalletKey(WalletKey other) : this()
        {
            name_ = other.name_;
            state_ = other.state_;
            outdated_ = other.outdated_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public WalletKey Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the user's wallet key. It must have the
        /// format of `installations/*/users/*/wallet-key`. For example:
        /// `installations/surelock-homes-hq/users/john-watson/wallet-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "state" field.</summary>
        public const int StateFieldNumber = 2;
        private Types.State state_ = Types.State.Unspecified;

        /// <summary>
        /// Indicates whether this wallet key has been assigned or not. This field
        /// cannot be modified using a standard
        /// [`UpdateWalletKey`][salto.nebula.user.v1.UserService.UpdateWalletKey]
        /// operation. To change the value of this field, you must call
        /// [`AssignWalletKey`][salto.nebula.user.v1.UserService.AssignWalletKey].
        /// </summary>
        public Types.State State
        {
            get { return state_; }
            set
            {
                state_ = value;
            }
        }

        /// <summary>Field number for the "outdated" field.</summary>
        public const int OutdatedFieldNumber = 3;
        private bool outdated_;

        /// <summary>
        /// Indicates whether this wallet key has pending updates or not.
        /// This field cannot be modified using a standard
        /// [`UpdateWalletKey`][salto.nebula.user.v1.UserService.UpdateWalletKey]
        /// operation. To change the value of this field, you must call
        /// [`OutdateWalletKey`][salto.nebula.user.v1.UserService.OutdateWalletKey].
        /// </summary>
        public bool Outdated
        {
            get { return outdated_; }
            set
            {
                outdated_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as WalletKey);
        public bool Equals(WalletKey other)
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
            if (State != other.State) return false;
            if (Outdated != other.Outdated) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (State != Types.State.Unspecified) hash ^= State.GetHashCode();
            if (Outdated != false) hash ^= Outdated.GetHashCode();
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
      if (State != Saltoapis.Nebula.User.V1.WalletKey.Types.State.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) State);
      }
      if (Outdated != false) {
        output.WriteRawTag(24);
        output.WriteBool(Outdated);
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
            if (State != Types.State.Unspecified)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)State);
            }
            if (Outdated != false)
            {
                output.WriteRawTag(24);
                output.WriteBool(Outdated);
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
            if (State != Types.State.Unspecified)
            {
                size += 1 + CodedOutputStream.ComputeEnumSize((int)State);
            }
            if (Outdated != false)
            {
                size += 1 + 1;
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(WalletKey other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.State != Types.State.Unspecified)
            {
                State = other.State;
            }
            if (other.Outdated != false)
            {
                Outdated = other.Outdated;
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
            State = (Saltoapis.Nebula.User.V1.WalletKey.Types.State) input.ReadEnum();
            break;
          }
          case 24: {
            Outdated = input.ReadBool();
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
                            State = (Types.State)input.ReadEnum();
                            break;
                        }
                    case 24:
                        {
                            Outdated = input.ReadBool();
                            break;
                        }
                }
            }
        }
#endif

        #region Nested types
        /// <summary>Container for nested types declared in the WalletKey message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// State for a wallet key.
            /// </summary>
            public enum State
            {
                /// <summary>
                /// Sentinel value used to indicate that the state is unknown, omitted,
                /// or is not applicable.
                /// </summary>
                [OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
                /// <summary>
                /// The wallet key is not assigned.
                /// </summary>
                [OriginalName("NOT_ASSIGNED")] NotAssigned = 1,
                /// <summary>
                /// The wallet key is pending activation.
                /// </summary>
                [OriginalName("PENDING")] Pending = 2,
                /// <summary>
                /// The wallet key is active and ready to be used.
                /// </summary>
                [OriginalName("ACTIVE")] Active = 3,
            }

        }
        #endregion

    }

    /// <summary>
    /// Representation of a passcode, belonging to a user
    /// </summary>
    public sealed partial class Passcode : IMessage<Passcode>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Passcode> _parser = new(() => new Passcode());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Passcode> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Passcode()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Passcode(Passcode other) : this()
        {
            name_ = other.name_;
            state_ = other.state_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Passcode Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the user's passcode. It must have the
        /// format of `installations/*/users/*/passcode`. For example:
        /// `installations/surelock-homes-hq/users/john-watson/passcode`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "state" field.</summary>
        public const int StateFieldNumber = 2;
        private Types.State state_ = Types.State.Unspecified;

        /// <summary>
        /// Indicates whether this passcode has been assigned, not assigned or is
        /// active and ready for use. This field cannot be modified using a standard
        /// passcode update operation. To change the value of this field, you must
        /// call
        /// [`AssignPasscode`][salto.nebula.user.v1.UserService.AssignPasscode].
        ///
        /// If the value is `NOT_ASSIGNED` it also applies to cases where the
        /// assignation process has been initiated, but not completed.
        /// </summary>
        public Types.State State
        {
            get { return state_; }
            set
            {
                state_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as Passcode);
        public bool Equals(Passcode other)
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
            if (State != other.State) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (State != Saltoapis.Nebula.User.V1.Passcode.Types.State.Unspecified) {
        output.WriteRawTag(16);
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
            if (State != Types.State.Unspecified)
            {
                output.WriteRawTag(16);
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

        public void MergeFrom(Passcode other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
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
          case 16: {
            State = (Saltoapis.Nebula.User.V1.Passcode.Types.State) input.ReadEnum();
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
                            State = (Types.State)input.ReadEnum();
                            break;
                        }
                }
            }
        }
#endif

        #region Nested types
        /// <summary>Container for nested types declared in the Passcode message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// State for a passcode.
            /// </summary>
            public enum State
            {
                /// <summary>
                /// Sentinel value used to indicate that the state is unknown, omitted,
                /// or is not applicable.
                /// </summary>
                [OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
                /// <summary>
                /// The passcode is not assigned.
                /// </summary>
                [OriginalName("NOT_ASSIGNED")] NotAssigned = 1,
                /// <summary>
                /// The passcode is active and ready to be used.
                /// </summary>
                [OriginalName("ACTIVE")] Active = 2,
            }

        }
        #endregion

    }

    /// <summary>
    /// Representation of an electronic key, belonging to a user
    /// </summary>
    public sealed partial class ElectronicKey : IMessage<ElectronicKey>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ElectronicKey> _parser = new(() => new ElectronicKey());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ElectronicKey> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ElectronicKey()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ElectronicKey(ElectronicKey other) : this()
        {
            name_ = other.name_;
            deviceId_ = other.deviceId_;
            state_ = other.state_;
            outdated_ = other.outdated_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ElectronicKey Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the user's electronic key. It must have the
        /// format of `installations/*/users/*/electronic-key`. For example:
        /// `installations/surelock-homes-hq/users/john-watson/electronic-key`.
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
        /// by SALTO.
        /// </summary>
        public string DeviceId
        {
            get { return deviceId_; }
            set
            {
                deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "state" field.</summary>
        public const int StateFieldNumber = 3;
        private Types.State state_ = Types.State.Unspecified;

        /// <summary>
        /// Indicates whether this electronic key has been assigned, not assigned or is
        /// active and ready for use. This field cannot be modified using a standard
        /// [`UpdateElectronicKey`][salto.nebula.user.v1.UserService.UpdateElectronicKey]
        /// operation. To change the value of this field, you must call
        /// [`EncodeElectronicKey`][salto.nebula.user.v1.UserService.EncodeElectronicKey].
        ///
        /// If the value is `NOT_ASSIGNED` it also applies to cases where the
        /// assignation process has been initiated, but not completed.
        /// </summary>
        public Types.State State
        {
            get { return state_; }
            set
            {
                state_ = value;
            }
        }

        /// <summary>Field number for the "outdated" field.</summary>
        public const int OutdatedFieldNumber = 4;
        private bool outdated_;

        /// <summary>
        /// Indicates whether this electronic key has pending updates or not.
        /// This field cannot be modified using a standard
        /// [`UpdateElectronicKey`][salto.nebula.user.v1.UserService.UpdateElectronicKey]
        /// operation. To change the value of this field, you must call
        /// [`OutdateElectronicKey`][salto.nebula.user.v1.UserService.OutdateElectronicKey].
        /// </summary>
        public bool Outdated
        {
            get { return outdated_; }
            set
            {
                outdated_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as ElectronicKey);
        public bool Equals(ElectronicKey other)
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
            if (State != other.State) return false;
            if (Outdated != other.Outdated) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DeviceId.Length != 0) hash ^= DeviceId.GetHashCode();
            if (State != Types.State.Unspecified) hash ^= State.GetHashCode();
            if (Outdated != false) hash ^= Outdated.GetHashCode();
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
      if (State != Saltoapis.Nebula.User.V1.ElectronicKey.Types.State.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) State);
      }
      if (Outdated != false) {
        output.WriteRawTag(32);
        output.WriteBool(Outdated);
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
            if (State != Types.State.Unspecified)
            {
                output.WriteRawTag(24);
                output.WriteEnum((int)State);
            }
            if (Outdated != false)
            {
                output.WriteRawTag(32);
                output.WriteBool(Outdated);
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
            if (State != Types.State.Unspecified)
            {
                size += 1 + CodedOutputStream.ComputeEnumSize((int)State);
            }
            if (Outdated != false)
            {
                size += 1 + 1;
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ElectronicKey other)
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
            if (other.State != Types.State.Unspecified)
            {
                State = other.State;
            }
            if (other.Outdated != false)
            {
                Outdated = other.Outdated;
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
          case 24: {
            State = (Saltoapis.Nebula.User.V1.ElectronicKey.Types.State) input.ReadEnum();
            break;
          }
          case 32: {
            Outdated = input.ReadBool();
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
                    case 24:
                        {
                            State = (Types.State)input.ReadEnum();
                            break;
                        }
                    case 32:
                        {
                            Outdated = input.ReadBool();
                            break;
                        }
                }
            }
        }
#endif

        #region Nested types
        /// <summary>Container for nested types declared in the ElectronicKey message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// State for an electronic key.
            /// </summary>
            public enum State
            {
                /// <summary>
                /// Sentinel value used to indicate that the state is unknown, omitted,
                /// or is not applicable.
                /// </summary>
                [OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
                /// <summary>
                /// The electronic key is not assigned to a physical device.
                /// </summary>
                [OriginalName("NOT_ASSIGNED")] NotAssigned = 1,
                /// <summary>
                /// The electronic key is pending activation.
                /// </summary>
                [OriginalName("PENDING")] Pending = 2,
                /// <summary>
                /// The electronic key is active and ready to be used.
                /// </summary>
                [OriginalName("ACTIVE")] Active = 3,
            }

        }
        #endregion

    }

    /// <summary>
    /// The request message for [`CreateUser`][salto.nebula.user.v1.UserService.CreateUser]
    /// </summary>
    public sealed partial class CreateUserRequest : IMessage<CreateUserRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateUserRequest> _parser = new(() => new CreateUserRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateUserRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateUserRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateUserRequest(CreateUserRequest other) : this()
        {
            parent_ = other.parent_;
            userId_ = other.userId_;
            user_ = other.user_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateUserRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the user is to be created. For
        /// example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "user_id" field.</summary>
        public const int UserIdFieldNumber = 2;
        private readonly static string UserIdDefaultValue = "";

        private string userId_;

        /// <summary>
        /// The user id to use for this user. In case it's empty the server
        /// will autogenerate a unique identifier.
        /// </summary>
        public string UserId
        {
            get { return userId_ ?? UserIdDefaultValue; }
            set
            {
                userId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "user_id" field is set</summary>
        public bool HasUserId
        {
            get { return userId_ != null; }
        }

        /// <summary>Clears the value of the "user_id" field</summary>
        public void ClearUserId()
        {
            userId_ = null;
        }

        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 3;
        private User user_;

        /// <summary>
        /// The user resource to be created. Client must not set the `User.name`
        /// field.
        /// </summary>
        public User User
        {
            get { return user_; }
            set
            {
                user_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateUserRequest);
        public bool Equals(CreateUserRequest other)
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
            if (UserId != other.UserId) return false;
            if (!Equals(User, other.User)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasUserId) hash ^= UserId.GetHashCode();
            if (user_ != null) hash ^= User.GetHashCode();
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
      if (HasUserId) {
        output.WriteRawTag(18);
        output.WriteString(UserId);
      }
      if (user_ != null) {
        output.WriteRawTag(26);
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
            if (Parent.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Parent);
            }
            if (HasUserId)
            {
                output.WriteRawTag(18);
                output.WriteString(UserId);
            }
            if (user_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(User);
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
            if (HasUserId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(UserId);
            }
            if (user_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(User);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateUserRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.HasUserId)
            {
                UserId = other.UserId;
            }
            if (other.user_ != null)
            {
                if (user_ == null)
                {
                    User = new User();
                }
                User.MergeFrom(other.User);
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
            UserId = input.ReadString();
            break;
          }
          case 26: {
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
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
                            UserId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (user_ == null)
                            {
                                User = new User();
                            }
                            input.ReadMessage(User);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetUser`][salto.nebula.user.v1.UserService.GetUser]
    /// </summary>
    public sealed partial class GetUserRequest : IMessage<GetUserRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetUserRequest> _parser = new(() => new GetUserRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetUserRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetUserRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetUserRequest(GetUserRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetUserRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested user resource. For example:
        /// `installations/surelock-homes-hq/users/john-watson`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetUserRequest);
        public bool Equals(GetUserRequest other)
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

        public void MergeFrom(GetUserRequest other)
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
    /// The request message for [`BatchGetUsersRequest`][salto.nebula.accesspoint.v1.UserService.BatchGetUsers]
    /// </summary>
    public sealed partial class BatchGetUsersRequest : IMessage<BatchGetUsersRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchGetUsersRequest> _parser = new(() => new BatchGetUsersRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchGetUsersRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[9]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchGetUsersRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchGetUsersRequest(BatchGetUsersRequest other) : this()
        {
            parent_ = other.parent_;
            names_ = other.names_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchGetUsersRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent of the users to be retreived.
        /// For example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "names" field.</summary>
        public const int NamesFieldNumber = 2;
        private static readonly FieldCodec<string> _repeated_names_codec
            = FieldCodec.ForString(18);
        private readonly RepeatedField<string> names_ = [];

        /// <summary>
        /// The names of the users requested.
        /// </summary>
        public RepeatedField<string> Names
        {
            get { return names_; }
        }

        public override bool Equals(object other) => Equals(other as BatchGetUsersRequest);
        public bool Equals(BatchGetUsersRequest other)
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
            if (!names_.Equals(other.names_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            hash ^= names_.GetHashCode();
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
      names_.WriteTo(output, _repeated_names_codec);
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
            names_.WriteTo(ref output, _repeated_names_codec);
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
            size += names_.CalculateSize(_repeated_names_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BatchGetUsersRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            names_.Add(other.names_);
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
            names_.AddEntriesFrom(input, _repeated_names_codec);
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
                            names_.AddEntriesFrom(ref input, _repeated_names_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`BatchGetUsers`][salto.nebula.accesspoint.v1.UserService.BatchGetUsers]
    /// </summary>
    public sealed partial class BatchGetUsersResponse : IMessage<BatchGetUsersResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchGetUsersResponse> _parser = new(() => new BatchGetUsersResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchGetUsersResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchGetUsersResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchGetUsersResponse(BatchGetUsersResponse other) : this()
        {
            users_ = other.users_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchGetUsersResponse Clone() => new(this);
        /// <summary>Field number for the "users" field.</summary>
        public const int UsersFieldNumber = 1;
        private static readonly FieldCodec<User> _repeated_users_codec
            = FieldCodec.ForMessage(10, User.Parser);
        private readonly RepeatedField<User> users_ = [];

        /// <summary>
        /// Users requested.
        /// </summary>
        public RepeatedField<User> Users
        {
            get { return users_; }
        }

        public override bool Equals(object other) => Equals(other as BatchGetUsersResponse);
        public bool Equals(BatchGetUsersResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!users_.Equals(other.users_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= users_.GetHashCode();
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
      users_.WriteTo(output, _repeated_users_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            users_.WriteTo(ref output, _repeated_users_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += users_.CalculateSize(_repeated_users_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BatchGetUsersResponse other)
        {
            if (other == null)
            {
                return;
            }
            users_.Add(other.users_);
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
            users_.AddEntriesFrom(input, _repeated_users_codec);
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
                            users_.AddEntriesFrom(ref input, _repeated_users_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`ListUsers`][salto.nebula.user.v1.UserService.ListUsers]
    /// </summary>
    public sealed partial class ListUsersRequest : IMessage<ListUsersRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListUsersRequest> _parser = new(() => new ListUsersRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListUsersRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[11]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListUsersRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListUsersRequest(ListUsersRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListUsersRequest Clone() => new(this);
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
        /// A filter that chooses which users to return.
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

        public override bool Equals(object other) => Equals(other as ListUsersRequest);
        public bool Equals(ListUsersRequest other)
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

        public void MergeFrom(ListUsersRequest other)
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
    /// The response message for [`ListUsers`][salto.nebula.user.v1.UserService.ListUsers]
    /// </summary>
    public sealed partial class ListUsersResponse : IMessage<ListUsersResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListUsersResponse> _parser = new(() => new ListUsersResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListUsersResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[12]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListUsersResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListUsersResponse(ListUsersResponse other) : this()
        {
            users_ = other.users_.Clone();
            nextPageToken_ = other.nextPageToken_;
            totalSize_ = other.totalSize_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListUsersResponse Clone() => new(this);
        /// <summary>Field number for the "users" field.</summary>
        public const int UsersFieldNumber = 1;
        private static readonly FieldCodec<User> _repeated_users_codec
            = FieldCodec.ForMessage(10, User.Parser);
        private readonly RepeatedField<User> users_ = [];

        /// <summary>
        /// The field name should match the noun `users` in the method name. There
        /// will be a maximum number of items returned based on the `page_size` field
        /// in the request.
        /// </summary>
        public RepeatedField<User> Users
        {
            get { return users_; }
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

        /// <summary>Field number for the "total_size" field.</summary>
        public const int TotalSizeFieldNumber = 3;
        private int totalSize_;

        /// <summary>
        /// The total number of users in all pages, irrespective of any pagination.
        /// This is an estimated number based on the requested filter, and it may change in
        /// subsequent pages.
        /// </summary>
        public int TotalSize
        {
            get { return totalSize_; }
            set
            {
                totalSize_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as ListUsersResponse);
        public bool Equals(ListUsersResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!users_.Equals(other.users_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            if (TotalSize != other.TotalSize) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= users_.GetHashCode();
            if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
            if (TotalSize != 0) hash ^= TotalSize.GetHashCode();
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
      users_.WriteTo(output, _repeated_users_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      if (TotalSize != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(TotalSize);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            users_.WriteTo(ref output, _repeated_users_codec);
            if (NextPageToken.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(NextPageToken);
            }
            if (TotalSize != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(TotalSize);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += users_.CalculateSize(_repeated_users_codec);
            if (NextPageToken.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(NextPageToken);
            }
            if (TotalSize != 0)
            {
                size += 1 + CodedOutputStream.ComputeInt32Size(TotalSize);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ListUsersResponse other)
        {
            if (other == null)
            {
                return;
            }
            users_.Add(other.users_);
            if (other.NextPageToken.Length != 0)
            {
                NextPageToken = other.NextPageToken;
            }
            if (other.TotalSize != 0)
            {
                TotalSize = other.TotalSize;
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
            users_.AddEntriesFrom(input, _repeated_users_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
            break;
          }
          case 24: {
            TotalSize = input.ReadInt32();
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
                            users_.AddEntriesFrom(ref input, _repeated_users_codec);
                            break;
                        }
                    case 18:
                        {
                            NextPageToken = input.ReadString();
                            break;
                        }
                    case 24:
                        {
                            TotalSize = input.ReadInt32();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`UpdateUser`][salto.nebula.user.v1.UserService.UpdateUser]
    /// </summary>
    public sealed partial class UpdateUserRequest : IMessage<UpdateUserRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateUserRequest> _parser = new(() => new UpdateUserRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateUserRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateUserRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateUserRequest(UpdateUserRequest other) : this()
        {
            user_ = other.user_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateUserRequest Clone() => new(this);
        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 1;
        private User user_;

        /// <summary>
        /// The user resource which replaces the resource on the server.
        /// </summary>
        public User User
        {
            get { return user_; }
            set
            {
                user_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateUserRequest);
        public bool Equals(UpdateUserRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(User, other.User)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (user_ != null) hash ^= User.GetHashCode();
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
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
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
            if (user_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(User);
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
            if (user_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(User);
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

        public void MergeFrom(UpdateUserRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.user_ != null)
            {
                if (user_ == null)
                {
                    User = new User();
                }
                User.MergeFrom(other.User);
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
            if (user_ == null) {
              User = new Saltoapis.Nebula.User.V1.User();
            }
            input.ReadMessage(User);
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
                            if (user_ == null)
                            {
                                User = new User();
                            }
                            input.ReadMessage(User);
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
    /// The request message for [`DeleteUser`][salto.nebula.user.v1.UserService.DeleteUser]
    /// </summary>
    public sealed partial class DeleteUserRequest : IMessage<DeleteUserRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteUserRequest> _parser = new(() => new DeleteUserRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteUserRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[14]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteUserRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteUserRequest(DeleteUserRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteUserRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the user to be deleted. For example:
        /// `installations/surelock-homes-hq/users/john-watson`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteUserRequest);
        public bool Equals(DeleteUserRequest other)
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

        public void MergeFrom(DeleteUserRequest other)
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
    /// The request message for [`BlockUser`][salto.nebula.user.v1.UserService.BlockUser]
    /// </summary>
    public sealed partial class BlockUserRequest : IMessage<BlockUserRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BlockUserRequest> _parser = new(() => new BlockUserRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BlockUserRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[15]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BlockUserRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BlockUserRequest(BlockUserRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BlockUserRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the user to be blocked. For example:
        /// `installations/surelock-homes-hq/users/john-watson`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as BlockUserRequest);
        public bool Equals(BlockUserRequest other)
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

        public void MergeFrom(BlockUserRequest other)
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
    /// The request message for [`BlockUser`][salto.nebula.user.v1.UserService.BlockUser]
    /// </summary>
    public sealed partial class BlockUserResponse : IMessage<BlockUserResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BlockUserResponse> _parser = new(() => new BlockUserResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BlockUserResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[16]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BlockUserResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BlockUserResponse(BlockUserResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BlockUserResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as BlockUserResponse);
        public bool Equals(BlockUserResponse other)
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

        public void MergeFrom(BlockUserResponse other)
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
    /// The request message for [`UnblockUser`][salto.nebula.user.v1.UserService.UnblockUser]
    /// </summary>
    public sealed partial class UnblockUserRequest : IMessage<UnblockUserRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnblockUserRequest> _parser = new(() => new UnblockUserRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnblockUserRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[17]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnblockUserRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnblockUserRequest(UnblockUserRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnblockUserRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the user to be unblocked. For example:
        /// `installations/surelock-homes-hq/users/john-watson`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as UnblockUserRequest);
        public bool Equals(UnblockUserRequest other)
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

        public void MergeFrom(UnblockUserRequest other)
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
    /// The request message for [`UnblockUser`][salto.nebula.user.v1.UserService.UnblockUser]
    /// </summary>
    public sealed partial class UnblockUserResponse : IMessage<UnblockUserResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnblockUserResponse> _parser = new(() => new UnblockUserResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnblockUserResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[18]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnblockUserResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnblockUserResponse(UnblockUserResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnblockUserResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as UnblockUserResponse);
        public bool Equals(UnblockUserResponse other)
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

        public void MergeFrom(UnblockUserResponse other)
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
    /// The request message for [`CreateUserAccessRight`][salto.nebula.user.v1.UserService.CreateUserAccessRight]
    /// </summary>
    public sealed partial class CreateUserAccessRightRequest : IMessage<CreateUserAccessRightRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateUserAccessRightRequest> _parser = new(() => new CreateUserAccessRightRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateUserAccessRightRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[19]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateUserAccessRightRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateUserAccessRightRequest(CreateUserAccessRightRequest other) : this()
        {
            parent_ = other.parent_;
            userAccessRight_ = other.userAccessRight_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateUserAccessRightRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the users's access right
        /// association is to be created. For example:
        /// `installations/surelock-homes-hq/users/john-watson`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "user_access_right" field.</summary>
        public const int UserAccessRightFieldNumber = 2;
        private UserAccessRight userAccessRight_;

        /// <summary>
        /// The user's access right association resource to be created. Client must
        /// not set the `UserAccessRight.name` field.
        /// </summary>
        public UserAccessRight UserAccessRight
        {
            get { return userAccessRight_; }
            set
            {
                userAccessRight_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateUserAccessRightRequest);
        public bool Equals(CreateUserAccessRightRequest other)
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
            if (!Equals(UserAccessRight, other.UserAccessRight)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (userAccessRight_ != null) hash ^= UserAccessRight.GetHashCode();
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
      if (userAccessRight_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UserAccessRight);
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
            if (userAccessRight_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(UserAccessRight);
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
            if (userAccessRight_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(UserAccessRight);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateUserAccessRightRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.userAccessRight_ != null)
            {
                if (userAccessRight_ == null)
                {
                    UserAccessRight = new UserAccessRight();
                }
                UserAccessRight.MergeFrom(other.UserAccessRight);
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
            if (userAccessRight_ == null) {
              UserAccessRight = new Saltoapis.Nebula.User.V1.UserAccessRight();
            }
            input.ReadMessage(UserAccessRight);
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
                            if (userAccessRight_ == null)
                            {
                                UserAccessRight = new UserAccessRight();
                            }
                            input.ReadMessage(UserAccessRight);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetUserAccessRight`][salto.nebula.user.v1.UserService.GetUserAcessRight]
    /// </summary>
    public sealed partial class GetUserAccessRightRequest : IMessage<GetUserAccessRightRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetUserAccessRightRequest> _parser = new(() => new GetUserAccessRightRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetUserAccessRightRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[20]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetUserAccessRightRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetUserAccessRightRequest(GetUserAccessRightRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetUserAccessRightRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested user's access right association resource. For
        /// example:
        /// `installations/surelock-homes-hq/users/john-watson/access-rights/baskerville`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetUserAccessRightRequest);
        public bool Equals(GetUserAccessRightRequest other)
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

        public void MergeFrom(GetUserAccessRightRequest other)
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
    /// The request message for [`ListUserAccessRights`][salto.nebula.user.v1.UserService.ListUserAccessRights]
    /// </summary>
    public sealed partial class ListUserAccessRightsRequest : IMessage<ListUserAccessRightsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListUserAccessRightsRequest> _parser = new(() => new ListUserAccessRightsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListUserAccessRightsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[21]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListUserAccessRightsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListUserAccessRightsRequest(ListUserAccessRightsRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListUserAccessRightsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name. For example:
        /// `installations/surelock-homes-hq/users/john-watson`.
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
        /// A filter that chooses which user's access right associations
        /// to return.
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

        public override bool Equals(object other) => Equals(other as ListUserAccessRightsRequest);
        public bool Equals(ListUserAccessRightsRequest other)
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

        public void MergeFrom(ListUserAccessRightsRequest other)
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
    /// The response message for [`ListUserAccessRights`][salto.nebula.user.v1.UserService.ListUserAccessRights]
    /// </summary>
    public sealed partial class ListUserAccessRightsResponse : IMessage<ListUserAccessRightsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListUserAccessRightsResponse> _parser = new(() => new ListUserAccessRightsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListUserAccessRightsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[22]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListUserAccessRightsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListUserAccessRightsResponse(ListUserAccessRightsResponse other) : this()
        {
            userAccessRights_ = other.userAccessRights_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListUserAccessRightsResponse Clone() => new(this);
        /// <summary>Field number for the "user_access_rights" field.</summary>
        public const int UserAccessRightsFieldNumber = 1;
        private static readonly FieldCodec<UserAccessRight> _repeated_userAccessRights_codec
            = FieldCodec.ForMessage(10, UserAccessRight.Parser);
        private readonly RepeatedField<UserAccessRight> userAccessRights_ = [];

        /// <summary>
        /// The field name should match the noun `user_access_rights` in the method
        /// name. There will be a maximum number of items returned based on the
        /// `page_size` field in the request.
        /// </summary>
        public RepeatedField<UserAccessRight> UserAccessRights
        {
            get { return userAccessRights_; }
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

        public override bool Equals(object other) => Equals(other as ListUserAccessRightsResponse);
        public bool Equals(ListUserAccessRightsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!userAccessRights_.Equals(other.userAccessRights_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= userAccessRights_.GetHashCode();
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
      userAccessRights_.WriteTo(output, _repeated_userAccessRights_codec);
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
            userAccessRights_.WriteTo(ref output, _repeated_userAccessRights_codec);
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
            size += userAccessRights_.CalculateSize(_repeated_userAccessRights_codec);
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

        public void MergeFrom(ListUserAccessRightsResponse other)
        {
            if (other == null)
            {
                return;
            }
            userAccessRights_.Add(other.userAccessRights_);
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
            userAccessRights_.AddEntriesFrom(input, _repeated_userAccessRights_codec);
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
                            userAccessRights_.AddEntriesFrom(ref input, _repeated_userAccessRights_codec);
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
    /// The request message for [`UpdateUserAccessRight`][salto.nebula.user.v1.UserService.UpdateUserAccessRight]
    /// </summary>
    public sealed partial class UpdateUserAccessRightRequest : IMessage<UpdateUserAccessRightRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateUserAccessRightRequest> _parser = new(() => new UpdateUserAccessRightRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateUserAccessRightRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[23]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateUserAccessRightRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateUserAccessRightRequest(UpdateUserAccessRightRequest other) : this()
        {
            userAccessRight_ = other.userAccessRight_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateUserAccessRightRequest Clone() => new(this);
        /// <summary>Field number for the "user_access_right" field.</summary>
        public const int UserAccessRightFieldNumber = 1;
        private UserAccessRight userAccessRight_;

        /// <summary>
        /// The user's access right resource which replaces the resource on the
        /// server.
        /// </summary>
        public UserAccessRight UserAccessRight
        {
            get { return userAccessRight_; }
            set
            {
                userAccessRight_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateUserAccessRightRequest);
        public bool Equals(UpdateUserAccessRightRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(UserAccessRight, other.UserAccessRight)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (userAccessRight_ != null) hash ^= UserAccessRight.GetHashCode();
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
      if (userAccessRight_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(UserAccessRight);
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
            if (userAccessRight_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(UserAccessRight);
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
            if (userAccessRight_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(UserAccessRight);
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

        public void MergeFrom(UpdateUserAccessRightRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.userAccessRight_ != null)
            {
                if (userAccessRight_ == null)
                {
                    UserAccessRight = new UserAccessRight();
                }
                UserAccessRight.MergeFrom(other.UserAccessRight);
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
            if (userAccessRight_ == null) {
              UserAccessRight = new Saltoapis.Nebula.User.V1.UserAccessRight();
            }
            input.ReadMessage(UserAccessRight);
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
                            if (userAccessRight_ == null)
                            {
                                UserAccessRight = new UserAccessRight();
                            }
                            input.ReadMessage(UserAccessRight);
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
    /// The request message for [`DeleteUserAccessRight`][salto.nebula.user.v1.UserService.DeleteUserAccessRight]
    /// </summary>
    public sealed partial class DeleteUserAccessRightRequest : IMessage<DeleteUserAccessRightRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteUserAccessRightRequest> _parser = new(() => new DeleteUserAccessRightRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteUserAccessRightRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[24]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteUserAccessRightRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteUserAccessRightRequest(DeleteUserAccessRightRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteUserAccessRightRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the user's access right association to be deleted.
        /// For example:
        /// `installations/surelock-homes-hq/users/john-watson/access-rights/baskerville`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteUserAccessRightRequest);
        public bool Equals(DeleteUserAccessRightRequest other)
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

        public void MergeFrom(DeleteUserAccessRightRequest other)
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
    /// The request message for [`AssignCardkey`][salto.nebula.user.v1.UserService.AssignCardkey]
    /// </summary>
    public sealed partial class AssignCardKeyRequest : IMessage<AssignCardKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AssignCardKeyRequest> _parser = new(() => new AssignCardKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AssignCardKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[25]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AssignCardKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AssignCardKeyRequest(AssignCardKeyRequest other) : this()
        {
            name_ = other.name_;
            uid_ = other.uid_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AssignCardKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested user's card key to be assigned. For example:
        /// `installations/surelock-homes-hq/users/john-watson/card-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "uid" field.</summary>
        public const int UidFieldNumber = 2;
        private string uid_ = "";

        /// <summary>
        /// Unique identifier of the physical card. Length dependent of technology.
        /// Max length for ISO14443-3 is 10 bytes.
        /// </summary>
        public string Uid
        {
            get { return uid_; }
            set
            {
                uid_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as AssignCardKeyRequest);
        public bool Equals(AssignCardKeyRequest other)
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
            if (Uid != other.Uid) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (Uid.Length != 0) hash ^= Uid.GetHashCode();
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
      if (Uid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Uid);
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
            if (Uid.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Uid);
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
            if (Uid.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Uid);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(AssignCardKeyRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.Uid.Length != 0)
            {
                Uid = other.Uid;
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
            Uid = input.ReadString();
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
                            Uid = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`CancelCardKey`][salto.nebula.user.v1.UserService.CancelCardKey]
    /// </summary>
    public sealed partial class CancelCardKeyRequest : IMessage<CancelCardKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CancelCardKeyRequest> _parser = new(() => new CancelCardKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CancelCardKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[26]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CancelCardKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CancelCardKeyRequest(CancelCardKeyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CancelCardKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested user's card key to be canceled. For example:
        /// `installations/surelock-homes-hq/users/john-watson/card-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as CancelCardKeyRequest);
        public bool Equals(CancelCardKeyRequest other)
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

        public void MergeFrom(CancelCardKeyRequest other)
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
    /// The request message for [`EncodeCardKey`][salto.nebula.user.v1.UserService.EncodeCardKey]
    /// </summary>
    public sealed partial class EncodeCardKeyRequest : IMessage<EncodeCardKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<EncodeCardKeyRequest> _parser = new(() => new EncodeCardKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<EncodeCardKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[27]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EncodeCardKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public EncodeCardKeyRequest(EncodeCardKeyRequest other) : this()
        {
            name_ = other.name_;
            switch (other.DeviceCase)
            {
                case DeviceOneofCase.Encoder:
                    Encoder = other.Encoder;
                    break;
                case DeviceOneofCase.ElectronicLock:
                    ElectronicLock = other.ElectronicLock;
                    break;
                case DeviceOneofCase.Controller:
                    Controller = other.Controller;
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public EncodeCardKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested user's card key to be encoded. For example:
        /// `installations/surelock-homes-hq/users/john-watson/card-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "encoder" field.</summary>
        public const int EncoderFieldNumber = 2;

        /// <summary>
        /// Device name, when device is an encoder
        /// </summary>
        public string Encoder
        {
            get { return HasEncoder ? (string)device_ : ""; }
            set
            {
                device_ = ProtoPreconditions.CheckNotNull(value, "value");
                deviceCase_ = DeviceOneofCase.Encoder;
            }
        }

        /// <summary>Gets whether the "encoder" field is set</summary>
        public bool HasEncoder
        {
            get { return deviceCase_ == DeviceOneofCase.Encoder; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "encoder" </summary>
        public void ClearEncoder()
        {
            if (HasEncoder)
            {
                ClearDevice();
            }
        }

        /// <summary>Field number for the "electronic_lock" field.</summary>
        public const int ElectronicLockFieldNumber = 3;

        /// <summary>
        /// Device name, when device is an electronic lock
        /// </summary>
        public string ElectronicLock
        {
            get { return HasElectronicLock ? (string)device_ : ""; }
            set
            {
                device_ = ProtoPreconditions.CheckNotNull(value, "value");
                deviceCase_ = DeviceOneofCase.ElectronicLock;
            }
        }

        /// <summary>Gets whether the "electronic_lock" field is set</summary>
        public bool HasElectronicLock
        {
            get { return deviceCase_ == DeviceOneofCase.ElectronicLock; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "electronic_lock" </summary>
        public void ClearElectronicLock()
        {
            if (HasElectronicLock)
            {
                ClearDevice();
            }
        }

        /// <summary>Field number for the "controller" field.</summary>
        public const int ControllerFieldNumber = 4;

        /// <summary>
        /// Device name, when device is a controller
        /// </summary>
        public string Controller
        {
            get { return HasController ? (string)device_ : ""; }
            set
            {
                device_ = ProtoPreconditions.CheckNotNull(value, "value");
                deviceCase_ = DeviceOneofCase.Controller;
            }
        }

        /// <summary>Gets whether the "controller" field is set</summary>
        public bool HasController
        {
            get { return deviceCase_ == DeviceOneofCase.Controller; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "controller" </summary>
        public void ClearController()
        {
            if (HasController)
            {
                ClearDevice();
            }
        }

        private object device_;

        /// <summary>Enum of possible cases for the "device" oneof.</summary>
        public enum DeviceOneofCase
        {
            None = 0,
            Encoder = 2,
            ElectronicLock = 3,
            Controller = 4,
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

        public override bool Equals(object other) => Equals(other as EncodeCardKeyRequest);
        public bool Equals(EncodeCardKeyRequest other)
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
            if (Encoder != other.Encoder) return false;
            if (ElectronicLock != other.ElectronicLock) return false;
            if (Controller != other.Controller) return false;
            if (DeviceCase != other.DeviceCase) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (HasEncoder) hash ^= Encoder.GetHashCode();
            if (HasElectronicLock) hash ^= ElectronicLock.GetHashCode();
            if (HasController) hash ^= Controller.GetHashCode();
            hash ^= (int)deviceCase_;
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
      if (HasEncoder) {
        output.WriteRawTag(18);
        output.WriteString(Encoder);
      }
      if (HasElectronicLock) {
        output.WriteRawTag(26);
        output.WriteString(ElectronicLock);
      }
      if (HasController) {
        output.WriteRawTag(34);
        output.WriteString(Controller);
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
            if (HasEncoder)
            {
                output.WriteRawTag(18);
                output.WriteString(Encoder);
            }
            if (HasElectronicLock)
            {
                output.WriteRawTag(26);
                output.WriteString(ElectronicLock);
            }
            if (HasController)
            {
                output.WriteRawTag(34);
                output.WriteString(Controller);
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
            if (HasEncoder)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Encoder);
            }
            if (HasElectronicLock)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(ElectronicLock);
            }
            if (HasController)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Controller);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(EncodeCardKeyRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            switch (other.DeviceCase)
            {
                case DeviceOneofCase.Encoder:
                    Encoder = other.Encoder;
                    break;
                case DeviceOneofCase.ElectronicLock:
                    ElectronicLock = other.ElectronicLock;
                    break;
                case DeviceOneofCase.Controller:
                    Controller = other.Controller;
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
            Encoder = input.ReadString();
            break;
          }
          case 26: {
            ElectronicLock = input.ReadString();
            break;
          }
          case 34: {
            Controller = input.ReadString();
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
                            Encoder = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            ElectronicLock = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            Controller = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`EncodeCardKey`][salto.nebula.user.v1.UserService.EncodeCardKey]
    /// </summary>
    public sealed partial class EncodeCardKeyResponse : IMessage<EncodeCardKeyResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<EncodeCardKeyResponse> _parser = new(() => new EncodeCardKeyResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<EncodeCardKeyResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[28]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EncodeCardKeyResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public EncodeCardKeyResponse(EncodeCardKeyResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public EncodeCardKeyResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as EncodeCardKeyResponse);
        public bool Equals(EncodeCardKeyResponse other)
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

        public void MergeFrom(EncodeCardKeyResponse other)
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
    /// The metadata message for [`EncodeCardKey`][salto.nebula.user.v1.UserService.EncodeCardKey]
    /// </summary>
    public sealed partial class EncodeCardKeyMetadata : IMessage<EncodeCardKeyMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<EncodeCardKeyMetadata> _parser = new(() => new EncodeCardKeyMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<EncodeCardKeyMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[29]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EncodeCardKeyMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public EncodeCardKeyMetadata(EncodeCardKeyMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public EncodeCardKeyMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as EncodeCardKeyMetadata);
        public bool Equals(EncodeCardKeyMetadata other)
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

        public void MergeFrom(EncodeCardKeyMetadata other)
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
    /// The request message for [`AssignDigitalkey`][salto.nebula.user.v1.UserService.AssignDigitalkey]
    /// </summary>
    public sealed partial class AssignAppKeyRequest : IMessage<AssignAppKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AssignAppKeyRequest> _parser = new(() => new AssignAppKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AssignAppKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[30]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AssignAppKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AssignAppKeyRequest(AssignAppKeyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AssignAppKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested user's app key to be assigned. For example:
        /// `installations/surelock-homes-hq/users/john-watson/app-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as AssignAppKeyRequest);
        public bool Equals(AssignAppKeyRequest other)
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

        public void MergeFrom(AssignAppKeyRequest other)
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
    /// The request message for [`CancelAppKey`][salto.nebula.user.v1.UserService.CancelAppKey]
    /// </summary>
    public sealed partial class CancelAppKeyRequest : IMessage<CancelAppKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CancelAppKeyRequest> _parser = new(() => new CancelAppKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CancelAppKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[31]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CancelAppKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CancelAppKeyRequest(CancelAppKeyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CancelAppKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested user's app key to be canceled. For example:
        /// `installations/surelock-homes-hq/users/john-watson/app-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as CancelAppKeyRequest);
        public bool Equals(CancelAppKeyRequest other)
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

        public void MergeFrom(CancelAppKeyRequest other)
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
    /// The request message for [`ComputeAppKeyData`][salto.nebula.user.v1.UserService.ComputeAppKeyData]
    /// </summary>
    public sealed partial class ComputeAppKeyDataRequest : IMessage<ComputeAppKeyDataRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ComputeAppKeyDataRequest> _parser = new(() => new ComputeAppKeyDataRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ComputeAppKeyDataRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[32]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ComputeAppKeyDataRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ComputeAppKeyDataRequest(ComputeAppKeyDataRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ComputeAppKeyDataRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested user's app key. For example:
        /// `installations/surelock-homes-hq/users/john-watson/app-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ComputeAppKeyDataRequest);
        public bool Equals(ComputeAppKeyDataRequest other)
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

        public void MergeFrom(ComputeAppKeyDataRequest other)
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
    /// The response message for [`ComputeAppKeyData`][salto.nebula.user.v1.UserService.ComputeAppKeyData]
    /// </summary>
    public sealed partial class ComputeAppKeyDataResponse : IMessage<ComputeAppKeyDataResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ComputeAppKeyDataResponse> _parser = new(() => new ComputeAppKeyDataResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ComputeAppKeyDataResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[33]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ComputeAppKeyDataResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ComputeAppKeyDataResponse(ComputeAppKeyDataResponse other) : this()
        {
            data_ = other.data_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ComputeAppKeyDataResponse Clone() => new(this);
        /// <summary>Field number for the "data" field.</summary>
        public const int DataFieldNumber = 1;
        private ByteString data_ = ByteString.Empty;

        /// <summary>
        /// Computed data of the requested app key.
        /// </summary>
        public ByteString Data
        {
            get { return data_; }
            set
            {
                data_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ComputeAppKeyDataResponse);
        public bool Equals(ComputeAppKeyDataResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Data != other.Data) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Data.Length != 0) hash ^= Data.GetHashCode();
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
      if (Data.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Data.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteBytes(Data);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Data.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeBytesSize(Data);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ComputeAppKeyDataResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Data.Length != 0)
            {
                Data = other.Data;
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
            Data = input.ReadBytes();
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
                            Data = input.ReadBytes();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`AssignWalletKey`][salto.nebula.user.v1.UserService.AssignWalletKey]
    /// </summary>
    public sealed partial class AssignWalletKeyRequest : IMessage<AssignWalletKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AssignWalletKeyRequest> _parser = new(() => new AssignWalletKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AssignWalletKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[34]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AssignWalletKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AssignWalletKeyRequest(AssignWalletKeyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AssignWalletKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested user's wallet key to be assigned. For example:
        /// `installations/surelock-homes-hq/users/john-watson/wallet-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as AssignWalletKeyRequest);
        public bool Equals(AssignWalletKeyRequest other)
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

        public void MergeFrom(AssignWalletKeyRequest other)
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
    /// The response message for [`AssignWalletKey`][salto.nebula.user.v1.UserService.AssignWalletKey]
    /// </summary>
    public sealed partial class AssignWalletKeyResponse : IMessage<AssignWalletKeyResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AssignWalletKeyResponse> _parser = new(() => new AssignWalletKeyResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AssignWalletKeyResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[35]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AssignWalletKeyResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AssignWalletKeyResponse(AssignWalletKeyResponse other) : this()
        {
            walletKey_ = other.walletKey_?.Clone();
            accessUri_ = other.accessUri_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AssignWalletKeyResponse Clone() => new(this);
        /// <summary>Field number for the "wallet_key" field.</summary>
        public const int WalletKeyFieldNumber = 1;
        private WalletKey walletKey_;

        /// <summary>
        /// The newly-assigned wallet key.
        /// </summary>
        public WalletKey WalletKey
        {
            get { return walletKey_; }
            set
            {
                walletKey_ = value;
            }
        }

        /// <summary>Field number for the "access_uri" field.</summary>
        public const int AccessUriFieldNumber = 2;
        private string accessUri_ = "";

        /// <summary>
        /// The access URL which contains the data to allow end users to
        /// sign in to SALTO Identity seamlessly and which is also used
        /// in the add-to-wallet process.
        /// </summary>
        public string AccessUri
        {
            get { return accessUri_; }
            set
            {
                accessUri_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as AssignWalletKeyResponse);
        public bool Equals(AssignWalletKeyResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(WalletKey, other.WalletKey)) return false;
            if (AccessUri != other.AccessUri) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (walletKey_ != null) hash ^= WalletKey.GetHashCode();
            if (AccessUri.Length != 0) hash ^= AccessUri.GetHashCode();
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
      if (walletKey_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(WalletKey);
      }
      if (AccessUri.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AccessUri);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (walletKey_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(WalletKey);
            }
            if (AccessUri.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(AccessUri);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (walletKey_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(WalletKey);
            }
            if (AccessUri.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(AccessUri);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(AssignWalletKeyResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.walletKey_ != null)
            {
                if (walletKey_ == null)
                {
                    WalletKey = new WalletKey();
                }
                WalletKey.MergeFrom(other.WalletKey);
            }
            if (other.AccessUri.Length != 0)
            {
                AccessUri = other.AccessUri;
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
            if (walletKey_ == null) {
              WalletKey = new Saltoapis.Nebula.User.V1.WalletKey();
            }
            input.ReadMessage(WalletKey);
            break;
          }
          case 18: {
            AccessUri = input.ReadString();
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
                            if (walletKey_ == null)
                            {
                                WalletKey = new WalletKey();
                            }
                            input.ReadMessage(WalletKey);
                            break;
                        }
                    case 18:
                        {
                            AccessUri = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`CancelWalletKey`][salto.nebula.user.v1.UserService.CancelWalletKey]
    /// </summary>
    public sealed partial class CancelWalletKeyRequest : IMessage<CancelWalletKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CancelWalletKeyRequest> _parser = new(() => new CancelWalletKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CancelWalletKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[36]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CancelWalletKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CancelWalletKeyRequest(CancelWalletKeyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CancelWalletKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested user's wallet key to be canceled. For example:
        /// `installations/surelock-homes-hq/users/john-watson/wallet-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as CancelWalletKeyRequest);
        public bool Equals(CancelWalletKeyRequest other)
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

        public void MergeFrom(CancelWalletKeyRequest other)
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
    /// The response message for [`CancelWalletKey`][salto.nebula.user.v1.UserService.CancelWalletKey]
    /// </summary>
    public sealed partial class CancelWalletKeyResponse : IMessage<CancelWalletKeyResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CancelWalletKeyResponse> _parser = new(() => new CancelWalletKeyResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CancelWalletKeyResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[37]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CancelWalletKeyResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CancelWalletKeyResponse(CancelWalletKeyResponse other) : this()
        {
            walletKey_ = other.walletKey_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CancelWalletKeyResponse Clone() => new(this);
        /// <summary>Field number for the "wallet_key" field.</summary>
        public const int WalletKeyFieldNumber = 1;
        private WalletKey walletKey_;

        /// <summary>
        /// The canceled wallet key.
        /// </summary>
        public WalletKey WalletKey
        {
            get { return walletKey_; }
            set
            {
                walletKey_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CancelWalletKeyResponse);
        public bool Equals(CancelWalletKeyResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(WalletKey, other.WalletKey)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (walletKey_ != null) hash ^= WalletKey.GetHashCode();
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
      if (walletKey_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(WalletKey);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (walletKey_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(WalletKey);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (walletKey_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(WalletKey);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CancelWalletKeyResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.walletKey_ != null)
            {
                if (walletKey_ == null)
                {
                    WalletKey = new WalletKey();
                }
                WalletKey.MergeFrom(other.WalletKey);
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
            if (walletKey_ == null) {
              WalletKey = new Saltoapis.Nebula.User.V1.WalletKey();
            }
            input.ReadMessage(WalletKey);
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
                            if (walletKey_ == null)
                            {
                                WalletKey = new WalletKey();
                            }
                            input.ReadMessage(WalletKey);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`AssignPasscode`][salto.nebula.user.v1.UserService.AssignPasscode]
    /// </summary>
    public sealed partial class AssignPasscodeRequest : IMessage<AssignPasscodeRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AssignPasscodeRequest> _parser = new(() => new AssignPasscodeRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AssignPasscodeRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[38]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AssignPasscodeRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AssignPasscodeRequest(AssignPasscodeRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AssignPasscodeRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested user's passcode to be assigned. For example:
        /// `installations/surelock-homes-hq/users/john-watson/passcode`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as AssignPasscodeRequest);
        public bool Equals(AssignPasscodeRequest other)
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

        public void MergeFrom(AssignPasscodeRequest other)
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
    /// The response message for [`AssignPasscode`][salto.nebula.user.v1.UserService.AssignPasscode]
    /// </summary>
    public sealed partial class AssignPasscodeResponse : IMessage<AssignPasscodeResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AssignPasscodeResponse> _parser = new(() => new AssignPasscodeResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AssignPasscodeResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[39]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AssignPasscodeResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AssignPasscodeResponse(AssignPasscodeResponse other) : this()
        {
            passcode_ = other.passcode_?.Clone();
            value_ = other.value_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AssignPasscodeResponse Clone() => new(this);
        /// <summary>Field number for the "passcode" field.</summary>
        public const int PasscodeFieldNumber = 1;
        private Passcode passcode_;

        /// <summary>
        /// The assigned passcode.
        /// </summary>
        public Passcode Passcode
        {
            get { return passcode_; }
            set
            {
                passcode_ = value;
            }
        }

        /// <summary>Field number for the "value" field.</summary>
        public const int ValueFieldNumber = 2;
        private string value_ = "";

        /// <summary>
        /// The passcode value.
        /// </summary>
        public string Value
        {
            get { return value_; }
            set
            {
                value_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as AssignPasscodeResponse);
        public bool Equals(AssignPasscodeResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Passcode, other.Passcode)) return false;
            if (Value != other.Value) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (passcode_ != null) hash ^= Passcode.GetHashCode();
            if (Value.Length != 0) hash ^= Value.GetHashCode();
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
      if (passcode_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Passcode);
      }
      if (Value.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (passcode_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Passcode);
            }
            if (Value.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Value);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (passcode_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Passcode);
            }
            if (Value.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Value);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(AssignPasscodeResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.passcode_ != null)
            {
                if (passcode_ == null)
                {
                    Passcode = new Passcode();
                }
                Passcode.MergeFrom(other.Passcode);
            }
            if (other.Value.Length != 0)
            {
                Value = other.Value;
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
            if (passcode_ == null) {
              Passcode = new Saltoapis.Nebula.User.V1.Passcode();
            }
            input.ReadMessage(Passcode);
            break;
          }
          case 18: {
            Value = input.ReadString();
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
                            if (passcode_ == null)
                            {
                                Passcode = new Passcode();
                            }
                            input.ReadMessage(Passcode);
                            break;
                        }
                    case 18:
                        {
                            Value = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`CancelPasscode`][salto.nebula.user.v1.UserService.CancelPasscode]
    /// </summary>
    public sealed partial class CancelPasscodeRequest : IMessage<CancelPasscodeRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CancelPasscodeRequest> _parser = new(() => new CancelPasscodeRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CancelPasscodeRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[40]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CancelPasscodeRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CancelPasscodeRequest(CancelPasscodeRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CancelPasscodeRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested user's passcode to be canceled. For example:
        /// `installations/surelock-homes-hq/users/john-watson/passcode`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as CancelPasscodeRequest);
        public bool Equals(CancelPasscodeRequest other)
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

        public void MergeFrom(CancelPasscodeRequest other)
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
    /// The response message for [`CancelPasscode`][salto.nebula.user.v1.UserService.CancelPasscode]
    /// </summary>
    public sealed partial class CancelPasscodeResponse : IMessage<CancelPasscodeResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CancelPasscodeResponse> _parser = new(() => new CancelPasscodeResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CancelPasscodeResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[41]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CancelPasscodeResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CancelPasscodeResponse(CancelPasscodeResponse other) : this()
        {
            passcode_ = other.passcode_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CancelPasscodeResponse Clone() => new(this);
        /// <summary>Field number for the "passcode" field.</summary>
        public const int PasscodeFieldNumber = 1;
        private Passcode passcode_;

        /// <summary>
        /// The canceled passcode.
        /// </summary>
        public Passcode Passcode
        {
            get { return passcode_; }
            set
            {
                passcode_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CancelPasscodeResponse);
        public bool Equals(CancelPasscodeResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Passcode, other.Passcode)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (passcode_ != null) hash ^= Passcode.GetHashCode();
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
      if (passcode_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Passcode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (passcode_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Passcode);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (passcode_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Passcode);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CancelPasscodeResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.passcode_ != null)
            {
                if (passcode_ == null)
                {
                    Passcode = new Passcode();
                }
                Passcode.MergeFrom(other.Passcode);
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
            if (passcode_ == null) {
              Passcode = new Saltoapis.Nebula.User.V1.Passcode();
            }
            input.ReadMessage(Passcode);
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
                            if (passcode_ == null)
                            {
                                Passcode = new Passcode();
                            }
                            input.ReadMessage(Passcode);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`AssignElectronicKey`][salto.nebula.user.v1.UserService.AssignElectronicKey]
    /// </summary>
    public sealed partial class AssignElectronicKeyRequest : IMessage<AssignElectronicKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AssignElectronicKeyRequest> _parser = new(() => new AssignElectronicKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AssignElectronicKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[42]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AssignElectronicKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AssignElectronicKeyRequest(AssignElectronicKeyRequest other) : this()
        {
            name_ = other.name_;
            deviceId_ = other.deviceId_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AssignElectronicKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested user's electronic key to be assigned. For example:
        /// `installations/surelock-homes-hq/users/john-watson/electronic-key`.
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
        /// by SALTO.
        /// </summary>
        public string DeviceId
        {
            get { return deviceId_; }
            set
            {
                deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as AssignElectronicKeyRequest);
        public bool Equals(AssignElectronicKeyRequest other)
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

        public void MergeFrom(AssignElectronicKeyRequest other)
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
    /// The response message for [`AssignElectronicKey`][salto.nebula.user.v1.UserService.AssignElectronicKey]
    /// </summary>
    public sealed partial class AssignElectronicKeyResponse : IMessage<AssignElectronicKeyResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AssignElectronicKeyResponse> _parser = new(() => new AssignElectronicKeyResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AssignElectronicKeyResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[43]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AssignElectronicKeyResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AssignElectronicKeyResponse(AssignElectronicKeyResponse other) : this()
        {
            electronicKey_ = other.electronicKey_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AssignElectronicKeyResponse Clone() => new(this);
        /// <summary>Field number for the "electronic_key" field.</summary>
        public const int ElectronicKeyFieldNumber = 1;
        private ElectronicKey electronicKey_;

        /// <summary>
        /// The assigned electronic key.
        /// </summary>
        public ElectronicKey ElectronicKey
        {
            get { return electronicKey_; }
            set
            {
                electronicKey_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as AssignElectronicKeyResponse);
        public bool Equals(AssignElectronicKeyResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(ElectronicKey, other.ElectronicKey)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (electronicKey_ != null) hash ^= ElectronicKey.GetHashCode();
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
      if (electronicKey_ != null) {
        output.WriteRawTag(10);
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
            if (electronicKey_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(ElectronicKey);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (electronicKey_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(ElectronicKey);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(AssignElectronicKeyResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.electronicKey_ != null)
            {
                if (electronicKey_ == null)
                {
                    ElectronicKey = new ElectronicKey();
                }
                ElectronicKey.MergeFrom(other.ElectronicKey);
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
            if (electronicKey_ == null) {
              ElectronicKey = new Saltoapis.Nebula.User.V1.ElectronicKey();
            }
            input.ReadMessage(ElectronicKey);
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
                            if (electronicKey_ == null)
                            {
                                ElectronicKey = new ElectronicKey();
                            }
                            input.ReadMessage(ElectronicKey);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`CancelElectronicKey`][salto.nebula.user.v1.UserService.CancelElectronicKey]
    /// </summary>
    public sealed partial class CancelElectronicKeyRequest : IMessage<CancelElectronicKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CancelElectronicKeyRequest> _parser = new(() => new CancelElectronicKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CancelElectronicKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[44]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CancelElectronicKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CancelElectronicKeyRequest(CancelElectronicKeyRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CancelElectronicKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested user's electronic key to be canceled. For example:
        /// `installations/surelock-homes-hq/users/john-watson/electronic-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as CancelElectronicKeyRequest);
        public bool Equals(CancelElectronicKeyRequest other)
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

        public void MergeFrom(CancelElectronicKeyRequest other)
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
    /// The response message for [`CancelElectronicKey`][salto.nebula.user.v1.UserService.CancelElectronicKey]
    /// </summary>
    public sealed partial class CancelElectronicKeyResponse : IMessage<CancelElectronicKeyResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CancelElectronicKeyResponse> _parser = new(() => new CancelElectronicKeyResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CancelElectronicKeyResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[45]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CancelElectronicKeyResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CancelElectronicKeyResponse(CancelElectronicKeyResponse other) : this()
        {
            electronicKey_ = other.electronicKey_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CancelElectronicKeyResponse Clone() => new(this);
        /// <summary>Field number for the "electronic_key" field.</summary>
        public const int ElectronicKeyFieldNumber = 1;
        private ElectronicKey electronicKey_;

        /// <summary>
        /// The canceled electronic key.
        /// </summary>
        public ElectronicKey ElectronicKey
        {
            get { return electronicKey_; }
            set
            {
                electronicKey_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CancelElectronicKeyResponse);
        public bool Equals(CancelElectronicKeyResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(ElectronicKey, other.ElectronicKey)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (electronicKey_ != null) hash ^= ElectronicKey.GetHashCode();
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
      if (electronicKey_ != null) {
        output.WriteRawTag(10);
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
            if (electronicKey_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(ElectronicKey);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (electronicKey_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(ElectronicKey);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CancelElectronicKeyResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.electronicKey_ != null)
            {
                if (electronicKey_ == null)
                {
                    ElectronicKey = new ElectronicKey();
                }
                ElectronicKey.MergeFrom(other.ElectronicKey);
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
            if (electronicKey_ == null) {
              ElectronicKey = new Saltoapis.Nebula.User.V1.ElectronicKey();
            }
            input.ReadMessage(ElectronicKey);
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
                            if (electronicKey_ == null)
                            {
                                ElectronicKey = new ElectronicKey();
                            }
                            input.ReadMessage(ElectronicKey);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`EncodeElectronicKey`][salto.nebula.user.v1.UserService.EncodeElectronicKey]
    /// </summary>
    public sealed partial class EncodeElectronicKeyRequest : IMessage<EncodeElectronicKeyRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<EncodeElectronicKeyRequest> _parser = new(() => new EncodeElectronicKeyRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<EncodeElectronicKeyRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[46]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EncodeElectronicKeyRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public EncodeElectronicKeyRequest(EncodeElectronicKeyRequest other) : this()
        {
            name_ = other.name_;
            switch (other.DeviceCase)
            {
                case DeviceOneofCase.Encoder:
                    Encoder = other.Encoder;
                    break;
                case DeviceOneofCase.ElectronicLock:
                    ElectronicLock = other.ElectronicLock;
                    break;
                case DeviceOneofCase.Controller:
                    Controller = other.Controller;
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public EncodeElectronicKeyRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested user's electronic key to be encoded. For example:
        /// `installations/surelock-homes-hq/users/john-watson/electronic-key`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "encoder" field.</summary>
        public const int EncoderFieldNumber = 2;

        /// <summary>
        /// Device name, when device is an encoder
        /// </summary>
        public string Encoder
        {
            get { return HasEncoder ? (string)device_ : ""; }
            set
            {
                device_ = ProtoPreconditions.CheckNotNull(value, "value");
                deviceCase_ = DeviceOneofCase.Encoder;
            }
        }

        /// <summary>Gets whether the "encoder" field is set</summary>
        public bool HasEncoder
        {
            get { return deviceCase_ == DeviceOneofCase.Encoder; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "encoder" </summary>
        public void ClearEncoder()
        {
            if (HasEncoder)
            {
                ClearDevice();
            }
        }

        /// <summary>Field number for the "electronic_lock" field.</summary>
        public const int ElectronicLockFieldNumber = 3;

        /// <summary>
        /// Device name, when device is an electronic lock
        /// </summary>
        public string ElectronicLock
        {
            get { return HasElectronicLock ? (string)device_ : ""; }
            set
            {
                device_ = ProtoPreconditions.CheckNotNull(value, "value");
                deviceCase_ = DeviceOneofCase.ElectronicLock;
            }
        }

        /// <summary>Gets whether the "electronic_lock" field is set</summary>
        public bool HasElectronicLock
        {
            get { return deviceCase_ == DeviceOneofCase.ElectronicLock; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "electronic_lock" </summary>
        public void ClearElectronicLock()
        {
            if (HasElectronicLock)
            {
                ClearDevice();
            }
        }

        /// <summary>Field number for the "controller" field.</summary>
        public const int ControllerFieldNumber = 4;

        /// <summary>
        /// Device name, when device is a controller
        /// </summary>
        public string Controller
        {
            get { return HasController ? (string)device_ : ""; }
            set
            {
                device_ = ProtoPreconditions.CheckNotNull(value, "value");
                deviceCase_ = DeviceOneofCase.Controller;
            }
        }

        /// <summary>Gets whether the "controller" field is set</summary>
        public bool HasController
        {
            get { return deviceCase_ == DeviceOneofCase.Controller; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "controller" </summary>
        public void ClearController()
        {
            if (HasController)
            {
                ClearDevice();
            }
        }

        private object device_;

        /// <summary>Enum of possible cases for the "device" oneof.</summary>
        public enum DeviceOneofCase
        {
            None = 0,
            Encoder = 2,
            ElectronicLock = 3,
            Controller = 4,
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

        public override bool Equals(object other) => Equals(other as EncodeElectronicKeyRequest);
        public bool Equals(EncodeElectronicKeyRequest other)
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
            if (Encoder != other.Encoder) return false;
            if (ElectronicLock != other.ElectronicLock) return false;
            if (Controller != other.Controller) return false;
            if (DeviceCase != other.DeviceCase) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (HasEncoder) hash ^= Encoder.GetHashCode();
            if (HasElectronicLock) hash ^= ElectronicLock.GetHashCode();
            if (HasController) hash ^= Controller.GetHashCode();
            hash ^= (int)deviceCase_;
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
      if (HasEncoder) {
        output.WriteRawTag(18);
        output.WriteString(Encoder);
      }
      if (HasElectronicLock) {
        output.WriteRawTag(26);
        output.WriteString(ElectronicLock);
      }
      if (HasController) {
        output.WriteRawTag(34);
        output.WriteString(Controller);
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
            if (HasEncoder)
            {
                output.WriteRawTag(18);
                output.WriteString(Encoder);
            }
            if (HasElectronicLock)
            {
                output.WriteRawTag(26);
                output.WriteString(ElectronicLock);
            }
            if (HasController)
            {
                output.WriteRawTag(34);
                output.WriteString(Controller);
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
            if (HasEncoder)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Encoder);
            }
            if (HasElectronicLock)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(ElectronicLock);
            }
            if (HasController)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Controller);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(EncodeElectronicKeyRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            switch (other.DeviceCase)
            {
                case DeviceOneofCase.Encoder:
                    Encoder = other.Encoder;
                    break;
                case DeviceOneofCase.ElectronicLock:
                    ElectronicLock = other.ElectronicLock;
                    break;
                case DeviceOneofCase.Controller:
                    Controller = other.Controller;
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
            Encoder = input.ReadString();
            break;
          }
          case 26: {
            ElectronicLock = input.ReadString();
            break;
          }
          case 34: {
            Controller = input.ReadString();
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
                            Encoder = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            ElectronicLock = input.ReadString();
                            break;
                        }
                    case 34:
                        {
                            Controller = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`EncodeElectronicKey`][salto.nebula.user.v1.UserService.EncodeElectronicKey]
    /// </summary>
    public sealed partial class EncodeElectronicKeyResponse : IMessage<EncodeElectronicKeyResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<EncodeElectronicKeyResponse> _parser = new(() => new EncodeElectronicKeyResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<EncodeElectronicKeyResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[47]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EncodeElectronicKeyResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public EncodeElectronicKeyResponse(EncodeElectronicKeyResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public EncodeElectronicKeyResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as EncodeElectronicKeyResponse);
        public bool Equals(EncodeElectronicKeyResponse other)
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

        public void MergeFrom(EncodeElectronicKeyResponse other)
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
    /// The metadata message for [`EncodeElectronicKey`][salto.nebula.user.v1.UserService.EncodeElectronicKey]
    /// </summary>
    public sealed partial class EncodeElectronicKeyMetadata : IMessage<EncodeElectronicKeyMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<EncodeElectronicKeyMetadata> _parser = new(() => new EncodeElectronicKeyMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<EncodeElectronicKeyMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UserReflection.Descriptor.MessageTypes[48]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public EncodeElectronicKeyMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public EncodeElectronicKeyMetadata(EncodeElectronicKeyMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public EncodeElectronicKeyMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as EncodeElectronicKeyMetadata);
        public bool Equals(EncodeElectronicKeyMetadata other)
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

        public void MergeFrom(EncodeElectronicKeyMetadata other)
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
