// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostWikiV2SpacesBySpaceIdMembersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 添加知识空间成员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 添加知识空间成员 请求体
/// <para>接口ID：7023947709203906564</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-member%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostWikiV2SpacesBySpaceIdMembersBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "member_type": "openid",
    "member_id": "ou_449b53ad6aee526f7ed311b216aabcef",
    "member_role": "admin"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostWikiV2SpacesBySpaceIdMembersBodyDto>(json);
        Assert.IsNotNull(result);
    }
}