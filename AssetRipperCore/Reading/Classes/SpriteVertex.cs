﻿using AssetRipper.Core.IO;
using AssetRipper.Core.IO.Extensions;
using AssetRipper.Core.Math;

namespace AssetRipper.Core.Reading.Classes
{
	public class SpriteVertex
	{
		public Vector3f pos;
		public Vector2f uv;

		public SpriteVertex(ObjectReader reader)
		{
			var version = reader.version;

			pos = reader.ReadVector3f();
			if (version[0] < 4 || (version[0] == 4 && version[1] <= 3)) //4.3 and down
			{
				uv = reader.ReadVector2f();
			}
		}
	}
}
