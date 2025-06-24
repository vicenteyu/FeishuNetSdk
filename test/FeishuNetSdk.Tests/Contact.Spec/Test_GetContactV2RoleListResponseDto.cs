// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetContactV2RoleListResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取角色列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact.Spec;

/// <summary>
/// 测试 获取角色列表 响应体
/// <para>接口ID：6907569744330391553</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version//user/obtain-a-role-list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYzMwUjL2MDM14iNzATN</para>
/// </summary>
[TestClass]
public class Test_GetContactV2RoleListResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "role_list": [
            {
                "id": "or_846ea69995a259a27cc690182f27de87",
                "name": "IT"
            },
            {
                "id": "or_b337b102aff4167bd29189b1d94b77f6",
                "name": "HR"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.Spec.GetContactV2RoleListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}