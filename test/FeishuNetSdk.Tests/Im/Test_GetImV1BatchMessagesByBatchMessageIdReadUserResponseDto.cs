namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 查询批量消息推送和阅读人数 响应体
/// <para>接口ID：7021850211959275548</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/batch_message/read_user</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fbatch_message%2fread_user</para>
/// </summary>
[TestClass]
public class Test_GetImV1BatchMessagesByBatchMessageIdReadUserResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "read_user": {
            "read_count": "10",
            "total_count": "100"
        }
    },
    "msg": "ok"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.GetImV1BatchMessagesByBatchMessageIdReadUserResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}