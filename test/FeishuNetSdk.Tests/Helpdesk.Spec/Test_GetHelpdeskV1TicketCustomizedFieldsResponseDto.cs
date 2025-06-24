// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHelpdeskV1TicketCustomizedFieldsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取全部工单自定义字段 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Helpdesk.Spec;

/// <summary>
/// 测试 获取全部工单自定义字段 响应体
/// <para>接口ID：6955768699895955458</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket_customized_field/list-ticket-customized-fields</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket_customized_field%2flist-ticket-customized-fields</para>
/// </summary>
[TestClass]
public class Test_GetHelpdeskV1TicketCustomizedFieldsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": true,
        "next_page_token": "6948728206392295444",
        "items": [
            {
                "ticket_customized_field_id": "6834320707288072194",
                "helpdesk_id": "1542164574896126",
                "key_name": "test dropdown",
                "display_name": "test dropdown",
                "position": "3",
                "field_type": "dropdown",
                "description": "下拉示例",
                "visible": true,
                "editable": true,
                "required": false,
                "created_at": "1591239289000",
                "updated_at": "1591239289000",
                "created_by": {
                    "id": "ou_37019b7c830210acd88fdce886e25c71",
                    "avatar_url": "https://xxxx",
                    "name": "abc",
                    "email": "xxxx@abc.com"
                },
                "updated_by": {
                    "id": "ou_37019b7c830210acd88fdce886e25c71",
                    "avatar_url": "https://xxxx",
                    "name": "abc",
                    "email": "xxxx@abc.com"
                },
                "dropdown_options": {
                    "children": [
                        {
                            "tag": "c495fe14-aac0-4fd6-8851-9fde726e2a40",
                            "display_name": "l1",
                            "children": [
                                {
                                    "tag": "498ed5f1-f2b1-4585-b21f-3d4d2cd0cd26",
                                    "display_name": "l2"
                                },
                                {
                                    "tag": "51285604-367f-454f-adca-b4760c38850d",
                                    "display_name": "l22"
                                }
                            ]
                        },
                        {
                            "tag": "295cf315-df56-445b-b430-b58925ef331c",
                            "display_name": "l11"
                        }
                    ]
                },
                "dropdown_allow_multiple": true
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.Spec.GetHelpdeskV1TicketCustomizedFieldsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}