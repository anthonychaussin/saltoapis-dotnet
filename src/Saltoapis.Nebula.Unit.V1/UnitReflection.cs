using Google.Protobuf.Reflection;
using Saltoapis.Nebula.Unit.V1.Request;
using Saltoapis.Nebula.Unit.V1.Response;

namespace Saltoapis.Nebula.Unit.V1
{
    /// <summary>Holder for reflection information generated from salto/nebula/unit/v1/unit.proto</summary>
    public static partial class UnitReflection
    {

        /// <summary>File descriptor for salto/nebula/unit/v1/unit.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static UnitReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "Ch9zYWx0by9uZWJ1bGEvdW5pdC92MS91bml0LnByb3RvEhRzYWx0by5uZWJ1",
                  "bGEudW5pdC52MRobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvGiBnb29n",
                  "bGUvcHJvdG9idWYvZmllbGRfbWFzay5wcm90bxofZ29vZ2xlL3Byb3RvYnVm",
                  "L3RpbWVzdGFtcC5wcm90byK6AgoEVW5pdBIMCgRuYW1lGAEgASgJEhQKDGRp",
                  "c3BsYXlfbmFtZRgCIAEoCRIwCgxtb3ZlX2luX3RpbWUYAyABKAsyGi5nb29n",
                  "bGUucHJvdG9idWYuVGltZXN0YW1wEjEKDW1vdmVfb3V0X3RpbWUYBCABKAsy",
                  "Gi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEkQKEHByaXZhY3lfc2V0dGlu",
                  "Z3MYBSABKAsyKi5zYWx0by5uZWJ1bGEudW5pdC52MS5Vbml0LlByaXZhY3lT",
                  "ZXR0aW5ncxIdChVkZWZhdWx0X2FjY2Vzc19yaWdodHMYBiADKAkSFAoHbWFu",
                  "YWdlchgHIAEoCUgAiAEBGiIKD1ByaXZhY3lTZXR0aW5ncxIPCgdlbmFibGVk",
                  "GAEgASgIQgoKCF9tYW5hZ2VyIjUKBlBvbGljeRIMCgRuYW1lGAEgASgJEg4K",
                  "Bm1lbWJlchgCIAEoCRINCgVyb2xlcxgDIAMoCSJvChFDcmVhdGVVbml0UmVx",
                  "dWVzdBIOCgZwYXJlbnQYASABKAkSFAoHdW5pdF9pZBgCIAEoCUgAiAEBEigK",
                  "BHVuaXQYAyABKAsyGi5zYWx0by5uZWJ1bGEudW5pdC52MS5Vbml0QgoKCF91",
                  "bml0X2lkIh4KDkdldFVuaXRSZXF1ZXN0EgwKBG5hbWUYASABKAkiawoQTGlz",
                  "dFVuaXRzUmVxdWVzdBIOCgZwYXJlbnQYASABKAkSEQoJcGFnZV9zaXplGAIg",
                  "ASgFEhIKCnBhZ2VfdG9rZW4YAyABKAkSDgoGZmlsdGVyGAQgASgJEhAKCG9y",
                  "ZGVyX2J5GAUgASgJIlcKEUxpc3RVbml0c1Jlc3BvbnNlEikKBXVuaXRzGAEg",
                  "AygLMhouc2FsdG8ubmVidWxhLnVuaXQudjEuVW5pdBIXCg9uZXh0X3BhZ2Vf",
                  "dG9rZW4YAiABKAkibgoRVXBkYXRlVW5pdFJlcXVlc3QSKAoEdW5pdBgBIAEo",
                  "CzIaLnNhbHRvLm5lYnVsYS51bml0LnYxLlVuaXQSLwoLdXBkYXRlX21hc2sY",
                  "AiABKAsyGi5nb29nbGUucHJvdG9idWYuRmllbGRNYXNrIiEKEURlbGV0ZVVu",
                  "aXRSZXF1ZXN0EgwKBG5hbWUYASABKAkiIwoTQ2xlYW5PdXRVbml0UmVxdWVz",
                  "dBIMCgRuYW1lGAEgASgJIhYKFENsZWFuT3V0VW5pdFJlc3BvbnNlIvkBChFN",
                  "b3ZlSW5Vbml0UmVxdWVzdBIMCgRuYW1lGAEgASgJEkMKCW9jY3VwYW50cxgC",
                  "IAMoCzIwLnNhbHRvLm5lYnVsYS51bml0LnYxLk1vdmVJblVuaXRSZXF1ZXN0",
                  "Lk9jY3VwYW50GpABCghPY2N1cGFudBISCgpnaXZlbl9uYW1lGAEgASgJEhgK",
                  "C2ZhbWlseV9uYW1lGAIgASgJSACIAQESEgoFZW1haWwYAyABKAlIAYgBARIV",
                  "Cg1hY2Nlc3NfcmlnaHRzGAQgAygJEhEKCWlhbV9yb2xlcxgFIAMoCUIOCgxf",
                  "ZmFtaWx5X25hbWVCCAoGX2VtYWlsIhQKEk1vdmVJblVuaXRSZXNwb25zZSIi",
                  "ChJNb3ZlT3V0VW5pdFJlcXVlc3QSDAoEbmFtZRgBIAEoCSIVChNNb3ZlT3V0",
                  "VW5pdFJlc3BvbnNlImYKE0NyZWF0ZVBvbGljeVJlcXVlc3QSDgoGcGFyZW50",
                  "GAEgASgJEhEKCXBvbGljeV9pZBgCIAEoCRIsCgZwb2xpY3kYAyABKAsyHC5z",
                  "YWx0by5uZWJ1bGEudW5pdC52MS5Qb2xpY3kiIAoQR2V0UG9saWN5UmVxdWVz",
                  "dBIMCgRuYW1lGAEgASgJIm4KE0xpc3RQb2xpY2llc1JlcXVlc3QSDgoGcGFy",
                  "ZW50GAEgASgJEhEKCXBhZ2Vfc2l6ZRgCIAEoBRISCgpwYWdlX3Rva2VuGAMg",
                  "ASgJEg4KBmZpbHRlchgEIAEoCRIQCghvcmRlcl9ieRgFIAEoCSJfChRMaXN0",
                  "UG9saWNpZXNSZXNwb25zZRIuCghwb2xpY2llcxgBIAMoCzIcLnNhbHRvLm5l",
                  "YnVsYS51bml0LnYxLlBvbGljeRIXCg9uZXh0X3BhZ2VfdG9rZW4YAiABKAki",
                  "dAoTVXBkYXRlUG9saWN5UmVxdWVzdBIsCgZwb2xpY3kYASABKAsyHC5zYWx0",
                  "by5uZWJ1bGEudW5pdC52MS5Qb2xpY3kSLwoLdXBkYXRlX21hc2sYAiABKAsy",
                  "Gi5nb29nbGUucHJvdG9idWYuRmllbGRNYXNrIiMKE0RlbGV0ZVBvbGljeVJl",
                  "cXVlc3QSDAoEbmFtZRgBIAEoCSI7ChZUZXN0UGVybWlzc2lvbnNSZXF1ZXN0",
                  "EgwKBHVuaXQYASABKAkSEwoLcGVybWlzc2lvbnMYAiADKAkiLgoXVGVzdFBl",
                  "cm1pc3Npb25zUmVzcG9uc2USEwoLcGVybWlzc2lvbnMYASADKAkyiAoKC1Vu",
                  "aXRTZXJ2aWNlElEKCkNyZWF0ZVVuaXQSJy5zYWx0by5uZWJ1bGEudW5pdC52",
                  "MS5DcmVhdGVVbml0UmVxdWVzdBoaLnNhbHRvLm5lYnVsYS51bml0LnYxLlVu",
                  "aXQSSwoHR2V0VW5pdBIkLnNhbHRvLm5lYnVsYS51bml0LnYxLkdldFVuaXRS",
                  "ZXF1ZXN0Ghouc2FsdG8ubmVidWxhLnVuaXQudjEuVW5pdBJcCglMaXN0VW5p",
                  "dHMSJi5zYWx0by5uZWJ1bGEudW5pdC52MS5MaXN0VW5pdHNSZXF1ZXN0Gicu",
                  "c2FsdG8ubmVidWxhLnVuaXQudjEuTGlzdFVuaXRzUmVzcG9uc2USUQoKVXBk",
                  "YXRlVW5pdBInLnNhbHRvLm5lYnVsYS51bml0LnYxLlVwZGF0ZVVuaXRSZXF1",
                  "ZXN0Ghouc2FsdG8ubmVidWxhLnVuaXQudjEuVW5pdBJNCgpEZWxldGVVbml0",
                  "Eicuc2FsdG8ubmVidWxhLnVuaXQudjEuRGVsZXRlVW5pdFJlcXVlc3QaFi5n",
                  "b29nbGUucHJvdG9idWYuRW1wdHkSZQoMQ2xlYW5PdXRVbml0Eikuc2FsdG8u",
                  "bmVidWxhLnVuaXQudjEuQ2xlYW5PdXRVbml0UmVxdWVzdBoqLnNhbHRvLm5l",
                  "YnVsYS51bml0LnYxLkNsZWFuT3V0VW5pdFJlc3BvbnNlEl8KCk1vdmVJblVu",
                  "aXQSJy5zYWx0by5uZWJ1bGEudW5pdC52MS5Nb3ZlSW5Vbml0UmVxdWVzdBoo",
                  "LnNhbHRvLm5lYnVsYS51bml0LnYxLk1vdmVJblVuaXRSZXNwb25zZRJiCgtN",
                  "b3ZlT3V0VW5pdBIoLnNhbHRvLm5lYnVsYS51bml0LnYxLk1vdmVPdXRVbml0",
                  "UmVxdWVzdBopLnNhbHRvLm5lYnVsYS51bml0LnYxLk1vdmVPdXRVbml0UmVz",
                  "cG9uc2USVwoMQ3JlYXRlUG9saWN5Eikuc2FsdG8ubmVidWxhLnVuaXQudjEu",
                  "Q3JlYXRlUG9saWN5UmVxdWVzdBocLnNhbHRvLm5lYnVsYS51bml0LnYxLlBv",
                  "bGljeRJRCglHZXRQb2xpY3kSJi5zYWx0by5uZWJ1bGEudW5pdC52MS5HZXRQ",
                  "b2xpY3lSZXF1ZXN0Ghwuc2FsdG8ubmVidWxhLnVuaXQudjEuUG9saWN5EmUK",
                  "DExpc3RQb2xpY2llcxIpLnNhbHRvLm5lYnVsYS51bml0LnYxLkxpc3RQb2xp",
                  "Y2llc1JlcXVlc3QaKi5zYWx0by5uZWJ1bGEudW5pdC52MS5MaXN0UG9saWNp",
                  "ZXNSZXNwb25zZRJXCgxVcGRhdGVQb2xpY3kSKS5zYWx0by5uZWJ1bGEudW5p",
                  "dC52MS5VcGRhdGVQb2xpY3lSZXF1ZXN0Ghwuc2FsdG8ubmVidWxhLnVuaXQu",
                  "djEuUG9saWN5ElEKDERlbGV0ZVBvbGljeRIpLnNhbHRvLm5lYnVsYS51bml0",
                  "LnYxLkRlbGV0ZVBvbGljeVJlcXVlc3QaFi5nb29nbGUucHJvdG9idWYuRW1w",
                  "dHkSbgoPVGVzdFBlcm1pc3Npb25zEiwuc2FsdG8ubmVidWxhLnVuaXQudjEu",
                  "VGVzdFBlcm1pc3Npb25zUmVxdWVzdBotLnNhbHRvLm5lYnVsYS51bml0LnYx",
                  "LlRlc3RQZXJtaXNzaW9uc1Jlc3BvbnNlQsgBChxjb20uc2FsdG9hcGlzLm5l",
                  "YnVsYS51bml0LnYxQglVbml0UHJvdG9QAVo+Z2l0aHViLmNvbS9zYWx0b2Fw",
                  "aXMtaW50ZXJuYWwvc2FsdG9hcGlzLWdvL25lYnVsYS91bml0L3YxO3VuaXSq",
                  "AhhTYWx0b2FwaXMuTmVidWxhLlVuaXQuVjHKAhhTYWx0b2FwaXNcTmVidWxh",
                  "XFVuaXRcVjHiAiRHUEJNZXRhZGF0YVxTYWx0b2FwaXNcTmVidWxhXFVuaXRc",
                  "VjFiBnByb3RvMw=="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Unit), Unit.Parser, ["Name", "DisplayName", "MoveInTime", "MoveOutTime", "PrivacySettings", "DefaultAccessRights", "Manager"], ["Manager"], null, null, [new(typeof(Unit.Types.PrivacySettings), Unit.Types.PrivacySettings.Parser, ["Enabled"], null, null, null, null)]),
            new(typeof(Policy), Policy.Parser, ["Name", "Member", "Roles"], null, null, null, null),
            new(typeof(CreateUnitRequest), CreateUnitRequest.Parser, ["Parent", "UnitId", "Unit"], ["UnitId"], null, null, null),
            new(typeof(GetUnitRequest), GetUnitRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListUnitsRequest), ListUnitsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListUnitsResponse), ListUnitsResponse.Parser, ["Units", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateUnitRequest), UpdateUnitRequest.Parser, ["Unit", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteUnitRequest), DeleteUnitRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(CleanOutUnitRequest), CleanOutUnitRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(CleanOutUnitResponse), CleanOutUnitResponse.Parser, null, null, null, null, null),
            new(typeof(MoveInUnitRequest), MoveInUnitRequest.Parser, ["Name", "Occupants"], null, null, null, [new(typeof(MoveInUnitRequest.Types.Occupant), MoveInUnitRequest.Types.Occupant.Parser, ["GivenName", "FamilyName", "Email", "AccessRights", "IamRoles"], ["FamilyName", "Email"], null, null, null)]),
            new(typeof(MoveInUnitResponse), MoveInUnitResponse.Parser, null, null, null, null, null),
            new(typeof(MoveOutUnitRequest), MoveOutUnitRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(MoveOutUnitResponse), MoveOutUnitResponse.Parser, null, null, null, null, null),
            new(typeof(CreatePolicyRequest), CreatePolicyRequest.Parser, ["Parent", "PolicyId", "Policy"], null, null, null, null),
            new(typeof(GetPolicyRequest), GetPolicyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListPoliciesRequest), ListPoliciesRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListPoliciesResponse), ListPoliciesResponse.Parser, ["Policies", "NextPageToken"], null, null, null, null),
            new(typeof(UpdatePolicyRequest), UpdatePolicyRequest.Parser, ["Policy", "UpdateMask"], null, null, null, null),
            new(typeof(DeletePolicyRequest), DeletePolicyRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(TestPermissionsRequest), TestPermissionsRequest.Parser, ["Unit", "Permissions"], null, null, null, null),
            new(typeof(TestPermissionsResponse), TestPermissionsResponse.Parser, ["Permissions"], null, null, null, null)
                ]));
        }

    }


}
