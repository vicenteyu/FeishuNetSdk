// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2PreHiresQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询待入职信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询待入职信息 请求体
/// <para>接口ID：7386487948991299587</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/pre_hire/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PreHiresQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "pre_hire_ids": [
        "7094136522860922112"
    ],
    "fields": [
        "employment_info.department"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2PreHiresQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}