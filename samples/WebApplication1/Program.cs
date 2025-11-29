using Serilog;
using WebApplication1;

internal class Program
{
    private static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .Normal()
            .CreateBootstrapLogger();

        var builder = WebApplication.CreateBuilder(args);

        builder.Services
            .AddFeishuNetSdk(
                appId: "cli_a609*************900e",
                appSecret: "zCAO4h*************bHNQVpZoK73",
                encryptKey: "75vyV*************Clrwpkjy",
                verificationToken: "WVr*************MSJw")
            //添加 长连接 服务
            .AddFeishuWebSocket();

        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Host.UseSerilog(Log.Logger);

        //每次启动应用会自动发送一条卡片消息用于测试卡片回调，如果不需要，则注释下面一行。
        builder.Services.AddHostedService<Class1>();

        var app = builder.Build();
        app.UsePathBase("/feishunetsdktest");
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        //app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages();

        //启用飞书事件回调地址服务
        app.UseFeishuEndpoint("/a/b/c/d");

        app.Run();
    }
}
