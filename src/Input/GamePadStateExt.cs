namespace Microsoft.Xna.Framework.Input
{
    /// <summary>
    /// Represents specific information about the state of the controller,
    /// including the current state of buttons and sticks.
    ///
    /// This is implemented as a partial struct to allow for individual platforms
    /// to offer additional data without separate state queries to GamePad.
    /// </summary>
    public partial struct GamePadState
    {
        /// <summary>
        /// The default initialized gamepad state.
        /// </summary>
        public static readonly GamePadState Default = new GamePadState();
    }
}