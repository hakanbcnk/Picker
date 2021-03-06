namespace Picker
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class ComputerDatabaseContext : DbContext
    {
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<BuildMemory> BuildMemories { get; set; }
        public virtual DbSet<Build> Builds { get; set; }
        public virtual DbSet<Chipset> Chipsets { get; set; }
        public virtual DbSet<GraphicsCard> GraphicsCards { get; set; }
        public virtual DbSet<Memory> Memories { get; set; }
        public virtual DbSet<Motherboard> Motherboards { get; set; }
        public virtual DbSet<ProcessorChipset> ProcessorChipsets { get; set; }
        public virtual DbSet<Processor> Processors { get; set; }
        public virtual DbSet<Socket> Sockets { get; set; }

        public ComputerDatabaseContext() : base("name=PickerDatabase")
        {
        }

        public void ClearTrackingEntities<TEntity>(TEntity exception)
            where TEntity : Entity
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is Build || entry.Entity is ProcessorChipset ||
                    entry.Entity is BuildMemory ||
                    entry.Entity is TEntity entity && entity.Id == exception.Id)
                    continue;

                entry.State = EntityState.Unchanged;
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            => modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
    }
}