namespace FeishuNetSdk.Tests.Helpdesk.Spec;

/// <summary>
/// 测试 创建工单自定义字段 请求体
/// <para>接口ID：6955768699895562242</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket_customized_field/create-ticket-customized-field</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket_customized_field%2fcreate-ticket-customized-field</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1TicketCustomizedFieldsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "helpdesk_id": "1542164574896126",
    "key_name": "test dropdown",
    "display_name": "test dropdown",
    "position": "3",
    "field_type": "dropdown",
    "description": "下拉示例",
    "visible": true,
    "required": false,
    "dropdown_options":{
         "children":[
            {
               "tag":"a2ac322d-8d8c-432e-9631-17c4acaddbf7",
               "display_name":"a"
            },
            {
               "tag":"67068d18-20c9-412e-afc0-714d0e8fac29",
               "display_name":"b"
            },
            {
               "tag":"d135b9f3-f260-49e6-bb7b-32e334a99caf",
               "display_name":"c"
            }
         ]
      },
    "dropdown_allow_multiple": true
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.Spec.PostHelpdeskV1TicketCustomizedFieldsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}