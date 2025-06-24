// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV1AuthorizationsRemoveRoleAssignResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 移除用户被授权的角色 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 移除用户被授权的角色 响应体
/// <para>接口ID：7361618338575777820</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/authorization/remove_role_assign</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fauthorization%2fremove_role_assign</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1AuthorizationsRemoveRoleAssignResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "assign_id": "67489937334909845"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PostCorehrV1AuthorizationsRemoveRoleAssignResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}