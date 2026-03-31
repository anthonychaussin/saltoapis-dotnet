using Google.Protobuf.Reflection;
using Google.Protobuf;

namespace Saltoapis.Nebula.IntercomAdaptor.V1.Request
{
    /// <summary>
    /// The request message for [UpdateIntercomAdaptor][salto.nebula.intercomadaptor.v1.IntercomAdaptorService.UpdateIntercomAdaptor]
    /// </summary>
    public sealed partial class UpdateIntercomAdaptorRequest : IMessage<UpdateIntercomAdaptorRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateIntercomAdaptorRequest> _parser = new(() => new UpdateIntercomAdaptorRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateIntercomAdaptorRequest> Parser { get { return _parser; } }

        public static MessageDescriptor Descriptor
        {
            get { return IntercomAdaptorReflection.Descriptor.MessageTypes[6]; }
        }

        MessageDescriptor IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        public UpdateIntercomAdaptorRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateIntercomAdaptorRequest(UpdateIntercomAdaptorRequest other) : this()
        {
            intercomAdaptor_ = other.intercomAdaptor_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateIntercomAdaptorRequest Clone() => new(this);
        /// <summary>Field number for the "intercom_adaptor" field.</summary>
        public const int IntercomAdaptorFieldNumber = 1;
        private IntercomAdaptor intercomAdaptor_;

        /// <summary>
        /// The intercom adaptor resource which replaces the resource on the server.
        /// </summary>
        public IntercomAdaptor IntercomAdaptor
        {
            get { return intercomAdaptor_; }
            set
            {
                intercomAdaptor_ = value;
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

        public override bool Equals(object other) => Equals(other as UpdateIntercomAdaptorRequest);
        public bool Equals(UpdateIntercomAdaptorRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(IntercomAdaptor, other.IntercomAdaptor)) || (!Equals(UpdateMask, other.UpdateMask))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (intercomAdaptor_ != null) hash ^= IntercomAdaptor.GetHashCode();
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
      if (intercomAdaptor_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(IntercomAdaptor);
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
            if (intercomAdaptor_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(IntercomAdaptor);
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
            if (intercomAdaptor_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(IntercomAdaptor);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateIntercomAdaptorRequest other)
        {
            if (other == null) return;
            if (other.intercomAdaptor_ != null)
            {
                if (intercomAdaptor_ == null) IntercomAdaptor = new IntercomAdaptor();
                IntercomAdaptor.MergeFrom(other.IntercomAdaptor);
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
            if (intercomAdaptor_ == null) {
              IntercomAdaptor = new Saltoapis.Nebula.IntercomAdaptor.V1.IntercomAdaptor();
            }
            input.ReadMessage(IntercomAdaptor);
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
                            if (intercomAdaptor_ == null) IntercomAdaptor = new IntercomAdaptor();
                            input.ReadMessage(IntercomAdaptor);
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
