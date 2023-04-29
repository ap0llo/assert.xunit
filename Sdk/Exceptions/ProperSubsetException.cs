#if XUNIT_NULLABLE
#nullable enable
#endif

using System;

namespace Xunit.Sdk
{
	/// <summary>
	/// Exception thrown when a set is not a proper subset of another set.
	/// </summary>
#if XUNIT_VISIBILITY_INTERNAL
	internal
#else
	public
#endif
	class ProperSubsetException : XunitException
	{
		ProperSubsetException(string message) :
			base(message)
		{ }

		/// <summary>
		/// Creates a new instance of the <see cref="ProperSubsetException"/> class to be thrown
		/// when a set is not a proper subset of another set
		/// </summary>
		/// <param name="expected">The expected value</param>
		/// <param name="actual">The actual value</param>
		public static ProperSubsetException ForFailure(
			string expected,
			string actual) =>
				new ProperSubsetException(
					"Assert.ProperSubset() Failure: Value is not a proper subset" + Environment.NewLine +
					"Expected: " + expected + Environment.NewLine +
					"Actual:   " + actual
				);
	}
}
