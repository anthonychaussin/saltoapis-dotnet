using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.Unit.V1.Request
{
    /// <summary>
    /// The request message for [`CreateUnit`][salto.nebula.unit.v1.UnitService.CreateUnit]
    /// </summary>
    public sealed partial class CreateUnitRequest : IMessage<CreateUnitRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<CreateUnitRequest> _parser = new(() => new CreateUnitRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<CreateUnitRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return UnitReflection.Descriptor.MessageTypes[2]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public CreateUnitRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public CreateUnitRequest(CreateUnitRequest other) : this()
        {
            parent_ = other.parent_;
            unitId_ = other.unitId_;
            unit_ = other.unit_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public CreateUnitRequest Clone() => new(this);
        /// <summary>Field number for the "parent" field.</summary>
        public const int ParentFieldNumber = 1;
        private string parent_ = "";

        /// <summary>
        /// Resource name of the parent resource under which the unit is created. For
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

        /// <summary>Field number for the "unit_id" field.</summary>
        public const int UnitIdFieldNumber = 2;
        private readonly static string UnitIdDefaultValue = "";

        private string unitId_;

        /// <summary>
        /// The unit id to use for this unit. If it's empty the server will
        /// autogenerate a unique identifier.
        /// </summary>
        public string UnitId
        {
            get { return unitId_ ?? UnitIdDefaultValue; }
            set
            {
                unitId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Gets whether the "unit_id" field is set</summary>
        public bool HasUnitId
        {
            get { return unitId_ != null; }
        }

        /// <summary>Clears the value of the "unit_id" field</summary>
        public void ClearUnitId()
        {
            unitId_ = null;
        }

        /// <summary>Field number for the "unit" field.</summary>
        public const int UnitFieldNumber = 3;
        private Unit unit_;

        /// <summary>
        /// The unit resource to be created. Client must not set the `Unit.name`
        /// field.
        /// </summary>
        public Unit Unit
        {
            get { return unit_; }
            set
            {
                unit_ = value;
            }
        }

        public override bool Equals(object other) => Equals(other as CreateUnitRequest);
        public bool Equals(CreateUnitRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((Parent != other.Parent) || (UnitId != other.UnitId)) return false;
            if (!Equals(Unit, other.Unit)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Parent.Length != 0) hash ^= Parent.GetHashCode();
            if (HasUnitId) hash ^= UnitId.GetHashCode();
            if (unit_ != null) hash ^= Unit.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
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
      if (HasUnitId) {
        output.WriteRawTag(18);
        output.WriteString(UnitId);
      }
      if (unit_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Unit);
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
            if (HasUnitId)
            {
                output.WriteRawTag(18);
                output.WriteString(UnitId);
            }
            if (unit_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Unit);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if (Parent.Length != 0) size += 1 + CodedOutputStream.ComputeStringSize(Parent);
            if (HasUnitId) size += 1 + CodedOutputStream.ComputeStringSize(UnitId);
            if (unit_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Unit);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(CreateUnitRequest other)
        {
            if (other == null) return;
            if (other.Parent.Length != 0) Parent = other.Parent;
            if (other.HasUnitId) UnitId = other.UnitId;
            if (other.unit_ != null)
            {
                if (unit_ == null) Unit = new Unit();
                Unit.MergeFrom(other.Unit);
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
            UnitId = input.ReadString();
            break;
          }
          case 26: {
            if (unit_ == null) {
              Unit = new Saltoapis.Nebula.Unit.V1.Unit();
            }
            input.ReadMessage(Unit);
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
                            UnitId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            if (unit_ == null) Unit = new Unit();
                            input.ReadMessage(Unit);
                            break;
                        }
                }
            }
        }
#endif

    }


}
