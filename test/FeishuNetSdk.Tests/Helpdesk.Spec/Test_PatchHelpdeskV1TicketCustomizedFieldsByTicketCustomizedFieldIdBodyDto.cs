// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchHelpdeskV1TicketCustomizedFieldsByTicketCustomizedFieldIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新工单自定义字段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Helpdesk.Spec;

/// <summary>
/// 测试 更新工单自定义字段 请求体
/// <para>接口ID：6955768699895660546</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket_customized_field/update-ticket-customized-field</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket_customized_field%2fupdate-ticket-customized-field</para>
/// </summary>
[TestClass]
public class Test_PatchHelpdeskV1TicketCustomizedFieldsByTicketCustomizedFieldIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "display_name": "test dropdown",
    "position": "3",
    "description": "下拉示例",
    "visible": true,
    "required": false
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.Spec.PatchHelpdeskV1TicketCustomizedFieldsByTicketCustomizedFieldIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}