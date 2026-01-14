using TerminalRPG.Lib.Enums;

namespace TerminalRPG.Lib.Exceptions
{
    class InvalidWeaponNameException : Exception
    {
        public InvalidWeaponNameException() : base(Strings.Messages.InvalidWeaponNameException) { }
    }
}
