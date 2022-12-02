// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace System.Text;

public static class UnicodeUtility {

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsValidCodePoint(uint codePoint) => codePoint <= 0x10FFFFU;
}
