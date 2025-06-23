namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询员工 HRBP / 属地 BP 响应体
/// <para>接口ID：7261860942295580674</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/authorization/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployees-bp%2fbatch_get</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2EmployeesBpsBatchGetResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "employment_direct_bps": [
            {
                "employment_id": "6863326262618752123",
                "hrbp_ids": [
                    "6863326262618752123"
                ],
                "location_bp_ids": [
                    "6863326262618752123"
                ]
            }
        ],
        "employment_all_bps": [
            {
                "employment_id": "6863326262618752123",
                "hrbp_ids": [
                    "6863326262618752123"
                ],
                "location_bp_ids": [
                    "6863326262618752123"
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2EmployeesBpsBatchGetResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}