namespace Saltoapis.Nebula.AccessRight.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/accessright/v1/access_right.proto</summary>
    public static partial class AccessRightReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/accessright/v1/access_right.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static AccessRightReflection()
        {
            byte[] descriptorData = Convert.FromBase64String(
                string.Concat(
                  "Ci5zYWx0by9uZWJ1bGEvYWNjZXNzcmlnaHQvdjEvYWNjZXNzX3JpZ2h0LnBy",
                  "b3RvEhtzYWx0by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEaG2dvb2dsZS9wcm90",
                  "b2J1Zi9lbXB0eS5wcm90bxogZ29vZ2xlL3Byb3RvYnVmL2ZpZWxkX21hc2su",
                  "cHJvdG8aIHNhbHRvL25lYnVsYS90eXBlL3NjaGVkdWxlLnByb3RvImEKC0Fj",
                  "Y2Vzc1JpZ2h0EgwKBG5hbWUYASABKAkSFAoMZGlzcGxheV9uYW1lGAIgASgJ",
                  "Ei4KCXNjaGVkdWxlcxgFIAMoCzIbLnNhbHRvLm5lYnVsYS50eXBlLlNjaGVk",
                  "dWxlIlIKFkFjY2Vzc1JpZ2h0QWNjZXNzUG9pbnQSDAoEbmFtZRgBIAEoCRIU",
                  "CgxhY2Nlc3NfcG9pbnQYAiABKAkSFAoMZGlzcGxheV9uYW1lGAMgASgJIl0K",
                  "G0FjY2Vzc1JpZ2h0QWNjZXNzUG9pbnRHcm91cBIMCgRuYW1lGAEgASgJEhoK",
                  "EmFjY2Vzc19wb2ludF9ncm91cBgCIAEoCRIUCgxkaXNwbGF5X25hbWUYAyAB",
                  "KAkiUQoWQWNjZXNzUmlnaHREZXN0aW5hdGlvbhIMCgRuYW1lGAEgASgJEhMK",
                  "C2Rlc3RpbmF0aW9uGAIgASgJEhQKDGRpc3BsYXlfbmFtZRgDIAEoCSKcAQoY",
                  "Q3JlYXRlQWNjZXNzUmlnaHRSZXF1ZXN0Eg4KBnBhcmVudBgBIAEoCRIcCg9h",
                  "Y2Nlc3NfcmlnaHRfaWQYAiABKAlIAIgBARI+CgxhY2Nlc3NfcmlnaHQYAyAB",
                  "KAsyKC5zYWx0by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEuQWNjZXNzUmlnaHRC",
                  "EgoQX2FjY2Vzc19yaWdodF9pZCIlChVHZXRBY2Nlc3NSaWdodFJlcXVlc3QS",
                  "DAoEbmFtZRgBIAEoCSJyChdMaXN0QWNjZXNzUmlnaHRzUmVxdWVzdBIOCgZw",
                  "YXJlbnQYASABKAkSEQoJcGFnZV9zaXplGAIgASgFEhIKCnBhZ2VfdG9rZW4Y",
                  "AyABKAkSDgoGZmlsdGVyGAQgASgJEhAKCG9yZGVyX2J5GAUgASgJInQKGExp",
                  "c3RBY2Nlc3NSaWdodHNSZXNwb25zZRI/Cg1hY2Nlc3NfcmlnaHRzGAEgAygL",
                  "Miguc2FsdG8ubmVidWxhLmFjY2Vzc3JpZ2h0LnYxLkFjY2Vzc1JpZ2h0EhcK",
                  "D25leHRfcGFnZV90b2tlbhgCIAEoCSKLAQoYVXBkYXRlQWNjZXNzUmlnaHRS",
                  "ZXF1ZXN0Ej4KDGFjY2Vzc19yaWdodBgBIAEoCzIoLnNhbHRvLm5lYnVsYS5h",
                  "Y2Nlc3NyaWdodC52MS5BY2Nlc3NSaWdodBIvCgt1cGRhdGVfbWFzaxgCIAEo",
                  "CzIaLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE1hc2siKAoYRGVsZXRlQWNjZXNz",
                  "UmlnaHRSZXF1ZXN0EgwKBG5hbWUYASABKAkijQEKI0NyZWF0ZUFjY2Vzc1Jp",
                  "Z2h0QWNjZXNzUG9pbnRSZXF1ZXN0Eg4KBnBhcmVudBgBIAEoCRJWChlhY2Nl",
                  "c3NfcmlnaHRfYWNjZXNzX3BvaW50GAIgASgLMjMuc2FsdG8ubmVidWxhLmFj",
                  "Y2Vzc3JpZ2h0LnYxLkFjY2Vzc1JpZ2h0QWNjZXNzUG9pbnQijwEKKUJhdGNo",
                  "Q3JlYXRlQWNjZXNzUmlnaHRBY2Nlc3NQb2ludHNSZXF1ZXN0Eg4KBnBhcmVu",
                  "dBgBIAEoCRJSCghyZXF1ZXN0cxgCIAMoCzJALnNhbHRvLm5lYnVsYS5hY2Nl",
                  "c3NyaWdodC52MS5DcmVhdGVBY2Nlc3NSaWdodEFjY2Vzc1BvaW50UmVxdWVz",
                  "dCKFAQoqQmF0Y2hDcmVhdGVBY2Nlc3NSaWdodEFjY2Vzc1BvaW50c1Jlc3Bv",
                  "bnNlElcKGmFjY2Vzc19yaWdodF9hY2Nlc3NfcG9pbnRzGAEgAygLMjMuc2Fs",
                  "dG8ubmVidWxhLmFjY2Vzc3JpZ2h0LnYxLkFjY2Vzc1JpZ2h0QWNjZXNzUG9p",
                  "bnQiMAogR2V0QWNjZXNzUmlnaHRBY2Nlc3NQb2ludFJlcXVlc3QSDAoEbmFt",
                  "ZRgBIAEoCSJ9CiJMaXN0QWNjZXNzUmlnaHRBY2Nlc3NQb2ludHNSZXF1ZXN0",
                  "Eg4KBnBhcmVudBgBIAEoCRIRCglwYWdlX3NpemUYAiABKAUSEgoKcGFnZV90",
                  "b2tlbhgDIAEoCRIOCgZmaWx0ZXIYBCABKAkSEAoIb3JkZXJfYnkYBSABKAki",
                  "lwEKI0xpc3RBY2Nlc3NSaWdodEFjY2Vzc1BvaW50c1Jlc3BvbnNlElcKGmFj",
                  "Y2Vzc19yaWdodF9hY2Nlc3NfcG9pbnRzGAEgAygLMjMuc2FsdG8ubmVidWxh",
                  "LmFjY2Vzc3JpZ2h0LnYxLkFjY2Vzc1JpZ2h0QWNjZXNzUG9pbnQSFwoPbmV4",
                  "dF9wYWdlX3Rva2VuGAIgASgJIq4BCiNVcGRhdGVBY2Nlc3NSaWdodEFjY2Vz",
                  "c1BvaW50UmVxdWVzdBJWChlhY2Nlc3NfcmlnaHRfYWNjZXNzX3BvaW50GAEg",
                  "ASgLMjMuc2FsdG8ubmVidWxhLmFjY2Vzc3JpZ2h0LnYxLkFjY2Vzc1JpZ2h0",
                  "QWNjZXNzUG9pbnQSLwoLdXBkYXRlX21hc2sYAiABKAsyGi5nb29nbGUucHJv",
                  "dG9idWYuRmllbGRNYXNrIjMKI0RlbGV0ZUFjY2Vzc1JpZ2h0QWNjZXNzUG9p",
                  "bnRSZXF1ZXN0EgwKBG5hbWUYASABKAkinQEKKENyZWF0ZUFjY2Vzc1JpZ2h0",
                  "QWNjZXNzUG9pbnRHcm91cFJlcXVlc3QSDgoGcGFyZW50GAEgASgJEmEKH2Fj",
                  "Y2Vzc19yaWdodF9hY2Nlc3NfcG9pbnRfZ3JvdXAYAiABKAsyOC5zYWx0by5u",
                  "ZWJ1bGEuYWNjZXNzcmlnaHQudjEuQWNjZXNzUmlnaHRBY2Nlc3NQb2ludEdy",
                  "b3VwIpkBCi5CYXRjaENyZWF0ZUFjY2Vzc1JpZ2h0QWNjZXNzUG9pbnRHcm91",
                  "cHNSZXF1ZXN0Eg4KBnBhcmVudBgBIAEoCRJXCghyZXF1ZXN0cxgCIAMoCzJF",
                  "LnNhbHRvLm5lYnVsYS5hY2Nlc3NyaWdodC52MS5DcmVhdGVBY2Nlc3NSaWdo",
                  "dEFjY2Vzc1BvaW50R3JvdXBSZXF1ZXN0IpUBCi9CYXRjaENyZWF0ZUFjY2Vz",
                  "c1JpZ2h0QWNjZXNzUG9pbnRHcm91cHNSZXNwb25zZRJiCiBhY2Nlc3Nfcmln",
                  "aHRfYWNjZXNzX3BvaW50X2dyb3VwcxgBIAMoCzI4LnNhbHRvLm5lYnVsYS5h",
                  "Y2Nlc3NyaWdodC52MS5BY2Nlc3NSaWdodEFjY2Vzc1BvaW50R3JvdXAiNQol",
                  "R2V0QWNjZXNzUmlnaHRBY2Nlc3NQb2ludEdyb3VwUmVxdWVzdBIMCgRuYW1l",
                  "GAEgASgJIoIBCidMaXN0QWNjZXNzUmlnaHRBY2Nlc3NQb2ludEdyb3Vwc1Jl",
                  "cXVlc3QSDgoGcGFyZW50GAEgASgJEhEKCXBhZ2Vfc2l6ZRgCIAEoBRISCgpw",
                  "YWdlX3Rva2VuGAMgASgJEg4KBmZpbHRlchgEIAEoCRIQCghvcmRlcl9ieRgF",
                  "IAEoCSKnAQooTGlzdEFjY2Vzc1JpZ2h0QWNjZXNzUG9pbnRHcm91cHNSZXNw",
                  "b25zZRJiCiBhY2Nlc3NfcmlnaHRfYWNjZXNzX3BvaW50X2dyb3VwcxgBIAMo",
                  "CzI4LnNhbHRvLm5lYnVsYS5hY2Nlc3NyaWdodC52MS5BY2Nlc3NSaWdodEFj",
                  "Y2Vzc1BvaW50R3JvdXASFwoPbmV4dF9wYWdlX3Rva2VuGAIgASgJIr4BCihV",
                  "cGRhdGVBY2Nlc3NSaWdodEFjY2Vzc1BvaW50R3JvdXBSZXF1ZXN0EmEKH2Fj",
                  "Y2Vzc19yaWdodF9hY2Nlc3NfcG9pbnRfZ3JvdXAYASABKAsyOC5zYWx0by5u",
                  "ZWJ1bGEuYWNjZXNzcmlnaHQudjEuQWNjZXNzUmlnaHRBY2Nlc3NQb2ludEdy",
                  "b3VwEi8KC3VwZGF0ZV9tYXNrGAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLkZp",
                  "ZWxkTWFzayI4CihEZWxldGVBY2Nlc3NSaWdodEFjY2Vzc1BvaW50R3JvdXBS",
                  "ZXF1ZXN0EgwKBG5hbWUYASABKAkimQEKLkJhdGNoRGVsZXRlQWNjZXNzUmln",
                  "aHRBY2Nlc3NQb2ludEdyb3Vwc1JlcXVlc3QSDgoGcGFyZW50GAEgASgJElcK",
                  "CHJlcXVlc3RzGAIgAygLMkUuc2FsdG8ubmVidWxhLmFjY2Vzc3JpZ2h0LnYx",
                  "LkRlbGV0ZUFjY2Vzc1JpZ2h0QWNjZXNzUG9pbnRHcm91cFJlcXVlc3QiMQov",
                  "QmF0Y2hEZWxldGVBY2Nlc3NSaWdodEFjY2Vzc1BvaW50R3JvdXBzUmVzcG9u",
                  "c2UijwEKKUJhdGNoRGVsZXRlQWNjZXNzUmlnaHRBY2Nlc3NQb2ludHNSZXF1",
                  "ZXN0Eg4KBnBhcmVudBgBIAEoCRJSCghyZXF1ZXN0cxgCIAMoCzJALnNhbHRv",
                  "Lm5lYnVsYS5hY2Nlc3NyaWdodC52MS5EZWxldGVBY2Nlc3NSaWdodEFjY2Vz",
                  "c1BvaW50UmVxdWVzdCIsCipCYXRjaERlbGV0ZUFjY2Vzc1JpZ2h0QWNjZXNz",
                  "UG9pbnRzUmVzcG9uc2UijAEKI0NyZWF0ZUFjY2Vzc1JpZ2h0RGVzdGluYXRp",
                  "b25SZXF1ZXN0Eg4KBnBhcmVudBgBIAEoCRJVChhhY2Nlc3NfcmlnaHRfZGVz",
                  "dGluYXRpb24YAiABKAsyMy5zYWx0by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEu",
                  "QWNjZXNzUmlnaHREZXN0aW5hdGlvbiIwCiBHZXRBY2Nlc3NSaWdodERlc3Rp",
                  "bmF0aW9uUmVxdWVzdBIMCgRuYW1lGAEgASgJIn0KIkxpc3RBY2Nlc3NSaWdo",
                  "dERlc3RpbmF0aW9uc1JlcXVlc3QSDgoGcGFyZW50GAEgASgJEhEKCXBhZ2Vf",
                  "c2l6ZRgCIAEoBRISCgpwYWdlX3Rva2VuGAMgASgJEg4KBmZpbHRlchgEIAEo",
                  "CRIQCghvcmRlcl9ieRgFIAEoCSKWAQojTGlzdEFjY2Vzc1JpZ2h0RGVzdGlu",
                  "YXRpb25zUmVzcG9uc2USVgoZYWNjZXNzX3JpZ2h0X2Rlc3RpbmF0aW9ucxgB",
                  "IAMoCzIzLnNhbHRvLm5lYnVsYS5hY2Nlc3NyaWdodC52MS5BY2Nlc3NSaWdo",
                  "dERlc3RpbmF0aW9uEhcKD25leHRfcGFnZV90b2tlbhgCIAEoCSKtAQojVXBk",
                  "YXRlQWNjZXNzUmlnaHREZXN0aW5hdGlvblJlcXVlc3QSVQoYYWNjZXNzX3Jp",
                  "Z2h0X2Rlc3RpbmF0aW9uGAEgASgLMjMuc2FsdG8ubmVidWxhLmFjY2Vzc3Jp",
                  "Z2h0LnYxLkFjY2Vzc1JpZ2h0RGVzdGluYXRpb24SLwoLdXBkYXRlX21hc2sY",
                  "AiABKAsyGi5nb29nbGUucHJvdG9idWYuRmllbGRNYXNrIjMKI0RlbGV0ZUFj",
                  "Y2Vzc1JpZ2h0RGVzdGluYXRpb25SZXF1ZXN0EgwKBG5hbWUYASABKAkytxwK",
                  "EkFjY2Vzc1JpZ2h0U2VydmljZRJ0ChFDcmVhdGVBY2Nlc3NSaWdodBI1LnNh",
                  "bHRvLm5lYnVsYS5hY2Nlc3NyaWdodC52MS5DcmVhdGVBY2Nlc3NSaWdodFJl",
                  "cXVlc3QaKC5zYWx0by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEuQWNjZXNzUmln",
                  "aHQSbgoOR2V0QWNjZXNzUmlnaHQSMi5zYWx0by5uZWJ1bGEuYWNjZXNzcmln",
                  "aHQudjEuR2V0QWNjZXNzUmlnaHRSZXF1ZXN0Giguc2FsdG8ubmVidWxhLmFj",
                  "Y2Vzc3JpZ2h0LnYxLkFjY2Vzc1JpZ2h0En8KEExpc3RBY2Nlc3NSaWdodHMS",
                  "NC5zYWx0by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEuTGlzdEFjY2Vzc1JpZ2h0",
                  "c1JlcXVlc3QaNS5zYWx0by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEuTGlzdEFj",
                  "Y2Vzc1JpZ2h0c1Jlc3BvbnNlEnQKEVVwZGF0ZUFjY2Vzc1JpZ2h0EjUuc2Fs",
                  "dG8ubmVidWxhLmFjY2Vzc3JpZ2h0LnYxLlVwZGF0ZUFjY2Vzc1JpZ2h0UmVx",
                  "dWVzdBooLnNhbHRvLm5lYnVsYS5hY2Nlc3NyaWdodC52MS5BY2Nlc3NSaWdo",
                  "dBJiChFEZWxldGVBY2Nlc3NSaWdodBI1LnNhbHRvLm5lYnVsYS5hY2Nlc3Ny",
                  "aWdodC52MS5EZWxldGVBY2Nlc3NSaWdodFJlcXVlc3QaFi5nb29nbGUucHJv",
                  "dG9idWYuRW1wdHkSlQEKHENyZWF0ZUFjY2Vzc1JpZ2h0QWNjZXNzUG9pbnQS",
                  "QC5zYWx0by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEuQ3JlYXRlQWNjZXNzUmln",
                  "aHRBY2Nlc3NQb2ludFJlcXVlc3QaMy5zYWx0by5uZWJ1bGEuYWNjZXNzcmln",
                  "aHQudjEuQWNjZXNzUmlnaHRBY2Nlc3NQb2ludBK1AQoiQmF0Y2hDcmVhdGVB",
                  "Y2Nlc3NSaWdodEFjY2Vzc1BvaW50cxJGLnNhbHRvLm5lYnVsYS5hY2Nlc3Ny",
                  "aWdodC52MS5CYXRjaENyZWF0ZUFjY2Vzc1JpZ2h0QWNjZXNzUG9pbnRzUmVx",
                  "dWVzdBpHLnNhbHRvLm5lYnVsYS5hY2Nlc3NyaWdodC52MS5CYXRjaENyZWF0",
                  "ZUFjY2Vzc1JpZ2h0QWNjZXNzUG9pbnRzUmVzcG9uc2USjwEKGUdldEFjY2Vz",
                  "c1JpZ2h0QWNjZXNzUG9pbnQSPS5zYWx0by5uZWJ1bGEuYWNjZXNzcmlnaHQu",
                  "djEuR2V0QWNjZXNzUmlnaHRBY2Nlc3NQb2ludFJlcXVlc3QaMy5zYWx0by5u",
                  "ZWJ1bGEuYWNjZXNzcmlnaHQudjEuQWNjZXNzUmlnaHRBY2Nlc3NQb2ludBKg",
                  "AQobTGlzdEFjY2Vzc1JpZ2h0QWNjZXNzUG9pbnRzEj8uc2FsdG8ubmVidWxh",
                  "LmFjY2Vzc3JpZ2h0LnYxLkxpc3RBY2Nlc3NSaWdodEFjY2Vzc1BvaW50c1Jl",
                  "cXVlc3QaQC5zYWx0by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEuTGlzdEFjY2Vz",
                  "c1JpZ2h0QWNjZXNzUG9pbnRzUmVzcG9uc2USlQEKHFVwZGF0ZUFjY2Vzc1Jp",
                  "Z2h0QWNjZXNzUG9pbnQSQC5zYWx0by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEu",
                  "VXBkYXRlQWNjZXNzUmlnaHRBY2Nlc3NQb2ludFJlcXVlc3QaMy5zYWx0by5u",
                  "ZWJ1bGEuYWNjZXNzcmlnaHQudjEuQWNjZXNzUmlnaHRBY2Nlc3NQb2ludBJ4",
                  "ChxEZWxldGVBY2Nlc3NSaWdodEFjY2Vzc1BvaW50EkAuc2FsdG8ubmVidWxh",
                  "LmFjY2Vzc3JpZ2h0LnYxLkRlbGV0ZUFjY2Vzc1JpZ2h0QWNjZXNzUG9pbnRS",
                  "ZXF1ZXN0GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5ErUBCiJCYXRjaERlbGV0",
                  "ZUFjY2Vzc1JpZ2h0QWNjZXNzUG9pbnRzEkYuc2FsdG8ubmVidWxhLmFjY2Vz",
                  "c3JpZ2h0LnYxLkJhdGNoRGVsZXRlQWNjZXNzUmlnaHRBY2Nlc3NQb2ludHNS",
                  "ZXF1ZXN0Gkcuc2FsdG8ubmVidWxhLmFjY2Vzc3JpZ2h0LnYxLkJhdGNoRGVs",
                  "ZXRlQWNjZXNzUmlnaHRBY2Nlc3NQb2ludHNSZXNwb25zZRKkAQohQ3JlYXRl",
                  "QWNjZXNzUmlnaHRBY2Nlc3NQb2ludEdyb3VwEkUuc2FsdG8ubmVidWxhLmFj",
                  "Y2Vzc3JpZ2h0LnYxLkNyZWF0ZUFjY2Vzc1JpZ2h0QWNjZXNzUG9pbnRHcm91",
                  "cFJlcXVlc3QaOC5zYWx0by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEuQWNjZXNz",
                  "UmlnaHRBY2Nlc3NQb2ludEdyb3VwEsQBCidCYXRjaENyZWF0ZUFjY2Vzc1Jp",
                  "Z2h0QWNjZXNzUG9pbnRHcm91cHMSSy5zYWx0by5uZWJ1bGEuYWNjZXNzcmln",
                  "aHQudjEuQmF0Y2hDcmVhdGVBY2Nlc3NSaWdodEFjY2Vzc1BvaW50R3JvdXBz",
                  "UmVxdWVzdBpMLnNhbHRvLm5lYnVsYS5hY2Nlc3NyaWdodC52MS5CYXRjaENy",
                  "ZWF0ZUFjY2Vzc1JpZ2h0QWNjZXNzUG9pbnRHcm91cHNSZXNwb25zZRKeAQoe",
                  "R2V0QWNjZXNzUmlnaHRBY2Nlc3NQb2ludEdyb3VwEkIuc2FsdG8ubmVidWxh",
                  "LmFjY2Vzc3JpZ2h0LnYxLkdldEFjY2Vzc1JpZ2h0QWNjZXNzUG9pbnRHcm91",
                  "cFJlcXVlc3QaOC5zYWx0by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEuQWNjZXNz",
                  "UmlnaHRBY2Nlc3NQb2ludEdyb3VwEq8BCiBMaXN0QWNjZXNzUmlnaHRBY2Nl",
                  "c3NQb2ludEdyb3VwcxJELnNhbHRvLm5lYnVsYS5hY2Nlc3NyaWdodC52MS5M",
                  "aXN0QWNjZXNzUmlnaHRBY2Nlc3NQb2ludEdyb3Vwc1JlcXVlc3QaRS5zYWx0",
                  "by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEuTGlzdEFjY2Vzc1JpZ2h0QWNjZXNz",
                  "UG9pbnRHcm91cHNSZXNwb25zZRKkAQohVXBkYXRlQWNjZXNzUmlnaHRBY2Nl",
                  "c3NQb2ludEdyb3VwEkUuc2FsdG8ubmVidWxhLmFjY2Vzc3JpZ2h0LnYxLlVw",
                  "ZGF0ZUFjY2Vzc1JpZ2h0QWNjZXNzUG9pbnRHcm91cFJlcXVlc3QaOC5zYWx0",
                  "by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEuQWNjZXNzUmlnaHRBY2Nlc3NQb2lu",
                  "dEdyb3VwEoIBCiFEZWxldGVBY2Nlc3NSaWdodEFjY2Vzc1BvaW50R3JvdXAS",
                  "RS5zYWx0by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEuRGVsZXRlQWNjZXNzUmln",
                  "aHRBY2Nlc3NQb2ludEdyb3VwUmVxdWVzdBoWLmdvb2dsZS5wcm90b2J1Zi5F",
                  "bXB0eRLEAQonQmF0Y2hEZWxldGVBY2Nlc3NSaWdodEFjY2Vzc1BvaW50R3Jv",
                  "dXBzEksuc2FsdG8ubmVidWxhLmFjY2Vzc3JpZ2h0LnYxLkJhdGNoRGVsZXRl",
                  "QWNjZXNzUmlnaHRBY2Nlc3NQb2ludEdyb3Vwc1JlcXVlc3QaTC5zYWx0by5u",
                  "ZWJ1bGEuYWNjZXNzcmlnaHQudjEuQmF0Y2hEZWxldGVBY2Nlc3NSaWdodEFj",
                  "Y2Vzc1BvaW50R3JvdXBzUmVzcG9uc2USlQEKHENyZWF0ZUFjY2Vzc1JpZ2h0",
                  "RGVzdGluYXRpb24SQC5zYWx0by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEuQ3Jl",
                  "YXRlQWNjZXNzUmlnaHREZXN0aW5hdGlvblJlcXVlc3QaMy5zYWx0by5uZWJ1",
                  "bGEuYWNjZXNzcmlnaHQudjEuQWNjZXNzUmlnaHREZXN0aW5hdGlvbhKPAQoZ",
                  "R2V0QWNjZXNzUmlnaHREZXN0aW5hdGlvbhI9LnNhbHRvLm5lYnVsYS5hY2Nl",
                  "c3NyaWdodC52MS5HZXRBY2Nlc3NSaWdodERlc3RpbmF0aW9uUmVxdWVzdBoz",
                  "LnNhbHRvLm5lYnVsYS5hY2Nlc3NyaWdodC52MS5BY2Nlc3NSaWdodERlc3Rp",
                  "bmF0aW9uEqABChtMaXN0QWNjZXNzUmlnaHREZXN0aW5hdGlvbnMSPy5zYWx0",
                  "by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEuTGlzdEFjY2Vzc1JpZ2h0RGVzdGlu",
                  "YXRpb25zUmVxdWVzdBpALnNhbHRvLm5lYnVsYS5hY2Nlc3NyaWdodC52MS5M",
                  "aXN0QWNjZXNzUmlnaHREZXN0aW5hdGlvbnNSZXNwb25zZRKVAQocVXBkYXRl",
                  "QWNjZXNzUmlnaHREZXN0aW5hdGlvbhJALnNhbHRvLm5lYnVsYS5hY2Nlc3Ny",
                  "aWdodC52MS5VcGRhdGVBY2Nlc3NSaWdodERlc3RpbmF0aW9uUmVxdWVzdBoz",
                  "LnNhbHRvLm5lYnVsYS5hY2Nlc3NyaWdodC52MS5BY2Nlc3NSaWdodERlc3Rp",
                  "bmF0aW9uEngKHERlbGV0ZUFjY2Vzc1JpZ2h0RGVzdGluYXRpb24SQC5zYWx0",
                  "by5uZWJ1bGEuYWNjZXNzcmlnaHQudjEuRGVsZXRlQWNjZXNzUmlnaHREZXN0",
                  "aW5hdGlvblJlcXVlc3QaFi5nb29nbGUucHJvdG9idWYuRW1wdHlC+QEKI2Nv",
                  "bS5zYWx0b2FwaXMubmVidWxhLmFjY2Vzc3JpZ2h0LnYxQhBBY2Nlc3NSaWdo",
                  "dFByb3RvUAFaTGdpdGh1Yi5jb20vc2FsdG9hcGlzLWludGVybmFsL3NhbHRv",
                  "YXBpcy1nby9uZWJ1bGEvYWNjZXNzcmlnaHQvdjE7YWNjZXNzcmlnaHSqAh9T",
                  "YWx0b2FwaXMuTmVidWxhLkFjY2Vzc1JpZ2h0LlYxygIfU2FsdG9hcGlzXE5l",
                  "YnVsYVxBY2Nlc3NSaWdodFxWMeICK0dQQk1ldGFkYXRhXFNhbHRvYXBpc1xO",
                  "ZWJ1bGFcQWNjZXNzUmlnaHRcVjFiBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Type.ScheduleReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(AccessRight), AccessRight.Parser, ["Name", "DisplayName", "Schedules"], null, null, null, null),
            new(typeof(AccessRightAccessPoint), AccessRightAccessPoint.Parser, ["Name", "AccessPoint", "DisplayName"], null, null, null, null),
            new(typeof(AccessRightAccessPointGroup), AccessRightAccessPointGroup.Parser, ["Name", "AccessPointGroup", "DisplayName"], null, null, null, null),
            new(typeof(AccessRightDestination), AccessRightDestination.Parser, ["Name", "Destination", "DisplayName"], null, null, null, null),
            new(typeof(CreateAccessRightRequest), CreateAccessRightRequest.Parser, ["Parent", "AccessRightId", "AccessRight"], ["AccessRightId"], null, null, null),
            new(typeof(GetAccessRightRequest), GetAccessRightRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListAccessRightsRequest), ListAccessRightsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListAccessRightsResponse), ListAccessRightsResponse.Parser, ["AccessRights", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateAccessRightRequest), UpdateAccessRightRequest.Parser, ["AccessRight", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteAccessRightRequest), DeleteAccessRightRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(CreateAccessRightAccessPointRequest), CreateAccessRightAccessPointRequest.Parser, ["Parent", "AccessRightAccessPoint"], null, null, null, null),
            new(typeof(BatchCreateAccessRightAccessPointsRequest), BatchCreateAccessRightAccessPointsRequest.Parser, ["Parent", "Requests"], null, null, null, null),
            new(typeof(BatchCreateAccessRightAccessPointsResponse), BatchCreateAccessRightAccessPointsResponse.Parser, ["AccessRightAccessPoints"], null, null, null, null),
            new(typeof(GetAccessRightAccessPointRequest), GetAccessRightAccessPointRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListAccessRightAccessPointsRequest), ListAccessRightAccessPointsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListAccessRightAccessPointsResponse), ListAccessRightAccessPointsResponse.Parser, ["AccessRightAccessPoints", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateAccessRightAccessPointRequest), UpdateAccessRightAccessPointRequest.Parser, ["AccessRightAccessPoint", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteAccessRightAccessPointRequest), DeleteAccessRightAccessPointRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(CreateAccessRightAccessPointGroupRequest), CreateAccessRightAccessPointGroupRequest.Parser, ["Parent", "AccessRightAccessPointGroup"], null, null, null, null),
            new(typeof(BatchCreateAccessRightAccessPointGroupsRequest), BatchCreateAccessRightAccessPointGroupsRequest.Parser, ["Parent", "Requests"], null, null, null, null),
            new(typeof(BatchCreateAccessRightAccessPointGroupsResponse), BatchCreateAccessRightAccessPointGroupsResponse.Parser, ["AccessRightAccessPointGroups"], null, null, null, null),
            new(typeof(GetAccessRightAccessPointGroupRequest), GetAccessRightAccessPointGroupRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListAccessRightAccessPointGroupsRequest), ListAccessRightAccessPointGroupsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListAccessRightAccessPointGroupsResponse), ListAccessRightAccessPointGroupsResponse.Parser, ["AccessRightAccessPointGroups", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateAccessRightAccessPointGroupRequest), UpdateAccessRightAccessPointGroupRequest.Parser, ["AccessRightAccessPointGroup", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteAccessRightAccessPointGroupRequest), DeleteAccessRightAccessPointGroupRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(BatchDeleteAccessRightAccessPointGroupsRequest), BatchDeleteAccessRightAccessPointGroupsRequest.Parser, ["Parent", "Requests"], null, null, null, null),
            new(typeof(BatchDeleteAccessRightAccessPointGroupsResponse), BatchDeleteAccessRightAccessPointGroupsResponse.Parser, null, null, null, null, null),
            new(typeof(BatchDeleteAccessRightAccessPointsRequest), BatchDeleteAccessRightAccessPointsRequest.Parser, ["Parent", "Requests"], null, null, null, null),
            new(typeof(BatchDeleteAccessRightAccessPointsResponse), BatchDeleteAccessRightAccessPointsResponse.Parser, null, null, null, null, null),
            new(typeof(CreateAccessRightDestinationRequest), CreateAccessRightDestinationRequest.Parser, ["Parent", "AccessRightDestination"], null, null, null, null),
            new(typeof(GetAccessRightDestinationRequest), GetAccessRightDestinationRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListAccessRightDestinationsRequest), ListAccessRightDestinationsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListAccessRightDestinationsResponse), ListAccessRightDestinationsResponse.Parser, ["AccessRightDestinations", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateAccessRightDestinationRequest), UpdateAccessRightDestinationRequest.Parser, ["AccessRightDestination", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteAccessRightDestinationRequest), DeleteAccessRightDestinationRequest.Parser, ["Name"], null, null, null, null)
                ]));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// The access right object
    /// </summary>
    public sealed partial class AccessRight : IMessage<AccessRight>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessRight> _parser = new(() => new AccessRight());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessRight> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessRight()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessRight(AccessRight other) : this()
        {
            name_ = other.name_;
            displayName_ = other.displayName_;
            schedules_ = other.schedules_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessRight Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the access right. It must have the format
        /// of `installations/*/access-rights/*`. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville`.
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
        /// Display name of the access right.
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
        public const int SchedulesFieldNumber = 5;
        private static readonly FieldCodec<Type.Schedule> _repeated_schedules_codec
            = FieldCodec.ForMessage(42, Type.Schedule.Parser);
        private readonly RepeatedField<Type.Schedule> schedules_ = [];

        /// <summary>
        /// Schedules in which this access right is applied.
        /// </summary>
        public RepeatedField<Type.Schedule> Schedules
        {
            get { return schedules_; }
        }

        public override bool Equals(object other) => Equals(other as AccessRight);
        public bool Equals(AccessRight other)
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
            if (!schedules_.Equals(other.schedules_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
            hash ^= schedules_.GetHashCode();
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
      schedules_.WriteTo(output, _repeated_schedules_codec);
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
            schedules_.WriteTo(ref output, _repeated_schedules_codec);
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
            size += schedules_.CalculateSize(_repeated_schedules_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(AccessRight other)
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
            schedules_.Add(other.schedules_);
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
          case 42: {
            schedules_.AddEntriesFrom(input, _repeated_schedules_codec);
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
                    case 42:
                        {
                            schedules_.AddEntriesFrom(ref input, _repeated_schedules_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The access right's access point association
    /// </summary>
    public sealed partial class AccessRightAccessPoint : IMessage<AccessRightAccessPoint>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessRightAccessPoint> _parser = new(() => new AccessRightAccessPoint());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessRightAccessPoint> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessRightAccessPoint()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessRightAccessPoint(AccessRightAccessPoint other) : this()
        {
            name_ = other.name_;
            accessPoint_ = other.accessPoint_;
            displayName_ = other.displayName_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessRightAccessPoint Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the access right's access point association. It must
        /// have the format of `installations/*/access-rights/*/access-points/*`.
        /// For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville/access-points/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "access_point" field.</summary>
        public const int AccessPointFieldNumber = 2;
        private string accessPoint_ = "";

        /// <summary>
        /// The access point resource name to bind as an association to the parent
        /// access right. For example:
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

        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 3;
        private string displayName_ = "";

        /// <summary>
        /// Display name of the associated entity. In this case an access point.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as AccessRightAccessPoint);
        public bool Equals(AccessRightAccessPoint other)
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
            if (AccessPoint != other.AccessPoint) return false;
            if (DisplayName != other.DisplayName) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (AccessPoint.Length != 0) hash ^= AccessPoint.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
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
      if (AccessPoint.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AccessPoint);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DisplayName);
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
            if (AccessPoint.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(AccessPoint);
            }
            if (DisplayName.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(DisplayName);
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
            if (AccessPoint.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(AccessPoint);
            }
            if (DisplayName.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(AccessRightAccessPoint other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.AccessPoint.Length != 0)
            {
                AccessPoint = other.AccessPoint;
            }
            if (other.DisplayName.Length != 0)
            {
                DisplayName = other.DisplayName;
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
            AccessPoint = input.ReadString();
            break;
          }
          case 26: {
            DisplayName = input.ReadString();
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
                            AccessPoint = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            DisplayName = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The access right's access point group association
    /// </summary>
    public sealed partial class AccessRightAccessPointGroup : IMessage<AccessRightAccessPointGroup>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessRightAccessPointGroup> _parser = new(() => new AccessRightAccessPointGroup());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessRightAccessPointGroup> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessRightAccessPointGroup()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessRightAccessPointGroup(AccessRightAccessPointGroup other) : this()
        {
            name_ = other.name_;
            accessPointGroup_ = other.accessPointGroup_;
            displayName_ = other.displayName_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessRightAccessPointGroup Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the access right's access point group association. It
        /// must have the format of
        /// `installations/*/access-rights/*/access-point-groups/*`. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville/access-point-groups/common-accesses`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "access_point_group" field.</summary>
        public const int AccessPointGroupFieldNumber = 2;
        private string accessPointGroup_ = "";

        /// <summary>
        /// The access point group resource name to bind as an association to the
        /// parent access right. For example:
        /// `installations/surelock-homes-hq/access-point-groups/common-accesses`.
        /// </summary>
        public string AccessPointGroup
        {
            get { return accessPointGroup_; }
            set
            {
                accessPointGroup_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 3;
        private string displayName_ = "";

        /// <summary>
        /// Display name of the associated entity. In this case an access point group.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as AccessRightAccessPointGroup);
        public bool Equals(AccessRightAccessPointGroup other)
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
            if (AccessPointGroup != other.AccessPointGroup) return false;
            if (DisplayName != other.DisplayName) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (AccessPointGroup.Length != 0) hash ^= AccessPointGroup.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
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
      if (AccessPointGroup.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AccessPointGroup);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DisplayName);
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
            if (AccessPointGroup.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(AccessPointGroup);
            }
            if (DisplayName.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(DisplayName);
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
            if (AccessPointGroup.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(AccessPointGroup);
            }
            if (DisplayName.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(AccessRightAccessPointGroup other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.AccessPointGroup.Length != 0)
            {
                AccessPointGroup = other.AccessPointGroup;
            }
            if (other.DisplayName.Length != 0)
            {
                DisplayName = other.DisplayName;
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
            AccessPointGroup = input.ReadString();
            break;
          }
          case 26: {
            DisplayName = input.ReadString();
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
                            AccessPointGroup = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            DisplayName = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The access right's destination association
    /// </summary>
    public sealed partial class AccessRightDestination : IMessage<AccessRightDestination>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<AccessRightDestination> _parser = new(() => new AccessRightDestination());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<AccessRightDestination> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public AccessRightDestination()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public AccessRightDestination(AccessRightDestination other) : this()
        {
            name_ = other.name_;
            destination_ = other.destination_;
            displayName_ = other.displayName_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public AccessRightDestination Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Resource name of the access right's destination association. It must
        /// have the format of `installations/*/access-rights/*/destinations/*`.
        /// For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville/destinations/elevator-floor-5`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "destination" field.</summary>
        public const int DestinationFieldNumber = 2;
        private string destination_ = "";

        /// <summary>
        /// The destination resource name to bind as an association to the parent
        /// access right. For example:
        /// `installations/surelock-homes-hq/destinations/elevator-floor-5`.
        /// </summary>
        public string Destination
        {
            get { return destination_; }
            set
            {
                destination_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "display_name" field.</summary>
        public const int DisplayNameFieldNumber = 3;
        private string displayName_ = "";

        /// <summary>
        /// Display name of the associated entity. In this case a destination.
        /// </summary>
        public string DisplayName
        {
            get { return displayName_; }
            set
            {
                displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as AccessRightDestination);
        public bool Equals(AccessRightDestination other)
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
            if (Destination != other.Destination) return false;
            if (DisplayName != other.DisplayName) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (Destination.Length != 0) hash ^= Destination.GetHashCode();
            if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
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
      if (Destination.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Destination);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DisplayName);
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
            if (Destination.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Destination);
            }
            if (DisplayName.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(DisplayName);
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
            if (Destination.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Destination);
            }
            if (DisplayName.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(AccessRightDestination other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.Destination.Length != 0)
            {
                Destination = other.Destination;
            }
            if (other.DisplayName.Length != 0)
            {
                DisplayName = other.DisplayName;
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
            Destination = input.ReadString();
            break;
          }
          case 26: {
            DisplayName = input.ReadString();
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
                            Destination = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            DisplayName = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`CreateAccessRight`][salto.nebula.accessright.v1.AccessRightService.CreateAccessRight]
    /// </summary>
    public sealed partial class CreateAccessRightRequest : IMessage<CreateAccessRightRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateAccessRightRequest> _parser = new(() => new CreateAccessRightRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateAccessRightRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateAccessRightRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateAccessRightRequest(CreateAccessRightRequest other) : this()
        {
            parent_ = other.parent_;
            accessRightId_ = other.accessRightId_;
            accessRight_ = other.accessRight_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateAccessRightRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the access right is to be
        /// created. For example: `installations/surelock-homes-hq`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "access_right_id" field.</summary>
        public const int AccessRightIdFieldNumber = 2;
        private readonly static string AccessRightIdDefaultValue = "";

        private string accessRightId_;

        /// <summary>
        /// The access right ID to use for this access right. In case it's
        /// empty the server will autogenerate a unique identifier.
        /// </summary>
        public string AccessRightId
        {
            get { return accessRightId_ ?? AccessRightIdDefaultValue; }
            set
            {
                accessRightId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "access_right_id" field is set</summary>
        public bool HasAccessRightId
        {
            get { return accessRightId_ != null; }
        }

        /// <summary>Clears the value of the "access_right_id" field</summary>
        public void ClearAccessRightId()
        {
            accessRightId_ = null;
        }

        /// <summary>Field number for the "access_right" field.</summary>
        public const int AccessRightFieldNumber = 3;
        private AccessRight accessRight_;

        /// <summary>
        /// The access right resource to be created. Client must not set the
        /// `AccessRight.name` field.
        /// </summary>
        public AccessRight AccessRight
        {
            get { return accessRight_; }
            set
            {
                accessRight_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateAccessRightRequest);
        public bool Equals(CreateAccessRightRequest other)
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
            if (AccessRightId != other.AccessRightId) return false;
            if (!Equals(AccessRight, other.AccessRight)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasAccessRightId) hash ^= AccessRightId.GetHashCode();
            if (accessRight_ != null) hash ^= AccessRight.GetHashCode();
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
      if (HasAccessRightId) {
        output.WriteRawTag(18);
        output.WriteString(AccessRightId);
      }
      if (accessRight_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(AccessRight);
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
            if (HasAccessRightId)
            {
                output.WriteRawTag(18);
                output.WriteString(AccessRightId);
            }
            if (accessRight_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(AccessRight);
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
            if (HasAccessRightId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(AccessRightId);
            }
            if (accessRight_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(AccessRight);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateAccessRightRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.HasAccessRightId)
            {
                AccessRightId = other.AccessRightId;
            }
            if (other.accessRight_ != null)
            {
                if (accessRight_ == null)
                {
                    AccessRight = new AccessRight();
                }
                AccessRight.MergeFrom(other.AccessRight);
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
            AccessRightId = input.ReadString();
            break;
          }
          case 26: {
            if (accessRight_ == null) {
              AccessRight = new Saltoapis.Nebula.AccessRight.V1.AccessRight();
            }
            input.ReadMessage(AccessRight);
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
                            AccessRightId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (accessRight_ == null)
                            {
                                AccessRight = new AccessRight();
                            }
                            input.ReadMessage(AccessRight);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetAccessRight`][salto.nebula.accessright.v1.AccessRightService.GetAccessRight]
    /// </summary>
    public sealed partial class GetAccessRightRequest : IMessage<GetAccessRightRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetAccessRightRequest> _parser = new(() => new GetAccessRightRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetAccessRightRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetAccessRightRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetAccessRightRequest(GetAccessRightRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetAccessRightRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested access right resource. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetAccessRightRequest);
        public bool Equals(GetAccessRightRequest other)
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

        public void MergeFrom(GetAccessRightRequest other)
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
    /// The request message for [`ListAccessRights`][salto.nebula.accessright.v1.AccessRightService.ListAccessRights]
    /// </summary>
    public sealed partial class ListAccessRightsRequest : IMessage<ListAccessRightsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListAccessRightsRequest> _parser = new(() => new ListAccessRightsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListAccessRightsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListAccessRightsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListAccessRightsRequest(ListAccessRightsRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListAccessRightsRequest Clone() => new(this);
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
        /// A filter that chooses which access rights to return.
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

        public override bool Equals(object other) => Equals(other as ListAccessRightsRequest);
        public bool Equals(ListAccessRightsRequest other)
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

        public void MergeFrom(ListAccessRightsRequest other)
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
    /// The response message for [`ListAccessRights`][salto.nebula.accessright.v1.AccessRightService.ListAccessRights]
    /// </summary>
    public sealed partial class ListAccessRightsResponse : IMessage<ListAccessRightsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListAccessRightsResponse> _parser = new(() => new ListAccessRightsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListAccessRightsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListAccessRightsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListAccessRightsResponse(ListAccessRightsResponse other) : this()
        {
            accessRights_ = other.accessRights_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListAccessRightsResponse Clone() => new(this);
        /// <summary>Field number for the "access_rights" field.</summary>
        public const int AccessRightsFieldNumber = 1;
        private static readonly FieldCodec<AccessRight> _repeated_accessRights_codec
            = FieldCodec.ForMessage(10, AccessRight.Parser);
        private readonly RepeatedField<AccessRight> accessRights_ = [];

        /// <summary>
        /// The field name should match the noun `access_rights` in the method name.
        /// There will be a maximum number of items returned based on the `page_size`
        /// field in the request.
        /// </summary>
        public RepeatedField<AccessRight> AccessRights
        {
            get { return accessRights_; }
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

        public override bool Equals(object other) => Equals(other as ListAccessRightsResponse);
        public bool Equals(ListAccessRightsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!accessRights_.Equals(other.accessRights_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= accessRights_.GetHashCode();
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
      accessRights_.WriteTo(output, _repeated_accessRights_codec);
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
            accessRights_.WriteTo(ref output, _repeated_accessRights_codec);
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
            size += accessRights_.CalculateSize(_repeated_accessRights_codec);
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

        public void MergeFrom(ListAccessRightsResponse other)
        {
            if (other == null)
            {
                return;
            }
            accessRights_.Add(other.accessRights_);
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
            accessRights_.AddEntriesFrom(input, _repeated_accessRights_codec);
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
                            accessRights_.AddEntriesFrom(ref input, _repeated_accessRights_codec);
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
    /// The request message for [`UpdateAccessRight`][salto.nebula.accessright.v1.AccessRightService.UpdateAccessRight]
    /// </summary>
    public sealed partial class UpdateAccessRightRequest : IMessage<UpdateAccessRightRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateAccessRightRequest> _parser = new(() => new UpdateAccessRightRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateAccessRightRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateAccessRightRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateAccessRightRequest(UpdateAccessRightRequest other) : this()
        {
            accessRight_ = other.accessRight_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateAccessRightRequest Clone() => new(this);
        /// <summary>Field number for the "access_right" field.</summary>
        public const int AccessRightFieldNumber = 1;
        private AccessRight accessRight_;

        /// <summary>
        /// The access right resource which replaces the resource on the server.
        /// </summary>
        public AccessRight AccessRight
        {
            get { return accessRight_; }
            set
            {
                accessRight_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateAccessRightRequest);
        public bool Equals(UpdateAccessRightRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(AccessRight, other.AccessRight)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessRight_ != null) hash ^= AccessRight.GetHashCode();
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
      if (accessRight_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessRight);
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
            if (accessRight_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessRight);
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
            if (accessRight_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(AccessRight);
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

        public void MergeFrom(UpdateAccessRightRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.accessRight_ != null)
            {
                if (accessRight_ == null)
                {
                    AccessRight = new AccessRight();
                }
                AccessRight.MergeFrom(other.AccessRight);
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
            if (accessRight_ == null) {
              AccessRight = new Saltoapis.Nebula.AccessRight.V1.AccessRight();
            }
            input.ReadMessage(AccessRight);
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
                            if (accessRight_ == null)
                            {
                                AccessRight = new AccessRight();
                            }
                            input.ReadMessage(AccessRight);
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
    /// The request message for [`DeleteAccessRight`][salto.nebula.accessright.v1.AccessRightService.DeleteAccessRight]
    /// </summary>
    public sealed partial class DeleteAccessRightRequest : IMessage<DeleteAccessRightRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteAccessRightRequest> _parser = new(() => new DeleteAccessRightRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteAccessRightRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[9]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteAccessRightRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteAccessRightRequest(DeleteAccessRightRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteAccessRightRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the access point to be deleted. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteAccessRightRequest);
        public bool Equals(DeleteAccessRightRequest other)
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

        public void MergeFrom(DeleteAccessRightRequest other)
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
    /// The request message for [`CreateAccessRightAccessPoint`][salto.nebula.accessright.v1.AccessRightService.CreateAccessRightAccessPoint]
    /// </summary>
    public sealed partial class CreateAccessRightAccessPointRequest : IMessage<CreateAccessRightAccessPointRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateAccessRightAccessPointRequest> _parser = new(() => new CreateAccessRightAccessPointRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateAccessRightAccessPointRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateAccessRightAccessPointRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateAccessRightAccessPointRequest(CreateAccessRightAccessPointRequest other) : this()
        {
            parent_ = other.parent_;
            accessRightAccessPoint_ = other.accessRightAccessPoint_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateAccessRightAccessPointRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the access right's access
        /// point association is to be created. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "access_right_access_point" field.</summary>
        public const int AccessRightAccessPointFieldNumber = 2;
        private AccessRightAccessPoint accessRightAccessPoint_;

        /// <summary>
        /// The access right's access point association resource to be created.
        /// Client must not set the `AccessRightAccessPoint.name` field.
        /// </summary>
        public AccessRightAccessPoint AccessRightAccessPoint
        {
            get { return accessRightAccessPoint_; }
            set
            {
                accessRightAccessPoint_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateAccessRightAccessPointRequest);
        public bool Equals(CreateAccessRightAccessPointRequest other)
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
            if (!Equals(AccessRightAccessPoint, other.AccessRightAccessPoint)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (accessRightAccessPoint_ != null) hash ^= AccessRightAccessPoint.GetHashCode();
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
      if (accessRightAccessPoint_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AccessRightAccessPoint);
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
            if (accessRightAccessPoint_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(AccessRightAccessPoint);
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
            if (accessRightAccessPoint_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(AccessRightAccessPoint);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateAccessRightAccessPointRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.accessRightAccessPoint_ != null)
            {
                if (accessRightAccessPoint_ == null)
                {
                    AccessRightAccessPoint = new AccessRightAccessPoint();
                }
                AccessRightAccessPoint.MergeFrom(other.AccessRightAccessPoint);
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
            if (accessRightAccessPoint_ == null) {
              AccessRightAccessPoint = new Saltoapis.Nebula.AccessRight.V1.AccessRightAccessPoint();
            }
            input.ReadMessage(AccessRightAccessPoint);
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
                            if (accessRightAccessPoint_ == null)
                            {
                                AccessRightAccessPoint = new AccessRightAccessPoint();
                            }
                            input.ReadMessage(AccessRightAccessPoint);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`BatchCreateAccessRightAccessPointsRequest`][salto.nebula.user.v1.AccessRightService.BatchCreateAccessRightAccessPoint]
    /// </summary>
    public sealed partial class BatchCreateAccessRightAccessPointsRequest : IMessage<BatchCreateAccessRightAccessPointsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchCreateAccessRightAccessPointsRequest> _parser = new(() => new BatchCreateAccessRightAccessPointsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchCreateAccessRightAccessPointsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[11]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchCreateAccessRightAccessPointsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchCreateAccessRightAccessPointsRequest(BatchCreateAccessRightAccessPointsRequest other) : this()
        {
            parent_ = other.parent_;
            requests_ = other.requests_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchCreateAccessRightAccessPointsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the access right's access points
        /// associations are to be created. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville`.
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
        private static readonly FieldCodec<CreateAccessRightAccessPointRequest> _repeated_requests_codec
            = FieldCodec.ForMessage(18, CreateAccessRightAccessPointRequest.Parser);
        private readonly RepeatedField<CreateAccessRightAccessPointRequest> requests_ = [];

        /// <summary>
        /// The request message specifying the resources to create.
        /// A maximum of 100 access right access points can be created in a batch.
        /// </summary>
        public RepeatedField<CreateAccessRightAccessPointRequest> Requests
        {
            get { return requests_; }
        }

        public override bool Equals(object other) => Equals(other as BatchCreateAccessRightAccessPointsRequest);
        public bool Equals(BatchCreateAccessRightAccessPointsRequest other)
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

        public void MergeFrom(BatchCreateAccessRightAccessPointsRequest other)
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
    /// The response message for [`BatchCreateAccessRightAccessPoints`][salto.nebula.user.v1.AccessRightService.BatchCreateAccessRightAccessPoints]
    /// </summary>
    public sealed partial class BatchCreateAccessRightAccessPointsResponse : IMessage<BatchCreateAccessRightAccessPointsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchCreateAccessRightAccessPointsResponse> _parser = new(() => new BatchCreateAccessRightAccessPointsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchCreateAccessRightAccessPointsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[12]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchCreateAccessRightAccessPointsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchCreateAccessRightAccessPointsResponse(BatchCreateAccessRightAccessPointsResponse other) : this()
        {
            accessRightAccessPoints_ = other.accessRightAccessPoints_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchCreateAccessRightAccessPointsResponse Clone() => new(this);
        /// <summary>Field number for the "access_right_access_points" field.</summary>
        public const int AccessRightAccessPointsFieldNumber = 1;
        private static readonly FieldCodec<AccessRightAccessPoint> _repeated_accessRightAccessPoints_codec
            = FieldCodec.ForMessage(10, AccessRightAccessPoint.Parser);
        private readonly RepeatedField<AccessRightAccessPoint> accessRightAccessPoints_ = [];

        /// <summary>
        /// Access right access points created.
        /// </summary>
        public RepeatedField<AccessRightAccessPoint> AccessRightAccessPoints
        {
            get { return accessRightAccessPoints_; }
        }

        public override bool Equals(object other) => Equals(other as BatchCreateAccessRightAccessPointsResponse);
        public bool Equals(BatchCreateAccessRightAccessPointsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!accessRightAccessPoints_.Equals(other.accessRightAccessPoints_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= accessRightAccessPoints_.GetHashCode();
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
      accessRightAccessPoints_.WriteTo(output, _repeated_accessRightAccessPoints_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            accessRightAccessPoints_.WriteTo(ref output, _repeated_accessRightAccessPoints_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += accessRightAccessPoints_.CalculateSize(_repeated_accessRightAccessPoints_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BatchCreateAccessRightAccessPointsResponse other)
        {
            if (other == null)
            {
                return;
            }
            accessRightAccessPoints_.Add(other.accessRightAccessPoints_);
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
            accessRightAccessPoints_.AddEntriesFrom(input, _repeated_accessRightAccessPoints_codec);
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
                            accessRightAccessPoints_.AddEntriesFrom(ref input, _repeated_accessRightAccessPoints_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetAccessRightAccessPoint`][salto.nebula.accessright.v1.AccessRightService.GetAccessRightAccessPoint]
    /// </summary>
    public sealed partial class GetAccessRightAccessPointRequest : IMessage<GetAccessRightAccessPointRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetAccessRightAccessPointRequest> _parser = new(() => new GetAccessRightAccessPointRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetAccessRightAccessPointRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetAccessRightAccessPointRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetAccessRightAccessPointRequest(GetAccessRightAccessPointRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetAccessRightAccessPointRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested access right's access point association
        /// resource. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville/access-points/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetAccessRightAccessPointRequest);
        public bool Equals(GetAccessRightAccessPointRequest other)
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

        public void MergeFrom(GetAccessRightAccessPointRequest other)
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
    /// The request message for [`ListAccessRightAccessPoints`][salto.nebula.accessright.v1.AccessRightService.ListAccessRightAccessPoints]
    /// </summary>
    public sealed partial class ListAccessRightAccessPointsRequest : IMessage<ListAccessRightAccessPointsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListAccessRightAccessPointsRequest> _parser = new(() => new ListAccessRightAccessPointsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListAccessRightAccessPointsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[14]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListAccessRightAccessPointsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListAccessRightAccessPointsRequest(ListAccessRightAccessPointsRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListAccessRightAccessPointsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville`.
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
        /// A filter that chooses which access right's access point
        /// associations to return.
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

        public override bool Equals(object other) => Equals(other as ListAccessRightAccessPointsRequest);
        public bool Equals(ListAccessRightAccessPointsRequest other)
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

        public void MergeFrom(ListAccessRightAccessPointsRequest other)
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
    /// The request message for [`ListAccessRightAccessPoints`][salto.nebula.accessright.v1.AccessRightService.ListAccessRightAccessPoints]
    /// </summary>
    public sealed partial class ListAccessRightAccessPointsResponse : IMessage<ListAccessRightAccessPointsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListAccessRightAccessPointsResponse> _parser = new(() => new ListAccessRightAccessPointsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListAccessRightAccessPointsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[15]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListAccessRightAccessPointsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListAccessRightAccessPointsResponse(ListAccessRightAccessPointsResponse other) : this()
        {
            accessRightAccessPoints_ = other.accessRightAccessPoints_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListAccessRightAccessPointsResponse Clone() => new(this);
        /// <summary>Field number for the "access_right_access_points" field.</summary>
        public const int AccessRightAccessPointsFieldNumber = 1;
        private static readonly FieldCodec<AccessRightAccessPoint> _repeated_accessRightAccessPoints_codec
            = FieldCodec.ForMessage(10, AccessRightAccessPoint.Parser);
        private readonly RepeatedField<AccessRightAccessPoint> accessRightAccessPoints_ = [];

        /// <summary>
        /// The field name should match the noun `access_right_access_points` in the
        /// method name. There will be a maximum number of items returned based on
        /// the `page_size` field in the request.
        /// </summary>
        public RepeatedField<AccessRightAccessPoint> AccessRightAccessPoints
        {
            get { return accessRightAccessPoints_; }
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

        public override bool Equals(object other) => Equals(other as ListAccessRightAccessPointsResponse);
        public bool Equals(ListAccessRightAccessPointsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!accessRightAccessPoints_.Equals(other.accessRightAccessPoints_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= accessRightAccessPoints_.GetHashCode();
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
      accessRightAccessPoints_.WriteTo(output, _repeated_accessRightAccessPoints_codec);
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
            accessRightAccessPoints_.WriteTo(ref output, _repeated_accessRightAccessPoints_codec);
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
            size += accessRightAccessPoints_.CalculateSize(_repeated_accessRightAccessPoints_codec);
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

        public void MergeFrom(ListAccessRightAccessPointsResponse other)
        {
            if (other == null)
            {
                return;
            }
            accessRightAccessPoints_.Add(other.accessRightAccessPoints_);
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
            accessRightAccessPoints_.AddEntriesFrom(input, _repeated_accessRightAccessPoints_codec);
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
                            accessRightAccessPoints_.AddEntriesFrom(ref input, _repeated_accessRightAccessPoints_codec);
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
    /// The request message for [`UpdateAccessRightAccessPoint`][salto.nebula.accessright.v1.AccessRightService.UpdateAccessRightAccessPoint]
    /// </summary>
    public sealed partial class UpdateAccessRightAccessPointRequest : IMessage<UpdateAccessRightAccessPointRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateAccessRightAccessPointRequest> _parser = new(() => new UpdateAccessRightAccessPointRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateAccessRightAccessPointRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[16]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateAccessRightAccessPointRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateAccessRightAccessPointRequest(UpdateAccessRightAccessPointRequest other) : this()
        {
            accessRightAccessPoint_ = other.accessRightAccessPoint_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateAccessRightAccessPointRequest Clone() => new(this);
        /// <summary>Field number for the "access_right_access_point" field.</summary>
        public const int AccessRightAccessPointFieldNumber = 1;
        private AccessRightAccessPoint accessRightAccessPoint_;

        /// <summary>
        /// The access right's access point resource which replaces the resource on
        /// the server.
        /// </summary>
        public AccessRightAccessPoint AccessRightAccessPoint
        {
            get { return accessRightAccessPoint_; }
            set
            {
                accessRightAccessPoint_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateAccessRightAccessPointRequest);
        public bool Equals(UpdateAccessRightAccessPointRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(AccessRightAccessPoint, other.AccessRightAccessPoint)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessRightAccessPoint_ != null) hash ^= AccessRightAccessPoint.GetHashCode();
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
      if (accessRightAccessPoint_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessRightAccessPoint);
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
            if (accessRightAccessPoint_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessRightAccessPoint);
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
            if (accessRightAccessPoint_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(AccessRightAccessPoint);
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

        public void MergeFrom(UpdateAccessRightAccessPointRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.accessRightAccessPoint_ != null)
            {
                if (accessRightAccessPoint_ == null)
                {
                    AccessRightAccessPoint = new AccessRightAccessPoint();
                }
                AccessRightAccessPoint.MergeFrom(other.AccessRightAccessPoint);
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
            if (accessRightAccessPoint_ == null) {
              AccessRightAccessPoint = new Saltoapis.Nebula.AccessRight.V1.AccessRightAccessPoint();
            }
            input.ReadMessage(AccessRightAccessPoint);
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
                            if (accessRightAccessPoint_ == null)
                            {
                                AccessRightAccessPoint = new AccessRightAccessPoint();
                            }
                            input.ReadMessage(AccessRightAccessPoint);
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
    /// The request message for [`DeleteAccessRightAccessPoint`][salto.nebula.accessright.v1.AccessRightService.DeleteAccessRightAccessPoint]
    /// </summary>
    public sealed partial class DeleteAccessRightAccessPointRequest : IMessage<DeleteAccessRightAccessPointRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteAccessRightAccessPointRequest> _parser = new(() => new DeleteAccessRightAccessPointRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteAccessRightAccessPointRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[17]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteAccessRightAccessPointRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteAccessRightAccessPointRequest(DeleteAccessRightAccessPointRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteAccessRightAccessPointRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the access right's access point association to be
        /// deleted. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville/access-points/baker-street-entrance`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteAccessRightAccessPointRequest);
        public bool Equals(DeleteAccessRightAccessPointRequest other)
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

        public void MergeFrom(DeleteAccessRightAccessPointRequest other)
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
    /// The request message for [`CreateAccessRightAccessPointGroup`][salto.nebula.accessright.v1.AccessRightService.CreateAccessRightAccessPointGroup]
    /// </summary>
    public sealed partial class CreateAccessRightAccessPointGroupRequest : IMessage<CreateAccessRightAccessPointGroupRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateAccessRightAccessPointGroupRequest> _parser = new(() => new CreateAccessRightAccessPointGroupRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateAccessRightAccessPointGroupRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[18]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateAccessRightAccessPointGroupRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateAccessRightAccessPointGroupRequest(CreateAccessRightAccessPointGroupRequest other) : this()
        {
            parent_ = other.parent_;
            accessRightAccessPointGroup_ = other.accessRightAccessPointGroup_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateAccessRightAccessPointGroupRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the access right's access
        /// point group association is to be created. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "access_right_access_point_group" field.</summary>
        public const int AccessRightAccessPointGroupFieldNumber = 2;
        private AccessRightAccessPointGroup accessRightAccessPointGroup_;

        /// <summary>
        /// The access right's access point group association resource to be created.
        /// Client must not set the `AccessRightAccessPointGroup.name` field.
        /// </summary>
        public AccessRightAccessPointGroup AccessRightAccessPointGroup
        {
            get { return accessRightAccessPointGroup_; }
            set
            {
                accessRightAccessPointGroup_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateAccessRightAccessPointGroupRequest);
        public bool Equals(CreateAccessRightAccessPointGroupRequest other)
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
            if (!Equals(AccessRightAccessPointGroup, other.AccessRightAccessPointGroup)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (accessRightAccessPointGroup_ != null) hash ^= AccessRightAccessPointGroup.GetHashCode();
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
      if (accessRightAccessPointGroup_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AccessRightAccessPointGroup);
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
            if (accessRightAccessPointGroup_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(AccessRightAccessPointGroup);
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
            if (accessRightAccessPointGroup_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(AccessRightAccessPointGroup);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateAccessRightAccessPointGroupRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.accessRightAccessPointGroup_ != null)
            {
                if (accessRightAccessPointGroup_ == null)
                {
                    AccessRightAccessPointGroup = new AccessRightAccessPointGroup();
                }
                AccessRightAccessPointGroup.MergeFrom(other.AccessRightAccessPointGroup);
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
            if (accessRightAccessPointGroup_ == null) {
              AccessRightAccessPointGroup = new Saltoapis.Nebula.AccessRight.V1.AccessRightAccessPointGroup();
            }
            input.ReadMessage(AccessRightAccessPointGroup);
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
                            if (accessRightAccessPointGroup_ == null)
                            {
                                AccessRightAccessPointGroup = new AccessRightAccessPointGroup();
                            }
                            input.ReadMessage(AccessRightAccessPointGroup);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`BatchCreateAccessRightAccessPointGroupsRequest`][salto.nebula.user.v1.AccessRightService.BatchCreateAccessRightAccessPointGroups]
    /// </summary>
    public sealed partial class BatchCreateAccessRightAccessPointGroupsRequest : IMessage<BatchCreateAccessRightAccessPointGroupsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchCreateAccessRightAccessPointGroupsRequest> _parser = new(() => new BatchCreateAccessRightAccessPointGroupsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchCreateAccessRightAccessPointGroupsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[19]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchCreateAccessRightAccessPointGroupsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchCreateAccessRightAccessPointGroupsRequest(BatchCreateAccessRightAccessPointGroupsRequest other) : this()
        {
            parent_ = other.parent_;
            requests_ = other.requests_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchCreateAccessRightAccessPointGroupsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the access right's access point groups
        /// associations are to be created. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville`.
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
        private static readonly FieldCodec<CreateAccessRightAccessPointGroupRequest> _repeated_requests_codec
            = FieldCodec.ForMessage(18, CreateAccessRightAccessPointGroupRequest.Parser);
        private readonly RepeatedField<CreateAccessRightAccessPointGroupRequest> requests_ = [];

        /// <summary>
        /// The request message specifying the resources to create.
        /// A maximum of 100 access right's access point groups can be created in a batch.
        /// </summary>
        public RepeatedField<CreateAccessRightAccessPointGroupRequest> Requests
        {
            get { return requests_; }
        }

        public override bool Equals(object other) => Equals(other as BatchCreateAccessRightAccessPointGroupsRequest);
        public bool Equals(BatchCreateAccessRightAccessPointGroupsRequest other)
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

        public void MergeFrom(BatchCreateAccessRightAccessPointGroupsRequest other)
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
    /// The response message for [`BatchCreateAccessRightAccessPointGroups`][salto.nebula.user.v1.AccessRightService.BatchCreateAccessRightAccessPointGroups]
    /// </summary>
    public sealed partial class BatchCreateAccessRightAccessPointGroupsResponse : IMessage<BatchCreateAccessRightAccessPointGroupsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchCreateAccessRightAccessPointGroupsResponse> _parser = new(() => new BatchCreateAccessRightAccessPointGroupsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchCreateAccessRightAccessPointGroupsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[20]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchCreateAccessRightAccessPointGroupsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchCreateAccessRightAccessPointGroupsResponse(BatchCreateAccessRightAccessPointGroupsResponse other) : this()
        {
            accessRightAccessPointGroups_ = other.accessRightAccessPointGroups_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchCreateAccessRightAccessPointGroupsResponse Clone() => new(this);
        /// <summary>Field number for the "access_right_access_point_groups" field.</summary>
        public const int AccessRightAccessPointGroupsFieldNumber = 1;
        private static readonly FieldCodec<AccessRightAccessPointGroup> _repeated_accessRightAccessPointGroups_codec
            = FieldCodec.ForMessage(10, AccessRightAccessPointGroup.Parser);
        private readonly RepeatedField<AccessRightAccessPointGroup> accessRightAccessPointGroups_ = [];

        /// <summary>
        /// Access right's access point groups created.
        /// </summary>
        public RepeatedField<AccessRightAccessPointGroup> AccessRightAccessPointGroups
        {
            get { return accessRightAccessPointGroups_; }
        }

        public override bool Equals(object other) => Equals(other as BatchCreateAccessRightAccessPointGroupsResponse);
        public bool Equals(BatchCreateAccessRightAccessPointGroupsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!accessRightAccessPointGroups_.Equals(other.accessRightAccessPointGroups_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= accessRightAccessPointGroups_.GetHashCode();
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
      accessRightAccessPointGroups_.WriteTo(output, _repeated_accessRightAccessPointGroups_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            accessRightAccessPointGroups_.WriteTo(ref output, _repeated_accessRightAccessPointGroups_codec);
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            size += accessRightAccessPointGroups_.CalculateSize(_repeated_accessRightAccessPointGroups_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BatchCreateAccessRightAccessPointGroupsResponse other)
        {
            if (other == null)
            {
                return;
            }
            accessRightAccessPointGroups_.Add(other.accessRightAccessPointGroups_);
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
            accessRightAccessPointGroups_.AddEntriesFrom(input, _repeated_accessRightAccessPointGroups_codec);
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
                            accessRightAccessPointGroups_.AddEntriesFrom(ref input, _repeated_accessRightAccessPointGroups_codec);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetAccessRightAccessPointGroup`][salto.nebula.accessright.v1.AccessRightService.GetAccessRightAccessPointGroup]
    /// </summary>
    public sealed partial class GetAccessRightAccessPointGroupRequest : IMessage<GetAccessRightAccessPointGroupRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetAccessRightAccessPointGroupRequest> _parser = new(() => new GetAccessRightAccessPointGroupRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetAccessRightAccessPointGroupRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[21]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetAccessRightAccessPointGroupRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetAccessRightAccessPointGroupRequest(GetAccessRightAccessPointGroupRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetAccessRightAccessPointGroupRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested access right's access point group association
        /// resource. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville/access-point-groups/common-accesses`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetAccessRightAccessPointGroupRequest);
        public bool Equals(GetAccessRightAccessPointGroupRequest other)
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

        public void MergeFrom(GetAccessRightAccessPointGroupRequest other)
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
    /// The request message for [`ListAccessRightAccessPointGroups`][salto.nebula.accessright.v1.AccessRightService.ListAccessRightAccessPointGroups]
    /// </summary>
    public sealed partial class ListAccessRightAccessPointGroupsRequest : IMessage<ListAccessRightAccessPointGroupsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListAccessRightAccessPointGroupsRequest> _parser = new(() => new ListAccessRightAccessPointGroupsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListAccessRightAccessPointGroupsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[22]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListAccessRightAccessPointGroupsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListAccessRightAccessPointGroupsRequest(ListAccessRightAccessPointGroupsRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListAccessRightAccessPointGroupsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville`.
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
        /// A filter that chooses which access right's access point group
        /// associations to return.
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

        public override bool Equals(object other) => Equals(other as ListAccessRightAccessPointGroupsRequest);
        public bool Equals(ListAccessRightAccessPointGroupsRequest other)
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

        public void MergeFrom(ListAccessRightAccessPointGroupsRequest other)
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
    /// The request message for [`ListAccessRightAccessPointGroups`][salto.nebula.accessright.v1.AccessRightService.ListAccessRightAccessPointGroups]
    /// </summary>
    public sealed partial class ListAccessRightAccessPointGroupsResponse : IMessage<ListAccessRightAccessPointGroupsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListAccessRightAccessPointGroupsResponse> _parser = new(() => new ListAccessRightAccessPointGroupsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListAccessRightAccessPointGroupsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[23]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListAccessRightAccessPointGroupsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListAccessRightAccessPointGroupsResponse(ListAccessRightAccessPointGroupsResponse other) : this()
        {
            accessRightAccessPointGroups_ = other.accessRightAccessPointGroups_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListAccessRightAccessPointGroupsResponse Clone() => new(this);
        /// <summary>Field number for the "access_right_access_point_groups" field.</summary>
        public const int AccessRightAccessPointGroupsFieldNumber = 1;
        private static readonly FieldCodec<AccessRightAccessPointGroup> _repeated_accessRightAccessPointGroups_codec
            = FieldCodec.ForMessage(10, AccessRightAccessPointGroup.Parser);
        private readonly RepeatedField<AccessRightAccessPointGroup> accessRightAccessPointGroups_ = [];

        /// <summary>
        /// The field name should match the noun `access_right_access_point_groups`
        /// in the method name. There will be a maximum number of items returned
        /// based on the `page_size` field in the request.
        /// </summary>
        public RepeatedField<AccessRightAccessPointGroup> AccessRightAccessPointGroups
        {
            get { return accessRightAccessPointGroups_; }
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

        public override bool Equals(object other) => Equals(other as ListAccessRightAccessPointGroupsResponse);
        public bool Equals(ListAccessRightAccessPointGroupsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!accessRightAccessPointGroups_.Equals(other.accessRightAccessPointGroups_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= accessRightAccessPointGroups_.GetHashCode();
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
      accessRightAccessPointGroups_.WriteTo(output, _repeated_accessRightAccessPointGroups_codec);
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
            accessRightAccessPointGroups_.WriteTo(ref output, _repeated_accessRightAccessPointGroups_codec);
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
            size += accessRightAccessPointGroups_.CalculateSize(_repeated_accessRightAccessPointGroups_codec);
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

        public void MergeFrom(ListAccessRightAccessPointGroupsResponse other)
        {
            if (other == null)
            {
                return;
            }
            accessRightAccessPointGroups_.Add(other.accessRightAccessPointGroups_);
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
            accessRightAccessPointGroups_.AddEntriesFrom(input, _repeated_accessRightAccessPointGroups_codec);
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
                            accessRightAccessPointGroups_.AddEntriesFrom(ref input, _repeated_accessRightAccessPointGroups_codec);
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
    /// The request message for [`UpdateAccessRightAccessPointGroup`][salto.nebula.accessright.v1.AccessRightService.UpdateAccessRightAccessPointGroup]
    /// </summary>
    public sealed partial class UpdateAccessRightAccessPointGroupRequest : IMessage<UpdateAccessRightAccessPointGroupRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateAccessRightAccessPointGroupRequest> _parser = new(() => new UpdateAccessRightAccessPointGroupRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateAccessRightAccessPointGroupRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[24]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateAccessRightAccessPointGroupRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateAccessRightAccessPointGroupRequest(UpdateAccessRightAccessPointGroupRequest other) : this()
        {
            accessRightAccessPointGroup_ = other.accessRightAccessPointGroup_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateAccessRightAccessPointGroupRequest Clone() => new(this);
        /// <summary>Field number for the "access_right_access_point_group" field.</summary>
        public const int AccessRightAccessPointGroupFieldNumber = 1;
        private AccessRightAccessPointGroup accessRightAccessPointGroup_;

        /// <summary>
        /// The access right's access point group resource which replaces the
        /// resource on the server.
        /// </summary>
        public AccessRightAccessPointGroup AccessRightAccessPointGroup
        {
            get { return accessRightAccessPointGroup_; }
            set
            {
                accessRightAccessPointGroup_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateAccessRightAccessPointGroupRequest);
        public bool Equals(UpdateAccessRightAccessPointGroupRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(AccessRightAccessPointGroup, other.AccessRightAccessPointGroup)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessRightAccessPointGroup_ != null) hash ^= AccessRightAccessPointGroup.GetHashCode();
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
      if (accessRightAccessPointGroup_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessRightAccessPointGroup);
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
            if (accessRightAccessPointGroup_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessRightAccessPointGroup);
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
            if (accessRightAccessPointGroup_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(AccessRightAccessPointGroup);
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

        public void MergeFrom(UpdateAccessRightAccessPointGroupRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.accessRightAccessPointGroup_ != null)
            {
                if (accessRightAccessPointGroup_ == null)
                {
                    AccessRightAccessPointGroup = new AccessRightAccessPointGroup();
                }
                AccessRightAccessPointGroup.MergeFrom(other.AccessRightAccessPointGroup);
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
            if (accessRightAccessPointGroup_ == null) {
              AccessRightAccessPointGroup = new Saltoapis.Nebula.AccessRight.V1.AccessRightAccessPointGroup();
            }
            input.ReadMessage(AccessRightAccessPointGroup);
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
                            if (accessRightAccessPointGroup_ == null)
                            {
                                AccessRightAccessPointGroup = new AccessRightAccessPointGroup();
                            }
                            input.ReadMessage(AccessRightAccessPointGroup);
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
    /// The request message for [`DeleteAccessRightAccessPointGroup`][salto.nebula.accessright.v1.AccessRightService.DeleteAccessRightAccessPointGroup]
    /// </summary>
    public sealed partial class DeleteAccessRightAccessPointGroupRequest : IMessage<DeleteAccessRightAccessPointGroupRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteAccessRightAccessPointGroupRequest> _parser = new(() => new DeleteAccessRightAccessPointGroupRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteAccessRightAccessPointGroupRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[25]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteAccessRightAccessPointGroupRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteAccessRightAccessPointGroupRequest(DeleteAccessRightAccessPointGroupRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteAccessRightAccessPointGroupRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the access right's access point group association to
        /// be deleted. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville/access-point-groups/common-accesses`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteAccessRightAccessPointGroupRequest);
        public bool Equals(DeleteAccessRightAccessPointGroupRequest other)
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

        public void MergeFrom(DeleteAccessRightAccessPointGroupRequest other)
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
    /// The request message for [`BatchDeleteAccessRightAccessPointGroups`][salto.nebula.accessright.v1.AccessRightService.BatchDeleteAccessRightAccessPointGroups]
    /// </summary>
    public sealed partial class BatchDeleteAccessRightAccessPointGroupsRequest : IMessage<BatchDeleteAccessRightAccessPointGroupsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchDeleteAccessRightAccessPointGroupsRequest> _parser = new(() => new BatchDeleteAccessRightAccessPointGroupsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchDeleteAccessRightAccessPointGroupsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[26]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchDeleteAccessRightAccessPointGroupsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchDeleteAccessRightAccessPointGroupsRequest(BatchDeleteAccessRightAccessPointGroupsRequest other) : this()
        {
            parent_ = other.parent_;
            requests_ = other.requests_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchDeleteAccessRightAccessPointGroupsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the access right's access point group associations to be deleted.
        /// For example: `installations/surelock-homes-hq/access-rights/baskerville/access-point-groups/common-accesses`.
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
        private static readonly FieldCodec<DeleteAccessRightAccessPointGroupRequest> _repeated_requests_codec
            = FieldCodec.ForMessage(18, DeleteAccessRightAccessPointGroupRequest.Parser);
        private readonly RepeatedField<DeleteAccessRightAccessPointGroupRequest> requests_ = [];

        /// <summary>
        /// The request message specifying the resources to delete.
        /// A maximum of 100 access right's access point group associations can be deleted in a batch.
        /// </summary>
        public RepeatedField<DeleteAccessRightAccessPointGroupRequest> Requests
        {
            get { return requests_; }
        }

        public override bool Equals(object other) => Equals(other as BatchDeleteAccessRightAccessPointGroupsRequest);
        public bool Equals(BatchDeleteAccessRightAccessPointGroupsRequest other)
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

        public void MergeFrom(BatchDeleteAccessRightAccessPointGroupsRequest other)
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
    /// The response message for [`BatchDeleteAccessRightAccessPointGroups`][salto.nebula.accessright.v1.AccessRightService.BatchDeleteAccessRightAccessPointGroups]
    /// </summary>
    public sealed partial class BatchDeleteAccessRightAccessPointGroupsResponse : IMessage<BatchDeleteAccessRightAccessPointGroupsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchDeleteAccessRightAccessPointGroupsResponse> _parser = new(() => new BatchDeleteAccessRightAccessPointGroupsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchDeleteAccessRightAccessPointGroupsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[27]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchDeleteAccessRightAccessPointGroupsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchDeleteAccessRightAccessPointGroupsResponse(BatchDeleteAccessRightAccessPointGroupsResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchDeleteAccessRightAccessPointGroupsResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as BatchDeleteAccessRightAccessPointGroupsResponse);
        public bool Equals(BatchDeleteAccessRightAccessPointGroupsResponse other)
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

        public void MergeFrom(BatchDeleteAccessRightAccessPointGroupsResponse other)
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
    /// The request message for [`BatchDeleteAccessRightAccessPoints`][salto.nebula.accessright.v1.AccessRightService.BatchDeleteAccessRightAccessPoints]
    /// </summary>
    public sealed partial class BatchDeleteAccessRightAccessPointsRequest : IMessage<BatchDeleteAccessRightAccessPointsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchDeleteAccessRightAccessPointsRequest> _parser = new(() => new BatchDeleteAccessRightAccessPointsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchDeleteAccessRightAccessPointsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[28]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchDeleteAccessRightAccessPointsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchDeleteAccessRightAccessPointsRequest(BatchDeleteAccessRightAccessPointsRequest other) : this()
        {
            parent_ = other.parent_;
            requests_ = other.requests_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchDeleteAccessRightAccessPointsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the access point's access right relation to be deleted.
        /// For example: `installations/surelock-homes-hq/access-rights/baskerville`.
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
        private static readonly FieldCodec<DeleteAccessRightAccessPointRequest> _repeated_requests_codec
            = FieldCodec.ForMessage(18, DeleteAccessRightAccessPointRequest.Parser);
        private readonly RepeatedField<DeleteAccessRightAccessPointRequest> requests_ = [];

        /// <summary>
        /// The request message specifying the resources to delete.
        /// A maximum of 100 access point's access rights associations can be deleted in a batch.
        /// </summary>
        public RepeatedField<DeleteAccessRightAccessPointRequest> Requests
        {
            get { return requests_; }
        }

        public override bool Equals(object other) => Equals(other as BatchDeleteAccessRightAccessPointsRequest);
        public bool Equals(BatchDeleteAccessRightAccessPointsRequest other)
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

        public void MergeFrom(BatchDeleteAccessRightAccessPointsRequest other)
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
    /// The response message for [`BatchDeleteAccessRightAccessPoints`][salto.nebula.accessright.v1.AccessRightService.BatchDeleteAccessRightAccessPoints]
    /// </summary>
    public sealed partial class BatchDeleteAccessRightAccessPointsResponse : IMessage<BatchDeleteAccessRightAccessPointsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BatchDeleteAccessRightAccessPointsResponse> _parser = new(() => new BatchDeleteAccessRightAccessPointsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BatchDeleteAccessRightAccessPointsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[29]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BatchDeleteAccessRightAccessPointsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BatchDeleteAccessRightAccessPointsResponse(BatchDeleteAccessRightAccessPointsResponse other) : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BatchDeleteAccessRightAccessPointsResponse Clone() => new(this);
        public override bool Equals(object other) => Equals(other as BatchDeleteAccessRightAccessPointsResponse);
        public bool Equals(BatchDeleteAccessRightAccessPointsResponse other)
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

        public void MergeFrom(BatchDeleteAccessRightAccessPointsResponse other)
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
    /// The request message for [`CreateAccessRightDestination`][salto.nebula.accessright.v1.AccessRightService.CreateAccessRightDestination]
    /// </summary>
    public sealed partial class CreateAccessRightDestinationRequest : IMessage<CreateAccessRightDestinationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateAccessRightDestinationRequest> _parser = new(() => new CreateAccessRightDestinationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateAccessRightDestinationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[30]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateAccessRightDestinationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateAccessRightDestinationRequest(CreateAccessRightDestinationRequest other) : this()
        {
            parent_ = other.parent_;
            accessRightDestination_ = other.accessRightDestination_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateAccessRightDestinationRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the access right's destination
        /// association is to be created. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "access_right_destination" field.</summary>
        public const int AccessRightDestinationFieldNumber = 2;
        private AccessRightDestination accessRightDestination_;

        /// <summary>
        /// The access right's destination association resource to be created.
        /// Client must not set the `AccessRightDestination.name` field.
        /// </summary>
        public AccessRightDestination AccessRightDestination
        {
            get { return accessRightDestination_; }
            set
            {
                accessRightDestination_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateAccessRightDestinationRequest);
        public bool Equals(CreateAccessRightDestinationRequest other)
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
            if (!Equals(AccessRightDestination, other.AccessRightDestination)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (accessRightDestination_ != null) hash ^= AccessRightDestination.GetHashCode();
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
      if (accessRightDestination_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AccessRightDestination);
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
            if (accessRightDestination_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(AccessRightDestination);
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
            if (accessRightDestination_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(AccessRightDestination);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateAccessRightDestinationRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.accessRightDestination_ != null)
            {
                if (accessRightDestination_ == null)
                {
                    AccessRightDestination = new AccessRightDestination();
                }
                AccessRightDestination.MergeFrom(other.AccessRightDestination);
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
            if (accessRightDestination_ == null) {
              AccessRightDestination = new Saltoapis.Nebula.AccessRight.V1.AccessRightDestination();
            }
            input.ReadMessage(AccessRightDestination);
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
                            if (accessRightDestination_ == null)
                            {
                                AccessRightDestination = new AccessRightDestination();
                            }
                            input.ReadMessage(AccessRightDestination);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetAccessRightDestination`][salto.nebula.accessright.v1.AccessRightService.GetAccessRightDestination]
    /// </summary>
    public sealed partial class GetAccessRightDestinationRequest : IMessage<GetAccessRightDestinationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetAccessRightDestinationRequest> _parser = new(() => new GetAccessRightDestinationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetAccessRightDestinationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[31]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetAccessRightDestinationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetAccessRightDestinationRequest(GetAccessRightDestinationRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetAccessRightDestinationRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested access right's destination association
        /// resource. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville/destinations/elevator-floor-5`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetAccessRightDestinationRequest);
        public bool Equals(GetAccessRightDestinationRequest other)
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

        public void MergeFrom(GetAccessRightDestinationRequest other)
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
    /// The request message for [`ListAccessRightDestinations`][salto.nebula.accessright.v1.AccessRightService.ListAccessRightDestinations]
    /// </summary>
    public sealed partial class ListAccessRightDestinationsRequest : IMessage<ListAccessRightDestinationsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListAccessRightDestinationsRequest> _parser = new(() => new ListAccessRightDestinationsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListAccessRightDestinationsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[32]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListAccessRightDestinationsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListAccessRightDestinationsRequest(ListAccessRightDestinationsRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListAccessRightDestinationsRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville`.
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
        /// A filter that chooses which access right's destination
        /// associations to return.
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

        public override bool Equals(object other) => Equals(other as ListAccessRightDestinationsRequest);
        public bool Equals(ListAccessRightDestinationsRequest other)
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

        public void MergeFrom(ListAccessRightDestinationsRequest other)
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
    /// The request message for [`ListAccessRightDestinations`][salto.nebula.accessright.v1.AccessRightService.ListAccessRightDestinations]
    /// </summary>
    public sealed partial class ListAccessRightDestinationsResponse : IMessage<ListAccessRightDestinationsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListAccessRightDestinationsResponse> _parser = new(() => new ListAccessRightDestinationsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListAccessRightDestinationsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[33]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListAccessRightDestinationsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListAccessRightDestinationsResponse(ListAccessRightDestinationsResponse other) : this()
        {
            accessRightDestinations_ = other.accessRightDestinations_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListAccessRightDestinationsResponse Clone() => new(this);
        /// <summary>Field number for the "access_right_destinations" field.</summary>
        public const int AccessRightDestinationsFieldNumber = 1;
        private static readonly FieldCodec<AccessRightDestination> _repeated_accessRightDestinations_codec
            = FieldCodec.ForMessage(10, AccessRightDestination.Parser);
        private readonly RepeatedField<AccessRightDestination> accessRightDestinations_ = [];

        /// <summary>
        /// The field name should match the noun `access_right_destinations` in the
        /// method name. There will be a maximum number of items returned based on
        /// the `page_size` field in the request.
        /// </summary>
        public RepeatedField<AccessRightDestination> AccessRightDestinations
        {
            get { return accessRightDestinations_; }
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

        public override bool Equals(object other) => Equals(other as ListAccessRightDestinationsResponse);
        public bool Equals(ListAccessRightDestinationsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!accessRightDestinations_.Equals(other.accessRightDestinations_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= accessRightDestinations_.GetHashCode();
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
      accessRightDestinations_.WriteTo(output, _repeated_accessRightDestinations_codec);
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
            accessRightDestinations_.WriteTo(ref output, _repeated_accessRightDestinations_codec);
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
            size += accessRightDestinations_.CalculateSize(_repeated_accessRightDestinations_codec);
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

        public void MergeFrom(ListAccessRightDestinationsResponse other)
        {
            if (other == null)
            {
                return;
            }
            accessRightDestinations_.Add(other.accessRightDestinations_);
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
            accessRightDestinations_.AddEntriesFrom(input, _repeated_accessRightDestinations_codec);
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
                            accessRightDestinations_.AddEntriesFrom(ref input, _repeated_accessRightDestinations_codec);
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
    /// The request message for [`UpdateAccessRightDestination`][salto.nebula.accessright.v1.AccessRightService.UpdateAccessRightDestination]
    /// </summary>
    public sealed partial class UpdateAccessRightDestinationRequest : IMessage<UpdateAccessRightDestinationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateAccessRightDestinationRequest> _parser = new(() => new UpdateAccessRightDestinationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateAccessRightDestinationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[34]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateAccessRightDestinationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateAccessRightDestinationRequest(UpdateAccessRightDestinationRequest other) : this()
        {
            accessRightDestination_ = other.accessRightDestination_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateAccessRightDestinationRequest Clone() => new(this);
        /// <summary>Field number for the "access_right_destination" field.</summary>
        public const int AccessRightDestinationFieldNumber = 1;
        private AccessRightDestination accessRightDestination_;

        /// <summary>
        /// The access right's destination resource which replaces the resource on
        /// the server.
        /// </summary>
        public AccessRightDestination AccessRightDestination
        {
            get { return accessRightDestination_; }
            set
            {
                accessRightDestination_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateAccessRightDestinationRequest);
        public bool Equals(UpdateAccessRightDestinationRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(AccessRightDestination, other.AccessRightDestination)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (accessRightDestination_ != null) hash ^= AccessRightDestination.GetHashCode();
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
      if (accessRightDestination_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessRightDestination);
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
            if (accessRightDestination_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(AccessRightDestination);
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
            if (accessRightDestination_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(AccessRightDestination);
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

        public void MergeFrom(UpdateAccessRightDestinationRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.accessRightDestination_ != null)
            {
                if (accessRightDestination_ == null)
                {
                    AccessRightDestination = new AccessRightDestination();
                }
                AccessRightDestination.MergeFrom(other.AccessRightDestination);
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
            if (accessRightDestination_ == null) {
              AccessRightDestination = new Saltoapis.Nebula.AccessRight.V1.AccessRightDestination();
            }
            input.ReadMessage(AccessRightDestination);
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
                            if (accessRightDestination_ == null)
                            {
                                AccessRightDestination = new AccessRightDestination();
                            }
                            input.ReadMessage(AccessRightDestination);
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
    /// The request message for [`DeleteAccessRightDestination`][salto.nebula.accessright.v1.AccessRightService.DeleteAccessRightDestination]
    /// </summary>
    public sealed partial class DeleteAccessRightDestinationRequest : IMessage<DeleteAccessRightDestinationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteAccessRightDestinationRequest> _parser = new(() => new DeleteAccessRightDestinationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteAccessRightDestinationRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return AccessRightReflection.Descriptor.MessageTypes[35]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteAccessRightDestinationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteAccessRightDestinationRequest(DeleteAccessRightDestinationRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteAccessRightDestinationRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the access right's destination association to be
        /// deleted. For example:
        /// `installations/surelock-homes-hq/access-rights/baskerville/destinations/elevator-floor-5`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteAccessRightDestinationRequest);
        public bool Equals(DeleteAccessRightDestinationRequest other)
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

        public void MergeFrom(DeleteAccessRightDestinationRequest other)
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

    #endregion

}
