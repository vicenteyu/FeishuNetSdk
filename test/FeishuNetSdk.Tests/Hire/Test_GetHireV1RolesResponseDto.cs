namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取角色列表 响应体
/// <para>接口ID：7044465181343449090</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/auth/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2frole%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1RolesResponseDto : TestBase
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
                "id": "101",
                "name": {
                    "zh_cn": "测试",
                    "en_us": "test"
                },
                "description": {
                    "zh_cn": "测试",
                    "en_us": "test"
                },
                "scope_of_application": 1,
                "modify_time": "1716535727510",
                "role_status": 1,
                "role_type": 1
            }
        ],
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ=="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1RolesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}