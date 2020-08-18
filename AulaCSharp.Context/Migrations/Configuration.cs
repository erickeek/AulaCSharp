using System.Data.Entity.Migrations;

namespace AulaCSharp.Context.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AulaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AulaContext context)
        {
        }
    }
}
