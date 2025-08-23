// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_PostCompensationV1SocialArchiveQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量获取员工参保档案 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 批量获取员工参保档案 请求体
/// <para>接口ID：7420038908975398914</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/social_archive/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fsocial_archive%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1SocialArchiveQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id_list": [
        "7023711013443944467"
    ],
    "effective_date": "2024-01-01"
}
""";
        var result = Deserialize<FeishuNetSdk.CompensationManagement.PostCompensationV1SocialArchiveQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}