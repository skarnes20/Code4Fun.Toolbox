using Code4Fun.Toolbox.Token;
using Code4Fun.Toolbox.UnitTest.TestData;
using Xunit;

namespace Code4Fun.Toolbox.UnitTest.Token
{
    public class JwtExtension
    {
        [Fact(DisplayName = "GetValue with valid property returns correct value")]
        public void GetValue_ValidProperty_Value()
        {
            var name = TokenGenerator.GetToken().GetValue("name");

            Assert.Equal("John Doe", name);
        }

        [Fact(DisplayName = "GetValue with not existing property returns null")]
        public void GetValue_NotValidProperty_Null()
        {
            var value = TokenGenerator.GetToken().GetValue("notExisting");

            Assert.Null(value);
        }

        [Fact(DisplayName = "GetClaims with valid jwt returns claims")]
        public void GetClaims_ValidToken_ListWithClaims()
        {
            var claims = TokenGenerator.GetToken().GetClaims();

            Assert.NotEmpty(claims);
        }
    }
}