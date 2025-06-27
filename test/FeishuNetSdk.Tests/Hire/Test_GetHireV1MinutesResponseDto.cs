// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1MinutesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取面试速记明细 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取面试速记明细 响应体
/// <para>接口ID：7397616200375304220</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/delivery-process-management/interview/get-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fminutes%2fget</para>
/// </summary>
[TestClass]
public class Test_GetHireV1MinutesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "minutes": {
            "sentences": [
                {
                    "content": "你好，可以做一下自我介绍么？",
                    "speak_time": "1720967514994",
                    "user_type": 1,
                    "speaker_name": {
                        "zh_cn": "张三",
                        "en_us": "Zhang San"
                    }
                }
            ]
        },
        "page_token": "NzM5MTgyNjQyNDY2MDc4OTU0OA==",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1MinutesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}