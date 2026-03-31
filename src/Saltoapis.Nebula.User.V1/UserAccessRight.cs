using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.User.V1
{
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
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Name != other.Name) || (AccessRight != other.AccessRight)) return false;
            if ((DisplayName != other.DisplayName) || (!schedules_.Equals(other.schedules_))) return false;
            if ((!effectiveSchedules_.Equals(other.effectiveSchedules_)) || (!Equals(ActivateTime, other.ActivateTime))) return false;
            if ((!Equals(ExpireTime, other.ExpireTime)) || (Manager != other.Manager)) return false;
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
            if (Name.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Name);
            if (AccessRight.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(AccessRight);
            if (DisplayName.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
            size += schedules_.CalculateSize(_repeated_schedules_codec);
            size += effectiveSchedules_.CalculateSize(_repeated_effectiveSchedules_codec);
            if (activateTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(ActivateTime);
            if (expireTime_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(ExpireTime);
            if (HasManager) size += 1 + CodedOutputStream.ComputeStringSize(Manager);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UserAccessRight other)
        {
            if (other == null) return;
            if (other.Name.Length != 0) Name = other.Name;
            if (other.AccessRight.Length != 0) AccessRight = other.AccessRight;
            if (other.DisplayName.Length != 0) DisplayName = other.DisplayName;
            schedules_.Add(other.schedules_);
            effectiveSchedules_.Add(other.effectiveSchedules_);
            if (other.activateTime_ != null)
            {
                if (activateTime_ == null) ActivateTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                ActivateTime.MergeFrom(other.ActivateTime);
            }
            if (other.expireTime_ != null)
            {
                if (expireTime_ == null) ExpireTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                ExpireTime.MergeFrom(other.ExpireTime);
            }
            if (other.HasManager) Manager = other.Manager;
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
                            if (activateTime_ == null) ActivateTime = new Google.Protobuf.WellKnownTypes.Timestamp();
                            input.ReadMessage(ActivateTime);
                            break;
                        }
                    case 58:
                        {
                            if (expireTime_ == null) ExpireTime = new Google.Protobuf.WellKnownTypes.Timestamp();
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


}
