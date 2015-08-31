using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIS.Client
{
    public class ZipFileEntry
    {
        // Fields
        public byte[] contents;
        public bool IsDir = false;
        public string Name;
    }

}
