// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1ResumeSourcesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取简历来源列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取简历来源列表 响应体
/// <para>接口ID：6964264269274578946</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/resume_source/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fresume_source%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1ResumeSourcesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "id": "10000",
                "zh_name": "内推",
                "en_name": "referral",
                "active_status": 1,
                "resume_source_type": "10001"
            }
        ],
        "page_token": "1",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1ResumeSourcesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}