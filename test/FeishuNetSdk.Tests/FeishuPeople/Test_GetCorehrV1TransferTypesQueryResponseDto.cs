namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 获取异动类型列表 响应体
/// <para>接口ID：7086375306023911425</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job_change/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2ftransfer_type%2fquery</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1TransferTypesQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "items": [
            {
                "active": true,
                "created_at": "2022-04-08 15:17:10",
                "flow_id": "people_6963913041981490725_6982474967023882020",
                "flow_name": [
                    {
                        "lang": "zh-CN",
                        "value": "xmz异动流程"
                    }
                ],
                "name": [
                    {
                        "lang": "zh-CN",
                        "value": "上级变 更"
                    },
                    {
                        "lang": "en-US",
                        "value": "Reporting Line Change2"
                    }
                ],
                "transfer_type_unique_identifier": "reporting_line_change",
                "updated_at": "2022-04-08 15:17:10"
            }
        ]
    },
    "msg": ""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1TransferTypesQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}