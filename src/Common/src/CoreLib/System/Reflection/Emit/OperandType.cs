// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*============================================================
**
** Enumeration: OperandType
**
** Purpose: Exposes OperandType Attribute of IL.
**
** THIS FILE IS AUTOMATICALLY GENERATED. DO NOT EDIT BY HAND!
** See $(RepoRoot)\src\inc\OpCodeGen.pl for more information.**
==============================================================*/

namespace System.Reflection.Emit
{
    public enum OperandType
    {
        InlineBrTarget = 0,
        InlineField = 1,
        InlineI = 2,
        InlineI8 = 3,
        InlineMethod = 4,
        InlineNone = 5,
        [Obsolete("This API has been deprecated. https://go.microsoft.com/fwlink/?linkid=14202")]
        InlinePhi = 6,
        InlineR = 7,
        InlineSig = 9,
        InlineString = 10,
        InlineSwitch = 11,
        InlineTok = 12,
        InlineType = 13,
        InlineVar = 14,
        ShortInlineBrTarget = 15,
        ShortInlineI = 16,
        ShortInlineR = 17,
        ShortInlineVar = 18,
    }
}
