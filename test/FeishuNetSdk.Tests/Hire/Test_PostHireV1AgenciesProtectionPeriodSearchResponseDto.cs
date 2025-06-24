// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1AgenciesProtectionPeriodSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询猎头保护期信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 查询猎头保护期信息 响应体
/// <para>接口ID：7307160083569655811</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/agency/protect_search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2fprotect_search</para>
/// </summary>
[TestClass]
public class Test_PostHireV1AgenciesProtectionPeriodSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "is_onboarded": false,
        "onboarded_in_protection": false,
        "onboarded_protection": {
            "protection_type": 1,
            "application_id": "6930815272790114323",
            "start_time": "1700023694629",
            "expire_time": "1700023694630",
            "agency_supplier_id": "6930815272790114324",
            "agency_supplier_name": {
                "zh_cn": "超越猎头公司",
                "en_us": "chaoyue head-hunting company"
            },
            "agency_supplier_user_id": "6930815272790114324",
            "agency_supplier_user_name": {
                "zh_cn": "张三",
                "en_us": "zhangsan"
            }
        },
        "protection_list": [
            {
                "protection_type": 1,
                "application_id": "6930815272790114323",
                "start_time": "1700023694629",
                "expire_time": "1700023694630",
                "agency_supplier_id": "6930815272790114324",
                "agency_supplier_name": {
                    "zh_cn": "超越猎头公司",
                    "en_us": "chaoyue head-hunting company"
                },
                "agency_supplier_user_id": "6930815272790114324",
                "agency_supplier_user_name": {
                    "zh_cn": "张三",
                    "en_us": "zhangsan"
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1AgenciesProtectionPeriodSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}