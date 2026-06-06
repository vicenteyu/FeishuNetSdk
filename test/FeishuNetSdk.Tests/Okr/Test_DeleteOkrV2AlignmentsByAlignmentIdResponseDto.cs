// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_DeleteOkrV2AlignmentsByAlignmentIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除 OKR 对齐 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 删除 OKR 对齐 响应体
/// <para>接口ID：7644764969658420172</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-alignment/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-alignment%2fdelete</para>
/// </summary>
[TestClass]
public class Test_DeleteOkrV2AlignmentsByAlignmentIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "alignment_id": "7342342398472398473"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.DeleteOkrV2AlignmentsByAlignmentIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}