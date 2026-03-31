using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Booking.V1
{

    /// <summary>Holder for reflection information generated from salto/nebula/booking/v1/booking.proto</summary>
    public static partial class BookingReflection
    {

        #region Descriptor
        /// <summary>File descriptor for salto/nebula/booking/v1/booking.proto</summary>
        public static FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

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
        #endregion

    }
    #region Messages
    /// <summary>
    /// The booking object
    /// Represents a booking resource that contains the contractual details of a stay,
    /// decoupled from the physical state of the booked asset.
    /// </summary>
    public sealed partial class Booking : IMessage<Booking>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Booking> _parser = new(() => new Booking());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<Booking> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Booking()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Booking(Booking other) : this()
        {
            name_ = other.name_;
            startTime_ = other.startTime_?.Clone();
            endTime_ = other.endTime_?.Clone();
            state_ = other.state_;
            checkInTime_ = other.checkInTime_?.Clone();
            checkOutTime_ = other.checkOutTime_?.Clone();
            accessRights_ = other.accessRights_.Clone();
            switch (other.AssetCase)
            {
                case AssetOneofCase.Unit:
                    Unit = other.Unit;
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Booking Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// Output only. Resource name of the booking. It must have the format of
        /// `installations/*/bookings/*`. For example:
        /// `installations/surelock-homes-hq/bookings/my-booking`.
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
        /// The start time of the booking. When creating a booking, this is the planned
        /// start time. Once the booking has started/checked in, it represents the
        /// actual start time.
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
        /// The end time of the booking. When creating a booking, this is the planned
        /// end time. Once the booking has completed/checked out, it represents the
        /// actual end time.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp EndTime
        {
            get { return endTime_; }
            set
            {
                endTime_ = value;
            }
        }

        /// <summary>Field number for the "state" field.</summary>
        public const int StateFieldNumber = 4;
        private Types.State state_ = Types.State.Unspecified;

        /// <summary>
        /// The lifecycle state of the booking.
        /// </summary>
        public Types.State State
        {
            get { return state_; }
            set
            {
                state_ = value;
            }
        }

        /// <summary>Field number for the "check_in_time" field.</summary>
        public const int CheckInTimeFieldNumber = 5;
        private Google.Protobuf.WellKnownTypes.Timestamp checkInTime_;

        /// <summary>
        /// The timestamp when the check-in was performed.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp CheckInTime
        {
            get { return checkInTime_; }
            set
            {
                checkInTime_ = value;
            }
        }

        /// <summary>Field number for the "check_out_time" field.</summary>
        public const int CheckOutTimeFieldNumber = 6;
        private Google.Protobuf.WellKnownTypes.Timestamp checkOutTime_;

        /// <summary>
        /// The timestamp when the check-out was performed.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.Timestamp CheckOutTime
        {
            get { return checkOutTime_; }
            set
            {
                checkOutTime_ = value;
            }
        }

        /// <summary>Field number for the "unit" field.</summary>
        public const int UnitFieldNumber = 7;

        /// <summary>
        /// The unit resource reference assigned to the booking.
        /// </summary>
        public string Unit
        {
            get { return HasUnit ? (string)asset_ : ""; }
            set
            {
                asset_ = ProtoPreconditions.CheckNotNull(value, "value");
                assetCase_ = AssetOneofCase.Unit;
            }
        }

        /// <summary>Gets whether the "unit" field is set</summary>
        public bool HasUnit
        {
            get { return assetCase_ == AssetOneofCase.Unit; }
        }

        /// <summary> Clears the value of the oneof if it's currently set to "unit" </summary>
        public void ClearUnit()
        {
            if (HasUnit)
            {
                ClearAsset();
            }
        }

        /// <summary>Field number for the "access_rights" field.</summary>
        public const int AccessRightsFieldNumber = 8;
        private static readonly FieldCodec<string> _repeated_accessRights_codec
            = FieldCodec.ForString(66);
        private readonly RepeatedField<string> accessRights_ = [];

        /// <summary>
        /// Access rights explicitly associated with the booking, such as common areas
        /// or facilities. A maximum of 5 access rights can be specified.
        ///
        /// These access rights are combined with the default access rights provided by
        /// the booked asset. They ensure the user has access to necessary areas as
        /// part of this booking, regardless of the specific asset's configuration.
        /// </summary>
        public RepeatedField<string> AccessRights
        {
            get { return accessRights_; }
        }

        private object asset_;

        /// <summary>Enum of possible cases for the "asset" oneof.</summary>
        public enum AssetOneofCase
        {
            None = 0,
            Unit = 7,
        }

        private AssetOneofCase assetCase_ = AssetOneofCase.None;

        public AssetOneofCase AssetCase
        {
            get { return assetCase_; }
        }

        public void ClearAsset()
        {
            assetCase_ = AssetOneofCase.None;
            asset_ = null;
        }

        public override bool Equals(object other) => Equals(other as Booking);
        public bool Equals(Booking other)
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
            if (State != other.State) return false;
            if (!Equals(CheckInTime, other.CheckInTime)) return false;
            if (!Equals(CheckOutTime, other.CheckOutTime)) return false;
            if (Unit != other.Unit) return false;
            if (!accessRights_.Equals(other.accessRights_)) return false;
            if (AssetCase != other.AssetCase) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (startTime_ != null) hash ^= StartTime.GetHashCode();
            if (endTime_ != null) hash ^= EndTime.GetHashCode();
            if (State != Types.State.Unspecified) hash ^= State.GetHashCode();
            if (checkInTime_ != null) hash ^= CheckInTime.GetHashCode();
            if (checkOutTime_ != null) hash ^= CheckOutTime.GetHashCode();
            if (HasUnit) hash ^= Unit.GetHashCode();
            hash ^= accessRights_.GetHashCode();
            hash ^= (int)assetCase_;
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
      if (State != Saltoapis.Nebula.Booking.V1.Booking.Types.State.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
      }
      if (checkInTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CheckInTime);
      }
      if (checkOutTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CheckOutTime);
      }
      if (HasUnit) {
        output.WriteRawTag(58);
        output.WriteString(Unit);
      }
      accessRights_.WriteTo(output, _repeated_accessRights_codec);
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
            if (State != Types.State.Unspecified)
            {
                output.WriteRawTag(32);
                output.WriteEnum((int)State);
            }
            if (checkInTime_ != null)
            {
                output.WriteRawTag(42);
                output.WriteMessage(CheckInTime);
            }
            if (checkOutTime_ != null)
            {
                output.WriteRawTag(50);
                output.WriteMessage(CheckOutTime);
            }
            if (HasUnit)
            {
                output.WriteRawTag(58);
                output.WriteString(Unit);
            }
            accessRights_.WriteTo(ref output, _repeated_accessRights_codec);
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
            if (State != Types.State.Unspecified)
            {
                size += 1 + CodedOutputStream.ComputeEnumSize((int)State);
            }
            if (checkInTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(CheckInTime);
            }
            if (checkOutTime_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(CheckOutTime);
            }
            if (HasUnit)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(Unit);
            }
            size += accessRights_.CalculateSize(_repeated_accessRights_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(Booking other)
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
            if (other.State != Types.State.Unspecified)
            {
                State = other.State;
            }
            if (other.checkInTime_ != null)
            {
                if (checkInTime_ == null)
                {
                    CheckInTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                CheckInTime.MergeFrom(other.CheckInTime);
            }
            if (other.checkOutTime_ != null)
            {
                if (checkOutTime_ == null)
                {
                    CheckOutTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                }
                CheckOutTime.MergeFrom(other.CheckOutTime);
            }
            accessRights_.Add(other.accessRights_);
            switch (other.AssetCase)
            {
                case AssetOneofCase.Unit:
                    Unit = other.Unit;
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
          case 32: {
            State = (Saltoapis.Nebula.Booking.V1.Booking.Types.State) input.ReadEnum();
            break;
          }
          case 42: {
            if (checkInTime_ == null) {
              CheckInTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CheckInTime);
            break;
          }
          case 50: {
            if (checkOutTime_ == null) {
              CheckOutTime = new Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CheckOutTime);
            break;
          }
          case 58: {
            Unit = input.ReadString();
            break;
          }
          case 66: {
            accessRights_.AddEntriesFrom(input, _repeated_accessRights_codec);
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
                    case 32:
                        {
                            State = (Types.State)input.ReadEnum();
                            break;
                        }
                    case 42:
                        {
                            if (checkInTime_ == null)
                            {
                                CheckInTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(CheckInTime);
                            break;
                        }
                    case 50:
                        {
                            if (checkOutTime_ == null)
                            {
                                CheckOutTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            }
                            input.ReadMessage(CheckOutTime);
                            break;
                        }
                    case 58:
                        {
                            Unit = input.ReadString();
                            break;
                        }
                    case 66:
                        {
                            accessRights_.AddEntriesFrom(ref input, _repeated_accessRights_codec);
                            break;
                        }
                }
            }
        }
#endif

        #region Nested types
        /// <summary>Container for nested types declared in the Booking message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// State for a booking.
            /// </summary>
            public enum State
            {
                /// <summary>
                /// Sentinel value used to indicate that the state is unknown, omitted,
                /// or is not applicable.
                /// </summary>
                [OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
                /// <summary>
                /// The booking is scheduled but the user has not yet checked in.
                /// </summary>
                [OriginalName("SCHEDULED")] Scheduled = 1,
                /// <summary>
                /// The booking is checked in.
                /// </summary>
                [OriginalName("CHECKED_IN")] CheckedIn = 2,
                /// <summary>
                /// The booking is checked out.
                /// </summary>
                [OriginalName("CHECKED_OUT")] CheckedOut = 3,
            }

        }
        #endregion

    }

    /// <summary>
    /// The request message for [CreateBooking][salto.nebula.booking.v1.BookingService.CreateBooking]
    /// </summary>
    public sealed partial class CreateBookingRequest : IMessage<CreateBookingRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateBookingRequest> _parser = new(() => new CreateBookingRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateBookingRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.MessageTypes[1]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateBookingRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateBookingRequest(CreateBookingRequest other) : this()
        {
            parent_ = other.parent_;
            bookingId_ = other.bookingId_;
            booking_ = other.booking_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateBookingRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource under which the booking is created. For
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

        /// <summary>Field number for the "booking_id" field.</summary>
        public const int BookingIdFieldNumber = 2;
        private readonly static string BookingIdDefaultValue = "";

        private string bookingId_;

        /// <summary>
        /// The booking ID to use for this booking. In case it's empty the
        /// server will autogenerate a unique identifier.
        /// </summary>
        public string BookingId
        {
            get { return bookingId_ ?? BookingIdDefaultValue; }
            set
            {
                bookingId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "booking_id" field is set</summary>
        public bool HasBookingId
        {
            get { return bookingId_ != null; }
        }

        /// <summary>Clears the value of the "booking_id" field</summary>
        public void ClearBookingId()
        {
            bookingId_ = null;
        }

        /// <summary>Field number for the "booking" field.</summary>
        public const int BookingFieldNumber = 3;
        private Booking booking_;

        /// <summary>
        /// The booking resource to be created. Client must not set the
        /// `Booking.name` field.
        /// </summary>
        public Booking Booking
        {
            get { return booking_; }
            set
            {
                booking_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateBookingRequest);
        public bool Equals(CreateBookingRequest other)
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
            if (BookingId != other.BookingId) return false;
            if (!Equals(Booking, other.Booking)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasBookingId) hash ^= BookingId.GetHashCode();
            if (booking_ != null) hash ^= Booking.GetHashCode();
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
      if (HasBookingId) {
        output.WriteRawTag(18);
        output.WriteString(BookingId);
      }
      if (booking_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Booking);
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
            if (HasBookingId)
            {
                output.WriteRawTag(18);
                output.WriteString(BookingId);
            }
            if (booking_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Booking);
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
            if (HasBookingId)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(BookingId);
            }
            if (booking_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Booking);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateBookingRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.HasBookingId)
            {
                BookingId = other.BookingId;
            }
            if (other.booking_ != null)
            {
                if (booking_ == null)
                {
                    Booking = new Booking();
                }
                Booking.MergeFrom(other.Booking);
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
            BookingId = input.ReadString();
            break;
          }
          case 26: {
            if (booking_ == null) {
              Booking = new Saltoapis.Nebula.Booking.V1.Booking();
            }
            input.ReadMessage(Booking);
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
                            BookingId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (booking_ == null)
                            {
                                Booking = new Booking();
                            }
                            input.ReadMessage(Booking);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [GetBooking][salto.nebula.booking.v1.BookingService.GetBooking]
    /// </summary>
    public sealed partial class GetBookingRequest : IMessage<GetBookingRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetBookingRequest> _parser = new(() => new GetBookingRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetBookingRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetBookingRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetBookingRequest(GetBookingRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetBookingRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested booking resource. For example:
        /// `installations/surelock-homes-hq/bookings/my-booking`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetBookingRequest);
        public bool Equals(GetBookingRequest other)
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

        public void MergeFrom(GetBookingRequest other)
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
    /// The request message for [ListBookings][salto.nebula.booking.v1.BookingService.ListBookings]
    /// </summary>
    public sealed partial class ListBookingsRequest : IMessage<ListBookingsRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListBookingsRequest> _parser = new(() => new ListBookingsRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListBookingsRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.MessageTypes[3]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListBookingsRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListBookingsRequest(ListBookingsRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListBookingsRequest Clone() => new(this);
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
        /// A filter that chooses which bookings to return.
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

        public override bool Equals(object other) => Equals(other as ListBookingsRequest);
        public bool Equals(ListBookingsRequest other)
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

        public void MergeFrom(ListBookingsRequest other)
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
    /// The response message for [ListBookings][salto.nebula.booking.v1.BookingService.ListBookings]
    /// </summary>
    public sealed partial class ListBookingsResponse : IMessage<ListBookingsResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListBookingsResponse> _parser = new(() => new ListBookingsResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListBookingsResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.MessageTypes[4]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListBookingsResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListBookingsResponse(ListBookingsResponse other) : this()
        {
            bookings_ = other.bookings_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListBookingsResponse Clone() => new(this);
        /// <summary>Field number for the "bookings" field.</summary>
        public const int BookingsFieldNumber = 1;
        private static readonly FieldCodec<Booking> _repeated_bookings_codec
            = FieldCodec.ForMessage(10, Booking.Parser);
        private readonly RepeatedField<Booking> bookings_ = [];

        /// <summary>
        /// The field name should match the noun `bookings` in the method name. There
        /// will be a maximum number of items returned based on the `page_size` field
        /// in the request.
        /// </summary>
        public RepeatedField<Booking> Bookings
        {
            get { return bookings_; }
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

        public override bool Equals(object other) => Equals(other as ListBookingsResponse);
        public bool Equals(ListBookingsResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!bookings_.Equals(other.bookings_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= bookings_.GetHashCode();
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
      bookings_.WriteTo(output, _repeated_bookings_codec);
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
            bookings_.WriteTo(ref output, _repeated_bookings_codec);
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
            size += bookings_.CalculateSize(_repeated_bookings_codec);
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

        public void MergeFrom(ListBookingsResponse other)
        {
            if (other == null)
            {
                return;
            }
            bookings_.Add(other.bookings_);
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
            bookings_.AddEntriesFrom(input, _repeated_bookings_codec);
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
                            bookings_.AddEntriesFrom(ref input, _repeated_bookings_codec);
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
    /// The request message for [UpdateBooking][salto.nebula.booking.v1.BookingService.UpdateBooking]
    /// </summary>
    public sealed partial class UpdateBookingRequest : IMessage<UpdateBookingRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateBookingRequest> _parser = new(() => new UpdateBookingRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateBookingRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.MessageTypes[5]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateBookingRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateBookingRequest(UpdateBookingRequest other) : this()
        {
            booking_ = other.booking_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateBookingRequest Clone() => new(this);
        /// <summary>Field number for the "booking" field.</summary>
        public const int BookingFieldNumber = 1;
        private Booking booking_;

        /// <summary>
        /// The booking resource to update. The resource's `name` field is used to
        /// identify the booking to update.
        /// </summary>
        public Booking Booking
        {
            get { return booking_; }
            set
            {
                booking_ = value;
            }
        }

        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;

        /// <summary>
        /// The update mask specifies which fields to update. If not provided,
        /// all fields will be updated.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get { return updateMask_; }
            set
            {
                updateMask_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as UpdateBookingRequest);
        public bool Equals(UpdateBookingRequest other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(Booking, other.Booking)) return false;
            if (!Equals(UpdateMask, other.UpdateMask)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (booking_ != null) hash ^= Booking.GetHashCode();
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
      if (booking_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Booking);
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
            if (booking_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Booking);
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
            if (booking_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(Booking);
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

        public void MergeFrom(UpdateBookingRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.booking_ != null)
            {
                if (booking_ == null)
                {
                    Booking = new Booking();
                }
                Booking.MergeFrom(other.Booking);
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
            if (booking_ == null) {
              Booking = new Saltoapis.Nebula.Booking.V1.Booking();
            }
            input.ReadMessage(Booking);
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
                            if (booking_ == null)
                            {
                                Booking = new Booking();
                            }
                            input.ReadMessage(Booking);
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
    /// The request message for [DeleteBooking][salto.nebula.booking.v1.BookingService.DeleteBooking]
    /// </summary>
    public sealed partial class DeleteBookingRequest : IMessage<DeleteBookingRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteBookingRequest> _parser = new(() => new DeleteBookingRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteBookingRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteBookingRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteBookingRequest(DeleteBookingRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteBookingRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the booking to be deleted. For example:
        /// `installations/surelock-homes-hq/bookings/my-booking`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteBookingRequest);
        public bool Equals(DeleteBookingRequest other)
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

        public void MergeFrom(DeleteBookingRequest other)
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
    /// The request message for [CheckInBooking][salto.nebula.booking.v1.BookingService.CheckInBooking]
    /// </summary>
    public sealed partial class CheckInBookingRequest : IMessage<CheckInBookingRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CheckInBookingRequest> _parser = new(() => new CheckInBookingRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CheckInBookingRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.MessageTypes[7]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CheckInBookingRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CheckInBookingRequest(CheckInBookingRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CheckInBookingRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the booking to be checked in. For example:
        /// `installations/surelock-homes-hq/bookings/my-booking`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as CheckInBookingRequest);
        public bool Equals(CheckInBookingRequest other)
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

        public void MergeFrom(CheckInBookingRequest other)
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
    /// The request message for [CheckOutBooking][salto.nebula.booking.v1.BookingService.CheckOutBooking]
    /// </summary>
    public sealed partial class CheckOutBookingRequest : IMessage<CheckOutBookingRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CheckOutBookingRequest> _parser = new(() => new CheckOutBookingRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CheckOutBookingRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.MessageTypes[8]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CheckOutBookingRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CheckOutBookingRequest(CheckOutBookingRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CheckOutBookingRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The booking resource for which to perform check-out. For example:
        /// `installations/surelock-homes-hq/bookings/my-booking`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as CheckOutBookingRequest);
        public bool Equals(CheckOutBookingRequest other)
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

        public void MergeFrom(CheckOutBookingRequest other)
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
    /// The BookingUser resource represents a user associated with a booking.
    /// </summary>
    public sealed partial class BookingUser : IMessage<BookingUser>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<BookingUser> _parser = new(() => new BookingUser());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<BookingUser> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.MessageTypes[9]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public BookingUser()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public BookingUser(BookingUser other) : this()
        {
            name_ = other.name_;
            user_ = other.user_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public BookingUser Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the booking's user association.
        /// It must have the format of `installations/*/bookings/*/users/*`.
        /// For example: `installations/surelock-homes-hq/bookings/my-booking/users/john-watson`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "user" field.</summary>
        public const int UserFieldNumber = 2;
        private string user_ = "";

        /// <summary>
        /// The user resource name to bind as an association to the parent booking.
        /// For example:
        /// `installations/surelock-homes-hq/users/john-watson`.
        /// </summary>
        public string User
        {
            get { return user_; }
            set
            {
                user_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as BookingUser);
        public bool Equals(BookingUser other)
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
            if (User != other.User) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Name.Length != 0) hash ^= Name.GetHashCode();
            if (User.Length != 0) hash ^= User.GetHashCode();
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
      if (User.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(User);
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
            if (User.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(User);
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
            if (User.Length != 0)
            {
                size += 1 + CodedOutputStream.ComputeStringSize(User);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(BookingUser other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Name.Length != 0)
            {
                Name = other.Name;
            }
            if (other.User.Length != 0)
            {
                User = other.User;
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
            User = input.ReadString();
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
                            User = input.ReadString();
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`CreateBookingUser`][salto.nebula.booking.v1.BookingService.CreateBookingUser]
    /// </summary>
    public sealed partial class CreateBookingUserRequest : IMessage<CreateBookingUserRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateBookingUserRequest> _parser = new(() => new CreateBookingUserRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateBookingUserRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.MessageTypes[10]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateBookingUserRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateBookingUserRequest(CreateBookingUserRequest other) : this()
        {
            parent_ = other.parent_;
            bookingUser_ = other.bookingUser_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateBookingUserRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource where the booking's user
        /// association is to be created. For example:
        /// `installations/surelock-homes-hq/bookings/my-booking`.
        /// </summary>
        public string Parent
        {
            get { return parent_; }
            set
            {
                parent_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "booking_user" field.</summary>
        public const int BookingUserFieldNumber = 2;
        private BookingUser bookingUser_;

        /// <summary>
        /// The booking's user association resource to be created.
        /// Client must not set the `BookingUser.name` field.
        /// </summary>
        public BookingUser BookingUser
        {
            get { return bookingUser_; }
            set
            {
                bookingUser_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateBookingUserRequest);
        public bool Equals(CreateBookingUserRequest other)
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
            if (!Equals(BookingUser, other.BookingUser)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (bookingUser_ != null) hash ^= BookingUser.GetHashCode();
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
      if (bookingUser_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(BookingUser);
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
            if (bookingUser_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(BookingUser);
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
            if (bookingUser_ != null)
            {
                size += 1 + CodedOutputStream.ComputeMessageSize(BookingUser);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        public void MergeFrom(CreateBookingUserRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Parent.Length != 0)
            {
                Parent = other.Parent;
            }
            if (other.bookingUser_ != null)
            {
                if (bookingUser_ == null)
                {
                    BookingUser = new BookingUser();
                }
                BookingUser.MergeFrom(other.BookingUser);
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
            if (bookingUser_ == null) {
              BookingUser = new Saltoapis.Nebula.Booking.V1.BookingUser();
            }
            input.ReadMessage(BookingUser);
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
                            if (bookingUser_ == null)
                            {
                                BookingUser = new BookingUser();
                            }
                            input.ReadMessage(BookingUser);
                            break;
                        }
                }
            }
        }
#endif

    }

    /// <summary>
    /// The request message for [`GetBookingUser`][salto.nebula.booking.v1.BookingService.GetBookingUser]
    /// </summary>
    public sealed partial class GetBookingUserRequest : IMessage<GetBookingUserRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<GetBookingUserRequest> _parser = new(() => new GetBookingUserRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<GetBookingUserRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.MessageTypes[11]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public GetBookingUserRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public GetBookingUserRequest(GetBookingUserRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public GetBookingUserRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The name of the requested booking's user association
        /// resource. For example:
        /// `installations/surelock-homes-hq/bookings/my-booking/users/john-watson`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as GetBookingUserRequest);
        public bool Equals(GetBookingUserRequest other)
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

        public void MergeFrom(GetBookingUserRequest other)
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
    /// The request message for [`ListBookingUsers`][salto.nebula.booking.v1.BookingService.ListBookingUsers]
    /// </summary>
    public sealed partial class ListBookingUsersRequest : IMessage<ListBookingUsersRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListBookingUsersRequest> _parser = new(() => new ListBookingUsersRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListBookingUsersRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.MessageTypes[12]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListBookingUsersRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListBookingUsersRequest(ListBookingUsersRequest other) : this()
        {
            parent_ = other.parent_;
            pageSize_ = other.pageSize_;
            pageToken_ = other.pageToken_;
            filter_ = other.filter_;
            orderBy_ = other.orderBy_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListBookingUsersRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// The parent resource name. For example:
        /// `installations/surelock-homes-hq/bookings/my-booking`.
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
        /// The `next_page_token` value returned from a previous `List` request, if any.
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
        /// A filter that chooses which booking's users associations to return.
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

        public override bool Equals(object other) => Equals(other as ListBookingUsersRequest);
        public bool Equals(ListBookingUsersRequest other)
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

        public void MergeFrom(ListBookingUsersRequest other)
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
    /// The response message for [`ListBookingUsers`][salto.nebula.booking.v1.BookingService.ListBookingUsers]
    /// </summary>
    public sealed partial class ListBookingUsersResponse : IMessage<ListBookingUsersResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<ListBookingUsersResponse> _parser = new(() => new ListBookingUsersResponse());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<ListBookingUsersResponse> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.MessageTypes[13]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public ListBookingUsersResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public ListBookingUsersResponse(ListBookingUsersResponse other) : this()
        {
            bookingUsers_ = other.bookingUsers_.Clone();
            nextPageToken_ = other.nextPageToken_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public ListBookingUsersResponse Clone() => new(this);
        /// <summary>Field number for the "booking_users" field.</summary>
        public const int BookingUsersFieldNumber = 1;
        private static readonly FieldCodec<BookingUser> _repeated_bookingUsers_codec
            = FieldCodec.ForMessage(10, BookingUser.Parser);
        private readonly RepeatedField<BookingUser> bookingUsers_ = [];

        /// <summary>
        /// The field name should match the noun `booking_users` in the
        /// method name. There will be a maximum number of items returned based on
        /// the `page_size` field in the request.
        /// </summary>
        public RepeatedField<BookingUser> BookingUsers
        {
            get { return bookingUsers_; }
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

        public override bool Equals(object other) => Equals(other as ListBookingUsersResponse);
        public bool Equals(ListBookingUsersResponse other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!bookingUsers_.Equals(other.bookingUsers_)) return false;
            if (NextPageToken != other.NextPageToken) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash ^= bookingUsers_.GetHashCode();
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
      bookingUsers_.WriteTo(output, _repeated_bookingUsers_codec);
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
            bookingUsers_.WriteTo(ref output, _repeated_bookingUsers_codec);
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
            size += bookingUsers_.CalculateSize(_repeated_bookingUsers_codec);
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

        public void MergeFrom(ListBookingUsersResponse other)
        {
            if (other == null)
            {
                return;
            }
            bookingUsers_.Add(other.bookingUsers_);
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
            bookingUsers_.AddEntriesFrom(input, _repeated_bookingUsers_codec);
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
                            bookingUsers_.AddEntriesFrom(ref input, _repeated_bookingUsers_codec);
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
    /// The request message for [`DeleteBookingUser`][salto.nebula.booking.v1.BookingService.DeleteBookingUser]
    /// </summary>
    public sealed partial class DeleteBookingUserRequest : IMessage<DeleteBookingUserRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<DeleteBookingUserRequest> _parser = new(() => new DeleteBookingUserRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<DeleteBookingUserRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return BookingReflection.Descriptor.MessageTypes[14]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public DeleteBookingUserRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public DeleteBookingUserRequest(DeleteBookingUserRequest other) : this()
        {
            name_ = other.name_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public DeleteBookingUserRequest Clone() => new(this);
        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";

        /// <summary>
        /// The resource name of the booking's user association to be deleted.
        /// For example: `installations/surelock-homes-hq/bookings/my-booking/users/john-watson`.
        /// </summary>
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        public override bool Equals(object other) => Equals(other as DeleteBookingUserRequest);
        public bool Equals(DeleteBookingUserRequest other)
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

        public void MergeFrom(DeleteBookingUserRequest other)
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
