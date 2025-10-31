using Microsoft.AspNetCore.Builder;

namespace AuthLivestock.Test.Config;

public class EnvironmentTest
{

   [Fact]
   public void IsNotDevModeByDefault()
   { 
       var builder = WebApplication.CreateEmptyBuilder(new WebApplicationOptions());
       var isDev = AuthLivestock.Config.Environment.IsDevMode(builder);
       Assert.False(isDev);
   }
}
