namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 搜索对用户或机器人可见的群列表 响应体
/// <para>接口ID：6946222929790648348</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2fsearch</para>
/// </summary>
[TestClass]
public class Test_GetImV1ChatsSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "chat_id": "oc_a0553eda9014c201e6969b478895c230",
                "avatar": "https://p3-lark-file.byteimg.com/img/lark-avatar-staging/default-avatar_44ae0ca3-e140-494b-956f-78091e348435~100x100.jpg",
                "name": "测试群名称",
                "description": "测试群描述",
                "owner_id": "4d7a3c6g",
                "owner_id_type": "user_id",
                "external": false,
                "tenant_key": "736588c9260f175e",
                "chat_status": "normal"
            }
        ],
        "page_token": "dmJCRHhpd3JRbGV1VEVNRFFyTitRWDY5ZFkybmYrMEUwMUFYT0VMMWdENEtuYUhsNUxGMDIwemtvdE5ORjBNQQ==",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.GetImV1ChatsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}