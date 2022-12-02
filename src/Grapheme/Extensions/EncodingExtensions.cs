using System.Text;
using System.Text.Unicode;

namespace Grapheme.Extensions;

public static class Encoding {
    /// <summary>
    /// Returns a iterator over a sequence of utf8 codepoints, in segments of graphemes.
    /// </summary>
    /// <param name="_">The reference to the encoding</param>
    /// <param name="input">The input sequence of utf8 codepoints to iterate.</param>
    /// <returns></returns>
    public static TextSegmentationUtility.GraphemeClusterEnumerator<byte> GetGraphemeClusterEnumerator(this UTF8Encoding _, ReadOnlySpan<byte> input) {
        return TextSegmentationUtility.GetUtf8ClusterEnumerator(input);
    }
}
