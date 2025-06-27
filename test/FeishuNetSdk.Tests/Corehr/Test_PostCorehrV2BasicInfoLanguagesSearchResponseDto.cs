// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2BasicInfoLanguagesSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询语言信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询语言信息 响应体
/// <para>接口ID：7424038983966425089</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/basic_info-language/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-language%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2BasicInfoLanguagesSearchResponseDto : TestBase
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
                "language_id": "6863323445740963342",
                "name": [
                    {
                        "lang": "zh-CN",
                        "value": "英文（英国）"
                    }
                ],
                "ietf_language_tag": "en-UK",
                "status": 1
            }
        ],
        "page_token": "6863323445740963342",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2BasicInfoLanguagesSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}