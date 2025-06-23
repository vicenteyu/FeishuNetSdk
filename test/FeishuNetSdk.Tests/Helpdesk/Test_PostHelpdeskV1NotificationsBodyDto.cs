namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 创建推送 请求体
/// <para>接口ID：6999529163292639234</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/notification/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fnotification%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1NotificationsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "id": "6981801914270744596",
    "job_name": "测试推送任务",
    "status": 0,
    "create_user": {
        "user_id": "ou_7277fd1262bfafc363d5b2a1f9c2ac90",
        "avatar_url": "http://*.com/*.png",
        "name": "test"
    },
    "created_at": "1626332244719",
    "update_user": {
        "user_id": "ou_7277fd1262bfafc363d5b2a1f9c2ac90",
        "avatar_url": "http://*.com/*.png",
        "name": "test"
    },
    "updated_at": "1626332244719",
    "target_user_count": 1,
    "sent_user_count": 1,
    "read_user_count": 1,
    "send_at": "1626332244719",
    "push_content": "{   \"config\": {     \"wide_screen_mode\": true   },   \"elements\": [     {       \"tag\": \"div\",       \"text\": {         \"tag\": \"lark_md\",         \"content\": \"[飞书](https://www.feishu.cn)整合即时沟通、日历、音视频会议、云文档、云盘、工作台等功能于一体，成就组织和个人，更高效、更愉悦。\"       }     }   ] }",
    "push_type": 0,
    "push_scope_type": 0,
    "new_staff_scope_type": 0,
    "new_staff_scope_department_list": [
        {
            "department_id": "od_7277fd1262bfafc363d5b2a1f9c2ac90",
            "name": "测试部门"
        }
    ],
    "user_list": [
        {
            "user_id": "ou_7277fd1262bfafc363d5b2a1f9c2ac90",
            "avatar_url": "http://*.com/*.png",
            "name": "test"
        }
    ],
    "department_list": [
        {
            "department_id": "od_7277fd1262bfafc363d5b2a1f9c2ac90",
            "name": "测试部门"
        }
    ],
    "chat_list": [
        {
            "chat_id": "oc_7277fd1262bfafc363d5b2a1f9c2ac90",
            "name": "测试群聊"
        }
    ],
    "ext": "{}"
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.PostHelpdeskV1NotificationsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}