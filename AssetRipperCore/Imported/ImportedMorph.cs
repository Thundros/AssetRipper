﻿using System.Collections.Generic;

namespace AssetRipper.Core.Imported
{
	public class ImportedMorph
	{
		public string Path { get; set; }
		public List<ImportedMorphChannel> Channels { get; set; }
	}
}
