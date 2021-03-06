// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.Extensions.Options;

namespace Microsoft.AspNetCore.Identity.Test
{
    internal class PasswordHasherOptionsAccessor : IOptions<PasswordHasherOptions>
    {
        public PasswordHasherOptions Value { get; } = new PasswordHasherOptions();
    }
}