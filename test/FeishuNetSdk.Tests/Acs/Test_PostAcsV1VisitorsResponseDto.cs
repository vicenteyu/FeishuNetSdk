// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAcsV1VisitorsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 添加访客 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Acs;

/// <summary>
/// 测试 添加访客 响应体
/// <para>接口ID：7321978105899057180</para>
/// <para>文档地址：https://open.feishu.cn/document/acs-v1/visitor/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2fvisitor%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAcsV1VisitorsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "visitor_id": "6939433228970082568"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Acs.PostAcsV1VisitorsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}