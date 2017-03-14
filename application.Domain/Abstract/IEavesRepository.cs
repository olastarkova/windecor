using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using application.Domain.Enitites;

namespace application.Domain.Abstract
{
    public interface IEavesRepository
    {
        IQueryable<EavesCatogory> EavesCatogories { get; }
        IQueryable<EavesCollectionFastenings> EavesCollectionFastenings { get; }
        IQueryable<EavesCollectionFasteningsByColor> EavesCollectionFasteningsByColors { get; }
        IQueryable<EavesCollectionItem> EavesCollectionItems { get; }
        IQueryable<EavesCollectionRing> EavesCollectionRings { get; }
        IQueryable<EavesCollection> EavesCollections { get; }
        IQueryable<EavesCollectionType> EavesCollectionTypes { get; }
        IQueryable<EavesColor> EavesColors { get; }
        IQueryable<EavesFastening> EavesFastenings { get; }
        IQueryable<EavesItem> EavesItems { get; }
        IQueryable<EavesItemsColor> EavesItemsColors { get; }
        IQueryable<EavesSize> EavesSizes { get; }
        IQueryable<EavesType> EavesTypes { get; }
        IQueryable<EavesVendor> EavesVendors { get; }
        IQueryable<Pipe> Pipes { get; }
        IQueryable<PipesColor> PipesColors { get; }
        IQueryable<PipesSize> PipesSizes { get; }
        IQueryable<Ring> Rings { get; }


    }
}
