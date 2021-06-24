// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.ComponentModel.Composition;
using Microsoft.AspNetCore.Razor.LanguageServer;
using Microsoft.CodeAnalysis.Host;

namespace Microsoft.VisualStudio.LanguageServerClient.Razor
{
    [Export(typeof(HostWorkspaceServicesProvider))]
    internal class VSHostWorkspaceServicesProvider : HostWorkspaceServicesProvider
    {
        private readonly CodeAnalysis.Workspace _workspace;

        [ImportingConstructor]
        public VSHostWorkspaceServicesProvider([Import(typeof(CodeAnalysis.Workspace))] CodeAnalysis.Workspace workspace)
        {
            if (workspace is null)
            {
                throw new ArgumentNullException(nameof(workspace));
            }

            _workspace = workspace;
        }

        public override HostWorkspaceServices GetServices() => _workspace.Services;
    }
}
