// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2JobGradesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建职等 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 创建职等 响应体
/// <para>接口ID：7422326822924582914</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job_grade/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_grade%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2JobGradesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "grade_id": "12345678"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2JobGradesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}