
namespace Mindmagma.Curses
{
    /// <summary>
    /// Constants for use with the Trace debugging API.
    /// </summary>
    public static class CursesTrace
    {
        /// <summary>
        /// Turn off tracing.
        /// </summary>
        public static uint DISABLE = 0x0000u;

        /// <summary>
        /// Trace user and system times of updates.
        /// </summary>
        public static uint TIMES = 0x0001u;

        /// <summary>
        /// Trace calls to tputs.
        /// </summary>
        public static uint TPUTS = 0x0002u;

        /// <summary>
        /// Trace update actions, old & new screens.
        /// </summary>
        public static uint UPDATE = 0x0004u;

        /// <summary>
        /// Trace cursor moves and scrolls.
        /// </summary>
        public static uint MOVE = 0x0008u;

        /// <summary>
        /// Trace all character output.
        /// </summary>
        public static uint CHARPUT = 0x0010u;

        /// <summary>
        /// Trace all update actions.
        /// </summary>
        public static uint ORDINARY = 0x001Fu;

        /// <summary>
        /// Trace all curses calls.
        /// </summary>
        public static uint CALLS = 0x0020u;

        /// <summary>
        /// Trace virtual character puts.
        /// </summary>
        public static uint VIRTPUT = 0x0040u;

        /// <summary>
        /// Trace low-level input processing.
        /// </summary>
        public static uint IEVENT = 0x0080u;

        /// <summary>
        /// Trace state of TTY control bits.
        /// </summary>
        public static uint BITS = 0x0100u;

        /// <summary>
        /// Trace internal/nested calls.
        /// </summary>
        public static uint ICALLS = 0x0200u;

        /// <summary>
        /// Trace per-character calls.
        /// </summary>
        public static uint CCALLS = 0x0400u;

        /// <summary>
        /// Trace read/write of terminfo/termcap data.
        /// </summary>
        public static uint DATABASE = 0x0800u;

        /// <summary>
        /// Trace attribute updates.
        /// </summary>
        public static uint ATTRS = 0x1000u;

        /// <summary>
        /// Maximum trace level.
        /// </summary>
        public static uint MAXIMUM = ((1u << 13) - 1u); // 13 = number of bits in trace masks, SHIFT in curses.h
    }
}