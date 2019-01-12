﻿/////////////////////////////////////////////////////////////////////////////////////////////////
//
// CenterCLR.RelaxVersioner - Easy-usage, Git-based, auto-generate version informations toolset.
// Copyright (c) 2016-2018 Kouji Matsui (@kozy_kekyo, @kekyo2)
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//	http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
/////////////////////////////////////////////////////////////////////////////////////////////////

using System.IO;

namespace CenterCLR.RelaxVersioner.Writers
{
    internal sealed class FSharpWriter : WriterBase
    {
        public override string Language => "F#";

        protected override void WriteBeforeBody(TextWriter tw)
        {
            tw.WriteLine("namespace System.Reflection");
            tw.WriteLine("    open System");
            tw.WriteLine("    [<Sealed>]");
            tw.WriteLine("    [<NoEquality>]");
            tw.WriteLine("    [<NoComparison>]");
            tw.WriteLine("    [<AutoSerializable(false)>]");
            tw.WriteLine("    [<AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)>]");
            tw.WriteLine("    type internal AssemblyVersionMetadataAttribute(key: string, value: string) =");
            tw.WriteLine("        inherit Attribute()");
            tw.WriteLine("        member this.Key = key");
            tw.WriteLine("        member this.Value = value");
            tw.WriteLine();

            tw.WriteLine("namespace global");
            tw.WriteLine();
        }

        protected override void WriteImport(TextWriter tw, string namespaceName)
        {
            // tw.WriteLine("open {0}", namespaceName);
        }
        
        protected override string GetArgumentString(string argumentValue)
        {
            return string.Format("@\"{0}\"", argumentValue.Replace("\"", "\"\""));
        }

        protected override void WriteAttribute(TextWriter tw, string name, string args)
        {
            tw.WriteLine("    [<assembly: {0}({1})>]", name, args);
        }

        protected override void WriteAfterBody(TextWriter tw)
        {
            tw.WriteLine("    do()");
            tw.WriteLine();

        }
    }
}
