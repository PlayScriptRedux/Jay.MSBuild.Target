using System;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Jay.MSBuild.Tasks
{
	public class JayDummyTask : Task
	{
		public JayDummyTask ()
		{
		}

		public override bool Execute ()
		{
			return true;
		}
	}
}

