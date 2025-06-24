// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV1AuthorizationsUpdateRoleAssignResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新用户被授权的数据范围 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 更新用户被授权的数据范围 响应体
/// <para>接口ID：7361618338575810588</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/authorization/update_role_assign</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fauthorization%2fupdate_role_assign</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1AuthorizationsUpdateRoleAssignResponseDto : TestBase
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PostCorehrV1AuthorizationsUpdateRoleAssignResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}