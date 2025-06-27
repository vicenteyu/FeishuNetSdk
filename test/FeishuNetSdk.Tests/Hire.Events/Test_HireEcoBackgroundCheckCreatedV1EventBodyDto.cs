// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_HireEcoBackgroundCheckCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建背调 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire.Events;

/// <summary>
/// 测试 创建背调 事件体
/// <para>接口ID：7195815979079516161</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check%2fevents%2fcreated</para>
/// </summary>
[TestClass]
public class Test_HireEcoBackgroundCheckCreatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "hire.eco_background_check.created_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "background_check_id": "6931286400470354183",
        "account_id": "6931286400470354183",
        "package_id": "12",
        "additional_item_id_list": [
            "ext002"
        ],
        "comment": "高阶候选人，请尽快处理",
        "candidate_info": {
            "name": "王二",
            "mobile": {
                "code": "86",
                "number": "18900001111"
            },
            "email": "xxx@abc.vom",
            "first_name": "Ming",
            "last_name": "Lee"
        },
        "client_contact_info": {
            "name": "王二",
            "mobile": {
                "code": "86",
                "number": "18900001111"
            },
            "email": "xxx@abc.vom"
        },
        "custom_field_list": [
            {
                "key": "candidate_extra_info",
                "value": "这是一些额外信息"
            }
        ]
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Hire.Events.HireEcoBackgroundCheckCreatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}