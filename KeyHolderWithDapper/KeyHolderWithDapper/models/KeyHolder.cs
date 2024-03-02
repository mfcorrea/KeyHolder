using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyHolderWithDapper.models
{
    internal class KeyHolder
    {
        public int Id { get; set; }

        public Key Key { get; set; }

        public Holder Holder { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
