namespace Saltoapis.Nebula.Destination.V1.Request
{
    /// <summary>
    /// The request message for [`UpdateDestination`][salto.nebula.destination.v1.DestinationService.UpdateDestination]
    /// </summary>
    public sealed partial class UpdateDestinationRequest : IMessage<UpdateDestinationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateDestinationRequest> _parser = new(() => new UpdateDestinationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateDestinationRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => DestinationReflection.Descriptor.MessageTypes[5];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public UpdateDestinationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateDestinationRequest(UpdateDestinationRequest other) : this()
        {
            destination_ = other.destination_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateDestinationRequest Clone() => new(this);
        /// <summary>Field number for the "destination" field.</summary>
        public const int DestinationFieldNumber = 1;
        private Destination destination_;
        /// <summary>
        /// The destination resource which replaces the resource on the server.
        /// </summary>
        public Destination Destination
        {
            get => destination_; set => destination_ = value;}
        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;
        /// <summary>
        /// The update mask applied to the resource.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get => updateMask_; set => updateMask_ = value;}

        public override bool Equals(object other) => Equals(other as UpdateDestinationRequest);
        public bool Equals(UpdateDestinationRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(Destination, other.Destination)) || (!Equals(UpdateMask, other.UpdateMask))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (destination_ != null) hash ^= Destination.GetHashCode();
            if (updateMask_ != null) hash ^= UpdateMask.GetHashCode();
            if (_unknownFields != null) hash ^= _unknownFields.GetHashCode();
            return hash;
        }

        public override string ToString() => JsonFormatter.ToDiagnosticString(this);
        public void WriteTo(CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (destination_ != null)
      {
        output.WriteRawTag(10);
        output.WriteMessage(Destination);
      }
      if (updateMask_ != null)
      {
        output.WriteRawTag(18);
        output.WriteMessage(UpdateMask);
      }
      if (_unknownFields != null)
      {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE

        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            if (destination_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Destination);
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
            if (destination_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Destination);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateDestinationRequest other)
        {
            if (other == null) return;
            if (other.destination_ != null)
            {
                if (destination_ == null) Destination = new Destination();
                Destination.MergeFrom(other.Destination);
            }
            if (other.updateMask_ != null)
            {
                if (updateMask_ == null) UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
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
      while ((tag = input.ReadTag()) != 0)
      {
      if ((tag & 7) == 4)
      {
        // Abort on any end group tag.
        return;
      }
      switch(tag)
      {
          default:
            _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10:
          {
            if (destination_ == null)
            {
              Destination = new Saltoapis.Nebula.Destination.V1.Destination();
            }
            input.ReadMessage(Destination);
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
                            if (destination_ == null) Destination = new Destination();
                            input.ReadMessage(Destination);
                            break;
                        }
                    case 18:
                        {
                            if (updateMask_ == null) UpdateMask = new Google.Protobuf.WellKnownTypes.FieldMask();
                            input.ReadMessage(UpdateMask);
                            break;
                        }
                }
            }
        }
#endif
    }

}