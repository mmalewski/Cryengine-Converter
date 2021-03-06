﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CgfConverter.CryEngine_Core
{
    public abstract class ChunkCompiledIntSkinVertices : Chunk
    {
        public int Reserved;
        public IntSkinVertex[] IntSkinVertices;
        public int NumIntVertices { get; set; }                  // Calculate by size of data div by size of IntSkinVertex structure.

        public override void WriteChunk()
        {
            Utils.Log(LogLevelEnum.Debug, "*** START MorphTargets Chunk ***");
            Utils.Log(LogLevelEnum.Debug, "    ChunkType:           {0}", ChunkType);
            Utils.Log(LogLevelEnum.Debug, "    Node ID:             {0:X}", ID);
        }
    }
}
