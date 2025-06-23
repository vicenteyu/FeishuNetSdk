namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 查询全部工单详情 响应体
/// <para>接口ID：6955768699896086530</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHelpdeskV1TicketsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "total": 100,
        "tickets": [
            {
                "ticket_id": "6626871355780366331",
                "helpdesk_id": "6626871355780366330",
                "guest": {
                    "id": "ou_37019b7c830210acd88fdce886e25c71",
                    "avatar_url": "https://xxxx",
                    "name": "abc",
                    "email": "xxxx@abc.com",
                    "department": "用户部门名称(有权限才展示)",
                    "city": "城市",
                    "country": "国家"
                },
                "comments": {
                    "content": "备注内容",
                    "created_at": 1690970837624,
                    "id": 12,
                    "user_avatar_url": "备注人头像",
                    "user_name": "备注人姓名",
                    "user_id": 7262656095919128578
                },
                "ticket_type": 1,
                "status": 50,
                "score": 1,
                "created_at": 1616920429000,
                "updated_at": 1616920429000,
                "closed_at": 1616920429000,
                "dissatisfaction_reason": {
                    "zh_cn": "答案看不懂",
                    "en_us": "I don't understand",
                    "ja_jp": "回答が複雑すぎる"
                },
                "agents": [
                    {
                        "id": "ou_37019b7c830210acd88fdce886e25c71",
                        "avatar_url": "https://xxxx",
                        "name": "abc",
                        "email": "xxxx@abc.com",
                        "department": "用户部门名称(有权限才展示)",
                        "city": "城市",
                        "country": "国家"
                    }
                ],
                "channel": 0,
                "solve": 1,
                "closed_by": {
                    "id": "ou_37019b7c830210acd88fdce886e25c71",
                    "avatar_url": "https://xxxx",
                    "name": "abc",
                    "email": "xxxx@abc.com",
                    "department": "用户部门名称(有权限才展示)",
                    "city": "城市",
                    "country": "国家"
                },
                "collaborators": [
                    {
                        "id": "ou_37019b7c830210acd88fdce886e25c71",
                        "avatar_url": "https://xxxx",
                        "name": "abc",
                        "email": "xxxx@abc.com",
                        "department": "用户部门名称(有权限才展示)",
                        "city": "城市",
                        "country": "国家"
                    }
                ],
                "customized_fields": [
                    {
                        "id": "123",
                        "value": "value",
                        "key_name": "key",
                        "display_name": "display name",
                        "position": 1,
                        "required": true,
                        "editable": true
                    }
                ],
                "agent_service_duration": 42624.95,
                "agent_first_response_duration": 123869,
                "bot_service_duration": 1,
                "agent_resolution_time": 66,
                "actual_processing_time": 68,
                "agent_entry_time": 1636444596000,
                "agent_first_response_time": 1636444696000,
                "agent_last_response_time": 1636444796000,
                "agent_owner": {
                    "id": "ou_37019b7c830210acd88fdce886e25c71",
                    "avatar_url": "https://xxxx",
                    "name": "abc",
                    "email": "xxxx@abc.com",
                    "department": "用户部门名称(有权限才展示)",
                    "city": "城市",
                    "country": "国家"
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.GetHelpdeskV1TicketsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}