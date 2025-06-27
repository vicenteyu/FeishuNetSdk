// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCardkitV1CardsIdConvertResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 转换 ID 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Cardkit;

/// <summary>
/// 测试 转换 ID 响应体
/// <para>接口ID：7397265677100957699</para>
/// <para>文档地址：https://open.feishu.cn/document/historic-version/id_convert</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard%2fid_convert</para>
/// </summary>
[TestClass]
public class Test_PostCardkitV1CardsIdConvertResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "card_id": "7355403067414003715"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Cardkit.PostCardkitV1CardsIdConvertResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}