using Google.Protobuf.Reflection;
using Saltoapis.Nebula.Iam.V1.Request;
using Saltoapis.Nebula.Iam.V1.Response;

namespace Saltoapis.Nebula.Iam.V1
{
    /// <summary>Holder for reflection information generated from salto/nebula/iam/v1/iam.proto</summary>
    public static partial class IamReflection
    {

        /// <summary>File descriptor for salto/nebula/iam/v1/iam.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static FileDescriptor descriptor;

        static IamReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "Ch1zYWx0by9uZWJ1bGEvaWFtL3YxL2lhbS5wcm90bxITc2FsdG8ubmVidWxh",
                  "LmlhbS52MSI/CgRSb2xlEgwKBG5hbWUYASABKAkSFAoMZGlzcGxheV9uYW1l",
                  "GAIgASgJEhMKC3Blcm1pc3Npb25zGAMgAygJIh4KDkdldFJvbGVSZXF1ZXN0",
                  "EgwKBG5hbWUYASABKAkiawoQTGlzdFJvbGVzUmVxdWVzdBIOCgZwYXJlbnQY",
                  "ASABKAkSEQoJcGFnZV9zaXplGAIgASgFEhIKCnBhZ2VfdG9rZW4YAyABKAkS",
                  "DgoGZmlsdGVyGAQgASgJEhAKCG9yZGVyX2J5GAUgASgJIlYKEUxpc3RSb2xl",
                  "c1Jlc3BvbnNlEigKBXJvbGVzGAEgAygLMhkuc2FsdG8ubmVidWxhLmlhbS52",
                  "MS5Sb2xlEhcKD25leHRfcGFnZV90b2tlbhgCIAEoCTKzAQoKSUFNU2Vydmlj",
                  "ZRJJCgdHZXRSb2xlEiMuc2FsdG8ubmVidWxhLmlhbS52MS5HZXRSb2xlUmVx",
                  "dWVzdBoZLnNhbHRvLm5lYnVsYS5pYW0udjEuUm9sZRJaCglMaXN0Um9sZXMS",
                  "JS5zYWx0by5uZWJ1bGEuaWFtLnYxLkxpc3RSb2xlc1JlcXVlc3QaJi5zYWx0",
                  "by5uZWJ1bGEuaWFtLnYxLkxpc3RSb2xlc1Jlc3BvbnNlQsEBChtjb20uc2Fs",
                  "dG9hcGlzLm5lYnVsYS5pYW0udjFCCElhbVByb3RvUAFaPGdpdGh1Yi5jb20v",
                  "c2FsdG9hcGlzLWludGVybmFsL3NhbHRvYXBpcy1nby9uZWJ1bGEvaWFtL3Yx",
                  "O2lhbaoCF1NhbHRvYXBpcy5OZWJ1bGEuSWFtLlYxygIXU2FsdG9hcGlzXE5l",
                  "YnVsYVxJYW1cVjHiAiNHUEJNZXRhZGF0YVxTYWx0b2FwaXNcTmVidWxhXElh",
                  "bVxWMWIGcHJvdG8z"));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Role), Role.Parser, ["Name", "DisplayName", "Permissions"], null, null, null, null),
            new(typeof(GetRoleRequest), GetRoleRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListRolesRequest), ListRolesRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListRolesResponse), ListRolesResponse.Parser, ["Roles", "NextPageToken"], null, null, null, null)
                ]));
        }

    }


}
