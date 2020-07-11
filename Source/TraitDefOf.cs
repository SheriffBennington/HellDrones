using System;
using RimWorld;

namespace Helldrone
{
    [DefOf]
    public static class TraitDefOf
    {
        static TraitDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(TraitDefOf));
        }

        public static TraitDef HelldroneHiveMind;
    }
}
