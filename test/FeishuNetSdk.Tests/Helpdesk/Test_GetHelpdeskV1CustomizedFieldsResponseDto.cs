namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 获取服务台自定义字段 响应体
/// <para>接口ID：6955768425688383491</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket/customized_fields</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket%2fcustomized_fields</para>
/// </summary>
[TestClass]
public class Test_GetHelpdeskV1CustomizedFieldsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "user_customized_fields": [
            {
                "user_customized_field_id": "6746384425543548981",
                "id": "6746384425543548981",
                "helpdesk_id": "1542164574896126",
                "key_name": "company_id3",
                "display_name": "Company ID",
                "position": "1",
                "field_type": "string",
                "description": "租户ID",
                "visible": false,
                "editable": false,
                "required": false,
                "created_at": "1574040677000",
                "updated_at": "1574040677000"
            }
        ],
        "ticket_customized_fields": [
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
                    "email": "xxxx@abc.com",
                    "department": "用户部门名称(有权限才展示)",
                    "city": "城市",
                    "country": "国家"
                },
                "updated_by": {
                    "id": "ou_37019b7c830210acd88fdce886e25c71",
                    "avatar_url": "https://xxxx",
                    "name": "abc",
                    "email": "xxxx@abc.com",
                    "department": "用户部门名称(有权限才展示)",
                    "city": "城市",
                    "country": "国家"
                },
                "dropdown_allow_multiple": true
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.GetHelpdeskV1CustomizedFieldsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}