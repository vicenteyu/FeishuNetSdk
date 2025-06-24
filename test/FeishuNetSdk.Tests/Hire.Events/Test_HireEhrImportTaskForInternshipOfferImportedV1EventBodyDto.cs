// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_HireEhrImportTaskForInternshipOfferImportedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 导入 e-HR（实习 Offer） 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire.Events;

/// <summary>
/// 测试 导入 e-HR（实习 Offer） 事件体
/// <para>接口ID：7219143467641470979</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/onboard/events/imported</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fehr_import_task_for_internship_offer%2fevents%2fimported</para>
/// </summary>
[TestClass]
public class Test_HireEhrImportTaskForInternshipOfferImportedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "hire.ehr_import_task_for_internship_offer.imported_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "task_id": "6890840517010000141",
        "application_id": "6891113078776137998",
        "offer_id": "6930815272790114324",
        "pre_onboard_id": "6030815272790115431",
        "ehr_department_id": "6887399523094627847",
        "operator_id": "e33ggbyz",
        "operator_user_id": {
            "union_id": "on_8ed6aa67826108097d9ee143816345",
            "user_id": "e33ggbyz",
            "open_id": "ou_84aad35d084aa403a838cf73ee18467"
        },
        "ehr_department": {
            "department_id": "6887399523094627847",
            "open_department_id": "od-13d9a8f63abc60673fccaa2ed4dfcfb6"
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Hire.Events.HireEhrImportTaskForInternshipOfferImportedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}