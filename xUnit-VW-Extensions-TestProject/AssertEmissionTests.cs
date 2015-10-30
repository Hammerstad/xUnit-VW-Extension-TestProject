namespace xUnit_VW_Extensions_TestProject
{
    using Xunit;
    using Assert = Xunit.VW.Assert;

    public class AssertEmissionTests
	{
		[Fact]
		public void EmissionTests()
		{
			const int Emissions = 9001;
			const int LegalLimit = 1337;
			
			Assert.InRange(Emissions, 0, LegalLimit);			
		}
	}
}