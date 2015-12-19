﻿// Copyright(c) Microsoft.All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Sql.Sdk;

namespace Microsoft.CodeAnalysis.Sql.Rules
{
    public abstract class DefaultSqlSkimmer : SqlSkimmerBase
    {
        protected override ResourceManager ResourceManager
        {
            get
            {
                return RuleResources.ResourceManager;
            }
        }

        public override Uri HelpUri
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
