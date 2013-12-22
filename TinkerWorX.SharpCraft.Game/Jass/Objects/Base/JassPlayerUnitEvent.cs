using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hplayerunitevent;")]
    public partial struct JassPlayerUnitEvent
    {
        public readonly IntPtr Handle;
        
        public JassPlayerUnitEvent(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}