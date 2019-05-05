using System.Collections.Generic;
using ContentPatcher.Framework.Tokens;
using Pathoschild.Stardew.Common.Utilities;

namespace ContentPatcher.Framework
{
    /// <summary>A string value optionally containing tokens.</summary>
    internal interface ITokenString : IContextual
    {
        /// <summary>The raw string without token substitution.</summary>
        string Raw { get; }

        /// <summary>The tokens used in the string.</summary>
        HashSet<TokenName> Tokens { get; }

        /// <summary>The unrecognised tokens in the string.</summary>
        InvariantHashSet InvalidTokens { get; }

        /// <summary>Whether the string contains any tokens (including invalid tokens).</summary>
        bool HasAnyTokens { get; }

        /// <summary>Whether the token string consists of a single token with no surrounding text.</summary>
        bool IsSingleTokenOnly { get; }

        /// <summary>The string with tokens substituted for the last context update.</summary>
        string Value { get; }
    }
}
