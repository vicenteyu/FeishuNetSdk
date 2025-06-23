namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 查询人才操作记录 响应体
/// <para>接口ID：7098526921012936706</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2ftalent_operation_log%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TalentOperationLogsSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "items": [
            {
                "application_id": "6949805467799537964",
                "talent_id": "6843547872837273223",
                "operator": {
                    "id": "ou_016632190e242d8c9eed0a542b00756c",
                    "name": {
                        "zh_cn": "张三",
                        "en_us": "Tom"
                    }
                },
                "operation_type": "3001",
                "operation_time": "1618500278663",
                "operator_type": 1
            }
        ],
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ=="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1TalentOperationLogsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}