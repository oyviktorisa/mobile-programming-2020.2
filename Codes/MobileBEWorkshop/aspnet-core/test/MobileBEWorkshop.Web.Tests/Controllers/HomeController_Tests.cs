using System.Threading.Tasks;
using MobileBEWorkshop.Models.TokenAuth;
using MobileBEWorkshop.Web.Controllers;
using Shouldly;
using Xunit;

namespace MobileBEWorkshop.Web.Tests.Controllers
{
    public class HomeController_Tests: MobileBEWorkshopWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}