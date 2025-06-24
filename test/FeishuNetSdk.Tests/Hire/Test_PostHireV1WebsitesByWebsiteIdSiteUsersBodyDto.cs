// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1WebsitesByWebsiteIdSiteUsersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新建招聘官网用户 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 新建招聘官网用户 请求体
/// <para>接口ID：6990661791098634243</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-site_user%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1WebsitesByWebsiteIdSiteUsersBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "张敏",
    "email": "zhangmin@163.com",
    "external_id": "6960663240925956621",
    "mobile": "182900291190",
    "mobile_country_code": "CN_1"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1WebsitesByWebsiteIdSiteUsersBodyDto>(json);
        Assert.IsNotNull(result);
    }
}