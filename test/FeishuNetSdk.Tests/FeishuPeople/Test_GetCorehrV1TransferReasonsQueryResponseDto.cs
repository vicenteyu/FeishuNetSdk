namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 获取异动原因列表 响应体
/// <para>接口ID：7086375306023895041</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job_change/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2ftransfer_reason%2fquery</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1TransferReasonsQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "transfer_reason_unique_identifier": "voluntary_transfer",
                "name": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "active": true,
                "parent_transfer_reason_unique_identifier": "reason_for_job_change_option25",
                "created_time": "2021-07-04 20:30:47",
                "updated_time": "2022-02-28 16:27:56"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1TransferReasonsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}