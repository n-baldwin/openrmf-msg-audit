using Xunit;
using openrmf_msg_audit.Data;
using openrmf_msg_audit.Models;
using System;

namespace tests.Data
{
    public class AuditRepositoryTests
    {
        private readonly AuditRepository _auditRepository;

        public AuditRepositoryTests()
        {
            Settings settings = new Settings();

            settings.ConnectionString = "mongodb://openrmfaudit:openrmf1234!@localhost/openrmfscore?authSource=admin";
            settings.Database = "openrmfaudit";

            _auditRepository = new AuditRepository(settings);
        }

        [Fact]
        public void Test_AuditRepositoryIsValid()
        {
            Audit audit = new Audit();

            // Testing
            _auditRepository.AddAudit(audit);                       
        }
    }
}
