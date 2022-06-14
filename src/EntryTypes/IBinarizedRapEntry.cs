using Antlr4.Runtime;
using RapNet.IO;

namespace RapNet.EntryTypes;

/// <summary>
/// Represents binarized raP entry.
/// </summary>
internal interface IBinarizedRapEntry : IRapEntry
{
    /// <summary>
    /// Converts raP entry in to a IRapEntry object.
    /// </summary>
    /// <param name="reader">Reader used for reading entry.</param>
    /// <param name="parent">Used for reading arrays recursive.</param>
    /// <returns>Returns a IRapEntry object.</returns>
    IRapEntry FromBinary(RapBinaryReader reader, bool parent = false);
}

