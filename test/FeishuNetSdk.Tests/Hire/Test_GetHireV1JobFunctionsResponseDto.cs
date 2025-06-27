// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1JobFunctionsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取职能分类列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取职能分类列表 响应体
/// <para>接口ID：7021031370929012739</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/list-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_function%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1JobFunctionsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ==",
        "items": [
            {
                "id": "7010952553315895596",
                "name": {
                    "zh_cn": "测试",
                    "en_us": "test"
                },
                "active_status": 1,
                "parent_id": "0"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1JobFunctionsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}