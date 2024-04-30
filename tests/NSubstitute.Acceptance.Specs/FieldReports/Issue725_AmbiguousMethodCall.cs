using NUnit.Framework;

namespace NSubstitute.Acceptance.Specs.FieldReports;

public class Issue725_AmbiguousMethodCall
{
    public interface ITest
    {
        Task<int?> TestAsync();
    }

    [Test]
    public void Stub_any_string_and_call_with_null()
    {
        var test = Substitute.For<ITest>();
        test.TestAsync().Returns(Task.FromResult(1));
    }
}