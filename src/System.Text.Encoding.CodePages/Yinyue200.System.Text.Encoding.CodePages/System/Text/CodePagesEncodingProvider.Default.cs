// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text;

namespace Yinyue200.Corefx.CodePages
{
    public sealed partial class CodePagesEncodingProvider : EncodingProvider
    {
        /// <summary>Get the system default non-unicode code page, or 0 if not available.</summary>
        private static int SystemDefaultCodePage
        {
            get { return 0; }
        }
    }
}
