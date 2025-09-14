using managerTracker.Models;
using Xunit;

namespace managerTracker.Tests
{
    public class EmailTemplateTests
    {
        [Fact]
        public void CanCreateEmailTemplate()
        {
            var template = new EmailTemplate
            {
                Id = 1,
                Name = "Welcome",
                Subject = "Welcome Subject",
                Body = "Hello, welcome!"
            };

            Assert.Equal(1, template.Id);
            Assert.Equal("Welcome", template.Name);
            Assert.Equal("Welcome Subject", template.Subject);
            Assert.Equal("Hello, welcome!", template.Body);
        }
    }
}
