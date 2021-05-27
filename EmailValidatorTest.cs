using System;
using Xunit;

namespace emailaddr
{
    public class EmailValidatorTest
    {
        [Theory]
        [InlineData("noparts")]
        [InlineData("missing@dot")]
        [InlineData("missing.at.sign")]
        public void TestBadEmailAddresses(string value)
        {
            EmailValidator v = new EmailValidator();
            Assert.False(v.IsValid(value));
        }

        [Theory]
        [InlineData("simple@test.com")]
        [InlineData("UPPERCASE@TEST.COM")]
        [InlineData("WithNumbers-123@TEST-company.Com")]
        [InlineData("Complicated-0123456789!#$%&'*+-/=?^_`{|}~@Some-Domain-9876543210.info")]
        public void TestGoodEmailAddresses(string value)
        {
            EmailValidator v = new EmailValidator();
            Assert.True(v.IsValid(value));
        }
    }
}
