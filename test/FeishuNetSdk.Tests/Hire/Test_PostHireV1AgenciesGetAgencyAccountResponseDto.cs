// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1AgenciesGetAgencyAccountResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询猎头供应商下猎头列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 查询猎头供应商下猎头列表 响应体
/// <para>接口ID：7413697955198058500</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/agency/get_agency_account</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2fget_agency_account</para>
/// </summary>
[TestClass]
public class Test_PostHireV1AgenciesGetAgencyAccountResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "SUCCESS",
    "data": {
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEsInRpbWVzdGFtcCI6MTY0MDc2NTYzMjA4OCwiaWQiOm51bGx9",
        "items": [
            {
                "id": "6995312261554538796",
                "reason": "这个猎头很不负责",
                "create_time": "1639992265035",
                "status": 1,
                "user_info": {
                    "user_id": "7398623155442682156",
                    "name": {
                        "zh_cn": "张三",
                        "en_us": "Zhangsan"
                    },
                    "email": "27188272xxxx1.com",
                    "mobile": "1879087xxx8"
                },
                "role": 1
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1AgenciesGetAgencyAccountResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}