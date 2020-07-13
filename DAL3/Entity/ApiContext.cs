using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DAL3.Entity
{
    public class ApiContext:DbContext
    {
        public ApiContext() : base("DefaultConnection")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<Docs4EcmServerApiContext, Migrations.Configuration>("BlogContext"));
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApiContext, Migrations.Configuration>());
            //Database.SetInitializer<WorkstationInfoDBContext>(null);
        }

        public ApiContext(string connectionString) : base(connectionString)
        {
            //Database.SetInitializer<WorkstationInfoDBContext>(null);
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<Docs4EcmServerApiContext, Migrations.Configuration>("BlogContext"));
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApiContext, Migrations.Configuration>());
        }
        public DbSet<WorkstationInfo> WorkstationInfos { get; set; }
        //public DbSet<Document> Documents { get; set; }
        //public DbSet<DocumentMetadata> DocumentMetadatas { get; set; }
        //public DbSet<BatchSignSession> BatchSignSessions { get; set; }
        //public DbSet<SessionMetadata> SessionMetadatas { get; set; }
        //public DbSet<EnvelopeAndWorkstepId> EnvelopeAndWorkstepIds { get; set; }
        //public DbSet<EnvelopeAndWorkstepIdsToMetadata> EnvelopeAndWorkstepIdsToMetadatas { get; set; }
        //public DbSet<EnvelopeAndWorkstepMetadata> EnvelopeAndWorkstepMetadatas { get; set; }

    }
}
