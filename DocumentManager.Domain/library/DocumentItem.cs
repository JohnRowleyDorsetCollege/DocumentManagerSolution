using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Domain.library
{
    public class DocumentItem
    {
        public string title { get; set; }
        public string content { get; set; }

        public DocumentItem(string title, string content)
        {
            this.title = title;
            this.content = content;
        }
    }
}
