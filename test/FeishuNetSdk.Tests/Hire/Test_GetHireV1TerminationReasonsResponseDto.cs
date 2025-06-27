// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1TerminationReasonsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取终止投递原因 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取终止投递原因 响应体
/// <para>接口ID：7036934321795039234</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftermination_reason%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1TerminationReasonsResponseDto : TestBase
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
                "id": "10002",
                "name": {
                    "zh_cn": "测试",
                    "en_us": "test"
                },
                "referral_name": {
                    "zh_cn": "测试",
                    "en_us": "test"
                },
                "termination_type": 22,
                "is_used_as_evaluation": false,
                "active_status": 1
            }
        ],
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ=="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1TerminationReasonsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}