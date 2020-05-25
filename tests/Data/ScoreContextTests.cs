using Xunit;
using openrmf_msg_audit.Data;
using openrmf_msg_audit.Models;

namespace tests.Data
{
    public class AuditContextTests
    {
        private readonly AuditContext _auditContext;

        public AuditContextTests()
        {
            Settings settings = new Settings();

            settings.ConnectionString = "mongodb://openrmfaudit:openrmf1234!@localhost/openrmfscore?authSource=admin";
            settings.Database = "openrmfaudit";

            _auditContext = new AuditContext(settings);
        }

        [Fact]
        public void Test_AuditContextIsValid()
        {
            // Testing
            Assert.False(_auditContext == null);
            Assert.False(_auditContext.Audits == null);
        }
    }
}
