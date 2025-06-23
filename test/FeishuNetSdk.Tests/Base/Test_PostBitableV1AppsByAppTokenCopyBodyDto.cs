namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 复制多维表格 请求体
/// <para>接口ID：7205776220394160156</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp%2fcopy</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenCopyBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "一篇新的多维表格",
    "folder_token": "fldcnqquW1svRIYVT2Np6Iabcef",
    "without_content": false,
    "time_zone": "Asia/Shanghai"
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenCopyBodyDto>(json);
        Assert.IsNotNull(result);
    }
}