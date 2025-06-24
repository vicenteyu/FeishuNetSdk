// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2EnumsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询枚举信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询枚举信息 请求体
/// <para>接口ID：7457854043681603588</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/enum/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fenum%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2EnumsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "enum_apiname_lists": [
        "overtime_date_type"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2EnumsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}