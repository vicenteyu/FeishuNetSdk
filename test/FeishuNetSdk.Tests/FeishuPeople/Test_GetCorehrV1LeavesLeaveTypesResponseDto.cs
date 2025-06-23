namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 获取假期类型列表 响应体
/// <para>接口ID：7126729166647885827</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/leave/leave_types</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave%2fleave_types</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1LeavesLeaveTypesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "leave_type_list": [
            {
                "leave_type_id": "4718803945687580505",
                "leave_type_name": [
                    {
                        "lang": "zh_CN",
                        "value": "张三"
                    }
                ],
                "status": 2,
                "leave_subtype_list": [
                    {
                        "leave_type_id": "4718803945687580505",
                        "leave_type_name": [
                            {
                                "lang": "zh_CN",
                                "value": "张三"
                            }
                        ]
                    }
                ],
                "created_at": "1658730384",
                "created_by": "7104164629974646786",
                "updated_at": "1658996995",
                "updated_by": "7112112899636854812"
            }
        ],
        "has_more": true,
        "page_token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1LeavesLeaveTypesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}