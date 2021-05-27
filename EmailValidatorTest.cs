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
        [InlineData("i_like_underscore@but_its_not_allowed_in_this_part.example.com ")]
        public void TestBasicBadEmailAddresses(string value)
        {
            EmailValidator v = new EmailValidator();
            Assert.False(v.IsValid(value));
        }

        [Theory]
        [InlineData("simple@example.com")]
        [InlineData("very.common@example.com")]
        [InlineData("other.email-with-hyphen@example.com")]
        [InlineData("fully-qualified-domain@example.com")]
        [InlineData("disposable.style.email.with+symbol@example.com")]
        [InlineData("user.name+tag+sorting@example.com")]
        [InlineData("x@example.com")]
        [InlineData("example-indeed@strange-example.com")]
        [InlineData("test/test@test.com")]
        [InlineData("example@s.example")]
        [InlineData("\" \"@example.org ")]
        [InlineData("\"john..doe\"@example.org")]
        [InlineData("mailhost!username@example.org")]
        [InlineData("user%example.com@example.org")]
        [InlineData("user-@example.org")]
        [InlineData("WithNumbers-123@TEST-company.Com")]
        [InlineData("Complicated-0123456789!#$%&'*+-/=?^_`{|}~@Some-Domain-9876543210.info")]
        public void TestGoodEmailAddresses(string value)
        {
            EmailValidator v = new EmailValidator();
            Assert.True(v.IsValid(value));
        }

        [Theory (Skip = "Not Implemented Yet!")]
        [InlineData("A@b@c@example.com")]
        [InlineData("a\"b(c)d,e:f;g<h>i[j\\k]l@example.com")]
        [InlineData("just\"not\"right@example.com")]
        [InlineData("this is\"not\\allowed@example.com")]
        [InlineData("this\\ still\\\"not\\\\allowed@example.com")]
        [InlineData("1234567890123456789012345678901234567890123456789012345678901234+x@example.com")]
        [InlineData("📧💩@test.com")]
        public void TestAdvancedBadEmailAddresses(string value)
        {
            EmailValidator v = new EmailValidator();
            Assert.False(v.IsValid(value));
        }

    }
}
