using Saltoapis.Nebula.Booking.V1.Request;
using Saltoapis.Nebula.Booking.V1.Response;

namespace Saltoapis.Nebula.Booking.V1
{
    /// <summary>Holder for reflection information generated from salto/nebula/booking/v1/booking.proto</summary>
    public static partial class BookingReflection
    {
        /// <summary>File descriptor for salto/nebula/booking/v1/booking.proto</summary>
        public static FileDescriptor Descriptor
        {
            get => descriptor;}

        private static FileDescriptor descriptor;

        static BookingReflection()
        {
            byte[] descriptorData = System.Convert.FromBase64String(
                string.Concat(
                  "CiVzYWx0by9uZWJ1bGEvYm9va2luZy92MS9ib29raW5nLnByb3RvEhdzYWx0",
                  "by5uZWJ1bGEuYm9va2luZy52MRobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnBy",
                  "b3RvGiBnb29nbGUvcHJvdG9idWYvZmllbGRfbWFzay5wcm90bxofZ29vZ2xl",
                  "L3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byKTAwoHQm9va2luZxIMCgRuYW1l",
                  "GAEgASgJEi4KCnN0YXJ0X3RpbWUYAiABKAsyGi5nb29nbGUucHJvdG9idWYu",
                  "VGltZXN0YW1wEiwKCGVuZF90aW1lGAMgASgLMhouZ29vZ2xlLnByb3RvYnVm",
                  "LlRpbWVzdGFtcBI1CgVzdGF0ZRgEIAEoDjImLnNhbHRvLm5lYnVsYS5ib29r",
                  "aW5nLnYxLkJvb2tpbmcuU3RhdGUSMQoNY2hlY2tfaW5fdGltZRgFIAEoCzIa",
                  "Lmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASMgoOY2hlY2tfb3V0X3RpbWUY",
                  "BiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEg4KBHVuaXQYByAB",
                  "KAlIABIVCg1hY2Nlc3NfcmlnaHRzGAggAygJIk4KBVN0YXRlEhUKEVNUQVRF",
                  "X1VOU1BFQ0lGSUVEEAASDQoJU0NIRURVTEVEEAESDgoKQ0hFQ0tFRF9JThAC",
                  "Eg8KC0NIRUNLRURfT1VUEANCBwoFYXNzZXQigQEKFENyZWF0ZUJvb2tpbmdS",
                  "ZXF1ZXN0Eg4KBnBhcmVudBgBIAEoCRIXCgpib29raW5nX2lkGAIgASgJSACI",
                  "AQESMQoHYm9va2luZxgDIAEoCzIgLnNhbHRvLm5lYnVsYS5ib29raW5nLnYx",
                  "LkJvb2tpbmdCDQoLX2Jvb2tpbmdfaWQiIQoRR2V0Qm9va2luZ1JlcXVlc3QS",
                  "DAoEbmFtZRgBIAEoCSJuChNMaXN0Qm9va2luZ3NSZXF1ZXN0Eg4KBnBhcmVu",
                  "dBgBIAEoCRIRCglwYWdlX3NpemUYAiABKAUSEgoKcGFnZV90b2tlbhgDIAEo",
                  "CRIOCgZmaWx0ZXIYBCABKAkSEAoIb3JkZXJfYnkYBSABKAkiYwoUTGlzdEJv",
                  "b2tpbmdzUmVzcG9uc2USMgoIYm9va2luZ3MYASADKAsyIC5zYWx0by5uZWJ1",
                  "bGEuYm9va2luZy52MS5Cb29raW5nEhcKD25leHRfcGFnZV90b2tlbhgCIAEo",
                  "CSJ6ChRVcGRhdGVCb29raW5nUmVxdWVzdBIxCgdib29raW5nGAEgASgLMiAu",
                  "c2FsdG8ubmVidWxhLmJvb2tpbmcudjEuQm9va2luZxIvCgt1cGRhdGVfbWFz",
                  "axgCIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE1hc2siJAoURGVsZXRl",
                  "Qm9va2luZ1JlcXVlc3QSDAoEbmFtZRgBIAEoCSIlChVDaGVja0luQm9va2lu",
                  "Z1JlcXVlc3QSDAoEbmFtZRgBIAEoCSImChZDaGVja091dEJvb2tpbmdSZXF1",
                  "ZXN0EgwKBG5hbWUYASABKAkiKQoLQm9va2luZ1VzZXISDAoEbmFtZRgBIAEo",
                  "CRIMCgR1c2VyGAIgASgJImYKGENyZWF0ZUJvb2tpbmdVc2VyUmVxdWVzdBIO",
                  "CgZwYXJlbnQYASABKAkSOgoMYm9va2luZ191c2VyGAIgASgLMiQuc2FsdG8u",
                  "bmVidWxhLmJvb2tpbmcudjEuQm9va2luZ1VzZXIiJQoVR2V0Qm9va2luZ1Vz",
                  "ZXJSZXF1ZXN0EgwKBG5hbWUYASABKAkicgoXTGlzdEJvb2tpbmdVc2Vyc1Jl",
                  "cXVlc3QSDgoGcGFyZW50GAEgASgJEhEKCXBhZ2Vfc2l6ZRgCIAEoBRISCgpw",
                  "YWdlX3Rva2VuGAMgASgJEg4KBmZpbHRlchgEIAEoCRIQCghvcmRlcl9ieRgF",
                  "IAEoCSJwChhMaXN0Qm9va2luZ1VzZXJzUmVzcG9uc2USOwoNYm9va2luZ191",
                  "c2VycxgBIAMoCzIkLnNhbHRvLm5lYnVsYS5ib29raW5nLnYxLkJvb2tpbmdV",
                  "c2VyEhcKD25leHRfcGFnZV90b2tlbhgCIAEoCSIoChhEZWxldGVCb29raW5n",
                  "VXNlclJlcXVlc3QSDAoEbmFtZRgBIAEoCTLuCAoOQm9va2luZ1NlcnZpY2US",
                  "YAoNQ3JlYXRlQm9va2luZxItLnNhbHRvLm5lYnVsYS5ib29raW5nLnYxLkNy",
                  "ZWF0ZUJvb2tpbmdSZXF1ZXN0GiAuc2FsdG8ubmVidWxhLmJvb2tpbmcudjEu",
                  "Qm9va2luZxJaCgpHZXRCb29raW5nEiouc2FsdG8ubmVidWxhLmJvb2tpbmcu",
                  "djEuR2V0Qm9va2luZ1JlcXVlc3QaIC5zYWx0by5uZWJ1bGEuYm9va2luZy52",
                  "MS5Cb29raW5nEmsKDExpc3RCb29raW5ncxIsLnNhbHRvLm5lYnVsYS5ib29r",
                  "aW5nLnYxLkxpc3RCb29raW5nc1JlcXVlc3QaLS5zYWx0by5uZWJ1bGEuYm9v",
                  "a2luZy52MS5MaXN0Qm9va2luZ3NSZXNwb25zZRJgCg1VcGRhdGVCb29raW5n",
                  "Ei0uc2FsdG8ubmVidWxhLmJvb2tpbmcudjEuVXBkYXRlQm9va2luZ1JlcXVl",
                  "c3QaIC5zYWx0by5uZWJ1bGEuYm9va2luZy52MS5Cb29raW5nElYKDURlbGV0",
                  "ZUJvb2tpbmcSLS5zYWx0by5uZWJ1bGEuYm9va2luZy52MS5EZWxldGVCb29r",
                  "aW5nUmVxdWVzdBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRJiCg5DaGVja0lu",
                  "Qm9va2luZxIuLnNhbHRvLm5lYnVsYS5ib29raW5nLnYxLkNoZWNrSW5Cb29r",
                  "aW5nUmVxdWVzdBogLnNhbHRvLm5lYnVsYS5ib29raW5nLnYxLkJvb2tpbmcS",
                  "ZAoPQ2hlY2tPdXRCb29raW5nEi8uc2FsdG8ubmVidWxhLmJvb2tpbmcudjEu",
                  "Q2hlY2tPdXRCb29raW5nUmVxdWVzdBogLnNhbHRvLm5lYnVsYS5ib29raW5n",
                  "LnYxLkJvb2tpbmcSbAoRQ3JlYXRlQm9va2luZ1VzZXISMS5zYWx0by5uZWJ1",
                  "bGEuYm9va2luZy52MS5DcmVhdGVCb29raW5nVXNlclJlcXVlc3QaJC5zYWx0",
                  "by5uZWJ1bGEuYm9va2luZy52MS5Cb29raW5nVXNlchJmCg5HZXRCb29raW5n",
                  "VXNlchIuLnNhbHRvLm5lYnVsYS5ib29raW5nLnYxLkdldEJvb2tpbmdVc2Vy",
                  "UmVxdWVzdBokLnNhbHRvLm5lYnVsYS5ib29raW5nLnYxLkJvb2tpbmdVc2Vy",
                  "EncKEExpc3RCb29raW5nVXNlcnMSMC5zYWx0by5uZWJ1bGEuYm9va2luZy52",
                  "MS5MaXN0Qm9va2luZ1VzZXJzUmVxdWVzdBoxLnNhbHRvLm5lYnVsYS5ib29r",
                  "aW5nLnYxLkxpc3RCb29raW5nVXNlcnNSZXNwb25zZRJeChFEZWxldGVCb29r",
                  "aW5nVXNlchIxLnNhbHRvLm5lYnVsYS5ib29raW5nLnYxLkRlbGV0ZUJvb2tp",
                  "bmdVc2VyUmVxdWVzdBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eULdAQofY29t",
                  "LnNhbHRvYXBpcy5uZWJ1bGEuYm9va2luZy52MUIMQm9va2luZ1Byb3RvUAFa",
                  "RGdpdGh1Yi5jb20vc2FsdG9hcGlzLWludGVybmFsL3NhbHRvYXBpcy1nby9u",
                  "ZWJ1bGEvYm9va2luZy92MTtib29raW5nqgIbU2FsdG9hcGlzLk5lYnVsYS5C",
                  "b29raW5nLlYxygIbU2FsdG9hcGlzXE5lYnVsYVxCb29raW5nXFYx4gInR1BC",
                  "TWV0YWRhdGFcU2FsdG9hcGlzXE5lYnVsYVxCb29raW5nXFYxYgZwcm90bzM="));
            descriptor = FileDescriptor.FromGeneratedCode(descriptorData,
                [Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor,],
                new GeneratedClrTypeInfo(null, null, [
            new(typeof(Booking), Booking.Parser, ["Name", "StartTime", "EndTime", "State", "CheckInTime", "CheckOutTime", "Unit", "AccessRights"], ["Asset"], [typeof(Booking.Types.State)], null, null),
            new(typeof(CreateBookingRequest), CreateBookingRequest.Parser, ["Parent", "BookingId", "Booking"], ["BookingId"], null, null, null),
            new(typeof(GetBookingRequest), GetBookingRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListBookingsRequest), ListBookingsRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListBookingsResponse), ListBookingsResponse.Parser, ["Bookings", "NextPageToken"], null, null, null, null),
            new(typeof(UpdateBookingRequest), UpdateBookingRequest.Parser, ["Booking", "UpdateMask"], null, null, null, null),
            new(typeof(DeleteBookingRequest), DeleteBookingRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(CheckInBookingRequest), CheckInBookingRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(CheckOutBookingRequest), CheckOutBookingRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(BookingUser), BookingUser.Parser, ["Name", "User"], null, null, null, null),
            new(typeof(CreateBookingUserRequest), CreateBookingUserRequest.Parser, ["Parent", "BookingUser"], null, null, null, null),
            new(typeof(GetBookingUserRequest), GetBookingUserRequest.Parser, ["Name"], null, null, null, null),
            new(typeof(ListBookingUsersRequest), ListBookingUsersRequest.Parser, ["Parent", "PageSize", "PageToken", "Filter", "OrderBy"], null, null, null, null),
            new(typeof(ListBookingUsersResponse), ListBookingUsersResponse.Parser, ["BookingUsers", "NextPageToken"], null, null, null, null),
            new(typeof(DeleteBookingUserRequest), DeleteBookingUserRequest.Parser, ["Name"], null, null, null, null)
                ]));
        }
    }

}