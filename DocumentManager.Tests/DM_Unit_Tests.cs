using DocumentManager.Domain;
using DocumentManager.Domain.library;
using System.Reflection.Metadata;

namespace DocumentManager.Tests
{
    [TestFixture]
    public class DocumentManagerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DemoTestShouldPass()
        {
            Assert.Pass();
        }

        [Test]
        public void DocumentShouldReturnCorrectTitle()
        {
            string titleToTest = "Demo Title";
            string contentToTest = "Demo Content";
            var documentItem = new DocumentItem(titleToTest, contentToTest);

               Assert.That(documentItem.content, Is.EqualTo(contentToTest));
            }

        [Test]
        public void DocumentShouldReturnCorrectContent()
        {
            string titleToTest = "Demo Title";
            string contentToTest = "Demo Content";
            var documentItem = new DocumentItem(titleToTest, contentToTest);

            Assert.That(documentItem.content, Is.EqualTo(contentToTest));
        }

        [Test]
        public void DocumentManagerShouldAddItemToQueue()
        {
            Assert.Fail();
        }

        [Test]
        public void DocumentManagerShouldReturnFirstItemInQueue()
        {
            Assert.Fail();
        }

        [Test]
        public void DocumentManager_IsDocumentAvailable_ShouldReturnFalseWhenQueueIsEmpty()
        {
            Assert.Fail();
        }

        [Test]
        public void DocumentManager_CountItemsInQueue_ShouldReturnCorrectCount()
        {
            Document_Manager dm = new();

            Assert.That(dm.CountItemsInQueue(), Is.EqualTo(0));

            string titleToTest = "Demo Title";
            string contentToTest = "Demo Content";
            var documentItem = new DocumentItem(titleToTest, contentToTest);

            dm.AddDocument(documentItem);

            Assert.That(dm.CountItemsInQueue(), Is.EqualTo(1));

            // Assert.Fail();
        }


    }
}