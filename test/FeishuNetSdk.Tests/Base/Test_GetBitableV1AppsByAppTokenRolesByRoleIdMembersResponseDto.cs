namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 列出协作者 响应体
/// <para>接口ID：7101134500528668675</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/advanced-permission/app-role-member/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-role-member%2flist</para>
/// </summary>
[TestClass]
public class Test_GetBitableV1AppsByAppTokenRolesByRoleIdMembersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "msg": "success",
    "data": {
        "items": [
            {
                "member_type": "user",
                "member_name": "张敏",
                "member_en_name": "Min Zhang",
                "open_id": "ou_7dab8a3d3cdcc9da365777c7ad5abcef",
                "union_id": "on_7dab8a3d3cdcc9da365777c7ad5abcef",
                "user_id": "13e4beac"
            },
            {
                "member_type": "chat",
                "member_name": "design-chat",
                "member_en_name": "design-chat",
                "chat_id": "oc_a0553eda9014c201e6969b478895c230"
            },
            {
                "member_type": "department",
                "member_name": "design-center",
                "member_en_name": "design-center",
                "department_id": "h121921",
                "open_department_id": "od-4e6ac4d14bcd5071a37a39de902c7141"
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0",
        "total": 3,
        "has_more": true
    },
    "code": 0
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.GetBitableV1AppsByAppTokenRolesByRoleIdMembersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}