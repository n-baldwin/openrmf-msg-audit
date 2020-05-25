using Xunit;
using openrmf_msg_audit.Models;
using System;

namespace tests.Models
{
    public class AuditTests
    {
        [Fact]
        public void Test_NewAuditIsValid()
        {
            Audit audit = new Audit();

            // Testing
            Assert.False(audit == null);
        }
    
        [Fact]
        public void Test_AuditWithDataIsValid()
        {
            Audit audit = new Audit();

            audit.program = "Save";
            audit.created = DateTime.Now;
            audit.action = "edit";
            audit.userid = Guid.NewGuid().ToString();
            audit.username = "my.username";
            audit.fullname = "My F. Name";
            audit.email = "dale.bingham@cingulara.com";
            audit.url = "https://www.openrmf.io";
            audit.message = "This is a test";

            // Testing
            Assert.True(audit.program == "Save");
            Assert.True(audit.action == "edit");
            Assert.True(audit.username == "my.username");
            Assert.True(audit.fullname == "My F. Name");
            Assert.True(audit.email == "dale.bingham@cingulara.com");
            Assert.True(audit.url == "https://www.openrmf.io");
            Assert.True(audit.message == "This is a test");
            Assert.False(audit.created == null);
            Assert.False(audit.userid == null);
            Assert.False(audit.auditId == null);
        }
    }
}
