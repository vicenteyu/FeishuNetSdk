// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="Test_PostApplicationV7ApplicationsByAppIdPublishResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 提交发布自建应用 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 提交发布自建应用 响应体
/// <para>接口ID：7621030901518552023</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v7/application-v7/application-publish/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v7%2fapplication-v7%2fapplication-publish%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostApplicationV7ApplicationsByAppIdPublishResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "version_id": "oav_d317f090b7258ad0372aa53963cda70d",
        "version": "1.1.1"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Application.PostApplicationV7ApplicationsByAppIdPublishResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}