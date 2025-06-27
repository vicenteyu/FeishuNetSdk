// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetVcV1ReportsGetTopUserResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取 Top 用户列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 获取 Top 用户列表 响应体
/// <para>接口ID：6921909217674723355</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/report/get_top_user</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freport%2fget_top_user</para>
/// </summary>
[TestClass]
public class Test_GetVcV1ReportsGetTopUserResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "top_user_report": [
            {
                "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
                "name": "name",
                "user_type": 1,
                "meeting_count": "100",
                "meeting_duration": "3000"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1ReportsGetTopUserResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}