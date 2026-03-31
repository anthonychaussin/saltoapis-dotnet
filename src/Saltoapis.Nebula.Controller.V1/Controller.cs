using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Controller.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/controller/v1/controller.proto</summary>
    public static partial class ControllerReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/controller/v1/controller.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static ControllerReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CitzYWx0by9uZWJ1bGEvY29udHJvbGxlci92MS9jb250cm9sbGVyLnByb3Rv",
                  "EhpzYWx0by5uZWJ1bGEuY29udHJvbGxlci52MRobZ29vZ2xlL3Byb3RvYnVm",
                  "L2VtcHR5LnByb3RvGiBnb29nbGUvcHJvdG9idWYvZmllbGRfbWFzay5wcm90",
                  "bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90bxokc2FsdG8vbG9u",
                  "Z3J1bm5pbmcvdjEvb3BlcmF0aW9uLnByb3RvGidzYWx0by9uZWJ1bGEvdHlw",
                  "ZS9kZXZpY2VfbWV0YWRhdGEucHJvdG8ilwMKCkNvbnRyb2xsZXISDAoEbmFt",
                  "ZRgBIAEoCRIUCgxkaXNwbGF5X25hbWUYAiABKAkSFgoJZGV2aWNlX2lkGAMg",
                  "ASgJSAGIAQESEQoHZ2F0ZXdheRgEIAEoCUgAEhIKCGV4dGVuZGVyGAUgASgJ",
                  "SAASFQoNYWNjZXNzX3BvaW50cxgGIAMoCRITCgtpbml0aWFsaXplZBgHIAEo",
                  "CBI6Cg9kZXZpY2VfbWV0YWRhdGEYCyABKAsyIS5zYWx0by5uZWJ1bGEudHlw",
                  "ZS5EZXZpY2VNZXRhZGF0YRIQCghvdXRkYXRlZBgIIAEoCBIWCgljb25uZWN0",
                  "ZWQYCSABKAhIAogBARIzCg9sYXN0X2V2ZW50X3RpbWUYCiABKAsyGi5nb29n",
                  "bGUucHJvdG9idWYuVGltZXN0YW1wEh0KEGNhcmRfa2V5X3VwZGF0ZXIYDCAB",
                  "KAhIA4gBAUIPCg1wYXJlbnRfZGV2aWNlQgwKCl9kZXZpY2VfaWRCDAoKX2Nv",
                  "bm5lY3RlZEITChFfY2FyZF9rZXlfdXBkYXRlciLOAgoPQ29udHJvbGxlclJl",
                  "bGF5EgwKBG5hbWUYASABKAkSFwoKZGlwX3N3aXRjaBgCIAEoBUgBiAEBEhAK",
                  "CHJlbGF5X2lkGAMgASgFElsKEmRlc3RpbmF0aW9uX291dHB1dBgEIAEoCzI9",
                  "LnNhbHRvLm5lYnVsYS5jb250cm9sbGVyLnYxLkNvbnRyb2xsZXJSZWxheS5E",
                  "ZXN0aW5hdGlvbk91dHB1dEgAEkQKBnN0cmlrZRgFIAEoCzIyLnNhbHRvLm5l",
                  "YnVsYS5jb250cm9sbGVyLnYxLkNvbnRyb2xsZXJSZWxheS5TdHJpa2VIABoo",
                  "ChFEZXN0aW5hdGlvbk91dHB1dBITCgtkZXN0aW5hdGlvbhgBIAEoCRoeCgZT",
                  "dHJpa2USFAoMYWNjZXNzX3BvaW50GAEgASgJQgYKBHR5cGVCDQoLX2RpcF9z",
                  "d2l0Y2gikwEKF0NyZWF0ZUNvbnRyb2xsZXJSZXF1ZXN0Eg4KBnBhcmVudBgB",
                  "IAEoCRIaCg1jb250cm9sbGVyX2lkGAIgASgJSACIAQESOgoKY29udHJvbGxl",
                  "chgDIAEoCzImLnNhbHRvLm5lYnVsYS5jb250cm9sbGVyLnYxLkNvbnRyb2xs",
                  "ZXJCEAoOX2NvbnRyb2xsZXJfaWQiJAoUR2V0Q29udHJvbGxlclJlcXVlc3QS",
                  "DAoEbmFtZRgBIAEoCSJxChZMaXN0Q29udHJvbGxlcnNSZXF1ZXN0Eg4KBnBh",
                  "cmVudBgBIAEoCRIRCglwYWdlX3NpemUYAiABKAUSEgoKcGFnZV90b2tlbhgD",
                  "IAEoCRIOCgZmaWx0ZXIYBCABKAkSEAoIb3JkZXJfYnkYBSABKAkibwoXTGlz",
                  "dENvbnRyb2xsZXJzUmVzcG9uc2USOwoLY29udHJvbGxlcnMYASADKAsyJi5z",
                  "YWx0by5uZWJ1bGEuY29udHJvbGxlci52MS5Db250cm9sbGVyEhcKD25leHRf",
                  "cGFnZV90b2tlbhgCIAEoCSKGAQoXVXBkYXRlQ29udHJvbGxlclJlcXVlc3QS",
                  "OgoKY29udHJvbGxlchgBIAEoCzImLnNhbHRvLm5lYnVsYS5jb250cm9sbGVy",
                  "LnYxLkNvbnRyb2xsZXISLwoLdXBkYXRlX21hc2sYAiABKAsyGi5nb29nbGUu",
                  "cHJvdG9idWYuRmllbGRNYXNrIicKF0RlbGV0ZUNvbnRyb2xsZXJSZXF1ZXN0",
                  "EgwKBG5hbWUYASABKAkiOAoVQmluZENvbnRyb2xsZXJSZXF1ZXN0EgwKBG5h",
                  "bWUYASABKAkSEQoJZGV2aWNlX2lkGAIgASgJIhgKFkJpbmRDb250cm9sbGVy",
                  "UmVzcG9uc2UiNgoXVW5iaW5kQ29udHJvbGxlclJlcXVlc3QSDAoEbmFtZRgB",
                  "IAEoCRINCgVmb3JjZRgCIAEoCCIaChhVbmJpbmRDb250cm9sbGVyUmVzcG9u",
                  "c2UiKwobSW5pdGlhbGl6ZUNvbnRyb2xsZXJSZXF1ZXN0EgwKBG5hbWUYASAB",
                  "KAkiHgocSW5pdGlhbGl6ZUNvbnRyb2xsZXJSZXNwb25zZSI4ChxJbml0aWFs",
                  "aXplQ29udHJvbGxlck1ldGFkYXRhEhgKEHByb2dyZXNzX3BlcmNlbnQYASAB",
                  "KAUiKgoaQ29uZmlndXJlQ29udHJvbGxlclJlcXVlc3QSDAoEbmFtZRgBIAEo",
                  "CSIdChtDb25maWd1cmVDb250cm9sbGVyUmVzcG9uc2UiNwobQ29uZmlndXJl",
                  "Q29udHJvbGxlck1ldGFkYXRhEhgKEHByb2dyZXNzX3BlcmNlbnQYASABKAUi",
                  "JgoWUmVzZXRDb250cm9sbGVyUmVxdWVzdBIMCgRuYW1lGAEgASgJIhkKF1Jl",
                  "c2V0Q29udHJvbGxlclJlc3BvbnNlIhkKF1Jlc2V0Q29udHJvbGxlck1ldGFk",
                  "YXRhIjUKH1VwZGF0ZUNvbnRyb2xsZXJGaXJtd2FyZVJlcXVlc3QSEgoKY29u",
                  "dHJvbGxlchgBIAEoCSIiCiBVcGRhdGVDb250cm9sbGVyRmlybXdhcmVSZXNw",
                  "b25zZSI8CiBVcGRhdGVDb250cm9sbGVyRmlybXdhcmVNZXRhZGF0YRIYChBw",
                  "cm9ncmVzc19wZXJjZW50GAEgASgFIjcKIUdlbmVyYXRlQXV0aG9yaXphdGlv",
                  "blRva2VuUmVxdWVzdBISCgpjb250cm9sbGVyGAEgASgJIkEKIkdlbmVyYXRl",
                  "QXV0aG9yaXphdGlvblRva2VuUmVzcG9uc2USGwoTYXV0aG9yaXphdGlvbl90",
                  "b2tlbhgBIAEoDCI4CiJHZW5lcmF0ZUZpcm13YXJlRG93bmxvYWRVcmlSZXF1",
                  "ZXN0EhIKCmNvbnRyb2xsZXIYASABKAkiSwojR2VuZXJhdGVGaXJtd2FyZURv",
                  "d25sb2FkVXJpUmVzcG9uc2USFAoMZG93bmxvYWRfdXJpGAEgASgJEg4KBmRp",
                  "Z2VzdBgCIAEoCSIlCiNHZW5lcmF0ZUZpcm13YXJlRG93bmxvYWRVcmlNZXRh",
                  "ZGF0YSKvAQocQ3JlYXRlQ29udHJvbGxlclJlbGF5UmVxdWVzdBIOCgZwYXJl",
                  "bnQYASABKAkSIAoTY29udHJvbGxlcl9yZWxheV9pZBgCIAEoCUgAiAEBEkUK",
                  "EGNvbnRyb2xsZXJfcmVsYXkYAyABKAsyKy5zYWx0by5uZWJ1bGEuY29udHJv",
                  "bGxlci52MS5Db250cm9sbGVyUmVsYXlCFgoUX2NvbnRyb2xsZXJfcmVsYXlf",
                  "aWQiKQoZR2V0Q29udHJvbGxlclJlbGF5UmVxdWVzdBIMCgRuYW1lGAEgASgJ",
                  "InYKG0xpc3RDb250cm9sbGVyUmVsYXlzUmVxdWVzdBIOCgZwYXJlbnQYASAB",
                  "KAkSEQoJcGFnZV9zaXplGAIgASgFEhIKCnBhZ2VfdG9rZW4YAyABKAkSDgoG",
                  "ZmlsdGVyGAQgASgJEhAKCG9yZGVyX2J5GAUgASgJIn8KHExpc3RDb250cm9s",
                  "bGVyUmVsYXlzUmVzcG9uc2USRgoRY29udHJvbGxlcl9yZWxheXMYASADKAsy",
                  "Ky5zYWx0by5uZWJ1bGEuY29udHJvbGxlci52MS5Db250cm9sbGVyUmVsYXkS",
                  "FwoPbmV4dF9wYWdlX3Rva2VuGAIgASgJIpYBChxVcGRhdGVDb250cm9sbGVy",
                  "UmVsYXlSZXF1ZXN0EkUKEGNvbnRyb2xsZXJfcmVsYXkYASABKAsyKy5zYWx0",
                  "by5uZWJ1bGEuY29udHJvbGxlci52MS5Db250cm9sbGVyUmVsYXkSLwoLdXBk",
                  "YXRlX21hc2sYAiABKAsyGi5nb29nbGUucHJvdG9idWYuRmllbGRNYXNrIiwK",
                  "HERlbGV0ZUNvbnRyb2xsZXJSZWxheVJlcXVlc3QSDAoEbmFtZRgBIAEoCSKA",
                  "AQoiQmF0Y2hEZWxldGVDb250cm9sbGVyUmVsYXlzUmVxdWVzdBIOCgZwYXJl",
                  "bnQYASABKAkSSgoIcmVxdWVzdHMYAiADKAsyOC5zYWx0by5uZWJ1bGEuY29u",
                  "dHJvbGxlci52MS5EZWxldGVDb250cm9sbGVyUmVsYXlSZXF1ZXN0IiUKI0Jh",
                  "dGNoRGVsZXRlQ29udHJvbGxlclJlbGF5c1Jlc3BvbnNlIoABCiJCYXRjaENy",
                  "ZWF0ZUNvbnRyb2xsZXJSZWxheXNSZXF1ZXN0Eg4KBnBhcmVudBgBIAEoCRJK",
                  "CghyZXF1ZXN0cxgCIAMoCzI4LnNhbHRvLm5lYnVsYS5jb250cm9sbGVyLnYx",
                  "LkNyZWF0ZUNvbnRyb2xsZXJSZWxheVJlcXVlc3QibQojQmF0Y2hDcmVhdGVD",
                  "b250cm9sbGVyUmVsYXlzUmVzcG9uc2USRgoRY29udHJvbGxlcl9yZWxheXMY",
                  "ASADKAsyKy5zYWx0by5uZWJ1bGEuY29udHJvbGxlci52MS5Db250cm9sbGVy",
                  "UmVsYXkigAEKIkJhdGNoVXBkYXRlQ29udHJvbGxlclJlbGF5c1JlcXVlc3QS",
                  "DgoGcGFyZW50GAEgASgJEkoKCHJlcXVlc3RzGAIgAygLMjguc2FsdG8ubmVi",
                  "dWxhLmNvbnRyb2xsZXIudjEuVXBkYXRlQ29udHJvbGxlclJlbGF5UmVxdWVz",
                  "dCJtCiNCYXRjaFVwZGF0ZUNvbnRyb2xsZXJSZWxheXNSZXNwb25zZRJGChFj",
                  "b250cm9sbGVyX3JlbGF5cxgBIAMoCzIrLnNhbHRvLm5lYnVsYS5jb250cm9s",
                  "bGVyLnYxLkNvbnRyb2xsZXJSZWxheTLrFAoRQ29udHJvbGxlclNlcnZpY2US",
                  "bwoQQ3JlYXRlQ29udHJvbGxlchIzLnNhbHRvLm5lYnVsYS5jb250cm9sbGVy",
                  "LnYxLkNyZWF0ZUNvbnRyb2xsZXJSZXF1ZXN0GiYuc2FsdG8ubmVidWxhLmNv",
                  "bnRyb2xsZXIudjEuQ29udHJvbGxlchJpCg1HZXRDb250cm9sbGVyEjAuc2Fs",
                  "dG8ubmVidWxhLmNvbnRyb2xsZXIudjEuR2V0Q29udHJvbGxlclJlcXVlc3Qa",
                  "Ji5zYWx0by5uZWJ1bGEuY29udHJvbGxlci52MS5Db250cm9sbGVyEnoKD0xp",
                  "c3RDb250cm9sbGVycxIyLnNhbHRvLm5lYnVsYS5jb250cm9sbGVyLnYxLkxp",
                  "c3RDb250cm9sbGVyc1JlcXVlc3QaMy5zYWx0by5uZWJ1bGEuY29udHJvbGxl",
                  "ci52MS5MaXN0Q29udHJvbGxlcnNSZXNwb25zZRJvChBVcGRhdGVDb250cm9s",
                  "bGVyEjMuc2FsdG8ubmVidWxhLmNvbnRyb2xsZXIudjEuVXBkYXRlQ29udHJv",
                  "bGxlclJlcXVlc3QaJi5zYWx0by5uZWJ1bGEuY29udHJvbGxlci52MS5Db250",
                  "cm9sbGVyEl8KEERlbGV0ZUNvbnRyb2xsZXISMy5zYWx0by5uZWJ1bGEuY29u",
                  "dHJvbGxlci52MS5EZWxldGVDb250cm9sbGVyUmVxdWVzdBoWLmdvb2dsZS5w",
                  "cm90b2J1Zi5FbXB0eRJ3Cg5CaW5kQ29udHJvbGxlchIxLnNhbHRvLm5lYnVs",
                  "YS5jb250cm9sbGVyLnYxLkJpbmRDb250cm9sbGVyUmVxdWVzdBoyLnNhbHRv",
                  "Lm5lYnVsYS5jb250cm9sbGVyLnYxLkJpbmRDb250cm9sbGVyUmVzcG9uc2US",
                  "fQoQVW5iaW5kQ29udHJvbGxlchIzLnNhbHRvLm5lYnVsYS5jb250cm9sbGVy",
                  "LnYxLlVuYmluZENvbnRyb2xsZXJSZXF1ZXN0GjQuc2FsdG8ubmVidWxhLmNv",
                  "bnRyb2xsZXIudjEuVW5iaW5kQ29udHJvbGxlclJlc3BvbnNlEnAKFEluaXRp",
                  "YWxpemVDb250cm9sbGVyEjcuc2FsdG8ubmVidWxhLmNvbnRyb2xsZXIudjEu",
                  "SW5pdGlhbGl6ZUNvbnRyb2xsZXJSZXF1ZXN0Gh8uc2FsdG8ubG9uZ3J1bm5p",
                  "bmcudjEuT3BlcmF0aW9uEm4KE0NvbmZpZ3VyZUNvbnRyb2xsZXISNi5zYWx0",
                  "by5uZWJ1bGEuY29udHJvbGxlci52MS5Db25maWd1cmVDb250cm9sbGVyUmVx",
                  "dWVzdBofLnNhbHRvLmxvbmdydW5uaW5nLnYxLk9wZXJhdGlvbhJmCg9SZXNl",
                  "dENvbnRyb2xsZXISMi5zYWx0by5uZWJ1bGEuY29udHJvbGxlci52MS5SZXNl",
                  "dENvbnRyb2xsZXJSZXF1ZXN0Gh8uc2FsdG8ubG9uZ3J1bm5pbmcudjEuT3Bl",
                  "cmF0aW9uEngKGFVwZGF0ZUNvbnRyb2xsZXJGaXJtd2FyZRI7LnNhbHRvLm5l",
                  "YnVsYS5jb250cm9sbGVyLnYxLlVwZGF0ZUNvbnRyb2xsZXJGaXJtd2FyZVJl",
                  "cXVlc3QaHy5zYWx0by5sb25ncnVubmluZy52MS5PcGVyYXRpb24SmwEKGkdl",
                  "bmVyYXRlQXV0aG9yaXphdGlvblRva2VuEj0uc2FsdG8ubmVidWxhLmNvbnRy",
                  "b2xsZXIudjEuR2VuZXJhdGVBdXRob3JpemF0aW9uVG9rZW5SZXF1ZXN0Gj4u",
                  "c2FsdG8ubmVidWxhLmNvbnRyb2xsZXIudjEuR2VuZXJhdGVBdXRob3JpemF0",
                  "aW9uVG9rZW5SZXNwb25zZRJ+ChtHZW5lcmF0ZUZpcm13YXJlRG93bmxvYWRV",
                  "cmkSPi5zYWx0by5uZWJ1bGEuY29udHJvbGxlci52MS5HZW5lcmF0ZUZpcm13",
                  "YXJlRG93bmxvYWRVcmlSZXF1ZXN0Gh8uc2FsdG8ubG9uZ3J1bm5pbmcudjEu",
                  "T3BlcmF0aW9uEn4KFUNyZWF0ZUNvbnRyb2xsZXJSZWxheRI4LnNhbHRvLm5l",
                  "YnVsYS5jb250cm9sbGVyLnYxLkNyZWF0ZUNvbnRyb2xsZXJSZWxheVJlcXVl",
                  "c3QaKy5zYWx0by5uZWJ1bGEuY29udHJvbGxlci52MS5Db250cm9sbGVyUmVs",
                  "YXkSngEKG0JhdGNoQ3JlYXRlQ29udHJvbGxlclJlbGF5cxI+LnNhbHRvLm5l",
                  "YnVsYS5jb250cm9sbGVyLnYxLkJhdGNoQ3JlYXRlQ29udHJvbGxlclJlbGF5",
                  "c1JlcXVlc3QaPy5zYWx0by5uZWJ1bGEuY29udHJvbGxlci52MS5CYXRjaENy",
                  "ZWF0ZUNvbnRyb2xsZXJSZWxheXNSZXNwb25zZRJ4ChJHZXRDb250cm9sbGVy",
                  "UmVsYXkSNS5zYWx0by5uZWJ1bGEuY29udHJvbGxlci52MS5HZXRDb250cm9s",
                  "bGVyUmVsYXlSZXF1ZXN0Gisuc2FsdG8ubmVidWxhLmNvbnRyb2xsZXIudjEu",
                  "Q29udHJvbGxlclJlbGF5EokBChRMaXN0Q29udHJvbGxlclJlbGF5cxI3LnNh",
                  "bHRvLm5lYnVsYS5jb250cm9sbGVyLnYxLkxpc3RDb250cm9sbGVyUmVsYXlz",
                  "UmVxdWVzdBo4LnNhbHRvLm5lYnVsYS5jb250cm9sbGVyLnYxLkxpc3RDb250",
                  "cm9sbGVyUmVsYXlzUmVzcG9uc2USfgoVVXBkYXRlQ29udHJvbGxlclJlbGF5",
                  "Ejguc2FsdG8ubmVidWxhLmNvbnRyb2xsZXIudjEuVXBkYXRlQ29udHJvbGxl",
                  "clJlbGF5UmVxdWVzdBorLnNhbHRvLm5lYnVsYS5jb250cm9sbGVyLnYxLkNv",
                  "bnRyb2xsZXJSZWxheRKeAQobQmF0Y2hVcGRhdGVDb250cm9sbGVyUmVsYXlz",
                  "Ej4uc2FsdG8ubmVidWxhLmNvbnRyb2xsZXIudjEuQmF0Y2hVcGRhdGVDb250",
                  "cm9sbGVyUmVsYXlzUmVxdWVzdBo/LnNhbHRvLm5lYnVsYS5jb250cm9sbGVy",
                  "LnYxLkJhdGNoVXBkYXRlQ29udHJvbGxlclJlbGF5c1Jlc3BvbnNlEmkKFURl",
                  "bGV0ZUNvbnRyb2xsZXJSZWxheRI4LnNhbHRvLm5lYnVsYS5jb250cm9sbGVy",
                  "LnYxLkRlbGV0ZUNvbnRyb2xsZXJSZWxheVJlcXVlc3QaFi5nb29nbGUucHJv",
                  "dG9idWYuRW1wdHkSngEKG0JhdGNoRGVsZXRlQ29udHJvbGxlclJlbGF5cxI+",
                  "LnNhbHRvLm5lYnVsYS5jb250cm9sbGVyLnYxLkJhdGNoRGVsZXRlQ29udHJv",
                  "bGxlclJlbGF5c1JlcXVlc3QaPy5zYWx0by5uZWJ1bGEuY29udHJvbGxlci52",
                  "MS5CYXRjaERlbGV0ZUNvbnRyb2xsZXJSZWxheXNSZXNwb25zZULyAQoiY29t",
                  "LnNhbHRvYXBpcy5uZWJ1bGEuY29udHJvbGxlci52MUIPQ29udHJvbGxlclBy",
                  "b3RvUAFaSmdpdGh1Yi5jb20vc2FsdG9hcGlzLWludGVybmFsL3NhbHRvYXBp",
                  "cy1nby9uZWJ1bGEvY29udHJvbGxlci92MTtjb250cm9sbGVyqgIeU2FsdG9h",
                  "cGlzLk5lYnVsYS5Db250cm9sbGVyLlYxygIeU2FsdG9hcGlzXE5lYnVsYVxD",
                  "b250cm9sbGVyXFYx4gIqR1BCTWV0YWRhdGFcU2FsdG9hcGlzXE5lYnVsYVxD",
                  "b250cm9sbGVyXFYxYgZwcm90bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, Longrunning.V1.OperationReflection.Descriptor, Type.DeviceMetadataReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Controller), Controller.Parser, ["Name", "DisplayName", "DeviceId", "Gateway", "Extender", "AccessPoints", "Initialized", "DeviceMetadata", "Outdated", "Connected", "LastEventTime", "CardKeyUpdater"], ["ParentDevice", "DeviceId", "Connected", "CardKeyUpdater"], null, null, null),
            new(typeof(ControllerRelay), ControllerRelay.Parser, ["Name", "DipSwitch", "RelayId", "DestinationOutput", "Strike"], ["Type", "DipSwitch"], null, null, [ new(typeof(ControllerRelay.Types.DestinationOutput), ControllerRelay.Types.DestinationOutput.Parser, ["Destination"], null, null, null, null),
            new(typeof(ControllerRelay.Types.Strike), ControllerRelay.Types.Strike.Parser, ["AccessPoint"], null, null, null, null)]),
            new(typeof(CreateControllerRequest), CreateControllerRequest.Parser, ["Parent", "ControllerId", "Controller"], ["ControllerId"], null, null, null),
            new(typeof(GetControllerRequest), GetControllerRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListControllersRequest), ListControllersRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListControllersResponse), ListControllersResponse.Parser, ["Controllers", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateControllerRequest), UpdateControllerRequest.Parser, ["Controller", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteControllerRequest), DeleteControllerRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(BindControllerRequest), BindControllerRequest.Parser, ["Name", "DeviceId"], null, null, null, null),
            new(typeof(BindControllerResponse), BindControllerResponse.Parser, null, null, null, null, null),
            new(typeof(UnbindControllerRequest), UnbindControllerRequest.Parser, ["Name", "Force"], null, null, null, null),
            new(typeof(UnbindControllerResponse), UnbindControllerResponse.Parser, null, null, null, null, null),
            new(typeof(InitializeControllerRequest), InitializeControllerRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(InitializeControllerResponse), InitializeControllerResponse.Parser, null, null, null, null, null),
            new(typeof(InitializeControllerMetadata), InitializeControllerMetadata.Parser, ["ProgressPercent"], null, null, null, null),
            new(typeof(ConfigureControllerRequest), ConfigureControllerRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ConfigureControllerResponse), ConfigureControllerResponse.Parser, null, null, null, null, null),
            new(typeof(ConfigureControllerMetadata), ConfigureControllerMetadata.Parser, ["ProgressPercent"], null, null, null, null),
            new(typeof(ResetControllerRequest), ResetControllerRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ResetControllerResponse), ResetControllerResponse.Parser, null, null, null, null, null),
            new(typeof(ResetControllerMetadata), ResetControllerMetadata.Parser, null, null, null, null, null),
            new(typeof(UpdateControllerFirmwareRequest), UpdateControllerFirmwareRequest.Parser, ["Controller"], null, null, null, null),
            new(typeof(UpdateControllerFirmwareResponse), UpdateControllerFirmwareResponse.Parser, null, null, null, null, null),
            new(typeof(UpdateControllerFirmwareMetadata), UpdateControllerFirmwareMetadata.Parser, ["ProgressPercent"], null, null, null, null),
            new(typeof(GenerateAuthorizationTokenRequest), GenerateAuthorizationTokenRequest.Parser, ["Controller"], null, null, null, null),
            new(typeof(GenerateAuthorizationTokenResponse), GenerateAuthorizationTokenResponse.Parser, ["AuthorizationToken"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriRequest), GenerateFirmwareDownloadUriRequest.Parser, ["Controller"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriResponse), GenerateFirmwareDownloadUriResponse.Parser, ["DownloadUri", "Digest"], null, null, null, null),
            new(typeof(GenerateFirmwareDownloadUriMetadata), GenerateFirmwareDownloadUriMetadata.Parser, null, null, null, null, null),
            new(typeof(CreateControllerRelayRequest), CreateControllerRelayRequest.Parser, ["Parent", "ControllerRelayId", "ControllerRelay"], ["ControllerRelayId"], null, null, null),
            new(typeof(GetControllerRelayRequest), GetControllerRelayRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListControllerRelaysRequest), ListControllerRelaysRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListControllerRelaysResponse), ListControllerRelaysResponse.Parser, ["ControllerRelays", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateControllerRelayRequest), UpdateControllerRelayRequest.Parser, ["ControllerRelay", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteControllerRelayRequest), DeleteControllerRelayRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(BatchDeleteControllerRelaysRequest), BatchDeleteControllerRelaysRequest.Parser, ["Parent", "Requests"], null, null, null, null),
            new(typeof(BatchDeleteControllerRelaysResponse), BatchDeleteControllerRelaysResponse.Parser, null, null, null, null, null),
            new(typeof(BatchCreateControllerRelaysRequest), BatchCreateControllerRelaysRequest.Parser, ["Parent", "Requests"], null, null, null, null),
            new(typeof(BatchCreateControllerRelaysResponse), BatchCreateControllerRelaysResponse.Parser, ["ControllerRelays"], null, null, null, null),
            new(typeof(BatchUpdateControllerRelaysRequest), BatchUpdateControllerRelaysRequest.Parser, ["Parent", "Requests"], null, null, null, null),
            new(typeof(BatchUpdateControllerRelaysResponse), BatchUpdateControllerRelaysResponse.Parser, ["ControllerRelays"], null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// The controller object
    /// </summary>
    public sealed partial class Controller : IMessage<Controller>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Controller> _parser = new(() => new Controller());
        private UnknownFieldSet _unknownFields;
        private int _hasBits0;

        public static MessageParser<Controller> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Controller()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Controller(Controller other) : this()
        {
            _hasBits0 = other._hasBits0;
            name_ = other.name_;
            displayName_ = other.displayName_;
            deviceId_ = other.deviceId_;
            accessPoints_ = other.accessPoints_.Clone();
            initialized_ = other.initialized_;
            deviceMetadata_ = other.deviceMetadata_?.Clone();
            outdated_ = other.outdated_;
            connected_ = other.connected_;
            lastEventTime_ = other.lastEventTime_?.Clone();
            cardKeyUpdater_ = other.cardKeyUpdater_;
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

        public Controller Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the controller. It must have the format of
        /// `installations/*/controllers/*`. For example:
        /// `installations/surelock-homes-hq/controller/dancing-men`.
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
        /// Display name of the controller.
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
        /// by SALTO, including gateways, extenders, electronic locks and so on.
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
        /// Parent name, when controller is connected to a gateway
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
        /// Parent name, when controller is connected to an extender
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
        private static readonly FieldCodec<string> _repeated_accessPoints_codec
            = FieldCodec.ForString(50);
        private readonly RepeatedField<string> accessPoints_ = [];

        /// <summary>
        /// The access points that the controller gives coverage to.
        /// </summary>
        public RepeatedField<string> AccessPoints
        {
            get { return accessPoints_; }
        }

        /// <summary>Field number for the "initialized" field.</summary>
        public const int InitializedFieldNumber = 7;
        private bool initialized_;

        /// <summary>
        /// Indicates whether this controller has been initialized or not. This
        /// field cannot be modified using a standard
        /// [`UpdateController`][salto.nebula.controller.v1.ControllerService.UpdateController]
        /// operation. To change the value of this field, you must call
        /// [`InitializeController`][salto.nebula.controller.v1.ControllerService.InitializeController].
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
        public const int DeviceMetadataFieldNumber = 11;
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
        /// Indicates whether this controller has pending updates or not. This
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
        private readonly static bool ConnectedDefaultValue = false;

        private bool connected_;

        /// <summary>
        /// Indicates whether this controller is connected or not. It's
        /// considered connected if there has been at least one communication with it
        /// within the last 10 minutes. The property is left unset if it is an
        /// offline controller.
        /// </summary>
        public bool Connected
        {
            get { if ((_hasBits0 & 1) != 0) { return connected_; } else { return ConnectedDefaultValue; } }
            set
            {
                _hasBits0 |= 1;
                connected_ = value;
            }
        }

        /// <summary>Gets whether the "connected" field is set</summary>
        public bool HasConnected
        {
            get { return (_hasBits0 & 1) != 0; }
        }

        /// <summary>Clears the value of the "connected" field</summary>
        public void ClearConnected()
        {
            _hasBits0 &= ~1;
        }

        /// <summary>Field number for the "last_event_time" field.</summary>
        public const int LastEventTimeFieldNumber = 10;
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

        /// <summary>Field number for the "card_key_updater" field.</summary>
        public const int CardKeyUpdaterFieldNumber = 12;
        private readonly static bool CardKeyUpdaterDefaultValue = false;

        private bool cardKeyUpdater_;

        /// <summary>
        /// Enables or disables card key updates. This property is only relevant when
        /// the controller functions as a destination enabler.
        /// </summary>
        public bool CardKeyUpdater
        {
            get { if ((_hasBits0 & 2) != 0) { return cardKeyUpdater_; } else { return CardKeyUpdaterDefaultValue; } }
            set
            {
                _hasBits0 |= 2;
                cardKeyUpdater_ = value;
            }
        }

        /// <summary>Gets whether the "card_key_updater" field is set</summary>
        public bool HasCardKeyUpdater
        {
            get { return (_hasBits0 & 2) != 0; }
        }

        /// <summary>Clears the value of the "card_key_updater" field</summary>
        public void ClearCardKeyUpdater()
        {
            _hasBits0 &= ~2;
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

        public override bool Equals(object other) => Equals(other as Controller);
        public bool Equals(Controller other)
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
            if (!Equals(LastEventTime, other.LastEventTime)) return false;
            if (CardKeyUpdater != other.CardKeyUpdater) return false;
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
            if (HasConnected) hash ^= Connected.GetHashCode();
            if (lastEventTime_ != null) hash ^= LastEventTime.GetHashCode();
            if (HasCardKeyUpdater) hash ^= CardKeyUpdater.GetHashCode();
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
      if (HasConnected) {
        output.WriteRawTag(72);
        output.WriteBool(Connected);
      }
      if (lastEventTime_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(LastEventTime);
      }
      if (deviceMetadata_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(DeviceMetadata);
      }
      if (HasCardKeyUpdater) {
        output.WriteRawTag(96);
        output.WriteBool(CardKeyUpdater);
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
            if (HasConnected)
            {
                output.WriteRawTag(72);
                output.WriteBool(Connected);
            }
            if (lastEventTime_ != null)
            {
                output.WriteRawTag(82);
                output.WriteMessage(LastEventTime);
            }
            if (deviceMetadata_ != null)
            {
                output.WriteRawTag(90);
                output.WriteMessage(DeviceMetadata);
            }
            if (HasCardKeyUpdater)
            {
                output.WriteRawTag(96);
                output.WriteBool(CardKeyUpdater);
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
                size += 1 + CodedOutputStream.ComputeMessageSize(DeviceMetadata);
            }
            if (Outdated != false)
            {
                size += 1 + 1;
            }
            if (HasConnected)
            {
                size += 1 + 1;
            }
            if (lastEventTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(LastEventTime);
            }
            if (HasCardKeyUpdater)
            {
                size += 1 + 1;
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(Controller other)
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
            if (other.HasConnected)
            {
                Connected = other.Connected;
            }
            if (other.lastEventTime_ != null)
            {
                if (lastEventTime_ == null)
                {
                    LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                LastEventTime.MergeFrom(other.LastEventTime);
            }
            if (other.HasCardKeyUpdater)
            {
                CardKeyUpdater = other.CardKeyUpdater;
            }
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
          case 82: {
            if (lastEventTime_ == null) {
              LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastEventTime);
            break;
          }
          case 90: {
            if (deviceMetadata_ == null) {
              DeviceMetadata = new Saltoapis.Nebula.Type.DeviceMetadata();
            }
            input.ReadMessage(DeviceMetadata);
            break;
          }
          case 96: {
            CardKeyUpdater = input.ReadBool();
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
                    case 82:
                        {
                            if (lastEventTime_ == null)
                            {
                                LastEventTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(LastEventTime);
                            break;
                        }
                    case 90:
                        {
                            if (deviceMetadata_ == null)
                            {
                                DeviceMetadata = new Type.DeviceMetadata();
                            }
                            input.ReadMessage(DeviceMetadata);
                            break;
                        }
                    case 96:
                        {
                            CardKeyUpdater = input.ReadBool();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// Relay represents a configurable output from a controller that can be used to control
    /// external devices such as doors or other electrical systems. Relays can be
    /// located on the main controller board or on extension boards, with addressing
    /// determined by dipswitch settings.
    /// </summary>
    public sealed partial class ControllerRelay : IMessage<ControllerRelay>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ControllerRelay> _parser = new(() => new ControllerRelay());
        private UnknownFieldSet _unknownFields;
        private int _hasBits0;

        public static MessageParser<ControllerRelay> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ControllerRelay()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ControllerRelay(ControllerRelay other) : this()
        {
            _hasBits0 = other._hasBits0;
            name_ = other.name_;
            dipSwitch_ = other.dipSwitch_;
            relayId_ = other.relayId_;
            switch (other.TypeCase)
            {
                case TypeOneofCase.DestinationOutput:
                    DestinationOutput = other.DestinationOutput.Clone();
                    break;
                case TypeOneofCase.Strike:
                    Strike = other.Strike.Clone();
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ControllerRelay Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the controller relay. It must have the format of
        /// `installations/*/controllers/*/relays/*`. For example:
        /// `installations/surelock-homes-hq/controller/dancing-men/relays/first-floor`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "dip_switch" field.</summary>
        public const int DipSwitchFieldNumber = 2;
        private readonly static int DipSwitchDefaultValue = 0;

        private int dipSwitch_;

        /// <summary>
        /// Extension board address. Values range from 0-15, allowing for up to 16 boards in the system.
        /// This field is not applicable for master boards or wall reader extension boards.
        /// </summary>
        public int DipSwitch
        {
            get { if ((_hasBits0 & 1) != 0) { return dipSwitch_; } else { return DipSwitchDefaultValue; } }
            set
            {
                _hasBits0 |= 1;
                dipSwitch_ = value;
            }
        }

        /// <summary>Gets whether the "dip_switch" field is set</summary>
        public bool HasDipSwitch
        {
            get { return (_hasBits0 & 1) != 0; }
        }

        /// <summary>Clears the value of the "dip_switch" field</summary>
        public void ClearDipSwitch()
        {
            _hasBits0 &= ~1;
        }

        /// <summary>Field number for the "relay_id" field.</summary>
        public const int RelayIdFieldNumber = 3;
        private int relayId_;

        /// <summary>
        /// Identifies the specific controller relay on the board (1-4). Board type determines
        /// which controller relay IDs are actually available for configuration and use.
        /// </summary>
        public int RelayId
        {
            get { return relayId_; }
            set
            {
                relayId_ = value;
            }
        }

        /// <summary>Field number for the "destination_output" field.</summary>
        public const int DestinationOutputFieldNumber = 4;

        /// <summary>
        /// Destination output configuration for this controller relay.
        /// </summary>
        public Types.DestinationOutput DestinationOutput
        {
            get { return typeCase_ == TypeOneofCase.DestinationOutput ? (Types.DestinationOutput)type_ : null; }
            set
            {
                type_ = value;
                typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.DestinationOutput;
            }
        }

        /// <summary>Field number for the "strike" field.</summary>
        public const int StrikeFieldNumber = 5;

        /// <summary>
        /// Strike configuration for this controller relay.
        /// </summary>
        public Types.Strike Strike
        {
            get { return typeCase_ == TypeOneofCase.Strike ? (Types.Strike)type_ : null; }
            set
            {
                type_ = value;
                typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.Strike;
            }
        }

        private object type_;

        /// <summary>Enum of possible cases for the "type" oneof.</summary>
        public enum TypeOneofCase
        {
            None = 0,
            DestinationOutput = 4,
            Strike = 5,
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

        public override bool Equals(object other) => Equals(other as ControllerRelay);
        public bool Equals(ControllerRelay other)
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
            if (DipSwitch != other.DipSwitch) return false;
            if (RelayId != other.RelayId) return false;
            if (!Equals(DestinationOutput, other.DestinationOutput)) return false;
            if (!Equals(Strike, other.Strike)) return false;
            if (TypeCase != other.TypeCase) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (HasDipSwitch) hash ^= DipSwitch.GetHashCode();
            if (RelayId != 0) hash ^= RelayId.GetHashCode();
            if (typeCase_ == TypeOneofCase.DestinationOutput) hash ^= DestinationOutput.GetHashCode();
            if (typeCase_ == TypeOneofCase.Strike) hash ^= Strike.GetHashCode();
            hash ^= (int)typeCase_;
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
      if (HasDipSwitch) {
        output.WriteRawTag(16);
        output.WriteInt32(DipSwitch);
      }
      if (RelayId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(RelayId);
      }
      if (typeCase_ == TypeOneofCase.DestinationOutput) {
        output.WriteRawTag(34);
        output.WriteMessage(DestinationOutput);
      }
      if (typeCase_ == TypeOneofCase.Strike) {
        output.WriteRawTag(42);
        output.WriteMessage(Strike);
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
            if (HasDipSwitch)
            {
                output.WriteRawTag(16);
                output.WriteInt32(DipSwitch);
            }
            if (RelayId != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(RelayId);
            }
            if (typeCase_ == TypeOneofCase.DestinationOutput)
            {
                output.WriteRawTag(34);
                output.WriteMessage(DestinationOutput);
            }
            if (typeCase_ == TypeOneofCase.Strike)
            {
                output.WriteRawTag(42);
                output.WriteMessage(Strike);
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
            if (HasDipSwitch)
            {
                size += 1 + CodedOutputStream.ComputeInt32Size(DipSwitch);
            }
            if (RelayId != 0)
            {
                size += 1 + CodedOutputStream.ComputeInt32Size(RelayId);
            }
            if (typeCase_ == TypeOneofCase.DestinationOutput)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(DestinationOutput);
            }
            if (typeCase_ == TypeOneofCase.Strike)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Strike);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(ControllerRelay other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.HasDipSwitch)
            {
                DipSwitch = other.DipSwitch;
            }
            if (other.RelayId != 0)
            {
                RelayId = other.RelayId;
            }
            switch (other.TypeCase)
            {
                case TypeOneofCase.DestinationOutput:
                    DestinationOutput ??= new Types.DestinationOutput();
                    DestinationOutput.MergeFrom(other.DestinationOutput);
                    break;
                case TypeOneofCase.Strike:
                    Strike ??= new Types.Strike();
                    Strike.MergeFrom(other.Strike);
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
          case 16: {
            DipSwitch = input.ReadInt32();
            break;
          }
          case 24: {
            RelayId = input.ReadInt32();
            break;
          }
          case 34: {
            Saltoapis.Nebula.Controller.V1.ControllerRelay.Types.DestinationOutput subBuilder = new Saltoapis.Nebula.Controller.V1.ControllerRelay.Types.DestinationOutput();
            if (typeCase_ == TypeOneofCase.DestinationOutput) {
              subBuilder.MergeFrom(DestinationOutput);
            }
            input.ReadMessage(subBuilder);
            DestinationOutput = subBuilder;
            break;
          }
          case 42: {
            Saltoapis.Nebula.Controller.V1.ControllerRelay.Types.Strike subBuilder = new Saltoapis.Nebula.Controller.V1.ControllerRelay.Types.Strike();
            if (typeCase_ == TypeOneofCase.Strike) {
              subBuilder.MergeFrom(Strike);
            }
            input.ReadMessage(subBuilder);
            Strike = subBuilder;
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
                            DipSwitch = input.ReadInt32();
                            break;
                        }
                    case 24:
                        {
                            RelayId = input.ReadInt32();
                            break;
                        }
                    case 34:
                        {
                            Types.DestinationOutput subBuilder = new();
                            if (typeCase_ == TypeOneofCase.DestinationOutput)
                            {
                                subBuilder.MergeFrom(DestinationOutput);
                            }
                            input.ReadMessage(subBuilder);
                            DestinationOutput = subBuilder;
                            break;
                        }
                    case 42:
                        {
                            Types.Strike subBuilder = new();
                            if (typeCase_ == TypeOneofCase.Strike)
                            {
                                subBuilder.MergeFrom(Strike);
                            }
                            input.ReadMessage(subBuilder);
                            Strike = subBuilder;
                            break;
                        }
                }
            }
        }
#endif

        #region Nested types
        /// <summary>Container for nested types declared in the ControllerRelay message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// DestinationOutput contains configuration information that identifies a specific
            /// destination resource and a specific output.
            ///
            /// This message maps a controller relay to a logical destination (like an elevator floor)
            /// and specifies which output activation value on the credential will trigger this controller relay.
            /// When used within a Relay's "type" oneof field, it configures the controller relay to activate
            /// when a credential with matching output permissions is presented at a reader connected
            /// to the controller.
            ///
            /// For example, in an elevator control scenario, each controller relay might control a different
            /// floor button, with the "output" field (0-255) corresponding to a specific permission
            /// bit in the credential's access rights.
            /// </summary>
            public sealed partial class DestinationOutput : IMessage<DestinationOutput>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<DestinationOutput> _parser = new(() => new DestinationOutput());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<DestinationOutput> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return ControllerRelay.Descriptor.NestedTypes[0]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public DestinationOutput()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public DestinationOutput(DestinationOutput other) : this()
                {
                    destination_ = other.destination_;
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public DestinationOutput Clone() => new(this);
                /// <summary>Field number for the "destination" field.</summary>
                public const int DestinationFieldNumber = 1;
                private string destination_ = "";

                /// <summary>
                /// Resource name of the destination the controller relay points to.
                /// For example: installations/surelock-homes-hq/destinations/elevator-floor-5.
                /// </summary>
                public string Destination
                {
                    get { return destination_; }
                    set
                    {
                        destination_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                public override bool Equals(object other) => Equals(other as DestinationOutput);
                public bool Equals(DestinationOutput other)
                {
                    if (other is null)
                    {
                        return false;
                    }
                    if (ReferenceEquals(other, this))
                    {
                        return true;
                    }
                    if (Destination != other.Destination) return false;
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (Destination.Length != 0) hash ^= Destination.GetHashCode();
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
          if (Destination.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Destination);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
                }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

                void IBufferMessage.InternalWriteTo(ref WriteContext output)
                {
                    if (Destination.Length != 0)
                    {
                        output.WriteRawTag(10);
                        output.WriteString(Destination);
                    }
                    _unknownFields?.WriteTo(ref output);
                }
#endif

                public int CalculateSize()
                {
                    int size = 0;
                    if (Destination.Length != 0)
                    {
                        size += 1 + CodedOutputStream.ComputeStringSize(Destination);
                    }
                    if (_unknownFields != null)
                    {
                        size += _unknownFields.CalculateSize();
                    }
                    return size;
                }

                public void MergeFrom(DestinationOutput other)
                {
                    if (other == null)
                    {
                        return;
                    }
                    if (other.Destination.Length != 0)
                    {
                        Destination = other.Destination;
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
                Destination = input.ReadString();
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
                                    Destination = input.ReadString();
                                    break;
                                }
                        }
                    }
                }
#endif

            }

            /// <summary>
            /// Strike contains configuration information that identifies a specific
            /// access point resource.
            /// </summary>
            public sealed partial class Strike : IMessage<Strike>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
                , IBufferMessage
#endif
            {
                private static readonly MessageParser<Strike> _parser = new(() => new Strike());
                private UnknownFieldSet _unknownFields;

                public static MessageParser<Strike> Parser { get { return _parser; } }

                public static MessageDescriptor Descriptor
                {
                    get { return ControllerRelay.Descriptor.NestedTypes[1]; }
                }

                MessageDescriptor IMessage.Descriptor
                {
                    get { return Descriptor; }
                }

                public Strike()
                {
                    OnConstruction();
                }

                partial void OnConstruction();

                public Strike(Strike other) : this()
                {
                    accessPoint_ = other.accessPoint_;
                    _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
                }

                public Strike Clone() => new(this);
                /// <summary>Field number for the "access_point" field.</summary>
                public const int AccessPointFieldNumber = 1;
                private string accessPoint_ = "";

                /// <summary>
                /// Resource name of the access point the controller relay points to.
                /// For example: `installations/surelock-homes-hq/access-points/baker-street-entrance`.
                /// </summary>
                public string AccessPoint
                {
                    get { return accessPoint_; }
                    set
                    {
                        accessPoint_ = ProtoPreconditions.CheckNotNull(value, "value");
                    }
                }

                public override bool Equals(object other) => Equals(other as Strike);
                public bool Equals(Strike other)
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
                    return Equals(_unknownFields, other._unknownFields);
                }

                public override int GetHashCode()
                {
                    int hash = 1;
                    if (AccessPoint.Length != 0) hash ^= AccessPoint.GetHashCode();
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
                    if (_unknownFields != null)
                    {
                        size += _unknownFields.CalculateSize();
                    }
                    return size;
                }

                public void MergeFrom(Strike other)
                {
                    if (other == null)
                    {
                        return;
                    }
                    if (other.AccessPoint.Length != 0)
                    {
                        AccessPoint = other.AccessPoint;
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
                        }
                    }
                }
#endif

            }

        }
        #endregion

    }

    /// <summary>
    /// The request message for [CreateController][salto.nebula.controller.v1.ControllerService.CreateController]
    /// </summary>
    public sealed partial class CreateControllerRequest : IMessage<CreateControllerRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateControllerRequest> _parser = new(() => new CreateControllerRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateControllerRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateControllerRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateControllerRequest(CreateControllerRequest other) : this()
        {
            parent_ = other.parent_;
            controllerId_ = other.controllerId_;
            controller_ = other.controller_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateControllerRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where to create the controller. For
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

        /// <summary>Field number for the "controller_id" field.</summary>
        public const int ControllerIdFieldNumber = 2;
        private readonly static string ControllerIdDefaultValue = "";

        private string controllerId_;

        /// <summary>
        /// The controller ID to use for this controller. In case it's empty the
        /// server will autogenerate a unique identifier.
        /// </summary>
        public string ControllerId
        {
            get { return controllerId_ ?? ControllerIdDefaultValue; }
            set
            {
                controllerId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "controller_id" field is set</summary>
        public bool HasControllerId
        {
            get { return controllerId_ != null; }
        }

        /// <summary>Clears the value of the "controller_id" field</summary>
        public void ClearControllerId()
        {
            controllerId_ = null;
        }

        /// <summary>Field number for the "controller" field.</summary>
        public const int ControllerFieldNumber = 3;
        private Controller controller_;

        /// <summary>
        /// The controller resource to be created. Client must not set the
        /// `Controller.name` field.
        /// </summary>
        public Controller Controller
        {
            get { return controller_; }
            set
            {
                controller_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateControllerRequest);
        public bool Equals(CreateControllerRequest other)
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
            if (ControllerId != other.ControllerId) return false;
            if (!Equals(Controller, other.Controller)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasControllerId) hash ^= ControllerId.GetHashCode();
            if (controller_ != null) hash ^= Controller.GetHashCode();
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
      if (HasControllerId) {
        output.WriteRawTag(18);
        output.WriteString(ControllerId);
      }
      if (controller_ != null) {
        output.WriteRawTag(26);
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
            if (Parent.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Parent);
            }
            if (HasControllerId)
            {
                output.WriteRawTag(18);
                output.WriteString(ControllerId);
            }
            if (controller_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Controller);
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
            if (HasControllerId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(ControllerId);
            }
            if (controller_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Controller);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateControllerRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.HasControllerId)
            {
                ControllerId = other.ControllerId;
            }
            if (other.controller_ != null)
            {
                if (controller_ == null)
                {
                    Controller = new Controller();
                }
                Controller.MergeFrom(other.Controller);
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
            ControllerId = input.ReadString();
            break;
          }
          case 26: {
            if (controller_ == null) {
              Controller = new Saltoapis.Nebula.Controller.V1.Controller();
            }
            input.ReadMessage(Controller);
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
                            ControllerId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (controller_ == null)
                            {
                                Controller = new Controller();
                            }
                            input.ReadMessage(Controller);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [GetController][salto.nebula.controller.v1.ControllerService.GetController]
    /// </summary>
    public sealed partial class GetControllerRequest : IMessage<GetControllerRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetControllerRequest> _parser = new(() => new GetControllerRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetControllerRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetControllerRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetControllerRequest(GetControllerRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetControllerRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested controller resource. For example:
        /// `installations/surelock-homes-hq/controllers/dancing-men`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetControllerRequest);
        public bool Equals(GetControllerRequest other)
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

        public void MergeFrom(GetControllerRequest other)
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
    /// The request message for [ListControllers][salto.nebula.controller.v1.ControllerService.ListControllers]
    /// </summary>
    public sealed partial class ListControllersRequest : IMessage<ListControllersRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListControllersRequest> _parser = new(() => new ListControllersRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListControllersRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListControllersRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListControllersRequest(ListControllersRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListControllersRequest Clone() => new(this);
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
        /// A filter that chooses which controllers to return.
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

        public override bool Equals(object other) => Equals(other as ListControllersRequest);
        public bool Equals(ListControllersRequest other)
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

        public void MergeFrom(ListControllersRequest other)
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
    /// The response message for [ListControllers][salto.nebula.controllers.v1.ControllerService.ListControllers]
    /// </summary>
    public sealed partial class ListControllersResponse : IMessage<ListControllersResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListControllersResponse> _parser = new(() => new ListControllersResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListControllersResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListControllersResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListControllersResponse(ListControllersResponse other) : this()
        {
            controllers_ = other.controllers_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListControllersResponse Clone() => new(this);
        /// <summary>Field number for the "controllers" field.</summary>
        public const int ControllersFieldNumber = 1;
        private static readonly FieldCodec<Controller> _repeated_controllers_codec
            = FieldCodec.ForMessage(10, Controller.Parser);
        private readonly RepeatedField<Controller> controllers_ = [];

        /// <summary>
        /// The field name should match the noun `controllers` in the method name. There
        /// will be a maximum number of items returned based on the `page_size` field
        /// in the request.
        /// </summary>
        public RepeatedField<Controller> Controllers
        {
            get { return controllers_; }
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

        public override bool Equals(object other) => Equals(other as ListControllersResponse);
        public bool Equals(ListControllersResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!controllers_.Equals(other.controllers_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= controllers_.GetHashCode();
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
      controllers_.WriteTo(output, _repeated_controllers_codec);
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
            controllers_.WriteTo(ref output, _repeated_controllers_codec);
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
            size += controllers_.CalculateSize(_repeated_controllers_codec);
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

        public void MergeFrom(ListControllersResponse other)
        {
            if (other == null)
            {
                return;
            }
            controllers_.Add(other.controllers_);
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
            controllers_.AddEntriesFrom(input, _repeated_controllers_codec);
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
                            controllers_.AddEntriesFrom(ref input, _repeated_controllers_codec);
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
    /// The request message for [UpdateController][salto.nebula.controller.v1.ControllerService.UpdateController]
    /// </summary>
    public sealed partial class UpdateControllerRequest : IMessage<UpdateControllerRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateControllerRequest> _parser = new(() => new UpdateControllerRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateControllerRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateControllerRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateControllerRequest(UpdateControllerRequest other) : this()
        {
            controller_ = other.controller_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateControllerRequest Clone() => new(this);
        /// <summary>Field number for the "controller" field.</summary>
        public const int ControllerFieldNumber = 1;
        private Controller controller_;

        /// <summary>
        /// The controller resource which replaces the resource on the server.
        /// </summary>
        public Controller Controller
        {
            get { return controller_; }
            set
            {
                controller_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateControllerRequest);
        public bool Equals(UpdateControllerRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Controller, other.Controller)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (controller_ != null) hash ^= Controller.GetHashCode();
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
      if (controller_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Controller);
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
            if (controller_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Controller);
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
            if (controller_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Controller);
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

        public void MergeFrom(UpdateControllerRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.controller_ != null)
            {
                if (controller_ == null)
                {
                    Controller = new Controller();
                }
                Controller.MergeFrom(other.Controller);
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
            if (controller_ == null) {
              Controller = new Saltoapis.Nebula.Controller.V1.Controller();
            }
            input.ReadMessage(Controller);
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
                            if (controller_ == null)
                            {
                                Controller = new Controller();
                            }
                            input.ReadMessage(Controller);
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
    /// The request message for [DeleteController][salto.nebula.controller.v1.ControllerService.DeleteController]
    /// </summary>
    public sealed partial class DeleteControllerRequest : IMessage<DeleteControllerRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteControllerRequest> _parser = new(() => new DeleteControllerRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteControllerRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteControllerRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteControllerRequest(DeleteControllerRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteControllerRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the controller to be deleted. For example:
        /// `installations/surelock-homes-hq/controllers/dancing-men`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteControllerRequest);
        public bool Equals(DeleteControllerRequest other)
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

        public void MergeFrom(DeleteControllerRequest other)
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
    /// The request message for [`BindController`][salto.nebula.controller.v1.ControllerService.BindController]
    /// </summary>
    public sealed partial class BindControllerRequest : IMessage<BindControllerRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BindControllerRequest> _parser = new(() => new BindControllerRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BindControllerRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BindControllerRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BindControllerRequest(BindControllerRequest other) : this()
        {
            name_ = other.name_;
            deviceId_ = other.deviceId_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BindControllerRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the controller to be bound. For example:
        /// `installations/surelock-homes-hq/controllers/main-controller`.
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
        /// by SALTO, including gateways, extenders, electronic locks and so on.
        /// </summary>
        public string DeviceId
        {
            get { return deviceId_; }
            set
            {
                deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as BindControllerRequest);
        public bool Equals(BindControllerRequest other)
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

        public void MergeFrom(BindControllerRequest other)
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
    /// The empty response message for [`BindController`][salto.nebula.controller.v1.ControllerService.BindController]
    /// </summary>
    public sealed partial class BindControllerResponse : IMessage<BindControllerResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BindControllerResponse> _parser = new(() => new BindControllerResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BindControllerResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[9]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BindControllerResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BindControllerResponse(BindControllerResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BindControllerResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as BindControllerResponse);
        public bool Equals(BindControllerResponse other)
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

        public void MergeFrom(BindControllerResponse other)
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
                _unknownFields = tag switch
                {
                    _ => UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input),
                };
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`UnbindController`][salto.nebula.controller.v1.ControllerService.UnbindController]
    /// </summary>
    public sealed partial class UnbindControllerRequest : IMessage<UnbindControllerRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnbindControllerRequest> _parser = new(() => new UnbindControllerRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnbindControllerRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnbindControllerRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnbindControllerRequest(UnbindControllerRequest other) : this()
        {
            name_ = other.name_;
            force_ = other.force_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnbindControllerRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the controller to be bound. For example:
        /// `installations/surelock-homes-hq/controllers/main-controller`.
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
        /// controller. Otherwise, the request will only work if the controller
        /// isn't bound to any previous device identifier.
        /// </summary>
        public bool Force
        {
            get { return force_; }
            set
            {
                force_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UnbindControllerRequest);
        public bool Equals(UnbindControllerRequest other)
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

        public void MergeFrom(UnbindControllerRequest other)
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
    /// The empty response message for [`UnbindController`][salto.nebula.controller.v1.ControllerService.UnbindController]
    /// </summary>
    public sealed partial class UnbindControllerResponse : IMessage<UnbindControllerResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UnbindControllerResponse> _parser = new(() => new UnbindControllerResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UnbindControllerResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[11]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UnbindControllerResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UnbindControllerResponse(UnbindControllerResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UnbindControllerResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as UnbindControllerResponse);
        public bool Equals(UnbindControllerResponse other)
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

        public void MergeFrom(UnbindControllerResponse other)
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
                _unknownFields = tag switch
                {
                    _ => UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input),
                };
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`InitializeController`][salto.nebula.controller.v1.ControllerService.InitializeController]
    /// </summary>
    public sealed partial class InitializeControllerRequest : IMessage<InitializeControllerRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeControllerRequest> _parser = new(() => new InitializeControllerRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeControllerRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[12]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeControllerRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeControllerRequest(InitializeControllerRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeControllerRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the controller to be initialized. For example:
        /// `installations/surelock-homes-hq/controllers/main-controller`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as InitializeControllerRequest);
        public bool Equals(InitializeControllerRequest other)
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

        public void MergeFrom(InitializeControllerRequest other)
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
    /// The empty response message for [`InitializeController`][salto.nebula.controller.v1.ControllerService.InitializeController]
    /// </summary>
    public sealed partial class InitializeControllerResponse : IMessage<InitializeControllerResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeControllerResponse> _parser = new(() => new InitializeControllerResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeControllerResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeControllerResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeControllerResponse(InitializeControllerResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeControllerResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as InitializeControllerResponse);
        public bool Equals(InitializeControllerResponse other)
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

        public void MergeFrom(InitializeControllerResponse other)
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
                _unknownFields = tag switch
                {
                    _ => UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input),
                };
            }
        }
#endif

    }

    public sealed partial class InitializeControllerMetadata : IMessage<InitializeControllerMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<InitializeControllerMetadata> _parser = new(() => new InitializeControllerMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<InitializeControllerMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[14]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public InitializeControllerMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public InitializeControllerMetadata(InitializeControllerMetadata other) : this()
        {
            progressPercent_ = other.progressPercent_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public InitializeControllerMetadata Clone() => new(this);
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

        public override bool Equals(object other) => Equals(other as InitializeControllerMetadata);
        public bool Equals(InitializeControllerMetadata other)
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

        public void MergeFrom(InitializeControllerMetadata other)
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
    /// The request message for [`ConfigureController`][salto.nebula.controller.v1.ControllerService.ConfigureController]
    /// </summary>
    public sealed partial class ConfigureControllerRequest : IMessage<ConfigureControllerRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureControllerRequest> _parser = new(() => new ConfigureControllerRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureControllerRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[15]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureControllerRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureControllerRequest(ConfigureControllerRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureControllerRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the controller to be configured. For example:
        /// `installations/surelock-homes-hq/controllers/main-controller`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ConfigureControllerRequest);
        public bool Equals(ConfigureControllerRequest other)
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

        public void MergeFrom(ConfigureControllerRequest other)
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
    /// The empty response message for [`ConfigureController`][salto.nebula.controller.v1.ControllerService.ConfigureController]
    /// </summary>
    public sealed partial class ConfigureControllerResponse : IMessage<ConfigureControllerResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureControllerResponse> _parser = new(() => new ConfigureControllerResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureControllerResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[16]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureControllerResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureControllerResponse(ConfigureControllerResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureControllerResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ConfigureControllerResponse);
        public bool Equals(ConfigureControllerResponse other)
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

        public void MergeFrom(ConfigureControllerResponse other)
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
                _unknownFields = tag switch
                {
                    _ => UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input),
                };
            }
        }
#endif

    }

    /// <summary>
    /// The metadata message for [`ConfigureController`][salto.nebula.controller.v1.ControllerService.ConfigureController]
    /// </summary>
    public sealed partial class ConfigureControllerMetadata : IMessage<ConfigureControllerMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ConfigureControllerMetadata> _parser = new(() => new ConfigureControllerMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ConfigureControllerMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[17]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ConfigureControllerMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ConfigureControllerMetadata(ConfigureControllerMetadata other) : this()
        {
            progressPercent_ = other.progressPercent_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ConfigureControllerMetadata Clone() => new(this);
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

        public override bool Equals(object other) => Equals(other as ConfigureControllerMetadata);
        public bool Equals(ConfigureControllerMetadata other)
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

        public void MergeFrom(ConfigureControllerMetadata other)
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
    /// The request message for [`ResetController`][salto.nebula.controller.v1.ControllerService.ResetController]
    /// </summary>
    public sealed partial class ResetControllerRequest : IMessage<ResetControllerRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetControllerRequest> _parser = new(() => new ResetControllerRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetControllerRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[18]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetControllerRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetControllerRequest(ResetControllerRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetControllerRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the controller to be reset. For example:
        /// `installations/surelock-homes-hq/controllers/main-controller`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as ResetControllerRequest);
        public bool Equals(ResetControllerRequest other)
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

        public void MergeFrom(ResetControllerRequest other)
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
    /// The empty response message for [`ResetController`][salto.nebula.controller.v1.ControllerService.ResetController]
    /// </summary>
    public sealed partial class ResetControllerResponse : IMessage<ResetControllerResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetControllerResponse> _parser = new(() => new ResetControllerResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetControllerResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[19]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetControllerResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetControllerResponse(ResetControllerResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetControllerResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ResetControllerResponse);
        public bool Equals(ResetControllerResponse other)
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

        public void MergeFrom(ResetControllerResponse other)
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
                _unknownFields = tag switch
                {
                    _ => UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input),
                };
            }
        }
#endif

    }

    /// <summary>
    /// The metadata message for [`ResetController`][salto.nebula.controller.v1.ControllerService.ResetController]
    /// </summary>
    public sealed partial class ResetControllerMetadata : IMessage<ResetControllerMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ResetControllerMetadata> _parser = new(() => new ResetControllerMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ResetControllerMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[20]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ResetControllerMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ResetControllerMetadata(ResetControllerMetadata other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ResetControllerMetadata Clone() => new(this);
        public override bool Equals(object other) => Equals(other as ResetControllerMetadata);
        public bool Equals(ResetControllerMetadata other)
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

        public void MergeFrom(ResetControllerMetadata other)
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
                _unknownFields = tag switch
                {
                    _ => UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input),
                };
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`UpdateControllerFirmware`][salto.nebula.controller.v1.ControllerService.UpdateControllerFirmware]
    /// </summary>
    public sealed partial class UpdateControllerFirmwareRequest : IMessage<UpdateControllerFirmwareRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateControllerFirmwareRequest> _parser = new(() => new UpdateControllerFirmwareRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateControllerFirmwareRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[21]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateControllerFirmwareRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateControllerFirmwareRequest(UpdateControllerFirmwareRequest other) : this()
        {
            controller_ = other.controller_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateControllerFirmwareRequest Clone() => new(this);
        /// <summary>Field number for the "controller" field.</summary>
        public const int ControllerFieldNumber = 1;
        private string controller_ = "";

        /// <summary>
        /// The resource name of the controller whose firmware will be updated. For
        /// example:
        /// `installations/surelock-homes-hq/controllers/main-controller`.
        /// </summary>
        public string Controller
        {
            get { return controller_; }
            set
            {
                controller_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateControllerFirmwareRequest);
        public bool Equals(UpdateControllerFirmwareRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Controller != other.Controller) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Controller.Length != 0) hash ^= Controller.GetHashCode();
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
      if (Controller.Length != 0) {
        output.WriteRawTag(10);
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
            if (Controller.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Controller);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Controller.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Controller);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(UpdateControllerFirmwareRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Controller.Length != 0)
            {
                Controller = other.Controller;
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
                            Controller = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`UpdateControllerFirmware`][salto.nebula.controller.v1.ControllerService.UpdateControllerFirmware]
    /// </summary>
    public sealed partial class UpdateControllerFirmwareResponse : IMessage<UpdateControllerFirmwareResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateControllerFirmwareResponse> _parser = new(() => new UpdateControllerFirmwareResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateControllerFirmwareResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[22]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateControllerFirmwareResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateControllerFirmwareResponse(UpdateControllerFirmwareResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateControllerFirmwareResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as UpdateControllerFirmwareResponse);
        public bool Equals(UpdateControllerFirmwareResponse other)
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

        public void MergeFrom(UpdateControllerFirmwareResponse other)
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
                _unknownFields = tag switch
                {
                    _ => UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input),
                };
            }
        }
#endif

    }

    /// <summary>
    /// The metadata message for [`UpdateControllerFirmware`][salto.nebula.controller.v1.ControllerService.UpdateControllerFirmware]
    /// </summary>
    public sealed partial class UpdateControllerFirmwareMetadata : IMessage<UpdateControllerFirmwareMetadata>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateControllerFirmwareMetadata> _parser = new(() => new UpdateControllerFirmwareMetadata());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateControllerFirmwareMetadata> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[23]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateControllerFirmwareMetadata()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateControllerFirmwareMetadata(UpdateControllerFirmwareMetadata other) : this()
        {
            progressPercent_ = other.progressPercent_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateControllerFirmwareMetadata Clone() => new(this);
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

        public override bool Equals(object other) => Equals(other as UpdateControllerFirmwareMetadata);
        public bool Equals(UpdateControllerFirmwareMetadata other)
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

        public void MergeFrom(UpdateControllerFirmwareMetadata other)
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
    /// The request message for [`GenerateAuthorizationToken`][salto.nebula.controller.v1.ControllerService.GenerateAuthorizationToken]
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
            get { return ControllerReflection.Descriptor.MessageTypes[24]; }
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
            controller_ = other.controller_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateAuthorizationTokenRequest Clone() => new(this);
        /// <summary>Field number for the "controller" field.</summary>
        public const int ControllerFieldNumber = 1;
        private string controller_ = "";

        /// <summary>
        /// The resource name of the controller that the authorization token is
        /// generated for. For example:
        /// `installations/surelock-homes-hq/controllers/baker-street-entrance`.
        /// </summary>
        public string Controller
        {
            get { return controller_; }
            set
            {
                controller_ = ProtoPreconditions.CheckNotNull(value, "value");
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
            if (Controller != other.Controller) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Controller.Length != 0) hash ^= Controller.GetHashCode();
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
      if (Controller.Length != 0) {
        output.WriteRawTag(10);
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
            if (Controller.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Controller);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Controller.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Controller);
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
            if (other.Controller.Length != 0)
            {
                Controller = other.Controller;
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
                            Controller = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`GenerateAuthorizationToken`][salto.nebula.controller.v1.ControllerService.GenerateAuthorizationToken]
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
            get { return ControllerReflection.Descriptor.MessageTypes[25]; }
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
        /// Authorization token to be used for connecting against a controller.
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
    /// The request message for [`GenerateFirmwareDownloadUri`][salto.nebula.controller.v1.ControllerService.GenerateFirmwareDownloadUri]
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
            get { return ControllerReflection.Descriptor.MessageTypes[26]; }
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
            controller_ = other.controller_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GenerateFirmwareDownloadUriRequest Clone() => new(this);
        /// <summary>Field number for the "controller" field.</summary>
        public const int ControllerFieldNumber = 1;
        private string controller_ = "";

        /// <summary>
        /// The resource name of the controller to get the firmware download URI.
        /// For example: `installations/surelock-homes-hq/controllers/main-controller`.
        /// </summary>
        public string Controller
        {
            get { return controller_; }
            set
            {
                controller_ = ProtoPreconditions.CheckNotNull(value, "value");
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
            if (Controller != other.Controller) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Controller.Length != 0) hash ^= Controller.GetHashCode();
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
      if (Controller.Length != 0) {
        output.WriteRawTag(10);
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
            if (Controller.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Controller);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Controller.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Controller);
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
            if (other.Controller.Length != 0)
            {
                Controller = other.Controller;
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
                            Controller = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`GenerateFirmwareDownloadUri`][salto.nebula.controller.v1.ControllerService.GenerateFirmwareDownloadUri]
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
            get { return ControllerReflection.Descriptor.MessageTypes[27]; }
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
    /// The metadata message for [`GenerateFirmwareDownloadUri`][salto.nebula.controller.v1.ControllerService.GenerateFirmwareDownloadUri]
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
            get { return ControllerReflection.Descriptor.MessageTypes[28]; }
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
                _unknownFields = tag switch
                {
                    _ => UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input),
                };
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`CreateControllerRelay`][salto.nebula.controller.v1.ControllerService.CreateControllerRelay]
    /// </summary>
    public sealed partial class CreateControllerRelayRequest : IMessage<CreateControllerRelayRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateControllerRelayRequest> _parser = new(() => new CreateControllerRelayRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateControllerRelayRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[29]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateControllerRelayRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateControllerRelayRequest(CreateControllerRelayRequest other) : this()
        {
            parent_ = other.parent_;
            controllerRelayId_ = other.controllerRelayId_;
            controllerRelay_ = other.controllerRelay_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateControllerRelayRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the controller relay is to be created. For
        /// example: `installations/surelock-homes-hq/controllers/dancing-men`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "controller_relay_id" field.</summary>
        public const int ControllerRelayIdFieldNumber = 2;
        private readonly static string ControllerRelayIdDefaultValue = "";

        private string controllerRelayId_;

        /// <summary>
        /// The controller relay ID to use for this controller relay. In case it's empty the
        /// server will autogenerate a unique identifier.
        /// </summary>
        public string ControllerRelayId
        {
            get { return controllerRelayId_ ?? ControllerRelayIdDefaultValue; }
            set
            {
                controllerRelayId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "controller_relay_id" field is set</summary>
        public bool HasControllerRelayId
        {
            get { return controllerRelayId_ != null; }
        }

        /// <summary>Clears the value of the "controller_relay_id" field</summary>
        public void ClearControllerRelayId()
        {
            controllerRelayId_ = null;
        }

        /// <summary>Field number for the "controller_relay" field.</summary>
        public const int ControllerRelayFieldNumber = 3;
        private ControllerRelay controllerRelay_;

        /// <summary>
        /// The controller relay resource to be created. Client must not set the
        /// `ControllerRelay.name` field.
        /// </summary>
        public ControllerRelay ControllerRelay
        {
            get { return controllerRelay_; }
            set
            {
                controllerRelay_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateControllerRelayRequest);
        public bool Equals(CreateControllerRelayRequest other)
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
            if (ControllerRelayId != other.ControllerRelayId) return false;
            if (!Equals(ControllerRelay, other.ControllerRelay)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasControllerRelayId) hash ^= ControllerRelayId.GetHashCode();
            if (controllerRelay_ != null) hash ^= ControllerRelay.GetHashCode();
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
      if (HasControllerRelayId) {
        output.WriteRawTag(18);
        output.WriteString(ControllerRelayId);
      }
      if (controllerRelay_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ControllerRelay);
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
            if (HasControllerRelayId)
            {
                output.WriteRawTag(18);
                output.WriteString(ControllerRelayId);
            }
            if (controllerRelay_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(ControllerRelay);
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
            if (HasControllerRelayId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(ControllerRelayId);
            }
            if (controllerRelay_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(ControllerRelay);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateControllerRelayRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.HasControllerRelayId)
            {
                ControllerRelayId = other.ControllerRelayId;
            }
            if (other.controllerRelay_ != null)
            {
                if (controllerRelay_ == null)
                {
                    ControllerRelay = new ControllerRelay();
                }
                ControllerRelay.MergeFrom(other.ControllerRelay);
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
            ControllerRelayId = input.ReadString();
            break;
          }
          case 26: {
            if (controllerRelay_ == null) {
              ControllerRelay = new Saltoapis.Nebula.Controller.V1.ControllerRelay();
            }
            input.ReadMessage(ControllerRelay);
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
                            ControllerRelayId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (controllerRelay_ == null)
                            {
                                ControllerRelay = new ControllerRelay();
                            }
                            input.ReadMessage(ControllerRelay);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [GetControllerRelay][salto.nebula.controller.v1.ControllerService.GetControllerRelay]
    /// </summary>
    public sealed partial class GetControllerRelayRequest : IMessage<GetControllerRelayRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetControllerRelayRequest> _parser = new(() => new GetControllerRelayRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetControllerRelayRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[30]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetControllerRelayRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetControllerRelayRequest(GetControllerRelayRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetControllerRelayRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested controller relay resource. For example:
        /// `installations/surelock-homes-hq/controllers/dancing-men/relay/first-floor`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetControllerRelayRequest);
        public bool Equals(GetControllerRelayRequest other)
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

        public void MergeFrom(GetControllerRelayRequest other)
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
    /// The request message for [ListControllerRelays][salto.nebula.controller.v1.ControllerService.ListControllerRelays]
    /// </summary>
    public sealed partial class ListControllerRelaysRequest : IMessage<ListControllerRelaysRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListControllerRelaysRequest> _parser = new(() => new ListControllerRelaysRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListControllerRelaysRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[31]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListControllerRelaysRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListControllerRelaysRequest(ListControllerRelaysRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListControllerRelaysRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name. For example, `installations/surelock-homes-hq/controllers/dancing-men`.
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
        /// A filter that chooses which controller relays to return.
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

        public override bool Equals(object other) => Equals(other as ListControllerRelaysRequest);
        public bool Equals(ListControllerRelaysRequest other)
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

        public void MergeFrom(ListControllerRelaysRequest other)
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
    /// The response message for [ListControllerRelays][salto.nebula.controllers.v1.ControllerService.ListControllerRelays]
    /// </summary>
    public sealed partial class ListControllerRelaysResponse : IMessage<ListControllerRelaysResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListControllerRelaysResponse> _parser = new(() => new ListControllerRelaysResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListControllerRelaysResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[32]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListControllerRelaysResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListControllerRelaysResponse(ListControllerRelaysResponse other) : this()
        {
            controllerRelays_ = other.controllerRelays_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListControllerRelaysResponse Clone() => new(this);
        /// <summary>Field number for the "controller_relays" field.</summary>
        public const int ControllerRelaysFieldNumber = 1;
        private static readonly FieldCodec<ControllerRelay> _repeated_controllerRelays_codec
            = FieldCodec.ForMessage(10, ControllerRelay.Parser);
        private readonly RepeatedField<ControllerRelay> controllerRelays_ = [];

        /// <summary>
        /// The field name should match the noun `relays` in the method name. There
        /// will be a maximum number of items returned based on the `page_size` field
        /// in the request.
        /// </summary>
        public RepeatedField<ControllerRelay> ControllerRelays
        {
            get { return controllerRelays_; }
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

        public override bool Equals(object other) => Equals(other as ListControllerRelaysResponse);
        public bool Equals(ListControllerRelaysResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!controllerRelays_.Equals(other.controllerRelays_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= controllerRelays_.GetHashCode();
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
      controllerRelays_.WriteTo(output, _repeated_controllerRelays_codec);
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
            controllerRelays_.WriteTo(ref output, _repeated_controllerRelays_codec);
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
            size += controllerRelays_.CalculateSize(_repeated_controllerRelays_codec);
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

        public void MergeFrom(ListControllerRelaysResponse other)
        {
            if (other == null)
            {
                return;
            }
            controllerRelays_.Add(other.controllerRelays_);
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
            controllerRelays_.AddEntriesFrom(input, _repeated_controllerRelays_codec);
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
                            controllerRelays_.AddEntriesFrom(ref input, _repeated_controllerRelays_codec);
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
    /// The request message for [UpdateControllerRelay][salto.nebula.controller.v1.ControllerService.UpdateControllerRelay]
    /// </summary>
    public sealed partial class UpdateControllerRelayRequest : IMessage<UpdateControllerRelayRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateControllerRelayRequest> _parser = new(() => new UpdateControllerRelayRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateControllerRelayRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[33]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateControllerRelayRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateControllerRelayRequest(UpdateControllerRelayRequest other) : this()
        {
            controllerRelay_ = other.controllerRelay_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateControllerRelayRequest Clone() => new(this);
        /// <summary>Field number for the "controller_relay" field.</summary>
        public const int ControllerRelayFieldNumber = 1;
        private ControllerRelay controllerRelay_;

        /// <summary>
        /// The controller relay resource which replaces the resource on the server.
        /// </summary>
        public ControllerRelay ControllerRelay
        {
            get { return controllerRelay_; }
            set
            {
                controllerRelay_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateControllerRelayRequest);
        public bool Equals(UpdateControllerRelayRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(ControllerRelay, other.ControllerRelay)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (controllerRelay_ != null) hash ^= ControllerRelay.GetHashCode();
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
      if (controllerRelay_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ControllerRelay);
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
            if (controllerRelay_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(ControllerRelay);
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
            if (controllerRelay_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(ControllerRelay);
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

        public void MergeFrom(UpdateControllerRelayRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.controllerRelay_ != null)
            {
                if (controllerRelay_ == null)
                {
                    ControllerRelay = new ControllerRelay();
                }
                ControllerRelay.MergeFrom(other.ControllerRelay);
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
            if (controllerRelay_ == null) {
              ControllerRelay = new Saltoapis.Nebula.Controller.V1.ControllerRelay();
            }
            input.ReadMessage(ControllerRelay);
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
                            if (controllerRelay_ == null)
                            {
                                ControllerRelay = new ControllerRelay();
                            }
                            input.ReadMessage(ControllerRelay);
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
    /// The request message for [DeleteControllerRelay][salto.nebula.controller.v1.ControllerService.DeleteControllerRelay]
    /// </summary>
    public sealed partial class DeleteControllerRelayRequest : IMessage<DeleteControllerRelayRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteControllerRelayRequest> _parser = new(() => new DeleteControllerRelayRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteControllerRelayRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[34]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteControllerRelayRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteControllerRelayRequest(DeleteControllerRelayRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteControllerRelayRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the controller relay to be deleted. For example:
        /// `installations/surelock-homes-hq/controllers/dancing-men/relays/first-floor`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteControllerRelayRequest);
        public bool Equals(DeleteControllerRelayRequest other)
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

        public void MergeFrom(DeleteControllerRelayRequest other)
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
    /// The request message for [`BatchDeleteControllerRelays`][salto.nebula.controller.v1.ControllerService.BatchDeleteControllerRelays]
    /// </summary>
    public sealed partial class BatchDeleteControllerRelaysRequest : IMessage<BatchDeleteControllerRelaysRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchDeleteControllerRelaysRequest> _parser = new(() => new BatchDeleteControllerRelaysRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchDeleteControllerRelaysRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[35]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchDeleteControllerRelaysRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchDeleteControllerRelaysRequest(BatchDeleteControllerRelaysRequest other) : this()
        {
            parent_ = other.parent_;
            requests_ = other.requests_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchDeleteControllerRelaysRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the controller relays to be deleted.
        /// For example: `installations/surelock-homes-hq/controllers/dancing-men`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "requests" field.</summary>
        public const int RequestsFieldNumber = 2;
        private static readonly FieldCodec<DeleteControllerRelayRequest> _repeated_requests_codec
            = FieldCodec.ForMessage(18, DeleteControllerRelayRequest.Parser);
        private readonly RepeatedField<DeleteControllerRelayRequest> requests_ = [];

        /// <summary>
        /// The request message specifying the resources to delete.
        /// A maximum of 100 controller relays can be deleted in a batch.
        /// </summary>
        public RepeatedField<DeleteControllerRelayRequest> Requests
        {
            get { return requests_; }
        }

        public override bool Equals(object other) => Equals(other as BatchDeleteControllerRelaysRequest);
        public bool Equals(BatchDeleteControllerRelaysRequest other)
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
            if (!requests_.Equals(other.requests_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            hash ^= requests_.GetHashCode();
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
      requests_.WriteTo(output, _repeated_requests_codec);
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
            requests_.WriteTo(ref output, _repeated_requests_codec);
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
            size += requests_.CalculateSize(_repeated_requests_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BatchDeleteControllerRelaysRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            requests_.Add(other.requests_);
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
            requests_.AddEntriesFrom(input, _repeated_requests_codec);
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
                            requests_.AddEntriesFrom(ref input, _repeated_requests_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`BatchDeleteControllerRelays`][salto.nebula.controller.v1.ControllerService.BatchDeleteControllerRelays]
    /// </summary>
    public sealed partial class BatchDeleteControllerRelaysResponse : IMessage<BatchDeleteControllerRelaysResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchDeleteControllerRelaysResponse> _parser = new(() => new BatchDeleteControllerRelaysResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchDeleteControllerRelaysResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[36]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchDeleteControllerRelaysResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchDeleteControllerRelaysResponse(BatchDeleteControllerRelaysResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchDeleteControllerRelaysResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as BatchDeleteControllerRelaysResponse);
        public bool Equals(BatchDeleteControllerRelaysResponse other)
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

        public void MergeFrom(BatchDeleteControllerRelaysResponse other)
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
                _unknownFields = tag switch
                {
                    _ => UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input),
                };
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`BatchCreateControllerRelays`][salto.nebula.controller.v1.ControllerService.BatchCreateControllerRelays]
    /// </summary>
    public sealed partial class BatchCreateControllerRelaysRequest : IMessage<BatchCreateControllerRelaysRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchCreateControllerRelaysRequest> _parser = new(() => new BatchCreateControllerRelaysRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchCreateControllerRelaysRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[37]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchCreateControllerRelaysRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchCreateControllerRelaysRequest(BatchCreateControllerRelaysRequest other) : this()
        {
            parent_ = other.parent_;
            requests_ = other.requests_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchCreateControllerRelaysRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the controller relays are to be created.
        /// For example: `installations/surelock-homes-hq/controllers/dancing-men`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "requests" field.</summary>
        public const int RequestsFieldNumber = 2;
        private static readonly FieldCodec<CreateControllerRelayRequest> _repeated_requests_codec
            = FieldCodec.ForMessage(18, CreateControllerRelayRequest.Parser);
        private readonly RepeatedField<CreateControllerRelayRequest> requests_ = [];

        /// <summary>
        /// The request message specifying the resources to create.
        /// A maximum of 100 controller relays can be created in a batch.
        /// </summary>
        public RepeatedField<CreateControllerRelayRequest> Requests
        {
            get { return requests_; }
        }

        public override bool Equals(object other) => Equals(other as BatchCreateControllerRelaysRequest);
        public bool Equals(BatchCreateControllerRelaysRequest other)
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
            if (!requests_.Equals(other.requests_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            hash ^= requests_.GetHashCode();
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
      requests_.WriteTo(output, _repeated_requests_codec);
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
            requests_.WriteTo(ref output, _repeated_requests_codec);
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
            size += requests_.CalculateSize(_repeated_requests_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BatchCreateControllerRelaysRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            requests_.Add(other.requests_);
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
            requests_.AddEntriesFrom(input, _repeated_requests_codec);
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
                            requests_.AddEntriesFrom(ref input, _repeated_requests_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`BatchCreateControllerRelays`][salto.nebula.controller.v1.ControllerService.BatchCreateControllerRelays]
    /// </summary>
    public sealed partial class BatchCreateControllerRelaysResponse : IMessage<BatchCreateControllerRelaysResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchCreateControllerRelaysResponse> _parser = new(() => new BatchCreateControllerRelaysResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchCreateControllerRelaysResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[38]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchCreateControllerRelaysResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchCreateControllerRelaysResponse(BatchCreateControllerRelaysResponse other) : this()
        {
            controllerRelays_ = other.controllerRelays_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchCreateControllerRelaysResponse Clone() => new(this);
        /// <summary>Field number for the "controller_relays" field.</summary>
        public const int ControllerRelaysFieldNumber = 1;
        private static readonly FieldCodec<ControllerRelay> _repeated_controllerRelays_codec
            = FieldCodec.ForMessage(10, ControllerRelay.Parser);
        private readonly RepeatedField<ControllerRelay> controllerRelays_ = [];

        /// <summary>
        /// The controller relay resources created.
        /// </summary>
        public RepeatedField<ControllerRelay> ControllerRelays
        {
            get { return controllerRelays_; }
        }

        public override bool Equals(object other) => Equals(other as BatchCreateControllerRelaysResponse);
        public bool Equals(BatchCreateControllerRelaysResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!controllerRelays_.Equals(other.controllerRelays_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= controllerRelays_.GetHashCode();
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
      controllerRelays_.WriteTo(output, _repeated_controllerRelays_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            controllerRelays_.WriteTo(ref output, _repeated_controllerRelays_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += controllerRelays_.CalculateSize(_repeated_controllerRelays_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BatchCreateControllerRelaysResponse other)
        {
            if (other == null)
            {
                return;
            }
            controllerRelays_.Add(other.controllerRelays_);
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
            controllerRelays_.AddEntriesFrom(input, _repeated_controllerRelays_codec);
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
                            controllerRelays_.AddEntriesFrom(ref input, _repeated_controllerRelays_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`BatchUpdateControllerRelays`][salto.nebula.controller.v1.ControllerService.BatchUpdateControllerRelays]
    /// </summary>
    public sealed partial class BatchUpdateControllerRelaysRequest : IMessage<BatchUpdateControllerRelaysRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchUpdateControllerRelaysRequest> _parser = new(() => new BatchUpdateControllerRelaysRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchUpdateControllerRelaysRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[39]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchUpdateControllerRelaysRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchUpdateControllerRelaysRequest(BatchUpdateControllerRelaysRequest other) : this()
        {
            parent_ = other.parent_;
            requests_ = other.requests_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchUpdateControllerRelaysRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the controller relays to be updated.
        /// For example: `installations/surelock-homes-hq/controllers/dancing-men`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "requests" field.</summary>
        public const int RequestsFieldNumber = 2;
        private static readonly FieldCodec<UpdateControllerRelayRequest> _repeated_requests_codec
            = FieldCodec.ForMessage(18, UpdateControllerRelayRequest.Parser);
        private readonly RepeatedField<UpdateControllerRelayRequest> requests_ = [];

        /// <summary>
        /// The request message specifying the resources to update.
        /// A maximum of 100 controller relays can be updated in a batch.
        /// </summary>
        public RepeatedField<UpdateControllerRelayRequest> Requests
        {
            get { return requests_; }
        }

        public override bool Equals(object other) => Equals(other as BatchUpdateControllerRelaysRequest);
        public bool Equals(BatchUpdateControllerRelaysRequest other)
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
            if (!requests_.Equals(other.requests_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            hash ^= requests_.GetHashCode();
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
      requests_.WriteTo(output, _repeated_requests_codec);
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
            requests_.WriteTo(ref output, _repeated_requests_codec);
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
            size += requests_.CalculateSize(_repeated_requests_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BatchUpdateControllerRelaysRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            requests_.Add(other.requests_);
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
            requests_.AddEntriesFrom(input, _repeated_requests_codec);
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
                            requests_.AddEntriesFrom(ref input, _repeated_requests_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The response message for [`BatchUpdateControllerRelays`][salto.nebula.controller.v1.ControllerService.BatchUpdateControllerRelays]
    /// </summary>
    public sealed partial class BatchUpdateControllerRelaysResponse : IMessage<BatchUpdateControllerRelaysResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchUpdateControllerRelaysResponse> _parser = new(() => new BatchUpdateControllerRelaysResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchUpdateControllerRelaysResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ControllerReflection.Descriptor.MessageTypes[40]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchUpdateControllerRelaysResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchUpdateControllerRelaysResponse(BatchUpdateControllerRelaysResponse other) : this()
        {
            controllerRelays_ = other.controllerRelays_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchUpdateControllerRelaysResponse Clone() => new(this);
        /// <summary>Field number for the "controller_relays" field.</summary>
        public const int ControllerRelaysFieldNumber = 1;
        private static readonly FieldCodec<ControllerRelay> _repeated_controllerRelays_codec
            = FieldCodec.ForMessage(10, ControllerRelay.Parser);
        private readonly RepeatedField<ControllerRelay> controllerRelays_ = [];

        /// <summary>
        /// The controller relay resources updated.
        /// </summary>
        public RepeatedField<ControllerRelay> ControllerRelays
        {
            get { return controllerRelays_; }
        }

        public override bool Equals(object other) => Equals(other as BatchUpdateControllerRelaysResponse);
        public bool Equals(BatchUpdateControllerRelaysResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!controllerRelays_.Equals(other.controllerRelays_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= controllerRelays_.GetHashCode();
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
      controllerRelays_.WriteTo(output, _repeated_controllerRelays_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            controllerRelays_.WriteTo(ref output, _repeated_controllerRelays_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += controllerRelays_.CalculateSize(_repeated_controllerRelays_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BatchUpdateControllerRelaysResponse other)
        {
            if (other == null)
            {
                return;
            }
            controllerRelays_.Add(other.controllerRelays_);
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
            controllerRelays_.AddEntriesFrom(input, _repeated_controllerRelays_codec);
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
                            controllerRelays_.AddEntriesFrom(ref input, _repeated_controllerRelays_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    #endregion

}
