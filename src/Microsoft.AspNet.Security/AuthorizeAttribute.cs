﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNet.Security
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class AuthorizeAttribute : Attribute
    {
        public AuthorizeAttribute() { }

        public AuthorizeAttribute(string policy)
        {
            Policy = policy;
        }

        public string Policy { get; set; }

        public string Roles { get; set; }

        public string ActiveAuthenticationTypes { get; set; }
    }
}