using System;
using System.Collections.Generic;
using System.Text;

namespace CardDispenserLibrary
{
    public class ICardDispenserFactory
    {
        public static ICardDispenser GetCardDispenser(EM_CardDispenser eM_CardDispenser)
        {
            switch (eM_CardDispenser)
            {
                case EM_CardDispenser.v5:
                    return new MT116v5();
                case EM_CardDispenser.v6:
                    return new MT116Controller();
                default:
                    return null;
            }
        }
    }
}
