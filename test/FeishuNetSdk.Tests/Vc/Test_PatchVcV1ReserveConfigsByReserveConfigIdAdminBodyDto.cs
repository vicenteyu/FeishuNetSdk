// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchVcV1ReserveConfigsByReserveConfigIdAdminBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新会议室预定管理员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 更新会议室预定管理员 请求体
/// <para>接口ID：7194805625628000259</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/scope_config/patch-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve_config-admin%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchVcV1ReserveConfigsByReserveConfigIdAdminBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "scope_type": 2,
    "reserve_admin_config": {
        "depts": [
            {
                "department_id": "od-47d8b570b0a011e9679a755efcc5f61a"
            }
        ],
        "users": [
            {
                "user_id": "ou_a27b07a9071d90577c0177bcec98f856"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PatchVcV1ReserveConfigsByReserveConfigIdAdminBodyDto>(json);
        Assert.IsNotNull(result);
    }
}