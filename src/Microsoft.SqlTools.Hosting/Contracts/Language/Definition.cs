//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using Microsoft.SqlTools.Hosting.Contracts.Workspace;
using Microsoft.SqlTools.Hosting.Protocol.Contracts;

namespace Microsoft.SqlTools.Hosting.Contracts.Language
{
    public class DefinitionRequest
    {
        public static readonly
            RequestType<TextDocumentPosition, Location[]> Type =
            RequestType<TextDocumentPosition, Location[]>.Create("textDocument/definition");
    }
}
