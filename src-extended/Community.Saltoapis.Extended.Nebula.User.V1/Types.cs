namespace Saltoapis.Nebula.User.V1
{
public sealed partial class WalletKey
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
#endif
    {
        /// <summary>Container for nested types declared in the WalletKey message type.</summary>
        public static partial class Types
        {
            /// <summary>
            /// State for a wallet key.
            /// </summary>
            public enum State
            {
                /// <summary>
                /// Sentinel value used to indicate that the state is unknown, omitted,
                /// or is not applicable.
                /// </summary>
                [OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
                /// <summary>
                /// The wallet key is not assigned.
                /// </summary>
                [OriginalName("NOT_ASSIGNED")] NotAssigned = 1,
                /// <summary>
                /// The wallet key is pending activation.
                /// </summary>
                [OriginalName("PENDING")] Pending = 2,
                /// <summary>
                /// The wallet key is active and ready to be used.
                /// </summary>
                [OriginalName("ACTIVE")] Active = 3,
            }
        }
    }

}