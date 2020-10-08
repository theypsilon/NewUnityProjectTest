using NUnit.Framework;

namespace Tests
{
    public class NewTestScript
    {
        [Test]
        public void NewTestScriptSimplePasses()
        {
            Assert.That(true, Is.EqualTo(true));
        }
    }
}
