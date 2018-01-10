// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Hosting;

namespace Microsoft.AspNetCore.Mvc.ApplicationParts
{
    /// <summary>
    /// Determines if an <see cref="ApplicationPart"/> represents the entry point for the application.
    /// <para>
    /// In the default case, the <see cref="AssemblyPart"/> produced by the assembly name <see cref="IHostingEnvironment.ApplicationName"/>
    /// is the entry point.
    /// </para>
    /// <para>
    /// An <see cref="IApplicationFeatureProvider"/> may choose to use this an interface as a way to resolve conflicts when
    /// multiple <see cref="ApplicationPart"/> instances resolve equivalent feature values.
    /// </para>
    /// </summary>
    /// <remarks>An application SHOULD NOT have more than one <see cref="ApplicationPart"/> where the value for <see cref="IsEntryPoint"/> is
    /// <see langword="true"/>.</remarks>
    public interface IEntryPointProvider
    {
        bool IsEntryPoint { get; }
    }
}
