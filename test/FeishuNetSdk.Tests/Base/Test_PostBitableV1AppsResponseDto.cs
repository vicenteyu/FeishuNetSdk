namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 创建多维表格 响应体
/// <para>接口ID：7047733935745007620</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "app": {
            "app_token": "S404b*****e9PQsYDWYcNryFn0g",
            "default_table_id": "tbl********oumSQ",
            "folder_token": "fldcnqquW1svRIYVT2Np6Iabcef",
            "name": "一篇新的多维表格",
            "url": "https://example.feishu.cn/base/S404b*****e9PQsYDWYcNryFn0g"
        }
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.PostBitableV1AppsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}