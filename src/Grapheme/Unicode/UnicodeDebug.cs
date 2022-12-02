// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Text;

namespace Grapheme.Unicode;

internal static class UnicodeDebug {
    [Conditional("DEBUG")]
    internal static void AssertIsValidCodePoint(uint codePoint)
    {
        if (!UnicodeUtility.IsValidCodePoint(codePoint))
        {
            Debug.Fail($"The value {ToHexString(codePoint)} is not a valid Unicode code point.");
        }
    }

    /// <summary>
    /// Formats a code point as the hex string "U+XXXX".
    /// </summary>
    /// <remarks>
    /// The input value doesn't have to be a real code point in the Unicode codespace. It can be any integer.
    /// </remarks>
    private static string ToHexString(uint codePoint)
    {
        return FormattableString.Invariant($"U+{codePoint:X4}");
    }
}
