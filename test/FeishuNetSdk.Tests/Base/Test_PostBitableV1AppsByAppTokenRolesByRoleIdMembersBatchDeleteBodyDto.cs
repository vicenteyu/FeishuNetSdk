// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostBitableV1AppsByAppTokenRolesByRoleIdMembersBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量删除协作者 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 批量删除协作者 请求体
/// <para>接口ID：7111246853309071363</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/advanced-permission/app-role-member/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-role-member%2fbatch_delete</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenRolesByRoleIdMembersBatchDeleteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "member_list": [
        {
            "type": "open_id",
            "id": "ou_35990a9d9052051a2fae9b2f1afabcef"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenRolesByRoleIdMembersBatchDeleteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}