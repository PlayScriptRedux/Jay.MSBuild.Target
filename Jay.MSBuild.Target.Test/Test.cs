using NUnit.Framework;
using System;
using Jay;

namespace Jay.MSBuild.Target
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void CreateTask ()
		{
			var task = new Jay.MSBuild.Tasks.JayDummyTask ();
			Assert.IsNotNull (task);
		}
	}
}

