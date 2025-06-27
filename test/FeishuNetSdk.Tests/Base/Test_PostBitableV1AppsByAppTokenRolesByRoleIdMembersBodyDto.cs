// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostBitableV1AppsByAppTokenRolesByRoleIdMembersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新增协作者 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 新增协作者 请求体
/// <para>接口ID：7101134500528619523</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/advanced-permission/app-role-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-role-member%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenRolesByRoleIdMembersBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "member_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62"
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenRolesByRoleIdMembersBodyDto>(json);
        Assert.IsNotNull(result);
    }
}