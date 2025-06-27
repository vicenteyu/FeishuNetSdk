// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetVcV1ReserveConfigsByReserveConfigIdFormResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询会议室预定表单 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 查询会议室预定表单 响应体
/// <para>接口ID：7194790671877144578</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/scope_config/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve_config-form%2fget</para>
/// </summary>
[TestClass]
public class Test_GetVcV1ReserveConfigsByReserveConfigIdFormResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "reserve_form_config": {
            "reserve_form": true,
            "notified_users": [
                {
                    "user_id": "ou_a27b07a9071d90577c0177bcec98f856"
                }
            ],
            "notified_time": 3,
            "time_unit": 3
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1ReserveConfigsByReserveConfigIdFormResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}