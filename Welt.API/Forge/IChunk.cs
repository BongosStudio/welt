﻿#region Copyright
// COPYRIGHT 2016 JUSTIN COX (CONJI)
#endregion

using System.Security.Cryptography.X509Certificates;

namespace Welt.API.Forge
{
    /// <summary>
    ///     Interface for Chunk objects. IChunk objects contain IFloors and are
    ///     contained within IWorlds.
    /// </summary>
    public interface IChunk
    {
        /// <summary>
        ///     The X location of the chunk in the world.
        /// </summary>
        uint X { get; }
        /// <summary>
        ///     The Z location of the chunk in the world.
        /// </summary>
        uint Z { get; }

        /// <summary>
        ///     The IChunk found to the north.
        /// </summary>
        IChunk N { get; }
        /// <summary>
        ///     The IChunk found to the east.
        /// </summary>
        IChunk E { get; }
        /// <summary>
        ///     The IChunk found to the south.
        /// </summary>
        IChunk S { get; }
        /// <summary>
        ///     The IChunk found to the west.
        /// </summary>
        IChunk W { get; }

        /// <summary>
        ///     The IChunk found to the northeast.
        /// </summary>
        IChunk NE { get; }
        /// <summary>
        ///     The IChunk found to the northwest.
        /// </summary>
        IChunk NW { get; }
        /// <summary>
        ///     The IChunk found to the southeast.
        /// </summary>
        IChunk SE { get; }
        /// <summary>
        ///     The IChunk found to the southwest.
        /// </summary>
        IChunk SW { get; }

        /// <summary>
        ///     The maximum height values of X;Z coordinates.
        /// </summary>
        /// // TODO: think about turning this into a flat array.
        byte[,] HeightMap { get; }
        /// <summary>
        ///     The collection of <see cref="IFloor"/>s in the chunk.
        /// </summary>
        IFloor[] Floors { get; }
        /// <summary>
        ///     Determines whether or not the IChunk has been modified.
        /// </summary>
        bool IsModified { get; set; }

        /// <summary>
        ///     Gets the block found at the requested location.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        Block GetBlock(int x, int y, int z);
        /// <summary>
        ///     Sets the block at the vector.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="value"></param>
        void SetBlock(int x, int y, int z, Block value);
        // these are `int`s so that we can gauge whether or not it wants to tap a relative chunk
    }
}