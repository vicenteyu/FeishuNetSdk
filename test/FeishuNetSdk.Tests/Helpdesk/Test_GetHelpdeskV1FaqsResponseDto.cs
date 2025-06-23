namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 获取全部知识库详情 响应体
/// <para>接口ID：6955768699895693314</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/faq-management/faq/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2ffaq%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHelpdeskV1FaqsResponseDto : TestBase
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
        "page_token": "6856395634652479491",
        "page_size": 100,
        "total": 200,
        "items": [
            {
                "faq_id": "6936004780707807231",
                "id": "6936004780707807231",
                "helpdesk_id": "6936004780707807251",
                "question": "问题",
                "answer": "答案",
                "answer_richtext": [
                    {
                        "content": "我的答案",
                        "type": "text"
                    }
                ],
                "create_time": 1596379008,
                "update_time": 1596379008,
                "categories": [
                    {
                        "category_id": "6948728206392295444",
                        "id": "6948728206392295444",
                        "name": "创建团队和邀请成员",
                        "parent_id": "0",
                        "helpdesk_id": "6939771743531696147",
                        "language": "zh_cn"
                    }
                ],
                "tags": [
                    "问题"
                ],
                "expire_time": 1596379008,
                "update_user": {
                    "id": "ou_37019b7c830210acd88fdce886e25c71",
                    "avatar_url": "https://xxxx",
                    "name": "abc",
                    "department": "用户部门名称(有权限才展示)",
                    "city": "城市",
                    "country": "国家"
                },
                "create_user": {
                    "id": "ou_37019b7c830210acd88fdce886e25c71",
                    "avatar_url": "https://xxxx",
                    "name": "abc",
                    "department": "用户部门名称(有权限才展示)",
                    "city": "城市",
                    "country": "国家"
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.GetHelpdeskV1FaqsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}