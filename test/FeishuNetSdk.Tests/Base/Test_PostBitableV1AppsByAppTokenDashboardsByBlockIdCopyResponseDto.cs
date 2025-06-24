namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 复制仪表盘 响应体
/// <para>接口ID：7177650713441812483</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-dashboard/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-dashboard%2fcopy</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenDashboardsByBlockIdCopyResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{"data":{
    "block_id": "blkXsf60PxMdJLQN",
    "name": "New Dashboard"
}}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenDashboardsByBlockIdCopyResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}