// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="Test_PostCorehrV2SignatureFilesQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询电子签文件详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询电子签文件详情 响应体
/// <para>接口ID：7408897731056500740</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_file/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_file%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2SignatureFilesQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{"code":0,
"msg":"success",
"data":{"items":[{
    "signature_file_id": "7147527056140813828",
    "names": [
        {
            "lang": "zh-CN",
            "value": "中文示例"
        }
    ],
    "create_time": "2023-01-01 00:00:00",
    "update_time": "2023-01-01 00:00:00",
    "employment_id": "7123132668099919891",
    "pre_hire_id": "7123132668099919891",
    "signature_file_state": {
        "enum_name": "sign_finished",
        "display": [
            {
                "lang": "zh-CN",
                "value": "签署已完成"
            }
        ]
    },
    "contract_code": "48793beea04f4e2583d50732e481d507",
    "effective_date": "2024-12-01",
    "template_id": "7147527056140813828",
    "sign_url": "123213"
}],
"page_token":"7371387495822411308",
"has_more":true}}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2SignatureFilesQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}