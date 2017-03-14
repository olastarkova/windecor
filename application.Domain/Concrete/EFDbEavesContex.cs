using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using application.Domain.Enitites;

namespace application.Domain.Concrete
{
    public class EFDbEavesContex : DbContext
    {
        public EFDbEavesContex()
        {
            Database.SetInitializer<EFDbEavesContex>(new ApplicationDbEavesIntializer());
        }

        public DbSet<EavesCatogory> EavesCatogories { get; set; }
        public DbSet<EavesCollectionFastenings> EavesCollectionFastenings { get; set; }
        public DbSet<EavesCollectionFasteningsByColor> EavesCollectionFasteningsByColors { get; set; }
        public DbSet<EavesCollectionItem> EavesCollectionItems { get; set; }
        public DbSet<EavesCollectionRing> EavesCollectionRings { get; set; }
        public DbSet<EavesCollection> EavesCollections { get; set; }
        public DbSet<EavesCollectionType> EavesCollectionTypes { get; set; }
        public DbSet<EavesColor> EavesColors { get; set; }
        public DbSet<EavesFastening> EavesFastenings { get; set; }
        public DbSet<EavesItem> EavesItems { get; set; }
        public DbSet<EavesItemsColor> EavesItemsColors { get; set; }
        public DbSet<EavesSize> EavesSizes { get; set; }
        public DbSet<EavesType> EavesTypes { get; set; }
        public DbSet<EavesVendor> EavesVendors { get; set; }
        public DbSet<Pipe> Pipes { get; set; }
        public DbSet<PipesColor> PipesColors { get; set; }
        public DbSet<PipesSize> PipesSizes { get; set; }
        public DbSet<Ring> Rings { get; set; }




    }
}
