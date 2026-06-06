// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_DeleteOkrV2KeyResultsByKeyResultIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除关键结果 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 删除关键结果 响应体
/// <para>接口ID：7644764969658551244</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-key_result/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-key_result%2fdelete</para>
/// </summary>
[TestClass]
public class Test_DeleteOkrV2KeyResultsByKeyResultIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "key_result_id": "7342342398472398473"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.DeleteOkrV2KeyResultsByKeyResultIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}