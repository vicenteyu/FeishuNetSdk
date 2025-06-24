// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetWikiV2SpacesBySpaceIdMembersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取知识空间成员列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取知识空间成员列表 响应体
/// <para>接口ID：7386702252390449180</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/wiki-v2/space-member/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-member%2flist</para>
/// </summary>
[TestClass]
public class Test_GetWikiV2SpacesBySpaceIdMembersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "members": [
            {
                "member_type": "openid",
                "member_id": "ou_67e5ecb64ce1c0bd94612c17999db411",
                "member_role": "admin",
                "type": "user"
            }
        ],
        "page_token": "ou_12345",
        "has_more": false
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetWikiV2SpacesBySpaceIdMembersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}