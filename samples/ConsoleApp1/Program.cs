using FeishuNetSdk;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Text.Json;

var serviceProvider = new ServiceCollection()
    .AddFeishuNetSdk(options =>
    {
        options.AppId = "cli_a5795e7db0xxxxxc";
        options.AppSecret = "aRmSRe32AiAlUnUmAqxxxxxxYgIJQ";
    })
    .AddLogging(option => option.AddConsole())
    .BuildServiceProvider();

var tenantApi = serviceProvider.GetService<IFeishuTenantApi>()!;

var list = await tenantApi.PostBitableV1AppsByAppTokenTablesByTableIdRecordsSearchAsync("Beyzb5vdeaxacixxxxxxAadnXg", "tblb4ABxxxxxZEjYj", new() { });
Console.WriteLine(JsonSerializer.Serialize(list));

Console.ReadKey();