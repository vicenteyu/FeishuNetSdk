namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询流程实例列表 响应体
/// <para>接口ID：7296819819722571804</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/process-instance/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2ProcessesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "process_ids": [
            "7278949005675988535"
        ],
        "has_more": true,
        "page_token": "7278949005675988535"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2ProcessesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}