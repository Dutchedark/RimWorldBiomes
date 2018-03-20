using System;
using RimWorld;
using Verse;
namespace RimWorldBiomesCaves
{
    public class IngestionOutComeDoer_RandomMoodBuff : IngestionOutComeDoer_RandomMoodBuff
    {
        protected override void DoIngestionOutcomeSpecial(Pawn pawn, Thing ingested)
        {
            pawn.needs.mood.thoughts.memories.TryGainMemory(Rand.value > 0.5 ? BluebellCutsGoodHigh : BluebellCutsBadHigh);
        }
    }
}