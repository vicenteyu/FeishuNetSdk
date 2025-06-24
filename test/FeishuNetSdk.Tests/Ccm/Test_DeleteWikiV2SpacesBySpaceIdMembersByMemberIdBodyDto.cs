// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DeleteWikiV2SpacesBySpaceIdMembersByMemberIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除知识空间成员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 删除知识空间成员 请求体
/// <para>接口ID：7041549010980651010</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space-member/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-member%2fdelete</para>
/// </summary>
[TestClass]
public class Test_DeleteWikiV2SpacesBySpaceIdMembersByMemberIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "member_type": "userid",
    "member_role": "admin",
    "type": "user"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.DeleteWikiV2SpacesBySpaceIdMembersByMemberIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}