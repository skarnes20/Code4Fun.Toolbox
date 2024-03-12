using Skarnes20.Toolbox.Token;
using Xunit;

namespace Skarnes20.Toolbox.UnitTest.Token
{
    public class JwtExtension
    {
        private readonly string _token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";

        [Fact(DisplayName = "GetValue with valid property returns correct value")]
        public void GetValue_ValidProperty_Value()
        {
            var name = _token.GetValue("name");

            Assert.Equal("John Doe", name);
        }

        [Fact(DisplayName = "GetValue with not existing property returns null")]
        public void GetValue_NotValidProperty_Null()
        {
            var value = _token.GetValue("notExisting");

            Assert.Null(value);
        }

        [Fact(DisplayName = "GetClaims with valid jwt returns claims")]
        public void GetClaims_ValidToken_ListWithClaims()
        {
            var claims = _token.GetClaims();

            Assert.NotEmpty(claims);
        }
    }
}