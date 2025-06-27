// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchCorehrV2PreHiresByPreHireIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新待入职信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 更新待入职信息 响应体
/// <para>接口ID：7357756972752715778</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/pre_hire/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV2PreHiresByPreHireIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "pre_hire_id": "7345005664477775407"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PatchCorehrV2PreHiresByPreHireIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}