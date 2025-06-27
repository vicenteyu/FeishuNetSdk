// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1ExternalBackgroundChecksBatchQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询外部背调列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 查询外部背调列表 响应体
/// <para>接口ID：7407298680641028099</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-background-info/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_background_check%2fbatch_query</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ExternalBackgroundChecksBatchQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "items": [
            {
                "id": "6989202908470446380",
                "external_application_id": "7003247299220982060",
                "date": 1626602069393,
                "name": "张三的背调",
                "result": "已通过",
                "attachment_list": [
                    {
                        "id": "6987954043925432620",
                        "name": "test_resume.pdf",
                        "size": 1928
                    }
                ]
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1ExternalBackgroundChecksBatchQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}