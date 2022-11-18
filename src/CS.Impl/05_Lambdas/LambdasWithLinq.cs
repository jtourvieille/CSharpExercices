using System;
using System.Collections.Generic;
using System.Linq;

namespace CS.Impl._05_Lambdas
{
    public class LambdasWithLinq
    {
        public enum Materiaux
        {
            Bois,
            Plastique,
            Metal
        }

        public class Chaise
        {
            public int Prix { get; set; }
            public int Pieds { get; set; }
            public Materiaux Materiaux { get; set; }
        }

        public static IDictionary<Materiaux, int> GetMoyenneDesPrixDesChaisesA4PeidsParMateriaux(IEnumerable<Chaise> chaises)
        {
            Func<Chaise, Materiaux> regroupeParMateriauxFunc = chaise => chaise.Materiaux;
            Func<Chaise, bool> only4PiedsFunc = chaise => chaise.Pieds == 4;
            Func<IGrouping<Materiaux, Chaise>, (Materiaux, int)> moyenneDesPrixParMateriauxFunc = group => (group.Key, group.Select(chaise => chaise.Prix).Sum() / group.Count());

            Func<(Materiaux, int), Materiaux> materiauxKeySelector = tuple => tuple.Item1;
            Func<(Materiaux, int), int> moyenneValueSelector = tuple => tuple.Item2;

            return chaises
                .Where(only4PiedsFunc)
                .GroupBy(regroupeParMateriauxFunc)
                .Select(moyenneDesPrixParMateriauxFunc)
                .ToDictionary(materiauxKeySelector, moyenneValueSelector);
        }
    }
}