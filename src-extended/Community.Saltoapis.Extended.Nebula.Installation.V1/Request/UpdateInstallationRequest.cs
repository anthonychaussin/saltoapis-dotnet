namespace Saltoapis.Nebula.Installation.V1.Request
{
    /// <summary>
    /// The request message for [`UpdateInstallation`][salto.nebula.installation.v1.InstallationService.UpdateInstallation]
    /// </summary>
    public sealed partial class UpdateInstallationRequest : IMessage<UpdateInstallationRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , IBufferMessage
#endif
    {
        private static readonly MessageParser<UpdateInstallationRequest> _parser = new(() => new UpdateInstallationRequest());
        private UnknownFieldSet _unknownFields;

        public static MessageParser<UpdateInstallationRequest> Parser { get => _parser;}

        public static MessageDescriptor Descriptor
        {
            get => InstallationReflection.Descriptor.MessageTypes[12];}

        MessageDescriptor IMessage.Descriptor
        {
            get => Descriptor;}

        public UpdateInstallationRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        public UpdateInstallationRequest(UpdateInstallationRequest other) : this()
        {
            installation_ = other.installation_?.Clone();
            updateMask_ = other.updateMask_?.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        public UpdateInstallationRequest Clone() => new(this);
        /// <summary>Field number for the "installation" field.</summary>
        public const int InstallationFieldNumber = 1;
        private Installation installation_;
        /// <summary>
        /// The installation resource which replaces the resource on the server.
        /// </summary>
        public Installation Installation
        {
            get => installation_; set => installation_ = value;}
        /// <summary>Field number for the "update_mask" field.</summary>
        public const int UpdateMaskFieldNumber = 2;
        private Google.Protobuf.WellKnownTypes.FieldMask updateMask_;
        /// <summary>
        /// The update mask applied to the resource.
        /// </summary>
        public Google.Protobuf.WellKnownTypes.FieldMask UpdateMask
        {
            get => updateMask_; set => updateMask_ = value;}

        public override bool Equals(object other) => Equals(other as UpdateInstallationRequest);
        public bool Equals(UpdateInstallationRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if ((!Equals(Installation, other.Installation)) || (!Equals(UpdateMask, other.UpdateMask))) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode()
        {
            int hash = 1;
            if (installation_ != null) hash ^= Installation.GetHashCode();
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
      if (installation_ != null)
      {
        output.WriteRawTag(10);
        output.WriteMessage(Installation);
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
            if (installation_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Installation);
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
            if (installation_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(Installation);
            if (updateMask_ != null) size += 1 + CodedOutputStream.ComputeMessageSize(UpdateMask);
            if (_unknownFields != null) size += _unknownFields.CalculateSize();
            return size;
        }

        public void MergeFrom(UpdateInstallationRequest other)
        {
            if (other == null) return;
            if (other.installation_ != null)
            {
                if (installation_ == null) Installation = new Installation();
                Installation.MergeFrom(other.Installation);
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
            if (installation_ == null)
            {
              Installation = new Saltoapis.Nebula.Installation.V1.Installation();
            }
            input.ReadMessage(Installation);
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
                            if (installation_ == null) Installation = new Installation();
                            input.ReadMessage(Installation);
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