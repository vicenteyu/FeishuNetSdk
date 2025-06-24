// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_HireEcoExamCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建笔试 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire.Events;

/// <summary>
/// 测试 创建笔试 事件体
/// <para>接口ID：7195815976042610690</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_exam/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_exam%2fevents%2fcreated</para>
/// </summary>
[TestClass]
public class Test_HireEcoExamCreatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "hire.eco_exam.created_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "exam_id": "7147998241542539527",
        "account_id": "7147998241542539527",
        "paper_id": "paper001",
        "candidate_info": {
            "name": "王二",
            "mobile": {
                "code": "86",
                "number": "18900001111"
            },
            "email": "xxx@abc.vom"
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Hire.Events.HireEcoExamCreatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}