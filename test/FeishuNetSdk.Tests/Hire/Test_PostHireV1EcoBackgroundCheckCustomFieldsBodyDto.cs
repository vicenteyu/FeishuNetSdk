// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1EcoBackgroundCheckCustomFieldsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建背调自定义字段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 创建背调自定义字段 请求体
/// <para>接口ID：7195815979079450625</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check_custom_field/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check_custom_field%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1EcoBackgroundCheckCustomFieldsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "account_id": "6995842370159937061",
    "custom_field_list": [
        {
            "type": "select",
            "key": "candidate_degree",
            "name": {
                "zh_cn": "候选人学历",
                "en_us": "Candidate degree"
            },
            "is_required": true,
            "description": {
                "zh_cn": "候选人的真实学历",
                "en_us": "The candidate's real degree"
            },
            "options": [
                {
                    "key": "bachelor",
                    "name": {
                        "zh_cn": "本科",
                        "en_us": "Bachelor"
                    }
                }
            ]
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1EcoBackgroundCheckCustomFieldsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}