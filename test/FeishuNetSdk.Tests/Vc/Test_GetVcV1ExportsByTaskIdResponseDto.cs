// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetVcV1ExportsByTaskIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询导出任务结果 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 查询导出任务结果 响应体
/// <para>接口ID：7124195547444527132</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/export/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fexport%2fget</para>
/// </summary>
[TestClass]
public class Test_GetVcV1ExportsByTaskIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "status": 3,
        "url": "https://lf1-ttcdn-tos.pstatp.com/obj/xxx",
        "file_token": "6yHu7Igp7Igy62Ez6fLr6IJz7j9i5WMe6fHq5yZeY2Jz6yLqYAMAY46fZfEz64Lr5fYyYQ==",
        "fail_msg": "no permission"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1ExportsByTaskIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}