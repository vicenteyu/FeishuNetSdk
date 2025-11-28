// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="Test_GetCorehrV2SignatureFilesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取电子签文件列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 获取电子签文件列表 响应体
/// <para>接口ID：7376163028442808348</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_file/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_file%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2SignatureFilesResponseDto : TestBase
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
            "value": "张三"
        }
    ],
    "create_time": "2023-01-01 00:00:00",
    "update_time": "2023-01-01 00:00:00",
    "employment_id": "ou_a294793e8fa21529f2a60e3e9de45520",
    "signature_file_state": {
        "enum_name": "phone_type",
        "display": [
            {
                "lang": "zh-CN",
                "value": "张三"
            }
        ]
    },
    "contract_code": "48793beea04f4e2583d50732e481d507",
    "effective_date": "2024-12-01",
    "template_id": "7147527056140813828"
}],
"page_token":"7371387495822411308",
"has_more":true}}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2SignatureFilesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}