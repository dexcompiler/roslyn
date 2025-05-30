﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Reflection;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Workspaces.ProjectSystem;

namespace Microsoft.CodeAnalysis.LanguageServer.HostWorkspace;

internal sealed class HostDiagnosticAnalyzerProvider(string? razorSourceGenerator) : IHostDiagnosticAnalyzerProvider
{
    public ImmutableArray<(AnalyzerFileReference reference, string extensionId)> GetAnalyzerReferencesInExtensions() => [];

    public ImmutableArray<(string path, string extensionId)> GetRazorAssembliesInExtensions()
    {
        if (File.Exists(razorSourceGenerator))
        {
            return [(razorSourceGenerator, ProjectSystemProject.RazorVsixExtensionId)];
        }
        return [];
    }
}
