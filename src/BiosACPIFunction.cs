﻿using System.Collections;

namespace OCMaestro
{
    public class BiosACPIFunction : IEnumerable
    {
        public string IDString;
        public uint ID;

        public BiosACPIFunction(string idString, uint id)
        {
            IDString = idString;
            ID = id;
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)IDString).GetEnumerator();
        }
    }

}
