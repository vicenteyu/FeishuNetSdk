// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHelpdeskV1TicketCustomizedFieldsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取全部工单自定义字段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Helpdesk.Spec;

/// <summary>
/// 测试 获取全部工单自定义字段 请求体
/// <para>接口ID：6955768699895955458</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket_customized_field/list-ticket-customized-fields</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket_customized_field%2flist-ticket-customized-fields</para>
/// </summary>
[TestClass]
public class Test_GetHelpdeskV1TicketCustomizedFieldsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "visible": true
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.Spec.GetHelpdeskV1TicketCustomizedFieldsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}