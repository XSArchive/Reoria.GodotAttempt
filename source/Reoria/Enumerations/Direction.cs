namespace Reoria.Enumerations
{
    /// <summary>
    /// Defines flag values for direction facings.
    /// </summary>
    [Flags]
    public enum Direction
    {
        /// <summary>
        /// Defines the default direction facing value.
        /// </summary>
        Default = Down,

        /// <summary>
        /// Defines the value for the Up direction flag.
        /// </summary>
        Up = 1 << 0,
        /// <summary>
        /// Defines the value for the Down direction flag.
        /// </summary>
        Down = 1 << 1,
        /// <summary>
        /// Defines the value for the Left direction flag.
        /// </summary>
        Left = 1 << 2,
        /// <summary>
        /// Defines the value for the Right direction flag.
        /// </summary>
        Right = 1 << 3,

        /// <summary>
        /// Defines the value for all direction facings.
        /// </summary>
        All = Up | Down | Left | Right
    }
}
