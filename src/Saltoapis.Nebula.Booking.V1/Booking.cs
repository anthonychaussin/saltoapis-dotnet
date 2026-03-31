using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Booking.V1
{
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
            if (HasUnit) ClearAsset();
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
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (!Equals(StartTime, other.StartTime))) return false;
            if ((!Equals(EndTime, other.EndTime)) || (State != other.State)) return false;
            if ((!Equals(CheckInTime, other.CheckInTime)) || (!Equals(CheckOutTime, other.CheckOutTime))) return false;
            if ((Unit != other.Unit) || (!accessRights_.Equals(other.accessRights_))) return false;
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
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
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
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (startTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(StartTime);
            if (endTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(EndTime);
            if (State != Types.State.Unspecified) size += 1 + CodedOutputStream.ComputeEnumSize((int)State);
            if (checkInTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(CheckInTime);
            if (checkOutTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(CheckOutTime);
            if (HasUnit) size += 1 + CodedOutputStream.ComputeStringSize(Unit);
            size += accessRights_.CalculateSize(_repeated_accessRights_codec);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Booking other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.startTime_ != null)
            {
                if (startTime_ == null) StartTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                StartTime.MergeFrom(other.StartTime);
            }
            if (other.endTime_ != null)
            {
                if (endTime_ == null) EndTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                EndTime.MergeFrom(other.EndTime);
            }
            if (other.State != Types.State.Unspecified) State = other.State;
            if (other.checkInTime_ != null)
            {
                if (checkInTime_ == null) CheckInTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                CheckInTime.MergeFrom(other.CheckInTime);
            }
            if (other.checkOutTime_ != null)
            {
                if (checkOutTime_ == null) CheckOutTime = new Google.Protobuf.WellKnownTypes.Timestamp();
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
                            if (startTime_ == null) StartTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(StartTime);
                            break;
                        }
                    case 26:
                        {
                            if (endTime_ == null) EndTime = new Google.Protobuf.WellKnownTypes.Timestamp();
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
                            if (checkInTime_ == null) CheckInTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(CheckInTime);
                            break;
                        }
                    case 50:
                        {
                            if (checkOutTime_ == null) CheckOutTime = new Google.Protobuf.WellKnownTypes.Timestamp();
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

    }
}
