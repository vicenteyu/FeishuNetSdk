namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 创建知识库分类 响应体
/// <para>接口ID：6955768699895775234</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/faq-management/category/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fcategory%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1CategoriesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "category": {
            "category_id": "6948728206392295444",
            "id": "6948728206392295444",
            "name": "创建团队和邀请成员",
            "parent_id": "0",
            "helpdesk_id": "6939771743531696147",
            "language": "zh_cn"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.PostHelpdeskV1CategoriesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}