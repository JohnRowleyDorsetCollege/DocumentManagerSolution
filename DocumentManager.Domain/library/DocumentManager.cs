using DocumentManager.Domain.library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Domain
{
    public class Document_Manager
    {
        private readonly Queue<DocumentItem> documentQueue = new Queue<DocumentItem>();
        public void AddDocument(DocumentItem doc)
        {
            documentQueue.Enqueue(doc);
        }

        public DocumentItem GetNextDocumentInQueue()
        {
            DocumentItem doc = null;

            return doc;
        }

        public DocumentItem ProcessNextDocumentInQueue()
        {
            DocumentItem doc = null;

            return doc;
        }


        public bool IsDocumentAvailable()
        {
            return false;
        }

        public int CountItemsInQueue()
        {
            return documentQueue.Count();
        }

    }
}
