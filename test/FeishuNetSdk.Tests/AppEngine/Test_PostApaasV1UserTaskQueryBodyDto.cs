namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 查询人工任务 请求体
/// <para>接口ID：7446337145820315652</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fuser_task%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1UserTaskQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "type": "pending",
    "source": "assignMe",
    "limit": "10",
    "offset": "0",
    "start_time": "1730208758000",
    "end_time": "1730208758000",
    "api_ids": [
        "package_b40c28__c__action_aadfv6lfu6kai"
    ],
    "kunlun_user_id": "1234"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1UserTaskQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}