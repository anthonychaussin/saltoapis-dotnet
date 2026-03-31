namespace Saltoapis.Type
{
    public sealed partial class Color : IMessage<Color>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<Color> _parser = new(() => new Color());
        private UnknownFieldSet _unknownFields;
        private int _hasBits0;

        public static MessageParser<Color> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return ColorReflection.Descriptor.MessageTypes[0]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public Color()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public Color(Color other) : this()
        {
            _hasBits0 = other._hasBits0;
            red_ = other.red_;
            green_ = other.green_;
            blue_ = other.blue_;
            alpha_ = other.alpha_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public Color Clone() => new(this);
        /// <summary>Field number for the "red" field.</summary>
        public const int RedFieldNumber = 1;
        private float red_;

        /// <summary>
        /// The amount of red in the color as a value in the interval [0, 1].
        /// </summary>
        public float Red
        {
            get { return red_; }
            set
            {
                red_ = value;
            }
        }

        /// <summary>Field number for the "green" field.</summary>
        public const int GreenFieldNumber = 2;
        private float green_;

        /// <summary>
        /// The amount of green in the color as a value in the interval [0, 1].
        /// </summary>
        public float Green
        {
            get { return green_; }
            set
            {
                green_ = value;
            }
        }

        /// <summary>Field number for the "blue" field.</summary>
        public const int BlueFieldNumber = 3;
        private float blue_;

        /// <summary>
        /// The amount of blue in the color as a value in the interval [0, 1].
        /// </summary>
        public float Blue
        {
            get { return blue_; }
            set
            {
                blue_ = value;
            }
        }

        /// <summary>Field number for the "alpha" field.</summary>
        public const int AlphaFieldNumber = 4;
        private static readonly float AlphaDefaultValue = 0F;

        private float alpha_;

        /// <summary>
        /// The fraction of this color that should be applied to the pixel. That is,
        /// the final pixel color is defined by the equation:
        ///
        ///   `pixel color = alpha * (this color) + (1.0 - alpha) * (background color)`
        ///
        /// This means that a value of 1.0 corresponds to a solid color, whereas
        /// a value of 0.0 corresponds to a completely transparent color.
        /// If omitted, this color object is rendered as a solid color
        /// (as if the alpha value had been explicitly given a value of 1.0).
        /// </summary>
        public float Alpha
        {
            get { if ((_hasBits0 & 1) != 0) { return alpha_; } else { return AlphaDefaultValue; } }
            set
            {
                _hasBits0 |= 1;
                alpha_ = value;
            }
        }

        /// <summary>Gets whether the "alpha" field is set</summary>
        public bool HasAlpha
        {
            get { return (_hasBits0 & 1) != 0; }
        }

        /// <summary>Clears the value of the "alpha" field</summary>
        public void ClearAlpha()
        {
            _hasBits0 &= ~1;
        }

        public override bool Equals(object other) => Equals(other as Color);
        public bool Equals(Color other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Red, other.Red)) || (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Green, other.Green))) return false;
            if ((!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Blue, other.Blue)) || (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Alpha, other.Alpha))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (Red != 0F) hash ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Red);
            if (Green != 0F) hash ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Green);
            if (Blue != 0F) hash ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Blue);
            if (HasAlpha) hash ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Alpha);
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Red != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(Red);
      }
      if (Green != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Green);
      }
      if (Blue != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Blue);
      }
      if (HasAlpha) {
        output.WriteRawTag(37);
        output.WriteFloat(Alpha);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (Red != 0F)
            {
                output.WriteRawTag(13);
                output.WriteFloat(Red);
            }
            if (Green != 0F)
            {
                output.WriteRawTag(21);
                output.WriteFloat(Green);
            }
            if (Blue != 0F)
            {
                output.WriteRawTag(29);
                output.WriteFloat(Blue);
            }
            if (HasAlpha)
            {
                output.WriteRawTag(37);
                output.WriteFloat(Alpha);
            }
            _unknownFields?.WriteTo(ref output);
        }
#endif

        public int CalculateSize()
        {
            int size = 0;
            if ((Red != 0F) || (Green != 0F)) size += 1 + 4;
            if ((Blue != 0F) || (HasAlpha)) size += 1 + 4;
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(Color other)
        {
            if (other == null) return;
            if (other.Red != 0F) Red = other.Red;
            if (other.Green != 0F) Green = other.Green;
            if (other.Blue != 0F) Blue = other.Blue;
            if (other.HasAlpha) Alpha = other.Alpha;
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
          case 13: {
            Red = input.ReadFloat();
            break;
          }
          case 21: {
            Green = input.ReadFloat();
            break;
          }
          case 29: {
            Blue = input.ReadFloat();
            break;
          }
          case 37: {
            Alpha = input.ReadFloat();
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
                    case 13:
                        {
                            Red = input.ReadFloat();
                            break;
                        }
                    case 21:
                        {
                            Green = input.ReadFloat();
                            break;
                        }
                    case 29:
                        {
                            Blue = input.ReadFloat();
                            break;
                        }
                    case 37:
                        {
                            Alpha = input.ReadFloat();
                            break;
                        }
                }
            }
        }
#endif

    }
}
