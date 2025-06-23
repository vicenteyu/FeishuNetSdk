namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 获取组织类角色授权列表 请求体
/// <para>接口ID：7141207412454998019</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/authorization/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fassigned_user%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1AssignedUsersSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "role_id": "100",
    "management_scope_list": [
        {
            "management_dimension": "department",
            "obj_id": "7023318326176777742"
        }
    ],
    "search_method": "1",
    "page_token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9",
    "page_size": "100"
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1AssignedUsersSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}