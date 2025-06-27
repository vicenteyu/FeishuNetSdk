// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchCorehrV1PreHiresByPreHireIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新待入职信息（不推荐） 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 更新待入职信息（不推荐） 响应体
/// <para>接口ID：7072977543561461762</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/pre_hire/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fpre_hire%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV1PreHiresByPreHireIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "pre_hire": {
            "ats_application_id": "4719168654814483759",
            "id": "154545454",
            "hire_date": "2020-01-01",
            "employee_type": {
                "enum_name": "type_1",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "刘梓新"
                    }
                ]
            },
            "worker_id": "1245646",
            "employee_type_id": "正式",
            "person_id": "656464648662",
            "custom_fields": [
                {
                    "field_name": "name",
                    "value": "\"Sandy\""
                }
            ],
            "cost_center_rate": [
                {
                    "cost_center_id": "6950635856373745165",
                    "rate": 100
                }
            ],
            "onboarding_status": {
                "enum_name": "type_1",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "刘梓新"
                    }
                ]
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PatchCorehrV1PreHiresByPreHireIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}