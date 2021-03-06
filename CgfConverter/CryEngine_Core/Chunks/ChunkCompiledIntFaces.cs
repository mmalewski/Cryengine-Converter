﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CgfConverter.CryEngine_Core
{
    public abstract class ChunkCompiledIntFaces : Chunk
    {
        public int Reserved;
        public uint NumIntFaces;
        public TFace[] Faces;

        public override void WriteChunk()
        {
            Utils.Log(LogLevelEnum.Debug, "*** START MorphTargets Chunk ***");
            Utils.Log(LogLevelEnum.Debug, "    ChunkType:           {0}", ChunkType);
            Utils.Log(LogLevelEnum.Debug, "    Node ID:             {0:X}", ID);
        }
    }
}
