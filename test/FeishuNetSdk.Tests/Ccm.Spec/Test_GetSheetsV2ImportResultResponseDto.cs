// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetSheetsV2ImportResultResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询导入结果 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 查询导入结果 响应体
/// <para>接口ID：6907568073252683778</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/sheets/sheet-operation/query-import-results</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuETO2YjLxkjN24SM5YjN</para>
/// </summary>
[TestClass]
public class Test_GetSheetsV2ImportResultResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "Success",
    "data": {
        "ticket": "6891610404246520328",
        "url": "https://example.feishu.cn/sheets/shtcnaryaxxxx",
        "warningCode": 32
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.GetSheetsV2ImportResultResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}