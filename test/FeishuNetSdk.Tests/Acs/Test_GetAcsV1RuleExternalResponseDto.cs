// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetAcsV1RuleExternalResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取权限组信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Acs;

/// <summary>
/// 测试 获取权限组信息 响应体
/// <para>接口ID：7321978105899089948</para>
/// <para>文档地址：https://open.feishu.cn/document/acs-v1/rule_external/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2frule_external%2fget</para>
/// </summary>
[TestClass]
public class Test_GetAcsV1RuleExternalResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "rules": [
            {
                "id": "34252345234523",
                "name": "南门",
                "devices": [
                    {
                        "id": "534545234523452345",
                        "name": "北门"
                    }
                ],
                "user_count": "3",
                "users": [
                    {
                        "user_type": 1,
                        "user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
                        "user_name": "张三",
                        "phone_num": "1357890001",
                        "department_id": "od-f7d44ab733f7602f5cc5194735fd9aaf"
                    }
                ],
                "visitor_count": "3",
                "visitors": [
                    {
                        "user_type": 1,
                        "user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
                        "user_name": "张三",
                        "phone_num": "1357890001",
                        "department_id": "od-f7d44ab733f7602f5cc5194735fd9aaf"
                    }
                ],
                "remind_face": false,
                "opening_time": {
                    "valid_day": {
                        "start_day": 1699031483,
                        "end_day": 1699931483
                    },
                    "weekdays": [
                        1,
                        2,
                        3
                    ],
                    "day_times": [
                        {
                            "start_hhmm": 1200,
                            "end_hhmm": 1400
                        }
                    ]
                },
                "is_temp": false
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Acs.GetAcsV1RuleExternalResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}