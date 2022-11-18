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
            Func<Chaise, Materiaux> regroupeParMateriauxFunc = null;
            Func<Chaise, bool> only4PiedsFunc = null;
            Func<IGrouping<Materiaux, Chaise>, (Materiaux, int)> moyenneDesPrixParMateriauxFunc = null;

            Func<(Materiaux, int), Materiaux> materiauxKeySelector = null;
            Func<(Materiaux, int), int> moyenneValueSelector = null;

            return chaises
                .Where(only4PiedsFunc)
                .GroupBy(regroupeParMateriauxFunc)
                .Select(moyenneDesPrixParMateriauxFunc)
                .ToDictionary(materiauxKeySelector, moyenneValueSelector);
        }
    }
}
