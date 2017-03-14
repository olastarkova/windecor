using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using application.Domain.Abstract;
using application.Domain.Enitites;

namespace application.Domain.Concrete
{
    public class EFEavesRepository : IEavesRepository
    {
        EFDbEavesContex context = new EFDbEavesContex();

        public IQueryable<EavesCatogory> EavesCatogories { get { return context.EavesCatogories; } }
        public IQueryable<EavesCollectionFastenings> EavesCollectionFastenings { get { return context.EavesCollectionFastenings; } }
        public IQueryable<EavesCollectionFasteningsByColor> EavesCollectionFasteningsByColors { get { return context.EavesCollectionFasteningsByColors; } }
        public IQueryable<EavesCollectionItem> EavesCollectionItems { get { return context.EavesCollectionItems; } }
        public IQueryable<EavesCollectionRing> EavesCollectionRings { get { return context.EavesCollectionRings; } }
        public IQueryable<EavesCollection> EavesCollections { get { return context.EavesCollections; } }
        public IQueryable<EavesCollectionType> EavesCollectionTypes { get { return context.EavesCollectionTypes; } }
        public IQueryable<EavesColor> EavesColors { get { return context.EavesColors; } }
        public IQueryable<EavesFastening> EavesFastenings { get { return context.EavesFastenings; } }
        public IQueryable<EavesItem> EavesItems { get { return context.EavesItems; } }
        public IQueryable<EavesItemsColor> EavesItemsColors { get { return context.EavesItemsColors; } }
        public IQueryable<EavesSize> EavesSizes { get { return context.EavesSizes; } }
        public IQueryable<EavesType> EavesTypes { get { return context.EavesTypes; } }
        public IQueryable<EavesVendor> EavesVendors { get { return context.EavesVendors; } }
        public IQueryable<Pipe> Pipes { get { return context.Pipes; } }
        public IQueryable<PipesColor> PipesColors { get { return context.PipesColors; } }
        public IQueryable<PipesSize> PipesSizes { get { return context.PipesSizes; } }
        public IQueryable<Ring> Rings { get { return context.Rings; } }

    }
}
