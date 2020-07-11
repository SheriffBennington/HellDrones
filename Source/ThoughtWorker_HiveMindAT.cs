using System;
using Verse;
using RimWorld;

namespace Helldrone
{
    class ThoughtWorker_HiveMindAT : ThoughtWorker
    {
        protected override ThoughtState CurrentSocialStateInternal(Pawn pawn, Pawn other)
        {
            if (!other.RaceProps.Humanlike || !RelationsUtility.PawnsKnowEachOther(pawn, other))
            {
                return false;
            }
            if (pawn.kindDef != Helldrone.PawnKindDefOf.AndroidHellUnit)
            {
                return false;
            }
            return true;
        }
    }
}
