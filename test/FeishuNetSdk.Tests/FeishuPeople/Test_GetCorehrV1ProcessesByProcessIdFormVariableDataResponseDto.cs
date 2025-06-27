// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV1ProcessesByProcessIdFormVariableDataResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取流程表单数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 获取流程表单数据 响应体
/// <para>接口ID：7160631114605608962</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/process-form_variable_data/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fprocess-form_variable_data%2fget</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1ProcessesByProcessIdFormVariableDataResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data":
    {
        "field_variable_values":
        [
            {
                "variable_api_name": "reason",
                "variable_name":
                {
                    "en-US": "Reason",
                    "zh-CN": "离职原因"
                },
                "variable_value":
                {
                    "enum_value":
                    {
                        "desc": null,
                        "name":
                        {
                            "en-US": "",
                            "zh-CN": "测试"
                        },
                        "value": "reason_for_offboarding_option96"
                    }
                }
            },
            {
                "variable_api_name": "offboarding_date",
                "variable_name":
                {
                    "en-US": "Offboarding date",
                    "zh-CN": "离职日期"
                },
                "variable_value":
                {
                    "date_value":
                    {
                        "value": 19265
                    }
                }
            },
            {
                "variable_api_name": "employment",
                "variable_name":
                {
                    "en-US": "Employment",
                    "zh-CN": "员工"
                },
                "variable_value":
                {
                    "employment_value":
                    {
                        "user_id": "123321",
                        "value": "123321"
                    }
                }
            }
        ]
    },
    "msg": ""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1ProcessesByProcessIdFormVariableDataResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}