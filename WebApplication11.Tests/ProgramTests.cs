using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace WebApplication11.Tests
{
    public class ProgramTests : IClassFixture<WebApplicationFactory<WebApplication11.Startup>>
    {
        private readonly WebApplicationFactory<WebApplication11.Startup> _factory;

        public ProgramTests(WebApplicationFactory<WebApplication11.Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Test1()
        {
            // 既存のテスト
        }

        [Fact]
        public void Test2()
        {
            // テストの内容をここに追加
            Assert.True(true); // 仮のアサーション
        }

        [Fact]
        public void Test3()
        {
            // テストの内容をここに追加
            Assert.Equal(4, 2 + 2); // 仮のアサーション
        }

        [Fact]
        public void Test4()
        {
            // テストの内容をここに追加
            Assert.True(false); // 仮のアサーション
        }


    }
}
