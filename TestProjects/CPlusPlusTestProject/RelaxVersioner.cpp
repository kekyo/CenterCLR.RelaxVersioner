// This is auto-generated version information attributes by CenterCLR.RelaxVersioner.0.9.67.0
// Do not edit.
// Generated date: Wed, 28 Aug 2019 11:38:28 GMT

#include "stdafx.h"

namespace System
{
	namespace Reflection
	{
		[System::AttributeUsage(System::AttributeTargets::Assembly, AllowMultiple = true, Inherited = false)]
		private ref class AssemblyVersionMetadataAttribute sealed : public System::Attribute
		{
		private:
			System::String^ key_;
			System::String^ value_;
		public:
			AssemblyVersionMetadataAttribute(System::String^ key, System::String^ value)
				: key_(key), value_(value) { }
			property System::String^ Key { System::String^ get() { return key_; } }
			property System::String^ Value { System::String^ get() { return value_; } }
		};
	}
}

using namespace System::Reflection;
using namespace System::Runtime::InteropServices;

[assembly: AssemblyVersionAttribute("0.9.67")];
[assembly: AssemblyFileVersionAttribute("2019.8.28.37085")];
[assembly: AssemblyInformationalVersionAttribute("15f58e69bf1cf320511616a6377a3d4b03690d57")];
[assembly: AssemblyVersionMetadataAttribute("Build","Wed, 28 Aug 2019 11:36:10 GMT")];
[assembly: AssemblyVersionMetadataAttribute("Branch","")];
[assembly: AssemblyVersionMetadataAttribute("Tags","0.9.67")];
[assembly: AssemblyVersionMetadataAttribute("Author","Kouji Matsui <k@kekyo.net>")];
[assembly: AssemblyVersionMetadataAttribute("Committer","Kouji Matsui <k@kekyo.net>")];
[assembly: AssemblyVersionMetadataAttribute("Message","Fixed failing extract branch name.")];

