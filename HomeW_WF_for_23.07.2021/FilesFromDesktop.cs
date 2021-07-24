using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeW_WF_for_23._07._2021
{
    class FilesFromDesktop
    {
        public string Name { get; set; }
        public long Size { get; set; }

        public FilesFromDesktop(string name , long size)
        {
            Size = size;
            Name = name;
        }
    }
}
