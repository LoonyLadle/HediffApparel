using System.Collections.Generic;
using Verse;

#pragma warning disable IDE1006 // Naming Styles

namespace HediffApparel
{
	public class CompProperties_HediffApparel : CompProperties
	{
		public HediffDef hediffDef;
		public List<BodyPartDef> partsToAffect;
		public List<BodyPartGroupDef> groupsToAffect;
		public List<string> filterTerms;
		public FilterMode filterMode = FilterMode.Contains;
		public SeverityMode severityMode = SeverityMode.None;
		public bool global;

		public CompProperties_HediffApparel()
		{
			compClass = typeof(CompHediffApparel);
		}
	}
}
