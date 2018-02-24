using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraImportFileGenerator
{
    public class DuplicateBlock
    {
        public int beginLine { get; set; }
        public string commitHashLong { get; set; }
        public int countLineCode { get; set; }
        public int endLine { get; set; }
        public string pkg { get; set; }
        public string relFile { get; set; }
        public string ticketId { get;set; }
    }

}
